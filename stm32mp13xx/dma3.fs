\
\ @file dma3.fs
\ @brief DMA3 stream0 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMA low interrupt status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_LISR_FEIF0                              \ stream x FIFO error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00000004 constant DMA3_DMA_LISR_DMEIF0                             \ stream x direct mode error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00000008 constant DMA3_DMA_LISR_TEIF0                              \ stream x transfer error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00000010 constant DMA3_DMA_LISR_HTIF0                              \ stream x half transfer interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00000020 constant DMA3_DMA_LISR_TCIF0                              \ stream x transfer complete interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00000040 constant DMA3_DMA_LISR_FEIF1                              \ stream x FIFO error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00000100 constant DMA3_DMA_LISR_DMEIF1                             \ stream x direct mode error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00000200 constant DMA3_DMA_LISR_TEIF1                              \ stream x transfer error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00000400 constant DMA3_DMA_LISR_HTIF1                              \ stream x half transfer interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00000800 constant DMA3_DMA_LISR_TCIF1                              \ stream x transfer complete interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00010000 constant DMA3_DMA_LISR_FEIF2                              \ stream x FIFO error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00040000 constant DMA3_DMA_LISR_DMEIF2                             \ stream x direct mode error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00080000 constant DMA3_DMA_LISR_TEIF2                              \ stream x transfer error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00100000 constant DMA3_DMA_LISR_HTIF2                              \ stream x half transfer interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00200000 constant DMA3_DMA_LISR_TCIF2                              \ stream x transfer complete interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$00400000 constant DMA3_DMA_LISR_FEIF3                              \ stream x FIFO error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$01000000 constant DMA3_DMA_LISR_DMEIF3                             \ stream x direct mode error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$02000000 constant DMA3_DMA_LISR_TEIF3                              \ stream x transfer error interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$04000000 constant DMA3_DMA_LISR_HTIF3                              \ stream x half transfer interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.
$08000000 constant DMA3_DMA_LISR_TCIF3                              \ stream x transfer complete interrupt flag (x = 3 to 0) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_LIFCR register.


\
\ @brief DMA high interrupt status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_HISR_FEIF4                              \ stream x FIFO error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00000004 constant DMA3_DMA_HISR_DMEIF4                             \ stream x direct mode error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00000008 constant DMA3_DMA_HISR_TEIF4                              \ stream x transfer error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00000010 constant DMA3_DMA_HISR_HTIF4                              \ stream x half transfer interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00000020 constant DMA3_DMA_HISR_TCIF4                              \ stream x transfer complete interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00000040 constant DMA3_DMA_HISR_FEIF5                              \ stream x FIFO error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00000100 constant DMA3_DMA_HISR_DMEIF5                             \ stream x direct mode error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00000200 constant DMA3_DMA_HISR_TEIF5                              \ stream x transfer error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00000400 constant DMA3_DMA_HISR_HTIF5                              \ stream x half transfer interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00000800 constant DMA3_DMA_HISR_TCIF5                              \ stream x transfer complete interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00010000 constant DMA3_DMA_HISR_FEIF6                              \ stream x FIFO error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00040000 constant DMA3_DMA_HISR_DMEIF6                             \ stream x direct mode error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00080000 constant DMA3_DMA_HISR_TEIF6                              \ stream x transfer error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00100000 constant DMA3_DMA_HISR_HTIF6                              \ stream x half transfer interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00200000 constant DMA3_DMA_HISR_TCIF6                              \ stream x transfer complete interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$00400000 constant DMA3_DMA_HISR_FEIF7                              \ stream x FIFO error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$01000000 constant DMA3_DMA_HISR_DMEIF7                             \ stream x direct mode error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$02000000 constant DMA3_DMA_HISR_TEIF7                              \ stream x transfer error interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$04000000 constant DMA3_DMA_HISR_HTIF7                              \ stream x half transfer interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.
$08000000 constant DMA3_DMA_HISR_TCIF7                              \ stream x transfer complete interrupt flag (x = 7 to 4) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_HIFCR register.


\
\ @brief DMA low interrupt flag clear register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_LIFCR_CFEIF0                            \ stream x clear FIFO error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_LISR register.
$00000004 constant DMA3_DMA_LIFCR_CDMEIF0                           \ stream x clear direct mode error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_LISR register.
$00000008 constant DMA3_DMA_LIFCR_CTEIF0                            \ Stream x clear transfer error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_LISR register.
$00000010 constant DMA3_DMA_LIFCR_CHTIF0                            \ stream x clear half transfer interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_LISR register
$00000020 constant DMA3_DMA_LIFCR_CTCIF0                            \ stream x clear transfer complete interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_LISR register.
$00000040 constant DMA3_DMA_LIFCR_CFEIF1                            \ stream x clear FIFO error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_LISR register.
$00000100 constant DMA3_DMA_LIFCR_CDMEIF1                           \ stream x clear direct mode error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_LISR register.
$00000200 constant DMA3_DMA_LIFCR_CTEIF1                            \ Stream x clear transfer error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_LISR register.
$00000400 constant DMA3_DMA_LIFCR_CHTIF1                            \ stream x clear half transfer interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_LISR register
$00000800 constant DMA3_DMA_LIFCR_CTCIF1                            \ stream x clear transfer complete interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_LISR register.
$00010000 constant DMA3_DMA_LIFCR_CFEIF2                            \ stream x clear FIFO error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_LISR register.
$00040000 constant DMA3_DMA_LIFCR_CDMEIF2                           \ stream x clear direct mode error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_LISR register.
$00080000 constant DMA3_DMA_LIFCR_CTEIF2                            \ Stream x clear transfer error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_LISR register.
$00100000 constant DMA3_DMA_LIFCR_CHTIF2                            \ stream x clear half transfer interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_LISR register
$00200000 constant DMA3_DMA_LIFCR_CTCIF2                            \ stream x clear transfer complete interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_LISR register.
$00400000 constant DMA3_DMA_LIFCR_CFEIF3                            \ stream x clear FIFO error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_LISR register.
$01000000 constant DMA3_DMA_LIFCR_CDMEIF3                           \ stream x clear direct mode error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_LISR register.
$02000000 constant DMA3_DMA_LIFCR_CTEIF3                            \ Stream x clear transfer error interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_LISR register.
$04000000 constant DMA3_DMA_LIFCR_CHTIF3                            \ stream x clear half transfer interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_LISR register
$08000000 constant DMA3_DMA_LIFCR_CTCIF3                            \ stream x clear transfer complete interrupt flag (x = 3 to 0) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_LISR register.


