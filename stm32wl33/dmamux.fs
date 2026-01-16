\
\ @file dmamux.fs
\ @brief DMAMUX address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CxCR register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_C0CR_DMAREQ_ID                            \ DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.


\
\ @brief CxCR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_C1CR_DMAREQ_ID                            \ DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.


\
\ @brief CxCR register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_C2CR_DMAREQ_ID                            \ DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.


\
\ @brief CxCR register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_C3CR_DMAREQ_ID                            \ DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.


\
\ @brief CxCR register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_C4CR_DMAREQ_ID                            \ DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.


\
\ @brief CxCR register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_C5CR_DMAREQ_ID                            \ DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.


\
\ @brief CxCR register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_C6CR_DMAREQ_ID                            \ DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.


\
\ @brief CxCR register
\ Address offset: 0x1C
\ Reset value: 0x    NULL
\

$0000001f constant DMAMUX_C7CR_DMAREQ_ID                            \ DMAREQ_ID[4:0]: DMA REQuest IDentification Selects the input DMA request. C.f. the DMAMUX table about assignments of multiplexer inputs to resources.


\
\ @brief DMAMUX address block description
\
$48800000 constant DMAMUX_C0CR    \ offset: 0x00 : CxCR register
$48800004 constant DMAMUX_C1CR    \ offset: 0x04 : CxCR register
$48800008 constant DMAMUX_C2CR    \ offset: 0x08 : CxCR register
$4880000c constant DMAMUX_C3CR    \ offset: 0x0C : CxCR register
$48800010 constant DMAMUX_C4CR    \ offset: 0x10 : CxCR register
$48800014 constant DMAMUX_C5CR    \ offset: 0x14 : CxCR register
$48800018 constant DMAMUX_C6CR    \ offset: 0x18 : CxCR register
$4880001c constant DMAMUX_C7CR    \ offset: 0x1C : CxCR register

