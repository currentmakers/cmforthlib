\
\ @file dmamux.fs
\ @brief DMAMUX
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMAMUX_DEF

  [ifdef] DMAMUX_C0CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX_SOIE                    \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable/disable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX_C1CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX_SOIE                    \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable/disable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX_C2CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX_SOIE                    \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable/disable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX_C3CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX_SOIE                    \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable/disable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX_C4CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX_SOIE                    \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable/disable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX_C5CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX_SOIE                    \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable/disable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX_C6CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX_SOIE                    \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable/disable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX_RG0CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX_OIE                     \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX_RG1CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX_OIE                     \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX_RG2CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX_OIE                     \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX_RG3CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX_OIE                     \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX_RGSR_DEF
    \
    \ @brief DMAMux - DMA request generator status register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_OF                      \ [0x00 : 4] Trigger event overrun flag The flag is set when a trigger event occurs on DMA request generator channel x, while the DMA request generator counter value is lower than GNBREQ. The flag is cleared by writing 1 to the corresponding COFx bit in DMAMUX_RGCFR register.
  [then]


  [ifdef] DMAMUX_RGCFR_DEF
    \
    \ @brief DMAMux - DMA request generator clear flag register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_COF                     \ [0x00 : 4] Clear trigger event overrun flag Upon setting, this bit clears the corresponding overrun flag OFx in the DMAMUX_RGCSR register.
  [then]

  \
  \ @brief DMAMUX
  \
  $00 constant DMAMUX_C0CR              \ DMAMux - DMA request line multiplexer channel x control register
  $04 constant DMAMUX_C1CR              \ DMAMux - DMA request line multiplexer channel x control register
  $08 constant DMAMUX_C2CR              \ DMAMux - DMA request line multiplexer channel x control register
  $0C constant DMAMUX_C3CR              \ DMAMux - DMA request line multiplexer channel x control register
  $10 constant DMAMUX_C4CR              \ DMAMux - DMA request line multiplexer channel x control register
  $14 constant DMAMUX_C5CR              \ DMAMux - DMA request line multiplexer channel x control register
  $18 constant DMAMUX_C6CR              \ DMAMux - DMA request line multiplexer channel x control register
  $100 constant DMAMUX_RG0CR            \ DMAMux - DMA request generator channel x control register
  $104 constant DMAMUX_RG1CR            \ DMAMux - DMA request generator channel x control register
  $108 constant DMAMUX_RG2CR            \ DMAMux - DMA request generator channel x control register
  $10C constant DMAMUX_RG3CR            \ DMAMux - DMA request generator channel x control register
  $140 constant DMAMUX_RGSR             \ DMAMux - DMA request generator status register
  $144 constant DMAMUX_RGCFR            \ DMAMux - DMA request generator clear flag register

: DMAMUX_DEF ; [then]
