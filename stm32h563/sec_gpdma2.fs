\
\ @file sec_gpdma2.fs
\ @brief General purpose direct memory access controller
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

$00000001 constant SEC_GPDMA2_GPDMA_SECCFGR_SEC0                    \ secure state of channel x (x = 7 to 0)
$00000002 constant SEC_GPDMA2_GPDMA_SECCFGR_SEC1                    \ secure state of channel x (x = 7 to 0)
$00000004 constant SEC_GPDMA2_GPDMA_SECCFGR_SEC2                    \ secure state of channel x (x = 7 to 0)
$00000008 constant SEC_GPDMA2_GPDMA_SECCFGR_SEC3                    \ secure state of channel x (x = 7 to 0)
$00000010 constant SEC_GPDMA2_GPDMA_SECCFGR_SEC4                    \ secure state of channel x (x = 7 to 0)
$00000020 constant SEC_GPDMA2_GPDMA_SECCFGR_SEC5                    \ secure state of channel x (x = 7 to 0)
$00000040 constant SEC_GPDMA2_GPDMA_SECCFGR_SEC6                    \ secure state of channel x (x = 7 to 0)
$00000080 constant SEC_GPDMA2_GPDMA_SECCFGR_SEC7                    \ secure state of channel x (x = 7 to 0)


\
\ @brief GPDMA privileged configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_PRIVCFGR_PRIV0                  \ privileged state of channel x (x = 7 to 0)
$00000002 constant SEC_GPDMA2_GPDMA_PRIVCFGR_PRIV1                  \ privileged state of channel x (x = 7 to 0)
$00000004 constant SEC_GPDMA2_GPDMA_PRIVCFGR_PRIV2                  \ privileged state of channel x (x = 7 to 0)
$00000008 constant SEC_GPDMA2_GPDMA_PRIVCFGR_PRIV3                  \ privileged state of channel x (x = 7 to 0)
$00000010 constant SEC_GPDMA2_GPDMA_PRIVCFGR_PRIV4                  \ privileged state of channel x (x = 7 to 0)
$00000020 constant SEC_GPDMA2_GPDMA_PRIVCFGR_PRIV5                  \ privileged state of channel x (x = 7 to 0)
$00000040 constant SEC_GPDMA2_GPDMA_PRIVCFGR_PRIV6                  \ privileged state of channel x (x = 7 to 0)
$00000080 constant SEC_GPDMA2_GPDMA_PRIVCFGR_PRIV7                  \ privileged state of channel x (x = 7 to 0)


\
\ @brief GPDMA configuration lock register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_RCFGLOCKR_LOCK0                 \ lock the configuration of GPDMA_SECCFGR.SECx and GPDMA_PRIVCFGR.PRIVx, until a global GPDMA reset (x = 7 to 0) This bit is cleared after reset and, once set, it cannot be reset until a global GPDMA reset.
$00000002 constant SEC_GPDMA2_GPDMA_RCFGLOCKR_LOCK1                 \ lock the configuration of GPDMA_SECCFGR.SECx and GPDMA_PRIVCFGR.PRIVx, until a global GPDMA reset (x = 7 to 0) This bit is cleared after reset and, once set, it cannot be reset until a global GPDMA reset.
$00000004 constant SEC_GPDMA2_GPDMA_RCFGLOCKR_LOCK2                 \ lock the configuration of GPDMA_SECCFGR.SECx and GPDMA_PRIVCFGR.PRIVx, until a global GPDMA reset (x = 7 to 0) This bit is cleared after reset and, once set, it cannot be reset until a global GPDMA reset.
$00000008 constant SEC_GPDMA2_GPDMA_RCFGLOCKR_LOCK3                 \ lock the configuration of GPDMA_SECCFGR.SECx and GPDMA_PRIVCFGR.PRIVx, until a global GPDMA reset (x = 7 to 0) This bit is cleared after reset and, once set, it cannot be reset until a global GPDMA reset.
$00000010 constant SEC_GPDMA2_GPDMA_RCFGLOCKR_LOCK4                 \ lock the configuration of GPDMA_SECCFGR.SECx and GPDMA_PRIVCFGR.PRIVx, until a global GPDMA reset (x = 7 to 0) This bit is cleared after reset and, once set, it cannot be reset until a global GPDMA reset.
$00000020 constant SEC_GPDMA2_GPDMA_RCFGLOCKR_LOCK5                 \ lock the configuration of GPDMA_SECCFGR.SECx and GPDMA_PRIVCFGR.PRIVx, until a global GPDMA reset (x = 7 to 0) This bit is cleared after reset and, once set, it cannot be reset until a global GPDMA reset.
$00000040 constant SEC_GPDMA2_GPDMA_RCFGLOCKR_LOCK6                 \ lock the configuration of GPDMA_SECCFGR.SECx and GPDMA_PRIVCFGR.PRIVx, until a global GPDMA reset (x = 7 to 0) This bit is cleared after reset and, once set, it cannot be reset until a global GPDMA reset.
$00000080 constant SEC_GPDMA2_GPDMA_RCFGLOCKR_LOCK7                 \ lock the configuration of GPDMA_SECCFGR.SECx and GPDMA_PRIVCFGR.PRIVx, until a global GPDMA reset (x = 7 to 0) This bit is cleared after reset and, once set, it cannot be reset until a global GPDMA reset.


\
\ @brief GPDMA non-secure masked interrupt status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_MISR_MIS0                       \ masked interrupt status of channel x (x = 7 to 0)
$00000002 constant SEC_GPDMA2_GPDMA_MISR_MIS1                       \ masked interrupt status of channel x (x = 7 to 0)
$00000004 constant SEC_GPDMA2_GPDMA_MISR_MIS2                       \ masked interrupt status of channel x (x = 7 to 0)
$00000008 constant SEC_GPDMA2_GPDMA_MISR_MIS3                       \ masked interrupt status of channel x (x = 7 to 0)
$00000010 constant SEC_GPDMA2_GPDMA_MISR_MIS4                       \ masked interrupt status of channel x (x = 7 to 0)
$00000020 constant SEC_GPDMA2_GPDMA_MISR_MIS5                       \ masked interrupt status of channel x (x = 7 to 0)
$00000040 constant SEC_GPDMA2_GPDMA_MISR_MIS6                       \ masked interrupt status of channel x (x = 7 to 0)
$00000080 constant SEC_GPDMA2_GPDMA_MISR_MIS7                       \ masked interrupt status of channel x (x = 7 to 0)


\
\ @brief GPDMA secure masked interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_SMISR_MIS0                      \ masked interrupt status of the secure channel x (x = 7 to 0)
$00000002 constant SEC_GPDMA2_GPDMA_SMISR_MIS1                      \ masked interrupt status of the secure channel x (x = 7 to 0)
$00000004 constant SEC_GPDMA2_GPDMA_SMISR_MIS2                      \ masked interrupt status of the secure channel x (x = 7 to 0)
$00000008 constant SEC_GPDMA2_GPDMA_SMISR_MIS3                      \ masked interrupt status of the secure channel x (x = 7 to 0)
$00000010 constant SEC_GPDMA2_GPDMA_SMISR_MIS4                      \ masked interrupt status of the secure channel x (x = 7 to 0)
$00000020 constant SEC_GPDMA2_GPDMA_SMISR_MIS5                      \ masked interrupt status of the secure channel x (x = 7 to 0)
$00000040 constant SEC_GPDMA2_GPDMA_SMISR_MIS6                      \ masked interrupt status of the secure channel x (x = 7 to 0)
$00000080 constant SEC_GPDMA2_GPDMA_SMISR_MIS7                      \ masked interrupt status of the secure channel x (x = 7 to 0)


\
\ @brief GPDMA channel 0 linked-list base address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_GPDMA2_GPDMA_C0LBAR_LBA                      \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 0 flag clear register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000100 constant SEC_GPDMA2_GPDMA_C0FCR_TCF                       \ transfer complete flag clear
$00000200 constant SEC_GPDMA2_GPDMA_C0FCR_HTF                       \ half transfer flag clear
$00000400 constant SEC_GPDMA2_GPDMA_C0FCR_DTEF                      \ data transfer error flag clear
$00000800 constant SEC_GPDMA2_GPDMA_C0FCR_ULEF                      \ update link transfer error flag clear
$00001000 constant SEC_GPDMA2_GPDMA_C0FCR_USEF                      \ user setting error flag clear
$00002000 constant SEC_GPDMA2_GPDMA_C0FCR_SUSPF                     \ completed suspension flag clear
$00004000 constant SEC_GPDMA2_GPDMA_C0FCR_TOF                       \ trigger overrun flag clear


\
\ @brief GPDMA channel 0 status register
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant SEC_GPDMA2_GPDMA_C0SR_IDLEF                      \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant SEC_GPDMA2_GPDMA_C0SR_TCF                        \ transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
$00000200 constant SEC_GPDMA2_GPDMA_C0SR_HTF                        \ half transfer flag A half transfer event is either a half block transfer or a half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). A half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. A half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
$00000400 constant SEC_GPDMA2_GPDMA_C0SR_DTEF                       \ data transfer error flag
$00000800 constant SEC_GPDMA2_GPDMA_C0SR_ULEF                       \ update link transfer error flag
$00001000 constant SEC_GPDMA2_GPDMA_C0SR_USEF                       \ user setting error flag
$00002000 constant SEC_GPDMA2_GPDMA_C0SR_SUSPF                      \ completed suspension flag
$00004000 constant SEC_GPDMA2_GPDMA_C0SR_TOF                        \ trigger overrun flag
$00ff0000 constant SEC_GPDMA2_GPDMA_C0SR_FIFOL                      \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).


\
\ @brief GPDMA channel 0 control register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_C0CR_EN                         \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_GPDMA2_GPDMA_C0CR_RESET                      \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant SEC_GPDMA2_GPDMA_C0CR_SUSP                       \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an ongoing GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
$00000100 constant SEC_GPDMA2_GPDMA_C0CR_TCIE                       \ transfer complete interrupt enable
$00000200 constant SEC_GPDMA2_GPDMA_C0CR_HTIE                       \ half transfer complete interrupt enable
$00000400 constant SEC_GPDMA2_GPDMA_C0CR_DTEIE                      \ data transfer error interrupt enable
$00000800 constant SEC_GPDMA2_GPDMA_C0CR_ULEIE                      \ update link transfer error interrupt enable
$00001000 constant SEC_GPDMA2_GPDMA_C0CR_USEIE                      \ user setting error interrupt enable
$00002000 constant SEC_GPDMA2_GPDMA_C0CR_SUSPIE                     \ completed suspension interrupt enable
$00004000 constant SEC_GPDMA2_GPDMA_C0CR_TOIE                       \ trigger overrun interrupt enable
$00010000 constant SEC_GPDMA2_GPDMA_C0CR_LSM                        \ Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant SEC_GPDMA2_GPDMA_C0CR_LAP                        \ linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_GPDMA2_GPDMA_C0CR_PRIO                       \ priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief GPDMA channel 0 transfer register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000003 constant SEC_GPDMA2_GPDMA_C0TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source burst transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant SEC_GPDMA2_GPDMA_C0TR1_SINC                      \ source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant SEC_GPDMA2_GPDMA_C0TR1_SBL_1                     \ source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$00001800 constant SEC_GPDMA2_GPDMA_C0TR1_PAM                       \ padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else, in the following enumerated values, the condition PAM_1 is when destination data width is higher that source data width, and the condition PAM_2 is when destination data width is higher than source data width. 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note: If the transfer from the source peripheral is configured with peripheral flow-control mode (SWREQ = 0 and PFREQ = 1 and DREQ = 0), and if the destination data width the source data width, packing is not supported.
$00002000 constant SEC_GPDMA2_GPDMA_C0TR1_SBX                       \ source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
$00004000 constant SEC_GPDMA2_GPDMA_C0TR1_SAP                       \ source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$00008000 constant SEC_GPDMA2_GPDMA_C0TR1_SSEC                      \ security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
$00030000 constant SEC_GPDMA2_GPDMA_C0TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
$00080000 constant SEC_GPDMA2_GPDMA_C0TR1_DINC                      \ destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant SEC_GPDMA2_GPDMA_C0TR1_DBL_1                     \ destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$04000000 constant SEC_GPDMA2_GPDMA_C0TR1_DBX                       \ destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
$08000000 constant SEC_GPDMA2_GPDMA_C0TR1_DHX                       \ destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
$40000000 constant SEC_GPDMA2_GPDMA_C0TR1_DAP                       \ destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$80000000 constant SEC_GPDMA2_GPDMA_C0TR1_DSEC                      \ security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.


