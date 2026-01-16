\
\ @file dma2.fs
\ @brief Direct memory access controller
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

$00000001 constant DMA2_DMA_ISR_GIF1                                \ global interrupt flag for channel 1
$00000002 constant DMA2_DMA_ISR_TCIF1                               \ transfer complete (TC) flag for channel 1
$00000004 constant DMA2_DMA_ISR_HTIF1                               \ half transfer (HT) flag for channel 1
$00000008 constant DMA2_DMA_ISR_TEIF1                               \ transfer error (TE) flag for channel 1
$00000010 constant DMA2_DMA_ISR_GIF2                                \ global interrupt flag for channel 2
$00000020 constant DMA2_DMA_ISR_TCIF2                               \ transfer complete (TC) flag for channel 2
$00000040 constant DMA2_DMA_ISR_HTIF2                               \ half transfer (HT) flag for channel 2
$00000080 constant DMA2_DMA_ISR_TEIF2                               \ transfer error (TE) flag for channel 2
$00000100 constant DMA2_DMA_ISR_GIF3                                \ global interrupt flag for channel 3
$00000200 constant DMA2_DMA_ISR_TCIF3                               \ transfer complete (TC) flag for channel 3
$00000400 constant DMA2_DMA_ISR_HTIF3                               \ half transfer (HT) flag for channel 3
$00000800 constant DMA2_DMA_ISR_TEIF3                               \ transfer error (TE) flag for channel 3
$00001000 constant DMA2_DMA_ISR_GIF4                                \ global interrupt flag for channel 4
$00002000 constant DMA2_DMA_ISR_TCIF4                               \ transfer complete (TC) flag for channel 4
$00004000 constant DMA2_DMA_ISR_HTIF4                               \ half transfer (HT) flag for channel 4
$00008000 constant DMA2_DMA_ISR_TEIF4                               \ transfer error (TE) flag for channel 4
$00010000 constant DMA2_DMA_ISR_GIF5                                \ global interrupt flag for channel 5
$00020000 constant DMA2_DMA_ISR_TCIF5                               \ transfer complete (TC) flag for channel 5
$00040000 constant DMA2_DMA_ISR_HTIF5                               \ half transfer (HT) flag for channel 5
$00080000 constant DMA2_DMA_ISR_TEIF5                               \ transfer error (TE) flag for channel 5
$00100000 constant DMA2_DMA_ISR_GIF6                                \ global interrupt flag for channel 6
$00200000 constant DMA2_DMA_ISR_TCIF6                               \ transfer complete (TC) flag for channel 6
$00400000 constant DMA2_DMA_ISR_HTIF6                               \ half transfer (HT) flag for channel 6
$00800000 constant DMA2_DMA_ISR_TEIF6                               \ transfer error (TE) flag for channel 6
$01000000 constant DMA2_DMA_ISR_GIF7                                \ global interrupt flag for channel 7
$02000000 constant DMA2_DMA_ISR_TCIF7                               \ transfer complete (TC) flag for channel 7
$04000000 constant DMA2_DMA_ISR_HTIF7                               \ half transfer (HT) flag for channel 7
$08000000 constant DMA2_DMA_ISR_TEIF7                               \ transfer error (TE) flag for channel 7


