\
\ @file dmamux.fs
\ @brief DMA request multiplexer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief request line multiplexer channel x configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C0CR_DMAREQ_ID                            \ DMA request identification
$00000100 constant DMAMUX_C0CR_SOIE                                 \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_C0CR_EGE                                  \ Event generation enable
$00010000 constant DMAMUX_C0CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C0CR_SPOL                                 \ Synchronization polarity
$00f80000 constant DMAMUX_C0CR_NBREQ                                \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX_C0CR_SYNC_ID                              \ Synchronization identification


\
\ @brief request line multiplexer channel x configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C1CR_DMAREQ_ID                            \ DMA request identification
$00000100 constant DMAMUX_C1CR_SOIE                                 \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_C1CR_EGE                                  \ Event generation enable
$00010000 constant DMAMUX_C1CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C1CR_SPOL                                 \ Synchronization polarity
$00f80000 constant DMAMUX_C1CR_NBREQ                                \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX_C1CR_SYNC_ID                              \ Synchronization identification


\
\ @brief request line multiplexer channel x configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C2CR_DMAREQ_ID                            \ DMA request identification
$00000100 constant DMAMUX_C2CR_SOIE                                 \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_C2CR_EGE                                  \ Event generation enable
$00010000 constant DMAMUX_C2CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C2CR_SPOL                                 \ Synchronization polarity
$00f80000 constant DMAMUX_C2CR_NBREQ                                \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX_C2CR_SYNC_ID                              \ Synchronization identification


\
\ @brief request line multiplexer channel x configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C3CR_DMAREQ_ID                            \ DMA request identification
$00000100 constant DMAMUX_C3CR_SOIE                                 \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_C3CR_EGE                                  \ Event generation enable
$00010000 constant DMAMUX_C3CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C3CR_SPOL                                 \ Synchronization polarity
$00f80000 constant DMAMUX_C3CR_NBREQ                                \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX_C3CR_SYNC_ID                              \ Synchronization identification


\
\ @brief request line multiplexer channel x configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C4CR_DMAREQ_ID                            \ DMA request identification
$00000100 constant DMAMUX_C4CR_SOIE                                 \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_C4CR_EGE                                  \ Event generation enable
$00010000 constant DMAMUX_C4CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C4CR_SPOL                                 \ Synchronization polarity
$00f80000 constant DMAMUX_C4CR_NBREQ                                \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX_C4CR_SYNC_ID                              \ Synchronization identification


\
\ @brief request line multiplexer channel x configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C5CR_DMAREQ_ID                            \ DMA request identification
$00000100 constant DMAMUX_C5CR_SOIE                                 \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_C5CR_EGE                                  \ Event generation enable
$00010000 constant DMAMUX_C5CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C5CR_SPOL                                 \ Synchronization polarity
$00f80000 constant DMAMUX_C5CR_NBREQ                                \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX_C5CR_SYNC_ID                              \ Synchronization identification


\
\ @brief request line multiplexer channel x configuration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C6CR_DMAREQ_ID                            \ DMA request identification
$00000100 constant DMAMUX_C6CR_SOIE                                 \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_C6CR_EGE                                  \ Event generation enable
$00010000 constant DMAMUX_C6CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C6CR_SPOL                                 \ Synchronization polarity
$00f80000 constant DMAMUX_C6CR_NBREQ                                \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX_C6CR_SYNC_ID                              \ Synchronization identification


\
\ @brief request line multiplexer channel x configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C7CR_DMAREQ_ID                            \ DMA request identification
$00000100 constant DMAMUX_C7CR_SOIE                                 \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_C7CR_EGE                                  \ Event generation enable
$00010000 constant DMAMUX_C7CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C7CR_SPOL                                 \ Synchronization polarity
$00f80000 constant DMAMUX_C7CR_NBREQ                                \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX_C7CR_SYNC_ID                              \ Synchronization identification


\
\ @brief request line multiplexer channel x configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C8CR_DMAREQ_ID                            \ DMA request identification
$00000100 constant DMAMUX_C8CR_SOIE                                 \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_C8CR_EGE                                  \ Event generation enable
$00010000 constant DMAMUX_C8CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C8CR_SPOL                                 \ Synchronization polarity
$00f80000 constant DMAMUX_C8CR_NBREQ                                \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX_C8CR_SYNC_ID                              \ Synchronization identification


\
\ @brief request line multiplexer channel x configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C9CR_DMAREQ_ID                            \ DMA request identification
$00000100 constant DMAMUX_C9CR_SOIE                                 \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_C9CR_EGE                                  \ Event generation enable
$00010000 constant DMAMUX_C9CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C9CR_SPOL                                 \ Synchronization polarity
$00f80000 constant DMAMUX_C9CR_NBREQ                                \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX_C9CR_SYNC_ID                              \ Synchronization identification