\
\ @brief GPDMA channel 0 transfer register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$000000ff constant SEC_GPDMA2_GPDMA_C0TR2_REQSEL                    \ GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[7:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_GPDMA2_GPDMA_C0TR2_SWREQ                     \ software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
$00000400 constant SEC_GPDMA2_GPDMA_C0TR2_DREQ                      \ destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note: If the channel x is activated (GPDMA_CxCR.EN is asserted) with SWREQ = 0 and PFREQ = 1 (peripheral hardware request with peripheral flow-control mode), any software assertion to this DREQ bit is ignored: in peripheral flow-control mode, only a peripheral-to-memory transfer is supported.
$00000800 constant SEC_GPDMA2_GPDMA_C0TR2_BREQ                      \ Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$00001000 constant SEC_GPDMA2_GPDMA_C0TR2_PFREQ                     \ Hardware request in peripheral flow control mode Important: If a given channel x is not implemented with this feature, this bit is reserved and PFREQ is not present (see for the list of the implemented channels with this feature. If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else: Note: In peripheral flow control mode, there are the following restrictions: - no 2D/repeated block support (GPDMA_CxBR1.BRC[10:0] must be set to 0 if present) - the peripheral must be set as the source of the transfer (DREQ = 0). - data packing to a wider destination width is not supported (if destination width source data width, GPDMA_CxTR1.PAM[1] must be set to 0). - GPDMA_CxBR1.BNDT[15:0] must be programmed as a multiple of the source (peripheral) burst size.
$0000c000 constant SEC_GPDMA2_GPDMA_C0TR2_TRIGM                     \ trigger mode These bits define the transfer granularity for its conditioning by the trigger..
$003f0000 constant SEC_GPDMA2_GPDMA_C0TR2_TRIGSEL                   \ trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] different 00.
$03000000 constant SEC_GPDMA2_GPDMA_C0TR2_TRIGPOL                   \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
$c0000000 constant SEC_GPDMA2_GPDMA_C0TR2_TCEM                      \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief GPDMA channel 0 block register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant SEC_GPDMA2_GPDMA_C0BR1_BNDT                      \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 0 source address register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C0SAR_SA                        \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each burst source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source burst (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel 0 destination address register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C0DAR_DA                        \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each burst destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 0 linked-list address register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000fffc constant SEC_GPDMA2_GPDMA_C0LLR_LA                        \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant SEC_GPDMA2_GPDMA_C0LLR_ULL                       \ Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
$08000000 constant SEC_GPDMA2_GPDMA_C0LLR_UDA                       \ Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
$10000000 constant SEC_GPDMA2_GPDMA_C0LLR_USA                       \ update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
$20000000 constant SEC_GPDMA2_GPDMA_C0LLR_UB1                       \ Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR different 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
$40000000 constant SEC_GPDMA2_GPDMA_C0LLR_UT2                       \ Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
$80000000 constant SEC_GPDMA2_GPDMA_C0LLR_UT1                       \ Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.


\
\ @brief GPDMA channel 1 linked-list base address register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_GPDMA2_GPDMA_C1LBAR_LBA                      \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 1 flag clear register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000100 constant SEC_GPDMA2_GPDMA_C1FCR_TCF                       \ transfer complete flag clear
$00000200 constant SEC_GPDMA2_GPDMA_C1FCR_HTF                       \ half transfer flag clear
$00000400 constant SEC_GPDMA2_GPDMA_C1FCR_DTEF                      \ data transfer error flag clear
$00000800 constant SEC_GPDMA2_GPDMA_C1FCR_ULEF                      \ update link transfer error flag clear
$00001000 constant SEC_GPDMA2_GPDMA_C1FCR_USEF                      \ user setting error flag clear
$00002000 constant SEC_GPDMA2_GPDMA_C1FCR_SUSPF                     \ completed suspension flag clear
$00004000 constant SEC_GPDMA2_GPDMA_C1FCR_TOF                       \ trigger overrun flag clear


\
\ @brief GPDMA channel 1 status register
\ Address offset: 0xE0
\ Reset value: 0x00000001
\

$00000001 constant SEC_GPDMA2_GPDMA_C1SR_IDLEF                      \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant SEC_GPDMA2_GPDMA_C1SR_TCF                        \ transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
$00000200 constant SEC_GPDMA2_GPDMA_C1SR_HTF                        \ half transfer flag A half transfer event is either a half block transfer or a half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). A half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. A half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
$00000400 constant SEC_GPDMA2_GPDMA_C1SR_DTEF                       \ data transfer error flag
$00000800 constant SEC_GPDMA2_GPDMA_C1SR_ULEF                       \ update link transfer error flag
$00001000 constant SEC_GPDMA2_GPDMA_C1SR_USEF                       \ user setting error flag
$00002000 constant SEC_GPDMA2_GPDMA_C1SR_SUSPF                      \ completed suspension flag
$00004000 constant SEC_GPDMA2_GPDMA_C1SR_TOF                        \ trigger overrun flag
$00ff0000 constant SEC_GPDMA2_GPDMA_C1SR_FIFOL                      \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).


\
\ @brief GPDMA channel 1 control register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_C1CR_EN                         \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_GPDMA2_GPDMA_C1CR_RESET                      \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant SEC_GPDMA2_GPDMA_C1CR_SUSP                       \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an ongoing GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
$00000100 constant SEC_GPDMA2_GPDMA_C1CR_TCIE                       \ transfer complete interrupt enable
$00000200 constant SEC_GPDMA2_GPDMA_C1CR_HTIE                       \ half transfer complete interrupt enable
$00000400 constant SEC_GPDMA2_GPDMA_C1CR_DTEIE                      \ data transfer error interrupt enable
$00000800 constant SEC_GPDMA2_GPDMA_C1CR_ULEIE                      \ update link transfer error interrupt enable
$00001000 constant SEC_GPDMA2_GPDMA_C1CR_USEIE                      \ user setting error interrupt enable
$00002000 constant SEC_GPDMA2_GPDMA_C1CR_SUSPIE                     \ completed suspension interrupt enable
$00004000 constant SEC_GPDMA2_GPDMA_C1CR_TOIE                       \ trigger overrun interrupt enable
$00010000 constant SEC_GPDMA2_GPDMA_C1CR_LSM                        \ Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant SEC_GPDMA2_GPDMA_C1CR_LAP                        \ linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_GPDMA2_GPDMA_C1CR_PRIO                       \ priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief GPDMA channel 1 transfer register 1
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000003 constant SEC_GPDMA2_GPDMA_C1TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source burst transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant SEC_GPDMA2_GPDMA_C1TR1_SINC                      \ source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant SEC_GPDMA2_GPDMA_C1TR1_SBL_1                     \ source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$00001800 constant SEC_GPDMA2_GPDMA_C1TR1_PAM                       \ padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else, in the following enumerated values, the condition PAM_1 is when destination data width is higher that source data width, and the condition PAM_2 is when destination data width is higher than source data width. 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note: If the transfer from the source peripheral is configured with peripheral flow-control mode (SWREQ = 0 and PFREQ = 1 and DREQ = 0), and if the destination data width the source data width, packing is not supported.
$00002000 constant SEC_GPDMA2_GPDMA_C1TR1_SBX                       \ source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
$00004000 constant SEC_GPDMA2_GPDMA_C1TR1_SAP                       \ source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$00008000 constant SEC_GPDMA2_GPDMA_C1TR1_SSEC                      \ security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
$00030000 constant SEC_GPDMA2_GPDMA_C1TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
$00080000 constant SEC_GPDMA2_GPDMA_C1TR1_DINC                      \ destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant SEC_GPDMA2_GPDMA_C1TR1_DBL_1                     \ destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$04000000 constant SEC_GPDMA2_GPDMA_C1TR1_DBX                       \ destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
$08000000 constant SEC_GPDMA2_GPDMA_C1TR1_DHX                       \ destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
$40000000 constant SEC_GPDMA2_GPDMA_C1TR1_DAP                       \ destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$80000000 constant SEC_GPDMA2_GPDMA_C1TR1_DSEC                      \ security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.


\
\ @brief GPDMA channel 1 transfer register 2
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$000000ff constant SEC_GPDMA2_GPDMA_C1TR2_REQSEL                    \ GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[7:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_GPDMA2_GPDMA_C1TR2_SWREQ                     \ software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
$00000400 constant SEC_GPDMA2_GPDMA_C1TR2_DREQ                      \ destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note: If the channel x is activated (GPDMA_CxCR.EN is asserted) with SWREQ = 0 and PFREQ = 1 (peripheral hardware request with peripheral flow-control mode), any software assertion to this DREQ bit is ignored: in peripheral flow-control mode, only a peripheral-to-memory transfer is supported.
$00000800 constant SEC_GPDMA2_GPDMA_C1TR2_BREQ                      \ Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$00001000 constant SEC_GPDMA2_GPDMA_C1TR2_PFREQ                     \ Hardware request in peripheral flow control mode Important: If a given channel x is not implemented with this feature, this bit is reserved and PFREQ is not present (see for the list of the implemented channels with this feature. If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else: Note: In peripheral flow control mode, there are the following restrictions: - no 2D/repeated block support (GPDMA_CxBR1.BRC[10:0] must be set to 0 if present) - the peripheral must be set as the source of the transfer (DREQ = 0). - data packing to a wider destination width is not supported (if destination width source data width, GPDMA_CxTR1.PAM[1] must be set to 0). - GPDMA_CxBR1.BNDT[15:0] must be programmed as a multiple of the source (peripheral) burst size.
$0000c000 constant SEC_GPDMA2_GPDMA_C1TR2_TRIGM                     \ trigger mode These bits define the transfer granularity for its conditioning by the trigger.
$003f0000 constant SEC_GPDMA2_GPDMA_C1TR2_TRIGSEL                   \ trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] different 00.
$03000000 constant SEC_GPDMA2_GPDMA_C1TR2_TRIGPOL                   \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
$c0000000 constant SEC_GPDMA2_GPDMA_C1TR2_TCEM                      \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief GPDMA channel 1 block register 1
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant SEC_GPDMA2_GPDMA_C1BR1_BNDT                      \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 1 source address register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C1SAR_SA                        \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each burst source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source burst (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel 1 destination address register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C1DAR_DA                        \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each burst destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 1 linked-list address register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$0000fffc constant SEC_GPDMA2_GPDMA_C1LLR_LA                        \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant SEC_GPDMA2_GPDMA_C1LLR_ULL                       \ Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
$08000000 constant SEC_GPDMA2_GPDMA_C1LLR_UDA                       \ Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
$10000000 constant SEC_GPDMA2_GPDMA_C1LLR_USA                       \ update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
$20000000 constant SEC_GPDMA2_GPDMA_C1LLR_UB1                       \ Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR different 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
$40000000 constant SEC_GPDMA2_GPDMA_C1LLR_UT2                       \ Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
$80000000 constant SEC_GPDMA2_GPDMA_C1LLR_UT1                       \ Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.


\
\ @brief GPDMA channel 2 linked-list base address register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_GPDMA2_GPDMA_C2LBAR_LBA                      \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 2 flag clear register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000100 constant SEC_GPDMA2_GPDMA_C2FCR_TCF                       \ transfer complete flag clear
$00000200 constant SEC_GPDMA2_GPDMA_C2FCR_HTF                       \ half transfer flag clear
$00000400 constant SEC_GPDMA2_GPDMA_C2FCR_DTEF                      \ data transfer error flag clear
$00000800 constant SEC_GPDMA2_GPDMA_C2FCR_ULEF                      \ update link transfer error flag clear
$00001000 constant SEC_GPDMA2_GPDMA_C2FCR_USEF                      \ user setting error flag clear
$00002000 constant SEC_GPDMA2_GPDMA_C2FCR_SUSPF                     \ completed suspension flag clear
$00004000 constant SEC_GPDMA2_GPDMA_C2FCR_TOF                       \ trigger overrun flag clear


\
\ @brief GPDMA channel 2 status register
\ Address offset: 0x160
\ Reset value: 0x00000001
\

$00000001 constant SEC_GPDMA2_GPDMA_C2SR_IDLEF                      \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant SEC_GPDMA2_GPDMA_C2SR_TCF                        \ transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
$00000200 constant SEC_GPDMA2_GPDMA_C2SR_HTF                        \ half transfer flag A half transfer event is either a half block transfer or a half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). A half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. A half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
$00000400 constant SEC_GPDMA2_GPDMA_C2SR_DTEF                       \ data transfer error flag
$00000800 constant SEC_GPDMA2_GPDMA_C2SR_ULEF                       \ update link transfer error flag
$00001000 constant SEC_GPDMA2_GPDMA_C2SR_USEF                       \ user setting error flag
$00002000 constant SEC_GPDMA2_GPDMA_C2SR_SUSPF                      \ completed suspension flag
$00004000 constant SEC_GPDMA2_GPDMA_C2SR_TOF                        \ trigger overrun flag
$00ff0000 constant SEC_GPDMA2_GPDMA_C2SR_FIFOL                      \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).


