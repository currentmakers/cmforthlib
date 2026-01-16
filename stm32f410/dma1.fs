\
\ @file dma1.fs
\ @brief RTC Alarms (A and B) through EXTI line         interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief low interrupt status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DMA1_LISR_FEIF0                                  \ Stream x FIFO error interrupt flag (x=3..0)
$00000004 constant DMA1_LISR_DMEIF0                                 \ Stream x direct mode error interrupt flag (x=3..0)
$00000008 constant DMA1_LISR_TEIF0                                  \ Stream x transfer error interrupt flag (x=3..0)
$00000010 constant DMA1_LISR_HTIF0                                  \ Stream x half transfer interrupt flag (x=3..0)
$00000020 constant DMA1_LISR_TCIF0                                  \ Stream x transfer complete interrupt flag (x = 3..0)
$00000040 constant DMA1_LISR_FEIF1                                  \ Stream x FIFO error interrupt flag (x=3..0)
$00000100 constant DMA1_LISR_DMEIF1                                 \ Stream x direct mode error interrupt flag (x=3..0)
$00000200 constant DMA1_LISR_TEIF1                                  \ Stream x transfer error interrupt flag (x=3..0)
$00000400 constant DMA1_LISR_HTIF1                                  \ Stream x half transfer interrupt flag (x=3..0)
$00000800 constant DMA1_LISR_TCIF1                                  \ Stream x transfer complete interrupt flag (x = 3..0)
$00010000 constant DMA1_LISR_FEIF2                                  \ Stream x FIFO error interrupt flag (x=3..0)
$00040000 constant DMA1_LISR_DMEIF2                                 \ Stream x direct mode error interrupt flag (x=3..0)
$00080000 constant DMA1_LISR_TEIF2                                  \ Stream x transfer error interrupt flag (x=3..0)
$00100000 constant DMA1_LISR_HTIF2                                  \ Stream x half transfer interrupt flag (x=3..0)
$00200000 constant DMA1_LISR_TCIF2                                  \ Stream x transfer complete interrupt flag (x = 3..0)
$00400000 constant DMA1_LISR_FEIF3                                  \ Stream x FIFO error interrupt flag (x=3..0)
$01000000 constant DMA1_LISR_DMEIF3                                 \ Stream x direct mode error interrupt flag (x=3..0)
$02000000 constant DMA1_LISR_TEIF3                                  \ Stream x transfer error interrupt flag (x=3..0)
$04000000 constant DMA1_LISR_HTIF3                                  \ Stream x half transfer interrupt flag (x=3..0)
$08000000 constant DMA1_LISR_TCIF3                                  \ Stream x transfer complete interrupt flag (x = 3..0)


\
\ @brief high interrupt status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA1_HISR_FEIF4                                  \ Stream x FIFO error interrupt flag (x=7..4)
$00000004 constant DMA1_HISR_DMEIF4                                 \ Stream x direct mode error interrupt flag (x=7..4)
$00000008 constant DMA1_HISR_TEIF4                                  \ Stream x transfer error interrupt flag (x=7..4)
$00000010 constant DMA1_HISR_HTIF4                                  \ Stream x half transfer interrupt flag (x=7..4)
$00000020 constant DMA1_HISR_TCIF4                                  \ Stream x transfer complete interrupt flag (x=7..4)
$00000040 constant DMA1_HISR_FEIF5                                  \ Stream x FIFO error interrupt flag (x=7..4)
$00000100 constant DMA1_HISR_DMEIF5                                 \ Stream x direct mode error interrupt flag (x=7..4)
$00000200 constant DMA1_HISR_TEIF5                                  \ Stream x transfer error interrupt flag (x=7..4)
$00000400 constant DMA1_HISR_HTIF5                                  \ Stream x half transfer interrupt flag (x=7..4)
$00000800 constant DMA1_HISR_TCIF5                                  \ Stream x transfer complete interrupt flag (x=7..4)
$00010000 constant DMA1_HISR_FEIF6                                  \ Stream x FIFO error interrupt flag (x=7..4)
$00040000 constant DMA1_HISR_DMEIF6                                 \ Stream x direct mode error interrupt flag (x=7..4)
$00080000 constant DMA1_HISR_TEIF6                                  \ Stream x transfer error interrupt flag (x=7..4)
$00100000 constant DMA1_HISR_HTIF6                                  \ Stream x half transfer interrupt flag (x=7..4)
$00200000 constant DMA1_HISR_TCIF6                                  \ Stream x transfer complete interrupt flag (x=7..4)
$00400000 constant DMA1_HISR_FEIF7                                  \ Stream x FIFO error interrupt flag (x=7..4)
$01000000 constant DMA1_HISR_DMEIF7                                 \ Stream x direct mode error interrupt flag (x=7..4)
$02000000 constant DMA1_HISR_TEIF7                                  \ Stream x transfer error interrupt flag (x=7..4)
$04000000 constant DMA1_HISR_HTIF7                                  \ Stream x half transfer interrupt flag (x=7..4)
$08000000 constant DMA1_HISR_TCIF7                                  \ Stream x transfer complete interrupt flag (x=7..4)


