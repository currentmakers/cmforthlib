\
\ @file sec_dma1.fs
\ @brief Direct memory access controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief interrupt status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA1_ISR_GIF1                                \ Channel x global interrupt flag (x = 1 ..7)
$00000002 constant SEC_DMA1_ISR_TCIF1                               \ Channel x transfer complete flag (x = 1 ..7)
$00000004 constant SEC_DMA1_ISR_HTIF1                               \ Channel x half transfer flag (x = 1 ..7)
$00000008 constant SEC_DMA1_ISR_TEIF1                               \ Channel x transfer error flag (x = 1 ..7)
$00000010 constant SEC_DMA1_ISR_GIF2                                \ Channel x global interrupt flag (x = 1 ..7)
$00000020 constant SEC_DMA1_ISR_TCIF2                               \ Channel x transfer complete flag (x = 1 ..7)
$00000040 constant SEC_DMA1_ISR_HTIF2                               \ Channel x half transfer flag (x = 1 ..7)
$00000080 constant SEC_DMA1_ISR_TEIF2                               \ Channel x transfer error flag (x = 1 ..7)
$00000100 constant SEC_DMA1_ISR_GIF3                                \ Channel x global interrupt flag (x = 1 ..7)
$00000200 constant SEC_DMA1_ISR_TCIF3                               \ Channel x transfer complete flag (x = 1 ..7)
$00000400 constant SEC_DMA1_ISR_HTIF3                               \ Channel x half transfer flag (x = 1 ..7)
$00000800 constant SEC_DMA1_ISR_TEIF3                               \ Channel x transfer error flag (x = 1 ..7)
$00001000 constant SEC_DMA1_ISR_GIF4                                \ Channel x global interrupt flag (x = 1 ..7)
$00002000 constant SEC_DMA1_ISR_TCIF4                               \ Channel x transfer complete flag (x = 1 ..7)
$00004000 constant SEC_DMA1_ISR_HTIF4                               \ Channel x half transfer flag (x = 1 ..7)
$00008000 constant SEC_DMA1_ISR_TEIF4                               \ Channel x transfer error flag (x = 1 ..7)
$00010000 constant SEC_DMA1_ISR_GIF5                                \ Channel x global interrupt flag (x = 1 ..7)
$00020000 constant SEC_DMA1_ISR_TCIF5                               \ Channel x transfer complete flag (x = 1 ..7)
$00040000 constant SEC_DMA1_ISR_HTIF5                               \ Channel x half transfer flag (x = 1 ..7)
$00080000 constant SEC_DMA1_ISR_TEIF5                               \ Channel x transfer error flag (x = 1 ..7)
$00100000 constant SEC_DMA1_ISR_GIF6                                \ Channel x global interrupt flag (x = 1 ..7)
$00200000 constant SEC_DMA1_ISR_TCIF6                               \ Channel x transfer complete flag (x = 1 ..7)
$00400000 constant SEC_DMA1_ISR_HTIF6                               \ Channel x half transfer flag (x = 1 ..7)
$00800000 constant SEC_DMA1_ISR_TEIF6                               \ Channel x transfer error flag (x = 1 ..7)
$01000000 constant SEC_DMA1_ISR_GIF7                                \ Channel x global interrupt flag (x = 1 ..7)
$02000000 constant SEC_DMA1_ISR_TCIF7                               \ Channel x transfer complete flag (x = 1 ..7)
$04000000 constant SEC_DMA1_ISR_HTIF7                               \ Channel x half transfer flag (x = 1 ..7)
$08000000 constant SEC_DMA1_ISR_TEIF7                               \ Channel x transfer error flag (x = 1 ..7)
$10000000 constant SEC_DMA1_ISR_GIF8                                \ global interrupt flag for channel 8
$20000000 constant SEC_DMA1_ISR_TCIF8                               \ transfer complete (TC) flag for channel 8
$40000000 constant SEC_DMA1_ISR_HTIF8                               \ half transfer (HT) flag for channel 8
$80000000 constant SEC_DMA1_ISR_TEIF8                               \ transfer error (TE) flag for channel 8


