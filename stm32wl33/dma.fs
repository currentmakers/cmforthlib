\
\ @file dma.fs
\ @brief DMA address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMA_ISR register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_ISR_GIF1                                 \ GIF1: Channel 1 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 1 1: A TE, HT or TC event occurred on channel 1
$00000002 constant DMA_DMA_ISR_TCIF1                                \ TCIF1: Channel 1 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 1 1: A transfer complete (TC) event occurred on channel 1
$00000004 constant DMA_DMA_ISR_HTIF1                                \ HTIF1: Channel 1 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 1 1: A half transfer (HT) event occurred on channel 1
$00000008 constant DMA_DMA_ISR_TE1F1                                \ TEIF1: Channel 1 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 1 1: A transfer error (TE) occurred on channel 1
$00000010 constant DMA_DMA_ISR_GIF2                                 \ GIF2: Channel 2 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 2 1: A TE, HT or TC event occurred on channel 2
$00000020 constant DMA_DMA_ISR_TCIF2                                \ TCIF2: Channel 2 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 2 1: A transfer complete (TC) event occurred on channel 2
$00000040 constant DMA_DMA_ISR_HTIF2                                \ HTIF2: Channel 2 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 2 1: A half transfer (HT) event occurred on channel 2
$00000080 constant DMA_DMA_ISR_TE1F2                                \ TEIF2: Channel 2 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 2 1: A transfer error (TE) occurred on channel 2
$00000100 constant DMA_DMA_ISR_GIF3                                 \ GIF3: Channel 3 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 3 1: A TE, HT or TC event occurred on channel 3
$00000200 constant DMA_DMA_ISR_TCIF3                                \ TCIF3: Channel 3 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 3 1: A transfer complete (TC) event occurred on channel 3
$00000400 constant DMA_DMA_ISR_HTIF3                                \ HTIF3: Channel 3 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 3 1: A half transfer (HT) event occurred on channel 3
$00000800 constant DMA_DMA_ISR_TE1F3                                \ TEIF3: Channel 3 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 3 1: A transfer error (TE) occurred on channel 3
$00001000 constant DMA_DMA_ISR_GIF4                                 \ GIF4: Channel 4 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 4 1: A TE, HT or TC event occurred on channel 4
$00002000 constant DMA_DMA_ISR_TCIF4                                \ TCIF4: Channel 4 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 4 1: A transfer complete (TC) event occurred on channel 4
$00004000 constant DMA_DMA_ISR_HTIF4                                \ HTIF4: Channel 4 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 4 1: A half transfer (HT) event occurred on channel 4
$00008000 constant DMA_DMA_ISR_TE1F4                                \ TEIF4: Channel 4 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 4 1: A transfer error (TE) occurred on channel 4
$00010000 constant DMA_DMA_ISR_GIF5                                 \ GIF5: Channel 5 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 5 1: A TE, HT or TC event occurred on channel 5
$00020000 constant DMA_DMA_ISR_TCIF5                                \ TCIF5: Channel 5 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 5 1: A transfer complete (TC) event occurred on channel 5
$00040000 constant DMA_DMA_ISR_HTIF5                                \ HTIF5: Channel 5 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 5 1: A half transfer (HT) event occurred on channel 5
$00080000 constant DMA_DMA_ISR_TE1F5                                \ TEIF5: Channel 5 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 5 1: A transfer error (TE) occurred on channel 5
$00100000 constant DMA_DMA_ISR_GIF6                                 \ GIF6: Channel 6 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 6 1: A TE, HT or TC event occurred on channel 6
$00200000 constant DMA_DMA_ISR_TCIF6                                \ TCIF6: Channel 6 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 6 1: A transfer complete (TC) event occurred on channel 6
$00400000 constant DMA_DMA_ISR_HTIF6                                \ HTIF6: Channel 6 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 6 1: A half transfer (HT) event occurred on channel 6
$00800000 constant DMA_DMA_ISR_TE1F6                                \ TEIF6: Channel 6 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 6 1: A transfer error (TE) occurred on channel 6
$01000000 constant DMA_DMA_ISR_GIF7                                 \ GIF7: Channel 7 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 7 1: A TE, HT or TC event occurred on channel 7
$02000000 constant DMA_DMA_ISR_TCIF7                                \ TCIF7: Channel 7 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 7 1: A transfer complete (TC) event occurred on channel 7
$04000000 constant DMA_DMA_ISR_HTIF7                                \ HTIF7: Channel 7 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 7 1: A half transfer (HT) event occurred on channel 7
$08000000 constant DMA_DMA_ISR_TE1F7                                \ TEIF7: Channel 7 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 7 1: A transfer error (TE) occurred on channel 7
$10000000 constant DMA_DMA_ISR_GIF8                                 \ GIF8: Channel 8 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 8 1: A TE, HT or TC event occurred on channel 8
$20000000 constant DMA_DMA_ISR_TCIF8                                \ TCIF8: Channel 8 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 8 1: A transfer complete (TC) event occurred on channel 8
$40000000 constant DMA_DMA_ISR_HTIF8                                \ HTIF8: Channel 8 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 8 1: A half transfer (HT) event occurred on channel 8
$80000000 constant DMA_DMA_ISR_TE1F8                                \ TEIF8: Channel 8 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 8 1: A transfer error (TE) occurred on channel 8