\
\ @brief low interrupt flag clear register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA1_LIFCR_CFEIF0                                \ Stream x clear FIFO error interrupt flag (x = 3..0)
$00000004 constant DMA1_LIFCR_CDMEIF0                               \ Stream x clear direct mode error interrupt flag (x = 3..0)
$00000008 constant DMA1_LIFCR_CTEIF0                                \ Stream x clear transfer error interrupt flag (x = 3..0)
$00000010 constant DMA1_LIFCR_CHTIF0                                \ Stream x clear half transfer interrupt flag (x = 3..0)
$00000020 constant DMA1_LIFCR_CTCIF0                                \ Stream x clear transfer complete interrupt flag (x = 3..0)
$00000040 constant DMA1_LIFCR_CFEIF1                                \ Stream x clear FIFO error interrupt flag (x = 3..0)
$00000100 constant DMA1_LIFCR_CDMEIF1                               \ Stream x clear direct mode error interrupt flag (x = 3..0)
$00000200 constant DMA1_LIFCR_CTEIF1                                \ Stream x clear transfer error interrupt flag (x = 3..0)
$00000400 constant DMA1_LIFCR_CHTIF1                                \ Stream x clear half transfer interrupt flag (x = 3..0)
$00000800 constant DMA1_LIFCR_CTCIF1                                \ Stream x clear transfer complete interrupt flag (x = 3..0)
$00010000 constant DMA1_LIFCR_CFEIF2                                \ Stream x clear FIFO error interrupt flag (x = 3..0)
$00040000 constant DMA1_LIFCR_CDMEIF2                               \ Stream x clear direct mode error interrupt flag (x = 3..0)
$00080000 constant DMA1_LIFCR_CTEIF2                                \ Stream x clear transfer error interrupt flag (x = 3..0)
$00100000 constant DMA1_LIFCR_CHTIF2                                \ Stream x clear half transfer interrupt flag (x = 3..0)
$00200000 constant DMA1_LIFCR_CTCIF2                                \ Stream x clear transfer complete interrupt flag (x = 3..0)
$00400000 constant DMA1_LIFCR_CFEIF3                                \ Stream x clear FIFO error interrupt flag (x = 3..0)
$01000000 constant DMA1_LIFCR_CDMEIF3                               \ Stream x clear direct mode error interrupt flag (x = 3..0)
$02000000 constant DMA1_LIFCR_CTEIF3                                \ Stream x clear transfer error interrupt flag (x = 3..0)
$04000000 constant DMA1_LIFCR_CHTIF3                                \ Stream x clear half transfer interrupt flag (x = 3..0)
$08000000 constant DMA1_LIFCR_CTCIF3                                \ Stream x clear transfer complete interrupt flag (x = 3..0)


\
\ @brief high interrupt flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant DMA1_HIFCR_CFEIF4                                \ Stream x clear FIFO error interrupt flag (x = 7..4)
$00000004 constant DMA1_HIFCR_CDMEIF4                               \ Stream x clear direct mode error interrupt flag (x = 7..4)
$00000008 constant DMA1_HIFCR_CTEIF4                                \ Stream x clear transfer error interrupt flag (x = 7..4)
$00000010 constant DMA1_HIFCR_CHTIF4                                \ Stream x clear half transfer interrupt flag (x = 7..4)
$00000020 constant DMA1_HIFCR_CTCIF4                                \ Stream x clear transfer complete interrupt flag (x = 7..4)
$00000040 constant DMA1_HIFCR_CFEIF5                                \ Stream x clear FIFO error interrupt flag (x = 7..4)
$00000100 constant DMA1_HIFCR_CDMEIF5                               \ Stream x clear direct mode error interrupt flag (x = 7..4)
$00000200 constant DMA1_HIFCR_CTEIF5                                \ Stream x clear transfer error interrupt flag (x = 7..4)
$00000400 constant DMA1_HIFCR_CHTIF5                                \ Stream x clear half transfer interrupt flag (x = 7..4)
$00000800 constant DMA1_HIFCR_CTCIF5                                \ Stream x clear transfer complete interrupt flag (x = 7..4)
$00010000 constant DMA1_HIFCR_CFEIF6                                \ Stream x clear FIFO error interrupt flag (x = 7..4)
$00040000 constant DMA1_HIFCR_CDMEIF6                               \ Stream x clear direct mode error interrupt flag (x = 7..4)
$00080000 constant DMA1_HIFCR_CTEIF6                                \ Stream x clear transfer error interrupt flag (x = 7..4)
$00100000 constant DMA1_HIFCR_CHTIF6                                \ Stream x clear half transfer interrupt flag (x = 7..4)
$00200000 constant DMA1_HIFCR_CTCIF6                                \ Stream x clear transfer complete interrupt flag (x = 7..4)
$00400000 constant DMA1_HIFCR_CFEIF7                                \ Stream x clear FIFO error interrupt flag (x = 7..4)
$01000000 constant DMA1_HIFCR_CDMEIF7                               \ Stream x clear direct mode error interrupt flag (x = 7..4)
$02000000 constant DMA1_HIFCR_CTEIF7                                \ Stream x clear transfer error interrupt flag (x = 7..4)
$04000000 constant DMA1_HIFCR_CHTIF7                                \ Stream x clear half transfer interrupt flag (x = 7..4)
$08000000 constant DMA1_HIFCR_CTCIF7                                \ Stream x clear transfer complete interrupt flag (x = 7..4)


