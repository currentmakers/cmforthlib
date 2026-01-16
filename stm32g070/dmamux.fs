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

$000000ff constant DMAMUX_DMAMUX_C0CR_DMAREQ_ID                     \ Input DMA request line selected
$00000100 constant DMAMUX_DMAMUX_C0CR_SOIE                          \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_DMAMUX_C0CR_EGE                           \ Event generation enable/disable
$00010000 constant DMAMUX_DMAMUX_C0CR_SE                            \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_DMAMUX_C0CR_SPOL                          \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C0CR_NBREQ                         \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_DMAMUX_C0CR_SYNC_ID                       \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_DMAMUX_C1CR_DMAREQ_ID                     \ Input DMA request line selected
$00000100 constant DMAMUX_DMAMUX_C1CR_SOIE                          \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_DMAMUX_C1CR_EGE                           \ Event generation enable/disable
$00010000 constant DMAMUX_DMAMUX_C1CR_SE                            \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_DMAMUX_C1CR_SPOL                          \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C1CR_NBREQ                         \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_DMAMUX_C1CR_SYNC_ID                       \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_DMAMUX_C2CR_DMAREQ_ID                     \ Input DMA request line selected
$00000100 constant DMAMUX_DMAMUX_C2CR_SOIE                          \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_DMAMUX_C2CR_EGE                           \ Event generation enable/disable
$00010000 constant DMAMUX_DMAMUX_C2CR_SE                            \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_DMAMUX_C2CR_SPOL                          \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C2CR_NBREQ                         \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_DMAMUX_C2CR_SYNC_ID                       \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_DMAMUX_C3CR_DMAREQ_ID                     \ Input DMA request line selected
$00000100 constant DMAMUX_DMAMUX_C3CR_SOIE                          \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_DMAMUX_C3CR_EGE                           \ Event generation enable/disable
$00010000 constant DMAMUX_DMAMUX_C3CR_SE                            \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_DMAMUX_C3CR_SPOL                          \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C3CR_NBREQ                         \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_DMAMUX_C3CR_SYNC_ID                       \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_DMAMUX_C4CR_DMAREQ_ID                     \ Input DMA request line selected
$00000100 constant DMAMUX_DMAMUX_C4CR_SOIE                          \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_DMAMUX_C4CR_EGE                           \ Event generation enable/disable
$00010000 constant DMAMUX_DMAMUX_C4CR_SE                            \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_DMAMUX_C4CR_SPOL                          \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C4CR_NBREQ                         \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_DMAMUX_C4CR_SYNC_ID                       \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_DMAMUX_C5CR_DMAREQ_ID                     \ Input DMA request line selected
$00000100 constant DMAMUX_DMAMUX_C5CR_SOIE                          \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_DMAMUX_C5CR_EGE                           \ Event generation enable/disable
$00010000 constant DMAMUX_DMAMUX_C5CR_SE                            \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_DMAMUX_C5CR_SPOL                          \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C5CR_NBREQ                         \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_DMAMUX_C5CR_SYNC_ID                       \ Synchronization input selected


\
\ @brief DMAMux - DMA request line multiplexer channel x control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant DMAMUX_DMAMUX_C6CR_DMAREQ_ID                     \ Input DMA request line selected
$00000100 constant DMAMUX_DMAMUX_C6CR_SOIE                          \ Interrupt enable at synchronization event overrun
$00000200 constant DMAMUX_DMAMUX_C6CR_EGE                           \ Event generation enable/disable
$00010000 constant DMAMUX_DMAMUX_C6CR_SE                            \ Synchronous operating mode enable/disable
$00060000 constant DMAMUX_DMAMUX_C6CR_SPOL                          \ Synchronization event type selector Defines the synchronization event on the selected synchronization input:
$00f80000 constant DMAMUX_DMAMUX_C6CR_NBREQ                         \ Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
$1f000000 constant DMAMUX_DMAMUX_C6CR_SYNC_ID                       \ Synchronization input selected


