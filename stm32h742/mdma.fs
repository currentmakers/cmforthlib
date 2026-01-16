\
\ @file mdma.fs
\ @brief MDMA
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief MDMA Global Interrupt/Status Register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_GISR0_GIF0                             \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00000002 constant MDMA_MDMA_GISR0_GIF1                             \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00000004 constant MDMA_MDMA_GISR0_GIF2                             \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00000008 constant MDMA_MDMA_GISR0_GIF3                             \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00000010 constant MDMA_MDMA_GISR0_GIF4                             \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00000020 constant MDMA_MDMA_GISR0_GIF5                             \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00000040 constant MDMA_MDMA_GISR0_GIF6                             \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00000080 constant MDMA_MDMA_GISR0_GIF7                             \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00000100 constant MDMA_MDMA_GISR0_GIF8                             \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00000200 constant MDMA_MDMA_GISR0_GIF9                             \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00000400 constant MDMA_MDMA_GISR0_GIF10                            \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00000800 constant MDMA_MDMA_GISR0_GIF11                            \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00001000 constant MDMA_MDMA_GISR0_GIF12                            \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00002000 constant MDMA_MDMA_GISR0_GIF13                            \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00004000 constant MDMA_MDMA_GISR0_GIF14                            \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)
$00008000 constant MDMA_MDMA_GISR0_GIF15                            \ Channel x global interrupt flag (x=...) This bit is set and reset by hardware. It is a logical OR of all the Channel x interrupt flags (CTCIFx, BTIFx, BRTIFx, TEIFx) which are enabled in the interrupt mask register (CTCIEx, BTIEx, BRTIEx, TEIEx)


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C0ISR_TEIF0                            \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C0ISR_CTCIF0                           \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C0ISR_BRTIF0                           \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C0ISR_BTIF0                            \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C0ISR_TCIF0                            \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C0ISR_CRQA0                            \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C0IFCR_CTEIF0                          \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C0IFCR_CCTCIF0                         \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C0IFCR_CBRTIF0                         \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C0IFCR_CBTIF0                          \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C0IFCR_CLTCIF0                         \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C0ESR_TEA                              \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C0ESR_TED                              \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C0ESR_TELD                             \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C0ESR_TEMD                             \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C0ESR_ASE                              \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C0ESR_BSE                              \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C0CR_EN                                \ channel enable
$00000002 constant MDMA_MDMA_C0CR_TEIE                              \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C0CR_CTCIE                             \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C0CR_BRTIE                             \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C0CR_BTIE                              \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C0CR_TCIE                              \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C0CR_PL                                \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C0CR_BEX                               \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C0CR_HEX                               \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C0CR_WEX                               \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C0CR_SWRQ                              \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C0TCR_SINC                             \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C0TCR_DINC                             \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C0TCR_SSIZE                            \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C0TCR_DSIZE                            \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C0TCR_SINCOS                           \ source increment offset size
$00000c00 constant MDMA_MDMA_C0TCR_DINCOS                           \ Destination increment offset
$00007000 constant MDMA_MDMA_C0TCR_SBURST                           \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C0TCR_DBURST                           \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C0TCR_TLEN                             \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C0TCR_PKE                              \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C0TCR_PAM                              \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C0TCR_TRGM                             \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C0TCR_SWRM                             \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C0TCR_BWM                              \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C0BNDTR_BNDT                           \ block number of data to transfer
$00040000 constant MDMA_MDMA_C0BNDTR_BRSUM                          \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C0BNDTR_BRDUM                          \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C0BNDTR_BRC                            \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C0SAR_SAR                              \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C0DAR_DAR                              \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C0BRUR_SUV                             \ source adresse update value
$ffff0000 constant MDMA_MDMA_C0BRUR_DUV                             \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C0LAR_LAR                              \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C0TBR_TSEL                             \ Trigger selection
$00010000 constant MDMA_MDMA_C0TBR_SBUS                             \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C0TBR_DBUS                             \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C0MAR_MAR                              \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C0MDR_MDR                              \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C1ISR_TEIF1                            \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C1ISR_CTCIF1                           \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C1ISR_BRTIF1                           \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C1ISR_BTIF1                            \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C1ISR_TCIF1                            \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C1ISR_CRQA1                            \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C1IFCR_CTEIF1                          \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C1IFCR_CCTCIF1                         \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C1IFCR_CBRTIF1                         \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C1IFCR_CBTIF1                          \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C1IFCR_CLTCIF1                         \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C1ESR_TEA                              \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C1ESR_TED                              \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C1ESR_TELD                             \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C1ESR_TEMD                             \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C1ESR_ASE                              \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C1ESR_BSE                              \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C1CR_EN                                \ channel enable
$00000002 constant MDMA_MDMA_C1CR_TEIE                              \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C1CR_CTCIE                             \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C1CR_BRTIE                             \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C1CR_BTIE                              \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C1CR_TCIE                              \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C1CR_PL                                \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C1CR_BEX                               \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C1CR_HEX                               \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C1CR_WEX                               \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C1CR_SWRQ                              \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C1TCR_SINC                             \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C1TCR_DINC                             \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C1TCR_SSIZE                            \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C1TCR_DSIZE                            \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C1TCR_SINCOS                           \ source increment offset size
$00000c00 constant MDMA_MDMA_C1TCR_DINCOS                           \ Destination increment offset
$00007000 constant MDMA_MDMA_C1TCR_SBURST                           \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C1TCR_DBURST                           \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C1TCR_TLEN                             \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C1TCR_PKE                              \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C1TCR_PAM                              \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C1TCR_TRGM                             \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C1TCR_SWRM                             \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C1TCR_BWM                              \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C1BNDTR_BNDT                           \ block number of data to transfer
$00040000 constant MDMA_MDMA_C1BNDTR_BRSUM                          \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C1BNDTR_BRDUM                          \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C1BNDTR_BRC                            \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C1SAR_SAR                              \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C1DAR_DAR                              \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C1BRUR_SUV                             \ source adresse update value
$ffff0000 constant MDMA_MDMA_C1BRUR_DUV                             \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C1LAR_LAR                              \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C1TBR_TSEL                             \ Trigger selection
$00010000 constant MDMA_MDMA_C1TBR_SBUS                             \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C1TBR_DBUS                             \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C1MAR_MAR                              \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C1MDR_MDR                              \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C2ISR_TEIF2                            \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C2ISR_CTCIF2                           \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C2ISR_BRTIF2                           \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C2ISR_BTIF2                            \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C2ISR_TCIF2                            \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C2ISR_CRQA2                            \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C2IFCR_CTEIF2                          \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C2IFCR_CCTCIF2                         \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C2IFCR_CBRTIF2                         \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C2IFCR_CBTIF2                          \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C2IFCR_CLTCIF2                         \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C2ESR_TEA                              \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C2ESR_TED                              \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C2ESR_TELD                             \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C2ESR_TEMD                             \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C2ESR_ASE                              \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C2ESR_BSE                              \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C2CR_EN                                \ channel enable
$00000002 constant MDMA_MDMA_C2CR_TEIE                              \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C2CR_CTCIE                             \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C2CR_BRTIE                             \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C2CR_BTIE                              \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C2CR_TCIE                              \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C2CR_PL                                \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C2CR_BEX                               \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C2CR_HEX                               \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C2CR_WEX                               \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C2CR_SWRQ                              \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C2TCR_SINC                             \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C2TCR_DINC                             \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C2TCR_SSIZE                            \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C2TCR_DSIZE                            \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C2TCR_SINCOS                           \ source increment offset size
$00000c00 constant MDMA_MDMA_C2TCR_DINCOS                           \ Destination increment offset
$00007000 constant MDMA_MDMA_C2TCR_SBURST                           \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C2TCR_DBURST                           \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C2TCR_TLEN                             \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C2TCR_PKE                              \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C2TCR_PAM                              \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C2TCR_TRGM                             \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C2TCR_SWRM                             \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C2TCR_BWM                              \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C2BNDTR_BNDT                           \ block number of data to transfer
$00040000 constant MDMA_MDMA_C2BNDTR_BRSUM                          \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C2BNDTR_BRDUM                          \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C2BNDTR_BRC                            \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C2SAR_SAR                              \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C2DAR_DAR                              \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C2BRUR_SUV                             \ source adresse update value
$ffff0000 constant MDMA_MDMA_C2BRUR_DUV                             \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C2LAR_LAR                              \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C2TBR_TSEL                             \ Trigger selection
$00010000 constant MDMA_MDMA_C2TBR_SBUS                             \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C2TBR_DBUS                             \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C2MAR_MAR                              \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C2MDR_MDR                              \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C3ISR_TEIF3                            \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C3ISR_CTCIF3                           \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C3ISR_BRTIF3                           \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C3ISR_BTIF3                            \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C3ISR_TCIF3                            \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C3ISR_CRQA3                            \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C3IFCR_CTEIF3                          \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C3IFCR_CCTCIF3                         \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C3IFCR_CBRTIF3                         \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C3IFCR_CBTIF3                          \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C3IFCR_CLTCIF3                         \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C3ESR_TEA                              \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C3ESR_TED                              \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C3ESR_TELD                             \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C3ESR_TEMD                             \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C3ESR_ASE                              \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C3ESR_BSE                              \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C3CR_EN                                \ channel enable
$00000002 constant MDMA_MDMA_C3CR_TEIE                              \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C3CR_CTCIE                             \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C3CR_BRTIE                             \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C3CR_BTIE                              \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C3CR_TCIE                              \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C3CR_PL                                \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C3CR_BEX                               \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C3CR_HEX                               \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C3CR_WEX                               \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C3CR_SWRQ                              \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C3TCR_SINC                             \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C3TCR_DINC                             \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C3TCR_SSIZE                            \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C3TCR_DSIZE                            \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C3TCR_SINCOS                           \ source increment offset size
$00000c00 constant MDMA_MDMA_C3TCR_DINCOS                           \ Destination increment offset
$00007000 constant MDMA_MDMA_C3TCR_SBURST                           \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C3TCR_DBURST                           \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C3TCR_TLEN                             \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C3TCR_PKE                              \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C3TCR_PAM                              \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C3TCR_TRGM                             \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C3TCR_SWRM                             \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C3TCR_BWM                              \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C3BNDTR_BNDT                           \ block number of data to transfer
$00040000 constant MDMA_MDMA_C3BNDTR_BRSUM                          \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C3BNDTR_BRDUM                          \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C3BNDTR_BRC                            \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C3SAR_SAR                              \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C3DAR_DAR                              \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C3BRUR_SUV                             \ source adresse update value
$ffff0000 constant MDMA_MDMA_C3BRUR_DUV                             \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C3LAR_LAR                              \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C3TBR_TSEL                             \ Trigger selection
$00010000 constant MDMA_MDMA_C3TBR_SBUS                             \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C3TBR_DBUS                             \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C3MAR_MAR                              \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C3MDR_MDR                              \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C4ISR_TEIF4                            \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C4ISR_CTCIF4                           \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C4ISR_BRTIF4                           \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C4ISR_BTIF4                            \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C4ISR_TCIF4                            \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C4ISR_CRQA4                            \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C4IFCR_CTEIF4                          \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C4IFCR_CCTCIF4                         \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C4IFCR_CBRTIF4                         \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C4IFCR_CBTIF4                          \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C4IFCR_CLTCIF4                         \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C4ESR_TEA                              \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C4ESR_TED                              \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C4ESR_TELD                             \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C4ESR_TEMD                             \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C4ESR_ASE                              \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C4ESR_BSE                              \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C4CR_EN                                \ channel enable
$00000002 constant MDMA_MDMA_C4CR_TEIE                              \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C4CR_CTCIE                             \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C4CR_BRTIE                             \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C4CR_BTIE                              \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C4CR_TCIE                              \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C4CR_PL                                \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C4CR_BEX                               \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C4CR_HEX                               \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C4CR_WEX                               \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C4CR_SWRQ                              \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C4TCR_SINC                             \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C4TCR_DINC                             \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C4TCR_SSIZE                            \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C4TCR_DSIZE                            \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C4TCR_SINCOS                           \ source increment offset size
$00000c00 constant MDMA_MDMA_C4TCR_DINCOS                           \ Destination increment offset
$00007000 constant MDMA_MDMA_C4TCR_SBURST                           \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C4TCR_DBURST                           \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C4TCR_TLEN                             \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C4TCR_PKE                              \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C4TCR_PAM                              \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C4TCR_TRGM                             \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C4TCR_SWRM                             \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C4TCR_BWM                              \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C4BNDTR_BNDT                           \ block number of data to transfer
$00040000 constant MDMA_MDMA_C4BNDTR_BRSUM                          \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C4BNDTR_BRDUM                          \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C4BNDTR_BRC                            \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C4SAR_SAR                              \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C4DAR_DAR                              \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C4BRUR_SUV                             \ source adresse update value
$ffff0000 constant MDMA_MDMA_C4BRUR_DUV                             \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C4LAR_LAR                              \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C4TBR_TSEL                             \ Trigger selection
$00010000 constant MDMA_MDMA_C4TBR_SBUS                             \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C4TBR_DBUS                             \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C4MAR_MAR                              \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C4MDR_MDR                              \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C5ISR_TEIF5                            \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C5ISR_CTCIF5                           \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C5ISR_BRTIF5                           \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C5ISR_BTIF5                            \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C5ISR_TCIF5                            \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C5ISR_CRQA5                            \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C5IFCR_CTEIF5                          \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C5IFCR_CCTCIF5                         \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C5IFCR_CBRTIF5                         \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C5IFCR_CBTIF5                          \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C5IFCR_CLTCIF5                         \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C5ESR_TEA                              \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C5ESR_TED                              \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C5ESR_TELD                             \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C5ESR_TEMD                             \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C5ESR_ASE                              \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C5ESR_BSE                              \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C5CR_EN                                \ channel enable
$00000002 constant MDMA_MDMA_C5CR_TEIE                              \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C5CR_CTCIE                             \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C5CR_BRTIE                             \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C5CR_BTIE                              \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C5CR_TCIE                              \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C5CR_PL                                \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C5CR_BEX                               \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C5CR_HEX                               \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C5CR_WEX                               \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C5CR_SWRQ                              \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C5TCR_SINC                             \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C5TCR_DINC                             \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C5TCR_SSIZE                            \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C5TCR_DSIZE                            \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C5TCR_SINCOS                           \ source increment offset size
$00000c00 constant MDMA_MDMA_C5TCR_DINCOS                           \ Destination increment offset
$00007000 constant MDMA_MDMA_C5TCR_SBURST                           \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C5TCR_DBURST                           \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C5TCR_TLEN                             \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C5TCR_PKE                              \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C5TCR_PAM                              \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C5TCR_TRGM                             \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C5TCR_SWRM                             \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C5TCR_BWM                              \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C5BNDTR_BNDT                           \ block number of data to transfer
$00040000 constant MDMA_MDMA_C5BNDTR_BRSUM                          \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C5BNDTR_BRDUM                          \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C5BNDTR_BRC                            \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C5SAR_SAR                              \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C5DAR_DAR                              \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C5BRUR_SUV                             \ source adresse update value
$ffff0000 constant MDMA_MDMA_C5BRUR_DUV                             \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C5LAR_LAR                              \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C5TBR_TSEL                             \ Trigger selection
$00010000 constant MDMA_MDMA_C5TBR_SBUS                             \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C5TBR_DBUS                             \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C5MAR_MAR                              \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C5MDR_MDR                              \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C6ISR_TEIF6                            \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C6ISR_CTCIF6                           \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C6ISR_BRTIF6                           \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C6ISR_BTIF6                            \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C6ISR_TCIF6                            \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C6ISR_CRQA6                            \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C6IFCR_CTEIF6                          \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C6IFCR_CCTCIF6                         \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C6IFCR_CBRTIF6                         \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C6IFCR_CBTIF6                          \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C6IFCR_CLTCIF6                         \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C6ESR_TEA                              \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C6ESR_TED                              \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C6ESR_TELD                             \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C6ESR_TEMD                             \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C6ESR_ASE                              \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C6ESR_BSE                              \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C6CR_EN                                \ channel enable
$00000002 constant MDMA_MDMA_C6CR_TEIE                              \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C6CR_CTCIE                             \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C6CR_BRTIE                             \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C6CR_BTIE                              \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C6CR_TCIE                              \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C6CR_PL                                \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C6CR_BEX                               \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C6CR_HEX                               \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C6CR_WEX                               \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C6CR_SWRQ                              \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C6TCR_SINC                             \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C6TCR_DINC                             \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C6TCR_SSIZE                            \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C6TCR_DSIZE                            \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C6TCR_SINCOS                           \ source increment offset size
$00000c00 constant MDMA_MDMA_C6TCR_DINCOS                           \ Destination increment offset
$00007000 constant MDMA_MDMA_C6TCR_SBURST                           \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C6TCR_DBURST                           \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C6TCR_TLEN                             \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C6TCR_PKE                              \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C6TCR_PAM                              \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C6TCR_TRGM                             \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C6TCR_SWRM                             \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C6TCR_BWM                              \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C6BNDTR_BNDT                           \ block number of data to transfer
$00040000 constant MDMA_MDMA_C6BNDTR_BRSUM                          \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C6BNDTR_BRDUM                          \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C6BNDTR_BRC                            \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0