\
\ @brief stream x configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant DMA1_S0CR_EN                                     \ Stream enable / flag stream ready when read low
$00000002 constant DMA1_S0CR_DMEIE                                  \ Direct mode error interrupt enable
$00000004 constant DMA1_S0CR_TEIE                                   \ Transfer error interrupt enable
$00000008 constant DMA1_S0CR_HTIE                                   \ Half transfer interrupt enable
$00000010 constant DMA1_S0CR_TCIE                                   \ Transfer complete interrupt enable
$00000020 constant DMA1_S0CR_PFCTRL                                 \ Peripheral flow controller
$000000c0 constant DMA1_S0CR_DIR                                    \ Data transfer direction
$00000100 constant DMA1_S0CR_CIRC                                   \ Circular mode
$00000200 constant DMA1_S0CR_PINC                                   \ Peripheral increment mode
$00000400 constant DMA1_S0CR_MINC                                   \ Memory increment mode
$00001800 constant DMA1_S0CR_PSIZE                                  \ Peripheral data size
$00006000 constant DMA1_S0CR_MSIZE                                  \ Memory data size
$00008000 constant DMA1_S0CR_PINCOS                                 \ Peripheral increment offset size
$00030000 constant DMA1_S0CR_PL                                     \ Priority level
$00040000 constant DMA1_S0CR_DBM                                    \ Double buffer mode
$00080000 constant DMA1_S0CR_CT                                     \ Current target (only in double buffer mode)
$00600000 constant DMA1_S0CR_PBURST                                 \ Peripheral burst transfer configuration
$01800000 constant DMA1_S0CR_MBURST                                 \ Memory burst transfer configuration
$0e000000 constant DMA1_S0CR_CHSEL                                  \ Channel selection


\
\ @brief stream x number of data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_S0NDTR_NDT                                  \ Number of data items to transfer


\
\ @brief stream x peripheral address register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S0PAR_PA                                    \ Peripheral address


\
\ @brief stream x memory 0 address register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S0M0AR_M0A                                  \ Memory 0 address


\
\ @brief stream x memory 1 address register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S0M1AR_M1A                                  \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief stream x FIFO control register
\ Address offset: 0x24
\ Reset value: 0x00000021
\

$00000003 constant DMA1_S0FCR_FTH                                   \ FIFO threshold selection
$00000004 constant DMA1_S0FCR_DMDIS                                 \ Direct mode disable
$00000038 constant DMA1_S0FCR_FS                                    \ FIFO status
$00000080 constant DMA1_S0FCR_FEIE                                  \ FIFO error interrupt enable


