\
\ @file dmamux.fs
\ @brief DMAMUX
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMAMUX_DEF

  [ifdef] DMAMUX_DMAMUX_C0CR_DEF
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


  [ifdef] DMAMUX_DMAMUX_C1CR_DEF
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


  [ifdef] DMAMUX_DMAMUX_C2CR_DEF
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


  [ifdef] DMAMUX_DMAMUX_C3CR_DEF
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


  [ifdef] DMAMUX_DMAMUX_C4CR_DEF
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


  [ifdef] DMAMUX_DMAMUX_C5CR_DEF
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


  [ifdef] DMAMUX_DMAMUX_C6CR_DEF
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


  [ifdef] DMAMUX_DMAMUX_CSR_DEF
    \
    \ @brief DMAMUX request line multiplexer interrupt channel status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SOF                     \ [0x00 : 7] Synchronization overrun event flag
  [then]


  [ifdef] DMAMUX_DMAMUX_CFR_DEF
    \
    \ @brief DMAMUX request line multiplexer interrupt clear flag register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_CSOF                    \ [0x00 : 7] Clear synchronization overrun event flag
  [then]


  [ifdef] DMAMUX_DMAMUX_RG0CR_DEF
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


  [ifdef] DMAMUX_DMAMUX_RG1CR_DEF
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


  [ifdef] DMAMUX_DMAMUX_RG2CR_DEF
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


  [ifdef] DMAMUX_DMAMUX_RG3CR_DEF
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


  [ifdef] DMAMUX_DMAMUX_RGSR_DEF
    \
    \ @brief DMAMux - DMA request generator status register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_OF                      \ [0x00 : 4] Trigger event overrun flag The flag is set when a trigger event occurs on DMA request generator channel x, while the DMA request generator counter value is lower than GNBREQ. The flag is cleared by writing 1 to the corresponding COFx bit in DMAMUX_RGCFR register.
  [then]


  [ifdef] DMAMUX_DMAMUX_RGCFR_DEF
    \
    \ @brief DMAMux - DMA request generator clear flag register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_COF                     \ [0x00 : 4] Clear trigger event overrun flag Upon setting, this bit clears the corresponding overrun flag OFx in the DMAMUX_RGCSR register.
  [then]


  [ifdef] DMAMUX_DMAMUX_HWCFGR2_DEF
    \
    \ @brief DMAMUX hardware configuration 2 register
    \ Address offset: 0x3EC
    \ Reset value: 0x00000017
    \
    $00 constant DMAMUX_NUM_DMA_EXT_REQ         \ [0x00 : 8] Number of DMA request trigger inputs
  [then]


  [ifdef] DMAMUX_DMAMUX_HWCFGR1_DEF
    \
    \ @brief DMAMUX hardware configuration 1 register
    \ Address offset: 0x3F0
    \ Reset value: 0x04173907
    \
    $00 constant DMAMUX_NUM_DMA_STREAMS         \ [0x00 : 8] number of DMA request line multiplexer (output) channels
    $08 constant DMAMUX_NUM_DMA_PERIPH_REQ      \ [0x08 : 8] number of DMA request lines from peripherals
    $10 constant DMAMUX_NUM_DMA_TRIG            \ [0x10 : 8] number of synchronization inputs
    $18 constant DMAMUX_NUM_DMA_REQGEN          \ [0x18 : 8] number of DMA request generator channels
  [then]


  [ifdef] DMAMUX_DMAMUX_VERR_DEF
    \
    \ @brief DMAMUX version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000011
    \
    $00 constant DMAMUX_MINREV                  \ [0x00 : 4] Minor IP revision
    $04 constant DMAMUX_MAJREV                  \ [0x04 : 4] Major IP revision
  [then]


  [ifdef] DMAMUX_DMAMUX_IPIDR_DEF
    \
    \ @brief DMAMUX IP identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00100011
    \
    $00 constant DMAMUX_ID                      \ [0x00 : 32] IP identification
  [then]


  [ifdef] DMAMUX_DMAMUX_SIDR_DEF
    \
    \ @brief DMAMUX size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant DMAMUX_SID                     \ [0x00 : 32] Size identification
  [then]

  \
  \ @brief DMAMUX
  \
  $00 constant DMAMUX_DMAMUX_C0CR       \ DMAMux - DMA request line multiplexer channel x control register
  $04 constant DMAMUX_DMAMUX_C1CR       \ DMAMux - DMA request line multiplexer channel x control register
  $08 constant DMAMUX_DMAMUX_C2CR       \ DMAMux - DMA request line multiplexer channel x control register
  $0C constant DMAMUX_DMAMUX_C3CR       \ DMAMux - DMA request line multiplexer channel x control register
  $10 constant DMAMUX_DMAMUX_C4CR       \ DMAMux - DMA request line multiplexer channel x control register
  $14 constant DMAMUX_DMAMUX_C5CR       \ DMAMux - DMA request line multiplexer channel x control register
  $18 constant DMAMUX_DMAMUX_C6CR       \ DMAMux - DMA request line multiplexer channel x control register
  $80 constant DMAMUX_DMAMUX_CSR        \ DMAMUX request line multiplexer interrupt channel status register
  $84 constant DMAMUX_DMAMUX_CFR        \ DMAMUX request line multiplexer interrupt clear flag register
  $100 constant DMAMUX_DMAMUX_RG0CR     \ DMAMux - DMA request generator channel x control register
  $104 constant DMAMUX_DMAMUX_RG1CR     \ DMAMux - DMA request generator channel x control register
  $108 constant DMAMUX_DMAMUX_RG2CR     \ DMAMux - DMA request generator channel x control register
  $10C constant DMAMUX_DMAMUX_RG3CR     \ DMAMux - DMA request generator channel x control register
  $140 constant DMAMUX_DMAMUX_RGSR      \ DMAMux - DMA request generator status register
  $144 constant DMAMUX_DMAMUX_RGCFR     \ DMAMux - DMA request generator clear flag register
  $3EC constant DMAMUX_DMAMUX_HWCFGR2   \ DMAMUX hardware configuration 2 register
  $3F0 constant DMAMUX_DMAMUX_HWCFGR1   \ DMAMUX hardware configuration 1 register
  $3F4 constant DMAMUX_DMAMUX_VERR      \ DMAMUX version register
  $3F8 constant DMAMUX_DMAMUX_IPIDR     \ DMAMUX IP identification register
  $3FC constant DMAMUX_DMAMUX_SIDR      \ DMAMUX size identification register

: DMAMUX_DEF ; [then]