\
\ @brief DMA high interrupt flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_HIFCR_CFEIF4                            \ stream x clear FIFO error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_HISR register.
$00000004 constant DMA3_DMA_HIFCR_CDMEIF4                           \ stream x clear direct mode error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_HISR register.
$00000008 constant DMA3_DMA_HIFCR_CTEIF4                            \ stream x clear transfer error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_HISR register.
$00000010 constant DMA3_DMA_HIFCR_CHTIF4                            \ stream x clear half transfer interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_HISR register.
$00000020 constant DMA3_DMA_HIFCR_CTCIF4                            \ stream x clear transfer complete interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_HISR register.
$00000040 constant DMA3_DMA_HIFCR_CFEIF5                            \ stream x clear FIFO error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_HISR register.
$00000100 constant DMA3_DMA_HIFCR_CDMEIF5                           \ stream x clear direct mode error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_HISR register.
$00000200 constant DMA3_DMA_HIFCR_CTEIF5                            \ stream x clear transfer error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_HISR register.
$00000400 constant DMA3_DMA_HIFCR_CHTIF5                            \ stream x clear half transfer interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_HISR register.
$00000800 constant DMA3_DMA_HIFCR_CTCIF5                            \ stream x clear transfer complete interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_HISR register.
$00010000 constant DMA3_DMA_HIFCR_CFEIF6                            \ stream x clear FIFO error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_HISR register.
$00040000 constant DMA3_DMA_HIFCR_CDMEIF6                           \ stream x clear direct mode error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_HISR register.
$00080000 constant DMA3_DMA_HIFCR_CTEIF6                            \ stream x clear transfer error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_HISR register.
$00100000 constant DMA3_DMA_HIFCR_CHTIF6                            \ stream x clear half transfer interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_HISR register.
$00200000 constant DMA3_DMA_HIFCR_CTCIF6                            \ stream x clear transfer complete interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_HISR register.
$00400000 constant DMA3_DMA_HIFCR_CFEIF7                            \ stream x clear FIFO error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding CFEIFx flag in the DMA_HISR register.
$01000000 constant DMA3_DMA_HIFCR_CDMEIF7                           \ stream x clear direct mode error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding DMEIFx flag in the DMA_HISR register.
$02000000 constant DMA3_DMA_HIFCR_CTEIF7                            \ stream x clear transfer error interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TEIFx flag in the DMA_HISR register.
$04000000 constant DMA3_DMA_HIFCR_CHTIF7                            \ stream x clear half transfer interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding HTIFx flag in the DMA_HISR register.
$08000000 constant DMA3_DMA_HIFCR_CTCIF7                            \ stream x clear transfer complete interrupt flag (x = 7 to 4) Writing 1 to this bit clears the corresponding TCIFx flag in the DMA_HISR register.


\
\ @brief DMA stream 0 configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_S0CR_EN                                 \ stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
$00000002 constant DMA3_DMA_S0CR_DMEIE                              \ direct mode error interrupt enable This bit is set and cleared by software.
$00000004 constant DMA3_DMA_S0CR_TEIE                               \ transfer error interrupt enable This bit is set and cleared by software.
$00000008 constant DMA3_DMA_S0CR_HTIE                               \ half transfer interrupt enable This bit is set and cleared by software.
$00000010 constant DMA3_DMA_S0CR_TCIE                               \ transfer complete interrupt enable This bit is set and cleared by software.
$00000020 constant DMA3_DMA_S0CR_PFCTRL                             \ peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
$000000c0 constant DMA3_DMA_S0CR_DIR                                \ data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00000100 constant DMA3_DMA_S0CR_CIRC                               \ circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
$00000200 constant DMA3_DMA_S0CR_PINC                               \ peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00000400 constant DMA3_DMA_S0CR_MINC                               \ memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00001800 constant DMA3_DMA_S0CR_PSIZE                              \ peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00006000 constant DMA3_DMA_S0CR_MSIZE                              \ memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
$00008000 constant DMA3_DMA_S0CR_PINCOS                             \ peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
$00030000 constant DMA3_DMA_S0CR_PL                                 \ priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00040000 constant DMA3_DMA_S0CR_DBM                                \ double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00080000 constant DMA3_DMA_S0CR_CT                                 \ current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
$00100000 constant DMA3_DMA_S0CR_TRBUFF                             \ Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
$00600000 constant DMA3_DMA_S0CR_PBURST                             \ peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
$01800000 constant DMA3_DMA_S0CR_MBURST                             \ memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.


