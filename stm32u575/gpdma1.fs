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


  [ifdef] GPDMA1_GPDMA_RCFGLOCKR_DEF
    \
    \ @brief GPDMA configuration lock register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_LOCK0                   \ [0x00] LOCK0
    $01 constant GPDMA1_LOCK1                   \ [0x01] LOCK1
    $02 constant GPDMA1_LOCK2                   \ [0x02] LOCK2
    $03 constant GPDMA1_LOCK3                   \ [0x03] LOCK3
    $04 constant GPDMA1_LOCK4                   \ [0x04] LOCK4
    $05 constant GPDMA1_LOCK5                   \ [0x05] LOCK5
    $06 constant GPDMA1_LOCK6                   \ [0x06] LOCK6
    $07 constant GPDMA1_LOCK7                   \ [0x07] LOCK7
    $08 constant GPDMA1_LOCK8                   \ [0x08] LOCK8
    $09 constant GPDMA1_LOCK9                   \ [0x09] LOCK9
    $0a constant GPDMA1_LOCK10                  \ [0x0a] LOCK10
    $0b constant GPDMA1_LOCK11                  \ [0x0b] LOCK11
    $0c constant GPDMA1_LOCK12                  \ [0x0c] LOCK12
    $0d constant GPDMA1_LOCK13                  \ [0x0d] LOCK13
    $0e constant GPDMA1_LOCK14                  \ [0x0e] LOCK14
    $0f constant GPDMA1_LOCK15                  \ [0x0f] LOCK15
  [then]


  [ifdef] GPDMA1_GPDMA_MISR_DEF
    \
    \ @brief GPDMA non-secure masked interrupt status register
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


  [ifdef] GPDMA1_GPDMA_SMISR_DEF
    \
    \ @brief GPDMA secure masked interrupt status register
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
    \ @brief GPDMA channel 0 linked-list base address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C0FCR_DEF
    \
    \ @brief GPDMA channel 0 flag clear register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C0SR_DEF
    \
    \ @brief GPDMA channel 0 status register
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C0CR_DEF
    \
    \ @brief GPDMA channel 0 control register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C0TR1_DEF
    \
    \ @brief GPDMA channel 0 transfer register 1
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C0TR2_DEF
    \
    \ @brief GPDMA channel 0 transfer register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C0BR1_DEF
    \
    \ @brief GPDMA channel 0 block register 1
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C0SAR_DEF
    \
    \ @brief GPDMA channel 0 source address register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C0DAR_DEF
    \
    \ @brief GPDMA channel 0 destination address register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C0LLR_DEF
    \
    \ @brief GPDMA channel 0 linked-list address register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C1LBAR_DEF
    \
    \ @brief GPDMA channel 1 linked-list base address register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C1FCR_DEF
    \
    \ @brief GPDMA channel 1 flag clear register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C1SR_DEF
    \
    \ @brief GPDMA channel 1 status register
    \ Address offset: 0xE0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C1CR_DEF
    \
    \ @brief GPDMA channel 1 control register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C1TR1_DEF
    \
    \ @brief GPDMA channel 1 transfer register 1
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C1TR2_DEF
    \
    \ @brief GPDMA channel 1 transfer register 2
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C1BR1_DEF
    \
    \ @brief GPDMA channel 1 block register 1
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C1SAR_DEF
    \
    \ @brief GPDMA channel 1 source address register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C1DAR_DEF
    \
    \ @brief GPDMA channel 1 destination address register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C1LLR_DEF
    \
    \ @brief GPDMA channel 1 linked-list address register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C2LBAR_DEF
    \
    \ @brief GPDMA channel 2 linked-list base address register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C2FCR_DEF
    \
    \ @brief GPDMA channel 2 flag clear register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C2SR_DEF
    \
    \ @brief GPDMA channel 2 status register
    \ Address offset: 0x160
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C2CR_DEF
    \
    \ @brief GPDMA channel 2 control register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C2TR1_DEF
    \
    \ @brief GPDMA channel 2 transfer register 1
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C2TR2_DEF
    \
    \ @brief GPDMA channel 2 transfer register 2
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C2BR1_DEF
    \
    \ @brief GPDMA channel 2 block register 1
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C2SAR_DEF
    \
    \ @brief GPDMA channel 2 source address register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C2DAR_DEF
    \
    \ @brief GPDMA channel 2 destination address register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C2LLR_DEF
    \
    \ @brief GPDMA channel 2 linked-list address register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C3LBAR_DEF
    \
    \ @brief GPDMA channel 3 linked-list base address register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C3FCR_DEF
    \
    \ @brief GPDMA channel 3 flag clear register
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C3SR_DEF
    \
    \ @brief GPDMA channel 3 status register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C3CR_DEF
    \
    \ @brief GPDMA channel 3 control register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C3TR1_DEF
    \
    \ @brief GPDMA channel 3 transfer register 1
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C3TR2_DEF
    \
    \ @brief GPDMA channel 3 transfer register 2
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C3BR1_DEF
    \
    \ @brief GPDMA channel 3 block register 1
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C3SAR_DEF
    \
    \ @brief GPDMA channel 3 source address register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C3DAR_DEF
    \
    \ @brief GPDMA channel 3 destination address register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C3LLR_DEF
    \
    \ @brief GPDMA channel 3 linked-list address register
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C4LBAR_DEF
    \
    \ @brief GPDMA channel 4 linked-list base address register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C4FCR_DEF
    \
    \ @brief GPDMA channel 4 flag clear register
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C4SR_DEF
    \
    \ @brief GPDMA channel 4 status register
    \ Address offset: 0x260
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C4CR_DEF
    \
    \ @brief GPDMA channel 4 control register
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C4TR1_DEF
    \
    \ @brief GPDMA channel 4 transfer register 1
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C4TR2_DEF
    \
    \ @brief GPDMA channel 4 transfer register 2
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C4BR1_DEF
    \
    \ @brief GPDMA channel 4 block register 1
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C4SAR_DEF
    \
    \ @brief GPDMA channel 4 source address register
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C4DAR_DEF
    \
    \ @brief GPDMA channel 4 destination address register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C4LLR_DEF
    \
    \ @brief GPDMA channel 4 linked-list address register
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C5LBAR_DEF
    \
    \ @brief GPDMA channel 5 linked-list base address register
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C5FCR_DEF
    \
    \ @brief GPDMA channel 5 flag clear register
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C5SR_DEF
    \
    \ @brief GPDMA channel 5 status register
    \ Address offset: 0x2E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C5CR_DEF
    \
    \ @brief GPDMA channel 5 control register
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C5TR1_DEF
    \
    \ @brief GPDMA channel 5 transfer register 1
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C5TR2_DEF
    \
    \ @brief GPDMA channel 5 transfer register 2
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C5BR1_DEF
    \
    \ @brief GPDMA channel 5 block register 1
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C5SAR_DEF
    \
    \ @brief GPDMA channel 5 source address register
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C5DAR_DEF
    \
    \ @brief GPDMA channel 5 destination address register
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C5LLR_DEF
    \
    \ @brief GPDMA channel 5 linked-list address register
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C6LBAR_DEF
    \
    \ @brief GPDMA channel 6 linked-list base address register
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C6FCR_DEF
    \
    \ @brief GPDMA channel 6 flag clear register
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C6SR_DEF
    \
    \ @brief GPDMA channel 6 status register
    \ Address offset: 0x360
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C6CR_DEF
    \
    \ @brief GPDMA channel 6 control register
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C6TR1_DEF
    \
    \ @brief GPDMA channel 6 transfer register 1
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C6TR2_DEF
    \
    \ @brief GPDMA channel 6 transfer register 2
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C6BR1_DEF
    \
    \ @brief GPDMA channel 6 block register 1
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C6SAR_DEF
    \
    \ @brief GPDMA channel 6 source address register
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C6DAR_DEF
    \
    \ @brief GPDMA channel 6 destination address register
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C6LLR_DEF
    \
    \ @brief GPDMA channel 6 linked-list address register
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C7LBAR_DEF
    \
    \ @brief GPDMA channel 7 linked-list base address register
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C7FCR_DEF
    \
    \ @brief GPDMA channel 7 flag clear register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C7SR_DEF
    \
    \ @brief GPDMA channel 7 status register
    \ Address offset: 0x3E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C7CR_DEF
    \
    \ @brief GPDMA channel 7 control register
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C7TR1_DEF
    \
    \ @brief GPDMA channel 7 transfer register 1
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C7TR2_DEF
    \
    \ @brief GPDMA channel 7 transfer register 2
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C7BR1_DEF
    \
    \ @brief GPDMA channel 7 block register 1
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C7SAR_DEF
    \
    \ @brief GPDMA channel 7 source address register
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C7DAR_DEF
    \
    \ @brief GPDMA channel 7 destination address register
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C7LLR_DEF
    \
    \ @brief GPDMA channel 7 linked-list address register
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C8LBAR_DEF
    \
    \ @brief GPDMA channel 8 linked-list base address register
    \ Address offset: 0x450
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C8FCR_DEF
    \
    \ @brief GPDMA channel 8 flag clear register
    \ Address offset: 0x45C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C8SR_DEF
    \
    \ @brief GPDMA channel 8 status register
    \ Address offset: 0x460
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C8CR_DEF
    \
    \ @brief GPDMA channel 8 control register
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C8TR1_DEF
    \
    \ @brief GPDMA channel 8 transfer register 1
    \ Address offset: 0x490
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C8TR2_DEF
    \
    \ @brief GPDMA channel 8 transfer register 2
    \ Address offset: 0x494
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C8BR1_DEF
    \
    \ @brief GPDMA channel 8 block register 1
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C8SAR_DEF
    \
    \ @brief GPDMA channel 8 source address register
    \ Address offset: 0x49C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C8DAR_DEF
    \
    \ @brief GPDMA channel 8 destination address register
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C8LLR_DEF
    \
    \ @brief GPDMA channel 8 linked-list address register
    \ Address offset: 0x4CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C9LBAR_DEF
    \
    \ @brief GPDMA channel 9 linked-list base address register
    \ Address offset: 0x4D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C9FCR_DEF
    \
    \ @brief GPDMA channel 9 flag clear register
    \ Address offset: 0x4DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C9SR_DEF
    \
    \ @brief GPDMA channel 9 status register
    \ Address offset: 0x4E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C9CR_DEF
    \
    \ @brief GPDMA channel 9 control register
    \ Address offset: 0x4E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C9TR1_DEF
    \
    \ @brief GPDMA channel 9 transfer register 1
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C9TR2_DEF
    \
    \ @brief GPDMA channel 9 transfer register 2
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C9BR1_DEF
    \
    \ @brief GPDMA channel 9 block register 1
    \ Address offset: 0x518
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C9SAR_DEF
    \
    \ @brief GPDMA channel 9 source address register
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C9DAR_DEF
    \
    \ @brief GPDMA channel 9 destination address register
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C9LLR_DEF
    \
    \ @brief GPDMA channel 9 linked-list address register
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C10LBAR_DEF
    \
    \ @brief GPDMA channel 10 linked-list base address register
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C10FCR_DEF
    \
    \ @brief GPDMA channel 10 flag clear register
    \ Address offset: 0x55C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C10SR_DEF
    \
    \ @brief GPDMA channel 10 status register
    \ Address offset: 0x560
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C10CR_DEF
    \
    \ @brief GPDMA channel 10 control register
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C10TR1_DEF
    \
    \ @brief GPDMA channel 10 transfer register 1
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C10TR2_DEF
    \
    \ @brief GPDMA channel 10 transfer register 2
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C10BR1_DEF
    \
    \ @brief GPDMA channel 10 block register 1
    \ Address offset: 0x598
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C10SAR_DEF
    \
    \ @brief GPDMA channel 10 source address register
    \ Address offset: 0x59C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C10DAR_DEF
    \
    \ @brief GPDMA channel 10 destination address register
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C10LLR_DEF
    \
    \ @brief GPDMA channel 10 linked-list address register
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C11LBAR_DEF
    \
    \ @brief GPDMA channel 11 linked-list base address register
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C11FCR_DEF
    \
    \ @brief GPDMA channel 11 flag clear register
    \ Address offset: 0x5DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C11SR_DEF
    \
    \ @brief GPDMA channel 11 status register
    \ Address offset: 0x5E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C11CR_DEF
    \
    \ @brief GPDMA channel 11 control register
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C11TR1_DEF
    \
    \ @brief GPDMA channel 11 transfer register 1
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C11TR2_DEF
    \
    \ @brief GPDMA channel 11 transfer register 2
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C11BR1_DEF
    \
    \ @brief GPDMA channel 11 block register 1
    \ Address offset: 0x618
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C11SAR_DEF
    \
    \ @brief GPDMA channel 11 source address register
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C11DAR_DEF
    \
    \ @brief GPDMA channel 11 destination address register
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C11LLR_DEF
    \
    \ @brief GPDMA channel 11 linked-list address register
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C12LBAR_DEF
    \
    \ @brief GPDMA channel 12 linked-list base address register
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C12FCR_DEF
    \
    \ @brief GPDMA channel 12 flag clear register
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C12SR_DEF
    \
    \ @brief GPDMA channel 12 status register
    \ Address offset: 0x660
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C12CR_DEF
    \
    \ @brief GPDMA channel 12 control register
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C12TR1_DEF
    \
    \ @brief GPDMA channel 12 transfer register 1
    \ Address offset: 0x690
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C12TR2_DEF
    \
    \ @brief GPDMA channel 12 transfer register 2
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C12BR1_DEF
    \
    \ @brief GPDMA channel 12 alternate block register 1
    \ Address offset: 0x698
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] ≠ 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1]=1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
    $10 constant GPDMA1_BRC                     \ [0x10 : 11] Block repeat counter This field contains the number of repetitions of the current block (0 to 2047). When the channel is enabled, this field becomes read-only. After decrements, this field indicates the remaining number of blocks, excluding the current one. This counter is hardware decremented for each completed block transfer. Once the last block transfer is completed (BRC[10:0] = BNDT[15:0] = 0): If GPDMA_CxLLR.UB1 = 1, all GPDMA_CxBR1 fields are updated by the next LLI in the memory. If GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] ≠ 0, this field is internally restored to the programmed value (infinite/continuous last LLI). if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI and data transfer.
    $1c constant GPDMA1_SDEC                    \ [0x1c] source address decrement
    $1d constant GPDMA1_DDEC                    \ [0x1d] destination address decrement
    $1e constant GPDMA1_BRSDEC                  \ [0x1e] Block repeat source address decrement Note: On top of this increment/decrement (depending on BRSDEC), GPDMA_CxSAR is in the same time also updated by the increment/decrement (depending on SDEC) of the GPDMA_CxTR3.SAO value, as it is done after any programmed burst transfer.
    $1f constant GPDMA1_BRDDEC                  \ [0x1f] Block repeat destination address decrement Note: On top of this increment/decrement (depending on BRDDEC), GPDMA_CxDAR is in the same time also updated by the increment/decrement (depending on DDEC) of the GPDMA_CxTR3.DAO value, as it is usually done at the end of each programmed burst transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C12SAR_DEF
    \
    \ @brief GPDMA channel 12 source address register
    \ Address offset: 0x69C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C12DAR_DEF
    \
    \ @brief GPDMA channel 12 destination address register
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C12TR3_DEF
    \
    \ @brief GPDMA channel 12 transfer register 3
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SAO                     \ [0x00 : 13] source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.SINC = 1). Note: A source address offset must be aligned with the programmed data width of a source burst (SAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
    $10 constant GPDMA1_DAO                     \ [0x10 : 13] destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.DINC = 1). Note: A destination address offset must be aligned with the programmed data width of a destination burst (DAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C12BR2_DEF
    \
    \ @brief GPDMA channel 12 block register 2
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BRSAO                   \ [0x00 : 16] Block repeated source address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (BRSAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
    $10 constant GPDMA1_BRDAO                   \ [0x10 : 16] Block repeated destination address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (BRDAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C12LLR_DEF
    \
    \ @brief GPDMA channel 12 alternate linked-list address register
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $19 constant GPDMA1_UB2                     \ [0x19] Update GPDMA_CxBR2 from memory This bit controls the update of GPDMA_CxBR2 from the memory during the link transfer.
    $1a constant GPDMA1_UT3                     \ [0x1a] Update GPDMA_CxTR3 from memory This bit controls the update of GPDMA_CxTR3 from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C13LBAR_DEF
    \
    \ @brief GPDMA channel 13 linked-list base address register
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C13FCR_DEF
    \
    \ @brief GPDMA channel 13 flag clear register
    \ Address offset: 0x6DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C13SR_DEF
    \
    \ @brief GPDMA channel 13 status register
    \ Address offset: 0x6E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C13CR_DEF
    \
    \ @brief GPDMA channel 13 control register
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C13TR1_DEF
    \
    \ @brief GPDMA channel 13 transfer register 1
    \ Address offset: 0x710
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C13TR2_DEF
    \
    \ @brief GPDMA channel 13 transfer register 2
    \ Address offset: 0x714
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C13BR1_DEF
    \
    \ @brief GPDMA channel 13 alternate block register 1
    \ Address offset: 0x718
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] ≠ 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1]=1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
    $10 constant GPDMA1_BRC                     \ [0x10 : 11] Block repeat counter This field contains the number of repetitions of the current block (0 to 2047). When the channel is enabled, this field becomes read-only. After decrements, this field indicates the remaining number of blocks, excluding the current one. This counter is hardware decremented for each completed block transfer. Once the last block transfer is completed (BRC[10:0] = BNDT[15:0] = 0): If GPDMA_CxLLR.UB1 = 1, all GPDMA_CxBR1 fields are updated by the next LLI in the memory. If GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] ≠ 0, this field is internally restored to the programmed value (infinite/continuous last LLI). if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI and data transfer.
    $1c constant GPDMA1_SDEC                    \ [0x1c] source address decrement
    $1d constant GPDMA1_DDEC                    \ [0x1d] destination address decrement
    $1e constant GPDMA1_BRSDEC                  \ [0x1e] Block repeat source address decrement Note: On top of this increment/decrement (depending on BRSDEC), GPDMA_CxSAR is in the same time also updated by the increment/decrement (depending on SDEC) of the GPDMA_CxTR3.SAO value, as it is done after any programmed burst transfer.
    $1f constant GPDMA1_BRDDEC                  \ [0x1f] Block repeat destination address decrement Note: On top of this increment/decrement (depending on BRDDEC), GPDMA_CxDAR is in the same time also updated by the increment/decrement (depending on DDEC) of the GPDMA_CxTR3.DAO value, as it is usually done at the end of each programmed burst transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C13SAR_DEF
    \
    \ @brief GPDMA channel 13 source address register
    \ Address offset: 0x71C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C13DAR_DEF
    \
    \ @brief GPDMA channel 13 destination address register
    \ Address offset: 0x720
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C13TR3_DEF
    \
    \ @brief GPDMA channel 13 transfer register 3
    \ Address offset: 0x724
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SAO                     \ [0x00 : 13] source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.SINC = 1). Note: A source address offset must be aligned with the programmed data width of a source burst (SAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
    $10 constant GPDMA1_DAO                     \ [0x10 : 13] destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.DINC = 1). Note: A destination address offset must be aligned with the programmed data width of a destination burst (DAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C13BR2_DEF
    \
    \ @brief GPDMA channel 13 block register 2
    \ Address offset: 0x728
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BRSAO                   \ [0x00 : 16] Block repeated source address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (BRSAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
    $10 constant GPDMA1_BRDAO                   \ [0x10 : 16] Block repeated destination address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (BRDAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C13LLR_DEF
    \
    \ @brief GPDMA channel 13 alternate linked-list address register
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $19 constant GPDMA1_UB2                     \ [0x19] Update GPDMA_CxBR2 from memory This bit controls the update of GPDMA_CxBR2 from the memory during the link transfer.
    $1a constant GPDMA1_UT3                     \ [0x1a] Update GPDMA_CxTR3 from memory This bit controls the update of GPDMA_CxTR3 from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C14LBAR_DEF
    \
    \ @brief GPDMA channel 14 linked-list base address register
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C14FCR_DEF
    \
    \ @brief GPDMA channel 14 flag clear register
    \ Address offset: 0x75C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C14SR_DEF
    \
    \ @brief GPDMA channel 14 status register
    \ Address offset: 0x760
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C14CR_DEF
    \
    \ @brief GPDMA channel 14 control register
    \ Address offset: 0x764
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C14TR1_DEF
    \
    \ @brief GPDMA channel 14 transfer register 1
    \ Address offset: 0x790
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C14TR2_DEF
    \
    \ @brief GPDMA channel 14 transfer register 2
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C14BR1_DEF
    \
    \ @brief GPDMA channel 14 alternate block register 1
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] ≠ 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1]=1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
    $10 constant GPDMA1_BRC                     \ [0x10 : 11] Block repeat counter This field contains the number of repetitions of the current block (0 to 2047). When the channel is enabled, this field becomes read-only. After decrements, this field indicates the remaining number of blocks, excluding the current one. This counter is hardware decremented for each completed block transfer. Once the last block transfer is completed (BRC[10:0] = BNDT[15:0] = 0): If GPDMA_CxLLR.UB1 = 1, all GPDMA_CxBR1 fields are updated by the next LLI in the memory. If GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] ≠ 0, this field is internally restored to the programmed value (infinite/continuous last LLI). if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI and data transfer.
    $1c constant GPDMA1_SDEC                    \ [0x1c] source address decrement
    $1d constant GPDMA1_DDEC                    \ [0x1d] destination address decrement
    $1e constant GPDMA1_BRSDEC                  \ [0x1e] Block repeat source address decrement Note: On top of this increment/decrement (depending on BRSDEC), GPDMA_CxSAR is in the same time also updated by the increment/decrement (depending on SDEC) of the GPDMA_CxTR3.SAO value, as it is done after any programmed burst transfer.
    $1f constant GPDMA1_BRDDEC                  \ [0x1f] Block repeat destination address decrement Note: On top of this increment/decrement (depending on BRDDEC), GPDMA_CxDAR is in the same time also updated by the increment/decrement (depending on DDEC) of the GPDMA_CxTR3.DAO value, as it is usually done at the end of each programmed burst transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C14SAR_DEF
    \
    \ @brief GPDMA channel 14 source address register
    \ Address offset: 0x79C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C14DAR_DEF
    \
    \ @brief GPDMA channel 14 destination address register
    \ Address offset: 0x7A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C14TR3_DEF
    \
    \ @brief GPDMA channel 14 transfer register 3
    \ Address offset: 0x7A4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SAO                     \ [0x00 : 13] source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.SINC = 1). Note: A source address offset must be aligned with the programmed data width of a source burst (SAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
    $10 constant GPDMA1_DAO                     \ [0x10 : 13] destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.DINC = 1). Note: A destination address offset must be aligned with the programmed data width of a destination burst (DAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C14BR2_DEF
    \
    \ @brief GPDMA channel 14 block register 2
    \ Address offset: 0x7A8
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BRSAO                   \ [0x00 : 16] Block repeated source address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (BRSAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
    $10 constant GPDMA1_BRDAO                   \ [0x10 : 16] Block repeated destination address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (BRDAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C14LLR_DEF
    \
    \ @brief GPDMA channel 14 alternate linked-list address register
    \ Address offset: 0x7CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $19 constant GPDMA1_UB2                     \ [0x19] Update GPDMA_CxBR2 from memory This bit controls the update of GPDMA_CxBR2 from the memory during the link transfer.
    $1a constant GPDMA1_UT3                     \ [0x1a] Update GPDMA_CxTR3 from memory This bit controls the update of GPDMA_CxTR3 from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C15LBAR_DEF
    \
    \ @brief GPDMA channel 15 linked-list base address register
    \ Address offset: 0x7D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA1_LBA                     \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA1_GPDMA_C15FCR_DEF
    \
    \ @brief GPDMA channel 15 flag clear register
    \ Address offset: 0x7DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA1_GPDMA_C15SR_DEF
    \
    \ @brief GPDMA channel 15 status register
    \ Address offset: 0x7E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant GPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
    $09 constant GPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is either an half block transfer or an half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). An half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. An half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
    $0a constant GPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant GPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant GPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant GPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant GPDMA1_TOF                     \ [0x0e] trigger overrun flag
    $10 constant GPDMA1_FIFOL                   \ [0x10 : 8] monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).
  [then]


  [ifdef] GPDMA1_GPDMA_C15CR_DEF
    \
    \ @brief GPDMA channel 15 control register
    \ Address offset: 0x7E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant GPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant GPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
    $08 constant GPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA1_LSM                     \ [0x10] Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $11 constant GPDMA1_LAP                     \ [0x11] linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant GPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] GPDMA1_GPDMA_C15TR1_DEF
    \
    \ @brief GPDMA channel 15 transfer register 1
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant GPDMA1_SINC                    \ [0x03] source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $04 constant GPDMA1_SBL_1                   \ [0x04 : 6] source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $0b constant GPDMA1_PAM                     \ [0x0b : 2] padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else: - Case 1: If destination data width > source data width 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer - Case 2: If destination data width < source data width 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note:
    $0d constant GPDMA1_SBX                     \ [0x0d] source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
    $0e constant GPDMA1_SAP                     \ [0x0e] source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $0f constant GPDMA1_SSEC                    \ [0x0f] security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
    $10 constant GPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
    $13 constant GPDMA1_DINC                    \ [0x13] destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
    $14 constant GPDMA1_DBL_1                   \ [0x14 : 6] destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower bursts/singles, but the data integrity is guaranteed.
    $1a constant GPDMA1_DBX                     \ [0x1a] destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
    $1b constant GPDMA1_DHX                     \ [0x1b] destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
    $1e constant GPDMA1_DAP                     \ [0x1e] destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
    $1f constant GPDMA1_DSEC                    \ [0x1f] security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] GPDMA1_GPDMA_C15TR2_DEF
    \
    \ @brief GPDMA channel 15 transfer register 2
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_REQSEL                  \ [0x00 : 7] GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[6:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant GPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
    $0a constant GPDMA1_DREQ                    \ [0x0a] destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note:
    $0b constant GPDMA1_BREQ                    \ [0x0b] Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant GPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (GPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 00 or 11, these TRIGM[1:0] bits are ignored. Else, a GPDMA transfer is conditioned by at least one trigger hit: first burst read of a 2D/repeated block transfer is conditioned by one hit trigger. – If the peripheral is programmed as a source (DREQ = 0) of the LLI data transfer, each programmed burst read is conditioned. – If the peripheral is programmed as a destination (DREQ = 1) of the LLI data transfer, each programmed burst write is conditioned. The first memory burst read of a (possibly 2D/repeated) block, also named as the first ready FIFO-based source burst, is gated by the occurrence of both the hardware request and the first trigger hit. The GPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 01 or respectively TRIGPOL[1:0] = 10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[5:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the GPDMA_CxTR2 with a new value for any of TRIGSEL[5:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized.memorized. A trigger overrun flag is reported (GPDMA_CxSR.TOF =1 ), and an interrupt is generated if enabled (GPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun. Note: When the source block size is not a multiple of the source burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, if TRIGM[1:0] = 11 and (SWREQ =1  or (SWREQ = 0 and DREQ =0 )), the shortened burst transfer (by singles or/and by bursts of lower length) is conditioned once by the trigger. When the programmed destination burst is internally shortened by singles or/and by bursts of lower length (versus FIFO size, versus block size, 1-Kbyte boundary address crossing): if the trigger is conditioning the programmed destination burst (if TRIGM[1:0] = 11 and SWREQ = 0 and DREQ = 1), this shortened destination burst transfer is conditioned once by the trigger.
    $10 constant GPDMA1_TRIGSEL                 \ [0x10 : 6] trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] ≠ 00.
    $18 constant GPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
    $1e constant GPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] GPDMA1_GPDMA_C15BR1_DEF
    \
    \ @brief GPDMA channel 15 alternate block register 1
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] ≠ 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1]=1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
    $10 constant GPDMA1_BRC                     \ [0x10 : 11] Block repeat counter This field contains the number of repetitions of the current block (0 to 2047). When the channel is enabled, this field becomes read-only. After decrements, this field indicates the remaining number of blocks, excluding the current one. This counter is hardware decremented for each completed block transfer. Once the last block transfer is completed (BRC[10:0] = BNDT[15:0] = 0): If GPDMA_CxLLR.UB1 = 1, all GPDMA_CxBR1 fields are updated by the next LLI in the memory. If GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] ≠ 0, this field is internally restored to the programmed value (infinite/continuous last LLI). if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI and data transfer.
    $1c constant GPDMA1_SDEC                    \ [0x1c] source address decrement
    $1d constant GPDMA1_DDEC                    \ [0x1d] destination address decrement
    $1e constant GPDMA1_BRSDEC                  \ [0x1e] Block repeat source address decrement Note: On top of this increment/decrement (depending on BRSDEC), GPDMA_CxSAR is in the same time also updated by the increment/decrement (depending on SDEC) of the GPDMA_CxTR3.SAO value, as it is done after any programmed burst transfer.
    $1f constant GPDMA1_BRDDEC                  \ [0x1f] Block repeat destination address decrement Note: On top of this increment/decrement (depending on BRDDEC), GPDMA_CxDAR is in the same time also updated by the increment/decrement (depending on DDEC) of the GPDMA_CxTR3.DAO value, as it is usually done at the end of each programmed burst transfer.
  [then]


  [ifdef] GPDMA1_GPDMA_C15SAR_DEF
    \
    \ @brief GPDMA channel 15 source address register
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
  [then]


  [ifdef] GPDMA1_GPDMA_C15DAR_DEF
    \
    \ @brief GPDMA channel 15 destination address register
    \ Address offset: 0x820
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C15TR3_DEF
    \
    \ @brief GPDMA channel 15 transfer register 3
    \ Address offset: 0x824
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_SAO                     \ [0x00 : 13] source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.SINC = 1). Note: A source address offset must be aligned with the programmed data width of a source burst (SAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
    $10 constant GPDMA1_DAO                     \ [0x10 : 13] destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.DINC = 1). Note: A destination address offset must be aligned with the programmed data width of a destination burst (DAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C15BR2_DEF
    \
    \ @brief GPDMA channel 15 block register 2
    \ Address offset: 0x828
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA1_BRSAO                   \ [0x00 : 16] Block repeated source address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (BRSAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
    $10 constant GPDMA1_BRDAO                   \ [0x10 : 16] Block repeated destination address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (BRDAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] GPDMA1_GPDMA_C15LLR_DEF
    \
    \ @brief GPDMA channel 15 alternate linked-list address register
    \ Address offset: 0x84C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant GPDMA1_ULL                     \ [0x10] Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
    $19 constant GPDMA1_UB2                     \ [0x19] Update GPDMA_CxBR2 from memory This bit controls the update of GPDMA_CxBR2 from the memory during the link transfer.
    $1a constant GPDMA1_UT3                     \ [0x1a] Update GPDMA_CxTR3 from memory This bit controls the update of GPDMA_CxTR3 from the memory during the link transfer.
    $1b constant GPDMA1_UDA                     \ [0x1b] Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
    $1c constant GPDMA1_USA                     \ [0x1c] update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
    $1d constant GPDMA1_UB1                     \ [0x1d] Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR ≠ 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
    $1e constant GPDMA1_UT2                     \ [0x1e] Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
    $1f constant GPDMA1_UT1                     \ [0x1f] Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.
  [then]

  \
  \ @brief GPDMA1
  \
  $00 constant GPDMA1_GPDMA_SECCFGR     \ GPDMA secure configuration register
  $04 constant GPDMA1_GPDMA_PRIVCFGR    \ GPDMA privileged configuration register
  $08 constant GPDMA1_GPDMA_RCFGLOCKR   \ GPDMA configuration lock register
  $0C constant GPDMA1_GPDMA_MISR        \ GPDMA non-secure masked interrupt status register
  $10 constant GPDMA1_GPDMA_SMISR       \ GPDMA secure masked interrupt status register
  $50 constant GPDMA1_GPDMA_C0LBAR      \ GPDMA channel 0 linked-list base address register
  $5C constant GPDMA1_GPDMA_C0FCR       \ GPDMA channel 0 flag clear register
  $60 constant GPDMA1_GPDMA_C0SR        \ GPDMA channel 0 status register
  $64 constant GPDMA1_GPDMA_C0CR        \ GPDMA channel 0 control register
  $90 constant GPDMA1_GPDMA_C0TR1       \ GPDMA channel 0 transfer register 1
  $94 constant GPDMA1_GPDMA_C0TR2       \ GPDMA channel 0 transfer register 2
  $98 constant GPDMA1_GPDMA_C0BR1       \ GPDMA channel 0 block register 1
  $9C constant GPDMA1_GPDMA_C0SAR       \ GPDMA channel 0 source address register
  $A0 constant GPDMA1_GPDMA_C0DAR       \ GPDMA channel 0 destination address register
  $CC constant GPDMA1_GPDMA_C0LLR       \ GPDMA channel 0 linked-list address register
  $D0 constant GPDMA1_GPDMA_C1LBAR      \ GPDMA channel 1 linked-list base address register
  $DC constant GPDMA1_GPDMA_C1FCR       \ GPDMA channel 1 flag clear register
  $E0 constant GPDMA1_GPDMA_C1SR        \ GPDMA channel 1 status register
  $E4 constant GPDMA1_GPDMA_C1CR        \ GPDMA channel 1 control register
  $110 constant GPDMA1_GPDMA_C1TR1      \ GPDMA channel 1 transfer register 1
  $114 constant GPDMA1_GPDMA_C1TR2      \ GPDMA channel 1 transfer register 2
  $118 constant GPDMA1_GPDMA_C1BR1      \ GPDMA channel 1 block register 1
  $11C constant GPDMA1_GPDMA_C1SAR      \ GPDMA channel 1 source address register
  $120 constant GPDMA1_GPDMA_C1DAR      \ GPDMA channel 1 destination address register
  $14C constant GPDMA1_GPDMA_C1LLR      \ GPDMA channel 1 linked-list address register
  $150 constant GPDMA1_GPDMA_C2LBAR     \ GPDMA channel 2 linked-list base address register
  $15C constant GPDMA1_GPDMA_C2FCR      \ GPDMA channel 2 flag clear register
  $160 constant GPDMA1_GPDMA_C2SR       \ GPDMA channel 2 status register
  $164 constant GPDMA1_GPDMA_C2CR       \ GPDMA channel 2 control register
  $190 constant GPDMA1_GPDMA_C2TR1      \ GPDMA channel 2 transfer register 1
  $194 constant GPDMA1_GPDMA_C2TR2      \ GPDMA channel 2 transfer register 2
  $198 constant GPDMA1_GPDMA_C2BR1      \ GPDMA channel 2 block register 1
  $19C constant GPDMA1_GPDMA_C2SAR      \ GPDMA channel 2 source address register
  $1A0 constant GPDMA1_GPDMA_C2DAR      \ GPDMA channel 2 destination address register
  $1CC constant GPDMA1_GPDMA_C2LLR      \ GPDMA channel 2 linked-list address register
  $1D0 constant GPDMA1_GPDMA_C3LBAR     \ GPDMA channel 3 linked-list base address register
  $1DC constant GPDMA1_GPDMA_C3FCR      \ GPDMA channel 3 flag clear register
  $1E0 constant GPDMA1_GPDMA_C3SR       \ GPDMA channel 3 status register
  $1E4 constant GPDMA1_GPDMA_C3CR       \ GPDMA channel 3 control register
  $210 constant GPDMA1_GPDMA_C3TR1      \ GPDMA channel 3 transfer register 1
  $214 constant GPDMA1_GPDMA_C3TR2      \ GPDMA channel 3 transfer register 2
  $218 constant GPDMA1_GPDMA_C3BR1      \ GPDMA channel 3 block register 1
  $21C constant GPDMA1_GPDMA_C3SAR      \ GPDMA channel 3 source address register
  $220 constant GPDMA1_GPDMA_C3DAR      \ GPDMA channel 3 destination address register
  $24C constant GPDMA1_GPDMA_C3LLR      \ GPDMA channel 3 linked-list address register
  $250 constant GPDMA1_GPDMA_C4LBAR     \ GPDMA channel 4 linked-list base address register
  $25C constant GPDMA1_GPDMA_C4FCR      \ GPDMA channel 4 flag clear register
  $260 constant GPDMA1_GPDMA_C4SR       \ GPDMA channel 4 status register
  $264 constant GPDMA1_GPDMA_C4CR       \ GPDMA channel 4 control register
  $290 constant GPDMA1_GPDMA_C4TR1      \ GPDMA channel 4 transfer register 1
  $294 constant GPDMA1_GPDMA_C4TR2      \ GPDMA channel 4 transfer register 2
  $298 constant GPDMA1_GPDMA_C4BR1      \ GPDMA channel 4 block register 1
  $29C constant GPDMA1_GPDMA_C4SAR      \ GPDMA channel 4 source address register
  $2A0 constant GPDMA1_GPDMA_C4DAR      \ GPDMA channel 4 destination address register
  $2CC constant GPDMA1_GPDMA_C4LLR      \ GPDMA channel 4 linked-list address register
  $2D0 constant GPDMA1_GPDMA_C5LBAR     \ GPDMA channel 5 linked-list base address register
  $2DC constant GPDMA1_GPDMA_C5FCR      \ GPDMA channel 5 flag clear register
  $2E0 constant GPDMA1_GPDMA_C5SR       \ GPDMA channel 5 status register
  $2E4 constant GPDMA1_GPDMA_C5CR       \ GPDMA channel 5 control register
  $310 constant GPDMA1_GPDMA_C5TR1      \ GPDMA channel 5 transfer register 1
  $314 constant GPDMA1_GPDMA_C5TR2      \ GPDMA channel 5 transfer register 2
  $318 constant GPDMA1_GPDMA_C5BR1      \ GPDMA channel 5 block register 1
  $31C constant GPDMA1_GPDMA_C5SAR      \ GPDMA channel 5 source address register
  $320 constant GPDMA1_GPDMA_C5DAR      \ GPDMA channel 5 destination address register
  $34C constant GPDMA1_GPDMA_C5LLR      \ GPDMA channel 5 linked-list address register
  $350 constant GPDMA1_GPDMA_C6LBAR     \ GPDMA channel 6 linked-list base address register
  $35C constant GPDMA1_GPDMA_C6FCR      \ GPDMA channel 6 flag clear register
  $360 constant GPDMA1_GPDMA_C6SR       \ GPDMA channel 6 status register
  $364 constant GPDMA1_GPDMA_C6CR       \ GPDMA channel 6 control register
  $390 constant GPDMA1_GPDMA_C6TR1      \ GPDMA channel 6 transfer register 1
  $394 constant GPDMA1_GPDMA_C6TR2      \ GPDMA channel 6 transfer register 2
  $398 constant GPDMA1_GPDMA_C6BR1      \ GPDMA channel 6 block register 1
  $39C constant GPDMA1_GPDMA_C6SAR      \ GPDMA channel 6 source address register
  $3A0 constant GPDMA1_GPDMA_C6DAR      \ GPDMA channel 6 destination address register
  $3CC constant GPDMA1_GPDMA_C6LLR      \ GPDMA channel 6 linked-list address register
  $3D0 constant GPDMA1_GPDMA_C7LBAR     \ GPDMA channel 7 linked-list base address register
  $3DC constant GPDMA1_GPDMA_C7FCR      \ GPDMA channel 7 flag clear register
  $3E0 constant GPDMA1_GPDMA_C7SR       \ GPDMA channel 7 status register
  $3E4 constant GPDMA1_GPDMA_C7CR       \ GPDMA channel 7 control register
  $410 constant GPDMA1_GPDMA_C7TR1      \ GPDMA channel 7 transfer register 1
  $414 constant GPDMA1_GPDMA_C7TR2      \ GPDMA channel 7 transfer register 2
  $418 constant GPDMA1_GPDMA_C7BR1      \ GPDMA channel 7 block register 1
  $41C constant GPDMA1_GPDMA_C7SAR      \ GPDMA channel 7 source address register
  $420 constant GPDMA1_GPDMA_C7DAR      \ GPDMA channel 7 destination address register
  $44C constant GPDMA1_GPDMA_C7LLR      \ GPDMA channel 7 linked-list address register
  $450 constant GPDMA1_GPDMA_C8LBAR     \ GPDMA channel 8 linked-list base address register
  $45C constant GPDMA1_GPDMA_C8FCR      \ GPDMA channel 8 flag clear register
  $460 constant GPDMA1_GPDMA_C8SR       \ GPDMA channel 8 status register
  $464 constant GPDMA1_GPDMA_C8CR       \ GPDMA channel 8 control register
  $490 constant GPDMA1_GPDMA_C8TR1      \ GPDMA channel 8 transfer register 1
  $494 constant GPDMA1_GPDMA_C8TR2      \ GPDMA channel 8 transfer register 2
  $498 constant GPDMA1_GPDMA_C8BR1      \ GPDMA channel 8 block register 1
  $49C constant GPDMA1_GPDMA_C8SAR      \ GPDMA channel 8 source address register
  $4A0 constant GPDMA1_GPDMA_C8DAR      \ GPDMA channel 8 destination address register
  $4CC constant GPDMA1_GPDMA_C8LLR      \ GPDMA channel 8 linked-list address register
  $4D0 constant GPDMA1_GPDMA_C9LBAR     \ GPDMA channel 9 linked-list base address register
  $4DC constant GPDMA1_GPDMA_C9FCR      \ GPDMA channel 9 flag clear register
  $4E0 constant GPDMA1_GPDMA_C9SR       \ GPDMA channel 9 status register
  $4E4 constant GPDMA1_GPDMA_C9CR       \ GPDMA channel 9 control register
  $510 constant GPDMA1_GPDMA_C9TR1      \ GPDMA channel 9 transfer register 1
  $514 constant GPDMA1_GPDMA_C9TR2      \ GPDMA channel 9 transfer register 2
  $518 constant GPDMA1_GPDMA_C9BR1      \ GPDMA channel 9 block register 1
  $51C constant GPDMA1_GPDMA_C9SAR      \ GPDMA channel 9 source address register
  $520 constant GPDMA1_GPDMA_C9DAR      \ GPDMA channel 9 destination address register
  $54C constant GPDMA1_GPDMA_C9LLR      \ GPDMA channel 9 linked-list address register
  $550 constant GPDMA1_GPDMA_C10LBAR    \ GPDMA channel 10 linked-list base address register
  $55C constant GPDMA1_GPDMA_C10FCR     \ GPDMA channel 10 flag clear register
  $560 constant GPDMA1_GPDMA_C10SR      \ GPDMA channel 10 status register
  $564 constant GPDMA1_GPDMA_C10CR      \ GPDMA channel 10 control register
  $590 constant GPDMA1_GPDMA_C10TR1     \ GPDMA channel 10 transfer register 1
  $594 constant GPDMA1_GPDMA_C10TR2     \ GPDMA channel 10 transfer register 2
  $598 constant GPDMA1_GPDMA_C10BR1     \ GPDMA channel 10 block register 1
  $59C constant GPDMA1_GPDMA_C10SAR     \ GPDMA channel 10 source address register
  $5A0 constant GPDMA1_GPDMA_C10DAR     \ GPDMA channel 10 destination address register
  $5CC constant GPDMA1_GPDMA_C10LLR     \ GPDMA channel 10 linked-list address register
  $5D0 constant GPDMA1_GPDMA_C11LBAR    \ GPDMA channel 11 linked-list base address register
  $5DC constant GPDMA1_GPDMA_C11FCR     \ GPDMA channel 11 flag clear register
  $5E0 constant GPDMA1_GPDMA_C11SR      \ GPDMA channel 11 status register
  $5E4 constant GPDMA1_GPDMA_C11CR      \ GPDMA channel 11 control register
  $610 constant GPDMA1_GPDMA_C11TR1     \ GPDMA channel 11 transfer register 1
  $614 constant GPDMA1_GPDMA_C11TR2     \ GPDMA channel 11 transfer register 2
  $618 constant GPDMA1_GPDMA_C11BR1     \ GPDMA channel 11 block register 1
  $61C constant GPDMA1_GPDMA_C11SAR     \ GPDMA channel 11 source address register
  $620 constant GPDMA1_GPDMA_C11DAR     \ GPDMA channel 11 destination address register
  $64C constant GPDMA1_GPDMA_C11LLR     \ GPDMA channel 11 linked-list address register
  $650 constant GPDMA1_GPDMA_C12LBAR    \ GPDMA channel 12 linked-list base address register
  $65C constant GPDMA1_GPDMA_C12FCR     \ GPDMA channel 12 flag clear register
  $660 constant GPDMA1_GPDMA_C12SR      \ GPDMA channel 12 status register
  $664 constant GPDMA1_GPDMA_C12CR      \ GPDMA channel 12 control register
  $690 constant GPDMA1_GPDMA_C12TR1     \ GPDMA channel 12 transfer register 1
  $694 constant GPDMA1_GPDMA_C12TR2     \ GPDMA channel 12 transfer register 2
  $698 constant GPDMA1_GPDMA_C12BR1     \ GPDMA channel 12 alternate block register 1
  $69C constant GPDMA1_GPDMA_C12SAR     \ GPDMA channel 12 source address register
  $6A0 constant GPDMA1_GPDMA_C12DAR     \ GPDMA channel 12 destination address register
  $6A4 constant GPDMA1_GPDMA_C12TR3     \ GPDMA channel 12 transfer register 3
  $6A8 constant GPDMA1_GPDMA_C12BR2     \ GPDMA channel 12 block register 2
  $6CC constant GPDMA1_GPDMA_C12LLR     \ GPDMA channel 12 alternate linked-list address register
  $6D0 constant GPDMA1_GPDMA_C13LBAR    \ GPDMA channel 13 linked-list base address register
  $6DC constant GPDMA1_GPDMA_C13FCR     \ GPDMA channel 13 flag clear register
  $6E0 constant GPDMA1_GPDMA_C13SR      \ GPDMA channel 13 status register
  $6E4 constant GPDMA1_GPDMA_C13CR      \ GPDMA channel 13 control register
  $710 constant GPDMA1_GPDMA_C13TR1     \ GPDMA channel 13 transfer register 1
  $714 constant GPDMA1_GPDMA_C13TR2     \ GPDMA channel 13 transfer register 2
  $718 constant GPDMA1_GPDMA_C13BR1     \ GPDMA channel 13 alternate block register 1
  $71C constant GPDMA1_GPDMA_C13SAR     \ GPDMA channel 13 source address register
  $720 constant GPDMA1_GPDMA_C13DAR     \ GPDMA channel 13 destination address register
  $724 constant GPDMA1_GPDMA_C13TR3     \ GPDMA channel 13 transfer register 3
  $728 constant GPDMA1_GPDMA_C13BR2     \ GPDMA channel 13 block register 2
  $74C constant GPDMA1_GPDMA_C13LLR     \ GPDMA channel 13 alternate linked-list address register
  $750 constant GPDMA1_GPDMA_C14LBAR    \ GPDMA channel 14 linked-list base address register
  $75C constant GPDMA1_GPDMA_C14FCR     \ GPDMA channel 14 flag clear register
  $760 constant GPDMA1_GPDMA_C14SR      \ GPDMA channel 14 status register
  $764 constant GPDMA1_GPDMA_C14CR      \ GPDMA channel 14 control register
  $790 constant GPDMA1_GPDMA_C14TR1     \ GPDMA channel 14 transfer register 1
  $794 constant GPDMA1_GPDMA_C14TR2     \ GPDMA channel 14 transfer register 2
  $798 constant GPDMA1_GPDMA_C14BR1     \ GPDMA channel 14 alternate block register 1
  $79C constant GPDMA1_GPDMA_C14SAR     \ GPDMA channel 14 source address register
  $7A0 constant GPDMA1_GPDMA_C14DAR     \ GPDMA channel 14 destination address register
  $7A4 constant GPDMA1_GPDMA_C14TR3     \ GPDMA channel 14 transfer register 3
  $7A8 constant GPDMA1_GPDMA_C14BR2     \ GPDMA channel 14 block register 2
  $7CC constant GPDMA1_GPDMA_C14LLR     \ GPDMA channel 14 alternate linked-list address register
  $7D0 constant GPDMA1_GPDMA_C15LBAR    \ GPDMA channel 15 linked-list base address register
  $7DC constant GPDMA1_GPDMA_C15FCR     \ GPDMA channel 15 flag clear register
  $7E0 constant GPDMA1_GPDMA_C15SR      \ GPDMA channel 15 status register
  $7E4 constant GPDMA1_GPDMA_C15CR      \ GPDMA channel 15 control register
  $810 constant GPDMA1_GPDMA_C15TR1     \ GPDMA channel 15 transfer register 1
  $814 constant GPDMA1_GPDMA_C15TR2     \ GPDMA channel 15 transfer register 2
  $818 constant GPDMA1_GPDMA_C15BR1     \ GPDMA channel 15 alternate block register 1
  $81C constant GPDMA1_GPDMA_C15SAR     \ GPDMA channel 15 source address register
  $820 constant GPDMA1_GPDMA_C15DAR     \ GPDMA channel 15 destination address register
  $824 constant GPDMA1_GPDMA_C15TR3     \ GPDMA channel 15 transfer register 3
  $828 constant GPDMA1_GPDMA_C15BR2     \ GPDMA channel 15 block register 2
  $84C constant GPDMA1_GPDMA_C15LLR     \ GPDMA channel 15 alternate linked-list address register

: GPDMA1_DEF ; [then]
