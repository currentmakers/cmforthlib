\
\ @file dma1.fs
\ @brief DMA controller 1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMA interrupt status register (DMA_ISR)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DMA1_ISR_GIF1                                    \ Channel 1 Global interrupt flag
$00000002 constant DMA1_ISR_TCIF1                                   \ Channel 1 Transfer Complete flag
$00000004 constant DMA1_ISR_HTIF1                                   \ Channel 1 Half Transfer Complete flag
$00000008 constant DMA1_ISR_TEIF1                                   \ Channel 1 Transfer Error flag
$00000010 constant DMA1_ISR_GIF2                                    \ Channel 2 Global interrupt flag
$00000020 constant DMA1_ISR_TCIF2                                   \ Channel 2 Transfer Complete flag
$00000040 constant DMA1_ISR_HTIF2                                   \ Channel 2 Half Transfer Complete flag
$00000080 constant DMA1_ISR_TEIF2                                   \ Channel 2 Transfer Error flag
$00000100 constant DMA1_ISR_GIF3                                    \ Channel 3 Global interrupt flag
$00000200 constant DMA1_ISR_TCIF3                                   \ Channel 3 Transfer Complete flag
$00000400 constant DMA1_ISR_HTIF3                                   \ Channel 3 Half Transfer Complete flag
$00000800 constant DMA1_ISR_TEIF3                                   \ Channel 3 Transfer Error flag
$00001000 constant DMA1_ISR_GIF4                                    \ Channel 4 Global interrupt flag
$00002000 constant DMA1_ISR_TCIF4                                   \ Channel 4 Transfer Complete flag
$00004000 constant DMA1_ISR_HTIF4                                   \ Channel 4 Half Transfer Complete flag
$00008000 constant DMA1_ISR_TEIF4                                   \ Channel 4 Transfer Error flag
$00010000 constant DMA1_ISR_GIF5                                    \ Channel 5 Global interrupt flag
$00020000 constant DMA1_ISR_TCIF5                                   \ Channel 5 Transfer Complete flag
$00040000 constant DMA1_ISR_HTIF5                                   \ Channel 5 Half Transfer Complete flag
$00080000 constant DMA1_ISR_TEIF5                                   \ Channel 5 Transfer Error flag
$00100000 constant DMA1_ISR_GIF6                                    \ Channel 6 Global interrupt flag
$00200000 constant DMA1_ISR_TCIF6                                   \ Channel 6 Transfer Complete flag
$00400000 constant DMA1_ISR_HTIF6                                   \ Channel 6 Half Transfer Complete flag
$00800000 constant DMA1_ISR_TEIF6                                   \ Channel 6 Transfer Error flag
$01000000 constant DMA1_ISR_GIF7                                    \ Channel 7 Global interrupt flag
$02000000 constant DMA1_ISR_TCIF7                                   \ Channel 7 Transfer Complete flag
$04000000 constant DMA1_ISR_HTIF7                                   \ Channel 7 Half Transfer Complete flag
$08000000 constant DMA1_ISR_TEIF7                                   \ Channel 7 Transfer Error flag