\
\ @brief DMA stream 0 number of data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant DMA3_DMA_S0NDTR_NDT                              \ number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.


\
\ @brief DMA stream 0 peripheral address register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S0PAR_PAR                               \ peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.


\
\ @brief DMA stream 0 memory 0 address register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S0M0AR_M0A                              \ memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).


\
\ @brief DMA stream 0 memory 1 address register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S0M1AR_M1A                              \ memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .


\
\ @brief DMA stream 0 FIFO control register
\ Address offset: 0x24
\ Reset value: 0x00000021
\

$00000003 constant DMA3_DMA_S0FCR_FTH                               \ FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
$00000004 constant DMA3_DMA_S0FCR_DMDIS                             \ direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
$00000038 constant DMA3_DMA_S0FCR_FS                                \ FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
$00000080 constant DMA3_DMA_S0FCR_FEIE                              \ FIFO error interrupt enable This bit is set and cleared by software.


\
\ @brief DMA stream 1 configuration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_S1CR_EN                                 \ stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
$00000002 constant DMA3_DMA_S1CR_DMEIE                              \ direct mode error interrupt enable This bit is set and cleared by software.
$00000004 constant DMA3_DMA_S1CR_TEIE                               \ transfer error interrupt enable This bit is set and cleared by software.
$00000008 constant DMA3_DMA_S1CR_HTIE                               \ half transfer interrupt enable This bit is set and cleared by software.
$00000010 constant DMA3_DMA_S1CR_TCIE                               \ transfer complete interrupt enable This bit is set and cleared by software.
$00000020 constant DMA3_DMA_S1CR_PFCTRL                             \ peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
$000000c0 constant DMA3_DMA_S1CR_DIR                                \ data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00000100 constant DMA3_DMA_S1CR_CIRC                               \ circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
$00000200 constant DMA3_DMA_S1CR_PINC                               \ peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00000400 constant DMA3_DMA_S1CR_MINC                               \ memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00001800 constant DMA3_DMA_S1CR_PSIZE                              \ peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00006000 constant DMA3_DMA_S1CR_MSIZE                              \ memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
$00008000 constant DMA3_DMA_S1CR_PINCOS                             \ peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
$00030000 constant DMA3_DMA_S1CR_PL                                 \ priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00040000 constant DMA3_DMA_S1CR_DBM                                \ double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00080000 constant DMA3_DMA_S1CR_CT                                 \ current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
$00100000 constant DMA3_DMA_S1CR_TRBUFF                             \ Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
$00600000 constant DMA3_DMA_S1CR_PBURST                             \ peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
$01800000 constant DMA3_DMA_S1CR_MBURST                             \ memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.


\
\ @brief DMA stream 1 number of data register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant DMA3_DMA_S1NDTR_NDT                              \ number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.


\
\ @brief DMA stream 1 peripheral address register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S1PAR_PAR                               \ peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.


\
\ @brief DMA stream 1 memory 0 address register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S1M0AR_M0A                              \ memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).


\
\ @brief DMA stream 1 memory 1 address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S1M1AR_M1A                              \ memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .


\
\ @brief DMA stream 1 FIFO control register
\ Address offset: 0x3C
\ Reset value: 0x00000021
\

$00000003 constant DMA3_DMA_S1FCR_FTH                               \ FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
$00000004 constant DMA3_DMA_S1FCR_DMDIS                             \ direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
$00000038 constant DMA3_DMA_S1FCR_FS                                \ FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
$00000080 constant DMA3_DMA_S1FCR_FEIE                              \ FIFO error interrupt enable This bit is set and cleared by software.


\
\ @brief DMA stream 2 configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_S2CR_EN                                 \ stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
$00000002 constant DMA3_DMA_S2CR_DMEIE                              \ direct mode error interrupt enable This bit is set and cleared by software.
$00000004 constant DMA3_DMA_S2CR_TEIE                               \ transfer error interrupt enable This bit is set and cleared by software.
$00000008 constant DMA3_DMA_S2CR_HTIE                               \ half transfer interrupt enable This bit is set and cleared by software.
$00000010 constant DMA3_DMA_S2CR_TCIE                               \ transfer complete interrupt enable This bit is set and cleared by software.
$00000020 constant DMA3_DMA_S2CR_PFCTRL                             \ peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
$000000c0 constant DMA3_DMA_S2CR_DIR                                \ data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00000100 constant DMA3_DMA_S2CR_CIRC                               \ circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
$00000200 constant DMA3_DMA_S2CR_PINC                               \ peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00000400 constant DMA3_DMA_S2CR_MINC                               \ memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00001800 constant DMA3_DMA_S2CR_PSIZE                              \ peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00006000 constant DMA3_DMA_S2CR_MSIZE                              \ memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
$00008000 constant DMA3_DMA_S2CR_PINCOS                             \ peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
$00030000 constant DMA3_DMA_S2CR_PL                                 \ priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00040000 constant DMA3_DMA_S2CR_DBM                                \ double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00080000 constant DMA3_DMA_S2CR_CT                                 \ current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
$00100000 constant DMA3_DMA_S2CR_TRBUFF                             \ Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
$00600000 constant DMA3_DMA_S2CR_PBURST                             \ peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
$01800000 constant DMA3_DMA_S2CR_MBURST                             \ memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.


\
\ @brief DMA stream 2 number of data register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant DMA3_DMA_S2NDTR_NDT                              \ number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.