\
\ @brief interrupt flag clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA1_IFCR_CGIF1                              \ Channel x global interrupt clear (x = 1 ..7)
$00000002 constant SEC_DMA1_IFCR_CTCIF1                             \ Channel x transfer complete clear (x = 1 ..7)
$00000004 constant SEC_DMA1_IFCR_CHTIF1                             \ Channel x half transfer clear (x = 1 ..7)
$00000008 constant SEC_DMA1_IFCR_CTEIF1                             \ Channel x transfer error clear (x = 1 ..7)
$00000010 constant SEC_DMA1_IFCR_CGIF2                              \ Channel x global interrupt clear (x = 1 ..7)
$00000020 constant SEC_DMA1_IFCR_CTCIF2                             \ Channel x transfer complete clear (x = 1 ..7)
$00000040 constant SEC_DMA1_IFCR_CHTIF2                             \ Channel x half transfer clear (x = 1 ..7)
$00000080 constant SEC_DMA1_IFCR_CTEIF2                             \ Channel x transfer error clear (x = 1 ..7)
$00000100 constant SEC_DMA1_IFCR_CGIF3                              \ Channel x global interrupt clear (x = 1 ..7)
$00000200 constant SEC_DMA1_IFCR_CTCIF3                             \ Channel x transfer complete clear (x = 1 ..7)
$00000400 constant SEC_DMA1_IFCR_CHTIF3                             \ Channel x half transfer clear (x = 1 ..7)
$00000800 constant SEC_DMA1_IFCR_CTEIF3                             \ Channel x transfer error clear (x = 1 ..7)
$00001000 constant SEC_DMA1_IFCR_CGIF4                              \ Channel x global interrupt clear (x = 1 ..7)
$00002000 constant SEC_DMA1_IFCR_CTCIF4                             \ Channel x transfer complete clear (x = 1 ..7)
$00004000 constant SEC_DMA1_IFCR_CHTIF4                             \ Channel x half transfer clear (x = 1 ..7)
$00008000 constant SEC_DMA1_IFCR_CTEIF4                             \ Channel x transfer error clear (x = 1 ..7)
$00010000 constant SEC_DMA1_IFCR_CGIF5                              \ Channel x global interrupt clear (x = 1 ..7)
$00020000 constant SEC_DMA1_IFCR_CTCIF5                             \ Channel x transfer complete clear (x = 1 ..7)
$00040000 constant SEC_DMA1_IFCR_CHTIF5                             \ Channel x half transfer clear (x = 1 ..7)
$00080000 constant SEC_DMA1_IFCR_CTEIF5                             \ Channel x transfer error clear (x = 1 ..7)
$00100000 constant SEC_DMA1_IFCR_CGIF6                              \ Channel x global interrupt clear (x = 1 ..7)
$00200000 constant SEC_DMA1_IFCR_CTCIF6                             \ Channel x transfer complete clear (x = 1 ..7)
$00400000 constant SEC_DMA1_IFCR_CHTIF6                             \ Channel x half transfer clear (x = 1 ..7)
$00800000 constant SEC_DMA1_IFCR_CTEIF6                             \ Channel x transfer error clear (x = 1 ..7)
$01000000 constant SEC_DMA1_IFCR_CGIF7                              \ Channel x global interrupt clear (x = 1 ..7)
$02000000 constant SEC_DMA1_IFCR_CTCIF7                             \ Channel x transfer complete clear (x = 1 ..7)
$04000000 constant SEC_DMA1_IFCR_CHTIF7                             \ Channel x half transfer clear (x = 1 ..7)
$08000000 constant SEC_DMA1_IFCR_CTEIF7                             \ Channel x transfer error clear (x = 1 ..7)
$10000000 constant SEC_DMA1_IFCR_CGIF8                              \ global interrupt flag clear for channel 8
$20000000 constant SEC_DMA1_IFCR_CTCIF8                             \ transfer complete flag clear for channel 8
$40000000 constant SEC_DMA1_IFCR_CHTIF8                             \ half transfer flag clear for channel 8
$80000000 constant SEC_DMA1_IFCR_CTEIF8                             \ transfer error flag clear for channel 8