\
\ @brief MDMA channel x source address register
\ Address offset: 0x1D8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C6SAR_SAR                              \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C6DAR_DAR                              \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C6BRUR_SUV                             \ source adresse update value
$ffff0000 constant MDMA_MDMA_C6BRUR_DUV                             \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C6LAR_LAR                              \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C6TBR_TSEL                             \ Trigger selection
$00010000 constant MDMA_MDMA_C6TBR_SBUS                             \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C6TBR_DBUS                             \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C6MAR_MAR                              \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C6MDR_MDR                              \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C7ISR_TEIF7                            \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C7ISR_CTCIF7                           \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C7ISR_BRTIF7                           \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C7ISR_BTIF7                            \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C7ISR_TCIF7                            \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C7ISR_CRQA7                            \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C7IFCR_CTEIF7                          \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C7IFCR_CCTCIF7                         \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C7IFCR_CBRTIF7                         \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C7IFCR_CBTIF7                          \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C7IFCR_CLTCIF7                         \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C7ESR_TEA                              \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C7ESR_TED                              \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C7ESR_TELD                             \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C7ESR_TEMD                             \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C7ESR_ASE                              \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C7ESR_BSE                              \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C7CR_EN                                \ channel enable
$00000002 constant MDMA_MDMA_C7CR_TEIE                              \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C7CR_CTCIE                             \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C7CR_BRTIE                             \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C7CR_BTIE                              \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C7CR_TCIE                              \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C7CR_PL                                \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C7CR_BEX                               \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C7CR_HEX                               \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C7CR_WEX                               \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C7CR_SWRQ                              \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C7TCR_SINC                             \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C7TCR_DINC                             \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C7TCR_SSIZE                            \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C7TCR_DSIZE                            \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C7TCR_SINCOS                           \ source increment offset size
$00000c00 constant MDMA_MDMA_C7TCR_DINCOS                           \ Destination increment offset
$00007000 constant MDMA_MDMA_C7TCR_SBURST                           \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C7TCR_DBURST                           \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C7TCR_TLEN                             \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C7TCR_PKE                              \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C7TCR_PAM                              \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C7TCR_TRGM                             \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C7TCR_SWRM                             \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C7TCR_BWM                              \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C7BNDTR_BNDT                           \ block number of data to transfer
$00040000 constant MDMA_MDMA_C7BNDTR_BRSUM                          \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C7BNDTR_BRDUM                          \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C7BNDTR_BRC                            \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C7SAR_SAR                              \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C7DAR_DAR                              \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C7BRUR_SUV                             \ source adresse update value
$ffff0000 constant MDMA_MDMA_C7BRUR_DUV                             \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C7LAR_LAR                              \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C7TBR_TSEL                             \ Trigger selection
$00010000 constant MDMA_MDMA_C7TBR_SBUS                             \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C7TBR_DBUS                             \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C7MAR_MAR                              \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C7MDR_MDR                              \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C8ISR_TEIF8                            \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C8ISR_CTCIF8                           \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C8ISR_BRTIF8                           \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C8ISR_BTIF8                            \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C8ISR_TCIF8                            \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C8ISR_CRQA8                            \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C8IFCR_CTEIF8                          \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C8IFCR_CCTCIF8                         \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C8IFCR_CBRTIF8                         \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C8IFCR_CBTIF8                          \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C8IFCR_CLTCIF8                         \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C8ESR_TEA                              \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C8ESR_TED                              \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C8ESR_TELD                             \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C8ESR_TEMD                             \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C8ESR_ASE                              \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C8ESR_BSE                              \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C8CR_EN                                \ channel enable
$00000002 constant MDMA_MDMA_C8CR_TEIE                              \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C8CR_CTCIE                             \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C8CR_BRTIE                             \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C8CR_BTIE                              \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C8CR_TCIE                              \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C8CR_PL                                \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C8CR_BEX                               \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C8CR_HEX                               \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C8CR_WEX                               \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C8CR_SWRQ                              \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C8TCR_SINC                             \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C8TCR_DINC                             \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C8TCR_SSIZE                            \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C8TCR_DSIZE                            \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C8TCR_SINCOS                           \ source increment offset size
$00000c00 constant MDMA_MDMA_C8TCR_DINCOS                           \ Destination increment offset
$00007000 constant MDMA_MDMA_C8TCR_SBURST                           \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C8TCR_DBURST                           \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C8TCR_TLEN                             \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C8TCR_PKE                              \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C8TCR_PAM                              \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C8TCR_TRGM                             \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C8TCR_SWRM                             \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C8TCR_BWM                              \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C8BNDTR_BNDT                           \ block number of data to transfer
$00040000 constant MDMA_MDMA_C8BNDTR_BRSUM                          \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C8BNDTR_BRDUM                          \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C8BNDTR_BRC                            \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C8SAR_SAR                              \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C8DAR_DAR                              \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C8BRUR_SUV                             \ source adresse update value
$ffff0000 constant MDMA_MDMA_C8BRUR_DUV                             \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C8LAR_LAR                              \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C8TBR_TSEL                             \ Trigger selection
$00010000 constant MDMA_MDMA_C8TBR_SBUS                             \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C8TBR_DBUS                             \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C8MAR_MAR                              \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C8MDR_MDR                              \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C9ISR_TEIF9                            \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C9ISR_CTCIF9                           \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C9ISR_BRTIF9                           \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C9ISR_BTIF9                            \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C9ISR_TCIF9                            \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C9ISR_CRQA9                            \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C9IFCR_CTEIF9                          \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C9IFCR_CCTCIF9                         \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C9IFCR_CBRTIF9                         \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C9IFCR_CBTIF9                          \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C9IFCR_CLTCIF9                         \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C9ESR_TEA                              \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C9ESR_TED                              \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C9ESR_TELD                             \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C9ESR_TEMD                             \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C9ESR_ASE                              \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C9ESR_BSE                              \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C9CR_EN                                \ channel enable
$00000002 constant MDMA_MDMA_C9CR_TEIE                              \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C9CR_CTCIE                             \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C9CR_BRTIE                             \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C9CR_BTIE                              \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C9CR_TCIE                              \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C9CR_PL                                \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C9CR_BEX                               \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C9CR_HEX                               \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C9CR_WEX                               \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C9CR_SWRQ                              \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C9TCR_SINC                             \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C9TCR_DINC                             \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C9TCR_SSIZE                            \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C9TCR_DSIZE                            \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C9TCR_SINCOS                           \ source increment offset size
$00000c00 constant MDMA_MDMA_C9TCR_DINCOS                           \ Destination increment offset
$00007000 constant MDMA_MDMA_C9TCR_SBURST                           \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C9TCR_DBURST                           \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C9TCR_TLEN                             \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C9TCR_PKE                              \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C9TCR_PAM                              \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C9TCR_TRGM                             \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C9TCR_SWRM                             \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C9TCR_BWM                              \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C9BNDTR_BNDT                           \ block number of data to transfer
$00040000 constant MDMA_MDMA_C9BNDTR_BRSUM                          \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C9BNDTR_BRDUM                          \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C9BNDTR_BRC                            \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C9SAR_SAR                              \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C9DAR_DAR                              \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C9BRUR_SUV                             \ source adresse update value
$ffff0000 constant MDMA_MDMA_C9BRUR_DUV                             \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C9LAR_LAR                              \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C9TBR_TSEL                             \ Trigger selection
$00010000 constant MDMA_MDMA_C9TBR_SBUS                             \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C9TBR_DBUS                             \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x2B0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C9MAR_MAR                              \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x2B4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C9MDR_MDR                              \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x2C0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C10ISR_TEIF10                          \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C10ISR_CTCIF10                         \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C10ISR_BRTIF10                         \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C10ISR_BTIF10                          \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C10ISR_TCIF10                          \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C10ISR_CRQA10                          \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x2C4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C10IFCR_CTEIF10                        \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C10IFCR_CCTCIF10                       \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C10IFCR_CBRTIF10                       \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C10IFCR_CBTIF10                        \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C10IFCR_CLTCIF10                       \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x2C8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C10ESR_TEA                             \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C10ESR_TED                             \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C10ESR_TELD                            \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C10ESR_TEMD                            \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C10ESR_ASE                             \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C10ESR_BSE                             \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C10CR_EN                               \ channel enable
$00000002 constant MDMA_MDMA_C10CR_TEIE                             \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C10CR_CTCIE                            \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C10CR_BRTIE                            \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C10CR_BTIE                             \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C10CR_TCIE                             \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C10CR_PL                               \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C10CR_BEX                              \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C10CR_HEX                              \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C10CR_WEX                              \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C10CR_SWRQ                             \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C10TCR_SINC                            \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C10TCR_DINC                            \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C10TCR_SSIZE                           \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C10TCR_DSIZE                           \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C10TCR_SINCOS                          \ source increment offset size
$00000c00 constant MDMA_MDMA_C10TCR_DINCOS                          \ Destination increment offset
$00007000 constant MDMA_MDMA_C10TCR_SBURST                          \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C10TCR_DBURST                          \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C10TCR_TLEN                            \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C10TCR_PKE                             \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C10TCR_PAM                             \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C10TCR_TRGM                            \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C10TCR_SWRM                            \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C10TCR_BWM                             \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x2D4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C10BNDTR_BNDT                          \ block number of data to transfer
$00040000 constant MDMA_MDMA_C10BNDTR_BRSUM                         \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C10BNDTR_BRDUM                         \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C10BNDTR_BRC                           \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x2D8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C10SAR_SAR                             \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C10DAR_DAR                             \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x2E0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C10BRUR_SUV                            \ source adresse update value
$ffff0000 constant MDMA_MDMA_C10BRUR_DUV                            \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C10LAR_LAR                             \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x2E8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C10TBR_TSEL                            \ Trigger selection
$00010000 constant MDMA_MDMA_C10TBR_SBUS                            \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C10TBR_DBUS                            \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x2F0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C10MAR_MAR                             \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x2F4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C10MDR_MDR                             \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C11ISR_TEIF11                          \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C11ISR_CTCIF11                         \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C11ISR_BRTIF11                         \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C11ISR_BTIF11                          \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C11ISR_TCIF11                          \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C11ISR_CRQA11                          \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C11IFCR_CTEIF11                        \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C11IFCR_CCTCIF11                       \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C11IFCR_CBRTIF11                       \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C11IFCR_CBTIF11                        \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C11IFCR_CLTCIF11                       \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C11ESR_TEA                             \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C11ESR_TED                             \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C11ESR_TELD                            \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C11ESR_TEMD                            \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C11ESR_ASE                             \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C11ESR_BSE                             \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C11CR_EN                               \ channel enable
$00000002 constant MDMA_MDMA_C11CR_TEIE                             \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C11CR_CTCIE                            \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C11CR_BRTIE                            \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C11CR_BTIE                             \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C11CR_TCIE                             \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C11CR_PL                               \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C11CR_BEX                              \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C11CR_HEX                              \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C11CR_WEX                              \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C11CR_SWRQ                             \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C11TCR_SINC                            \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C11TCR_DINC                            \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C11TCR_SSIZE                           \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C11TCR_DSIZE                           \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C11TCR_SINCOS                          \ source increment offset size
$00000c00 constant MDMA_MDMA_C11TCR_DINCOS                          \ Destination increment offset
$00007000 constant MDMA_MDMA_C11TCR_SBURST                          \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C11TCR_DBURST                          \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C11TCR_TLEN                            \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C11TCR_PKE                             \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C11TCR_PAM                             \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C11TCR_TRGM                            \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C11TCR_SWRM                            \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C11TCR_BWM                             \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C11BNDTR_BNDT                          \ block number of data to transfer
$00040000 constant MDMA_MDMA_C11BNDTR_BRSUM                         \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C11BNDTR_BRDUM                         \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C11BNDTR_BRC                           \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C11SAR_SAR                             \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C11DAR_DAR                             \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C11BRUR_SUV                            \ source adresse update value
$ffff0000 constant MDMA_MDMA_C11BRUR_DUV                            \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C11LAR_LAR                             \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C11TBR_TSEL                            \ Trigger selection
$00010000 constant MDMA_MDMA_C11TBR_SBUS                            \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C11TBR_DBUS                            \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C11MAR_MAR                             \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C11MDR_MDR                             \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C12ISR_TEIF12                          \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C12ISR_CTCIF12                         \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C12ISR_BRTIF12                         \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C12ISR_BTIF12                          \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C12ISR_TCIF12                          \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C12ISR_CRQA12                          \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C12IFCR_CTEIF12                        \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C12IFCR_CCTCIF12                       \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C12IFCR_CBRTIF12                       \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C12IFCR_CBTIF12                        \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C12IFCR_CLTCIF12                       \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x348
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C12ESR_TEA                             \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C12ESR_TED                             \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C12ESR_TELD                            \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C12ESR_TEMD                            \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C12ESR_ASE                             \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C12ESR_BSE                             \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C12CR_EN                               \ channel enable
$00000002 constant MDMA_MDMA_C12CR_TEIE                             \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C12CR_CTCIE                            \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C12CR_BRTIE                            \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C12CR_BTIE                             \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C12CR_TCIE                             \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C12CR_PL                               \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C12CR_BEX                              \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C12CR_HEX                              \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C12CR_WEX                              \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C12CR_SWRQ                             \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C12TCR_SINC                            \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C12TCR_DINC                            \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C12TCR_SSIZE                           \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C12TCR_DSIZE                           \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C12TCR_SINCOS                          \ source increment offset size
$00000c00 constant MDMA_MDMA_C12TCR_DINCOS                          \ Destination increment offset
$00007000 constant MDMA_MDMA_C12TCR_SBURST                          \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C12TCR_DBURST                          \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C12TCR_TLEN                            \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C12TCR_PKE                             \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C12TCR_PAM                             \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C12TCR_TRGM                            \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C12TCR_SWRM                            \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C12TCR_BWM                             \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x354
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C12BNDTR_BNDT                          \ block number of data to transfer
$00040000 constant MDMA_MDMA_C12BNDTR_BRSUM                         \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C12BNDTR_BRDUM                         \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C12BNDTR_BRC                           \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x358
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C12SAR_SAR                             \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C12DAR_DAR                             \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x360
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C12BRUR_SUV                            \ source adresse update value
$ffff0000 constant MDMA_MDMA_C12BRUR_DUV                            \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C12LAR_LAR                             \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x368
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C12TBR_TSEL                            \ Trigger selection
$00010000 constant MDMA_MDMA_C12TBR_SBUS                            \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C12TBR_DBUS                            \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C12MAR_MAR                             \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x374
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C12MDR_MDR                             \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C13ISR_TEIF13                          \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C13ISR_CTCIF13                         \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C13ISR_BRTIF13                         \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C13ISR_BTIF13                          \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C13ISR_TCIF13                          \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C13ISR_CRQA13                          \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C13IFCR_CTEIF13                        \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C13IFCR_CCTCIF13                       \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C13IFCR_CBRTIF13                       \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C13IFCR_CBTIF13                        \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C13IFCR_CLTCIF13                       \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x388
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C13ESR_TEA                             \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C13ESR_TED                             \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C13ESR_TELD                            \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C13ESR_TEMD                            \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C13ESR_ASE                             \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C13ESR_BSE                             \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x38C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C13CR_EN                               \ channel enable
$00000002 constant MDMA_MDMA_C13CR_TEIE                             \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C13CR_CTCIE                            \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C13CR_BRTIE                            \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C13CR_BTIE                             \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C13CR_TCIE                             \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C13CR_PL                               \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C13CR_BEX                              \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C13CR_HEX                              \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C13CR_WEX                              \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C13CR_SWRQ                             \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C13TCR_SINC                            \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C13TCR_DINC                            \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C13TCR_SSIZE                           \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C13TCR_DSIZE                           \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C13TCR_SINCOS                          \ source increment offset size
$00000c00 constant MDMA_MDMA_C13TCR_DINCOS                          \ Destination increment offset
$00007000 constant MDMA_MDMA_C13TCR_SBURST                          \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C13TCR_DBURST                          \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C13TCR_TLEN                            \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C13TCR_PKE                             \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C13TCR_PAM                             \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C13TCR_TRGM                            \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C13TCR_SWRM                            \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C13TCR_BWM                             \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C13BNDTR_BNDT                          \ block number of data to transfer
$00040000 constant MDMA_MDMA_C13BNDTR_BRSUM                         \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C13BNDTR_BRDUM                         \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C13BNDTR_BRC                           \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C13SAR_SAR                             \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C13DAR_DAR                             \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C13BRUR_SUV                            \ source adresse update value
$ffff0000 constant MDMA_MDMA_C13BRUR_DUV                            \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x3A4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C13LAR_LAR                             \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x3A8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C13TBR_TSEL                            \ Trigger selection
$00010000 constant MDMA_MDMA_C13TBR_SBUS                            \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C13TBR_DBUS                            \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x3B0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C13MAR_MAR                             \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x3B4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C13MDR_MDR                             \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x3C0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C14ISR_TEIF14                          \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C14ISR_CTCIF14                         \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C14ISR_BRTIF14                         \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C14ISR_BTIF14                          \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C14ISR_TCIF14                          \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C14ISR_CRQA14                          \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x3C4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C14IFCR_CTEIF14                        \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C14IFCR_CCTCIF14                       \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C14IFCR_CBRTIF14                       \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C14IFCR_CBTIF14                        \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C14IFCR_CLTCIF14                       \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x3C8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C14ESR_TEA                             \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C14ESR_TED                             \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C14ESR_TELD                            \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C14ESR_TEMD                            \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C14ESR_ASE                             \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C14ESR_BSE                             \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x3CC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C14CR_EN                               \ channel enable
$00000002 constant MDMA_MDMA_C14CR_TEIE                             \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C14CR_CTCIE                            \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C14CR_BRTIE                            \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C14CR_BTIE                             \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C14CR_TCIE                             \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C14CR_PL                               \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C14CR_BEX                              \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C14CR_HEX                              \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C14CR_WEX                              \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C14CR_SWRQ                             \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C14TCR_SINC                            \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C14TCR_DINC                            \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C14TCR_SSIZE                           \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C14TCR_DSIZE                           \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C14TCR_SINCOS                          \ source increment offset size
$00000c00 constant MDMA_MDMA_C14TCR_DINCOS                          \ Destination increment offset
$00007000 constant MDMA_MDMA_C14TCR_SBURST                          \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C14TCR_DBURST                          \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C14TCR_TLEN                            \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C14TCR_PKE                             \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C14TCR_PAM                             \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C14TCR_TRGM                            \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C14TCR_SWRM                            \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C14TCR_BWM                             \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x3D4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C14BNDTR_BNDT                          \ block number of data to transfer
$00040000 constant MDMA_MDMA_C14BNDTR_BRSUM                         \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C14BNDTR_BRDUM                         \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C14BNDTR_BRC                           \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x3D8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C14SAR_SAR                             \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C14DAR_DAR                             \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C14BRUR_SUV                            \ source adresse update value
$ffff0000 constant MDMA_MDMA_C14BRUR_DUV                            \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C14LAR_LAR                             \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x3E8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C14TBR_TSEL                            \ Trigger selection
$00010000 constant MDMA_MDMA_C14TBR_SBUS                            \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C14TBR_DBUS                            \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C14MAR_MAR                             \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x3F4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C14MDR_MDR                             \ Mask data


