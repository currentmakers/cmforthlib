\
\ @file bdma1.fs
\ @brief Basic direct memory access controller
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

$00000001 constant BDMA1_ISR_GIF1                                   \ Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00000002 constant BDMA1_ISR_TCIF1                                  \ Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00000004 constant BDMA1_ISR_HTIF1                                  \ Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00000008 constant BDMA1_ISR_TEIF1                                  \ Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00000010 constant BDMA1_ISR_GIF2                                   \ Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00000020 constant BDMA1_ISR_TCIF2                                  \ Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00000040 constant BDMA1_ISR_HTIF2                                  \ Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00000080 constant BDMA1_ISR_TEIF2                                  \ Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00000100 constant BDMA1_ISR_GIF3                                   \ Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00000200 constant BDMA1_ISR_TCIF3                                  \ Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00000400 constant BDMA1_ISR_HTIF3                                  \ Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00000800 constant BDMA1_ISR_TEIF3                                  \ Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00001000 constant BDMA1_ISR_GIF4                                   \ Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00002000 constant BDMA1_ISR_TCIF4                                  \ Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00004000 constant BDMA1_ISR_HTIF4                                  \ Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00008000 constant BDMA1_ISR_TEIF4                                  \ Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00010000 constant BDMA1_ISR_GIF5                                   \ Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00020000 constant BDMA1_ISR_TCIF5                                  \ Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00040000 constant BDMA1_ISR_HTIF5                                  \ Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00080000 constant BDMA1_ISR_TEIF5                                  \ Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00100000 constant BDMA1_ISR_GIF6                                   \ Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00200000 constant BDMA1_ISR_TCIF6                                  \ Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00400000 constant BDMA1_ISR_HTIF6                                  \ Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$00800000 constant BDMA1_ISR_TEIF6                                  \ Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$01000000 constant BDMA1_ISR_GIF7                                   \ Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$02000000 constant BDMA1_ISR_TCIF7                                  \ Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$04000000 constant BDMA1_ISR_HTIF7                                  \ Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$08000000 constant BDMA1_ISR_TEIF7                                  \ Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$10000000 constant BDMA1_ISR_GIF8                                   \ Channel x global interrupt flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$20000000 constant BDMA1_ISR_TCIF8                                  \ Channel x transfer complete flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$40000000 constant BDMA1_ISR_HTIF8                                  \ Channel x half transfer flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.
$80000000 constant BDMA1_ISR_TEIF8                                  \ Channel x transfer error flag (x = 1..8) This bit is set by hardware. It is cleared by software writing 1 to the corresponding bit in the DMA_IFCR register.


