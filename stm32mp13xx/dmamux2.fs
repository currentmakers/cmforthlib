\
\ @file dmamux2.fs
\ @brief DMAMUX2
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMAMUX2_DEF

  [ifdef] DMAMUX2_DMAMUX_C0CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel 0 configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $08 constant DMAMUX2_SOIE                   \ [0x08] SOIE
    $09 constant DMAMUX2_EGE                    \ [0x09] EGE
    $10 constant DMAMUX2_SE                     \ [0x10] SE
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] SPOL
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] NBREQ
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 3] SYNC_ID
  [then]


  [ifdef] DMAMUX2_DMAMUX_C1CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel 1 configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $08 constant DMAMUX2_SOIE                   \ [0x08] SOIE
    $09 constant DMAMUX2_EGE                    \ [0x09] EGE
    $10 constant DMAMUX2_SE                     \ [0x10] SE
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] SPOL
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] NBREQ
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 3] SYNC_ID
  [then]


  [ifdef] DMAMUX2_DMAMUX_C2CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel 2 configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $08 constant DMAMUX2_SOIE                   \ [0x08] SOIE
    $09 constant DMAMUX2_EGE                    \ [0x09] EGE
    $10 constant DMAMUX2_SE                     \ [0x10] SE
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] SPOL
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] NBREQ
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 3] SYNC_ID
  [then]


  [ifdef] DMAMUX2_DMAMUX_C3CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel 3 configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $08 constant DMAMUX2_SOIE                   \ [0x08] SOIE
    $09 constant DMAMUX2_EGE                    \ [0x09] EGE
    $10 constant DMAMUX2_SE                     \ [0x10] SE
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] SPOL
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] NBREQ
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 3] SYNC_ID
  [then]


  [ifdef] DMAMUX2_DMAMUX_C4CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel 4 configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $08 constant DMAMUX2_SOIE                   \ [0x08] SOIE
    $09 constant DMAMUX2_EGE                    \ [0x09] EGE
    $10 constant DMAMUX2_SE                     \ [0x10] SE
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] SPOL
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] NBREQ
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 3] SYNC_ID
  [then]


  [ifdef] DMAMUX2_DMAMUX_C5CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel 5 configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $08 constant DMAMUX2_SOIE                   \ [0x08] SOIE
    $09 constant DMAMUX2_EGE                    \ [0x09] EGE
    $10 constant DMAMUX2_SE                     \ [0x10] SE
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] SPOL
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] NBREQ
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 3] SYNC_ID
  [then]


  [ifdef] DMAMUX2_DMAMUX_C6CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel 6 configuration register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $08 constant DMAMUX2_SOIE                   \ [0x08] SOIE
    $09 constant DMAMUX2_EGE                    \ [0x09] EGE
    $10 constant DMAMUX2_SE                     \ [0x10] SE
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] SPOL
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] NBREQ
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 3] SYNC_ID
  [then]


  [ifdef] DMAMUX2_DMAMUX_C7CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel 7 configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $08 constant DMAMUX2_SOIE                   \ [0x08] SOIE
    $09 constant DMAMUX2_EGE                    \ [0x09] EGE
    $10 constant DMAMUX2_SE                     \ [0x10] SE
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] SPOL
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] NBREQ
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 3] SYNC_ID
  [then]


  [ifdef] DMAMUX2_DMAMUX_CSR_DEF
    \
    \ @brief DMAMUX request line multiplexer interrupt channel status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SOF0                   \ [0x00] SOF0
    $01 constant DMAMUX2_SOF1                   \ [0x01] SOF1
    $02 constant DMAMUX2_SOF2                   \ [0x02] SOF2
    $03 constant DMAMUX2_SOF3                   \ [0x03] SOF3
    $04 constant DMAMUX2_SOF4                   \ [0x04] SOF4
    $05 constant DMAMUX2_SOF5                   \ [0x05] SOF5
    $06 constant DMAMUX2_SOF6                   \ [0x06] SOF6
    $07 constant DMAMUX2_SOF7                   \ [0x07] SOF7
    $08 constant DMAMUX2_SOF8                   \ [0x08] SOF8
    $09 constant DMAMUX2_SOF9                   \ [0x09] SOF9
    $0a constant DMAMUX2_SOF10                  \ [0x0a] SOF10
    $0b constant DMAMUX2_SOF11                  \ [0x0b] SOF11
    $0c constant DMAMUX2_SOF12                  \ [0x0c] SOF12
    $0d constant DMAMUX2_SOF13                  \ [0x0d] SOF13
    $0e constant DMAMUX2_SOF14                  \ [0x0e] SOF14
    $0f constant DMAMUX2_SOF15                  \ [0x0f] SOF15
  [then]


  [ifdef] DMAMUX2_DMAMUX_CFR_DEF
    \
    \ @brief DMAMUX request line multiplexer interrupt clear flag register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_CSOF0                  \ [0x00] CSOF0
    $01 constant DMAMUX2_CSOF1                  \ [0x01] CSOF1
    $02 constant DMAMUX2_CSOF2                  \ [0x02] CSOF2
    $03 constant DMAMUX2_CSOF3                  \ [0x03] CSOF3
    $04 constant DMAMUX2_CSOF4                  \ [0x04] CSOF4
    $05 constant DMAMUX2_CSOF5                  \ [0x05] CSOF5
    $06 constant DMAMUX2_CSOF6                  \ [0x06] CSOF6
    $07 constant DMAMUX2_CSOF7                  \ [0x07] CSOF7
    $08 constant DMAMUX2_CSOF8                  \ [0x08] CSOF8
    $09 constant DMAMUX2_CSOF9                  \ [0x09] CSOF9
    $0a constant DMAMUX2_CSOF10                 \ [0x0a] CSOF10
    $0b constant DMAMUX2_CSOF11                 \ [0x0b] CSOF11
    $0c constant DMAMUX2_CSOF12                 \ [0x0c] CSOF12
    $0d constant DMAMUX2_CSOF13                 \ [0x0d] CSOF13
    $0e constant DMAMUX2_CSOF14                 \ [0x0e] CSOF14
    $0f constant DMAMUX2_CSOF15                 \ [0x0f] CSOF15
  [then]


  [ifdef] DMAMUX2_DMAMUX_RG0CR_DEF
    \
    \ @brief DMAMUX request generator channel 0 configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 3] SIG_ID
    $08 constant DMAMUX2_OIE                    \ [0x08] OIE
    $10 constant DMAMUX2_GE                     \ [0x10] GE
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] GPOL
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] GNBREQ
  [then]


  [ifdef] DMAMUX2_DMAMUX_RG1CR_DEF
    \
    \ @brief DMAMUX request generator channel 1 configuration register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 3] SIG_ID
    $08 constant DMAMUX2_OIE                    \ [0x08] OIE
    $10 constant DMAMUX2_GE                     \ [0x10] GE
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] GPOL
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] GNBREQ
  [then]


  [ifdef] DMAMUX2_DMAMUX_RG2CR_DEF
    \
    \ @brief DMAMUX request generator channel 2 configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 3] SIG_ID
    $08 constant DMAMUX2_OIE                    \ [0x08] OIE
    $10 constant DMAMUX2_GE                     \ [0x10] GE
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] GPOL
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] GNBREQ
  [then]


  [ifdef] DMAMUX2_DMAMUX_RG3CR_DEF
    \
    \ @brief DMAMUX request generator channel 3 configuration register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 3] SIG_ID
    $08 constant DMAMUX2_OIE                    \ [0x08] OIE
    $10 constant DMAMUX2_GE                     \ [0x10] GE
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] GPOL
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] GNBREQ
  [then]


  [ifdef] DMAMUX2_DMAMUX_RG4CR_DEF
    \
    \ @brief DMAMUX request generator channel 4 configuration register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 3] SIG_ID
    $08 constant DMAMUX2_OIE                    \ [0x08] OIE
    $10 constant DMAMUX2_GE                     \ [0x10] GE
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] GPOL
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] GNBREQ
  [then]


  [ifdef] DMAMUX2_DMAMUX_RG5CR_DEF
    \
    \ @brief DMAMUX request generator channel 5 configuration register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 3] SIG_ID
    $08 constant DMAMUX2_OIE                    \ [0x08] OIE
    $10 constant DMAMUX2_GE                     \ [0x10] GE
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] GPOL
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] GNBREQ
  [then]


  [ifdef] DMAMUX2_DMAMUX_RG6CR_DEF
    \
    \ @brief DMAMUX request generator channel 6 configuration register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 3] SIG_ID
    $08 constant DMAMUX2_OIE                    \ [0x08] OIE
    $10 constant DMAMUX2_GE                     \ [0x10] GE
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] GPOL
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] GNBREQ
  [then]


  [ifdef] DMAMUX2_DMAMUX_RG7CR_DEF
    \
    \ @brief DMAMUX request generator channel 7 configuration register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 3] SIG_ID
    $08 constant DMAMUX2_OIE                    \ [0x08] OIE
    $10 constant DMAMUX2_GE                     \ [0x10] GE
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] GPOL
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] GNBREQ
  [then]


  [ifdef] DMAMUX2_DMAMUX_RGSR_DEF
    \
    \ @brief DMAMUX request generator interrupt status register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_OF0                    \ [0x00] OF0
    $01 constant DMAMUX2_OF1                    \ [0x01] OF1
    $02 constant DMAMUX2_OF2                    \ [0x02] OF2
    $03 constant DMAMUX2_OF3                    \ [0x03] OF3
    $04 constant DMAMUX2_OF4                    \ [0x04] OF4
    $05 constant DMAMUX2_OF5                    \ [0x05] OF5
    $06 constant DMAMUX2_OF6                    \ [0x06] OF6
    $07 constant DMAMUX2_OF7                    \ [0x07] OF7
  [then]


  [ifdef] DMAMUX2_DMAMUX_RGCFR_DEF
    \
    \ @brief DMAMUX request generator interrupt clear flag register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_COF0                   \ [0x00] COF0
    $01 constant DMAMUX2_COF1                   \ [0x01] COF1
    $02 constant DMAMUX2_COF2                   \ [0x02] COF2
    $03 constant DMAMUX2_COF3                   \ [0x03] COF3
    $04 constant DMAMUX2_COF4                   \ [0x04] COF4
    $05 constant DMAMUX2_COF5                   \ [0x05] COF5
    $06 constant DMAMUX2_COF6                   \ [0x06] COF6
    $07 constant DMAMUX2_COF7                   \ [0x07] COF7
  [then]


  [ifdef] DMAMUX2_DMAMUX_HWCFGR2_DEF
    \
    \ @brief DMAMUX hardware configuration 2 register
    \ Address offset: 0x3EC
    \ Reset value: 0x00000008
    \
    $00 constant DMAMUX2_NUM_DMA_EXT_REQ        \ [0x00 : 8] NUM_DMA_EXT_REQ
  [then]


  [ifdef] DMAMUX2_DMAMUX_HWCFGR1_DEF
    \
    \ @brief DMAMUX hardware configuration 1 register
    \ Address offset: 0x3F0
    \ Reset value: 0x08086C10
    \
    $00 constant DMAMUX2_NUM_DMA_STREAMS        \ [0x00 : 8] NUM_DMA_STREAMS
    $08 constant DMAMUX2_NUM_DMA_PERIPH_REQ     \ [0x08 : 8] NUM_DMA_PERIPH_REQ
    $10 constant DMAMUX2_NUM_DMA_TRIG           \ [0x10 : 8] NUM_DMA_TRIG
    $18 constant DMAMUX2_NUM_DMA_REQGEN         \ [0x18 : 8] NUM_DMA_REQGEN
  [then]


  [ifdef] DMAMUX2_DMAMUX_VERR_DEF
    \
    \ @brief This register identifies the IP version.
    \ Address offset: 0x3F4
    \ Reset value: 0x00000011
    \
    $00 constant DMAMUX2_MINREV                 \ [0x00 : 4] MINREV
    $04 constant DMAMUX2_MAJREV                 \ [0x04 : 4] MAJREV
  [then]


  [ifdef] DMAMUX2_DMAMUX_IPIDR_DEF
    \
    \ @brief This register identifies the IP.
    \ Address offset: 0x3F8
    \ Reset value: 0x00100011
    \
    $00 constant DMAMUX2_ID                     \ [0x00 : 32] ID
  [then]


  [ifdef] DMAMUX2_DMAMUX_SIDR_DEF
    \
    \ @brief DMAMUX size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant DMAMUX2_SID                    \ [0x00 : 32] SID
  [then]

  \
  \ @brief DMAMUX2
  \
  $00 constant DMAMUX2_DMAMUX_C0CR      \ DMAMUX request line multiplexer channel 0 configuration register
  $04 constant DMAMUX2_DMAMUX_C1CR      \ DMAMUX request line multiplexer channel 1 configuration register
  $08 constant DMAMUX2_DMAMUX_C2CR      \ DMAMUX request line multiplexer channel 2 configuration register
  $0C constant DMAMUX2_DMAMUX_C3CR      \ DMAMUX request line multiplexer channel 3 configuration register
  $10 constant DMAMUX2_DMAMUX_C4CR      \ DMAMUX request line multiplexer channel 4 configuration register
  $14 constant DMAMUX2_DMAMUX_C5CR      \ DMAMUX request line multiplexer channel 5 configuration register
  $18 constant DMAMUX2_DMAMUX_C6CR      \ DMAMUX request line multiplexer channel 6 configuration register
  $1C constant DMAMUX2_DMAMUX_C7CR      \ DMAMUX request line multiplexer channel 7 configuration register
  $80 constant DMAMUX2_DMAMUX_CSR       \ DMAMUX request line multiplexer interrupt channel status register
  $84 constant DMAMUX2_DMAMUX_CFR       \ DMAMUX request line multiplexer interrupt clear flag register
  $100 constant DMAMUX2_DMAMUX_RG0CR    \ DMAMUX request generator channel 0 configuration register
  $104 constant DMAMUX2_DMAMUX_RG1CR    \ DMAMUX request generator channel 1 configuration register
  $108 constant DMAMUX2_DMAMUX_RG2CR    \ DMAMUX request generator channel 2 configuration register
  $10C constant DMAMUX2_DMAMUX_RG3CR    \ DMAMUX request generator channel 3 configuration register
  $110 constant DMAMUX2_DMAMUX_RG4CR    \ DMAMUX request generator channel 4 configuration register
  $114 constant DMAMUX2_DMAMUX_RG5CR    \ DMAMUX request generator channel 5 configuration register
  $118 constant DMAMUX2_DMAMUX_RG6CR    \ DMAMUX request generator channel 6 configuration register
  $11C constant DMAMUX2_DMAMUX_RG7CR    \ DMAMUX request generator channel 7 configuration register
  $140 constant DMAMUX2_DMAMUX_RGSR     \ DMAMUX request generator interrupt status register
  $144 constant DMAMUX2_DMAMUX_RGCFR    \ DMAMUX request generator interrupt clear flag register
  $3EC constant DMAMUX2_DMAMUX_HWCFGR2  \ DMAMUX hardware configuration 2 register
  $3F0 constant DMAMUX2_DMAMUX_HWCFGR1  \ DMAMUX hardware configuration 1 register
  $3F4 constant DMAMUX2_DMAMUX_VERR     \ This register identifies the IP version.
  $3F8 constant DMAMUX2_DMAMUX_IPIDR    \ This register identifies the IP.
  $3FC constant DMAMUX2_DMAMUX_SIDR     \ DMAMUX size identification register

: DMAMUX2_DEF ; [then]
