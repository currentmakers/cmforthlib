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


  [ifdef] LPDMA1_LPDMA_RCFGLOCKR_DEF
    \
    \ @brief LPDMA configuration lock register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_LOCK0                   \ [0x00] LOCK0
    $01 constant LPDMA1_LOCK1                   \ [0x01] LOCK1
    $02 constant LPDMA1_LOCK2                   \ [0x02] LOCK2
    $03 constant LPDMA1_LOCK3                   \ [0x03] LOCK3
  [then]


  [ifdef] LPDMA1_LPDMA_MISR_DEF
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


  [ifdef] LPDMA1_LPDMA_SMISR_DEF
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
    \ @brief LPDMA channel 0 linked-list base address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $10 constant LPDMA1_LBA                     \ [0x10 : 16] linked-list base address of LPDMA channel x
  [then]


  [ifdef] LPDMA1_LPDMA_C0FCR_DEF
    \
    \ @brief LPDMA channel 0 flag clear register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant LPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] LPDMA1_LPDMA_C0SR_DEF
    \
    \ @brief LPDMA channel 0 status register
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant LPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (LPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is a block transfer complete or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode LPDMA_CxTR2.TCEM[1:0].
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is an half block transfer that occurs when half of the bytes of the source block size (rounded-up integer of LPDMA_CxBR1.BNDT[15:0] / 2) has been transferred to the destination.
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant LPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] LPDMA1_LPDMA_C0CR_DEF
    \
    \ @brief LPDMA channel 0 control register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant LPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (LPDMA_CxSR.SUSPF = 1 and LPDMA_CxSR.IDLEF = LPDMA_CxCR.EN = 1) - channel in disabled state (LPDMA_CxSR.IDLEF = 1 and LPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant LPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in sequence.
    $08 constant LPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant LPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant LPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant LPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant LPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant LPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant LPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant LPDMA1_LSM                     \ [0x10] Link step mode First the block transfer is executed as defined by the current internal register file until LPDMA_CxBR1.BNDT[15:0 ] =0). Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant LPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x LPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] LPDMA1_LPDMA_C0TR1_DEF
    \
    \ @brief LPDMA channel 0 transfer register 1
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. a source block size must be a multiple of the source data width (LPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address LPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant LPDMA1_SINC                    \ [0x03] source incrementing single The source address, pointed by LPDMA_CxSAR, is kept constant after a single transfer or is incremented by the offset value corresponding to a contiguous data after a single transfer.
    $0b constant LPDMA1_PAM                     \ [0x0b] padding/alignment mode If DDW_LOG2[1:0]=SDW_LOG2[1:0]: if the data width of a single destination transfer is equal to the data width of a single source transfer, this bit is ignored. Else: Case 1: If destination data width > source data width Case 2: If destination data width < source data width
    $0f constant LPDMA1_SSEC                    \ [0x0f] security attribute of the LPDMA transfer from the source If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx =1 . A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer from the source is non-secure.
    $10 constant LPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination single transfer must have an aligned address with its data width (start address LPDMA_CxDAR[2:0] versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and none transfer is issued.
    $13 constant LPDMA1_DINC                    \ [0x13] destination incrementing single The destination address, pointed by LPDMA_CxDAR, is kept constant after a single transfer, or is incremented by the offset value corresponding to a contiguous data after a single transfer.
    $1f constant LPDMA1_DSEC                    \ [0x1f] security attribute of the LPDMA transfer to the destination If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx = 1. A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] LPDMA1_LPDMA_C0TR2_DEF
    \
    \ @brief LPDMA channel 0 transfer register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_REQSEL                  \ [0x00 : 5] DMA hardware request selection These bits are ignored if channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per request. Note: The user must not assign a same input hardware request (same REQSEL[4:0] value) to different active DMA channels (LPDMA_CxCR.EN = 1 and LPDMA_CxTR2.SWREQ = 0 for these channels). DMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant LPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when LPDMA_CxCR.EN is asserted.
    $0b constant LPDMA1_BREQ                    \ [0x0b] block hardware request If the channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant LPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (LPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 0b00 or 0b11, these TRIGM[1:0] bits are ignored. Else, a DMA transfer is conditioned by at least one trigger hit: The LPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 0b01 or respectively TRIGPOL[1:0] = 0b10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[4:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the LPDMA_CxTR2 with a new value for any of TRIGSEL[4:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized, and a trigger overrun flag is reported (LPDMA_CxSR.TOF = 1), an interrupt is generated if enabled (LPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun.
    $10 constant LPDMA1_TRIGSEL                 \ [0x10 : 5] trigger event input selection These bits select the trigger event input of the LPDMA transfer (as per Programmed LPDMA1 trigger), with an active trigger event if TRIGPOL[1:0] = 00.
    $18 constant LPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[4:0].
    $1e constant LPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] LPDMA1_LPDMA_C0BR1_DEF
    \
    \ @brief LPDMA channel 0 block register 1
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if LPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if LPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all LPDMA_CxLLR.Uxx = 0 and if LPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if LPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C0SAR_DEF
    \
    \ @brief LPDMA channel 0 source address register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (LPDMA_CxTR1.SINC), this field is either kept fixed or incremented by the data width (LPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by LPDMA from the memory, provided the LLI is set with LPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[32:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C0DAR_DEF
    \
    \ @brief LPDMA channel 0 destination address register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (LPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (LPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by DMA from the memory, provided the LLI is set with LPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination single (DA[2:0] versus LPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C0LLR_DEF
    \
    \ @brief LPDMA channel 0 linked-list address register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $02 constant LPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file (LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant LPDMA1_ULL                     \ [0x10] Update LPDMA_CxLLR register from memory This bit is used to control the update of the LPDMA_CxLLR register from the memory during the link transfer.
    $1b constant LPDMA1_UDA                     \ [0x1b] Update LPDMA_CxDAR register from memory This bit is used to control the update of the LPDMA_CxDAR register from the memory during the link transfer.
    $1c constant LPDMA1_USA                     \ [0x1c] update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer.
    $1d constant LPDMA1_UB1                     \ [0x1d] Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer.
    $1e constant LPDMA1_UT2                     \ [0x1e] Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer.
    $1f constant LPDMA1_UT1                     \ [0x1f] Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer.
  [then]


  [ifdef] LPDMA1_LPDMA_C1LBAR_DEF
    \
    \ @brief LPDMA channel 1 linked-list base address register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $10 constant LPDMA1_LBA                     \ [0x10 : 16] linked-list base address of LPDMA channel x
  [then]


  [ifdef] LPDMA1_LPDMA_C1FCR_DEF
    \
    \ @brief LPDMA channel 1 flag clear register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant LPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] LPDMA1_LPDMA_C1SR_DEF
    \
    \ @brief LPDMA channel 1 status register
    \ Address offset: 0xE0
    \ Reset value: 0x00000001
    \
    $00 constant LPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (LPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is a block transfer complete or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode LPDMA_CxTR2.TCEM[1:0].
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is an half block transfer that occurs when half of the bytes of the source block size (rounded-up integer of LPDMA_CxBR1.BNDT[15:0] / 2) has been transferred to the destination.
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant LPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] LPDMA1_LPDMA_C1CR_DEF
    \
    \ @brief LPDMA channel 1 control register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant LPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (LPDMA_CxSR.SUSPF = 1 and LPDMA_CxSR.IDLEF = LPDMA_CxCR.EN = 1) - channel in disabled state (LPDMA_CxSR.IDLEF = 1 and LPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant LPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in sequence.
    $08 constant LPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant LPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant LPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant LPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant LPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant LPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant LPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant LPDMA1_LSM                     \ [0x10] Link step mode First the block transfer is executed as defined by the current internal register file until LPDMA_CxBR1.BNDT[15:0 ] =0). Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant LPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x LPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] LPDMA1_LPDMA_C1TR1_DEF
    \
    \ @brief LPDMA channel 1 transfer register 1
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. a source block size must be a multiple of the source data width (LPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address LPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant LPDMA1_SINC                    \ [0x03] source incrementing single The source address, pointed by LPDMA_CxSAR, is kept constant after a single transfer or is incremented by the offset value corresponding to a contiguous data after a single transfer.
    $0b constant LPDMA1_PAM                     \ [0x0b] padding/alignment mode If DDW_LOG2[1:0]=SDW_LOG2[1:0]: if the data width of a single destination transfer is equal to the data width of a single source transfer, this bit is ignored. Else: Case 1: If destination data width > source data width Case 2: If destination data width < source data width
    $0f constant LPDMA1_SSEC                    \ [0x0f] security attribute of the LPDMA transfer from the source If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx =1 . A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer from the source is non-secure.
    $10 constant LPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination single transfer must have an aligned address with its data width (start address LPDMA_CxDAR[2:0] versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and none transfer is issued.
    $13 constant LPDMA1_DINC                    \ [0x13] destination incrementing single The destination address, pointed by LPDMA_CxDAR, is kept constant after a single transfer, or is incremented by the offset value corresponding to a contiguous data after a single transfer.
    $1f constant LPDMA1_DSEC                    \ [0x1f] security attribute of the LPDMA transfer to the destination If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx = 1. A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] LPDMA1_LPDMA_C1TR2_DEF
    \
    \ @brief LPDMA channel 1 transfer register 2
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_REQSEL                  \ [0x00 : 5] DMA hardware request selection These bits are ignored if channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per request. Note: The user must not assign a same input hardware request (same REQSEL[4:0] value) to different active DMA channels (LPDMA_CxCR.EN = 1 and LPDMA_CxTR2.SWREQ = 0 for these channels). DMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant LPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when LPDMA_CxCR.EN is asserted.
    $0b constant LPDMA1_BREQ                    \ [0x0b] block hardware request If the channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant LPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (LPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 0b00 or 0b11, these TRIGM[1:0] bits are ignored. Else, a DMA transfer is conditioned by at least one trigger hit: The LPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 0b01 or respectively TRIGPOL[1:0] = 0b10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[4:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the LPDMA_CxTR2 with a new value for any of TRIGSEL[4:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized, and a trigger overrun flag is reported (LPDMA_CxSR.TOF = 1), an interrupt is generated if enabled (LPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun.
    $10 constant LPDMA1_TRIGSEL                 \ [0x10 : 5] trigger event input selection These bits select the trigger event input of the LPDMA transfer (as per Programmed LPDMA1 trigger), with an active trigger event if TRIGPOL[1:0] = 00.
    $18 constant LPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[4:0].
    $1e constant LPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] LPDMA1_LPDMA_C1BR1_DEF
    \
    \ @brief LPDMA channel 1 block register 1
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if LPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if LPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all LPDMA_CxLLR.Uxx = 0 and if LPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if LPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C1SAR_DEF
    \
    \ @brief LPDMA channel 1 source address register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (LPDMA_CxTR1.SINC), this field is either kept fixed or incremented by the data width (LPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by LPDMA from the memory, provided the LLI is set with LPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[32:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C1DAR_DEF
    \
    \ @brief LPDMA channel 1 destination address register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (LPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (LPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by DMA from the memory, provided the LLI is set with LPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination single (DA[2:0] versus LPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C1LLR_DEF
    \
    \ @brief LPDMA channel 1 linked-list address register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $02 constant LPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file (LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant LPDMA1_ULL                     \ [0x10] Update LPDMA_CxLLR register from memory This bit is used to control the update of the LPDMA_CxLLR register from the memory during the link transfer.
    $1b constant LPDMA1_UDA                     \ [0x1b] Update LPDMA_CxDAR register from memory This bit is used to control the update of the LPDMA_CxDAR register from the memory during the link transfer.
    $1c constant LPDMA1_USA                     \ [0x1c] update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer.
    $1d constant LPDMA1_UB1                     \ [0x1d] Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer.
    $1e constant LPDMA1_UT2                     \ [0x1e] Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer.
    $1f constant LPDMA1_UT1                     \ [0x1f] Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer.
  [then]


  [ifdef] LPDMA1_LPDMA_C2LBAR_DEF
    \
    \ @brief LPDMA channel 2 linked-list base address register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $10 constant LPDMA1_LBA                     \ [0x10 : 16] linked-list base address of LPDMA channel x
  [then]


  [ifdef] LPDMA1_LPDMA_C2FCR_DEF
    \
    \ @brief LPDMA channel 2 flag clear register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant LPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] LPDMA1_LPDMA_C2SR_DEF
    \
    \ @brief LPDMA channel 2 status register
    \ Address offset: 0x160
    \ Reset value: 0x00000001
    \
    $00 constant LPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (LPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is a block transfer complete or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode LPDMA_CxTR2.TCEM[1:0].
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is an half block transfer that occurs when half of the bytes of the source block size (rounded-up integer of LPDMA_CxBR1.BNDT[15:0] / 2) has been transferred to the destination.
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant LPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] LPDMA1_LPDMA_C2CR_DEF
    \
    \ @brief LPDMA channel 2 control register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant LPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (LPDMA_CxSR.SUSPF = 1 and LPDMA_CxSR.IDLEF = LPDMA_CxCR.EN = 1) - channel in disabled state (LPDMA_CxSR.IDLEF = 1 and LPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant LPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in sequence.
    $08 constant LPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant LPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant LPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant LPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant LPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant LPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant LPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant LPDMA1_LSM                     \ [0x10] Link step mode First the block transfer is executed as defined by the current internal register file until LPDMA_CxBR1.BNDT[15:0 ] =0). Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant LPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x LPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] LPDMA1_LPDMA_C2TR1_DEF
    \
    \ @brief LPDMA channel 2 transfer register 1
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. a source block size must be a multiple of the source data width (LPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address LPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant LPDMA1_SINC                    \ [0x03] source incrementing single The source address, pointed by LPDMA_CxSAR, is kept constant after a single transfer or is incremented by the offset value corresponding to a contiguous data after a single transfer.
    $0b constant LPDMA1_PAM                     \ [0x0b] padding/alignment mode If DDW_LOG2[1:0]=SDW_LOG2[1:0]: if the data width of a single destination transfer is equal to the data width of a single source transfer, this bit is ignored. Else: Case 1: If destination data width > source data width Case 2: If destination data width < source data width
    $0f constant LPDMA1_SSEC                    \ [0x0f] security attribute of the LPDMA transfer from the source If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx =1 . A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer from the source is non-secure.
    $10 constant LPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination single transfer must have an aligned address with its data width (start address LPDMA_CxDAR[2:0] versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and none transfer is issued.
    $13 constant LPDMA1_DINC                    \ [0x13] destination incrementing single The destination address, pointed by LPDMA_CxDAR, is kept constant after a single transfer, or is incremented by the offset value corresponding to a contiguous data after a single transfer.
    $1f constant LPDMA1_DSEC                    \ [0x1f] security attribute of the LPDMA transfer to the destination If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx = 1. A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] LPDMA1_LPDMA_C2TR2_DEF
    \
    \ @brief LPDMA channel 2 transfer register 2
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_REQSEL                  \ [0x00 : 5] DMA hardware request selection These bits are ignored if channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per request. Note: The user must not assign a same input hardware request (same REQSEL[4:0] value) to different active DMA channels (LPDMA_CxCR.EN = 1 and LPDMA_CxTR2.SWREQ = 0 for these channels). DMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant LPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when LPDMA_CxCR.EN is asserted.
    $0b constant LPDMA1_BREQ                    \ [0x0b] block hardware request If the channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant LPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (LPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 0b00 or 0b11, these TRIGM[1:0] bits are ignored. Else, a DMA transfer is conditioned by at least one trigger hit: The LPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 0b01 or respectively TRIGPOL[1:0] = 0b10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[4:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the LPDMA_CxTR2 with a new value for any of TRIGSEL[4:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized, and a trigger overrun flag is reported (LPDMA_CxSR.TOF = 1), an interrupt is generated if enabled (LPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun.
    $10 constant LPDMA1_TRIGSEL                 \ [0x10 : 5] trigger event input selection These bits select the trigger event input of the LPDMA transfer (as per Programmed LPDMA1 trigger), with an active trigger event if TRIGPOL[1:0] = 00.
    $18 constant LPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[4:0].
    $1e constant LPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] LPDMA1_LPDMA_C2BR1_DEF
    \
    \ @brief LPDMA channel 2 block register 1
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if LPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if LPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all LPDMA_CxLLR.Uxx = 0 and if LPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if LPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C2SAR_DEF
    \
    \ @brief LPDMA channel 2 source address register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (LPDMA_CxTR1.SINC), this field is either kept fixed or incremented by the data width (LPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by LPDMA from the memory, provided the LLI is set with LPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[32:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C2DAR_DEF
    \
    \ @brief LPDMA channel 2 destination address register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (LPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (LPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by DMA from the memory, provided the LLI is set with LPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination single (DA[2:0] versus LPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C2LLR_DEF
    \
    \ @brief LPDMA channel 2 linked-list address register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $02 constant LPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file (LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant LPDMA1_ULL                     \ [0x10] Update LPDMA_CxLLR register from memory This bit is used to control the update of the LPDMA_CxLLR register from the memory during the link transfer.
    $1b constant LPDMA1_UDA                     \ [0x1b] Update LPDMA_CxDAR register from memory This bit is used to control the update of the LPDMA_CxDAR register from the memory during the link transfer.
    $1c constant LPDMA1_USA                     \ [0x1c] update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer.
    $1d constant LPDMA1_UB1                     \ [0x1d] Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer.
    $1e constant LPDMA1_UT2                     \ [0x1e] Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer.
    $1f constant LPDMA1_UT1                     \ [0x1f] Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer.
  [then]


  [ifdef] LPDMA1_LPDMA_C3LBAR_DEF
    \
    \ @brief LPDMA channel 3 linked-list base address register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $10 constant LPDMA1_LBA                     \ [0x10 : 16] linked-list base address of LPDMA channel x
  [then]


  [ifdef] LPDMA1_LPDMA_C3FCR_DEF
    \
    \ @brief LPDMA channel 3 flag clear register
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag clear
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag clear
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag clear
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag clear
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag clear
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag clear
    $0e constant LPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] LPDMA1_LPDMA_C3SR_DEF
    \
    \ @brief LPDMA channel 3 status register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000001
    \
    $00 constant LPDMA1_IDLEF                   \ [0x00] idle flag This idle flag is de-asserted by hardware when the channel is enabled (LPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
    $08 constant LPDMA1_TCF                     \ [0x08] transfer complete flag A transfer complete event is a block transfer complete or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode LPDMA_CxTR2.TCEM[1:0].
    $09 constant LPDMA1_HTF                     \ [0x09] half transfer flag An half transfer event is an half block transfer that occurs when half of the bytes of the source block size (rounded-up integer of LPDMA_CxBR1.BNDT[15:0] / 2) has been transferred to the destination.
    $0a constant LPDMA1_DTEF                    \ [0x0a] data transfer error flag
    $0b constant LPDMA1_ULEF                    \ [0x0b] update link transfer error flag
    $0c constant LPDMA1_USEF                    \ [0x0c] user setting error flag
    $0d constant LPDMA1_SUSPF                   \ [0x0d] completed suspension flag
    $0e constant LPDMA1_TOF                     \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] LPDMA1_LPDMA_C3CR_DEF
    \
    \ @brief LPDMA channel 3 control register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_EN                      \ [0x00] enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
    $01 constant LPDMA1_RESET                   \ [0x01] reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (LPDMA_CxSR.SUSPF = 1 and LPDMA_CxSR.IDLEF = LPDMA_CxCR.EN = 1) - channel in disabled state (LPDMA_CxSR.IDLEF = 1 and LPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
    $02 constant LPDMA1_SUSP                    \ [0x02] suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in sequence.
    $08 constant LPDMA1_TCIE                    \ [0x08] transfer complete interrupt enable
    $09 constant LPDMA1_HTIE                    \ [0x09] half transfer complete interrupt enable
    $0a constant LPDMA1_DTEIE                   \ [0x0a] data transfer error interrupt enable
    $0b constant LPDMA1_ULEIE                   \ [0x0b] update link transfer error interrupt enable
    $0c constant LPDMA1_USEIE                   \ [0x0c] user setting error interrupt enable
    $0d constant LPDMA1_SUSPIE                  \ [0x0d] completed suspension interrupt enable
    $0e constant LPDMA1_TOIE                    \ [0x0e] trigger overrun interrupt enable
    $10 constant LPDMA1_LSM                     \ [0x10] Link step mode First the block transfer is executed as defined by the current internal register file until LPDMA_CxBR1.BNDT[15:0 ] =0). Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
    $16 constant LPDMA1_PRIO                    \ [0x16 : 2] priority level of the channel x LPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
  [then]


  [ifdef] LPDMA1_LPDMA_C3TR1_DEF
    \
    \ @brief LPDMA channel 3 transfer register 1
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SDW_LOG2                \ [0x00 : 2] binary logarithm of the source data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. a source block size must be a multiple of the source data width (LPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address LPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
    $03 constant LPDMA1_SINC                    \ [0x03] source incrementing single The source address, pointed by LPDMA_CxSAR, is kept constant after a single transfer or is incremented by the offset value corresponding to a contiguous data after a single transfer.
    $0b constant LPDMA1_PAM                     \ [0x0b] padding/alignment mode If DDW_LOG2[1:0]=SDW_LOG2[1:0]: if the data width of a single destination transfer is equal to the data width of a single source transfer, this bit is ignored. Else: Case 1: If destination data width > source data width Case 2: If destination data width < source data width
    $0f constant LPDMA1_SSEC                    \ [0x0f] security attribute of the LPDMA transfer from the source If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx =1 . A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer from the source is non-secure.
    $10 constant LPDMA1_DDW_LOG2                \ [0x10 : 2] binary logarithm of the destination data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination single transfer must have an aligned address with its data width (start address LPDMA_CxDAR[2:0] versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and none transfer is issued.
    $13 constant LPDMA1_DINC                    \ [0x13] destination incrementing single The destination address, pointed by LPDMA_CxDAR, is kept constant after a single transfer, or is incremented by the offset value corresponding to a contiguous data after a single transfer.
    $1f constant LPDMA1_DSEC                    \ [0x1f] security attribute of the LPDMA transfer to the destination If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx = 1. A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer to the destination is non-secure.
  [then]


  [ifdef] LPDMA1_LPDMA_C3TR2_DEF
    \
    \ @brief LPDMA channel 3 transfer register 2
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_REQSEL                  \ [0x00 : 5] DMA hardware request selection These bits are ignored if channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per request. Note: The user must not assign a same input hardware request (same REQSEL[4:0] value) to different active DMA channels (LPDMA_CxCR.EN = 1 and LPDMA_CxTR2.SWREQ = 0 for these channels). DMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
    $09 constant LPDMA1_SWREQ                   \ [0x09] software request This bit is internally taken into account when LPDMA_CxCR.EN is asserted.
    $0b constant LPDMA1_BREQ                    \ [0x0b] block hardware request If the channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
    $0e constant LPDMA1_TRIGM                   \ [0x0e : 2] trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (LPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 0b00 or 0b11, these TRIGM[1:0] bits are ignored. Else, a DMA transfer is conditioned by at least one trigger hit: The LPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 0b01 or respectively TRIGPOL[1:0] = 0b10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[4:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the LPDMA_CxTR2 with a new value for any of TRIGSEL[4:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized, and a trigger overrun flag is reported (LPDMA_CxSR.TOF = 1), an interrupt is generated if enabled (LPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun.
    $10 constant LPDMA1_TRIGSEL                 \ [0x10 : 5] trigger event input selection These bits select the trigger event input of the LPDMA transfer (as per Programmed LPDMA1 trigger), with an active trigger event if TRIGPOL[1:0] = 00.
    $18 constant LPDMA1_TRIGPOL                 \ [0x18 : 2] trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[4:0].
    $1e constant LPDMA1_TCEM                    \ [0x1e : 2] transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.
  [then]


  [ifdef] LPDMA1_LPDMA_C3BR1_DEF
    \
    \ @brief LPDMA channel 3 block register 1
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_BNDT                    \ [0x00 : 16] block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if LPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if LPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all LPDMA_CxLLR.Uxx = 0 and if LPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if LPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C3SAR_DEF
    \
    \ @brief LPDMA channel 3 source address register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_SA                      \ [0x00 : 32] source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (LPDMA_CxTR1.SINC), this field is either kept fixed or incremented by the data width (LPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by LPDMA from the memory, provided the LLI is set with LPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[32:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C3DAR_DEF
    \
    \ @brief LPDMA channel 3 destination address register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant LPDMA1_DA                      \ [0x00 : 32] destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (LPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (LPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by DMA from the memory, provided the LLI is set with LPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination single (DA[2:0] versus LPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.
  [then]


  [ifdef] LPDMA1_LPDMA_C3LLR_DEF
    \
    \ @brief LPDMA channel 3 linked-list address register
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $02 constant LPDMA1_LA                      \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file (LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
    $10 constant LPDMA1_ULL                     \ [0x10] Update LPDMA_CxLLR register from memory This bit is used to control the update of the LPDMA_CxLLR register from the memory during the link transfer.
    $1b constant LPDMA1_UDA                     \ [0x1b] Update LPDMA_CxDAR register from memory This bit is used to control the update of the LPDMA_CxDAR register from the memory during the link transfer.
    $1c constant LPDMA1_USA                     \ [0x1c] update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer.
    $1d constant LPDMA1_UB1                     \ [0x1d] Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer.
    $1e constant LPDMA1_UT2                     \ [0x1e] Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer.
    $1f constant LPDMA1_UT1                     \ [0x1f] Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer.
  [then]

  \
  \ @brief LPDMA1
  \
  $00 constant LPDMA1_LPDMA_SECCFGR     \ LPDMA secure configuration register
  $04 constant LPDMA1_LPDMA_PRIVCFGR    \ LPDMA privileged configuration register
  $08 constant LPDMA1_LPDMA_RCFGLOCKR   \ LPDMA configuration lock register
  $0C constant LPDMA1_LPDMA_MISR        \ LPDMA non-secure masked interrupt status register
  $10 constant LPDMA1_LPDMA_SMISR       \ LPDMA secure masked interrupt status register
  $50 constant LPDMA1_LPDMA_C0LBAR      \ LPDMA channel 0 linked-list base address register
  $5C constant LPDMA1_LPDMA_C0FCR       \ LPDMA channel 0 flag clear register
  $60 constant LPDMA1_LPDMA_C0SR        \ LPDMA channel 0 status register
  $64 constant LPDMA1_LPDMA_C0CR        \ LPDMA channel 0 control register
  $90 constant LPDMA1_LPDMA_C0TR1       \ LPDMA channel 0 transfer register 1
  $94 constant LPDMA1_LPDMA_C0TR2       \ LPDMA channel 0 transfer register 2
  $98 constant LPDMA1_LPDMA_C0BR1       \ LPDMA channel 0 block register 1
  $9C constant LPDMA1_LPDMA_C0SAR       \ LPDMA channel 0 source address register
  $A0 constant LPDMA1_LPDMA_C0DAR       \ LPDMA channel 0 destination address register
  $CC constant LPDMA1_LPDMA_C0LLR       \ LPDMA channel 0 linked-list address register
  $D0 constant LPDMA1_LPDMA_C1LBAR      \ LPDMA channel 1 linked-list base address register
  $DC constant LPDMA1_LPDMA_C1FCR       \ LPDMA channel 1 flag clear register
  $E0 constant LPDMA1_LPDMA_C1SR        \ LPDMA channel 1 status register
  $E4 constant LPDMA1_LPDMA_C1CR        \ LPDMA channel 1 control register
  $110 constant LPDMA1_LPDMA_C1TR1      \ LPDMA channel 1 transfer register 1
  $114 constant LPDMA1_LPDMA_C1TR2      \ LPDMA channel 1 transfer register 2
  $118 constant LPDMA1_LPDMA_C1BR1      \ LPDMA channel 1 block register 1
  $11C constant LPDMA1_LPDMA_C1SAR      \ LPDMA channel 1 source address register
  $120 constant LPDMA1_LPDMA_C1DAR      \ LPDMA channel 1 destination address register
  $14C constant LPDMA1_LPDMA_C1LLR      \ LPDMA channel 1 linked-list address register
  $150 constant LPDMA1_LPDMA_C2LBAR     \ LPDMA channel 2 linked-list base address register
  $15C constant LPDMA1_LPDMA_C2FCR      \ LPDMA channel 2 flag clear register
  $160 constant LPDMA1_LPDMA_C2SR       \ LPDMA channel 2 status register
  $164 constant LPDMA1_LPDMA_C2CR       \ LPDMA channel 2 control register
  $190 constant LPDMA1_LPDMA_C2TR1      \ LPDMA channel 2 transfer register 1
  $194 constant LPDMA1_LPDMA_C2TR2      \ LPDMA channel 2 transfer register 2
  $198 constant LPDMA1_LPDMA_C2BR1      \ LPDMA channel 2 block register 1
  $19C constant LPDMA1_LPDMA_C2SAR      \ LPDMA channel 2 source address register
  $1A0 constant LPDMA1_LPDMA_C2DAR      \ LPDMA channel 2 destination address register
  $1CC constant LPDMA1_LPDMA_C2LLR      \ LPDMA channel 2 linked-list address register
  $1D0 constant LPDMA1_LPDMA_C3LBAR     \ LPDMA channel 3 linked-list base address register
  $1DC constant LPDMA1_LPDMA_C3FCR      \ LPDMA channel 3 flag clear register
  $1E0 constant LPDMA1_LPDMA_C3SR       \ LPDMA channel 3 status register
  $1E4 constant LPDMA1_LPDMA_C3CR       \ LPDMA channel 3 control register
  $210 constant LPDMA1_LPDMA_C3TR1      \ LPDMA channel 3 transfer register 1
  $214 constant LPDMA1_LPDMA_C3TR2      \ LPDMA channel 3 transfer register 2
  $218 constant LPDMA1_LPDMA_C3BR1      \ LPDMA channel 3 block register 1
  $21C constant LPDMA1_LPDMA_C3SAR      \ LPDMA channel 3 source address register
  $220 constant LPDMA1_LPDMA_C3DAR      \ LPDMA channel 3 destination address register
  $24C constant LPDMA1_LPDMA_C3LLR      \ LPDMA channel 3 linked-list address register

: LPDMA1_DEF ; [then]
