\
\ @file lpdma1.fs
\ @brief LPDMA1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPDMA1_DEF

  [ifdef] LPDMA1_LPDMA_SECCFGR_DEF
    \
    \ @brief LPDMA secure configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SEC0                    \ [0x00] SEC0
    $01 constant LPDMA1_SEC1                    \ [0x01] SEC1
    $02 constant LPDMA1_SEC2                    \ [0x02] SEC2
    $03 constant LPDMA1_SEC3                    \ [0x03] SEC3
  [then]


  [ifdef] LPDMA1_LPDMA_PRIVCFGR_DEF
    \
    \ @brief LPDMA privileged configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_PRIV0                   \ [0x00] PRIV0
    $01 constant LPDMA1_PRIV1                   \ [0x01] PRIV1
    $02 constant LPDMA1_PRIV2                   \ [0x02] PRIV2
    $03 constant LPDMA1_PRIV3                   \ [0x03] PRIV3
  [then]


  [ifdef] LPDMA1_MISR_DEF
    \
    \ @brief LPDMA non-secure masked interrupt status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_MIS0                    \ [0x00] MIS0
    $01 constant LPDMA1_MIS1                    \ [0x01] MIS1
    $02 constant LPDMA1_MIS2                    \ [0x02] MIS2
    $03 constant LPDMA1_MIS3                    \ [0x03] MIS3
  [then]


  [ifdef] LPDMA1_SMISR_DEF
    \
    \ @brief LPDMA secure masked interrupt status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_MIS0                    \ [0x00] MIS0
    $01 constant LPDMA1_MIS1                    \ [0x01] MIS1
    $02 constant LPDMA1_MIS2                    \ [0x02] MIS2
    $03 constant LPDMA1_MIS3                    \ [0x03] MIS3
  [then]


  [ifdef] LPDMA1_LPDMA_C0LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $10 constant LPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] LPDMA1_LPDMA_C0FCR_DEF
    \
    \ @brief LPDMA channel x flag clear register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
  [then]


  [ifdef] LPDMA1_LPDMA_C0SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant LPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into LPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0].
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of LPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (LPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
  [then]


  [ifdef] LPDMA1_LPDMA_C0CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant LPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. LPDMA_CxSR.SUSPF=1 and LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant LPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant LPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant LPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant LPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant LPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant LPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant LPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant LPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when LPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant LPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] LPDMA1_LPDMA_C0TR1_DEF
    \
    \ @brief LPDMA channel x transfer register 1
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxSAR[2:0] and address offset LPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $03 constant LPDMA1_SINC                    \ [0x03] source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $0b constant LPDMA1_PAM                     \ [0x0b : 2] PAM
    $0f constant LPDMA1_SSEC                    \ [0x0f] security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
    $10 constant LPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxDAR[2:0] and address offset LPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $13 constant LPDMA1_DINC                    \ [0x13] destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $1f constant LPDMA1_DSEC                    \ [0x1f] security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
  [then]


  [ifdef] LPDMA1_LPDMA_C0TR2_DEF
    \
    \ @brief LPDMA channel x transfer register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_REQSEL                  \ [0x00 : 5] DMA hardware request selection If the channel x is activated (i.e. LPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if LPDMA_CxCR.EN=1 and LPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant LPDMA1_SWREQ                   \ [0x09] Software request When LPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0b constant LPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant LPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when LPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if LPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11
    $10 constant LPDMA1_TRIGSEL                 \ [0x10 : 5] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant LPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant LPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when LPDMA_CxBR1.BRC[10:0]= 0 and LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address LPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the LPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] LPDMA1_LPDMA_C0BR1_DEF
    \
    \ @brief LPDMA channel x block register 1
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] LPDMA1_LPDMA_C0SAR_DEF
    \
    \ @brief LPDMA channel x source address register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] LPDMA1_LPDMA_C0DAR_DEF
    \
    \ @brief LPDMA channel x destination address register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] LPDMA1_LPDMA_C0LLR_DEF
    \
    \ @brief LPDMA channel x linked-list address register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $02 constant LPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant LPDMA1_ULL                     \ [0x10] Update LPDMA_CxLLR from memory This bit controls the update of the LPDMA_CxLLR register from the memory during the link transfer. - 0: no LPDMA_CxLLR update - 1: LPDMA_CxLLR update
    $1b constant LPDMA1_UDA                     \ [0x1b] Update LPDMA_CxDAR from memory This bit controls the update of the LPDMA_CxDAR register from the memory during the link transfer. - 0: no LPDMA_CxDAR update - 1: LPDMA_CxDAR update
    $1c constant LPDMA1_USA                     \ [0x1c] Update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer. - 0: no LPDMA_CxSAR update - 1: LPDMA_CxSAR update
    $1d constant LPDMA1_UB1                     \ [0x1d] Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if LPDMA_CxLLR != 0, the linked-list is not completed. Then LPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no LPDMA_CxBR1 update (LPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: LPDMA_CxBR1 update
    $1e constant LPDMA1_UT2                     \ [0x1e] Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer. - 0: no LPDMA_CxTR2 update - 1: LPDMA_CxTR2 update
    $1f constant LPDMA1_UT1                     \ [0x1f] Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer. - 0: no LPDMA_CxTR1 update - 1: LPDMA_CxTR1 update
  [then]


  [ifdef] LPDMA1_LPDMA_C1LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $10 constant LPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] LPDMA1_LPDMA_C1FCR_DEF
    \
    \ @brief LPDMA channel x flag clear register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
  [then]


  [ifdef] LPDMA1_LPDMA_C1SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0xE0
    \ Reset value: 0x00000001
    \
    $00 constant LPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into LPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0].
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of LPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (LPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
  [then]


  [ifdef] LPDMA1_LPDMA_C1CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant LPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. LPDMA_CxSR.SUSPF=1 and LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant LPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant LPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant LPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant LPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant LPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant LPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant LPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant LPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when LPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant LPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] LPDMA1_LPDMA_C1TR1_DEF
    \
    \ @brief LPDMA channel x transfer register 1
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxSAR[2:0] and address offset LPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $03 constant LPDMA1_SINC                    \ [0x03] source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $0b constant LPDMA1_PAM                     \ [0x0b : 2] PAM
    $0f constant LPDMA1_SSEC                    \ [0x0f] security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
    $10 constant LPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxDAR[2:0] and address offset LPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $13 constant LPDMA1_DINC                    \ [0x13] destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $1f constant LPDMA1_DSEC                    \ [0x1f] security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
  [then]


  [ifdef] LPDMA1_LPDMA_C1TR2_DEF
    \
    \ @brief LPDMA channel x transfer register 2
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_REQSEL                  \ [0x00 : 5] DMA hardware request selection If the channel x is activated (i.e. LPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if LPDMA_CxCR.EN=1 and LPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant LPDMA1_SWREQ                   \ [0x09] Software request When LPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0b constant LPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant LPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode
    $10 constant LPDMA1_TRIGSEL                 \ [0x10 : 5] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant LPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant LPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when LPDMA_CxBR1.BRC[10:0]= 0 and LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address LPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the LPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] LPDMA1_LPDMA_C1BR1_DEF
    \
    \ @brief LPDMA channel x block register 1
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] LPDMA1_LPDMA_C1SAR_DEF
    \
    \ @brief LPDMA channel x source address register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] LPDMA1_LPDMA_C1DAR_DEF
    \
    \ @brief LPDMA channel x destination address register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] LPDMA1_LPDMA_C1LLR_DEF
    \
    \ @brief LPDMA channel x linked-list address register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $02 constant LPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant LPDMA1_ULL                     \ [0x10] Update LPDMA_CxLLR from memory This bit controls the update of the LPDMA_CxLLR register from the memory during the link transfer. - 0: no LPDMA_CxLLR update - 1: LPDMA_CxLLR update
    $1b constant LPDMA1_UDA                     \ [0x1b] Update LPDMA_CxDAR from memory This bit controls the update of the LPDMA_CxDAR register from the memory during the link transfer. - 0: no LPDMA_CxDAR update - 1: LPDMA_CxDAR update
    $1c constant LPDMA1_USA                     \ [0x1c] Update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer. - 0: no LPDMA_CxSAR update - 1: LPDMA_CxSAR update
    $1d constant LPDMA1_UB1                     \ [0x1d] Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if LPDMA_CxLLR != 0, the linked-list is not completed. Then LPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no LPDMA_CxBR1 update (LPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: LPDMA_CxBR1 update
    $1e constant LPDMA1_UT2                     \ [0x1e] Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer. - 0: no LPDMA_CxTR2 update - 1: LPDMA_CxTR2 update
    $1f constant LPDMA1_UT1                     \ [0x1f] Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer. - 0: no LPDMA_CxTR1 update - 1: LPDMA_CxTR1 update
  [then]


  [ifdef] LPDMA1_LPDMA_C2LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $10 constant LPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] LPDMA1_LPDMA_C2FCR_DEF
    \
    \ @brief LPDMA channel x flag clear register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
  [then]


  [ifdef] LPDMA1_LPDMA_C2SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x160
    \ Reset value: 0x00000001
    \
    $00 constant LPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into LPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0].
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of LPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (LPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
  [then]


  [ifdef] LPDMA1_LPDMA_C2CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant LPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. LPDMA_CxSR.SUSPF=1 and LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant LPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant LPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant LPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant LPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant LPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant LPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant LPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant LPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when LPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant LPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] LPDMA1_LPDMA_C2TR1_DEF
    \
    \ @brief LPDMA channel x transfer register 1
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxSAR[2:0] and address offset LPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $03 constant LPDMA1_SINC                    \ [0x03] source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $0b constant LPDMA1_PAM                     \ [0x0b : 2] PAM
    $0f constant LPDMA1_SSEC                    \ [0x0f] security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
    $10 constant LPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxDAR[2:0] and address offset LPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $13 constant LPDMA1_DINC                    \ [0x13] destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $1f constant LPDMA1_DSEC                    \ [0x1f] security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
  [then]


  [ifdef] LPDMA1_LPDMA_C2TR2_DEF
    \
    \ @brief LPDMA channel x transfer register 2
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_REQSEL                  \ [0x00 : 5] DMA hardware request selection If the channel x is activated (i.e. LPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if LPDMA_CxCR.EN=1 and LPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant LPDMA1_SWREQ                   \ [0x09] Software request When LPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0b constant LPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant LPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode
    $10 constant LPDMA1_TRIGSEL                 \ [0x10 : 5] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant LPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant LPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when LPDMA_CxBR1.BRC[10:0]= 0 and LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address LPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the LPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] LPDMA1_LPDMA_C2BR1_DEF
    \
    \ @brief LPDMA channel x block register 1
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] LPDMA1_LPDMA_C2SAR_DEF
    \
    \ @brief LPDMA channel x source address register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] LPDMA1_LPDMA_C2DAR_DEF
    \
    \ @brief LPDMA channel x destination address register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] LPDMA1_LPDMA_C2LLR_DEF
    \
    \ @brief LPDMA channel x linked-list address register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $02 constant LPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant LPDMA1_ULL                     \ [0x10] Update LPDMA_CxLLR from memory This bit controls the update of the LPDMA_CxLLR register from the memory during the link transfer. - 0: no LPDMA_CxLLR update - 1: LPDMA_CxLLR update
    $1b constant LPDMA1_UDA                     \ [0x1b] Update LPDMA_CxDAR from memory This bit controls the update of the LPDMA_CxDAR register from the memory during the link transfer. - 0: no LPDMA_CxDAR update - 1: LPDMA_CxDAR update
    $1c constant LPDMA1_USA                     \ [0x1c] Update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer. - 0: no LPDMA_CxSAR update - 1: LPDMA_CxSAR update
    $1d constant LPDMA1_UB1                     \ [0x1d] Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if LPDMA_CxLLR != 0, the linked-list is not completed. Then LPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no LPDMA_CxBR1 update (LPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: LPDMA_CxBR1 update
    $1e constant LPDMA1_UT2                     \ [0x1e] Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer. - 0: no LPDMA_CxTR2 update - 1: LPDMA_CxTR2 update
    $1f constant LPDMA1_UT1                     \ [0x1f] Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer. - 0: no LPDMA_CxTR1 update - 1: LPDMA_CxTR1 update
  [then]


  [ifdef] LPDMA1_LPDMA_C3LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $10 constant LPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] LPDMA1_LPDMA_C3FCR_DEF
    \
    \ @brief LPDMA channel x flag clear register
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
  [then]


  [ifdef] LPDMA1_LPDMA_C3SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000001
    \
    $00 constant LPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into LPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0].
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of LPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (LPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
  [then]


  [ifdef] LPDMA1_LPDMA_C3CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant LPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. LPDMA_CxSR.SUSPF=1 and LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant LPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant LPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant LPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant LPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant LPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant LPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant LPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant LPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when LPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant LPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] LPDMA1_LPDMA_C3TR1_DEF
    \
    \ @brief LPDMA channel x transfer register 1
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxSAR[2:0] and address offset LPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $03 constant LPDMA1_SINC                    \ [0x03] source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $0b constant LPDMA1_PAM                     \ [0x0b : 2] PAM
    $0f constant LPDMA1_SSEC                    \ [0x0f] security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
    $10 constant LPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxDAR[2:0] and address offset LPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $13 constant LPDMA1_DINC                    \ [0x13] destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $1f constant LPDMA1_DSEC                    \ [0x1f] security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
  [then]


  [ifdef] LPDMA1_LPDMA_C3TR2_DEF
    \
    \ @brief LPDMA channel x transfer register 2
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_REQSEL                  \ [0x00 : 5] DMA hardware request selection If the channel x is activated (i.e. LPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if LPDMA_CxCR.EN=1 and LPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant LPDMA1_SWREQ                   \ [0x09] Software request When LPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0b constant LPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant LPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode
    $10 constant LPDMA1_TRIGSEL                 \ [0x10 : 5] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant LPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant LPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when LPDMA_CxBR1.BRC[10:0]= 0 and LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address LPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the LPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] LPDMA1_LPDMA_C3BR1_DEF
    \
    \ @brief LPDMA channel x block register 1
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] LPDMA1_LPDMA_C3SAR_DEF
    \
    \ @brief LPDMA channel x source address register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] LPDMA1_LPDMA_C3DAR_DEF
    \
    \ @brief LPDMA channel x destination address register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] LPDMA1_LPDMA_C3LLR_DEF
    \
    \ @brief LPDMA channel x linked-list address register
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $02 constant LPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant LPDMA1_ULL                     \ [0x10] Update LPDMA_CxLLR from memory This bit controls the update of the LPDMA_CxLLR register from the memory during the link transfer. - 0: no LPDMA_CxLLR update - 1: LPDMA_CxLLR update
    $1b constant LPDMA1_UDA                     \ [0x1b] Update LPDMA_CxDAR from memory This bit controls the update of the LPDMA_CxDAR register from the memory during the link transfer. - 0: no LPDMA_CxDAR update - 1: LPDMA_CxDAR update
    $1c constant LPDMA1_USA                     \ [0x1c] Update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer. - 0: no LPDMA_CxSAR update - 1: LPDMA_CxSAR update
    $1d constant LPDMA1_UB1                     \ [0x1d] Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if LPDMA_CxLLR != 0, the linked-list is not completed. Then LPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no LPDMA_CxBR1 update (LPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: LPDMA_CxBR1 update
    $1e constant LPDMA1_UT2                     \ [0x1e] Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer. - 0: no LPDMA_CxTR2 update - 1: LPDMA_CxTR2 update
    $1f constant LPDMA1_UT1                     \ [0x1f] Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer. - 0: no LPDMA_CxTR1 update - 1: LPDMA_CxTR1 update
  [then]

  \
  \ @brief LPDMA1
  \
  $00 constant LPDMA1_LPDMA_SECCFGR     \ LPDMA secure configuration register
  $04 constant LPDMA1_LPDMA_PRIVCFGR    \ LPDMA privileged configuration register
  $0C constant LPDMA1_MISR              \ LPDMA non-secure masked interrupt status register
  $10 constant LPDMA1_SMISR             \ LPDMA secure masked interrupt status register
  $50 constant LPDMA1_LPDMA_C0LBAR      \ channel x linked-list base address register
  $5C constant LPDMA1_LPDMA_C0FCR       \ LPDMA channel x flag clear register
  $60 constant LPDMA1_LPDMA_C0SR        \ channel x status register
  $64 constant LPDMA1_LPDMA_C0CR        \ channel x control register
  $90 constant LPDMA1_LPDMA_C0TR1       \ LPDMA channel x transfer register 1
  $94 constant LPDMA1_LPDMA_C0TR2       \ LPDMA channel x transfer register 2
  $98 constant LPDMA1_LPDMA_C0BR1       \ LPDMA channel x block register 1
  $9C constant LPDMA1_LPDMA_C0SAR       \ LPDMA channel x source address register
  $A0 constant LPDMA1_LPDMA_C0DAR       \ LPDMA channel x destination address register
  $CC constant LPDMA1_LPDMA_C0LLR       \ LPDMA channel x linked-list address register
  $D0 constant LPDMA1_LPDMA_C1LBAR      \ channel x linked-list base address register
  $DC constant LPDMA1_LPDMA_C1FCR       \ LPDMA channel x flag clear register
  $E0 constant LPDMA1_LPDMA_C1SR        \ channel x status register
  $E4 constant LPDMA1_LPDMA_C1CR        \ channel x control register
  $110 constant LPDMA1_LPDMA_C1TR1      \ LPDMA channel x transfer register 1
  $114 constant LPDMA1_LPDMA_C1TR2      \ LPDMA channel x transfer register 2
  $118 constant LPDMA1_LPDMA_C1BR1      \ LPDMA channel x block register 1
  $11C constant LPDMA1_LPDMA_C1SAR      \ LPDMA channel x source address register
  $120 constant LPDMA1_LPDMA_C1DAR      \ LPDMA channel x destination address register
  $14C constant LPDMA1_LPDMA_C1LLR      \ LPDMA channel x linked-list address register
  $150 constant LPDMA1_LPDMA_C2LBAR     \ channel x linked-list base address register
  $15C constant LPDMA1_LPDMA_C2FCR      \ LPDMA channel x flag clear register
  $160 constant LPDMA1_LPDMA_C2SR       \ channel x status register
  $164 constant LPDMA1_LPDMA_C2CR       \ channel x control register
  $190 constant LPDMA1_LPDMA_C2TR1      \ LPDMA channel x transfer register 1
  $194 constant LPDMA1_LPDMA_C2TR2      \ LPDMA channel x transfer register 2
  $198 constant LPDMA1_LPDMA_C2BR1      \ LPDMA channel x block register 1
  $19C constant LPDMA1_LPDMA_C2SAR      \ LPDMA channel x source address register
  $1A0 constant LPDMA1_LPDMA_C2DAR      \ LPDMA channel x destination address register
  $1CC constant LPDMA1_LPDMA_C2LLR      \ LPDMA channel x linked-list address register
  $1D0 constant LPDMA1_LPDMA_C3LBAR     \ channel x linked-list base address register
  $1DC constant LPDMA1_LPDMA_C3FCR      \ LPDMA channel x flag clear register
  $1E0 constant LPDMA1_LPDMA_C3SR       \ channel x status register
  $1E4 constant LPDMA1_LPDMA_C3CR       \ channel x control register
  $210 constant LPDMA1_LPDMA_C3TR1      \ LPDMA channel x transfer register 1
  $214 constant LPDMA1_LPDMA_C3TR2      \ LPDMA channel x transfer register 2
  $218 constant LPDMA1_LPDMA_C3BR1      \ LPDMA channel x block register 1
  $21C constant LPDMA1_LPDMA_C3SAR      \ LPDMA channel x source address register
  $220 constant LPDMA1_LPDMA_C3DAR      \ LPDMA channel x destination address register
  $24C constant LPDMA1_LPDMA_C3LLR      \ LPDMA channel x linked-list address register

: LPDMA1_DEF ; [then]