\
\ @brief DMA interrupt flag clear register (DMA_IFCR)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA1_IFCR_CGIF1                                  \ Channel 1 Global interrupt clear
$00000002 constant DMA1_IFCR_CTCIF1                                 \ Channel 1 Transfer Complete clear
$00000004 constant DMA1_IFCR_CHTIF1                                 \ Channel 1 Half Transfer clear
$00000008 constant DMA1_IFCR_CTEIF1                                 \ Channel 1 Transfer Error clear
$00000010 constant DMA1_IFCR_CGIF2                                  \ Channel 2 Global interrupt clear
$00000020 constant DMA1_IFCR_CTCIF2                                 \ Channel 2 Transfer Complete clear
$00000040 constant DMA1_IFCR_CHTIF2                                 \ Channel 2 Half Transfer clear
$00000080 constant DMA1_IFCR_CTEIF2                                 \ Channel 2 Transfer Error clear
$00000100 constant DMA1_IFCR_CGIF3                                  \ Channel 3 Global interrupt clear
$00000200 constant DMA1_IFCR_CTCIF3                                 \ Channel 3 Transfer Complete clear
$00000400 constant DMA1_IFCR_CHTIF3                                 \ Channel 3 Half Transfer clear
$00000800 constant DMA1_IFCR_CTEIF3                                 \ Channel 3 Transfer Error clear
$00001000 constant DMA1_IFCR_CGIF4                                  \ Channel 4 Global interrupt clear
$00002000 constant DMA1_IFCR_CTCIF4                                 \ Channel 4 Transfer Complete clear
$00004000 constant DMA1_IFCR_CHTIF4                                 \ Channel 4 Half Transfer clear
$00008000 constant DMA1_IFCR_CTEIF4                                 \ Channel 4 Transfer Error clear
$00010000 constant DMA1_IFCR_CGIF5                                  \ Channel 5 Global interrupt clear
$00020000 constant DMA1_IFCR_CTCIF5                                 \ Channel 5 Transfer Complete clear
$00040000 constant DMA1_IFCR_CHTIF5                                 \ Channel 5 Half Transfer clear
$00080000 constant DMA1_IFCR_CTEIF5                                 \ Channel 5 Transfer Error clear
$00100000 constant DMA1_IFCR_CGIF6                                  \ Channel 6 Global interrupt clear
$00200000 constant DMA1_IFCR_CTCIF6                                 \ Channel 6 Transfer Complete clear
$00400000 constant DMA1_IFCR_CHTIF6                                 \ Channel 6 Half Transfer clear
$00800000 constant DMA1_IFCR_CTEIF6                                 \ Channel 6 Transfer Error clear
$01000000 constant DMA1_IFCR_CGIF7                                  \ Channel 7 Global interrupt clear
$02000000 constant DMA1_IFCR_CTCIF7                                 \ Channel 7 Transfer Complete clear
$04000000 constant DMA1_IFCR_CHTIF7                                 \ Channel 7 Half Transfer clear
$08000000 constant DMA1_IFCR_CTEIF7                                 \ Channel 7 Transfer Error clear


\
\ @brief DMA channel configuration register (DMA_CCR)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR1_EN                                     \ Channel enable
$00000002 constant DMA1_CCR1_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA1_CCR1_HTIE                                   \ Half Transfer interrupt enable
$00000008 constant DMA1_CCR1_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA1_CCR1_DIR                                    \ Data transfer direction
$00000020 constant DMA1_CCR1_CIRC                                   \ Circular mode
$00000040 constant DMA1_CCR1_PINC                                   \ Peripheral increment mode
$00000080 constant DMA1_CCR1_MINC                                   \ Memory increment mode
$00000300 constant DMA1_CCR1_PSIZE                                  \ Peripheral size
$00000c00 constant DMA1_CCR1_MSIZE                                  \ Memory size
$00003000 constant DMA1_CCR1_PL                                     \ Channel Priority level
$00004000 constant DMA1_CCR1_MEM2MEM                                \ Memory to memory mode


\
\ @brief DMA channel 1 number of data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR1_NDT                                  \ Number of data to transfer


\
\ @brief DMA channel 1 peripheral address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR1_PA                                    \ Peripheral address


\
\ @brief DMA channel 1 memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR1_MA                                    \ Memory address


\
\ @brief DMA channel configuration register (DMA_CCR)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR2_EN                                     \ Channel enable
$00000002 constant DMA1_CCR2_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA1_CCR2_HTIE                                   \ Half Transfer interrupt enable
$00000008 constant DMA1_CCR2_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA1_CCR2_DIR                                    \ Data transfer direction
$00000020 constant DMA1_CCR2_CIRC                                   \ Circular mode
$00000040 constant DMA1_CCR2_PINC                                   \ Peripheral increment mode
$00000080 constant DMA1_CCR2_MINC                                   \ Memory increment mode
$00000300 constant DMA1_CCR2_PSIZE                                  \ Peripheral size
$00000c00 constant DMA1_CCR2_MSIZE                                  \ Memory size
$00003000 constant DMA1_CCR2_PL                                     \ Channel Priority level
$00004000 constant DMA1_CCR2_MEM2MEM                                \ Memory to memory mode


\
\ @brief DMA channel 2 number of data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR2_NDT                                  \ Number of data to transfer


\
\ @brief DMA channel 2 peripheral address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR2_PA                                    \ Peripheral address


\
\ @brief DMA channel 2 memory address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR2_MA                                    \ Memory address


\
\ @brief DMA channel configuration register (DMA_CCR)
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR3_EN                                     \ Channel enable
$00000002 constant DMA1_CCR3_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA1_CCR3_HTIE                                   \ Half Transfer interrupt enable
$00000008 constant DMA1_CCR3_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA1_CCR3_DIR                                    \ Data transfer direction
$00000020 constant DMA1_CCR3_CIRC                                   \ Circular mode
$00000040 constant DMA1_CCR3_PINC                                   \ Peripheral increment mode
$00000080 constant DMA1_CCR3_MINC                                   \ Memory increment mode
$00000300 constant DMA1_CCR3_PSIZE                                  \ Peripheral size
$00000c00 constant DMA1_CCR3_MSIZE                                  \ Memory size
$00003000 constant DMA1_CCR3_PL                                     \ Channel Priority level
$00004000 constant DMA1_CCR3_MEM2MEM                                \ Memory to memory mode


