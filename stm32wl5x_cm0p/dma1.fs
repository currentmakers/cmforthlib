\
\ @file dma1.fs
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

$00000001 constant DMA1_ISR_GIF1                                    \ global interrupt flag for channel 1
$00000002 constant DMA1_ISR_TCIF1                                   \ transfer complete (TC) flag for channel 1
$00000004 constant DMA1_ISR_HTIF1                                   \ half transfer (HT) flag for channel 1
$00000008 constant DMA1_ISR_TEIF1                                   \ transfer error (TE) flag for channel 1
$00000010 constant DMA1_ISR_GIF2                                    \ global interrupt flag for channel 2
$00000020 constant DMA1_ISR_TCIF2                                   \ transfer complete (TC) flag for channel 2
$00000040 constant DMA1_ISR_HTIF2                                   \ half transfer (HT) flag for channel 2
$00000080 constant DMA1_ISR_TEIF2                                   \ transfer error (TE) flag for channel 2
$00000100 constant DMA1_ISR_GIF3                                    \ global interrupt flag for channel 3
$00000200 constant DMA1_ISR_TCIF3                                   \ transfer complete (TC) flag for channel 3
$00000400 constant DMA1_ISR_HTIF3                                   \ half transfer (HT) flag for channel 3
$00000800 constant DMA1_ISR_TEIF3                                   \ transfer error (TE) flag for channel 3
$00001000 constant DMA1_ISR_GIF4                                    \ global interrupt flag for channel 4
$00002000 constant DMA1_ISR_TCIF4                                   \ transfer complete (TC) flag for channel 4
$00004000 constant DMA1_ISR_HTIF4                                   \ half transfer (HT) flag for channel 4
$00008000 constant DMA1_ISR_TEIF4                                   \ transfer error (TE) flag for channel 4
$00010000 constant DMA1_ISR_GIF5                                    \ global interrupt flag for channel 5
$00020000 constant DMA1_ISR_TCIF5                                   \ transfer complete (TC) flag for channel 5
$00040000 constant DMA1_ISR_HTIF5                                   \ half transfer (HT) flag for channel 5
$00080000 constant DMA1_ISR_TEIF5                                   \ transfer error (TE) flag for channel 5
$00100000 constant DMA1_ISR_GIF6                                    \ global interrupt flag for channel 6
$00200000 constant DMA1_ISR_TCIF6                                   \ transfer complete (TC) flag for channel 6
$00400000 constant DMA1_ISR_HTIF6                                   \ half transfer (HT) flag for channel 6
$00800000 constant DMA1_ISR_TEIF6                                   \ transfer error (TE) flag for channel 6
$01000000 constant DMA1_ISR_GIF7                                    \ global interrupt flag for channel 7
$02000000 constant DMA1_ISR_TCIF7                                   \ transfer complete (TC) flag for channel 7
$04000000 constant DMA1_ISR_HTIF7                                   \ half transfer (HT) flag for channel 7
$08000000 constant DMA1_ISR_TEIF7                                   \ transfer error (TE) flag for channel 7