\
\ @brief MDMA channel x interrupt/status register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C15ISR_TEIF15                          \ Channel x transfer error interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000002 constant MDMA_MDMA_C15ISR_CTCIF15                         \ Channel x Channel Transfer Complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register. CTC is set when the last block was transferred and the channel has been automatically disabled. CTC is also set when the channel is suspended, as a result of writing EN bit to 0.
$00000004 constant MDMA_MDMA_C15ISR_BRTIF15                         \ Channel x block repeat transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000008 constant MDMA_MDMA_C15ISR_BTIF15                          \ Channel x block transfer complete interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCRy register.
$00000010 constant MDMA_MDMA_C15ISR_TCIF15                          \ channel x buffer transfer complete
$00010000 constant MDMA_MDMA_C15ISR_CRQA15                          \ channel x request active flag


\
\ @brief MDMA channel x interrupt flag clear register
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C15IFCR_CTEIF15                        \ Channel x clear transfer error interrupt flag Writing a 1 into this bit clears TEIFx in the MDMA_ISRy register
$00000002 constant MDMA_MDMA_C15IFCR_CCTCIF15                       \ Clear Channel transfer complete interrupt flag for channel x Writing a 1 into this bit clears CTCIFx in the MDMA_ISRy register
$00000004 constant MDMA_MDMA_C15IFCR_CBRTIF15                       \ Channel x clear block repeat transfer complete interrupt flag Writing a 1 into this bit clears BRTIFx in the MDMA_ISRy register
$00000008 constant MDMA_MDMA_C15IFCR_CBTIF15                        \ Channel x Clear block transfer complete interrupt flag Writing a 1 into this bit clears BTIFx in the MDMA_ISRy register
$00000010 constant MDMA_MDMA_C15IFCR_CLTCIF15                       \ CLear buffer Transfer Complete Interrupt Flag for channel x Writing a 1 into this bit clears TCIFx in the MDMA_ISRy register