\
\ @brief channel x configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA1_CCR1_EN                                 \ Channel enable
$00000002 constant SEC_DMA1_CCR1_TCIE                               \ Transfer complete interrupt enable
$00000004 constant SEC_DMA1_CCR1_HTIE                               \ Half transfer interrupt enable
$00000008 constant SEC_DMA1_CCR1_TEIE                               \ Transfer error interrupt enable
$00000010 constant SEC_DMA1_CCR1_DIR                                \ Data transfer direction
$00000020 constant SEC_DMA1_CCR1_CIRC                               \ Circular mode
$00000040 constant SEC_DMA1_CCR1_PINC                               \ Peripheral increment mode
$00000080 constant SEC_DMA1_CCR1_MINC                               \ Memory increment mode
$00000300 constant SEC_DMA1_CCR1_PSIZE                              \ Peripheral size
$00000c00 constant SEC_DMA1_CCR1_MSIZE                              \ Memory size
$00003000 constant SEC_DMA1_CCR1_PL                                 \ Channel priority level
$00004000 constant SEC_DMA1_CCR1_MEM2MEM                            \ Memory to memory mode
$00008000 constant SEC_DMA1_CCR1_DBM                                \ double-buffer mode
$00010000 constant SEC_DMA1_CCR1_CT                                 \ current target memory of DMA transfer in double-buffer mode
$00020000 constant SEC_DMA1_CCR1_SECM                               \ secure mode
$00040000 constant SEC_DMA1_CCR1_SSEC                               \ security of the DMA transfer from the source
$00080000 constant SEC_DMA1_CCR1_DSEC                               \ security of the DMA transfer to the destination
$00100000 constant SEC_DMA1_CCR1_PRIV                               \ privileged mode


\
\ @brief channel x number of data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0003ffff constant SEC_DMA1_CNDTR1_NDT                              \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CPAR1_PA                                \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM0AR1_MA                               \ Memory address


\
\ @brief channel x memory address register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM1AR1_MA                               \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA1_CCR2_EN                                 \ Channel enable
$00000002 constant SEC_DMA1_CCR2_TCIE                               \ Transfer complete interrupt enable
$00000004 constant SEC_DMA1_CCR2_HTIE                               \ Half transfer interrupt enable
$00000008 constant SEC_DMA1_CCR2_TEIE                               \ Transfer error interrupt enable
$00000010 constant SEC_DMA1_CCR2_DIR                                \ Data transfer direction
$00000020 constant SEC_DMA1_CCR2_CIRC                               \ Circular mode
$00000040 constant SEC_DMA1_CCR2_PINC                               \ Peripheral increment mode
$00000080 constant SEC_DMA1_CCR2_MINC                               \ Memory increment mode
$00000300 constant SEC_DMA1_CCR2_PSIZE                              \ Peripheral size
$00000c00 constant SEC_DMA1_CCR2_MSIZE                              \ Memory size
$00003000 constant SEC_DMA1_CCR2_PL                                 \ Channel priority level
$00004000 constant SEC_DMA1_CCR2_MEM2MEM                            \ Memory to memory mode
$00008000 constant SEC_DMA1_CCR2_DBM                                \ double-buffer mode
$00010000 constant SEC_DMA1_CCR2_CT                                 \ current target memory of DMA transfer in double-buffer mode
$00020000 constant SEC_DMA1_CCR2_SECM                               \ secure mode
$00040000 constant SEC_DMA1_CCR2_SSEC                               \ security of the DMA transfer from the source
$00080000 constant SEC_DMA1_CCR2_DSEC                               \ security of the DMA transfer to the destination
$00100000 constant SEC_DMA1_CCR2_PRIV                               \ privileged mode


\
\ @brief channel x number of data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0003ffff constant SEC_DMA1_CNDTR2_NDT                              \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CPAR2_PA                                \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM0AR2_MA                               \ Memory address


