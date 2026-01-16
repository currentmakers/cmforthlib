\
\ @file dma.fs
\ @brief DMA controller
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

$00000001 constant DMA_DMA_ISR_GIF1                                 \ global interrupt flag for channel 1
$00000002 constant DMA_DMA_ISR_TCIF1                                \ transfer complete (TC) flag for channel 1
$00000004 constant DMA_DMA_ISR_HTIF1                                \ half transfer (HT) flag for channel 1
$00000008 constant DMA_DMA_ISR_TEIF1                                \ transfer error (TE) flag for channel 1
$00000010 constant DMA_DMA_ISR_GIF2                                 \ global interrupt flag for channel 2
$00000020 constant DMA_DMA_ISR_TCIF2                                \ transfer complete (TC) flag for channel 2
$00000040 constant DMA_DMA_ISR_HTIF2                                \ half transfer (HT) flag for channel 2
$00000080 constant DMA_DMA_ISR_TEIF2                                \ transfer error (TE) flag for channel 2
$00000100 constant DMA_DMA_ISR_GIF3                                 \ global interrupt flag for channel 3
$00000200 constant DMA_DMA_ISR_TCIF3                                \ transfer complete (TC) flag for channel 3
$00000400 constant DMA_DMA_ISR_HTIF3                                \ half transfer (HT) flag for channel 3
$00000800 constant DMA_DMA_ISR_TEIF3                                \ transfer error (TE) flag for channel 3


\
\ @brief DMA interrupt flag clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_IFCR_CGIF1                               \ global interrupt flag clear for channel 1
$00000002 constant DMA_DMA_IFCR_CTCIF1                              \ transfer complete flag clear for channel 1
$00000004 constant DMA_DMA_IFCR_CHTIF1                              \ half transfer flag clear for channel 1
$00000008 constant DMA_DMA_IFCR_CTEIF1                              \ transfer error flag clear for channel 1
$00000010 constant DMA_DMA_IFCR_CGIF2                               \ global interrupt flag clear for channel 2
$00000020 constant DMA_DMA_IFCR_CTCIF2                              \ transfer complete flag clear for channel 2
$00000040 constant DMA_DMA_IFCR_CHTIF2                              \ half transfer flag clear for channel 2
$00000080 constant DMA_DMA_IFCR_CTEIF2                              \ transfer error flag clear for channel 2
$00000100 constant DMA_DMA_IFCR_CGIF3                               \ global interrupt flag clear for channel 3
$00000200 constant DMA_DMA_IFCR_CTCIF3                              \ transfer complete flag clear for channel 3
$00000400 constant DMA_DMA_IFCR_CHTIF3                              \ half transfer flag clear for channel 3
$00000800 constant DMA_DMA_IFCR_CTEIF3                              \ transfer error flag clear for channel 3