\
\ @brief DMA channel 3 number of data register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR3_NDT                                  \ Number of data to transfer


\
\ @brief DMA channel 3 peripheral address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR3_PA                                    \ Peripheral address


\
\ @brief DMA channel 3 memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR3_MA                                    \ Memory address


\
\ @brief DMA channel configuration register (DMA_CCR)
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR4_EN                                     \ Channel enable
$00000002 constant DMA1_CCR4_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA1_CCR4_HTIE                                   \ Half Transfer interrupt enable
$00000008 constant DMA1_CCR4_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA1_CCR4_DIR                                    \ Data transfer direction
$00000020 constant DMA1_CCR4_CIRC                                   \ Circular mode
$00000040 constant DMA1_CCR4_PINC                                   \ Peripheral increment mode
$00000080 constant DMA1_CCR4_MINC                                   \ Memory increment mode
$00000300 constant DMA1_CCR4_PSIZE                                  \ Peripheral size
$00000c00 constant DMA1_CCR4_MSIZE                                  \ Memory size
$00003000 constant DMA1_CCR4_PL                                     \ Channel Priority level
$00004000 constant DMA1_CCR4_MEM2MEM                                \ Memory to memory mode


\
\ @brief DMA channel 4 number of data register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR4_NDT                                  \ Number of data to transfer


\
\ @brief DMA channel 4 peripheral address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR4_PA                                    \ Peripheral address


\
\ @brief DMA channel 4 memory address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR4_MA                                    \ Memory address


\
\ @brief DMA channel configuration register (DMA_CCR)
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR5_EN                                     \ Channel enable
$00000002 constant DMA1_CCR5_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA1_CCR5_HTIE                                   \ Half Transfer interrupt enable
$00000008 constant DMA1_CCR5_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA1_CCR5_DIR                                    \ Data transfer direction
$00000020 constant DMA1_CCR5_CIRC                                   \ Circular mode
$00000040 constant DMA1_CCR5_PINC                                   \ Peripheral increment mode
$00000080 constant DMA1_CCR5_MINC                                   \ Memory increment mode
$00000300 constant DMA1_CCR5_PSIZE                                  \ Peripheral size
$00000c00 constant DMA1_CCR5_MSIZE                                  \ Memory size
$00003000 constant DMA1_CCR5_PL                                     \ Channel Priority level
$00004000 constant DMA1_CCR5_MEM2MEM                                \ Memory to memory mode


\
\ @brief DMA channel 5 number of data register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR5_NDT                                  \ Number of data to transfer


\
\ @brief DMA channel 5 peripheral address register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR5_PA                                    \ Peripheral address


\
\ @brief DMA channel 5 memory address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR5_MA                                    \ Memory address


\
\ @brief DMA channel configuration register (DMA_CCR)
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR6_EN                                     \ Channel enable
$00000002 constant DMA1_CCR6_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA1_CCR6_HTIE                                   \ Half Transfer interrupt enable
$00000008 constant DMA1_CCR6_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA1_CCR6_DIR                                    \ Data transfer direction
$00000020 constant DMA1_CCR6_CIRC                                   \ Circular mode
$00000040 constant DMA1_CCR6_PINC                                   \ Peripheral increment mode
$00000080 constant DMA1_CCR6_MINC                                   \ Memory increment mode
$00000300 constant DMA1_CCR6_PSIZE                                  \ Peripheral size
$00000c00 constant DMA1_CCR6_MSIZE                                  \ Memory size
$00003000 constant DMA1_CCR6_PL                                     \ Channel Priority level
$00004000 constant DMA1_CCR6_MEM2MEM                                \ Memory to memory mode


\
\ @brief DMA channel 6 number of data register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR6_NDT                                  \ Number of data to transfer


\
\ @brief DMA channel 6 peripheral address register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR6_PA                                    \ Peripheral address


\
\ @brief DMA channel 6 memory address register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR6_MA                                    \ Memory address


