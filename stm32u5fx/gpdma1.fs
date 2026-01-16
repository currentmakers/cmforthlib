\
\ @file gpdma1.fs
\ @brief GPDMA1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GPDMA secure configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_SECCFGR_SEC0                        \ SEC0
$00000002 constant GPDMA1_GPDMA_SECCFGR_SEC1                        \ SEC1
$00000004 constant GPDMA1_GPDMA_SECCFGR_SEC2                        \ SEC2
$00000008 constant GPDMA1_GPDMA_SECCFGR_SEC3                        \ SEC3
$00000010 constant GPDMA1_GPDMA_SECCFGR_SEC4                        \ SEC4
$00000020 constant GPDMA1_GPDMA_SECCFGR_SEC5                        \ SEC5
$00000040 constant GPDMA1_GPDMA_SECCFGR_SEC6                        \ SEC6
$00000080 constant GPDMA1_GPDMA_SECCFGR_SEC7                        \ SEC7
$00000100 constant GPDMA1_GPDMA_SECCFGR_SEC8                        \ SEC8
$00000200 constant GPDMA1_GPDMA_SECCFGR_SEC9                        \ SEC9
$00000400 constant GPDMA1_GPDMA_SECCFGR_SEC10                       \ SEC10
$00000800 constant GPDMA1_GPDMA_SECCFGR_SEC11                       \ SEC11
$00001000 constant GPDMA1_GPDMA_SECCFGR_SEC12                       \ SEC12
$00002000 constant GPDMA1_GPDMA_SECCFGR_SEC13                       \ SEC13
$00004000 constant GPDMA1_GPDMA_SECCFGR_SEC14                       \ SEC14
$00008000 constant GPDMA1_GPDMA_SECCFGR_SEC15                       \ SEC15


\
\ @brief GPDMA privileged configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_PRIVCFGR_PRIV0                      \ PRIV0
$00000002 constant GPDMA1_GPDMA_PRIVCFGR_PRIV1                      \ PRIV1
$00000004 constant GPDMA1_GPDMA_PRIVCFGR_PRIV2                      \ PRIV2
$00000008 constant GPDMA1_GPDMA_PRIVCFGR_PRIV3                      \ PRIV3
$00000010 constant GPDMA1_GPDMA_PRIVCFGR_PRIV4                      \ PRIV4
$00000020 constant GPDMA1_GPDMA_PRIVCFGR_PRIV5                      \ PRIV5
$00000040 constant GPDMA1_GPDMA_PRIVCFGR_PRIV6                      \ PRIV6
$00000080 constant GPDMA1_GPDMA_PRIVCFGR_PRIV7                      \ PRIV7
$00000100 constant GPDMA1_GPDMA_PRIVCFGR_PRIV8                      \ PRIV8
$00000200 constant GPDMA1_GPDMA_PRIVCFGR_PRIV9                      \ PRIV9
$00000400 constant GPDMA1_GPDMA_PRIVCFGR_PRIV10                     \ PRIV10
$00000800 constant GPDMA1_GPDMA_PRIVCFGR_PRIV11                     \ PRIV11
$00001000 constant GPDMA1_GPDMA_PRIVCFGR_PRIV12                     \ PRIV12
$00002000 constant GPDMA1_GPDMA_PRIVCFGR_PRIV13                     \ PRIV13
$00004000 constant GPDMA1_GPDMA_PRIVCFGR_PRIV14                     \ PRIV14
$00008000 constant GPDMA1_GPDMA_PRIVCFGR_PRIV15                     \ PRIV15


\
\ @brief non-secure masked interrupt status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_MISR_MIS0                                 \ MIS0
$00000002 constant GPDMA1_MISR_MIS1                                 \ MIS1
$00000004 constant GPDMA1_MISR_MIS2                                 \ MIS2
$00000008 constant GPDMA1_MISR_MIS3                                 \ MIS3
$00000010 constant GPDMA1_MISR_MIS4                                 \ MIS4
$00000020 constant GPDMA1_MISR_MIS5                                 \ MIS5
$00000040 constant GPDMA1_MISR_MIS6                                 \ MIS6
$00000080 constant GPDMA1_MISR_MIS7                                 \ MIS7
$00000100 constant GPDMA1_MISR_MIS8                                 \ MIS8
$00000200 constant GPDMA1_MISR_MIS9                                 \ MIS9
$00000400 constant GPDMA1_MISR_MIS10                                \ MIS10
$00000800 constant GPDMA1_MISR_MIS11                                \ MIS11
$00001000 constant GPDMA1_MISR_MIS12                                \ MIS12
$00002000 constant GPDMA1_MISR_MIS13                                \ MIS13
$00004000 constant GPDMA1_MISR_MIS14                                \ MIS14
$00008000 constant GPDMA1_MISR_MIS15                                \ MIS15


\
\ @brief secure masked interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_SMISR_MIS0                                \ MIS0
$00000002 constant GPDMA1_SMISR_MIS1                                \ MIS1
$00000004 constant GPDMA1_SMISR_MIS2                                \ MIS2
$00000008 constant GPDMA1_SMISR_MIS3                                \ MIS3
$00000010 constant GPDMA1_SMISR_MIS4                                \ MIS4
$00000020 constant GPDMA1_SMISR_MIS5                                \ MIS5
$00000040 constant GPDMA1_SMISR_MIS6                                \ MIS6
$00000080 constant GPDMA1_SMISR_MIS7                                \ MIS7
$00000100 constant GPDMA1_SMISR_MIS8                                \ MIS8
$00000200 constant GPDMA1_SMISR_MIS9                                \ MIS9
$00000400 constant GPDMA1_SMISR_MIS10                               \ MIS10
$00000800 constant GPDMA1_SMISR_MIS11                               \ MIS11
$00001000 constant GPDMA1_SMISR_MIS12                               \ MIS12
$00002000 constant GPDMA1_SMISR_MIS13                               \ MIS13
$00004000 constant GPDMA1_SMISR_MIS14                               \ MIS14
$00008000 constant GPDMA1_SMISR_MIS15                               \ MIS15


