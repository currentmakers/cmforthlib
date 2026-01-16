\
\ @file dmamux1.fs
\ @brief DMA request multiplexer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief channel 0 configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C0CR_DMAREQ_ID                           \ DMA request identification
$00000100 constant DMAMUX1_C0CR_SOIE                                \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C0CR_EGE                                 \ Event generation enable
$00010000 constant DMAMUX1_C0CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C0CR_SPOL                                \ Synchronization polarity
$00f80000 constant DMAMUX1_C0CR_NBREQ                               \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C0CR_SYNC_ID                             \ Synchronization identification


\
\ @brief channel 1 configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C1CR_DMAREQ_ID                           \ DMA request identification
$00000100 constant DMAMUX1_C1CR_SOIE                                \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C1CR_EGE                                 \ Event generation enable
$00010000 constant DMAMUX1_C1CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C1CR_SPOL                                \ Synchronization polarity
$00f80000 constant DMAMUX1_C1CR_NBREQ                               \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C1CR_SYNC_ID                             \ Synchronization identification


\
\ @brief channel 2 configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C2CR_DMAREQ_ID                           \ DMA request identification
$00000100 constant DMAMUX1_C2CR_SOIE                                \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C2CR_EGE                                 \ Event generation enable
$00010000 constant DMAMUX1_C2CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C2CR_SPOL                                \ Synchronization polarity
$00f80000 constant DMAMUX1_C2CR_NBREQ                               \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C2CR_SYNC_ID                             \ Synchronization identification


\
\ @brief channel 3 configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C3CR_DMAREQ_ID                           \ DMA request identification
$00000100 constant DMAMUX1_C3CR_SOIE                                \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C3CR_EGE                                 \ Event generation enable
$00010000 constant DMAMUX1_C3CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C3CR_SPOL                                \ Synchronization polarity
$00f80000 constant DMAMUX1_C3CR_NBREQ                               \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C3CR_SYNC_ID                             \ Synchronization identification


\
\ @brief channel 4 configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C4CR_DMAREQ_ID                           \ DMA request identification
$00000100 constant DMAMUX1_C4CR_SOIE                                \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C4CR_EGE                                 \ Event generation enable
$00010000 constant DMAMUX1_C4CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C4CR_SPOL                                \ Synchronization polarity
$00f80000 constant DMAMUX1_C4CR_NBREQ                               \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C4CR_SYNC_ID                             \ Synchronization identification


\
\ @brief channel 5 configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C5CR_DMAREQ_ID                           \ DMA request identification
$00000100 constant DMAMUX1_C5CR_SOIE                                \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C5CR_EGE                                 \ Event generation enable
$00010000 constant DMAMUX1_C5CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C5CR_SPOL                                \ Synchronization polarity
$00f80000 constant DMAMUX1_C5CR_NBREQ                               \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C5CR_SYNC_ID                             \ Synchronization identification


\
\ @brief channel 6 configuration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C6CR_DMAREQ_ID                           \ DMA request identification
$00000100 constant DMAMUX1_C6CR_SOIE                                \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C6CR_EGE                                 \ Event generation enable
$00010000 constant DMAMUX1_C6CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C6CR_SPOL                                \ Synchronization polarity
$00f80000 constant DMAMUX1_C6CR_NBREQ                               \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C6CR_SYNC_ID                             \ Synchronization identification


\
\ @brief channel 7 configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C7CR_DMAREQ_ID                           \ DMA request identification
$00000100 constant DMAMUX1_C7CR_SOIE                                \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C7CR_EGE                                 \ Event generation enable
$00010000 constant DMAMUX1_C7CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C7CR_SPOL                                \ Synchronization polarity
$00f80000 constant DMAMUX1_C7CR_NBREQ                               \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C7CR_SYNC_ID                             \ Synchronization identification


\
\ @brief channel 8 configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C8CR_DMAREQ_ID                           \ DMA request identification
$00000100 constant DMAMUX1_C8CR_SOIE                                \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C8CR_EGE                                 \ Event generation enable
$00010000 constant DMAMUX1_C8CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C8CR_SPOL                                \ Synchronization polarity
$00f80000 constant DMAMUX1_C8CR_NBREQ                               \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C8CR_SYNC_ID                             \ Synchronization identification


\
\ @brief channel 9 configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C9CR_DMAREQ_ID                           \ DMA request identification
$00000100 constant DMAMUX1_C9CR_SOIE                                \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C9CR_EGE                                 \ Event generation enable
$00010000 constant DMAMUX1_C9CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C9CR_SPOL                                \ Synchronization polarity
$00f80000 constant DMAMUX1_C9CR_NBREQ                               \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C9CR_SYNC_ID                             \ Synchronization identification