\
\ @brief DMA interrupt flag clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_IFCR_CGIF1                              \ global interrupt flag clear for channel 1
$00000002 constant DMA2_DMA_IFCR_CTCIF1                             \ transfer complete flag clear for channel 1
$00000004 constant DMA2_DMA_IFCR_CHTIF1                             \ half transfer flag clear for channel 1
$00000008 constant DMA2_DMA_IFCR_CTEIF1                             \ transfer error flag clear for channel 1
$00000010 constant DMA2_DMA_IFCR_CGIF2                              \ global interrupt flag clear for channel 2
$00000020 constant DMA2_DMA_IFCR_CTCIF2                             \ transfer complete flag clear for channel 2
$00000040 constant DMA2_DMA_IFCR_CHTIF2                             \ half transfer flag clear for channel 2
$00000080 constant DMA2_DMA_IFCR_CTEIF2                             \ transfer error flag clear for channel 2
$00000100 constant DMA2_DMA_IFCR_CGIF3                              \ global interrupt flag clear for channel 3
$00000200 constant DMA2_DMA_IFCR_CTCIF3                             \ transfer complete flag clear for channel 3
$00000400 constant DMA2_DMA_IFCR_CHTIF3                             \ half transfer flag clear for channel 3
$00000800 constant DMA2_DMA_IFCR_CTEIF3                             \ transfer error flag clear for channel 3
$00001000 constant DMA2_DMA_IFCR_CGIF4                              \ global interrupt flag clear for channel 4
$00002000 constant DMA2_DMA_IFCR_CTCIF4                             \ transfer complete flag clear for channel 4
$00004000 constant DMA2_DMA_IFCR_CHTIF4                             \ half transfer flag clear for channel 4
$00008000 constant DMA2_DMA_IFCR_CTEIF4                             \ transfer error flag clear for channel 4
$00010000 constant DMA2_DMA_IFCR_CGIF5                              \ global interrupt flag clear for channel 5
$00020000 constant DMA2_DMA_IFCR_CTCIF5                             \ transfer complete flag clear for channel 5
$00040000 constant DMA2_DMA_IFCR_CHTIF5                             \ half transfer flag clear for channel 5
$00080000 constant DMA2_DMA_IFCR_CTEIF5                             \ transfer error flag clear for channel 5
$00100000 constant DMA2_DMA_IFCR_CGIF6                              \ global interrupt flag clear for channel 6
$00200000 constant DMA2_DMA_IFCR_CTCIF6                             \ transfer complete flag clear for channel 6
$00400000 constant DMA2_DMA_IFCR_CHTIF6                             \ half transfer flag clear for channel 6
$00800000 constant DMA2_DMA_IFCR_CTEIF6                             \ transfer error flag clear for channel 6
$01000000 constant DMA2_DMA_IFCR_CGIF7                              \ global interrupt flag clear for channel 7
$02000000 constant DMA2_DMA_IFCR_CTCIF7                             \ transfer complete flag clear for channel 7
$04000000 constant DMA2_DMA_IFCR_CHTIF7                             \ half transfer flag clear for channel 7
$08000000 constant DMA2_DMA_IFCR_CTEIF7                             \ transfer error flag clear for channel 7