\
\ @brief DMA interrupt flag clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant BDMA1_IFCR_CGIF1                                 \ Channel x global interrupt clear This bit is set and cleared by software.
$00000002 constant BDMA1_IFCR_CTCIF1                                \ Channel x transfer complete clear This bit is set and cleared by software.
$00000004 constant BDMA1_IFCR_CHTIF1                                \ Channel x half transfer clear This bit is set and cleared by software.
$00000008 constant BDMA1_IFCR_CTEIF1                                \ Channel x transfer error clear This bit is set and cleared by software.
$00000010 constant BDMA1_IFCR_CGIF2                                 \ Channel x global interrupt clear This bit is set and cleared by software.
$00000020 constant BDMA1_IFCR_CTCIF2                                \ Channel x transfer complete clear This bit is set and cleared by software.
$00000040 constant BDMA1_IFCR_CHTIF2                                \ Channel x half transfer clear This bit is set and cleared by software.
$00000080 constant BDMA1_IFCR_CTEIF2                                \ Channel x transfer error clear This bit is set and cleared by software.
$00000100 constant BDMA1_IFCR_CGIF3                                 \ Channel x global interrupt clear This bit is set and cleared by software.
$00000200 constant BDMA1_IFCR_CTCIF3                                \ Channel x transfer complete clear This bit is set and cleared by software.
$00000400 constant BDMA1_IFCR_CHTIF3                                \ Channel x half transfer clear This bit is set and cleared by software.
$00000800 constant BDMA1_IFCR_CTEIF3                                \ Channel x transfer error clear This bit is set and cleared by software.
$00001000 constant BDMA1_IFCR_CGIF4                                 \ Channel x global interrupt clear This bit is set and cleared by software.
$00002000 constant BDMA1_IFCR_CTCIF4                                \ Channel x transfer complete clear This bit is set and cleared by software.
$00004000 constant BDMA1_IFCR_CHTIF4                                \ Channel x half transfer clear This bit is set and cleared by software.
$00008000 constant BDMA1_IFCR_CTEIF4                                \ Channel x transfer error clear This bit is set and cleared by software.
$00010000 constant BDMA1_IFCR_CGIF5                                 \ Channel x global interrupt clear This bit is set and cleared by software.
$00020000 constant BDMA1_IFCR_CTCIF5                                \ Channel x transfer complete clear This bit is set and cleared by software.
$00040000 constant BDMA1_IFCR_CHTIF5                                \ Channel x half transfer clear This bit is set and cleared by software.
$00080000 constant BDMA1_IFCR_CTEIF5                                \ Channel x transfer error clear This bit is set and cleared by software.
$00100000 constant BDMA1_IFCR_CGIF6                                 \ Channel x global interrupt clear This bit is set and cleared by software.
$00200000 constant BDMA1_IFCR_CTCIF6                                \ Channel x transfer complete clear This bit is set and cleared by software.
$00400000 constant BDMA1_IFCR_CHTIF6                                \ Channel x half transfer clear This bit is set and cleared by software.
$00800000 constant BDMA1_IFCR_CTEIF6                                \ Channel x transfer error clear This bit is set and cleared by software.
$01000000 constant BDMA1_IFCR_CGIF7                                 \ Channel x global interrupt clear This bit is set and cleared by software.
$02000000 constant BDMA1_IFCR_CTCIF7                                \ Channel x transfer complete clear This bit is set and cleared by software.
$04000000 constant BDMA1_IFCR_CHTIF7                                \ Channel x half transfer clear This bit is set and cleared by software.
$08000000 constant BDMA1_IFCR_CTEIF7                                \ Channel x transfer error clear This bit is set and cleared by software.
$10000000 constant BDMA1_IFCR_CGIF8                                 \ Channel x global interrupt clear This bit is set and cleared by software.
$20000000 constant BDMA1_IFCR_CTCIF8                                \ Channel x transfer complete clear This bit is set and cleared by software.
$40000000 constant BDMA1_IFCR_CHTIF8                                \ Channel x half transfer clear This bit is set and cleared by software.
$80000000 constant BDMA1_IFCR_CTEIF8                                \ Channel x transfer error clear This bit is set and cleared by software.


\
\ @brief DMA channel x configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant BDMA1_CCR0_EN                                    \ Channel enable This bit is set and cleared by software.
$00000002 constant BDMA1_CCR0_TCIE                                  \ Transfer complete interrupt enable This bit is set and cleared by software.
$00000004 constant BDMA1_CCR0_HTIE                                  \ Half transfer interrupt enable This bit is set and cleared by software.
$00000008 constant BDMA1_CCR0_TEIE                                  \ Transfer error interrupt enable This bit is set and cleared by software.
$00000010 constant BDMA1_CCR0_DIR                                   \ Data transfer direction This bit is set and cleared by software.
$00000020 constant BDMA1_CCR0_CIRC                                  \ Circular mode This bit is set and cleared by software.
$00000040 constant BDMA1_CCR0_PINC                                  \ Peripheral increment mode This bit is set and cleared by software.
$00000080 constant BDMA1_CCR0_MINC                                  \ Memory increment mode This bit is set and cleared by software.
$00000300 constant BDMA1_CCR0_PSIZE                                 \ Peripheral size These bits are set and cleared by software.
$00000c00 constant BDMA1_CCR0_MSIZE                                 \ Memory size These bits are set and cleared by software.
$00003000 constant BDMA1_CCR0_PL                                    \ Channel priority level These bits are set and cleared by software.
$00004000 constant BDMA1_CCR0_MEM2MEM                               \ Memory to memory mode This bit is set and cleared by software.


\
\ @brief DMA channel x number of data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant BDMA1_CNDTR0_NDT                                 \ Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CPAR0_PA                                   \ Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CM0AR0_MA                                  \ Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled
\ Address offset: 0x18
\ Reset value: 0x00000000
\