\
\ @brief channel 10 configuration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C10CR_DMAREQ_ID                          \ DMA request identification
$00000100 constant DMAMUX1_C10CR_SOIE                               \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C10CR_EGE                                \ Event generation enable
$00010000 constant DMAMUX1_C10CR_SE                                 \ Synchronization enable
$00060000 constant DMAMUX1_C10CR_SPOL                               \ Synchronization polarity
$00f80000 constant DMAMUX1_C10CR_NBREQ                              \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C10CR_SYNC_ID                            \ Synchronization identification


\
\ @brief channel 11 configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C11CR_DMAREQ_ID                          \ DMA request identification
$00000100 constant DMAMUX1_C11CR_SOIE                               \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C11CR_EGE                                \ Event generation enable
$00010000 constant DMAMUX1_C11CR_SE                                 \ Synchronization enable
$00060000 constant DMAMUX1_C11CR_SPOL                               \ Synchronization polarity
$00f80000 constant DMAMUX1_C11CR_NBREQ                              \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C11CR_SYNC_ID                            \ Synchronization identification


\
\ @brief channel 12 configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C12CR_DMAREQ_ID                          \ DMA request identification
$00000100 constant DMAMUX1_C12CR_SOIE                               \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C12CR_EGE                                \ Event generation enable
$00010000 constant DMAMUX1_C12CR_SE                                 \ Synchronization enable
$00060000 constant DMAMUX1_C12CR_SPOL                               \ Synchronization polarity
$00f80000 constant DMAMUX1_C12CR_NBREQ                              \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C12CR_SYNC_ID                            \ Synchronization identification


\
\ @brief channel 13 configuration register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C13CR_DMAREQ_ID                          \ DMA request identification
$00000100 constant DMAMUX1_C13CR_SOIE                               \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C13CR_EGE                                \ Event generation enable
$00010000 constant DMAMUX1_C13CR_SE                                 \ Synchronization enable
$00060000 constant DMAMUX1_C13CR_SPOL                               \ Synchronization polarity
$00f80000 constant DMAMUX1_C13CR_NBREQ                              \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C13CR_SYNC_ID                            \ Synchronization identification


\
\ @brief channel status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_CSR_SOF0                                 \ Synchronization overrun event flag
$00000002 constant DMAMUX1_CSR_SOF1                                 \ Synchronization overrun event flag
$00000004 constant DMAMUX1_CSR_SOF2                                 \ Synchronization overrun event flag
$00000008 constant DMAMUX1_CSR_SOF3                                 \ Synchronization overrun event flag
$00000010 constant DMAMUX1_CSR_SOF4                                 \ Synchronization overrun event flag
$00000020 constant DMAMUX1_CSR_SOF5                                 \ Synchronization overrun event flag
$00000040 constant DMAMUX1_CSR_SOF6                                 \ Synchronization overrun event flag
$00000080 constant DMAMUX1_CSR_SOF7                                 \ Synchronization overrun event flag
$00000100 constant DMAMUX1_CSR_SOF8                                 \ Synchronization overrun event flag
$00000200 constant DMAMUX1_CSR_SOF9                                 \ Synchronization overrun event flag
$00000400 constant DMAMUX1_CSR_SOF10                                \ Synchronization overrun event flag
$00000800 constant DMAMUX1_CSR_SOF11                                \ Synchronization overrun event flag
$00001000 constant DMAMUX1_CSR_SOF12                                \ Synchronization overrun event flag
$00002000 constant DMAMUX1_CSR_SOF13                                \ Synchronization overrun event flag


\
\ @brief clear flag register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_CFR_CSOF0                                \ Clear synchronization overrun event flag
$00000002 constant DMAMUX1_CFR_CSOF1                                \ Clear synchronization overrun event flag
$00000004 constant DMAMUX1_CFR_CSOF2                                \ Clear synchronization overrun event flag
$00000008 constant DMAMUX1_CFR_CSOF3                                \ Clear synchronization overrun event flag
$00000010 constant DMAMUX1_CFR_CSOF4                                \ Clear synchronization overrun event flag
$00000020 constant DMAMUX1_CFR_CSOF5                                \ Clear synchronization overrun event flag
$00000040 constant DMAMUX1_CFR_CSOF6                                \ Clear synchronization overrun event flag
$00000080 constant DMAMUX1_CFR_CSOF7                                \ Clear synchronization overrun event flag
$00000100 constant DMAMUX1_CFR_CSOF8                                \ Clear synchronization overrun event flag
$00000200 constant DMAMUX1_CFR_CSOF9                                \ Clear synchronization overrun event flag
$00000400 constant DMAMUX1_CFR_CSOF10                               \ Clear synchronization overrun event flag
$00000800 constant DMAMUX1_CFR_CSOF11                               \ Clear synchronization overrun event flag
$00001000 constant DMAMUX1_CFR_CSOF12                               \ Clear synchronization overrun event flag
$00002000 constant DMAMUX1_CFR_CSOF13                               \ Clear synchronization overrun event flag