\
\ @brief channel x memory address register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM1AR2_MA                               \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA1_CCR3_EN                                 \ Channel enable
$00000002 constant SEC_DMA1_CCR3_TCIE                               \ Transfer complete interrupt enable
$00000004 constant SEC_DMA1_CCR3_HTIE                               \ Half transfer interrupt enable
$00000008 constant SEC_DMA1_CCR3_TEIE                               \ Transfer error interrupt enable
$00000010 constant SEC_DMA1_CCR3_DIR                                \ Data transfer direction
$00000020 constant SEC_DMA1_CCR3_CIRC                               \ Circular mode
$00000040 constant SEC_DMA1_CCR3_PINC                               \ Peripheral increment mode
$00000080 constant SEC_DMA1_CCR3_MINC                               \ Memory increment mode
$00000300 constant SEC_DMA1_CCR3_PSIZE                              \ Peripheral size
$00000c00 constant SEC_DMA1_CCR3_MSIZE                              \ Memory size
$00003000 constant SEC_DMA1_CCR3_PL                                 \ Channel priority level
$00004000 constant SEC_DMA1_CCR3_MEM2MEM                            \ Memory to memory mode
$00008000 constant SEC_DMA1_CCR3_DBM                                \ double-buffer mode
$00010000 constant SEC_DMA1_CCR3_CT                                 \ current target memory of DMA transfer in double-buffer mode
$00020000 constant SEC_DMA1_CCR3_SECM                               \ secure mode
$00040000 constant SEC_DMA1_CCR3_SSEC                               \ security of the DMA transfer from the source
$00080000 constant SEC_DMA1_CCR3_DSEC                               \ security of the DMA transfer to the destination
$00100000 constant SEC_DMA1_CCR3_PRIV                               \ privileged mode


\
\ @brief channel x number of data register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0003ffff constant SEC_DMA1_CNDTR3_NDT                              \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CPAR3_PA                                \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM0AR3_MA                               \ Memory address


\
\ @brief channel x memory address register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM1AR3_MA                               \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA1_CCR4_EN                                 \ Channel enable
$00000002 constant SEC_DMA1_CCR4_TCIE                               \ Transfer complete interrupt enable
$00000004 constant SEC_DMA1_CCR4_HTIE                               \ Half transfer interrupt enable
$00000008 constant SEC_DMA1_CCR4_TEIE                               \ Transfer error interrupt enable
$00000010 constant SEC_DMA1_CCR4_DIR                                \ Data transfer direction
$00000020 constant SEC_DMA1_CCR4_CIRC                               \ Circular mode
$00000040 constant SEC_DMA1_CCR4_PINC                               \ Peripheral increment mode
$00000080 constant SEC_DMA1_CCR4_MINC                               \ Memory increment mode
$00000300 constant SEC_DMA1_CCR4_PSIZE                              \ Peripheral size
$00000c00 constant SEC_DMA1_CCR4_MSIZE                              \ Memory size
$00003000 constant SEC_DMA1_CCR4_PL                                 \ Channel priority level
$00004000 constant SEC_DMA1_CCR4_MEM2MEM                            \ Memory to memory mode
$00008000 constant SEC_DMA1_CCR4_DBM                                \ double-buffer mode
$00010000 constant SEC_DMA1_CCR4_CT                                 \ current target memory of DMA transfer in double-buffer mode
$00020000 constant SEC_DMA1_CCR4_SECM                               \ secure mode
$00040000 constant SEC_DMA1_CCR4_SSEC                               \ security of the DMA transfer from the source
$00080000 constant SEC_DMA1_CCR4_DSEC                               \ security of the DMA transfer to the destination
$00100000 constant SEC_DMA1_CCR4_PRIV                               \ privileged mode


\
\ @brief channel x number of data register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0003ffff constant SEC_DMA1_CNDTR4_NDT                              \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CPAR4_PA                                \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM0AR4_MA                               \ Memory address


\
\ @brief channel x memory address register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM1AR4_MA                               \ Memory address