\
\ @brief interrupt flag clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA1_IFCR_GIF1                                   \ global interrupt flag clear for channel 1
$00000002 constant DMA1_IFCR_TCIF1                                  \ transfer complete flag clear for channel 1
$00000004 constant DMA1_IFCR_HTIF1                                  \ half transfer flag clear for channel 1
$00000008 constant DMA1_IFCR_TEIF1                                  \ transfer error flag clear for channel 1
$00000010 constant DMA1_IFCR_GIF2                                   \ global interrupt flag clear for channel 2
$00000020 constant DMA1_IFCR_TCIF2                                  \ transfer complete flag clear for channel 2
$00000040 constant DMA1_IFCR_HTIF2                                  \ half transfer flag clear for channel 2
$00000080 constant DMA1_IFCR_TEIF2                                  \ transfer error flag clear for channel 2
$00000100 constant DMA1_IFCR_GIF3                                   \ global interrupt flag clear for channel 3
$00000200 constant DMA1_IFCR_TCIF3                                  \ transfer complete flag clear for channel 3
$00000400 constant DMA1_IFCR_HTIF3                                  \ half transfer flag clear for channel 3
$00000800 constant DMA1_IFCR_TEIF3                                  \ transfer error flag clear for channel 3
$00001000 constant DMA1_IFCR_GIF4                                   \ global interrupt flag clear for channel 4
$00002000 constant DMA1_IFCR_TCIF4                                  \ transfer complete flag clear for channel 4
$00004000 constant DMA1_IFCR_HTIF4                                  \ half transfer flag clear for channel 4
$00008000 constant DMA1_IFCR_TEIF4                                  \ transfer error flag clear for channel 4
$00010000 constant DMA1_IFCR_GIF5                                   \ global interrupt flag clear for channel 5
$00020000 constant DMA1_IFCR_TCIF5                                  \ transfer complete flag clear for channel 5
$00040000 constant DMA1_IFCR_HTIF5                                  \ half transfer flag clear for channel 5
$00080000 constant DMA1_IFCR_TEIF5                                  \ transfer error flag clear for channel 5
$00100000 constant DMA1_IFCR_GIF6                                   \ global interrupt flag clear for channel 6
$00200000 constant DMA1_IFCR_TCIF6                                  \ transfer complete flag clear for channel 6
$00400000 constant DMA1_IFCR_HTIF6                                  \ half transfer flag clear for channel 6
$00800000 constant DMA1_IFCR_TEIF6                                  \ transfer error flag clear for channel 6
$01000000 constant DMA1_IFCR_GIF7                                   \ global interrupt flag clear for channel 7
$02000000 constant DMA1_IFCR_TCIF7                                  \ transfer complete flag clear for channel 7
$04000000 constant DMA1_IFCR_HTIF7                                  \ half transfer flag clear for channel 7
$08000000 constant DMA1_IFCR_TEIF7                                  \ transfer error flag clear for channel 7