\
\ @brief DMA stream 2 peripheral address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S2PAR_PAR                               \ peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.


\
\ @brief DMA stream 2 memory 0 address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S2M0AR_M0A                              \ memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).


\
\ @brief DMA stream 2 memory 1 address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S2M1AR_M1A                              \ memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .


\
\ @brief DMA stream 2 FIFO control register
\ Address offset: 0x54
\ Reset value: 0x00000021
\

$00000003 constant DMA3_DMA_S2FCR_FTH                               \ FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
$00000004 constant DMA3_DMA_S2FCR_DMDIS                             \ direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
$00000038 constant DMA3_DMA_S2FCR_FS                                \ FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
$00000080 constant DMA3_DMA_S2FCR_FEIE                              \ FIFO error interrupt enable This bit is set and cleared by software.


\
\ @brief DMA stream 3 configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_S3CR_EN                                 \ stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
$00000002 constant DMA3_DMA_S3CR_DMEIE                              \ direct mode error interrupt enable This bit is set and cleared by software.
$00000004 constant DMA3_DMA_S3CR_TEIE                               \ transfer error interrupt enable This bit is set and cleared by software.
$00000008 constant DMA3_DMA_S3CR_HTIE                               \ half transfer interrupt enable This bit is set and cleared by software.
$00000010 constant DMA3_DMA_S3CR_TCIE                               \ transfer complete interrupt enable This bit is set and cleared by software.
$00000020 constant DMA3_DMA_S3CR_PFCTRL                             \ peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
$000000c0 constant DMA3_DMA_S3CR_DIR                                \ data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00000100 constant DMA3_DMA_S3CR_CIRC                               \ circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
$00000200 constant DMA3_DMA_S3CR_PINC                               \ peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00000400 constant DMA3_DMA_S3CR_MINC                               \ memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00001800 constant DMA3_DMA_S3CR_PSIZE                              \ peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00006000 constant DMA3_DMA_S3CR_MSIZE                              \ memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
$00008000 constant DMA3_DMA_S3CR_PINCOS                             \ peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
$00030000 constant DMA3_DMA_S3CR_PL                                 \ priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00040000 constant DMA3_DMA_S3CR_DBM                                \ double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00080000 constant DMA3_DMA_S3CR_CT                                 \ current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
$00100000 constant DMA3_DMA_S3CR_TRBUFF                             \ Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
$00600000 constant DMA3_DMA_S3CR_PBURST                             \ peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
$01800000 constant DMA3_DMA_S3CR_MBURST                             \ memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.


\
\ @brief DMA stream 3 number of data register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant DMA3_DMA_S3NDTR_NDT                              \ number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.


\
\ @brief DMA stream 3 peripheral address register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S3PAR_PAR                               \ peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.


\
\ @brief DMA stream 3 memory 0 address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S3M0AR_M0A                              \ memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).


\
\ @brief DMA stream 3 memory 1 address register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S3M1AR_M1A                              \ memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .


\
\ @brief DMA stream 3 FIFO control register
\ Address offset: 0x6C
\ Reset value: 0x00000021
\

$00000003 constant DMA3_DMA_S3FCR_FTH                               \ FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
$00000004 constant DMA3_DMA_S3FCR_DMDIS                             \ direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
$00000038 constant DMA3_DMA_S3FCR_FS                                \ FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
$00000080 constant DMA3_DMA_S3FCR_FEIE                              \ FIFO error interrupt enable This bit is set and cleared by software.


\
\ @brief DMA stream 4 configuration register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_S4CR_EN                                 \ stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
$00000002 constant DMA3_DMA_S4CR_DMEIE                              \ direct mode error interrupt enable This bit is set and cleared by software.
$00000004 constant DMA3_DMA_S4CR_TEIE                               \ transfer error interrupt enable This bit is set and cleared by software.
$00000008 constant DMA3_DMA_S4CR_HTIE                               \ half transfer interrupt enable This bit is set and cleared by software.
$00000010 constant DMA3_DMA_S4CR_TCIE                               \ transfer complete interrupt enable This bit is set and cleared by software.
$00000020 constant DMA3_DMA_S4CR_PFCTRL                             \ peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
$000000c0 constant DMA3_DMA_S4CR_DIR                                \ data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00000100 constant DMA3_DMA_S4CR_CIRC                               \ circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
$00000200 constant DMA3_DMA_S4CR_PINC                               \ peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00000400 constant DMA3_DMA_S4CR_MINC                               \ memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00001800 constant DMA3_DMA_S4CR_PSIZE                              \ peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00006000 constant DMA3_DMA_S4CR_MSIZE                              \ memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
$00008000 constant DMA3_DMA_S4CR_PINCOS                             \ peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
$00030000 constant DMA3_DMA_S4CR_PL                                 \ priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00040000 constant DMA3_DMA_S4CR_DBM                                \ double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00080000 constant DMA3_DMA_S4CR_CT                                 \ current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
$00100000 constant DMA3_DMA_S4CR_TRBUFF                             \ Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
$00600000 constant DMA3_DMA_S4CR_PBURST                             \ peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
$01800000 constant DMA3_DMA_S4CR_MBURST                             \ memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.


\
\ @brief DMA stream 4 number of data register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000ffff constant DMA3_DMA_S4NDTR_NDT                              \ number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.


\
\ @brief DMA stream 4 peripheral address register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S4PAR_PAR                               \ peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.


\
\ @brief DMA stream 4 memory 0 address register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S4M0AR_M0A                              \ memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).