\
\ @brief DMA channel 1 configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_CCR1_EN                                 \ channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
$00000002 constant DMA2_DMA_CCR1_TCIE                               \ transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000004 constant DMA2_DMA_CCR1_HTIE                               \ half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000008 constant DMA2_DMA_CCR1_TEIE                               \ transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000010 constant DMA2_DMA_CCR1_DIR                                \ data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000020 constant DMA2_DMA_CCR1_CIRC                               \ circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000040 constant DMA2_DMA_CCR1_PINC                               \ peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000080 constant DMA2_DMA_CCR1_MINC                               \ memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000300 constant DMA2_DMA_CCR1_PSIZE                              \ peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000c00 constant DMA2_DMA_CCR1_MSIZE                              \ memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00003000 constant DMA2_DMA_CCR1_PL                                 \ priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00004000 constant DMA2_DMA_CCR1_MEM2MEM                            \ memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 1 number of data to transfer register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_CNDTR1_NDT                              \ number of data to transfer (0 to 216-1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA 'read followed by write' transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC=0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC=1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 1 peripheral address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CPAR1_PA                                \ peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0]=01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE=10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR=1 and the memory source address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR=1 and the peripheral source address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 1 memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CMAR1_MA                                \ peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0]=01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE=10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR=1 and the memory destination address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR=1 and the peripheral destination address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 2 configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_CCR2_EN                                 \ channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
$00000002 constant DMA2_DMA_CCR2_TCIE                               \ transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000004 constant DMA2_DMA_CCR2_HTIE                               \ half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000008 constant DMA2_DMA_CCR2_TEIE                               \ transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000010 constant DMA2_DMA_CCR2_DIR                                \ data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000020 constant DMA2_DMA_CCR2_CIRC                               \ circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000040 constant DMA2_DMA_CCR2_PINC                               \ peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000080 constant DMA2_DMA_CCR2_MINC                               \ memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000300 constant DMA2_DMA_CCR2_PSIZE                              \ peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000c00 constant DMA2_DMA_CCR2_MSIZE                              \ memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00003000 constant DMA2_DMA_CCR2_PL                                 \ priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00004000 constant DMA2_DMA_CCR2_MEM2MEM                            \ memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 2 number of data to transfer register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_CNDTR2_NDT                              \ number of data to transfer (0 to 216-1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA 'read followed by write' transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC=0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC=1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 2 peripheral address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CPAR2_PA                                \ peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0]=01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE=10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR=1 and the memory source address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR=1 and the peripheral source address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 2 memory address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CMAR2_MA                                \ peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0]=01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE=10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR=1 and the memory destination address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR=1 and the peripheral destination address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 3 configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_CCR3_EN                                 \ channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
$00000002 constant DMA2_DMA_CCR3_TCIE                               \ transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000004 constant DMA2_DMA_CCR3_HTIE                               \ half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000008 constant DMA2_DMA_CCR3_TEIE                               \ transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000010 constant DMA2_DMA_CCR3_DIR                                \ data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000020 constant DMA2_DMA_CCR3_CIRC                               \ circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000040 constant DMA2_DMA_CCR3_PINC                               \ peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000080 constant DMA2_DMA_CCR3_MINC                               \ memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000300 constant DMA2_DMA_CCR3_PSIZE                              \ peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000c00 constant DMA2_DMA_CCR3_MSIZE                              \ memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00003000 constant DMA2_DMA_CCR3_PL                                 \ priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00004000 constant DMA2_DMA_CCR3_MEM2MEM                            \ memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 3 number of data to transfer register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_CNDTR3_NDT                              \ number of data to transfer (0 to 216-1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA 'read followed by write' transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC=0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC=1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 3 peripheral address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CPAR3_PA                                \ peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0]=01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE=10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR=1 and the memory source address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR=1 and the peripheral source address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 3 memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CMAR3_MA                                \ peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0]=01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE=10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR=1 and the memory destination address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR=1 and the peripheral destination address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 4 configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_CCR4_EN                                 \ channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
$00000002 constant DMA2_DMA_CCR4_TCIE                               \ transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000004 constant DMA2_DMA_CCR4_HTIE                               \ half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000008 constant DMA2_DMA_CCR4_TEIE                               \ transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000010 constant DMA2_DMA_CCR4_DIR                                \ data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000020 constant DMA2_DMA_CCR4_CIRC                               \ circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000040 constant DMA2_DMA_CCR4_PINC                               \ peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000080 constant DMA2_DMA_CCR4_MINC                               \ memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000300 constant DMA2_DMA_CCR4_PSIZE                              \ peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000c00 constant DMA2_DMA_CCR4_MSIZE                              \ memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00003000 constant DMA2_DMA_CCR4_PL                                 \ priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00004000 constant DMA2_DMA_CCR4_MEM2MEM                            \ memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 4 number of data to transfer register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_CNDTR4_NDT                              \ number of data to transfer (0 to 216-1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA 'read followed by write' transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC=0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC=1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 4 peripheral address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CPAR4_PA                                \ peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0]=01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE=10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR=1 and the memory source address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR=1 and the peripheral source address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 4 memory address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CMAR4_MA                                \ peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0]=01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE=10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR=1 and the memory destination address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR=1 and the peripheral destination address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 5 configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_CCR5_EN                                 \ channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
$00000002 constant DMA2_DMA_CCR5_TCIE                               \ transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000004 constant DMA2_DMA_CCR5_HTIE                               \ half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000008 constant DMA2_DMA_CCR5_TEIE                               \ transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000010 constant DMA2_DMA_CCR5_DIR                                \ data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000020 constant DMA2_DMA_CCR5_CIRC                               \ circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000040 constant DMA2_DMA_CCR5_PINC                               \ peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000080 constant DMA2_DMA_CCR5_MINC                               \ memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000300 constant DMA2_DMA_CCR5_PSIZE                              \ peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000c00 constant DMA2_DMA_CCR5_MSIZE                              \ memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00003000 constant DMA2_DMA_CCR5_PL                                 \ priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00004000 constant DMA2_DMA_CCR5_MEM2MEM                            \ memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 5 number of data to transfer register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_CNDTR5_NDT                              \ number of data to transfer (0 to 216-1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA 'read followed by write' transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC=0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC=1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 5 peripheral address register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CPAR5_PA                                \ peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0]=01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE=10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR=1 and the memory source address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR=1 and the peripheral source address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 5 memory address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CMAR5_MA                                \ peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0]=01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE=10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR=1 and the memory destination address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR=1 and the peripheral destination address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 6 configuration register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_CCR6_EN                                 \ channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
$00000002 constant DMA2_DMA_CCR6_TCIE                               \ transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000004 constant DMA2_DMA_CCR6_HTIE                               \ half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000008 constant DMA2_DMA_CCR6_TEIE                               \ transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000010 constant DMA2_DMA_CCR6_DIR                                \ data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000020 constant DMA2_DMA_CCR6_CIRC                               \ circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000040 constant DMA2_DMA_CCR6_PINC                               \ peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000080 constant DMA2_DMA_CCR6_MINC                               \ memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000300 constant DMA2_DMA_CCR6_PSIZE                              \ peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000c00 constant DMA2_DMA_CCR6_MSIZE                              \ memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00003000 constant DMA2_DMA_CCR6_PL                                 \ priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00004000 constant DMA2_DMA_CCR6_MEM2MEM                            \ memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 6 number of data to transfer register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_CNDTR6_NDT                              \ number of data to transfer (0 to 216-1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA 'read followed by write' transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC=0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC=1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 6 peripheral address register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CPAR6_PA                                \ peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0]=01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE=10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR=1 and the memory source address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR=1 and the peripheral source address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 6 memory address register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CMAR6_MA                                \ peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0]=01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE=10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR=1 and the memory destination address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR=1 and the peripheral destination address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 7 configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_CCR7_EN                                 \ channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
$00000002 constant DMA2_DMA_CCR7_TCIE                               \ transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000004 constant DMA2_DMA_CCR7_HTIE                               \ half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000008 constant DMA2_DMA_CCR7_TEIE                               \ transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000010 constant DMA2_DMA_CCR7_DIR                                \ data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000020 constant DMA2_DMA_CCR7_CIRC                               \ circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).
$00000040 constant DMA2_DMA_CCR7_PINC                               \ peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000080 constant DMA2_DMA_CCR7_MINC                               \ memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000300 constant DMA2_DMA_CCR7_PSIZE                              \ peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR=1 and the memory source if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR=1 and the peripheral source if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00000c00 constant DMA2_DMA_CCR7_MSIZE                              \ memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR=1 and the memory destination if DIR=0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR=1 and the peripheral destination if DIR=0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00003000 constant DMA2_DMA_CCR7_PL                                 \ priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).
$00004000 constant DMA2_DMA_CCR7_MEM2MEM                            \ memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 7 number of data to transfer register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_CNDTR7_NDT                              \ number of data to transfer (0 to 216-1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA 'read followed by write' transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC=0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC=1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 7 peripheral address register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CPAR7_PA                                \ peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0]=01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE=10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR=1 and the memory source address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR=1 and the peripheral source address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief DMA channel 7 memory address register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_CMAR7_MA                                \ peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0]=01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE=10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR=1 and the memory destination address if DIR=0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR=1 and the peripheral destination address if DIR=0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN=1).