\
\ @brief GPDMA channel 2 control register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_C2CR_EN                         \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_GPDMA2_GPDMA_C2CR_RESET                      \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant SEC_GPDMA2_GPDMA_C2CR_SUSP                       \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an ongoing GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
$00000100 constant SEC_GPDMA2_GPDMA_C2CR_TCIE                       \ transfer complete interrupt enable
$00000200 constant SEC_GPDMA2_GPDMA_C2CR_HTIE                       \ half transfer complete interrupt enable
$00000400 constant SEC_GPDMA2_GPDMA_C2CR_DTEIE                      \ data transfer error interrupt enable
$00000800 constant SEC_GPDMA2_GPDMA_C2CR_ULEIE                      \ update link transfer error interrupt enable
$00001000 constant SEC_GPDMA2_GPDMA_C2CR_USEIE                      \ user setting error interrupt enable
$00002000 constant SEC_GPDMA2_GPDMA_C2CR_SUSPIE                     \ completed suspension interrupt enable
$00004000 constant SEC_GPDMA2_GPDMA_C2CR_TOIE                       \ trigger overrun interrupt enable
$00010000 constant SEC_GPDMA2_GPDMA_C2CR_LSM                        \ Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant SEC_GPDMA2_GPDMA_C2CR_LAP                        \ linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_GPDMA2_GPDMA_C2CR_PRIO                       \ priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief GPDMA channel 2 transfer register 1
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000003 constant SEC_GPDMA2_GPDMA_C2TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source burst transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant SEC_GPDMA2_GPDMA_C2TR1_SINC                      \ source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant SEC_GPDMA2_GPDMA_C2TR1_SBL_1                     \ source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$00001800 constant SEC_GPDMA2_GPDMA_C2TR1_PAM                       \ padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else, in the following enumerated values, the condition PAM_1 is when destination data width is higher that source data width, and the condition PAM_2 is when destination data width is higher than source data width. 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note: If the transfer from the source peripheral is configured with peripheral flow-control mode (SWREQ = 0 and PFREQ = 1 and DREQ = 0), and if the destination data width the source data width, packing is not supported.
$00002000 constant SEC_GPDMA2_GPDMA_C2TR1_SBX                       \ source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
$00004000 constant SEC_GPDMA2_GPDMA_C2TR1_SAP                       \ source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$00008000 constant SEC_GPDMA2_GPDMA_C2TR1_SSEC                      \ security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
$00030000 constant SEC_GPDMA2_GPDMA_C2TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
$00080000 constant SEC_GPDMA2_GPDMA_C2TR1_DINC                      \ destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant SEC_GPDMA2_GPDMA_C2TR1_DBL_1                     \ destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$04000000 constant SEC_GPDMA2_GPDMA_C2TR1_DBX                       \ destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
$08000000 constant SEC_GPDMA2_GPDMA_C2TR1_DHX                       \ destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
$40000000 constant SEC_GPDMA2_GPDMA_C2TR1_DAP                       \ destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$80000000 constant SEC_GPDMA2_GPDMA_C2TR1_DSEC                      \ security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.


\
\ @brief GPDMA channel 2 transfer register 2
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$000000ff constant SEC_GPDMA2_GPDMA_C2TR2_REQSEL                    \ GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[7:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_GPDMA2_GPDMA_C2TR2_SWREQ                     \ software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
$00000400 constant SEC_GPDMA2_GPDMA_C2TR2_DREQ                      \ destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note: If the channel x is activated (GPDMA_CxCR.EN is asserted) with SWREQ = 0 and PFREQ = 1 (peripheral hardware request with peripheral flow-control mode), any software assertion to this DREQ bit is ignored: in peripheral flow-control mode, only a peripheral-to-memory transfer is supported.
$00000800 constant SEC_GPDMA2_GPDMA_C2TR2_BREQ                      \ Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$00001000 constant SEC_GPDMA2_GPDMA_C2TR2_PFREQ                     \ Hardware request in peripheral flow control mode Important: If a given channel x is not implemented with this feature, this bit is reserved and PFREQ is not present (see for the list of the implemented channels with this feature. If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else: Note: In peripheral flow control mode, there are the following restrictions: - no 2D/repeated block support (GPDMA_CxBR1.BRC[10:0] must be set to 0 if present) - the peripheral must be set as the source of the transfer (DREQ = 0). - data packing to a wider destination width is not supported (if destination width source data width, GPDMA_CxTR1.PAM[1] must be set to 0). - GPDMA_CxBR1.BNDT[15:0] must be programmed as a multiple of the source (peripheral) burst size.
$0000c000 constant SEC_GPDMA2_GPDMA_C2TR2_TRIGM                     \ trigger mode These bits define the transfer granularity for its conditioning by the trigger.
$003f0000 constant SEC_GPDMA2_GPDMA_C2TR2_TRIGSEL                   \ trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] different 00.
$03000000 constant SEC_GPDMA2_GPDMA_C2TR2_TRIGPOL                   \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
$c0000000 constant SEC_GPDMA2_GPDMA_C2TR2_TCEM                      \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief GPDMA channel 2 block register 1
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$0000ffff constant SEC_GPDMA2_GPDMA_C2BR1_BNDT                      \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 2 source address register
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C2SAR_SA                        \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each burst source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source burst (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel 2 destination address register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C2DAR_DA                        \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each burst destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 2 linked-list address register
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$0000fffc constant SEC_GPDMA2_GPDMA_C2LLR_LA                        \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant SEC_GPDMA2_GPDMA_C2LLR_ULL                       \ Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
$08000000 constant SEC_GPDMA2_GPDMA_C2LLR_UDA                       \ Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
$10000000 constant SEC_GPDMA2_GPDMA_C2LLR_USA                       \ update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
$20000000 constant SEC_GPDMA2_GPDMA_C2LLR_UB1                       \ Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR different 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
$40000000 constant SEC_GPDMA2_GPDMA_C2LLR_UT2                       \ Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
$80000000 constant SEC_GPDMA2_GPDMA_C2LLR_UT1                       \ Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.


\
\ @brief GPDMA channel 3 linked-list base address register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_GPDMA2_GPDMA_C3LBAR_LBA                      \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 3 flag clear register
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$00000100 constant SEC_GPDMA2_GPDMA_C3FCR_TCF                       \ transfer complete flag clear
$00000200 constant SEC_GPDMA2_GPDMA_C3FCR_HTF                       \ half transfer flag clear
$00000400 constant SEC_GPDMA2_GPDMA_C3FCR_DTEF                      \ data transfer error flag clear
$00000800 constant SEC_GPDMA2_GPDMA_C3FCR_ULEF                      \ update link transfer error flag clear
$00001000 constant SEC_GPDMA2_GPDMA_C3FCR_USEF                      \ user setting error flag clear
$00002000 constant SEC_GPDMA2_GPDMA_C3FCR_SUSPF                     \ completed suspension flag clear
$00004000 constant SEC_GPDMA2_GPDMA_C3FCR_TOF                       \ trigger overrun flag clear


\
\ @brief GPDMA channel 3 status register
\ Address offset: 0x1E0
\ Reset value: 0x00000001
\

$00000001 constant SEC_GPDMA2_GPDMA_C3SR_IDLEF                      \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant SEC_GPDMA2_GPDMA_C3SR_TCF                        \ transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
$00000200 constant SEC_GPDMA2_GPDMA_C3SR_HTF                        \ half transfer flag A half transfer event is either a half block transfer or a half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). A half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. A half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
$00000400 constant SEC_GPDMA2_GPDMA_C3SR_DTEF                       \ data transfer error flag
$00000800 constant SEC_GPDMA2_GPDMA_C3SR_ULEF                       \ update link transfer error flag
$00001000 constant SEC_GPDMA2_GPDMA_C3SR_USEF                       \ user setting error flag
$00002000 constant SEC_GPDMA2_GPDMA_C3SR_SUSPF                      \ completed suspension flag
$00004000 constant SEC_GPDMA2_GPDMA_C3SR_TOF                        \ trigger overrun flag
$00ff0000 constant SEC_GPDMA2_GPDMA_C3SR_FIFOL                      \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).


\
\ @brief GPDMA channel 3 control register
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_C3CR_EN                         \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_GPDMA2_GPDMA_C3CR_RESET                      \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant SEC_GPDMA2_GPDMA_C3CR_SUSP                       \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an ongoing GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
$00000100 constant SEC_GPDMA2_GPDMA_C3CR_TCIE                       \ transfer complete interrupt enable
$00000200 constant SEC_GPDMA2_GPDMA_C3CR_HTIE                       \ half transfer complete interrupt enable
$00000400 constant SEC_GPDMA2_GPDMA_C3CR_DTEIE                      \ data transfer error interrupt enable
$00000800 constant SEC_GPDMA2_GPDMA_C3CR_ULEIE                      \ update link transfer error interrupt enable
$00001000 constant SEC_GPDMA2_GPDMA_C3CR_USEIE                      \ user setting error interrupt enable
$00002000 constant SEC_GPDMA2_GPDMA_C3CR_SUSPIE                     \ completed suspension interrupt enable
$00004000 constant SEC_GPDMA2_GPDMA_C3CR_TOIE                       \ trigger overrun interrupt enable
$00010000 constant SEC_GPDMA2_GPDMA_C3CR_LSM                        \ Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant SEC_GPDMA2_GPDMA_C3CR_LAP                        \ linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_GPDMA2_GPDMA_C3CR_PRIO                       \ priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief GPDMA channel 3 transfer register 1
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000003 constant SEC_GPDMA2_GPDMA_C3TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source burst transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant SEC_GPDMA2_GPDMA_C3TR1_SINC                      \ source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant SEC_GPDMA2_GPDMA_C3TR1_SBL_1                     \ source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$00001800 constant SEC_GPDMA2_GPDMA_C3TR1_PAM                       \ padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else, in the following enumerated values, the condition PAM_1 is when destination data width is higher that source data width, and the condition PAM_2 is when destination data width is higher than source data width. 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note: If the transfer from the source peripheral is configured with peripheral flow-control mode (SWREQ = 0 and PFREQ = 1 and DREQ = 0), and if the destination data width the source data width, packing is not supported.
$00002000 constant SEC_GPDMA2_GPDMA_C3TR1_SBX                       \ source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
$00004000 constant SEC_GPDMA2_GPDMA_C3TR1_SAP                       \ source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$00008000 constant SEC_GPDMA2_GPDMA_C3TR1_SSEC                      \ security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
$00030000 constant SEC_GPDMA2_GPDMA_C3TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
$00080000 constant SEC_GPDMA2_GPDMA_C3TR1_DINC                      \ destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant SEC_GPDMA2_GPDMA_C3TR1_DBL_1                     \ destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$04000000 constant SEC_GPDMA2_GPDMA_C3TR1_DBX                       \ destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
$08000000 constant SEC_GPDMA2_GPDMA_C3TR1_DHX                       \ destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
$40000000 constant SEC_GPDMA2_GPDMA_C3TR1_DAP                       \ destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$80000000 constant SEC_GPDMA2_GPDMA_C3TR1_DSEC                      \ security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.


\
\ @brief GPDMA channel 3 transfer register 2
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$000000ff constant SEC_GPDMA2_GPDMA_C3TR2_REQSEL                    \ GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[7:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_GPDMA2_GPDMA_C3TR2_SWREQ                     \ software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
$00000400 constant SEC_GPDMA2_GPDMA_C3TR2_DREQ                      \ destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note: If the channel x is activated (GPDMA_CxCR.EN is asserted) with SWREQ = 0 and PFREQ = 1 (peripheral hardware request with peripheral flow-control mode), any software assertion to this DREQ bit is ignored: in peripheral flow-control mode, only a peripheral-to-memory transfer is supported.
$00000800 constant SEC_GPDMA2_GPDMA_C3TR2_BREQ                      \ Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$00001000 constant SEC_GPDMA2_GPDMA_C3TR2_PFREQ                     \ Hardware request in peripheral flow control mode Important: If a given channel x is not implemented with this feature, this bit is reserved and PFREQ is not present (see for the list of the implemented channels with this feature. If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else: Note: In peripheral flow control mode, there are the following restrictions: - no 2D/repeated block support (GPDMA_CxBR1.BRC[10:0] must be set to 0 if present) - the peripheral must be set as the source of the transfer (DREQ = 0). - data packing to a wider destination width is not supported (if destination width source data width, GPDMA_CxTR1.PAM[1] must be set to 0). - GPDMA_CxBR1.BNDT[15:0] must be programmed as a multiple of the source (peripheral) burst size.
$0000c000 constant SEC_GPDMA2_GPDMA_C3TR2_TRIGM                     \ trigger mode These bits define the transfer granularity for its conditioning by the trigger.
$003f0000 constant SEC_GPDMA2_GPDMA_C3TR2_TRIGSEL                   \ trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] different 00.
$03000000 constant SEC_GPDMA2_GPDMA_C3TR2_TRIGPOL                   \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
$c0000000 constant SEC_GPDMA2_GPDMA_C3TR2_TCEM                      \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief GPDMA channel 3 block register 1
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$0000ffff constant SEC_GPDMA2_GPDMA_C3BR1_BNDT                      \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 3 source address register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C3SAR_SA                        \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each burst source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source burst (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel 3 destination address register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C3DAR_DA                        \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each burst destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 3 linked-list address register
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$0000fffc constant SEC_GPDMA2_GPDMA_C3LLR_LA                        \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant SEC_GPDMA2_GPDMA_C3LLR_ULL                       \ Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
$08000000 constant SEC_GPDMA2_GPDMA_C3LLR_UDA                       \ Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
$10000000 constant SEC_GPDMA2_GPDMA_C3LLR_USA                       \ update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
$20000000 constant SEC_GPDMA2_GPDMA_C3LLR_UB1                       \ Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR different 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
$40000000 constant SEC_GPDMA2_GPDMA_C3LLR_UT2                       \ Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
$80000000 constant SEC_GPDMA2_GPDMA_C3LLR_UT1                       \ Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.


\
\ @brief GPDMA channel 4 linked-list base address register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_GPDMA2_GPDMA_C4LBAR_LBA                      \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 4 flag clear register
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000100 constant SEC_GPDMA2_GPDMA_C4FCR_TCF                       \ transfer complete flag clear
$00000200 constant SEC_GPDMA2_GPDMA_C4FCR_HTF                       \ half transfer flag clear
$00000400 constant SEC_GPDMA2_GPDMA_C4FCR_DTEF                      \ data transfer error flag clear
$00000800 constant SEC_GPDMA2_GPDMA_C4FCR_ULEF                      \ update link transfer error flag clear
$00001000 constant SEC_GPDMA2_GPDMA_C4FCR_USEF                      \ user setting error flag clear
$00002000 constant SEC_GPDMA2_GPDMA_C4FCR_SUSPF                     \ completed suspension flag clear
$00004000 constant SEC_GPDMA2_GPDMA_C4FCR_TOF                       \ trigger overrun flag clear


\
\ @brief GPDMA channel 4 status register
\ Address offset: 0x260
\ Reset value: 0x00000001
\

$00000001 constant SEC_GPDMA2_GPDMA_C4SR_IDLEF                      \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant SEC_GPDMA2_GPDMA_C4SR_TCF                        \ transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
$00000200 constant SEC_GPDMA2_GPDMA_C4SR_HTF                        \ half transfer flag A half transfer event is either a half block transfer or a half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). A half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. A half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
$00000400 constant SEC_GPDMA2_GPDMA_C4SR_DTEF                       \ data transfer error flag
$00000800 constant SEC_GPDMA2_GPDMA_C4SR_ULEF                       \ update link transfer error flag
$00001000 constant SEC_GPDMA2_GPDMA_C4SR_USEF                       \ user setting error flag
$00002000 constant SEC_GPDMA2_GPDMA_C4SR_SUSPF                      \ completed suspension flag
$00004000 constant SEC_GPDMA2_GPDMA_C4SR_TOF                        \ trigger overrun flag
$00ff0000 constant SEC_GPDMA2_GPDMA_C4SR_FIFOL                      \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).


