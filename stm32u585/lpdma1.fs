\
\ @file lpdma1.fs
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

$00000001 constant LPDMA1_LPDMA_SECCFGR_SEC0                        \ SEC0
$00000002 constant LPDMA1_LPDMA_SECCFGR_SEC1                        \ SEC1
$00000004 constant LPDMA1_LPDMA_SECCFGR_SEC2                        \ SEC2
$00000008 constant LPDMA1_LPDMA_SECCFGR_SEC3                        \ SEC3


\
\ @brief LPDMA privileged configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPDMA1_LPDMA_PRIVCFGR_PRIV0                      \ PRIV0
$00000002 constant LPDMA1_LPDMA_PRIVCFGR_PRIV1                      \ PRIV1
$00000004 constant LPDMA1_LPDMA_PRIVCFGR_PRIV2                      \ PRIV2
$00000008 constant LPDMA1_LPDMA_PRIVCFGR_PRIV3                      \ PRIV3


\
\ @brief LPDMA configuration lock register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPDMA1_LPDMA_RCFGLOCKR_LOCK0                     \ LOCK0
$00000002 constant LPDMA1_LPDMA_RCFGLOCKR_LOCK1                     \ LOCK1
$00000004 constant LPDMA1_LPDMA_RCFGLOCKR_LOCK2                     \ LOCK2
$00000008 constant LPDMA1_LPDMA_RCFGLOCKR_LOCK3                     \ LOCK3


\
\ @brief LPDMA non-secure masked interrupt status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant LPDMA1_LPDMA_MISR_MIS0                           \ MIS0
$00000002 constant LPDMA1_LPDMA_MISR_MIS1                           \ MIS1
$00000004 constant LPDMA1_LPDMA_MISR_MIS2                           \ MIS2
$00000008 constant LPDMA1_LPDMA_MISR_MIS3                           \ MIS3


\
\ @brief LPDMA secure masked interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPDMA1_LPDMA_SMISR_MIS0                          \ MIS0
$00000002 constant LPDMA1_LPDMA_SMISR_MIS1                          \ MIS1
$00000004 constant LPDMA1_LPDMA_SMISR_MIS2                          \ MIS2
$00000008 constant LPDMA1_LPDMA_SMISR_MIS3                          \ MIS3


\
\ @brief LPDMA channel 0 linked-list base address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$ffff0000 constant LPDMA1_LPDMA_C0LBAR_LBA                          \ linked-list base address of LPDMA channel x


\
\ @brief LPDMA channel 0 flag clear register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000100 constant LPDMA1_LPDMA_C0FCR_TCF                           \ transfer complete flag clear
$00000200 constant LPDMA1_LPDMA_C0FCR_HTF                           \ half transfer flag clear
$00000400 constant LPDMA1_LPDMA_C0FCR_DTEF                          \ data transfer error flag clear
$00000800 constant LPDMA1_LPDMA_C0FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant LPDMA1_LPDMA_C0FCR_USEF                          \ user setting error flag clear
$00002000 constant LPDMA1_LPDMA_C0FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant LPDMA1_LPDMA_C0FCR_TOF                           \ trigger overrun flag clear