\
\ @brief DMAMUX request line multiplexer interrupt channel status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_CSR_SOF                            \ Synchronization overrun event flag


\
\ @brief DMAMUX request line multiplexer interrupt clear flag register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000007f constant DMAMUX_DMAMUX_CFR_CSOF                           \ Clear synchronization overrun event flag


\
\ @brief DMAMux - DMA request generator channel x control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_DMAMUX_RG0CR_SIG_ID                       \ DMA request trigger input selected
$00000100 constant DMAMUX_DMAMUX_RG0CR_OIE                          \ Interrupt enable at trigger event overrun
$00010000 constant DMAMUX_DMAMUX_RG0CR_GE                           \ DMA request generator channel enable/disable
$00060000 constant DMAMUX_DMAMUX_RG0CR_GPOL                         \ DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
$00f80000 constant DMAMUX_DMAMUX_RG0CR_GNBREQ                       \ Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.


\
\ @brief DMAMux - DMA request generator channel x control register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_DMAMUX_RG1CR_SIG_ID                       \ DMA request trigger input selected
$00000100 constant DMAMUX_DMAMUX_RG1CR_OIE                          \ Interrupt enable at trigger event overrun
$00010000 constant DMAMUX_DMAMUX_RG1CR_GE                           \ DMA request generator channel enable/disable
$00060000 constant DMAMUX_DMAMUX_RG1CR_GPOL                         \ DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
$00f80000 constant DMAMUX_DMAMUX_RG1CR_GNBREQ                       \ Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.


\
\ @brief DMAMux - DMA request generator channel x control register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_DMAMUX_RG2CR_SIG_ID                       \ DMA request trigger input selected
$00000100 constant DMAMUX_DMAMUX_RG2CR_OIE                          \ Interrupt enable at trigger event overrun
$00010000 constant DMAMUX_DMAMUX_RG2CR_GE                           \ DMA request generator channel enable/disable
$00060000 constant DMAMUX_DMAMUX_RG2CR_GPOL                         \ DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
$00f80000 constant DMAMUX_DMAMUX_RG2CR_GNBREQ                       \ Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.


\
\ @brief DMAMux - DMA request generator channel x control register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000001f constant DMAMUX_DMAMUX_RG3CR_SIG_ID                       \ DMA request trigger input selected
$00000100 constant DMAMUX_DMAMUX_RG3CR_OIE                          \ Interrupt enable at trigger event overrun
$00010000 constant DMAMUX_DMAMUX_RG3CR_GE                           \ DMA request generator channel enable/disable
$00060000 constant DMAMUX_DMAMUX_RG3CR_GPOL                         \ DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
$00f80000 constant DMAMUX_DMAMUX_RG3CR_GNBREQ                       \ Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.


\
\ @brief DMAMux - DMA request generator status register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$0000000f constant DMAMUX_DMAMUX_RGSR_OF                            \ Trigger event overrun flag The flag is set when a trigger event occurs on DMA request generator channel x, while the DMA request generator counter value is lower than GNBREQ. The flag is cleared by writing 1 to the corresponding COFx bit in DMAMUX_RGCFR register.


\
\ @brief DMAMux - DMA request generator clear flag register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$0000000f constant DMAMUX_DMAMUX_RGCFR_COF                          \ Clear trigger event overrun flag Upon setting, this bit clears the corresponding overrun flag OFx in the DMAMUX_RGCSR register.


\
\ @brief DMAMUX hardware configuration 2 register
\ Address offset: 0x3EC
\ Reset value: 0x00000017
\

$000000ff constant DMAMUX_DMAMUX_HWCFGR2_NUM_DMA_EXT_REQ            \ Number of DMA request trigger inputs


\
\ @brief DMAMUX hardware configuration 1 register
\ Address offset: 0x3F0
\ Reset value: 0x04173907
\

