\
\ @file dmamux.fs
\ @brief DMAMUX address block description
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

$0000007f constant DMAMUX_DMAMUX_C0CR_DMAREQ_ID                     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C0CR_SOIE                          \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C0CR_EGE                           \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C0CR_SE                            \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C0CR_SPOL                          \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C0CR_NBREQ                         \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C0CR_SYNC_ID                       \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer channel 1 configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_C1CR_DMAREQ_ID                     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C1CR_SOIE                          \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C1CR_EGE                           \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C1CR_SE                            \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C1CR_SPOL                          \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C1CR_NBREQ                         \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C1CR_SYNC_ID                       \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer channel 2 configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_C2CR_DMAREQ_ID                     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C2CR_SOIE                          \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C2CR_EGE                           \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C2CR_SE                            \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C2CR_SPOL                          \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C2CR_NBREQ                         \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C2CR_SYNC_ID                       \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer channel 3 configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_C3CR_DMAREQ_ID                     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C3CR_SOIE                          \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C3CR_EGE                           \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C3CR_SE                            \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C3CR_SPOL                          \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C3CR_NBREQ                         \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C3CR_SYNC_ID                       \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer channel 4 configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_C4CR_DMAREQ_ID                     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C4CR_SOIE                          \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C4CR_EGE                           \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C4CR_SE                            \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C4CR_SPOL                          \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C4CR_NBREQ                         \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C4CR_SYNC_ID                       \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer channel 5 configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_C5CR_DMAREQ_ID                     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C5CR_SOIE                          \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C5CR_EGE                           \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C5CR_SE                            \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C5CR_SPOL                          \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C5CR_NBREQ                         \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C5CR_SYNC_ID                       \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer channel 6 configuration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_C6CR_DMAREQ_ID                     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C6CR_SOIE                          \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C6CR_EGE                           \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C6CR_SE                            \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C6CR_SPOL                          \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C6CR_NBREQ                         \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C6CR_SYNC_ID                       \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer channel 7 configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_C7CR_DMAREQ_ID                     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C7CR_SOIE                          \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C7CR_EGE                           \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C7CR_SE                            \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C7CR_SPOL                          \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C7CR_NBREQ                         \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C7CR_SYNC_ID                       \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer channel 8 configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_C8CR_DMAREQ_ID                     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C8CR_SOIE                          \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C8CR_EGE                           \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C8CR_SE                            \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C8CR_SPOL                          \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C8CR_NBREQ                         \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C8CR_SYNC_ID                       \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer channel 9 configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_C9CR_DMAREQ_ID                     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C9CR_SOIE                          \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C9CR_EGE                           \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C9CR_SE                            \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C9CR_SPOL                          \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C9CR_NBREQ                         \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C9CR_SYNC_ID                       \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer channel 10 configuration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_C10CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C10CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C10CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C10CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C10CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C10CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C10CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer channel 11 configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_C11CR_DMAREQ_ID                    \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
$00000100 constant DMAMUX_DMAMUX_C11CR_SOIE                         \ Synchronization overrun interrupt enable
$00000200 constant DMAMUX_DMAMUX_C11CR_EGE                          \ Event generation enable
$00010000 constant DMAMUX_DMAMUX_C11CR_SE                           \ Synchronization enable
$00060000 constant DMAMUX_DMAMUX_C11CR_SPOL                         \ Synchronization polarity Defines the edge polarity of the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C11CR_NBREQ                        \ Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field must only be written when both SE and EGE bits are low.
$1f000000 constant DMAMUX_DMAMUX_C11CR_SYNC_ID                      \ Synchronization identification Selects the synchronization input (see Table137: DMAMUX: assignment of synchronization inputs to resources).


\
\ @brief DMAMUX request line multiplexer interrupt channel status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_DMAMUX_CSR_SOF0                           \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
$00000002 constant DMAMUX_DMAMUX_CSR_SOF1                           \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
$00000004 constant DMAMUX_DMAMUX_CSR_SOF2                           \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
$00000008 constant DMAMUX_DMAMUX_CSR_SOF3                           \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
$00000010 constant DMAMUX_DMAMUX_CSR_SOF4                           \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
$00000020 constant DMAMUX_DMAMUX_CSR_SOF5                           \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
$00000040 constant DMAMUX_DMAMUX_CSR_SOF6                           \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
$00000080 constant DMAMUX_DMAMUX_CSR_SOF7                           \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
$00000100 constant DMAMUX_DMAMUX_CSR_SOF8                           \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
$00000200 constant DMAMUX_DMAMUX_CSR_SOF9                           \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
$00000400 constant DMAMUX_DMAMUX_CSR_SOF10                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
$00000800 constant DMAMUX_DMAMUX_CSR_SOF11                          \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.


\
\ @brief DMAMUX request line multiplexer interrupt clear flag register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_DMAMUX_CFR_CSOF0                          \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000002 constant DMAMUX_DMAMUX_CFR_CSOF1                          \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000004 constant DMAMUX_DMAMUX_CFR_CSOF2                          \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000008 constant DMAMUX_DMAMUX_CFR_CSOF3                          \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000010 constant DMAMUX_DMAMUX_CFR_CSOF4                          \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000020 constant DMAMUX_DMAMUX_CFR_CSOF5                          \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000040 constant DMAMUX_DMAMUX_CFR_CSOF6                          \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000080 constant DMAMUX_DMAMUX_CFR_CSOF7                          \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000100 constant DMAMUX_DMAMUX_CFR_CSOF8                          \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000200 constant DMAMUX_DMAMUX_CFR_CSOF9                          \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000400 constant DMAMUX_DMAMUX_CFR_CSOF10                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
$00000800 constant DMAMUX_DMAMUX_CFR_CSOF11                         \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.