\
\ @brief MDMA Channel x error status register
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C15ESR_TEA                             \ Transfer Error Address These bits are set and cleared by HW, in case of an MDMA data transfer error. It is used in conjunction with TED. This field indicates the 7 LSBits of the address which generated a transfer/access error. It may be used by SW to retrieve the failing address, by adding this value (truncated to the buffer transfer length size) to the current SAR/DAR value. Note: The SAR/DAR current value doesnt reflect this last address due to the FIFO management system. The SAR/DAR are only updated at the end of a (buffer) transfer (of TLEN+1 bytes). Note: It is not set in case of a link data error.
$00000080 constant MDMA_MDMA_C15ESR_TED                             \ Transfer Error Direction These bit is set and cleared by HW, in case of an MDMA data transfer error.
$00000100 constant MDMA_MDMA_C15ESR_TELD                            \ Transfer Error Link Data These bit is set by HW, in case of a transfer error while reading the block link data structure. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000200 constant MDMA_MDMA_C15ESR_TEMD                            \ Transfer Error Mask Data These bit is set by HW, in case of a transfer error while writing the Mask Data. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000400 constant MDMA_MDMA_C15ESR_ASE                             \ Address/Size Error These bit is set by HW, when the programmed address is not aligned with the data size. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.
$00000800 constant MDMA_MDMA_C15ESR_BSE                             \ Block Size Error These bit is set by HW, when the block size is not an integer multiple of the data size either for source or destination. TED will indicate whether the problem is on the source or destination. It is cleared by software writing 1 to the CTEIFx bit in the DMA_IFCRy register.


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C15CR_EN                               \ channel enable
$00000002 constant MDMA_MDMA_C15CR_TEIE                             \ Transfer error interrupt enable This bit is set and cleared by software.
$00000004 constant MDMA_MDMA_C15CR_CTCIE                            \ Channel Transfer Complete interrupt enable This bit is set and cleared by software.
$00000008 constant MDMA_MDMA_C15CR_BRTIE                            \ Block Repeat transfer interrupt enable This bit is set and cleared by software.
$00000010 constant MDMA_MDMA_C15CR_BTIE                             \ Block Transfer interrupt enable This bit is set and cleared by software.
$00000020 constant MDMA_MDMA_C15CR_TCIE                             \ buffer Transfer Complete interrupt enable This bit is set and cleared by software.
$000000c0 constant MDMA_MDMA_C15CR_PL                               \ Priority level These bits are set and cleared by software. These bits are protected and can be written only if EN is 0.
$00001000 constant MDMA_MDMA_C15CR_BEX                              \ byte Endianness exchange
$00002000 constant MDMA_MDMA_C15CR_HEX                              \ Half word Endianes exchange
$00004000 constant MDMA_MDMA_C15CR_WEX                              \ Word Endianness exchange
$00010000 constant MDMA_MDMA_C15CR_SWRQ                             \ SW ReQuest Writing a 1 into this bit sets the CRQAx in MDMA_ISRy register, activating the request on Channel x Note: Either the whole CxCR register or the 8-bit/16-bit register @ Address offset: 0x4E + 0x40 chn may be used for SWRQ activation. In case of a SW request, acknowledge is not generated (neither HW signal, nor CxMAR write access).