\
\ @brief DMA channel 1 configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_CCR1_EN                                  \ channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
$00000002 constant DMA_DMA_CCR1_TCIE                                \ transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000004 constant DMA_DMA_CCR1_HTIE                                \ half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000008 constant DMA_DMA_CCR1_TEIE                                \ transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000010 constant DMA_DMA_CCR1_DIR                                 \ data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000020 constant DMA_DMA_CCR1_CIRC                                \ circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000040 constant DMA_DMA_CCR1_PINC                                \ peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000080 constant DMA_DMA_CCR1_MINC                                \ memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000300 constant DMA_DMA_CCR1_PSIZE                               \ peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000c00 constant DMA_DMA_CCR1_MSIZE                               \ memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00003000 constant DMA_DMA_CCR1_PL                                  \ priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00004000 constant DMA_DMA_CCR1_MEM2MEM                             \ memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 1 number of data to transfer register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DMA_DMA_CNDTR1_NDT                               \ number of data to transfer (0 to 216 - 1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA read followed by write transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC = 0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC = 1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 1 peripheral address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CPAR1_PA                                 \ peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR = 1 and the peripheral source address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 1 memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CMAR1_MA                                 \ peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR = 1 and the memory destination address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR = 1 and the peripheral destination address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 2 configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_CCR2_EN                                  \ channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
$00000002 constant DMA_DMA_CCR2_TCIE                                \ transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000004 constant DMA_DMA_CCR2_HTIE                                \ half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000008 constant DMA_DMA_CCR2_TEIE                                \ transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000010 constant DMA_DMA_CCR2_DIR                                 \ data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000020 constant DMA_DMA_CCR2_CIRC                                \ circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000040 constant DMA_DMA_CCR2_PINC                                \ peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000080 constant DMA_DMA_CCR2_MINC                                \ memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000300 constant DMA_DMA_CCR2_PSIZE                               \ peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000c00 constant DMA_DMA_CCR2_MSIZE                               \ memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00003000 constant DMA_DMA_CCR2_PL                                  \ priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00004000 constant DMA_DMA_CCR2_MEM2MEM                             \ memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 2 number of data to transfer register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant DMA_DMA_CNDTR2_NDT                               \ number of data to transfer (0 to 216 - 1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA read followed by write transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC = 0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC = 1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 2 peripheral address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CPAR2_PA                                 \ peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR = 1 and the peripheral source address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 2 memory address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CMAR2_MA                                 \ peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR = 1 and the memory destination address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR = 1 and the peripheral destination address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 3 configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant DMA_DMA_CCR3_EN                                  \ channel enable When a channel transfer error occurs, this bit is cleared by hardware. It can not be set again by software (channel x re-activated) until the TEIFx bit of the DMA_ISR register is cleared (by setting the CTEIFx bit of the DMA_IFCR register). Note: this bit is set and cleared by software.
$00000002 constant DMA_DMA_CCR3_TCIE                                \ transfer complete interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000004 constant DMA_DMA_CCR3_HTIE                                \ half transfer interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000008 constant DMA_DMA_CCR3_TEIE                                \ transfer error interrupt enable Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000010 constant DMA_DMA_CCR3_DIR                                 \ data transfer direction This bit must be set only in memory-to-peripheral and peripheral-to-memory modes. Source attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Destination attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Destination attributes are defined by PSIZE and PINC, plus the DMA_CPARx register. This is still valid in a memory-to-memory mode. Source attributes are defined by MSIZE and MINC, plus the DMA_CMARx register. This is still valid in a peripheral-to-peripheral mode. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000020 constant DMA_DMA_CCR3_CIRC                                \ circular mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).
$00000040 constant DMA_DMA_CCR3_PINC                                \ peripheral increment mode Defines the increment mode for each DMA transfer to the identified peripheral. n memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000080 constant DMA_DMA_CCR3_MINC                                \ memory increment mode Defines the increment mode for each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000300 constant DMA_DMA_CCR3_PSIZE                               \ peripheral size Defines the data size of each DMA transfer to the identified peripheral. In memory-to-memory mode, this field identifies the memory destination if DIR = 1 and the memory source if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral destination if DIR = 1 and the peripheral source if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00000c00 constant DMA_DMA_CCR3_MSIZE                               \ memory size Defines the data size of each DMA transfer to the identified memory. In memory-to-memory mode, this field identifies the memory source if DIR = 1 and the memory destination if DIR = 0. In peripheral-to-peripheral mode, this field identifies the peripheral source if DIR = 1 and the peripheral destination if DIR = 0. Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00003000 constant DMA_DMA_CCR3_PL                                  \ priority level Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).
$00004000 constant DMA_DMA_CCR3_MEM2MEM                             \ memory-to-memory mode Note: this bit is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 3 number of data to transfer register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant DMA_DMA_CNDTR3_NDT                               \ number of data to transfer (0 to 216 - 1) This field is updated by hardware when the channel is enabled: It is decremented after each single DMA read followed by write transfer, indicating the remaining amount of data items to transfer. It is kept at zero when the programmed amount of data to transfer is reached, if the channel is not in circular mode (CIRC = 0 in the DMA_CCRx register). It is reloaded automatically by the previously programmed value, when the transfer is complete, if the channel is in circular mode (CIRC = 1). If this field is zero, no transfer can be served whatever the channel status (enabled or not). Note: this field is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 3 peripheral address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CPAR3_PA                                 \ peripheral address It contains the base address of the peripheral data register from/to which the data will be read/written. When PSIZE[1:0] = 01 (16 bits), bit 0 of PA[31:0] is ignored. Access is automatically aligned to a half-word address. When PSIZE = 10 (32 bits), bits 1 and 0 of PA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory destination address if DIR = 1 and the memory source address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral destination address DIR = 1 and the peripheral source address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA channel 3 memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant DMA_DMA_CMAR3_MA                                 \ peripheral address It contains the base address of the memory from/to which the data will be read/written. When MSIZE[1:0] = 01 (16 bits), bit 0 of MA[31:0] is ignored. Access is automatically aligned to a half-word address. When MSIZE = 10 (32 bits), bits 1 and 0 of MA[31:0] are ignored. Access is automatically aligned to a word address. In memory-to-memory mode, this register identifies the memory source address if DIR = 1 and the memory destination address if DIR = 0. In peripheral-to-peripheral mode, this register identifies the peripheral source address DIR = 1 and the peripheral destination address if DIR = 0. Note: this register is set and cleared by software. It must not be written when the channel is enabled (EN = 1). It is not read-only when the channel is enabled (EN = 1).


\
\ @brief DMA controller
\
$40020000 constant DMA_DMA_ISR    \ offset: 0x00 : DMA interrupt status register
$40020004 constant DMA_DMA_IFCR   \ offset: 0x04 : DMA interrupt flag clear register
$40020008 constant DMA_DMA_CCR1   \ offset: 0x08 : DMA channel 1 configuration register
$4002000c constant DMA_DMA_CNDTR1  \ offset: 0x0C : DMA channel 1 number of data to transfer register
$40020010 constant DMA_DMA_CPAR1  \ offset: 0x10 : DMA channel 1 peripheral address register
$40020014 constant DMA_DMA_CMAR1  \ offset: 0x14 : DMA channel 1 memory address register
$4002001c constant DMA_DMA_CCR2   \ offset: 0x1C : DMA channel 2 configuration register
$40020020 constant DMA_DMA_CNDTR2  \ offset: 0x20 : DMA channel 2 number of data to transfer register
$40020024 constant DMA_DMA_CPAR2  \ offset: 0x24 : DMA channel 2 peripheral address register
$40020028 constant DMA_DMA_CMAR2  \ offset: 0x28 : DMA channel 2 memory address register
$40020030 constant DMA_DMA_CCR3   \ offset: 0x30 : DMA channel 3 configuration register
$40020034 constant DMA_DMA_CNDTR3  \ offset: 0x34 : DMA channel 3 number of data to transfer register
$40020038 constant DMA_DMA_CPAR3  \ offset: 0x38 : DMA channel 3 peripheral address register
$4002003c constant DMA_DMA_CMAR3  \ offset: 0x3C : DMA channel 3 memory address register