\
\ @brief channel x configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR1_EN                                     \ channel enable
$00000002 constant DMA1_CCR1_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA1_CCR1_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA1_CCR1_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA1_CCR1_DIR                                    \ data transfer direction
$00000020 constant DMA1_CCR1_CIRC                                   \ circular mode
$00000040 constant DMA1_CCR1_PINC                                   \ peripheral increment mode
$00000080 constant DMA1_CCR1_MINC                                   \ memory increment mode
$00000300 constant DMA1_CCR1_PSIZE                                  \ peripheral size
$00000c00 constant DMA1_CCR1_MSIZE                                  \ memory size
$00003000 constant DMA1_CCR1_PL                                     \ priority level
$00004000 constant DMA1_CCR1_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA1_CCR1_SECM                                   \ ecure mode
$00040000 constant DMA1_CCR1_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA1_CCR1_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA1_CCR1_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0003ffff constant DMA1_CNDTR1_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR1_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR1_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR2_EN                                     \ channel enable
$00000002 constant DMA1_CCR2_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA1_CCR2_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA1_CCR2_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA1_CCR2_DIR                                    \ data transfer direction
$00000020 constant DMA1_CCR2_CIRC                                   \ circular mode
$00000040 constant DMA1_CCR2_PINC                                   \ peripheral increment mode
$00000080 constant DMA1_CCR2_MINC                                   \ memory increment mode
$00000300 constant DMA1_CCR2_PSIZE                                  \ peripheral size
$00000c00 constant DMA1_CCR2_MSIZE                                  \ memory size
$00003000 constant DMA1_CCR2_PL                                     \ priority level
$00004000 constant DMA1_CCR2_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA1_CCR2_SECM                                   \ ecure mode
$00040000 constant DMA1_CCR2_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA1_CCR2_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA1_CCR2_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0003ffff constant DMA1_CNDTR2_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR2_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR2_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR3_EN                                     \ channel enable
$00000002 constant DMA1_CCR3_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA1_CCR3_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA1_CCR3_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA1_CCR3_DIR                                    \ data transfer direction
$00000020 constant DMA1_CCR3_CIRC                                   \ circular mode
$00000040 constant DMA1_CCR3_PINC                                   \ peripheral increment mode
$00000080 constant DMA1_CCR3_MINC                                   \ memory increment mode
$00000300 constant DMA1_CCR3_PSIZE                                  \ peripheral size
$00000c00 constant DMA1_CCR3_MSIZE                                  \ memory size
$00003000 constant DMA1_CCR3_PL                                     \ priority level
$00004000 constant DMA1_CCR3_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA1_CCR3_SECM                                   \ ecure mode
$00040000 constant DMA1_CCR3_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA1_CCR3_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA1_CCR3_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0003ffff constant DMA1_CNDTR3_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR3_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR3_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR4_EN                                     \ channel enable
$00000002 constant DMA1_CCR4_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA1_CCR4_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA1_CCR4_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA1_CCR4_DIR                                    \ data transfer direction
$00000020 constant DMA1_CCR4_CIRC                                   \ circular mode
$00000040 constant DMA1_CCR4_PINC                                   \ peripheral increment mode
$00000080 constant DMA1_CCR4_MINC                                   \ memory increment mode
$00000300 constant DMA1_CCR4_PSIZE                                  \ peripheral size
$00000c00 constant DMA1_CCR4_MSIZE                                  \ memory size
$00003000 constant DMA1_CCR4_PL                                     \ priority level
$00004000 constant DMA1_CCR4_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA1_CCR4_SECM                                   \ ecure mode
$00040000 constant DMA1_CCR4_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA1_CCR4_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA1_CCR4_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0003ffff constant DMA1_CNDTR4_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR4_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR4_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR5_EN                                     \ channel enable
$00000002 constant DMA1_CCR5_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA1_CCR5_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA1_CCR5_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA1_CCR5_DIR                                    \ data transfer direction
$00000020 constant DMA1_CCR5_CIRC                                   \ circular mode
$00000040 constant DMA1_CCR5_PINC                                   \ peripheral increment mode
$00000080 constant DMA1_CCR5_MINC                                   \ memory increment mode
$00000300 constant DMA1_CCR5_PSIZE                                  \ peripheral size
$00000c00 constant DMA1_CCR5_MSIZE                                  \ memory size
$00003000 constant DMA1_CCR5_PL                                     \ priority level
$00004000 constant DMA1_CCR5_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA1_CCR5_SECM                                   \ ecure mode
$00040000 constant DMA1_CCR5_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA1_CCR5_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA1_CCR5_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0003ffff constant DMA1_CNDTR5_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR5_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR5_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR6_EN                                     \ channel enable
$00000002 constant DMA1_CCR6_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA1_CCR6_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA1_CCR6_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA1_CCR6_DIR                                    \ data transfer direction
$00000020 constant DMA1_CCR6_CIRC                                   \ circular mode
$00000040 constant DMA1_CCR6_PINC                                   \ peripheral increment mode
$00000080 constant DMA1_CCR6_MINC                                   \ memory increment mode
$00000300 constant DMA1_CCR6_PSIZE                                  \ peripheral size
$00000c00 constant DMA1_CCR6_MSIZE                                  \ memory size
$00003000 constant DMA1_CCR6_PL                                     \ priority level
$00004000 constant DMA1_CCR6_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA1_CCR6_SECM                                   \ ecure mode
$00040000 constant DMA1_CCR6_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA1_CCR6_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA1_CCR6_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0003ffff constant DMA1_CNDTR6_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR6_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR6_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMA1_CCR7_EN                                     \ channel enable
$00000002 constant DMA1_CCR7_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA1_CCR7_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA1_CCR7_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA1_CCR7_DIR                                    \ data transfer direction
$00000020 constant DMA1_CCR7_CIRC                                   \ circular mode
$00000040 constant DMA1_CCR7_PINC                                   \ peripheral increment mode
$00000080 constant DMA1_CCR7_MINC                                   \ memory increment mode
$00000300 constant DMA1_CCR7_PSIZE                                  \ peripheral size
$00000c00 constant DMA1_CCR7_MSIZE                                  \ memory size
$00003000 constant DMA1_CCR7_PL                                     \ priority level
$00004000 constant DMA1_CCR7_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA1_CCR7_SECM                                   \ ecure mode
$00040000 constant DMA1_CCR7_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA1_CCR7_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA1_CCR7_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0003ffff constant DMA1_CNDTR7_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CPAR7_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_CMAR7_MA                                    \ peripheral address