\
\ @brief stream x configuration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant DMA1_S1CR_EN                                     \ Stream enable / flag stream ready when read low
$00000002 constant DMA1_S1CR_DMEIE                                  \ Direct mode error interrupt enable
$00000004 constant DMA1_S1CR_TEIE                                   \ Transfer error interrupt enable
$00000008 constant DMA1_S1CR_HTIE                                   \ Half transfer interrupt enable
$00000010 constant DMA1_S1CR_TCIE                                   \ Transfer complete interrupt enable
$00000020 constant DMA1_S1CR_PFCTRL                                 \ Peripheral flow controller
$000000c0 constant DMA1_S1CR_DIR                                    \ Data transfer direction
$00000100 constant DMA1_S1CR_CIRC                                   \ Circular mode
$00000200 constant DMA1_S1CR_PINC                                   \ Peripheral increment mode
$00000400 constant DMA1_S1CR_MINC                                   \ Memory increment mode
$00001800 constant DMA1_S1CR_PSIZE                                  \ Peripheral data size
$00006000 constant DMA1_S1CR_MSIZE                                  \ Memory data size
$00008000 constant DMA1_S1CR_PINCOS                                 \ Peripheral increment offset size
$00030000 constant DMA1_S1CR_PL                                     \ Priority level
$00040000 constant DMA1_S1CR_DBM                                    \ Double buffer mode
$00080000 constant DMA1_S1CR_CT                                     \ Current target (only in double buffer mode)
$00100000 constant DMA1_S1CR_ACK                                    \ ACK
$00600000 constant DMA1_S1CR_PBURST                                 \ Peripheral burst transfer configuration
$01800000 constant DMA1_S1CR_MBURST                                 \ Memory burst transfer configuration
$0e000000 constant DMA1_S1CR_CHSEL                                  \ Channel selection


\
\ @brief stream x number of data register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_S1NDTR_NDT                                  \ Number of data items to transfer


\
\ @brief stream x peripheral address register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S1PAR_PA                                    \ Peripheral address


\
\ @brief stream x memory 0 address register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S1M0AR_M0A                                  \ Memory 0 address


\
\ @brief stream x memory 1 address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S1M1AR_M1A                                  \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief stream x FIFO control register
\ Address offset: 0x3C
\ Reset value: 0x00000021
\

$00000003 constant DMA1_S1FCR_FTH                                   \ FIFO threshold selection
$00000004 constant DMA1_S1FCR_DMDIS                                 \ Direct mode disable
$00000038 constant DMA1_S1FCR_FS                                    \ FIFO status
$00000080 constant DMA1_S1FCR_FEIE                                  \ FIFO error interrupt enable


\
\ @brief stream x configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant DMA1_S2CR_EN                                     \ Stream enable / flag stream ready when read low
$00000002 constant DMA1_S2CR_DMEIE                                  \ Direct mode error interrupt enable
$00000004 constant DMA1_S2CR_TEIE                                   \ Transfer error interrupt enable
$00000008 constant DMA1_S2CR_HTIE                                   \ Half transfer interrupt enable
$00000010 constant DMA1_S2CR_TCIE                                   \ Transfer complete interrupt enable
$00000020 constant DMA1_S2CR_PFCTRL                                 \ Peripheral flow controller
$000000c0 constant DMA1_S2CR_DIR                                    \ Data transfer direction
$00000100 constant DMA1_S2CR_CIRC                                   \ Circular mode
$00000200 constant DMA1_S2CR_PINC                                   \ Peripheral increment mode
$00000400 constant DMA1_S2CR_MINC                                   \ Memory increment mode
$00001800 constant DMA1_S2CR_PSIZE                                  \ Peripheral data size
$00006000 constant DMA1_S2CR_MSIZE                                  \ Memory data size
$00008000 constant DMA1_S2CR_PINCOS                                 \ Peripheral increment offset size
$00030000 constant DMA1_S2CR_PL                                     \ Priority level
$00040000 constant DMA1_S2CR_DBM                                    \ Double buffer mode
$00080000 constant DMA1_S2CR_CT                                     \ Current target (only in double buffer mode)
$00100000 constant DMA1_S2CR_ACK                                    \ ACK
$00600000 constant DMA1_S2CR_PBURST                                 \ Peripheral burst transfer configuration
$01800000 constant DMA1_S2CR_MBURST                                 \ Memory burst transfer configuration
$0e000000 constant DMA1_S2CR_CHSEL                                  \ Channel selection


\
\ @brief stream x number of data register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_S2NDTR_NDT                                  \ Number of data items to transfer


\
\ @brief stream x peripheral address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S2PAR_PA                                    \ Peripheral address


\
\ @brief stream x memory 0 address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S2M0AR_M0A                                  \ Memory 0 address


\
\ @brief stream x memory 1 address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S2M1AR_M1A                                  \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief stream x FIFO control register
\ Address offset: 0x54
\ Reset value: 0x00000021
\

$00000003 constant DMA1_S2FCR_FTH                                   \ FIFO threshold selection
$00000004 constant DMA1_S2FCR_DMDIS                                 \ Direct mode disable
$00000038 constant DMA1_S2FCR_FS                                    \ FIFO status
$00000080 constant DMA1_S2FCR_FEIE                                  \ FIFO error interrupt enable


