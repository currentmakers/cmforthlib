\
\ @file dmamux.fs
\ @brief DMA request multiplexer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMAMUX_DEF

  [ifdef] DMAMUX_C0CR_DEF
    \
    \ @brief request line multiplexer channel x configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA request identification
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX_C1CR_DEF
    \
    \ @brief request line multiplexer channel x configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA request identification
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX_C2CR_DEF
    \
    \ @brief request line multiplexer channel x configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA request identification
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX_C3CR_DEF
    \
    \ @brief request line multiplexer channel x configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA request identification
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX_C4CR_DEF
    \
    \ @brief request line multiplexer channel x configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA request identification
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX_C5CR_DEF
    \
    \ @brief request line multiplexer channel x configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA request identification
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX_C6CR_DEF
    \
    \ @brief request line multiplexer channel x configuration register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA request identification
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX_C7CR_DEF
    \
    \ @brief request line multiplexer channel x configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA request identification
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX_C8CR_DEF
    \
    \ @brief request line multiplexer channel x configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA request identification
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX_C9CR_DEF
    \
    \ @brief request line multiplexer channel x configuration register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA request identification
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification
  [then]


  [ifdef] DMAMUX_C10CR_DEF
    \
    \ @brief C10CR
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMAREQ_ID
    $08 constant DMAMUX_SOIE                    \ [0x08] SOIE
    $09 constant DMAMUX_EGE                     \ [0x09] EGE
    $10 constant DMAMUX_SE                      \ [0x10] SE
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] SPOL
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] NBREQ
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C11CR_DEF
    \
    \ @brief C11CR
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMAREQ_ID
    $08 constant DMAMUX_SOIE                    \ [0x08] SOIE
    $09 constant DMAMUX_EGE                     \ [0x09] EGE
    $10 constant DMAMUX_SE                      \ [0x10] SE
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] SPOL
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] NBREQ
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C12CR_DEF
    \
    \ @brief C12CR
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMAREQ_ID
    $08 constant DMAMUX_SOIE                    \ [0x08] SOIE
    $09 constant DMAMUX_EGE                     \ [0x09] EGE
    $10 constant DMAMUX_SE                      \ [0x10] SE
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] SPOL
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] NBREQ
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C13CR_DEF
    \
    \ @brief C13CR
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMAREQ_ID
    $08 constant DMAMUX_SOIE                    \ [0x08] SOIE
    $09 constant DMAMUX_EGE                     \ [0x09] EGE
    $10 constant DMAMUX_SE                      \ [0x10] SE
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] SPOL
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] NBREQ
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_CSR_DEF
    \
    \ @brief request line multiplexer interrupt channel status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SOF0                    \ [0x00] SOF0
    $01 constant DMAMUX_SOF1                    \ [0x01] SOF1
    $02 constant DMAMUX_SOF2                    \ [0x02] SOF2
    $03 constant DMAMUX_SOF3                    \ [0x03] SOF3
    $04 constant DMAMUX_SOF4                    \ [0x04] SOF4
    $05 constant DMAMUX_SOF5                    \ [0x05] SOF5
    $06 constant DMAMUX_SOF6                    \ [0x06] SOF6
    $07 constant DMAMUX_SOF7                    \ [0x07] SOF7
    $08 constant DMAMUX_SOF8                    \ [0x08] SOF8
    $09 constant DMAMUX_SOF9                    \ [0x09] SOF9
    $0a constant DMAMUX_SOF10                   \ [0x0a] SOF10
    $0b constant DMAMUX_SOF11                   \ [0x0b] SOF11
    $0c constant DMAMUX_SOF12                   \ [0x0c] SOF12
    $0d constant DMAMUX_SOF13                   \ [0x0d] Synchronization overrun event flag
  [then]


  [ifdef] DMAMUX_CCFR_DEF
    \
    \ @brief request line multiplexer interrupt channel clear flag register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_CSOF0                   \ [0x00] CSOF0
    $01 constant DMAMUX_CSOF1                   \ [0x01] CSOF1
    $02 constant DMAMUX_CSOF2                   \ [0x02] CSOF2
    $03 constant DMAMUX_CSOF3                   \ [0x03] CSOF3
    $04 constant DMAMUX_CSOF4                   \ [0x04] CSOF4
    $05 constant DMAMUX_CSOF5                   \ [0x05] CSOF5
    $06 constant DMAMUX_CSOF6                   \ [0x06] CSOF6
    $07 constant DMAMUX_CSOF7                   \ [0x07] CSOF7
    $08 constant DMAMUX_CSOF8                   \ [0x08] CSOF8
    $09 constant DMAMUX_CSOF9                   \ [0x09] CSOF9
    $0a constant DMAMUX_CSOF10                  \ [0x0a] CSOF10
    $0b constant DMAMUX_CSOF11                  \ [0x0b] CSOF11
    $0c constant DMAMUX_CSOF12                  \ [0x0c] CSOF12
    $0d constant DMAMUX_CSOF13                  \ [0x0d] CSOF13
  [then]


  [ifdef] DMAMUX_RG0CR_DEF
    \
    \ @brief request generator channel x configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal identification
    $08 constant DMAMUX_OIE                     \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger polarity
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to be generated (minus 1)
  [then]


  [ifdef] DMAMUX_RG1CR_DEF
    \
    \ @brief request generator channel x configuration register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal identification
    $08 constant DMAMUX_OIE                     \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger polarity
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to be generated (minus 1)
  [then]


  [ifdef] DMAMUX_RG2CR_DEF
    \
    \ @brief request generator channel x configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal identification
    $08 constant DMAMUX_OIE                     \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger polarity
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to be generated (minus 1)
  [then]


  [ifdef] DMAMUX_RG3CR_DEF
    \
    \ @brief request generator channel x configuration register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal identification
    $08 constant DMAMUX_OIE                     \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger polarity
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to be generated (minus 1)
  [then]


  [ifdef] DMAMUX_RGSR_DEF
    \
    \ @brief request generator interrupt status register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_OF0                     \ [0x00] OF0
    $01 constant DMAMUX_OF1                     \ [0x01] OF1
    $02 constant DMAMUX_OF2                     \ [0x02] OF2
    $03 constant DMAMUX_OF3                     \ [0x03] Trigger overrun event flag
  [then]


  [ifdef] DMAMUX_RGCFR_DEF
    \
    \ @brief request generator interrupt clear flag register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_COF0                    \ [0x00] COF0
    $01 constant DMAMUX_COF1                    \ [0x01] COF1
    $02 constant DMAMUX_COF2                    \ [0x02] COF2
    $03 constant DMAMUX_COF3                    \ [0x03] Clear trigger overrun event flag
  [then]

  \
  \ @brief DMA request multiplexer
  \
  $00 constant DMAMUX_C0CR              \ request line multiplexer channel x configuration register
  $04 constant DMAMUX_C1CR              \ request line multiplexer channel x configuration register
  $08 constant DMAMUX_C2CR              \ request line multiplexer channel x configuration register
  $0C constant DMAMUX_C3CR              \ request line multiplexer channel x configuration register
  $10 constant DMAMUX_C4CR              \ request line multiplexer channel x configuration register
  $14 constant DMAMUX_C5CR              \ request line multiplexer channel x configuration register
  $18 constant DMAMUX_C6CR              \ request line multiplexer channel x configuration register
  $1C constant DMAMUX_C7CR              \ request line multiplexer channel x configuration register
  $20 constant DMAMUX_C8CR              \ request line multiplexer channel x configuration register
  $24 constant DMAMUX_C9CR              \ request line multiplexer channel x configuration register
  $28 constant DMAMUX_C10CR             \ C10CR
  $2C constant DMAMUX_C11CR             \ C11CR
  $30 constant DMAMUX_C12CR             \ C12CR
  $34 constant DMAMUX_C13CR             \ C13CR
  $80 constant DMAMUX_CSR               \ request line multiplexer interrupt channel status register
  $84 constant DMAMUX_CCFR              \ request line multiplexer interrupt channel clear flag register
  $100 constant DMAMUX_RG0CR            \ request generator channel x configuration register
  $104 constant DMAMUX_RG1CR            \ request generator channel x configuration register
  $108 constant DMAMUX_RG2CR            \ request generator channel x configuration register
  $10C constant DMAMUX_RG3CR            \ request generator channel x configuration register
  $140 constant DMAMUX_RGSR             \ request generator interrupt status register
  $144 constant DMAMUX_RGCFR            \ request generator interrupt clear flag register

: DMAMUX_DEF ; [then]
