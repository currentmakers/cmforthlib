\
\ @file sai.fs
\ @brief Serial audio interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SAI_DEF

  [ifdef] SAI_SAI_GCR_DEF
    \
    \ @brief SAI global configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SAI_SYNCIN                     \ [0x00 : 2] Synchronization outputs
    $04 constant SAI_SYNCOUT                    \ [0x04 : 2] Synchronization outputs
  [then]


  [ifdef] SAI_SAI_ACR1_DEF
    \
    \ @brief SAI configuration register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000040
    \
    $00 constant SAI_MODE                       \ [0x00 : 2] SAIx audio block mode
    $02 constant SAI_PRTCFG                     \ [0x02 : 2] Protocol configuration
    $05 constant SAI_DS                         \ [0x05 : 3] Data size
    $08 constant SAI_LSBFIRST                   \ [0x08] Least significant bit first
    $09 constant SAI_CKSTR                      \ [0x09] Clock strobing edge
    $0a constant SAI_SYNCEN                     \ [0x0a : 2] Synchronization enable
    $0c constant SAI_MONO                       \ [0x0c] Mono mode
    $0d constant SAI_OUTDRIV                    \ [0x0d] Output drive
    $10 constant SAI_SAIEN                      \ [0x10] Audio block enable
    $11 constant SAI_DMAEN                      \ [0x11] DMA enable
    $13 constant SAI_NODIV                      \ [0x13] No divider
    $14 constant SAI_MCKDIV                     \ [0x14 : 6] Master clock divider
    $1a constant SAI_OSR                        \ [0x1a] Oversampling ratio for master clock
    $1b constant SAI_MCKEN                      \ [0x1b] Master clock generation enable
  [then]


  [ifdef] SAI_SAI_ACR2_DEF
    \
    \ @brief SAI configuration register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FTH                        \ [0x00 : 3] FIFO threshold.
    $03 constant SAI_FFLUSH                     \ [0x03] FIFO flush.
    $04 constant SAI_TRIS                       \ [0x04] Tristate management on data line.
    $05 constant SAI_MUTE                       \ [0x05] Mute.
    $06 constant SAI_MUTEVAL                    \ [0x06] Mute value.
    $07 constant SAI_MUTECNT                    \ [0x07 : 6] Mute counter.
    $0d constant SAI_CPL                        \ [0x0d] Complement bit.
    $0e constant SAI_COMP                       \ [0x0e : 2] Companding mode.
  [then]


  [ifdef] SAI_SAI_AFRCR_DEF
    \
    \ @brief SAI frame configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $00 constant SAI_FRL                        \ [0x00 : 8] Frame length.
    $08 constant SAI_FSALL                      \ [0x08 : 7] Frame synchronization active level length.
    $10 constant SAI_FSDEF                      \ [0x10] Frame synchronization definition.
    $11 constant SAI_FSPOL                      \ [0x11] Frame synchronization polarity.
    $12 constant SAI_FSOFF                      \ [0x12] Frame synchronization offset.
  [then]


  [ifdef] SAI_SAI_ASLOTR_DEF
    \
    \ @brief SAI slot register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FBOFF                      \ [0x00 : 5] First bit offset
    $06 constant SAI_SLOTSZ                     \ [0x06 : 2] Slot size
    $08 constant SAI_NBSLOT                     \ [0x08 : 4] Number of slots in an audio frame.
    $10 constant SAI_SLOTEN                     \ [0x10 : 16] Slot enable.
  [then]


  [ifdef] SAI_SAI_AIM_DEF
    \
    \ @brief SAI interrupt mask register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SAI_OVRUDRIE                   \ [0x00] Overrun/underrun interrupt enable.
    $01 constant SAI_MUTEDETIE                  \ [0x01] Mute detection interrupt enable.
    $02 constant SAI_WCKCFGIE                   \ [0x02] Wrong clock configuration interrupt enable.
    $03 constant SAI_FREQIE                     \ [0x03] FIFO request interrupt enable.
    $04 constant SAI_CNRDYIE                    \ [0x04] Codec not ready interrupt enable (AC'97).
    $05 constant SAI_AFSDETIE                   \ [0x05] Anticipated frame synchronization detection interrupt enable.
    $06 constant SAI_LFSDETIE                   \ [0x06] Late frame synchronization detection interrupt enable.
  [then]


  [ifdef] SAI_SAI_ASR_DEF
    \
    \ @brief SAI status register
    \ Address offset: 0x18
    \ Reset value: 0x00000008
    \
    $00 constant SAI_OVRUDR                     \ [0x00] Overrun / underrun.
    $01 constant SAI_MUTEDET                    \ [0x01] Mute detection.
    $02 constant SAI_WCKCFG                     \ [0x02] Wrong clock configuration flag.
    $03 constant SAI_FREQ                       \ [0x03] FIFO request.
    $04 constant SAI_CNRDY                      \ [0x04] Codec not ready.
    $05 constant SAI_AFSDET                     \ [0x05] Anticipated frame synchronization detection.
    $06 constant SAI_LFSDET                     \ [0x06] Late frame synchronization detection.
    $10 constant SAI_FLVL                       \ [0x10 : 3] FIFO level threshold.
  [then]


  [ifdef] SAI_SAI_ACLRFR_DEF
    \
    \ @brief SAI clear flag register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SAI_COVRUDR                    \ [0x00] Clear overrun / underrun.
    $01 constant SAI_CMUTEDET                   \ [0x01] Mute detection flag.
    $02 constant SAI_CWCKCFG                    \ [0x02] Clear wrong clock configuration flag.
    $04 constant SAI_CCNRDY                     \ [0x04] Clear Codec not ready flag.
    $05 constant SAI_CAFSDET                    \ [0x05] Clear anticipated frame synchronization detection flag.
    $06 constant SAI_CLFSDET                    \ [0x06] Clear late frame synchronization detection flag.
  [then]


  [ifdef] SAI_SAI_ADR_DEF
    \
    \ @brief SAI data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SAI_DATA                       \ [0x00 : 32] Data
  [then]


  [ifdef] SAI_SAI_BCR1_DEF
    \
    \ @brief SAI configuration register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000040
    \
    $00 constant SAI_MODE                       \ [0x00 : 2] SAIx audio block mode
    $02 constant SAI_PRTCFG                     \ [0x02 : 2] Protocol configuration
    $05 constant SAI_DS                         \ [0x05 : 3] Data size
    $08 constant SAI_LSBFIRST                   \ [0x08] Least significant bit first
    $09 constant SAI_CKSTR                      \ [0x09] Clock strobing edge
    $0a constant SAI_SYNCEN                     \ [0x0a : 2] Synchronization enable
    $0c constant SAI_MONO                       \ [0x0c] Mono mode
    $0d constant SAI_OUTDRIV                    \ [0x0d] Output drive
    $10 constant SAI_SAIEN                      \ [0x10] Audio block enable
    $11 constant SAI_DMAEN                      \ [0x11] DMA enable
    $13 constant SAI_NODIV                      \ [0x13] No divider
    $14 constant SAI_MCKDIV                     \ [0x14 : 6] Master clock divider
    $1a constant SAI_OSR                        \ [0x1a] Oversampling ratio for master clock
    $1b constant SAI_MCKEN                      \ [0x1b] Master clock generation enable
  [then]


  [ifdef] SAI_SAI_BCR2_DEF
    \
    \ @brief SAI configuration register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FTH                        \ [0x00 : 3] FIFO threshold.
    $03 constant SAI_FFLUSH                     \ [0x03] FIFO flush.
    $04 constant SAI_TRIS                       \ [0x04] Tristate management on data line.
    $05 constant SAI_MUTE                       \ [0x05] Mute.
    $06 constant SAI_MUTEVAL                    \ [0x06] Mute value.
    $07 constant SAI_MUTECNT                    \ [0x07 : 6] Mute counter.
    $0d constant SAI_CPL                        \ [0x0d] Complement bit.
    $0e constant SAI_COMP                       \ [0x0e : 2] Companding mode.
  [then]


  [ifdef] SAI_SAI_BFRCR_DEF
    \
    \ @brief SAI frame configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000007
    \
    $00 constant SAI_FRL                        \ [0x00 : 8] Frame length.
    $08 constant SAI_FSALL                      \ [0x08 : 7] Frame synchronization active level length.
    $10 constant SAI_FSDEF                      \ [0x10] Frame synchronization definition.
    $11 constant SAI_FSPOL                      \ [0x11] Frame synchronization polarity.
    $12 constant SAI_FSOFF                      \ [0x12] Frame synchronization offset.
  [then]


  [ifdef] SAI_SAI_BSLOTR_DEF
    \
    \ @brief SAI slot register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FBOFF                      \ [0x00 : 5] First bit offset
    $06 constant SAI_SLOTSZ                     \ [0x06 : 2] Slot size
    $08 constant SAI_NBSLOT                     \ [0x08 : 4] Number of slots in an audio frame.
    $10 constant SAI_SLOTEN                     \ [0x10 : 16] Slot enable.
  [then]


  [ifdef] SAI_SAI_BIM_DEF
    \
    \ @brief SAI interrupt mask register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SAI_OVRUDRIE                   \ [0x00] Overrun/underrun interrupt enable.
    $01 constant SAI_MUTEDETIE                  \ [0x01] Mute detection interrupt enable.
    $02 constant SAI_WCKCFGIE                   \ [0x02] Wrong clock configuration interrupt enable.
    $03 constant SAI_FREQIE                     \ [0x03] FIFO request interrupt enable.
    $04 constant SAI_CNRDYIE                    \ [0x04] Codec not ready interrupt enable (AC'97).
    $05 constant SAI_AFSDETIE                   \ [0x05] Anticipated frame synchronization detection interrupt enable.
    $06 constant SAI_LFSDETIE                   \ [0x06] Late frame synchronization detection interrupt enable.
  [then]


  [ifdef] SAI_SAI_BSR_DEF
    \
    \ @brief SAI status register
    \ Address offset: 0x38
    \ Reset value: 0x00000008
    \
    $00 constant SAI_OVRUDR                     \ [0x00] Overrun / underrun.
    $01 constant SAI_MUTEDET                    \ [0x01] Mute detection.
    $02 constant SAI_WCKCFG                     \ [0x02] Wrong clock configuration flag.
    $03 constant SAI_FREQ                       \ [0x03] FIFO request.
    $04 constant SAI_CNRDY                      \ [0x04] Codec not ready.
    $05 constant SAI_AFSDET                     \ [0x05] Anticipated frame synchronization detection.
    $06 constant SAI_LFSDET                     \ [0x06] Late frame synchronization detection.
    $10 constant SAI_FLVL                       \ [0x10 : 3] FIFO level threshold.
  [then]


  [ifdef] SAI_SAI_BCLRFR_DEF
    \
    \ @brief SAI clear flag register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SAI_COVRUDR                    \ [0x00] Clear overrun / underrun.
    $01 constant SAI_CMUTEDET                   \ [0x01] Mute detection flag.
    $02 constant SAI_CWCKCFG                    \ [0x02] Clear wrong clock configuration flag.
    $04 constant SAI_CCNRDY                     \ [0x04] Clear Codec not ready flag.
    $05 constant SAI_CAFSDET                    \ [0x05] Clear anticipated frame synchronization detection flag.
    $06 constant SAI_CLFSDET                    \ [0x06] Clear late frame synchronization detection flag.
  [then]


  [ifdef] SAI_SAI_BDR_DEF
    \
    \ @brief SAI data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SAI_DATA                       \ [0x00 : 32] Data
  [then]


  [ifdef] SAI_SAI_PDMCR_DEF
    \
    \ @brief SAI PDM control register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SAI_PDMEN                      \ [0x00] PDM enable
    $04 constant SAI_MICNBR                     \ [0x04 : 2] Number of microphones
    $08 constant SAI_CKEN1                      \ [0x08] Clock enable of bitstream clock number 1
    $09 constant SAI_CKEN2                      \ [0x09] Clock enable of bitstream clock number 2
  [then]


  [ifdef] SAI_SAI_PDMDLY_DEF
    \
    \ @brief SAI PDM delay register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SAI_DLYM1L                     \ [0x00 : 3] Delay line adjust for first microphone of pair 1
    $04 constant SAI_DLYM1R                     \ [0x04 : 3] Delay line adjust for second microphone of pair 1
    $08 constant SAI_DLYM2L                     \ [0x08 : 3] Delay line for first microphone of pair 2
    $0c constant SAI_DLYM2R                     \ [0x0c : 3] Delay line for second microphone of pair 2
    $10 constant SAI_DLYM3L                     \ [0x10 : 3] Delay line for first microphone of pair 3
    $14 constant SAI_DLYM3R                     \ [0x14 : 3] Delay line for second microphone of pair 3
    $18 constant SAI_DLYM4L                     \ [0x18 : 3] Delay line for first microphone of pair 4
    $1c constant SAI_DLYM4R                     \ [0x1c : 3] Delay line for second microphone of pair 4
  [then]

  \
  \ @brief Serial audio interface
  \
  $00 constant SAI_SAI_GCR              \ SAI global configuration register
  $04 constant SAI_SAI_ACR1             \ SAI configuration register 1
  $08 constant SAI_SAI_ACR2             \ SAI configuration register 2
  $0C constant SAI_SAI_AFRCR            \ SAI frame configuration register
  $10 constant SAI_SAI_ASLOTR           \ SAI slot register
  $14 constant SAI_SAI_AIM              \ SAI interrupt mask register
  $18 constant SAI_SAI_ASR              \ SAI status register
  $1C constant SAI_SAI_ACLRFR           \ SAI clear flag register
  $20 constant SAI_SAI_ADR              \ SAI data register
  $24 constant SAI_SAI_BCR1             \ SAI configuration register 1
  $28 constant SAI_SAI_BCR2             \ SAI configuration register 2
  $2C constant SAI_SAI_BFRCR            \ SAI frame configuration register
  $30 constant SAI_SAI_BSLOTR           \ SAI slot register
  $34 constant SAI_SAI_BIM              \ SAI interrupt mask register
  $38 constant SAI_SAI_BSR              \ SAI status register
  $3C constant SAI_SAI_BCLRFR           \ SAI clear flag register
  $40 constant SAI_SAI_BDR              \ SAI data register
  $44 constant SAI_SAI_PDMCR            \ SAI PDM control register
  $48 constant SAI_SAI_PDMDLY           \ SAI PDM delay register

: SAI_DEF ; [then]
