\
\ @file sec_lpdma1.fs
\ @brief LPDMA1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPDMA secure configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPDMA1_LPDMA_SECCFGR_SEC0                    \ SEC0
$00000002 constant SEC_LPDMA1_LPDMA_SECCFGR_SEC1                    \ SEC1
$00000004 constant SEC_LPDMA1_LPDMA_SECCFGR_SEC2                    \ SEC2
$00000008 constant SEC_LPDMA1_LPDMA_SECCFGR_SEC3                    \ SEC3


\
\ @brief LPDMA privileged configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPDMA1_LPDMA_PRIVCFGR_PRIV0                  \ PRIV0
$00000002 constant SEC_LPDMA1_LPDMA_PRIVCFGR_PRIV1                  \ PRIV1
$00000004 constant SEC_LPDMA1_LPDMA_PRIVCFGR_PRIV2                  \ PRIV2
$00000008 constant SEC_LPDMA1_LPDMA_PRIVCFGR_PRIV3                  \ PRIV3


\
\ @brief LPDMA non-secure masked interrupt status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPDMA1_MISR_MIS0                             \ MIS0
$00000002 constant SEC_LPDMA1_MISR_MIS1                             \ MIS1
$00000004 constant SEC_LPDMA1_MISR_MIS2                             \ MIS2
$00000008 constant SEC_LPDMA1_MISR_MIS3                             \ MIS3


\
\ @brief LPDMA secure masked interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPDMA1_SMISR_MIS0                            \ MIS0
$00000002 constant SEC_LPDMA1_SMISR_MIS1                            \ MIS1
$00000004 constant SEC_LPDMA1_SMISR_MIS2                            \ MIS2
$00000008 constant SEC_LPDMA1_SMISR_MIS3                            \ MIS3


\
\ @brief channel x linked-list base address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_LPDMA1_LPDMA_C0LBAR_LBA                      \ linked-list base address of DMA channel x


\
\ @brief LPDMA channel x flag clear register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000100 constant SEC_LPDMA1_LPDMA_C0FCR_TCF                       \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant SEC_LPDMA1_LPDMA_C0FCR_HTF                       \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant SEC_LPDMA1_LPDMA_C0FCR_DTEF                      \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant SEC_LPDMA1_LPDMA_C0FCR_ULEF                      \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant SEC_LPDMA1_LPDMA_C0FCR_USEF                      \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant SEC_LPDMA1_LPDMA_C0FCR_SUSPF                     \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag


