\
\ @file dmamux.fs
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

$000000ff constant DMAMUX_C0CR_DMAREQ_ID                            \ DMA Request ID
$00000100 constant DMAMUX_C0CR_SOIE                                 \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C0CR_EGE                                  \ Event Generation Enable
$00010000 constant DMAMUX_C0CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C0CR_SPOL                                 \ Sync polarity
$00f80000 constant DMAMUX_C0CR_NBREQ                                \ Nb request
$1f000000 constant DMAMUX_C0CR_SYNC_ID                              \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 1 Control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C1CR_DMAREQ_ID                            \ DMA Request ID
$00000100 constant DMAMUX_C1CR_SOIE                                 \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C1CR_EGE                                  \ Event Generation Enable
$00010000 constant DMAMUX_C1CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C1CR_SPOL                                 \ Sync polarity
$00f80000 constant DMAMUX_C1CR_NBREQ                                \ Nb request
$1f000000 constant DMAMUX_C1CR_SYNC_ID                              \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 2 Control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C2CR_DMAREQ_ID                            \ DMA Request ID
$00000100 constant DMAMUX_C2CR_SOIE                                 \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C2CR_EGE                                  \ Event Generation Enable
$00010000 constant DMAMUX_C2CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C2CR_SPOL                                 \ Sync polarity
$00f80000 constant DMAMUX_C2CR_NBREQ                                \ Nb request
$1f000000 constant DMAMUX_C2CR_SYNC_ID                              \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 3 Control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C3CR_DMAREQ_ID                            \ DMA Request ID
$00000100 constant DMAMUX_C3CR_SOIE                                 \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C3CR_EGE                                  \ Event Generation Enable
$00010000 constant DMAMUX_C3CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C3CR_SPOL                                 \ Sync polarity
$00f80000 constant DMAMUX_C3CR_NBREQ                                \ Nb request
$1f000000 constant DMAMUX_C3CR_SYNC_ID                              \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 4 Control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C4CR_DMAREQ_ID                            \ DMA Request ID
$00000100 constant DMAMUX_C4CR_SOIE                                 \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C4CR_EGE                                  \ Event Generation Enable
$00010000 constant DMAMUX_C4CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C4CR_SPOL                                 \ Sync polarity
$00f80000 constant DMAMUX_C4CR_NBREQ                                \ Nb request
$1f000000 constant DMAMUX_C4CR_SYNC_ID                              \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 5 Control register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C5CR_DMAREQ_ID                            \ DMA Request ID
$00000100 constant DMAMUX_C5CR_SOIE                                 \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C5CR_EGE                                  \ Event Generation Enable
$00010000 constant DMAMUX_C5CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C5CR_SPOL                                 \ Sync polarity
$00f80000 constant DMAMUX_C5CR_NBREQ                                \ Nb request
$1f000000 constant DMAMUX_C5CR_SYNC_ID                              \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 6 Control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C6CR_DMAREQ_ID                            \ DMA Request ID
$00000100 constant DMAMUX_C6CR_SOIE                                 \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C6CR_EGE                                  \ Event Generation Enable
$00010000 constant DMAMUX_C6CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C6CR_SPOL                                 \ Sync polarity
$00f80000 constant DMAMUX_C6CR_NBREQ                                \ Nb request
$1f000000 constant DMAMUX_C6CR_SYNC_ID                              \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 7 Control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C7CR_DMAREQ_ID                            \ DMA Request ID
$00000100 constant DMAMUX_C7CR_SOIE                                 \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C7CR_EGE                                  \ Event Generation Enable
$00010000 constant DMAMUX_C7CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C7CR_SPOL                                 \ Sync polarity
$00f80000 constant DMAMUX_C7CR_NBREQ                                \ Nb request
$1f000000 constant DMAMUX_C7CR_SYNC_ID                              \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 8 Control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C8CR_DMAREQ_ID                            \ DMA Request ID
$00000100 constant DMAMUX_C8CR_SOIE                                 \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C8CR_EGE                                  \ Event Generation Enable
$00010000 constant DMAMUX_C8CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C8CR_SPOL                                 \ Sync polarity
$00f80000 constant DMAMUX_C8CR_NBREQ                                \ Nb request
$1f000000 constant DMAMUX_C8CR_SYNC_ID                              \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 9 Control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C9CR_DMAREQ_ID                            \ DMA Request ID
$00000100 constant DMAMUX_C9CR_SOIE                                 \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C9CR_EGE                                  \ Event Generation Enable
$00010000 constant DMAMUX_C9CR_SE                                   \ Synchronization enable
$00060000 constant DMAMUX_C9CR_SPOL                                 \ Sync polarity
$00f80000 constant DMAMUX_C9CR_NBREQ                                \ Nb request
$1f000000 constant DMAMUX_C9CR_SYNC_ID                              \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 10 Control register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C10CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX_C10CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C10CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX_C10CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX_C10CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX_C10CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX_C10CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 11 Control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C11CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX_C11CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C11CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX_C11CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX_C11CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX_C11CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX_C11CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 12 Control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C12CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX_C12CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C12CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX_C12CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX_C12CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX_C12CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX_C12CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel 13 Control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_C13CR_DMAREQ_ID                           \ DMA Request ID
$00000100 constant DMAMUX_C13CR_SOIE                                \ Synchronization Overrun Interrupt Enable
$00000200 constant DMAMUX_C13CR_EGE                                 \ Event Generation Enable
$00010000 constant DMAMUX_C13CR_SE                                  \ Synchronization enable
$00060000 constant DMAMUX_C13CR_SPOL                                \ Sync polarity
$00f80000 constant DMAMUX_C13CR_NBREQ                               \ Nb request
$1f000000 constant DMAMUX_C13CR_SYNC_ID                             \ SYNC_ID


