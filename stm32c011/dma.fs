\
\ @file dma.fs
\ @brief DMA controller
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
    $00 constant DMA_GIF1                       \ [0x00] global interrupt flag for channel 1
    $01 constant DMA_TCIF1                      \ [0x01] transfer complete (TC) flag for channel 1
    $02 constant DMA_HTIF1                      \ [0x02] half transfer (HT) flag for channel 1
    $03 constant DMA_TEIF1                      \ [0x03] transfer error (TE) flag for channel 1
    $04 constant DMA_GIF2                       \ [0x04] global interrupt flag for channel 2
    $05 constant DMA_TCIF2                      \ [0x05] transfer complete (TC) flag for channel 2
    $06 constant DMA_HTIF2                      \ [0x06] half transfer (HT) flag for channel 2
    $07 constant DMA_TEIF2                      \ [0x07] transfer error (TE) flag for channel 2
    $08 constant DMA_GIF3                       \ [0x08] global interrupt flag for channel 3
    $09 constant DMA_TCIF3                      \ [0x09] transfer complete (TC) flag for channel 3
    $0a constant DMA_HTIF3                      \ [0x0a] half transfer (HT) flag for channel 3
    $0b constant DMA_TEIF3                      \ [0x0b] transfer error (TE) flag for channel 3
  [then]


  [ifdef] DMA_DMA_IFCR_DEF
    \
    \ @brief DMA interrupt flag clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMA_CGIF1                      \ [0x00] global interrupt flag clear for channel 1
    $01 constant DMA_CTCIF1                     \ [0x01] transfer complete flag clear for channel 1
    $02 constant DMA_CHTIF1                     \ [0x02] half transfer flag clear for channel 1
    $03 constant DMA_CTEIF1                     \ [0x03] transfer error flag clear for channel 1
    $04 constant DMA_CGIF2                      \ [0x04] global interrupt flag clear for channel 2
    $05 constant DMA_CTCIF2                     \ [0x05] transfer complete flag clear for channel 2
    $06 constant DMA_CHTIF2                     \ [0x06] half transfer flag clear for channel 2
    $07 constant DMA_CTEIF2                     \ [0x07] transfer error flag clear for channel 2
    $08 constant DMA_CGIF3                      \ [0x08] global interrupt flag clear for channel 3
    $09 constant DMA_CTCIF3                     \ [0x09] transfer complete flag clear for channel 3
    $0a constant DMA_CHTIF3                     \ [0x0a] half transfer flag clear for channel 3
    $0b constant DMA_CTEIF3                     \ [0x0b] transfer error flag clear for channel 3
  [then]


  [ifdef] DMA_DMA_CCR1_DEF
    \
    \ @brief DMA channel 1 configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
    $01 constant DMA_TCIE                       \ [0x01] transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $02 constant DMA_HTIE                       \ [0x02] half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $03 constant DMA_TEIE                       \ [0x03] transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $04 constant DMA_DIR                        \ [0x04] data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $05 constant DMA_CIRC                       \ [0x05] circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $06 constant DMA_PINC                       \ [0x06] peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $07 constant DMA_MINC                       \ [0x07] memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $08 constant DMA_PSIZE                      \ [0x08 : 2] peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0a constant DMA_MSIZE                      \ [0x0a : 2] memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0c constant DMA_PL                         \ [0x0c : 2] priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0e constant DMA_MEM2MEM                    \ [0x0e] memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CNDTR1_DEF
    \
    \ @brief DMA channel 1 number of data to transfer register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] number of data to transfer (0 to 216 - 1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA read followed by write transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC = 0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC = 1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CPAR1_DEF
    \
    \ @brief DMA channel 1 peripheral address register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR = 1 and the peripheral source address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CMAR1_DEF
    \
    \ @brief DMA channel 1 memory address register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR = 1 and the memory destination address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR = 1 and the peripheral destination address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CCR2_DEF
    \
    \ @brief DMA channel 2 configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
    $01 constant DMA_TCIE                       \ [0x01] transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $02 constant DMA_HTIE                       \ [0x02] half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $03 constant DMA_TEIE                       \ [0x03] transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $04 constant DMA_DIR                        \ [0x04] data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $05 constant DMA_CIRC                       \ [0x05] circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $06 constant DMA_PINC                       \ [0x06] peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $07 constant DMA_MINC                       \ [0x07] memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $08 constant DMA_PSIZE                      \ [0x08 : 2] peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0a constant DMA_MSIZE                      \ [0x0a : 2] memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0c constant DMA_PL                         \ [0x0c : 2] priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0e constant DMA_MEM2MEM                    \ [0x0e] memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CNDTR2_DEF
    \
    \ @brief DMA channel 2 number of data to transfer register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] number of data to transfer (0 to 216 - 1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA read followed by write transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC = 0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC = 1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CPAR2_DEF
    \
    \ @brief DMA channel 2 peripheral address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR = 1 and the peripheral source address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CMAR2_DEF
    \
    \ @brief DMA channel 2 memory address register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR = 1 and the memory destination address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR = 1 and the peripheral destination address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CCR3_DEF
    \
    \ @brief DMA channel 3 configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
    $01 constant DMA_TCIE                       \ [0x01] transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $02 constant DMA_HTIE                       \ [0x02] half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $03 constant DMA_TEIE                       \ [0x03] transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $04 constant DMA_DIR                        \ [0x04] data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $05 constant DMA_CIRC                       \ [0x05] circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
    $06 constant DMA_PINC                       \ [0x06] peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $07 constant DMA_MINC                       \ [0x07] memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $08 constant DMA_PSIZE                      \ [0x08 : 2] peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0a constant DMA_MSIZE                      \ [0x0a : 2] memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0c constant DMA_PL                         \ [0x0c : 2] priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
    $0e constant DMA_MEM2MEM                    \ [0x0e] memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CNDTR3_DEF
    \
    \ @brief DMA channel 3 number of data to transfer register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] number of data to transfer (0 to 216 - 1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA read followed by write transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC = 0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC = 1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CPAR3_DEF
    \
    \ @brief DMA channel 3 peripheral address register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR = 1 and the peripheral source address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]


  [ifdef] DMA_DMA_CMAR3_DEF
    \
    \ @brief DMA channel 3 memory address register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR = 1 and the memory destination address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR = 1 and the peripheral destination address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
  [then]

  \
  \ @brief DMA controller
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

: DMA_DEF ; [then]
