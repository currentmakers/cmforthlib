\
\ @file dmamux.fs
\ @brief DMAMUX address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMAMUX_DEF

  [ifdef] DMAMUX_C0CR_DEF
    \
    \ @brief CxCR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 5] DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.
  [then]


  [ifdef] DMAMUX_C1CR_DEF
    \
    \ @brief CxCR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 5] DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.
  [then]


  [ifdef] DMAMUX_C2CR_DEF
    \
    \ @brief CxCR register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 5] DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.
  [then]


  [ifdef] DMAMUX_C3CR_DEF
    \
    \ @brief CxCR register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 5] DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.
  [then]


  [ifdef] DMAMUX_C4CR_DEF
    \
    \ @brief CxCR register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 5] DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.
  [then]


  [ifdef] DMAMUX_C5CR_DEF
    \
    \ @brief CxCR register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 5] DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.
  [then]


  [ifdef] DMAMUX_C6CR_DEF
    \
    \ @brief CxCR register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 5] DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.
  [then]


  [ifdef] DMAMUX_C7CR_DEF
    \
    \ @brief CxCR register
    \ Address offset: 0x1C
    \ Reset value: 0x    NULL
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 5] DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.
  [then]

  \
  \ @brief DMAMUX address block description
  \
  $00 constant DMAMUX_C0CR              \ CxCR register
  $04 constant DMAMUX_C1CR              \ CxCR register
  $08 constant DMAMUX_C2CR              \ CxCR register
  $0C constant DMAMUX_C3CR              \ CxCR register
  $10 constant DMAMUX_C4CR              \ CxCR register
  $14 constant DMAMUX_C5CR              \ CxCR register
  $18 constant DMAMUX_C6CR              \ CxCR register
  $1C constant DMAMUX_C7CR              \ CxCR register

: DMAMUX_DEF ; [then]
