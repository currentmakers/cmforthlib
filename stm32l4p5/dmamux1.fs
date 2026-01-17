\
\ @file dmamux1.fs
\ @brief DMA request multiplexer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMAMUX1_DEF

  [ifdef] DMAMUX1_C0CR_DEF
    \
    \ @brief channel 0 configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C1CR_DEF
    \
    \ @brief channel 1 configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C2CR_DEF
    \
    \ @brief channel 2 configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C3CR_DEF
    \
    \ @brief channel 3 configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C4CR_DEF
    \
    \ @brief channel 4 configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C5CR_DEF
    \
    \ @brief channel 5 configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C6CR_DEF
    \
    \ @brief channel 6 configuration register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C7CR_DEF
    \
    \ @brief channel 7 configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C8CR_DEF
    \
    \ @brief channel 8 configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C9CR_DEF
    \
    \ @brief channel 9 configuration register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C10CR_DEF
    \
    \ @brief channel 10 configuration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C11CR_DEF
    \
    \ @brief channel 11 configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C12CR_DEF
    \
    \ @brief channel 12 configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_C13CR_DEF
    \
    \ @brief channel 13 configuration register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX1_CSR_DEF
    \
    \ @brief channel status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SOF0                   \ [0x00] Synchronization overrun event flag
    $01 constant DMAMUX1_SOF1                   \ [0x01] Synchronization overrun event flag
    $02 constant DMAMUX1_SOF2                   \ [0x02] Synchronization overrun event flag
    $03 constant DMAMUX1_SOF3                   \ [0x03] Synchronization overrun event flag
    $04 constant DMAMUX1_SOF4                   \ [0x04] Synchronization overrun event flag
    $05 constant DMAMUX1_SOF5                   \ [0x05] Synchronization overrun event flag
    $06 constant DMAMUX1_SOF6                   \ [0x06] Synchronization overrun event flag
    $07 constant DMAMUX1_SOF7                   \ [0x07] Synchronization overrun event flag
    $08 constant DMAMUX1_SOF8                   \ [0x08] Synchronization overrun event flag
    $09 constant DMAMUX1_SOF9                   \ [0x09] Synchronization overrun event flag
    $0a constant DMAMUX1_SOF10                  \ [0x0a] Synchronization overrun event flag
    $0b constant DMAMUX1_SOF11                  \ [0x0b] Synchronization overrun event flag
    $0c constant DMAMUX1_SOF12                  \ [0x0c] Synchronization overrun event flag
    $0d constant DMAMUX1_SOF13                  \ [0x0d] Synchronization overrun event flag
  [then]


  [ifdef] DMAMUX1_CFR_DEF
    \
    \ @brief clear flag register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_CSOF0                  \ [0x00] Clear synchronization overrun event flag
    $01 constant DMAMUX1_CSOF1                  \ [0x01] Clear synchronization overrun event flag
    $02 constant DMAMUX1_CSOF2                  \ [0x02] Clear synchronization overrun event flag
    $03 constant DMAMUX1_CSOF3                  \ [0x03] Clear synchronization overrun event flag
    $04 constant DMAMUX1_CSOF4                  \ [0x04] Clear synchronization overrun event flag
    $05 constant DMAMUX1_CSOF5                  \ [0x05] Clear synchronization overrun event flag
    $06 constant DMAMUX1_CSOF6                  \ [0x06] Clear synchronization overrun event flag
    $07 constant DMAMUX1_CSOF7                  \ [0x07] Clear synchronization overrun event flag
    $08 constant DMAMUX1_CSOF8                  \ [0x08] Clear synchronization overrun event flag
    $09 constant DMAMUX1_CSOF9                  \ [0x09] Clear synchronization overrun event flag
    $0a constant DMAMUX1_CSOF10                 \ [0x0a] Clear synchronization overrun event flag
    $0b constant DMAMUX1_CSOF11                 \ [0x0b] Clear synchronization overrun event flag
    $0c constant DMAMUX1_CSOF12                 \ [0x0c] Clear synchronization overrun event flag
    $0d constant DMAMUX1_CSOF13                 \ [0x0d] Clear synchronization overrun event flag
  [then]


  [ifdef] DMAMUX1_RG0CR_DEF
    \
    \ @brief request generator channel 0 configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 5] Signal identification
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel 0 enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated minus 1
  [then]


  [ifdef] DMAMUX1_RG1CR_DEF
    \
    \ @brief request generator channel 1 configuration register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 5] Signal identification
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel 1 enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated minus 1
  [then]


  [ifdef] DMAMUX1_RG2CR_DEF
    \
    \ @brief request generator channel 2 configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 5] Signal identification
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel 2 enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated minus 1
  [then]


  [ifdef] DMAMUX1_RG3CR_DEF
    \
    \ @brief request generator channel 3 configuration register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 5] Signal identification
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel 3 enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated minus 1
  [then]


  [ifdef] DMAMUX1_RGSR_DEF
    \
    \ @brief request generator interrupt status register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_OF0                    \ [0x00] Trigger overrun event flag
    $01 constant DMAMUX1_OF1                    \ [0x01] Trigger overrun event flag
    $02 constant DMAMUX1_OF2                    \ [0x02] Trigger overrun event flag
    $03 constant DMAMUX1_OF3                    \ [0x03] Trigger overrun event flag
  [then]


  [ifdef] DMAMUX1_RGCFR_DEF
    \
    \ @brief request generator interrupt clear flag register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_COF0                   \ [0x00] Clear trigger overrun event flag
    $01 constant DMAMUX1_COF1                   \ [0x01] Clear trigger overrun event flag
    $02 constant DMAMUX1_COF2                   \ [0x02] Clear trigger overrun event flag
    $03 constant DMAMUX1_COF3                   \ [0x03] Clear trigger overrun event flag
  [then]

  \
  \ @brief DMA request multiplexer
  \
  $00 constant DMAMUX1_C0CR             \ channel 0 configuration register
  $04 constant DMAMUX1_C1CR             \ channel 1 configuration register
  $08 constant DMAMUX1_C2CR             \ channel 2 configuration register
  $0C constant DMAMUX1_C3CR             \ channel 3 configuration register
  $10 constant DMAMUX1_C4CR             \ channel 4 configuration register
  $14 constant DMAMUX1_C5CR             \ channel 5 configuration register
  $18 constant DMAMUX1_C6CR             \ channel 6 configuration register
  $1C constant DMAMUX1_C7CR             \ channel 7 configuration register
  $20 constant DMAMUX1_C8CR             \ channel 8 configuration register
  $24 constant DMAMUX1_C9CR             \ channel 9 configuration register
  $28 constant DMAMUX1_C10CR            \ channel 10 configuration register
  $2C constant DMAMUX1_C11CR            \ channel 11 configuration register
  $30 constant DMAMUX1_C12CR            \ channel 12 configuration register
  $34 constant DMAMUX1_C13CR            \ channel 13 configuration register
  $80 constant DMAMUX1_CSR              \ channel status register
  $84 constant DMAMUX1_CFR              \ clear flag register
  $100 constant DMAMUX1_RG0CR           \ request generator channel 0 configuration register
  $104 constant DMAMUX1_RG1CR           \ request generator channel 1 configuration register
  $108 constant DMAMUX1_RG2CR           \ request generator channel 2 configuration register
  $10C constant DMAMUX1_RG3CR           \ request generator channel 3 configuration register
  $140 constant DMAMUX1_RGSR            \ request generator interrupt status register
  $144 constant DMAMUX1_RGCFR           \ request generator interrupt clear flag register

: DMAMUX1_DEF ; [then]
