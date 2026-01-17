\
\ @file dmamux2.fs
\ @brief DMAMUX
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMAMUX2_DEF

  [ifdef] DMAMUX2_DMAMUX2_C0CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_DMAREQ_ID              \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX2_SOIE                   \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX2_EGE                    \ [0x09] Event generation enable/disable
    $10 constant DMAMUX2_SE                     \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX2_DMAMUX2_C1CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_DMAREQ_ID              \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX2_SOIE                   \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX2_EGE                    \ [0x09] Event generation enable/disable
    $10 constant DMAMUX2_SE                     \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX2_DMAMUX2_C2CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_DMAREQ_ID              \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX2_SOIE                   \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX2_EGE                    \ [0x09] Event generation enable/disable
    $10 constant DMAMUX2_SE                     \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX2_DMAMUX2_C3CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_DMAREQ_ID              \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX2_SOIE                   \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX2_EGE                    \ [0x09] Event generation enable/disable
    $10 constant DMAMUX2_SE                     \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX2_DMAMUX2_C4CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_DMAREQ_ID              \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX2_SOIE                   \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX2_EGE                    \ [0x09] Event generation enable/disable
    $10 constant DMAMUX2_SE                     \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX2_DMAMUX2_C5CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_DMAREQ_ID              \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX2_SOIE                   \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX2_EGE                    \ [0x09] Event generation enable/disable
    $10 constant DMAMUX2_SE                     \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX2_DMAMUX2_C6CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_DMAREQ_ID              \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX2_SOIE                   \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX2_EGE                    \ [0x09] Event generation enable/disable
    $10 constant DMAMUX2_SE                     \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX2_DMAMUX2_C7CR_DEF
    \
    \ @brief DMAMux - DMA request line multiplexer channel x control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_DMAREQ_ID              \ [0x00 : 8] Input DMA request line selected
    $08 constant DMAMUX2_SOIE                   \ [0x08] Interrupt enable at synchronization event overrun
    $09 constant DMAMUX2_EGE                    \ [0x09] Event generation enable/disable
    $10 constant DMAMUX2_SE                     \ [0x10] Synchronous operating mode enable/disable
    $11 constant DMAMUX2_SPOL                   \ [0x11 : 2] Synchronization event type selector Defines the synchronization event on the selected synchronization input:
    $13 constant DMAMUX2_NBREQ                  \ [0x13 : 5] Number of DMA requests to forward Defines the number of DMA requests forwarded before output event is generated. In synchronous mode, it also defines the number of DMA requests to forward after a synchronization event, then stop forwarding. The actual number of DMA requests forwarded is NBREQ+1. Note: This field can only be written when both SE and EGE bits are reset.
    $18 constant DMAMUX2_SYNC_ID                \ [0x18 : 5] Synchronization input selected
  [then]


  [ifdef] DMAMUX2_DMAMUX2_CSR_DEF
    \
    \ @brief DMAMUX request line multiplexer interrupt channel status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SOF                    \ [0x00 : 16] Synchronization overrun event flag
  [then]


  [ifdef] DMAMUX2_DMAMUX2_CFR_DEF
    \
    \ @brief DMAMUX request line multiplexer interrupt clear flag register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_CSOF                   \ [0x00 : 16] Clear synchronization overrun event flag
  [then]


  [ifdef] DMAMUX2_DMAMUX2_RG0CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX2_OIE                    \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX2_GE                     \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX2_DMAMUX2_RG1CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX2_OIE                    \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX2_GE                     \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX2_DMAMUX2_RG2CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX2_OIE                    \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX2_GE                     \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX2_DMAMUX2_RG3CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX2_OIE                    \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX2_GE                     \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX2_DMAMUX2_RG4CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX2_OIE                    \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX2_GE                     \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX2_DMAMUX2_RG5CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX2_OIE                    \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX2_GE                     \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX2_DMAMUX2_RG6CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX2_OIE                    \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX2_GE                     \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX2_DMAMUX2_RG7CR_DEF
    \
    \ @brief DMAMux - DMA request generator channel x control register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_SIG_ID                 \ [0x00 : 5] DMA request trigger input selected
    $08 constant DMAMUX2_OIE                    \ [0x08] Interrupt enable at trigger event overrun
    $10 constant DMAMUX2_GE                     \ [0x10] DMA request generator channel enable/disable
    $11 constant DMAMUX2_GPOL                   \ [0x11 : 2] DMA request generator trigger event type selection Defines the trigger event on the selected DMA request trigger input
    $13 constant DMAMUX2_GNBREQ                 \ [0x13 : 5] Number of DMA requests to generate Defines the number of DMA requests generated after a trigger event, then stop generating. The actual number of generated DMA requests is GNBREQ+1. Note: This field can only be written when GE bit is reset.
  [then]


  [ifdef] DMAMUX2_DMAMUX2_RGSR_DEF
    \
    \ @brief DMAMux - DMA request generator status register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_OF                     \ [0x00 : 8] Trigger event overrun flag The flag is set when a trigger event occurs on DMA request generator channel x, while the DMA request generator counter value is lower than GNBREQ. The flag is cleared by writing 1 to the corresponding COFx bit in DMAMUX_RGCFR register.
  [then]


  [ifdef] DMAMUX2_DMAMUX2_RGCFR_DEF
    \
    \ @brief DMAMux - DMA request generator clear flag register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX2_COF                    \ [0x00 : 8] Clear trigger event overrun flag Upon setting, this bit clears the corresponding overrun flag OFx in the DMAMUX_RGCSR register.
  [then]

  \
  \ @brief DMAMUX
  \
  $00 constant DMAMUX2_DMAMUX2_C0CR     \ DMAMux - DMA request line multiplexer channel x control register
  $04 constant DMAMUX2_DMAMUX2_C1CR     \ DMAMux - DMA request line multiplexer channel x control register
  $08 constant DMAMUX2_DMAMUX2_C2CR     \ DMAMux - DMA request line multiplexer channel x control register
  $0C constant DMAMUX2_DMAMUX2_C3CR     \ DMAMux - DMA request line multiplexer channel x control register
  $10 constant DMAMUX2_DMAMUX2_C4CR     \ DMAMux - DMA request line multiplexer channel x control register
  $14 constant DMAMUX2_DMAMUX2_C5CR     \ DMAMux - DMA request line multiplexer channel x control register
  $18 constant DMAMUX2_DMAMUX2_C6CR     \ DMAMux - DMA request line multiplexer channel x control register
  $1C constant DMAMUX2_DMAMUX2_C7CR     \ DMAMux - DMA request line multiplexer channel x control register
  $80 constant DMAMUX2_DMAMUX2_CSR      \ DMAMUX request line multiplexer interrupt channel status register
  $84 constant DMAMUX2_DMAMUX2_CFR      \ DMAMUX request line multiplexer interrupt clear flag register
  $100 constant DMAMUX2_DMAMUX2_RG0CR   \ DMAMux - DMA request generator channel x control register
  $104 constant DMAMUX2_DMAMUX2_RG1CR   \ DMAMux - DMA request generator channel x control register
  $108 constant DMAMUX2_DMAMUX2_RG2CR   \ DMAMux - DMA request generator channel x control register
  $10C constant DMAMUX2_DMAMUX2_RG3CR   \ DMAMux - DMA request generator channel x control register
  $110 constant DMAMUX2_DMAMUX2_RG4CR   \ DMAMux - DMA request generator channel x control register
  $114 constant DMAMUX2_DMAMUX2_RG5CR   \ DMAMux - DMA request generator channel x control register
  $118 constant DMAMUX2_DMAMUX2_RG6CR   \ DMAMux - DMA request generator channel x control register
  $11C constant DMAMUX2_DMAMUX2_RG7CR   \ DMAMux - DMA request generator channel x control register
  $140 constant DMAMUX2_DMAMUX2_RGSR    \ DMAMux - DMA request generator status register
  $144 constant DMAMUX2_DMAMUX2_RGCFR   \ DMAMux - DMA request generator clear flag register

: DMAMUX2_DEF ; [then]