\
\ @brief C10CR
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C10CR_DMAREQ_ID                           \ DMAREQ_ID
$00000100 constant DMAMUX_C10CR_SOIE                                \ SOIE
$00000200 constant DMAMUX_C10CR_EGE                                 \ EGE
$00010000 constant DMAMUX_C10CR_SE                                  \ SE
$00060000 constant DMAMUX_C10CR_SPOL                                \ SPOL
$00f80000 constant DMAMUX_C10CR_NBREQ                               \ NBREQ
$1f000000 constant DMAMUX_C10CR_SYNC_ID                             \ SYNC_ID


\
\ @brief C11CR
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C11CR_DMAREQ_ID                           \ DMAREQ_ID
$00000100 constant DMAMUX_C11CR_SOIE                                \ SOIE
$00000200 constant DMAMUX_C11CR_EGE                                 \ EGE
$00010000 constant DMAMUX_C11CR_SE                                  \ SE
$00060000 constant DMAMUX_C11CR_SPOL                                \ SPOL
$00f80000 constant DMAMUX_C11CR_NBREQ                               \ NBREQ
$1f000000 constant DMAMUX_C11CR_SYNC_ID                             \ SYNC_ID


\
\ @brief C12CR
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C12CR_DMAREQ_ID                           \ DMAREQ_ID
$00000100 constant DMAMUX_C12CR_SOIE                                \ SOIE
$00000200 constant DMAMUX_C12CR_EGE                                 \ EGE
$00010000 constant DMAMUX_C12CR_SE                                  \ SE
$00060000 constant DMAMUX_C12CR_SPOL                                \ SPOL
$00f80000 constant DMAMUX_C12CR_NBREQ                               \ NBREQ
$1f000000 constant DMAMUX_C12CR_SYNC_ID                             \ SYNC_ID


\
\ @brief C13CR
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C13CR_DMAREQ_ID                           \ DMAREQ_ID
$00000100 constant DMAMUX_C13CR_SOIE                                \ SOIE
$00000200 constant DMAMUX_C13CR_EGE                                 \ EGE
$00010000 constant DMAMUX_C13CR_SE                                  \ SE
$00060000 constant DMAMUX_C13CR_SPOL                                \ SPOL
$00f80000 constant DMAMUX_C13CR_NBREQ                               \ NBREQ
$1f000000 constant DMAMUX_C13CR_SYNC_ID                             \ SYNC_ID


\
\ @brief request line multiplexer interrupt channel status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_CSR_SOF0                                  \ SOF0
$00000002 constant DMAMUX_CSR_SOF1                                  \ SOF1
$00000004 constant DMAMUX_CSR_SOF2                                  \ SOF2
$00000008 constant DMAMUX_CSR_SOF3                                  \ SOF3
$00000010 constant DMAMUX_CSR_SOF4                                  \ SOF4
$00000020 constant DMAMUX_CSR_SOF5                                  \ SOF5
$00000040 constant DMAMUX_CSR_SOF6                                  \ SOF6
$00000080 constant DMAMUX_CSR_SOF7                                  \ SOF7
$00000100 constant DMAMUX_CSR_SOF8                                  \ SOF8
$00000200 constant DMAMUX_CSR_SOF9                                  \ SOF9
$00000400 constant DMAMUX_CSR_SOF10                                 \ SOF10
$00000800 constant DMAMUX_CSR_SOF11                                 \ SOF11
$00001000 constant DMAMUX_CSR_SOF12                                 \ SOF12
$00002000 constant DMAMUX_CSR_SOF13                                 \ Synchronization overrun event flag


\
\ @brief request line multiplexer interrupt channel clear flag register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_CCFR_CSOF0                                \ CSOF0
$00000002 constant DMAMUX_CCFR_CSOF1                                \ CSOF1
$00000004 constant DMAMUX_CCFR_CSOF2                                \ CSOF2
$00000008 constant DMAMUX_CCFR_CSOF3                                \ CSOF3
$00000010 constant DMAMUX_CCFR_CSOF4                                \ CSOF4
$00000020 constant DMAMUX_CCFR_CSOF5                                \ CSOF5
$00000040 constant DMAMUX_CCFR_CSOF6                                \ CSOF6
$00000080 constant DMAMUX_CCFR_CSOF7                                \ CSOF7
$00000100 constant DMAMUX_CCFR_CSOF8                                \ CSOF8
$00000200 constant DMAMUX_CCFR_CSOF9                                \ CSOF9
$00000400 constant DMAMUX_CCFR_CSOF10                               \ CSOF10
$00000800 constant DMAMUX_CCFR_CSOF11                               \ CSOF11
$00001000 constant DMAMUX_CCFR_CSOF12                               \ CSOF12
$00002000 constant DMAMUX_CCFR_CSOF13                               \ CSOF13