\
\ @brief Direct memory access controller
\
$40020000 constant DMA1_ISR       \ offset: 0x00 : interrupt status register
$40020004 constant DMA1_IFCR      \ offset: 0x04 : interrupt flag clear register
$40020008 constant DMA1_CCR1      \ offset: 0x08 : channel x configuration register
$4002000c constant DMA1_CNDTR1    \ offset: 0x0C : channel x number of data to transfer register
$40020010 constant DMA1_CPAR1     \ offset: 0x10 : channel x peripheral address register
$40020014 constant DMA1_CMAR1     \ offset: 0x14 : channel x memory address register
$4002001c constant DMA1_CCR2      \ offset: 0x1C : channel x configuration register
$40020020 constant DMA1_CNDTR2    \ offset: 0x20 : channel x number of data to transfer register
$40020024 constant DMA1_CPAR2     \ offset: 0x24 : channel x peripheral address register
$40020028 constant DMA1_CMAR2     \ offset: 0x28 : channel x memory address register
$40020030 constant DMA1_CCR3      \ offset: 0x30 : channel x configuration register
$40020034 constant DMA1_CNDTR3    \ offset: 0x34 : channel x number of data to transfer register
$40020038 constant DMA1_CPAR3     \ offset: 0x38 : channel x peripheral address register
$4002003c constant DMA1_CMAR3     \ offset: 0x3C : channel x memory address register
$40020044 constant DMA1_CCR4      \ offset: 0x44 : channel x configuration register
$40020048 constant DMA1_CNDTR4    \ offset: 0x48 : channel x number of data to transfer register
$4002004c constant DMA1_CPAR4     \ offset: 0x4C : channel x peripheral address register
$40020050 constant DMA1_CMAR4     \ offset: 0x50 : channel x memory address register
$40020058 constant DMA1_CCR5      \ offset: 0x58 : channel x configuration register
$4002005c constant DMA1_CNDTR5    \ offset: 0x5C : channel x number of data to transfer register
$40020060 constant DMA1_CPAR5     \ offset: 0x60 : channel x peripheral address register
$40020064 constant DMA1_CMAR5     \ offset: 0x64 : channel x memory address register
$4002006c constant DMA1_CCR6      \ offset: 0x6C : channel x configuration register
$40020070 constant DMA1_CNDTR6    \ offset: 0x70 : channel x number of data to transfer register
$40020074 constant DMA1_CPAR6     \ offset: 0x74 : channel x peripheral address register
$40020078 constant DMA1_CMAR6     \ offset: 0x78 : channel x memory address register
$40020080 constant DMA1_CCR7      \ offset: 0x80 : channel x configuration register
$40020084 constant DMA1_CNDTR7    \ offset: 0x84 : channel x number of data to transfer register
$40020088 constant DMA1_CPAR7     \ offset: 0x88 : channel x peripheral address register
$4002008c constant DMA1_CMAR7     \ offset: 0x8C : channel x memory address register