\
\ @brief stream x configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant DMA1_S3CR_EN                                     \ Stream enable / flag stream ready when read low
$00000002 constant DMA1_S3CR_DMEIE                                  \ Direct mode error interrupt enable
$00000004 constant DMA1_S3CR_TEIE                                   \ Transfer error interrupt enable
$00000008 constant DMA1_S3CR_HTIE                                   \ Half transfer interrupt enable
$00000010 constant DMA1_S3CR_TCIE                                   \ Transfer complete interrupt enable
$00000020 constant DMA1_S3CR_PFCTRL                                 \ Peripheral flow controller
$000000c0 constant DMA1_S3CR_DIR                                    \ Data transfer direction
$00000100 constant DMA1_S3CR_CIRC                                   \ Circular mode
$00000200 constant DMA1_S3CR_PINC                                   \ Peripheral increment mode
$00000400 constant DMA1_S3CR_MINC                                   \ Memory increment mode
$00001800 constant DMA1_S3CR_PSIZE                                  \ Peripheral data size
$00006000 constant DMA1_S3CR_MSIZE                                  \ Memory data size
$00008000 constant DMA1_S3CR_PINCOS                                 \ Peripheral increment offset size
$00030000 constant DMA1_S3CR_PL                                     \ Priority level
$00040000 constant DMA1_S3CR_DBM                                    \ Double buffer mode
$00080000 constant DMA1_S3CR_CT                                     \ Current target (only in double buffer mode)
$00100000 constant DMA1_S3CR_ACK                                    \ ACK
$00600000 constant DMA1_S3CR_PBURST                                 \ Peripheral burst transfer configuration
$01800000 constant DMA1_S3CR_MBURST                                 \ Memory burst transfer configuration
$0e000000 constant DMA1_S3CR_CHSEL                                  \ Channel selection


\
\ @brief stream x number of data register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_S3NDTR_NDT                                  \ Number of data items to transfer


\
\ @brief stream x peripheral address register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S3PAR_PA                                    \ Peripheral address


\
\ @brief stream x memory 0 address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S3M0AR_M0A                                  \ Memory 0 address


\
\ @brief stream x memory 1 address register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S3M1AR_M1A                                  \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief stream x FIFO control register
\ Address offset: 0x6C
\ Reset value: 0x00000021
\

$00000003 constant DMA1_S3FCR_FTH                                   \ FIFO threshold selection
$00000004 constant DMA1_S3FCR_DMDIS                                 \ Direct mode disable
$00000038 constant DMA1_S3FCR_FS                                    \ FIFO status
$00000080 constant DMA1_S3FCR_FEIE                                  \ FIFO error interrupt enable


\
\ @brief stream x configuration register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant DMA1_S4CR_EN                                     \ Stream enable / flag stream ready when read low
$00000002 constant DMA1_S4CR_DMEIE                                  \ Direct mode error interrupt enable
$00000004 constant DMA1_S4CR_TEIE                                   \ Transfer error interrupt enable
$00000008 constant DMA1_S4CR_HTIE                                   \ Half transfer interrupt enable
$00000010 constant DMA1_S4CR_TCIE                                   \ Transfer complete interrupt enable
$00000020 constant DMA1_S4CR_PFCTRL                                 \ Peripheral flow controller
$000000c0 constant DMA1_S4CR_DIR                                    \ Data transfer direction
$00000100 constant DMA1_S4CR_CIRC                                   \ Circular mode
$00000200 constant DMA1_S4CR_PINC                                   \ Peripheral increment mode
$00000400 constant DMA1_S4CR_MINC                                   \ Memory increment mode
$00001800 constant DMA1_S4CR_PSIZE                                  \ Peripheral data size
$00006000 constant DMA1_S4CR_MSIZE                                  \ Memory data size
$00008000 constant DMA1_S4CR_PINCOS                                 \ Peripheral increment offset size
$00030000 constant DMA1_S4CR_PL                                     \ Priority level
$00040000 constant DMA1_S4CR_DBM                                    \ Double buffer mode
$00080000 constant DMA1_S4CR_CT                                     \ Current target (only in double buffer mode)
$00100000 constant DMA1_S4CR_ACK                                    \ ACK
$00600000 constant DMA1_S4CR_PBURST                                 \ Peripheral burst transfer configuration
$01800000 constant DMA1_S4CR_MBURST                                 \ Memory burst transfer configuration
$0e000000 constant DMA1_S4CR_CHSEL                                  \ Channel selection


\
\ @brief stream x number of data register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_S4NDTR_NDT                                  \ Number of data items to transfer


\
\ @brief stream x peripheral address register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S4PAR_PA                                    \ Peripheral address