\
\ @brief channel x status register
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant SEC_LPDMA1_LPDMA_C0SR_IDLEF                      \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into LPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant SEC_LPDMA1_LPDMA_C0SR_TCF                        \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0].
$00000200 constant SEC_LPDMA1_LPDMA_C0SR_HTF                        \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of LPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (LPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant SEC_LPDMA1_LPDMA_C0SR_DTEF                       \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant SEC_LPDMA1_LPDMA_C0SR_ULEF                       \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant SEC_LPDMA1_LPDMA_C0SR_USEF                       \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant SEC_LPDMA1_LPDMA_C0SR_SUSPF                      \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred


\
\ @brief channel x control register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPDMA1_LPDMA_C0CR_EN                         \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_LPDMA1_LPDMA_C0CR_RESET                      \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. LPDMA_CxSR.SUSPF=1 and LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant SEC_LPDMA1_LPDMA_C0CR_SUSP                       \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant SEC_LPDMA1_LPDMA_C0CR_TCIE                       \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant SEC_LPDMA1_LPDMA_C0CR_HTIE                       \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant SEC_LPDMA1_LPDMA_C0CR_DTEIE                      \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant SEC_LPDMA1_LPDMA_C0CR_ULEIE                      \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant SEC_LPDMA1_LPDMA_C0CR_USEIE                      \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant SEC_LPDMA1_LPDMA_C0CR_SUSPIE                     \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant SEC_LPDMA1_LPDMA_C0CR_LSM                        \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when LPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_LPDMA1_LPDMA_C0CR_PRIO                       \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief LPDMA channel x transfer register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000003 constant SEC_LPDMA1_LPDMA_C0TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxSAR[2:0] and address offset LPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00000008 constant SEC_LPDMA1_LPDMA_C0TR1_SINC                      \ source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$00001800 constant SEC_LPDMA1_LPDMA_C0TR1_PAM                       \ PAM
$00008000 constant SEC_LPDMA1_LPDMA_C0TR1_SSEC                      \ security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
$00030000 constant SEC_LPDMA1_LPDMA_C0TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxDAR[2:0] and address offset LPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00080000 constant SEC_LPDMA1_LPDMA_C0TR1_DINC                      \ destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$80000000 constant SEC_LPDMA1_LPDMA_C0TR1_DSEC                      \ security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure


\
\ @brief LPDMA channel x transfer register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000001f constant SEC_LPDMA1_LPDMA_C0TR2_REQSEL                    \ DMA hardware request selection If the channel x is activated (i.e. LPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if LPDMA_CxCR.EN=1 and LPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_LPDMA1_LPDMA_C0TR2_SWREQ                     \ Software request When LPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000800 constant SEC_LPDMA1_LPDMA_C0TR2_BREQ                      \ BREQ
$0000c000 constant SEC_LPDMA1_LPDMA_C0TR2_TRIGM                     \ Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when LPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if LPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11
$001f0000 constant SEC_LPDMA1_LPDMA_C0TR2_TRIGSEL                   \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant SEC_LPDMA1_LPDMA_C0TR2_TRIGPOL                   \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant SEC_LPDMA1_LPDMA_C0TR2_TCEM                      \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when LPDMA_CxBR1.BRC[10:0]= 0 and LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address LPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the LPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief LPDMA channel x block register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPDMA1_LPDMA_C0BR1_BNDT                      \ block number of data bytes to transfer from the source


\
\ @brief LPDMA channel x source address register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant SEC_LPDMA1_LPDMA_C0SAR_SA                        \ source address


\
\ @brief LPDMA channel x destination address register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant SEC_LPDMA1_LPDMA_C0DAR_DA                        \ destination address


\
\ @brief LPDMA channel x linked-list address register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000fffc constant SEC_LPDMA1_LPDMA_C0LLR_LA                        \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant SEC_LPDMA1_LPDMA_C0LLR_ULL                       \ Update LPDMA_CxLLR from memory This bit controls the update of the LPDMA_CxLLR register from the memory during the link transfer. - 0: no LPDMA_CxLLR update - 1: LPDMA_CxLLR update
$08000000 constant SEC_LPDMA1_LPDMA_C0LLR_UDA                       \ Update LPDMA_CxDAR from memory This bit controls the update of the LPDMA_CxDAR register from the memory during the link transfer. - 0: no LPDMA_CxDAR update - 1: LPDMA_CxDAR update
$10000000 constant SEC_LPDMA1_LPDMA_C0LLR_USA                       \ Update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer. - 0: no LPDMA_CxSAR update - 1: LPDMA_CxSAR update
$20000000 constant SEC_LPDMA1_LPDMA_C0LLR_UB1                       \ Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if LPDMA_CxLLR != 0, the linked-list is not completed. Then LPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no LPDMA_CxBR1 update (LPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: LPDMA_CxBR1 update
$40000000 constant SEC_LPDMA1_LPDMA_C0LLR_UT2                       \ Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer. - 0: no LPDMA_CxTR2 update - 1: LPDMA_CxTR2 update
$80000000 constant SEC_LPDMA1_LPDMA_C0LLR_UT1                       \ Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer. - 0: no LPDMA_CxTR1 update - 1: LPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_LPDMA1_LPDMA_C1LBAR_LBA                      \ linked-list base address of DMA channel x


\
\ @brief LPDMA channel x flag clear register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000100 constant SEC_LPDMA1_LPDMA_C1FCR_TCF                       \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant SEC_LPDMA1_LPDMA_C1FCR_HTF                       \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant SEC_LPDMA1_LPDMA_C1FCR_DTEF                      \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant SEC_LPDMA1_LPDMA_C1FCR_ULEF                      \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant SEC_LPDMA1_LPDMA_C1FCR_USEF                      \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant SEC_LPDMA1_LPDMA_C1FCR_SUSPF                     \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag


\
\ @brief channel x status register
\ Address offset: 0xE0
\ Reset value: 0x00000001
\

$00000001 constant SEC_LPDMA1_LPDMA_C1SR_IDLEF                      \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into LPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant SEC_LPDMA1_LPDMA_C1SR_TCF                        \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0].
$00000200 constant SEC_LPDMA1_LPDMA_C1SR_HTF                        \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of LPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (LPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant SEC_LPDMA1_LPDMA_C1SR_DTEF                       \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant SEC_LPDMA1_LPDMA_C1SR_ULEF                       \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant SEC_LPDMA1_LPDMA_C1SR_USEF                       \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant SEC_LPDMA1_LPDMA_C1SR_SUSPF                      \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred


\
\ @brief channel x control register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPDMA1_LPDMA_C1CR_EN                         \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_LPDMA1_LPDMA_C1CR_RESET                      \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. LPDMA_CxSR.SUSPF=1 and LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant SEC_LPDMA1_LPDMA_C1CR_SUSP                       \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant SEC_LPDMA1_LPDMA_C1CR_TCIE                       \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant SEC_LPDMA1_LPDMA_C1CR_HTIE                       \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant SEC_LPDMA1_LPDMA_C1CR_DTEIE                      \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant SEC_LPDMA1_LPDMA_C1CR_ULEIE                      \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant SEC_LPDMA1_LPDMA_C1CR_USEIE                      \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant SEC_LPDMA1_LPDMA_C1CR_SUSPIE                     \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant SEC_LPDMA1_LPDMA_C1CR_LSM                        \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when LPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_LPDMA1_LPDMA_C1CR_PRIO                       \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief LPDMA channel x transfer register 1
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000003 constant SEC_LPDMA1_LPDMA_C1TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxSAR[2:0] and address offset LPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00000008 constant SEC_LPDMA1_LPDMA_C1TR1_SINC                      \ source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$00001800 constant SEC_LPDMA1_LPDMA_C1TR1_PAM                       \ PAM
$00008000 constant SEC_LPDMA1_LPDMA_C1TR1_SSEC                      \ security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
$00030000 constant SEC_LPDMA1_LPDMA_C1TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxDAR[2:0] and address offset LPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00080000 constant SEC_LPDMA1_LPDMA_C1TR1_DINC                      \ destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$80000000 constant SEC_LPDMA1_LPDMA_C1TR1_DSEC                      \ security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure


\
\ @brief LPDMA channel x transfer register 2
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0000001f constant SEC_LPDMA1_LPDMA_C1TR2_REQSEL                    \ DMA hardware request selection If the channel x is activated (i.e. LPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if LPDMA_CxCR.EN=1 and LPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_LPDMA1_LPDMA_C1TR2_SWREQ                     \ Software request When LPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000800 constant SEC_LPDMA1_LPDMA_C1TR2_BREQ                      \ BREQ
$0000c000 constant SEC_LPDMA1_LPDMA_C1TR2_TRIGM                     \ Trigger mode
$001f0000 constant SEC_LPDMA1_LPDMA_C1TR2_TRIGSEL                   \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant SEC_LPDMA1_LPDMA_C1TR2_TRIGPOL                   \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant SEC_LPDMA1_LPDMA_C1TR2_TCEM                      \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when LPDMA_CxBR1.BRC[10:0]= 0 and LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address LPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the LPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief LPDMA channel x block register 1
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPDMA1_LPDMA_C1BR1_BNDT                      \ block number of data bytes to transfer from the source


\
\ @brief LPDMA channel x source address register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant SEC_LPDMA1_LPDMA_C1SAR_SA                        \ source address


\
\ @brief LPDMA channel x destination address register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant SEC_LPDMA1_LPDMA_C1DAR_DA                        \ destination address


\
\ @brief LPDMA channel x linked-list address register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$0000fffc constant SEC_LPDMA1_LPDMA_C1LLR_LA                        \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant SEC_LPDMA1_LPDMA_C1LLR_ULL                       \ Update LPDMA_CxLLR from memory This bit controls the update of the LPDMA_CxLLR register from the memory during the link transfer. - 0: no LPDMA_CxLLR update - 1: LPDMA_CxLLR update
$08000000 constant SEC_LPDMA1_LPDMA_C1LLR_UDA                       \ Update LPDMA_CxDAR from memory This bit controls the update of the LPDMA_CxDAR register from the memory during the link transfer. - 0: no LPDMA_CxDAR update - 1: LPDMA_CxDAR update
$10000000 constant SEC_LPDMA1_LPDMA_C1LLR_USA                       \ Update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer. - 0: no LPDMA_CxSAR update - 1: LPDMA_CxSAR update
$20000000 constant SEC_LPDMA1_LPDMA_C1LLR_UB1                       \ Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if LPDMA_CxLLR != 0, the linked-list is not completed. Then LPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no LPDMA_CxBR1 update (LPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: LPDMA_CxBR1 update
$40000000 constant SEC_LPDMA1_LPDMA_C1LLR_UT2                       \ Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer. - 0: no LPDMA_CxTR2 update - 1: LPDMA_CxTR2 update
$80000000 constant SEC_LPDMA1_LPDMA_C1LLR_UT1                       \ Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer. - 0: no LPDMA_CxTR1 update - 1: LPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_LPDMA1_LPDMA_C2LBAR_LBA                      \ linked-list base address of DMA channel x


\
\ @brief LPDMA channel x flag clear register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000100 constant SEC_LPDMA1_LPDMA_C2FCR_TCF                       \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant SEC_LPDMA1_LPDMA_C2FCR_HTF                       \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant SEC_LPDMA1_LPDMA_C2FCR_DTEF                      \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant SEC_LPDMA1_LPDMA_C2FCR_ULEF                      \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant SEC_LPDMA1_LPDMA_C2FCR_USEF                      \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant SEC_LPDMA1_LPDMA_C2FCR_SUSPF                     \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag


\
\ @brief channel x status register
\ Address offset: 0x160
\ Reset value: 0x00000001
\

$00000001 constant SEC_LPDMA1_LPDMA_C2SR_IDLEF                      \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into LPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant SEC_LPDMA1_LPDMA_C2SR_TCF                        \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0].
$00000200 constant SEC_LPDMA1_LPDMA_C2SR_HTF                        \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of LPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (LPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant SEC_LPDMA1_LPDMA_C2SR_DTEF                       \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant SEC_LPDMA1_LPDMA_C2SR_ULEF                       \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant SEC_LPDMA1_LPDMA_C2SR_USEF                       \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant SEC_LPDMA1_LPDMA_C2SR_SUSPF                      \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred


\
\ @brief channel x control register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPDMA1_LPDMA_C2CR_EN                         \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_LPDMA1_LPDMA_C2CR_RESET                      \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. LPDMA_CxSR.SUSPF=1 and LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant SEC_LPDMA1_LPDMA_C2CR_SUSP                       \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant SEC_LPDMA1_LPDMA_C2CR_TCIE                       \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant SEC_LPDMA1_LPDMA_C2CR_HTIE                       \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant SEC_LPDMA1_LPDMA_C2CR_DTEIE                      \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant SEC_LPDMA1_LPDMA_C2CR_ULEIE                      \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant SEC_LPDMA1_LPDMA_C2CR_USEIE                      \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant SEC_LPDMA1_LPDMA_C2CR_SUSPIE                     \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant SEC_LPDMA1_LPDMA_C2CR_LSM                        \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when LPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_LPDMA1_LPDMA_C2CR_PRIO                       \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief LPDMA channel x transfer register 1
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000003 constant SEC_LPDMA1_LPDMA_C2TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxSAR[2:0] and address offset LPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00000008 constant SEC_LPDMA1_LPDMA_C2TR1_SINC                      \ source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$00001800 constant SEC_LPDMA1_LPDMA_C2TR1_PAM                       \ PAM
$00008000 constant SEC_LPDMA1_LPDMA_C2TR1_SSEC                      \ security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
$00030000 constant SEC_LPDMA1_LPDMA_C2TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxDAR[2:0] and address offset LPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00080000 constant SEC_LPDMA1_LPDMA_C2TR1_DINC                      \ destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$80000000 constant SEC_LPDMA1_LPDMA_C2TR1_DSEC                      \ security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure


\
\ @brief LPDMA channel x transfer register 2
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$0000001f constant SEC_LPDMA1_LPDMA_C2TR2_REQSEL                    \ DMA hardware request selection If the channel x is activated (i.e. LPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if LPDMA_CxCR.EN=1 and LPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_LPDMA1_LPDMA_C2TR2_SWREQ                     \ Software request When LPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000800 constant SEC_LPDMA1_LPDMA_C2TR2_BREQ                      \ BREQ
$0000c000 constant SEC_LPDMA1_LPDMA_C2TR2_TRIGM                     \ Trigger mode
$001f0000 constant SEC_LPDMA1_LPDMA_C2TR2_TRIGSEL                   \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant SEC_LPDMA1_LPDMA_C2TR2_TRIGPOL                   \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant SEC_LPDMA1_LPDMA_C2TR2_TCEM                      \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when LPDMA_CxBR1.BRC[10:0]= 0 and LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address LPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the LPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief LPDMA channel x block register 1
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPDMA1_LPDMA_C2BR1_BNDT                      \ block number of data bytes to transfer from the source


\
\ @brief LPDMA channel x source address register
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant SEC_LPDMA1_LPDMA_C2SAR_SA                        \ source address


\
\ @brief LPDMA channel x destination address register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant SEC_LPDMA1_LPDMA_C2DAR_DA                        \ destination address


\
\ @brief LPDMA channel x linked-list address register
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$0000fffc constant SEC_LPDMA1_LPDMA_C2LLR_LA                        \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant SEC_LPDMA1_LPDMA_C2LLR_ULL                       \ Update LPDMA_CxLLR from memory This bit controls the update of the LPDMA_CxLLR register from the memory during the link transfer. - 0: no LPDMA_CxLLR update - 1: LPDMA_CxLLR update
$08000000 constant SEC_LPDMA1_LPDMA_C2LLR_UDA                       \ Update LPDMA_CxDAR from memory This bit controls the update of the LPDMA_CxDAR register from the memory during the link transfer. - 0: no LPDMA_CxDAR update - 1: LPDMA_CxDAR update
$10000000 constant SEC_LPDMA1_LPDMA_C2LLR_USA                       \ Update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer. - 0: no LPDMA_CxSAR update - 1: LPDMA_CxSAR update
$20000000 constant SEC_LPDMA1_LPDMA_C2LLR_UB1                       \ Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if LPDMA_CxLLR != 0, the linked-list is not completed. Then LPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no LPDMA_CxBR1 update (LPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: LPDMA_CxBR1 update
$40000000 constant SEC_LPDMA1_LPDMA_C2LLR_UT2                       \ Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer. - 0: no LPDMA_CxTR2 update - 1: LPDMA_CxTR2 update
$80000000 constant SEC_LPDMA1_LPDMA_C2LLR_UT1                       \ Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer. - 0: no LPDMA_CxTR1 update - 1: LPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_LPDMA1_LPDMA_C3LBAR_LBA                      \ linked-list base address of DMA channel x


\
\ @brief LPDMA channel x flag clear register
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$00000100 constant SEC_LPDMA1_LPDMA_C3FCR_TCF                       \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant SEC_LPDMA1_LPDMA_C3FCR_HTF                       \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant SEC_LPDMA1_LPDMA_C3FCR_DTEF                      \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant SEC_LPDMA1_LPDMA_C3FCR_ULEF                      \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant SEC_LPDMA1_LPDMA_C3FCR_USEF                      \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant SEC_LPDMA1_LPDMA_C3FCR_SUSPF                     \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag


\
\ @brief channel x status register
\ Address offset: 0x1E0
\ Reset value: 0x00000001
\

$00000001 constant SEC_LPDMA1_LPDMA_C3SR_IDLEF                      \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into LPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant SEC_LPDMA1_LPDMA_C3SR_TCF                        \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0].
$00000200 constant SEC_LPDMA1_LPDMA_C3SR_HTF                        \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. LPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of LPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (LPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant SEC_LPDMA1_LPDMA_C3SR_DTEF                       \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant SEC_LPDMA1_LPDMA_C3SR_ULEF                       \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant SEC_LPDMA1_LPDMA_C3SR_USEF                       \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant SEC_LPDMA1_LPDMA_C3SR_SUSPF                      \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred


\
\ @brief channel x control register
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPDMA1_LPDMA_C3CR_EN                         \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_LPDMA1_LPDMA_C3CR_RESET                      \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. LPDMA_CxSR.SUSPF=1 and LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. LPDMA_CxSR.IDLEF=1 and LPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant SEC_LPDMA1_LPDMA_C3CR_SUSP                       \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant SEC_LPDMA1_LPDMA_C3CR_TCIE                       \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant SEC_LPDMA1_LPDMA_C3CR_HTIE                       \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant SEC_LPDMA1_LPDMA_C3CR_DTEIE                      \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant SEC_LPDMA1_LPDMA_C3CR_ULEIE                      \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant SEC_LPDMA1_LPDMA_C3CR_USEIE                      \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant SEC_LPDMA1_LPDMA_C3CR_SUSPIE                     \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant SEC_LPDMA1_LPDMA_C3CR_LSM                        \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when LPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (LPDMA_CxBR1.BRC[10:0]=0 and LPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_LPDMA1_LPDMA_C3CR_PRIO                       \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief LPDMA channel x transfer register 1
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000003 constant SEC_LPDMA1_LPDMA_C3TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxSAR[2:0] and address offset LPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00000008 constant SEC_LPDMA1_LPDMA_C3TR1_SINC                      \ source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$00001800 constant SEC_LPDMA1_LPDMA_C3TR1_PAM                       \ PAM
$00008000 constant SEC_LPDMA1_LPDMA_C3TR1_SSEC                      \ security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
$00030000 constant SEC_LPDMA1_LPDMA_C3TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address LPDMA_CxDAR[2:0] and address offset LPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. LPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00080000 constant SEC_LPDMA1_LPDMA_C3TR1_DINC                      \ destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$80000000 constant SEC_LPDMA1_LPDMA_C3TR1_DSEC                      \ security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx=1. A secure write is ignored when LPDMA_SECCFGR.SECx=0.When is de-asserted LPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If LPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure


\
\ @brief LPDMA channel x transfer register 2
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$0000001f constant SEC_LPDMA1_LPDMA_C3TR2_REQSEL                    \ DMA hardware request selection If the channel x is activated (i.e. LPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if LPDMA_CxCR.EN=1 and LPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_LPDMA1_LPDMA_C3TR2_SWREQ                     \ Software request When LPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000800 constant SEC_LPDMA1_LPDMA_C3TR2_BREQ                      \ BREQ
$0000c000 constant SEC_LPDMA1_LPDMA_C3TR2_TRIGM                     \ Trigger mode
$001f0000 constant SEC_LPDMA1_LPDMA_C3TR2_TRIGSEL                   \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant SEC_LPDMA1_LPDMA_C3TR2_TRIGPOL                   \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant SEC_LPDMA1_LPDMA_C3TR2_TCEM                      \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when LPDMA_CxBR1.BRC[10:0]= 0 and LPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address LPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the LPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief LPDMA channel x block register 1
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPDMA1_LPDMA_C3BR1_BNDT                      \ block number of data bytes to transfer from the source


\
\ @brief LPDMA channel x source address register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant SEC_LPDMA1_LPDMA_C3SAR_SA                        \ source address


\
\ @brief LPDMA channel x destination address register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant SEC_LPDMA1_LPDMA_C3DAR_DA                        \ destination address


\
\ @brief LPDMA channel x linked-list address register
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$0000fffc constant SEC_LPDMA1_LPDMA_C3LLR_LA                        \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant SEC_LPDMA1_LPDMA_C3LLR_ULL                       \ Update LPDMA_CxLLR from memory This bit controls the update of the LPDMA_CxLLR register from the memory during the link transfer. - 0: no LPDMA_CxLLR update - 1: LPDMA_CxLLR update
$08000000 constant SEC_LPDMA1_LPDMA_C3LLR_UDA                       \ Update LPDMA_CxDAR from memory This bit controls the update of the LPDMA_CxDAR register from the memory during the link transfer. - 0: no LPDMA_CxDAR update - 1: LPDMA_CxDAR update
$10000000 constant SEC_LPDMA1_LPDMA_C3LLR_USA                       \ Update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer. - 0: no LPDMA_CxSAR update - 1: LPDMA_CxSAR update
$20000000 constant SEC_LPDMA1_LPDMA_C3LLR_UB1                       \ Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if LPDMA_CxLLR != 0, the linked-list is not completed. Then LPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no LPDMA_CxBR1 update (LPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: LPDMA_CxBR1 update
$40000000 constant SEC_LPDMA1_LPDMA_C3LLR_UT2                       \ Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer. - 0: no LPDMA_CxTR2 update - 1: LPDMA_CxTR2 update
$80000000 constant SEC_LPDMA1_LPDMA_C3LLR_UT1                       \ Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer. - 0: no LPDMA_CxTR1 update - 1: LPDMA_CxTR1 update


\
\ @brief LPDMA1
\
$56025000 constant SEC_LPDMA1_LPDMA_SECCFGR  \ offset: 0x00 : LPDMA secure configuration register
$56025004 constant SEC_LPDMA1_LPDMA_PRIVCFGR  \ offset: 0x04 : LPDMA privileged configuration register
$5602500c constant SEC_LPDMA1_MISR  \ offset: 0x0C : LPDMA non-secure masked interrupt status register
$56025010 constant SEC_LPDMA1_SMISR  \ offset: 0x10 : LPDMA secure masked interrupt status register
$56025050 constant SEC_LPDMA1_LPDMA_C0LBAR  \ offset: 0x50 : channel x linked-list base address register
$5602505c constant SEC_LPDMA1_LPDMA_C0FCR  \ offset: 0x5C : LPDMA channel x flag clear register
$56025060 constant SEC_LPDMA1_LPDMA_C0SR  \ offset: 0x60 : channel x status register
$56025064 constant SEC_LPDMA1_LPDMA_C0CR  \ offset: 0x64 : channel x control register
$56025090 constant SEC_LPDMA1_LPDMA_C0TR1  \ offset: 0x90 : LPDMA channel x transfer register 1
$56025094 constant SEC_LPDMA1_LPDMA_C0TR2  \ offset: 0x94 : LPDMA channel x transfer register 2
$56025098 constant SEC_LPDMA1_LPDMA_C0BR1  \ offset: 0x98 : LPDMA channel x block register 1
$5602509c constant SEC_LPDMA1_LPDMA_C0SAR  \ offset: 0x9C : LPDMA channel x source address register
$560250a0 constant SEC_LPDMA1_LPDMA_C0DAR  \ offset: 0xA0 : LPDMA channel x destination address register
$560250cc constant SEC_LPDMA1_LPDMA_C0LLR  \ offset: 0xCC : LPDMA channel x linked-list address register
$560250d0 constant SEC_LPDMA1_LPDMA_C1LBAR  \ offset: 0xD0 : channel x linked-list base address register
$560250dc constant SEC_LPDMA1_LPDMA_C1FCR  \ offset: 0xDC : LPDMA channel x flag clear register
$560250e0 constant SEC_LPDMA1_LPDMA_C1SR  \ offset: 0xE0 : channel x status register
$560250e4 constant SEC_LPDMA1_LPDMA_C1CR  \ offset: 0xE4 : channel x control register
$56025110 constant SEC_LPDMA1_LPDMA_C1TR1  \ offset: 0x110 : LPDMA channel x transfer register 1
$56025114 constant SEC_LPDMA1_LPDMA_C1TR2  \ offset: 0x114 : LPDMA channel x transfer register 2
$56025118 constant SEC_LPDMA1_LPDMA_C1BR1  \ offset: 0x118 : LPDMA channel x block register 1
$5602511c constant SEC_LPDMA1_LPDMA_C1SAR  \ offset: 0x11C : LPDMA channel x source address register
$56025120 constant SEC_LPDMA1_LPDMA_C1DAR  \ offset: 0x120 : LPDMA channel x destination address register
$5602514c constant SEC_LPDMA1_LPDMA_C1LLR  \ offset: 0x14C : LPDMA channel x linked-list address register
$56025150 constant SEC_LPDMA1_LPDMA_C2LBAR  \ offset: 0x150 : channel x linked-list base address register
$5602515c constant SEC_LPDMA1_LPDMA_C2FCR  \ offset: 0x15C : LPDMA channel x flag clear register
$56025160 constant SEC_LPDMA1_LPDMA_C2SR  \ offset: 0x160 : channel x status register
$56025164 constant SEC_LPDMA1_LPDMA_C2CR  \ offset: 0x164 : channel x control register
$56025190 constant SEC_LPDMA1_LPDMA_C2TR1  \ offset: 0x190 : LPDMA channel x transfer register 1
$56025194 constant SEC_LPDMA1_LPDMA_C2TR2  \ offset: 0x194 : LPDMA channel x transfer register 2
$56025198 constant SEC_LPDMA1_LPDMA_C2BR1  \ offset: 0x198 : LPDMA channel x block register 1
$5602519c constant SEC_LPDMA1_LPDMA_C2SAR  \ offset: 0x19C : LPDMA channel x source address register
$560251a0 constant SEC_LPDMA1_LPDMA_C2DAR  \ offset: 0x1A0 : LPDMA channel x destination address register
$560251cc constant SEC_LPDMA1_LPDMA_C2LLR  \ offset: 0x1CC : LPDMA channel x linked-list address register
$560251d0 constant SEC_LPDMA1_LPDMA_C3LBAR  \ offset: 0x1D0 : channel x linked-list base address register
$560251dc constant SEC_LPDMA1_LPDMA_C3FCR  \ offset: 0x1DC : LPDMA channel x flag clear register
$560251e0 constant SEC_LPDMA1_LPDMA_C3SR  \ offset: 0x1E0 : channel x status register
$560251e4 constant SEC_LPDMA1_LPDMA_C3CR  \ offset: 0x1E4 : channel x control register
$56025210 constant SEC_LPDMA1_LPDMA_C3TR1  \ offset: 0x210 : LPDMA channel x transfer register 1
$56025214 constant SEC_LPDMA1_LPDMA_C3TR2  \ offset: 0x214 : LPDMA channel x transfer register 2
$56025218 constant SEC_LPDMA1_LPDMA_C3BR1  \ offset: 0x218 : LPDMA channel x block register 1
$5602521c constant SEC_LPDMA1_LPDMA_C3SAR  \ offset: 0x21C : LPDMA channel x source address register
$56025220 constant SEC_LPDMA1_LPDMA_C3DAR  \ offset: 0x220 : LPDMA channel x destination address register
$5602524c constant SEC_LPDMA1_LPDMA_C3LLR  \ offset: 0x24C : LPDMA channel x linked-list address register