\
\ @brief GPDMA channel 4 control register
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_C4CR_EN                         \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_GPDMA2_GPDMA_C4CR_RESET                      \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant SEC_GPDMA2_GPDMA_C4CR_SUSP                       \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an ongoing GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
$00000100 constant SEC_GPDMA2_GPDMA_C4CR_TCIE                       \ transfer complete interrupt enable
$00000200 constant SEC_GPDMA2_GPDMA_C4CR_HTIE                       \ half transfer complete interrupt enable
$00000400 constant SEC_GPDMA2_GPDMA_C4CR_DTEIE                      \ data transfer error interrupt enable
$00000800 constant SEC_GPDMA2_GPDMA_C4CR_ULEIE                      \ update link transfer error interrupt enable
$00001000 constant SEC_GPDMA2_GPDMA_C4CR_USEIE                      \ user setting error interrupt enable
$00002000 constant SEC_GPDMA2_GPDMA_C4CR_SUSPIE                     \ completed suspension interrupt enable
$00004000 constant SEC_GPDMA2_GPDMA_C4CR_TOIE                       \ trigger overrun interrupt enable
$00010000 constant SEC_GPDMA2_GPDMA_C4CR_LSM                        \ Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant SEC_GPDMA2_GPDMA_C4CR_LAP                        \ linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_GPDMA2_GPDMA_C4CR_PRIO                       \ priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief GPDMA channel 4 transfer register 1
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000003 constant SEC_GPDMA2_GPDMA_C4TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source burst transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant SEC_GPDMA2_GPDMA_C4TR1_SINC                      \ source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant SEC_GPDMA2_GPDMA_C4TR1_SBL_1                     \ source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$00001800 constant SEC_GPDMA2_GPDMA_C4TR1_PAM                       \ padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else, in the following enumerated values, the condition PAM_1 is when destination data width is higher that source data width, and the condition PAM_2 is when destination data width is higher than source data width. 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note: If the transfer from the source peripheral is configured with peripheral flow-control mode (SWREQ = 0 and PFREQ = 1 and DREQ = 0), and if the destination data width the source data width, packing is not supported.
$00002000 constant SEC_GPDMA2_GPDMA_C4TR1_SBX                       \ source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
$00004000 constant SEC_GPDMA2_GPDMA_C4TR1_SAP                       \ source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$00008000 constant SEC_GPDMA2_GPDMA_C4TR1_SSEC                      \ security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
$00030000 constant SEC_GPDMA2_GPDMA_C4TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
$00080000 constant SEC_GPDMA2_GPDMA_C4TR1_DINC                      \ destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant SEC_GPDMA2_GPDMA_C4TR1_DBL_1                     \ destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$04000000 constant SEC_GPDMA2_GPDMA_C4TR1_DBX                       \ destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
$08000000 constant SEC_GPDMA2_GPDMA_C4TR1_DHX                       \ destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
$40000000 constant SEC_GPDMA2_GPDMA_C4TR1_DAP                       \ destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$80000000 constant SEC_GPDMA2_GPDMA_C4TR1_DSEC                      \ security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.


\
\ @brief GPDMA channel 4 transfer register 2
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$000000ff constant SEC_GPDMA2_GPDMA_C4TR2_REQSEL                    \ GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[7:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_GPDMA2_GPDMA_C4TR2_SWREQ                     \ software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
$00000400 constant SEC_GPDMA2_GPDMA_C4TR2_DREQ                      \ destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note: If the channel x is activated (GPDMA_CxCR.EN is asserted) with SWREQ = 0 and PFREQ = 1 (peripheral hardware request with peripheral flow-control mode), any software assertion to this DREQ bit is ignored: in peripheral flow-control mode, only a peripheral-to-memory transfer is supported.
$00000800 constant SEC_GPDMA2_GPDMA_C4TR2_BREQ                      \ Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$00001000 constant SEC_GPDMA2_GPDMA_C4TR2_PFREQ                     \ Hardware request in peripheral flow control mode Important: If a given channel x is not implemented with this feature, this bit is reserved and PFREQ is not present (see for the list of the implemented channels with this feature. If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else: Note: In peripheral flow control mode, there are the following restrictions: - no 2D/repeated block support (GPDMA_CxBR1.BRC[10:0] must be set to 0 if present) - the peripheral must be set as the source of the transfer (DREQ = 0). - data packing to a wider destination width is not supported (if destination width source data width, GPDMA_CxTR1.PAM[1] must be set to 0). - GPDMA_CxBR1.BNDT[15:0] must be programmed as a multiple of the source (peripheral) burst size.
$0000c000 constant SEC_GPDMA2_GPDMA_C4TR2_TRIGM                     \ trigger mode These bits define the transfer granularity for its conditioning by the trigger.
$003f0000 constant SEC_GPDMA2_GPDMA_C4TR2_TRIGSEL                   \ trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] different 00.
$03000000 constant SEC_GPDMA2_GPDMA_C4TR2_TRIGPOL                   \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
$c0000000 constant SEC_GPDMA2_GPDMA_C4TR2_TCEM                      \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief GPDMA channel 4 block register 1
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$0000ffff constant SEC_GPDMA2_GPDMA_C4BR1_BNDT                      \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 4 source address register
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C4SAR_SA                        \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each burst source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source burst (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel 4 destination address register
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C4DAR_DA                        \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each burst destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 4 linked-list address register
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$0000fffc constant SEC_GPDMA2_GPDMA_C4LLR_LA                        \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant SEC_GPDMA2_GPDMA_C4LLR_ULL                       \ Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
$08000000 constant SEC_GPDMA2_GPDMA_C4LLR_UDA                       \ Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
$10000000 constant SEC_GPDMA2_GPDMA_C4LLR_USA                       \ update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
$20000000 constant SEC_GPDMA2_GPDMA_C4LLR_UB1                       \ Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR different 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
$40000000 constant SEC_GPDMA2_GPDMA_C4LLR_UT2                       \ Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
$80000000 constant SEC_GPDMA2_GPDMA_C4LLR_UT1                       \ Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.


\
\ @brief GPDMA channel 5 linked-list base address register
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_GPDMA2_GPDMA_C5LBAR_LBA                      \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 5 flag clear register
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$00000100 constant SEC_GPDMA2_GPDMA_C5FCR_TCF                       \ transfer complete flag clear
$00000200 constant SEC_GPDMA2_GPDMA_C5FCR_HTF                       \ half transfer flag clear
$00000400 constant SEC_GPDMA2_GPDMA_C5FCR_DTEF                      \ data transfer error flag clear
$00000800 constant SEC_GPDMA2_GPDMA_C5FCR_ULEF                      \ update link transfer error flag clear
$00001000 constant SEC_GPDMA2_GPDMA_C5FCR_USEF                      \ user setting error flag clear
$00002000 constant SEC_GPDMA2_GPDMA_C5FCR_SUSPF                     \ completed suspension flag clear
$00004000 constant SEC_GPDMA2_GPDMA_C5FCR_TOF                       \ trigger overrun flag clear


\
\ @brief GPDMA channel 5 status register
\ Address offset: 0x2E0
\ Reset value: 0x00000001
\

$00000001 constant SEC_GPDMA2_GPDMA_C5SR_IDLEF                      \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant SEC_GPDMA2_GPDMA_C5SR_TCF                        \ transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
$00000200 constant SEC_GPDMA2_GPDMA_C5SR_HTF                        \ half transfer flag A half transfer event is either a half block transfer or a half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). A half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. A half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
$00000400 constant SEC_GPDMA2_GPDMA_C5SR_DTEF                       \ data transfer error flag
$00000800 constant SEC_GPDMA2_GPDMA_C5SR_ULEF                       \ update link transfer error flag
$00001000 constant SEC_GPDMA2_GPDMA_C5SR_USEF                       \ user setting error flag
$00002000 constant SEC_GPDMA2_GPDMA_C5SR_SUSPF                      \ completed suspension flag
$00004000 constant SEC_GPDMA2_GPDMA_C5SR_TOF                        \ trigger overrun flag
$00ff0000 constant SEC_GPDMA2_GPDMA_C5SR_FIFOL                      \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).


\
\ @brief GPDMA channel 5 control register
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_C5CR_EN                         \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_GPDMA2_GPDMA_C5CR_RESET                      \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant SEC_GPDMA2_GPDMA_C5CR_SUSP                       \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an ongoing GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
$00000100 constant SEC_GPDMA2_GPDMA_C5CR_TCIE                       \ transfer complete interrupt enable
$00000200 constant SEC_GPDMA2_GPDMA_C5CR_HTIE                       \ half transfer complete interrupt enable
$00000400 constant SEC_GPDMA2_GPDMA_C5CR_DTEIE                      \ data transfer error interrupt enable
$00000800 constant SEC_GPDMA2_GPDMA_C5CR_ULEIE                      \ update link transfer error interrupt enable
$00001000 constant SEC_GPDMA2_GPDMA_C5CR_USEIE                      \ user setting error interrupt enable
$00002000 constant SEC_GPDMA2_GPDMA_C5CR_SUSPIE                     \ completed suspension interrupt enable
$00004000 constant SEC_GPDMA2_GPDMA_C5CR_TOIE                       \ trigger overrun interrupt enable
$00010000 constant SEC_GPDMA2_GPDMA_C5CR_LSM                        \ Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant SEC_GPDMA2_GPDMA_C5CR_LAP                        \ linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_GPDMA2_GPDMA_C5CR_PRIO                       \ priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief GPDMA channel 5 transfer register 1
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000003 constant SEC_GPDMA2_GPDMA_C5TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source burst transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant SEC_GPDMA2_GPDMA_C5TR1_SINC                      \ source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant SEC_GPDMA2_GPDMA_C5TR1_SBL_1                     \ source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$00001800 constant SEC_GPDMA2_GPDMA_C5TR1_PAM                       \ padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else, in the following enumerated values, the condition PAM_1 is when destination data width is higher that source data width, and the condition PAM_2 is when destination data width is higher than source data width. 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note: If the transfer from the source peripheral is configured with peripheral flow-control mode (SWREQ = 0 and PFREQ = 1 and DREQ = 0), and if the destination data width the source data width, packing is not supported.
$00002000 constant SEC_GPDMA2_GPDMA_C5TR1_SBX                       \ source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
$00004000 constant SEC_GPDMA2_GPDMA_C5TR1_SAP                       \ source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$00008000 constant SEC_GPDMA2_GPDMA_C5TR1_SSEC                      \ security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
$00030000 constant SEC_GPDMA2_GPDMA_C5TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
$00080000 constant SEC_GPDMA2_GPDMA_C5TR1_DINC                      \ destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant SEC_GPDMA2_GPDMA_C5TR1_DBL_1                     \ destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$04000000 constant SEC_GPDMA2_GPDMA_C5TR1_DBX                       \ destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
$08000000 constant SEC_GPDMA2_GPDMA_C5TR1_DHX                       \ destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
$40000000 constant SEC_GPDMA2_GPDMA_C5TR1_DAP                       \ destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$80000000 constant SEC_GPDMA2_GPDMA_C5TR1_DSEC                      \ security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.