\
\ @brief DMA channel x configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant BDMA1_CCR1_EN                                    \ Channel enable This bit is set and cleared by software.
$00000002 constant BDMA1_CCR1_TCIE                                  \ Transfer complete interrupt enable This bit is set and cleared by software.
$00000004 constant BDMA1_CCR1_HTIE                                  \ Half transfer interrupt enable This bit is set and cleared by software.
$00000008 constant BDMA1_CCR1_TEIE                                  \ Transfer error interrupt enable This bit is set and cleared by software.
$00000010 constant BDMA1_CCR1_DIR                                   \ Data transfer direction This bit is set and cleared by software.
$00000020 constant BDMA1_CCR1_CIRC                                  \ Circular mode This bit is set and cleared by software.
$00000040 constant BDMA1_CCR1_PINC                                  \ Peripheral increment mode This bit is set and cleared by software.
$00000080 constant BDMA1_CCR1_MINC                                  \ Memory increment mode This bit is set and cleared by software.
$00000300 constant BDMA1_CCR1_PSIZE                                 \ Peripheral size These bits are set and cleared by software.
$00000c00 constant BDMA1_CCR1_MSIZE                                 \ Memory size These bits are set and cleared by software.
$00003000 constant BDMA1_CCR1_PL                                    \ Channel priority level These bits are set and cleared by software.
$00004000 constant BDMA1_CCR1_MEM2MEM                               \ Memory to memory mode This bit is set and cleared by software.


\
\ @brief DMA channel x number of data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant BDMA1_CNDTR1_NDT                                 \ Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CPAR1_PA                                   \ Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CM0AR1_MA                                  \ Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief BDMA_CMAR1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\


\
\ @brief DMA channel x configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant BDMA1_CCR2_EN                                    \ Channel enable This bit is set and cleared by software.
$00000002 constant BDMA1_CCR2_TCIE                                  \ Transfer complete interrupt enable This bit is set and cleared by software.
$00000004 constant BDMA1_CCR2_HTIE                                  \ Half transfer interrupt enable This bit is set and cleared by software.
$00000008 constant BDMA1_CCR2_TEIE                                  \ Transfer error interrupt enable This bit is set and cleared by software.
$00000010 constant BDMA1_CCR2_DIR                                   \ Data transfer direction This bit is set and cleared by software.
$00000020 constant BDMA1_CCR2_CIRC                                  \ Circular mode This bit is set and cleared by software.
$00000040 constant BDMA1_CCR2_PINC                                  \ Peripheral increment mode This bit is set and cleared by software.
$00000080 constant BDMA1_CCR2_MINC                                  \ Memory increment mode This bit is set and cleared by software.
$00000300 constant BDMA1_CCR2_PSIZE                                 \ Peripheral size These bits are set and cleared by software.
$00000c00 constant BDMA1_CCR2_MSIZE                                 \ Memory size These bits are set and cleared by software.
$00003000 constant BDMA1_CCR2_PL                                    \ Channel priority level These bits are set and cleared by software.
$00004000 constant BDMA1_CCR2_MEM2MEM                               \ Memory to memory mode This bit is set and cleared by software.


\
\ @brief DMA channel x number of data register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant BDMA1_CNDTR2_NDT                                 \ Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CPAR2_PA                                   \ Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CM0AR2_MA                                  \ Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief BDMA_CM1AR2
\ Address offset: 0x40
\ Reset value: 0x00000000
\


\
\ @brief DMA channel x configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant BDMA1_CCR3_EN                                    \ Channel enable This bit is set and cleared by software.
$00000002 constant BDMA1_CCR3_TCIE                                  \ Transfer complete interrupt enable This bit is set and cleared by software.
$00000004 constant BDMA1_CCR3_HTIE                                  \ Half transfer interrupt enable This bit is set and cleared by software.
$00000008 constant BDMA1_CCR3_TEIE                                  \ Transfer error interrupt enable This bit is set and cleared by software.
$00000010 constant BDMA1_CCR3_DIR                                   \ Data transfer direction This bit is set and cleared by software.
$00000020 constant BDMA1_CCR3_CIRC                                  \ Circular mode This bit is set and cleared by software.
$00000040 constant BDMA1_CCR3_PINC                                  \ Peripheral increment mode This bit is set and cleared by software.
$00000080 constant BDMA1_CCR3_MINC                                  \ Memory increment mode This bit is set and cleared by software.
$00000300 constant BDMA1_CCR3_PSIZE                                 \ Peripheral size These bits are set and cleared by software.
$00000c00 constant BDMA1_CCR3_MSIZE                                 \ Memory size These bits are set and cleared by software.
$00003000 constant BDMA1_CCR3_PL                                    \ Channel priority level These bits are set and cleared by software.
$00004000 constant BDMA1_CCR3_MEM2MEM                               \ Memory to memory mode This bit is set and cleared by software.