\
\ @brief channel x configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA1_CCR5_EN                                 \ Channel enable
$00000002 constant SEC_DMA1_CCR5_TCIE                               \ Transfer complete interrupt enable
$00000004 constant SEC_DMA1_CCR5_HTIE                               \ Half transfer interrupt enable
$00000008 constant SEC_DMA1_CCR5_TEIE                               \ Transfer error interrupt enable
$00000010 constant SEC_DMA1_CCR5_DIR                                \ Data transfer direction
$00000020 constant SEC_DMA1_CCR5_CIRC                               \ Circular mode
$00000040 constant SEC_DMA1_CCR5_PINC                               \ Peripheral increment mode
$00000080 constant SEC_DMA1_CCR5_MINC                               \ Memory increment mode
$00000300 constant SEC_DMA1_CCR5_PSIZE                              \ Peripheral size
$00000c00 constant SEC_DMA1_CCR5_MSIZE                              \ Memory size
$00003000 constant SEC_DMA1_CCR5_PL                                 \ Channel priority level
$00004000 constant SEC_DMA1_CCR5_MEM2MEM                            \ Memory to memory mode
$00008000 constant SEC_DMA1_CCR5_DBM                                \ double-buffer mode
$00010000 constant SEC_DMA1_CCR5_CT                                 \ current target memory of DMA transfer in double-buffer mode
$00020000 constant SEC_DMA1_CCR5_SECM                               \ secure mode
$00040000 constant SEC_DMA1_CCR5_SSEC                               \ security of the DMA transfer from the source
$00080000 constant SEC_DMA1_CCR5_DSEC                               \ security of the DMA transfer to the destination
$00100000 constant SEC_DMA1_CCR5_PRIV                               \ privileged mode


\
\ @brief channel x number of data register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0003ffff constant SEC_DMA1_CNDTR5_NDT                              \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CPAR5_PA                                \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM0AR5_MA                               \ Memory address


\
\ @brief channel x memory address register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM1AR5_MA                               \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA1_CCR6_EN                                 \ Channel enable
$00000002 constant SEC_DMA1_CCR6_TCIE                               \ Transfer complete interrupt enable
$00000004 constant SEC_DMA1_CCR6_HTIE                               \ Half transfer interrupt enable
$00000008 constant SEC_DMA1_CCR6_TEIE                               \ Transfer error interrupt enable
$00000010 constant SEC_DMA1_CCR6_DIR                                \ Data transfer direction
$00000020 constant SEC_DMA1_CCR6_CIRC                               \ Circular mode
$00000040 constant SEC_DMA1_CCR6_PINC                               \ Peripheral increment mode
$00000080 constant SEC_DMA1_CCR6_MINC                               \ Memory increment mode
$00000300 constant SEC_DMA1_CCR6_PSIZE                              \ Peripheral size
$00000c00 constant SEC_DMA1_CCR6_MSIZE                              \ Memory size
$00003000 constant SEC_DMA1_CCR6_PL                                 \ Channel priority level
$00004000 constant SEC_DMA1_CCR6_MEM2MEM                            \ Memory to memory mode
$00008000 constant SEC_DMA1_CCR6_DBM                                \ double-buffer mode
$00010000 constant SEC_DMA1_CCR6_CT                                 \ current target memory of DMA transfer in double-buffer mode
$00020000 constant SEC_DMA1_CCR6_SECM                               \ secure mode
$00040000 constant SEC_DMA1_CCR6_SSEC                               \ security of the DMA transfer from the source
$00080000 constant SEC_DMA1_CCR6_DSEC                               \ security of the DMA transfer to the destination
$00100000 constant SEC_DMA1_CCR6_PRIV                               \ privileged mode


\
\ @brief channel x number of data register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0003ffff constant SEC_DMA1_CNDTR6_NDT                              \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CPAR6_PA                                \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM0AR6_MA                               \ Memory address


