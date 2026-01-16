\
\ @file dma1.fs
\ @brief DMA controller
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

$00000001 constant DMA1_ISR_GIF1                                    \ GIF1
$00000002 constant DMA1_ISR_TCIF1                                   \ TCIF1
$00000004 constant DMA1_ISR_HTIF1                                   \ HTIF1
$00000008 constant DMA1_ISR_TEIF1                                   \ TEIF1
$00000010 constant DMA1_ISR_GIF2                                    \ GIF2
$00000020 constant DMA1_ISR_TCIF2                                   \ TCIF2
$00000040 constant DMA1_ISR_HTIF2                                   \ HTIF2
$00000080 constant DMA1_ISR_TEIF2                                   \ TEIF2
$00000100 constant DMA1_ISR_GIF3                                    \ GIF3
$00000200 constant DMA1_ISR_TCIF3                                   \ TCIF3
$00000400 constant DMA1_ISR_HTIF3                                   \ HTIF3
$00000800 constant DMA1_ISR_TEIF3                                   \ TEIF3
$00001000 constant DMA1_ISR_GIF4                                    \ GIF4
$00002000 constant DMA1_ISR_TCIF4                                   \ TCIF4
$00004000 constant DMA1_ISR_HTIF4                                   \ HTIF4
$00008000 constant DMA1_ISR_TEIF4                                   \ TEIF4
$00010000 constant DMA1_ISR_GIF5                                    \ GIF5
$00020000 constant DMA1_ISR_TCIF5                                   \ TCIF5
$00040000 constant DMA1_ISR_HTIF5                                   \ HTIF5
$00080000 constant DMA1_ISR_TEIF5                                   \ TEIF5
$00100000 constant DMA1_ISR_GIF6                                    \ GIF6
$00200000 constant DMA1_ISR_TCIF6                                   \ TCIF6
$00400000 constant DMA1_ISR_HTIF6                                   \ HTIF6
$00800000 constant DMA1_ISR_TEIF6                                   \ TEIF6
$01000000 constant DMA1_ISR_GIF7                                    \ GIF7
$02000000 constant DMA1_ISR_TCIF7                                   \ TCIF7
$04000000 constant DMA1_ISR_HTIF7                                   \ HTIF7
$08000000 constant DMA1_ISR_TEIF7                                   \ TEIF7
$10000000 constant DMA1_ISR_GIF8                                    \ GIF8
$20000000 constant DMA1_ISR_TCIF8                                   \ TCIF8
$40000000 constant DMA1_ISR_HTIF8                                   \ HTIF8
$80000000 constant DMA1_ISR_TEIF8                                   \ TEIF8


\
\ @brief DMA interrupt flag clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA1_IFCR_GIF1                                   \ GIF1
$00000002 constant DMA1_IFCR_TCIF1                                  \ TCIF1
$00000004 constant DMA1_IFCR_HTIF1                                  \ HTIF1
$00000008 constant DMA1_IFCR_TEIF1                                  \ TEIF1
$00000010 constant DMA1_IFCR_GIF2                                   \ GIF2
$00000020 constant DMA1_IFCR_TCIF2                                  \ TCIF2
$00000040 constant DMA1_IFCR_HTIF2                                  \ HTIF2
$00000080 constant DMA1_IFCR_TEIF2                                  \ TEIF2
$00000100 constant DMA1_IFCR_GIF3                                   \ GIF3
$00000200 constant DMA1_IFCR_TCIF3                                  \ TCIF3
$00000400 constant DMA1_IFCR_HTIF3                                  \ HTIF3
$00000800 constant DMA1_IFCR_TEIF3                                  \ TEIF3
$00001000 constant DMA1_IFCR_GIF4                                   \ GIF4
$00002000 constant DMA1_IFCR_TCIF4                                  \ TCIF4
$00004000 constant DMA1_IFCR_HTIF4                                  \ HTIF4
$00008000 constant DMA1_IFCR_TEIF4                                  \ TEIF4
$00010000 constant DMA1_IFCR_GIF5                                   \ GIF5
$00020000 constant DMA1_IFCR_TCIF5                                  \ TCIF5
$00040000 constant DMA1_IFCR_HTIF5                                  \ HTIF5
$00080000 constant DMA1_IFCR_TEIF5                                  \ TEIF5
$00100000 constant DMA1_IFCR_GIF6                                   \ GIF6
$00200000 constant DMA1_IFCR_TCIF6                                  \ TCIF6
$00400000 constant DMA1_IFCR_HTIF6                                  \ HTIF6
$00800000 constant DMA1_IFCR_TEIF6                                  \ TEIF6
$01000000 constant DMA1_IFCR_GIF7                                   \ GIF7
$02000000 constant DMA1_IFCR_TCIF7                                  \ TCIF7
$04000000 constant DMA1_IFCR_HTIF7                                  \ HTIF7
$08000000 constant DMA1_IFCR_TEIF7                                  \ TEIF7
$10000000 constant DMA1_IFCR_GIF8                                   \ GIF8
$20000000 constant DMA1_IFCR_TCIF8                                  \ TCIF8
$40000000 constant DMA1_IFCR_HTIF8                                  \ HTIF8
$80000000 constant DMA1_IFCR_TEIF8                                  \ TEIF8