\
\ @brief GPDMA channel 5 transfer register 2
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$000000ff constant SEC_GPDMA2_GPDMA_C5TR2_REQSEL                    \ GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[7:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_GPDMA2_GPDMA_C5TR2_SWREQ                     \ software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
$00000400 constant SEC_GPDMA2_GPDMA_C5TR2_DREQ                      \ destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note: If the channel x is activated (GPDMA_CxCR.EN is asserted) with SWREQ = 0 and PFREQ = 1 (peripheral hardware request with peripheral flow-control mode), any software assertion to this DREQ bit is ignored: in peripheral flow-control mode, only a peripheral-to-memory transfer is supported.
$00000800 constant SEC_GPDMA2_GPDMA_C5TR2_BREQ                      \ Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$00001000 constant SEC_GPDMA2_GPDMA_C5TR2_PFREQ                     \ Hardware request in peripheral flow control mode Important: If a given channel x is not implemented with this feature, this bit is reserved and PFREQ is not present (see for the list of the implemented channels with this feature. If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else: Note: In peripheral flow control mode, there are the following restrictions: - no 2D/repeated block support (GPDMA_CxBR1.BRC[10:0] must be set to 0 if present) - the peripheral must be set as the source of the transfer (DREQ = 0). - data packing to a wider destination width is not supported (if destination width source data width, GPDMA_CxTR1.PAM[1] must be set to 0). - GPDMA_CxBR1.BNDT[15:0] must be programmed as a multiple of the source (peripheral) burst size.
$0000c000 constant SEC_GPDMA2_GPDMA_C5TR2_TRIGM                     \ trigger mode These bits define the transfer granularity for its conditioning by the trigger.
$003f0000 constant SEC_GPDMA2_GPDMA_C5TR2_TRIGSEL                   \ trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] different 00.
$03000000 constant SEC_GPDMA2_GPDMA_C5TR2_TRIGPOL                   \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
$c0000000 constant SEC_GPDMA2_GPDMA_C5TR2_TCEM                      \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief GPDMA channel 5 block register 1
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$0000ffff constant SEC_GPDMA2_GPDMA_C5BR1_BNDT                      \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one non null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] = 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1] = 1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 5 source address register
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C5SAR_SA                        \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each burst source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source burst (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel 5 destination address register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C5DAR_DA                        \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each burst destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 5 linked-list address register
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$0000fffc constant SEC_GPDMA2_GPDMA_C5LLR_LA                        \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant SEC_GPDMA2_GPDMA_C5LLR_ULL                       \ Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
$08000000 constant SEC_GPDMA2_GPDMA_C5LLR_UDA                       \ Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
$10000000 constant SEC_GPDMA2_GPDMA_C5LLR_USA                       \ update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
$20000000 constant SEC_GPDMA2_GPDMA_C5LLR_UB1                       \ Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR different 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
$40000000 constant SEC_GPDMA2_GPDMA_C5LLR_UT2                       \ Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
$80000000 constant SEC_GPDMA2_GPDMA_C5LLR_UT1                       \ Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.


\
\ @brief GPDMA channel 6 linked-list base address register
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_GPDMA2_GPDMA_C6LBAR_LBA                      \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 6 flag clear register
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$00000100 constant SEC_GPDMA2_GPDMA_C6FCR_TCF                       \ transfer complete flag clear
$00000200 constant SEC_GPDMA2_GPDMA_C6FCR_HTF                       \ half transfer flag clear
$00000400 constant SEC_GPDMA2_GPDMA_C6FCR_DTEF                      \ data transfer error flag clear
$00000800 constant SEC_GPDMA2_GPDMA_C6FCR_ULEF                      \ update link transfer error flag clear
$00001000 constant SEC_GPDMA2_GPDMA_C6FCR_USEF                      \ user setting error flag clear
$00002000 constant SEC_GPDMA2_GPDMA_C6FCR_SUSPF                     \ completed suspension flag clear
$00004000 constant SEC_GPDMA2_GPDMA_C6FCR_TOF                       \ trigger overrun flag clear


\
\ @brief GPDMA channel 6 status register
\ Address offset: 0x360
\ Reset value: 0x00000001
\

$00000001 constant SEC_GPDMA2_GPDMA_C6SR_IDLEF                      \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant SEC_GPDMA2_GPDMA_C6SR_TCF                        \ transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
$00000200 constant SEC_GPDMA2_GPDMA_C6SR_HTF                        \ half transfer flag A half transfer event is either a half block transfer or a half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). A half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. A half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
$00000400 constant SEC_GPDMA2_GPDMA_C6SR_DTEF                       \ data transfer error flag
$00000800 constant SEC_GPDMA2_GPDMA_C6SR_ULEF                       \ update link transfer error flag
$00001000 constant SEC_GPDMA2_GPDMA_C6SR_USEF                       \ user setting error flag
$00002000 constant SEC_GPDMA2_GPDMA_C6SR_SUSPF                      \ completed suspension flag
$00004000 constant SEC_GPDMA2_GPDMA_C6SR_TOF                        \ trigger overrun flag
$00ff0000 constant SEC_GPDMA2_GPDMA_C6SR_FIFOL                      \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).


\
\ @brief GPDMA channel 6 control register
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_C6CR_EN                         \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_GPDMA2_GPDMA_C6CR_RESET                      \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant SEC_GPDMA2_GPDMA_C6CR_SUSP                       \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an ongoing GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
$00000100 constant SEC_GPDMA2_GPDMA_C6CR_TCIE                       \ transfer complete interrupt enable
$00000200 constant SEC_GPDMA2_GPDMA_C6CR_HTIE                       \ half transfer complete interrupt enable
$00000400 constant SEC_GPDMA2_GPDMA_C6CR_DTEIE                      \ data transfer error interrupt enable
$00000800 constant SEC_GPDMA2_GPDMA_C6CR_ULEIE                      \ update link transfer error interrupt enable
$00001000 constant SEC_GPDMA2_GPDMA_C6CR_USEIE                      \ user setting error interrupt enable
$00002000 constant SEC_GPDMA2_GPDMA_C6CR_SUSPIE                     \ completed suspension interrupt enable
$00004000 constant SEC_GPDMA2_GPDMA_C6CR_TOIE                       \ trigger overrun interrupt enable
$00010000 constant SEC_GPDMA2_GPDMA_C6CR_LSM                        \ Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant SEC_GPDMA2_GPDMA_C6CR_LAP                        \ linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_GPDMA2_GPDMA_C6CR_PRIO                       \ priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief GPDMA channel 6 transfer register 1
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$00000003 constant SEC_GPDMA2_GPDMA_C6TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source burst transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant SEC_GPDMA2_GPDMA_C6TR1_SINC                      \ source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant SEC_GPDMA2_GPDMA_C6TR1_SBL_1                     \ source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$00001800 constant SEC_GPDMA2_GPDMA_C6TR1_PAM                       \ padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else, in the following enumerated values, the condition PAM_1 is when destination data width is higher that source data width, and the condition PAM_2 is when destination data width is higher than source data width. 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note: If the transfer from the source peripheral is configured with peripheral flow-control mode (SWREQ = 0 and PFREQ = 1 and DREQ = 0), and if the destination data width the source data width, packing is not supported.
$00002000 constant SEC_GPDMA2_GPDMA_C6TR1_SBX                       \ source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
$00004000 constant SEC_GPDMA2_GPDMA_C6TR1_SAP                       \ source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$00008000 constant SEC_GPDMA2_GPDMA_C6TR1_SSEC                      \ security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
$00030000 constant SEC_GPDMA2_GPDMA_C6TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
$00080000 constant SEC_GPDMA2_GPDMA_C6TR1_DINC                      \ destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant SEC_GPDMA2_GPDMA_C6TR1_DBL_1                     \ destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$04000000 constant SEC_GPDMA2_GPDMA_C6TR1_DBX                       \ destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
$08000000 constant SEC_GPDMA2_GPDMA_C6TR1_DHX                       \ destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
$40000000 constant SEC_GPDMA2_GPDMA_C6TR1_DAP                       \ destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$80000000 constant SEC_GPDMA2_GPDMA_C6TR1_DSEC                      \ security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.


\
\ @brief GPDMA channel 6 transfer register 2
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$000000ff constant SEC_GPDMA2_GPDMA_C6TR2_REQSEL                    \ GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[7:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_GPDMA2_GPDMA_C6TR2_SWREQ                     \ software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
$00000400 constant SEC_GPDMA2_GPDMA_C6TR2_DREQ                      \ destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note: If the channel x is activated (GPDMA_CxCR.EN is asserted) with SWREQ = 0 and PFREQ = 1 (peripheral hardware request with peripheral flow-control mode), any software assertion to this DREQ bit is ignored: in peripheral flow-control mode, only a peripheral-to-memory transfer is supported.
$00000800 constant SEC_GPDMA2_GPDMA_C6TR2_BREQ                      \ Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$00001000 constant SEC_GPDMA2_GPDMA_C6TR2_PFREQ                     \ Hardware request in peripheral flow control mode Important: If a given channel x is not implemented with this feature, this bit is reserved and PFREQ is not present (see for the list of the implemented channels with this feature. If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else: Note: In peripheral flow control mode, there are the following restrictions: - no 2D/repeated block support (GPDMA_CxBR1.BRC[10:0] must be set to 0 if present) - the peripheral must be set as the source of the transfer (DREQ = 0). - data packing to a wider destination width is not supported (if destination width source data width, GPDMA_CxTR1.PAM[1] must be set to 0). - GPDMA_CxBR1.BNDT[15:0] must be programmed as a multiple of the source (peripheral) burst size.
$0000c000 constant SEC_GPDMA2_GPDMA_C6TR2_TRIGM                     \ trigger mode These bits define the transfer granularity for its conditioning by the trigger.
$003f0000 constant SEC_GPDMA2_GPDMA_C6TR2_TRIGSEL                   \ trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] different 00.
$03000000 constant SEC_GPDMA2_GPDMA_C6TR2_TRIGPOL                   \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
$c0000000 constant SEC_GPDMA2_GPDMA_C6TR2_TCEM                      \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief GPDMA channel 6 alternate block register 1
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$0000ffff constant SEC_GPDMA2_GPDMA_C6BR1_BNDT                      \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] different 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1]=1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
$07ff0000 constant SEC_GPDMA2_GPDMA_C6BR1_BRC                       \ Block repeat counter This field contains the number of repetitions of the current block (0 to 2047). When the channel is enabled, this field becomes read-only. After decrements, this field indicates the remaining number of blocks, excluding the current one. This counter is hardware decremented for each completed block transfer. Once the last block transfer is completed (BRC[10:0] = BNDT[15:0] = 0): If GPDMA_CxLLR.UB1 = 1, all GPDMA_CxBR1 fields are updated by the next LLI in the memory. If GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] different 0, this field is internally restored to the programmed value (infinite/continuous last LLI). if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI and data transfer.
$10000000 constant SEC_GPDMA2_GPDMA_C6BR1_SDEC                      \ source address decrement
$20000000 constant SEC_GPDMA2_GPDMA_C6BR1_DDEC                      \ destination address decrement
$40000000 constant SEC_GPDMA2_GPDMA_C6BR1_BRSDEC                    \ Block repeat source address decrement Note: On top of this increment/decrement (depending on BRSDEC), GPDMA_CxSAR is in the same time also updated by the increment/decrement (depending on SDEC) of the GPDMA_CxTR3.SAO value, as it is done after any programmed burst transfer.
$80000000 constant SEC_GPDMA2_GPDMA_C6BR1_BRDDEC                    \ Block repeat destination address decrement Note: On top of this increment/decrement (depending on BRDDEC), GPDMA_CxDAR is in the same time also updated by the increment/decrement (depending on DDEC) of the GPDMA_CxTR3.DAO value, as it is usually done at the end of each programmed burst transfer.


