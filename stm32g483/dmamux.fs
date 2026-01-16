\
\ @file dmamux.fs
\ @brief DMAMUX
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C0CR_DMAREQ_ID                            \ Input DMA request line selected
$00000100 constant DMAMUX_C0CR_SOIE                                 \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C0CR_EGE                                  \ Event generation enable/disable
$00010000 constant DMAMUX_C0CR_SE                                   \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C0CR_SPOL                                 \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C0CR_NBREQ                                \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C0CR_SYNC_ID                              \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C1CR_DMAREQ_ID                            \ Input DMA request line selected
$00000100 constant DMAMUX_C1CR_SOIE                                 \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C1CR_EGE                                  \ Event generation enable/disable
$00010000 constant DMAMUX_C1CR_SE                                   \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C1CR_SPOL                                 \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C1CR_NBREQ                                \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C1CR_SYNC_ID                              \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C2CR_DMAREQ_ID                            \ Input DMA request line selected
$00000100 constant DMAMUX_C2CR_SOIE                                 \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C2CR_EGE                                  \ Event generation enable/disable
$00010000 constant DMAMUX_C2CR_SE                                   \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C2CR_SPOL                                 \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C2CR_NBREQ                                \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C2CR_SYNC_ID                              \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C3CR_DMAREQ_ID                            \ Input DMA request line selected
$00000100 constant DMAMUX_C3CR_SOIE                                 \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C3CR_EGE                                  \ Event generation enable/disable
$00010000 constant DMAMUX_C3CR_SE                                   \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C3CR_SPOL                                 \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C3CR_NBREQ                                \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C3CR_SYNC_ID                              \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C4CR_DMAREQ_ID                            \ Input DMA request line selected
$00000100 constant DMAMUX_C4CR_SOIE                                 \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C4CR_EGE                                  \ Event generation enable/disable
$00010000 constant DMAMUX_C4CR_SE                                   \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C4CR_SPOL                                 \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C4CR_NBREQ                                \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C4CR_SYNC_ID                              \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C5CR_DMAREQ_ID                            \ Input DMA request line selected
$00000100 constant DMAMUX_C5CR_SOIE                                 \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C5CR_EGE                                  \ Event generation enable/disable
$00010000 constant DMAMUX_C5CR_SE                                   \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C5CR_SPOL                                 \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C5CR_NBREQ                                \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C5CR_SYNC_ID                              \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C6CR_DMAREQ_ID                            \ Input DMA request line selected
$00000100 constant DMAMUX_C6CR_SOIE                                 \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C6CR_EGE                                  \ Event generation enable/disable
$00010000 constant DMAMUX_C6CR_SE                                   \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C6CR_SPOL                                 \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C6CR_NBREQ                                \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C6CR_SYNC_ID                              \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C7CR_DMAREQ_ID                            \ Input DMA request line selected
$00000100 constant DMAMUX_C7CR_SOIE                                 \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C7CR_EGE                                  \ Event generation enable/disable
$00010000 constant DMAMUX_C7CR_SE                                   \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C7CR_SPOL                                 \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C7CR_NBREQ                                \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C7CR_SYNC_ID                              \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C8CR_DMAREQ_ID                            \ Input DMA request line selected
$00000100 constant DMAMUX_C8CR_SOIE                                 \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C8CR_EGE                                  \ Event generation enable/disable
$00010000 constant DMAMUX_C8CR_SE                                   \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C8CR_SPOL                                 \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C8CR_NBREQ                                \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C8CR_SYNC_ID                              \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C9CR_DMAREQ_ID                            \ Input DMA request line selected
$00000100 constant DMAMUX_C9CR_SOIE                                 \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C9CR_EGE                                  \ Event generation enable/disable
$00010000 constant DMAMUX_C9CR_SE                                   \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C9CR_SPOL                                 \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C9CR_NBREQ                                \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C9CR_SYNC_ID                              \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C10CR_DMAREQ_ID                           \ Input DMA request line selected
$00000100 constant DMAMUX_C10CR_SOIE                                \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C10CR_EGE                                 \ Event generation enable/disable
$00010000 constant DMAMUX_C10CR_SE                                  \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C10CR_SPOL                                \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C10CR_NBREQ                               \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C10CR_SYNC_ID                             \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C11CR_DMAREQ_ID                           \ Input DMA request line selected
$00000100 constant DMAMUX_C11CR_SOIE                                \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C11CR_EGE                                 \ Event generation enable/disable
$00010000 constant DMAMUX_C11CR_SE                                  \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C11CR_SPOL                                \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C11CR_NBREQ                               \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C11CR_SYNC_ID                             \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C12CR_DMAREQ_ID                           \ Input DMA request line selected
$00000100 constant DMAMUX_C12CR_SOIE                                \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C12CR_EGE                                 \ Event generation enable/disable
$00010000 constant DMAMUX_C12CR_SE                                  \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C12CR_SPOL                                \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C12CR_NBREQ                               \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C12CR_SYNC_ID                             \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C13CR_DMAREQ_ID                           \ Input DMA request line selected
$00000100 constant DMAMUX_C13CR_SOIE                                \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C13CR_EGE                                 \ Event generation enable/disable
$00010000 constant DMAMUX_C13CR_SE                                  \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C13CR_SPOL                                \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C13CR_NBREQ                               \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C13CR_SYNC_ID                             \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C14CR_DMAREQ_ID                           \ Input DMA request line selected
$00000100 constant DMAMUX_C14CR_SOIE                                \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C14CR_EGE                                 \ Event generation enable/disable
$00010000 constant DMAMUX_C14CR_SE                                  \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C14CR_SPOL                                \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C14CR_NBREQ                               \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C14CR_SYNC_ID                             \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_C15CR_DMAREQ_ID                           \ Input DMA request line selected
$00000100 constant DMAMUX_C15CR_SOIE                                \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_C15CR_EGE                                 \ Event generation enable/disable
$00010000 constant DMAMUX_C15CR_SE                                  \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_C15CR_SPOL                                \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_C15CR_NBREQ                               \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_C15CR_SYNC_ID                             \ Synchronization input selected