\
\ @brief channel x memory address register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM1AR6_MA                               \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA1_CCR7_EN                                 \ Channel enable
$00000002 constant SEC_DMA1_CCR7_TCIE                               \ Transfer complete interrupt enable
$00000004 constant SEC_DMA1_CCR7_HTIE                               \ Half transfer interrupt enable
$00000008 constant SEC_DMA1_CCR7_TEIE                               \ Transfer error interrupt enable
$00000010 constant SEC_DMA1_CCR7_DIR                                \ Data transfer direction
$00000020 constant SEC_DMA1_CCR7_CIRC                               \ Circular mode
$00000040 constant SEC_DMA1_CCR7_PINC                               \ Peripheral increment mode
$00000080 constant SEC_DMA1_CCR7_MINC                               \ Memory increment mode
$00000300 constant SEC_DMA1_CCR7_PSIZE                              \ Peripheral size
$00000c00 constant SEC_DMA1_CCR7_MSIZE                              \ Memory size
$00003000 constant SEC_DMA1_CCR7_PL                                 \ Channel priority level
$00004000 constant SEC_DMA1_CCR7_MEM2MEM                            \ Memory to memory mode
$00008000 constant SEC_DMA1_CCR7_DBM                                \ double-buffer mode
$00010000 constant SEC_DMA1_CCR7_CT                                 \ current target memory of DMA transfer in double-buffer mode
$00020000 constant SEC_DMA1_CCR7_SECM                               \ secure mode
$00040000 constant SEC_DMA1_CCR7_SSEC                               \ security of the DMA transfer from the source
$00080000 constant SEC_DMA1_CCR7_DSEC                               \ security of the DMA transfer to the destination
$00100000 constant SEC_DMA1_CCR7_PRIV                               \ privileged mode


\
\ @brief channel x number of data register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0003ffff constant SEC_DMA1_CNDTR7_NDT                              \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CPAR7_PA                                \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM0AR7_MA                               \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM1AR7_MA                               \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA1_CCR8_EN                                 \ Channel enable
$00000002 constant SEC_DMA1_CCR8_TCIE                               \ Transfer complete interrupt enable
$00000004 constant SEC_DMA1_CCR8_HTIE                               \ Half transfer interrupt enable
$00000008 constant SEC_DMA1_CCR8_TEIE                               \ Transfer error interrupt enable
$00000010 constant SEC_DMA1_CCR8_DIR                                \ Data transfer direction
$00000020 constant SEC_DMA1_CCR8_CIRC                               \ Circular mode
$00000040 constant SEC_DMA1_CCR8_PINC                               \ Peripheral increment mode
$00000080 constant SEC_DMA1_CCR8_MINC                               \ Memory increment mode
$00000300 constant SEC_DMA1_CCR8_PSIZE                              \ Peripheral size
$00000c00 constant SEC_DMA1_CCR8_MSIZE                              \ Memory size
$00003000 constant SEC_DMA1_CCR8_PL                                 \ Channel priority level
$00004000 constant SEC_DMA1_CCR8_MEM2MEM                            \ Memory to memory mode
$00008000 constant SEC_DMA1_CCR8_DBM                                \ double-buffer mode
$00010000 constant SEC_DMA1_CCR8_CT                                 \ current target memory of DMA transfer in double-buffer mode
$00020000 constant SEC_DMA1_CCR8_SECM                               \ secure mode
$00040000 constant SEC_DMA1_CCR8_SSEC                               \ security of the DMA transfer from the source
$00080000 constant SEC_DMA1_CCR8_DSEC                               \ security of the DMA transfer to the destination
$00100000 constant SEC_DMA1_CCR8_PRIV                               \ privileged mode


\
\ @brief channel x number of data register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0003ffff constant SEC_DMA1_CNDTR8_NDT                              \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CPAR8_PA                                \ Peripheral address


\
\ @brief channel x peripheral address register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM0AR8_MA                               \ Memory address


\
\ @brief channel x peripheral address register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CM1AR8_MA                               \ peripheral address


\
\ @brief channel selection register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA1_CSELR_MA                                \ peripheral address


