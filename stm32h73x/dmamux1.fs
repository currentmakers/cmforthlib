\
\ @file dmamux1.fs
\ @brief DMAMUX
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C0CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C0CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C0CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C0CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C0CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C0CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C0CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C1CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C1CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C1CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C1CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C1CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C1CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C1CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C2CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C2CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C2CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C2CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C2CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C2CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C2CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C3CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C3CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C3CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C3CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C3CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C3CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C3CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C4CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C4CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C4CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C4CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C4CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C4CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C4CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C5CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C5CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C5CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C5CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C5CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C5CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C5CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C6CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C6CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C6CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C6CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C6CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C6CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C6CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C7CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C7CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C7CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C7CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C7CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C7CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C7CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C8CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C8CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C8CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C8CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C8CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C8CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C8CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C9CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C9CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C9CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C9CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C9CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C9CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C9CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C10CR_DMAREQ_ID                   \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C10CR_SOIE                        \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C10CR_EGE                         \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C10CR_SE                          \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C10CR_SPOL                        \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C10CR_NBREQ                       \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C10CR_SYNC_ID                     \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C11CR_DMAREQ_ID                   \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C11CR_SOIE                        \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C11CR_EGE                         \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C11CR_SE                          \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C11CR_SPOL                        \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C11CR_NBREQ                       \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C11CR_SYNC_ID                     \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C12CR_DMAREQ_ID                   \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C12CR_SOIE                        \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C12CR_EGE                         \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C12CR_SE                          \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C12CR_SPOL                        \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C12CR_NBREQ                       \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C12CR_SYNC_ID                     \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C13CR_DMAREQ_ID                   \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C13CR_SOIE                        \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C13CR_EGE                         \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C13CR_SE                          \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C13CR_SPOL                        \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C13CR_NBREQ                       \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C13CR_SYNC_ID                     \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C14CR_DMAREQ_ID                   \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C14CR_SOIE                        \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C14CR_EGE                         \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C14CR_SE                          \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C14CR_SPOL                        \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C14CR_NBREQ                       \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C14CR_SYNC_ID                     \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX1_DMAMUX_C15CR_DMAREQ_ID                   \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX1_DMAMUX_C15CR_SOIE                        \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX1_DMAMUX_C15CR_EGE                         \ Event generation enable
$00010000 constant DMAMUX1_DMAMUX_C15CR_SE                          \ Synchronization enable
$00060000 constant DMAMUX1_DMAMUX_C15CR_SPOL                        \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX1_DMAMUX_C15CR_NBREQ                       \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
$07000000 constant DMAMUX1_DMAMUX_C15CR_SYNC_ID                     \ Synchronization identification Selects the synchronization input (see inputs to resources).


\
\ @brief Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_DMAMUX_CSR_SOF0                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00000002 constant DMAMUX1_DMAMUX_CSR_SOF1                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00000004 constant DMAMUX1_DMAMUX_CSR_SOF2                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00000008 constant DMAMUX1_DMAMUX_CSR_SOF3                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00000010 constant DMAMUX1_DMAMUX_CSR_SOF4                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00000020 constant DMAMUX1_DMAMUX_CSR_SOF5                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00000040 constant DMAMUX1_DMAMUX_CSR_SOF6                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00000080 constant DMAMUX1_DMAMUX_CSR_SOF7                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00000100 constant DMAMUX1_DMAMUX_CSR_SOF8                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00000200 constant DMAMUX1_DMAMUX_CSR_SOF9                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00000400 constant DMAMUX1_DMAMUX_CSR_SOF10                         \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00000800 constant DMAMUX1_DMAMUX_CSR_SOF11                         \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00001000 constant DMAMUX1_DMAMUX_CSR_SOF12                         \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00002000 constant DMAMUX1_DMAMUX_CSR_SOF13                         \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00004000 constant DMAMUX1_DMAMUX_CSR_SOF14                         \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$00008000 constant DMAMUX1_DMAMUX_CSR_SOF15                         \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.


