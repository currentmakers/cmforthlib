\
\ @file dma2.fs
\ @brief DMA2 Channel 1 global Interrupt
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

$00000001 constant DMA2_ISR_GIF1                                    \ Channel x global interrupt flag (x = 1 ..7)
$00000002 constant DMA2_ISR_TCIF1                                   \ Channel x transfer complete flag (x = 1 ..7)
$00000004 constant DMA2_ISR_HTIF1                                   \ Channel x half transfer flag (x = 1 ..7)
$00000008 constant DMA2_ISR_TEIF1                                   \ Channel x transfer error flag (x = 1 ..7)
$00000010 constant DMA2_ISR_GIF2                                    \ Channel x global interrupt flag (x = 1 ..7)
$00000020 constant DMA2_ISR_TCIF2                                   \ Channel x transfer complete flag (x = 1 ..7)
$00000040 constant DMA2_ISR_HTIF2                                   \ Channel x half transfer flag (x = 1 ..7)
$00000080 constant DMA2_ISR_TEIF2                                   \ Channel x transfer error flag (x = 1 ..7)
$00000100 constant DMA2_ISR_GIF3                                    \ Channel x global interrupt flag (x = 1 ..7)
$00000200 constant DMA2_ISR_TCIF3                                   \ Channel x transfer complete flag (x = 1 ..7)
$00000400 constant DMA2_ISR_HTIF3                                   \ Channel x half transfer flag (x = 1 ..7)
$00000800 constant DMA2_ISR_TEIF3                                   \ Channel x transfer error flag (x = 1 ..7)
$00001000 constant DMA2_ISR_GIF4                                    \ Channel x global interrupt flag (x = 1 ..7)
$00002000 constant DMA2_ISR_TCIF4                                   \ Channel x transfer complete flag (x = 1 ..7)
$00004000 constant DMA2_ISR_HTIF4                                   \ Channel x half transfer flag (x = 1 ..7)
$00008000 constant DMA2_ISR_TEIF4                                   \ Channel x transfer error flag (x = 1 ..7)
$00010000 constant DMA2_ISR_GIF5                                    \ Channel x global interrupt flag (x = 1 ..7)
$00020000 constant DMA2_ISR_TCIF5                                   \ Channel x transfer complete flag (x = 1 ..7)
$00040000 constant DMA2_ISR_HTIF5                                   \ Channel x half transfer flag (x = 1 ..7)
$00080000 constant DMA2_ISR_TEIF5                                   \ Channel x transfer error flag (x = 1 ..7)
$00100000 constant DMA2_ISR_GIF6                                    \ Channel x global interrupt flag (x = 1 ..7)
$00200000 constant DMA2_ISR_TCIF6                                   \ Channel x transfer complete flag (x = 1 ..7)
$00400000 constant DMA2_ISR_HTIF6                                   \ Channel x half transfer flag (x = 1 ..7)
$00800000 constant DMA2_ISR_TEIF6                                   \ Channel x transfer error flag (x = 1 ..7)
$01000000 constant DMA2_ISR_GIF7                                    \ Channel x global interrupt flag (x = 1 ..7)
$02000000 constant DMA2_ISR_TCIF7                                   \ Channel x transfer complete flag (x = 1 ..7)
$04000000 constant DMA2_ISR_HTIF7                                   \ Channel x half transfer flag (x = 1 ..7)
$08000000 constant DMA2_ISR_TEIF7                                   \ Channel x transfer error flag (x = 1 ..7)


