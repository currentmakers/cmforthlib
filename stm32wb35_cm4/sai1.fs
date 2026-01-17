\
\ @file sai1.fs
\ @brief Serial audio interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SAI1_DEF

  [ifdef] SAI1_ACR1_DEF
    \
    \ @brief AConfiguration register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000040
    \
    $00 constant SAI1_MODE                      \ [0x00 : 2] Audio block mode
    $02 constant SAI1_PRTCFG                    \ [0x02 : 2] Protocol configuration
    $05 constant SAI1_DS                        \ [0x05 : 3] Data size
    $08 constant SAI1_LSBFIRST                  \ [0x08] Least significant bit first
    $09 constant SAI1_CKSTR                     \ [0x09] Clock strobing edge
    $0a constant SAI1_SYNCEN                    \ [0x0a : 2] Synchronization enable
    $0c constant SAI1_MONO                      \ [0x0c] Mono mode
    $0d constant SAI1_OUTDRIV                   \ [0x0d] Output drive
    $10 constant SAI1_SAIEN                     \ [0x10] Audio block B enable
    $11 constant SAI1_DMAEN                     \ [0x11] DMA enable
    $13 constant SAI1_NODIV                     \ [0x13] No divider
    $14 constant SAI1_MCKDIV                    \ [0x14 : 6] Master clock divider
    $1a constant SAI1_OSR                       \ [0x1a] Oversampling ratio for master clock
    $1b constant SAI1_MCKEN                     \ [0x1b] Master clock generation enable
  [then]


  [ifdef] SAI1_ACR2_DEF
    \
    \ @brief AConfiguration register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_FTH                       \ [0x00 : 3] FIFO threshold
    $03 constant SAI1_FFLUSH                    \ [0x03] FIFO flush
    $04 constant SAI1_TRIS                      \ [0x04] Tristate management on data line
    $05 constant SAI1_MUTE                      \ [0x05] Mute
    $06 constant SAI1_MUTEVAL                   \ [0x06] Mute value
    $07 constant SAI1_MUTECNT                   \ [0x07 : 6] Mute counter
    $0d constant SAI1_CPL                       \ [0x0d] Complement bit
    $0e constant SAI1_COMP                      \ [0x0e : 2] Companding mode
  [then]


  [ifdef] SAI1_AFRCR_DEF
    \
    \ @brief Aframe configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $00 constant SAI1_FRL                       \ [0x00 : 8] Frame length
    $08 constant SAI1_FSALL                     \ [0x08 : 7] Frame synchronization active level length
    $10 constant SAI1_FSDEF                     \ [0x10] Frame synchronization definition
    $11 constant SAI1_FSPOL                     \ [0x11] Frame synchronization polarity
    $12 constant SAI1_FSOFF                     \ [0x12] Frame synchronization offset
  [then]


  [ifdef] SAI1_ASLOTR_DEF
    \
    \ @brief ASlot register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_FBOFF                     \ [0x00 : 5] First bit offset
    $06 constant SAI1_SLOTSZ                    \ [0x06 : 2] Slot size
    $08 constant SAI1_NBSLOT                    \ [0x08 : 4] Number of slots in an audio frame
    $10 constant SAI1_SLOTEN                    \ [0x10 : 16] Slot enable
  [then]


  [ifdef] SAI1_AIM_DEF
    \
    \ @brief AInterrupt mask register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_OVRUDRIE                  \ [0x00] Overrun/underrun interrupt enable
    $01 constant SAI1_MUTEDET                   \ [0x01] Mute detection interrupt enable
    $02 constant SAI1_WCKCFG                    \ [0x02] Wrong clock configuration interrupt enable
    $03 constant SAI1_FREQIE                    \ [0x03] FIFO request interrupt enable
    $04 constant SAI1_CNRDYIE                   \ [0x04] Codec not ready interrupt enable
    $05 constant SAI1_AFSDETIE                  \ [0x05] Anticipated frame synchronization detection interrupt enable
    $06 constant SAI1_LFSDET                    \ [0x06] Late frame synchronization detection interrupt enable
  [then]


  [ifdef] SAI1_ASR_DEF
    \
    \ @brief AStatus register
    \ Address offset: 0x18
    \ Reset value: 0x00000008
    \
    $00 constant SAI1_OVRUDR                    \ [0x00] Overrun / underrun
    $01 constant SAI1_MUTEDET                   \ [0x01] Mute detection
    $02 constant SAI1_WCKCFG                    \ [0x02] Wrong clock configuration flag
    $03 constant SAI1_FREQ                      \ [0x03] FIFO request
    $04 constant SAI1_CNRDY                     \ [0x04] Codec not ready
    $05 constant SAI1_AFSDET                    \ [0x05] Anticipated frame synchronization detection
    $06 constant SAI1_LFSDET                    \ [0x06] Late frame synchronization detection
    $10 constant SAI1_FLVL                      \ [0x10 : 3] FIFO level threshold
  [then]


  [ifdef] SAI1_ACLRFR_DEF
    \
    \ @brief AClear flag register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_COVRUDR                   \ [0x00] Clear overrun / underrun
    $01 constant SAI1_CMUTEDET                  \ [0x01] Mute detection flag
    $02 constant SAI1_CWCKCFG                   \ [0x02] Clear wrong clock configuration flag
    $04 constant SAI1_CCNRDY                    \ [0x04] Clear codec not ready flag
    $05 constant SAI1_CAFSDET                   \ [0x05] Clear anticipated frame synchronization detection flag
    $06 constant SAI1_CLFSDET                   \ [0x06] Clear late frame synchronization detection flag
  [then]


  [ifdef] SAI1_ADR_DEF
    \
    \ @brief AData register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_DATA                      \ [0x00 : 32] Data
  [then]


  [ifdef] SAI1_BCR1_DEF
    \
    \ @brief BConfiguration register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000040
    \
    $00 constant SAI1_MODE                      \ [0x00 : 2] Audio block mode
    $02 constant SAI1_PRTCFG                    \ [0x02 : 2] Protocol configuration
    $05 constant SAI1_DS                        \ [0x05 : 3] Data size
    $08 constant SAI1_LSBFIRST                  \ [0x08] Least significant bit first
    $09 constant SAI1_CKSTR                     \ [0x09] Clock strobing edge
    $0a constant SAI1_SYNCEN                    \ [0x0a : 2] Synchronization enable
    $0c constant SAI1_MONO                      \ [0x0c] Mono mode
    $0d constant SAI1_OUTDRIV                   \ [0x0d] Output drive
    $10 constant SAI1_SAIEN                     \ [0x10] Audio block B enable
    $11 constant SAI1_DMAEN                     \ [0x11] DMA enable
    $13 constant SAI1_NODIV                     \ [0x13] No divider
    $14 constant SAI1_MCKDIV                    \ [0x14 : 6] Master clock divider
    $1a constant SAI1_OSR                       \ [0x1a] Oversampling ratio for master clock
    $1b constant SAI1_MCKEN                     \ [0x1b] Master clock generation enable
  [then]


  [ifdef] SAI1_BCR2_DEF
    \
    \ @brief BConfiguration register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_FTH                       \ [0x00 : 3] FIFO threshold
    $03 constant SAI1_FFLUSH                    \ [0x03] FIFO flush
    $04 constant SAI1_TRIS                      \ [0x04] Tristate management on data line
    $05 constant SAI1_MUTE                      \ [0x05] Mute
    $06 constant SAI1_MUTEVAL                   \ [0x06] Mute value
    $07 constant SAI1_MUTECNT                   \ [0x07 : 6] Mute counter
    $0d constant SAI1_CPL                       \ [0x0d] Complement bit
    $0e constant SAI1_COMP                      \ [0x0e : 2] Companding mode
  [then]


  [ifdef] SAI1_BFRCR_DEF
    \
    \ @brief Bframe configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000007
    \
    $00 constant SAI1_FRL                       \ [0x00 : 8] Frame length
    $08 constant SAI1_FSALL                     \ [0x08 : 7] Frame synchronization active level length
    $10 constant SAI1_FSDEF                     \ [0x10] Frame synchronization definition
    $11 constant SAI1_FSPOL                     \ [0x11] Frame synchronization polarity
    $12 constant SAI1_FSOFF                     \ [0x12] Frame synchronization offset
  [then]


  [ifdef] SAI1_BSLOTR_DEF
    \
    \ @brief BSlot register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_FBOFF                     \ [0x00 : 5] First bit offset
    $06 constant SAI1_SLOTSZ                    \ [0x06 : 2] Slot size
    $08 constant SAI1_NBSLOT                    \ [0x08 : 4] Number of slots in an audio frame
    $10 constant SAI1_SLOTEN                    \ [0x10 : 16] Slot enable
  [then]


  [ifdef] SAI1_BIM_DEF
    \
    \ @brief BInterrupt mask register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_OVRUDRIE                  \ [0x00] Overrun/underrun interrupt enable
    $01 constant SAI1_MUTEDET                   \ [0x01] Mute detection interrupt enable
    $02 constant SAI1_WCKCFG                    \ [0x02] Wrong clock configuration interrupt enable
    $03 constant SAI1_FREQIE                    \ [0x03] FIFO request interrupt enable
    $04 constant SAI1_CNRDYIE                   \ [0x04] Codec not ready interrupt enable
    $05 constant SAI1_AFSDETIE                  \ [0x05] Anticipated frame synchronization detection interrupt enable
    $06 constant SAI1_LFSDETIE                  \ [0x06] Late frame synchronization detection interrupt enable
  [then]


  [ifdef] SAI1_BSR_DEF
    \
    \ @brief BStatus register
    \ Address offset: 0x38
    \ Reset value: 0x00000008
    \
    $00 constant SAI1_OVRUDR                    \ [0x00] Overrun / underrun
    $01 constant SAI1_MUTEDET                   \ [0x01] Mute detection
    $02 constant SAI1_WCKCFG                    \ [0x02] Wrong clock configuration flag
    $03 constant SAI1_FREQ                      \ [0x03] FIFO request
    $04 constant SAI1_CNRDY                     \ [0x04] Codec not ready
    $05 constant SAI1_AFSDET                    \ [0x05] Anticipated frame synchronization detection
    $06 constant SAI1_LFSDET                    \ [0x06] Late frame synchronization detection
    $10 constant SAI1_FLVL                      \ [0x10 : 3] FIFO level threshold
  [then]


  [ifdef] SAI1_BCLRFR_DEF
    \
    \ @brief BClear flag register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_COVRUDR                   \ [0x00] Clear overrun / underrun
    $01 constant SAI1_CMUTEDET                  \ [0x01] Mute detection flag
    $02 constant SAI1_CWCKCFG                   \ [0x02] Clear wrong clock configuration flag
    $04 constant SAI1_CCNRDY                    \ [0x04] Clear codec not ready flag
    $05 constant SAI1_CAFSDET                   \ [0x05] Clear anticipated frame synchronization detection flag
    $06 constant SAI1_CLFSDET                   \ [0x06] Clear late frame synchronization detection flag
  [then]


  [ifdef] SAI1_BDR_DEF
    \
    \ @brief BData register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_DATA                      \ [0x00 : 32] Data
  [then]


  [ifdef] SAI1_PDMCR_DEF
    \
    \ @brief PDM control register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_PDMEN                     \ [0x00] PDM enable
    $04 constant SAI1_MICNBR                    \ [0x04 : 2] Number of microphones
    $08 constant SAI1_CKEN1                     \ [0x08] Clock enable of bitstream clock number 1
    $09 constant SAI1_CKEN2                     \ [0x09] Clock enable of bitstream clock number 2
  [then]


  [ifdef] SAI1_PDMDLY_DEF
    \
    \ @brief PDM delay register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SAI1_DLYM1L                    \ [0x00 : 3] Delay line for first microphone of pair 1
    $04 constant SAI1_DLYM1R                    \ [0x04 : 3] Delay line for second microphone of pair 1
    $08 constant SAI1_DLYM2L                    \ [0x08 : 3] Delay line for first microphone of pair 2
    $0c constant SAI1_DLYM2R                    \ [0x0c : 3] Delay line for second microphone of pair 2
    $10 constant SAI1_DLYM3L                    \ [0x10 : 3] Delay line for first microphone of pair 3
    $14 constant SAI1_DLYM3R                    \ [0x14 : 3] Delay line for second microphone of pair 3
    $18 constant SAI1_DLYM4L                    \ [0x18 : 3] Delay line for first microphone of pair 4
    $1c constant SAI1_DLYM4R                    \ [0x1c : 3] Delay line for second microphone of pair 4
  [then]

  \
  \ @brief Serial audio interface
  \
  $04 constant SAI1_ACR1                \ AConfiguration register 1
  $08 constant SAI1_ACR2                \ AConfiguration register 2
  $0C constant SAI1_AFRCR               \ Aframe configuration register
  $10 constant SAI1_ASLOTR              \ ASlot register
  $14 constant SAI1_AIM                 \ AInterrupt mask register
  $18 constant SAI1_ASR                 \ AStatus register
  $1C constant SAI1_ACLRFR              \ AClear flag register
  $20 constant SAI1_ADR                 \ AData register
  $24 constant SAI1_BCR1                \ BConfiguration register 1
  $28 constant SAI1_BCR2                \ BConfiguration register 2
  $2C constant SAI1_BFRCR               \ Bframe configuration register
  $30 constant SAI1_BSLOTR              \ BSlot register
  $34 constant SAI1_BIM                 \ BInterrupt mask register
  $38 constant SAI1_BSR                 \ BStatus register
  $3C constant SAI1_BCLRFR              \ BClear flag register
  $40 constant SAI1_BDR                 \ BData register
  $44 constant SAI1_PDMCR               \ PDM control register
  $48 constant SAI1_PDMDLY              \ PDM delay register

: SAI1_DEF ; [then]