\
\ @brief DMA Multiplexer Channel Status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_CSR_SOF0                                  \ Synchronization Overrun Flag 0
$00000002 constant DMAMUX_CSR_SOF1                                  \ Synchronization Overrun Flag 1
$00000004 constant DMAMUX_CSR_SOF2                                  \ Synchronization Overrun Flag 2
$00000008 constant DMAMUX_CSR_SOF3                                  \ Synchronization Overrun Flag 3
$00000010 constant DMAMUX_CSR_SOF4                                  \ Synchronization Overrun Flag 4
$00000020 constant DMAMUX_CSR_SOF5                                  \ Synchronization Overrun Flag 5
$00000040 constant DMAMUX_CSR_SOF6                                  \ Synchronization Overrun Flag 6
$00000080 constant DMAMUX_CSR_SOF7                                  \ Synchronization Overrun Flag 7
$00000100 constant DMAMUX_CSR_SOF8                                  \ Synchronization Overrun Flag 8
$00000200 constant DMAMUX_CSR_SOF9                                  \ Synchronization Overrun Flag 9
$00000400 constant DMAMUX_CSR_SOF10                                 \ Synchronization Overrun Flag 10
$00000800 constant DMAMUX_CSR_SOF11                                 \ Synchronization Overrun Flag 11
$00001000 constant DMAMUX_CSR_SOF12                                 \ Synchronization Overrun Flag 12
$00002000 constant DMAMUX_CSR_SOF13                                 \ Synchronization Overrun Flag 13


\
\ @brief DMA Channel Clear Flag Register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_CFR_CSOF0                                 \ Synchronization Clear Overrun Flag 0
$00000002 constant DMAMUX_CFR_CSOF1                                 \ Synchronization Clear Overrun Flag 1
$00000004 constant DMAMUX_CFR_CSOF2                                 \ Synchronization Clear Overrun Flag 2
$00000008 constant DMAMUX_CFR_CSOF3                                 \ Synchronization Clear Overrun Flag 3
$00000010 constant DMAMUX_CFR_CSOF4                                 \ Synchronization Clear Overrun Flag 4
$00000020 constant DMAMUX_CFR_CSOF5                                 \ Synchronization Clear Overrun Flag 5
$00000040 constant DMAMUX_CFR_CSOF6                                 \ Synchronization Clear Overrun Flag 6
$00000080 constant DMAMUX_CFR_CSOF7                                 \ Synchronization Clear Overrun Flag 7
$00000100 constant DMAMUX_CFR_CSOF8                                 \ Synchronization Clear Overrun Flag 8
$00000200 constant DMAMUX_CFR_CSOF9                                 \ Synchronization Clear Overrun Flag 9
$00000400 constant DMAMUX_CFR_CSOF10                                \ Synchronization Clear Overrun Flag 10
$00000800 constant DMAMUX_CFR_CSOF11                                \ Synchronization Clear Overrun Flag 11
$00001000 constant DMAMUX_CFR_CSOF12                                \ Synchronization Clear Overrun Flag 12
$00002000 constant DMAMUX_CFR_CSOF13                                \ Synchronization Clear Overrun Flag 13


\
\ @brief DMA Request Generator 0 Control Register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG0CR_SIG_ID                              \ Signal ID
$00000100 constant DMAMUX_RG0CR_OIE                                 \ Overrun Interrupt Enable
$00010000 constant DMAMUX_RG0CR_GE                                  \ Generation Enable
$00060000 constant DMAMUX_RG0CR_GPOL                                \ Generation Polarity
$00f80000 constant DMAMUX_RG0CR_GNBREQ                              \ Number of Request


