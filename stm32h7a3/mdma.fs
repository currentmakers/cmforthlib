\
\ @file mdma.fs
\ @brief MDMA
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] MDMA_DEF

  [ifdef] MDMA_GISR0_DEF
    \
    \ @brief MDMA Global Interrupt/Status Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_GIF0                      \ [0x00] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $01 constant MDMA_GIF1                      \ [0x01] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $02 constant MDMA_GIF2                      \ [0x02] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $03 constant MDMA_GIF3                      \ [0x03] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $04 constant MDMA_GIF4                      \ [0x04] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $05 constant MDMA_GIF5                      \ [0x05] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $06 constant MDMA_GIF6                      \ [0x06] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $07 constant MDMA_GIF7                      \ [0x07] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $08 constant MDMA_GIF8                      \ [0x08] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $09 constant MDMA_GIF9                      \ [0x09] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $0a constant MDMA_GIF10                     \ [0x0a] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $0b constant MDMA_GIF11                     \ [0x0b] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $0c constant MDMA_GIF12                     \ [0x0c] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $0d constant MDMA_GIF13                     \ [0x0d] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $0e constant MDMA_GIF14                     \ [0x0e] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
    $0f constant MDMA_GIF15                     \ [0x0f] Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
  [then]


  [ifdef] MDMA_C0ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF0                     \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF0                    \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF0                    \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF0                     \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF0                     \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA0                     \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C0IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF0                    \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF0                   \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF0                   \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF0                    \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF0                   \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C0ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C0CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C0TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C0BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C0SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C0DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C0BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C0LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C0TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C0MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C0MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C1ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF1                     \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF1                    \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF1                    \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF1                     \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF1                     \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA1                     \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C1IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF1                    \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF1                   \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF1                   \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF1                    \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF1                   \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C1ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C1CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C1TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C1BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C1SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C1DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C1BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C1LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C1TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C1MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C1MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C2ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF2                     \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF2                    \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF2                    \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF2                     \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF2                     \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA2                     \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C2IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF2                    \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF2                   \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF2                   \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF2                    \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF2                   \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C2ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C2CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C2TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C2BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C2SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C2DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C2BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C2LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C2TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C2MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C2MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C3ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF3                     \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF3                    \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF3                    \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF3                     \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF3                     \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA3                     \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C3IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF3                    \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF3                   \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF3                   \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF3                    \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF3                   \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C3ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C3CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C3TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C3BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C3SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C3DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C3BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C3LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C3TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C3MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C3MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C4ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF4                     \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF4                    \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF4                    \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF4                     \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF4                     \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA4                     \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C4IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF4                    \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF4                   \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF4                   \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF4                    \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF4                   \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C4ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C4CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C4TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C4BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C4SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C4DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C4BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C4LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C4TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C4MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C4MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C5ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF5                     \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF5                    \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF5                    \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF5                     \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF5                     \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA5                     \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C5IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF5                    \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF5                   \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF5                   \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF5                    \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF5                   \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C5ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C5CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C5TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C5BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C5SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C5DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C5BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C5LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C5TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C5MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C5MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C6ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF6                     \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF6                    \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF6                    \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF6                     \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF6                     \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA6                     \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C6IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF6                    \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF6                   \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF6                   \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF6                    \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF6                   \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C6ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C6CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C6TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C6BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0
  [then]


  [ifdef] MDMA_C6SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x1D8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C6DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C6BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C6LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C6TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C6MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C6MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C7ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF7                     \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF7                    \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF7                    \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF7                     \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF7                     \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA7                     \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C7IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF7                    \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF7                   \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF7                   \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF7                    \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF7                   \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C7ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C7CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C7TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C7BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C7SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C7DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C7BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C7LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C7TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C7MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C7MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C8ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF8                     \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF8                    \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF8                    \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF8                     \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF8                     \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA8                     \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C8IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF8                    \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF8                   \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF8                   \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF8                    \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF8                   \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C8ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C8CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C8TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C8BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C8SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C8DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C8BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C8LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C8TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C8MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C8MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C9ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF9                     \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF9                    \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF9                    \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF9                     \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF9                     \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA9                     \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C9IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF9                    \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF9                   \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF9                   \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF9                    \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF9                   \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C9ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C9CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C9TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C9BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C9SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C9DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C9BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C9LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C9TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C9MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C9MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C10ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x2C0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF10                    \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF10                   \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF10                   \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF10                    \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF10                    \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA10                    \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C10IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x2C4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF10                   \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF10                  \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF10                  \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF10                   \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF10                  \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C10ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x2C8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C10CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C10TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C10BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x2D4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C10SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x2D8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C10DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C10BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x2E0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C10LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C10TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x2E8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C10MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x2F0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C10MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x2F4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C11ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF11                    \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF11                   \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF11                   \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF11                    \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF11                    \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA11                    \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C11IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF11                   \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF11                  \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF11                  \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF11                   \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF11                  \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C11ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C11CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C11TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C11BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C11SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C11DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C11BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C11LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C11TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C11MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C11MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C12ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF12                    \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF12                   \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF12                   \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF12                    \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF12                    \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA12                    \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C12IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x344
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF12                   \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF12                  \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF12                  \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF12                   \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF12                  \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C12ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x348
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C12CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C12TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C12BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x354
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C12SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x358
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C12DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C12BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x360
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C12LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C12TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x368
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C12MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C12MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x374
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C13ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF13                    \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF13                   \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF13                   \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF13                    \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF13                    \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA13                    \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C13IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF13                   \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF13                  \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF13                  \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF13                   \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF13                  \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C13ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x388
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C13CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x38C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C13TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C13BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C13SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C13DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C13BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C13LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x3A4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C13TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x3A8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C13MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x3B0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C13MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x3B4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C14ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x3C0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF14                    \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF14                   \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF14                   \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF14                    \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF14                    \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA14                    \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C14IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x3C4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF14                   \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF14                  \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF14                  \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF14                   \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF14                  \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C14ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x3C8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C14CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C14TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C14BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x3D4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C14SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x3D8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C14DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C14BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C14LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C14TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C14MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C14MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]


  [ifdef] MDMA_C15ISR_DEF
    \
    \ @brief MDMA channel x interrupt/status register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF15                    \ [0x00] Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $01 constant MDMA_CTCIF15                   \ [0x01] Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
    $02 constant MDMA_BRTIF15                   \ [0x02] Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $03 constant MDMA_BTIF15                    \ [0x03] Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
    $04 constant MDMA_TCIF15                    \ [0x04] channel x buffer transfer complete
    $10 constant MDMA_CRQA15                    \ [0x10] channel x request active flag
  [then]


  [ifdef] MDMA_C15IFCR_DEF
    \
    \ @brief MDMA channel x interrupt flag clear register
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF15                   \ [0x00] Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
    $01 constant MDMA_CCTCIF15                  \ [0x01] Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
    $02 constant MDMA_CBRTIF15                  \ [0x02] Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
    $03 constant MDMA_CBTIF15                   \ [0x03] Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
    $04 constant MDMA_CLTCIF15                  \ [0x04] CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register
  [then]


  [ifdef] MDMA_C15ESR_DEF
    \
    \ @brief MDMA Channel x error status register
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
    $07 constant MDMA_TED                       \ [0x07] Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
    $08 constant MDMA_TELD                      \ [0x08] Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $09 constant MDMA_TEMD                      \ [0x09] Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0a constant MDMA_ASE                       \ [0x0a] Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
    $0b constant MDMA_BSE                       \ [0x0b] Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
  [then]


  [ifdef] MDMA_C15CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] channel enable
    $01 constant MDMA_TEIE                      \ [0x01] Transfer error interrupt enable This bit is set and cleared by software.
    $02 constant MDMA_CTCIE                     \ [0x02] Channel Transfer Complete interrupt enable This bit is set and cleared by software.
    $03 constant MDMA_BRTIE                     \ [0x03] Block Repeat transfer interrupt enable This bit is set and cleared by software.
    $04 constant MDMA_BTIE                      \ [0x04] Block Transfer interrupt enable This bit is set and cleared by software.
    $05 constant MDMA_TCIE                      \ [0x05] buffer Transfer Complete interrupt enable This bit is set and cleared by software.
    $06 constant MDMA_PL                        \ [0x06 : 2] Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
    $0c constant MDMA_BEX                       \ [0x0c] byte Endianness exchange
    $0d constant MDMA_HEX                       \ [0x0d] Half word Endianes exchange
    $0e constant MDMA_WEX                       \ [0x0e] Word Endianness exchange
    $10 constant MDMA_SWRQ                      \ [0x10] SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).
  [then]


  [ifdef] MDMA_C15TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel.
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    $02 constant MDMA_DINC                      \ [0x02 : 2] Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] source increment offset size
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] Destination increment offset
    $0c constant MDMA_SBURST                    \ [0x0c : 3] source burst transfer configuration
    $0f constant MDMA_DBURST                    \ [0x0f : 3] Destination burst transfer configuration
    $12 constant MDMA_TLEN                      \ [0x12 : 7] buffer transfer lengh
    $19 constant MDMA_PKE                       \ [0x19] PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
    $1a constant MDMA_PAM                       \ [0x1a : 2] Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
    $1c constant MDMA_TRGM                      \ [0x1c : 2] Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
    $1e constant MDMA_SWRM                      \ [0x1e] SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
    $1f constant MDMA_BWM                       \ [0x1f] Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.
  [then]


  [ifdef] MDMA_C15BNDTR_DEF
    \
    \ @brief MDMA Channel x block number of data register
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] block number of data to transfer
    $12 constant MDMA_BRSUM                     \ [0x12] Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
    $13 constant MDMA_BRDUM                     \ [0x13] Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
    $14 constant MDMA_BRC                       \ [0x14 : 12] Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C15SAR_DEF
    \
    \ @brief MDMA channel x source address register
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] source adr base
  [then]


  [ifdef] MDMA_C15DAR_DEF
    \
    \ @brief MDMA channel x destination address register
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] Destination adr base
  [then]


  [ifdef] MDMA_C15BRUR_DEF
    \
    \ @brief MDMA channel x Block Repeat address Update register
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] source adresse update value
    $10 constant MDMA_DUV                       \ [0x10 : 16] destination address update
  [then]


  [ifdef] MDMA_C15LAR_DEF
    \
    \ @brief MDMA channel x Link Address register
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] Link address register
  [then]


  [ifdef] MDMA_C15TBR_DEF
    \
    \ @brief MDMA channel x Trigger and Bus selection Register
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] Trigger selection
    $10 constant MDMA_SBUS                      \ [0x10] Source BUS select This bit is protected and can be written only if EN is 0.
    $11 constant MDMA_DBUS                      \ [0x11] Destination BUS slect This bit is protected and can be written only if EN is 0.
  [then]


  [ifdef] MDMA_C15MAR_DEF
    \
    \ @brief MDMA channel x Mask address register
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] Mask address
  [then]


  [ifdef] MDMA_C15MDR_DEF
    \
    \ @brief MDMA channel x Mask Data register
    \ Address offset: 0x434
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] Mask data
  [then]

  \
  \ @brief MDMA
  \
  $00 constant MDMA_GISR0               \ MDMA Global Interrupt/Status Register
  $40 constant MDMA_C0ISR               \ MDMA channel x interrupt/status register
  $44 constant MDMA_C0IFCR              \ MDMA channel x interrupt flag clear register
  $48 constant MDMA_C0ESR               \ MDMA Channel x error status register
  $4C constant MDMA_C0CR                \ This register is used to control the concerned channel.
  $50 constant MDMA_C0TCR               \ This register is used to configure the concerned channel.
  $54 constant MDMA_C0BNDTR             \ MDMA Channel x block number of data register
  $58 constant MDMA_C0SAR               \ MDMA channel x source address register
  $5C constant MDMA_C0DAR               \ MDMA channel x destination address register
  $60 constant MDMA_C0BRUR              \ MDMA channel x Block Repeat address Update register
  $64 constant MDMA_C0LAR               \ MDMA channel x Link Address register
  $68 constant MDMA_C0TBR               \ MDMA channel x Trigger and Bus selection Register
  $70 constant MDMA_C0MAR               \ MDMA channel x Mask address register
  $74 constant MDMA_C0MDR               \ MDMA channel x Mask Data register
  $80 constant MDMA_C1ISR               \ MDMA channel x interrupt/status register
  $84 constant MDMA_C1IFCR              \ MDMA channel x interrupt flag clear register
  $88 constant MDMA_C1ESR               \ MDMA Channel x error status register
  $8C constant MDMA_C1CR                \ This register is used to control the concerned channel.
  $90 constant MDMA_C1TCR               \ This register is used to configure the concerned channel.
  $94 constant MDMA_C1BNDTR             \ MDMA Channel x block number of data register
  $98 constant MDMA_C1SAR               \ MDMA channel x source address register
  $9C constant MDMA_C1DAR               \ MDMA channel x destination address register
  $A0 constant MDMA_C1BRUR              \ MDMA channel x Block Repeat address Update register
  $A4 constant MDMA_C1LAR               \ MDMA channel x Link Address register
  $A8 constant MDMA_C1TBR               \ MDMA channel x Trigger and Bus selection Register
  $B0 constant MDMA_C1MAR               \ MDMA channel x Mask address register
  $B4 constant MDMA_C1MDR               \ MDMA channel x Mask Data register
  $C0 constant MDMA_C2ISR               \ MDMA channel x interrupt/status register
  $C4 constant MDMA_C2IFCR              \ MDMA channel x interrupt flag clear register
  $C8 constant MDMA_C2ESR               \ MDMA Channel x error status register
  $CC constant MDMA_C2CR                \ This register is used to control the concerned channel.
  $D0 constant MDMA_C2TCR               \ This register is used to configure the concerned channel.
  $D4 constant MDMA_C2BNDTR             \ MDMA Channel x block number of data register
  $D8 constant MDMA_C2SAR               \ MDMA channel x source address register
  $DC constant MDMA_C2DAR               \ MDMA channel x destination address register
  $E0 constant MDMA_C2BRUR              \ MDMA channel x Block Repeat address Update register
  $E4 constant MDMA_C2LAR               \ MDMA channel x Link Address register
  $E8 constant MDMA_C2TBR               \ MDMA channel x Trigger and Bus selection Register
  $F0 constant MDMA_C2MAR               \ MDMA channel x Mask address register
  $F4 constant MDMA_C2MDR               \ MDMA channel x Mask Data register
  $100 constant MDMA_C3ISR              \ MDMA channel x interrupt/status register
  $104 constant MDMA_C3IFCR             \ MDMA channel x interrupt flag clear register
  $108 constant MDMA_C3ESR              \ MDMA Channel x error status register
  $10C constant MDMA_C3CR               \ This register is used to control the concerned channel.
  $110 constant MDMA_C3TCR              \ This register is used to configure the concerned channel.
  $114 constant MDMA_C3BNDTR            \ MDMA Channel x block number of data register
  $118 constant MDMA_C3SAR              \ MDMA channel x source address register
  $11C constant MDMA_C3DAR              \ MDMA channel x destination address register
  $120 constant MDMA_C3BRUR             \ MDMA channel x Block Repeat address Update register
  $124 constant MDMA_C3LAR              \ MDMA channel x Link Address register
  $128 constant MDMA_C3TBR              \ MDMA channel x Trigger and Bus selection Register
  $130 constant MDMA_C3MAR              \ MDMA channel x Mask address register
  $134 constant MDMA_C3MDR              \ MDMA channel x Mask Data register
  $140 constant MDMA_C4ISR              \ MDMA channel x interrupt/status register
  $144 constant MDMA_C4IFCR             \ MDMA channel x interrupt flag clear register
  $148 constant MDMA_C4ESR              \ MDMA Channel x error status register
  $14C constant MDMA_C4CR               \ This register is used to control the concerned channel.
  $150 constant MDMA_C4TCR              \ This register is used to configure the concerned channel.
  $154 constant MDMA_C4BNDTR            \ MDMA Channel x block number of data register
  $158 constant MDMA_C4SAR              \ MDMA channel x source address register
  $15C constant MDMA_C4DAR              \ MDMA channel x destination address register
  $160 constant MDMA_C4BRUR             \ MDMA channel x Block Repeat address Update register
  $164 constant MDMA_C4LAR              \ MDMA channel x Link Address register
  $168 constant MDMA_C4TBR              \ MDMA channel x Trigger and Bus selection Register
  $170 constant MDMA_C4MAR              \ MDMA channel x Mask address register
  $174 constant MDMA_C4MDR              \ MDMA channel x Mask Data register
  $180 constant MDMA_C5ISR              \ MDMA channel x interrupt/status register
  $184 constant MDMA_C5IFCR             \ MDMA channel x interrupt flag clear register
  $188 constant MDMA_C5ESR              \ MDMA Channel x error status register
  $18C constant MDMA_C5CR               \ This register is used to control the concerned channel.
  $190 constant MDMA_C5TCR              \ This register is used to configure the concerned channel.
  $194 constant MDMA_C5BNDTR            \ MDMA Channel x block number of data register
  $198 constant MDMA_C5SAR              \ MDMA channel x source address register
  $19C constant MDMA_C5DAR              \ MDMA channel x destination address register
  $1A0 constant MDMA_C5BRUR             \ MDMA channel x Block Repeat address Update register
  $1A4 constant MDMA_C5LAR              \ MDMA channel x Link Address register
  $1A8 constant MDMA_C5TBR              \ MDMA channel x Trigger and Bus selection Register
  $1B0 constant MDMA_C5MAR              \ MDMA channel x Mask address register
  $1B4 constant MDMA_C5MDR              \ MDMA channel x Mask Data register
  $1C0 constant MDMA_C6ISR              \ MDMA channel x interrupt/status register
  $1C4 constant MDMA_C6IFCR             \ MDMA channel x interrupt flag clear register
  $1C8 constant MDMA_C6ESR              \ MDMA Channel x error status register
  $1CC constant MDMA_C6CR               \ This register is used to control the concerned channel.
  $1D0 constant MDMA_C6TCR              \ This register is used to configure the concerned channel.
  $1D4 constant MDMA_C6BNDTR            \ MDMA Channel x block number of data register
  $1D8 constant MDMA_C6SAR              \ MDMA channel x source address register
  $1DC constant MDMA_C6DAR              \ MDMA channel x destination address register
  $1E0 constant MDMA_C6BRUR             \ MDMA channel x Block Repeat address Update register
  $1E4 constant MDMA_C6LAR              \ MDMA channel x Link Address register
  $1E8 constant MDMA_C6TBR              \ MDMA channel x Trigger and Bus selection Register
  $1F0 constant MDMA_C6MAR              \ MDMA channel x Mask address register
  $1F4 constant MDMA_C6MDR              \ MDMA channel x Mask Data register
  $200 constant MDMA_C7ISR              \ MDMA channel x interrupt/status register
  $204 constant MDMA_C7IFCR             \ MDMA channel x interrupt flag clear register
  $208 constant MDMA_C7ESR              \ MDMA Channel x error status register
  $20C constant MDMA_C7CR               \ This register is used to control the concerned channel.
  $210 constant MDMA_C7TCR              \ This register is used to configure the concerned channel.
  $214 constant MDMA_C7BNDTR            \ MDMA Channel x block number of data register
  $218 constant MDMA_C7SAR              \ MDMA channel x source address register
  $21C constant MDMA_C7DAR              \ MDMA channel x destination address register
  $220 constant MDMA_C7BRUR             \ MDMA channel x Block Repeat address Update register
  $224 constant MDMA_C7LAR              \ MDMA channel x Link Address register
  $228 constant MDMA_C7TBR              \ MDMA channel x Trigger and Bus selection Register
  $230 constant MDMA_C7MAR              \ MDMA channel x Mask address register
  $234 constant MDMA_C7MDR              \ MDMA channel x Mask Data register
  $240 constant MDMA_C8ISR              \ MDMA channel x interrupt/status register
  $244 constant MDMA_C8IFCR             \ MDMA channel x interrupt flag clear register
  $248 constant MDMA_C8ESR              \ MDMA Channel x error status register
  $24C constant MDMA_C8CR               \ This register is used to control the concerned channel.
  $250 constant MDMA_C8TCR              \ This register is used to configure the concerned channel.
  $254 constant MDMA_C8BNDTR            \ MDMA Channel x block number of data register
  $258 constant MDMA_C8SAR              \ MDMA channel x source address register
  $25C constant MDMA_C8DAR              \ MDMA channel x destination address register
  $260 constant MDMA_C8BRUR             \ MDMA channel x Block Repeat address Update register
  $264 constant MDMA_C8LAR              \ MDMA channel x Link Address register
  $268 constant MDMA_C8TBR              \ MDMA channel x Trigger and Bus selection Register
  $270 constant MDMA_C8MAR              \ MDMA channel x Mask address register
  $274 constant MDMA_C8MDR              \ MDMA channel x Mask Data register
  $280 constant MDMA_C9ISR              \ MDMA channel x interrupt/status register
  $284 constant MDMA_C9IFCR             \ MDMA channel x interrupt flag clear register
  $288 constant MDMA_C9ESR              \ MDMA Channel x error status register
  $28C constant MDMA_C9CR               \ This register is used to control the concerned channel.
  $290 constant MDMA_C9TCR              \ This register is used to configure the concerned channel.
  $294 constant MDMA_C9BNDTR            \ MDMA Channel x block number of data register
  $298 constant MDMA_C9SAR              \ MDMA channel x source address register
  $29C constant MDMA_C9DAR              \ MDMA channel x destination address register
  $2A0 constant MDMA_C9BRUR             \ MDMA channel x Block Repeat address Update register
  $2A4 constant MDMA_C9LAR              \ MDMA channel x Link Address register
  $2A8 constant MDMA_C9TBR              \ MDMA channel x Trigger and Bus selection Register
  $2B0 constant MDMA_C9MAR              \ MDMA channel x Mask address register
  $2B4 constant MDMA_C9MDR              \ MDMA channel x Mask Data register
  $2C0 constant MDMA_C10ISR             \ MDMA channel x interrupt/status register
  $2C4 constant MDMA_C10IFCR            \ MDMA channel x interrupt flag clear register
  $2C8 constant MDMA_C10ESR             \ MDMA Channel x error status register
  $2CC constant MDMA_C10CR              \ This register is used to control the concerned channel.
  $2D0 constant MDMA_C10TCR             \ This register is used to configure the concerned channel.
  $2D4 constant MDMA_C10BNDTR           \ MDMA Channel x block number of data register
  $2D8 constant MDMA_C10SAR             \ MDMA channel x source address register
  $2DC constant MDMA_C10DAR             \ MDMA channel x destination address register
  $2E0 constant MDMA_C10BRUR            \ MDMA channel x Block Repeat address Update register
  $2E4 constant MDMA_C10LAR             \ MDMA channel x Link Address register
  $2E8 constant MDMA_C10TBR             \ MDMA channel x Trigger and Bus selection Register
  $2F0 constant MDMA_C10MAR             \ MDMA channel x Mask address register
  $2F4 constant MDMA_C10MDR             \ MDMA channel x Mask Data register
  $300 constant MDMA_C11ISR             \ MDMA channel x interrupt/status register
  $304 constant MDMA_C11IFCR            \ MDMA channel x interrupt flag clear register
  $308 constant MDMA_C11ESR             \ MDMA Channel x error status register
  $30C constant MDMA_C11CR              \ This register is used to control the concerned channel.
  $310 constant MDMA_C11TCR             \ This register is used to configure the concerned channel.
  $314 constant MDMA_C11BNDTR           \ MDMA Channel x block number of data register
  $318 constant MDMA_C11SAR             \ MDMA channel x source address register
  $31C constant MDMA_C11DAR             \ MDMA channel x destination address register
  $320 constant MDMA_C11BRUR            \ MDMA channel x Block Repeat address Update register
  $324 constant MDMA_C11LAR             \ MDMA channel x Link Address register
  $328 constant MDMA_C11TBR             \ MDMA channel x Trigger and Bus selection Register
  $330 constant MDMA_C11MAR             \ MDMA channel x Mask address register
  $334 constant MDMA_C11MDR             \ MDMA channel x Mask Data register
  $340 constant MDMA_C12ISR             \ MDMA channel x interrupt/status register
  $344 constant MDMA_C12IFCR            \ MDMA channel x interrupt flag clear register
  $348 constant MDMA_C12ESR             \ MDMA Channel x error status register
  $34C constant MDMA_C12CR              \ This register is used to control the concerned channel.
  $350 constant MDMA_C12TCR             \ This register is used to configure the concerned channel.
  $354 constant MDMA_C12BNDTR           \ MDMA Channel x block number of data register
  $358 constant MDMA_C12SAR             \ MDMA channel x source address register
  $35C constant MDMA_C12DAR             \ MDMA channel x destination address register
  $360 constant MDMA_C12BRUR            \ MDMA channel x Block Repeat address Update register
  $364 constant MDMA_C12LAR             \ MDMA channel x Link Address register
  $368 constant MDMA_C12TBR             \ MDMA channel x Trigger and Bus selection Register
  $370 constant MDMA_C12MAR             \ MDMA channel x Mask address register
  $374 constant MDMA_C12MDR             \ MDMA channel x Mask Data register
  $380 constant MDMA_C13ISR             \ MDMA channel x interrupt/status register
  $384 constant MDMA_C13IFCR            \ MDMA channel x interrupt flag clear register
  $388 constant MDMA_C13ESR             \ MDMA Channel x error status register
  $38C constant MDMA_C13CR              \ This register is used to control the concerned channel.
  $390 constant MDMA_C13TCR             \ This register is used to configure the concerned channel.
  $394 constant MDMA_C13BNDTR           \ MDMA Channel x block number of data register
  $398 constant MDMA_C13SAR             \ MDMA channel x source address register
  $39C constant MDMA_C13DAR             \ MDMA channel x destination address register
  $3A0 constant MDMA_C13BRUR            \ MDMA channel x Block Repeat address Update register
  $3A4 constant MDMA_C13LAR             \ MDMA channel x Link Address register
  $3A8 constant MDMA_C13TBR             \ MDMA channel x Trigger and Bus selection Register
  $3B0 constant MDMA_C13MAR             \ MDMA channel x Mask address register
  $3B4 constant MDMA_C13MDR             \ MDMA channel x Mask Data register
  $3C0 constant MDMA_C14ISR             \ MDMA channel x interrupt/status register
  $3C4 constant MDMA_C14IFCR            \ MDMA channel x interrupt flag clear register
  $3C8 constant MDMA_C14ESR             \ MDMA Channel x error status register
  $3CC constant MDMA_C14CR              \ This register is used to control the concerned channel.
  $3D0 constant MDMA_C14TCR             \ This register is used to configure the concerned channel.
  $3D4 constant MDMA_C14BNDTR           \ MDMA Channel x block number of data register
  $3D8 constant MDMA_C14SAR             \ MDMA channel x source address register
  $3DC constant MDMA_C14DAR             \ MDMA channel x destination address register
  $3E0 constant MDMA_C14BRUR            \ MDMA channel x Block Repeat address Update register
  $3E4 constant MDMA_C14LAR             \ MDMA channel x Link Address register
  $3E8 constant MDMA_C14TBR             \ MDMA channel x Trigger and Bus selection Register
  $3F0 constant MDMA_C14MAR             \ MDMA channel x Mask address register
  $3F4 constant MDMA_C14MDR             \ MDMA channel x Mask Data register
  $400 constant MDMA_C15ISR             \ MDMA channel x interrupt/status register
  $404 constant MDMA_C15IFCR            \ MDMA channel x interrupt flag clear register
  $408 constant MDMA_C15ESR             \ MDMA Channel x error status register
  $40C constant MDMA_C15CR              \ This register is used to control the concerned channel.
  $410 constant MDMA_C15TCR             \ This register is used to configure the concerned channel.
  $414 constant MDMA_C15BNDTR           \ MDMA Channel x block number of data register
  $418 constant MDMA_C15SAR             \ MDMA channel x source address register
  $41C constant MDMA_C15DAR             \ MDMA channel x destination address register
  $420 constant MDMA_C15BRUR            \ MDMA channel x Block Repeat address Update register
  $424 constant MDMA_C15LAR             \ MDMA channel x Link Address register
  $428 constant MDMA_C15TBR             \ MDMA channel x Trigger and Bus selection Register
  $430 constant MDMA_C15MAR             \ MDMA channel x Mask address register
  $434 constant MDMA_C15MDR             \ MDMA channel x Mask Data register

: MDMA_DEF ; [then]