\
\ @brief Direct memory access controller
\
$40020400 constant DMA2_DMA_ISR   \ offset: 0x00 : DMA interrupt status register
$40020404 constant DMA2_DMA_IFCR  \ offset: 0x04 : DMA interrupt flag clear register
$40020408 constant DMA2_DMA_CCR1  \ offset: 0x08 : DMA channel 1 configuration register
$4002040c constant DMA2_DMA_CNDTR1  \ offset: 0x0C : DMA channel 1 number of data to transfer register
$40020410 constant DMA2_DMA_CPAR1  \ offset: 0x10 : DMA channel 1 peripheral address register
$40020414 constant DMA2_DMA_CMAR1  \ offset: 0x14 : DMA channel 1 memory address register
$4002041c constant DMA2_DMA_CCR2  \ offset: 0x1C : DMA channel 2 configuration register
$40020420 constant DMA2_DMA_CNDTR2  \ offset: 0x20 : DMA channel 2 number of data to transfer register
$40020424 constant DMA2_DMA_CPAR2  \ offset: 0x24 : DMA channel 2 peripheral address register
$40020428 constant DMA2_DMA_CMAR2  \ offset: 0x28 : DMA channel 2 memory address register
$40020430 constant DMA2_DMA_CCR3  \ offset: 0x30 : DMA channel 3 configuration register
$40020434 constant DMA2_DMA_CNDTR3  \ offset: 0x34 : DMA channel 3 number of data to transfer register
$40020438 constant DMA2_DMA_CPAR3  \ offset: 0x38 : DMA channel 3 peripheral address register
$4002043c constant DMA2_DMA_CMAR3  \ offset: 0x3C : DMA channel 3 memory address register
$40020444 constant DMA2_DMA_CCR4  \ offset: 0x44 : DMA channel 4 configuration register
$40020448 constant DMA2_DMA_CNDTR4  \ offset: 0x48 : DMA channel 4 number of data to transfer register
$4002044c constant DMA2_DMA_CPAR4  \ offset: 0x4C : DMA channel 4 peripheral address register
$40020450 constant DMA2_DMA_CMAR4  \ offset: 0x50 : DMA channel 4 memory address register
$40020458 constant DMA2_DMA_CCR5  \ offset: 0x58 : DMA channel 5 configuration register
$4002045c constant DMA2_DMA_CNDTR5  \ offset: 0x5C : DMA channel 5 number of data to transfer register
$40020460 constant DMA2_DMA_CPAR5  \ offset: 0x60 : DMA channel 5 peripheral address register
$40020464 constant DMA2_DMA_CMAR5  \ offset: 0x64 : DMA channel 5 memory address register
$4002046c constant DMA2_DMA_CCR6  \ offset: 0x6C : DMA channel 6 configuration register
$40020470 constant DMA2_DMA_CNDTR6  \ offset: 0x70 : DMA channel 6 number of data to transfer register
$40020474 constant DMA2_DMA_CPAR6  \ offset: 0x74 : DMA channel 6 peripheral address register
$40020478 constant DMA2_DMA_CMAR6  \ offset: 0x78 : DMA channel 6 memory address register
$40020480 constant DMA2_DMA_CCR7  \ offset: 0x80 : DMA channel 7 configuration register
$40020484 constant DMA2_DMA_CNDTR7  \ offset: 0x84 : DMA channel 7 number of data to transfer register
$40020488 constant DMA2_DMA_CPAR7  \ offset: 0x88 : DMA channel 7 peripheral address register
$4002048c constant DMA2_DMA_CMAR7  \ offset: 0x8C : DMA channel 7 memory address register