\
\ @brief channel x linked-list base address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C0LBAR_LBA                          \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C0FCR_TCF                           \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C0FCR_HTF                           \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C0FCR_DTEF                          \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C0FCR_ULEF                          \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C0FCR_USEF                          \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C0FCR_SUSPF                         \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C0FCR_TOF                           \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C0SR_IDLEF                          \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C0SR_TCF                            \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C0SR_HTF                            \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C0SR_DTEF                           \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C0SR_ULEF                           \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C0SR_USEF                           \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C0SR_SUSPF                          \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C0SR_FIFOL                          \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C0CR_EN                             \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C0CR_RESET                          \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0.
$00000004 constant GPDMA1_GPDMA_C0CR_SUSP                           \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C0CR_TCIE                           \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C0CR_HTIE                           \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C0CR_DTEIE                          \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C0CR_ULEIE                          \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C0CR_USEIE                          \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C0CR_SUSPIE                         \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C0CR_LSM                            \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C0CR_LAP                            \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C0CR_PRIO                           \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000003 constant GPDMA1_GPDMA_C0TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxSAR[2:0] and address offset GPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00000008 constant GPDMA1_GPDMA_C0TR1_SINC                          \ source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant GPDMA1_GPDMA_C0TR1_SBL_1                         \ source burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If SBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the source data width i.e. SDW_LOG2[1:0].Note: A burst transfer must have an aligned address (c.f. start address GPDMA_CxSAR and address offset GPDMA_CxTR3.SAO) with its data width (byte, half-word or word). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
$00001800 constant GPDMA1_GPDMA_C0TR1_PAM                           \ PAM
$00002000 constant GPDMA1_GPDMA_C0TR1_SBX                           \ source byte exchange within the unaligned half-word of each source wordIf source data width is shorter than a word, this bit is ignored.If source data width is a word:- 0: no byte-based exchange within the unaligned half-word of each source word- 1: the two consecutive bytes within the unaligned half-word of each source word are exchanged
$00004000 constant GPDMA1_GPDMA_C0TR1_SAP                           \ source allocated portAllocate the master port to the source transfer.- 0: port 0 (AHB) is allocated to the source transfer- 1: port 1 (AHB) is allocated to the source transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00008000 constant GPDMA1_GPDMA_C0TR1_SSEC                          \ security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
$00030000 constant GPDMA1_GPDMA_C0TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00080000 constant GPDMA1_GPDMA_C0TR1_DINC                          \ destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant GPDMA1_GPDMA_C0TR1_DBL_1                         \ destination burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If DBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the destination data width i.e. DDW_LOG2[1:0].Note: A burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
$04000000 constant GPDMA1_GPDMA_C0TR1_DBX                           \ destination byte exchangeIf destination data size is a byte, this bit is ignored.If destination data size is not a byte:- 0: no byte-based exchange within half-word- 1: the two consecutive (post PAM) bytes are exchanged in each destination half-word
$08000000 constant GPDMA1_GPDMA_C0TR1_DHX                           \ destination half-word exchangeIf destination data size is shorter than a word, this bit is ignored.If destination data size is a word:- 0: no halfword-based exchange within word- 1: the two consecutive (post PAM) half-words are exchanged in each destination word
$40000000 constant GPDMA1_GPDMA_C0TR1_DAP                           \ destination allocated portAllocate the master port to the destination transfer.- 0: port 0 (AHB) is allocated to the destination transfer- 1: port 1 (AHB) is allocated to the destination transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$80000000 constant GPDMA1_GPDMA_C0TR1_DSEC                          \ security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C0TR2_REQSEL                        \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C0TR2_SWREQ                         \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C0TR2_DREQ                          \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C0TR2_BREQ                          \ BREQ
$0000c000 constant GPDMA1_GPDMA_C0TR2_TRIGM                         \ Trigger mode
$003f0000 constant GPDMA1_GPDMA_C0TR2_TRIGSEL                       \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C0TR2_TRIGPOL                       \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C0TR2_TCEM                          \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C0BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C0SAR_SA                            \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C0DAR_DA                            \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C0LLR_LA                            \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C0LLR_ULL                           \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C0LLR_UDA                           \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C0LLR_USA                           \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C0LLR_UB1                           \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C0LLR_UT2                           \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C0LLR_UT1                           \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C1LBAR_LBA                          \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C1FCR_TCF                           \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C1FCR_HTF                           \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C1FCR_DTEF                          \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C1FCR_ULEF                          \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C1FCR_USEF                          \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C1FCR_SUSPF                         \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C1FCR_TOF                           \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0xE0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C1SR_IDLEF                          \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C1SR_TCF                            \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C1SR_HTF                            \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C1SR_DTEF                           \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C1SR_ULEF                           \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C1SR_USEF                           \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C1SR_SUSPF                          \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C1SR_FIFOL                          \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C1CR_EN                             \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C1CR_RESET                          \ reset
$00000004 constant GPDMA1_GPDMA_C1CR_SUSP                           \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C1CR_TCIE                           \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C1CR_HTIE                           \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C1CR_DTEIE                          \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C1CR_ULEIE                          \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C1CR_USEIE                          \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C1CR_SUSPIE                         \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C1CR_LSM                            \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C1CR_LAP                            \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C1CR_PRIO                           \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 1
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000003 constant GPDMA1_GPDMA_C1TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxSAR[2:0] and address offset GPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00000008 constant GPDMA1_GPDMA_C1TR1_SINC                          \ source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant GPDMA1_GPDMA_C1TR1_SBL_1                         \ source burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If SBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the source data width i.e. SDW_LOG2[1:0].Note: A burst transfer must have an aligned address (c.f. start address GPDMA_CxSAR and address offset GPDMA_CxTR3.SAO) with its data width (byte, half-word or word). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
$00001800 constant GPDMA1_GPDMA_C1TR1_PAM                           \ PAM
$00002000 constant GPDMA1_GPDMA_C1TR1_SBX                           \ source byte exchange within the unaligned half-word of each source wordIf source data width is shorter than a word, this bit is ignored.If source data width is a word:- 0: no byte-based exchange within the unaligned half-word of each source word- 1: the two consecutive bytes within the unaligned half-word of each source word are exchanged
$00004000 constant GPDMA1_GPDMA_C1TR1_SAP                           \ source allocated portAllocate the master port to the source transfer.- 0: port 0 (AHB) is allocated to the source transfer- 1: port 1 (AHB) is allocated to the source transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00008000 constant GPDMA1_GPDMA_C1TR1_SSEC                          \ security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
$00030000 constant GPDMA1_GPDMA_C1TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00080000 constant GPDMA1_GPDMA_C1TR1_DINC                          \ destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant GPDMA1_GPDMA_C1TR1_DBL_1                         \ destination burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If DBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the destination data width i.e. DDW_LOG2[1:0].Note: A burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
$04000000 constant GPDMA1_GPDMA_C1TR1_DBX                           \ destination byte exchangeIf destination data size is a byte, this bit is ignored.If destination data size is not a byte:- 0: no byte-based exchange within half-word- 1: the two consecutive (post PAM) bytes are exchanged in each destination half-word
$08000000 constant GPDMA1_GPDMA_C1TR1_DHX                           \ destination half-word exchangeIf destination data size is shorter than a word, this bit is ignored.If destination data size is a word:- 0: no halfword-based exchange within word- 1: the two consecutive (post PAM) half-words are exchanged in each destination word
$40000000 constant GPDMA1_GPDMA_C1TR1_DAP                           \ destination allocated portAllocate the master port to the destination transfer.- 0: port 0 (AHB) is allocated to the destination transfer- 1: port 1 (AHB) is allocated to the destination transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$80000000 constant GPDMA1_GPDMA_C1TR1_DSEC                          \ security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C1TR2_REQSEL                        \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C1TR2_SWREQ                         \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C1TR2_DREQ                          \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C1TR2_BREQ                          \ BREQ
$0000c000 constant GPDMA1_GPDMA_C1TR2_TRIGM                         \ TRIGM mode
$003f0000 constant GPDMA1_GPDMA_C1TR2_TRIGSEL                       \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C1TR2_TRIGPOL                       \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C1TR2_TCEM                          \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C1BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C1SAR_SA                            \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C1DAR_DA                            \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C1LLR_LA                            \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C1LLR_ULL                           \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C1LLR_UDA                           \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C1LLR_USA                           \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C1LLR_UB1                           \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C1LLR_UT2                           \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C1LLR_UT1                           \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C2LBAR_LBA                          \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C2FCR_TCF                           \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C2FCR_HTF                           \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C2FCR_DTEF                          \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C2FCR_ULEF                          \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C2FCR_USEF                          \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C2FCR_SUSPF                         \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C2FCR_TOF                           \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x160
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C2SR_IDLEF                          \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C2SR_TCF                            \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C2SR_HTF                            \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C2SR_DTEF                           \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C2SR_ULEF                           \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C2SR_USEF                           \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C2SR_SUSPF                          \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C2SR_FIFOL                          \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C2CR_EN                             \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C2CR_RESET                          \ reset
$00000004 constant GPDMA1_GPDMA_C2CR_SUSP                           \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C2CR_TCIE                           \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C2CR_HTIE                           \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C2CR_DTEIE                          \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C2CR_ULEIE                          \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C2CR_USEIE                          \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C2CR_SUSPIE                         \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C2CR_LSM                            \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C2CR_LAP                            \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C2CR_PRIO                           \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 1
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000003 constant GPDMA1_GPDMA_C2TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxSAR[2:0] and address offset GPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00000008 constant GPDMA1_GPDMA_C2TR1_SINC                          \ source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant GPDMA1_GPDMA_C2TR1_SBL_1                         \ source burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If SBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the source data width i.e. SDW_LOG2[1:0].Note: A burst transfer must have an aligned address (c.f. start address GPDMA_CxSAR and address offset GPDMA_CxTR3.SAO) with its data width (byte, half-word or word). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
$00001800 constant GPDMA1_GPDMA_C2TR1_PAM                           \ PAM
$00002000 constant GPDMA1_GPDMA_C2TR1_SBX                           \ source byte exchange within the unaligned half-word of each source wordIf source data width is shorter than a word, this bit is ignored.If source data width is a word:- 0: no byte-based exchange within the unaligned half-word of each source word- 1: the two consecutive bytes within the unaligned half-word of each source word are exchanged
$00004000 constant GPDMA1_GPDMA_C2TR1_SAP                           \ source allocated portAllocate the master port to the source transfer.- 0: port 0 (AHB) is allocated to the source transfer- 1: port 1 (AHB) is allocated to the source transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00008000 constant GPDMA1_GPDMA_C2TR1_SSEC                          \ security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
$00030000 constant GPDMA1_GPDMA_C2TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00080000 constant GPDMA1_GPDMA_C2TR1_DINC                          \ destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant GPDMA1_GPDMA_C2TR1_DBL_1                         \ destination burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If DBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the destination data width i.e. DDW_LOG2[1:0].Note: A burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
$04000000 constant GPDMA1_GPDMA_C2TR1_DBX                           \ destination byte exchangeIf destination data size is a byte, this bit is ignored.If destination data size is not a byte:- 0: no byte-based exchange within half-word- 1: the two consecutive (post PAM) bytes are exchanged in each destination half-word
$08000000 constant GPDMA1_GPDMA_C2TR1_DHX                           \ destination half-word exchangeIf destination data size is shorter than a word, this bit is ignored.If destination data size is a word:- 0: no halfword-based exchange within word- 1: the two consecutive (post PAM) half-words are exchanged in each destination word
$40000000 constant GPDMA1_GPDMA_C2TR1_DAP                           \ destination allocated portAllocate the master port to the destination transfer.- 0: port 0 (AHB) is allocated to the destination transfer- 1: port 1 (AHB) is allocated to the destination transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$80000000 constant GPDMA1_GPDMA_C2TR1_DSEC                          \ security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C2TR2_REQSEL                        \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C2TR2_SWREQ                         \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C2TR2_DREQ                          \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C2TR2_BREQ                          \ BREQ
$0000c000 constant GPDMA1_GPDMA_C2TR2_TRIGM                         \ Trigger mode
$003f0000 constant GPDMA1_GPDMA_C2TR2_TRIGSEL                       \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C2TR2_TRIGPOL                       \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C2TR2_TCEM                          \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C2BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C2SAR_SA                            \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C2DAR_DA                            \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C2LLR_LA                            \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C2LLR_ULL                           \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C2LLR_UDA                           \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C2LLR_USA                           \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C2LLR_UB1                           \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C2LLR_UT2                           \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C2LLR_UT1                           \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C3LBAR_LBA                          \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C3FCR_TCF                           \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C3FCR_HTF                           \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C3FCR_DTEF                          \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C3FCR_ULEF                          \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C3FCR_USEF                          \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C3FCR_SUSPF                         \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C3FCR_TOF                           \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x1E0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C3SR_IDLEF                          \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C3SR_TCF                            \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C3SR_HTF                            \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C3SR_DTEF                           \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C3SR_ULEF                           \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C3SR_USEF                           \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C3SR_SUSPF                          \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C3SR_FIFOL                          \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C3CR_EN                             \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C3CR_RESET                          \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel. i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant GPDMA1_GPDMA_C3CR_SUSP                           \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C3CR_TCIE                           \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C3CR_HTIE                           \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C3CR_DTEIE                          \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C3CR_ULEIE                          \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C3CR_USEIE                          \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C3CR_SUSPIE                         \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C3CR_LSM                            \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C3CR_LAP                            \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C3CR_PRIO                           \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 1
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000003 constant GPDMA1_GPDMA_C3TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: a source block size must be a multiple of the source data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: A source burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxSAR[2:0] and address offset GPDMA_CxTR3.SAO[2:0] vs SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00000008 constant GPDMA1_GPDMA_C3TR1_SINC                          \ source incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe source address, pointed by DMA_CxSAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant GPDMA1_GPDMA_C3TR1_SBL_1                         \ source burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If SBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the source data width i.e. SDW_LOG2[1:0].Note: A burst transfer must have an aligned address (c.f. start address GPDMA_CxSAR and address offset GPDMA_CxTR3.SAO) with its data width (byte, half-word or word). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
$00001800 constant GPDMA1_GPDMA_C3TR1_PAM                           \ PAM
$00002000 constant GPDMA1_GPDMA_C3TR1_SBX                           \ source byte exchange within the unaligned half-word of each source wordIf source data width is shorter than a word, this bit is ignored.If source data width is a word:- 0: no byte-based exchange within the unaligned half-word of each source word- 1: the two consecutive bytes within the unaligned half-word of each source word are exchanged
$00004000 constant GPDMA1_GPDMA_C3TR1_SAP                           \ source allocated portAllocate the master port to the source transfer.- 0: port 0 (AHB) is allocated to the source transfer- 1: port 1 (AHB) is allocated to the source transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00008000 constant GPDMA1_GPDMA_C3TR1_SSEC                          \ security attribute of the DMA transfer from the sourceThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer from the source is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure
$00030000 constant GPDMA1_GPDMA_C3TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes- 00: byte- 01: half-word (2 bytes)- 10: word (4 bytes)- 11: a user setting error is reported and no transfer is issued.Note: Setting a 8-byte data width is causing a user setting error to be reported and none transfer is issued.Note: A destination burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: When configured in packing mode (i.e. if PAM[1]=1 and destination data width different from source data width), a source block size must be a multiple of the destination data width (c.f. GPDMA_CxBR1.BNDT[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$00080000 constant GPDMA1_GPDMA_C3TR1_DINC                          \ destination incrementing burst- 0: fixed burst- 1: contiguously incremented burstThe destination address, pointed by DMA_CxDAR, is either kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant GPDMA1_GPDMA_C3TR1_DBL_1                         \ destination burst length minus 1 , between 0 and 63.Burst length unit is one data a.k.a. beat within a burst.If DBL_1[5:0]=0, then burst can be named as single.Each data/beat has a width defined by the destination data width i.e. DDW_LOG2[1:0].Note: A burst transfer must have an aligned address with its data width (c.f. start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0] vs DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.Note: If a burst transfer would have crossed a 1kB address boundary on a AHB transfer, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the AHB protocol.Note: If a burst transfer is of length greater than the FIFO size of the channel x, internally DMA modifies and shortens the programmed burst into single(s) or burst(s) of lower length, to be compliant with the FIFO size. Transfer performance is lower, with DMA re-arbitration between effective and lower burst(s)/singles, but data integrity is guaranteed.
$04000000 constant GPDMA1_GPDMA_C3TR1_DBX                           \ destination byte exchangeIf destination data size is a byte, this bit is ignored.If destination data size is not a byte:- 0: no byte-based exchange within half-word- 1: the two consecutive (post PAM) bytes are exchanged in each destination half-word
$08000000 constant GPDMA1_GPDMA_C3TR1_DHX                           \ destination half-word exchangeIf destination data size is shorter than a word, this bit is ignored.If destination data size is a word:- 0: no halfword-based exchange within word- 1: the two consecutive (post PAM) half-words are exchanged in each destination word
$40000000 constant GPDMA1_GPDMA_C3TR1_DAP                           \ destination allocated portAllocate the master port to the destination transfer.- 0: port 0 (AHB) is allocated to the destination transfer- 1: port 1 (AHB) is allocated to the destination transferNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$80000000 constant GPDMA1_GPDMA_C3TR1_DSEC                          \ security attribute of the DMA transfer to the destinationThis is a secure register bit.This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx=1. A secure write is ignored when GPDMA_SECCFGR.SECx=0.When is de-asserted GPDMA_SECCFGR.SECx, this bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the DMA transfer to the destination is non-secure.If GPDMA_SECCFGR.SECx=1 (and a secure access):- 0: non-secure- 1: secure


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C3TR2_REQSEL                        \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C3TR2_SWREQ                         \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C3TR2_DREQ                          \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C3TR2_BREQ                          \ BREQ
$0000c000 constant GPDMA1_GPDMA_C3TR2_TRIGM                         \ Trigger mode
$003f0000 constant GPDMA1_GPDMA_C3TR2_TRIGSEL                       \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C3TR2_TRIGPOL                       \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C3TR2_TCEM                          \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C3BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C3SAR_SA                            \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C3DAR_DA                            \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C3LLR_LA                            \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C3LLR_ULL                           \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C3LLR_UDA                           \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C3LLR_USA                           \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C3LLR_UB1                           \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C3LLR_UT2                           \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C3LLR_UT1                           \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C4LBAR_LBA                          \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C4FCR_TCF                           \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C4FCR_HTF                           \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C4FCR_DTEF                          \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C4FCR_ULEF                          \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C4FCR_USEF                          \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C4FCR_SUSPF                         \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C4FCR_TOF                           \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x260
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C4SR_IDLEF                          \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C4SR_TCF                            \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C4SR_HTF                            \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C4SR_DTEF                           \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C4SR_ULEF                           \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C4SR_USEF                           \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C4SR_SUSPF                          \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C4SR_FIFOL                          \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C4CR_EN                             \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C4CR_RESET                          \ reset
$00000004 constant GPDMA1_GPDMA_C4CR_SUSP                           \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C4CR_TCIE                           \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C4CR_HTIE                           \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C4CR_DTEIE                          \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C4CR_ULEIE                          \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C4CR_USEIE                          \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C4CR_SUSPIE                         \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C4CR_LSM                            \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C4CR_LAP                            \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C4CR_PRIO                           \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C4TR2_REQSEL                        \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C4TR2_SWREQ                         \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C4TR2_DREQ                          \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C4TR2_BREQ                          \ BREQ
$0000c000 constant GPDMA1_GPDMA_C4TR2_TRIGM                         \ Trigger mode: rst read of a/each block transfer is conditioned by one hit trigger.
$003f0000 constant GPDMA1_GPDMA_C4TR2_TRIGSEL                       \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C4TR2_TRIGPOL                       \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C4TR2_TCEM                          \ Transfer complete event mode


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C4BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C4SAR_SA                            \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C4DAR_DA                            \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C4LLR_LA                            \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C4LLR_ULL                           \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C4LLR_UDA                           \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C4LLR_USA                           \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C4LLR_UB1                           \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C4LLR_UT2                           \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C4LLR_UT1                           \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C5LBAR_LBA                          \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C5FCR_TCF                           \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C5FCR_HTF                           \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C5FCR_DTEF                          \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C5FCR_ULEF                          \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C5FCR_USEF                          \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C5FCR_SUSPF                         \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C5FCR_TOF                           \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x2E0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C5SR_IDLEF                          \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C5SR_TCF                            \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C5SR_HTF                            \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C5SR_DTEF                           \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C5SR_ULEF                           \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C5SR_USEF                           \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C5SR_SUSPF                          \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C5SR_FIFOL                          \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C5CR_EN                             \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C5CR_RESET                          \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant GPDMA1_GPDMA_C5CR_SUSP                           \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C5CR_TCIE                           \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C5CR_HTIE                           \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C5CR_DTEIE                          \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C5CR_ULEIE                          \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C5CR_USEIE                          \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C5CR_SUSPIE                         \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C5CR_LSM                            \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C5CR_LAP                            \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C5CR_PRIO                           \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C5TR2_REQSEL                        \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C5TR2_SWREQ                         \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C5TR2_DREQ                          \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C5TR2_BREQ                          \ BREQ
$0000c000 constant GPDMA1_GPDMA_C5TR2_TRIGM                         \ Trigger mode
$003f0000 constant GPDMA1_GPDMA_C5TR2_TRIGSEL                       \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C5TR2_TRIGPOL                       \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C5TR2_TCEM                          \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C5BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C5SAR_SA                            \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C5DAR_DA                            \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C5LLR_LA                            \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C5LLR_ULL                           \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C5LLR_UDA                           \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C5LLR_USA                           \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C5LLR_UB1                           \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C5LLR_UT2                           \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C5LLR_UT1                           \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C6LBAR_LBA                          \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C6FCR_TCF                           \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C6FCR_HTF                           \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C6FCR_DTEF                          \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C6FCR_ULEF                          \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C6FCR_USEF                          \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C6FCR_SUSPF                         \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C6FCR_TOF                           \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x360
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C6SR_IDLEF                          \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C6SR_TCF                            \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C6SR_HTF                            \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C6SR_DTEF                           \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C6SR_ULEF                           \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C6SR_USEF                           \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C6SR_SUSPF                          \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C6SR_FIFOL                          \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C6CR_EN                             \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C6CR_RESET                          \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant GPDMA1_GPDMA_C6CR_SUSP                           \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C6CR_TCIE                           \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C6CR_HTIE                           \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C6CR_DTEIE                          \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C6CR_ULEIE                          \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C6CR_USEIE                          \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C6CR_SUSPIE                         \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C6CR_LSM                            \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C6CR_LAP                            \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C6CR_PRIO                           \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C6TR2_REQSEL                        \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C6TR2_SWREQ                         \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C6TR2_DREQ                          \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C6TR2_BREQ                          \ BREQ
$0000c000 constant GPDMA1_GPDMA_C6TR2_TRIGM                         \ Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when GPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if GPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11
$003f0000 constant GPDMA1_GPDMA_C6TR2_TRIGSEL                       \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C6TR2_TRIGPOL                       \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C6TR2_TCEM                          \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C6BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C6SAR_SA                            \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C6DAR_DA                            \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x3CC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C6LLR_LA                            \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C6LLR_ULL                           \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C6LLR_UDA                           \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C6LLR_USA                           \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C6LLR_UB1                           \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C6LLR_UT2                           \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C6LLR_UT1                           \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C7LBAR_LBA                          \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C7FCR_TCF                           \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C7FCR_HTF                           \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C7FCR_DTEF                          \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C7FCR_ULEF                          \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C7FCR_USEF                          \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C7FCR_SUSPF                         \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C7FCR_TOF                           \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x3E0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C7SR_IDLEF                          \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C7SR_TCF                            \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C7SR_HTF                            \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C7SR_DTEF                           \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C7SR_ULEF                           \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C7SR_USEF                           \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C7SR_SUSPF                          \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C7SR_FIFOL                          \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C7CR_EN                             \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C7CR_RESET                          \ reset
$00000004 constant GPDMA1_GPDMA_C7CR_SUSP                           \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C7CR_TCIE                           \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C7CR_HTIE                           \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C7CR_DTEIE                          \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C7CR_ULEIE                          \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C7CR_USEIE                          \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C7CR_SUSPIE                         \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C7CR_LSM                            \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C7CR_LAP                            \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C7CR_PRIO                           \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C7TR2_REQSEL                        \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C7TR2_SWREQ                         \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C7TR2_DREQ                          \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C7TR2_BREQ                          \ BREQ
$0000c000 constant GPDMA1_GPDMA_C7TR2_TRIGM                         \ Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when GPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if GPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11: the first burst read of a 2D/repeated block transfer is conditioned by one hit trigger.
$003f0000 constant GPDMA1_GPDMA_C7TR2_TRIGSEL                       \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C7TR2_TRIGPOL                       \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C7TR2_TCEM                          \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C7BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C7SAR_SA                            \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C7DAR_DA                            \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x44C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C7LLR_LA                            \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C7LLR_ULL                           \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C7LLR_UDA                           \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C7LLR_USA                           \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C7LLR_UB1                           \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C7LLR_UT2                           \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C7LLR_UT1                           \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x450
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C8LBAR_LBA                          \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x45C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C8FCR_TCF                           \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C8FCR_HTF                           \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C8FCR_DTEF                          \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C8FCR_ULEF                          \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C8FCR_USEF                          \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C8FCR_SUSPF                         \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C8FCR_TOF                           \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x460
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C8SR_IDLEF                          \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C8SR_TCF                            \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C8SR_HTF                            \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C8SR_DTEF                           \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C8SR_ULEF                           \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C8SR_USEF                           \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C8SR_SUSPF                          \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C8SR_FIFOL                          \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x464
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C8CR_EN                             \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C8CR_RESET                          \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant GPDMA1_GPDMA_C8CR_SUSP                           \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C8CR_TCIE                           \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C8CR_HTIE                           \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C8CR_DTEIE                          \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C8CR_ULEIE                          \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C8CR_USEIE                          \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C8CR_SUSPIE                         \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C8CR_LSM                            \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C8CR_LAP                            \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C8CR_PRIO                           \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x494
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C8TR2_REQSEL                        \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C8TR2_SWREQ                         \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C8TR2_DREQ                          \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C8TR2_BREQ                          \ BREQ
$0000c000 constant GPDMA1_GPDMA_C8TR2_TRIGM                         \ Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when GPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if GPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11: the first burst read of a 2D/repeated block transfer is conditioned by one hit trigger.
$003f0000 constant GPDMA1_GPDMA_C8TR2_TRIGSEL                       \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C8TR2_TRIGPOL                       \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C8TR2_TCEM                          \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C8BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x49C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C8SAR_SA                            \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C8DAR_DA                            \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x4CC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C8LLR_LA                            \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C8LLR_ULL                           \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C8LLR_UDA                           \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C8LLR_USA                           \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C8LLR_UB1                           \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C8LLR_UT2                           \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C8LLR_UT1                           \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x4D0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C9LBAR_LBA                          \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x4DC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C9FCR_TCF                           \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C9FCR_HTF                           \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C9FCR_DTEF                          \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C9FCR_ULEF                          \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C9FCR_USEF                          \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C9FCR_SUSPF                         \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C9FCR_TOF                           \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x4E0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C9SR_IDLEF                          \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C9SR_TCF                            \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C9SR_HTF                            \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C9SR_DTEF                           \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C9SR_ULEF                           \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C9SR_USEF                           \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C9SR_SUSPF                          \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C9SR_FIFOL                          \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x4E4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C9CR_EN                             \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C9CR_RESET                          \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant GPDMA1_GPDMA_C9CR_SUSP                           \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C9CR_TCIE                           \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C9CR_HTIE                           \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C9CR_DTEIE                          \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C9CR_ULEIE                          \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C9CR_USEIE                          \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C9CR_SUSPIE                         \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C9CR_LSM                            \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C9CR_LAP                            \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C9CR_PRIO                           \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x514
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C9TR2_REQSEL                        \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C9TR2_SWREQ                         \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C9TR2_DREQ                          \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C9TR2_BREQ                          \ BREQ
$0000c000 constant GPDMA1_GPDMA_C9TR2_TRIGM                         \ Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when GPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if GPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11: the first burst read of a 2D/repeated block transfer is conditioned by one hit trigger.
$003f0000 constant GPDMA1_GPDMA_C9TR2_TRIGSEL                       \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C9TR2_TRIGPOL                       \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C9TR2_TCEM                          \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x518
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C9BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x51C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C9SAR_SA                            \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C9DAR_DA                            \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C9LLR_LA                            \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C9LLR_ULL                           \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C9LLR_UDA                           \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C9LLR_USA                           \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C9LLR_UB1                           \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C9LLR_UT2                           \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C9LLR_UT1                           \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C10LBAR_LBA                         \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x55C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C10FCR_TCF                          \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C10FCR_HTF                          \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C10FCR_DTEF                         \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C10FCR_ULEF                         \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C10FCR_USEF                         \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C10FCR_SUSPF                        \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C10FCR_TOF                          \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x560
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C10SR_IDLEF                         \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C10SR_TCF                           \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C10SR_HTF                           \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C10SR_DTEF                          \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C10SR_ULEF                          \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C10SR_USEF                          \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C10SR_SUSPF                         \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C10SR_FIFOL                         \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x564
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C10CR_EN                            \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C10CR_RESET                         \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant GPDMA1_GPDMA_C10CR_SUSP                          \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C10CR_TCIE                          \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C10CR_HTIE                          \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C10CR_DTEIE                         \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C10CR_ULEIE                         \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C10CR_USEIE                         \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C10CR_SUSPIE                        \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C10CR_LSM                           \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C10CR_LAP                           \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C10CR_PRIO                          \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x594
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C10TR2_REQSEL                       \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C10TR2_SWREQ                        \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C10TR2_DREQ                         \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C10TR2_BREQ                         \ BREQ
$0000c000 constant GPDMA1_GPDMA_C10TR2_TRIGM                        \ Trigger mode: Defines the transfer granularity for its conditioning by the trigger. If the channel x is enabled (i.e. when GPDMA_CxCR.EN is asserted) with TRIGPOL[1:0]=00 or 11, these bits are ignored. Else, a DMA transfer is conditioned by (at least) one trigger hit, either at: - 00: at block level (for channel x=12 to 15: for each block if a 2D/repeated block is configured i.e. if GPDMA_CxBR1.BRC[10:0]! = 0): the first burst read of a/each block transfer is conditioned by one hit trigger. - 01: at 2D/repeated block level for channel x=12 to 15; same as 00 for channel x=0 to 11: the first burst read of a 2D/repeated block transfer is conditioned by one hit trigger.
$003f0000 constant GPDMA1_GPDMA_C10TR2_TRIGSEL                      \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C10TR2_TRIGPOL                      \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C10TR2_TCEM                         \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x598
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C10BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x59C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C10SAR_SA                           \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x5A0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C10DAR_DA                           \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x5CC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C10LLR_LA                           \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C10LLR_ULL                          \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C10LLR_UDA                          \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C10LLR_USA                          \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C10LLR_UB1                          \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C10LLR_UT2                          \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C10LLR_UT1                          \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C11LBAR_LBA                         \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x5DC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C11FCR_TCF                          \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C11FCR_HTF                          \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C11FCR_DTEF                         \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C11FCR_ULEF                         \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C11FCR_USEF                         \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C11FCR_SUSPF                        \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C11FCR_TOF                          \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x5E0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C11SR_IDLEF                         \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C11SR_TCF                           \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C11SR_HTF                           \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C11SR_DTEF                          \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C11SR_ULEF                          \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C11SR_USEF                          \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C11SR_SUSPF                         \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C11SR_FIFOL                         \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x5E4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C11CR_EN                            \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C11CR_RESET                         \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant GPDMA1_GPDMA_C11CR_SUSP                          \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C11CR_TCIE                          \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C11CR_HTIE                          \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C11CR_DTEIE                         \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C11CR_ULEIE                         \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C11CR_USEIE                         \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C11CR_SUSPIE                        \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C11CR_LSM                           \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C11CR_LAP                           \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C11CR_PRIO                          \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C11TR2_REQSEL                       \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C11TR2_SWREQ                        \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C11TR2_DREQ                         \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C11TR2_BREQ                         \ BREQ
$0000c000 constant GPDMA1_GPDMA_C11TR2_TRIGM                        \ Trigger mode: enabled. Transferring a next LLIn+1 which updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0] resets the monitoring, trashing the (possible) memorized hit of the formerly defined LLIn trigger. After that a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, this new second trigger hitn+2 is lost and not memorized. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0]=11 and (SWREQ=1 or (SWREQ=0 and DREQ=0)), the shortened burst transfer (by single(s) or/and by burst(s) of lower length) is conditioned once by the trigger. Note: When the programmed destination burst is internally shortened by single(s) or/and by burst(s) of lower length (e.g. vs FIFO size, vs block size, 1kB/4kB boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0]=11 and SWREQ=0 and DREQ=1), this shortened destination burst transfer is conditioned once by the trigger.
$003f0000 constant GPDMA1_GPDMA_C11TR2_TRIGSEL                      \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C11TR2_TRIGPOL                      \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C11TR2_TCEM                         \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x618
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C11BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x61C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C11SAR_SA                           \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C11DAR_DA                           \ destination address


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C11LLR_LA                           \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C11LLR_ULL                          \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$08000000 constant GPDMA1_GPDMA_C11LLR_UDA                          \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C11LLR_USA                          \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C11LLR_UB1                          \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C11LLR_UT2                          \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C11LLR_UT1                          \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C12LBAR_LBA                         \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x65C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C12FCR_TCF                          \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C12FCR_HTF                          \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C12FCR_DTEF                         \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C12FCR_ULEF                         \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C12FCR_USEF                         \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C12FCR_SUSPF                        \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C12FCR_TOF                          \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x660
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C12SR_IDLEF                         \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C12SR_TCF                           \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C12SR_HTF                           \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C12SR_DTEF                          \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C12SR_ULEF                          \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C12SR_USEF                          \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C12SR_SUSPF                         \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C12SR_FIFOL                         \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C12CR_EN                            \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C12CR_RESET                         \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant GPDMA1_GPDMA_C12CR_SUSP                          \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C12CR_TCIE                          \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C12CR_HTIE                          \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C12CR_DTEIE                         \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C12CR_ULEIE                         \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C12CR_USEIE                         \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C12CR_SUSPIE                        \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C12CR_LSM                           \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C12CR_LAP                           \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C12CR_PRIO                          \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x694
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C12TR2_REQSEL                       \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C12TR2_SWREQ                        \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C12TR2_DREQ                         \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C12TR2_BREQ                         \ BREQ
$0000c000 constant GPDMA1_GPDMA_C12TR2_TRIGM                        \ Trigger mode: enabled. Transferring a next LLIn+1 which updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0] resets the monitoring, trashing the (possible) memorized hit of the formerly defined LLIn trigger. After that a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, this new second trigger hitn+2 is lost and not memorized. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0]=11 and (SWREQ=1 or (SWREQ=0 and DREQ=0)), the shortened burst transfer (by single(s) or/and by burst(s) of lower length) is conditioned once by the trigger. Note: When the programmed destination burst is internally shortened by single(s) or/and by burst(s) of lower length (e.g. vs FIFO size, vs block size, 1kB/4kB boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0]=11 and SWREQ=0 and DREQ=1), this shortened destination burst transfer is conditioned once by the trigger.
$003f0000 constant GPDMA1_GPDMA_C12TR2_TRIGSEL                      \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C12TR2_TRIGPOL                      \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C12TR2_TCEM                         \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x698
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C12BR1_BNDT                         \ block number of data bytes to transfer from the source
$07ff0000 constant GPDMA1_GPDMA_C12BR1_BRC                          \ BRC
$10000000 constant GPDMA1_GPDMA_C12BR1_SDEC                         \ SDEC
$20000000 constant GPDMA1_GPDMA_C12BR1_DDEC                         \ DDEC
$40000000 constant GPDMA1_GPDMA_C12BR1_BRSDEC                       \ BRSDEC
$80000000 constant GPDMA1_GPDMA_C12BR1_BRDDEC                       \ BRDDEC


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x69C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C12SAR_SA                           \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x6A0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C12DAR_DA                           \ destination address


