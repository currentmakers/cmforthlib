\
\ @file dma2.fs
\ @brief DMA2 channel 7:1 secure and non-secure interrupt        (C2IMR2[14:8]),DMAMUX1 overrun interrupt (C2IMR2[15])
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

$00000001 constant DMA2_ISR_GIF1                                    \ global interrupt flag for channel 1
$00000002 constant DMA2_ISR_TCIF1                                   \ transfer complete (TC) flag for channel 1
$00000004 constant DMA2_ISR_HTIF1                                   \ half transfer (HT) flag for channel 1
$00000008 constant DMA2_ISR_TEIF1                                   \ transfer error (TE) flag for channel 1
$00000010 constant DMA2_ISR_GIF2                                    \ global interrupt flag for channel 2
$00000020 constant DMA2_ISR_TCIF2                                   \ transfer complete (TC) flag for channel 2
$00000040 constant DMA2_ISR_HTIF2                                   \ half transfer (HT) flag for channel 2
$00000080 constant DMA2_ISR_TEIF2                                   \ transfer error (TE) flag for channel 2
$00000100 constant DMA2_ISR_GIF3                                    \ global interrupt flag for channel 3
$00000200 constant DMA2_ISR_TCIF3                                   \ transfer complete (TC) flag for channel 3
$00000400 constant DMA2_ISR_HTIF3                                   \ half transfer (HT) flag for channel 3
$00000800 constant DMA2_ISR_TEIF3                                   \ transfer error (TE) flag for channel 3
$00001000 constant DMA2_ISR_GIF4                                    \ global interrupt flag for channel 4
$00002000 constant DMA2_ISR_TCIF4                                   \ transfer complete (TC) flag for channel 4
$00004000 constant DMA2_ISR_HTIF4                                   \ half transfer (HT) flag for channel 4
$00008000 constant DMA2_ISR_TEIF4                                   \ transfer error (TE) flag for channel 4
$00010000 constant DMA2_ISR_GIF5                                    \ global interrupt flag for channel 5
$00020000 constant DMA2_ISR_TCIF5                                   \ transfer complete (TC) flag for channel 5
$00040000 constant DMA2_ISR_HTIF5                                   \ half transfer (HT) flag for channel 5
$00080000 constant DMA2_ISR_TEIF5                                   \ transfer error (TE) flag for channel 5
$00100000 constant DMA2_ISR_GIF6                                    \ global interrupt flag for channel 6
$00200000 constant DMA2_ISR_TCIF6                                   \ transfer complete (TC) flag for channel 6
$00400000 constant DMA2_ISR_HTIF6                                   \ half transfer (HT) flag for channel 6
$00800000 constant DMA2_ISR_TEIF6                                   \ transfer error (TE) flag for channel 6
$01000000 constant DMA2_ISR_GIF7                                    \ global interrupt flag for channel 7
$02000000 constant DMA2_ISR_TCIF7                                   \ transfer complete (TC) flag for channel 7
$04000000 constant DMA2_ISR_HTIF7                                   \ half transfer (HT) flag for channel 7
$08000000 constant DMA2_ISR_TEIF7                                   \ transfer error (TE) flag for channel 7