\
\ @brief GPDMA channel 6 source address register
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C6SAR_SA                        \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each burst source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source burst (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel 6 destination address register
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C6DAR_DA                        \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each burst destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 6 transfer register 3
\ Address offset: 0x3A4
\ Reset value: 0x00000000
\

$00001fff constant SEC_GPDMA2_GPDMA_C6TR3_SAO                       \ source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.SINC = 1). Note: A source address offset must be aligned with the programmed data width of a source burst (SAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
$1fff0000 constant SEC_GPDMA2_GPDMA_C6TR3_DAO                       \ destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.DINC = 1). Note: A destination address offset must be aligned with the programmed data width of a destination burst (DAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 6 block register 2
\ Address offset: 0x3A8
\ Reset value: 0x00000000
\

$0000ffff constant SEC_GPDMA2_GPDMA_C6BR2_BRSAO                     \ Block repeated source address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (BRSAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. BRSAO[15:0] must be set to 0 in peripheral flow-control mode (if GPDMA_CxTR2.PFREQ = 1).
$ffff0000 constant SEC_GPDMA2_GPDMA_C6BR2_BRDAO                     \ Block repeated destination address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (BRDAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. BRDAO[15:0] must be set to 0 in peripheral flow-control mode (if GPDMA_CxTR2.PFREQ = 1).


\
\ @brief GPDMA channel 6 alternate linked-list address register
\ Address offset: 0x3CC
\ Reset value: 0x00000000
\

$0000fffc constant SEC_GPDMA2_GPDMA_C6LLR_LA                        \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant SEC_GPDMA2_GPDMA_C6LLR_ULL                       \ Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
$02000000 constant SEC_GPDMA2_GPDMA_C6LLR_UB2                       \ Update GPDMA_CxBR2 from memory This bit controls the update of GPDMA_CxBR2 from the memory during the link transfer.
$04000000 constant SEC_GPDMA2_GPDMA_C6LLR_UT3                       \ Update GPDMA_CxTR3 from memory This bit controls the update of GPDMA_CxTR3 from the memory during the link transfer.
$08000000 constant SEC_GPDMA2_GPDMA_C6LLR_UDA                       \ Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
$10000000 constant SEC_GPDMA2_GPDMA_C6LLR_USA                       \ update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
$20000000 constant SEC_GPDMA2_GPDMA_C6LLR_UB1                       \ Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR different 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
$40000000 constant SEC_GPDMA2_GPDMA_C6LLR_UT2                       \ Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
$80000000 constant SEC_GPDMA2_GPDMA_C6LLR_UT1                       \ Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.


\
\ @brief GPDMA channel 7 linked-list base address register
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_GPDMA2_GPDMA_C7LBAR_LBA                      \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 7 flag clear register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$00000100 constant SEC_GPDMA2_GPDMA_C7FCR_TCF                       \ transfer complete flag clear
$00000200 constant SEC_GPDMA2_GPDMA_C7FCR_HTF                       \ half transfer flag clear
$00000400 constant SEC_GPDMA2_GPDMA_C7FCR_DTEF                      \ data transfer error flag clear
$00000800 constant SEC_GPDMA2_GPDMA_C7FCR_ULEF                      \ update link transfer error flag clear
$00001000 constant SEC_GPDMA2_GPDMA_C7FCR_USEF                      \ user setting error flag clear
$00002000 constant SEC_GPDMA2_GPDMA_C7FCR_SUSPF                     \ completed suspension flag clear
$00004000 constant SEC_GPDMA2_GPDMA_C7FCR_TOF                       \ trigger overrun flag clear


\
\ @brief GPDMA channel 7 status register
\ Address offset: 0x3E0
\ Reset value: 0x00000001
\

$00000001 constant SEC_GPDMA2_GPDMA_C7SR_IDLEF                      \ idle flag This idle flag is de-asserted by hardware when the channel is enabled (GPDMA_CxCR.EN = 1) with a valid channel configuration (no USEF to be immediately reported). This idle flag is asserted after hard reset or by hardware when the channel is back in idle state (in suspended or disabled state).
$00000100 constant SEC_GPDMA2_GPDMA_C7SR_TCF                        \ transfer complete flag A transfer complete event is either a block transfer complete, a 2D/repeated block transfer complete, a LLI transfer complete including the upload of the next LLI if any, or the full linked-list completion, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]).
$00000200 constant SEC_GPDMA2_GPDMA_C7SR_HTF                        \ half transfer flag A half transfer event is either a half block transfer or a half 2D/repeated block transfer, depending on the transfer complete event mode (GPDMA_CxTR2.TCEM[1:0]). A half block transfer occurs when half of the bytes of the source block size (rounded up integer of GPDMA_CxBR1.BNDT[15:0]/2) has been transferred to the destination. A half 2D/repeated block transfer occurs when half of the repeated blocks (rounded up integer of (GPDMA_CxBR1.BRC[10:0]+1)/2)) has been transferred to the destination.
$00000400 constant SEC_GPDMA2_GPDMA_C7SR_DTEF                       \ data transfer error flag
$00000800 constant SEC_GPDMA2_GPDMA_C7SR_ULEF                       \ update link transfer error flag
$00001000 constant SEC_GPDMA2_GPDMA_C7SR_USEF                       \ user setting error flag
$00002000 constant SEC_GPDMA2_GPDMA_C7SR_SUSPF                      \ completed suspension flag
$00004000 constant SEC_GPDMA2_GPDMA_C7SR_TOF                        \ trigger overrun flag
$00ff0000 constant SEC_GPDMA2_GPDMA_C7SR_FIFOL                      \ monitored FIFO level Number of available write beats in the FIFO, in units of the programmed destination data width (see GPDMA_CxTR1.DDW_LOG2[1:0], in units of bytes, half-words, or words). Note: After having suspended an active transfer, the user may need to read FIFOL[7:0], additionally to GPDMA_CxBR1.BDNT[15:0] and GPDMA_CxBR1.BRC[10:0], to know how many data have been transferred to the destination. Before reading, the user may wait for the transfer to be suspended (GPDMA_CxSR.SUSPF = 1).


\
\ @brief GPDMA channel 7 control register
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPDMA2_GPDMA_C7CR_EN                         \ enable Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 0. Else: this bit is de-asserted by hardware when there is a transfer error (master bus error or user setting error) or when there is a channel transfer complete (channel ready to be configured, e.g. if LSM=1 at the end of a single execution of the LLI). Else, this bit can be asserted by software. Writing 0 into this EN bit is ignored.
$00000002 constant SEC_GPDMA2_GPDMA_C7CR_RESET                      \ reset This bit is write only. Writing 0 has no impact. Writing 1 implies the reset of the following: the FIFO, the channel internal state, SUSP and EN bits (whatever is written receptively in bit 2 and bit 0). The reset is effective when the channel is in steady state, meaning one of the following: - active channel in suspended state (GPDMA_CxSR.SUSPF = 1 and GPDMA_CxSR.IDLEF = GPDMA_CxCR.EN = 1) - channel in disabled state (GPDMA_CxSR.IDLEF = 1 and GPDMA_CxCR.EN = 0). After writing a RESET, to continue using this channel, the user must explicitly reconfigure the channel including the hardware-modified configuration registers (GPDMA_CxBR1, GPDMA_CxSAR and GPDMA_CxDAR) before enabling again the channel (see the programming sequence in ).
$00000004 constant SEC_GPDMA2_GPDMA_C7CR_SUSP                       \ suspend Writing 1 into the field RESET (bit 1) causes the hardware to de-assert this bit, whatever is written into this bit 2. Else: Software must write 1 in order to suspend an active channel i.e. a channel with an ongoing GPDMA transfer over its master ports. The software must write 0 in order to resume a suspended channel, following the programming sequence detailed in .
$00000100 constant SEC_GPDMA2_GPDMA_C7CR_TCIE                       \ transfer complete interrupt enable
$00000200 constant SEC_GPDMA2_GPDMA_C7CR_HTIE                       \ half transfer complete interrupt enable
$00000400 constant SEC_GPDMA2_GPDMA_C7CR_DTEIE                      \ data transfer error interrupt enable
$00000800 constant SEC_GPDMA2_GPDMA_C7CR_ULEIE                      \ update link transfer error interrupt enable
$00001000 constant SEC_GPDMA2_GPDMA_C7CR_USEIE                      \ user setting error interrupt enable
$00002000 constant SEC_GPDMA2_GPDMA_C7CR_SUSPIE                     \ completed suspension interrupt enable
$00004000 constant SEC_GPDMA2_GPDMA_C7CR_TOIE                       \ trigger overrun interrupt enable
$00010000 constant SEC_GPDMA2_GPDMA_C7CR_LSM                        \ Link step mode First the (possible 1D/repeated) block transfer is executed as defined by the current internal register file until GPDMA_CxBR1.BNDT[15:0] = 0 and GPDMA_CxBR1.BRC[10:0] = 0 if present. Secondly the next linked-list data structure is conditionally uploaded from memory as defined by GPDMA_CxLLR. Then channel execution is completed. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00020000 constant SEC_GPDMA2_GPDMA_C7CR_LAP                        \ linked-list allocated port This bit is used to allocate the master port for the update of the GPDMA linked-list registers from the memory. Note: This bit must be written when EN=0. This bit is read-only when EN=1.
$00c00000 constant SEC_GPDMA2_GPDMA_C7CR_PRIO                       \ priority level of the channel x GPDMA transfer versus others Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.


\
\ @brief GPDMA channel 7 transfer register 1
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$00000003 constant SEC_GPDMA2_GPDMA_C7TR1_SDW_LOG2                  \ binary logarithm of the source data width of a burst in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and no transfer is issued. A source block size must be a multiple of the source data width (GPDMA_CxBR1.BNDT[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and no transfer is issued. A source burst transfer must have an aligned address with its data width (start address GPDMA_CxSAR[2:0] versus SDW_LOG2[1:0]). Otherwise, a user setting error is reported and none transfer is issued.
$00000008 constant SEC_GPDMA2_GPDMA_C7TR1_SINC                      \ source incrementing burst The source address, pointed by GPDMA_CxSAR, is kept constant after a burst beat/single transfer or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$000003f0 constant SEC_GPDMA2_GPDMA_C7TR1_SBL_1                     \ source burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If SBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width SDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$00001800 constant SEC_GPDMA2_GPDMA_C7TR1_PAM                       \ padding/alignment mode If DDW_LOG2[1:0] = SDW_LOG2[1:0]: if the data width of a burst destination transfer is equal to the data width of a burst source transfer, these bits are ignored. Else, in the following enumerated values, the condition PAM_1 is when destination data width is higher that source data width, and the condition PAM_2 is when destination data width is higher than source data width. 1x: successive source data are FIFO queued and packed at the destination data width, in a left (LSB) to right (MSB) order (named little endian), before a destination transfer 1x: source data is FIFO queued and unpacked at the destination data width, to be transferred in a left (LSB) to right (MSB) order (named little endian) to the destination Note: If the transfer from the source peripheral is configured with peripheral flow-control mode (SWREQ = 0 and PFREQ = 1 and DREQ = 0), and if the destination data width the source data width, packing is not supported.
$00002000 constant SEC_GPDMA2_GPDMA_C7TR1_SBX                       \ source byte exchange within the unaligned half-word of each source word If the source data width is shorter than a word, this bit is ignored. If the source data width is a word:
$00004000 constant SEC_GPDMA2_GPDMA_C7TR1_SAP                       \ source allocated port This bit is used to allocate the master port for the source transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$00008000 constant SEC_GPDMA2_GPDMA_C7TR1_SSEC                      \ security attribute of the GPDMA transfer from the source If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx =1 . A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this SSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer from the source is non-secure.
$00030000 constant SEC_GPDMA2_GPDMA_C7TR1_DDW_LOG2                  \ binary logarithm of the destination data width of a burst, in bytes Note: Setting a 8-byte data width causes a user setting error to be reported and none transfer is issued. A destination burst transfer must have an aligned address with its data width (start address GPDMA_CxDAR[2:0] and address offset GPDMA_CxTR3.DAO[2:0], versus DDW_LOG2[1:0]). Otherwise a user setting error is reported and no transfer is issued.
$00080000 constant SEC_GPDMA2_GPDMA_C7TR1_DINC                      \ destination incrementing burst The destination address, pointed by GPDMA_CxDAR, is kept constant after a burst beat/single transfer, or is incremented by the offset value corresponding to a contiguous data after a burst beat/single transfer.
$03f00000 constant SEC_GPDMA2_GPDMA_C7TR1_DBL_1                     \ destination burst length minus 1, between 0 and 63 The burst length unit is one data named beat within a burst. If DBL_1[5:0] =0 , the burst can be named as single. Each data/beat has a width defined by the destination data width DDW_LOG2[1:0]. Note: If a burst transfer crossed a 1-Kbyte address boundary on a AHB transfer, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the AHB protocol. If a burst transfer is of length greater than the FIFO size of the channel x, the GPDMA modifies and shortens the programmed burst into singles or bursts of lower length, to be compliant with the FIFO size. Transfer performance is lower, with GPDMA re-arbitration between effective and lower singles/bursts, but the data integrity is guaranteed.
$04000000 constant SEC_GPDMA2_GPDMA_C7TR1_DBX                       \ destination byte exchange If the destination data size is a byte, this bit is ignored. If the destination data size is not a byte:
$08000000 constant SEC_GPDMA2_GPDMA_C7TR1_DHX                       \ destination half-word exchange If the destination data size is shorter than a word, this bit is ignored. If the destination data size is a word:
$40000000 constant SEC_GPDMA2_GPDMA_C7TR1_DAP                       \ destination allocated port This bit is used to allocate the master port for the destination transfer Note: This bit must be written when EN = 0. This bit is read-only when EN = 1.
$80000000 constant SEC_GPDMA2_GPDMA_C7TR1_DSEC                      \ security attribute of the GPDMA transfer to the destination If GPDMA_SECCFGR.SECx = 1 and the access is secure: This is a secure register bit. This bit can only be read by a secure software. This bit must be written by a secure software when GPDMA_SECCFGR.SECx = 1. A secure write is ignored when GPDMA_SECCFGR.SECx = 0. When GPDMA_SECCFGR.SECx is de-asserted, this DSEC bit is also de-asserted by hardware (on a secure reconfiguration of the channel as non-secure), and the GPDMA transfer to the destination is non-secure.


\
\ @brief GPDMA channel 7 transfer register 2
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$000000ff constant SEC_GPDMA2_GPDMA_C7TR2_REQSEL                    \ GPDMA hardware request selection These bits are ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else, the selected hardware request is internally taken into account as per . The user must not assign a same input hardware request (same REQSEL[7:0] value) to different active GPDMA channels (GPDMA_CxCR.EN = 1 and GPDMA_CxTR2.SWREQ = 0 for these channels). GPDMA is not intended to hardware support the case of simultaneous enabled channels incorrectly configured with a same hardware peripheral request signal, and there is no user setting error reporting.
$00000200 constant SEC_GPDMA2_GPDMA_C7TR2_SWREQ                     \ software request This bit is internally taken into account when GPDMA_CxCR.EN is asserted.
$00000400 constant SEC_GPDMA2_GPDMA_C7TR2_DREQ                      \ destination hardware request This bit is ignored if channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer). Else: Note: If the channel x is activated (GPDMA_CxCR.EN is asserted) with SWREQ = 0 and PFREQ = 1 (peripheral hardware request with peripheral flow-control mode), any software assertion to this DREQ bit is ignored: in peripheral flow-control mode, only a peripheral-to-memory transfer is supported.
$00000800 constant SEC_GPDMA2_GPDMA_C7TR2_BREQ                      \ Block hardware request If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else:
$00001000 constant SEC_GPDMA2_GPDMA_C7TR2_PFREQ                     \ Hardware request in peripheral flow control mode Important: If a given channel x is not implemented with this feature, this bit is reserved and PFREQ is not present (see for the list of the implemented channels with this feature. If the channel x is activated (GPDMA_CxCR.EN asserted) with SWREQ = 1 (software request for a memory-to-memory transfer), this bit is ignored. Else: Note: In peripheral flow control mode, there are the following restrictions: - no 2D/repeated block support (GPDMA_CxBR1.BRC[10:0] must be set to 0 if present) - the peripheral must be set as the source of the transfer (DREQ = 0). - data packing to a wider destination width is not supported (if destination width source data width, GPDMA_CxTR1.PAM[1] must be set to 0). - GPDMA_CxBR1.BNDT[15:0] must be programmed as a multiple of the source (peripheral) burst size.
$0000c000 constant SEC_GPDMA2_GPDMA_C7TR2_TRIGM                     \ trigger mode These bits define the transfer granularity for its conditioning by the trigger.
$003f0000 constant SEC_GPDMA2_GPDMA_C7TR2_TRIGSEL                   \ trigger event input selection These bits select the trigger event input of the GPDMA transfer (as per ), with an active trigger event if TRIGPOL[1:0] different 00.
$03000000 constant SEC_GPDMA2_GPDMA_C7TR2_TRIGPOL                   \ trigger event polarity These bits define the polarity of the selected trigger event input defined by TRIGSEL[5:0].
$c0000000 constant SEC_GPDMA2_GPDMA_C7TR2_TCEM                      \ transfer complete event mode These bits define the transfer granularity for the transfer complete and half transfer complete events generation. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] = 0), then neither the complete transfer event nor the half transfer event is generated. Note: If the initial LLI0 data transfer is null/void (i.e. directly programmed by the internal register file with GPDMA_CxBR1.BNDT[15:0] =0 ), then the half transfer event is not generated, and the transfer complete event is generated when is completed the loading of the LLI1.


