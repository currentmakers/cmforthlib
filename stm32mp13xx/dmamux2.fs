\
\ @file dmamux2.fs
\ @brief DMAMUX2
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMAMUX request line multiplexer channel 0 configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000100 constant DMAMUX2_DMAMUX_C0CR_SOIE                         \ SOIE
$00000200 constant DMAMUX2_DMAMUX_C0CR_EGE                          \ EGE
$00010000 constant DMAMUX2_DMAMUX_C0CR_SE                           \ SE
$00060000 constant DMAMUX2_DMAMUX_C0CR_SPOL                         \ SPOL
$00f80000 constant DMAMUX2_DMAMUX_C0CR_NBREQ                        \ NBREQ
$07000000 constant DMAMUX2_DMAMUX_C0CR_SYNC_ID                      \ SYNC_ID


\
\ @brief DMAMUX request line multiplexer channel 1 configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000100 constant DMAMUX2_DMAMUX_C1CR_SOIE                         \ SOIE
$00000200 constant DMAMUX2_DMAMUX_C1CR_EGE                          \ EGE
$00010000 constant DMAMUX2_DMAMUX_C1CR_SE                           \ SE
$00060000 constant DMAMUX2_DMAMUX_C1CR_SPOL                         \ SPOL
$00f80000 constant DMAMUX2_DMAMUX_C1CR_NBREQ                        \ NBREQ
$07000000 constant DMAMUX2_DMAMUX_C1CR_SYNC_ID                      \ SYNC_ID


\
\ @brief DMAMUX request line multiplexer channel 2 configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000100 constant DMAMUX2_DMAMUX_C2CR_SOIE                         \ SOIE
$00000200 constant DMAMUX2_DMAMUX_C2CR_EGE                          \ EGE
$00010000 constant DMAMUX2_DMAMUX_C2CR_SE                           \ SE
$00060000 constant DMAMUX2_DMAMUX_C2CR_SPOL                         \ SPOL
$00f80000 constant DMAMUX2_DMAMUX_C2CR_NBREQ                        \ NBREQ
$07000000 constant DMAMUX2_DMAMUX_C2CR_SYNC_ID                      \ SYNC_ID


\
\ @brief DMAMUX request line multiplexer channel 3 configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000100 constant DMAMUX2_DMAMUX_C3CR_SOIE                         \ SOIE
$00000200 constant DMAMUX2_DMAMUX_C3CR_EGE                          \ EGE
$00010000 constant DMAMUX2_DMAMUX_C3CR_SE                           \ SE
$00060000 constant DMAMUX2_DMAMUX_C3CR_SPOL                         \ SPOL
$00f80000 constant DMAMUX2_DMAMUX_C3CR_NBREQ                        \ NBREQ
$07000000 constant DMAMUX2_DMAMUX_C3CR_SYNC_ID                      \ SYNC_ID


\
\ @brief DMAMUX request line multiplexer channel 4 configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000100 constant DMAMUX2_DMAMUX_C4CR_SOIE                         \ SOIE
$00000200 constant DMAMUX2_DMAMUX_C4CR_EGE                          \ EGE
$00010000 constant DMAMUX2_DMAMUX_C4CR_SE                           \ SE
$00060000 constant DMAMUX2_DMAMUX_C4CR_SPOL                         \ SPOL
$00f80000 constant DMAMUX2_DMAMUX_C4CR_NBREQ                        \ NBREQ
$07000000 constant DMAMUX2_DMAMUX_C4CR_SYNC_ID                      \ SYNC_ID


\
\ @brief DMAMUX request line multiplexer channel 5 configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000100 constant DMAMUX2_DMAMUX_C5CR_SOIE                         \ SOIE
$00000200 constant DMAMUX2_DMAMUX_C5CR_EGE                          \ EGE
$00010000 constant DMAMUX2_DMAMUX_C5CR_SE                           \ SE
$00060000 constant DMAMUX2_DMAMUX_C5CR_SPOL                         \ SPOL
$00f80000 constant DMAMUX2_DMAMUX_C5CR_NBREQ                        \ NBREQ
$07000000 constant DMAMUX2_DMAMUX_C5CR_SYNC_ID                      \ SYNC_ID


