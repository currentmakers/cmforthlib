\
\ @file dma.fs
\ @brief DMA1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMA_DEF

  [ifdef] DMA_DMA_LISR_DEF
    \
    \ @brief DMA low interrupt status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMA_FEIF0                      \ [0x00] stream x FIFO error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $02 constant DMA_DMEIF0                     \ [0x02] stream x direct mode error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $03 constant DMA_TEIF0                      \ [0x03] stream x transfer error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $04 constant DMA_HTIF0                      \ [0x04] stream x half transfer interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $05 constant DMA_TCIF0                      \ [0x05] stream x transfer complete interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $06 constant DMA_FEIF1                      \ [0x06] stream x FIFO error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $08 constant DMA_DMEIF1                     \ [0x08] stream x direct mode error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $09 constant DMA_TEIF1                      \ [0x09] stream x transfer error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $0a constant DMA_HTIF1                      \ [0x0a] stream x half transfer interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $0b constant DMA_TCIF1                      \ [0x0b] stream x transfer complete interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $10 constant DMA_FEIF2                      \ [0x10] stream x FIFO error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $12 constant DMA_DMEIF2                     \ [0x12] stream x direct mode error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $13 constant DMA_TEIF2                      \ [0x13] stream x transfer error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $14 constant DMA_HTIF2                      \ [0x14] stream x half transfer interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $15 constant DMA_TCIF2                      \ [0x15] stream x transfer complete interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $16 constant DMA_FEIF3                      \ [0x16] stream x FIFO error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $18 constant DMA_DMEIF3                     \ [0x18] stream x direct mode error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $19 constant DMA_TEIF3                      \ [0x19] stream x transfer error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $1a constant DMA_HTIF3                      \ [0x1a] stream x half transfer interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
    $1b constant DMA_TCIF3                      \ [0x1b] stream x transfer complete interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
  [then]


  [ifdef] DMA_DMA_HISR_DEF
    \
    \ @brief DMA high interrupt status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMA_FEIF4                      \ [0x00] stream x FIFO error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $02 constant DMA_DMEIF4                     \ [0x02] stream x direct mode error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $03 constant DMA_TEIF4                      \ [0x03] stream x transfer error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $04 constant DMA_HTIF4                      \ [0x04] stream x half transfer interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $05 constant DMA_TCIF4                      \ [0x05] stream x transfer complete interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $06 constant DMA_FEIF5                      \ [0x06] stream x FIFO error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $08 constant DMA_DMEIF5                     \ [0x08] stream x direct mode error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $09 constant DMA_TEIF5                      \ [0x09] stream x transfer error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $0a constant DMA_HTIF5                      \ [0x0a] stream x half transfer interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $0b constant DMA_TCIF5                      \ [0x0b] stream x transfer complete interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $10 constant DMA_FEIF6                      \ [0x10] stream x FIFO error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $12 constant DMA_DMEIF6                     \ [0x12] stream x direct mode error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $13 constant DMA_TEIF6                      \ [0x13] stream x transfer error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $14 constant DMA_HTIF6                      \ [0x14] stream x half transfer interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $15 constant DMA_TCIF6                      \ [0x15] stream x transfer complete interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $16 constant DMA_FEIF7                      \ [0x16] stream x FIFO error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $18 constant DMA_DMEIF7                     \ [0x18] stream x direct mode error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $19 constant DMA_TEIF7                      \ [0x19] stream x transfer error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $1a constant DMA_HTIF7                      \ [0x1a] stream x half transfer interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
    $1b constant DMA_TCIF7                      \ [0x1b] stream x transfer complete interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
  [then]


  [ifdef] DMA_DMA_LIFCR_DEF
    \
    \ @brief DMA low interrupt flag clear register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA_CFEIF0                     \ [0x00] stream x clear FIFO error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_LISR register.
    $02 constant DMA_CDMEIF0                    \ [0x02] stream x clear direct mode error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_LISR register.
    $03 constant DMA_CTEIF0                     \ [0x03] Stream x clear transfer error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_LISR register.
    $04 constant DMA_CHTIF0                     \ [0x04] stream x clear half transfer interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_LISR register
    $05 constant DMA_CTCIF0                     \ [0x05] stream x clear transfer complete interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_LISR register.
    $06 constant DMA_CFEIF1                     \ [0x06] stream x clear FIFO error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_LISR register.
    $08 constant DMA_CDMEIF1                    \ [0x08] stream x clear direct mode error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_LISR register.
    $09 constant DMA_CTEIF1                     \ [0x09] Stream x clear transfer error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_LISR register.
    $0a constant DMA_CHTIF1                     \ [0x0a] stream x clear half transfer interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_LISR register
    $0b constant DMA_CTCIF1                     \ [0x0b] stream x clear transfer complete interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_LISR register.
    $10 constant DMA_CFEIF2                     \ [0x10] stream x clear FIFO error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_LISR register.
    $12 constant DMA_CDMEIF2                    \ [0x12] stream x clear direct mode error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_LISR register.
    $13 constant DMA_CTEIF2                     \ [0x13] Stream x clear transfer error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_LISR register.
    $14 constant DMA_CHTIF2                     \ [0x14] stream x clear half transfer interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_LISR register
    $15 constant DMA_CTCIF2                     \ [0x15] stream x clear transfer complete interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_LISR register.
    $16 constant DMA_CFEIF3                     \ [0x16] stream x clear FIFO error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_LISR register.
    $18 constant DMA_CDMEIF3                    \ [0x18] stream x clear direct mode error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_LISR register.
    $19 constant DMA_CTEIF3                     \ [0x19] Stream x clear transfer error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_LISR register.
    $1a constant DMA_CHTIF3                     \ [0x1a] stream x clear half transfer interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_LISR register
    $1b constant DMA_CTCIF3                     \ [0x1b] stream x clear transfer complete interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_LISR register.
  [then]


  [ifdef] DMA_DMA_HIFCR_DEF
    \
    \ @brief DMA high interrupt flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_CFEIF4                     \ [0x00] stream x clear FIFO error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_HISR register.
    $02 constant DMA_CDMEIF4                    \ [0x02] stream x clear direct mode error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_HISR register.
    $03 constant DMA_CTEIF4                     \ [0x03] stream x clear transfer error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_HISR register.
    $04 constant DMA_CHTIF4                     \ [0x04] stream x clear half transfer interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_HISR register.
    $05 constant DMA_CTCIF4                     \ [0x05] stream x clear transfer complete interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_HISR register.
    $06 constant DMA_CFEIF5                     \ [0x06] stream x clear FIFO error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_HISR register.
    $08 constant DMA_CDMEIF5                    \ [0x08] stream x clear direct mode error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_HISR register.
    $09 constant DMA_CTEIF5                     \ [0x09] stream x clear transfer error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_HISR register.
    $0a constant DMA_CHTIF5                     \ [0x0a] stream x clear half transfer interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_HISR register.
    $0b constant DMA_CTCIF5                     \ [0x0b] stream x clear transfer complete interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_HISR register.
    $10 constant DMA_CFEIF6                     \ [0x10] stream x clear FIFO error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_HISR register.
    $12 constant DMA_CDMEIF6                    \ [0x12] stream x clear direct mode error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_HISR register.
    $13 constant DMA_CTEIF6                     \ [0x13] stream x clear transfer error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_HISR register.
    $14 constant DMA_CHTIF6                     \ [0x14] stream x clear half transfer interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_HISR register.
    $15 constant DMA_CTCIF6                     \ [0x15] stream x clear transfer complete interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_HISR register.
    $16 constant DMA_CFEIF7                     \ [0x16] stream x clear FIFO error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_HISR register.
    $18 constant DMA_CDMEIF7                    \ [0x18] stream x clear direct mode error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_HISR register.
    $19 constant DMA_CTEIF7                     \ [0x19] stream x clear transfer error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_HISR register.
    $1a constant DMA_CHTIF7                     \ [0x1a] stream x clear half transfer interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_HISR register.
    $1b constant DMA_CTCIF7                     \ [0x1b] stream x clear transfer complete interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_HISR register.
  [then]


  [ifdef] DMA_DMA_S0CR_DEF
    \
    \ @brief DMA stream 0 configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
    $01 constant DMA_DMEIE                      \ [0x01] direct mode error interrupt enable This bit is set and cleared by software.
    $02 constant DMA_TEIE                       \ [0x02] transfer error interrupt enable This bit is set and cleared by software.
    $03 constant DMA_HTIE                       \ [0x03] half transfer interrupt enable This bit is set and cleared by software.
    $04 constant DMA_TCIE                       \ [0x04] transfer complete interrupt enable This bit is set and cleared by software.
    $05 constant DMA_PFCTRL                     \ [0x05] peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
    $06 constant DMA_DIR                        \ [0x06 : 2] data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $08 constant DMA_CIRC                       \ [0x08] circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
    $09 constant DMA_PINC                       \ [0x09] peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0a constant DMA_MINC                       \ [0x0a] memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0b constant DMA_PSIZE                      \ [0x0b : 2] peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $0d constant DMA_MSIZE                      \ [0x0d : 2] memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
    $0f constant DMA_PINCOS                     \ [0x0f] peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
    $10 constant DMA_PL                         \ [0x10 : 2] priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $12 constant DMA_DBM                        \ [0x12] double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $13 constant DMA_CT                         \ [0x13] current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
    $14 constant DMA_TRBUFF                     \ [0x14] Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
    $15 constant DMA_PBURST                     \ [0x15 : 2] peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
    $17 constant DMA_MBURST                     \ [0x17 : 2] memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.
  [then]


  [ifdef] DMA_DMA_S0NDTR_DEF
    \
    \ @brief DMA stream 0 number of data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.
  [then]


  [ifdef] DMA_DMA_S0PAR_DEF
    \
    \ @brief DMA stream 0 peripheral address register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.
  [then]


  [ifdef] DMA_DMA_S0M0AR_DEF
    \
    \ @brief DMA stream 0 memory 0 address register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).
  [then]


  [ifdef] DMA_DMA_S0M1AR_DEF
    \
    \ @brief DMA stream 0 memory 1 address register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .
  [then]


  [ifdef] DMA_DMA_S0FCR_DEF
    \
    \ @brief DMA stream 0 FIFO control register
    \ Address offset: 0x24
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
    $02 constant DMA_DMDIS                      \ [0x02] direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] DMA_DMA_S1CR_DEF
    \
    \ @brief DMA stream 1 configuration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
    $01 constant DMA_DMEIE                      \ [0x01] direct mode error interrupt enable This bit is set and cleared by software.
    $02 constant DMA_TEIE                       \ [0x02] transfer error interrupt enable This bit is set and cleared by software.
    $03 constant DMA_HTIE                       \ [0x03] half transfer interrupt enable This bit is set and cleared by software.
    $04 constant DMA_TCIE                       \ [0x04] transfer complete interrupt enable This bit is set and cleared by software.
    $05 constant DMA_PFCTRL                     \ [0x05] peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
    $06 constant DMA_DIR                        \ [0x06 : 2] data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $08 constant DMA_CIRC                       \ [0x08] circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
    $09 constant DMA_PINC                       \ [0x09] peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0a constant DMA_MINC                       \ [0x0a] memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0b constant DMA_PSIZE                      \ [0x0b : 2] peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $0d constant DMA_MSIZE                      \ [0x0d : 2] memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
    $0f constant DMA_PINCOS                     \ [0x0f] peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
    $10 constant DMA_PL                         \ [0x10 : 2] priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $12 constant DMA_DBM                        \ [0x12] double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $13 constant DMA_CT                         \ [0x13] current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
    $14 constant DMA_TRBUFF                     \ [0x14] Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
    $15 constant DMA_PBURST                     \ [0x15 : 2] peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
    $17 constant DMA_MBURST                     \ [0x17 : 2] memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.
  [then]


  [ifdef] DMA_DMA_S1NDTR_DEF
    \
    \ @brief DMA stream 1 number of data register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.
  [then]


  [ifdef] DMA_DMA_S1PAR_DEF
    \
    \ @brief DMA stream 1 peripheral address register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.
  [then]


  [ifdef] DMA_DMA_S1M0AR_DEF
    \
    \ @brief DMA stream 1 memory 0 address register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).
  [then]


  [ifdef] DMA_DMA_S1M1AR_DEF
    \
    \ @brief DMA stream 1 memory 1 address register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .
  [then]


  [ifdef] DMA_DMA_S1FCR_DEF
    \
    \ @brief DMA stream 1 FIFO control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
    $02 constant DMA_DMDIS                      \ [0x02] direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] DMA_DMA_S2CR_DEF
    \
    \ @brief DMA stream 2 configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
    $01 constant DMA_DMEIE                      \ [0x01] direct mode error interrupt enable This bit is set and cleared by software.
    $02 constant DMA_TEIE                       \ [0x02] transfer error interrupt enable This bit is set and cleared by software.
    $03 constant DMA_HTIE                       \ [0x03] half transfer interrupt enable This bit is set and cleared by software.
    $04 constant DMA_TCIE                       \ [0x04] transfer complete interrupt enable This bit is set and cleared by software.
    $05 constant DMA_PFCTRL                     \ [0x05] peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
    $06 constant DMA_DIR                        \ [0x06 : 2] data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $08 constant DMA_CIRC                       \ [0x08] circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
    $09 constant DMA_PINC                       \ [0x09] peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0a constant DMA_MINC                       \ [0x0a] memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0b constant DMA_PSIZE                      \ [0x0b : 2] peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $0d constant DMA_MSIZE                      \ [0x0d : 2] memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
    $0f constant DMA_PINCOS                     \ [0x0f] peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
    $10 constant DMA_PL                         \ [0x10 : 2] priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $12 constant DMA_DBM                        \ [0x12] double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $13 constant DMA_CT                         \ [0x13] current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
    $14 constant DMA_TRBUFF                     \ [0x14] Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
    $15 constant DMA_PBURST                     \ [0x15 : 2] peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
    $17 constant DMA_MBURST                     \ [0x17 : 2] memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.
  [then]


  [ifdef] DMA_DMA_S2NDTR_DEF
    \
    \ @brief DMA stream 2 number of data register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.
  [then]


  [ifdef] DMA_DMA_S2PAR_DEF
    \
    \ @brief DMA stream 2 peripheral address register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.
  [then]


  [ifdef] DMA_DMA_S2M0AR_DEF
    \
    \ @brief DMA stream 2 memory 0 address register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).
  [then]


  [ifdef] DMA_DMA_S2M1AR_DEF
    \
    \ @brief DMA stream 2 memory 1 address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .
  [then]


  [ifdef] DMA_DMA_S2FCR_DEF
    \
    \ @brief DMA stream 2 FIFO control register
    \ Address offset: 0x54
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
    $02 constant DMA_DMDIS                      \ [0x02] direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] DMA_DMA_S3CR_DEF
    \
    \ @brief DMA stream 3 configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
    $01 constant DMA_DMEIE                      \ [0x01] direct mode error interrupt enable This bit is set and cleared by software.
    $02 constant DMA_TEIE                       \ [0x02] transfer error interrupt enable This bit is set and cleared by software.
    $03 constant DMA_HTIE                       \ [0x03] half transfer interrupt enable This bit is set and cleared by software.
    $04 constant DMA_TCIE                       \ [0x04] transfer complete interrupt enable This bit is set and cleared by software.
    $05 constant DMA_PFCTRL                     \ [0x05] peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
    $06 constant DMA_DIR                        \ [0x06 : 2] data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $08 constant DMA_CIRC                       \ [0x08] circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
    $09 constant DMA_PINC                       \ [0x09] peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0a constant DMA_MINC                       \ [0x0a] memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0b constant DMA_PSIZE                      \ [0x0b : 2] peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $0d constant DMA_MSIZE                      \ [0x0d : 2] memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
    $0f constant DMA_PINCOS                     \ [0x0f] peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
    $10 constant DMA_PL                         \ [0x10 : 2] priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $12 constant DMA_DBM                        \ [0x12] double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $13 constant DMA_CT                         \ [0x13] current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
    $14 constant DMA_TRBUFF                     \ [0x14] Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
    $15 constant DMA_PBURST                     \ [0x15 : 2] peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
    $17 constant DMA_MBURST                     \ [0x17 : 2] memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.
  [then]


  [ifdef] DMA_DMA_S3NDTR_DEF
    \
    \ @brief DMA stream 3 number of data register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.
  [then]


  [ifdef] DMA_DMA_S3PAR_DEF
    \
    \ @brief DMA stream 3 peripheral address register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.
  [then]


  [ifdef] DMA_DMA_S3M0AR_DEF
    \
    \ @brief DMA stream 3 memory 0 address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).
  [then]


  [ifdef] DMA_DMA_S3M1AR_DEF
    \
    \ @brief DMA stream 3 memory 1 address register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .
  [then]


  [ifdef] DMA_DMA_S3FCR_DEF
    \
    \ @brief DMA stream 3 FIFO control register
    \ Address offset: 0x6C
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
    $02 constant DMA_DMDIS                      \ [0x02] direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] DMA_DMA_S4CR_DEF
    \
    \ @brief DMA stream 4 configuration register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
    $01 constant DMA_DMEIE                      \ [0x01] direct mode error interrupt enable This bit is set and cleared by software.
    $02 constant DMA_TEIE                       \ [0x02] transfer error interrupt enable This bit is set and cleared by software.
    $03 constant DMA_HTIE                       \ [0x03] half transfer interrupt enable This bit is set and cleared by software.
    $04 constant DMA_TCIE                       \ [0x04] transfer complete interrupt enable This bit is set and cleared by software.
    $05 constant DMA_PFCTRL                     \ [0x05] peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
    $06 constant DMA_DIR                        \ [0x06 : 2] data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $08 constant DMA_CIRC                       \ [0x08] circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
    $09 constant DMA_PINC                       \ [0x09] peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0a constant DMA_MINC                       \ [0x0a] memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0b constant DMA_PSIZE                      \ [0x0b : 2] peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $0d constant DMA_MSIZE                      \ [0x0d : 2] memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
    $0f constant DMA_PINCOS                     \ [0x0f] peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
    $10 constant DMA_PL                         \ [0x10 : 2] priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $12 constant DMA_DBM                        \ [0x12] double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $13 constant DMA_CT                         \ [0x13] current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
    $14 constant DMA_TRBUFF                     \ [0x14] Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
    $15 constant DMA_PBURST                     \ [0x15 : 2] peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
    $17 constant DMA_MBURST                     \ [0x17 : 2] memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.
  [then]


  [ifdef] DMA_DMA_S4NDTR_DEF
    \
    \ @brief DMA stream 4 number of data register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.
  [then]


  [ifdef] DMA_DMA_S4PAR_DEF
    \
    \ @brief DMA stream 4 peripheral address register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.
  [then]


  [ifdef] DMA_DMA_S4M0AR_DEF
    \
    \ @brief DMA stream 4 memory 0 address register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).
  [then]


  [ifdef] DMA_DMA_S4M1AR_DEF
    \
    \ @brief DMA stream 4 memory 1 address register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .
  [then]


  [ifdef] DMA_DMA_S4FCR_DEF
    \
    \ @brief DMA stream 4 FIFO control register
    \ Address offset: 0x84
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
    $02 constant DMA_DMDIS                      \ [0x02] direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] DMA_DMA_S5CR_DEF
    \
    \ @brief DMA stream 5 configuration register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
    $01 constant DMA_DMEIE                      \ [0x01] direct mode error interrupt enable This bit is set and cleared by software.
    $02 constant DMA_TEIE                       \ [0x02] transfer error interrupt enable This bit is set and cleared by software.
    $03 constant DMA_HTIE                       \ [0x03] half transfer interrupt enable This bit is set and cleared by software.
    $04 constant DMA_TCIE                       \ [0x04] transfer complete interrupt enable This bit is set and cleared by software.
    $05 constant DMA_PFCTRL                     \ [0x05] peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
    $06 constant DMA_DIR                        \ [0x06 : 2] data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $08 constant DMA_CIRC                       \ [0x08] circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
    $09 constant DMA_PINC                       \ [0x09] peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0a constant DMA_MINC                       \ [0x0a] memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0b constant DMA_PSIZE                      \ [0x0b : 2] peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $0d constant DMA_MSIZE                      \ [0x0d : 2] memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
    $0f constant DMA_PINCOS                     \ [0x0f] peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
    $10 constant DMA_PL                         \ [0x10 : 2] priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $12 constant DMA_DBM                        \ [0x12] double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $13 constant DMA_CT                         \ [0x13] current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
    $14 constant DMA_TRBUFF                     \ [0x14] Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
    $15 constant DMA_PBURST                     \ [0x15 : 2] peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
    $17 constant DMA_MBURST                     \ [0x17 : 2] memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.
  [then]


  [ifdef] DMA_DMA_S5NDTR_DEF
    \
    \ @brief DMA stream 5 number of data register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.
  [then]


  [ifdef] DMA_DMA_S5PAR_DEF
    \
    \ @brief DMA stream 5 peripheral address register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.
  [then]


  [ifdef] DMA_DMA_S5M0AR_DEF
    \
    \ @brief DMA stream 5 memory 0 address register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).
  [then]


  [ifdef] DMA_DMA_S5M1AR_DEF
    \
    \ @brief DMA stream 5 memory 1 address register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .
  [then]


  [ifdef] DMA_DMA_S5FCR_DEF
    \
    \ @brief DMA stream 5 FIFO control register
    \ Address offset: 0x9C
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
    $02 constant DMA_DMDIS                      \ [0x02] direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] DMA_DMA_S6CR_DEF
    \
    \ @brief DMA stream 6 configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
    $01 constant DMA_DMEIE                      \ [0x01] direct mode error interrupt enable This bit is set and cleared by software.
    $02 constant DMA_TEIE                       \ [0x02] transfer error interrupt enable This bit is set and cleared by software.
    $03 constant DMA_HTIE                       \ [0x03] half transfer interrupt enable This bit is set and cleared by software.
    $04 constant DMA_TCIE                       \ [0x04] transfer complete interrupt enable This bit is set and cleared by software.
    $05 constant DMA_PFCTRL                     \ [0x05] peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
    $06 constant DMA_DIR                        \ [0x06 : 2] data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $08 constant DMA_CIRC                       \ [0x08] circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
    $09 constant DMA_PINC                       \ [0x09] peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0a constant DMA_MINC                       \ [0x0a] memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0b constant DMA_PSIZE                      \ [0x0b : 2] peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $0d constant DMA_MSIZE                      \ [0x0d : 2] memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
    $0f constant DMA_PINCOS                     \ [0x0f] peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
    $10 constant DMA_PL                         \ [0x10 : 2] priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $12 constant DMA_DBM                        \ [0x12] double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $13 constant DMA_CT                         \ [0x13] current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
    $14 constant DMA_TRBUFF                     \ [0x14] Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
    $15 constant DMA_PBURST                     \ [0x15 : 2] peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
    $17 constant DMA_MBURST                     \ [0x17 : 2] memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.
  [then]


  [ifdef] DMA_DMA_S6NDTR_DEF
    \
    \ @brief DMA stream 6 number of data register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.
  [then]


  [ifdef] DMA_DMA_S6PAR_DEF
    \
    \ @brief DMA stream 6 peripheral address register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.
  [then]


  [ifdef] DMA_DMA_S6M0AR_DEF
    \
    \ @brief DMA stream 6 memory 0 address register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).
  [then]


  [ifdef] DMA_DMA_S6M1AR_DEF
    \
    \ @brief DMA stream 6 memory 1 address register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .
  [then]


  [ifdef] DMA_DMA_S6FCR_DEF
    \
    \ @brief DMA stream 6 FIFO control register
    \ Address offset: 0xB4
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
    $02 constant DMA_DMDIS                      \ [0x02] direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] DMA_DMA_S7CR_DEF
    \
    \ @brief DMA stream 7 configuration register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
    $01 constant DMA_DMEIE                      \ [0x01] direct mode error interrupt enable This bit is set and cleared by software.
    $02 constant DMA_TEIE                       \ [0x02] transfer error interrupt enable This bit is set and cleared by software.
    $03 constant DMA_HTIE                       \ [0x03] half transfer interrupt enable This bit is set and cleared by software.
    $04 constant DMA_TCIE                       \ [0x04] transfer complete interrupt enable This bit is set and cleared by software.
    $05 constant DMA_PFCTRL                     \ [0x05] peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
    $06 constant DMA_DIR                        \ [0x06 : 2] data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $08 constant DMA_CIRC                       \ [0x08] circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
    $09 constant DMA_PINC                       \ [0x09] peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0a constant DMA_MINC                       \ [0x0a] memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $0b constant DMA_PSIZE                      \ [0x0b : 2] peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $0d constant DMA_MSIZE                      \ [0x0d : 2] memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
    $0f constant DMA_PINCOS                     \ [0x0f] peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
    $10 constant DMA_PL                         \ [0x10 : 2] priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
    $12 constant DMA_DBM                        \ [0x12] double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
    $13 constant DMA_CT                         \ [0x13] current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
    $14 constant DMA_TRBUFF                     \ [0x14] Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
    $15 constant DMA_PBURST                     \ [0x15 : 2] peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
    $17 constant DMA_MBURST                     \ [0x17 : 2] memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.
  [then]


  [ifdef] DMA_DMA_S7NDTR_DEF
    \
    \ @brief DMA stream 7 number of data register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.
  [then]


  [ifdef] DMA_DMA_S7PAR_DEF
    \
    \ @brief DMA stream 7 peripheral address register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.
  [then]


  [ifdef] DMA_DMA_S7M0AR_DEF
    \
    \ @brief DMA stream 7 memory 0 address register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).
  [then]


  [ifdef] DMA_DMA_S7M1AR_DEF
    \
    \ @brief DMA stream 7 memory 1 address register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .
  [then]


  [ifdef] DMA_DMA_S7FCR_DEF
    \
    \ @brief DMA stream 7 FIFO control register
    \ Address offset: 0xCC
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
    $02 constant DMA_DMDIS                      \ [0x02] direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] DMA_DMA_HWCFGR2_DEF
    \
    \ @brief DMA hardware configuration 2 register
    \ Address offset: 0x3EC
    \ Reset value: 0x00000001
    \
    $00 constant DMA_FIFO_SIZE                  \ [0x00 : 2] FIFO size, common to all streams In [0..3] range: 2: 8-word FIFO 3: 16-word FIFO
    $04 constant DMA_WRITE_BUFFERABLE           \ [0x04] In any case, DMA acknowledge signal is asserted one cycle after the address phase of the bus access on its AHB peripheral master port.
    $08 constant DMA_CHSEL_WIDTH                \ [0x08 : 3] bit width of the CHSEL field of any DMA_SxCR register common to all streams In [0..6] range: 2: up to 8 channels programmable selection 3: up to 16 channels programmable selection 4: up to 32 channels programmable selection 5: up to 64 channels programmable selection 6: up to 128 channels programmable selection
  [then]


  [ifdef] DMA_DMA_HWCFGR1_DEF
    \
    \ @brief DMA hardware configuration 1 register
    \ Address offset: 0x3F0
    \ Reset value: 0x22222222
    \
    $00 constant DMA_DMA_DEF0                   \ [0x00 : 2] type of the stream 0 2: double-buffer 3: Reserved
    $04 constant DMA_DMA_DEF1                   \ [0x04 : 2] type of the stream 1 2: double-buffer 3: Reserved
    $08 constant DMA_DMA_DEF2                   \ [0x08 : 2] type of the stream 2 2: double-buffer 3: Reserved
    $0c constant DMA_DMA_DEF3                   \ [0x0c : 2] type of the stream 3 2: double-buffer 3: Reserved
    $10 constant DMA_DMA_DEF4                   \ [0x10 : 2] type of the stream 4 2: double-buffer 3: Reserved
    $14 constant DMA_DMA_DEF5                   \ [0x14 : 2] type of the stream 5 2: double-buffer 3: Reserved
    $18 constant DMA_DMA_DEF6                   \ [0x18 : 2] type of the stream 6 2: double-buffer 3: Reserved
    $1c constant DMA_DMA_DEF7                   \ [0x1c : 2] type of the stream 7 2: double-buffer 3: Reserved
  [then]


  [ifdef] DMA_DMA_VERR_DEF
    \
    \ @brief DMA version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000014
    \
    $00 constant DMA_MINREV                     \ [0x00 : 4] minor IP revision
    $04 constant DMA_MAJREV                     \ [0x04 : 4] major IP revision
  [then]


  [ifdef] DMA_DMA_IPDR_DEF
    \
    \ @brief DMA identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00100002
    \
    $00 constant DMA_ID                         \ [0x00 : 32] size identification This register identifies the peripheral.
  [then]


  [ifdef] DMA_DMA_SIDR_DEF
    \
    \ @brief DMA size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant DMA_SID                        \ [0x00 : 32] size identification This register identifies the DMA as a peripheal with a size of 1 Kbyte address space.
  [then]

  \
  \ @brief DMA1
  \
  $00 constant DMA_DMA_LISR             \ DMA low interrupt status register
  $04 constant DMA_DMA_HISR             \ DMA high interrupt status register
  $08 constant DMA_DMA_LIFCR            \ DMA low interrupt flag clear register
  $0C constant DMA_DMA_HIFCR            \ DMA high interrupt flag clear register
  $10 constant DMA_DMA_S0CR             \ DMA stream 0 configuration register
  $14 constant DMA_DMA_S0NDTR           \ DMA stream 0 number of data register
  $18 constant DMA_DMA_S0PAR            \ DMA stream 0 peripheral address register
  $1C constant DMA_DMA_S0M0AR           \ DMA stream 0 memory 0 address register
  $20 constant DMA_DMA_S0M1AR           \ DMA stream 0 memory 1 address register
  $24 constant DMA_DMA_S0FCR            \ DMA stream 0 FIFO control register
  $28 constant DMA_DMA_S1CR             \ DMA stream 1 configuration register
  $2C constant DMA_DMA_S1NDTR           \ DMA stream 1 number of data register
  $30 constant DMA_DMA_S1PAR            \ DMA stream 1 peripheral address register
  $34 constant DMA_DMA_S1M0AR           \ DMA stream 1 memory 0 address register
  $38 constant DMA_DMA_S1M1AR           \ DMA stream 1 memory 1 address register
  $3C constant DMA_DMA_S1FCR            \ DMA stream 1 FIFO control register
  $40 constant DMA_DMA_S2CR             \ DMA stream 2 configuration register
  $44 constant DMA_DMA_S2NDTR           \ DMA stream 2 number of data register
  $48 constant DMA_DMA_S2PAR            \ DMA stream 2 peripheral address register
  $4C constant DMA_DMA_S2M0AR           \ DMA stream 2 memory 0 address register
  $50 constant DMA_DMA_S2M1AR           \ DMA stream 2 memory 1 address register
  $54 constant DMA_DMA_S2FCR            \ DMA stream 2 FIFO control register
  $58 constant DMA_DMA_S3CR             \ DMA stream 3 configuration register
  $5C constant DMA_DMA_S3NDTR           \ DMA stream 3 number of data register
  $60 constant DMA_DMA_S3PAR            \ DMA stream 3 peripheral address register
  $64 constant DMA_DMA_S3M0AR           \ DMA stream 3 memory 0 address register
  $68 constant DMA_DMA_S3M1AR           \ DMA stream 3 memory 1 address register
  $6C constant DMA_DMA_S3FCR            \ DMA stream 3 FIFO control register
  $70 constant DMA_DMA_S4CR             \ DMA stream 4 configuration register
  $74 constant DMA_DMA_S4NDTR           \ DMA stream 4 number of data register
  $78 constant DMA_DMA_S4PAR            \ DMA stream 4 peripheral address register
  $7C constant DMA_DMA_S4M0AR           \ DMA stream 4 memory 0 address register
  $80 constant DMA_DMA_S4M1AR           \ DMA stream 4 memory 1 address register
  $84 constant DMA_DMA_S4FCR            \ DMA stream 4 FIFO control register
  $88 constant DMA_DMA_S5CR             \ DMA stream 5 configuration register
  $8C constant DMA_DMA_S5NDTR           \ DMA stream 5 number of data register
  $90 constant DMA_DMA_S5PAR            \ DMA stream 5 peripheral address register
  $94 constant DMA_DMA_S5M0AR           \ DMA stream 5 memory 0 address register
  $98 constant DMA_DMA_S5M1AR           \ DMA stream 5 memory 1 address register
  $9C constant DMA_DMA_S5FCR            \ DMA stream 5 FIFO control register
  $A0 constant DMA_DMA_S6CR             \ DMA stream 6 configuration register
  $A4 constant DMA_DMA_S6NDTR           \ DMA stream 6 number of data register
  $A8 constant DMA_DMA_S6PAR            \ DMA stream 6 peripheral address register
  $AC constant DMA_DMA_S6M0AR           \ DMA stream 6 memory 0 address register
  $B0 constant DMA_DMA_S6M1AR           \ DMA stream 6 memory 1 address register
  $B4 constant DMA_DMA_S6FCR            \ DMA stream 6 FIFO control register
  $B8 constant DMA_DMA_S7CR             \ DMA stream 7 configuration register
  $BC constant DMA_DMA_S7NDTR           \ DMA stream 7 number of data register
  $C0 constant DMA_DMA_S7PAR            \ DMA stream 7 peripheral address register
  $C4 constant DMA_DMA_S7M0AR           \ DMA stream 7 memory 0 address register
  $C8 constant DMA_DMA_S7M1AR           \ DMA stream 7 memory 1 address register
  $CC constant DMA_DMA_S7FCR            \ DMA stream 7 FIFO control register
  $3EC constant DMA_DMA_HWCFGR2         \ DMA hardware configuration 2 register
  $3F0 constant DMA_DMA_HWCFGR1         \ DMA hardware configuration 1 register
  $3F4 constant DMA_DMA_VERR            \ DMA version register
  $3F8 constant DMA_DMA_IPDR            \ DMA identification register
  $3FC constant DMA_DMA_SIDR            \ DMA size identification register

: DMA_DEF ; [then]
