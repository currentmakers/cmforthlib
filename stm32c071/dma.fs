\
\ @file dma.fs
\ @brief DMA register bank
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMA_DEF

  [ifdef] DMA_DMA_ISR_DEF
    \
    \ @brief DMA interrupt status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMA_GIF1                       \ [0x00] Global interrupt flag for channel 1
    $01 constant DMA_TCIF1                      \ [0x01] Transfer complete (TC) flag for channel 1
    $02 constant DMA_HTIF1                      \ [0x02] Half transfer (HT) flag for channel 1
    $03 constant DMA_TEIF1                      \ [0x03] Transfer error (TE) flag for channel 1
    $04 constant DMA_GIF2                       \ [0x04] Global interrupt flag for channel 2
    $05 constant DMA_TCIF2                      \ [0x05] Transfer complete (TC) flag for channel 2
    $06 constant DMA_HTIF2                      \ [0x06] Half transfer (HT) flag for channel 2
    $07 constant DMA_TEIF2                      \ [0x07] Transfer error (TE) flag for channel 2
    $08 constant DMA_GIF3                       \ [0x08] Global interrupt flag for channel 3
    $09 constant DMA_TCIF3                      \ [0x09] Transfer complete (TC) flag for channel 3
    $0a constant DMA_HTIF3                      \ [0x0a] Half transfer (HT) flag for channel 3
    $0b constant DMA_TEIF3                      \ [0x0b] Transfer error (TE) flag for channel 3
    $0c constant DMA_GIF4                       \ [0x0c] global interrupt flag for channel 4
    $0d constant DMA_TCIF4                      \ [0x0d] Transfer complete (TC) flag for channel 4
    $0e constant DMA_HTIF4                      \ [0x0e] Half transfer (HT) flag for channel 4
    $0f constant DMA_TEIF4                      \ [0x0f] Transfer error (TE) flag for channel 4
    $10 constant DMA_GIF5                       \ [0x10] global interrupt flag for channel 5
    $11 constant DMA_TCIF5                      \ [0x11] Transfer complete (TC) flag for channel 5
    $12 constant DMA_HTIF5                      \ [0x12] Half transfer (HT) flag for channel 5
    $13 constant DMA_TEIF5                      \ [0x13] Transfer error (TE) flag for channel 5
  [then]


  [ifdef] DMA_DMA_IFCR_DEF
    \
    \ @brief DMA interrupt flag clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMA_CGIF1                      \ [0x00] Global interrupt flag clear for channel 1
    $01 constant DMA_CTCIF1                     \ [0x01] Transfer complete flag clear for channel 1
    $02 constant DMA_CHTIF1                     \ [0x02] Half transfer flag clear for channel 1
    $03 constant DMA_CTEIF1                     \ [0x03] Transfer error flag clear for channel 1
    $04 constant DMA_CGIF2                      \ [0x04] Global interrupt flag clear for channel 2
    $05 constant DMA_CTCIF2                     \ [0x05] Transfer complete flag clear for channel 2
    $06 constant DMA_CHTIF2                     \ [0x06] Half transfer flag clear for channel 2
    $07 constant DMA_CTEIF2                     \ [0x07] Transfer error flag clear for channel 2
    $08 constant DMA_CGIF3                      \ [0x08] Global interrupt flag clear for channel 3
    $09 constant DMA_CTCIF3                     \ [0x09] Transfer complete flag clear for channel 3
    $0a constant DMA_CHTIF3                     \ [0x0a] Half transfer flag clear for channel 3
    $0b constant DMA_CTEIF3                     \ [0x0b] Transfer error flag clear for channel 3
    $0c constant DMA_CGIF4                      \ [0x0c] Global interrupt flag clear for channel 4
    $0d constant DMA_CTCIF4                     \ [0x0d] Transfer complete flag clear for channel 4
    $0e constant DMA_CHTIF4                     \ [0x0e] Half transfer flag clear for channel 4
    $0f constant DMA_CTEIF4                     \ [0x0f] Transfer error flag clear for channel 4
    $10 constant DMA_CGIF5                      \ [0x10] Global interrupt flag clear for channel 5
    $11 constant DMA_CTCIF5                     \ [0x11] Transfer complete flag clear for channel 5
    $12 constant DMA_CHTIF5                     \ [0x12] Half transfer flag clear for channel 5
    $13 constant DMA_CTEIF5                     \ [0x13] Transfer error flag clear for channel 5
  [then]


  [ifdef] DMA_DMA_CCR1_DEF
    \
    \ @brief DMA channel 1 configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $05 constant DMA_CIRC                       \ [0x05] Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0c constant DMA_PL                         \ [0x0c : 2] Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CNDTR1_DEF
    \
    \ @brief DMA channel 1 number of data to transfer register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer (0 to 2<sup>16</sup> - 1) This bitfield is updated by hardware when the channel is enabled: It is decremented after each single DMA read followed by write transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC = 0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC = 1). If this bitfield is zero, no transfer can be served whatever the channel status (enabled or not). Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CPAR1_DEF
    \
    \ @brief DMA channel 1 peripheral address register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR = 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CMAR1_DEF
    \
    \ @brief DMA channel 1 memory address register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR = 1 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CCR2_DEF
    \
    \ @brief DMA channel 2 configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $05 constant DMA_CIRC                       \ [0x05] Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0c constant DMA_PL                         \ [0x0c : 2] Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CNDTR2_DEF
    \
    \ @brief DMA channel 2 number of data to transfer register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer (0 to 2<sup>16</sup> - 1) This bitfield is updated by hardware when the channel is enabled: It is decremented after each single DMA read followed by write transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC = 0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC = 1). If this bitfield is zero, no transfer can be served whatever the channel status (enabled or not). Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CPAR2_DEF
    \
    \ @brief DMA channel 2 peripheral address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR = 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CMAR2_DEF
    \
    \ @brief DMA channel 2 memory address register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR = 1 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CCR3_DEF
    \
    \ @brief DMA channel 3 configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $05 constant DMA_CIRC                       \ [0x05] Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0c constant DMA_PL                         \ [0x0c : 2] Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CNDTR3_DEF
    \
    \ @brief DMA channel 3 number of data to transfer register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer (0 to 2<sup>16</sup> - 1) This bitfield is updated by hardware when the channel is enabled: It is decremented after each single DMA read followed by write transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC = 0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC = 1). If this bitfield is zero, no transfer can be served whatever the channel status (enabled or not). Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CPAR3_DEF
    \
    \ @brief DMA channel 3 peripheral address register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR = 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CMAR3_DEF
    \
    \ @brief DMA channel 3 memory address register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR = 1 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CCR4_DEF
    \
    \ @brief DMA channel 4 configuration register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $05 constant DMA_CIRC                       \ [0x05] Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0c constant DMA_PL                         \ [0x0c : 2] Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CNDTR4_DEF
    \
    \ @brief DMA channel 4 number of data to transfer register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer (0 to 2<sup>16</sup> - 1) This bitfield is updated by hardware when the channel is enabled: It is decremented after each single DMA read followed by write transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC = 0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC = 1). If this bitfield is zero, no transfer can be served whatever the channel status (enabled or not). Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CPAR4_DEF
    \
    \ @brief DMA channel 4 peripheral address register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR = 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CMAR4_DEF
    \
    \ @brief DMA channel 4 memory address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR = 1 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CCR5_DEF
    \
    \ @brief DMA channel 5 configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $05 constant DMA_CIRC                       \ [0x05] Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0c constant DMA_PL                         \ [0x0c : 2] Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CNDTR5_DEF
    \
    \ @brief DMA channel 5 number of data to transfer register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer (0 to 2<sup>16</sup> - 1) This bitfield is updated by hardware when the channel is enabled: It is decremented after each single DMA read followed by write transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC = 0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC = 1). If this bitfield is zero, no transfer can be served whatever the channel status (enabled or not). Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CPAR5_DEF
    \
    \ @brief DMA channel 5 peripheral address register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR = 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CMAR5_DEF
    \
    \ @brief DMA channel 5 memory address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR = 1 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]

  \
  \ @brief DMA register bank
  \
  $00 constant DMA_DMA_ISR              \ DMA interrupt status register
  $04 constant DMA_DMA_IFCR             \ DMA interrupt flag clear register
  $08 constant DMA_DMA_CCR1             \ DMA channel 1 configuration register
  $0C constant DMA_DMA_CNDTR1           \ DMA channel 1 number of data to transfer register
  $10 constant DMA_DMA_CPAR1            \ DMA channel 1 peripheral address register
  $14 constant DMA_DMA_CMAR1            \ DMA channel 1 memory address register
  $1C constant DMA_DMA_CCR2             \ DMA channel 2 configuration register
  $20 constant DMA_DMA_CNDTR2           \ DMA channel 2 number of data to transfer register
  $24 constant DMA_DMA_CPAR2            \ DMA channel 2 peripheral address register
  $28 constant DMA_DMA_CMAR2            \ DMA channel 2 memory address register
  $30 constant DMA_DMA_CCR3             \ DMA channel 3 configuration register
  $34 constant DMA_DMA_CNDTR3           \ DMA channel 3 number of data to transfer register
  $38 constant DMA_DMA_CPAR3            \ DMA channel 3 peripheral address register
  $3C constant DMA_DMA_CMAR3            \ DMA channel 3 memory address register
  $44 constant DMA_DMA_CCR4             \ DMA channel 4 configuration register
  $48 constant DMA_DMA_CNDTR4           \ DMA channel 4 number of data to transfer register
  $4C constant DMA_DMA_CPAR4            \ DMA channel 4 peripheral address register
  $50 constant DMA_DMA_CMAR4            \ DMA channel 4 memory address register
  $58 constant DMA_DMA_CCR5             \ DMA channel 5 configuration register
  $5C constant DMA_DMA_CNDTR5           \ DMA channel 5 number of data to transfer register
  $60 constant DMA_DMA_CPAR5            \ DMA channel 5 peripheral address register
  $64 constant DMA_DMA_CMAR5            \ DMA channel 5 memory address register

: DMA_DEF ; [then]