\
\ @brief request generator channel 0 configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX1_RG0CR_SIG_ID                             \ Signal identification
$00000100 constant DMAMUX1_RG0CR_OIE                                \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_RG0CR_GE                                 \ DMA request generator channel 0 enable
$00060000 constant DMAMUX1_RG0CR_GPOL                               \ DMA request generator trigger polarity
$00f80000 constant DMAMUX1_RG0CR_GNBREQ                             \ Number of DMA requests to be generated minus 1


\
\ @brief request generator channel 1 configuration register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX1_RG1CR_SIG_ID                             \ Signal identification
$00000100 constant DMAMUX1_RG1CR_OIE                                \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_RG1CR_GE                                 \ DMA request generator channel 1 enable
$00060000 constant DMAMUX1_RG1CR_GPOL                               \ DMA request generator trigger polarity
$00f80000 constant DMAMUX1_RG1CR_GNBREQ                             \ Number of DMA requests to be generated minus 1


\
\ @brief request generator channel 2 configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX1_RG2CR_SIG_ID                             \ Signal identification
$00000100 constant DMAMUX1_RG2CR_OIE                                \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_RG2CR_GE                                 \ DMA request generator channel 2 enable
$00060000 constant DMAMUX1_RG2CR_GPOL                               \ DMA request generator trigger polarity
$00f80000 constant DMAMUX1_RG2CR_GNBREQ                             \ Number of DMA requests to be generated minus 1


\
\ @brief request generator channel 3 configuration register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX1_RG3CR_SIG_ID                             \ Signal identification
$00000100 constant DMAMUX1_RG3CR_OIE                                \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_RG3CR_GE                                 \ DMA request generator channel 3 enable
$00060000 constant DMAMUX1_RG3CR_GPOL                               \ DMA request generator trigger polarity
$00f80000 constant DMAMUX1_RG3CR_GNBREQ                             \ Number of DMA requests to be generated minus 1


\
\ @brief request generator interrupt status register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_RGSR_OF0                                 \ Trigger overrun event flag
$00000002 constant DMAMUX1_RGSR_OF1                                 \ Trigger overrun event flag
$00000004 constant DMAMUX1_RGSR_OF2                                 \ Trigger overrun event flag
$00000008 constant DMAMUX1_RGSR_OF3                                 \ Trigger overrun event flag


\
\ @brief request generator interrupt clear flag register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_RGCFR_COF0                               \ Clear trigger overrun event flag
$00000002 constant DMAMUX1_RGCFR_COF1                               \ Clear trigger overrun event flag
$00000004 constant DMAMUX1_RGCFR_COF2                               \ Clear trigger overrun event flag
$00000008 constant DMAMUX1_RGCFR_COF3                               \ Clear trigger overrun event flag


\
\ @brief DMA request multiplexer
\
$40020800 constant DMAMUX1_C0CR   \ offset: 0x00 : channel 0 configuration register
$40020804 constant DMAMUX1_C1CR   \ offset: 0x04 : channel 1 configuration register
$40020808 constant DMAMUX1_C2CR   \ offset: 0x08 : channel 2 configuration register
$4002080c constant DMAMUX1_C3CR   \ offset: 0x0C : channel 3 configuration register
$40020810 constant DMAMUX1_C4CR   \ offset: 0x10 : channel 4 configuration register
$40020814 constant DMAMUX1_C5CR   \ offset: 0x14 : channel 5 configuration register
$40020818 constant DMAMUX1_C6CR   \ offset: 0x18 : channel 6 configuration register
$4002081c constant DMAMUX1_C7CR   \ offset: 0x1C : channel 7 configuration register
$40020820 constant DMAMUX1_C8CR   \ offset: 0x20 : channel 8 configuration register
$40020824 constant DMAMUX1_C9CR   \ offset: 0x24 : channel 9 configuration register
$40020828 constant DMAMUX1_C10CR  \ offset: 0x28 : channel 10 configuration register
$4002082c constant DMAMUX1_C11CR  \ offset: 0x2C : channel 11 configuration register
$40020830 constant DMAMUX1_C12CR  \ offset: 0x30 : channel 12 configuration register
$40020834 constant DMAMUX1_C13CR  \ offset: 0x34 : channel 13 configuration register
$40020880 constant DMAMUX1_CSR    \ offset: 0x80 : channel status register
$40020884 constant DMAMUX1_CFR    \ offset: 0x84 : clear flag register
$40020900 constant DMAMUX1_RG0CR  \ offset: 0x100 : request generator channel 0 configuration register
$40020904 constant DMAMUX1_RG1CR  \ offset: 0x104 : request generator channel 1 configuration register
$40020908 constant DMAMUX1_RG2CR  \ offset: 0x108 : request generator channel 2 configuration register
$4002090c constant DMAMUX1_RG3CR  \ offset: 0x10C : request generator channel 3 configuration register
$40020940 constant DMAMUX1_RGSR   \ offset: 0x140 : request generator interrupt status register
$40020944 constant DMAMUX1_RGCFR  \ offset: 0x144 : request generator interrupt clear flag register