\
\ @brief interrupt flag clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA2_IFCR_CGIF1                                  \ Channel x global interrupt clear (x = 1 ..7)
$00000002 constant DMA2_IFCR_CTCIF1                                 \ Channel x transfer complete clear (x = 1 ..7)
$00000004 constant DMA2_IFCR_CHTIF1                                 \ Channel x half transfer clear (x = 1 ..7)
$00000008 constant DMA2_IFCR_CTEIF1                                 \ Channel x transfer error clear (x = 1 ..7)
$00000010 constant DMA2_IFCR_CGIF2                                  \ Channel x global interrupt clear (x = 1 ..7)
$00000020 constant DMA2_IFCR_CTCIF2                                 \ Channel x transfer complete clear (x = 1 ..7)
$00000040 constant DMA2_IFCR_CHTIF2                                 \ Channel x half transfer clear (x = 1 ..7)
$00000080 constant DMA2_IFCR_CTEIF2                                 \ Channel x transfer error clear (x = 1 ..7)
$00000100 constant DMA2_IFCR_CGIF3                                  \ Channel x global interrupt clear (x = 1 ..7)
$00000200 constant DMA2_IFCR_CTCIF3                                 \ Channel x transfer complete clear (x = 1 ..7)
$00000400 constant DMA2_IFCR_CHTIF3                                 \ Channel x half transfer clear (x = 1 ..7)
$00000800 constant DMA2_IFCR_CTEIF3                                 \ Channel x transfer error clear (x = 1 ..7)
$00001000 constant DMA2_IFCR_CGIF4                                  \ Channel x global interrupt clear (x = 1 ..7)
$00002000 constant DMA2_IFCR_CTCIF4                                 \ Channel x transfer complete clear (x = 1 ..7)
$00004000 constant DMA2_IFCR_CHTIF4                                 \ Channel x half transfer clear (x = 1 ..7)
$00008000 constant DMA2_IFCR_CTEIF4                                 \ Channel x transfer error clear (x = 1 ..7)
$00010000 constant DMA2_IFCR_CGIF5                                  \ Channel x global interrupt clear (x = 1 ..7)
$00020000 constant DMA2_IFCR_CTCIF5                                 \ Channel x transfer complete clear (x = 1 ..7)
$00040000 constant DMA2_IFCR_CHTIF5                                 \ Channel x half transfer clear (x = 1 ..7)
$00080000 constant DMA2_IFCR_CTEIF5                                 \ Channel x transfer error clear (x = 1 ..7)
$00100000 constant DMA2_IFCR_CGIF6                                  \ Channel x global interrupt clear (x = 1 ..7)
$00200000 constant DMA2_IFCR_CTCIF6                                 \ Channel x transfer complete clear (x = 1 ..7)
$00400000 constant DMA2_IFCR_CHTIF6                                 \ Channel x half transfer clear (x = 1 ..7)
$00800000 constant DMA2_IFCR_CTEIF6                                 \ Channel x transfer error clear (x = 1 ..7)
$01000000 constant DMA2_IFCR_CGIF7                                  \ Channel x global interrupt clear (x = 1 ..7)
$02000000 constant DMA2_IFCR_CTCIF7                                 \ Channel x transfer complete clear (x = 1 ..7)
$04000000 constant DMA2_IFCR_CHTIF7                                 \ Channel x half transfer clear (x = 1 ..7)
$08000000 constant DMA2_IFCR_CTEIF7                                 \ Channel x transfer error clear (x = 1 ..7)


\
\ @brief channel x configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR1_EN                                     \ Channel enable
$00000002 constant DMA2_CCR1_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA2_CCR1_HTIE                                   \ Half transfer interrupt enable
$00000008 constant DMA2_CCR1_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA2_CCR1_DIR                                    \ Data transfer direction
$00000020 constant DMA2_CCR1_CIRC                                   \ Circular mode
$00000040 constant DMA2_CCR1_PINC                                   \ Peripheral increment mode
$00000080 constant DMA2_CCR1_MINC                                   \ Memory increment mode
$00000300 constant DMA2_CCR1_PSIZE                                  \ Peripheral size
$00000c00 constant DMA2_CCR1_MSIZE                                  \ Memory size
$00003000 constant DMA2_CCR1_PL                                     \ Channel priority level
$00004000 constant DMA2_CCR1_MEM2MEM                                \ Memory to memory mode


\
\ @brief channel x number of data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_CNDTR1_NDT                                  \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR1_PA                                    \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR1_MA                                    \ Memory address


\
\ @brief channel x configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR2_EN                                     \ Channel enable
$00000002 constant DMA2_CCR2_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA2_CCR2_HTIE                                   \ Half transfer interrupt enable
$00000008 constant DMA2_CCR2_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA2_CCR2_DIR                                    \ Data transfer direction
$00000020 constant DMA2_CCR2_CIRC                                   \ Circular mode
$00000040 constant DMA2_CCR2_PINC                                   \ Peripheral increment mode
$00000080 constant DMA2_CCR2_MINC                                   \ Memory increment mode
$00000300 constant DMA2_CCR2_PSIZE                                  \ Peripheral size
$00000c00 constant DMA2_CCR2_MSIZE                                  \ Memory size
$00003000 constant DMA2_CCR2_PL                                     \ Channel priority level
$00004000 constant DMA2_CCR2_MEM2MEM                                \ Memory to memory mode