\
\ @brief DMA channel x number of data register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant BDMA1_CNDTR3_NDT                                 \ Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CPAR3_PA                                   \ Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CM0AR3_MA                                  \ Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief BDMA_CMAR3
\ Address offset: 0x54
\ Reset value: 0x00000000
\


\
\ @brief DMA channel x configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant BDMA1_CCR4_EN                                    \ Channel enable This bit is set and cleared by software.
$00000002 constant BDMA1_CCR4_TCIE                                  \ Transfer complete interrupt enable This bit is set and cleared by software.
$00000004 constant BDMA1_CCR4_HTIE                                  \ Half transfer interrupt enable This bit is set and cleared by software.
$00000008 constant BDMA1_CCR4_TEIE                                  \ Transfer error interrupt enable This bit is set and cleared by software.
$00000010 constant BDMA1_CCR4_DIR                                   \ Data transfer direction This bit is set and cleared by software.
$00000020 constant BDMA1_CCR4_CIRC                                  \ Circular mode This bit is set and cleared by software.
$00000040 constant BDMA1_CCR4_PINC                                  \ Peripheral increment mode This bit is set and cleared by software.
$00000080 constant BDMA1_CCR4_MINC                                  \ Memory increment mode This bit is set and cleared by software.
$00000300 constant BDMA1_CCR4_PSIZE                                 \ Peripheral size These bits are set and cleared by software.
$00000c00 constant BDMA1_CCR4_MSIZE                                 \ Memory size These bits are set and cleared by software.
$00003000 constant BDMA1_CCR4_PL                                    \ Channel priority level These bits are set and cleared by software.
$00004000 constant BDMA1_CCR4_MEM2MEM                               \ Memory to memory mode This bit is set and cleared by software.


\
\ @brief DMA channel x number of data register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant BDMA1_CNDTR4_NDT                                 \ Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CPAR4_PA                                   \ Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CM0AR4_MA                                  \ Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief BDMA_CM1AR4
\ Address offset: 0x68
\ Reset value: 0x00000000
\


\
\ @brief DMA channel x configuration register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant BDMA1_CCR5_EN                                    \ Channel enable This bit is set and cleared by software.
$00000002 constant BDMA1_CCR5_TCIE                                  \ Transfer complete interrupt enable This bit is set and cleared by software.
$00000004 constant BDMA1_CCR5_HTIE                                  \ Half transfer interrupt enable This bit is set and cleared by software.
$00000008 constant BDMA1_CCR5_TEIE                                  \ Transfer error interrupt enable This bit is set and cleared by software.
$00000010 constant BDMA1_CCR5_DIR                                   \ Data transfer direction This bit is set and cleared by software.
$00000020 constant BDMA1_CCR5_CIRC                                  \ Circular mode This bit is set and cleared by software.
$00000040 constant BDMA1_CCR5_PINC                                  \ Peripheral increment mode This bit is set and cleared by software.
$00000080 constant BDMA1_CCR5_MINC                                  \ Memory increment mode This bit is set and cleared by software.
$00000300 constant BDMA1_CCR5_PSIZE                                 \ Peripheral size These bits are set and cleared by software.
$00000c00 constant BDMA1_CCR5_MSIZE                                 \ Memory size These bits are set and cleared by software.
$00003000 constant BDMA1_CCR5_PL                                    \ Channel priority level These bits are set and cleared by software.
$00004000 constant BDMA1_CCR5_MEM2MEM                               \ Memory to memory mode This bit is set and cleared by software.


\
\ @brief DMA channel x number of data register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant BDMA1_CNDTR5_NDT                                 \ Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CPAR5_PA                                   \ Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CM0AR5_MA                                  \ Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x7C
\ Reset value: 0x00000000
\


