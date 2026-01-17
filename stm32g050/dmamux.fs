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
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_C1CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_C2CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_C3CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_C4CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_C5CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_C6CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_C7CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_C8CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_C9CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_C10CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_C11CR_DEF
    \
    \ @brief DMAMUX request line multiplexer channel x configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_DMAREQ_ID               \ [0x00 : 6] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX_SOIE                    \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX_EGE                     \ [0x09] Event generation enable
    $10 constant DMAMUX_SE                      \ [0x10] Synchronization enable
    $11 constant DMAMUX_SPOL                    \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX_NBREQ                   \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX_SYNC_ID                 \ [0x18 : 5] Synchronization identification Selects the synchronization input (see inputs to resources STM32G0).
  [then]


  [ifdef] DMAMUX_DMAMUX_CSR_DEF
    \
    \ @brief DMAMUX request line multiplexer interrupt channel status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SOF0                    \ [0x00] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
    $01 constant DMAMUX_SOF1                    \ [0x01] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
    $02 constant DMAMUX_SOF2                    \ [0x02] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
    $03 constant DMAMUX_SOF3                    \ [0x03] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
    $04 constant DMAMUX_SOF4                    \ [0x04] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
    $05 constant DMAMUX_SOF5                    \ [0x05] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
    $06 constant DMAMUX_SOF6                    \ [0x06] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
    $07 constant DMAMUX_SOF7                    \ [0x07] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
    $08 constant DMAMUX_SOF8                    \ [0x08] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
    $09 constant DMAMUX_SOF9                    \ [0x09] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
    $0a constant DMAMUX_SOF10                   \ [0x0a] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
    $0b constant DMAMUX_SOF11                   \ [0x0b] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register.
  [then]


  [ifdef] DMAMUX_DMAMUX_CFR_DEF
    \
    \ @brief DMAMUX request line multiplexer interrupt clear flag register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_CSOF0                   \ [0x00] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $01 constant DMAMUX_CSOF1                   \ [0x01] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $02 constant DMAMUX_CSOF2                   \ [0x02] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $03 constant DMAMUX_CSOF3                   \ [0x03] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $04 constant DMAMUX_CSOF4                   \ [0x04] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $05 constant DMAMUX_CSOF5                   \ [0x05] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $06 constant DMAMUX_CSOF6                   \ [0x06] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $07 constant DMAMUX_CSOF7                   \ [0x07] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $08 constant DMAMUX_CSOF8                   \ [0x08] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $09 constant DMAMUX_CSOF9                   \ [0x09] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $0a constant DMAMUX_CSOF10                  \ [0x0a] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $0b constant DMAMUX_CSOF11                  \ [0x0b] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
  [then]


  [ifdef] DMAMUX_DMAMUX_RG0CR_DEF
    \
    \ @brief DMAMUX request generator channel x configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX_OIE                     \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field shall only be written when GE bit is disabled.
  [then]


  [ifdef] DMAMUX_DMAMUX_RG1CR_DEF
    \
    \ @brief DMAMUX request generator channel x configuration register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX_OIE                     \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field shall only be written when GE bit is disabled.
  [then]


  [ifdef] DMAMUX_DMAMUX_RG2CR_DEF
    \
    \ @brief DMAMUX request generator channel x configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX_OIE                     \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field shall only be written when GE bit is disabled.
  [then]


  [ifdef] DMAMUX_DMAMUX_RG3CR_DEF
    \
    \ @brief DMAMUX request generator channel x configuration register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_SIG_ID                  \ [0x00 : 5] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX_OIE                     \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX_GE                      \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX_GPOL                    \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX_GNBREQ                  \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field shall only be written when GE bit is disabled.
  [then]


  [ifdef] DMAMUX_DMAMUX_RGSR_DEF
    \
    \ @brief DMAMUX request generator interrupt status register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_OF0                     \ [0x00] Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
    $01 constant DMAMUX_OF1                     \ [0x01] Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
    $02 constant DMAMUX_OF2                     \ [0x02] Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
    $03 constant DMAMUX_OF3                     \ [0x03] Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
  [then]


  [ifdef] DMAMUX_DMAMUX_RGCFR_DEF
    \
    \ @brief DMAMUX request generator interrupt clear flag register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX_COF0                    \ [0x00] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
    $01 constant DMAMUX_COF1                    \ [0x01] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
    $02 constant DMAMUX_COF2                    \ [0x02] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
    $03 constant DMAMUX_COF3                    \ [0x03] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
  [then]

  \
  \ @brief DMAMUX
  \
  $00 constant DMAMUX_DMAMUX_C0CR       \ DMAMUX request line multiplexer channel x configuration register
  $04 constant DMAMUX_DMAMUX_C1CR       \ DMAMUX request line multiplexer channel x configuration register
  $08 constant DMAMUX_DMAMUX_C2CR       \ DMAMUX request line multiplexer channel x configuration register
  $0C constant DMAMUX_DMAMUX_C3CR       \ DMAMUX request line multiplexer channel x configuration register
  $10 constant DMAMUX_DMAMUX_C4CR       \ DMAMUX request line multiplexer channel x configuration register
  $14 constant DMAMUX_DMAMUX_C5CR       \ DMAMUX request line multiplexer channel x configuration register
  $18 constant DMAMUX_DMAMUX_C6CR       \ DMAMUX request line multiplexer channel x configuration register
  $1C constant DMAMUX_DMAMUX_C7CR       \ DMAMUX request line multiplexer channel x configuration register
  $20 constant DMAMUX_DMAMUX_C8CR       \ DMAMUX request line multiplexer channel x configuration register
  $24 constant DMAMUX_DMAMUX_C9CR       \ DMAMUX request line multiplexer channel x configuration register
  $28 constant DMAMUX_DMAMUX_C10CR      \ DMAMUX request line multiplexer channel x configuration register
  $2C constant DMAMUX_DMAMUX_C11CR      \ DMAMUX request line multiplexer channel x configuration register
  $80 constant DMAMUX_DMAMUX_CSR        \ DMAMUX request line multiplexer interrupt channel status register
  $84 constant DMAMUX_DMAMUX_CFR        \ DMAMUX request line multiplexer interrupt clear flag register
  $100 constant DMAMUX_DMAMUX_RG0CR     \ DMAMUX request generator channel x configuration register
  $104 constant DMAMUX_DMAMUX_RG1CR     \ DMAMUX request generator channel x configuration register
  $108 constant DMAMUX_DMAMUX_RG2CR     \ DMAMUX request generator channel x configuration register
  $10C constant DMAMUX_DMAMUX_RG3CR     \ DMAMUX request generator channel x configuration register
  $140 constant DMAMUX_DMAMUX_RGSR      \ DMAMUX request generator interrupt status register
  $144 constant DMAMUX_DMAMUX_RGCFR     \ DMAMUX request generator interrupt clear flag register

: DMAMUX_DEF ; [then]
