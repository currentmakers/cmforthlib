\
\ @file dma1.fs
\ @brief DMA register bank
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMA interrupt status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DMA1_DMA_ISR_GIF1                                \ Global interrupt flag for channel 1
$00000002 constant DMA1_DMA_ISR_TCIF1                               \ Transfer complete (TC) flag for channel 1
$00000004 constant DMA1_DMA_ISR_HTIF1                               \ Half transfer (HT) flag for channel 1
$00000008 constant DMA1_DMA_ISR_TEIF1                               \ Transfer error (TE) flag for channel 1
$00000010 constant DMA1_DMA_ISR_GIF2                                \ Global interrupt flag for channel 2
$00000020 constant DMA1_DMA_ISR_TCIF2                               \ Transfer complete (TC) flag for channel 2
$00000040 constant DMA1_DMA_ISR_HTIF2                               \ Half transfer (HT) flag for channel 2
$00000080 constant DMA1_DMA_ISR_TEIF2                               \ Transfer error (TE) flag for channel 2
$00000100 constant DMA1_DMA_ISR_GIF3                                \ Global interrupt flag for channel 3
$00000200 constant DMA1_DMA_ISR_TCIF3                               \ Transfer complete (TC) flag for channel 3
$00000400 constant DMA1_DMA_ISR_HTIF3                               \ Half transfer (HT) flag for channel 3
$00000800 constant DMA1_DMA_ISR_TEIF3                               \ Transfer error (TE) flag for channel 3
$00001000 constant DMA1_DMA_ISR_GIF4                                \ global interrupt flag for channel 4
$00002000 constant DMA1_DMA_ISR_TCIF4                               \ Transfer complete (TC) flag for channel 4
$00004000 constant DMA1_DMA_ISR_HTIF4                               \ Half transfer (HT) flag for channel 4
$00008000 constant DMA1_DMA_ISR_TEIF4                               \ Transfer error (TE) flag for channel 4
$00010000 constant DMA1_DMA_ISR_GIF5                                \ global interrupt flag for channel 5
$00020000 constant DMA1_DMA_ISR_TCIF5                               \ Transfer complete (TC) flag for channel 5
$00040000 constant DMA1_DMA_ISR_HTIF5                               \ Half transfer (HT) flag for channel 5
$00080000 constant DMA1_DMA_ISR_TEIF5                               \ Transfer error (TE) flag for channel 5
$00100000 constant DMA1_DMA_ISR_GIF6                                \ Global interrupt flag for channel 6
$00200000 constant DMA1_DMA_ISR_TCIF6                               \ Transfer complete (TC) flag for channel 6
$00400000 constant DMA1_DMA_ISR_HTIF6                               \ Half transfer (HT) flag for channel 6
$00800000 constant DMA1_DMA_ISR_TEIF6                               \ Transfer error (TE) flag for channel 6
$01000000 constant DMA1_DMA_ISR_GIF7                                \ Global interrupt flag for channel 7
$02000000 constant DMA1_DMA_ISR_TCIF7                               \ Transfer complete (TC) flag for channel 7
$04000000 constant DMA1_DMA_ISR_HTIF7                               \ Half transfer (HT) flag for channel 7
$08000000 constant DMA1_DMA_ISR_TEIF7                               \ Transfer error (TE) flag for channel 7