\
\ @brief DMA channel 1 configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR1_EN                                     \ channel enable
$00000002 constant DMA1_CCR1_TCIE                                   \ TCIE
$00000004 constant DMA1_CCR1_HTIE                                   \ HTIE
$00000008 constant DMA1_CCR1_TEIE                                   \ TEIE
$00000010 constant DMA1_CCR1_DIR                                    \ DIR
$00000020 constant DMA1_CCR1_CIRC                                   \ CIRC
$00000040 constant DMA1_CCR1_PINC                                   \ PINC
$00000080 constant DMA1_CCR1_MINC                                   \ MINC
$00000300 constant DMA1_CCR1_PSIZE                                  \ PSIZE
$00000c00 constant DMA1_CCR1_MSIZE                                  \ MSIZE
$00003000 constant DMA1_CCR1_PL                                     \ PL
$00004000 constant DMA1_CCR1_MEM2MEM                                \ MEM2MEM


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR1_NDT                                  \ Number of data items to transfer


\
\ @brief DMA channel x peripheral address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR1_PA                                    \ Peripheral address


\
\ @brief DMA channel x memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR1_MA                                    \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief DMA channel 2 configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR2_EN                                     \ channel enable
$00000002 constant DMA1_CCR2_TCIE                                   \ TCIE
$00000004 constant DMA1_CCR2_HTIE                                   \ HTIE
$00000008 constant DMA1_CCR2_TEIE                                   \ TEIE
$00000010 constant DMA1_CCR2_DIR                                    \ DIR
$00000020 constant DMA1_CCR2_CIRC                                   \ CIRC
$00000040 constant DMA1_CCR2_PINC                                   \ PINC
$00000080 constant DMA1_CCR2_MINC                                   \ MINC
$00000300 constant DMA1_CCR2_PSIZE                                  \ PSIZE
$00000c00 constant DMA1_CCR2_MSIZE                                  \ MSIZE
$00003000 constant DMA1_CCR2_PL                                     \ PL
$00004000 constant DMA1_CCR2_MEM2MEM                                \ MEM2MEM


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR2_NDT                                  \ Number of data items to transfer


\
\ @brief DMA channel x peripheral address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR2_PA                                    \ Peripheral address


\
\ @brief DMA channel x memory address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR2_MA                                    \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief DMA channel 3 configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR3_EN                                     \ channel enable
$00000002 constant DMA1_CCR3_TCIE                                   \ TCIE
$00000004 constant DMA1_CCR3_HTIE                                   \ HTIE
$00000008 constant DMA1_CCR3_TEIE                                   \ TEIE
$00000010 constant DMA1_CCR3_DIR                                    \ DIR
$00000020 constant DMA1_CCR3_CIRC                                   \ CIRC
$00000040 constant DMA1_CCR3_PINC                                   \ PINC
$00000080 constant DMA1_CCR3_MINC                                   \ MINC
$00000300 constant DMA1_CCR3_PSIZE                                  \ PSIZE
$00000c00 constant DMA1_CCR3_MSIZE                                  \ MSIZE
$00003000 constant DMA1_CCR3_PL                                     \ PL
$00004000 constant DMA1_CCR3_MEM2MEM                                \ MEM2MEM


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR3_NDT                                  \ Number of data items to transfer


\
\ @brief DMA channel x peripheral address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR3_PA                                    \ Peripheral address


