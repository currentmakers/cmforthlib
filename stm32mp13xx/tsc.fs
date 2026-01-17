\
\ @file tsc.fs
\ @brief TSC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TSC_DEF

  [ifdef] TSC_TSC_CR_DEF
    \
    \ @brief Touch sensing controller enable This bit is set and cleared by software to enable/disable the touch sensing controller. Note: When the touch sensing controller is disabled, TSC registers settings have no effect.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TSC_TSCE                       \ [0x00] Touch sensing controller enable This bit is set and cleared by software to enable/disable the touch sensing controller. Note: When the touch sensing controller is disabled, TSC registers settings have no effect.
    $01 constant TSC_START                      \ [0x01] Start a new acquisition This bit is set by software to start a new acquisition. It is cleared by hardware as soon as the acquisition is complete or by software to cancel the ongoing acquisition.
    $02 constant TSC_AM                         \ [0x02] Acquisition mode This bit is set and cleared by software to select the acquisition mode. Note: This bit must not be modified when an acquisition is ongoing.
    $03 constant TSC_SYNCPOL                    \ [0x03] Synchronization pin polarity This bit is set and cleared by software to select the polarity of the synchronization input pin.
    $04 constant TSC_IODEF                      \ [0x04] I/O Default mode This bit is set and cleared by software. It defines the configuration of all the TSC I/Os when there is no ongoing acquisition. When there is an ongoing acquisition, it defines the configuration of all unused I/Os (not defined as sampling capacitor I/O or as channel I/O). Note: This bit must not be modified when an acquisition is ongoing.
    $05 constant TSC_MCV                        \ [0x05 : 3] Max count value These bits are set and cleared by software. They define the maximum number of charge transfer pulses that can be generated before a max count error is generated. Note: These bits must not be modified when an acquisition is ongoing.
    $0c constant TSC_PGPSC                      \ [0x0c : 3] Pulse generator prescaler These bits are set and cleared by software.They select the AHB clock divider used to generate the pulse generator clock (PGCLK). Note: These bits must not be modified when an acquisition is ongoing. Note: Some configurations are forbidden. Refer to the acquisition sequence for details.
    $0f constant TSC_SSPSC                      \ [0x0f] Spread spectrum prescaler This bit is set and cleared by software. It selects the AHB clock divider used to generate the spread spectrum clock (SSCLK). Note: This bit must not be modified when an acquisition is ongoing.
    $10 constant TSC_SSE                        \ [0x10] Spread spectrum enable This bit is set and cleared by software to enable/disable the spread spectrum feature. Note: This bit must not be modified when an acquisition is ongoing.
    $11 constant TSC_SSD                        \ [0x11 : 7] Spread spectrum deviation These bits are set and cleared by software. They define the spread spectrum deviation which consists in adding a variable number of periods of the SSCLK clock to the charge transfer pulse high state. ... Note: These bits must not be modified when an acquisition is ongoing.
    $18 constant TSC_CTPL                       \ [0x18 : 4] Charge transfer pulse low These bits are set and cleared by software. They define the duration of the low state of the charge transfer pulse (transfer of charge from CX to CS). ... Note: These bits must not be modified when an acquisition is ongoing. Note: Some configurations are forbidden. Refer to the acquisition sequence for details.
    $1c constant TSC_CTPH                       \ [0x1c : 4] Charge transfer pulse high These bits are set and cleared by software. They define the duration of the high state of the charge transfer pulse (charge of CX). ... Note: These bits must not be modified when an acquisition is ongoing.
  [then]


  [ifdef] TSC_TSC_IER_DEF
    \
    \ @brief End of acquisition interrupt enable This bit is set and cleared by software to enable/disable the end of acquisition interrupt.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TSC_EOAIE                      \ [0x00] End of acquisition interrupt enable This bit is set and cleared by software to enable/disable the end of acquisition interrupt.
    $01 constant TSC_MCEIE                      \ [0x01] Max count error interrupt enable This bit is set and cleared by software to enable/disable the max count error interrupt.
  [then]


  [ifdef] TSC_TSC_ICR_DEF
    \
    \ @brief End of acquisition interrupt clear This bit is set by software to clear the end of acquisition flag and it is cleared by hardware when the flag is reset. Writing a '0â has no effect.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TSC_EOAIC                      \ [0x00] End of acquisition interrupt clear This bit is set by software to clear the end of acquisition flag and it is cleared by hardware when the flag is reset. Writing a '0â has no effect.
    $01 constant TSC_MCEIC                      \ [0x01] Max count error interrupt clear This bit is set by software to clear the max count error flag and it is cleared by hardware when the flag is reset. Writing a '0â has no effect.
  [then]


  [ifdef] TSC_TSC_ISR_DEF
    \
    \ @brief End of acquisition flag This bit is set by hardware when the acquisition of all enabled group is complete (all GxS bits of all enabled analog I/O groups are set or when a max count error is detected). It is cleared by software writing 1 to the bit EOAIC of the TSC_ICR register.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TSC_EOAF                       \ [0x00] End of acquisition flag This bit is set by hardware when the acquisition of all enabled group is complete (all GxS bits of all enabled analog I/O groups are set or when a max count error is detected). It is cleared by software writing 1 to the bit EOAIC of the TSC_ICR register.
    $01 constant TSC_MCEF                       \ [0x01] Max count error flag This bit is set by hardware as soon as an analog I/O group counter reaches the max count value specified. It is cleared by software writing 1 to the bit MCEIC of the TSC_ICR register.
  [then]


  [ifdef] TSC_TSC_IOHCR_DEF
    \
    \ Address offset: 0x10
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TSC_G1_IO1                     \ [0x00] G1_IO1
    $01 constant TSC_G1_IO2                     \ [0x01] G1_IO2
    $02 constant TSC_G1_IO3                     \ [0x02] G1_IO3
    $03 constant TSC_G1_IO4                     \ [0x03] G1_IO4
    $04 constant TSC_G2_IO1                     \ [0x04] G2_IO1
    $05 constant TSC_G2_IO2                     \ [0x05] G2_IO2
    $06 constant TSC_G2_IO3                     \ [0x06] G2_IO3
    $07 constant TSC_G2_IO4                     \ [0x07] G2_IO4
    $08 constant TSC_G3_IO1                     \ [0x08] G3_IO1
    $09 constant TSC_G3_IO2                     \ [0x09] G3_IO2
    $0a constant TSC_G3_IO3                     \ [0x0a] G3_IO3
    $0b constant TSC_G3_IO4                     \ [0x0b] G3_IO4
    $0c constant TSC_G4_IO1                     \ [0x0c] G4_IO1
    $0d constant TSC_G4_IO2                     \ [0x0d] G4_IO2
    $0e constant TSC_G4_IO3                     \ [0x0e] G4_IO3
    $0f constant TSC_G4_IO4                     \ [0x0f] G4_IO4
    $10 constant TSC_G5_IO1                     \ [0x10] G5_IO1
    $11 constant TSC_G5_IO2                     \ [0x11] G5_IO2
    $12 constant TSC_G5_IO3                     \ [0x12] G5_IO3
    $13 constant TSC_G5_IO4                     \ [0x13] G5_IO4
  [then]


  [ifdef] TSC_TSC_IOASCR_DEF
    \
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TSC_G1_IO1                     \ [0x00] G1_IO1
    $01 constant TSC_G1_IO2                     \ [0x01] G1_IO2
    $02 constant TSC_G1_IO3                     \ [0x02] G1_IO3
    $03 constant TSC_G1_IO4                     \ [0x03] G1_IO4
    $04 constant TSC_G2_IO1                     \ [0x04] G2_IO1
    $05 constant TSC_G2_IO2                     \ [0x05] G2_IO2
    $06 constant TSC_G2_IO3                     \ [0x06] G2_IO3
    $07 constant TSC_G2_IO4                     \ [0x07] G2_IO4
    $08 constant TSC_G3_IO1                     \ [0x08] G3_IO1
    $09 constant TSC_G3_IO2                     \ [0x09] G3_IO2
    $0a constant TSC_G3_IO3                     \ [0x0a] G3_IO3
    $0b constant TSC_G3_IO4                     \ [0x0b] G3_IO4
    $0c constant TSC_G4_IO1                     \ [0x0c] G4_IO1
    $0d constant TSC_G4_IO2                     \ [0x0d] G4_IO2
    $0e constant TSC_G4_IO3                     \ [0x0e] G4_IO3
    $0f constant TSC_G4_IO4                     \ [0x0f] G4_IO4
    $10 constant TSC_G5_IO1                     \ [0x10] G5_IO1
    $11 constant TSC_G5_IO2                     \ [0x11] G5_IO2
    $12 constant TSC_G5_IO3                     \ [0x12] G5_IO3
    $13 constant TSC_G5_IO4                     \ [0x13] G5_IO4
  [then]


  [ifdef] TSC_TSC_IOCCR_DEF
    \
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TSC_G1_IO1                     \ [0x00] G1_IO1
    $01 constant TSC_G1_IO2                     \ [0x01] G1_IO2
    $02 constant TSC_G1_IO3                     \ [0x02] G1_IO3
    $03 constant TSC_G1_IO4                     \ [0x03] G1_IO4
    $04 constant TSC_G2_IO1                     \ [0x04] G2_IO1
    $05 constant TSC_G2_IO2                     \ [0x05] G2_IO2
    $06 constant TSC_G2_IO3                     \ [0x06] G2_IO3
    $07 constant TSC_G2_IO4                     \ [0x07] G2_IO4
    $08 constant TSC_G3_IO1                     \ [0x08] G3_IO1
    $09 constant TSC_G3_IO2                     \ [0x09] G3_IO2
    $0a constant TSC_G3_IO3                     \ [0x0a] G3_IO3
    $0b constant TSC_G3_IO4                     \ [0x0b] G3_IO4
    $0c constant TSC_G4_IO1                     \ [0x0c] G4_IO1
    $0d constant TSC_G4_IO2                     \ [0x0d] G4_IO2
    $0e constant TSC_G4_IO3                     \ [0x0e] G4_IO3
    $0f constant TSC_G4_IO4                     \ [0x0f] G4_IO4
    $10 constant TSC_G5_IO1                     \ [0x10] G5_IO1
    $11 constant TSC_G5_IO2                     \ [0x11] G5_IO2
    $12 constant TSC_G5_IO3                     \ [0x12] G5_IO3
    $13 constant TSC_G5_IO4                     \ [0x13] G5_IO4
  [then]


  [ifdef] TSC_TSC_IOGCSR_DEF
    \
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TSC_G1E                        \ [0x00] G1E
    $01 constant TSC_G2E                        \ [0x01] G2E
    $02 constant TSC_G3E                        \ [0x02] G3E
    $03 constant TSC_G4E                        \ [0x03] G4E
    $04 constant TSC_G5E                        \ [0x04] G5E
    $10 constant TSC_G1S                        \ [0x10] G1S
    $11 constant TSC_G2S                        \ [0x11] G2S
    $12 constant TSC_G3S                        \ [0x12] G3S
    $13 constant TSC_G4S                        \ [0x13] G4S
    $14 constant TSC_G5S                        \ [0x14] G5S
  [then]


  [ifdef] TSC_TSC_IOG1CR_DEF
    \
    \ @brief Counter value
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value
  [then]


  [ifdef] TSC_TSC_IOG2CR_DEF
    \
    \ @brief Counter value
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value
  [then]


  [ifdef] TSC_TSC_IOG3CR_DEF
    \
    \ @brief Counter value
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value
  [then]


  [ifdef] TSC_TSC_IOG4CR_DEF
    \
    \ @brief Counter value
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value
  [then]


  [ifdef] TSC_TSC_HWCFGR_DEF
    \
    \ @brief TSC hardware configuration 1 These bits return the TSP CFG1[3:0] configuration. CFG1[3:0] = group_size = 0x5 (group size).
    \ Address offset: 0x3F0
    \ Reset value: 0x00000025
    \
    $00 constant TSC_CFG1                       \ [0x00 : 4] TSC hardware configuration 1 These bits return the TSP CFG1[3:0] configuration. CFG1[3:0] = group_size = 0x5 (group size).
    $04 constant TSC_CFG2                       \ [0x04 : 4] TSC hardware configuration 2 These bits return the TSP CFG2[3:0] configuration. CFG2[3:0] = dt_duration = 0x2 (dead time duration).
  [then]


  [ifdef] TSC_TSC_VERR_DEF
    \
    \ @brief Minor revision These bits return the TSC minor revision. MINREV[3:0] = 0x2
    \ Address offset: 0x3F4
    \ Reset value: 0x00000012
    \
    $00 constant TSC_MINREV                     \ [0x00 : 4] Minor revision These bits return the TSC minor revision. MINREV[3:0] = 0x2
    $04 constant TSC_MAJREV                     \ [0x04 : 4] Major revision These bits return the TSC major revision. MAJREV[3:0] = 0x1
  [then]


  [ifdef] TSC_TSC_IDR_DEF
    \
    \ @brief TSC identifier These bits return the TSC identifier. ID[31:0] = 0x00110041
    \ Address offset: 0x3F8
    \ Reset value: 0x00110041
    \
    $00 constant TSC_ID                         \ [0x00 : 32] TSC identifier These bits return the TSC identifier. ID[31:0] = 0x00110041
  [then]


  [ifdef] TSC_TSC_SIDR_DEF
    \
    \ @brief TSC size identification These bits return the size of the memory region allocated to the TSC registers. SID[31:0] = 0xA3C5DD01
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant TSC_SID                        \ [0x00 : 32] TSC size identification These bits return the size of the memory region allocated to the TSC registers. SID[31:0] = 0xA3C5DD01
  [then]

  \
  \ @brief TSC
  \
  $00 constant TSC_TSC_CR               \ Touch sensing controller enable This bit is set and cleared by software to enable/disable the touch sensing controller. Note: When the touch sensing controller is disabled, TSC registers settings have no effect.
  $04 constant TSC_TSC_IER              \ End of acquisition interrupt enable This bit is set and cleared by software to enable/disable the end of acquisition interrupt.
  $08 constant TSC_TSC_ICR              \ End of acquisition interrupt clear This bit is set by software to clear the end of acquisition flag and it is cleared by hardware when the flag is reset. Writing a '0â has no effect.
  $0C constant TSC_TSC_ISR              \ End of acquisition flag This bit is set by hardware when the acquisition of all enabled group is complete (all GxS bits of all enabled analog I/O groups are set or when a max count error is detected). It is cleared by software writing 1 to the bit EOAIC of the TSC_ICR register.
  $10 constant TSC_TSC_IOHCR            
  $18 constant TSC_TSC_IOASCR           
  $28 constant TSC_TSC_IOCCR            
  $30 constant TSC_TSC_IOGCSR           
  $34 constant TSC_TSC_IOG1CR           \ Counter value
  $38 constant TSC_TSC_IOG2CR           \ Counter value
  $3C constant TSC_TSC_IOG3CR           \ Counter value
  $40 constant TSC_TSC_IOG4CR           \ Counter value
  $3F0 constant TSC_TSC_HWCFGR          \ TSC hardware configuration 1 These bits return the TSP CFG1[3:0] configuration. CFG1[3:0] = group_size = 0x5 (group size).
  $3F4 constant TSC_TSC_VERR            \ Minor revision These bits return the TSC minor revision. MINREV[3:0] = 0x2
  $3F8 constant TSC_TSC_IDR             \ TSC identifier These bits return the TSC identifier. ID[31:0] = 0x00110041
  $3FC constant TSC_TSC_SIDR            \ TSC size identification These bits return the size of the memory region allocated to the TSC registers. SID[31:0] = 0xA3C5DD01

: TSC_DEF ; [then]