\
\ @brief DMA interrupt flag clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA1_DMA_IFCR_CGIF1                              \ Global interrupt flag clear for channel 1
$00000002 constant DMA1_DMA_IFCR_CTCIF1                             \ Transfer complete flag clear for channel 1
$00000004 constant DMA1_DMA_IFCR_CHTIF1                             \ Half transfer flag clear for channel 1
$00000008 constant DMA1_DMA_IFCR_CTEIF1                             \ Transfer error flag clear for channel 1
$00000010 constant DMA1_DMA_IFCR_CGIF2                              \ Global interrupt flag clear for channel 2
$00000020 constant DMA1_DMA_IFCR_CTCIF2                             \ Transfer complete flag clear for channel 2
$00000040 constant DMA1_DMA_IFCR_CHTIF2                             \ Half transfer flag clear for channel 2
$00000080 constant DMA1_DMA_IFCR_CTEIF2                             \ Transfer error flag clear for channel 2
$00000100 constant DMA1_DMA_IFCR_CGIF3                              \ Global interrupt flag clear for channel 3
$00000200 constant DMA1_DMA_IFCR_CTCIF3                             \ Transfer complete flag clear for channel 3
$00000400 constant DMA1_DMA_IFCR_CHTIF3                             \ Half transfer flag clear for channel 3
$00000800 constant DMA1_DMA_IFCR_CTEIF3                             \ Transfer error flag clear for channel 3
$00001000 constant DMA1_DMA_IFCR_CGIF4                              \ Global interrupt flag clear for channel 4
$00002000 constant DMA1_DMA_IFCR_CTCIF4                             \ Transfer complete flag clear for channel 4
$00004000 constant DMA1_DMA_IFCR_CHTIF4                             \ Half transfer flag clear for channel 4
$00008000 constant DMA1_DMA_IFCR_CTEIF4                             \ Transfer error flag clear for channel 4
$00010000 constant DMA1_DMA_IFCR_CGIF5                              \ Global interrupt flag clear for channel 5
$00020000 constant DMA1_DMA_IFCR_CTCIF5                             \ Transfer complete flag clear for channel 5
$00040000 constant DMA1_DMA_IFCR_CHTIF5                             \ Half transfer flag clear for channel 5
$00080000 constant DMA1_DMA_IFCR_CTEIF5                             \ Transfer error flag clear for channel 5
$00100000 constant DMA1_DMA_IFCR_CGIF6                              \ Global interrupt flag clear for channel 6
$00200000 constant DMA1_DMA_IFCR_CTCIF6                             \ Transfer complete flag clear for channel 6
$00400000 constant DMA1_DMA_IFCR_CHTIF6                             \ Half transfer flag clear for channel 6
$00800000 constant DMA1_DMA_IFCR_CTEIF6                             \ Transfer error flag clear for channel 6
$01000000 constant DMA1_DMA_IFCR_CGIF7                              \ Global interrupt flag clear for channel 7
$02000000 constant DMA1_DMA_IFCR_CTCIF7                             \ Transfer complete flag clear for channel 7
$04000000 constant DMA1_DMA_IFCR_CHTIF7                             \ Half transfer flag clear for channel 7
$08000000 constant DMA1_DMA_IFCR_CTEIF7                             \ Transfer error flag clear for channel 7


\
\ @brief DMA channel 1 configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA1_DMA_CCR1_EN                                 \ Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by1setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
$00000002 constant DMA1_DMA_CCR1_TCIE                               \ Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000004 constant DMA1_DMA_CCR1_HTIE                               \ Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000008 constant DMA1_DMA_CCR1_TEIE                               \ Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000010 constant DMA1_DMA_CCR1_DIR                                \ Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000020 constant DMA1_DMA_CCR1_CIRC                               \ Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000040 constant DMA1_DMA_CCR1_PINC                               \ Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000080 constant DMA1_DMA_CCR1_MINC                               \ Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000300 constant DMA1_DMA_CCR1_PSIZE                              \ Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000c00 constant DMA1_DMA_CCR1_MSIZE                              \ Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00003000 constant DMA1_DMA_CCR1_PL                                 \ Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00004000 constant DMA1_DMA_CCR1_MEM2MEM                            \ Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 1 number of data to transfer register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_DMA_CNDTR1_NDT                              \ Number of data to transfer


\
\ @brief DMA channel 1 peripheral address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CPAR1_PA                                \ Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR1= 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 1 memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CMAR1_MA                                \ Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR1=10. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR1=11 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 2 configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant DMA1_DMA_CCR2_EN                                 \ Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by1setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
$00000002 constant DMA1_DMA_CCR2_TCIE                               \ Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000004 constant DMA1_DMA_CCR2_HTIE                               \ Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000008 constant DMA1_DMA_CCR2_TEIE                               \ Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000010 constant DMA1_DMA_CCR2_DIR                                \ Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000020 constant DMA1_DMA_CCR2_CIRC                               \ Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000040 constant DMA1_DMA_CCR2_PINC                               \ Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000080 constant DMA1_DMA_CCR2_MINC                               \ Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000300 constant DMA1_DMA_CCR2_PSIZE                              \ Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000c00 constant DMA1_DMA_CCR2_MSIZE                              \ Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00003000 constant DMA1_DMA_CCR2_PL                                 \ Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00004000 constant DMA1_DMA_CCR2_MEM2MEM                            \ Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 2 number of data to transfer register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_DMA_CNDTR2_NDT                              \ Number of data to transfer


\
\ @brief DMA channel 2 peripheral address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CPAR2_PA                                \ Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR1= 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 2 memory address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CMAR2_MA                                \ Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR1=10. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR1=11 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 3 configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant DMA1_DMA_CCR3_EN                                 \ Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by1setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
$00000002 constant DMA1_DMA_CCR3_TCIE                               \ Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000004 constant DMA1_DMA_CCR3_HTIE                               \ Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000008 constant DMA1_DMA_CCR3_TEIE                               \ Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000010 constant DMA1_DMA_CCR3_DIR                                \ Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000020 constant DMA1_DMA_CCR3_CIRC                               \ Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000040 constant DMA1_DMA_CCR3_PINC                               \ Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000080 constant DMA1_DMA_CCR3_MINC                               \ Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000300 constant DMA1_DMA_CCR3_PSIZE                              \ Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000c00 constant DMA1_DMA_CCR3_MSIZE                              \ Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00003000 constant DMA1_DMA_CCR3_PL                                 \ Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00004000 constant DMA1_DMA_CCR3_MEM2MEM                            \ Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 3 number of data to transfer register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_DMA_CNDTR3_NDT                              \ Number of data to transfer