\
\ @brief DMAMUX request line multiplexer channel 6 configuration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000100 constant DMAMUX2_DMAMUX_C6CR_SOIE                         \ SOIE
$00000200 constant DMAMUX2_DMAMUX_C6CR_EGE                          \ EGE
$00010000 constant DMAMUX2_DMAMUX_C6CR_SE                           \ SE
$00060000 constant DMAMUX2_DMAMUX_C6CR_SPOL                         \ SPOL
$00f80000 constant DMAMUX2_DMAMUX_C6CR_NBREQ                        \ NBREQ
$07000000 constant DMAMUX2_DMAMUX_C6CR_SYNC_ID                      \ SYNC_ID


\
\ @brief DMAMUX request line multiplexer channel 7 configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000100 constant DMAMUX2_DMAMUX_C7CR_SOIE                         \ SOIE
$00000200 constant DMAMUX2_DMAMUX_C7CR_EGE                          \ EGE
$00010000 constant DMAMUX2_DMAMUX_C7CR_SE                           \ SE
$00060000 constant DMAMUX2_DMAMUX_C7CR_SPOL                         \ SPOL
$00f80000 constant DMAMUX2_DMAMUX_C7CR_NBREQ                        \ NBREQ
$07000000 constant DMAMUX2_DMAMUX_C7CR_SYNC_ID                      \ SYNC_ID


\
\ @brief DMAMUX request line multiplexer interrupt channel status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX2_DMAMUX_CSR_SOF0                          \ SOF0
$00000002 constant DMAMUX2_DMAMUX_CSR_SOF1                          \ SOF1
$00000004 constant DMAMUX2_DMAMUX_CSR_SOF2                          \ SOF2
$00000008 constant DMAMUX2_DMAMUX_CSR_SOF3                          \ SOF3
$00000010 constant DMAMUX2_DMAMUX_CSR_SOF4                          \ SOF4
$00000020 constant DMAMUX2_DMAMUX_CSR_SOF5                          \ SOF5
$00000040 constant DMAMUX2_DMAMUX_CSR_SOF6                          \ SOF6
$00000080 constant DMAMUX2_DMAMUX_CSR_SOF7                          \ SOF7
$00000100 constant DMAMUX2_DMAMUX_CSR_SOF8                          \ SOF8
$00000200 constant DMAMUX2_DMAMUX_CSR_SOF9                          \ SOF9
$00000400 constant DMAMUX2_DMAMUX_CSR_SOF10                         \ SOF10
$00000800 constant DMAMUX2_DMAMUX_CSR_SOF11                         \ SOF11
$00001000 constant DMAMUX2_DMAMUX_CSR_SOF12                         \ SOF12
$00002000 constant DMAMUX2_DMAMUX_CSR_SOF13                         \ SOF13
$00004000 constant DMAMUX2_DMAMUX_CSR_SOF14                         \ SOF14
$00008000 constant DMAMUX2_DMAMUX_CSR_SOF15                         \ SOF15


\
\ @brief DMAMUX request line multiplexer interrupt clear flag register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX2_DMAMUX_CFR_CSOF0                         \ CSOF0
$00000002 constant DMAMUX2_DMAMUX_CFR_CSOF1                         \ CSOF1
$00000004 constant DMAMUX2_DMAMUX_CFR_CSOF2                         \ CSOF2
$00000008 constant DMAMUX2_DMAMUX_CFR_CSOF3                         \ CSOF3
$00000010 constant DMAMUX2_DMAMUX_CFR_CSOF4                         \ CSOF4
$00000020 constant DMAMUX2_DMAMUX_CFR_CSOF5                         \ CSOF5
$00000040 constant DMAMUX2_DMAMUX_CFR_CSOF6                         \ CSOF6
$00000080 constant DMAMUX2_DMAMUX_CFR_CSOF7                         \ CSOF7
$00000100 constant DMAMUX2_DMAMUX_CFR_CSOF8                         \ CSOF8
$00000200 constant DMAMUX2_DMAMUX_CFR_CSOF9                         \ CSOF9
$00000400 constant DMAMUX2_DMAMUX_CFR_CSOF10                        \ CSOF10
$00000800 constant DMAMUX2_DMAMUX_CFR_CSOF11                        \ CSOF11
$00001000 constant DMAMUX2_DMAMUX_CFR_CSOF12                        \ CSOF12
$00002000 constant DMAMUX2_DMAMUX_CFR_CSOF13                        \ CSOF13
$00004000 constant DMAMUX2_DMAMUX_CFR_CSOF14                        \ CSOF14
$00008000 constant DMAMUX2_DMAMUX_CFR_CSOF15                        \ CSOF15