\
\ @brief Direct memory access controller
\
$50020000 constant SEC_DMA1_ISR   \ offset: 0x00 : interrupt status register
$50020004 constant SEC_DMA1_IFCR  \ offset: 0x04 : interrupt flag clear register
$50020008 constant SEC_DMA1_CCR1  \ offset: 0x08 : channel x configuration register
$5002000c constant SEC_DMA1_CNDTR1  \ offset: 0x0C : channel x number of data register
$50020010 constant SEC_DMA1_CPAR1  \ offset: 0x10 : channel x peripheral address register
$50020014 constant SEC_DMA1_CM0AR1  \ offset: 0x14 : channel x memory address register
$50020018 constant SEC_DMA1_CM1AR1  \ offset: 0x18 : channel x memory address register
$5002001c constant SEC_DMA1_CCR2  \ offset: 0x1C : channel x configuration register
$50020020 constant SEC_DMA1_CNDTR2  \ offset: 0x20 : channel x number of data register
$50020024 constant SEC_DMA1_CPAR2  \ offset: 0x24 : channel x peripheral address register
$50020028 constant SEC_DMA1_CM0AR2  \ offset: 0x28 : channel x memory address register
$5002002c constant SEC_DMA1_CM1AR2  \ offset: 0x2C : channel x memory address register
$50020030 constant SEC_DMA1_CCR3  \ offset: 0x30 : channel x configuration register
$50020034 constant SEC_DMA1_CNDTR3  \ offset: 0x34 : channel x number of data register
$50020038 constant SEC_DMA1_CPAR3  \ offset: 0x38 : channel x peripheral address register
$5002003c constant SEC_DMA1_CM0AR3  \ offset: 0x3C : channel x memory address register
$50020040 constant SEC_DMA1_CM1AR3  \ offset: 0x40 : channel x memory address register
$50020044 constant SEC_DMA1_CCR4  \ offset: 0x44 : channel x configuration register
$50020048 constant SEC_DMA1_CNDTR4  \ offset: 0x48 : channel x number of data register
$5002004c constant SEC_DMA1_CPAR4  \ offset: 0x4C : channel x peripheral address register
$50020050 constant SEC_DMA1_CM0AR4  \ offset: 0x50 : channel x memory address register
$50020054 constant SEC_DMA1_CM1AR4  \ offset: 0x54 : channel x memory address register
$50020058 constant SEC_DMA1_CCR5  \ offset: 0x58 : channel x configuration register
$5002005c constant SEC_DMA1_CNDTR5  \ offset: 0x5C : channel x number of data register
$50020060 constant SEC_DMA1_CPAR5  \ offset: 0x60 : channel x peripheral address register
$50020064 constant SEC_DMA1_CM0AR5  \ offset: 0x64 : channel x memory address register
$50020068 constant SEC_DMA1_CM1AR5  \ offset: 0x68 : channel x memory address register
$5002006c constant SEC_DMA1_CCR6  \ offset: 0x6C : channel x configuration register
$50020070 constant SEC_DMA1_CNDTR6  \ offset: 0x70 : channel x number of data register
$50020074 constant SEC_DMA1_CPAR6  \ offset: 0x74 : channel x peripheral address register
$50020078 constant SEC_DMA1_CM0AR6  \ offset: 0x78 : channel x memory address register
$5002007c constant SEC_DMA1_CM1AR6  \ offset: 0x7C : channel x memory address register
$50020080 constant SEC_DMA1_CCR7  \ offset: 0x80 : channel x configuration register
$50020084 constant SEC_DMA1_CNDTR7  \ offset: 0x84 : channel x number of data register
$50020088 constant SEC_DMA1_CPAR7  \ offset: 0x88 : channel x peripheral address register
$5002008c constant SEC_DMA1_CM0AR7  \ offset: 0x8C : channel x memory address register
$50020090 constant SEC_DMA1_CM1AR7  \ offset: 0x90 : channel x memory address register
$50020094 constant SEC_DMA1_CCR8  \ offset: 0x94 : channel x configuration register
$50020098 constant SEC_DMA1_CNDTR8  \ offset: 0x98 : channel x number of data register
$5002009c constant SEC_DMA1_CPAR8  \ offset: 0x9C : channel x peripheral address register
$500200a0 constant SEC_DMA1_CM0AR8  \ offset: 0xA0 : channel x peripheral address register
$500200a4 constant SEC_DMA1_CM1AR8  \ offset: 0xA4 : channel x peripheral address register
$500200a8 constant SEC_DMA1_CSELR  \ offset: 0xA8 : channel selection register