\
\ @brief DMA channel 3 peripheral address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CPAR3_PA                                \ Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR1= 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 3 memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CMAR3_MA                                \ Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR1=10. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR1=11 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 4 configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant DMA1_DMA_CCR4_EN                                 \ Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by1setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
$00000002 constant DMA1_DMA_CCR4_TCIE                               \ Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000004 constant DMA1_DMA_CCR4_HTIE                               \ Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000008 constant DMA1_DMA_CCR4_TEIE                               \ Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000010 constant DMA1_DMA_CCR4_DIR                                \ Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000020 constant DMA1_DMA_CCR4_CIRC                               \ Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000040 constant DMA1_DMA_CCR4_PINC                               \ Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000080 constant DMA1_DMA_CCR4_MINC                               \ Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000300 constant DMA1_DMA_CCR4_PSIZE                              \ Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000c00 constant DMA1_DMA_CCR4_MSIZE                              \ Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00003000 constant DMA1_DMA_CCR4_PL                                 \ Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00004000 constant DMA1_DMA_CCR4_MEM2MEM                            \ Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 4 number of data to transfer register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_DMA_CNDTR4_NDT                              \ Number of data to transfer


\
\ @brief DMA channel 4 peripheral address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CPAR4_PA                                \ Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR1= 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 4 memory address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CMAR4_MA                                \ Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR1=10. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR1=11 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 5 configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant DMA1_DMA_CCR5_EN                                 \ Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by1setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
$00000002 constant DMA1_DMA_CCR5_TCIE                               \ Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000004 constant DMA1_DMA_CCR5_HTIE                               \ Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000008 constant DMA1_DMA_CCR5_TEIE                               \ Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000010 constant DMA1_DMA_CCR5_DIR                                \ Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000020 constant DMA1_DMA_CCR5_CIRC                               \ Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000040 constant DMA1_DMA_CCR5_PINC                               \ Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000080 constant DMA1_DMA_CCR5_MINC                               \ Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000300 constant DMA1_DMA_CCR5_PSIZE                              \ Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000c00 constant DMA1_DMA_CCR5_MSIZE                              \ Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00003000 constant DMA1_DMA_CCR5_PL                                 \ Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00004000 constant DMA1_DMA_CCR5_MEM2MEM                            \ Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 5 number of data to transfer register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_DMA_CNDTR5_NDT                              \ Number of data to transfer


\
\ @brief DMA channel 5 peripheral address register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CPAR5_PA                                \ Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR1= 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 5 memory address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CMAR5_MA                                \ Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR1=10. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR1=11 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 6 configuration register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant DMA1_DMA_CCR6_EN                                 \ Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by1setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
$00000002 constant DMA1_DMA_CCR6_TCIE                               \ Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000004 constant DMA1_DMA_CCR6_HTIE                               \ Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000008 constant DMA1_DMA_CCR6_TEIE                               \ Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000010 constant DMA1_DMA_CCR6_DIR                                \ Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000020 constant DMA1_DMA_CCR6_CIRC                               \ Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000040 constant DMA1_DMA_CCR6_PINC                               \ Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000080 constant DMA1_DMA_CCR6_MINC                               \ Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000300 constant DMA1_DMA_CCR6_PSIZE                              \ Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000c00 constant DMA1_DMA_CCR6_MSIZE                              \ Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00003000 constant DMA1_DMA_CCR6_PL                                 \ Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00004000 constant DMA1_DMA_CCR6_MEM2MEM                            \ Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 6 number of data to transfer register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_DMA_CNDTR6_NDT                              \ Number of data to transfer


\
\ @brief DMA channel 6 peripheral address register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CPAR6_PA                                \ Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR1= 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 6 memory address register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CMAR6_MA                                \ Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR1=10. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR1=11 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 7 configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMA1_DMA_CCR7_EN                                 \ Channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by1setting the CTEIFx bit of the DMA_IFCR register). Note: This bit is set and cleared by software.
$00000002 constant DMA1_DMA_CCR7_TCIE                               \ Transfer complete interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000004 constant DMA1_DMA_CCR7_HTIE                               \ Half transfer interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000008 constant DMA1_DMA_CCR7_TEIE                               \ Transfer error interrupt enable Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000010 constant DMA1_DMA_CCR7_DIR                                \ Data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000020 constant DMA1_DMA_CCR7_CIRC                               \ Circular mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000040 constant DMA1_DMA_CCR7_PINC                               \ Peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this bit identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000080 constant DMA1_DMA_CCR7_MINC                               \ Memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this bit identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bit identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000300 constant DMA1_DMA_CCR7_PSIZE                              \ Peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this bitfield identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000c00 constant DMA1_DMA_CCR7_MSIZE                              \ Memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this bitfield identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00003000 constant DMA1_DMA_CCR7_PL                                 \ Priority level Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00004000 constant DMA1_DMA_CCR7_MEM2MEM                            \ Memory-to-memory mode Note: This bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 7 number of data to transfer register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_DMA_CNDTR7_NDT                              \ Number of data to transfer