\
\ @brief DMAMUX request generator channel 0 configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX2_DMAMUX_RG0CR_SIG_ID                      \ SIG_ID
$00000100 constant DMAMUX2_DMAMUX_RG0CR_OIE                         \ OIE
$00010000 constant DMAMUX2_DMAMUX_RG0CR_GE                          \ GE
$00060000 constant DMAMUX2_DMAMUX_RG0CR_GPOL                        \ GPOL
$00f80000 constant DMAMUX2_DMAMUX_RG0CR_GNBREQ                      \ GNBREQ


\
\ @brief DMAMUX request generator channel 1 configuration register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX2_DMAMUX_RG1CR_SIG_ID                      \ SIG_ID
$00000100 constant DMAMUX2_DMAMUX_RG1CR_OIE                         \ OIE
$00010000 constant DMAMUX2_DMAMUX_RG1CR_GE                          \ GE
$00060000 constant DMAMUX2_DMAMUX_RG1CR_GPOL                        \ GPOL
$00f80000 constant DMAMUX2_DMAMUX_RG1CR_GNBREQ                      \ GNBREQ


\
\ @brief DMAMUX request generator channel 2 configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX2_DMAMUX_RG2CR_SIG_ID                      \ SIG_ID
$00000100 constant DMAMUX2_DMAMUX_RG2CR_OIE                         \ OIE
$00010000 constant DMAMUX2_DMAMUX_RG2CR_GE                          \ GE
$00060000 constant DMAMUX2_DMAMUX_RG2CR_GPOL                        \ GPOL
$00f80000 constant DMAMUX2_DMAMUX_RG2CR_GNBREQ                      \ GNBREQ


\
\ @brief DMAMUX request generator channel 3 configuration register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX2_DMAMUX_RG3CR_SIG_ID                      \ SIG_ID
$00000100 constant DMAMUX2_DMAMUX_RG3CR_OIE                         \ OIE
$00010000 constant DMAMUX2_DMAMUX_RG3CR_GE                          \ GE
$00060000 constant DMAMUX2_DMAMUX_RG3CR_GPOL                        \ GPOL
$00f80000 constant DMAMUX2_DMAMUX_RG3CR_GNBREQ                      \ GNBREQ


\
\ @brief DMAMUX request generator channel 4 configuration register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX2_DMAMUX_RG4CR_SIG_ID                      \ SIG_ID
$00000100 constant DMAMUX2_DMAMUX_RG4CR_OIE                         \ OIE
$00010000 constant DMAMUX2_DMAMUX_RG4CR_GE                          \ GE
$00060000 constant DMAMUX2_DMAMUX_RG4CR_GPOL                        \ GPOL
$00f80000 constant DMAMUX2_DMAMUX_RG4CR_GNBREQ                      \ GNBREQ


\
\ @brief DMAMUX request generator channel 5 configuration register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX2_DMAMUX_RG5CR_SIG_ID                      \ SIG_ID
$00000100 constant DMAMUX2_DMAMUX_RG5CR_OIE                         \ OIE
$00010000 constant DMAMUX2_DMAMUX_RG5CR_GE                          \ GE
$00060000 constant DMAMUX2_DMAMUX_RG5CR_GPOL                        \ GPOL
$00f80000 constant DMAMUX2_DMAMUX_RG5CR_GNBREQ                      \ GNBREQ