\
\ @brief DMA channel configuration register (DMA_CCR)
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR7_EN                                     \ Channel enable
$00000002 constant DMA1_CCR7_TCIE                                   \ Transfer complete interrupt enable
$00000004 constant DMA1_CCR7_HTIE                                   \ Half Transfer interrupt enable
$00000008 constant DMA1_CCR7_TEIE                                   \ Transfer error interrupt enable
$00000010 constant DMA1_CCR7_DIR                                    \ Data transfer direction
$00000020 constant DMA1_CCR7_CIRC                                   \ Circular mode
$00000040 constant DMA1_CCR7_PINC                                   \ Peripheral increment mode
$00000080 constant DMA1_CCR7_MINC                                   \ Memory increment mode
$00000300 constant DMA1_CCR7_PSIZE                                  \ Peripheral size
$00000c00 constant DMA1_CCR7_MSIZE                                  \ Memory size
$00003000 constant DMA1_CCR7_PL                                     \ Channel Priority level
$00004000 constant DMA1_CCR7_MEM2MEM                                \ Memory to memory mode


\
\ @brief DMA channel 7 number of data register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR7_NDT                                  \ Number of data to transfer


\
\ @brief DMA channel 7 peripheral address register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR7_PA                                    \ Peripheral address


\
\ @brief DMA channel 7 memory address register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR7_MA                                    \ Memory address


\
\ @brief DMA controller 1
\
$40020000 constant DMA1_ISR       \ offset: 0x00 : DMA interrupt status register (DMA_ISR)
$40020004 constant DMA1_IFCR      \ offset: 0x04 : DMA interrupt flag clear register (DMA_IFCR)
$40020008 constant DMA1_CCR1      \ offset: 0x08 : DMA channel configuration register (DMA_CCR)
$4002000c constant DMA1_CNDTR1    \ offset: 0x0C : DMA channel 1 number of data register
$40020010 constant DMA1_CPAR1     \ offset: 0x10 : DMA channel 1 peripheral address register
$40020014 constant DMA1_CMAR1     \ offset: 0x14 : DMA channel 1 memory address register
$4002001c constant DMA1_CCR2      \ offset: 0x1C : DMA channel configuration register (DMA_CCR)
$40020020 constant DMA1_CNDTR2    \ offset: 0x20 : DMA channel 2 number of data register
$40020024 constant DMA1_CPAR2     \ offset: 0x24 : DMA channel 2 peripheral address register
$40020028 constant DMA1_CMAR2     \ offset: 0x28 : DMA channel 2 memory address register
$40020030 constant DMA1_CCR3      \ offset: 0x30 : DMA channel configuration register (DMA_CCR)
$40020034 constant DMA1_CNDTR3    \ offset: 0x34 : DMA channel 3 number of data register
$40020038 constant DMA1_CPAR3     \ offset: 0x38 : DMA channel 3 peripheral address register
$4002003c constant DMA1_CMAR3     \ offset: 0x3C : DMA channel 3 memory address register
$40020044 constant DMA1_CCR4      \ offset: 0x44 : DMA channel configuration register (DMA_CCR)
$40020048 constant DMA1_CNDTR4    \ offset: 0x48 : DMA channel 4 number of data register
$4002004c constant DMA1_CPAR4     \ offset: 0x4C : DMA channel 4 peripheral address register
$40020050 constant DMA1_CMAR4     \ offset: 0x50 : DMA channel 4 memory address register
$40020058 constant DMA1_CCR5      \ offset: 0x58 : DMA channel configuration register (DMA_CCR)
$4002005c constant DMA1_CNDTR5    \ offset: 0x5C : DMA channel 5 number of data register
$40020060 constant DMA1_CPAR5     \ offset: 0x60 : DMA channel 5 peripheral address register
$40020064 constant DMA1_CMAR5     \ offset: 0x64 : DMA channel 5 memory address register
$4002006c constant DMA1_CCR6      \ offset: 0x6C : DMA channel configuration register (DMA_CCR)
$40020070 constant DMA1_CNDTR6    \ offset: 0x70 : DMA channel 6 number of data register
$40020074 constant DMA1_CPAR6     \ offset: 0x74 : DMA channel 6 peripheral address register
$40020078 constant DMA1_CMAR6     \ offset: 0x78 : DMA channel 6 memory address register
$40020080 constant DMA1_CCR7      \ offset: 0x80 : DMA channel configuration register (DMA_CCR)
$40020084 constant DMA1_CNDTR7    \ offset: 0x84 : DMA channel 7 number of data register
$40020088 constant DMA1_CPAR7     \ offset: 0x88 : DMA channel 7 peripheral address register
$4002008c constant DMA1_CMAR7     \ offset: 0x8C : DMA channel 7 memory address register