\
\ @brief stream x memory 0 address register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S4M0AR_M0A                                  \ Memory 0 address


\
\ @brief stream x memory 1 address register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S4M1AR_M1A                                  \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief stream x FIFO control register
\ Address offset: 0x84
\ Reset value: 0x00000021
\

$00000003 constant DMA1_S4FCR_FTH                                   \ FIFO threshold selection
$00000004 constant DMA1_S4FCR_DMDIS                                 \ Direct mode disable
$00000038 constant DMA1_S4FCR_FS                                    \ FIFO status
$00000080 constant DMA1_S4FCR_FEIE                                  \ FIFO error interrupt enable


\
\ @brief stream x configuration register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant DMA1_S5CR_EN                                     \ Stream enable / flag stream ready when read low
$00000002 constant DMA1_S5CR_DMEIE                                  \ Direct mode error interrupt enable
$00000004 constant DMA1_S5CR_TEIE                                   \ Transfer error interrupt enable
$00000008 constant DMA1_S5CR_HTIE                                   \ Half transfer interrupt enable
$00000010 constant DMA1_S5CR_TCIE                                   \ Transfer complete interrupt enable
$00000020 constant DMA1_S5CR_PFCTRL                                 \ Peripheral flow controller
$000000c0 constant DMA1_S5CR_DIR                                    \ Data transfer direction
$00000100 constant DMA1_S5CR_CIRC                                   \ Circular mode
$00000200 constant DMA1_S5CR_PINC                                   \ Peripheral increment mode
$00000400 constant DMA1_S5CR_MINC                                   \ Memory increment mode
$00001800 constant DMA1_S5CR_PSIZE                                  \ Peripheral data size
$00006000 constant DMA1_S5CR_MSIZE                                  \ Memory data size
$00008000 constant DMA1_S5CR_PINCOS                                 \ Peripheral increment offset size
$00030000 constant DMA1_S5CR_PL                                     \ Priority level
$00040000 constant DMA1_S5CR_DBM                                    \ Double buffer mode
$00080000 constant DMA1_S5CR_CT                                     \ Current target (only in double buffer mode)
$00100000 constant DMA1_S5CR_ACK                                    \ ACK
$00600000 constant DMA1_S5CR_PBURST                                 \ Peripheral burst transfer configuration
$01800000 constant DMA1_S5CR_MBURST                                 \ Memory burst transfer configuration
$0e000000 constant DMA1_S5CR_CHSEL                                  \ Channel selection


\
\ @brief stream x number of data register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_S5NDTR_NDT                                  \ Number of data items to transfer


\
\ @brief stream x peripheral address register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S5PAR_PA                                    \ Peripheral address


\
\ @brief stream x memory 0 address register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S5M0AR_M0A                                  \ Memory 0 address


\
\ @brief stream x memory 1 address register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S5M1AR_M1A                                  \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief stream x FIFO control register
\ Address offset: 0x9C
\ Reset value: 0x00000021
\

$00000003 constant DMA1_S5FCR_FTH                                   \ FIFO threshold selection
$00000004 constant DMA1_S5FCR_DMDIS                                 \ Direct mode disable
$00000038 constant DMA1_S5FCR_FS                                    \ FIFO status
$00000080 constant DMA1_S5FCR_FEIE                                  \ FIFO error interrupt enable


\
\ @brief stream x configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant DMA1_S6CR_EN                                     \ Stream enable / flag stream ready when read low
$00000002 constant DMA1_S6CR_DMEIE                                  \ Direct mode error interrupt enable
$00000004 constant DMA1_S6CR_TEIE                                   \ Transfer error interrupt enable
$00000008 constant DMA1_S6CR_HTIE                                   \ Half transfer interrupt enable
$00000010 constant DMA1_S6CR_TCIE                                   \ Transfer complete interrupt enable
$00000020 constant DMA1_S6CR_PFCTRL                                 \ Peripheral flow controller
$000000c0 constant DMA1_S6CR_DIR                                    \ Data transfer direction
$00000100 constant DMA1_S6CR_CIRC                                   \ Circular mode
$00000200 constant DMA1_S6CR_PINC                                   \ Peripheral increment mode
$00000400 constant DMA1_S6CR_MINC                                   \ Memory increment mode
$00001800 constant DMA1_S6CR_PSIZE                                  \ Peripheral data size
$00006000 constant DMA1_S6CR_MSIZE                                  \ Memory data size
$00008000 constant DMA1_S6CR_PINCOS                                 \ Peripheral increment offset size
$00030000 constant DMA1_S6CR_PL                                     \ Priority level
$00040000 constant DMA1_S6CR_DBM                                    \ Double buffer mode
$00080000 constant DMA1_S6CR_CT                                     \ Current target (only in double buffer mode)
$00100000 constant DMA1_S6CR_ACK                                    \ ACK
$00600000 constant DMA1_S6CR_PBURST                                 \ Peripheral burst transfer configuration
$01800000 constant DMA1_S6CR_MBURST                                 \ Memory burst transfer configuration
$0e000000 constant DMA1_S6CR_CHSEL                                  \ Channel selection