\
\ @brief This register is used to configure the concerned channel.
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C15TCR_SINC                            \ Source increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When source is AHB (SBUS=1), SINC = 00 is forbidden. In Linked List Mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$0000000c constant MDMA_MDMA_C15TCR_DINC                            \ Destination increment mode These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: When destination is AHB (DBUS=1), DINC = 00 is forbidden.
$00000030 constant MDMA_MDMA_C15TCR_SSIZE                           \ Source data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0 Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If SINCOS &lt; SSIZE and SINC &#8800; 00, the result will be unpredictable. Note: SSIZE = 11 (double-word) is forbidden when source is TCM/AHB bus (SBUS=1).
$000000c0 constant MDMA_MDMA_C15TCR_DSIZE                           \ Destination data size These bits are set and cleared by software. These bits are protected and can be written only if EN is 0. Note: If a value of 11 is programmed for the TCM access/AHB port, a transfer error will occur (TEIF bit set) If DINCOS &lt; DSIZE and DINC &#8800; 00, the result will be unpredictable. Note: DSIZE = 11 (double-word) is forbidden when destination is TCM/AHB bus (DBUS=1).
$00000300 constant MDMA_MDMA_C15TCR_SINCOS                          \ source increment offset size
$00000c00 constant MDMA_MDMA_C15TCR_DINCOS                          \ Destination increment offset
$00007000 constant MDMA_MDMA_C15TCR_SBURST                          \ source burst transfer configuration
$00038000 constant MDMA_MDMA_C15TCR_DBURST                          \ Destination burst transfer configuration
$01fc0000 constant MDMA_MDMA_C15TCR_TLEN                            \ buffer transfer lengh
$02000000 constant MDMA_MDMA_C15TCR_PKE                             \ PacK Enable These bit is set and cleared by software. If the Source Size is smaller than the destination, it will be padded according to the PAM value. If the Source data size is larger than the destination one, it will be truncated. The alignment will be done according to the PAM[0] value. This bit is protected and can be written only if EN is 0
$0c000000 constant MDMA_MDMA_C15TCR_PAM                             \ Padding/Alignement Mode These bits are set and cleared by software. Case 1: Source data size smaller than destination data size - 3 options are valid. Case 2: Source data size larger than destination data size. The remainder part is discarded. When PKE = 1 or DSIZE=SSIZE, these bits are ignored. These bits are protected and can be written only if EN is 0
$30000000 constant MDMA_MDMA_C15TCR_TRGM                            \ Trigger Mode These bits are set and cleared by software. Note: If TRGM is 11 for the current block, all the values loaded at the end of the current block through the linked list mechanism must keep the same value (TRGM=11) and the same SWRM value, otherwise the result is undefined. These bits are protected and can be written only if EN is 0.
$40000000 constant MDMA_MDMA_C15TCR_SWRM                            \ SW Request Mode This bit is set and cleared by software. If a HW or SW request is currently active, the bit change will be delayed until the current transfer is completed. If the CxMAR contains a valid address, the CxMDR value will also be written @ CxMAR address. This bit is protected and can be written only if EN is 0.
$80000000 constant MDMA_MDMA_C15TCR_BWM                             \ Bufferable Write Mode This bit is set and cleared by software. This bit is protected and can be written only if EN is 0. Note: All MDMA destination accesses are non-cacheable.