\
\ @brief DMAMUX request generator channel 6 configuration register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX2_DMAMUX_RG6CR_SIG_ID                      \ SIG_ID
$00000100 constant DMAMUX2_DMAMUX_RG6CR_OIE                         \ OIE
$00010000 constant DMAMUX2_DMAMUX_RG6CR_GE                          \ GE
$00060000 constant DMAMUX2_DMAMUX_RG6CR_GPOL                        \ GPOL
$00f80000 constant DMAMUX2_DMAMUX_RG6CR_GNBREQ                      \ GNBREQ


\
\ @brief DMAMUX request generator channel 7 configuration register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX2_DMAMUX_RG7CR_SIG_ID                      \ SIG_ID
$00000100 constant DMAMUX2_DMAMUX_RG7CR_OIE                         \ OIE
$00010000 constant DMAMUX2_DMAMUX_RG7CR_GE                          \ GE
$00060000 constant DMAMUX2_DMAMUX_RG7CR_GPOL                        \ GPOL
$00f80000 constant DMAMUX2_DMAMUX_RG7CR_GNBREQ                      \ GNBREQ


\
\ @brief DMAMUX request generator interrupt status register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX2_DMAMUX_RGSR_OF0                          \ OF0
$00000002 constant DMAMUX2_DMAMUX_RGSR_OF1                          \ OF1
$00000004 constant DMAMUX2_DMAMUX_RGSR_OF2                          \ OF2
$00000008 constant DMAMUX2_DMAMUX_RGSR_OF3                          \ OF3
$00000010 constant DMAMUX2_DMAMUX_RGSR_OF4                          \ OF4
$00000020 constant DMAMUX2_DMAMUX_RGSR_OF5                          \ OF5
$00000040 constant DMAMUX2_DMAMUX_RGSR_OF6                          \ OF6
$00000080 constant DMAMUX2_DMAMUX_RGSR_OF7                          \ OF7


\
\ @brief DMAMUX request generator interrupt clear flag register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX2_DMAMUX_RGCFR_COF0                        \ COF0
$00000002 constant DMAMUX2_DMAMUX_RGCFR_COF1                        \ COF1
$00000004 constant DMAMUX2_DMAMUX_RGCFR_COF2                        \ COF2
$00000008 constant DMAMUX2_DMAMUX_RGCFR_COF3                        \ COF3
$00000010 constant DMAMUX2_DMAMUX_RGCFR_COF4                        \ COF4
$00000020 constant DMAMUX2_DMAMUX_RGCFR_COF5                        \ COF5
$00000040 constant DMAMUX2_DMAMUX_RGCFR_COF6                        \ COF6
$00000080 constant DMAMUX2_DMAMUX_RGCFR_COF7                        \ COF7


\
\ @brief DMAMUX hardware configuration 2 register
\ Address offset: 0x3EC
\ Reset value: 0x00000008
\

$000000ff constant DMAMUX2_DMAMUX_HWCFGR2_NUM_DMA_EXT_REQ           \ NUM_DMA_EXT_REQ


\
\ @brief DMAMUX hardware configuration 1 register
\ Address offset: 0x3F0
\ Reset value: 0x08086C10
\

$000000ff constant DMAMUX2_DMAMUX_HWCFGR1_NUM_DMA_STREAMS           \ NUM_DMA_STREAMS
$0000ff00 constant DMAMUX2_DMAMUX_HWCFGR1_NUM_DMA_PERIPH_REQ        \ NUM_DMA_PERIPH_REQ
$00ff0000 constant DMAMUX2_DMAMUX_HWCFGR1_NUM_DMA_TRIG              \ NUM_DMA_TRIG
$ff000000 constant DMAMUX2_DMAMUX_HWCFGR1_NUM_DMA_REQGEN            \ NUM_DMA_REQGEN


\
\ @brief This register identifies the IP version.
\ Address offset: 0x3F4
\ Reset value: 0x00000011
\

$0000000f constant DMAMUX2_DMAMUX_VERR_MINREV                       \ MINREV
$000000f0 constant DMAMUX2_DMAMUX_VERR_MAJREV                       \ MAJREV