\
\ @brief stream x number of data register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_S6NDTR_NDT                                  \ Number of data items to transfer


\
\ @brief stream x peripheral address register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S6PAR_PA                                    \ Peripheral address


\
\ @brief stream x memory 0 address register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S6M0AR_M0A                                  \ Memory 0 address


\
\ @brief stream x memory 1 address register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S6M1AR_M1A                                  \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief stream x FIFO control register
\ Address offset: 0xB4
\ Reset value: 0x00000021
\

$00000003 constant DMA1_S6FCR_FTH                                   \ FIFO threshold selection
$00000004 constant DMA1_S6FCR_DMDIS                                 \ Direct mode disable
$00000038 constant DMA1_S6FCR_FS                                    \ FIFO status
$00000080 constant DMA1_S6FCR_FEIE                                  \ FIFO error interrupt enable


\
\ @brief stream x configuration register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant DMA1_S7CR_EN                                     \ Stream enable / flag stream ready when read low
$00000002 constant DMA1_S7CR_DMEIE                                  \ Direct mode error interrupt enable
$00000004 constant DMA1_S7CR_TEIE                                   \ Transfer error interrupt enable
$00000008 constant DMA1_S7CR_HTIE                                   \ Half transfer interrupt enable
$00000010 constant DMA1_S7CR_TCIE                                   \ Transfer complete interrupt enable
$00000020 constant DMA1_S7CR_PFCTRL                                 \ Peripheral flow controller
$000000c0 constant DMA1_S7CR_DIR                                    \ Data transfer direction
$00000100 constant DMA1_S7CR_CIRC                                   \ Circular mode
$00000200 constant DMA1_S7CR_PINC                                   \ Peripheral increment mode
$00000400 constant DMA1_S7CR_MINC                                   \ Memory increment mode
$00001800 constant DMA1_S7CR_PSIZE                                  \ Peripheral data size
$00006000 constant DMA1_S7CR_MSIZE                                  \ Memory data size
$00008000 constant DMA1_S7CR_PINCOS                                 \ Peripheral increment offset size
$00030000 constant DMA1_S7CR_PL                                     \ Priority level
$00040000 constant DMA1_S7CR_DBM                                    \ Double buffer mode
$00080000 constant DMA1_S7CR_CT                                     \ Current target (only in double buffer mode)
$00100000 constant DMA1_S7CR_ACK                                    \ ACK
$00600000 constant DMA1_S7CR_PBURST                                 \ Peripheral burst transfer configuration
$01800000 constant DMA1_S7CR_MBURST                                 \ Memory burst transfer configuration
$0e000000 constant DMA1_S7CR_CHSEL                                  \ Channel selection


\
\ @brief stream x number of data register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$0000ffff constant DMA1_S7NDTR_NDT                                  \ Number of data items to transfer


\
\ @brief stream x peripheral address register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S7PAR_PA                                    \ Peripheral address


\
\ @brief stream x memory 0 address register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S7M0AR_M0A                                  \ Memory 0 address


\
\ @brief stream x memory 1 address register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant DMA1_S7M1AR_M1A                                  \ Memory 1 address (used in case of Double buffer mode)


\
\ @brief stream x FIFO control register
\ Address offset: 0xCC
\ Reset value: 0x00000021
\

$00000003 constant DMA1_S7FCR_FTH                                   \ FIFO threshold selection
$00000004 constant DMA1_S7FCR_DMDIS                                 \ Direct mode disable
$00000038 constant DMA1_S7FCR_FS                                    \ FIFO status
$00000080 constant DMA1_S7FCR_FEIE                                  \ FIFO error interrupt enable