\
\ @brief MDMA Channel x block number of data register
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C15BNDTR_BNDT                          \ block number of data to transfer
$00040000 constant MDMA_MDMA_C15BNDTR_BRSUM                         \ Block Repeat Source address Update Mode These bits are protected and can be written only if EN is 0.
$00080000 constant MDMA_MDMA_C15BNDTR_BRDUM                         \ Block Repeat Destination address Update Mode These bits are protected and can be written only if EN is 0.
$fff00000 constant MDMA_MDMA_C15BNDTR_BRC                           \ Block Repeat Count This field contains the number of repetitions of the current block (0 to 4095). When the channel is enabled, this register is read-only, indicating the remaining number of blocks, excluding the current one. This register decrements after each complete block transfer. Once the last block transfer has completed, this register can either stay at zero or be reloaded automatically from memory (in Linked List mode - i.e. Link Address valid). These bits are protected and can be written only if EN is 0.


\
\ @brief MDMA channel x source address register
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C15SAR_SAR                             \ source adr base


\
\ @brief MDMA channel x destination address register
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C15DAR_DAR                             \ Destination adr base


\
\ @brief MDMA channel x Block Repeat address Update register
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C15BRUR_SUV                            \ source adresse update value
$ffff0000 constant MDMA_MDMA_C15BRUR_DUV                            \ destination address update


\
\ @brief MDMA channel x Link Address register
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C15LAR_LAR                             \ Link address register


\
\ @brief MDMA channel x Trigger and Bus selection Register
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C15TBR_TSEL                            \ Trigger selection
$00010000 constant MDMA_MDMA_C15TBR_SBUS                            \ Source BUS select This bit is protected and can be written only if EN is 0.
$00020000 constant MDMA_MDMA_C15TBR_DBUS                            \ Destination BUS slect This bit is protected and can be written only if EN is 0.


\
\ @brief MDMA channel x Mask address register
\ Address offset: 0x430
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C15MAR_MAR                             \ Mask address


\
\ @brief MDMA channel x Mask Data register
\ Address offset: 0x434
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C15MDR_MDR                             \ Mask data