\
\ @brief DMA channel x configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant BDMA1_CCR6_EN                                    \ Channel enable This bit is set and cleared by software.
$00000002 constant BDMA1_CCR6_TCIE                                  \ Transfer complete interrupt enable This bit is set and cleared by software.
$00000004 constant BDMA1_CCR6_HTIE                                  \ Half transfer interrupt enable This bit is set and cleared by software.
$00000008 constant BDMA1_CCR6_TEIE                                  \ Transfer error interrupt enable This bit is set and cleared by software.
$00000010 constant BDMA1_CCR6_DIR                                   \ Data transfer direction This bit is set and cleared by software.
$00000020 constant BDMA1_CCR6_CIRC                                  \ Circular mode This bit is set and cleared by software.
$00000040 constant BDMA1_CCR6_PINC                                  \ Peripheral increment mode This bit is set and cleared by software.
$00000080 constant BDMA1_CCR6_MINC                                  \ Memory increment mode This bit is set and cleared by software.
$00000300 constant BDMA1_CCR6_PSIZE                                 \ Peripheral size These bits are set and cleared by software.
$00000c00 constant BDMA1_CCR6_MSIZE                                 \ Memory size These bits are set and cleared by software.
$00003000 constant BDMA1_CCR6_PL                                    \ Channel priority level These bits are set and cleared by software.
$00004000 constant BDMA1_CCR6_MEM2MEM                               \ Memory to memory mode This bit is set and cleared by software.


\
\ @brief DMA channel x number of data register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant BDMA1_CNDTR6_NDT                                 \ Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CPAR6_PA                                   \ Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CM0AR6_MA                                  \ Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x90
\ Reset value: 0x00000000
\


\
\ @brief DMA channel x configuration register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant BDMA1_CCR7_EN                                    \ Channel enable This bit is set and cleared by software.
$00000002 constant BDMA1_CCR7_TCIE                                  \ Transfer complete interrupt enable This bit is set and cleared by software.
$00000004 constant BDMA1_CCR7_HTIE                                  \ Half transfer interrupt enable This bit is set and cleared by software.
$00000008 constant BDMA1_CCR7_TEIE                                  \ Transfer error interrupt enable This bit is set and cleared by software.
$00000010 constant BDMA1_CCR7_DIR                                   \ Data transfer direction This bit is set and cleared by software.
$00000020 constant BDMA1_CCR7_CIRC                                  \ Circular mode This bit is set and cleared by software.
$00000040 constant BDMA1_CCR7_PINC                                  \ Peripheral increment mode This bit is set and cleared by software.
$00000080 constant BDMA1_CCR7_MINC                                  \ Memory increment mode This bit is set and cleared by software.
$00000300 constant BDMA1_CCR7_PSIZE                                 \ Peripheral size These bits are set and cleared by software.
$00000c00 constant BDMA1_CCR7_MSIZE                                 \ Memory size These bits are set and cleared by software.
$00003000 constant BDMA1_CCR7_PL                                    \ Channel priority level These bits are set and cleared by software.
$00004000 constant BDMA1_CCR7_MEM2MEM                               \ Memory to memory mode This bit is set and cleared by software.


\
\ @brief DMA channel x number of data register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant BDMA1_CNDTR7_NDT                                 \ Number of data to transfer Number of data to be transferred (0 up to 65535). This register can only be written when the channel is disabled. Once the channel is enabled, this register is read-only, indicating the remaining bytes to be transmitted. This register decrements after each DMA transfer. Once the transfer is completed, this register can either stay at zero or be reloaded automatically by the value previously programmed if the channel is configured in auto-reload mode. If this register is zero, no transaction can be served whether the channel is enabled or not.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CPAR7_PA                                   \ Peripheral address Base address of the peripheral data register from/to which the data will be read/written. When PSIZE is 01 (16-bit), the PA[0] bit is ignored. Access is automatically aligned to a half-word address. When PSIZE is 10 (32-bit), PA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant BDMA1_CM0AR7_MA                                  \ Memory address Base address of the memory area from/to which the data will be read/written. When MSIZE is 01 (16-bit), the MA[0] bit is ignored. Access is automatically aligned to a half-word address. When MSIZE is 10 (32-bit), MA[1:0] are ignored. Access is automatically aligned to a word address.


\
\ @brief This register must not be written when the channel is enabled.
\ Address offset: 0xA4
\ Reset value: 0x00000000
\