\
\ @brief GPDMA channel x transfer register 3
\ Address offset: 0x6A4
\ Reset value: 0x00000000
\

$00001fff constant GPDMA1_GPDMA_C12TR3_SAO                          \ source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.SINC=1. Note: A source address offset must be aligned with the programmed data width of a source burst (c.f. SAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$1fff0000 constant GPDMA1_GPDMA_C12TR3_DAO                          \ destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.DINC=1. Note: A destination address offset must be aligned with the programmed data width of a destination burst (c.f. DAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. Note: When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel x block register 2
\ Address offset: 0x6A8
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C12BR2_BRSAO                        \ Block repeated source address offset For a channel with 2D addressing capability, this field BRSAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (i.e. GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (c.f. BRSAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$ffff0000 constant GPDMA1_GPDMA_C12BR2_BRDAO                        \ Block repeated destination address offset For a channel with 2D addressing capability, this field BRDAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (i.e. GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (c.f. BRDAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x6CC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C12LLR_LA                           \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C12LLR_ULL                          \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$02000000 constant GPDMA1_GPDMA_C12LLR_UB2                          \ Update GPDMA_CxBR2 from memory This bit controls the update of the GPDMA_CxBR2 register from the memory during the link transfer. - 0: no GPDMA_CxBR2 update - 1: GPDMA_CxBR2 update
$04000000 constant GPDMA1_GPDMA_C12LLR_UT3                          \ Update GPDMA_CxTR3 from memory This bit controls the update of the GPDMA_CxTR3 register from the memory during the link transfer. - 0: no GPDMA_CxTR3 update - 1: GPDMA_CxTR3 update
$08000000 constant GPDMA1_GPDMA_C12LLR_UDA                          \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C12LLR_USA                          \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C12LLR_UB1                          \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C12LLR_UT2                          \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C12LLR_UT1                          \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x6D0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C13LBAR_LBA                         \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x6DC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C13FCR_TCF                          \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C13FCR_HTF                          \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C13FCR_DTEF                         \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C13FCR_ULEF                         \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C13FCR_USEF                         \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C13FCR_SUSPF                        \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C13FCR_TOF                          \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x6E0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C13SR_IDLEF                         \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C13SR_TCF                           \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C13SR_HTF                           \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C13SR_DTEF                          \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C13SR_ULEF                          \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C13SR_USEF                          \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C13SR_SUSPF                         \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C13SR_FIFOL                         \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x6E4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C13CR_EN                            \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C13CR_RESET                         \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant GPDMA1_GPDMA_C13CR_SUSP                          \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C13CR_TCIE                          \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C13CR_HTIE                          \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C13CR_DTEIE                         \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C13CR_ULEIE                         \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C13CR_USEIE                         \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C13CR_SUSPIE                        \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C13CR_LSM                           \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C13CR_LAP                           \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C13CR_PRIO                          \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x714
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C13TR2_REQSEL                       \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C13TR2_SWREQ                        \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C13TR2_DREQ                         \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C13TR2_BREQ                         \ BREQ
$0000c000 constant GPDMA1_GPDMA_C13TR2_TRIGM                        \ Trigger mode: enabled. Transferring a next LLIn+1 which updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0] resets the monitoring, trashing the (possible) memorized hit of the formerly defined LLIn trigger. After that a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, this new second trigger hitn+2 is lost and not memorized. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0]=11 and (SWREQ=1 or (SWREQ=0 and DREQ=0)), the shortened burst transfer (by single(s) or/and by burst(s) of lower length) is conditioned once by the trigger. Note: When the programmed destination burst is internally shortened by single(s) or/and by burst(s) of lower length (e.g. vs FIFO size, vs block size, 1kB/4kB boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0]=11 and SWREQ=0 and DREQ=1), this shortened destination burst transfer is conditioned once by the trigger.
$003f0000 constant GPDMA1_GPDMA_C13TR2_TRIGSEL                      \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C13TR2_TRIGPOL                      \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C13TR2_TCEM                         \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x718
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C13BR1_BNDT                         \ block number of data bytes to transfer from the source
$07ff0000 constant GPDMA1_GPDMA_C13BR1_BRC                          \ BRC
$10000000 constant GPDMA1_GPDMA_C13BR1_SDEC                         \ SDEC
$20000000 constant GPDMA1_GPDMA_C13BR1_DDEC                         \ DDEC
$40000000 constant GPDMA1_GPDMA_C13BR1_BRSDEC                       \ BRSDEC
$80000000 constant GPDMA1_GPDMA_C13BR1_BRDDEC                       \ BRDDEC


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x71C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C13SAR_SA                           \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x720
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C13DAR_DA                           \ destination address


\
\ @brief GPDMA channel x transfer register 3
\ Address offset: 0x724
\ Reset value: 0x00000000
\

$00001fff constant GPDMA1_GPDMA_C13TR3_SAO                          \ source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.SINC=1. Note: A source address offset must be aligned with the programmed data width of a source burst (c.f. SAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$1fff0000 constant GPDMA1_GPDMA_C13TR3_DAO                          \ destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.DINC=1. Note: A destination address offset must be aligned with the programmed data width of a destination burst (c.f. DAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. Note: When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel x block register 2
\ Address offset: 0x728
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C13BR2_BRSAO                        \ Block repeated source address offset For a channel with 2D addressing capability, this field BRSAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (i.e. GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (c.f. BRSAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$ffff0000 constant GPDMA1_GPDMA_C13BR2_BRDAO                        \ Block repeated destination address offset For a channel with 2D addressing capability, this field BRDAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (i.e. GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (c.f. BRDAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x74C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C13LLR_LA                           \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C13LLR_ULL                          \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$02000000 constant GPDMA1_GPDMA_C13LLR_UB2                          \ Update GPDMA_CxBR2 from memory This bit controls the update of the GPDMA_CxBR2 register from the memory during the link transfer. - 0: no GPDMA_CxBR2 update - 1: GPDMA_CxBR2 update
$04000000 constant GPDMA1_GPDMA_C13LLR_UT3                          \ Update GPDMA_CxTR3 from memory This bit controls the update of the GPDMA_CxTR3 register from the memory during the link transfer. - 0: no GPDMA_CxTR3 update - 1: GPDMA_CxTR3 update
$08000000 constant GPDMA1_GPDMA_C13LLR_UDA                          \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C13LLR_USA                          \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C13LLR_UB1                          \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C13LLR_UT2                          \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C13LLR_UT1                          \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x750
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C14LBAR_LBA                         \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x75C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C14FCR_TCF                          \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C14FCR_HTF                          \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C14FCR_DTEF                         \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C14FCR_ULEF                         \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C14FCR_USEF                         \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C14FCR_SUSPF                        \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C14FCR_TOF                          \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x760
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C14SR_IDLEF                         \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C14SR_TCF                           \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C14SR_HTF                           \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C14SR_DTEF                          \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C14SR_ULEF                          \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C14SR_USEF                          \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C14SR_SUSPF                         \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C14SR_FIFOL                         \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x764
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C14CR_EN                            \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C14CR_RESET                         \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant GPDMA1_GPDMA_C14CR_SUSP                          \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C14CR_TCIE                          \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C14CR_HTIE                          \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C14CR_DTEIE                         \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C14CR_ULEIE                         \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C14CR_USEIE                         \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C14CR_SUSPIE                        \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C14CR_LSM                           \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C14CR_LAP                           \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C14CR_PRIO                          \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x794
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C14TR2_REQSEL                       \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C14TR2_SWREQ                        \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C14TR2_DREQ                         \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C14TR2_BREQ                         \ BREQ
$0000c000 constant GPDMA1_GPDMA_C14TR2_TRIGM                        \ Trigger mode: enabled. Transferring a next LLIn+1 which updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0] resets the monitoring, trashing the (possible) memorized hit of the formerly defined LLIn trigger. After that a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, this new second trigger hitn+2 is lost and not memorized. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0]=11 and (SWREQ=1 or (SWREQ=0 and DREQ=0)), the shortened burst transfer (by single(s) or/and by burst(s) of lower length) is conditioned once by the trigger. Note: When the programmed destination burst is internally shortened by single(s) or/and by burst(s) of lower length (e.g. vs FIFO size, vs block size, 1kB/4kB boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0]=11 and SWREQ=0 and DREQ=1), this shortened destination burst transfer is conditioned once by the trigger.
$003f0000 constant GPDMA1_GPDMA_C14TR2_TRIGSEL                      \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C14TR2_TRIGPOL                      \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C14TR2_TCEM                         \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x798
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C14BR1_BNDT                         \ block number of data bytes to transfer from the source
$07ff0000 constant GPDMA1_GPDMA_C14BR1_BRC                          \ BRC
$10000000 constant GPDMA1_GPDMA_C14BR1_SDEC                         \ SDEC
$20000000 constant GPDMA1_GPDMA_C14BR1_DDEC                         \ DDEC
$40000000 constant GPDMA1_GPDMA_C14BR1_BRSDEC                       \ BRSDEC
$80000000 constant GPDMA1_GPDMA_C14BR1_BRDDEC                       \ BRDDEC


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x79C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C14SAR_SA                           \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x7A0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C14DAR_DA                           \ destination address


\
\ @brief GPDMA channel x transfer register 3
\ Address offset: 0x7A4
\ Reset value: 0x00000000
\

$00001fff constant GPDMA1_GPDMA_C14TR3_SAO                          \ source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.SINC=1. Note: A source address offset must be aligned with the programmed data width of a source burst (c.f. SAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$1fff0000 constant GPDMA1_GPDMA_C14TR3_DAO                          \ destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.DINC=1. Note: A destination address offset must be aligned with the programmed data width of a destination burst (c.f. DAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. Note: When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel x block register 2
\ Address offset: 0x7A8
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C14BR2_BRSAO                        \ Block repeated source address offset For a channel with 2D addressing capability, this field BRSAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (i.e. GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (c.f. BRSAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$ffff0000 constant GPDMA1_GPDMA_C14BR2_BRDAO                        \ Block repeated destination address offset For a channel with 2D addressing capability, this field BRDAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (i.e. GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (c.f. BRDAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x7CC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C14LLR_LA                           \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C14LLR_ULL                          \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$02000000 constant GPDMA1_GPDMA_C14LLR_UB2                          \ Update GPDMA_CxBR2 from memory This bit controls the update of the GPDMA_CxBR2 register from the memory during the link transfer. - 0: no GPDMA_CxBR2 update - 1: GPDMA_CxBR2 update
$04000000 constant GPDMA1_GPDMA_C14LLR_UT3                          \ Update GPDMA_CxTR3 from memory This bit controls the update of the GPDMA_CxTR3 register from the memory during the link transfer. - 0: no GPDMA_CxTR3 update - 1: GPDMA_CxTR3 update
$08000000 constant GPDMA1_GPDMA_C14LLR_UDA                          \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C14LLR_USA                          \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C14LLR_UB1                          \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C14LLR_UT2                          \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C14LLR_UT1                          \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief channel x linked-list base address register
\ Address offset: 0x7D0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA1_GPDMA_C15LBAR_LBA                         \ linked-list base address of DMA channel x


\
\ @brief GPDMA channel x flag clear register
\ Address offset: 0x7DC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA1_GPDMA_C15FCR_TCF                          \ transfer complete flag clear - 0: no effect - 1: clears the corresponding TCF flag
$00000200 constant GPDMA1_GPDMA_C15FCR_HTF                          \ half transfer flag clear - 0: no effect - 1: clears the corresponding HTF flag
$00000400 constant GPDMA1_GPDMA_C15FCR_DTEF                         \ data transfer error flag clear - 0: no effect - 1: clears the corresponding DTEF flag
$00000800 constant GPDMA1_GPDMA_C15FCR_ULEF                         \ update link transfer error flag clear - 0: no effect - 1: clears the corresponding ULEF flag
$00001000 constant GPDMA1_GPDMA_C15FCR_USEF                         \ user setting error flag clear - 0: no effect - 1: clears the corresponding USEF flag
$00002000 constant GPDMA1_GPDMA_C15FCR_SUSPF                        \ completed suspension flag clear - 0: no effect - 1: clears the corresponding SUSPF flag
$00004000 constant GPDMA1_GPDMA_C15FCR_TOF                          \ trigger overrun flag clear


\
\ @brief channel x status register
\ Address offset: 0x7E0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA1_GPDMA_C15SR_IDLEF                         \ idle flag - 0: the channel is not in idle state - 1: the channel is in idle state This idle flag is de-asserted by hardware when the channel is enabled (i.e. is written 1 into GPDMA_CxCR.EN) with a valid channel configuration (i.e. no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (i.e. in suspended or disabled state).
$00000100 constant GPDMA1_GPDMA_C15SR_TCF                           \ transfer complete flag - 0: no transfer complete event - 1: a transfer complete event occurred A transfer complete event is either a block transfer complete or a 2D/repeated block transfer complete, or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0].
$00000200 constant GPDMA1_GPDMA_C15SR_HTF                           \ half transfer flag - 0: no half transfer event - 1: an half transfer event occurred An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode i.e. GPDMA_CxTR2.TCEM[1:0]. An half block transfer occurs when half of the bytes of the source block size (i.e. rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. Half 2D/repeated block transfer occurs when half of the repeated blocks (i.e. rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2) have been transferred to the destination.
$00000400 constant GPDMA1_GPDMA_C15SR_DTEF                          \ data transfer error flag - 0: no data transfer error event - 1: a master bus error event occurred on a data transfer
$00000800 constant GPDMA1_GPDMA_C15SR_ULEF                          \ update link transfer error flag - 0: no update link transfer error event - 1: a master bus error event occurred while updating a linked-list register from memory
$00001000 constant GPDMA1_GPDMA_C15SR_USEF                          \ user setting error flag - 0: no user setting error event - 1: a user setting error event occurred
$00002000 constant GPDMA1_GPDMA_C15SR_SUSPF                         \ completed suspension flag - 0: no completed suspension event - 1: a completed suspension event occurred
$00ff0000 constant GPDMA1_GPDMA_C15SR_FIFOL                         \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (c.f. GPDMA_CxTR1.DDW_LOG2[1:0], i.e. in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0] in order to know exactly how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be indeed suspended i.e. GPDMA_CxSR.SUSPF=1.


\
\ @brief channel x control register
\ Address offset: 0x7E4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA1_GPDMA_C15CR_EN                            \ enable - 0: write: ignored, read: channel disabled - 1: write: enable channel, read: channel enabled Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: * this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). * Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant GPDMA1_GPDMA_C15CR_RESET                         \ reset - 0: no channel reset - 1: channel reset This bit is write only. Writing 0 has no impact. Writing 1 implies/will imply the reset of the FIFO, the reset of the channel internal state, and the reset of the SUSP and EN bits, whatever is written in respectively bit 2 and bit 0. The reset is/will be effective when the channel is in state i.e. either i) the active channel is in suspended state (i.e. GPDMA_CxSR.SUSPF=1 and GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=1) or ii) the channel is in disabled state (i.e. GPDMA_CxSR.IDLEF=1 and GPDMA_CxCR.EN=0). After writing a RESET, if the user wants to continue using this channel, the user should explicitly reconfigure the channel including the hardware-modified configuration registers GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR, before enabling again the channel. Following the programming sequence in Figure 4: DMA channel abort and restart sequence.
$00000004 constant GPDMA1_GPDMA_C15CR_SUSP                          \ suspend - 0: write: resume channel, read: channel not suspended - 1: write: suspend channel, read: channel suspended Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. Software must write 0 in order to resume a suspended channel, following the programming sequence in Figure 3: DMA channel suspend and resume sequence.
$00000100 constant GPDMA1_GPDMA_C15CR_TCIE                          \ transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000200 constant GPDMA1_GPDMA_C15CR_HTIE                          \ half transfer complete interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000400 constant GPDMA1_GPDMA_C15CR_DTEIE                         \ data transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00000800 constant GPDMA1_GPDMA_C15CR_ULEIE                         \ update link transfer error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00001000 constant GPDMA1_GPDMA_C15CR_USEIE                         \ user setting error interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00002000 constant GPDMA1_GPDMA_C15CR_SUSPIE                        \ completed suspension interrupt enable - 0: interrupt disabled - 1: interrupt enabled
$00010000 constant GPDMA1_GPDMA_C15CR_LSM                           \ Link Step mode:- 0: channel is executed for the full linked-list, and completed at the end (if any) of the last LLI i.e. when GPDMA_CxLLR=0: the 16 low significant bits of the link address are null (LA[15:0]=0) and all the update bits are null i.e. UT1=UB1=UT2=USA=UDA=UB2 =UT3=ULL=0. Then GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0.- 1: channel is executed once for the current LLI:* First the (possibly 2D/repeated) block transfer is executed as defined by the current internal register file until that (GPDMA_CxBR1.BRC[10:0]=0 and GPDMA_CxBR1.BNDT[15:0]=0).* Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR register. Then channel execution is completed.Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant GPDMA1_GPDMA_C15CR_LAP                           \ linked-list allocated portAllocate the master port for the update of the DMA linked-list registers from the memory.- 0: port 0 (AHB) is allocated for the update of the DMA linked-list channel x registers- 1: port 1 (AHB) is allocated for the update of the DMA linked-list channel x registersNote: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant GPDMA1_GPDMA_C15CR_PRIO                          \ priority level of the DMA transfer of the channel x vs others- 00: low priority, low weight- 01: low priority, mid weight- 10: low priority, high weight- 11: high priorityNote: This bit must be written when EN=0. This bit is read-only when EN=1.


\
\ @brief GPDMA channel x transfer register 2
\ Address offset: 0x814
\ Reset value: 0x00000000
\

$0000007f constant GPDMA1_GPDMA_C15TR2_REQSEL                       \ DMA hardware request selection If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else, the selected hardware request as per Table 12 is internally taken into account. Note: The user must not assign a same input hardware request (i.e. a same REQSEL[6:0] value) to different active DMA channels (i.e. if GPDMA_CxCR.EN=1 and GPDMA_CxTR2.SWREQ=0 for the related x channels). In other words, DMA is not intended to hardware support the case of simultaneous enabled channels having been -incorrectly- configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant GPDMA1_GPDMA_C15TR2_SWREQ                        \ Software request When GPDMA_CxCR.EN is asserted, this field is internally taken into account: - 0: no software request. The selected hardware request REQSEL[6:0] is taken into account. - 1: software request (for a memory-to-memory transfer). And the default selected hardware request as per REQSEL[6:0] is ignored.
$00000400 constant GPDMA1_GPDMA_C15TR2_DREQ                         \ Destination hardware request If the channel x is activated (i.e. GPDMA_CxCR.EN is asserted) with SWREQ=1 (i.e. software request for a memory-to-memory transfer), this bit is ignored. Else: - 0: the selected hardware request is driven by a source peripheral (i.e. this request signal is taken into account by the DMA transfer scheduler over the source/read port) - 1: the selected hardware request is driven by a destination peripheral (.e. this request signal is taken into account by the DMA transfer scheduler over the destination/write port)
$00000800 constant GPDMA1_GPDMA_C15TR2_BREQ                         \ BREQ
$0000c000 constant GPDMA1_GPDMA_C15TR2_TRIGM                        \ Trigger mode: enabled. Transferring a next LLIn+1 which updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0] resets the monitoring, trashing the (possible) memorized hit of the formerly defined LLIn trigger. After that a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, this new second trigger hitn+2 is lost and not memorized. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0]=11 and (SWREQ=1 or (SWREQ=0 and DREQ=0)), the shortened burst transfer (by single(s) or/and by burst(s) of lower length) is conditioned once by the trigger. Note: When the programmed destination burst is internally shortened by single(s) or/and by burst(s) of lower length (e.g. vs FIFO size, vs block size, 1kB/4kB boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0]=11 and SWREQ=0 and DREQ=1), this shortened destination burst transfer is conditioned once by the trigger.
$003f0000 constant GPDMA1_GPDMA_C15TR2_TRIGSEL                      \ Trigger event input selection Note: Selects the trigger event input as per Table 13 of the DMA transfer, with an active trigger event if TRIGPOL[1:0] !=00.
$03000000 constant GPDMA1_GPDMA_C15TR2_TRIGPOL                      \ Trigger event polarity Defines the polarity of the selected trigger event input defined by TRIGSEL[5:0]. - 00: no trigger. Masked trigger event. - 01: trigger on the rising edge - 10: trigger on the falling edge - 11: same as 00
$c0000000 constant GPDMA1_GPDMA_C15TR2_TCEM                         \ Transfer complete event mode Defines the transfer granularity for the transfer complete (and half transfer complete) event generation. - 00: at block level (i.e. when GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the (respectively half of the) end of a block. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 01: channel x=0 to 11: same as 00 ;channel x=12 to 15: at 2D/repeated block level (i.e. when GPDMA_CxBR1.BRC[10:0]= 0 and GPDMA_CxBR1.BNDT[15:0]= 0): the complete (and the half) transfer event is generated at the end (respectively half of the end) of the 2D/repeated block Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then neither the complete transfer event nor the half transfer event is generated. - 10: at LLI level: the complete transfer event is generated at the end of the LLI transfer, including the update of the LLI if any. The half transfer event is generated at the half of the LLI data transfer (the LLI data transfer being a block or a 2D/repeated block transfer), if any data transfer. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0]=0), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1. - 11: at channel level: the complete transfer event is generated at the end of the last LLI transfer. The half transfer event is generated at the half of the data transfer of the last LLI. The last LLI is the one that updates the link address GPDMA_CxLLR.LA[15:2] to zero and that clears all the update bits - UT1, UT2, UB1, USA, UDA, if present UT3, UB2 and ULL - of the GPDMA_CxLLR register. If the channel transfer is continuous/infinite, no event is generated.


\
\ @brief GPDMA channel x block register 1
\ Address offset: 0x818
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C15BR1_BNDT                         \ block number of data bytes to transfer from the source
$07ff0000 constant GPDMA1_GPDMA_C15BR1_BRC                          \ BRC
$10000000 constant GPDMA1_GPDMA_C15BR1_SDEC                         \ SDEC
$20000000 constant GPDMA1_GPDMA_C15BR1_DDEC                         \ DDEC
$40000000 constant GPDMA1_GPDMA_C15BR1_BRSDEC                       \ BRSDEC
$80000000 constant GPDMA1_GPDMA_C15BR1_BRDDEC                       \ BRDDEC


\
\ @brief GPDMA channel x source address register
\ Address offset: 0x81C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C15SAR_SA                           \ source address


\
\ @brief GPDMA channel x destination address register
\ Address offset: 0x820
\ Reset value: 0x00000000
\

$00000000 constant GPDMA1_GPDMA_C15DAR_DA                           \ destination address


\
\ @brief GPDMA channel x transfer register 3
\ Address offset: 0x824
\ Reset value: 0x00000000
\

$00001fff constant GPDMA1_GPDMA_C15TR3_SAO                          \ source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.SINC=1. Note: A source address offset must be aligned with the programmed data width of a source burst (c.f. SAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$1fff0000 constant GPDMA1_GPDMA_C15TR3_DAO                          \ destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode i.e. if GPDMA_CxTR1.DINC=1. Note: A destination address offset must be aligned with the programmed data width of a destination burst (c.f. DAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. Note: When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel x block register 2
\ Address offset: 0x828
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA1_GPDMA_C15BR2_BRSAO                        \ Block repeated source address offset For a channel with 2D addressing capability, this field BRSAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (i.e. GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (c.f. BRSAO[2:0] vs GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
$ffff0000 constant GPDMA1_GPDMA_C15BR2_BRDAO                        \ Block repeated destination address offset For a channel with 2D addressing capability, this field BRDAO[15:0] is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (i.e. GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (c.f. BRDAO[2:0] vs GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.


\
\ @brief GPDMA channel x linked-list address register
\ Address offset: 0x84C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA1_GPDMA_C15LLR_LA                           \ pointer (16-bit low significant address) to the next linked-list data structure If UT1=UT2=UB1=USA=UDA=ULL=0 and if LA[15:2]=0: the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure will be automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file i.e. possibly GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR. Note: The user should program the pointer to be 32-bit aligned. The two low significant bits are write ignored.
$00010000 constant GPDMA1_GPDMA_C15LLR_ULL                          \ Update GPDMA_CxLLR from memory This bit controls the update of the GPDMA_CxLLR register from the memory during the link transfer. - 0: no GPDMA_CxLLR update - 1: GPDMA_CxLLR update
$02000000 constant GPDMA1_GPDMA_C15LLR_UB2                          \ Update GPDMA_CxBR2 from memory This bit controls the update of the GPDMA_CxBR2 register from the memory during the link transfer. - 0: no GPDMA_CxBR2 update - 1: GPDMA_CxBR2 update
$04000000 constant GPDMA1_GPDMA_C15LLR_UT3                          \ Update GPDMA_CxTR3 from memory This bit controls the update of the GPDMA_CxTR3 register from the memory during the link transfer. - 0: no GPDMA_CxTR3 update - 1: GPDMA_CxTR3 update
$08000000 constant GPDMA1_GPDMA_C15LLR_UDA                          \ Update GPDMA_CxDAR from memory This bit controls the update of the GPDMA_CxDAR register from the memory during the link transfer. - 0: no GPDMA_CxDAR update - 1: GPDMA_CxDAR update
$10000000 constant GPDMA1_GPDMA_C15LLR_USA                          \ Update GPDMA_CxSAR from memory This bit controls the update of the GPDMA_CxSAR register from the memory during the link transfer. - 0: no GPDMA_CxSAR update - 1: GPDMA_CxSAR update
$20000000 constant GPDMA1_GPDMA_C15LLR_UB1                          \ Update GPDMA_CxBR1 from memory This bit controls the update of the GPDMA_CxBR1 register from the memory during the link transfer. If UB1=0 and if GPDMA_CxLLR != 0, the linked-list is not completed. Then GPDMA_CxBR1.BNDT[15:0] is restored to the programmed value after data transfer is completed and before the link transfer. - 0: no GPDMA_CxBR1 update (GPDMA_CxBR1.BNDT[15:0] is restored, if any link transfer) - 1: GPDMA_CxBR1 update
$40000000 constant GPDMA1_GPDMA_C15LLR_UT2                          \ Update GPDMA_CxTR2 from memory This bit controls the update of the GPDMA_CxTR2 register from the memory during the link transfer. - 0: no GPDMA_CxTR2 update - 1: GPDMA_CxTR2 update
$80000000 constant GPDMA1_GPDMA_C15LLR_UT1                          \ Update GPDMA_CxTR1 from memory This bit controls the update of the GPDMA_CxTR1 register from the memory during the link transfer. - 0: no GPDMA_CxTR1 update - 1: GPDMA_CxTR1 update


\
\ @brief GPDMA1
\
$40020000 constant GPDMA1_GPDMA_SECCFGR  \ offset: 0x00 : GPDMA secure configuration register
$40020004 constant GPDMA1_GPDMA_PRIVCFGR  \ offset: 0x04 : GPDMA privileged configuration register
$4002000c constant GPDMA1_MISR    \ offset: 0x0C : non-secure masked interrupt status register
$40020010 constant GPDMA1_SMISR   \ offset: 0x10 : secure masked interrupt status register
$40020050 constant GPDMA1_GPDMA_C0LBAR  \ offset: 0x50 : channel x linked-list base address register
$4002005c constant GPDMA1_GPDMA_C0FCR  \ offset: 0x5C : GPDMA channel x flag clear register
$40020060 constant GPDMA1_GPDMA_C0SR  \ offset: 0x60 : channel x status register
$40020064 constant GPDMA1_GPDMA_C0CR  \ offset: 0x64 : channel x control register
$40020090 constant GPDMA1_GPDMA_C0TR1  \ offset: 0x90 : GPDMA channel x transfer register 1
$40020094 constant GPDMA1_GPDMA_C0TR2  \ offset: 0x94 : GPDMA channel x transfer register 2
$40020098 constant GPDMA1_GPDMA_C0BR1  \ offset: 0x98 : GPDMA channel x block register 1
$4002009c constant GPDMA1_GPDMA_C0SAR  \ offset: 0x9C : GPDMA channel x source address register
$400200a0 constant GPDMA1_GPDMA_C0DAR  \ offset: 0xA0 : GPDMA channel x destination address register
$400200cc constant GPDMA1_GPDMA_C0LLR  \ offset: 0xCC : GPDMA channel x linked-list address register
$400200d0 constant GPDMA1_GPDMA_C1LBAR  \ offset: 0xD0 : channel x linked-list base address register
$400200dc constant GPDMA1_GPDMA_C1FCR  \ offset: 0xDC : GPDMA channel x flag clear register
$400200e0 constant GPDMA1_GPDMA_C1SR  \ offset: 0xE0 : channel x status register
$400200e4 constant GPDMA1_GPDMA_C1CR  \ offset: 0xE4 : channel x control register
$40020110 constant GPDMA1_GPDMA_C1TR1  \ offset: 0x110 : GPDMA channel x transfer register 1
$40020114 constant GPDMA1_GPDMA_C1TR2  \ offset: 0x114 : GPDMA channel x transfer register 2
$40020118 constant GPDMA1_GPDMA_C1BR1  \ offset: 0x118 : GPDMA channel x block register 1
$4002011c constant GPDMA1_GPDMA_C1SAR  \ offset: 0x11C : GPDMA channel x source address register
$40020120 constant GPDMA1_GPDMA_C1DAR  \ offset: 0x120 : GPDMA channel x destination address register
$4002014c constant GPDMA1_GPDMA_C1LLR  \ offset: 0x14C : GPDMA channel x linked-list address register
$40020150 constant GPDMA1_GPDMA_C2LBAR  \ offset: 0x150 : channel x linked-list base address register
$4002015c constant GPDMA1_GPDMA_C2FCR  \ offset: 0x15C : GPDMA channel x flag clear register
$40020160 constant GPDMA1_GPDMA_C2SR  \ offset: 0x160 : channel x status register
$40020164 constant GPDMA1_GPDMA_C2CR  \ offset: 0x164 : channel x control register
$40020190 constant GPDMA1_GPDMA_C2TR1  \ offset: 0x190 : GPDMA channel x transfer register 1
$40020194 constant GPDMA1_GPDMA_C2TR2  \ offset: 0x194 : GPDMA channel x transfer register 2
$40020198 constant GPDMA1_GPDMA_C2BR1  \ offset: 0x198 : GPDMA channel x block register 1
$4002019c constant GPDMA1_GPDMA_C2SAR  \ offset: 0x19C : GPDMA channel x source address register
$400201a0 constant GPDMA1_GPDMA_C2DAR  \ offset: 0x1A0 : GPDMA channel x destination address register
$400201cc constant GPDMA1_GPDMA_C2LLR  \ offset: 0x1CC : GPDMA channel x linked-list address register
$400201d0 constant GPDMA1_GPDMA_C3LBAR  \ offset: 0x1D0 : channel x linked-list base address register
$400201dc constant GPDMA1_GPDMA_C3FCR  \ offset: 0x1DC : GPDMA channel x flag clear register
$400201e0 constant GPDMA1_GPDMA_C3SR  \ offset: 0x1E0 : channel x status register
$400201e4 constant GPDMA1_GPDMA_C3CR  \ offset: 0x1E4 : channel x control register
$40020210 constant GPDMA1_GPDMA_C3TR1  \ offset: 0x210 : GPDMA channel x transfer register 1
$40020214 constant GPDMA1_GPDMA_C3TR2  \ offset: 0x214 : GPDMA channel x transfer register 2
$40020218 constant GPDMA1_GPDMA_C3BR1  \ offset: 0x218 : GPDMA channel x block register 1
$4002021c constant GPDMA1_GPDMA_C3SAR  \ offset: 0x21C : GPDMA channel x source address register
$40020220 constant GPDMA1_GPDMA_C3DAR  \ offset: 0x220 : GPDMA channel x destination address register
$4002024c constant GPDMA1_GPDMA_C3LLR  \ offset: 0x24C : GPDMA channel x linked-list address register
$40020250 constant GPDMA1_GPDMA_C4LBAR  \ offset: 0x250 : channel x linked-list base address register
$4002025c constant GPDMA1_GPDMA_C4FCR  \ offset: 0x25C : GPDMA channel x flag clear register
$40020260 constant GPDMA1_GPDMA_C4SR  \ offset: 0x260 : channel x status register
$40020264 constant GPDMA1_GPDMA_C4CR  \ offset: 0x264 : channel x control register
$40020294 constant GPDMA1_GPDMA_C4TR2  \ offset: 0x294 : GPDMA channel x transfer register 2
$40020298 constant GPDMA1_GPDMA_C4BR1  \ offset: 0x298 : GPDMA channel x block register 1
$4002029c constant GPDMA1_GPDMA_C4SAR  \ offset: 0x29C : GPDMA channel x source address register
$400202a0 constant GPDMA1_GPDMA_C4DAR  \ offset: 0x2A0 : GPDMA channel x destination address register
$400202cc constant GPDMA1_GPDMA_C4LLR  \ offset: 0x2CC : GPDMA channel x linked-list address register
$400202d0 constant GPDMA1_GPDMA_C5LBAR  \ offset: 0x2D0 : channel x linked-list base address register
$400202dc constant GPDMA1_GPDMA_C5FCR  \ offset: 0x2DC : GPDMA channel x flag clear register
$400202e0 constant GPDMA1_GPDMA_C5SR  \ offset: 0x2E0 : channel x status register
$400202e4 constant GPDMA1_GPDMA_C5CR  \ offset: 0x2E4 : channel x control register
$40020314 constant GPDMA1_GPDMA_C5TR2  \ offset: 0x314 : GPDMA channel x transfer register 2
$40020318 constant GPDMA1_GPDMA_C5BR1  \ offset: 0x318 : GPDMA channel x block register 1
$4002031c constant GPDMA1_GPDMA_C5SAR  \ offset: 0x31C : GPDMA channel x source address register
$40020320 constant GPDMA1_GPDMA_C5DAR  \ offset: 0x320 : GPDMA channel x destination address register
$4002034c constant GPDMA1_GPDMA_C5LLR  \ offset: 0x34C : GPDMA channel x linked-list address register
$40020350 constant GPDMA1_GPDMA_C6LBAR  \ offset: 0x350 : channel x linked-list base address register
$4002035c constant GPDMA1_GPDMA_C6FCR  \ offset: 0x35C : GPDMA channel x flag clear register
$40020360 constant GPDMA1_GPDMA_C6SR  \ offset: 0x360 : channel x status register
$40020364 constant GPDMA1_GPDMA_C6CR  \ offset: 0x364 : channel x control register
$40020394 constant GPDMA1_GPDMA_C6TR2  \ offset: 0x394 : GPDMA channel x transfer register 2
$40020398 constant GPDMA1_GPDMA_C6BR1  \ offset: 0x398 : GPDMA channel x block register 1
$4002039c constant GPDMA1_GPDMA_C6SAR  \ offset: 0x39C : GPDMA channel x source address register
$400203a0 constant GPDMA1_GPDMA_C6DAR  \ offset: 0x3A0 : GPDMA channel x destination address register
$400203cc constant GPDMA1_GPDMA_C6LLR  \ offset: 0x3CC : GPDMA channel x linked-list address register
$400203d0 constant GPDMA1_GPDMA_C7LBAR  \ offset: 0x3D0 : channel x linked-list base address register
$400203dc constant GPDMA1_GPDMA_C7FCR  \ offset: 0x3DC : GPDMA channel x flag clear register
$400203e0 constant GPDMA1_GPDMA_C7SR  \ offset: 0x3E0 : channel x status register
$400203e4 constant GPDMA1_GPDMA_C7CR  \ offset: 0x3E4 : channel x control register
$40020414 constant GPDMA1_GPDMA_C7TR2  \ offset: 0x414 : GPDMA channel x transfer register 2
$40020418 constant GPDMA1_GPDMA_C7BR1  \ offset: 0x418 : GPDMA channel x block register 1
$4002041c constant GPDMA1_GPDMA_C7SAR  \ offset: 0x41C : GPDMA channel x source address register
$40020420 constant GPDMA1_GPDMA_C7DAR  \ offset: 0x420 : GPDMA channel x destination address register
$4002044c constant GPDMA1_GPDMA_C7LLR  \ offset: 0x44C : GPDMA channel x linked-list address register
$40020450 constant GPDMA1_GPDMA_C8LBAR  \ offset: 0x450 : channel x linked-list base address register
$4002045c constant GPDMA1_GPDMA_C8FCR  \ offset: 0x45C : GPDMA channel x flag clear register
$40020460 constant GPDMA1_GPDMA_C8SR  \ offset: 0x460 : channel x status register
$40020464 constant GPDMA1_GPDMA_C8CR  \ offset: 0x464 : channel x control register
$40020494 constant GPDMA1_GPDMA_C8TR2  \ offset: 0x494 : GPDMA channel x transfer register 2
$40020498 constant GPDMA1_GPDMA_C8BR1  \ offset: 0x498 : GPDMA channel x block register 1
$4002049c constant GPDMA1_GPDMA_C8SAR  \ offset: 0x49C : GPDMA channel x source address register
$400204a0 constant GPDMA1_GPDMA_C8DAR  \ offset: 0x4A0 : GPDMA channel x destination address register
$400204cc constant GPDMA1_GPDMA_C8LLR  \ offset: 0x4CC : GPDMA channel x linked-list address register
$400204d0 constant GPDMA1_GPDMA_C9LBAR  \ offset: 0x4D0 : channel x linked-list base address register
$400204dc constant GPDMA1_GPDMA_C9FCR  \ offset: 0x4DC : GPDMA channel x flag clear register
$400204e0 constant GPDMA1_GPDMA_C9SR  \ offset: 0x4E0 : channel x status register
$400204e4 constant GPDMA1_GPDMA_C9CR  \ offset: 0x4E4 : channel x control register
$40020514 constant GPDMA1_GPDMA_C9TR2  \ offset: 0x514 : GPDMA channel x transfer register 2
$40020518 constant GPDMA1_GPDMA_C9BR1  \ offset: 0x518 : GPDMA channel x block register 1
$4002051c constant GPDMA1_GPDMA_C9SAR  \ offset: 0x51C : GPDMA channel x source address register
$40020520 constant GPDMA1_GPDMA_C9DAR  \ offset: 0x520 : GPDMA channel x destination address register
$4002054c constant GPDMA1_GPDMA_C9LLR  \ offset: 0x54C : GPDMA channel x linked-list address register
$40020550 constant GPDMA1_GPDMA_C10LBAR  \ offset: 0x550 : channel x linked-list base address register
$4002055c constant GPDMA1_GPDMA_C10FCR  \ offset: 0x55C : GPDMA channel x flag clear register
$40020560 constant GPDMA1_GPDMA_C10SR  \ offset: 0x560 : channel x status register
$40020564 constant GPDMA1_GPDMA_C10CR  \ offset: 0x564 : channel x control register
$40020594 constant GPDMA1_GPDMA_C10TR2  \ offset: 0x594 : GPDMA channel x transfer register 2
$40020598 constant GPDMA1_GPDMA_C10BR1  \ offset: 0x598 : GPDMA channel x block register 1
$4002059c constant GPDMA1_GPDMA_C10SAR  \ offset: 0x59C : GPDMA channel x source address register
$400205a0 constant GPDMA1_GPDMA_C10DAR  \ offset: 0x5A0 : GPDMA channel x destination address register
$400205cc constant GPDMA1_GPDMA_C10LLR  \ offset: 0x5CC : GPDMA channel x linked-list address register
$400205d0 constant GPDMA1_GPDMA_C11LBAR  \ offset: 0x5D0 : channel x linked-list base address register
$400205dc constant GPDMA1_GPDMA_C11FCR  \ offset: 0x5DC : GPDMA channel x flag clear register
$400205e0 constant GPDMA1_GPDMA_C11SR  \ offset: 0x5E0 : channel x status register
$400205e4 constant GPDMA1_GPDMA_C11CR  \ offset: 0x5E4 : channel x control register
$40020614 constant GPDMA1_GPDMA_C11TR2  \ offset: 0x614 : GPDMA channel x transfer register 2
$40020618 constant GPDMA1_GPDMA_C11BR1  \ offset: 0x618 : GPDMA channel x block register 1
$4002061c constant GPDMA1_GPDMA_C11SAR  \ offset: 0x61C : GPDMA channel x source address register
$40020620 constant GPDMA1_GPDMA_C11DAR  \ offset: 0x620 : GPDMA channel x destination address register
$4002064c constant GPDMA1_GPDMA_C11LLR  \ offset: 0x64C : GPDMA channel x linked-list address register
$40020650 constant GPDMA1_GPDMA_C12LBAR  \ offset: 0x650 : channel x linked-list base address register
$4002065c constant GPDMA1_GPDMA_C12FCR  \ offset: 0x65C : GPDMA channel x flag clear register
$40020660 constant GPDMA1_GPDMA_C12SR  \ offset: 0x660 : channel x status register
$40020664 constant GPDMA1_GPDMA_C12CR  \ offset: 0x664 : channel x control register
$40020694 constant GPDMA1_GPDMA_C12TR2  \ offset: 0x694 : GPDMA channel x transfer register 2
$40020698 constant GPDMA1_GPDMA_C12BR1  \ offset: 0x698 : GPDMA channel x block register 1
$4002069c constant GPDMA1_GPDMA_C12SAR  \ offset: 0x69C : GPDMA channel x source address register
$400206a0 constant GPDMA1_GPDMA_C12DAR  \ offset: 0x6A0 : GPDMA channel x destination address register
$400206a4 constant GPDMA1_GPDMA_C12TR3  \ offset: 0x6A4 : GPDMA channel x transfer register 3
$400206a8 constant GPDMA1_GPDMA_C12BR2  \ offset: 0x6A8 : GPDMA channel x block register 2
$400206cc constant GPDMA1_GPDMA_C12LLR  \ offset: 0x6CC : GPDMA channel x linked-list address register
$400206d0 constant GPDMA1_GPDMA_C13LBAR  \ offset: 0x6D0 : channel x linked-list base address register
$400206dc constant GPDMA1_GPDMA_C13FCR  \ offset: 0x6DC : GPDMA channel x flag clear register
$400206e0 constant GPDMA1_GPDMA_C13SR  \ offset: 0x6E0 : channel x status register
$400206e4 constant GPDMA1_GPDMA_C13CR  \ offset: 0x6E4 : channel x control register
$40020714 constant GPDMA1_GPDMA_C13TR2  \ offset: 0x714 : GPDMA channel x transfer register 2
$40020718 constant GPDMA1_GPDMA_C13BR1  \ offset: 0x718 : GPDMA channel x block register 1
$4002071c constant GPDMA1_GPDMA_C13SAR  \ offset: 0x71C : GPDMA channel x source address register
$40020720 constant GPDMA1_GPDMA_C13DAR  \ offset: 0x720 : GPDMA channel x destination address register
$40020724 constant GPDMA1_GPDMA_C13TR3  \ offset: 0x724 : GPDMA channel x transfer register 3
$40020728 constant GPDMA1_GPDMA_C13BR2  \ offset: 0x728 : GPDMA channel x block register 2
$4002074c constant GPDMA1_GPDMA_C13LLR  \ offset: 0x74C : GPDMA channel x linked-list address register
$40020750 constant GPDMA1_GPDMA_C14LBAR  \ offset: 0x750 : channel x linked-list base address register
$4002075c constant GPDMA1_GPDMA_C14FCR  \ offset: 0x75C : GPDMA channel x flag clear register
$40020760 constant GPDMA1_GPDMA_C14SR  \ offset: 0x760 : channel x status register
$40020764 constant GPDMA1_GPDMA_C14CR  \ offset: 0x764 : channel x control register
$40020794 constant GPDMA1_GPDMA_C14TR2  \ offset: 0x794 : GPDMA channel x transfer register 2
$40020798 constant GPDMA1_GPDMA_C14BR1  \ offset: 0x798 : GPDMA channel x block register 1
$4002079c constant GPDMA1_GPDMA_C14SAR  \ offset: 0x79C : GPDMA channel x source address register
$400207a0 constant GPDMA1_GPDMA_C14DAR  \ offset: 0x7A0 : GPDMA channel x destination address register
$400207a4 constant GPDMA1_GPDMA_C14TR3  \ offset: 0x7A4 : GPDMA channel x transfer register 3
$400207a8 constant GPDMA1_GPDMA_C14BR2  \ offset: 0x7A8 : GPDMA channel x block register 2
$400207cc constant GPDMA1_GPDMA_C14LLR  \ offset: 0x7CC : GPDMA channel x linked-list address register
$400207d0 constant GPDMA1_GPDMA_C15LBAR  \ offset: 0x7D0 : channel x linked-list base address register
$400207dc constant GPDMA1_GPDMA_C15FCR  \ offset: 0x7DC : GPDMA channel x flag clear register
$400207e0 constant GPDMA1_GPDMA_C15SR  \ offset: 0x7E0 : channel x status register
$400207e4 constant GPDMA1_GPDMA_C15CR  \ offset: 0x7E4 : channel x control register
$40020814 constant GPDMA1_GPDMA_C15TR2  \ offset: 0x814 : GPDMA channel x transfer register 2
$40020818 constant GPDMA1_GPDMA_C15BR1  \ offset: 0x818 : GPDMA channel x block register 1
$4002081c constant GPDMA1_GPDMA_C15SAR  \ offset: 0x81C : GPDMA channel x source address register
$40020820 constant GPDMA1_GPDMA_C15DAR  \ offset: 0x820 : GPDMA channel x destination address register
$40020824 constant GPDMA1_GPDMA_C15TR3  \ offset: 0x824 : GPDMA channel x transfer register 3
$40020828 constant GPDMA1_GPDMA_C15BR2  \ offset: 0x828 : GPDMA channel x block register 2
$4002084c constant GPDMA1_GPDMA_C15LLR  \ offset: 0x84C : GPDMA channel x linked-list address register