\
\ @brief DMAMUX request generator channel 0 configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_DMAMUX_RG0CR_SIG_ID                       \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX_DMAMUX_RG0CR_OIE                          \ Trigger overrun interrupt enable
$00010000 constant DMAMUX_DMAMUX_RG0CR_GE                           \ DMA request generator channel x enable
$00060000 constant DMAMUX_DMAMUX_RG0CR_GPOL                         \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX_DMAMUX_RG0CR_GNBREQ                       \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief DMAMUX request generator channel 1 configuration register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_DMAMUX_RG1CR_SIG_ID                       \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX_DMAMUX_RG1CR_OIE                          \ Trigger overrun interrupt enable
$00010000 constant DMAMUX_DMAMUX_RG1CR_GE                           \ DMA request generator channel x enable
$00060000 constant DMAMUX_DMAMUX_RG1CR_GPOL                         \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX_DMAMUX_RG1CR_GNBREQ                       \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief DMAMUX request generator channel 2 configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_DMAMUX_RG2CR_SIG_ID                       \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX_DMAMUX_RG2CR_OIE                          \ Trigger overrun interrupt enable
$00010000 constant DMAMUX_DMAMUX_RG2CR_GE                           \ DMA request generator channel x enable
$00060000 constant DMAMUX_DMAMUX_RG2CR_GPOL                         \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX_DMAMUX_RG2CR_GNBREQ                       \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief DMAMUX request generator channel 3 configuration register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_DMAMUX_RG3CR_SIG_ID                       \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
$00000100 constant DMAMUX_DMAMUX_RG3CR_OIE                          \ Trigger overrun interrupt enable
$00010000 constant DMAMUX_DMAMUX_RG3CR_GE                           \ DMA request generator channel x enable
$00060000 constant DMAMUX_DMAMUX_RG3CR_GPOL                         \ DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
$00f80000 constant DMAMUX_DMAMUX_RG3CR_GNBREQ                       \ Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.


\
\ @brief DMAMUX request generator interrupt status register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_DMAMUX_RGSR_OF0                           \ Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
$00000002 constant DMAMUX_DMAMUX_RGSR_OF1                           \ Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
$00000004 constant DMAMUX_DMAMUX_RGSR_OF2                           \ Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
$00000008 constant DMAMUX_DMAMUX_RGSR_OF3                           \ Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.


\
\ @brief DMAMUX request generator interrupt clear flag register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant DMAMUX_DMAMUX_RGCFR_COF0                         \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
$00000002 constant DMAMUX_DMAMUX_RGCFR_COF1                         \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
$00000004 constant DMAMUX_DMAMUX_RGCFR_COF2                         \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
$00000008 constant DMAMUX_DMAMUX_RGCFR_COF3                         \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.


\
\ @brief DMAMUX address block description
\
$40020800 constant DMAMUX_DMAMUX_C0CR  \ offset: 0x00 : DMAMUX request line multiplexer channel 0 configuration register
$40020804 constant DMAMUX_DMAMUX_C1CR  \ offset: 0x04 : DMAMUX request line multiplexer channel 1 configuration register
$40020808 constant DMAMUX_DMAMUX_C2CR  \ offset: 0x08 : DMAMUX request line multiplexer channel 2 configuration register
$4002080c constant DMAMUX_DMAMUX_C3CR  \ offset: 0x0C : DMAMUX request line multiplexer channel 3 configuration register
$40020810 constant DMAMUX_DMAMUX_C4CR  \ offset: 0x10 : DMAMUX request line multiplexer channel 4 configuration register
$40020814 constant DMAMUX_DMAMUX_C5CR  \ offset: 0x14 : DMAMUX request line multiplexer channel 5 configuration register
$40020818 constant DMAMUX_DMAMUX_C6CR  \ offset: 0x18 : DMAMUX request line multiplexer channel 6 configuration register
$4002081c constant DMAMUX_DMAMUX_C7CR  \ offset: 0x1C : DMAMUX request line multiplexer channel 7 configuration register
$40020820 constant DMAMUX_DMAMUX_C8CR  \ offset: 0x20 : DMAMUX request line multiplexer channel 8 configuration register
$40020824 constant DMAMUX_DMAMUX_C9CR  \ offset: 0x24 : DMAMUX request line multiplexer channel 9 configuration register
$40020828 constant DMAMUX_DMAMUX_C10CR  \ offset: 0x28 : DMAMUX request line multiplexer channel 10 configuration register
$4002082c constant DMAMUX_DMAMUX_C11CR  \ offset: 0x2C : DMAMUX request line multiplexer channel 11 configuration register
$40020880 constant DMAMUX_DMAMUX_CSR  \ offset: 0x80 : DMAMUX request line multiplexer interrupt channel status register
$40020884 constant DMAMUX_DMAMUX_CFR  \ offset: 0x84 : DMAMUX request line multiplexer interrupt clear flag register
$40020900 constant DMAMUX_DMAMUX_RG0CR  \ offset: 0x100 : DMAMUX request generator channel 0 configuration register
$40020904 constant DMAMUX_DMAMUX_RG1CR  \ offset: 0x104 : DMAMUX request generator channel 1 configuration register
$40020908 constant DMAMUX_DMAMUX_RG2CR  \ offset: 0x108 : DMAMUX request generator channel 2 configuration register
$4002090c constant DMAMUX_DMAMUX_RG3CR  \ offset: 0x10C : DMAMUX request generator channel 3 configuration register
$40020940 constant DMAMUX_DMAMUX_RGSR  \ offset: 0x140 : DMAMUX request generator interrupt status register
$40020944 constant DMAMUX_DMAMUX_RGCFR  \ offset: 0x144 : DMAMUX request generator interrupt clear flag register