\
\ @brief This register identifies the IP.
\ Address offset: 0x3F8
\ Reset value: 0x00100011
\

$00000000 constant DMAMUX2_DMAMUX_IPIDR_ID                          \ ID


\
\ @brief DMAMUX size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant DMAMUX2_DMAMUX_SIDR_SID                          \ SID


\
\ @brief DMAMUX2
\
$48006000 constant DMAMUX2_DMAMUX_C0CR  \ offset: 0x00 : DMAMUX request line multiplexer channel 0 configuration register
$48006004 constant DMAMUX2_DMAMUX_C1CR  \ offset: 0x04 : DMAMUX request line multiplexer channel 1 configuration register
$48006008 constant DMAMUX2_DMAMUX_C2CR  \ offset: 0x08 : DMAMUX request line multiplexer channel 2 configuration register
$4800600c constant DMAMUX2_DMAMUX_C3CR  \ offset: 0x0C : DMAMUX request line multiplexer channel 3 configuration register
$48006010 constant DMAMUX2_DMAMUX_C4CR  \ offset: 0x10 : DMAMUX request line multiplexer channel 4 configuration register
$48006014 constant DMAMUX2_DMAMUX_C5CR  \ offset: 0x14 : DMAMUX request line multiplexer channel 5 configuration register
$48006018 constant DMAMUX2_DMAMUX_C6CR  \ offset: 0x18 : DMAMUX request line multiplexer channel 6 configuration register
$4800601c constant DMAMUX2_DMAMUX_C7CR  \ offset: 0x1C : DMAMUX request line multiplexer channel 7 configuration register
$48006080 constant DMAMUX2_DMAMUX_CSR  \ offset: 0x80 : DMAMUX request line multiplexer interrupt channel status register
$48006084 constant DMAMUX2_DMAMUX_CFR  \ offset: 0x84 : DMAMUX request line multiplexer interrupt clear flag register
$48006100 constant DMAMUX2_DMAMUX_RG0CR  \ offset: 0x100 : DMAMUX request generator channel 0 configuration register
$48006104 constant DMAMUX2_DMAMUX_RG1CR  \ offset: 0x104 : DMAMUX request generator channel 1 configuration register
$48006108 constant DMAMUX2_DMAMUX_RG2CR  \ offset: 0x108 : DMAMUX request generator channel 2 configuration register
$4800610c constant DMAMUX2_DMAMUX_RG3CR  \ offset: 0x10C : DMAMUX request generator channel 3 configuration register
$48006110 constant DMAMUX2_DMAMUX_RG4CR  \ offset: 0x110 : DMAMUX request generator channel 4 configuration register
$48006114 constant DMAMUX2_DMAMUX_RG5CR  \ offset: 0x114 : DMAMUX request generator channel 5 configuration register
$48006118 constant DMAMUX2_DMAMUX_RG6CR  \ offset: 0x118 : DMAMUX request generator channel 6 configuration register
$4800611c constant DMAMUX2_DMAMUX_RG7CR  \ offset: 0x11C : DMAMUX request generator channel 7 configuration register
$48006140 constant DMAMUX2_DMAMUX_RGSR  \ offset: 0x140 : DMAMUX request generator interrupt status register
$48006144 constant DMAMUX2_DMAMUX_RGCFR  \ offset: 0x144 : DMAMUX request generator interrupt clear flag register
$480063ec constant DMAMUX2_DMAMUX_HWCFGR2  \ offset: 0x3EC : DMAMUX hardware configuration 2 register
$480063f0 constant DMAMUX2_DMAMUX_HWCFGR1  \ offset: 0x3F0 : DMAMUX hardware configuration 1 register
$480063f4 constant DMAMUX2_DMAMUX_VERR  \ offset: 0x3F4 : This register identifies the IP version.
$480063f8 constant DMAMUX2_DMAMUX_IPIDR  \ offset: 0x3F8 : This register identifies the IP.
$480063fc constant DMAMUX2_DMAMUX_SIDR  \ offset: 0x3FC : DMAMUX size identification register

