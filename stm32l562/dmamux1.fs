\
\ @file dmamux1.fs
\ @brief Direct memory access Multiplexer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMA Multiplexer Channel 0 Control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C0CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX1_C0CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C0CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX1_C0CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C0CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX1_C0CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX1_C0CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 1 Control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C1CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX1_C1CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C1CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX1_C1CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C1CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX1_C1CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX1_C1CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 2 Control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C2CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX1_C2CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C2CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX1_C2CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C2CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX1_C2CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX1_C2CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 3 Control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C3CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX1_C3CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C3CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX1_C3CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C3CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX1_C3CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX1_C3CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 4 Control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C4CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX1_C4CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C4CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX1_C4CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C4CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX1_C4CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX1_C4CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 5 Control register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C5CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX1_C5CR_OIE                                 \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C5CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX1_C5CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C5CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX1_C5CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX1_C5CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 6 Control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C6CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX1_C6CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C6CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX1_C6CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C6CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX1_C6CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX1_C6CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 7 Control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C7CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX1_C7CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C7CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX1_C7CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C7CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX1_C7CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX1_C7CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 8 Control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C8CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX1_C8CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C8CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX1_C8CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C8CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX1_C8CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX1_C8CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 9 Control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C9CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX1_C9CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C9CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX1_C9CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX1_C9CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX1_C9CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX1_C9CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 10 Control register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C10CR_DMAREQ_ID                          \ DMA Request ID
$00000100 constant DMAMUX1_C10CR_SOIE                               \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C10CR_EGE                                \ Event Generation Enable
$00010000 constant DMAMUX1_C10CR_SE                                 \ Synchronization enable
$00060000 constant DMAMUX1_C10CR_SPOL                               \ Sync polarity
$00f80000 constant DMAMUX1_C10CR_NBREQ                              \ Nb request
$1f000000 constant DMAMUX1_C10CR_SYNC_ID                            \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 11 Control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C11CR_DMAREQ_ID                          \ DMA Request ID
$00000100 constant DMAMUX1_C11CR_SOIE                               \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C11CR_EGE                                \ Event Generation Enable
$00010000 constant DMAMUX1_C11CR_SE                                 \ Synchronization enable
$00060000 constant DMAMUX1_C11CR_SPOL                               \ Sync polarity
$00f80000 constant DMAMUX1_C11CR_NBREQ                              \ Nb request
$1f000000 constant DMAMUX1_C11CR_SYNC_ID                            \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 12 Control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C12CR_DMAREQ_ID                          \ DMA Request ID
$00000100 constant DMAMUX1_C12CR_SOIE                               \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C12CR_EGE                                \ Event Generation Enable
$00010000 constant DMAMUX1_C12CR_SE                                 \ Synchronization enable
$00060000 constant DMAMUX1_C12CR_SPOL                               \ Sync polarity
$00f80000 constant DMAMUX1_C12CR_NBREQ                              \ Nb request
$1f000000 constant DMAMUX1_C12CR_SYNC_ID                            \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 13 Control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C13CR_DMAREQ_ID                          \ DMA Request ID
$00000100 constant DMAMUX1_C13CR_SOIE                               \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX1_C13CR_EGE                                \ Event Generation Enable
$00010000 constant DMAMUX1_C13CR_SE                                 \ Synchronization enable
$00060000 constant DMAMUX1_C13CR_SPOL                               \ Sync polarity
$00f80000 constant DMAMUX1_C13CR_NBREQ                              \ Nb request
$1f000000 constant DMAMUX1_C13CR_SYNC_ID                            \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 10 Control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C14CR_DMAREQ_ID                          \ DMA request identification
$00000100 constant DMAMUX1_C14CR_SOIE                               \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C14CR_EGE                                \ Event generation enable
$00010000 constant DMAMUX1_C14CR_SE                                 \ Synchronization enable
$00060000 constant DMAMUX1_C14CR_SPOL                               \ Synchronization polarity
$00f80000 constant DMAMUX1_C14CR_NBREQ                              \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C14CR_SYNC_ID                            \ Synchronization identification


\
\ @brief DMA Multiplexer Channel 10 Control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_C15CR_DMAREQ_ID                          \ DMA request identification
$00000100 constant DMAMUX1_C15CR_SOIE                               \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_C15CR_EGE                                \ Event generation enable
$00010000 constant DMAMUX1_C15CR_SE                                 \ Synchronization enable
$00060000 constant DMAMUX1_C15CR_SPOL                               \ Synchronization polarity
$00f80000 constant DMAMUX1_C15CR_NBREQ                              \ Number of DMA requests minus 1 to forward
$1f000000 constant DMAMUX1_C15CR_SYNC_ID                            \ Synchronization identification


