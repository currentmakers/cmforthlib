\
\ @file dmamux1.fs
\ @brief DMAMUX
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMAMUX1_DEF

  [ifdef] DMAMUX1_DMAMUX_C0CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C1CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C2CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C3CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C4CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C5CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C6CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C7CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C8CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C9CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C10CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C11CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C12CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C13CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C14CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_C15CR_DEF
    \
    \ @brief DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_DMAREQ_ID              \ [0x00 : 7] DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
    $08 constant DMAMUX1_SOIE                   \ [0x08] Synchronization overrun interrupt enable
    $09 constant DMAMUX1_EGE                    \ [0x09] Event generation enable
    $10 constant DMAMUX1_SE                     \ [0x10] Synchronization enable
    $11 constant DMAMUX1_SPOL                   \ [0x11 : 2] Synchronization polarity Defines the edge polarity of the selected synchronization input:
    $13 constant DMAMUX1_NBREQ                  \ [0x13 : 5] Number of DMA requests minus 1 to forward Defines the number of DMA requests to forward to the DMA controller after a synchronization event, and/or the number of DMA requests before an output event is generated. This field shall only be written when both SE and EGE bits are low.
    $18 constant DMAMUX1_SYNC_ID                \ [0x18 : 3] Synchronization identification Selects the synchronization input (see inputs to resources).
  [then]


  [ifdef] DMAMUX1_DMAMUX_CSR_DEF
    \
    \ @brief Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SOF0                   \ [0x00] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $01 constant DMAMUX1_SOF1                   \ [0x01] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $02 constant DMAMUX1_SOF2                   \ [0x02] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $03 constant DMAMUX1_SOF3                   \ [0x03] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $04 constant DMAMUX1_SOF4                   \ [0x04] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $05 constant DMAMUX1_SOF5                   \ [0x05] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $06 constant DMAMUX1_SOF6                   \ [0x06] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $07 constant DMAMUX1_SOF7                   \ [0x07] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $08 constant DMAMUX1_SOF8                   \ [0x08] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $09 constant DMAMUX1_SOF9                   \ [0x09] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $0a constant DMAMUX1_SOF10                  \ [0x0a] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $0b constant DMAMUX1_SOF11                  \ [0x0b] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $0c constant DMAMUX1_SOF12                  \ [0x0c] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $0d constant DMAMUX1_SOF13                  \ [0x0d] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $0e constant DMAMUX1_SOF14                  \ [0x0e] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
    $0f constant DMAMUX1_SOF15                  \ [0x0f] Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
  [then]


  [ifdef] DMAMUX1_DMAMUX_CFR_DEF
    \
    \ @brief Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_CSOF0                  \ [0x00] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $01 constant DMAMUX1_CSOF1                  \ [0x01] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $02 constant DMAMUX1_CSOF2                  \ [0x02] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $03 constant DMAMUX1_CSOF3                  \ [0x03] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $04 constant DMAMUX1_CSOF4                  \ [0x04] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $05 constant DMAMUX1_CSOF5                  \ [0x05] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $06 constant DMAMUX1_CSOF6                  \ [0x06] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $07 constant DMAMUX1_CSOF7                  \ [0x07] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $08 constant DMAMUX1_CSOF8                  \ [0x08] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $09 constant DMAMUX1_CSOF9                  \ [0x09] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $0a constant DMAMUX1_CSOF10                 \ [0x0a] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $0b constant DMAMUX1_CSOF11                 \ [0x0b] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $0c constant DMAMUX1_CSOF12                 \ [0x0c] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $0d constant DMAMUX1_CSOF13                 \ [0x0d] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $0e constant DMAMUX1_CSOF14                 \ [0x0e] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
    $0f constant DMAMUX1_CSOF15                 \ [0x0f] Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
  [then]


  [ifdef] DMAMUX1_DMAMUX_RG0CR_DEF
    \
    \ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 3] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.
  [then]


  [ifdef] DMAMUX1_DMAMUX_RG1CR_DEF
    \
    \ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 3] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.
  [then]


  [ifdef] DMAMUX1_DMAMUX_RG2CR_DEF
    \
    \ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 3] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.
  [then]


  [ifdef] DMAMUX1_DMAMUX_RG3CR_DEF
    \
    \ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 3] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.
  [then]


  [ifdef] DMAMUX1_DMAMUX_RG4CR_DEF
    \
    \ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 3] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.
  [then]


  [ifdef] DMAMUX1_DMAMUX_RG5CR_DEF
    \
    \ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 3] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.
  [then]


  [ifdef] DMAMUX1_DMAMUX_RG6CR_DEF
    \
    \ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 3] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.
  [then]


  [ifdef] DMAMUX1_DMAMUX_RG7CR_DEF
    \
    \ @brief Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_SIG_ID                 \ [0x00 : 3] Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
    $08 constant DMAMUX1_OIE                    \ [0x08] Trigger overrun interrupt enable
    $10 constant DMAMUX1_GE                     \ [0x10] DMA request generator channel x enable
    $11 constant DMAMUX1_GPOL                   \ [0x11 : 2] DMA request generator trigger polarity Defines the edge polarity of the selected trigger input
    $13 constant DMAMUX1_GNBREQ                 \ [0x13 : 5] Number of DMA requests to be generated (minus 1) Defines the number of DMA requests to be generated after a trigger event. The actual number of generated DMA requests is GNBREQ +1. Note: This field must be written only when GE bit is disabled.
  [then]


  [ifdef] DMAMUX1_DMAMUX_RGSR_DEF
    \
    \ @brief [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_OF0                    \ [0x00] [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
    $01 constant DMAMUX1_OF1                    \ [0x01] [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
    $02 constant DMAMUX1_OF2                    \ [0x02] [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
    $03 constant DMAMUX1_OF3                    \ [0x03] [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
    $04 constant DMAMUX1_OF4                    \ [0x04] [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
    $05 constant DMAMUX1_OF5                    \ [0x05] [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
    $06 constant DMAMUX1_OF6                    \ [0x06] [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
    $07 constant DMAMUX1_OF7                    \ [0x07] [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
  [then]


  [ifdef] DMAMUX1_DMAMUX_RGCFR_DEF
    \
    \ @brief Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DMAMUX1_COF0                   \ [0x00] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
    $01 constant DMAMUX1_COF1                   \ [0x01] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
    $02 constant DMAMUX1_COF2                   \ [0x02] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
    $03 constant DMAMUX1_COF3                   \ [0x03] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
    $04 constant DMAMUX1_COF4                   \ [0x04] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
    $05 constant DMAMUX1_COF5                   \ [0x05] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
    $06 constant DMAMUX1_COF6                   \ [0x06] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
    $07 constant DMAMUX1_COF7                   \ [0x07] Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.
  [then]

  \
  \ @brief DMAMUX
  \
  $00 constant DMAMUX1_DMAMUX_C0CR      \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $04 constant DMAMUX1_DMAMUX_C1CR      \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $08 constant DMAMUX1_DMAMUX_C2CR      \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $0C constant DMAMUX1_DMAMUX_C3CR      \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $10 constant DMAMUX1_DMAMUX_C4CR      \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $14 constant DMAMUX1_DMAMUX_C5CR      \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $18 constant DMAMUX1_DMAMUX_C6CR      \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $1C constant DMAMUX1_DMAMUX_C7CR      \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $20 constant DMAMUX1_DMAMUX_C8CR      \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $24 constant DMAMUX1_DMAMUX_C9CR      \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $28 constant DMAMUX1_DMAMUX_C10CR     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $2C constant DMAMUX1_DMAMUX_C11CR     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $30 constant DMAMUX1_DMAMUX_C12CR     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $34 constant DMAMUX1_DMAMUX_C13CR     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $38 constant DMAMUX1_DMAMUX_C14CR     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $3C constant DMAMUX1_DMAMUX_C15CR     \ DMA request identification Selects the input DMA request. See the DMAMUX table about assignments of multiplexer inputs to resources.
  $80 constant DMAMUX1_DMAMUX_CSR       \ Synchronization overrun event flag The flag is set when a synchronization event occurs on a DMA request line multiplexer channel x, while the DMA request counter value is lower than NBREQ. The flag is cleared by writing 1 to the corresponding CSOFx bit in DMAMUX_CFR register. For DMAMUX2 bits 15:8 are reserved, keep them at reset value.
  $84 constant DMAMUX1_DMAMUX_CFR       \ Clear synchronization overrun event flag Writing 1 in each bit clears the corresponding overrun flag SOFx in the DMAMUX_CSR register.
  $100 constant DMAMUX1_DMAMUX_RG0CR    \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
  $104 constant DMAMUX1_DMAMUX_RG1CR    \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
  $108 constant DMAMUX1_DMAMUX_RG2CR    \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
  $10C constant DMAMUX1_DMAMUX_RG3CR    \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
  $110 constant DMAMUX1_DMAMUX_RG4CR    \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
  $114 constant DMAMUX1_DMAMUX_RG5CR    \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
  $118 constant DMAMUX1_DMAMUX_RG6CR    \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
  $11C constant DMAMUX1_DMAMUX_RG7CR    \ Signal identification Selects the DMA request trigger input used for the channel x of the DMA request generator
  $140 constant DMAMUX1_DMAMUX_RGSR     \ [:0]: Trigger overrun event flag The flag is set when a new trigger event occurs on DMA request generator channel x, before the request counter underrun (the internal request counter programmed via the GNBREQ field of the DMAMUX_RGxCR register). The flag is cleared by writing 1 to the corresponding COFx bit in the DMAMUX_RGCFR register.
  $144 constant DMAMUX1_DMAMUX_RGCFR    \ Clear trigger overrun event flag Writing 1 in each bit clears the corresponding overrun flag OFx in the DMAMUX_RGSR register.

: DMAMUX1_DEF ; [then]