\
\ @brief interrupt flag clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA2_IFCR_GIF1                                   \ global interrupt flag clear for channel 1
$00000002 constant DMA2_IFCR_TCIF1                                  \ transfer complete flag clear for channel 1
$00000004 constant DMA2_IFCR_HTIF1                                  \ half transfer flag clear for channel 1
$00000008 constant DMA2_IFCR_TEIF1                                  \ transfer error flag clear for channel 1
$00000010 constant DMA2_IFCR_GIF2                                   \ global interrupt flag clear for channel 2
$00000020 constant DMA2_IFCR_TCIF2                                  \ transfer complete flag clear for channel 2
$00000040 constant DMA2_IFCR_HTIF2                                  \ half transfer flag clear for channel 2
$00000080 constant DMA2_IFCR_TEIF2                                  \ transfer error flag clear for channel 2
$00000100 constant DMA2_IFCR_GIF3                                   \ global interrupt flag clear for channel 3
$00000200 constant DMA2_IFCR_TCIF3                                  \ transfer complete flag clear for channel 3
$00000400 constant DMA2_IFCR_HTIF3                                  \ half transfer flag clear for channel 3
$00000800 constant DMA2_IFCR_TEIF3                                  \ transfer error flag clear for channel 3
$00001000 constant DMA2_IFCR_GIF4                                   \ global interrupt flag clear for channel 4
$00002000 constant DMA2_IFCR_TCIF4                                  \ transfer complete flag clear for channel 4
$00004000 constant DMA2_IFCR_HTIF4                                  \ half transfer flag clear for channel 4
$00008000 constant DMA2_IFCR_TEIF4                                  \ transfer error flag clear for channel 4
$00010000 constant DMA2_IFCR_GIF5                                   \ global interrupt flag clear for channel 5
$00020000 constant DMA2_IFCR_TCIF5                                  \ transfer complete flag clear for channel 5
$00040000 constant DMA2_IFCR_HTIF5                                  \ half transfer flag clear for channel 5
$00080000 constant DMA2_IFCR_TEIF5                                  \ transfer error flag clear for channel 5
$00100000 constant DMA2_IFCR_GIF6                                   \ global interrupt flag clear for channel 6
$00200000 constant DMA2_IFCR_TCIF6                                  \ transfer complete flag clear for channel 6
$00400000 constant DMA2_IFCR_HTIF6                                  \ half transfer flag clear for channel 6
$00800000 constant DMA2_IFCR_TEIF6                                  \ transfer error flag clear for channel 6
$01000000 constant DMA2_IFCR_GIF7                                   \ global interrupt flag clear for channel 7
$02000000 constant DMA2_IFCR_TCIF7                                  \ transfer complete flag clear for channel 7
$04000000 constant DMA2_IFCR_HTIF7                                  \ half transfer flag clear for channel 7
$08000000 constant DMA2_IFCR_TEIF7                                  \ transfer error flag clear for channel 7