\
\ @brief MDMA
\
$52000000 constant MDMA_MDMA_GISR0  \ offset: 0x00 : MDMA Global Interrupt/Status Register
$52000040 constant MDMA_MDMA_C0ISR  \ offset: 0x40 : MDMA channel x interrupt/status register
$52000044 constant MDMA_MDMA_C0IFCR  \ offset: 0x44 : MDMA channel x interrupt flag clear register
$52000048 constant MDMA_MDMA_C0ESR  \ offset: 0x48 : MDMA Channel x error status register
$5200004c constant MDMA_MDMA_C0CR  \ offset: 0x4C : This register is used to control the concerned channel.
$52000050 constant MDMA_MDMA_C0TCR  \ offset: 0x50 : This register is used to configure the concerned channel.
$52000054 constant MDMA_MDMA_C0BNDTR  \ offset: 0x54 : MDMA Channel x block number of data register
$52000058 constant MDMA_MDMA_C0SAR  \ offset: 0x58 : MDMA channel x source address register
$5200005c constant MDMA_MDMA_C0DAR  \ offset: 0x5C : MDMA channel x destination address register
$52000060 constant MDMA_MDMA_C0BRUR  \ offset: 0x60 : MDMA channel x Block Repeat address Update register
$52000064 constant MDMA_MDMA_C0LAR  \ offset: 0x64 : MDMA channel x Link Address register
$52000068 constant MDMA_MDMA_C0TBR  \ offset: 0x68 : MDMA channel x Trigger and Bus selection Register
$52000070 constant MDMA_MDMA_C0MAR  \ offset: 0x70 : MDMA channel x Mask address register
$52000074 constant MDMA_MDMA_C0MDR  \ offset: 0x74 : MDMA channel x Mask Data register
$52000080 constant MDMA_MDMA_C1ISR  \ offset: 0x80 : MDMA channel x interrupt/status register
$52000084 constant MDMA_MDMA_C1IFCR  \ offset: 0x84 : MDMA channel x interrupt flag clear register
$52000088 constant MDMA_MDMA_C1ESR  \ offset: 0x88 : MDMA Channel x error status register
$5200008c constant MDMA_MDMA_C1CR  \ offset: 0x8C : This register is used to control the concerned channel.
$52000090 constant MDMA_MDMA_C1TCR  \ offset: 0x90 : This register is used to configure the concerned channel.
$52000094 constant MDMA_MDMA_C1BNDTR  \ offset: 0x94 : MDMA Channel x block number of data register
$52000098 constant MDMA_MDMA_C1SAR  \ offset: 0x98 : MDMA channel x source address register
$5200009c constant MDMA_MDMA_C1DAR  \ offset: 0x9C : MDMA channel x destination address register
$520000a0 constant MDMA_MDMA_C1BRUR  \ offset: 0xA0 : MDMA channel x Block Repeat address Update register
$520000a4 constant MDMA_MDMA_C1LAR  \ offset: 0xA4 : MDMA channel x Link Address register
$520000a8 constant MDMA_MDMA_C1TBR  \ offset: 0xA8 : MDMA channel x Trigger and Bus selection Register
$520000b0 constant MDMA_MDMA_C1MAR  \ offset: 0xB0 : MDMA channel x Mask address register
$520000b4 constant MDMA_MDMA_C1MDR  \ offset: 0xB4 : MDMA channel x Mask Data register
$520000c0 constant MDMA_MDMA_C2ISR  \ offset: 0xC0 : MDMA channel x interrupt/status register
$520000c4 constant MDMA_MDMA_C2IFCR  \ offset: 0xC4 : MDMA channel x interrupt flag clear register
$520000c8 constant MDMA_MDMA_C2ESR  \ offset: 0xC8 : MDMA Channel x error status register
$520000cc constant MDMA_MDMA_C2CR  \ offset: 0xCC : This register is used to control the concerned channel.
$520000d0 constant MDMA_MDMA_C2TCR  \ offset: 0xD0 : This register is used to configure the concerned channel.
$520000d4 constant MDMA_MDMA_C2BNDTR  \ offset: 0xD4 : MDMA Channel x block number of data register
$520000d8 constant MDMA_MDMA_C2SAR  \ offset: 0xD8 : MDMA channel x source address register
$520000dc constant MDMA_MDMA_C2DAR  \ offset: 0xDC : MDMA channel x destination address register
$520000e0 constant MDMA_MDMA_C2BRUR  \ offset: 0xE0 : MDMA channel x Block Repeat address Update register
$520000e4 constant MDMA_MDMA_C2LAR  \ offset: 0xE4 : MDMA channel x Link Address register
$520000e8 constant MDMA_MDMA_C2TBR  \ offset: 0xE8 : MDMA channel x Trigger and Bus selection Register
$520000f0 constant MDMA_MDMA_C2MAR  \ offset: 0xF0 : MDMA channel x Mask address register
$520000f4 constant MDMA_MDMA_C2MDR  \ offset: 0xF4 : MDMA channel x Mask Data register
$52000100 constant MDMA_MDMA_C3ISR  \ offset: 0x100 : MDMA channel x interrupt/status register
$52000104 constant MDMA_MDMA_C3IFCR  \ offset: 0x104 : MDMA channel x interrupt flag clear register
$52000108 constant MDMA_MDMA_C3ESR  \ offset: 0x108 : MDMA Channel x error status register
$5200010c constant MDMA_MDMA_C3CR  \ offset: 0x10C : This register is used to control the concerned channel.
$52000110 constant MDMA_MDMA_C3TCR  \ offset: 0x110 : This register is used to configure the concerned channel.
$52000114 constant MDMA_MDMA_C3BNDTR  \ offset: 0x114 : MDMA Channel x block number of data register
$52000118 constant MDMA_MDMA_C3SAR  \ offset: 0x118 : MDMA channel x source address register
$5200011c constant MDMA_MDMA_C3DAR  \ offset: 0x11C : MDMA channel x destination address register
$52000120 constant MDMA_MDMA_C3BRUR  \ offset: 0x120 : MDMA channel x Block Repeat address Update register
$52000124 constant MDMA_MDMA_C3LAR  \ offset: 0x124 : MDMA channel x Link Address register
$52000128 constant MDMA_MDMA_C3TBR  \ offset: 0x128 : MDMA channel x Trigger and Bus selection Register
$52000130 constant MDMA_MDMA_C3MAR  \ offset: 0x130 : MDMA channel x Mask address register
$52000134 constant MDMA_MDMA_C3MDR  \ offset: 0x134 : MDMA channel x Mask Data register
$52000140 constant MDMA_MDMA_C4ISR  \ offset: 0x140 : MDMA channel x interrupt/status register
$52000144 constant MDMA_MDMA_C4IFCR  \ offset: 0x144 : MDMA channel x interrupt flag clear register
$52000148 constant MDMA_MDMA_C4ESR  \ offset: 0x148 : MDMA Channel x error status register
$5200014c constant MDMA_MDMA_C4CR  \ offset: 0x14C : This register is used to control the concerned channel.
$52000150 constant MDMA_MDMA_C4TCR  \ offset: 0x150 : This register is used to configure the concerned channel.
$52000154 constant MDMA_MDMA_C4BNDTR  \ offset: 0x154 : MDMA Channel x block number of data register
$52000158 constant MDMA_MDMA_C4SAR  \ offset: 0x158 : MDMA channel x source address register
$5200015c constant MDMA_MDMA_C4DAR  \ offset: 0x15C : MDMA channel x destination address register
$52000160 constant MDMA_MDMA_C4BRUR  \ offset: 0x160 : MDMA channel x Block Repeat address Update register
$52000164 constant MDMA_MDMA_C4LAR  \ offset: 0x164 : MDMA channel x Link Address register
$52000168 constant MDMA_MDMA_C4TBR  \ offset: 0x168 : MDMA channel x Trigger and Bus selection Register
$52000170 constant MDMA_MDMA_C4MAR  \ offset: 0x170 : MDMA channel x Mask address register
$52000174 constant MDMA_MDMA_C4MDR  \ offset: 0x174 : MDMA channel x Mask Data register
$52000180 constant MDMA_MDMA_C5ISR  \ offset: 0x180 : MDMA channel x interrupt/status register
$52000184 constant MDMA_MDMA_C5IFCR  \ offset: 0x184 : MDMA channel x interrupt flag clear register
$52000188 constant MDMA_MDMA_C5ESR  \ offset: 0x188 : MDMA Channel x error status register
$5200018c constant MDMA_MDMA_C5CR  \ offset: 0x18C : This register is used to control the concerned channel.
$52000190 constant MDMA_MDMA_C5TCR  \ offset: 0x190 : This register is used to configure the concerned channel.
$52000194 constant MDMA_MDMA_C5BNDTR  \ offset: 0x194 : MDMA Channel x block number of data register
$52000198 constant MDMA_MDMA_C5SAR  \ offset: 0x198 : MDMA channel x source address register
$5200019c constant MDMA_MDMA_C5DAR  \ offset: 0x19C : MDMA channel x destination address register
$520001a0 constant MDMA_MDMA_C5BRUR  \ offset: 0x1A0 : MDMA channel x Block Repeat address Update register
$520001a4 constant MDMA_MDMA_C5LAR  \ offset: 0x1A4 : MDMA channel x Link Address register
$520001a8 constant MDMA_MDMA_C5TBR  \ offset: 0x1A8 : MDMA channel x Trigger and Bus selection Register
$520001b0 constant MDMA_MDMA_C5MAR  \ offset: 0x1B0 : MDMA channel x Mask address register
$520001b4 constant MDMA_MDMA_C5MDR  \ offset: 0x1B4 : MDMA channel x Mask Data register
$520001c0 constant MDMA_MDMA_C6ISR  \ offset: 0x1C0 : MDMA channel x interrupt/status register
$520001c4 constant MDMA_MDMA_C6IFCR  \ offset: 0x1C4 : MDMA channel x interrupt flag clear register
$520001c8 constant MDMA_MDMA_C6ESR  \ offset: 0x1C8 : MDMA Channel x error status register
$520001cc constant MDMA_MDMA_C6CR  \ offset: 0x1CC : This register is used to control the concerned channel.
$520001d0 constant MDMA_MDMA_C6TCR  \ offset: 0x1D0 : This register is used to configure the concerned channel.
$520001d4 constant MDMA_MDMA_C6BNDTR  \ offset: 0x1D4 : MDMA Channel x block number of data register
$520001d8 constant MDMA_MDMA_C6SAR  \ offset: 0x1D8 : MDMA channel x source address register
$520001dc constant MDMA_MDMA_C6DAR  \ offset: 0x1DC : MDMA channel x destination address register
$520001e0 constant MDMA_MDMA_C6BRUR  \ offset: 0x1E0 : MDMA channel x Block Repeat address Update register
$520001e4 constant MDMA_MDMA_C6LAR  \ offset: 0x1E4 : MDMA channel x Link Address register
$520001e8 constant MDMA_MDMA_C6TBR  \ offset: 0x1E8 : MDMA channel x Trigger and Bus selection Register
$520001f0 constant MDMA_MDMA_C6MAR  \ offset: 0x1F0 : MDMA channel x Mask address register
$520001f4 constant MDMA_MDMA_C6MDR  \ offset: 0x1F4 : MDMA channel x Mask Data register
$52000200 constant MDMA_MDMA_C7ISR  \ offset: 0x200 : MDMA channel x interrupt/status register
$52000204 constant MDMA_MDMA_C7IFCR  \ offset: 0x204 : MDMA channel x interrupt flag clear register
$52000208 constant MDMA_MDMA_C7ESR  \ offset: 0x208 : MDMA Channel x error status register
$5200020c constant MDMA_MDMA_C7CR  \ offset: 0x20C : This register is used to control the concerned channel.
$52000210 constant MDMA_MDMA_C7TCR  \ offset: 0x210 : This register is used to configure the concerned channel.
$52000214 constant MDMA_MDMA_C7BNDTR  \ offset: 0x214 : MDMA Channel x block number of data register
$52000218 constant MDMA_MDMA_C7SAR  \ offset: 0x218 : MDMA channel x source address register
$5200021c constant MDMA_MDMA_C7DAR  \ offset: 0x21C : MDMA channel x destination address register
$52000220 constant MDMA_MDMA_C7BRUR  \ offset: 0x220 : MDMA channel x Block Repeat address Update register
$52000224 constant MDMA_MDMA_C7LAR  \ offset: 0x224 : MDMA channel x Link Address register
$52000228 constant MDMA_MDMA_C7TBR  \ offset: 0x228 : MDMA channel x Trigger and Bus selection Register
$52000230 constant MDMA_MDMA_C7MAR  \ offset: 0x230 : MDMA channel x Mask address register
$52000234 constant MDMA_MDMA_C7MDR  \ offset: 0x234 : MDMA channel x Mask Data register
$52000240 constant MDMA_MDMA_C8ISR  \ offset: 0x240 : MDMA channel x interrupt/status register
$52000244 constant MDMA_MDMA_C8IFCR  \ offset: 0x244 : MDMA channel x interrupt flag clear register
$52000248 constant MDMA_MDMA_C8ESR  \ offset: 0x248 : MDMA Channel x error status register
$5200024c constant MDMA_MDMA_C8CR  \ offset: 0x24C : This register is used to control the concerned channel.
$52000250 constant MDMA_MDMA_C8TCR  \ offset: 0x250 : This register is used to configure the concerned channel.
$52000254 constant MDMA_MDMA_C8BNDTR  \ offset: 0x254 : MDMA Channel x block number of data register
$52000258 constant MDMA_MDMA_C8SAR  \ offset: 0x258 : MDMA channel x source address register
$5200025c constant MDMA_MDMA_C8DAR  \ offset: 0x25C : MDMA channel x destination address register
$52000260 constant MDMA_MDMA_C8BRUR  \ offset: 0x260 : MDMA channel x Block Repeat address Update register
$52000264 constant MDMA_MDMA_C8LAR  \ offset: 0x264 : MDMA channel x Link Address register
$52000268 constant MDMA_MDMA_C8TBR  \ offset: 0x268 : MDMA channel x Trigger and Bus selection Register
$52000270 constant MDMA_MDMA_C8MAR  \ offset: 0x270 : MDMA channel x Mask address register
$52000274 constant MDMA_MDMA_C8MDR  \ offset: 0x274 : MDMA channel x Mask Data register
$52000280 constant MDMA_MDMA_C9ISR  \ offset: 0x280 : MDMA channel x interrupt/status register
$52000284 constant MDMA_MDMA_C9IFCR  \ offset: 0x284 : MDMA channel x interrupt flag clear register
$52000288 constant MDMA_MDMA_C9ESR  \ offset: 0x288 : MDMA Channel x error status register
$5200028c constant MDMA_MDMA_C9CR  \ offset: 0x28C : This register is used to control the concerned channel.
$52000290 constant MDMA_MDMA_C9TCR  \ offset: 0x290 : This register is used to configure the concerned channel.
$52000294 constant MDMA_MDMA_C9BNDTR  \ offset: 0x294 : MDMA Channel x block number of data register
$52000298 constant MDMA_MDMA_C9SAR  \ offset: 0x298 : MDMA channel x source address register
$5200029c constant MDMA_MDMA_C9DAR  \ offset: 0x29C : MDMA channel x destination address register
$520002a0 constant MDMA_MDMA_C9BRUR  \ offset: 0x2A0 : MDMA channel x Block Repeat address Update register
$520002a4 constant MDMA_MDMA_C9LAR  \ offset: 0x2A4 : MDMA channel x Link Address register
$520002a8 constant MDMA_MDMA_C9TBR  \ offset: 0x2A8 : MDMA channel x Trigger and Bus selection Register
$520002b0 constant MDMA_MDMA_C9MAR  \ offset: 0x2B0 : MDMA channel x Mask address register
$520002b4 constant MDMA_MDMA_C9MDR  \ offset: 0x2B4 : MDMA channel x Mask Data register
$520002c0 constant MDMA_MDMA_C10ISR  \ offset: 0x2C0 : MDMA channel x interrupt/status register
$520002c4 constant MDMA_MDMA_C10IFCR  \ offset: 0x2C4 : MDMA channel x interrupt flag clear register
$520002c8 constant MDMA_MDMA_C10ESR  \ offset: 0x2C8 : MDMA Channel x error status register
$520002cc constant MDMA_MDMA_C10CR  \ offset: 0x2CC : This register is used to control the concerned channel.
$520002d0 constant MDMA_MDMA_C10TCR  \ offset: 0x2D0 : This register is used to configure the concerned channel.
$520002d4 constant MDMA_MDMA_C10BNDTR  \ offset: 0x2D4 : MDMA Channel x block number of data register
$520002d8 constant MDMA_MDMA_C10SAR  \ offset: 0x2D8 : MDMA channel x source address register
$520002dc constant MDMA_MDMA_C10DAR  \ offset: 0x2DC : MDMA channel x destination address register
$520002e0 constant MDMA_MDMA_C10BRUR  \ offset: 0x2E0 : MDMA channel x Block Repeat address Update register
$520002e4 constant MDMA_MDMA_C10LAR  \ offset: 0x2E4 : MDMA channel x Link Address register
$520002e8 constant MDMA_MDMA_C10TBR  \ offset: 0x2E8 : MDMA channel x Trigger and Bus selection Register
$520002f0 constant MDMA_MDMA_C10MAR  \ offset: 0x2F0 : MDMA channel x Mask address register
$520002f4 constant MDMA_MDMA_C10MDR  \ offset: 0x2F4 : MDMA channel x Mask Data register
$52000300 constant MDMA_MDMA_C11ISR  \ offset: 0x300 : MDMA channel x interrupt/status register
$52000304 constant MDMA_MDMA_C11IFCR  \ offset: 0x304 : MDMA channel x interrupt flag clear register
$52000308 constant MDMA_MDMA_C11ESR  \ offset: 0x308 : MDMA Channel x error status register
$5200030c constant MDMA_MDMA_C11CR  \ offset: 0x30C : This register is used to control the concerned channel.
$52000310 constant MDMA_MDMA_C11TCR  \ offset: 0x310 : This register is used to configure the concerned channel.
$52000314 constant MDMA_MDMA_C11BNDTR  \ offset: 0x314 : MDMA Channel x block number of data register
$52000318 constant MDMA_MDMA_C11SAR  \ offset: 0x318 : MDMA channel x source address register
$5200031c constant MDMA_MDMA_C11DAR  \ offset: 0x31C : MDMA channel x destination address register
$52000320 constant MDMA_MDMA_C11BRUR  \ offset: 0x320 : MDMA channel x Block Repeat address Update register
$52000324 constant MDMA_MDMA_C11LAR  \ offset: 0x324 : MDMA channel x Link Address register
$52000328 constant MDMA_MDMA_C11TBR  \ offset: 0x328 : MDMA channel x Trigger and Bus selection Register
$52000330 constant MDMA_MDMA_C11MAR  \ offset: 0x330 : MDMA channel x Mask address register
$52000334 constant MDMA_MDMA_C11MDR  \ offset: 0x334 : MDMA channel x Mask Data register
$52000340 constant MDMA_MDMA_C12ISR  \ offset: 0x340 : MDMA channel x interrupt/status register
$52000344 constant MDMA_MDMA_C12IFCR  \ offset: 0x344 : MDMA channel x interrupt flag clear register
$52000348 constant MDMA_MDMA_C12ESR  \ offset: 0x348 : MDMA Channel x error status register
$5200034c constant MDMA_MDMA_C12CR  \ offset: 0x34C : This register is used to control the concerned channel.
$52000350 constant MDMA_MDMA_C12TCR  \ offset: 0x350 : This register is used to configure the concerned channel.
$52000354 constant MDMA_MDMA_C12BNDTR  \ offset: 0x354 : MDMA Channel x block number of data register
$52000358 constant MDMA_MDMA_C12SAR  \ offset: 0x358 : MDMA channel x source address register
$5200035c constant MDMA_MDMA_C12DAR  \ offset: 0x35C : MDMA channel x destination address register
$52000360 constant MDMA_MDMA_C12BRUR  \ offset: 0x360 : MDMA channel x Block Repeat address Update register
$52000364 constant MDMA_MDMA_C12LAR  \ offset: 0x364 : MDMA channel x Link Address register
$52000368 constant MDMA_MDMA_C12TBR  \ offset: 0x368 : MDMA channel x Trigger and Bus selection Register
$52000370 constant MDMA_MDMA_C12MAR  \ offset: 0x370 : MDMA channel x Mask address register
$52000374 constant MDMA_MDMA_C12MDR  \ offset: 0x374 : MDMA channel x Mask Data register
$52000380 constant MDMA_MDMA_C13ISR  \ offset: 0x380 : MDMA channel x interrupt/status register
$52000384 constant MDMA_MDMA_C13IFCR  \ offset: 0x384 : MDMA channel x interrupt flag clear register
$52000388 constant MDMA_MDMA_C13ESR  \ offset: 0x388 : MDMA Channel x error status register
$5200038c constant MDMA_MDMA_C13CR  \ offset: 0x38C : This register is used to control the concerned channel.
$52000390 constant MDMA_MDMA_C13TCR  \ offset: 0x390 : This register is used to configure the concerned channel.
$52000394 constant MDMA_MDMA_C13BNDTR  \ offset: 0x394 : MDMA Channel x block number of data register
$52000398 constant MDMA_MDMA_C13SAR  \ offset: 0x398 : MDMA channel x source address register
$5200039c constant MDMA_MDMA_C13DAR  \ offset: 0x39C : MDMA channel x destination address register
$520003a0 constant MDMA_MDMA_C13BRUR  \ offset: 0x3A0 : MDMA channel x Block Repeat address Update register
$520003a4 constant MDMA_MDMA_C13LAR  \ offset: 0x3A4 : MDMA channel x Link Address register
$520003a8 constant MDMA_MDMA_C13TBR  \ offset: 0x3A8 : MDMA channel x Trigger and Bus selection Register
$520003b0 constant MDMA_MDMA_C13MAR  \ offset: 0x3B0 : MDMA channel x Mask address register
$520003b4 constant MDMA_MDMA_C13MDR  \ offset: 0x3B4 : MDMA channel x Mask Data register
$520003c0 constant MDMA_MDMA_C14ISR  \ offset: 0x3C0 : MDMA channel x interrupt/status register
$520003c4 constant MDMA_MDMA_C14IFCR  \ offset: 0x3C4 : MDMA channel x interrupt flag clear register
$520003c8 constant MDMA_MDMA_C14ESR  \ offset: 0x3C8 : MDMA Channel x error status register
$520003cc constant MDMA_MDMA_C14CR  \ offset: 0x3CC : This register is used to control the concerned channel.
$520003d0 constant MDMA_MDMA_C14TCR  \ offset: 0x3D0 : This register is used to configure the concerned channel.
$520003d4 constant MDMA_MDMA_C14BNDTR  \ offset: 0x3D4 : MDMA Channel x block number of data register
$520003d8 constant MDMA_MDMA_C14SAR  \ offset: 0x3D8 : MDMA channel x source address register
$520003dc constant MDMA_MDMA_C14DAR  \ offset: 0x3DC : MDMA channel x destination address register
$520003e0 constant MDMA_MDMA_C14BRUR  \ offset: 0x3E0 : MDMA channel x Block Repeat address Update register
$520003e4 constant MDMA_MDMA_C14LAR  \ offset: 0x3E4 : MDMA channel x Link Address register
$520003e8 constant MDMA_MDMA_C14TBR  \ offset: 0x3E8 : MDMA channel x Trigger and Bus selection Register
$520003f0 constant MDMA_MDMA_C14MAR  \ offset: 0x3F0 : MDMA channel x Mask address register
$520003f4 constant MDMA_MDMA_C14MDR  \ offset: 0x3F4 : MDMA channel x Mask Data register
$52000400 constant MDMA_MDMA_C15ISR  \ offset: 0x400 : MDMA channel x interrupt/status register
$52000404 constant MDMA_MDMA_C15IFCR  \ offset: 0x404 : MDMA channel x interrupt flag clear register
$52000408 constant MDMA_MDMA_C15ESR  \ offset: 0x408 : MDMA Channel x error status register
$5200040c constant MDMA_MDMA_C15CR  \ offset: 0x40C : This register is used to control the concerned channel.
$52000410 constant MDMA_MDMA_C15TCR  \ offset: 0x410 : This register is used to configure the concerned channel.
$52000414 constant MDMA_MDMA_C15BNDTR  \ offset: 0x414 : MDMA Channel x block number of data register
$52000418 constant MDMA_MDMA_C15SAR  \ offset: 0x418 : MDMA channel x source address register
$5200041c constant MDMA_MDMA_C15DAR  \ offset: 0x41C : MDMA channel x destination address register
$52000420 constant MDMA_MDMA_C15BRUR  \ offset: 0x420 : MDMA channel x Block Repeat address Update register
$52000424 constant MDMA_MDMA_C15LAR  \ offset: 0x424 : MDMA channel x Link Address register
$52000428 constant MDMA_MDMA_C15TBR  \ offset: 0x428 : MDMA channel x Trigger and Bus selection Register
$52000430 constant MDMA_MDMA_C15MAR  \ offset: 0x430 : MDMA channel x Mask address register
$52000434 constant MDMA_MDMA_C15MDR  \ offset: 0x434 : MDMA channel x Mask Data register