\
\ @brief DMA Request Generator 1 Control Register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG1CR_SIG_ID                              \ Signal ID
$00000100 constant DMAMUX_RG1CR_OIE                                 \ Overrun Interrupt Enable
$00010000 constant DMAMUX_RG1CR_GE                                  \ Generation Enable
$00060000 constant DMAMUX_RG1CR_GPOL                                \ Generation Polarity
$00f80000 constant DMAMUX_RG1CR_GNBREQ                              \ Number of Request


\
\ @brief DMA Request Generator 2 Control Register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG2CR_SIG_ID                              \ Signal ID
$00000100 constant DMAMUX_RG2CR_OIE                                 \ Overrun Interrupt Enable
$00010000 constant DMAMUX_RG2CR_GE                                  \ Generation Enable
$00060000 constant DMAMUX_RG2CR_GPOL                                \ Generation Polarity
$00f80000 constant DMAMUX_RG2CR_GNBREQ                              \ Number of Request


\
\ @brief DMA Request Generator 3 Control Register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG3CR_SIG_ID                              \ Signal ID
$00000100 constant DMAMUX_RG3CR_OIE                                 \ Overrun Interrupt Enable
$00010000 constant DMAMUX_RG3CR_GE                                  \ Generation Enable
$00060000 constant DMAMUX_RG3CR_GPOL                                \ Generation Polarity
$00f80000 constant DMAMUX_RG3CR_GNBREQ                              \ Number of Request


\
\ @brief DMA Request Generator Status Register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_RGSR_OF0                                  \ Generator Overrun Flag 0
$00000002 constant DMAMUX_RGSR_OF1                                  \ Generator Overrun Flag 1
$00000004 constant DMAMUX_RGSR_OF2                                  \ Generator Overrun Flag 2
$00000008 constant DMAMUX_RGSR_OF3                                  \ Generator Overrun Flag 3


\
\ @brief DMA Request Generator Clear Flag Register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_RGCFR_COF0                                \ Clear trigger Overrun Flag 0
$00000002 constant DMAMUX_RGCFR_COF1                                \ Clear trigger Overrun Flag 1
$00000004 constant DMAMUX_RGCFR_COF2                                \ Clear trigger Overrun Flag 2
$00000008 constant DMAMUX_RGCFR_COF3                                \ Clear trigger Overrun Flag 3


\
\ @brief Direct memory access Multiplexer
\
$40020800 constant DMAMUX_C0CR    \ offset: 0x00 : DMA Multiplexer Channel 0 Control register
$40020804 constant DMAMUX_C1CR    \ offset: 0x04 : DMA Multiplexer Channel 1 Control register
$40020808 constant DMAMUX_C2CR    \ offset: 0x08 : DMA Multiplexer Channel 2 Control register
$4002080c constant DMAMUX_C3CR    \ offset: 0x0C : DMA Multiplexer Channel 3 Control register
$40020810 constant DMAMUX_C4CR    \ offset: 0x10 : DMA Multiplexer Channel 4 Control register
$40020814 constant DMAMUX_C5CR    \ offset: 0x14 : DMA Multiplexer Channel 5 Control register
$40020818 constant DMAMUX_C6CR    \ offset: 0x18 : DMA Multiplexer Channel 6 Control register
$4002081c constant DMAMUX_C7CR    \ offset: 0x1C : DMA Multiplexer Channel 7 Control register
$40020820 constant DMAMUX_C8CR    \ offset: 0x20 : DMA Multiplexer Channel 8 Control register
$40020824 constant DMAMUX_C9CR    \ offset: 0x24 : DMA Multiplexer Channel 9 Control register
$40020828 constant DMAMUX_C10CR   \ offset: 0x28 : DMA Multiplexer Channel 10 Control register
$4002082c constant DMAMUX_C11CR   \ offset: 0x2C : DMA Multiplexer Channel 11 Control register
$40020830 constant DMAMUX_C12CR   \ offset: 0x30 : DMA Multiplexer Channel 12 Control register
$40020834 constant DMAMUX_C13CR   \ offset: 0x34 : DMA Multiplexer Channel 13 Control register
$40020880 constant DMAMUX_CSR     \ offset: 0x80 : DMA Multiplexer Channel Status register
$40020884 constant DMAMUX_CFR     \ offset: 0x84 : DMA Channel Clear Flag Register
$40020900 constant DMAMUX_RG0CR   \ offset: 0x100 : DMA Request Generator 0 Control Register
$40020904 constant DMAMUX_RG1CR   \ offset: 0x104 : DMA Request Generator 1 Control Register
$40020908 constant DMAMUX_RG2CR   \ offset: 0x108 : DMA Request Generator 2 Control Register
$4002090c constant DMAMUX_RG3CR   \ offset: 0x10C : DMA Request Generator 3 Control Register
$40020940 constant DMAMUX_RGSR    \ offset: 0x140 : DMA Request Generator Status Register
$40020944 constant DMAMUX_RGCFR   \ offset: 0x144 : DMA Request Generator Clear Flag Register