\
\ @brief DMA channel x memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR3_MA                                    \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief DMA channel 3 configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR4_EN                                     \ channel enable
$00000002 constant DMA1_CCR4_TCIE                                   \ TCIE
$00000004 constant DMA1_CCR4_HTIE                                   \ HTIE
$00000008 constant DMA1_CCR4_TEIE                                   \ TEIE
$00000010 constant DMA1_CCR4_DIR                                    \ DIR
$00000020 constant DMA1_CCR4_CIRC                                   \ CIRC
$00000040 constant DMA1_CCR4_PINC                                   \ PINC
$00000080 constant DMA1_CCR4_MINC                                   \ MINC
$00000300 constant DMA1_CCR4_PSIZE                                  \ PSIZE
$00000c00 constant DMA1_CCR4_MSIZE                                  \ MSIZE
$00003000 constant DMA1_CCR4_PL                                     \ PL
$00004000 constant DMA1_CCR4_MEM2MEM                                \ MEM2MEM


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR4_NDT                                  \ Number of data items to transfer


\
\ @brief DMA channel x peripheral address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR4_PA                                    \ Peripheral address


\
\ @brief DMA channel x memory address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR4_MA                                    \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief DMA channel 4 configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR5_EN                                     \ channel enable
$00000002 constant DMA1_CCR5_TCIE                                   \ TCIE
$00000004 constant DMA1_CCR5_HTIE                                   \ HTIE
$00000008 constant DMA1_CCR5_TEIE                                   \ TEIE
$00000010 constant DMA1_CCR5_DIR                                    \ DIR
$00000020 constant DMA1_CCR5_CIRC                                   \ CIRC
$00000040 constant DMA1_CCR5_PINC                                   \ PINC
$00000080 constant DMA1_CCR5_MINC                                   \ MINC
$00000300 constant DMA1_CCR5_PSIZE                                  \ PSIZE
$00000c00 constant DMA1_CCR5_MSIZE                                  \ MSIZE
$00003000 constant DMA1_CCR5_PL                                     \ PL
$00004000 constant DMA1_CCR5_MEM2MEM                                \ MEM2MEM


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR5_NDT                                  \ Number of data items to transfer


\
\ @brief DMA channel x peripheral address register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR5_PA                                    \ Peripheral address


\
\ @brief DMA channel x memory address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR5_MA                                    \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief DMA channel 5 configuration register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR6_EN                                     \ channel enable
$00000002 constant DMA1_CCR6_TCIE                                   \ TCIE
$00000004 constant DMA1_CCR6_HTIE                                   \ HTIE
$00000008 constant DMA1_CCR6_TEIE                                   \ TEIE
$00000010 constant DMA1_CCR6_DIR                                    \ DIR
$00000020 constant DMA1_CCR6_CIRC                                   \ CIRC
$00000040 constant DMA1_CCR6_PINC                                   \ PINC
$00000080 constant DMA1_CCR6_MINC                                   \ MINC
$00000300 constant DMA1_CCR6_PSIZE                                  \ PSIZE
$00000c00 constant DMA1_CCR6_MSIZE                                  \ MSIZE
$00003000 constant DMA1_CCR6_PL                                     \ PL
$00004000 constant DMA1_CCR6_MEM2MEM                                \ MEM2MEM


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR6_NDT                                  \ Number of data items to transfer


\
\ @brief DMA channel x peripheral address register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR6_PA                                    \ Peripheral address


\
\ @brief DMA channel x memory address register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR6_MA                                    \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief DMA channel 6 configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR7_EN                                     \ channel enable
$00000002 constant DMA1_CCR7_TCIE                                   \ TCIE
$00000004 constant DMA1_CCR7_HTIE                                   \ HTIE
$00000008 constant DMA1_CCR7_TEIE                                   \ TEIE
$00000010 constant DMA1_CCR7_DIR                                    \ DIR
$00000020 constant DMA1_CCR7_CIRC                                   \ CIRC
$00000040 constant DMA1_CCR7_PINC                                   \ PINC
$00000080 constant DMA1_CCR7_MINC                                   \ MINC
$00000300 constant DMA1_CCR7_PSIZE                                  \ PSIZE
$00000c00 constant DMA1_CCR7_MSIZE                                  \ MSIZE
$00003000 constant DMA1_CCR7_PL                                     \ PL
$00004000 constant DMA1_CCR7_MEM2MEM                                \ MEM2MEM


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR7_NDT                                  \ Number of data items to transfer


\
\ @brief DMA channel x peripheral address register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR7_PA                                    \ Peripheral address


