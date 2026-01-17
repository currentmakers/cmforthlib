\
\ @file dma.fs
\ @brief DMA address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMA_DEF

  [ifdef] DMA_DMA_ISR_DEF
    \
    \ @brief DMA_ISR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMA_GIF1                       \ [0x00] GIF1: Channel 1 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 1 1: A TE, HT or TC event occurred on channel 1
    $01 constant DMA_TCIF1                      \ [0x01] TCIF1: Channel 1 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 1 1: A transfer complete (TC) event occurred on channel 1
    $02 constant DMA_HTIF1                      \ [0x02] HTIF1: Channel 1 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 1 1: A half transfer (HT) event occurred on channel 1
    $03 constant DMA_TE1F1                      \ [0x03] TEIF1: Channel 1 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 1 1: A transfer error (TE) occurred on channel 1
    $04 constant DMA_GIF2                       \ [0x04] GIF2: Channel 2 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 2 1: A TE, HT or TC event occurred on channel 2
    $05 constant DMA_TCIF2                      \ [0x05] TCIF2: Channel 2 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 2 1: A transfer complete (TC) event occurred on channel 2
    $06 constant DMA_HTIF2                      \ [0x06] HTIF2: Channel 2 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 2 1: A half transfer (HT) event occurred on channel 2
    $07 constant DMA_TE1F2                      \ [0x07] TEIF2: Channel 2 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 2 1: A transfer error (TE) occurred on channel 2
    $08 constant DMA_GIF3                       \ [0x08] GIF3: Channel 3 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 3 1: A TE, HT or TC event occurred on channel 3
    $09 constant DMA_TCIF3                      \ [0x09] TCIF3: Channel 3 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 3 1: A transfer complete (TC) event occurred on channel 3
    $0a constant DMA_HTIF3                      \ [0x0a] HTIF3: Channel 3 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 3 1: A half transfer (HT) event occurred on channel 3
    $0b constant DMA_TE1F3                      \ [0x0b] TEIF3: Channel 3 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 3 1: A transfer error (TE) occurred on channel 3
    $0c constant DMA_GIF4                       \ [0x0c] GIF4: Channel 4 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 4 1: A TE, HT or TC event occurred on channel 4
    $0d constant DMA_TCIF4                      \ [0x0d] TCIF4: Channel 4 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 4 1: A transfer complete (TC) event occurred on channel 4
    $0e constant DMA_HTIF4                      \ [0x0e] HTIF4: Channel 4 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 4 1: A half transfer (HT) event occurred on channel 4
    $0f constant DMA_TE1F4                      \ [0x0f] TEIF4: Channel 4 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 4 1: A transfer error (TE) occurred on channel 4
    $10 constant DMA_GIF5                       \ [0x10] GIF5: Channel 5 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 5 1: A TE, HT or TC event occurred on channel 5
    $11 constant DMA_TCIF5                      \ [0x11] TCIF5: Channel 5 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 5 1: A transfer complete (TC) event occurred on channel 5
    $12 constant DMA_HTIF5                      \ [0x12] HTIF5: Channel 5 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 5 1: A half transfer (HT) event occurred on channel 5
    $13 constant DMA_TE1F5                      \ [0x13] TEIF5: Channel 5 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 5 1: A transfer error (TE) occurred on channel 5
    $14 constant DMA_GIF6                       \ [0x14] GIF6: Channel 6 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 6 1: A TE, HT or TC event occurred on channel 6
    $15 constant DMA_TCIF6                      \ [0x15] TCIF6: Channel 6 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 6 1: A transfer complete (TC) event occurred on channel 6
    $16 constant DMA_HTIF6                      \ [0x16] HTIF6: Channel 6 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 6 1: A half transfer (HT) event occurred on channel 6
    $17 constant DMA_TE1F6                      \ [0x17] TEIF6: Channel 6 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 6 1: A transfer error (TE) occurred on channel 6
    $18 constant DMA_GIF7                       \ [0x18] GIF7: Channel 7 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 7 1: A TE, HT or TC event occurred on channel 7
    $19 constant DMA_TCIF7                      \ [0x19] TCIF7: Channel 7 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 7 1: A transfer complete (TC) event occurred on channel 7
    $1a constant DMA_HTIF7                      \ [0x1a] HTIF7: Channel 7 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 7 1: A half transfer (HT) event occurred on channel 7
    $1b constant DMA_TE1F7                      \ [0x1b] TEIF7: Channel 7 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 7 1: A transfer error (TE) occurred on channel 7
    $1c constant DMA_GIF8                       \ [0x1c] GIF8: Channel 8 global interrupt flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No TE, HT or TC event on channel 8 1: A TE, HT or TC event occurred on channel 8
    $1d constant DMA_TCIF8                      \ [0x1d] TCIF8: Channel 8 transfer complete flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer complete (TC) event on channel 8 1: A transfer complete (TC) event occurred on channel 8
    $1e constant DMA_HTIF8                      \ [0x1e] HTIF8: Channel 8 half transfer flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No half transfer (HT) event on channel 8 1: A half transfer (HT) event occurred on channel 8
    $1f constant DMA_TE1F8                      \ [0x1f] TEIF8: Channel 8 transfer error flag This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register. 0: No transfer error (TE) on channel 8 1: A transfer error (TE) occurred on channel 8
  [then]


  [ifdef] DMA_DMA_IFCR_DEF
    \
    \ @brief DMA_IFCR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMA_CGIF1                      \ [0x00] CGIF1: Channel 1 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
    $01 constant DMA_CTCIF1                     \ [0x01] CTCIF1: Channel 1 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
    $02 constant DMA_CHTIF1                     \ [0x02] CHTIF1: Channel 1 half transfer clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding HTIF flag in the DMA_ISR register
    $03 constant DMA_CTEIF1                     \ [0x03] CTEIF1: Channel 1 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
    $04 constant DMA_CGIF2                      \ [0x04] CGIF2: Channel 2 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
    $05 constant DMA_CTCIF2                     \ [0x05] CTCIF2: Channel 2 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
    $06 constant DMA_CHTIF2                     \ [0x06] CHTIF2: Channel 2 half transfer clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding HTIF flag in the DMA_ISR register
    $07 constant DMA_CTEIF2                     \ [0x07] CTEIF2: Channel 2 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
    $08 constant DMA_CGIF3                      \ [0x08] CGIF3: Channel 3 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
    $09 constant DMA_CTCIF3                     \ [0x09] CTCIF3: Channel 3 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
    $0a constant DMA_CHTIF3                     \ [0x0a] CHTIF3: Channel 3 half transfer clear This bit is set and cleared by software. 0: No effect. 1: Clears the corresponding HTIF flag in the DMA_ISR register
    $0b constant DMA_CTEIF3                     \ [0x0b] CTEIF3: Channel 3 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
    $0c constant DMA_CGIF4                      \ [0x0c] CGIF4: Channel 4 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
    $0d constant DMA_CTCIF4                     \ [0x0d] CTCIF4: Channel 4 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
    $0e constant DMA_CHTIF4                     \ [0x0e] CHTIF4: Channel 4 half transfer clear This bit is set and cleared by software. 0: No effect. 1: Clears the corresponding HTIF flag in the DMA_ISR register
    $0f constant DMA_CTEIF4                     \ [0x0f] CTEIF4: Channel 4 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
    $10 constant DMA_CGIF5                      \ [0x10] CGIF5: Channel 5 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
    $11 constant DMA_CTCIF5                     \ [0x11] CTCIF5: Channel 5 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
    $12 constant DMA_CHTIF5                     \ [0x12] CHTIF5: Channel 5 half transfer clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding HTIF flag in the DMA_ISR register
    $13 constant DMA_CTEIF5                     \ [0x13] CTEIF5: Channel 5 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
    $14 constant DMA_CGIF6                      \ [0x14] CGIF6: Channel 6 global interrupt clear This bit is set and cleared by software. 0: No effect. 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
    $15 constant DMA_CTCIF6                     \ [0x15] CTCIF6: Channel 6 transfer complete clear This bit is set and cleared by software. 0: No effect. 1: Clears the corresponding TCIF flag in the DMA_ISR register
    $16 constant DMA_CHTIF6                     \ [0x16] CHTIF6: Channel 6 half transfer clear This bit is set and cleared by software. 0: No effect. 1: Clears the corresponding HTIF flag in the DMA_ISR register
    $17 constant DMA_CTEIF6                     \ [0x17] CTEIF6: Channel 6 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
    $18 constant DMA_CGIF7                      \ [0x18] CGIF7: Channel 7 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
    $19 constant DMA_CTCIF7                     \ [0x19] CTCIF7: Channel 7 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
    $1a constant DMA_CHTIF7                     \ [0x1a] CHTIF7: Channel 7 half transfer clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding HTIF flag in the DMA_ISR register
    $1b constant DMA_CTEIF7                     \ [0x1b] CTEIF7: Channel 7 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
    $1c constant DMA_CGIF8                      \ [0x1c] CGIF8: Channel 8 global interrupt clear This bit is set and cleared by software. 0: No effect 1: Clears the GIF, TEIF, HTIF and TCIF flags in the DMA_ISR register
    $1d constant DMA_CTCIF8                     \ [0x1d] CTCIF8: Channel 8 transfer complete clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TCIF flag in the DMA_ISR register
    $1e constant DMA_CHTIF8                     \ [0x1e] CHTIF8: Channel 8 half transfer clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding HTIF flag in the DMA_ISR register
    $1f constant DMA_CTEIF8                     \ [0x1f] CTEIF8: Channel 8 transfer error clear This bit is set and cleared by software. 0: No effect 1: Clears the corresponding TEIF flag in the DMA_ISR register
  [then]


  [ifdef] DMA_DMA_CCR1_DEF
    \
    \ @brief DMA_CCRx register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
    $01 constant DMA_TCIE                       \ [0x01] TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
    $02 constant DMA_HTIE                       \ [0x02] HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
    $03 constant DMA_TEIE                       \ [0x03] TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
    $04 constant DMA_DIR                        \ [0x04] DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
    $05 constant DMA_CIRC                       \ [0x05] CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
    $06 constant DMA_PINC                       \ [0x06] PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
    $07 constant DMA_MINC                       \ [0x07] MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
    $08 constant DMA_PSIZE                      \ [0x08 : 2] PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0a constant DMA_MSIZE                      \ [0x0a : 2] MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0c constant DMA_PL                         \ [0x0c : 2] PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
    $0e constant DMA_MEM2MEM                    \ [0x0e] MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled
  [then]


  [ifdef] DMA_DMA_CNDTR1_DEF
    \
    \ @brief DMA_CNDTRx register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] DMA_DMA_CPAR1_DEF
    \
    \ @brief DMA_CPARx register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CMAR1_DEF
    \
    \ @brief DMA_CMARx register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CCR2_DEF
    \
    \ @brief DMA_CCRx register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
    $01 constant DMA_TCIE                       \ [0x01] TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
    $02 constant DMA_HTIE                       \ [0x02] HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
    $03 constant DMA_TEIE                       \ [0x03] TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
    $04 constant DMA_DIR                        \ [0x04] DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
    $05 constant DMA_CIRC                       \ [0x05] CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
    $06 constant DMA_PINC                       \ [0x06] PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
    $07 constant DMA_MINC                       \ [0x07] MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
    $08 constant DMA_PSIZE                      \ [0x08 : 2] PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0a constant DMA_MSIZE                      \ [0x0a : 2] MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0c constant DMA_PL                         \ [0x0c : 2] PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
    $0e constant DMA_MEM2MEM                    \ [0x0e] MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled
  [then]


  [ifdef] DMA_DMA_CNDTR2_DEF
    \
    \ @brief DMA_CNDTRx register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] DMA_DMA_CPAR2_DEF
    \
    \ @brief DMA_CPARx register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CMAR2_DEF
    \
    \ @brief DMA_CMARx register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CCR3_DEF
    \
    \ @brief DMA_CCRx register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
    $01 constant DMA_TCIE                       \ [0x01] TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
    $02 constant DMA_HTIE                       \ [0x02] HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
    $03 constant DMA_TEIE                       \ [0x03] TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
    $04 constant DMA_DIR                        \ [0x04] DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
    $05 constant DMA_CIRC                       \ [0x05] CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
    $06 constant DMA_PINC                       \ [0x06] PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
    $07 constant DMA_MINC                       \ [0x07] MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
    $08 constant DMA_PSIZE                      \ [0x08 : 2] PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0a constant DMA_MSIZE                      \ [0x0a : 2] MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0c constant DMA_PL                         \ [0x0c : 2] PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
    $0e constant DMA_MEM2MEM                    \ [0x0e] MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled
  [then]


  [ifdef] DMA_DMA_CNDTR3_DEF
    \
    \ @brief DMA_CNDTRx register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] DMA_DMA_CPAR3_DEF
    \
    \ @brief DMA_CPARx register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CMAR3_DEF
    \
    \ @brief DMA_CMARx register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CCR4_DEF
    \
    \ @brief DMA_CCRx register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
    $01 constant DMA_TCIE                       \ [0x01] TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
    $02 constant DMA_HTIE                       \ [0x02] HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
    $03 constant DMA_TEIE                       \ [0x03] TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
    $04 constant DMA_DIR                        \ [0x04] DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
    $05 constant DMA_CIRC                       \ [0x05] CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
    $06 constant DMA_PINC                       \ [0x06] PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
    $07 constant DMA_MINC                       \ [0x07] MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
    $08 constant DMA_PSIZE                      \ [0x08 : 2] PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0a constant DMA_MSIZE                      \ [0x0a : 2] MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0c constant DMA_PL                         \ [0x0c : 2] PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
    $0e constant DMA_MEM2MEM                    \ [0x0e] MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled
  [then]


  [ifdef] DMA_DMA_CNDTR4_DEF
    \
    \ @brief DMA_CNDTRx register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] DMA_DMA_CPAR4_DEF
    \
    \ @brief DMA_CPARx register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CMAR4_DEF
    \
    \ @brief DMA_CMARx register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CCR5_DEF
    \
    \ @brief DMA_CCRx register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
    $01 constant DMA_TCIE                       \ [0x01] TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
    $02 constant DMA_HTIE                       \ [0x02] HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
    $03 constant DMA_TEIE                       \ [0x03] TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
    $04 constant DMA_DIR                        \ [0x04] DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
    $05 constant DMA_CIRC                       \ [0x05] CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
    $06 constant DMA_PINC                       \ [0x06] PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
    $07 constant DMA_MINC                       \ [0x07] MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
    $08 constant DMA_PSIZE                      \ [0x08 : 2] PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0a constant DMA_MSIZE                      \ [0x0a : 2] MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0c constant DMA_PL                         \ [0x0c : 2] PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
    $0e constant DMA_MEM2MEM                    \ [0x0e] MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled
  [then]


  [ifdef] DMA_DMA_CNDTR5_DEF
    \
    \ @brief DMA_CNDTRx register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] DMA_DMA_CPAR5_DEF
    \
    \ @brief DMA_CPARx register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CMAR5_DEF
    \
    \ @brief DMA_CMARx register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CCR6_DEF
    \
    \ @brief DMA_CCRx register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
    $01 constant DMA_TCIE                       \ [0x01] TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
    $02 constant DMA_HTIE                       \ [0x02] HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
    $03 constant DMA_TEIE                       \ [0x03] TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
    $04 constant DMA_DIR                        \ [0x04] DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
    $05 constant DMA_CIRC                       \ [0x05] CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
    $06 constant DMA_PINC                       \ [0x06] PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
    $07 constant DMA_MINC                       \ [0x07] MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
    $08 constant DMA_PSIZE                      \ [0x08 : 2] PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0a constant DMA_MSIZE                      \ [0x0a : 2] MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0c constant DMA_PL                         \ [0x0c : 2] PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
    $0e constant DMA_MEM2MEM                    \ [0x0e] MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled
  [then]


  [ifdef] DMA_DMA_CNDTR6_DEF
    \
    \ @brief DMA_CNDTRx register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] DMA_DMA_CPAR6_DEF
    \
    \ @brief DMA_CPARx register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CMAR6_DEF
    \
    \ @brief DMA_CMARx register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CCR7_DEF
    \
    \ @brief DMA_CCRx register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
    $01 constant DMA_TCIE                       \ [0x01] TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
    $02 constant DMA_HTIE                       \ [0x02] HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
    $03 constant DMA_TEIE                       \ [0x03] TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
    $04 constant DMA_DIR                        \ [0x04] DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
    $05 constant DMA_CIRC                       \ [0x05] CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
    $06 constant DMA_PINC                       \ [0x06] PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
    $07 constant DMA_MINC                       \ [0x07] MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
    $08 constant DMA_PSIZE                      \ [0x08 : 2] PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0a constant DMA_MSIZE                      \ [0x0a : 2] MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0c constant DMA_PL                         \ [0x0c : 2] PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
    $0e constant DMA_MEM2MEM                    \ [0x0e] MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled
  [then]


  [ifdef] DMA_DMA_CNDTR7_DEF
    \
    \ @brief DMA_CNDTRx register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] DMA_DMA_CPAR7_DEF
    \
    \ @brief DMA_CPARx register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CMAR7_DEF
    \
    \ @brief DMA_CMARx register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CCR8_DEF
    \
    \ @brief DMA_CCRx register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN: Channel enable This bit is set and cleared by software. 0: Channel disabled 1: Channel enabled
    $01 constant DMA_TCIE                       \ [0x01] TCIE: Transfer complete interrupt enable This bit is set and cleared by software. 0: TC interrupt disabled 1: TC interrupt enabled
    $02 constant DMA_HTIE                       \ [0x02] HTIE: Half transfer interrupt enable This bit is set and cleared by software. 0: HT interrupt disabled 1: HT interrupt enabled
    $03 constant DMA_TEIE                       \ [0x03] TEIE: Transfer error interrupt enable This bit is set and cleared by software. 0: TE interrupt disabled 1: TE interrupt enabled
    $04 constant DMA_DIR                        \ [0x04] DIR: Data transfer direction This bit is set and cleared by software. 0: Read from peripheral. 1: Read from memory
    $05 constant DMA_CIRC                       \ [0x05] CIRC: Circular mode This bit is set and cleared by software. 0: Circular mode disabled 1: Circular mode enabled
    $06 constant DMA_PINC                       \ [0x06] PINC: Peripheral increment mode This bit is set and cleared by software. 0: Peripheral increment mode disabled 1: Peripheral increment mode enabled
    $07 constant DMA_MINC                       \ [0x07] MINC: Memory increment mode This bit is set and cleared by software. 0: Memory increment mode disabled 1: Memory increment mode enabled
    $08 constant DMA_PSIZE                      \ [0x08 : 2] PSIZE[1:0]: Peripheral size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0a constant DMA_MSIZE                      \ [0x0a : 2] MSIZE[1:0]: Memory size These bits are set and cleared by software. 00: 8-bits 01: 16-bits 10: 32-bits
    $0c constant DMA_PL                         \ [0x0c : 2] PL[1:0]: Channel priority level These bits are set and cleared by software. 00: Low 01: Medium 10: High 11: Very high
    $0e constant DMA_MEM2MEM                    \ [0x0e] MEM2MEM: Memory to memory mode This bit is set and cleared by software. 0: Memory to memory mode disabled 1: Memory to memory mode enabled
  [then]


  [ifdef] DMA_DMA_CNDTR8_DEF
    \
    \ @brief DMA_CNDTRx register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT[15:0]: Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] DMA_DMA_CPAR8_DEF
    \
    \ @brief DMA_CPARx register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] PA[31:0]: Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a halfword address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] DMA_DMA_CMAR8_DEF
    \
    \ @brief DMA_CMARx register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] MA[31:0]: Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a halfword address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]

  \
  \ @brief DMA address block description
  \
  $00 constant DMA_DMA_ISR              \ DMA_ISR register
  $04 constant DMA_DMA_IFCR             \ DMA_IFCR register
  $08 constant DMA_DMA_CCR1             \ DMA_CCRx register
  $0C constant DMA_DMA_CNDTR1           \ DMA_CNDTRx register
  $10 constant DMA_DMA_CPAR1            \ DMA_CPARx register
  $14 constant DMA_DMA_CMAR1            \ DMA_CMARx register
  $1C constant DMA_DMA_CCR2             \ DMA_CCRx register
  $20 constant DMA_DMA_CNDTR2           \ DMA_CNDTRx register
  $24 constant DMA_DMA_CPAR2            \ DMA_CPARx register
  $28 constant DMA_DMA_CMAR2            \ DMA_CMARx register
  $30 constant DMA_DMA_CCR3             \ DMA_CCRx register
  $34 constant DMA_DMA_CNDTR3           \ DMA_CNDTRx register
  $38 constant DMA_DMA_CPAR3            \ DMA_CPARx register
  $3C constant DMA_DMA_CMAR3            \ DMA_CMARx register
  $44 constant DMA_DMA_CCR4             \ DMA_CCRx register
  $48 constant DMA_DMA_CNDTR4           \ DMA_CNDTRx register
  $4C constant DMA_DMA_CPAR4            \ DMA_CPARx register
  $50 constant DMA_DMA_CMAR4            \ DMA_CMARx register
  $58 constant DMA_DMA_CCR5             \ DMA_CCRx register
  $5C constant DMA_DMA_CNDTR5           \ DMA_CNDTRx register
  $60 constant DMA_DMA_CPAR5            \ DMA_CPARx register
  $64 constant DMA_DMA_CMAR5            \ DMA_CMARx register
  $6C constant DMA_DMA_CCR6             \ DMA_CCRx register
  $70 constant DMA_DMA_CNDTR6           \ DMA_CNDTRx register
  $74 constant DMA_DMA_CPAR6            \ DMA_CPARx register
  $78 constant DMA_DMA_CMAR6            \ DMA_CMARx register
  $80 constant DMA_DMA_CCR7             \ DMA_CCRx register
  $84 constant DMA_DMA_CNDTR7           \ DMA_CNDTRx register
  $88 constant DMA_DMA_CPAR7            \ DMA_CPARx register
  $8C constant DMA_DMA_CMAR7            \ DMA_CMARx register
  $94 constant DMA_DMA_CCR8             \ DMA_CCRx register
  $98 constant DMA_DMA_CNDTR8           \ DMA_CNDTRx register
  $9C constant DMA_DMA_CPAR8            \ DMA_CPARx register
  $A0 constant DMA_DMA_CMAR8            \ DMA_CMARx register

: DMA_DEF ; [then]
