\
\ @file bdma.fs
\ @brief Basic direct memory access controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] BDMA_DEF

  [ifdef] BDMA_ISR_DEF
    \
    \ @brief DMA interrupt status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_GIF1                      \ [0x00] Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $01 constant BDMA_TCIF1                     \ [0x01] Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $02 constant BDMA_HTIF1                     \ [0x02] Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $03 constant BDMA_TEIF1                     \ [0x03] Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $04 constant BDMA_GIF2                      \ [0x04] Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $05 constant BDMA_TCIF2                     \ [0x05] Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $06 constant BDMA_HTIF2                     \ [0x06] Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $07 constant BDMA_TEIF2                     \ [0x07] Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $08 constant BDMA_GIF3                      \ [0x08] Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $09 constant BDMA_TCIF3                     \ [0x09] Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $0a constant BDMA_HTIF3                     \ [0x0a] Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $0b constant BDMA_TEIF3                     \ [0x0b] Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $0c constant BDMA_GIF4                      \ [0x0c] Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $0d constant BDMA_TCIF4                     \ [0x0d] Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $0e constant BDMA_HTIF4                     \ [0x0e] Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $0f constant BDMA_TEIF4                     \ [0x0f] Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $10 constant BDMA_GIF5                      \ [0x10] Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $11 constant BDMA_TCIF5                     \ [0x11] Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $12 constant BDMA_HTIF5                     \ [0x12] Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $13 constant BDMA_TEIF5                     \ [0x13] Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $14 constant BDMA_GIF6                      \ [0x14] Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $15 constant BDMA_TCIF6                     \ [0x15] Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $16 constant BDMA_HTIF6                     \ [0x16] Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $17 constant BDMA_TEIF6                     \ [0x17] Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $18 constant BDMA_GIF7                      \ [0x18] Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $19 constant BDMA_TCIF7                     \ [0x19] Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $1a constant BDMA_HTIF7                     \ [0x1a] Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $1b constant BDMA_TEIF7                     \ [0x1b] Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $1c constant BDMA_GIF8                      \ [0x1c] Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $1d constant BDMA_TCIF8                     \ [0x1d] Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $1e constant BDMA_HTIF8                     \ [0x1e] Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
    $1f constant BDMA_TEIF8                     \ [0x1f] Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
  [then]


  [ifdef] BDMA_IFCR_DEF
    \
    \ @brief DMA interrupt flag clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_CGIF1                     \ [0x00] Channel x global interrupt clear This bit is set and cleared by software.
    $01 constant BDMA_CTCIF1                    \ [0x01] Channel x transfer complete clear This bit is set and cleared by software.
    $02 constant BDMA_CHTIF1                    \ [0x02] Channel x half transfer clear This bit is set and cleared by software.
    $03 constant BDMA_CTEIF1                    \ [0x03] Channel x transfer error clear This bit is set and cleared by software.
    $04 constant BDMA_CGIF2                     \ [0x04] Channel x global interrupt clear This bit is set and cleared by software.
    $05 constant BDMA_CTCIF2                    \ [0x05] Channel x transfer complete clear This bit is set and cleared by software.
    $06 constant BDMA_CHTIF2                    \ [0x06] Channel x half transfer clear This bit is set and cleared by software.
    $07 constant BDMA_CTEIF2                    \ [0x07] Channel x transfer error clear This bit is set and cleared by software.
    $08 constant BDMA_CGIF3                     \ [0x08] Channel x global interrupt clear This bit is set and cleared by software.
    $09 constant BDMA_CTCIF3                    \ [0x09] Channel x transfer complete clear This bit is set and cleared by software.
    $0a constant BDMA_CHTIF3                    \ [0x0a] Channel x half transfer clear This bit is set and cleared by software.
    $0b constant BDMA_CTEIF3                    \ [0x0b] Channel x transfer error clear This bit is set and cleared by software.
    $0c constant BDMA_CGIF4                     \ [0x0c] Channel x global interrupt clear This bit is set and cleared by software.
    $0d constant BDMA_CTCIF4                    \ [0x0d] Channel x transfer complete clear This bit is set and cleared by software.
    $0e constant BDMA_CHTIF4                    \ [0x0e] Channel x half transfer clear This bit is set and cleared by software.
    $0f constant BDMA_CTEIF4                    \ [0x0f] Channel x transfer error clear This bit is set and cleared by software.
    $10 constant BDMA_CGIF5                     \ [0x10] Channel x global interrupt clear This bit is set and cleared by software.
    $11 constant BDMA_CTCIF5                    \ [0x11] Channel x transfer complete clear This bit is set and cleared by software.
    $12 constant BDMA_CHTIF5                    \ [0x12] Channel x half transfer clear This bit is set and cleared by software.
    $13 constant BDMA_CTEIF5                    \ [0x13] Channel x transfer error clear This bit is set and cleared by software.
    $14 constant BDMA_CGIF6                     \ [0x14] Channel x global interrupt clear This bit is set and cleared by software.
    $15 constant BDMA_CTCIF6                    \ [0x15] Channel x transfer complete clear This bit is set and cleared by software.
    $16 constant BDMA_CHTIF6                    \ [0x16] Channel x half transfer clear This bit is set and cleared by software.
    $17 constant BDMA_CTEIF6                    \ [0x17] Channel x transfer error clear This bit is set and cleared by software.
    $18 constant BDMA_CGIF7                     \ [0x18] Channel x global interrupt clear This bit is set and cleared by software.
    $19 constant BDMA_CTCIF7                    \ [0x19] Channel x transfer complete clear This bit is set and cleared by software.
    $1a constant BDMA_CHTIF7                    \ [0x1a] Channel x half transfer clear This bit is set and cleared by software.
    $1b constant BDMA_CTEIF7                    \ [0x1b] Channel x transfer error clear This bit is set and cleared by software.
    $1c constant BDMA_CGIF8                     \ [0x1c] Channel x global interrupt clear This bit is set and cleared by software.
    $1d constant BDMA_CTCIF8                    \ [0x1d] Channel x transfer complete clear This bit is set and cleared by software.
    $1e constant BDMA_CHTIF8                    \ [0x1e] Channel x half transfer clear This bit is set and cleared by software.
    $1f constant BDMA_CTEIF8                    \ [0x1f] Channel x transfer error clear This bit is set and cleared by software.
  [then]


  [ifdef] BDMA_CCR0_DEF
    \
    \ @brief DMA channel x configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_EN                        \ [0x00] Channel enable This bit is set and cleared by software.
    $01 constant BDMA_TCIE                      \ [0x01] Transfer complete interrupt enable This bit is set and cleared by software.
    $02 constant BDMA_HTIE                      \ [0x02] Half transfer interrupt enable This bit is set and cleared by software.
    $03 constant BDMA_TEIE                      \ [0x03] Transfer error interrupt enable This bit is set and cleared by software.
    $04 constant BDMA_DIR                       \ [0x04] Data transfer direction This bit is set and cleared by software.
    $05 constant BDMA_CIRC                      \ [0x05] Circular mode This bit is set and cleared by software.
    $06 constant BDMA_PINC                      \ [0x06] Peripheral increment mode This bit is set and cleared by software.
    $07 constant BDMA_MINC                      \ [0x07] Memory increment mode This bit is set and cleared by software.
    $08 constant BDMA_PSIZE                     \ [0x08 : 2] Peripheral size These bits are set and cleared by software.
    $0a constant BDMA_MSIZE                     \ [0x0a : 2] Memory size These bits are set and cleared by software.
    $0c constant BDMA_PL                        \ [0x0c : 2] Channel priority level These bits are set and cleared by software.
    $0e constant BDMA_MEM2MEM                   \ [0x0e] Memory to memory mode This bit is set and cleared by software.
  [then]


  [ifdef] BDMA_CNDTR0_DEF
    \
    \ @brief DMA channel x number of data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_NDT                       \ [0x00 : 16] Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] BDMA_CPAR0_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_PA                        \ [0x00 : 32] Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM0AR0_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_MA                        \ [0x00 : 32] Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM1AR0_DEF
    \
    \ @brief This register must not be written when the channel is enabled
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] BDMA_CCR1_DEF
    \
    \ @brief DMA channel x configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_EN                        \ [0x00] Channel enable This bit is set and cleared by software.
    $01 constant BDMA_TCIE                      \ [0x01] Transfer complete interrupt enable This bit is set and cleared by software.
    $02 constant BDMA_HTIE                      \ [0x02] Half transfer interrupt enable This bit is set and cleared by software.
    $03 constant BDMA_TEIE                      \ [0x03] Transfer error interrupt enable This bit is set and cleared by software.
    $04 constant BDMA_DIR                       \ [0x04] Data transfer direction This bit is set and cleared by software.
    $05 constant BDMA_CIRC                      \ [0x05] Circular mode This bit is set and cleared by software.
    $06 constant BDMA_PINC                      \ [0x06] Peripheral increment mode This bit is set and cleared by software.
    $07 constant BDMA_MINC                      \ [0x07] Memory increment mode This bit is set and cleared by software.
    $08 constant BDMA_PSIZE                     \ [0x08 : 2] Peripheral size These bits are set and cleared by software.
    $0a constant BDMA_MSIZE                     \ [0x0a : 2] Memory size These bits are set and cleared by software.
    $0c constant BDMA_PL                        \ [0x0c : 2] Channel priority level These bits are set and cleared by software.
    $0e constant BDMA_MEM2MEM                   \ [0x0e] Memory to memory mode This bit is set and cleared by software.
  [then]


  [ifdef] BDMA_CNDTR1_DEF
    \
    \ @brief DMA channel x number of data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_NDT                       \ [0x00 : 16] Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] BDMA_CPAR1_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_PA                        \ [0x00 : 32] Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM0AR1_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_MA                        \ [0x00 : 32] Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM1AR1_DEF
    \
    \ @brief BDMA_CMAR1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] BDMA_CCR2_DEF
    \
    \ @brief DMA channel x configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_EN                        \ [0x00] Channel enable This bit is set and cleared by software.
    $01 constant BDMA_TCIE                      \ [0x01] Transfer complete interrupt enable This bit is set and cleared by software.
    $02 constant BDMA_HTIE                      \ [0x02] Half transfer interrupt enable This bit is set and cleared by software.
    $03 constant BDMA_TEIE                      \ [0x03] Transfer error interrupt enable This bit is set and cleared by software.
    $04 constant BDMA_DIR                       \ [0x04] Data transfer direction This bit is set and cleared by software.
    $05 constant BDMA_CIRC                      \ [0x05] Circular mode This bit is set and cleared by software.
    $06 constant BDMA_PINC                      \ [0x06] Peripheral increment mode This bit is set and cleared by software.
    $07 constant BDMA_MINC                      \ [0x07] Memory increment mode This bit is set and cleared by software.
    $08 constant BDMA_PSIZE                     \ [0x08 : 2] Peripheral size These bits are set and cleared by software.
    $0a constant BDMA_MSIZE                     \ [0x0a : 2] Memory size These bits are set and cleared by software.
    $0c constant BDMA_PL                        \ [0x0c : 2] Channel priority level These bits are set and cleared by software.
    $0e constant BDMA_MEM2MEM                   \ [0x0e] Memory to memory mode This bit is set and cleared by software.
  [then]


  [ifdef] BDMA_CNDTR2_DEF
    \
    \ @brief DMA channel x number of data register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_NDT                       \ [0x00 : 16] Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] BDMA_CPAR2_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_PA                        \ [0x00 : 32] Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM0AR2_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_MA                        \ [0x00 : 32] Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM1AR2_DEF
    \
    \ @brief BDMA_CM1AR2
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] BDMA_CCR3_DEF
    \
    \ @brief DMA channel x configuration register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_EN                        \ [0x00] Channel enable This bit is set and cleared by software.
    $01 constant BDMA_TCIE                      \ [0x01] Transfer complete interrupt enable This bit is set and cleared by software.
    $02 constant BDMA_HTIE                      \ [0x02] Half transfer interrupt enable This bit is set and cleared by software.
    $03 constant BDMA_TEIE                      \ [0x03] Transfer error interrupt enable This bit is set and cleared by software.
    $04 constant BDMA_DIR                       \ [0x04] Data transfer direction This bit is set and cleared by software.
    $05 constant BDMA_CIRC                      \ [0x05] Circular mode This bit is set and cleared by software.
    $06 constant BDMA_PINC                      \ [0x06] Peripheral increment mode This bit is set and cleared by software.
    $07 constant BDMA_MINC                      \ [0x07] Memory increment mode This bit is set and cleared by software.
    $08 constant BDMA_PSIZE                     \ [0x08 : 2] Peripheral size These bits are set and cleared by software.
    $0a constant BDMA_MSIZE                     \ [0x0a : 2] Memory size These bits are set and cleared by software.
    $0c constant BDMA_PL                        \ [0x0c : 2] Channel priority level These bits are set and cleared by software.
    $0e constant BDMA_MEM2MEM                   \ [0x0e] Memory to memory mode This bit is set and cleared by software.
  [then]


  [ifdef] BDMA_CNDTR3_DEF
    \
    \ @brief DMA channel x number of data register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_NDT                       \ [0x00 : 16] Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] BDMA_CPAR3_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_PA                        \ [0x00 : 32] Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM0AR3_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_MA                        \ [0x00 : 32] Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM1AR3_DEF
    \
    \ @brief BDMA_CMAR3
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] BDMA_CCR4_DEF
    \
    \ @brief DMA channel x configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_EN                        \ [0x00] Channel enable This bit is set and cleared by software.
    $01 constant BDMA_TCIE                      \ [0x01] Transfer complete interrupt enable This bit is set and cleared by software.
    $02 constant BDMA_HTIE                      \ [0x02] Half transfer interrupt enable This bit is set and cleared by software.
    $03 constant BDMA_TEIE                      \ [0x03] Transfer error interrupt enable This bit is set and cleared by software.
    $04 constant BDMA_DIR                       \ [0x04] Data transfer direction This bit is set and cleared by software.
    $05 constant BDMA_CIRC                      \ [0x05] Circular mode This bit is set and cleared by software.
    $06 constant BDMA_PINC                      \ [0x06] Peripheral increment mode This bit is set and cleared by software.
    $07 constant BDMA_MINC                      \ [0x07] Memory increment mode This bit is set and cleared by software.
    $08 constant BDMA_PSIZE                     \ [0x08 : 2] Peripheral size These bits are set and cleared by software.
    $0a constant BDMA_MSIZE                     \ [0x0a : 2] Memory size These bits are set and cleared by software.
    $0c constant BDMA_PL                        \ [0x0c : 2] Channel priority level These bits are set and cleared by software.
    $0e constant BDMA_MEM2MEM                   \ [0x0e] Memory to memory mode This bit is set and cleared by software.
  [then]


  [ifdef] BDMA_CNDTR4_DEF
    \
    \ @brief DMA channel x number of data register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_NDT                       \ [0x00 : 16] Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] BDMA_CPAR4_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_PA                        \ [0x00 : 32] Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM0AR4_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_MA                        \ [0x00 : 32] Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM1AR4_DEF
    \
    \ @brief BDMA_CM1AR4
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] BDMA_CCR5_DEF
    \
    \ @brief DMA channel x configuration register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_EN                        \ [0x00] Channel enable This bit is set and cleared by software.
    $01 constant BDMA_TCIE                      \ [0x01] Transfer complete interrupt enable This bit is set and cleared by software.
    $02 constant BDMA_HTIE                      \ [0x02] Half transfer interrupt enable This bit is set and cleared by software.
    $03 constant BDMA_TEIE                      \ [0x03] Transfer error interrupt enable This bit is set and cleared by software.
    $04 constant BDMA_DIR                       \ [0x04] Data transfer direction This bit is set and cleared by software.
    $05 constant BDMA_CIRC                      \ [0x05] Circular mode This bit is set and cleared by software.
    $06 constant BDMA_PINC                      \ [0x06] Peripheral increment mode This bit is set and cleared by software.
    $07 constant BDMA_MINC                      \ [0x07] Memory increment mode This bit is set and cleared by software.
    $08 constant BDMA_PSIZE                     \ [0x08 : 2] Peripheral size These bits are set and cleared by software.
    $0a constant BDMA_MSIZE                     \ [0x0a : 2] Memory size These bits are set and cleared by software.
    $0c constant BDMA_PL                        \ [0x0c : 2] Channel priority level These bits are set and cleared by software.
    $0e constant BDMA_MEM2MEM                   \ [0x0e] Memory to memory mode This bit is set and cleared by software.
  [then]


  [ifdef] BDMA_CNDTR5_DEF
    \
    \ @brief DMA channel x number of data register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_NDT                       \ [0x00 : 16] Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] BDMA_CPAR5_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_PA                        \ [0x00 : 32] Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM0AR5_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_MA                        \ [0x00 : 32] Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM1AR5_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] BDMA_CCR6_DEF
    \
    \ @brief DMA channel x configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_EN                        \ [0x00] Channel enable This bit is set and cleared by software.
    $01 constant BDMA_TCIE                      \ [0x01] Transfer complete interrupt enable This bit is set and cleared by software.
    $02 constant BDMA_HTIE                      \ [0x02] Half transfer interrupt enable This bit is set and cleared by software.
    $03 constant BDMA_TEIE                      \ [0x03] Transfer error interrupt enable This bit is set and cleared by software.
    $04 constant BDMA_DIR                       \ [0x04] Data transfer direction This bit is set and cleared by software.
    $05 constant BDMA_CIRC                      \ [0x05] Circular mode This bit is set and cleared by software.
    $06 constant BDMA_PINC                      \ [0x06] Peripheral increment mode This bit is set and cleared by software.
    $07 constant BDMA_MINC                      \ [0x07] Memory increment mode This bit is set and cleared by software.
    $08 constant BDMA_PSIZE                     \ [0x08 : 2] Peripheral size These bits are set and cleared by software.
    $0a constant BDMA_MSIZE                     \ [0x0a : 2] Memory size These bits are set and cleared by software.
    $0c constant BDMA_PL                        \ [0x0c : 2] Channel priority level These bits are set and cleared by software.
    $0e constant BDMA_MEM2MEM                   \ [0x0e] Memory to memory mode This bit is set and cleared by software.
  [then]


  [ifdef] BDMA_CNDTR6_DEF
    \
    \ @brief DMA channel x number of data register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_NDT                       \ [0x00 : 16] Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] BDMA_CPAR6_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_PA                        \ [0x00 : 32] Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM0AR6_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_MA                        \ [0x00 : 32] Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM1AR6_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] BDMA_CCR7_DEF
    \
    \ @brief DMA channel x configuration register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_EN                        \ [0x00] Channel enable This bit is set and cleared by software.
    $01 constant BDMA_TCIE                      \ [0x01] Transfer complete interrupt enable This bit is set and cleared by software.
    $02 constant BDMA_HTIE                      \ [0x02] Half transfer interrupt enable This bit is set and cleared by software.
    $03 constant BDMA_TEIE                      \ [0x03] Transfer error interrupt enable This bit is set and cleared by software.
    $04 constant BDMA_DIR                       \ [0x04] Data transfer direction This bit is set and cleared by software.
    $05 constant BDMA_CIRC                      \ [0x05] Circular mode This bit is set and cleared by software.
    $06 constant BDMA_PINC                      \ [0x06] Peripheral increment mode This bit is set and cleared by software.
    $07 constant BDMA_MINC                      \ [0x07] Memory increment mode This bit is set and cleared by software.
    $08 constant BDMA_PSIZE                     \ [0x08 : 2] Peripheral size These bits are set and cleared by software.
    $0a constant BDMA_MSIZE                     \ [0x0a : 2] Memory size These bits are set and cleared by software.
    $0c constant BDMA_PL                        \ [0x0c : 2] Channel priority level These bits are set and cleared by software.
    $0e constant BDMA_MEM2MEM                   \ [0x0e] Memory to memory mode This bit is set and cleared by software.
  [then]


  [ifdef] BDMA_CNDTR7_DEF
    \
    \ @brief DMA channel x number of data register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_NDT                       \ [0x00 : 16] Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.
  [then]


  [ifdef] BDMA_CPAR7_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_PA                        \ [0x00 : 32] Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM0AR7_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant BDMA_MA                        \ [0x00 : 32] Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.
  [then]


  [ifdef] BDMA_CM1AR7_DEF
    \
    \ @brief This register must not be written when the channel is enabled.
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
  [then]

  \
  \ @brief Basic direct memory access controller
  \
  $00 constant BDMA_ISR                 \ DMA interrupt status register
  $04 constant BDMA_IFCR                \ DMA interrupt flag clear register
  $08 constant BDMA_CCR0                \ DMA channel x configuration register
  $0C constant BDMA_CNDTR0              \ DMA channel x number of data register
  $10 constant BDMA_CPAR0               \ This register must not be written when the channel is enabled.
  $14 constant BDMA_CM0AR0              \ This register must not be written when the channel is enabled.
  $18 constant BDMA_CM1AR0              \ This register must not be written when the channel is enabled
  $1C constant BDMA_CCR1                \ DMA channel x configuration register
  $20 constant BDMA_CNDTR1              \ DMA channel x number of data register
  $24 constant BDMA_CPAR1               \ This register must not be written when the channel is enabled.
  $28 constant BDMA_CM0AR1              \ This register must not be written when the channel is enabled.
  $2C constant BDMA_CM1AR1              \ BDMA_CMAR1
  $30 constant BDMA_CCR2                \ DMA channel x configuration register
  $34 constant BDMA_CNDTR2              \ DMA channel x number of data register
  $38 constant BDMA_CPAR2               \ This register must not be written when the channel is enabled.
  $3C constant BDMA_CM0AR2              \ This register must not be written when the channel is enabled.
  $40 constant BDMA_CM1AR2              \ BDMA_CM1AR2
  $44 constant BDMA_CCR3                \ DMA channel x configuration register
  $48 constant BDMA_CNDTR3              \ DMA channel x number of data register
  $4C constant BDMA_CPAR3               \ This register must not be written when the channel is enabled.
  $50 constant BDMA_CM0AR3              \ This register must not be written when the channel is enabled.
  $54 constant BDMA_CM1AR3              \ BDMA_CMAR3
  $58 constant BDMA_CCR4                \ DMA channel x configuration register
  $5C constant BDMA_CNDTR4              \ DMA channel x number of data register
  $60 constant BDMA_CPAR4               \ This register must not be written when the channel is enabled.
  $64 constant BDMA_CM0AR4              \ This register must not be written when the channel is enabled.
  $68 constant BDMA_CM1AR4              \ BDMA_CM1AR4
  $6C constant BDMA_CCR5                \ DMA channel x configuration register
  $70 constant BDMA_CNDTR5              \ DMA channel x number of data register
  $74 constant BDMA_CPAR5               \ This register must not be written when the channel is enabled.
  $78 constant BDMA_CM0AR5              \ This register must not be written when the channel is enabled.
  $7C constant BDMA_CM1AR5              \ This register must not be written when the channel is enabled.
  $80 constant BDMA_CCR6                \ DMA channel x configuration register
  $84 constant BDMA_CNDTR6              \ DMA channel x number of data register
  $88 constant BDMA_CPAR6               \ This register must not be written when the channel is enabled.
  $8C constant BDMA_CM0AR6              \ This register must not be written when the channel is enabled.
  $90 constant BDMA_CM1AR6              \ This register must not be written when the channel is enabled.
  $94 constant BDMA_CCR7                \ DMA channel x configuration register
  $98 constant BDMA_CNDTR7              \ DMA channel x number of data register
  $9C constant BDMA_CPAR7               \ This register must not be written when the channel is enabled.
  $A0 constant BDMA_CM0AR7              \ This register must not be written when the channel is enabled.
  $A4 constant BDMA_CM1AR7              \ This register must not be written when the channel is enabled.

: BDMA_DEF ; [then]