\
\ @brief channel x number of data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_CNDTR2_NDT                                  \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR2_PA                                    \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR2_MA                                    \ Memory address


\
\ @brief channel x configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR3_EN                                     \ Channel enable
$00000002 constant DMA2_CCR3_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA2_CCR3_HTIE                                   \ Half transfer interrupt enable
$00000008 constant DMA2_CCR3_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA2_CCR3_DIR                                    \ Data transfer direction
$00000020 constant DMA2_CCR3_CIRC                                   \ Circular mode
$00000040 constant DMA2_CCR3_PINC                                   \ Peripheral increment mode
$00000080 constant DMA2_CCR3_MINC                                   \ Memory increment mode
$00000300 constant DMA2_CCR3_PSIZE                                  \ Peripheral size
$00000c00 constant DMA2_CCR3_MSIZE                                  \ Memory size
$00003000 constant DMA2_CCR3_PL                                     \ Channel priority level
$00004000 constant DMA2_CCR3_MEM2MEM                                \ Memory to memory mode


\
\ @brief channel x number of data register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_CNDTR3_NDT                                  \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR3_PA                                    \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR3_MA                                    \ Memory address


\
\ @brief channel x configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR4_EN                                     \ Channel enable
$00000002 constant DMA2_CCR4_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA2_CCR4_HTIE                                   \ Half transfer interrupt enable
$00000008 constant DMA2_CCR4_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA2_CCR4_DIR                                    \ Data transfer direction
$00000020 constant DMA2_CCR4_CIRC                                   \ Circular mode
$00000040 constant DMA2_CCR4_PINC                                   \ Peripheral increment mode
$00000080 constant DMA2_CCR4_MINC                                   \ Memory increment mode
$00000300 constant DMA2_CCR4_PSIZE                                  \ Peripheral size
$00000c00 constant DMA2_CCR4_MSIZE                                  \ Memory size
$00003000 constant DMA2_CCR4_PL                                     \ Channel priority level
$00004000 constant DMA2_CCR4_MEM2MEM                                \ Memory to memory mode


\
\ @brief channel x number of data register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_CNDTR4_NDT                                  \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR4_PA                                    \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR4_MA                                    \ Memory address


\
\ @brief channel x configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR5_EN                                     \ Channel enable
$00000002 constant DMA2_CCR5_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA2_CCR5_HTIE                                   \ Half transfer interrupt enable
$00000008 constant DMA2_CCR5_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA2_CCR5_DIR                                    \ Data transfer direction
$00000020 constant DMA2_CCR5_CIRC                                   \ Circular mode
$00000040 constant DMA2_CCR5_PINC                                   \ Peripheral increment mode
$00000080 constant DMA2_CCR5_MINC                                   \ Memory increment mode
$00000300 constant DMA2_CCR5_PSIZE                                  \ Peripheral size
$00000c00 constant DMA2_CCR5_MSIZE                                  \ Memory size
$00003000 constant DMA2_CCR5_PL                                     \ Channel priority level
$00004000 constant DMA2_CCR5_MEM2MEM                                \ Memory to memory mode


\
\ @brief channel x number of data register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_CNDTR5_NDT                                  \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR5_PA                                    \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR5_MA                                    \ Memory address


\
\ @brief channel x configuration register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR6_EN                                     \ Channel enable
$00000002 constant DMA2_CCR6_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA2_CCR6_HTIE                                   \ Half transfer interrupt enable
$00000008 constant DMA2_CCR6_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA2_CCR6_DIR                                    \ Data transfer direction
$00000020 constant DMA2_CCR6_CIRC                                   \ Circular mode
$00000040 constant DMA2_CCR6_PINC                                   \ Peripheral increment mode
$00000080 constant DMA2_CCR6_MINC                                   \ Memory increment mode
$00000300 constant DMA2_CCR6_PSIZE                                  \ Peripheral size
$00000c00 constant DMA2_CCR6_MSIZE                                  \ Memory size
$00003000 constant DMA2_CCR6_PL                                     \ Channel priority level
$00004000 constant DMA2_CCR6_MEM2MEM                                \ Memory to memory mode