\
\ @brief Basic direct memory access controller
\
$48022c00 constant BDMA1_ISR      \ offset: 0x00 : DMA interrupt status register
$48022c04 constant BDMA1_IFCR     \ offset: 0x04 : DMA interrupt flag clear register
$48022c08 constant BDMA1_CCR0     \ offset: 0x08 : DMA channel x configuration register
$48022c0c constant BDMA1_CNDTR0   \ offset: 0x0C : DMA channel x number of data register
$48022c10 constant BDMA1_CPAR0    \ offset: 0x10 : This register must not be written when the channel is enabled.
$48022c14 constant BDMA1_CM0AR0   \ offset: 0x14 : This register must not be written when the channel is enabled.
$48022c18 constant BDMA1_CM1AR0   \ offset: 0x18 : This register must not be written when the channel is enabled
$48022c1c constant BDMA1_CCR1     \ offset: 0x1C : DMA channel x configuration register
$48022c20 constant BDMA1_CNDTR1   \ offset: 0x20 : DMA channel x number of data register
$48022c24 constant BDMA1_CPAR1    \ offset: 0x24 : This register must not be written when the channel is enabled.
$48022c28 constant BDMA1_CM0AR1   \ offset: 0x28 : This register must not be written when the channel is enabled.
$48022c2c constant BDMA1_CM1AR1   \ offset: 0x2C : BDMA_CMAR1
$48022c30 constant BDMA1_CCR2     \ offset: 0x30 : DMA channel x configuration register
$48022c34 constant BDMA1_CNDTR2   \ offset: 0x34 : DMA channel x number of data register
$48022c38 constant BDMA1_CPAR2    \ offset: 0x38 : This register must not be written when the channel is enabled.
$48022c3c constant BDMA1_CM0AR2   \ offset: 0x3C : This register must not be written when the channel is enabled.
$48022c40 constant BDMA1_CM1AR2   \ offset: 0x40 : BDMA_CM1AR2
$48022c44 constant BDMA1_CCR3     \ offset: 0x44 : DMA channel x configuration register
$48022c48 constant BDMA1_CNDTR3   \ offset: 0x48 : DMA channel x number of data register
$48022c4c constant BDMA1_CPAR3    \ offset: 0x4C : This register must not be written when the channel is enabled.
$48022c50 constant BDMA1_CM0AR3   \ offset: 0x50 : This register must not be written when the channel is enabled.
$48022c54 constant BDMA1_CM1AR3   \ offset: 0x54 : BDMA_CMAR3
$48022c58 constant BDMA1_CCR4     \ offset: 0x58 : DMA channel x configuration register
$48022c5c constant BDMA1_CNDTR4   \ offset: 0x5C : DMA channel x number of data register
$48022c60 constant BDMA1_CPAR4    \ offset: 0x60 : This register must not be written when the channel is enabled.
$48022c64 constant BDMA1_CM0AR4   \ offset: 0x64 : This register must not be written when the channel is enabled.
$48022c68 constant BDMA1_CM1AR4   \ offset: 0x68 : BDMA_CM1AR4
$48022c6c constant BDMA1_CCR5     \ offset: 0x6C : DMA channel x configuration register
$48022c70 constant BDMA1_CNDTR5   \ offset: 0x70 : DMA channel x number of data register
$48022c74 constant BDMA1_CPAR5    \ offset: 0x74 : This register must not be written when the channel is enabled.
$48022c78 constant BDMA1_CM0AR5   \ offset: 0x78 : This register must not be written when the channel is enabled.
$48022c7c constant BDMA1_CM1AR5   \ offset: 0x7C : This register must not be written when the channel is enabled.
$48022c80 constant BDMA1_CCR6     \ offset: 0x80 : DMA channel x configuration register
$48022c84 constant BDMA1_CNDTR6   \ offset: 0x84 : DMA channel x number of data register
$48022c88 constant BDMA1_CPAR6    \ offset: 0x88 : This register must not be written when the channel is enabled.
$48022c8c constant BDMA1_CM0AR6   \ offset: 0x8C : This register must not be written when the channel is enabled.
$48022c90 constant BDMA1_CM1AR6   \ offset: 0x90 : This register must not be written when the channel is enabled.
$48022c94 constant BDMA1_CCR7     \ offset: 0x94 : DMA channel x configuration register
$48022c98 constant BDMA1_CNDTR7   \ offset: 0x98 : DMA channel x number of data register
$48022c9c constant BDMA1_CPAR7    \ offset: 0x9C : This register must not be written when the channel is enabled.
$48022ca0 constant BDMA1_CM0AR7   \ offset: 0xA0 : This register must not be written when the channel is enabled.
$48022ca4 constant BDMA1_CM1AR7   \ offset: 0xA4 : This register must not be written when the channel is enabled.