\
\ @brief GPDMA channel 7 alternate block register 1
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$0000ffff constant SEC_GPDMA2_GPDMA_C7BR1_BNDT                      \ block number of data bytes to transfer from the source Block size transferred from the source. When the channel is enabled, this field becomes read-only and is decremented, indicating the remaining number of data items in the current source block to be transferred. BNDT[15:0] is programmed in number of bytes, maximum source block size is 64 Kbytes -1. Once the last data transfer is completed (BNDT[15:0] = 0): - if GPDMA_CxLLR.UB1 = 1, this field is updated by the LLI in the memory. - if GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. - if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] different 0, this field is internally restored to the programmed value (infinite/continuous last LLI). - if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI data transfer. Note: A non-null source block size must be a multiple of the source data width (BNDT[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. When configured in packing mode (GPDMA_CxTR1.PAM[1]=1 and destination data width different from source data width), a non-null source block size must be a multiple of the destination data width (BNDT[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued.
$07ff0000 constant SEC_GPDMA2_GPDMA_C7BR1_BRC                       \ Block repeat counter This field contains the number of repetitions of the current block (0 to 2047). When the channel is enabled, this field becomes read-only. After decrements, this field indicates the remaining number of blocks, excluding the current one. This counter is hardware decremented for each completed block transfer. Once the last block transfer is completed (BRC[10:0] = BNDT[15:0] = 0): If GPDMA_CxLLR.UB1 = 1, all GPDMA_CxBR1 fields are updated by the next LLI in the memory. If GPDMA_CxLLR.UB1 = 0 and if there is at least one not null Uxx update bit, this field is internally restored to the programmed value. if all GPDMA_CxLLR.Uxx = 0 and if GPDMA_CxLLR.LA[15:0] different 0, this field is internally restored to the programmed value (infinite/continuous last LLI). if GPDMA_CxLLR = 0, this field is kept as zero following the last LLI and data transfer.
$10000000 constant SEC_GPDMA2_GPDMA_C7BR1_SDEC                      \ source address decrement
$20000000 constant SEC_GPDMA2_GPDMA_C7BR1_DDEC                      \ destination address decrement
$40000000 constant SEC_GPDMA2_GPDMA_C7BR1_BRSDEC                    \ Block repeat source address decrement Note: On top of this increment/decrement (depending on BRSDEC), GPDMA_CxSAR is in the same time also updated by the increment/decrement (depending on SDEC) of the GPDMA_CxTR3.SAO value, as it is done after any programmed burst transfer.
$80000000 constant SEC_GPDMA2_GPDMA_C7BR1_BRDDEC                    \ Block repeat destination address decrement Note: On top of this increment/decrement (depending on BRDDEC), GPDMA_CxDAR is in the same time also updated by the increment/decrement (depending on DDEC) of the GPDMA_CxTR3.DAO value, as it is usually done at the end of each programmed burst transfer.


\
\ @brief GPDMA channel 7 source address register
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C7SAR_SA                        \ source address This field is the pointer to the address from which the next data is read. During the channel activity, depending on the source addressing mode (GPDMA_CxTR1.SINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.SDW_LOG2[1:0]) after each burst source data, reflecting the next address from which data is read. During the channel activity, this address is updated after each completed source burst, consequently to: the programmed source burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.SINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.SBL_1[5:0] and GPDMA_CxTR1.SDW_LOG2[21:0] the additional source incremented/decremented offset value as programmed by GPDMA_CxBR1.SDEC and GPDMA_CxTR3.SAO[12:0] once/if completed source block transfer, for a channel x with 2D addressing capability (x = 12 to 15). additional block repeat source incremented/decremented offset value as programmed by GPDMA_CxBR1.BRSDEC and GPDMA_CxBR2.BRSAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.USA = 1. Note: A source address must be aligned with the programmed data width of a source burst (SA[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued. When the source block size is not a multiple of the source burst size and is a multiple of the source data width, the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.


\
\ @brief GPDMA channel 7 destination address register
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$00000000 constant SEC_GPDMA2_GPDMA_C7DAR_DA                        \ destination address This field is the pointer to the address from which the next data is written. During the channel activity, depending on the destination addressing mode (GPDMA_CxTR1.DINC), this field is kept fixed or incremented by the data width (GPDMA_CxTR1.DDW_LOG2[21:0]) after each burst destination data, reflecting the next address from which data is written. During the channel activity, this address is updated after each completed destination burst, consequently to: the programmed destination burst; either in fixed addressing mode or in contiguous-data incremented mode. If contiguously incremented (GPDMA_CxTR1.DINC = 1), then the additional address offset value is the programmed burst size, as defined by GPDMA_CxTR1.DBL_1[5:0] and GPDMA_CxTR1.DDW_LOG2[1:0] the additional destination incremented/decremented offset value as programmed by GPDMA_CxBR1.DDEC and GPDMA_CxTR3.DAO[12:0] once/if completed destination block transfer, for a channel x with 2D addressing capability (x = 12 to 15), the additional block repeat destination incremented/decremented offset value as programmed by GPDMA_CxBR1.BRDDEC and GPDMA_CxBR2.BRDAO[15:0] In linked-list mode, after a LLI data transfer is completed, this register is automatically updated by the GPDMA from the memory, provided the LLI is set with GPDMA_CxLLR.UDA = 1. Note: A destination address must be aligned with the programmed data width of a destination burst (DA[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 7 transfer register 3
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$00001fff constant SEC_GPDMA2_GPDMA_C7TR3_SAO                       \ source address offset increment The source address, pointed by GPDMA_CxSAR, is incremented or decremented (depending on GPDMA_CxBR1.SDEC) by this offset SAO[12:0] for each programmed source burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.SINC = 1). Note: A source address offset must be aligned with the programmed data width of a source burst (SAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and none transfer is issued. When the source block size is not a multiple of the destination burst size and is a multiple of the source data width, then the last programmed source burst is not completed and is internally shorten to match the block size. In this case, the additional GPDMA_CxTR3.SAO[12:0] is not applied.
$1fff0000 constant SEC_GPDMA2_GPDMA_C7TR3_DAO                       \ destination address offset increment The destination address, pointed by GPDMA_CxDAR, is incremented or decremented (depending on GPDMA_CxBR1.DDEC) by this offset DAO[12:0] for each programmed destination burst. This offset is not including and is added to the programmed burst size when the completed burst is addressed in incremented mode (GPDMA_CxTR1.DINC = 1). Note: A destination address offset must be aligned with the programmed data width of a destination burst (DAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else, a user setting error is reported and no transfer is issued.


\
\ @brief GPDMA channel 7 block register 2
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$0000ffff constant SEC_GPDMA2_GPDMA_C7BR2_BRSAO                     \ Block repeated source address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRSDEC) the current source address (GPDMA_CxSAR) at the end of a block transfer. Note: A block repeated source address offset must be aligned with the programmed data width of a source burst (BRSAO[2:0] versus GPDMA_CxTR1.SDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. BRSAO[15:0] must be set to 0 in peripheral flow-control mode (if GPDMA_CxTR2.PFREQ = 1).
$ffff0000 constant SEC_GPDMA2_GPDMA_C7BR2_BRDAO                     \ Block repeated destination address offset For a channel with 2D addressing capability, this field is used to update (by addition or subtraction depending on GPDMA_CxBR1.BRDDEC) the current destination address (GPDMA_CxDAR) at the end of a block transfer. Note: A block repeated destination address offset must be aligned with the programmed data width of a destination burst (BRDAO[2:0] versus GPDMA_CxTR1.DDW_LOG2[1:0]). Else a user setting error is reported and no transfer is issued. BRDAO[15:0] must be set to 0 in peripheral flow-control mode (if GPDMA_CxTR2.PFREQ = 1).


\
\ @brief GPDMA channel 7 alternate linked-list address register
\ Address offset: 0x44C
\ Reset value: 0x00000000
\

$0000fffc constant SEC_GPDMA2_GPDMA_C7LLR_LA                        \ pointer (16-bit low-significant address) to the next linked-list data structure If UT1 = UT2 = UB1 = USA = UDA = ULL = 0 and if LA[15:20] = 0, the current LLI is the last one. The channel transfer is completed without any update of the linked-list GPDMA register file. Else, this field is the pointer to the memory address offset from which the next linked-list data structure is automatically fetched from, once the data transfer is completed, in order to conditionally update the linked-list GPDMA internal register file (GPDMA_CxCTR1, GPDMA_CxTR2, GPDMA_CxBR1, GPDMA_CxSAR, GPDMA_CxDAR and GPDMA_CxLLR). Note: The user must program the pointer to be 32-bit aligned. The two low-significant bits are write ignored.
$00010000 constant SEC_GPDMA2_GPDMA_C7LLR_ULL                       \ Update GPDMA_CxLLR register from memory This bit is used to control the update of GPDMA_CxLLR from the memory during the link transfer.
$02000000 constant SEC_GPDMA2_GPDMA_C7LLR_UB2                       \ Update GPDMA_CxBR2 from memory This bit controls the update of GPDMA_CxBR2 from the memory during the link transfer.
$04000000 constant SEC_GPDMA2_GPDMA_C7LLR_UT3                       \ Update GPDMA_CxTR3 from memory This bit controls the update of GPDMA_CxTR3 from the memory during the link transfer.
$08000000 constant SEC_GPDMA2_GPDMA_C7LLR_UDA                       \ Update GPDMA_CxDAR register from memory This bit is used to control the update of GPDMA_CxDAR from the memory during the link transfer.
$10000000 constant SEC_GPDMA2_GPDMA_C7LLR_USA                       \ update GPDMA_CxSAR from memory This bit controls the update of GPDMA_CxSAR from the memory during the link transfer.
$20000000 constant SEC_GPDMA2_GPDMA_C7LLR_UB1                       \ Update GPDMA_CxBR1 from memory This bit controls the update of GPDMA_CxBR1 from the memory during the link transfer. If UB1 = 0 and if GPDMA_CxLLR different 0, the linked-list is not completed. GPDMA_CxBR1.BNDT[15:0] is then restored to the programmed value after data transfer is completed and before the link transfer.
$40000000 constant SEC_GPDMA2_GPDMA_C7LLR_UT2                       \ Update GPDMA_CxTR2 from memory This bit controls the update of GPDMA_CxTR2 from the memory during the link transfer.
$80000000 constant SEC_GPDMA2_GPDMA_C7LLR_UT1                       \ Update GPDMA_CxTR1 from memory This bit controls the update of GPDMA_CxTR1 from the memory during the link transfer.


\
\ @brief General purpose direct memory access controller
\
$50021000 constant SEC_GPDMA2_GPDMA_SECCFGR  \ offset: 0x00 : GPDMA secure configuration register
$50021004 constant SEC_GPDMA2_GPDMA_PRIVCFGR  \ offset: 0x04 : GPDMA privileged configuration register
$50021008 constant SEC_GPDMA2_GPDMA_RCFGLOCKR  \ offset: 0x08 : GPDMA configuration lock register
$5002100c constant SEC_GPDMA2_GPDMA_MISR  \ offset: 0x0C : GPDMA non-secure masked interrupt status register
$50021010 constant SEC_GPDMA2_GPDMA_SMISR  \ offset: 0x10 : GPDMA secure masked interrupt status register
$50021050 constant SEC_GPDMA2_GPDMA_C0LBAR  \ offset: 0x50 : GPDMA channel 0 linked-list base address register
$5002105c constant SEC_GPDMA2_GPDMA_C0FCR  \ offset: 0x5C : GPDMA channel 0 flag clear register
$50021060 constant SEC_GPDMA2_GPDMA_C0SR  \ offset: 0x60 : GPDMA channel 0 status register
$50021064 constant SEC_GPDMA2_GPDMA_C0CR  \ offset: 0x64 : GPDMA channel 0 control register
$50021090 constant SEC_GPDMA2_GPDMA_C0TR1  \ offset: 0x90 : GPDMA channel 0 transfer register 1
$50021094 constant SEC_GPDMA2_GPDMA_C0TR2  \ offset: 0x94 : GPDMA channel 0 transfer register 2
$50021098 constant SEC_GPDMA2_GPDMA_C0BR1  \ offset: 0x98 : GPDMA channel 0 block register 1
$5002109c constant SEC_GPDMA2_GPDMA_C0SAR  \ offset: 0x9C : GPDMA channel 0 source address register
$500210a0 constant SEC_GPDMA2_GPDMA_C0DAR  \ offset: 0xA0 : GPDMA channel 0 destination address register
$500210cc constant SEC_GPDMA2_GPDMA_C0LLR  \ offset: 0xCC : GPDMA channel 0 linked-list address register
$500210d0 constant SEC_GPDMA2_GPDMA_C1LBAR  \ offset: 0xD0 : GPDMA channel 1 linked-list base address register
$500210dc constant SEC_GPDMA2_GPDMA_C1FCR  \ offset: 0xDC : GPDMA channel 1 flag clear register
$500210e0 constant SEC_GPDMA2_GPDMA_C1SR  \ offset: 0xE0 : GPDMA channel 1 status register
$500210e4 constant SEC_GPDMA2_GPDMA_C1CR  \ offset: 0xE4 : GPDMA channel 1 control register
$50021110 constant SEC_GPDMA2_GPDMA_C1TR1  \ offset: 0x110 : GPDMA channel 1 transfer register 1
$50021114 constant SEC_GPDMA2_GPDMA_C1TR2  \ offset: 0x114 : GPDMA channel 1 transfer register 2
$50021118 constant SEC_GPDMA2_GPDMA_C1BR1  \ offset: 0x118 : GPDMA channel 1 block register 1
$5002111c constant SEC_GPDMA2_GPDMA_C1SAR  \ offset: 0x11C : GPDMA channel 1 source address register
$50021120 constant SEC_GPDMA2_GPDMA_C1DAR  \ offset: 0x120 : GPDMA channel 1 destination address register
$5002114c constant SEC_GPDMA2_GPDMA_C1LLR  \ offset: 0x14C : GPDMA channel 1 linked-list address register
$50021150 constant SEC_GPDMA2_GPDMA_C2LBAR  \ offset: 0x150 : GPDMA channel 2 linked-list base address register
$5002115c constant SEC_GPDMA2_GPDMA_C2FCR  \ offset: 0x15C : GPDMA channel 2 flag clear register
$50021160 constant SEC_GPDMA2_GPDMA_C2SR  \ offset: 0x160 : GPDMA channel 2 status register
$50021164 constant SEC_GPDMA2_GPDMA_C2CR  \ offset: 0x164 : GPDMA channel 2 control register
$50021190 constant SEC_GPDMA2_GPDMA_C2TR1  \ offset: 0x190 : GPDMA channel 2 transfer register 1
$50021194 constant SEC_GPDMA2_GPDMA_C2TR2  \ offset: 0x194 : GPDMA channel 2 transfer register 2
$50021198 constant SEC_GPDMA2_GPDMA_C2BR1  \ offset: 0x198 : GPDMA channel 2 block register 1
$5002119c constant SEC_GPDMA2_GPDMA_C2SAR  \ offset: 0x19C : GPDMA channel 2 source address register
$500211a0 constant SEC_GPDMA2_GPDMA_C2DAR  \ offset: 0x1A0 : GPDMA channel 2 destination address register
$500211cc constant SEC_GPDMA2_GPDMA_C2LLR  \ offset: 0x1CC : GPDMA channel 2 linked-list address register
$500211d0 constant SEC_GPDMA2_GPDMA_C3LBAR  \ offset: 0x1D0 : GPDMA channel 3 linked-list base address register
$500211dc constant SEC_GPDMA2_GPDMA_C3FCR  \ offset: 0x1DC : GPDMA channel 3 flag clear register
$500211e0 constant SEC_GPDMA2_GPDMA_C3SR  \ offset: 0x1E0 : GPDMA channel 3 status register
$500211e4 constant SEC_GPDMA2_GPDMA_C3CR  \ offset: 0x1E4 : GPDMA channel 3 control register
$50021210 constant SEC_GPDMA2_GPDMA_C3TR1  \ offset: 0x210 : GPDMA channel 3 transfer register 1
$50021214 constant SEC_GPDMA2_GPDMA_C3TR2  \ offset: 0x214 : GPDMA channel 3 transfer register 2
$50021218 constant SEC_GPDMA2_GPDMA_C3BR1  \ offset: 0x218 : GPDMA channel 3 block register 1
$5002121c constant SEC_GPDMA2_GPDMA_C3SAR  \ offset: 0x21C : GPDMA channel 3 source address register
$50021220 constant SEC_GPDMA2_GPDMA_C3DAR  \ offset: 0x220 : GPDMA channel 3 destination address register
$5002124c constant SEC_GPDMA2_GPDMA_C3LLR  \ offset: 0x24C : GPDMA channel 3 linked-list address register
$50021250 constant SEC_GPDMA2_GPDMA_C4LBAR  \ offset: 0x250 : GPDMA channel 4 linked-list base address register
$5002125c constant SEC_GPDMA2_GPDMA_C4FCR  \ offset: 0x25C : GPDMA channel 4 flag clear register
$50021260 constant SEC_GPDMA2_GPDMA_C4SR  \ offset: 0x260 : GPDMA channel 4 status register
$50021264 constant SEC_GPDMA2_GPDMA_C4CR  \ offset: 0x264 : GPDMA channel 4 control register
$50021290 constant SEC_GPDMA2_GPDMA_C4TR1  \ offset: 0x290 : GPDMA channel 4 transfer register 1
$50021294 constant SEC_GPDMA2_GPDMA_C4TR2  \ offset: 0x294 : GPDMA channel 4 transfer register 2
$50021298 constant SEC_GPDMA2_GPDMA_C4BR1  \ offset: 0x298 : GPDMA channel 4 block register 1
$5002129c constant SEC_GPDMA2_GPDMA_C4SAR  \ offset: 0x29C : GPDMA channel 4 source address register
$500212a0 constant SEC_GPDMA2_GPDMA_C4DAR  \ offset: 0x2A0 : GPDMA channel 4 destination address register
$500212cc constant SEC_GPDMA2_GPDMA_C4LLR  \ offset: 0x2CC : GPDMA channel 4 linked-list address register
$500212d0 constant SEC_GPDMA2_GPDMA_C5LBAR  \ offset: 0x2D0 : GPDMA channel 5 linked-list base address register
$500212dc constant SEC_GPDMA2_GPDMA_C5FCR  \ offset: 0x2DC : GPDMA channel 5 flag clear register
$500212e0 constant SEC_GPDMA2_GPDMA_C5SR  \ offset: 0x2E0 : GPDMA channel 5 status register
$500212e4 constant SEC_GPDMA2_GPDMA_C5CR  \ offset: 0x2E4 : GPDMA channel 5 control register
$50021310 constant SEC_GPDMA2_GPDMA_C5TR1  \ offset: 0x310 : GPDMA channel 5 transfer register 1
$50021314 constant SEC_GPDMA2_GPDMA_C5TR2  \ offset: 0x314 : GPDMA channel 5 transfer register 2
$50021318 constant SEC_GPDMA2_GPDMA_C5BR1  \ offset: 0x318 : GPDMA channel 5 block register 1
$5002131c constant SEC_GPDMA2_GPDMA_C5SAR  \ offset: 0x31C : GPDMA channel 5 source address register
$50021320 constant SEC_GPDMA2_GPDMA_C5DAR  \ offset: 0x320 : GPDMA channel 5 destination address register
$5002134c constant SEC_GPDMA2_GPDMA_C5LLR  \ offset: 0x34C : GPDMA channel 5 linked-list address register
$50021350 constant SEC_GPDMA2_GPDMA_C6LBAR  \ offset: 0x350 : GPDMA channel 6 linked-list base address register
$5002135c constant SEC_GPDMA2_GPDMA_C6FCR  \ offset: 0x35C : GPDMA channel 6 flag clear register
$50021360 constant SEC_GPDMA2_GPDMA_C6SR  \ offset: 0x360 : GPDMA channel 6 status register
$50021364 constant SEC_GPDMA2_GPDMA_C6CR  \ offset: 0x364 : GPDMA channel 6 control register
$50021390 constant SEC_GPDMA2_GPDMA_C6TR1  \ offset: 0x390 : GPDMA channel 6 transfer register 1
$50021394 constant SEC_GPDMA2_GPDMA_C6TR2  \ offset: 0x394 : GPDMA channel 6 transfer register 2
$50021398 constant SEC_GPDMA2_GPDMA_C6BR1  \ offset: 0x398 : GPDMA channel 6 alternate block register 1
$5002139c constant SEC_GPDMA2_GPDMA_C6SAR  \ offset: 0x39C : GPDMA channel 6 source address register
$500213a0 constant SEC_GPDMA2_GPDMA_C6DAR  \ offset: 0x3A0 : GPDMA channel 6 destination address register
$500213a4 constant SEC_GPDMA2_GPDMA_C6TR3  \ offset: 0x3A4 : GPDMA channel 6 transfer register 3
$500213a8 constant SEC_GPDMA2_GPDMA_C6BR2  \ offset: 0x3A8 : GPDMA channel 6 block register 2
$500213cc constant SEC_GPDMA2_GPDMA_C6LLR  \ offset: 0x3CC : GPDMA channel 6 alternate linked-list address register
$500213d0 constant SEC_GPDMA2_GPDMA_C7LBAR  \ offset: 0x3D0 : GPDMA channel 7 linked-list base address register
$500213dc constant SEC_GPDMA2_GPDMA_C7FCR  \ offset: 0x3DC : GPDMA channel 7 flag clear register
$500213e0 constant SEC_GPDMA2_GPDMA_C7SR  \ offset: 0x3E0 : GPDMA channel 7 status register
$500213e4 constant SEC_GPDMA2_GPDMA_C7CR  \ offset: 0x3E4 : GPDMA channel 7 control register
$50021410 constant SEC_GPDMA2_GPDMA_C7TR1  \ offset: 0x410 : GPDMA channel 7 transfer register 1
$50021414 constant SEC_GPDMA2_GPDMA_C7TR2  \ offset: 0x414 : GPDMA channel 7 transfer register 2
$50021418 constant SEC_GPDMA2_GPDMA_C7BR1  \ offset: 0x418 : GPDMA channel 7 alternate block register 1
$5002141c constant SEC_GPDMA2_GPDMA_C7SAR  \ offset: 0x41C : GPDMA channel 7 source address register
$50021420 constant SEC_GPDMA2_GPDMA_C7DAR  \ offset: 0x420 : GPDMA channel 7 destination address register
$50021424 constant SEC_GPDMA2_GPDMA_C7TR3  \ offset: 0x424 : GPDMA channel 7 transfer register 3
$50021428 constant SEC_GPDMA2_GPDMA_C7BR2  \ offset: 0x428 : GPDMA channel 7 block register 2
$5002144c constant SEC_GPDMA2_GPDMA_C7LLR  \ offset: 0x44C : GPDMA channel 7 alternate linked-list address register