\
\ @brief DMA_IFCR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_IFCR_CGIF1                               \ CGIF1: Channel 1 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
$00000002 constant DMA_DMA_IFCR_CTCIF1                              \ CTCIF1: Channel 1 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
$00000004 constant DMA_DMA_IFCR_CHTIF1                              \ CHTIF1: Channel 1 half transfer clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding HTIF flag in the DMA_ISR register
$00000008 constant DMA_DMA_IFCR_CTEIF1                              \ CTEIF1: Channel 1 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
$00000010 constant DMA_DMA_IFCR_CGIF2                               \ CGIF2: Channel 2 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
$00000020 constant DMA_DMA_IFCR_CTCIF2                              \ CTCIF2: Channel 2 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
$00000040 constant DMA_DMA_IFCR_CHTIF2                              \ CHTIF2: Channel 2 half transfer clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding HTIF flag in the DMA_ISR register
$00000080 constant DMA_DMA_IFCR_CTEIF2                              \ CTEIF2: Channel 2 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
$00000100 constant DMA_DMA_IFCR_CGIF3                               \ CGIF3: Channel 3 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
$00000200 constant DMA_DMA_IFCR_CTCIF3                              \ CTCIF3: Channel 3 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
$00000400 constant DMA_DMA_IFCR_CHTIF3                              \ CHTIF3: Channel 3 half transfer clear This bit is set and cleared by software. 0: No effect. 1: Clears the corresponding HTIF flag in the DMA_ISR register
$00000800 constant DMA_DMA_IFCR_CTEIF3                              \ CTEIF3: Channel 3 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
$00001000 constant DMA_DMA_IFCR_CGIF4                               \ CGIF4: Channel 4 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
$00002000 constant DMA_DMA_IFCR_CTCIF4                              \ CTCIF4: Channel 4 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
$00004000 constant DMA_DMA_IFCR_CHTIF4                              \ CHTIF4: Channel 4 half transfer clear This bit is set and cleared by software. 0: No effect. 1: Clears the corresponding HTIF flag in the DMA_ISR register
$00008000 constant DMA_DMA_IFCR_CTEIF4                              \ CTEIF4: Channel 4 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
$00010000 constant DMA_DMA_IFCR_CGIF5                               \ CGIF5: Channel 5 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
$00020000 constant DMA_DMA_IFCR_CTCIF5                              \ CTCIF5: Channel 5 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
$00040000 constant DMA_DMA_IFCR_CHTIF5                              \ CHTIF5: Channel 5 half transfer clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding HTIF flag in the DMA_ISR register
$00080000 constant DMA_DMA_IFCR_CTEIF5                              \ CTEIF5: Channel 5 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
$00100000 constant DMA_DMA_IFCR_CGIF6                               \ CGIF6: Channel 6 global interrupt clear This bit is set and cleared by software. 0: No effect. 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
$00200000 constant DMA_DMA_IFCR_CTCIF6                              \ CTCIF6: Channel 6 transfer complete clear This bit is set and cleared by software. 0: No effect. 1: Clears the corresponding TCIF flag in the DMA_ISR register
$00400000 constant DMA_DMA_IFCR_CHTIF6                              \ CHTIF6: Channel 6 half transfer clear This bit is set and cleared by software. 0: No effect. 1: Clears the corresponding HTIF flag in the DMA_ISR register
$00800000 constant DMA_DMA_IFCR_CTEIF6                              \ CTEIF6: Channel 6 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
$01000000 constant DMA_DMA_IFCR_CGIF7                               \ CGIF7: Channel 7 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
$02000000 constant DMA_DMA_IFCR_CTCIF7                              \ CTCIF7: Channel 7 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
$04000000 constant DMA_DMA_IFCR_CHTIF7                              \ CHTIF7: Channel 7 half transfer clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding HTIF flag in the DMA_ISR register
$08000000 constant DMA_DMA_IFCR_CTEIF7                              \ CTEIF7: Channel 7 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
$10000000 constant DMA_DMA_IFCR_CGIF8                               \ CGIF8: Channel 8 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
$20000000 constant DMA_DMA_IFCR_CTCIF8                              \ CTCIF8: Channel 8 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
$40000000 constant DMA_DMA_IFCR_CHTIF8                              \ CHTIF8: Channel 8 half transfer clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding HTIF flag in the DMA_ISR register
$80000000 constant DMA_DMA_IFCR_CTEIF8                              \ CTEIF8: Channel 8 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register