\
\ @brief RTC Alarms (A and B) through EXTI line interrupt
\
$40026000 constant DMA1_LISR      \ offset: 0x00 : low interrupt status register
$40026004 constant DMA1_HISR      \ offset: 0x04 : high interrupt status register
$40026008 constant DMA1_LIFCR     \ offset: 0x08 : low interrupt flag clear register
$4002600c constant DMA1_HIFCR     \ offset: 0x0C : high interrupt flag clear register
$40026010 constant DMA1_S0CR      \ offset: 0x10 : stream x configuration register
$40026014 constant DMA1_S0NDTR    \ offset: 0x14 : stream x number of data register
$40026018 constant DMA1_S0PAR     \ offset: 0x18 : stream x peripheral address register
$4002601c constant DMA1_S0M0AR    \ offset: 0x1C : stream x memory 0 address register
$40026020 constant DMA1_S0M1AR    \ offset: 0x20 : stream x memory 1 address register
$40026024 constant DMA1_S0FCR     \ offset: 0x24 : stream x FIFO control register
$40026028 constant DMA1_S1CR      \ offset: 0x28 : stream x configuration register
$4002602c constant DMA1_S1NDTR    \ offset: 0x2C : stream x number of data register
$40026030 constant DMA1_S1PAR     \ offset: 0x30 : stream x peripheral address register
$40026034 constant DMA1_S1M0AR    \ offset: 0x34 : stream x memory 0 address register
$40026038 constant DMA1_S1M1AR    \ offset: 0x38 : stream x memory 1 address register
$4002603c constant DMA1_S1FCR     \ offset: 0x3C : stream x FIFO control register
$40026040 constant DMA1_S2CR      \ offset: 0x40 : stream x configuration register
$40026044 constant DMA1_S2NDTR    \ offset: 0x44 : stream x number of data register
$40026048 constant DMA1_S2PAR     \ offset: 0x48 : stream x peripheral address register
$4002604c constant DMA1_S2M0AR    \ offset: 0x4C : stream x memory 0 address register
$40026050 constant DMA1_S2M1AR    \ offset: 0x50 : stream x memory 1 address register
$40026054 constant DMA1_S2FCR     \ offset: 0x54 : stream x FIFO control register
$40026058 constant DMA1_S3CR      \ offset: 0x58 : stream x configuration register
$4002605c constant DMA1_S3NDTR    \ offset: 0x5C : stream x number of data register
$40026060 constant DMA1_S3PAR     \ offset: 0x60 : stream x peripheral address register
$40026064 constant DMA1_S3M0AR    \ offset: 0x64 : stream x memory 0 address register
$40026068 constant DMA1_S3M1AR    \ offset: 0x68 : stream x memory 1 address register
$4002606c constant DMA1_S3FCR     \ offset: 0x6C : stream x FIFO control register
$40026070 constant DMA1_S4CR      \ offset: 0x70 : stream x configuration register
$40026074 constant DMA1_S4NDTR    \ offset: 0x74 : stream x number of data register
$40026078 constant DMA1_S4PAR     \ offset: 0x78 : stream x peripheral address register
$4002607c constant DMA1_S4M0AR    \ offset: 0x7C : stream x memory 0 address register
$40026080 constant DMA1_S4M1AR    \ offset: 0x80 : stream x memory 1 address register
$40026084 constant DMA1_S4FCR     \ offset: 0x84 : stream x FIFO control register
$40026088 constant DMA1_S5CR      \ offset: 0x88 : stream x configuration register
$4002608c constant DMA1_S5NDTR    \ offset: 0x8C : stream x number of data register
$40026090 constant DMA1_S5PAR     \ offset: 0x90 : stream x peripheral address register
$40026094 constant DMA1_S5M0AR    \ offset: 0x94 : stream x memory 0 address register
$40026098 constant DMA1_S5M1AR    \ offset: 0x98 : stream x memory 1 address register
$4002609c constant DMA1_S5FCR     \ offset: 0x9C : stream x FIFO control register
$400260a0 constant DMA1_S6CR      \ offset: 0xA0 : stream x configuration register
$400260a4 constant DMA1_S6NDTR    \ offset: 0xA4 : stream x number of data register
$400260a8 constant DMA1_S6PAR     \ offset: 0xA8 : stream x peripheral address register
$400260ac constant DMA1_S6M0AR    \ offset: 0xAC : stream x memory 0 address register
$400260b0 constant DMA1_S6M1AR    \ offset: 0xB0 : stream x memory 1 address register
$400260b4 constant DMA1_S6FCR     \ offset: 0xB4 : stream x FIFO control register
$400260b8 constant DMA1_S7CR      \ offset: 0xB8 : stream x configuration register
$400260bc constant DMA1_S7NDTR    \ offset: 0xBC : stream x number of data register
$400260c0 constant DMA1_S7PAR     \ offset: 0xC0 : stream x peripheral address register
$400260c4 constant DMA1_S7M0AR    \ offset: 0xC4 : stream x memory 0 address register
$400260c8 constant DMA1_S7M1AR    \ offset: 0xC8 : stream x memory 1 address register
$400260cc constant DMA1_S7FCR     \ offset: 0xCC : stream x FIFO control register