\
\ @brief DMA channel 7 peripheral address register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CPAR7_PA                                \ Peripheral address It contains the base address of the peripheral data register from/to which the data is read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE[1:0] = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this bitfield identifies the peripheral destination address if DIR1= 1 and the peripheral source address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 7 memory address register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_DMA_CMAR7_MA                                \ Peripheral address It contains the base address of the memory from/to which the data is read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE[1:0] = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this bitfield identifies the memory source address if DIR = 1 and the memory destination address if DIR1=10. In peripheral-to-peripheral mode, this bitfield identifies the peripheral source address if DIR1=11 and the peripheral destination address if DIR = 0. Note: This bitfield is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA register bank
\
$40020000 constant DMA1_DMA_ISR   \ offset: 0x00 : DMA interrupt status register
$40020004 constant DMA1_DMA_IFCR  \ offset: 0x04 : DMA interrupt flag clear register
$40020008 constant DMA1_DMA_CCR1  \ offset: 0x08 : DMA channel 1 configuration register
$4002000c constant DMA1_DMA_CNDTR1  \ offset: 0x0C : DMA channel 1 number of data to transfer register
$40020010 constant DMA1_DMA_CPAR1  \ offset: 0x10 : DMA channel 1 peripheral address register
$40020014 constant DMA1_DMA_CMAR1  \ offset: 0x14 : DMA channel 1 memory address register
$4002001c constant DMA1_DMA_CCR2  \ offset: 0x1C : DMA channel 2 configuration register
$40020020 constant DMA1_DMA_CNDTR2  \ offset: 0x20 : DMA channel 2 number of data to transfer register
$40020024 constant DMA1_DMA_CPAR2  \ offset: 0x24 : DMA channel 2 peripheral address register
$40020028 constant DMA1_DMA_CMAR2  \ offset: 0x28 : DMA channel 2 memory address register
$40020030 constant DMA1_DMA_CCR3  \ offset: 0x30 : DMA channel 3 configuration register
$40020034 constant DMA1_DMA_CNDTR3  \ offset: 0x34 : DMA channel 3 number of data to transfer register
$40020038 constant DMA1_DMA_CPAR3  \ offset: 0x38 : DMA channel 3 peripheral address register
$4002003c constant DMA1_DMA_CMAR3  \ offset: 0x3C : DMA channel 3 memory address register
$40020044 constant DMA1_DMA_CCR4  \ offset: 0x44 : DMA channel 4 configuration register
$40020048 constant DMA1_DMA_CNDTR4  \ offset: 0x48 : DMA channel 4 number of data to transfer register
$4002004c constant DMA1_DMA_CPAR4  \ offset: 0x4C : DMA channel 4 peripheral address register
$40020050 constant DMA1_DMA_CMAR4  \ offset: 0x50 : DMA channel 4 memory address register
$40020058 constant DMA1_DMA_CCR5  \ offset: 0x58 : DMA channel 5 configuration register
$4002005c constant DMA1_DMA_CNDTR5  \ offset: 0x5C : DMA channel 5 number of data to transfer register
$40020060 constant DMA1_DMA_CPAR5  \ offset: 0x60 : DMA channel 5 peripheral address register
$40020064 constant DMA1_DMA_CMAR5  \ offset: 0x64 : DMA channel 5 memory address register
$4002006c constant DMA1_DMA_CCR6  \ offset: 0x6C : DMA channel 6 configuration register
$40020070 constant DMA1_DMA_CNDTR6  \ offset: 0x70 : DMA channel 6 number of data to transfer register
$40020074 constant DMA1_DMA_CPAR6  \ offset: 0x74 : DMA channel 6 peripheral address register
$40020078 constant DMA1_DMA_CMAR6  \ offset: 0x78 : DMA channel 6 memory address register
$40020080 constant DMA1_DMA_CCR7  \ offset: 0x80 : DMA channel 7 configuration register
$40020084 constant DMA1_DMA_CNDTR7  \ offset: 0x84 : DMA channel 7 number of data to transfer register
$40020088 constant DMA1_DMA_CPAR7  \ offset: 0x88 : DMA channel 7 peripheral address register
$4002008c constant DMA1_DMA_CMAR7  \ offset: 0x8C : DMA channel 7 memory address register