\
\ @brief Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_DMAMUX_CFR_CSOF0                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000002 constant DMAMUX1_DMAMUX_CFR_CSOF1                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000004 constant DMAMUX1_DMAMUX_CFR_CSOF2                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000008 constant DMAMUX1_DMAMUX_CFR_CSOF3                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000010 constant DMAMUX1_DMAMUX_CFR_CSOF4                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000020 constant DMAMUX1_DMAMUX_CFR_CSOF5                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000040 constant DMAMUX1_DMAMUX_CFR_CSOF6                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000080 constant DMAMUX1_DMAMUX_CFR_CSOF7                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000100 constant DMAMUX1_DMAMUX_CFR_CSOF8                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000200 constant DMAMUX1_DMAMUX_CFR_CSOF9                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000400 constant DMAMUX1_DMAMUX_CFR_CSOF10                        \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000800 constant DMAMUX1_DMAMUX_CFR_CSOF11                        \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00001000 constant DMAMUX1_DMAMUX_CFR_CSOF12                        \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00002000 constant DMAMUX1_DMAMUX_CFR_CSOF13                        \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00004000 constant DMAMUX1_DMAMUX_CFR_CSOF14                        \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00008000 constant DMAMUX1_DMAMUX_CFR_CSOF15                        \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.


\
\ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX1_DMAMUX_RG0CR_SIG_ID                      \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX1_DMAMUX_RG0CR_OIE                         \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_DMAMUX_RG0CR_GE                          \ DMA request generator channel x enable
$00060000 constant DMAMUX1_DMAMUX_RG0CR_GPOL                        \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX1_DMAMUX_RG0CR_GNBREQ                      \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX1_DMAMUX_RG1CR_SIG_ID                      \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX1_DMAMUX_RG1CR_OIE                         \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_DMAMUX_RG1CR_GE                          \ DMA request generator channel x enable
$00060000 constant DMAMUX1_DMAMUX_RG1CR_GPOL                        \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX1_DMAMUX_RG1CR_GNBREQ                      \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX1_DMAMUX_RG2CR_SIG_ID                      \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX1_DMAMUX_RG2CR_OIE                         \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_DMAMUX_RG2CR_GE                          \ DMA request generator channel x enable
$00060000 constant DMAMUX1_DMAMUX_RG2CR_GPOL                        \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX1_DMAMUX_RG2CR_GNBREQ                      \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX1_DMAMUX_RG3CR_SIG_ID                      \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX1_DMAMUX_RG3CR_OIE                         \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_DMAMUX_RG3CR_GE                          \ DMA request generator channel x enable
$00060000 constant DMAMUX1_DMAMUX_RG3CR_GPOL                        \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX1_DMAMUX_RG3CR_GNBREQ                      \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX1_DMAMUX_RG4CR_SIG_ID                      \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX1_DMAMUX_RG4CR_OIE                         \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_DMAMUX_RG4CR_GE                          \ DMA request generator channel x enable
$00060000 constant DMAMUX1_DMAMUX_RG4CR_GPOL                        \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX1_DMAMUX_RG4CR_GNBREQ                      \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX1_DMAMUX_RG5CR_SIG_ID                      \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX1_DMAMUX_RG5CR_OIE                         \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_DMAMUX_RG5CR_GE                          \ DMA request generator channel x enable
$00060000 constant DMAMUX1_DMAMUX_RG5CR_GPOL                        \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX1_DMAMUX_RG5CR_GNBREQ                      \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX1_DMAMUX_RG6CR_SIG_ID                      \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX1_DMAMUX_RG6CR_OIE                         \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_DMAMUX_RG6CR_GE                          \ DMA request generator channel x enable
$00060000 constant DMAMUX1_DMAMUX_RG6CR_GPOL                        \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX1_DMAMUX_RG6CR_GNBREQ                      \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000007 constant DMAMUX1_DMAMUX_RG7CR_SIG_ID                      \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX1_DMAMUX_RG7CR_OIE                         \ Trigger overrun interrupt enable
$00010000 constant DMAMUX1_DMAMUX_RG7CR_GE                          \ DMA request generator channel x enable
$00060000 constant DMAMUX1_DMAMUX_RG7CR_GPOL                        \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX1_DMAMUX_RG7CR_GNBREQ                      \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_DMAMUX_RGSR_OF0                          \ [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
$00000002 constant DMAMUX1_DMAMUX_RGSR_OF1                          \ [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
$00000004 constant DMAMUX1_DMAMUX_RGSR_OF2                          \ [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
$00000008 constant DMAMUX1_DMAMUX_RGSR_OF3                          \ [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
$00000010 constant DMAMUX1_DMAMUX_RGSR_OF4                          \ [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
$00000020 constant DMAMUX1_DMAMUX_RGSR_OF5                          \ [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
$00000040 constant DMAMUX1_DMAMUX_RGSR_OF6                          \ [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
$00000080 constant DMAMUX1_DMAMUX_RGSR_OF7                          \ [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.


\
\ @brief Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX1_DMAMUX_RGCFR_COF0                        \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
$00000002 constant DMAMUX1_DMAMUX_RGCFR_COF1                        \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
$00000004 constant DMAMUX1_DMAMUX_RGCFR_COF2                        \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
$00000008 constant DMAMUX1_DMAMUX_RGCFR_COF3                        \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
$00000010 constant DMAMUX1_DMAMUX_RGCFR_COF4                        \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
$00000020 constant DMAMUX1_DMAMUX_RGCFR_COF5                        \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
$00000040 constant DMAMUX1_DMAMUX_RGCFR_COF6                        \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
$00000080 constant DMAMUX1_DMAMUX_RGCFR_COF7                        \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.


\
\ @brief DMAMUX
\
$40020800 constant DMAMUX1_DMAMUX_C0CR  \ offset: 0x00 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020804 constant DMAMUX1_DMAMUX_C1CR  \ offset: 0x04 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020808 constant DMAMUX1_DMAMUX_C2CR  \ offset: 0x08 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$4002080c constant DMAMUX1_DMAMUX_C3CR  \ offset: 0x0C : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020810 constant DMAMUX1_DMAMUX_C4CR  \ offset: 0x10 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020814 constant DMAMUX1_DMAMUX_C5CR  \ offset: 0x14 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020818 constant DMAMUX1_DMAMUX_C6CR  \ offset: 0x18 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$4002081c constant DMAMUX1_DMAMUX_C7CR  \ offset: 0x1C : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020820 constant DMAMUX1_DMAMUX_C8CR  \ offset: 0x20 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020824 constant DMAMUX1_DMAMUX_C9CR  \ offset: 0x24 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020828 constant DMAMUX1_DMAMUX_C10CR  \ offset: 0x28 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$4002082c constant DMAMUX1_DMAMUX_C11CR  \ offset: 0x2C : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020830 constant DMAMUX1_DMAMUX_C12CR  \ offset: 0x30 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020834 constant DMAMUX1_DMAMUX_C13CR  \ offset: 0x34 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020838 constant DMAMUX1_DMAMUX_C14CR  \ offset: 0x38 : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$4002083c constant DMAMUX1_DMAMUX_C15CR  \ offset: 0x3C : DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$40020880 constant DMAMUX1_DMAMUX_CSR  \ offset: 0x80 : Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
$40020884 constant DMAMUX1_DMAMUX_CFR  \ offset: 0x84 : Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$40020900 constant DMAMUX1_DMAMUX_RG0CR  \ offset: 0x100 : Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$40020904 constant DMAMUX1_DMAMUX_RG1CR  \ offset: 0x104 : Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$40020908 constant DMAMUX1_DMAMUX_RG2CR  \ offset: 0x108 : Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$4002090c constant DMAMUX1_DMAMUX_RG3CR  \ offset: 0x10C : Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$40020910 constant DMAMUX1_DMAMUX_RG4CR  \ offset: 0x110 : Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$40020914 constant DMAMUX1_DMAMUX_RG5CR  \ offset: 0x114 : Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$40020918 constant DMAMUX1_DMAMUX_RG6CR  \ offset: 0x118 : Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$4002091c constant DMAMUX1_DMAMUX_RG7CR  \ offset: 0x11C : Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$40020940 constant DMAMUX1_DMAMUX_RGSR  \ offset: 0x140 : [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
$40020944 constant DMAMUX1_DMAMUX_RGCFR  \ offset: 0x144 : Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.