$000000ff constant DMAMUX_DMAMUX_HWCFGR1_NUM_DMA_STREAMS            \ number of DMA request line multiplexer (output) channels
$0000ff00 constant DMAMUX_DMAMUX_HWCFGR1_NUM_DMA_PERIPH_REQ         \ number of DMA request lines from peripherals
$00ff0000 constant DMAMUX_DMAMUX_HWCFGR1_NUM_DMA_TRIG               \ number of synchronization inputs
$ff000000 constant DMAMUX_DMAMUX_HWCFGR1_NUM_DMA_REQGEN             \ number of DMA request generator channels


\
\ @brief DMAMUX version register
\ Address offset: 0x3F4
\ Reset value: 0x00000011
\

$0000000f constant DMAMUX_DMAMUX_VERR_MINREV                        \ Minor IP revision
$000000f0 constant DMAMUX_DMAMUX_VERR_MAJREV                        \ Major IP revision


\
\ @brief DMAMUX IP identification register
\ Address offset: 0x3F8
\ Reset value: 0x00100011
\

$00000000 constant DMAMUX_DMAMUX_IPIDR_ID                           \ IP identification


\
\ @brief DMAMUX size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant DMAMUX_DMAMUX_SIDR_SID                           \ Size identification


\
\ @brief DMAMUX
\
$40020800 constant DMAMUX_DMAMUX_C0CR  \ offset: 0x00 : DMAMux - DMA request line multiplexer channel x control register
$40020804 constant DMAMUX_DMAMUX_C1CR  \ offset: 0x04 : DMAMux - DMA request line multiplexer channel x control register
$40020808 constant DMAMUX_DMAMUX_C2CR  \ offset: 0x08 : DMAMux - DMA request line multiplexer channel x control register
$4002080c constant DMAMUX_DMAMUX_C3CR  \ offset: 0x0C : DMAMux - DMA request line multiplexer channel x control register
$40020810 constant DMAMUX_DMAMUX_C4CR  \ offset: 0x10 : DMAMux - DMA request line multiplexer channel x control register
$40020814 constant DMAMUX_DMAMUX_C5CR  \ offset: 0x14 : DMAMux - DMA request line multiplexer channel x control register
$40020818 constant DMAMUX_DMAMUX_C6CR  \ offset: 0x18 : DMAMux - DMA request line multiplexer channel x control register
$40020880 constant DMAMUX_DMAMUX_CSR  \ offset: 0x80 : DMAMUX request line multiplexer interrupt channel status register
$40020884 constant DMAMUX_DMAMUX_CFR  \ offset: 0x84 : DMAMUX request line multiplexer interrupt clear flag register
$40020900 constant DMAMUX_DMAMUX_RG0CR  \ offset: 0x100 : DMAMux - DMA request generator channel x control register
$40020904 constant DMAMUX_DMAMUX_RG1CR  \ offset: 0x104 : DMAMux - DMA request generator channel x control register
$40020908 constant DMAMUX_DMAMUX_RG2CR  \ offset: 0x108 : DMAMux - DMA request generator channel x control register
$4002090c constant DMAMUX_DMAMUX_RG3CR  \ offset: 0x10C : DMAMux - DMA request generator channel x control register
$40020940 constant DMAMUX_DMAMUX_RGSR  \ offset: 0x140 : DMAMux - DMA request generator status register
$40020944 constant DMAMUX_DMAMUX_RGCFR  \ offset: 0x144 : DMAMux - DMA request generator clear flag register
$40020bec constant DMAMUX_DMAMUX_HWCFGR2  \ offset: 0x3EC : DMAMUX hardware configuration 2 register
$40020bf0 constant DMAMUX_DMAMUX_HWCFGR1  \ offset: 0x3F0 : DMAMUX hardware configuration 1 register
$40020bf4 constant DMAMUX_DMAMUX_VERR  \ offset: 0x3F4 : DMAMUX version register
$40020bf8 constant DMAMUX_DMAMUX_IPIDR  \ offset: 0x3F8 : DMAMUX IP identification register
$40020bfc constant DMAMUX_DMAMUX_SIDR  \ offset: 0x3FC : DMAMUX size identification register