\
\ @brief channel x number of data register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_CNDTR6_NDT                                  \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR6_PA                                    \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR6_MA                                    \ Memory address


\
\ @brief channel x configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR7_EN                                     \ Channel enable
$00000002 constant DMA2_CCR7_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA2_CCR7_HTIE                                   \ Half transfer interrupt enable
$00000008 constant DMA2_CCR7_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA2_CCR7_DIR                                    \ Data transfer direction
$00000020 constant DMA2_CCR7_CIRC                                   \ Circular mode
$00000040 constant DMA2_CCR7_PINC                                   \ Peripheral increment mode
$00000080 constant DMA2_CCR7_MINC                                   \ Memory increment mode
$00000300 constant DMA2_CCR7_PSIZE                                  \ Peripheral size
$00000c00 constant DMA2_CCR7_MSIZE                                  \ Memory size
$00003000 constant DMA2_CCR7_PL                                     \ Channel priority level
$00004000 constant DMA2_CCR7_MEM2MEM                                \ Memory to memory mode


\
\ @brief channel x number of data register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_CNDTR7_NDT                                  \ Number of data to transfer


\
\ @brief channel x peripheral address register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR7_PA                                    \ Peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR7_MA                                    \ Memory address


\
\ @brief DMA2 Channel 1 global Interrupt
\
$40020400 constant DMA2_ISR       \ offset: 0x00 : interrupt status register
$40020404 constant DMA2_IFCR      \ offset: 0x04 : interrupt flag clear register
$40020408 constant DMA2_CCR1      \ offset: 0x08 : channel x configuration register
$4002040c constant DMA2_CNDTR1    \ offset: 0x0C : channel x number of data register
$40020410 constant DMA2_CPAR1     \ offset: 0x10 : channel x peripheral address register
$40020414 constant DMA2_CMAR1     \ offset: 0x14 : channel x memory address register
$4002041c constant DMA2_CCR2      \ offset: 0x1C : channel x configuration register
$40020420 constant DMA2_CNDTR2    \ offset: 0x20 : channel x number of data register
$40020424 constant DMA2_CPAR2     \ offset: 0x24 : channel x peripheral address register
$40020428 constant DMA2_CMAR2     \ offset: 0x28 : channel x memory address register
$40020430 constant DMA2_CCR3      \ offset: 0x30 : channel x configuration register
$40020434 constant DMA2_CNDTR3    \ offset: 0x34 : channel x number of data register
$40020438 constant DMA2_CPAR3     \ offset: 0x38 : channel x peripheral address register
$4002043c constant DMA2_CMAR3     \ offset: 0x3C : channel x memory address register
$40020444 constant DMA2_CCR4      \ offset: 0x44 : channel x configuration register
$40020448 constant DMA2_CNDTR4    \ offset: 0x48 : channel x number of data register
$4002044c constant DMA2_CPAR4     \ offset: 0x4C : channel x peripheral address register
$40020450 constant DMA2_CMAR4     \ offset: 0x50 : channel x memory address register
$40020458 constant DMA2_CCR5      \ offset: 0x58 : channel x configuration register
$4002045c constant DMA2_CNDTR5    \ offset: 0x5C : channel x number of data register
$40020460 constant DMA2_CPAR5     \ offset: 0x60 : channel x peripheral address register
$40020464 constant DMA2_CMAR5     \ offset: 0x64 : channel x memory address register
$4002046c constant DMA2_CCR6      \ offset: 0x6C : channel x configuration register
$40020470 constant DMA2_CNDTR6    \ offset: 0x70 : channel x number of data register
$40020474 constant DMA2_CPAR6     \ offset: 0x74 : channel x peripheral address register
$40020478 constant DMA2_CMAR6     \ offset: 0x78 : channel x memory address register
$40020480 constant DMA2_CCR7      \ offset: 0x80 : channel x configuration register
$40020484 constant DMA2_CNDTR7    \ offset: 0x84 : channel x number of data register
$40020488 constant DMA2_CPAR7     \ offset: 0x88 : channel x peripheral address register
$4002048c constant DMA2_CMAR7     \ offset: 0x8C : channel x memory address register