\
\ @brief channel x configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR1_EN                                     \ channel enable
$00000002 constant DMA2_CCR1_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA2_CCR1_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA2_CCR1_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA2_CCR1_DIR                                    \ data transfer direction
$00000020 constant DMA2_CCR1_CIRC                                   \ circular mode
$00000040 constant DMA2_CCR1_PINC                                   \ peripheral increment mode
$00000080 constant DMA2_CCR1_MINC                                   \ memory increment mode
$00000300 constant DMA2_CCR1_PSIZE                                  \ peripheral size
$00000c00 constant DMA2_CCR1_MSIZE                                  \ memory size
$00003000 constant DMA2_CCR1_PL                                     \ priority level
$00004000 constant DMA2_CCR1_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA2_CCR1_SECM                                   \ ecure mode
$00040000 constant DMA2_CCR1_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA2_CCR1_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA2_CCR1_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0003ffff constant DMA2_CNDTR1_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR1_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR1_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR2_EN                                     \ channel enable
$00000002 constant DMA2_CCR2_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA2_CCR2_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA2_CCR2_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA2_CCR2_DIR                                    \ data transfer direction
$00000020 constant DMA2_CCR2_CIRC                                   \ circular mode
$00000040 constant DMA2_CCR2_PINC                                   \ peripheral increment mode
$00000080 constant DMA2_CCR2_MINC                                   \ memory increment mode
$00000300 constant DMA2_CCR2_PSIZE                                  \ peripheral size
$00000c00 constant DMA2_CCR2_MSIZE                                  \ memory size
$00003000 constant DMA2_CCR2_PL                                     \ priority level
$00004000 constant DMA2_CCR2_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA2_CCR2_SECM                                   \ ecure mode
$00040000 constant DMA2_CCR2_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA2_CCR2_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA2_CCR2_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0003ffff constant DMA2_CNDTR2_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR2_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR2_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR3_EN                                     \ channel enable
$00000002 constant DMA2_CCR3_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA2_CCR3_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA2_CCR3_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA2_CCR3_DIR                                    \ data transfer direction
$00000020 constant DMA2_CCR3_CIRC                                   \ circular mode
$00000040 constant DMA2_CCR3_PINC                                   \ peripheral increment mode
$00000080 constant DMA2_CCR3_MINC                                   \ memory increment mode
$00000300 constant DMA2_CCR3_PSIZE                                  \ peripheral size
$00000c00 constant DMA2_CCR3_MSIZE                                  \ memory size
$00003000 constant DMA2_CCR3_PL                                     \ priority level
$00004000 constant DMA2_CCR3_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA2_CCR3_SECM                                   \ ecure mode
$00040000 constant DMA2_CCR3_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA2_CCR3_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA2_CCR3_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0003ffff constant DMA2_CNDTR3_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR3_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR3_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR4_EN                                     \ channel enable
$00000002 constant DMA2_CCR4_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA2_CCR4_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA2_CCR4_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA2_CCR4_DIR                                    \ data transfer direction
$00000020 constant DMA2_CCR4_CIRC                                   \ circular mode
$00000040 constant DMA2_CCR4_PINC                                   \ peripheral increment mode
$00000080 constant DMA2_CCR4_MINC                                   \ memory increment mode
$00000300 constant DMA2_CCR4_PSIZE                                  \ peripheral size
$00000c00 constant DMA2_CCR4_MSIZE                                  \ memory size
$00003000 constant DMA2_CCR4_PL                                     \ priority level
$00004000 constant DMA2_CCR4_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA2_CCR4_SECM                                   \ ecure mode
$00040000 constant DMA2_CCR4_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA2_CCR4_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA2_CCR4_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0003ffff constant DMA2_CNDTR4_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR4_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR4_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR5_EN                                     \ channel enable
$00000002 constant DMA2_CCR5_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA2_CCR5_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA2_CCR5_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA2_CCR5_DIR                                    \ data transfer direction
$00000020 constant DMA2_CCR5_CIRC                                   \ circular mode
$00000040 constant DMA2_CCR5_PINC                                   \ peripheral increment mode
$00000080 constant DMA2_CCR5_MINC                                   \ memory increment mode
$00000300 constant DMA2_CCR5_PSIZE                                  \ peripheral size
$00000c00 constant DMA2_CCR5_MSIZE                                  \ memory size
$00003000 constant DMA2_CCR5_PL                                     \ priority level
$00004000 constant DMA2_CCR5_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA2_CCR5_SECM                                   \ ecure mode
$00040000 constant DMA2_CCR5_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA2_CCR5_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA2_CCR5_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0003ffff constant DMA2_CNDTR5_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR5_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR5_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR6_EN                                     \ channel enable
$00000002 constant DMA2_CCR6_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA2_CCR6_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA2_CCR6_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA2_CCR6_DIR                                    \ data transfer direction
$00000020 constant DMA2_CCR6_CIRC                                   \ circular mode
$00000040 constant DMA2_CCR6_PINC                                   \ peripheral increment mode
$00000080 constant DMA2_CCR6_MINC                                   \ memory increment mode
$00000300 constant DMA2_CCR6_PSIZE                                  \ peripheral size
$00000c00 constant DMA2_CCR6_MSIZE                                  \ memory size
$00003000 constant DMA2_CCR6_PL                                     \ priority level
$00004000 constant DMA2_CCR6_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA2_CCR6_SECM                                   \ ecure mode
$00040000 constant DMA2_CCR6_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA2_CCR6_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA2_CCR6_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0003ffff constant DMA2_CNDTR6_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR6_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR6_MA                                    \ peripheral address