\
\ @brief DMA stream 4 memory 1 address register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S4M1AR_M1A                              \ memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .


\
\ @brief DMA stream 4 FIFO control register
\ Address offset: 0x84
\ Reset value: 0x00000021
\

$00000003 constant DMA3_DMA_S4FCR_FTH                               \ FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
$00000004 constant DMA3_DMA_S4FCR_DMDIS                             \ direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
$00000038 constant DMA3_DMA_S4FCR_FS                                \ FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
$00000080 constant DMA3_DMA_S4FCR_FEIE                              \ FIFO error interrupt enable This bit is set and cleared by software.


\
\ @brief DMA stream 5 configuration register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_S5CR_EN                                 \ stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
$00000002 constant DMA3_DMA_S5CR_DMEIE                              \ direct mode error interrupt enable This bit is set and cleared by software.
$00000004 constant DMA3_DMA_S5CR_TEIE                               \ transfer error interrupt enable This bit is set and cleared by software.
$00000008 constant DMA3_DMA_S5CR_HTIE                               \ half transfer interrupt enable This bit is set and cleared by software.
$00000010 constant DMA3_DMA_S5CR_TCIE                               \ transfer complete interrupt enable This bit is set and cleared by software.
$00000020 constant DMA3_DMA_S5CR_PFCTRL                             \ peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
$000000c0 constant DMA3_DMA_S5CR_DIR                                \ data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00000100 constant DMA3_DMA_S5CR_CIRC                               \ circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
$00000200 constant DMA3_DMA_S5CR_PINC                               \ peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00000400 constant DMA3_DMA_S5CR_MINC                               \ memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00001800 constant DMA3_DMA_S5CR_PSIZE                              \ peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00006000 constant DMA3_DMA_S5CR_MSIZE                              \ memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
$00008000 constant DMA3_DMA_S5CR_PINCOS                             \ peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
$00030000 constant DMA3_DMA_S5CR_PL                                 \ priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00040000 constant DMA3_DMA_S5CR_DBM                                \ double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00080000 constant DMA3_DMA_S5CR_CT                                 \ current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
$00100000 constant DMA3_DMA_S5CR_TRBUFF                             \ Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
$00600000 constant DMA3_DMA_S5CR_PBURST                             \ peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
$01800000 constant DMA3_DMA_S5CR_MBURST                             \ memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.


\
\ @brief DMA stream 5 number of data register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant DMA3_DMA_S5NDTR_NDT                              \ number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.


\
\ @brief DMA stream 5 peripheral address register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S5PAR_PAR                               \ peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.


\
\ @brief DMA stream 5 memory 0 address register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S5M0AR_M0A                              \ memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).


\
\ @brief DMA stream 5 memory 1 address register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S5M1AR_M1A                              \ memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .


\
\ @brief DMA stream 5 FIFO control register
\ Address offset: 0x9C
\ Reset value: 0x00000021
\

$00000003 constant DMA3_DMA_S5FCR_FTH                               \ FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
$00000004 constant DMA3_DMA_S5FCR_DMDIS                             \ direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
$00000038 constant DMA3_DMA_S5FCR_FS                                \ FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
$00000080 constant DMA3_DMA_S5FCR_FEIE                              \ FIFO error interrupt enable This bit is set and cleared by software.


\
\ @brief DMA stream 6 configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_S6CR_EN                                 \ stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
$00000002 constant DMA3_DMA_S6CR_DMEIE                              \ direct mode error interrupt enable This bit is set and cleared by software.
$00000004 constant DMA3_DMA_S6CR_TEIE                               \ transfer error interrupt enable This bit is set and cleared by software.
$00000008 constant DMA3_DMA_S6CR_HTIE                               \ half transfer interrupt enable This bit is set and cleared by software.
$00000010 constant DMA3_DMA_S6CR_TCIE                               \ transfer complete interrupt enable This bit is set and cleared by software.
$00000020 constant DMA3_DMA_S6CR_PFCTRL                             \ peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
$000000c0 constant DMA3_DMA_S6CR_DIR                                \ data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00000100 constant DMA3_DMA_S6CR_CIRC                               \ circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
$00000200 constant DMA3_DMA_S6CR_PINC                               \ peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00000400 constant DMA3_DMA_S6CR_MINC                               \ memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00001800 constant DMA3_DMA_S6CR_PSIZE                              \ peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00006000 constant DMA3_DMA_S6CR_MSIZE                              \ memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
$00008000 constant DMA3_DMA_S6CR_PINCOS                             \ peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
$00030000 constant DMA3_DMA_S6CR_PL                                 \ priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00040000 constant DMA3_DMA_S6CR_DBM                                \ double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00080000 constant DMA3_DMA_S6CR_CT                                 \ current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
$00100000 constant DMA3_DMA_S6CR_TRBUFF                             \ Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
$00600000 constant DMA3_DMA_S6CR_PBURST                             \ peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
$01800000 constant DMA3_DMA_S6CR_MBURST                             \ memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.


\
\ @brief DMA stream 6 number of data register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000ffff constant DMA3_DMA_S6NDTR_NDT                              \ number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.


\
\ @brief DMA stream 6 peripheral address register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S6PAR_PAR                               \ peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.


\
\ @brief DMA stream 6 memory 0 address register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S6M0AR_M0A                              \ memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).


\
\ @brief DMA stream 6 memory 1 address register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S6M1AR_M1A                              \ memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .


\
\ @brief DMA stream 6 FIFO control register
\ Address offset: 0xB4
\ Reset value: 0x00000021
\