\
\ @brief DMA Multiplexer Channel Status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_CSR_SOF0                                 \ Synchronization Overrun Flag 0
$00000002 constant DMAMUX1_CSR_SOF1                                 \ Synchronization Overrun Flag 1
$00000004 constant DMAMUX1_CSR_SOF2                                 \ Synchronization Overrun Flag 2
$00000008 constant DMAMUX1_CSR_SOF3                                 \ Synchronization Overrun Flag 3
$00000010 constant DMAMUX1_CSR_SOF4                                 \ Synchronization Overrun Flag 4
$00000020 constant DMAMUX1_CSR_SOF5                                 \ Synchronization Overrun Flag 5
$00000040 constant DMAMUX1_CSR_SOF6                                 \ Synchronization Overrun Flag 6
$00000080 constant DMAMUX1_CSR_SOF7                                 \ Synchronization Overrun Flag 7
$00000100 constant DMAMUX1_CSR_SOF8                                 \ Synchronization Overrun Flag 8
$00000200 constant DMAMUX1_CSR_SOF9                                 \ Synchronization Overrun Flag 9
$00000400 constant DMAMUX1_CSR_SOF10                                \ Synchronization Overrun Flag 10
$00000800 constant DMAMUX1_CSR_SOF11                                \ Synchronization Overrun Flag 11
$00001000 constant DMAMUX1_CSR_SOF12                                \ Synchronization Overrun Flag 12
$00002000 constant DMAMUX1_CSR_SOF13                                \ Synchronization Overrun Flag 13
$00004000 constant DMAMUX1_CSR_SOF14                                \ Synchronization Overrun Flag 13
$00008000 constant DMAMUX1_CSR_SOF15                                \ Synchronization Overrun Flag 13


\
\ @brief DMA Channel Clear Flag Register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_CCFR_CSOF0                               \ Synchronization Clear Overrun Flag 0
$00000002 constant DMAMUX1_CCFR_CSOF1                               \ Synchronization Clear Overrun Flag 1
$00000004 constant DMAMUX1_CCFR_CSOF2                               \ Synchronization Clear Overrun Flag 2
$00000008 constant DMAMUX1_CCFR_CSOF3                               \ Synchronization Clear Overrun Flag 3
$00000010 constant DMAMUX1_CCFR_CSOF4                               \ Synchronization Clear Overrun Flag 4
$00000020 constant DMAMUX1_CCFR_CSOF5                               \ Synchronization Clear Overrun Flag 5
$00000040 constant DMAMUX1_CCFR_CSOF6                               \ Synchronization Clear Overrun Flag 6
$00000080 constant DMAMUX1_CCFR_CSOF7                               \ Synchronization Clear Overrun Flag 7
$00000100 constant DMAMUX1_CCFR_CSOF8                               \ Synchronization Clear Overrun Flag 8
$00000200 constant DMAMUX1_CCFR_CSOF9                               \ Synchronization Clear Overrun Flag 9
$00000400 constant DMAMUX1_CCFR_CSOF10                              \ Synchronization Clear Overrun Flag 10
$00000800 constant DMAMUX1_CCFR_CSOF11                              \ Synchronization Clear Overrun Flag 11
$00001000 constant DMAMUX1_CCFR_CSOF12                              \ Synchronization Clear Overrun Flag 12
$00002000 constant DMAMUX1_CCFR_CSOF13                              \ Synchronization Clear Overrun Flag 13
$00004000 constant DMAMUX1_CCFR_CSOF14                              \ Synchronization Clear Overrun Flag 13
$00008000 constant DMAMUX1_CCFR_CSOF15                              \ Synchronization Clear Overrun Flag 13


\
\ @brief DMA Request Generator 0 Control Register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX1_RG0CR_SIG_ID                             \ Signal ID
$00000100 constant DMAMUX1_RG0CR_OIE                                \ Overrun Interrupt Enable
$00010000 constant DMAMUX1_RG0CR_GE                                 \ Generation Enable
$00060000 constant DMAMUX1_RG0CR_GPOL                               \ Generation Polarity
$00f80000 constant DMAMUX1_RG0CR_GNBREQ                             \ Number of Request


\
\ @brief DMA Request Generator 1 Control Register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX1_RG1CR_SIG_ID                             \ Signal ID
$00000100 constant DMAMUX1_RG1CR_OIE                                \ Overrun Interrupt Enable
$00010000 constant DMAMUX1_RG1CR_GE                                 \ Generation Enable
$00060000 constant DMAMUX1_RG1CR_GPOL                               \ Generation Polarity
$00f80000 constant DMAMUX1_RG1CR_GNBREQ                             \ Number of Request