\
\ @brief channel x configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant DMA2_CCR7_EN                                     \ channel enable
$00000002 constant DMA2_CCR7_TCIE                                   \ transfer complete interrupt enable
$00000004 constant DMA2_CCR7_HTIE                                   \ half transfer interrupt enable
$00000008 constant DMA2_CCR7_TEIE                                   \ transfer error interrupt enable
$00000010 constant DMA2_CCR7_DIR                                    \ data transfer direction
$00000020 constant DMA2_CCR7_CIRC                                   \ circular mode
$00000040 constant DMA2_CCR7_PINC                                   \ peripheral increment mode
$00000080 constant DMA2_CCR7_MINC                                   \ memory increment mode
$00000300 constant DMA2_CCR7_PSIZE                                  \ peripheral size
$00000c00 constant DMA2_CCR7_MSIZE                                  \ memory size
$00003000 constant DMA2_CCR7_PL                                     \ priority level
$00004000 constant DMA2_CCR7_MEM2MEM                                \ memory-to-memory mode
$00020000 constant DMA2_CCR7_SECM                                   \ ecure mode
$00040000 constant DMA2_CCR7_SSEC                                   \ ecurity of the DMA transfer from the source
$00080000 constant DMA2_CCR7_DSEC                                   \ ecurity of the DMA transfer to the destination
$00100000 constant DMA2_CCR7_PRIV                                   \ rivileged mode


\
\ @brief channel x number of data to transfer register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0003ffff constant DMA2_CNDTR7_NDT                                  \ number of data to transfer (0 to 218 - 1)


\
\ @brief channel x peripheral address register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CPAR7_PA                                    \ peripheral address


\
\ @brief channel x memory address register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_CMAR7_MA                                    \ peripheral address


\
\ @brief DMA2 channel 7:1 secure and non-secure interrupt (C2IMR2[14:8]),DMAMUX1 overrun interrupt (C2IMR2[15])
\
$40020400 constant DMA2_ISR       \ offset: 0x00 : interrupt status register
$40020404 constant DMA2_IFCR      \ offset: 0x04 : interrupt flag clear register
$40020408 constant DMA2_CCR1      \ offset: 0x08 : channel x configuration register
$4002040c constant DMA2_CNDTR1    \ offset: 0x0C : channel x number of data to transfer register
$40020410 constant DMA2_CPAR1     \ offset: 0x10 : channel x peripheral address register
$40020414 constant DMA2_CMAR1     \ offset: 0x14 : channel x memory address register
$4002041c constant DMA2_CCR2      \ offset: 0x1C : channel x configuration register
$40020420 constant DMA2_CNDTR2    \ offset: 0x20 : channel x number of data to transfer register
$40020424 constant DMA2_CPAR2     \ offset: 0x24 : channel x peripheral address register
$40020428 constant DMA2_CMAR2     \ offset: 0x28 : channel x memory address register
$40020430 constant DMA2_CCR3      \ offset: 0x30 : channel x configuration register
$40020434 constant DMA2_CNDTR3    \ offset: 0x34 : channel x number of data to transfer register
$40020438 constant DMA2_CPAR3     \ offset: 0x38 : channel x peripheral address register
$4002043c constant DMA2_CMAR3     \ offset: 0x3C : channel x memory address register
$40020444 constant DMA2_CCR4      \ offset: 0x44 : channel x configuration register
$40020448 constant DMA2_CNDTR4    \ offset: 0x48 : channel x number of data to transfer register
$4002044c constant DMA2_CPAR4     \ offset: 0x4C : channel x peripheral address register
$40020450 constant DMA2_CMAR4     \ offset: 0x50 : channel x memory address register
$40020458 constant DMA2_CCR5      \ offset: 0x58 : channel x configuration register
$4002045c constant DMA2_CNDTR5    \ offset: 0x5C : channel x number of data to transfer register
$40020460 constant DMA2_CPAR5     \ offset: 0x60 : channel x peripheral address register
$40020464 constant DMA2_CMAR5     \ offset: 0x64 : channel x memory address register
$4002046c constant DMA2_CCR6      \ offset: 0x6C : channel x configuration register
$40020470 constant DMA2_CNDTR6    \ offset: 0x70 : channel x number of data to transfer register
$40020474 constant DMA2_CPAR6     \ offset: 0x74 : channel x peripheral address register
$40020478 constant DMA2_CMAR6     \ offset: 0x78 : channel x memory address register
$40020480 constant DMA2_CCR7      \ offset: 0x80 : channel x configuration register
$40020484 constant DMA2_CNDTR7    \ offset: 0x84 : channel x number of data to transfer register
$40020488 constant DMA2_CPAR7     \ offset: 0x88 : channel x peripheral address register
$4002048c constant DMA2_CMAR7     \ offset: 0x8C : channel x memory address register