$00000003 constant DMA3_DMA_S6FCR_FTH                               \ FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
$00000004 constant DMA3_DMA_S6FCR_DMDIS                             \ direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
$00000038 constant DMA3_DMA_S6FCR_FS                                \ FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
$00000080 constant DMA3_DMA_S6FCR_FEIE                              \ FIFO error interrupt enable This bit is set and cleared by software.


\
\ @brief DMA stream 7 configuration register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant DMA3_DMA_S7CR_EN                                 \ stream enable / flag stream ready when read low This bit is set and cleared by software. This bit may be cleared by hardware: on a DMA end of transfer (stream ready to be configured) if a transfer error occurs on the AHB master buses when the FIFO threshold on memory AHB port is not compatible with the size of the burst When this bit is read as 0, the software is allowed to program the configuration and FIFO bits registers. It is forbidden to write these registers when the EN bit is read as 1. Note: Before setting EN bit to 1 to start a new transfer, the event flags corresponding to the stream in DMA_LISR or DMA_HISR register must be cleared.
$00000002 constant DMA3_DMA_S7CR_DMEIE                              \ direct mode error interrupt enable This bit is set and cleared by software.
$00000004 constant DMA3_DMA_S7CR_TEIE                               \ transfer error interrupt enable This bit is set and cleared by software.
$00000008 constant DMA3_DMA_S7CR_HTIE                               \ half transfer interrupt enable This bit is set and cleared by software.
$00000010 constant DMA3_DMA_S7CR_TCIE                               \ transfer complete interrupt enable This bit is set and cleared by software.
$00000020 constant DMA3_DMA_S7CR_PFCTRL                             \ peripheral flow controller This bit is set and cleared by software. This bit is protected and can be written only if EN = 0. When the memory-to-memory mode is selected (bits DIR[1:0]=10), then this bit is automatically forced to 0 by hardware.
$000000c0 constant DMA3_DMA_S7CR_DIR                                \ data transfer direction These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00000100 constant DMA3_DMA_S7CR_CIRC                               \ circular mode This bit is set and cleared by software and can be cleared by hardware. When the peripheral is the flow controller (bit PFCTRL = 1) and the stream is enabled (EN = 1), then this bit is automatically forced by hardware to 0. It is automatically forced by hardware to 1 if the DBM bit is set, as soon as the stream is enabled (EN = 1).
$00000200 constant DMA3_DMA_S7CR_PINC                               \ peripheral increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00000400 constant DMA3_DMA_S7CR_MINC                               \ memory increment mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00001800 constant DMA3_DMA_S7CR_PSIZE                              \ peripheral data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00006000 constant DMA3_DMA_S7CR_MSIZE                              \ memory data size These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, MSIZE is forced by hardware to the same value as PSIZE as soon as EN = 1.
$00008000 constant DMA3_DMA_S7CR_PINCOS                             \ peripheral increment offset size This bit is set and cleared by software This bit has no meaning if bit PINC = 0. This bit is protected and can be written only if EN = 0. This bit is forced low by hardware when the stream is enabled (EN = 1) if the direct mode is selected or if PBURST are different from 00.
$00030000 constant DMA3_DMA_S7CR_PL                                 \ priority level These bits are set and cleared by software. These bits are protected and can be written only if EN = 0.
$00040000 constant DMA3_DMA_S7CR_DBM                                \ double-buffer mode This bit is set and cleared by software. This bit is protected and can be written only if EN = 0.
$00080000 constant DMA3_DMA_S7CR_CT                                 \ current target (only in double-buffer mode) This bit is set and cleared by hardware. It can also be written by software. This bit can be written only if EN = 0 to indicate the target memory area of the first transfer. Once the stream is enabled, this bit operates as a status flag indicating which memory area is the current target.
$00100000 constant DMA3_DMA_S7CR_TRBUFF                             \ Enable the DMA to handle bufferable transfers. Note: This bit must be set to 1 if the DMA stream manages UART/USART/LPUART transfers.
$00600000 constant DMA3_DMA_S7CR_PBURST                             \ peripheral burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware.
$01800000 constant DMA3_DMA_S7CR_MBURST                             \ memory burst transfer configuration These bits are set and cleared by software. These bits are protected and can be written only if EN = 0. In direct mode, these bits are forced to 0x0 by hardware as soon as bit EN = 1.


\
\ @brief DMA stream 7 number of data register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$0000ffff constant DMA3_DMA_S7NDTR_NDT                              \ number of data items to transfer (0 up to 65535) This register can be written only when the stream is disabled. When the stream is enabled, this register is read-only, indicating the remaining data items to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero (when the stream is in normal mode) or be reloaded automatically with the previously programmed value in the following cases: when the stream is configured in circular mode. when the stream is enabled again by setting EN bit to 1. If the value of this register is zero, no transaction can be served even if the stream is enabled.


\
\ @brief DMA stream 7 peripheral address register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S7PAR_PAR                               \ peripheral address Base address of the peripheral data register from/to which the data is read/written. These bits are write-protected and can be written only when bit EN = 0 in DMA_SxCR.


\
\ @brief DMA stream 7 memory 0 address register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S7M0AR_M0A                              \ memory 0 address Base address of memory area 0 from/to which the data is read/written. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and CT = 1 in DMA_SxCR (in double-buffer mode).