\
\ @brief LPDMA channel 0 status register
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant LPDMA1_LPDMA_C0SR_IDLEF                          \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (LPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant LPDMA1_LPDMA_C0SR_TCF                            \ transfer complete flag A transfer complete event is a block transfer complete or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode LPDMA_CxTR2.TCEM[1:0].
$00000200 constant LPDMA1_LPDMA_C0SR_HTF                            \ half transfer flag An half transfer event is an half block transfer that occurs when half of the bytes of the source block size (rounded-up integer of LPDMA_CxBR1.BNDT[15:0] / 2) has been transferred to the destination.
$00000400 constant LPDMA1_LPDMA_C0SR_DTEF                           \ data transfer error flag
$00000800 constant LPDMA1_LPDMA_C0SR_ULEF                           \ update link transfer error flag
$00001000 constant LPDMA1_LPDMA_C0SR_USEF                           \ user setting error flag
$00002000 constant LPDMA1_LPDMA_C0SR_SUSPF                          \ completed suspension flag
$00004000 constant LPDMA1_LPDMA_C0SR_TOF                            \ trigger overrun flag clear


\
\ @brief LPDMA channel 0 control register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant LPDMA1_LPDMA_C0CR_EN                             \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant LPDMA1_LPDMA_C0CR_RESET                          \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (LPDMA_CxSR.SUSPF = 1 and LPDMA_CxSR.IDLEF = LPDMA_CxCR.EN = 1) - channel in disabled state (LPDMA_CxSR.IDLEF = 1 and LPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant LPDMA1_LPDMA_C0CR_SUSP                           \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in sequence.
$00000100 constant LPDMA1_LPDMA_C0CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant LPDMA1_LPDMA_C0CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant LPDMA1_LPDMA_C0CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant LPDMA1_LPDMA_C0CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant LPDMA1_LPDMA_C0CR_USEIE                          \ user setting error interrupt enable
$00002000 constant LPDMA1_LPDMA_C0CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant LPDMA1_LPDMA_C0CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant LPDMA1_LPDMA_C0CR_LSM                            \ Link step mode First the block transfer is executed as defined by the current internal register file until LPDMA_CxBR1.BNDT[15:0 ] =0). Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant LPDMA1_LPDMA_C0CR_PRIO                           \ priority level of the channel x LPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief LPDMA channel 0 transfer register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000003 constant LPDMA1_LPDMA_C0TR1_SDW_LOG2                      \ binary logarithm of the source data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. a source block size must be a multiple of the source data width (LPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address LPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant LPDMA1_LPDMA_C0TR1_SINC                          \ source incrementing single The source address, pointed by LPDMA_CxSAR, is kept constant after a single transfer or is incremented by the offset value corresponding to a contiguous data after a single transfer.
$00000800 constant LPDMA1_LPDMA_C0TR1_PAM                           \ padding/alignment mode If DDW_LOG2[1:0]=SDW_LOG2[1:0]: if the data width of a single destination transfer is equal to the data width of a single source transfer, this bit is ignored. Else: Case 1: If destination data width > source data width Case 2: If destination data width < source data width
$00008000 constant LPDMA1_LPDMA_C0TR1_SSEC                          \ security attribute of the LPDMA transfer from the source If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx =1 . A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer from the source is non-secure.
$00030000 constant LPDMA1_LPDMA_C0TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination single transfer must have an aligned address with its data width (start address LPDMA_CxDAR[2:0] versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and none transfer is issued.
$00080000 constant LPDMA1_LPDMA_C0TR1_DINC                          \ destination incrementing single The destination address, pointed by LPDMA_CxDAR, is kept constant after a single transfer, or is incremented by the offset value corresponding to a contiguous data after a single transfer.
$80000000 constant LPDMA1_LPDMA_C0TR1_DSEC                          \ security attribute of the LPDMA transfer to the destination If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx = 1. A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer to the destination is non-secure.


\
\ @brief LPDMA channel 0 transfer register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000001f constant LPDMA1_LPDMA_C0TR2_REQSEL                        \ DMA hardware request selection These bits are ignored if channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per request. Note: The user must not assign a same input hardware request (same REQSEL[4:0] value) to different active DMA channels (LPDMA_CxCR.EN = 1 and LPDMA_CxTR2.SWREQ = 0 for these channels). DMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant LPDMA1_LPDMA_C0TR2_SWREQ                         \ software request This bit is internally taken into account when LPDMA_CxCR.EN is asserted.
$00000800 constant LPDMA1_LPDMA_C0TR2_BREQ                          \ block hardware request If the channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$0000c000 constant LPDMA1_LPDMA_C0TR2_TRIGM                         \ trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (LPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 0b00 or 0b11, these TRIGM[1:0] bits are ignored. Else, a DMA transfer is conditioned by at least one trigger hit: The LPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 0b01 or respectively TRIGPOL[1:0] = 0b10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[4:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the LPDMA_CxTR2 with a new value for any of TRIGSEL[4:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized, and a trigger overrun flag is reported (LPDMA_CxSR.TOF = 1), an interrupt is generated if enabled (LPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun.
$001f0000 constant LPDMA1_LPDMA_C0TR2_TRIGSEL                       \ trigger event input selection These bits select the trigger event input of the LPDMA transfer (as per Programmed LPDMA1 trigger), with an active trigger event if TRIGPOL[1:0] = 00.
$03000000 constant LPDMA1_LPDMA_C0TR2_TRIGPOL                       \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[4:0].
$c0000000 constant LPDMA1_LPDMA_C0TR2_TCEM                          \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief LPDMA channel 0 block register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant LPDMA1_LPDMA_C0BR1_BNDT                          \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if LPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if LPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all LPDMA_CxLLR.Uxx = 0 and if LPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if LPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.


\
\ @brief LPDMA channel 0 source address register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant LPDMA1_LPDMA_C0SAR_SA                            \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (LPDMA_CxTR1.SINC), this field is either kept fixed or incremented by the data width (LPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by LPDMA from the memory, provided the LLI is set with LPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[32:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief LPDMA channel 0 destination address register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant LPDMA1_LPDMA_C0DAR_DA                            \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (LPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (LPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by DMA from the memory, provided the LLI is set with LPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination single (DA[2:0] versus LPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief LPDMA channel 0 linked-list address register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000fffc constant LPDMA1_LPDMA_C0LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file (LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant LPDMA1_LPDMA_C0LLR_ULL                           \ Update LPDMA_CxLLR register from memory This bit is used to control the update of the LPDMA_CxLLR register from the memory during the link transfer.
$08000000 constant LPDMA1_LPDMA_C0LLR_UDA                           \ Update LPDMA_CxDAR register from memory This bit is used to control the update of the LPDMA_CxDAR register from the memory during the link transfer.
$10000000 constant LPDMA1_LPDMA_C0LLR_USA                           \ update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer.
$20000000 constant LPDMA1_LPDMA_C0LLR_UB1                           \ Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer.
$40000000 constant LPDMA1_LPDMA_C0LLR_UT2                           \ Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer.
$80000000 constant LPDMA1_LPDMA_C0LLR_UT1                           \ Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer.


\
\ @brief LPDMA channel 1 linked-list base address register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$ffff0000 constant LPDMA1_LPDMA_C1LBAR_LBA                          \ linked-list base address of LPDMA channel x


\
\ @brief LPDMA channel 1 flag clear register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000100 constant LPDMA1_LPDMA_C1FCR_TCF                           \ transfer complete flag clear
$00000200 constant LPDMA1_LPDMA_C1FCR_HTF                           \ half transfer flag clear
$00000400 constant LPDMA1_LPDMA_C1FCR_DTEF                          \ data transfer error flag clear
$00000800 constant LPDMA1_LPDMA_C1FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant LPDMA1_LPDMA_C1FCR_USEF                          \ user setting error flag clear
$00002000 constant LPDMA1_LPDMA_C1FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant LPDMA1_LPDMA_C1FCR_TOF                           \ trigger overrun flag clear


\
\ @brief LPDMA channel 1 status register
\ Address offset: 0xE0
\ Reset value: 0x00000001
\

$00000001 constant LPDMA1_LPDMA_C1SR_IDLEF                          \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (LPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant LPDMA1_LPDMA_C1SR_TCF                            \ transfer complete flag A transfer complete event is a block transfer complete or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode LPDMA_CxTR2.TCEM[1:0].
$00000200 constant LPDMA1_LPDMA_C1SR_HTF                            \ half transfer flag An half transfer event is an half block transfer that occurs when half of the bytes of the source block size (rounded-up integer of LPDMA_CxBR1.BNDT[15:0] / 2) has been transferred to the destination.
$00000400 constant LPDMA1_LPDMA_C1SR_DTEF                           \ data transfer error flag
$00000800 constant LPDMA1_LPDMA_C1SR_ULEF                           \ update link transfer error flag
$00001000 constant LPDMA1_LPDMA_C1SR_USEF                           \ user setting error flag
$00002000 constant LPDMA1_LPDMA_C1SR_SUSPF                          \ completed suspension flag
$00004000 constant LPDMA1_LPDMA_C1SR_TOF                            \ trigger overrun flag clear


\
\ @brief LPDMA channel 1 control register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000001 constant LPDMA1_LPDMA_C1CR_EN                             \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant LPDMA1_LPDMA_C1CR_RESET                          \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (LPDMA_CxSR.SUSPF = 1 and LPDMA_CxSR.IDLEF = LPDMA_CxCR.EN = 1) - channel in disabled state (LPDMA_CxSR.IDLEF = 1 and LPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant LPDMA1_LPDMA_C1CR_SUSP                           \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in sequence.
$00000100 constant LPDMA1_LPDMA_C1CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant LPDMA1_LPDMA_C1CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant LPDMA1_LPDMA_C1CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant LPDMA1_LPDMA_C1CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant LPDMA1_LPDMA_C1CR_USEIE                          \ user setting error interrupt enable
$00002000 constant LPDMA1_LPDMA_C1CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant LPDMA1_LPDMA_C1CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant LPDMA1_LPDMA_C1CR_LSM                            \ Link step mode First the block transfer is executed as defined by the current internal register file until LPDMA_CxBR1.BNDT[15:0 ] =0). Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant LPDMA1_LPDMA_C1CR_PRIO                           \ priority level of the channel x LPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief LPDMA channel 1 transfer register 1
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000003 constant LPDMA1_LPDMA_C1TR1_SDW_LOG2                      \ binary logarithm of the source data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. a source block size must be a multiple of the source data width (LPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address LPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant LPDMA1_LPDMA_C1TR1_SINC                          \ source incrementing single The source address, pointed by LPDMA_CxSAR, is kept constant after a single transfer or is incremented by the offset value corresponding to a contiguous data after a single transfer.
$00000800 constant LPDMA1_LPDMA_C1TR1_PAM                           \ padding/alignment mode If DDW_LOG2[1:0]=SDW_LOG2[1:0]: if the data width of a single destination transfer is equal to the data width of a single source transfer, this bit is ignored. Else: Case 1: If destination data width > source data width Case 2: If destination data width < source data width
$00008000 constant LPDMA1_LPDMA_C1TR1_SSEC                          \ security attribute of the LPDMA transfer from the source If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx =1 . A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer from the source is non-secure.
$00030000 constant LPDMA1_LPDMA_C1TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination single transfer must have an aligned address with its data width (start address LPDMA_CxDAR[2:0] versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and none transfer is issued.
$00080000 constant LPDMA1_LPDMA_C1TR1_DINC                          \ destination incrementing single The destination address, pointed by LPDMA_CxDAR, is kept constant after a single transfer, or is incremented by the offset value corresponding to a contiguous data after a single transfer.
$80000000 constant LPDMA1_LPDMA_C1TR1_DSEC                          \ security attribute of the LPDMA transfer to the destination If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx = 1. A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer to the destination is non-secure.


\
\ @brief LPDMA channel 1 transfer register 2
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0000001f constant LPDMA1_LPDMA_C1TR2_REQSEL                        \ DMA hardware request selection These bits are ignored if channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per request. Note: The user must not assign a same input hardware request (same REQSEL[4:0] value) to different active DMA channels (LPDMA_CxCR.EN = 1 and LPDMA_CxTR2.SWREQ = 0 for these channels). DMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant LPDMA1_LPDMA_C1TR2_SWREQ                         \ software request This bit is internally taken into account when LPDMA_CxCR.EN is asserted.
$00000800 constant LPDMA1_LPDMA_C1TR2_BREQ                          \ block hardware request If the channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$0000c000 constant LPDMA1_LPDMA_C1TR2_TRIGM                         \ trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (LPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 0b00 or 0b11, these TRIGM[1:0] bits are ignored. Else, a DMA transfer is conditioned by at least one trigger hit: The LPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 0b01 or respectively TRIGPOL[1:0] = 0b10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[4:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the LPDMA_CxTR2 with a new value for any of TRIGSEL[4:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized, and a trigger overrun flag is reported (LPDMA_CxSR.TOF = 1), an interrupt is generated if enabled (LPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun.
$001f0000 constant LPDMA1_LPDMA_C1TR2_TRIGSEL                       \ trigger event input selection These bits select the trigger event input of the LPDMA transfer (as per Programmed LPDMA1 trigger), with an active trigger event if TRIGPOL[1:0] = 00.
$03000000 constant LPDMA1_LPDMA_C1TR2_TRIGPOL                       \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[4:0].
$c0000000 constant LPDMA1_LPDMA_C1TR2_TCEM                          \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief LPDMA channel 1 block register 1
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant LPDMA1_LPDMA_C1BR1_BNDT                          \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if LPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if LPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all LPDMA_CxLLR.Uxx = 0 and if LPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if LPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.


\
\ @brief LPDMA channel 1 source address register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant LPDMA1_LPDMA_C1SAR_SA                            \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (LPDMA_CxTR1.SINC), this field is either kept fixed or incremented by the data width (LPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by LPDMA from the memory, provided the LLI is set with LPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[32:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief LPDMA channel 1 destination address register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant LPDMA1_LPDMA_C1DAR_DA                            \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (LPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (LPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by DMA from the memory, provided the LLI is set with LPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination single (DA[2:0] versus LPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief LPDMA channel 1 linked-list address register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$0000fffc constant LPDMA1_LPDMA_C1LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file (LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant LPDMA1_LPDMA_C1LLR_ULL                           \ Update LPDMA_CxLLR register from memory This bit is used to control the update of the LPDMA_CxLLR register from the memory during the link transfer.
$08000000 constant LPDMA1_LPDMA_C1LLR_UDA                           \ Update LPDMA_CxDAR register from memory This bit is used to control the update of the LPDMA_CxDAR register from the memory during the link transfer.
$10000000 constant LPDMA1_LPDMA_C1LLR_USA                           \ update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer.
$20000000 constant LPDMA1_LPDMA_C1LLR_UB1                           \ Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer.
$40000000 constant LPDMA1_LPDMA_C1LLR_UT2                           \ Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer.
$80000000 constant LPDMA1_LPDMA_C1LLR_UT1                           \ Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer.


\
\ @brief LPDMA channel 2 linked-list base address register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$ffff0000 constant LPDMA1_LPDMA_C2LBAR_LBA                          \ linked-list base address of LPDMA channel x


\
\ @brief LPDMA channel 2 flag clear register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000100 constant LPDMA1_LPDMA_C2FCR_TCF                           \ transfer complete flag clear
$00000200 constant LPDMA1_LPDMA_C2FCR_HTF                           \ half transfer flag clear
$00000400 constant LPDMA1_LPDMA_C2FCR_DTEF                          \ data transfer error flag clear
$00000800 constant LPDMA1_LPDMA_C2FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant LPDMA1_LPDMA_C2FCR_USEF                          \ user setting error flag clear
$00002000 constant LPDMA1_LPDMA_C2FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant LPDMA1_LPDMA_C2FCR_TOF                           \ trigger overrun flag clear


\
\ @brief LPDMA channel 2 status register
\ Address offset: 0x160
\ Reset value: 0x00000001
\

$00000001 constant LPDMA1_LPDMA_C2SR_IDLEF                          \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (LPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant LPDMA1_LPDMA_C2SR_TCF                            \ transfer complete flag A transfer complete event is a block transfer complete or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode LPDMA_CxTR2.TCEM[1:0].
$00000200 constant LPDMA1_LPDMA_C2SR_HTF                            \ half transfer flag An half transfer event is an half block transfer that occurs when half of the bytes of the source block size (rounded-up integer of LPDMA_CxBR1.BNDT[15:0] / 2) has been transferred to the destination.
$00000400 constant LPDMA1_LPDMA_C2SR_DTEF                           \ data transfer error flag
$00000800 constant LPDMA1_LPDMA_C2SR_ULEF                           \ update link transfer error flag
$00001000 constant LPDMA1_LPDMA_C2SR_USEF                           \ user setting error flag
$00002000 constant LPDMA1_LPDMA_C2SR_SUSPF                          \ completed suspension flag
$00004000 constant LPDMA1_LPDMA_C2SR_TOF                            \ trigger overrun flag clear


\
\ @brief LPDMA channel 2 control register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000001 constant LPDMA1_LPDMA_C2CR_EN                             \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant LPDMA1_LPDMA_C2CR_RESET                          \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (LPDMA_CxSR.SUSPF = 1 and LPDMA_CxSR.IDLEF = LPDMA_CxCR.EN = 1) - channel in disabled state (LPDMA_CxSR.IDLEF = 1 and LPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant LPDMA1_LPDMA_C2CR_SUSP                           \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in sequence.
$00000100 constant LPDMA1_LPDMA_C2CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant LPDMA1_LPDMA_C2CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant LPDMA1_LPDMA_C2CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant LPDMA1_LPDMA_C2CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant LPDMA1_LPDMA_C2CR_USEIE                          \ user setting error interrupt enable
$00002000 constant LPDMA1_LPDMA_C2CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant LPDMA1_LPDMA_C2CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant LPDMA1_LPDMA_C2CR_LSM                            \ Link step mode First the block transfer is executed as defined by the current internal register file until LPDMA_CxBR1.BNDT[15:0 ] =0). Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant LPDMA1_LPDMA_C2CR_PRIO                           \ priority level of the channel x LPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief LPDMA channel 2 transfer register 1
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000003 constant LPDMA1_LPDMA_C2TR1_SDW_LOG2                      \ binary logarithm of the source data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. a source block size must be a multiple of the source data width (LPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address LPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant LPDMA1_LPDMA_C2TR1_SINC                          \ source incrementing single The source address, pointed by LPDMA_CxSAR, is kept constant after a single transfer or is incremented by the offset value corresponding to a contiguous data after a single transfer.
$00000800 constant LPDMA1_LPDMA_C2TR1_PAM                           \ padding/alignment mode If DDW_LOG2[1:0]=SDW_LOG2[1:0]: if the data width of a single destination transfer is equal to the data width of a single source transfer, this bit is ignored. Else: Case 1: If destination data width > source data width Case 2: If destination data width < source data width
$00008000 constant LPDMA1_LPDMA_C2TR1_SSEC                          \ security attribute of the LPDMA transfer from the source If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx =1 . A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer from the source is non-secure.
$00030000 constant LPDMA1_LPDMA_C2TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination single transfer must have an aligned address with its data width (start address LPDMA_CxDAR[2:0] versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and none transfer is issued.
$00080000 constant LPDMA1_LPDMA_C2TR1_DINC                          \ destination incrementing single The destination address, pointed by LPDMA_CxDAR, is kept constant after a single transfer, or is incremented by the offset value corresponding to a contiguous data after a single transfer.
$80000000 constant LPDMA1_LPDMA_C2TR1_DSEC                          \ security attribute of the LPDMA transfer to the destination If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx = 1. A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer to the destination is non-secure.


\
\ @brief LPDMA channel 2 transfer register 2
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$0000001f constant LPDMA1_LPDMA_C2TR2_REQSEL                        \ DMA hardware request selection These bits are ignored if channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per request. Note: The user must not assign a same input hardware request (same REQSEL[4:0] value) to different active DMA channels (LPDMA_CxCR.EN = 1 and LPDMA_CxTR2.SWREQ = 0 for these channels). DMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant LPDMA1_LPDMA_C2TR2_SWREQ                         \ software request This bit is internally taken into account when LPDMA_CxCR.EN is asserted.
$00000800 constant LPDMA1_LPDMA_C2TR2_BREQ                          \ block hardware request If the channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$0000c000 constant LPDMA1_LPDMA_C2TR2_TRIGM                         \ trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (LPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 0b00 or 0b11, these TRIGM[1:0] bits are ignored. Else, a DMA transfer is conditioned by at least one trigger hit: The LPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 0b01 or respectively TRIGPOL[1:0] = 0b10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[4:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the LPDMA_CxTR2 with a new value for any of TRIGSEL[4:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized, and a trigger overrun flag is reported (LPDMA_CxSR.TOF = 1), an interrupt is generated if enabled (LPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun.
$001f0000 constant LPDMA1_LPDMA_C2TR2_TRIGSEL                       \ trigger event input selection These bits select the trigger event input of the LPDMA transfer (as per Programmed LPDMA1 trigger), with an active trigger event if TRIGPOL[1:0] = 00.
$03000000 constant LPDMA1_LPDMA_C2TR2_TRIGPOL                       \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[4:0].
$c0000000 constant LPDMA1_LPDMA_C2TR2_TCEM                          \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief LPDMA channel 2 block register 1
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$0000ffff constant LPDMA1_LPDMA_C2BR1_BNDT                          \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if LPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if LPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all LPDMA_CxLLR.Uxx = 0 and if LPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if LPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.


\
\ @brief LPDMA channel 2 source address register
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant LPDMA1_LPDMA_C2SAR_SA                            \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (LPDMA_CxTR1.SINC), this field is either kept fixed or incremented by the data width (LPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by LPDMA from the memory, provided the LLI is set with LPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[32:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief LPDMA channel 2 destination address register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant LPDMA1_LPDMA_C2DAR_DA                            \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (LPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (LPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by DMA from the memory, provided the LLI is set with LPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination single (DA[2:0] versus LPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief LPDMA channel 2 linked-list address register
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$0000fffc constant LPDMA1_LPDMA_C2LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file (LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant LPDMA1_LPDMA_C2LLR_ULL                           \ Update LPDMA_CxLLR register from memory This bit is used to control the update of the LPDMA_CxLLR register from the memory during the link transfer.
$08000000 constant LPDMA1_LPDMA_C2LLR_UDA                           \ Update LPDMA_CxDAR register from memory This bit is used to control the update of the LPDMA_CxDAR register from the memory during the link transfer.
$10000000 constant LPDMA1_LPDMA_C2LLR_USA                           \ update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer.
$20000000 constant LPDMA1_LPDMA_C2LLR_UB1                           \ Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer.
$40000000 constant LPDMA1_LPDMA_C2LLR_UT2                           \ Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer.
$80000000 constant LPDMA1_LPDMA_C2LLR_UT1                           \ Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer.


\
\ @brief LPDMA channel 3 linked-list base address register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$ffff0000 constant LPDMA1_LPDMA_C3LBAR_LBA                          \ linked-list base address of LPDMA channel x


\
\ @brief LPDMA channel 3 flag clear register
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$00000100 constant LPDMA1_LPDMA_C3FCR_TCF                           \ transfer complete flag clear
$00000200 constant LPDMA1_LPDMA_C3FCR_HTF                           \ half transfer flag clear
$00000400 constant LPDMA1_LPDMA_C3FCR_DTEF                          \ data transfer error flag clear
$00000800 constant LPDMA1_LPDMA_C3FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant LPDMA1_LPDMA_C3FCR_USEF                          \ user setting error flag clear
$00002000 constant LPDMA1_LPDMA_C3FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant LPDMA1_LPDMA_C3FCR_TOF                           \ trigger overrun flag clear


\
\ @brief LPDMA channel 3 status register
\ Address offset: 0x1E0
\ Reset value: 0x00000001
\

$00000001 constant LPDMA1_LPDMA_C3SR_IDLEF                          \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (LPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant LPDMA1_LPDMA_C3SR_TCF                            \ transfer complete flag A transfer complete event is a block transfer complete or a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode LPDMA_CxTR2.TCEM[1:0].
$00000200 constant LPDMA1_LPDMA_C3SR_HTF                            \ half transfer flag An half transfer event is an half block transfer that occurs when half of the bytes of the source block size (rounded-up integer of LPDMA_CxBR1.BNDT[15:0] / 2) has been transferred to the destination.
$00000400 constant LPDMA1_LPDMA_C3SR_DTEF                           \ data transfer error flag
$00000800 constant LPDMA1_LPDMA_C3SR_ULEF                           \ update link transfer error flag
$00001000 constant LPDMA1_LPDMA_C3SR_USEF                           \ user setting error flag
$00002000 constant LPDMA1_LPDMA_C3SR_SUSPF                          \ completed suspension flag
$00004000 constant LPDMA1_LPDMA_C3SR_TOF                            \ trigger overrun flag clear


\
\ @brief LPDMA channel 3 control register
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$00000001 constant LPDMA1_LPDMA_C3CR_EN                             \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant LPDMA1_LPDMA_C3CR_RESET                          \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (LPDMA_CxSR.SUSPF = 1 and LPDMA_CxSR.IDLEF = LPDMA_CxCR.EN = 1) - channel in disabled state (LPDMA_CxSR.IDLEF = 1 and LPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (LPDMA_CxBR1, LPDMA_CxSAR and LPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant LPDMA1_LPDMA_C3CR_SUSP                           \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an on-going DMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in sequence.
$00000100 constant LPDMA1_LPDMA_C3CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant LPDMA1_LPDMA_C3CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant LPDMA1_LPDMA_C3CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant LPDMA1_LPDMA_C3CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant LPDMA1_LPDMA_C3CR_USEIE                          \ user setting error interrupt enable
$00002000 constant LPDMA1_LPDMA_C3CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant LPDMA1_LPDMA_C3CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant LPDMA1_LPDMA_C3CR_LSM                            \ Link step mode First the block transfer is executed as defined by the current internal register file until LPDMA_CxBR1.BNDT[15:0 ] =0). Secondly the next linked-list data structure is conditionally uploaded from memory as defined by LPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant LPDMA1_LPDMA_C3CR_PRIO                           \ priority level of the channel x LPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief LPDMA channel 3 transfer register 1
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000003 constant LPDMA1_LPDMA_C3TR1_SDW_LOG2                      \ binary logarithm of the source data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. a source block size must be a multiple of the source data width (LPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source single transfer must have an aligned address with its data width (start address LPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant LPDMA1_LPDMA_C3TR1_SINC                          \ source incrementing single The source address, pointed by LPDMA_CxSAR, is kept constant after a single transfer or is incremented by the offset value corresponding to a contiguous data after a single transfer.
$00000800 constant LPDMA1_LPDMA_C3TR1_PAM                           \ padding/alignment mode If DDW_LOG2[1:0]=SDW_LOG2[1:0]: if the data width of a single destination transfer is equal to the data width of a single source transfer, this bit is ignored. Else: Case 1: If destination data width > source data width Case 2: If destination data width < source data width
$00008000 constant LPDMA1_LPDMA_C3TR1_SSEC                          \ security attribute of the LPDMA transfer from the source If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx =1 . A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer from the source is non-secure.
$00030000 constant LPDMA1_LPDMA_C3TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a single in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination single transfer must have an aligned address with its data width (start address LPDMA_CxDAR[2:0] versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and none transfer is issued.
$00080000 constant LPDMA1_LPDMA_C3TR1_DINC                          \ destination incrementing single The destination address, pointed by LPDMA_CxDAR, is kept constant after a single transfer, or is incremented by the offset value corresponding to a contiguous data after a single transfer.
$80000000 constant LPDMA1_LPDMA_C3TR1_DSEC                          \ security attribute of the LPDMA transfer to the destination If LPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when LPDMA_SECCFGR.SECx = 1. A secure write is ignored when LPDMA_SECCFGR.SECx = 0. When LPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the LPDMA transfer to the destination is non-secure.


\
\ @brief LPDMA channel 3 transfer register 2
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$0000001f constant LPDMA1_LPDMA_C3TR2_REQSEL                        \ DMA hardware request selection These bits are ignored if channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per request. Note: The user must not assign a same input hardware request (same REQSEL[4:0] value) to different active DMA channels (LPDMA_CxCR.EN = 1 and LPDMA_CxTR2.SWREQ = 0 for these channels). DMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant LPDMA1_LPDMA_C3TR2_SWREQ                         \ software request This bit is internally taken into account when LPDMA_CxCR.EN is asserted.
$00000800 constant LPDMA1_LPDMA_C3TR2_BREQ                          \ block hardware request If the channel x is activated (LPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$0000c000 constant LPDMA1_LPDMA_C3TR2_TRIGM                         \ trigger mode These bits define the transfer granularity for its conditioning by the trigger. If the channel x is enabled (LPDMA_CxCR.EN asserted) with TRIGPOL[1:0] = 0b00 or 0b11, these TRIGM[1:0] bits are ignored. Else, a DMA transfer is conditioned by at least one trigger hit: The LPDMA monitoring of a trigger for channel x is started when the channel is enabled/loaded with a new active trigger configuration: rising or falling edge on a selected trigger (TRIGPOL[1:0] = 0b01 or respectively TRIGPOL[1:0] = 0b10). The monitoring of this trigger is kept active during the triggered and uncompleted (data or link) transfer; and if a new trigger is detected then, this hit is internally memorized to grant the next transfer, as long as the defined rising or falling edge is not modified, and the TRIGSEL[4:0] is not modified, and the channel is enabled. Transferring a next LLIn+1 that updates the LPDMA_CxTR2 with a new value for any of TRIGSEL[4:0] or TRIGPOL[1:0], resets the monitoring, trashing the memorized hit of the formerly defined LLIn trigger. After a first new trigger hitn+1 is memorized, if another second trigger hitn+2 is detected and if the hitn triggered transfer is still not completed, hitn+2 is lost and not memorized, and a trigger overrun flag is reported (LPDMA_CxSR.TOF = 1), an interrupt is generated if enabled (LPDMA_CxCR.TOIE = 1). The channel is not automatically disabled by hardware due to a trigger overrun.
$001f0000 constant LPDMA1_LPDMA_C3TR2_TRIGSEL                       \ trigger event input selection These bits select the trigger event input of the LPDMA transfer (as per Programmed LPDMA1 trigger), with an active trigger event if TRIGPOL[1:0] = 00.
$03000000 constant LPDMA1_LPDMA_C3TR2_TRIGPOL                       \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[4:0].
$c0000000 constant LPDMA1_LPDMA_C3TR2_TCEM                          \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with LPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief LPDMA channel 3 block register 1
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$0000ffff constant LPDMA1_LPDMA_C3BR1_BNDT                          \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if LPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if LPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all LPDMA_CxLLR.Uxx = 0 and if LPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if LPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued.


\
\ @brief LPDMA channel 3 source address register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant LPDMA1_LPDMA_C3SAR_SA                            \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (LPDMA_CxTR1.SINC), this field is either kept fixed or incremented by the data width (LPDMA_CxTR1.SDW_LOG2[1:0]) after each single source data, reflecting the next address from which data is read. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by LPDMA from the memory, provided the LLI is set with LPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source single (SA[32:0] versus LPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief LPDMA channel 3 destination address register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant LPDMA1_LPDMA_C3DAR_DA                            \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (LPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (LPDMA_CxTR1.DDW_LOG2[21:0]) after each single destination data, reflecting the next address from which data is written. In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by DMA from the memory, provided the LLI is set with LPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination single (DA[2:0] versus LPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief LPDMA channel 3 linked-list address register
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$0000fffc constant LPDMA1_LPDMA_C3LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list DMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list DMA internal register file (LPDMA_CxCTR1, LPDMA_CxTR2, LPDMA_CxBR1, LPDMA_CxSAR, LPDMA_CxDAR and LPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant LPDMA1_LPDMA_C3LLR_ULL                           \ Update LPDMA_CxLLR register from memory This bit is used to control the update of the LPDMA_CxLLR register from the memory during the link transfer.
$08000000 constant LPDMA1_LPDMA_C3LLR_UDA                           \ Update LPDMA_CxDAR register from memory This bit is used to control the update of the LPDMA_CxDAR register from the memory during the link transfer.
$10000000 constant LPDMA1_LPDMA_C3LLR_USA                           \ update LPDMA_CxSAR from memory This bit controls the update of the LPDMA_CxSAR register from the memory during the link transfer.
$20000000 constant LPDMA1_LPDMA_C3LLR_UB1                           \ Update LPDMA_CxBR1 from memory This bit controls the update of the LPDMA_CxBR1 register from the memory during the link transfer.
$40000000 constant LPDMA1_LPDMA_C3LLR_UT2                           \ Update LPDMA_CxTR2 from memory This bit controls the update of the LPDMA_CxTR2 register from the memory during the link transfer.
$80000000 constant LPDMA1_LPDMA_C3LLR_UT1                           \ Update LPDMA_CxTR1 from memory This bit controls the update of the LPDMA_CxTR1 register from the memory during the link transfer.


\
\ @brief LPDMA1
\
$46025000 constant LPDMA1_LPDMA_SECCFGR  \ offset: 0x00 : LPDMA secure configuration register
$46025004 constant LPDMA1_LPDMA_PRIVCFGR  \ offset: 0x04 : LPDMA privileged configuration register
$46025008 constant LPDMA1_LPDMA_RCFGLOCKR  \ offset: 0x08 : LPDMA configuration lock register
$4602500c constant LPDMA1_LPDMA_MISR  \ offset: 0x0C : LPDMA non-secure masked interrupt status register
$46025010 constant LPDMA1_LPDMA_SMISR  \ offset: 0x10 : LPDMA secure masked interrupt status register
$46025050 constant LPDMA1_LPDMA_C0LBAR  \ offset: 0x50 : LPDMA channel 0 linked-list base address register
$4602505c constant LPDMA1_LPDMA_C0FCR  \ offset: 0x5C : LPDMA channel 0 flag clear register
$46025060 constant LPDMA1_LPDMA_C0SR  \ offset: 0x60 : LPDMA channel 0 status register
$46025064 constant LPDMA1_LPDMA_C0CR  \ offset: 0x64 : LPDMA channel 0 control register
$46025090 constant LPDMA1_LPDMA_C0TR1  \ offset: 0x90 : LPDMA channel 0 transfer register 1
$46025094 constant LPDMA1_LPDMA_C0TR2  \ offset: 0x94 : LPDMA channel 0 transfer register 2
$46025098 constant LPDMA1_LPDMA_C0BR1  \ offset: 0x98 : LPDMA channel 0 block register 1
$4602509c constant LPDMA1_LPDMA_C0SAR  \ offset: 0x9C : LPDMA channel 0 source address register
$460250a0 constant LPDMA1_LPDMA_C0DAR  \ offset: 0xA0 : LPDMA channel 0 destination address register
$460250cc constant LPDMA1_LPDMA_C0LLR  \ offset: 0xCC : LPDMA channel 0 linked-list address register
$460250d0 constant LPDMA1_LPDMA_C1LBAR  \ offset: 0xD0 : LPDMA channel 1 linked-list base address register
$460250dc constant LPDMA1_LPDMA_C1FCR  \ offset: 0xDC : LPDMA channel 1 flag clear register
$460250e0 constant LPDMA1_LPDMA_C1SR  \ offset: 0xE0 : LPDMA channel 1 status register
$460250e4 constant LPDMA1_LPDMA_C1CR  \ offset: 0xE4 : LPDMA channel 1 control register
$46025110 constant LPDMA1_LPDMA_C1TR1  \ offset: 0x110 : LPDMA channel 1 transfer register 1
$46025114 constant LPDMA1_LPDMA_C1TR2  \ offset: 0x114 : LPDMA channel 1 transfer register 2
$46025118 constant LPDMA1_LPDMA_C1BR1  \ offset: 0x118 : LPDMA channel 1 block register 1
$4602511c constant LPDMA1_LPDMA_C1SAR  \ offset: 0x11C : LPDMA channel 1 source address register
$46025120 constant LPDMA1_LPDMA_C1DAR  \ offset: 0x120 : LPDMA channel 1 destination address register
$4602514c constant LPDMA1_LPDMA_C1LLR  \ offset: 0x14C : LPDMA channel 1 linked-list address register
$46025150 constant LPDMA1_LPDMA_C2LBAR  \ offset: 0x150 : LPDMA channel 2 linked-list base address register
$4602515c constant LPDMA1_LPDMA_C2FCR  \ offset: 0x15C : LPDMA channel 2 flag clear register
$46025160 constant LPDMA1_LPDMA_C2SR  \ offset: 0x160 : LPDMA channel 2 status register
$46025164 constant LPDMA1_LPDMA_C2CR  \ offset: 0x164 : LPDMA channel 2 control register
$46025190 constant LPDMA1_LPDMA_C2TR1  \ offset: 0x190 : LPDMA channel 2 transfer register 1
$46025194 constant LPDMA1_LPDMA_C2TR2  \ offset: 0x194 : LPDMA channel 2 transfer register 2
$46025198 constant LPDMA1_LPDMA_C2BR1  \ offset: 0x198 : LPDMA channel 2 block register 1
$4602519c constant LPDMA1_LPDMA_C2SAR  \ offset: 0x19C : LPDMA channel 2 source address register
$460251a0 constant LPDMA1_LPDMA_C2DAR  \ offset: 0x1A0 : LPDMA channel 2 destination address register
$460251cc constant LPDMA1_LPDMA_C2LLR  \ offset: 0x1CC : LPDMA channel 2 linked-list address register
$460251d0 constant LPDMA1_LPDMA_C3LBAR  \ offset: 0x1D0 : LPDMA channel 3 linked-list base address register
$460251dc constant LPDMA1_LPDMA_C3FCR  \ offset: 0x1DC : LPDMA channel 3 flag clear register
$460251e0 constant LPDMA1_LPDMA_C3SR  \ offset: 0x1E0 : LPDMA channel 3 status register
$460251e4 constant LPDMA1_LPDMA_C3CR  \ offset: 0x1E4 : LPDMA channel 3 control register
$46025210 constant LPDMA1_LPDMA_C3TR1  \ offset: 0x210 : LPDMA channel 3 transfer register 1
$46025214 constant LPDMA1_LPDMA_C3TR2  \ offset: 0x214 : LPDMA channel 3 transfer register 2
$46025218 constant LPDMA1_LPDMA_C3BR1  \ offset: 0x218 : LPDMA channel 3 block register 1
$4602521c constant LPDMA1_LPDMA_C3SAR  \ offset: 0x21C : LPDMA channel 3 source address register
$46025220 constant LPDMA1_LPDMA_C3DAR  \ offset: 0x220 : LPDMA channel 3 destination address register
$4602524c constant LPDMA1_LPDMA_C3LLR  \ offset: 0x24C : LPDMA channel 3 linked-list address register