\
\ @brief DMA channel x memory address register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR7_MA                                    \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief DMA channel 7 configuration register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR8_EN                                     \ channel enable
$00000002 constant DMA1_CCR8_TCIE                                   \ TCIE
$00000004 constant DMA1_CCR8_HTIE                                   \ HTIE
$00000008 constant DMA1_CCR8_TEIE                                   \ TEIE
$00000010 constant DMA1_CCR8_DIR                                    \ DIR
$00000020 constant DMA1_CCR8_CIRC                                   \ CIRC
$00000040 constant DMA1_CCR8_PINC                                   \ PINC
$00000080 constant DMA1_CCR8_MINC                                   \ MINC
$00000300 constant DMA1_CCR8_PSIZE                                  \ PSIZE
$00000c00 constant DMA1_CCR8_MSIZE                                  \ MSIZE
$00003000 constant DMA1_CCR8_PL                                     \ PL
$00004000 constant DMA1_CCR8_MEM2MEM                                \ MEM2MEM


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_CNDTR8_NDT                                  \ Number of data items to transfer


\
\ @brief DMA channel x peripheral address register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR8_PA                                    \ Peripheral address


\
\ @brief DMA channel x memory address register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR8_MA                                    \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief DMA controller
\
$40020000 constant DMA1_ISR       \ offset: 0x00 : interrupt status register
$40020004 constant DMA1_IFCR      \ offset: 0x04 : DMA interrupt flag clear register
$40020008 constant DMA1_CCR1      \ offset: 0x08 : DMA channel 1 configuration register
$4002000c constant DMA1_CNDTR1    \ offset: 0x0C : channel x number of data to transfer register
$40020010 constant DMA1_CPAR1     \ offset: 0x10 : DMA channel x peripheral address register
$40020014 constant DMA1_CMAR1     \ offset: 0x14 : DMA channel x memory address register
$4002001c constant DMA1_CCR2      \ offset: 0x1C : DMA channel 2 configuration register
$40020020 constant DMA1_CNDTR2    \ offset: 0x20 : channel x number of data to transfer register
$40020024 constant DMA1_CPAR2     \ offset: 0x24 : DMA channel x peripheral address register
$40020028 constant DMA1_CMAR2     \ offset: 0x28 : DMA channel x memory address register
$40020030 constant DMA1_CCR3      \ offset: 0x30 : DMA channel 3 configuration register
$40020034 constant DMA1_CNDTR3    \ offset: 0x34 : channel x number of data to transfer register
$40020038 constant DMA1_CPAR3     \ offset: 0x38 : DMA channel x peripheral address register
$4002003c constant DMA1_CMAR3     \ offset: 0x3C : DMA channel x memory address register
$40020044 constant DMA1_CCR4      \ offset: 0x44 : DMA channel 3 configuration register
$40020048 constant DMA1_CNDTR4    \ offset: 0x48 : channel x number of data to transfer register
$4002004c constant DMA1_CPAR4     \ offset: 0x4C : DMA channel x peripheral address register
$40020050 constant DMA1_CMAR4     \ offset: 0x50 : DMA channel x memory address register
$40020058 constant DMA1_CCR5      \ offset: 0x58 : DMA channel 4 configuration register
$4002005c constant DMA1_CNDTR5    \ offset: 0x5C : channel x number of data to transfer register
$40020060 constant DMA1_CPAR5     \ offset: 0x60 : DMA channel x peripheral address register
$40020064 constant DMA1_CMAR5     \ offset: 0x64 : DMA channel x memory address register
$4002006c constant DMA1_CCR6      \ offset: 0x6C : DMA channel 5 configuration register
$40020070 constant DMA1_CNDTR6    \ offset: 0x70 : channel x number of data to transfer register
$40020074 constant DMA1_CPAR6     \ offset: 0x74 : DMA channel x peripheral address register
$40020078 constant DMA1_CMAR6     \ offset: 0x78 : DMA channel x memory address register
$40020080 constant DMA1_CCR7      \ offset: 0x80 : DMA channel 6 configuration register
$40020084 constant DMA1_CNDTR7    \ offset: 0x84 : channel x number of data to transfer register
$40020088 constant DMA1_CPAR7     \ offset: 0x88 : DMA channel x peripheral address register
$4002008c constant DMA1_CMAR7     \ offset: 0x8C : DMA channel x memory address register
$40020094 constant DMA1_CCR8      \ offset: 0x94 : DMA channel 7 configuration register
$40020098 constant DMA1_CNDTR8    \ offset: 0x98 : channel x number of data to transfer register
$4002009c constant DMA1_CPAR8     \ offset: 0x9C : DMA channel x peripheral address register
$400200a0 constant DMA1_CMAR8     \ offset: 0xA0 : DMA channel x memory address register