\
\ @brief DMA_CCRx register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_CCR1_EN                                  \ EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
$00000002 constant DMA_DMA_CCR1_TCIE                                \ TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
$00000004 constant DMA_DMA_CCR1_HTIE                                \ HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
$00000008 constant DMA_DMA_CCR1_TEIE                                \ TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
$00000010 constant DMA_DMA_CCR1_DIR                                 \ DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
$00000020 constant DMA_DMA_CCR1_CIRC                                \ CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
$00000040 constant DMA_DMA_CCR1_PINC                                \ PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
$00000080 constant DMA_DMA_CCR1_MINC                                \ MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
$00000300 constant DMA_DMA_CCR1_PSIZE                               \ PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00000c00 constant DMA_DMA_CCR1_MSIZE                               \ MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00003000 constant DMA_DMA_CCR1_PL                                  \ PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
$00004000 constant DMA_DMA_CCR1_MEM2MEM                             \ MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled


\
\ @brief DMA_CNDTRx register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DMA_DMA_CNDTR1_NDT                               \ NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief DMA_CPARx register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CPAR1_PA                                 \ PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CMARx register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CMAR1_MA                                 \ MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CCRx register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_CCR2_EN                                  \ EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
$00000002 constant DMA_DMA_CCR2_TCIE                                \ TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
$00000004 constant DMA_DMA_CCR2_HTIE                                \ HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
$00000008 constant DMA_DMA_CCR2_TEIE                                \ TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
$00000010 constant DMA_DMA_CCR2_DIR                                 \ DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
$00000020 constant DMA_DMA_CCR2_CIRC                                \ CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
$00000040 constant DMA_DMA_CCR2_PINC                                \ PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
$00000080 constant DMA_DMA_CCR2_MINC                                \ MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
$00000300 constant DMA_DMA_CCR2_PSIZE                               \ PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00000c00 constant DMA_DMA_CCR2_MSIZE                               \ MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00003000 constant DMA_DMA_CCR2_PL                                  \ PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
$00004000 constant DMA_DMA_CCR2_MEM2MEM                             \ MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled


\
\ @brief DMA_CNDTRx register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant DMA_DMA_CNDTR2_NDT                               \ NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief DMA_CPARx register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CPAR2_PA                                 \ PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CMARx register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CMAR2_MA                                 \ MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CCRx register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_CCR3_EN                                  \ EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
$00000002 constant DMA_DMA_CCR3_TCIE                                \ TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
$00000004 constant DMA_DMA_CCR3_HTIE                                \ HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
$00000008 constant DMA_DMA_CCR3_TEIE                                \ TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
$00000010 constant DMA_DMA_CCR3_DIR                                 \ DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
$00000020 constant DMA_DMA_CCR3_CIRC                                \ CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
$00000040 constant DMA_DMA_CCR3_PINC                                \ PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
$00000080 constant DMA_DMA_CCR3_MINC                                \ MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
$00000300 constant DMA_DMA_CCR3_PSIZE                               \ PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00000c00 constant DMA_DMA_CCR3_MSIZE                               \ MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00003000 constant DMA_DMA_CCR3_PL                                  \ PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
$00004000 constant DMA_DMA_CCR3_MEM2MEM                             \ MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled


\
\ @brief DMA_CNDTRx register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant DMA_DMA_CNDTR3_NDT                               \ NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief DMA_CPARx register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CPAR3_PA                                 \ PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CMARx register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CMAR3_MA                                 \ MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CCRx register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_CCR4_EN                                  \ EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
$00000002 constant DMA_DMA_CCR4_TCIE                                \ TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
$00000004 constant DMA_DMA_CCR4_HTIE                                \ HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
$00000008 constant DMA_DMA_CCR4_TEIE                                \ TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
$00000010 constant DMA_DMA_CCR4_DIR                                 \ DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
$00000020 constant DMA_DMA_CCR4_CIRC                                \ CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
$00000040 constant DMA_DMA_CCR4_PINC                                \ PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
$00000080 constant DMA_DMA_CCR4_MINC                                \ MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
$00000300 constant DMA_DMA_CCR4_PSIZE                               \ PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00000c00 constant DMA_DMA_CCR4_MSIZE                               \ MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00003000 constant DMA_DMA_CCR4_PL                                  \ PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
$00004000 constant DMA_DMA_CCR4_MEM2MEM                             \ MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled


\
\ @brief DMA_CNDTRx register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant DMA_DMA_CNDTR4_NDT                               \ NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief DMA_CPARx register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CPAR4_PA                                 \ PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CMARx register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CMAR4_MA                                 \ MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CCRx register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_CCR5_EN                                  \ EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
$00000002 constant DMA_DMA_CCR5_TCIE                                \ TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
$00000004 constant DMA_DMA_CCR5_HTIE                                \ HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
$00000008 constant DMA_DMA_CCR5_TEIE                                \ TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
$00000010 constant DMA_DMA_CCR5_DIR                                 \ DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
$00000020 constant DMA_DMA_CCR5_CIRC                                \ CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
$00000040 constant DMA_DMA_CCR5_PINC                                \ PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
$00000080 constant DMA_DMA_CCR5_MINC                                \ MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
$00000300 constant DMA_DMA_CCR5_PSIZE                               \ PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00000c00 constant DMA_DMA_CCR5_MSIZE                               \ MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00003000 constant DMA_DMA_CCR5_PL                                  \ PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
$00004000 constant DMA_DMA_CCR5_MEM2MEM                             \ MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled


\
\ @brief DMA_CNDTRx register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant DMA_DMA_CNDTR5_NDT                               \ NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief DMA_CPARx register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CPAR5_PA                                 \ PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CMARx register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CMAR5_MA                                 \ MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CCRx register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_CCR6_EN                                  \ EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
$00000002 constant DMA_DMA_CCR6_TCIE                                \ TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
$00000004 constant DMA_DMA_CCR6_HTIE                                \ HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
$00000008 constant DMA_DMA_CCR6_TEIE                                \ TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
$00000010 constant DMA_DMA_CCR6_DIR                                 \ DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
$00000020 constant DMA_DMA_CCR6_CIRC                                \ CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
$00000040 constant DMA_DMA_CCR6_PINC                                \ PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
$00000080 constant DMA_DMA_CCR6_MINC                                \ MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
$00000300 constant DMA_DMA_CCR6_PSIZE                               \ PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00000c00 constant DMA_DMA_CCR6_MSIZE                               \ MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00003000 constant DMA_DMA_CCR6_PL                                  \ PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
$00004000 constant DMA_DMA_CCR6_MEM2MEM                             \ MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled


\
\ @brief DMA_CNDTRx register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DMA_DMA_CNDTR6_NDT                               \ NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief DMA_CPARx register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CPAR6_PA                                 \ PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CMARx register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CMAR6_MA                                 \ MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CCRx register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_CCR7_EN                                  \ EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
$00000002 constant DMA_DMA_CCR7_TCIE                                \ TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
$00000004 constant DMA_DMA_CCR7_HTIE                                \ HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
$00000008 constant DMA_DMA_CCR7_TEIE                                \ TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
$00000010 constant DMA_DMA_CCR7_DIR                                 \ DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
$00000020 constant DMA_DMA_CCR7_CIRC                                \ CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
$00000040 constant DMA_DMA_CCR7_PINC                                \ PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
$00000080 constant DMA_DMA_CCR7_MINC                                \ MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
$00000300 constant DMA_DMA_CCR7_PSIZE                               \ PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00000c00 constant DMA_DMA_CCR7_MSIZE                               \ MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00003000 constant DMA_DMA_CCR7_PL                                  \ PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
$00004000 constant DMA_DMA_CCR7_MEM2MEM                             \ MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled


\
\ @brief DMA_CNDTRx register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant DMA_DMA_CNDTR7_NDT                               \ NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief DMA_CPARx register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CPAR7_PA                                 \ PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CMARx register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CMAR7_MA                                 \ MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CCRx register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_CCR8_EN                                  \ EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
$00000002 constant DMA_DMA_CCR8_TCIE                                \ TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
$00000004 constant DMA_DMA_CCR8_HTIE                                \ HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
$00000008 constant DMA_DMA_CCR8_TEIE                                \ TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
$00000010 constant DMA_DMA_CCR8_DIR                                 \ DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
$00000020 constant DMA_DMA_CCR8_CIRC                                \ CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
$00000040 constant DMA_DMA_CCR8_PINC                                \ PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
$00000080 constant DMA_DMA_CCR8_MINC                                \ MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
$00000300 constant DMA_DMA_CCR8_PSIZE                               \ PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00000c00 constant DMA_DMA_CCR8_MSIZE                               \ MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
$00003000 constant DMA_DMA_CCR8_PL                                  \ PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
$00004000 constant DMA_DMA_CCR8_MEM2MEM                             \ MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled


\
\ @brief DMA_CNDTRx register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant DMA_DMA_CNDTR8_NDT                               \ NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief DMA_CPARx register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CPAR8_PA                                 \ PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA_CMARx register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CMAR8_MA                                 \ MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief DMA address block description
\
$48700000 constant DMA_DMA_ISR    \ offset: 0x00 : DMA_ISR register
$48700004 constant DMA_DMA_IFCR   \ offset: 0x04 : DMA_IFCR register
$48700008 constant DMA_DMA_CCR1   \ offset: 0x08 : DMA_CCRx register
$4870000c constant DMA_DMA_CNDTR1  \ offset: 0x0C : DMA_CNDTRx register
$48700010 constant DMA_DMA_CPAR1  \ offset: 0x10 : DMA_CPARx register
$48700014 constant DMA_DMA_CMAR1  \ offset: 0x14 : DMA_CMARx register
$4870001c constant DMA_DMA_CCR2   \ offset: 0x1C : DMA_CCRx register
$48700020 constant DMA_DMA_CNDTR2  \ offset: 0x20 : DMA_CNDTRx register
$48700024 constant DMA_DMA_CPAR2  \ offset: 0x24 : DMA_CPARx register
$48700028 constant DMA_DMA_CMAR2  \ offset: 0x28 : DMA_CMARx register
$48700030 constant DMA_DMA_CCR3   \ offset: 0x30 : DMA_CCRx register
$48700034 constant DMA_DMA_CNDTR3  \ offset: 0x34 : DMA_CNDTRx register
$48700038 constant DMA_DMA_CPAR3  \ offset: 0x38 : DMA_CPARx register
$4870003c constant DMA_DMA_CMAR3  \ offset: 0x3C : DMA_CMARx register
$48700044 constant DMA_DMA_CCR4   \ offset: 0x44 : DMA_CCRx register
$48700048 constant DMA_DMA_CNDTR4  \ offset: 0x48 : DMA_CNDTRx register
$4870004c constant DMA_DMA_CPAR4  \ offset: 0x4C : DMA_CPARx register
$48700050 constant DMA_DMA_CMAR4  \ offset: 0x50 : DMA_CMARx register
$48700058 constant DMA_DMA_CCR5   \ offset: 0x58 : DMA_CCRx register
$4870005c constant DMA_DMA_CNDTR5  \ offset: 0x5C : DMA_CNDTRx register
$48700060 constant DMA_DMA_CPAR5  \ offset: 0x60 : DMA_CPARx register
$48700064 constant DMA_DMA_CMAR5  \ offset: 0x64 : DMA_CMARx register
$4870006c constant DMA_DMA_CCR6   \ offset: 0x6C : DMA_CCRx register
$48700070 constant DMA_DMA_CNDTR6  \ offset: 0x70 : DMA_CNDTRx register
$48700074 constant DMA_DMA_CPAR6  \ offset: 0x74 : DMA_CPARx register
$48700078 constant DMA_DMA_CMAR6  \ offset: 0x78 : DMA_CMARx register
$48700080 constant DMA_DMA_CCR7   \ offset: 0x80 : DMA_CCRx register
$48700084 constant DMA_DMA_CNDTR7  \ offset: 0x84 : DMA_CNDTRx register
$48700088 constant DMA_DMA_CPAR7  \ offset: 0x88 : DMA_CPARx register
$4870008c constant DMA_DMA_CMAR7  \ offset: 0x8C : DMA_CMARx register
$48700094 constant DMA_DMA_CCR8   \ offset: 0x94 : DMA_CCRx register
$48700098 constant DMA_DMA_CNDTR8  \ offset: 0x98 : DMA_CNDTRx register
$4870009c constant DMA_DMA_CPAR8  \ offset: 0x9C : DMA_CPARx register
$487000a0 constant DMA_DMA_CMAR8  \ offset: 0xA0 : DMA_CMARx register