\
\ @brief DMA stream 7 memory 1 address register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant DMA3_DMA_S7M1AR_M1A                              \ memory 1 address (used in case of double-buffer mode) Base address of memory area 1 from/to which the data is read/written. This register is used only for the double-buffer mode. These bits are write-protected. They can be written only if: the stream is disabled (EN = 0 in DMA_SxCR) or the stream is enabled (EN = 1 in DMA_SxCR) and bit CT = 0 in DMA_SxCR .


\
\ @brief DMA stream 7 FIFO control register
\ Address offset: 0xCC
\ Reset value: 0x00000021
\

$00000003 constant DMA3_DMA_S7FCR_FTH                               \ FIFO threshold selection These bits are set and cleared by software. These bits are not used in the direct mode when the DMIS = 0. These bits are protected and can be written only if EN = 0.
$00000004 constant DMA3_DMA_S7FCR_DMDIS                             \ direct mode disable This bit is set and cleared by software. It can be set by hardware. This bit is protected and can be written only if EN = 0. This bit is set by hardware if the memory-to-memory mode is selected (DIR bit in DMA_SxCR are 10) and the EN = 1 in DMA_SxCR because the direct mode is not allowed in the memory-to-memory configuration.
$00000038 constant DMA3_DMA_S7FCR_FS                                \ FIFO status These bits are read-only. others: no meaning These bits are not relevant in the direct mode (DMDIS = 0).
$00000080 constant DMA3_DMA_S7FCR_FEIE                              \ FIFO error interrupt enable This bit is set and cleared by software.


\
\ @brief DMA hardware configuration 2 register
\ Address offset: 0x3EC
\ Reset value: 0x00000001
\

$00000003 constant DMA3_DMA_HWCFGR2_FIFO_SIZE                       \ FIFO size, common to all streams In [0..3] range: 2: 8-word FIFO 3: 16-word FIFO
$00000010 constant DMA3_DMA_HWCFGR2_WRITE_BUFFERABLE                \ In any case, DMA acknowledge signal is asserted one cycle after the address phase of the bus access on its AHB peripheral master port.
$00000700 constant DMA3_DMA_HWCFGR2_CHSEL_WIDTH                     \ bit width of the CHSEL field of any DMA_SxCR register common to all streams In [0..6] range: 2: up to 8 channels programmable selection 3: up to 16 channels programmable selection 4: up to 32 channels programmable selection 5: up to 64 channels programmable selection 6: up to 128 channels programmable selection


\
\ @brief DMA hardware configuration 1 register
\ Address offset: 0x3F0
\ Reset value: 0x22222222
\

$00000003 constant DMA3_DMA_HWCFGR1_DMA_DEF0                        \ type of the stream 0 2: double-buffer 3: Reserved
$00000030 constant DMA3_DMA_HWCFGR1_DMA_DEF1                        \ type of the stream 1 2: double-buffer 3: Reserved
$00000300 constant DMA3_DMA_HWCFGR1_DMA_DEF2                        \ type of the stream 2 2: double-buffer 3: Reserved
$00003000 constant DMA3_DMA_HWCFGR1_DMA_DEF3                        \ type of the stream 3 2: double-buffer 3: Reserved
$00030000 constant DMA3_DMA_HWCFGR1_DMA_DEF4                        \ type of the stream 4 2: double-buffer 3: Reserved
$00300000 constant DMA3_DMA_HWCFGR1_DMA_DEF5                        \ type of the stream 5 2: double-buffer 3: Reserved
$03000000 constant DMA3_DMA_HWCFGR1_DMA_DEF6                        \ type of the stream 6 2: double-buffer 3: Reserved
$30000000 constant DMA3_DMA_HWCFGR1_DMA_DEF7                        \ type of the stream 7 2: double-buffer 3: Reserved


\
\ @brief DMA version register
\ Address offset: 0x3F4
\ Reset value: 0x00000014
\

$0000000f constant DMA3_DMA_VERR_MINREV                             \ minor IP revision
$000000f0 constant DMA3_DMA_VERR_MAJREV                             \ major IP revision


\
\ @brief DMA identification register
\ Address offset: 0x3F8
\ Reset value: 0x00100002
\

$00000000 constant DMA3_DMA_IPDR_ID                                 \ size identification This register identifies the peripheral.


\
\ @brief DMA size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant DMA3_DMA_SIDR_SID                                \ size identification This register identifies the DMA as a peripheal with a size of 1 Kbyte address space.


