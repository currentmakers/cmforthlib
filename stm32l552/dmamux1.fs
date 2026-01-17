\
\ @file dmamux1.fs
\ @brief Direct memory access Multiplexer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMAMUX1_DEF

  [ifdef] DMAMUX1_C0CR_DEF
    \
    \ @brief DMA Multiplexer Channel 0 Control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C1CR_DEF
    \
    \ @brief DMA Multiplexer Channel 1 Control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C2CR_DEF
    \
    \ @brief DMA Multiplexer Channel 2 Control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C3CR_DEF
    \
    \ @brief DMA Multiplexer Channel 3 Control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C4CR_DEF
    \
    \ @brief DMA Multiplexer Channel 4 Control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C5CR_DEF
    \
    \ @brief DMA Multiplexer Channel 5 Control register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_OIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C6CR_DEF
    \
    \ @brief DMA Multiplexer Channel 6 Control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C7CR_DEF
    \
    \ @brief DMA Multiplexer Channel 7 Control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C8CR_DEF
    \
    \ @brief DMA Multiplexer Channel 8 Control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C9CR_DEF
    \
    \ @brief DMA Multiplexer Channel 9 Control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C10CR_DEF
    \
    \ @brief DMA Multiplexer Channel 10 Control register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C11CR_DEF
    \
    \ @brief DMA Multiplexer Channel 11 Control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C12CR_DEF
    \
    \ @brief DMA Multiplexer Channel 12 Control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C13CR_DEF
    \
    \ @brief DMA Multiplexer Channel 13 Control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA Request ID
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event Generation Enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Nb request
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX1_C14CR_DEF
    \
    \ @brief DMA Multiplexer Channel 10 Control register
    \ Address offset: 0x38
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


  [ifdef] DMAMUX1_C15CR_DEF
    \
    \ @brief DMA Multiplexer Channel 10 Control register
    \ Address offset: 0x3C
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
    \ @brief DMA Multiplexer Channel Status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SOF0                   \ [0x00] Synchronization Overrun Flag 0
    $01 constant DMAMUX1_SOF1                   \ [0x01] Synchronization Overrun Flag 1
    $02 constant DMAMUX1_SOF2                   \ [0x02] Synchronization Overrun Flag 2
    $03 constant DMAMUX1_SOF3                   \ [0x03] Synchronization Overrun Flag 3
    $04 constant DMAMUX1_SOF4                   \ [0x04] Synchronization Overrun Flag 4
    $05 constant DMAMUX1_SOF5                   \ [0x05] Synchronization Overrun Flag 5
    $06 constant DMAMUX1_SOF6                   \ [0x06] Synchronization Overrun Flag 6
    $07 constant DMAMUX1_SOF7                   \ [0x07] Synchronization Overrun Flag 7
    $08 constant DMAMUX1_SOF8                   \ [0x08] Synchronization Overrun Flag 8
    $09 constant DMAMUX1_SOF9                   \ [0x09] Synchronization Overrun Flag 9
    $0a constant DMAMUX1_SOF10                  \ [0x0a] Synchronization Overrun Flag 10
    $0b constant DMAMUX1_SOF11                  \ [0x0b] Synchronization Overrun Flag 11
    $0c constant DMAMUX1_SOF12                  \ [0x0c] Synchronization Overrun Flag 12
    $0d constant DMAMUX1_SOF13                  \ [0x0d] Synchronization Overrun Flag 13
    $0e constant DMAMUX1_SOF14                  \ [0x0e] Synchronization Overrun Flag 13
    $0f constant DMAMUX1_SOF15                  \ [0x0f] Synchronization Overrun Flag 13
  [then]


  [ifdef] DMAMUX1_CCFR_DEF
    \
    \ @brief DMA Channel Clear Flag Register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_CSOF0                  \ [0x00] Synchronization Clear Overrun Flag 0
    $01 constant DMAMUX1_CSOF1                  \ [0x01] Synchronization Clear Overrun Flag 1
    $02 constant DMAMUX1_CSOF2                  \ [0x02] Synchronization Clear Overrun Flag 2
    $03 constant DMAMUX1_CSOF3                  \ [0x03] Synchronization Clear Overrun Flag 3
    $04 constant DMAMUX1_CSOF4                  \ [0x04] Synchronization Clear Overrun Flag 4
    $05 constant DMAMUX1_CSOF5                  \ [0x05] Synchronization Clear Overrun Flag 5
    $06 constant DMAMUX1_CSOF6                  \ [0x06] Synchronization Clear Overrun Flag 6
    $07 constant DMAMUX1_CSOF7                  \ [0x07] Synchronization Clear Overrun Flag 7
    $08 constant DMAMUX1_CSOF8                  \ [0x08] Synchronization Clear Overrun Flag 8
    $09 constant DMAMUX1_CSOF9                  \ [0x09] Synchronization Clear Overrun Flag 9
    $0a constant DMAMUX1_CSOF10                 \ [0x0a] Synchronization Clear Overrun Flag 10
    $0b constant DMAMUX1_CSOF11                 \ [0x0b] Synchronization Clear Overrun Flag 11
    $0c constant DMAMUX1_CSOF12                 \ [0x0c] Synchronization Clear Overrun Flag 12
    $0d constant DMAMUX1_CSOF13                 \ [0x0d] Synchronization Clear Overrun Flag 13
    $0e constant DMAMUX1_CSOF14                 \ [0x0e] Synchronization Clear Overrun Flag 13
    $0f constant DMAMUX1_CSOF15                 \ [0x0f] Synchronization Clear Overrun Flag 13
  [then]


  [ifdef] DMAMUX1_RG0CR_DEF
    \
    \ @brief DMA Request Generator 0 Control Register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 5] Signal ID
    $08 constant DMAMUX1_OIE                    \ [0x08] Overrun Interrupt Enable
    $10 constant DMAMUX1_GE                     \ [0x10] Generation Enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] Generation Polarity
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of Request
  [then]


  [ifdef] DMAMUX1_RG1CR_DEF
    \
    \ @brief DMA Request Generator 1 Control Register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 5] Signal ID
    $08 constant DMAMUX1_OIE                    \ [0x08] Overrun Interrupt Enable
    $10 constant DMAMUX1_GE                     \ [0x10] Generation Enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] Generation Polarity
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of Request
  [then]


  [ifdef] DMAMUX1_RG2CR_DEF
    \
    \ @brief DMA Request Generator 2 Control Register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 5] Signal ID
    $08 constant DMAMUX1_OIE                    \ [0x08] Overrun Interrupt Enable
    $10 constant DMAMUX1_GE                     \ [0x10] Generation Enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] Generation Polarity
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of Request
  [then]


  [ifdef] DMAMUX1_RG3CR_DEF
    \
    \ @brief DMA Request Generator 3 Control Register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 5] Signal ID
    $08 constant DMAMUX1_OIE                    \ [0x08] Overrun Interrupt Enable
    $10 constant DMAMUX1_GE                     \ [0x10] Generation Enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] Generation Polarity
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of Request
  [then]


  [ifdef] DMAMUX1_RGSR_DEF
    \
    \ @brief DMA Request Generator Status Register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_OF0                    \ [0x00] Generator Overrun Flag 0
    $01 constant DMAMUX1_OF1                    \ [0x01] Generator Overrun Flag 1
    $02 constant DMAMUX1_OF2                    \ [0x02] Generator Overrun Flag 2
    $03 constant DMAMUX1_OF3                    \ [0x03] Generator Overrun Flag 3
  [then]


  [ifdef] DMAMUX1_RGCFR_DEF
    \
    \ @brief DMA Request Generator Clear Flag Register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_CSOF0                  \ [0x00] Generator Clear Overrun Flag 0
    $01 constant DMAMUX1_CSOF1                  \ [0x01] Generator Clear Overrun Flag 1
    $02 constant DMAMUX1_CSOF2                  \ [0x02] Generator Clear Overrun Flag 2
    $03 constant DMAMUX1_CSOF3                  \ [0x03] Generator Clear Overrun Flag 3
  [then]

  \
  \ @brief Direct memory access Multiplexer
  \
  $00 constant DMAMUX1_C0CR             \ DMA Multiplexer Channel 0 Control register
  $04 constant DMAMUX1_C1CR             \ DMA Multiplexer Channel 1 Control register
  $08 constant DMAMUX1_C2CR             \ DMA Multiplexer Channel 2 Control register
  $0C constant DMAMUX1_C3CR             \ DMA Multiplexer Channel 3 Control register
  $10 constant DMAMUX1_C4CR             \ DMA Multiplexer Channel 4 Control register
  $14 constant DMAMUX1_C5CR             \ DMA Multiplexer Channel 5 Control register
  $18 constant DMAMUX1_C6CR             \ DMA Multiplexer Channel 6 Control register
  $1C constant DMAMUX1_C7CR             \ DMA Multiplexer Channel 7 Control register
  $20 constant DMAMUX1_C8CR             \ DMA Multiplexer Channel 8 Control register
  $24 constant DMAMUX1_C9CR             \ DMA Multiplexer Channel 9 Control register
  $28 constant DMAMUX1_C10CR            \ DMA Multiplexer Channel 10 Control register
  $2C constant DMAMUX1_C11CR            \ DMA Multiplexer Channel 11 Control register
  $30 constant DMAMUX1_C12CR            \ DMA Multiplexer Channel 12 Control register
  $34 constant DMAMUX1_C13CR            \ DMA Multiplexer Channel 13 Control register
  $38 constant DMAMUX1_C14CR            \ DMA Multiplexer Channel 10 Control register
  $3C constant DMAMUX1_C15CR            \ DMA Multiplexer Channel 10 Control register
  $80 constant DMAMUX1_CSR              \ DMA Multiplexer Channel Status register
  $84 constant DMAMUX1_CCFR             \ DMA Channel Clear Flag Register
  $100 constant DMAMUX1_RG0CR           \ DMA Request Generator 0 Control Register
  $104 constant DMAMUX1_RG1CR           \ DMA Request Generator 1 Control Register
  $108 constant DMAMUX1_RG2CR           \ DMA Request Generator 2 Control Register
  $10C constant DMAMUX1_RG3CR           \ DMA Request Generator 3 Control Register
  $140 constant DMAMUX1_RGSR            \ DMA Request Generator Status Register
  $144 constant DMAMUX1_RGCFR           \ DMA Request Generator Clear Flag Register

: DMAMUX1_DEF ; [then]
