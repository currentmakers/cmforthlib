\
\ @file gpdma1.fs
\ @brief GPDMA1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPDMA1_DEF

  [ifdef] GPDMA1_GPDMA_SECCFGR_DEF
    \
    \ @brief GPDMA secure configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SEC0                    \ [0x00] SEC0
    $01 constant GPDMA1_SEC1                    \ [0x01] SEC1
    $02 constant GPDMA1_SEC2                    \ [0x02] SEC2
    $03 constant GPDMA1_SEC3                    \ [0x03] SEC3
    $04 constant GPDMA1_SEC4                    \ [0x04] SEC4
    $05 constant GPDMA1_SEC5                    \ [0x05] SEC5
    $06 constant GPDMA1_SEC6                    \ [0x06] SEC6
    $07 constant GPDMA1_SEC7                    \ [0x07] SEC7
    $08 constant GPDMA1_SEC8                    \ [0x08] SEC8
    $09 constant GPDMA1_SEC9                    \ [0x09] SEC9
    $0a constant GPDMA1_SEC10                   \ [0x0a] SEC10
    $0b constant GPDMA1_SEC11                   \ [0x0b] SEC11
    $0c constant GPDMA1_SEC12                   \ [0x0c] SEC12
    $0d constant GPDMA1_SEC13                   \ [0x0d] SEC13
    $0e constant GPDMA1_SEC14                   \ [0x0e] SEC14
    $0f constant GPDMA1_SEC15                   \ [0x0f] SEC15
  [then]


  [ifdef] GPDMA1_GPDMA_PRIVCFGR_DEF
    \
    \ @brief GPDMA privileged configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_PRIV0                   \ [0x00] PRIV0
    $01 constant GPDMA1_PRIV1                   \ [0x01] PRIV1
    $02 constant GPDMA1_PRIV2                   \ [0x02] PRIV2
    $03 constant GPDMA1_PRIV3                   \ [0x03] PRIV3
    $04 constant GPDMA1_PRIV4                   \ [0x04] PRIV4
    $05 constant GPDMA1_PRIV5                   \ [0x05] PRIV5
    $06 constant GPDMA1_PRIV6                   \ [0x06] PRIV6
    $07 constant GPDMA1_PRIV7                   \ [0x07] PRIV7
    $08 constant GPDMA1_PRIV8                   \ [0x08] PRIV8
    $09 constant GPDMA1_PRIV9                   \ [0x09] PRIV9
    $0a constant GPDMA1_PRIV10                  \ [0x0a] PRIV10
    $0b constant GPDMA1_PRIV11                  \ [0x0b] PRIV11
    $0c constant GPDMA1_PRIV12                  \ [0x0c] PRIV12
    $0d constant GPDMA1_PRIV13                  \ [0x0d] PRIV13
    $0e constant GPDMA1_PRIV14                  \ [0x0e] PRIV14
    $0f constant GPDMA1_PRIV15                  \ [0x0f] PRIV15
  [then]


  [ifdef] GPDMA1_MISR_DEF
    \
    \ @brief non-secure masked interrupt status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_MIS0                    \ [0x00] MIS0
    $01 constant GPDMA1_MIS1                    \ [0x01] MIS1
    $02 constant GPDMA1_MIS2                    \ [0x02] MIS2
    $03 constant GPDMA1_MIS3                    \ [0x03] MIS3
    $04 constant GPDMA1_MIS4                    \ [0x04] MIS4
    $05 constant GPDMA1_MIS5                    \ [0x05] MIS5
    $06 constant GPDMA1_MIS6                    \ [0x06] MIS6
    $07 constant GPDMA1_MIS7                    \ [0x07] MIS7
    $08 constant GPDMA1_MIS8                    \ [0x08] MIS8
    $09 constant GPDMA1_MIS9                    \ [0x09] MIS9
    $0a constant GPDMA1_MIS10                   \ [0x0a] MIS10
    $0b constant GPDMA1_MIS11                   \ [0x0b] MIS11
    $0c constant GPDMA1_MIS12                   \ [0x0c] MIS12
    $0d constant GPDMA1_MIS13                   \ [0x0d] MIS13
    $0e constant GPDMA1_MIS14                   \ [0x0e] MIS14
    $0f constant GPDMA1_MIS15                   \ [0x0f] MIS15
  [then]


  [ifdef] GPDMA1_SMISR_DEF
    \
    \ @brief secure masked interrupt status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_MIS0                    \ [0x00] MIS0
    $01 constant GPDMA1_MIS1                    \ [0x01] MIS1
    $02 constant GPDMA1_MIS2                    \ [0x02] MIS2
    $03 constant GPDMA1_MIS3                    \ [0x03] MIS3
    $04 constant GPDMA1_MIS4                    \ [0x04] MIS4
    $05 constant GPDMA1_MIS5                    \ [0x05] MIS5
    $06 constant GPDMA1_MIS6                    \ [0x06] MIS6
    $07 constant GPDMA1_MIS7                    \ [0x07] MIS7
    $08 constant GPDMA1_MIS8                    \ [0x08] MIS8
    $09 constant GPDMA1_MIS9                    \ [0x09] MIS9
    $0a constant GPDMA1_MIS10                   \ [0x0a] MIS10
    $0b constant GPDMA1_MIS11                   \ [0x0b] MIS11
    $0c constant GPDMA1_MIS12                   \ [0x0c] MIS12
    $0d constant GPDMA1_MIS13                   \ [0x0d] MIS13
    $0e constant GPDMA1_MIS14                   \ [0x0e] MIS14
    $0f constant GPDMA1_MIS15                   \ [0x0f] MIS15
  [then]


  [ifdef] GPDMA1_GPDMA_C0LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C0FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C0SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C0CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C0TR1_DEF
    \
    \ @brief GPDMA channel x transfer register 1
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxSAR[2:0] and address offset GPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If SBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the source data width i.e. SDW_LOG2[1:0].Note: A burst transfer must have an aligned address (c.f. start address GPDMA_CxSAR and address offset GPDMA_CxTR3.SAO) with its data width (byte, half-word or word). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] PAM
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source wordIf source data width is shorter than a word, this bit is ignored.If source data width is a word:- 0: no byte-based exchange within the unaligned half-word of each source word- 1: the two consecutive bytes within the unaligned half-word of each source word are exchanged
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated portAllocate the master port to the source transfer.- 0: port 0 (AHB) is allocated to the source transfer- 1: port 1 (AHB) is allocated to the source transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If DBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the destination data width i.e. DDW_LOG2[1:0].Note: A burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchangeIf destination data size is a byte, this bit is ignored.If destination data size is not a byte:- 0: no byte-based exchange within half-word- 1: the two consecutive (post PAM) bytes are exchanged in each destination half-word
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchangeIf destination data size is shorter than a word, this bit is ignored.If destination data size is a word:- 0: no halfword-based exchange within word- 1: the two consecutive (post PAM) half-words are exchanged in each destination word
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated portAllocate the master port to the destination transfer.- 0: port 0 (AHB) is allocated to the destination transfer- 1: port 1 (AHB) is allocated to the destination transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
  [then]


  [ifdef] GPDMA1_GPDMA_C0TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C0BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C0SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C0DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C0LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C1LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C1FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C1SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0xE0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C1CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C1TR1_DEF
    \
    \ @brief GPDMA channel x transfer register 1
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxSAR[2:0] and address offset GPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If SBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the source data width i.e. SDW_LOG2[1:0].Note: A burst transfer must have an aligned address (c.f. start address GPDMA_CxSAR and address offset GPDMA_CxTR3.SAO) with its data width (byte, half-word or word). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] PAM
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source wordIf source data width is shorter than a word, this bit is ignored.If source data width is a word:- 0: no byte-based exchange within the unaligned half-word of each source word- 1: the two consecutive bytes within the unaligned half-word of each source word are exchanged
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated portAllocate the master port to the source transfer.- 0: port 0 (AHB) is allocated to the source transfer- 1: port 1 (AHB) is allocated to the source transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If DBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the destination data width i.e. DDW_LOG2[1:0].Note: A burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchangeIf destination data size is a byte, this bit is ignored.If destination data size is not a byte:- 0: no byte-based exchange within half-word- 1: the two consecutive (post PAM) bytes are exchanged in each destination half-word
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchangeIf destination data size is shorter than a word, this bit is ignored.If destination data size is a word:- 0: no halfword-based exchange within word- 1: the two consecutive (post PAM) half-words are exchanged in each destination word
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated portAllocate the master port to the destination transfer.- 0: port 0 (AHB) is allocated to the destination transfer- 1: port 1 (AHB) is allocated to the destination transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
  [then]


  [ifdef] GPDMA1_GPDMA_C1TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] TRIGM mode
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C1BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C1SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C1DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C1LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C2LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C2FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C2SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x160
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C2CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C2TR1_DEF
    \
    \ @brief GPDMA channel x transfer register 1
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxSAR[2:0] and address offset GPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If SBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the source data width i.e. SDW_LOG2[1:0].Note: A burst transfer must have an aligned address (c.f. start address GPDMA_CxSAR and address offset GPDMA_CxTR3.SAO) with its data width (byte, half-word or word). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] PAM
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source wordIf source data width is shorter than a word, this bit is ignored.If source data width is a word:- 0: no byte-based exchange within the unaligned half-word of each source word- 1: the two consecutive bytes within the unaligned half-word of each source word are exchanged
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated portAllocate the master port to the source transfer.- 0: port 0 (AHB) is allocated to the source transfer- 1: port 1 (AHB) is allocated to the source transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If DBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the destination data width i.e. DDW_LOG2[1:0].Note: A burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchangeIf destination data size is a byte, this bit is ignored.If destination data size is not a byte:- 0: no byte-based exchange within half-word- 1: the two consecutive (post PAM) bytes are exchanged in each destination half-word
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchangeIf destination data size is shorter than a word, this bit is ignored.If destination data size is a word:- 0: no halfword-based exchange within word- 1: the two consecutive (post PAM) half-words are exchanged in each destination word
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated portAllocate the master port to the destination transfer.- 0: port 0 (AHB) is allocated to the destination transfer- 1: port 1 (AHB) is allocated to the destination transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
  [then]


  [ifdef] GPDMA1_GPDMA_C2TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C2BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C2SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C2DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C2LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C3LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C3FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C3SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C3CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel. i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C3TR1_DEF
    \
    \ @brief GPDMA channel x transfer register 1
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxSAR[2:0] and address offset GPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If SBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the source data width i.e. SDW_LOG2[1:0].Note: A burst transfer must have an aligned address (c.f. start address GPDMA_CxSAR and address offset GPDMA_CxTR3.SAO) with its data width (byte, half-word or word). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] PAM
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source wordIf source data width is shorter than a word, this bit is ignored.If source data width is a word:- 0: no byte-based exchange within the unaligned half-word of each source word- 1: the two consecutive bytes within the unaligned half-word of each source word are exchanged
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated portAllocate the master port to the source transfer.- 0: port 0 (AHB) is allocated to the source transfer- 1: port 1 (AHB) is allocated to the source transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If DBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the destination data width i.e. DDW_LOG2[1:0].Note: A burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchangeIf destination data size is a byte, this bit is ignored.If destination data size is not a byte:- 0: no byte-based exchange within half-word- 1: the two consecutive (post PAM) bytes are exchanged in each destination half-word
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchangeIf destination data size is shorter than a word, this bit is ignored.If destination data size is a word:- 0: no halfword-based exchange within word- 1: the two consecutive (post PAM) half-words are exchanged in each destination word
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated portAllocate the master port to the destination transfer.- 0: port 0 (AHB) is allocated to the destination transfer- 1: port 1 (AHB) is allocated to the destination transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
  [then]


  [ifdef] GPDMA1_GPDMA_C3TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C3BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C3SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C3DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C3LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C4LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C4FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C4SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x260
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C4CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C4TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: rst read of a/each block transfer is conditioned by one hit trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode
  [then]


  [ifdef] GPDMA1_GPDMA_C4BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C4SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C4DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C4LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C5LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C5FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C5SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x2E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C5CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C5TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C5BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C5SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C5DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C5LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C6LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C6FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C6SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x360
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C6CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C6TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when GPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if GPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C6BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C6SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C6DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C6LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C7LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C7FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C7SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x3E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C7CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C7TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when GPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if GPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11: the first burst read of a 2D/repeated block transfer is conditioned by one hit trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C7BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C7SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C7DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C7LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C8LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x450
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C8FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x45C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C8SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x460
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C8CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C8TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x494
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when GPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if GPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11: the first burst read of a 2D/repeated block transfer is conditioned by one hit trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C8BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C8SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x49C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C8DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C8LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x4CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C9LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x4D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C9FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x4DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C9SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x4E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C9CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x4E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C9TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when GPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if GPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11: the first burst read of a 2D/repeated block transfer is conditioned by one hit trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C9BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x518
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C9SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C9DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C9LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C10LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C10FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x55C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C10SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x560
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C10CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C10TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when GPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if GPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11: the first burst read of a 2D/repeated block transfer is conditioned by one hit trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C10BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x598
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C10SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x59C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C10DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C10LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C11LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C11FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x5DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C11SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x5E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C11CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C11TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: enabled. Transferring a next LLIn+1 which updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0] resets the monitoring, trashing the (possible) memorized hit of the formerly defined LLIn trigger. After that a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, this new second trigger hitn+2 is lost and not memorized. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0]=11 and (SWREQ=1 or (SWREQ=0 and DREQ=0)), the shortened burst transfer (by single(s) or/and by burst(s) of lower length) is conditioned once by the trigger. Note: When the programmed destination burst is internally shortened by single(s) or/and by burst(s) of lower length (e.g. vs FIFO size, vs block size, 1kB/4kB boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0]=11 and SWREQ=0 and DREQ=1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C11BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x618
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA1_GPDMA_C11SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C11DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C11LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C12LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C12FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C12SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x660
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C12CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C12TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: enabled. Transferring a next LLIn+1 which updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0] resets the monitoring, trashing the (possible) memorized hit of the formerly defined LLIn trigger. After that a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, this new second trigger hitn+2 is lost and not memorized. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0]=11 and (SWREQ=1 or (SWREQ=0 and DREQ=0)), the shortened burst transfer (by single(s) or/and by burst(s) of lower length) is conditioned once by the trigger. Note: When the programmed destination burst is internally shortened by single(s) or/and by burst(s) of lower length (e.g. vs FIFO size, vs block size, 1kB/4kB boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0]=11 and SWREQ=0 and DREQ=1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C12BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x698
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
    $10 constant GPDMA1_BRC                     \ [0x10 : 11] BRC
    $1c constant GPDMA1_SDEC                    \ [0x1c] SDEC
    $1d constant GPDMA1_DDEC                    \ [0x1d] DDEC
    $1e constant GPDMA1_BRSDEC                  \ [0x1e] BRSDEC
    $1f constant GPDMA1_BRDDEC                  \ [0x1f] BRDDEC
  [then]


  [ifdef] GPDMA1_GPDMA_C12SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x69C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C12DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C12TR3_DEF
    \
    \ @brief GPDMA channel x transfer register 3
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SAO                     \ [0x00 : 13] source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.SINC=1. Note: A source address offset must be aligned with the programmed data width of a source burst (c.f. SAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $10 constant GPDMA1_DAO                     \ [0x10 : 13] destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.DINC=1. Note: A destination address offset must be aligned with the programmed data width of a destination burst (c.f. DAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. Note: When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C12BR2_DEF
    \
    \ @brief GPDMA channel x block register 2
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BRSAO                   \ [0x00 : 16] Block repeated source address offset For a channel with 2D addressing capability, this field BRSAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (i.e. GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (c.f. BRSAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $10 constant GPDMA1_BRDAO                   \ [0x10 : 16] Block repeated destination address offset For a channel with 2D addressing capability, this field BRDAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (i.e. GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (c.f. BRDAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C12LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $19 constant GPDMA1_UB2                     \ [0x19] Update GPDMA_CxBR2 from memory This bit controls the update of the GPDMA_CxBR2 register from the memory during the link transfer. - 0: no GPDMA_CxBR2 update - 1: GPDMA_CxBR2 update
    $1a constant GPDMA1_UT3                     \ [0x1a] Update GPDMA_CxTR3 from memory This bit controls the update of the GPDMA_CxTR3 register from the memory during the link transfer. - 0: no GPDMA_CxTR3 update - 1: GPDMA_CxTR3 update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C13LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C13FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x6DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C13SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x6E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C13CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C13TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x714
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: enabled. Transferring a next LLIn+1 which updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0] resets the monitoring, trashing the (possible) memorized hit of the formerly defined LLIn trigger. After that a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, this new second trigger hitn+2 is lost and not memorized. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0]=11 and (SWREQ=1 or (SWREQ=0 and DREQ=0)), the shortened burst transfer (by single(s) or/and by burst(s) of lower length) is conditioned once by the trigger. Note: When the programmed destination burst is internally shortened by single(s) or/and by burst(s) of lower length (e.g. vs FIFO size, vs block size, 1kB/4kB boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0]=11 and SWREQ=0 and DREQ=1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C13BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x718
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
    $10 constant GPDMA1_BRC                     \ [0x10 : 11] BRC
    $1c constant GPDMA1_SDEC                    \ [0x1c] SDEC
    $1d constant GPDMA1_DDEC                    \ [0x1d] DDEC
    $1e constant GPDMA1_BRSDEC                  \ [0x1e] BRSDEC
    $1f constant GPDMA1_BRDDEC                  \ [0x1f] BRDDEC
  [then]


  [ifdef] GPDMA1_GPDMA_C13SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x71C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C13DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x720
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C13TR3_DEF
    \
    \ @brief GPDMA channel x transfer register 3
    \ Address offset: 0x724
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SAO                     \ [0x00 : 13] source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.SINC=1. Note: A source address offset must be aligned with the programmed data width of a source burst (c.f. SAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $10 constant GPDMA1_DAO                     \ [0x10 : 13] destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.DINC=1. Note: A destination address offset must be aligned with the programmed data width of a destination burst (c.f. DAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. Note: When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C13BR2_DEF
    \
    \ @brief GPDMA channel x block register 2
    \ Address offset: 0x728
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BRSAO                   \ [0x00 : 16] Block repeated source address offset For a channel with 2D addressing capability, this field BRSAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (i.e. GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (c.f. BRSAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $10 constant GPDMA1_BRDAO                   \ [0x10 : 16] Block repeated destination address offset For a channel with 2D addressing capability, this field BRDAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (i.e. GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (c.f. BRDAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C13LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $19 constant GPDMA1_UB2                     \ [0x19] Update GPDMA_CxBR2 from memory This bit controls the update of the GPDMA_CxBR2 register from the memory during the link transfer. - 0: no GPDMA_CxBR2 update - 1: GPDMA_CxBR2 update
    $1a constant GPDMA1_UT3                     \ [0x1a] Update GPDMA_CxTR3 from memory This bit controls the update of the GPDMA_CxTR3 register from the memory during the link transfer. - 0: no GPDMA_CxTR3 update - 1: GPDMA_CxTR3 update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C14LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C14FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x75C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C14SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x760
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C14CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x764
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C14TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: enabled. Transferring a next LLIn+1 which updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0] resets the monitoring, trashing the (possible) memorized hit of the formerly defined LLIn trigger. After that a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, this new second trigger hitn+2 is lost and not memorized. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0]=11 and (SWREQ=1 or (SWREQ=0 and DREQ=0)), the shortened burst transfer (by single(s) or/and by burst(s) of lower length) is conditioned once by the trigger. Note: When the programmed destination burst is internally shortened by single(s) or/and by burst(s) of lower length (e.g. vs FIFO size, vs block size, 1kB/4kB boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0]=11 and SWREQ=0 and DREQ=1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C14BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
    $10 constant GPDMA1_BRC                     \ [0x10 : 11] BRC
    $1c constant GPDMA1_SDEC                    \ [0x1c] SDEC
    $1d constant GPDMA1_DDEC                    \ [0x1d] DDEC
    $1e constant GPDMA1_BRSDEC                  \ [0x1e] BRSDEC
    $1f constant GPDMA1_BRDDEC                  \ [0x1f] BRDDEC
  [then]


  [ifdef] GPDMA1_GPDMA_C14SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x79C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C14DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x7A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C14TR3_DEF
    \
    \ @brief GPDMA channel x transfer register 3
    \ Address offset: 0x7A4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SAO                     \ [0x00 : 13] source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.SINC=1. Note: A source address offset must be aligned with the programmed data width of a source burst (c.f. SAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $10 constant GPDMA1_DAO                     \ [0x10 : 13] destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.DINC=1. Note: A destination address offset must be aligned with the programmed data width of a destination burst (c.f. DAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. Note: When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C14BR2_DEF
    \
    \ @brief GPDMA channel x block register 2
    \ Address offset: 0x7A8
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BRSAO                   \ [0x00 : 16] Block repeated source address offset For a channel with 2D addressing capability, this field BRSAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (i.e. GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (c.f. BRSAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $10 constant GPDMA1_BRDAO                   \ [0x10 : 16] Block repeated destination address offset For a channel with 2D addressing capability, this field BRDAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (i.e. GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (c.f. BRDAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C14LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x7CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $19 constant GPDMA1_UB2                     \ [0x19] Update GPDMA_CxBR2 from memory This bit controls the update of the GPDMA_CxBR2 register from the memory during the link transfer. - 0: no GPDMA_CxBR2 update - 1: GPDMA_CxBR2 update
    $1a constant GPDMA1_UT3                     \ [0x1a] Update GPDMA_CxTR3 from memory This bit controls the update of the GPDMA_CxTR3 register from the memory during the link transfer. - 0: no GPDMA_CxTR3 update - 1: GPDMA_CxTR3 update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]


  [ifdef] GPDMA1_GPDMA_C15LBAR_DEF
    \
    \ @brief channel x linked-list base address register
    \ Address offset: 0x7D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of DMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C15FCR_DEF
    \
    \ @brief GPDMA channel x flag clear register
    \ Address offset: 0x7DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C15SR_DEF
    \
    \ @brief channel x status register
    \ Address offset: 0x7E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C15CR_DEF
    \
    \ @brief channel x control register
    \ Address offset: 0x7E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
    $10 constant GPDMA1_LSM                     \ [0x10] Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.
  [then]


  [ifdef] GPDMA1_GPDMA_C15TR2_DEF
    \
    \ @brief GPDMA channel x transfer register 2
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
    $0a constant GPDMA1_DREQ                    \ [0x0a] Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
    $0b constant GPDMA1_BREQ                    \ [0x0b] BREQ
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] Trigger mode: enabled. Transferring a next LLIn+1 which updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0] resets the monitoring, trashing the (possible) memorized hit of the formerly defined LLIn trigger. After that a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, this new second trigger hitn+2 is lost and not memorized. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0]=11 and (SWREQ=1 or (SWREQ=0 and DREQ=0)), the shortened burst transfer (by single(s) or/and by burst(s) of lower length) is conditioned once by the trigger. Note: When the programmed destination burst is internally shortened by single(s) or/and by burst(s) of lower length (e.g. vs FIFO size, vs block size, 1kB/4kB boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0]=11 and SWREQ=0 and DREQ=1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.
  [then]


  [ifdef] GPDMA1_GPDMA_C15BR1_DEF
    \
    \ @brief GPDMA channel x block register 1
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source
    $10 constant GPDMA1_BRC                     \ [0x10 : 11] BRC
    $1c constant GPDMA1_SDEC                    \ [0x1c] SDEC
    $1d constant GPDMA1_DDEC                    \ [0x1d] DDEC
    $1e constant GPDMA1_BRSDEC                  \ [0x1e] BRSDEC
    $1f constant GPDMA1_BRDDEC                  \ [0x1f] BRDDEC
  [then]


  [ifdef] GPDMA1_GPDMA_C15SAR_DEF
    \
    \ @brief GPDMA channel x source address register
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA1_GPDMA_C15DAR_DEF
    \
    \ @brief GPDMA channel x destination address register
    \ Address offset: 0x820
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA1_GPDMA_C15TR3_DEF
    \
    \ @brief GPDMA channel x transfer register 3
    \ Address offset: 0x824
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SAO                     \ [0x00 : 13] source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.SINC=1. Note: A source address offset must be aligned with the programmed data width of a source burst (c.f. SAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $10 constant GPDMA1_DAO                     \ [0x10 : 13] destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.DINC=1. Note: A destination address offset must be aligned with the programmed data width of a destination burst (c.f. DAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. Note: When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C15BR2_DEF
    \
    \ @brief GPDMA channel x block register 2
    \ Address offset: 0x828
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BRSAO                   \ [0x00 : 16] Block repeated source address offset For a channel with 2D addressing capability, this field BRSAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (i.e. GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (c.f. BRSAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
    $10 constant GPDMA1_BRDAO                   \ [0x10 : 16] Block repeated destination address offset For a channel with 2D addressing capability, this field BRDAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (i.e. GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (c.f. BRDAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C15LLR_DEF
    \
    \ @brief GPDMA channel x linked-list address register
    \ Address offset: 0x84C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
    $19 constant GPDMA1_UB2                     \ [0x19] Update GPDMA_CxBR2 from memory This bit controls the update of the GPDMA_CxBR2 register from the memory during the link transfer. - 0: no GPDMA_CxBR2 update - 1: GPDMA_CxBR2 update
    $1a constant GPDMA1_UT3                     \ [0x1a] Update GPDMA_CxTR3 from memory This bit controls the update of the GPDMA_CxTR3 register from the memory during the link transfer. - 0: no GPDMA_CxTR3 update - 1: GPDMA_CxTR3 update
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
    $1c constant GPDMA1_USA                     \ [0x1c] Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update
  [then]

  \
  \ @brief GPDMA1
  \
  $00 constant GPDMA1_GPDMA_SECCFGR     \ GPDMA secure configuration register
  $04 constant GPDMA1_GPDMA_PRIVCFGR    \ GPDMA privileged configuration register
  $0C constant GPDMA1_MISR              \ non-secure masked interrupt status register
  $10 constant GPDMA1_SMISR             \ secure masked interrupt status register
  $50 constant GPDMA1_GPDMA_C0LBAR      \ channel x linked-list base address register
  $5C constant GPDMA1_GPDMA_C0FCR       \ GPDMA channel x flag clear register
  $60 constant GPDMA1_GPDMA_C0SR        \ channel x status register
  $64 constant GPDMA1_GPDMA_C0CR        \ channel x control register
  $90 constant GPDMA1_GPDMA_C0TR1       \ GPDMA channel x transfer register 1
  $94 constant GPDMA1_GPDMA_C0TR2       \ GPDMA channel x transfer register 2
  $98 constant GPDMA1_GPDMA_C0BR1       \ GPDMA channel x block register 1
  $9C constant GPDMA1_GPDMA_C0SAR       \ GPDMA channel x source address register
  $A0 constant GPDMA1_GPDMA_C0DAR       \ GPDMA channel x destination address register
  $CC constant GPDMA1_GPDMA_C0LLR       \ GPDMA channel x linked-list address register
  $D0 constant GPDMA1_GPDMA_C1LBAR      \ channel x linked-list base address register
  $DC constant GPDMA1_GPDMA_C1FCR       \ GPDMA channel x flag clear register
  $E0 constant GPDMA1_GPDMA_C1SR        \ channel x status register
  $E4 constant GPDMA1_GPDMA_C1CR        \ channel x control register
  $110 constant GPDMA1_GPDMA_C1TR1      \ GPDMA channel x transfer register 1
  $114 constant GPDMA1_GPDMA_C1TR2      \ GPDMA channel x transfer register 2
  $118 constant GPDMA1_GPDMA_C1BR1      \ GPDMA channel x block register 1
  $11C constant GPDMA1_GPDMA_C1SAR      \ GPDMA channel x source address register
  $120 constant GPDMA1_GPDMA_C1DAR      \ GPDMA channel x destination address register
  $14C constant GPDMA1_GPDMA_C1LLR      \ GPDMA channel x linked-list address register
  $150 constant GPDMA1_GPDMA_C2LBAR     \ channel x linked-list base address register
  $15C constant GPDMA1_GPDMA_C2FCR      \ GPDMA channel x flag clear register
  $160 constant GPDMA1_GPDMA_C2SR       \ channel x status register
  $164 constant GPDMA1_GPDMA_C2CR       \ channel x control register
  $190 constant GPDMA1_GPDMA_C2TR1      \ GPDMA channel x transfer register 1
  $194 constant GPDMA1_GPDMA_C2TR2      \ GPDMA channel x transfer register 2
  $198 constant GPDMA1_GPDMA_C2BR1      \ GPDMA channel x block register 1
  $19C constant GPDMA1_GPDMA_C2SAR      \ GPDMA channel x source address register
  $1A0 constant GPDMA1_GPDMA_C2DAR      \ GPDMA channel x destination address register
  $1CC constant GPDMA1_GPDMA_C2LLR      \ GPDMA channel x linked-list address register
  $1D0 constant GPDMA1_GPDMA_C3LBAR     \ channel x linked-list base address register
  $1DC constant GPDMA1_GPDMA_C3FCR      \ GPDMA channel x flag clear register
  $1E0 constant GPDMA1_GPDMA_C3SR       \ channel x status register
  $1E4 constant GPDMA1_GPDMA_C3CR       \ channel x control register
  $210 constant GPDMA1_GPDMA_C3TR1      \ GPDMA channel x transfer register 1
  $214 constant GPDMA1_GPDMA_C3TR2      \ GPDMA channel x transfer register 2
  $218 constant GPDMA1_GPDMA_C3BR1      \ GPDMA channel x block register 1
  $21C constant GPDMA1_GPDMA_C3SAR      \ GPDMA channel x source address register
  $220 constant GPDMA1_GPDMA_C3DAR      \ GPDMA channel x destination address register
  $24C constant GPDMA1_GPDMA_C3LLR      \ GPDMA channel x linked-list address register
  $250 constant GPDMA1_GPDMA_C4LBAR     \ channel x linked-list base address register
  $25C constant GPDMA1_GPDMA_C4FCR      \ GPDMA channel x flag clear register
  $260 constant GPDMA1_GPDMA_C4SR       \ channel x status register
  $264 constant GPDMA1_GPDMA_C4CR       \ channel x control register
  $294 constant GPDMA1_GPDMA_C4TR2      \ GPDMA channel x transfer register 2
  $298 constant GPDMA1_GPDMA_C4BR1      \ GPDMA channel x block register 1
  $29C constant GPDMA1_GPDMA_C4SAR      \ GPDMA channel x source address register
  $2A0 constant GPDMA1_GPDMA_C4DAR      \ GPDMA channel x destination address register
  $2CC constant GPDMA1_GPDMA_C4LLR      \ GPDMA channel x linked-list address register
  $2D0 constant GPDMA1_GPDMA_C5LBAR     \ channel x linked-list base address register
  $2DC constant GPDMA1_GPDMA_C5FCR      \ GPDMA channel x flag clear register
  $2E0 constant GPDMA1_GPDMA_C5SR       \ channel x status register
  $2E4 constant GPDMA1_GPDMA_C5CR       \ channel x control register
  $314 constant GPDMA1_GPDMA_C5TR2      \ GPDMA channel x transfer register 2
  $318 constant GPDMA1_GPDMA_C5BR1      \ GPDMA channel x block register 1
  $31C constant GPDMA1_GPDMA_C5SAR      \ GPDMA channel x source address register
  $320 constant GPDMA1_GPDMA_C5DAR      \ GPDMA channel x destination address register
  $34C constant GPDMA1_GPDMA_C5LLR      \ GPDMA channel x linked-list address register
  $350 constant GPDMA1_GPDMA_C6LBAR     \ channel x linked-list base address register
  $35C constant GPDMA1_GPDMA_C6FCR      \ GPDMA channel x flag clear register
  $360 constant GPDMA1_GPDMA_C6SR       \ channel x status register
  $364 constant GPDMA1_GPDMA_C6CR       \ channel x control register
  $394 constant GPDMA1_GPDMA_C6TR2      \ GPDMA channel x transfer register 2
  $398 constant GPDMA1_GPDMA_C6BR1      \ GPDMA channel x block register 1
  $39C constant GPDMA1_GPDMA_C6SAR      \ GPDMA channel x source address register
  $3A0 constant GPDMA1_GPDMA_C6DAR      \ GPDMA channel x destination address register
  $3CC constant GPDMA1_GPDMA_C6LLR      \ GPDMA channel x linked-list address register
  $3D0 constant GPDMA1_GPDMA_C7LBAR     \ channel x linked-list base address register
  $3DC constant GPDMA1_GPDMA_C7FCR      \ GPDMA channel x flag clear register
  $3E0 constant GPDMA1_GPDMA_C7SR       \ channel x status register
  $3E4 constant GPDMA1_GPDMA_C7CR       \ channel x control register
  $414 constant GPDMA1_GPDMA_C7TR2      \ GPDMA channel x transfer register 2
  $418 constant GPDMA1_GPDMA_C7BR1      \ GPDMA channel x block register 1
  $41C constant GPDMA1_GPDMA_C7SAR      \ GPDMA channel x source address register
  $420 constant GPDMA1_GPDMA_C7DAR      \ GPDMA channel x destination address register
  $44C constant GPDMA1_GPDMA_C7LLR      \ GPDMA channel x linked-list address register
  $450 constant GPDMA1_GPDMA_C8LBAR     \ channel x linked-list base address register
  $45C constant GPDMA1_GPDMA_C8FCR      \ GPDMA channel x flag clear register
  $460 constant GPDMA1_GPDMA_C8SR       \ channel x status register
  $464 constant GPDMA1_GPDMA_C8CR       \ channel x control register
  $494 constant GPDMA1_GPDMA_C8TR2      \ GPDMA channel x transfer register 2
  $498 constant GPDMA1_GPDMA_C8BR1      \ GPDMA channel x block register 1
  $49C constant GPDMA1_GPDMA_C8SAR      \ GPDMA channel x source address register
  $4A0 constant GPDMA1_GPDMA_C8DAR      \ GPDMA channel x destination address register
  $4CC constant GPDMA1_GPDMA_C8LLR      \ GPDMA channel x linked-list address register
  $4D0 constant GPDMA1_GPDMA_C9LBAR     \ channel x linked-list base address register
  $4DC constant GPDMA1_GPDMA_C9FCR      \ GPDMA channel x flag clear register
  $4E0 constant GPDMA1_GPDMA_C9SR       \ channel x status register
  $4E4 constant GPDMA1_GPDMA_C9CR       \ channel x control register
  $514 constant GPDMA1_GPDMA_C9TR2      \ GPDMA channel x transfer register 2
  $518 constant GPDMA1_GPDMA_C9BR1      \ GPDMA channel x block register 1
  $51C constant GPDMA1_GPDMA_C9SAR      \ GPDMA channel x source address register
  $520 constant GPDMA1_GPDMA_C9DAR      \ GPDMA channel x destination address register
  $54C constant GPDMA1_GPDMA_C9LLR      \ GPDMA channel x linked-list address register
  $550 constant GPDMA1_GPDMA_C10LBAR    \ channel x linked-list base address register
  $55C constant GPDMA1_GPDMA_C10FCR     \ GPDMA channel x flag clear register
  $560 constant GPDMA1_GPDMA_C10SR      \ channel x status register
  $564 constant GPDMA1_GPDMA_C10CR      \ channel x control register
  $594 constant GPDMA1_GPDMA_C10TR2     \ GPDMA channel x transfer register 2
  $598 constant GPDMA1_GPDMA_C10BR1     \ GPDMA channel x block register 1
  $59C constant GPDMA1_GPDMA_C10SAR     \ GPDMA channel x source address register
  $5A0 constant GPDMA1_GPDMA_C10DAR     \ GPDMA channel x destination address register
  $5CC constant GPDMA1_GPDMA_C10LLR     \ GPDMA channel x linked-list address register
  $5D0 constant GPDMA1_GPDMA_C11LBAR    \ channel x linked-list base address register
  $5DC constant GPDMA1_GPDMA_C11FCR     \ GPDMA channel x flag clear register
  $5E0 constant GPDMA1_GPDMA_C11SR      \ channel x status register
  $5E4 constant GPDMA1_GPDMA_C11CR      \ channel x control register
  $614 constant GPDMA1_GPDMA_C11TR2     \ GPDMA channel x transfer register 2
  $618 constant GPDMA1_GPDMA_C11BR1     \ GPDMA channel x block register 1
  $61C constant GPDMA1_GPDMA_C11SAR     \ GPDMA channel x source address register
  $620 constant GPDMA1_GPDMA_C11DAR     \ GPDMA channel x destination address register
  $64C constant GPDMA1_GPDMA_C11LLR     \ GPDMA channel x linked-list address register
  $650 constant GPDMA1_GPDMA_C12LBAR    \ channel x linked-list base address register
  $65C constant GPDMA1_GPDMA_C12FCR     \ GPDMA channel x flag clear register
  $660 constant GPDMA1_GPDMA_C12SR      \ channel x status register
  $664 constant GPDMA1_GPDMA_C12CR      \ channel x control register
  $694 constant GPDMA1_GPDMA_C12TR2     \ GPDMA channel x transfer register 2
  $698 constant GPDMA1_GPDMA_C12BR1     \ GPDMA channel x block register 1
  $69C constant GPDMA1_GPDMA_C12SAR     \ GPDMA channel x source address register
  $6A0 constant GPDMA1_GPDMA_C12DAR     \ GPDMA channel x destination address register
  $6A4 constant GPDMA1_GPDMA_C12TR3     \ GPDMA channel x transfer register 3
  $6A8 constant GPDMA1_GPDMA_C12BR2     \ GPDMA channel x block register 2
  $6CC constant GPDMA1_GPDMA_C12LLR     \ GPDMA channel x linked-list address register
  $6D0 constant GPDMA1_GPDMA_C13LBAR    \ channel x linked-list base address register
  $6DC constant GPDMA1_GPDMA_C13FCR     \ GPDMA channel x flag clear register
  $6E0 constant GPDMA1_GPDMA_C13SR      \ channel x status register
  $6E4 constant GPDMA1_GPDMA_C13CR      \ channel x control register
  $714 constant GPDMA1_GPDMA_C13TR2     \ GPDMA channel x transfer register 2
  $718 constant GPDMA1_GPDMA_C13BR1     \ GPDMA channel x block register 1
  $71C constant GPDMA1_GPDMA_C13SAR     \ GPDMA channel x source address register
  $720 constant GPDMA1_GPDMA_C13DAR     \ GPDMA channel x destination address register
  $724 constant GPDMA1_GPDMA_C13TR3     \ GPDMA channel x transfer register 3
  $728 constant GPDMA1_GPDMA_C13BR2     \ GPDMA channel x block register 2
  $74C constant GPDMA1_GPDMA_C13LLR     \ GPDMA channel x linked-list address register
  $750 constant GPDMA1_GPDMA_C14LBAR    \ channel x linked-list base address register
  $75C constant GPDMA1_GPDMA_C14FCR     \ GPDMA channel x flag clear register
  $760 constant GPDMA1_GPDMA_C14SR      \ channel x status register
  $764 constant GPDMA1_GPDMA_C14CR      \ channel x control register
  $794 constant GPDMA1_GPDMA_C14TR2     \ GPDMA channel x transfer register 2
  $798 constant GPDMA1_GPDMA_C14BR1     \ GPDMA channel x block register 1
  $79C constant GPDMA1_GPDMA_C14SAR     \ GPDMA channel x source address register
  $7A0 constant GPDMA1_GPDMA_C14DAR     \ GPDMA channel x destination address register
  $7A4 constant GPDMA1_GPDMA_C14TR3     \ GPDMA channel x transfer register 3
  $7A8 constant GPDMA1_GPDMA_C14BR2     \ GPDMA channel x block register 2
  $7CC constant GPDMA1_GPDMA_C14LLR     \ GPDMA channel x linked-list address register
  $7D0 constant GPDMA1_GPDMA_C15LBAR    \ channel x linked-list base address register
  $7DC constant GPDMA1_GPDMA_C15FCR     \ GPDMA channel x flag clear register
  $7E0 constant GPDMA1_GPDMA_C15SR      \ channel x status register
  $7E4 constant GPDMA1_GPDMA_C15CR      \ channel x control register
  $814 constant GPDMA1_GPDMA_C15TR2     \ GPDMA channel x transfer register 2
  $818 constant GPDMA1_GPDMA_C15BR1     \ GPDMA channel x block register 1
  $81C constant GPDMA1_GPDMA_C15SAR     \ GPDMA channel x source address register
  $820 constant GPDMA1_GPDMA_C15DAR     \ GPDMA channel x destination address register
  $824 constant GPDMA1_GPDMA_C15TR3     \ GPDMA channel x transfer register 3
  $828 constant GPDMA1_GPDMA_C15BR2     \ GPDMA channel x block register 2
  $84C constant GPDMA1_GPDMA_C15LLR     \ GPDMA channel x linked-list address register

: GPDMA1_DEF ; [then]