\
\ @brief DMA3 stream0 global interrupt
\
$48005000 constant DMA3_DMA_LISR  \ offset: 0x00 : DMA low interrupt status register
$48005004 constant DMA3_DMA_HISR  \ offset: 0x04 : DMA high interrupt status register
$48005008 constant DMA3_DMA_LIFCR  \ offset: 0x08 : DMA low interrupt flag clear register
$4800500c constant DMA3_DMA_HIFCR  \ offset: 0x0C : DMA high interrupt flag clear register
$48005010 constant DMA3_DMA_S0CR  \ offset: 0x10 : DMA stream 0 configuration register
$48005014 constant DMA3_DMA_S0NDTR  \ offset: 0x14 : DMA stream 0 number of data register
$48005018 constant DMA3_DMA_S0PAR  \ offset: 0x18 : DMA stream 0 peripheral address register
$4800501c constant DMA3_DMA_S0M0AR  \ offset: 0x1C : DMA stream 0 memory 0 address register
$48005020 constant DMA3_DMA_S0M1AR  \ offset: 0x20 : DMA stream 0 memory 1 address register
$48005024 constant DMA3_DMA_S0FCR  \ offset: 0x24 : DMA stream 0 FIFO control register
$48005028 constant DMA3_DMA_S1CR  \ offset: 0x28 : DMA stream 1 configuration register
$4800502c constant DMA3_DMA_S1NDTR  \ offset: 0x2C : DMA stream 1 number of data register
$48005030 constant DMA3_DMA_S1PAR  \ offset: 0x30 : DMA stream 1 peripheral address register
$48005034 constant DMA3_DMA_S1M0AR  \ offset: 0x34 : DMA stream 1 memory 0 address register
$48005038 constant DMA3_DMA_S1M1AR  \ offset: 0x38 : DMA stream 1 memory 1 address register
$4800503c constant DMA3_DMA_S1FCR  \ offset: 0x3C : DMA stream 1 FIFO control register
$48005040 constant DMA3_DMA_S2CR  \ offset: 0x40 : DMA stream 2 configuration register
$48005044 constant DMA3_DMA_S2NDTR  \ offset: 0x44 : DMA stream 2 number of data register
$48005048 constant DMA3_DMA_S2PAR  \ offset: 0x48 : DMA stream 2 peripheral address register
$4800504c constant DMA3_DMA_S2M0AR  \ offset: 0x4C : DMA stream 2 memory 0 address register
$48005050 constant DMA3_DMA_S2M1AR  \ offset: 0x50 : DMA stream 2 memory 1 address register
$48005054 constant DMA3_DMA_S2FCR  \ offset: 0x54 : DMA stream 2 FIFO control register
$48005058 constant DMA3_DMA_S3CR  \ offset: 0x58 : DMA stream 3 configuration register
$4800505c constant DMA3_DMA_S3NDTR  \ offset: 0x5C : DMA stream 3 number of data register
$48005060 constant DMA3_DMA_S3PAR  \ offset: 0x60 : DMA stream 3 peripheral address register
$48005064 constant DMA3_DMA_S3M0AR  \ offset: 0x64 : DMA stream 3 memory 0 address register
$48005068 constant DMA3_DMA_S3M1AR  \ offset: 0x68 : DMA stream 3 memory 1 address register
$4800506c constant DMA3_DMA_S3FCR  \ offset: 0x6C : DMA stream 3 FIFO control register
$48005070 constant DMA3_DMA_S4CR  \ offset: 0x70 : DMA stream 4 configuration register
$48005074 constant DMA3_DMA_S4NDTR  \ offset: 0x74 : DMA stream 4 number of data register
$48005078 constant DMA3_DMA_S4PAR  \ offset: 0x78 : DMA stream 4 peripheral address register
$4800507c constant DMA3_DMA_S4M0AR  \ offset: 0x7C : DMA stream 4 memory 0 address register
$48005080 constant DMA3_DMA_S4M1AR  \ offset: 0x80 : DMA stream 4 memory 1 address register
$48005084 constant DMA3_DMA_S4FCR  \ offset: 0x84 : DMA stream 4 FIFO control register
$48005088 constant DMA3_DMA_S5CR  \ offset: 0x88 : DMA stream 5 configuration register
$4800508c constant DMA3_DMA_S5NDTR  \ offset: 0x8C : DMA stream 5 number of data register
$48005090 constant DMA3_DMA_S5PAR  \ offset: 0x90 : DMA stream 5 peripheral address register
$48005094 constant DMA3_DMA_S5M0AR  \ offset: 0x94 : DMA stream 5 memory 0 address register
$48005098 constant DMA3_DMA_S5M1AR  \ offset: 0x98 : DMA stream 5 memory 1 address register
$4800509c constant DMA3_DMA_S5FCR  \ offset: 0x9C : DMA stream 5 FIFO control register
$480050a0 constant DMA3_DMA_S6CR  \ offset: 0xA0 : DMA stream 6 configuration register
$480050a4 constant DMA3_DMA_S6NDTR  \ offset: 0xA4 : DMA stream 6 number of data register
$480050a8 constant DMA3_DMA_S6PAR  \ offset: 0xA8 : DMA stream 6 peripheral address register
$480050ac constant DMA3_DMA_S6M0AR  \ offset: 0xAC : DMA stream 6 memory 0 address register
$480050b0 constant DMA3_DMA_S6M1AR  \ offset: 0xB0 : DMA stream 6 memory 1 address register
$480050b4 constant DMA3_DMA_S6FCR  \ offset: 0xB4 : DMA stream 6 FIFO control register
$480050b8 constant DMA3_DMA_S7CR  \ offset: 0xB8 : DMA stream 7 configuration register
$480050bc constant DMA3_DMA_S7NDTR  \ offset: 0xBC : DMA stream 7 number of data register
$480050c0 constant DMA3_DMA_S7PAR  \ offset: 0xC0 : DMA stream 7 peripheral address register
$480050c4 constant DMA3_DMA_S7M0AR  \ offset: 0xC4 : DMA stream 7 memory 0 address register
$480050c8 constant DMA3_DMA_S7M1AR  \ offset: 0xC8 : DMA stream 7 memory 1 address register
$480050cc constant DMA3_DMA_S7FCR  \ offset: 0xCC : DMA stream 7 FIFO control register
$480053ec constant DMA3_DMA_HWCFGR2  \ offset: 0x3EC : DMA hardware configuration 2 register
$480053f0 constant DMA3_DMA_HWCFGR1  \ offset: 0x3F0 : DMA hardware configuration 1 register
$480053f4 constant DMA3_DMA_VERR  \ offset: 0x3F4 : DMA version register
$480053f8 constant DMA3_DMA_IPDR  \ offset: 0x3F8 : DMA identification register
$480053fc constant DMA3_DMA_SIDR  \ offset: 0x3FC : DMA size identification register