\
\ @brief DMA Request Generator 2 Control Register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX1_RG2CR_SIG_ID                             \ Signal ID
$00000100 constant DMAMUX1_RG2CR_OIE                                \ Overrun Interrupt Enable
$00010000 constant DMAMUX1_RG2CR_GE                                 \ Generation Enable
$00060000 constant DMAMUX1_RG2CR_GPOL                               \ Generation Polarity
$00f80000 constant DMAMUX1_RG2CR_GNBREQ                             \ Number of Request


\
\ @brief DMA Request Generator 3 Control Register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX1_RG3CR_SIG_ID                             \ Signal ID
$00000100 constant DMAMUX1_RG3CR_OIE                                \ Overrun Interrupt Enable
$00010000 constant DMAMUX1_RG3CR_GE                                 \ Generation Enable
$00060000 constant DMAMUX1_RG3CR_GPOL                               \ Generation Polarity
$00f80000 constant DMAMUX1_RG3CR_GNBREQ                             \ Number of Request


\
\ @brief DMA Request Generator Status Register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_RGSR_OF0                                 \ Generator Overrun Flag 0
$00000002 constant DMAMUX1_RGSR_OF1                                 \ Generator Overrun Flag 1
$00000004 constant DMAMUX1_RGSR_OF2                                 \ Generator Overrun Flag 2
$00000008 constant DMAMUX1_RGSR_OF3                                 \ Generator Overrun Flag 3


\
\ @brief DMA Request Generator Clear Flag Register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_RGCFR_CSOF0                              \ Generator Clear Overrun Flag 0
$00000002 constant DMAMUX1_RGCFR_CSOF1                              \ Generator Clear Overrun Flag 1
$00000004 constant DMAMUX1_RGCFR_CSOF2                              \ Generator Clear Overrun Flag 2
$00000008 constant DMAMUX1_RGCFR_CSOF3                              \ Generator Clear Overrun Flag 3


\
\ @brief Direct memory access Multiplexer
\
$40020800 constant DMAMUX1_C0CR   \ offset: 0x00 : DMA Multiplexer Channel 0 Control register
$40020804 constant DMAMUX1_C1CR   \ offset: 0x04 : DMA Multiplexer Channel 1 Control register
$40020808 constant DMAMUX1_C2CR   \ offset: 0x08 : DMA Multiplexer Channel 2 Control register
$4002080c constant DMAMUX1_C3CR   \ offset: 0x0C : DMA Multiplexer Channel 3 Control register
$40020810 constant DMAMUX1_C4CR   \ offset: 0x10 : DMA Multiplexer Channel 4 Control register
$40020814 constant DMAMUX1_C5CR   \ offset: 0x14 : DMA Multiplexer Channel 5 Control register
$40020818 constant DMAMUX1_C6CR   \ offset: 0x18 : DMA Multiplexer Channel 6 Control register
$4002081c constant DMAMUX1_C7CR   \ offset: 0x1C : DMA Multiplexer Channel 7 Control register
$40020820 constant DMAMUX1_C8CR   \ offset: 0x20 : DMA Multiplexer Channel 8 Control register
$40020824 constant DMAMUX1_C9CR   \ offset: 0x24 : DMA Multiplexer Channel 9 Control register
$40020828 constant DMAMUX1_C10CR  \ offset: 0x28 : DMA Multiplexer Channel 10 Control register
$4002082c constant DMAMUX1_C11CR  \ offset: 0x2C : DMA Multiplexer Channel 11 Control register
$40020830 constant DMAMUX1_C12CR  \ offset: 0x30 : DMA Multiplexer Channel 12 Control register
$40020834 constant DMAMUX1_C13CR  \ offset: 0x34 : DMA Multiplexer Channel 13 Control register
$40020838 constant DMAMUX1_C14CR  \ offset: 0x38 : DMA Multiplexer Channel 10 Control register
$4002083c constant DMAMUX1_C15CR  \ offset: 0x3C : DMA Multiplexer Channel 10 Control register
$40020880 constant DMAMUX1_CSR    \ offset: 0x80 : DMA Multiplexer Channel Status register
$40020884 constant DMAMUX1_CCFR   \ offset: 0x84 : DMA Channel Clear Flag Register
$40020900 constant DMAMUX1_RG0CR  \ offset: 0x100 : DMA Request Generator 0 Control Register
$40020904 constant DMAMUX1_RG1CR  \ offset: 0x104 : DMA Request Generator 1 Control Register
$40020908 constant DMAMUX1_RG2CR  \ offset: 0x108 : DMA Request Generator 2 Control Register
$4002090c constant DMAMUX1_RG3CR  \ offset: 0x10C : DMA Request Generator 3 Control Register
$40020940 constant DMAMUX1_RGSR   \ offset: 0x140 : DMA Request Generator Status Register
$40020944 constant DMAMUX1_RGCFR  \ offset: 0x144 : DMA Request Generator Clear Flag Register