\
\ @brief request generator channel x configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG0CR_SIG_ID                              \ Signal identification
$00000100 constant DMAMUX_RG0CR_OIE                                 \ Trigger overrun interrupt enable
$00010000 constant DMAMUX_RG0CR_GE                                  \ DMA request generator channel x enable
$00060000 constant DMAMUX_RG0CR_GPOL                                \ DMA request generator trigger polarity
$00f80000 constant DMAMUX_RG0CR_GNBREQ                              \ Number of DMA requests to be generated (minus 1)


\
\ @brief request generator channel x configuration register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG1CR_SIG_ID                              \ Signal identification
$00000100 constant DMAMUX_RG1CR_OIE                                 \ Trigger overrun interrupt enable
$00010000 constant DMAMUX_RG1CR_GE                                  \ DMA request generator channel x enable
$00060000 constant DMAMUX_RG1CR_GPOL                                \ DMA request generator trigger polarity
$00f80000 constant DMAMUX_RG1CR_GNBREQ                              \ Number of DMA requests to be generated (minus 1)


\
\ @brief request generator channel x configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG2CR_SIG_ID                              \ Signal identification
$00000100 constant DMAMUX_RG2CR_OIE                                 \ Trigger overrun interrupt enable
$00010000 constant DMAMUX_RG2CR_GE                                  \ DMA request generator channel x enable
$00060000 constant DMAMUX_RG2CR_GPOL                                \ DMA request generator trigger polarity
$00f80000 constant DMAMUX_RG2CR_GNBREQ                              \ Number of DMA requests to be generated (minus 1)


\
\ @brief request generator channel x configuration register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG3CR_SIG_ID                              \ Signal identification
$00000100 constant DMAMUX_RG3CR_OIE                                 \ Trigger overrun interrupt enable
$00010000 constant DMAMUX_RG3CR_GE                                  \ DMA request generator channel x enable
$00060000 constant DMAMUX_RG3CR_GPOL                                \ DMA request generator trigger polarity
$00f80000 constant DMAMUX_RG3CR_GNBREQ                              \ Number of DMA requests to be generated (minus 1)


\
\ @brief request generator interrupt status register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_RGSR_OF0                                  \ OF0
$00000002 constant DMAMUX_RGSR_OF1                                  \ OF1
$00000004 constant DMAMUX_RGSR_OF2                                  \ OF2
$00000008 constant DMAMUX_RGSR_OF3                                  \ Trigger overrun event flag


\
\ @brief request generator interrupt clear flag register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_RGCFR_COF0                                \ COF0
$00000002 constant DMAMUX_RGCFR_COF1                                \ COF1
$00000004 constant DMAMUX_RGCFR_COF2                                \ COF2
$00000008 constant DMAMUX_RGCFR_COF3                                \ Clear trigger overrun event flag


\
\ @brief DMA request multiplexer
\
$40020800 constant DMAMUX_C0CR    \ offset: 0x00 : request line multiplexer channel x configuration register
$40020804 constant DMAMUX_C1CR    \ offset: 0x04 : request line multiplexer channel x configuration register
$40020808 constant DMAMUX_C2CR    \ offset: 0x08 : request line multiplexer channel x configuration register
$4002080c constant DMAMUX_C3CR    \ offset: 0x0C : request line multiplexer channel x configuration register
$40020810 constant DMAMUX_C4CR    \ offset: 0x10 : request line multiplexer channel x configuration register
$40020814 constant DMAMUX_C5CR    \ offset: 0x14 : request line multiplexer channel x configuration register
$40020818 constant DMAMUX_C6CR    \ offset: 0x18 : request line multiplexer channel x configuration register
$4002081c constant DMAMUX_C7CR    \ offset: 0x1C : request line multiplexer channel x configuration register
$40020820 constant DMAMUX_C8CR    \ offset: 0x20 : request line multiplexer channel x configuration register
$40020824 constant DMAMUX_C9CR    \ offset: 0x24 : request line multiplexer channel x configuration register
$40020828 constant DMAMUX_C10CR   \ offset: 0x28 : C10CR
$4002082c constant DMAMUX_C11CR   \ offset: 0x2C : C11CR
$40020830 constant DMAMUX_C12CR   \ offset: 0x30 : C12CR
$40020834 constant DMAMUX_C13CR   \ offset: 0x34 : C13CR
$40020880 constant DMAMUX_CSR     \ offset: 0x80 : request line multiplexer interrupt channel status register
$40020884 constant DMAMUX_CCFR    \ offset: 0x84 : request line multiplexer interrupt channel clear flag register
$40020900 constant DMAMUX_RG0CR   \ offset: 0x100 : request generator channel x configuration register
$40020904 constant DMAMUX_RG1CR   \ offset: 0x104 : request generator channel x configuration register
$40020908 constant DMAMUX_RG2CR   \ offset: 0x108 : request generator channel x configuration register
$4002090c constant DMAMUX_RG3CR   \ offset: 0x10C : request generator channel x configuration register
$40020940 constant DMAMUX_RGSR    \ offset: 0x140 : request generator interrupt status register
$40020944 constant DMAMUX_RGCFR   \ offset: 0x144 : request generator interrupt clear flag register