\
\ @brief DMAMUX request line multiplexer interrupt channel status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant DMAMUX_CSR_SOF                                   \ Synchronization overrun event flag


\
\ @brief DMAMUX request line multiplexer interrupt clear flag register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant DMAMUX_CFR_CSOF                                  \ Clear synchronization overrun event flag


\
\ @brief DMAMux - DMA request generator channel x control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG0CR_SIG_ID                              \ DMA request trigger input selected
$00000100 constant DMAMUX_RG0CR_OIE                                 \ Interrupt enable at trigger event overrun
$00010000 constant DMAMUX_RG0CR_GE                                  \ DMA request generator channel enable/disable
$00060000 constant DMAMUX_RG0CR_GPOL                                \ DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
$00f80000 constant DMAMUX_RG0CR_GNBREQ                              \ Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.


\
\ @brief DMAMux - DMA request generator channel x control register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG1CR_SIG_ID                              \ DMA request trigger input selected
$00000100 constant DMAMUX_RG1CR_OIE                                 \ Interrupt enable at trigger event overrun
$00010000 constant DMAMUX_RG1CR_GE                                  \ DMA request generator channel enable/disable
$00060000 constant DMAMUX_RG1CR_GPOL                                \ DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
$00f80000 constant DMAMUX_RG1CR_GNBREQ                              \ Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.


\
\ @brief DMAMux - DMA request generator channel x control register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG2CR_SIG_ID                              \ DMA request trigger input selected
$00000100 constant DMAMUX_RG2CR_OIE                                 \ Interrupt enable at trigger event overrun
$00010000 constant DMAMUX_RG2CR_GE                                  \ DMA request generator channel enable/disable
$00060000 constant DMAMUX_RG2CR_GPOL                                \ DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
$00f80000 constant DMAMUX_RG2CR_GNBREQ                              \ Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.


