\
\ @file dmamux.fs
\ @brief Direct memory access Multiplexer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMAMUX_DEF

  [ifdef] DMAMUX_C0CR_DEF
    \
    \ @brief DMA Multiplexer Channel 0 Control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C1CR_DEF
    \
    \ @brief DMA Multiplexer Channel 1 Control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C2CR_DEF
    \
    \ @brief DMA Multiplexer Channel 2 Control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C3CR_DEF
    \
    \ @brief DMA Multiplexer Channel 3 Control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C4CR_DEF
    \
    \ @brief DMA Multiplexer Channel 4 Control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C5CR_DEF
    \
    \ @brief DMA Multiplexer Channel 5 Control register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C6CR_DEF
    \
    \ @brief DMA Multiplexer Channel 6 Control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C7CR_DEF
    \
    \ @brief DMA Multiplexer Channel 7 Control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C8CR_DEF
    \
    \ @brief DMA Multiplexer Channel 8 Control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C9CR_DEF
    \
    \ @brief DMA Multiplexer Channel 9 Control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C10CR_DEF
    \
    \ @brief DMA Multiplexer Channel 10 Control register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C11CR_DEF
    \
    \ @brief DMA Multiplexer Channel 11 Control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C12CR_DEF
    \
    \ @brief DMA Multiplexer Channel 12 Control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_C13CR_DEF
    \
    \ @brief DMA Multiplexer Channel 13 Control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] DMA Request ID
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization Overrun Interrupt Enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event Generation Enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Sync polarity
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Nb request
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] SYNC_ID
  [then]


  [ifdef] DMAMUX_CSR_DEF
    \
    \ @brief DMA Multiplexer Channel Status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SOF0                    \ [0x00] Synchronization Overrun Flag 0
    $01 constant DMAMUX_SOF1                    \ [0x01] Synchronization Overrun Flag 1
    $02 constant DMAMUX_SOF2                    \ [0x02] Synchronization Overrun Flag 2
    $03 constant DMAMUX_SOF3                    \ [0x03] Synchronization Overrun Flag 3
    $04 constant DMAMUX_SOF4                    \ [0x04] Synchronization Overrun Flag 4
    $05 constant DMAMUX_SOF5                    \ [0x05] Synchronization Overrun Flag 5
    $06 constant DMAMUX_SOF6                    \ [0x06] Synchronization Overrun Flag 6
    $07 constant DMAMUX_SOF7                    \ [0x07] Synchronization Overrun Flag 7
    $08 constant DMAMUX_SOF8                    \ [0x08] Synchronization Overrun Flag 8
    $09 constant DMAMUX_SOF9                    \ [0x09] Synchronization Overrun Flag 9
    $0a constant DMAMUX_SOF10                   \ [0x0a] Synchronization Overrun Flag 10
    $0b constant DMAMUX_SOF11                   \ [0x0b] Synchronization Overrun Flag 11
    $0c constant DMAMUX_SOF12                   \ [0x0c] Synchronization Overrun Flag 12
    $0d constant DMAMUX_SOF13                   \ [0x0d] Synchronization Overrun Flag 13
  [then]


  [ifdef] DMAMUX_CFR_DEF
    \
    \ @brief DMA Channel Clear Flag Register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_CSOF0                   \ [0x00] Synchronization Clear Overrun Flag 0
    $01 constant DMAMUX_CSOF1                   \ [0x01] Synchronization Clear Overrun Flag 1
    $02 constant DMAMUX_CSOF2                   \ [0x02] Synchronization Clear Overrun Flag 2
    $03 constant DMAMUX_CSOF3                   \ [0x03] Synchronization Clear Overrun Flag 3
    $04 constant DMAMUX_CSOF4                   \ [0x04] Synchronization Clear Overrun Flag 4
    $05 constant DMAMUX_CSOF5                   \ [0x05] Synchronization Clear Overrun Flag 5
    $06 constant DMAMUX_CSOF6                   \ [0x06] Synchronization Clear Overrun Flag 6
    $07 constant DMAMUX_CSOF7                   \ [0x07] Synchronization Clear Overrun Flag 7
    $08 constant DMAMUX_CSOF8                   \ [0x08] Synchronization Clear Overrun Flag 8
    $09 constant DMAMUX_CSOF9                   \ [0x09] Synchronization Clear Overrun Flag 9
    $0a constant DMAMUX_CSOF10                  \ [0x0a] Synchronization Clear Overrun Flag 10
    $0b constant DMAMUX_CSOF11                  \ [0x0b] Synchronization Clear Overrun Flag 11
    $0c constant DMAMUX_CSOF12                  \ [0x0c] Synchronization Clear Overrun Flag 12
    $0d constant DMAMUX_CSOF13                  \ [0x0d] Synchronization Clear Overrun Flag 13
  [then]


  [ifdef] DMAMUX_RG0CR_DEF
    \
    \ @brief DMA Request Generator 0 Control Register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal ID
    $08 constant DMAMUX_OIE                     \ [0x08] Overrun Interrupt Enable
    $10 constant DMAMUX_GE                      \ [0x10] Generation Enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] Generation Polarity
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of Request
  [then]


  [ifdef] DMAMUX_RG1CR_DEF
    \
    \ @brief DMA Request Generator 1 Control Register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal ID
    $08 constant DMAMUX_OIE                     \ [0x08] Overrun Interrupt Enable
    $10 constant DMAMUX_GE                      \ [0x10] Generation Enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] Generation Polarity
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of Request
  [then]


  [ifdef] DMAMUX_RG2CR_DEF
    \
    \ @brief DMA Request Generator 2 Control Register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal ID
    $08 constant DMAMUX_OIE                     \ [0x08] Overrun Interrupt Enable
    $10 constant DMAMUX_GE                      \ [0x10] Generation Enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] Generation Polarity
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of Request
  [then]


  [ifdef] DMAMUX_RG3CR_DEF
    \
    \ @brief DMA Request Generator 3 Control Register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal ID
    $08 constant DMAMUX_OIE                     \ [0x08] Overrun Interrupt Enable
    $10 constant DMAMUX_GE                      \ [0x10] Generation Enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] Generation Polarity
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of Request
  [then]


  [ifdef] DMAMUX_RGSR_DEF
    \
    \ @brief DMA Request Generator Status Register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_OF0                     \ [0x00] Generator Overrun Flag 0
    $01 constant DMAMUX_OF1                     \ [0x01] Generator Overrun Flag 1
    $02 constant DMAMUX_OF2                     \ [0x02] Generator Overrun Flag 2
    $03 constant DMAMUX_OF3                     \ [0x03] Generator Overrun Flag 3
  [then]


  [ifdef] DMAMUX_RGCFR_DEF
    \
    \ @brief DMA Request Generator Clear Flag Register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_CSOF0                   \ [0x00] Generator Clear Overrun Flag 0
    $01 constant DMAMUX_CSOF1                   \ [0x01] Generator Clear Overrun Flag 1
    $02 constant DMAMUX_CSOF2                   \ [0x02] Generator Clear Overrun Flag 2
    $03 constant DMAMUX_CSOF3                   \ [0x03] Generator Clear Overrun Flag 3
  [then]

  \
  \ @brief Direct memory access Multiplexer
  \
  $00 constant DMAMUX_C0CR              \ DMA Multiplexer Channel 0 Control register
  $04 constant DMAMUX_C1CR              \ DMA Multiplexer Channel 1 Control register
  $08 constant DMAMUX_C2CR              \ DMA Multiplexer Channel 2 Control register
  $0C constant DMAMUX_C3CR              \ DMA Multiplexer Channel 3 Control register
  $10 constant DMAMUX_C4CR              \ DMA Multiplexer Channel 4 Control register
  $14 constant DMAMUX_C5CR              \ DMA Multiplexer Channel 5 Control register
  $18 constant DMAMUX_C6CR              \ DMA Multiplexer Channel 6 Control register
  $1C constant DMAMUX_C7CR              \ DMA Multiplexer Channel 7 Control register
  $20 constant DMAMUX_C8CR              \ DMA Multiplexer Channel 8 Control register
  $24 constant DMAMUX_C9CR              \ DMA Multiplexer Channel 9 Control register
  $28 constant DMAMUX_C10CR             \ DMA Multiplexer Channel 10 Control register
  $2C constant DMAMUX_C11CR             \ DMA Multiplexer Channel 11 Control register
  $30 constant DMAMUX_C12CR             \ DMA Multiplexer Channel 12 Control register
  $34 constant DMAMUX_C13CR             \ DMA Multiplexer Channel 13 Control register
  $80 constant DMAMUX_CSR               \ DMA Multiplexer Channel Status register
  $84 constant DMAMUX_CFR               \ DMA Channel Clear Flag Register
  $100 constant DMAMUX_RG0CR            \ DMA Request Generator 0 Control Register
  $104 constant DMAMUX_RG1CR            \ DMA Request Generator 1 Control Register
  $108 constant DMAMUX_RG2CR            \ DMA Request Generator 2 Control Register
  $10C constant DMAMUX_RG3CR            \ DMA Request Generator 3 Control Register
  $140 constant DMAMUX_RGSR             \ DMA Request Generator Status Register
  $144 constant DMAMUX_RGCFR            \ DMA Request Generator Clear Flag Register

: DMAMUX_DEF ; [then]