\
\ @brief DMAMux - DMA request generator channel x control register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_RG3CR_SIG_ID                              \ DMA request trigger input selected
$00000100 constant DMAMUX_RG3CR_OIE                                 \ Interrupt enable at trigger event overrun
$00010000 constant DMAMUX_RG3CR_GE                                  \ DMA request generator channel enable/disable
$00060000 constant DMAMUX_RG3CR_GPOL                                \ DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
$00f80000 constant DMAMUX_RG3CR_GNBREQ                              \ Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.


\
\ @brief DMAMux - DMA request generator status register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$0000000f constant DMAMUX_RGSR_OF                                   \ Trigger event overrun flag The flag is set when a trigger event occurs on DMA request generator channel x, while the DMA request generator counter value is lower than GNBREQ. The flag is cleared by writing 1 to the corresponding COFx bit in DMAMUX_RGCFR register.


\
\ @brief DMAMux - DMA request generator clear flag register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$0000000f constant DMAMUX_RGCFR_COF                                 \ Clear trigger event overrun flag Upon setting, this bit clears the corresponding overrun flag OFx in the DMAMUX_RGCSR register.


\
\ @brief DMAMUX
\
$40020800 constant DMAMUX_C0CR    \ offset: 0x00 : DMAMux - DMA request line multiplexer channel x control register
$40020804 constant DMAMUX_C1CR    \ offset: 0x04 : DMAMux - DMA request line multiplexer channel x control register
$40020808 constant DMAMUX_C2CR    \ offset: 0x08 : DMAMux - DMA request line multiplexer channel x control register
$4002080c constant DMAMUX_C3CR    \ offset: 0x0C : DMAMux - DMA request line multiplexer channel x control register
$40020810 constant DMAMUX_C4CR    \ offset: 0x10 : DMAMux - DMA request line multiplexer channel x control register
$40020814 constant DMAMUX_C5CR    \ offset: 0x14 : DMAMux - DMA request line multiplexer channel x control register
$40020818 constant DMAMUX_C6CR    \ offset: 0x18 : DMAMux - DMA request line multiplexer channel x control register
$4002081c constant DMAMUX_C7CR    \ offset: 0x1C : DMAMux - DMA request line multiplexer channel x control register
$40020820 constant DMAMUX_C8CR    \ offset: 0x20 : DMAMux - DMA request line multiplexer channel x control register
$40020824 constant DMAMUX_C9CR    \ offset: 0x24 : DMAMux - DMA request line multiplexer channel x control register
$40020828 constant DMAMUX_C10CR   \ offset: 0x28 : DMAMux - DMA request line multiplexer channel x control register
$4002082c constant DMAMUX_C11CR   \ offset: 0x2C : DMAMux - DMA request line multiplexer channel x control register
$40020830 constant DMAMUX_C12CR   \ offset: 0x30 : DMAMux - DMA request line multiplexer channel x control register
$40020834 constant DMAMUX_C13CR   \ offset: 0x34 : DMAMux - DMA request line multiplexer channel x control register
$40020838 constant DMAMUX_C14CR   \ offset: 0x38 : DMAMux - DMA request line multiplexer channel x control register
$4002083c constant DMAMUX_C15CR   \ offset: 0x3C : DMAMux - DMA request line multiplexer channel x control register
$40020880 constant DMAMUX_CSR     \ offset: 0x80 : DMAMUX request line multiplexer interrupt channel status register
$40020884 constant DMAMUX_CFR     \ offset: 0x84 : DMAMUX request line multiplexer interrupt clear flag register
$40020900 constant DMAMUX_RG0CR   \ offset: 0x100 : DMAMux - DMA request generator channel x control register
$40020904 constant DMAMUX_RG1CR   \ offset: 0x104 : DMAMux - DMA request generator channel x control register
$40020908 constant DMAMUX_RG2CR   \ offset: 0x108 : DMAMux - DMA request generator channel x control register
$4002090c constant DMAMUX_RG3CR   \ offset: 0x10C : DMAMux - DMA request generator channel x control register
$40020940 constant DMAMUX_RGSR    \ offset: 0x140 : DMAMux - DMA request generator status register
$40020944 constant DMAMUX_RGCFR   \ offset: 0x144 : DMAMux - DMA request generator clear flag register

