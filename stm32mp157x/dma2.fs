\
\ @file dma2.fs
\ @brief DMA2 stream0 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMA low interrupt status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_LISR_FEIF0                              \ FEIF0
$00000004 constant DMA2_DMA_LISR_DMEIF0                             \ DMEIF0
$00000008 constant DMA2_DMA_LISR_TEIF0                              \ TEIF0
$00000010 constant DMA2_DMA_LISR_HTIF0                              \ HTIF0
$00000020 constant DMA2_DMA_LISR_TCIF0                              \ TCIF0
$00000040 constant DMA2_DMA_LISR_FEIF1                              \ FEIF1
$00000100 constant DMA2_DMA_LISR_DMEIF1                             \ DMEIF1
$00000200 constant DMA2_DMA_LISR_TEIF1                              \ TEIF1
$00000400 constant DMA2_DMA_LISR_HTIF1                              \ HTIF1
$00000800 constant DMA2_DMA_LISR_TCIF1                              \ TCIF1
$00010000 constant DMA2_DMA_LISR_FEIF2                              \ FEIF2
$00040000 constant DMA2_DMA_LISR_DMEIF2                             \ DMEIF2
$00080000 constant DMA2_DMA_LISR_TEIF2                              \ TEIF2
$00100000 constant DMA2_DMA_LISR_HTIF2                              \ HTIF2
$00200000 constant DMA2_DMA_LISR_TCIF2                              \ TCIF2
$00400000 constant DMA2_DMA_LISR_FEIF3                              \ FEIF3
$01000000 constant DMA2_DMA_LISR_DMEIF3                             \ DMEIF3
$02000000 constant DMA2_DMA_LISR_TEIF3                              \ TEIF3
$04000000 constant DMA2_DMA_LISR_HTIF3                              \ HTIF3
$08000000 constant DMA2_DMA_LISR_TCIF3                              \ TCIF3


\
\ @brief DMA high interrupt status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_HISR_FEIF4                              \ FEIF4
$00000004 constant DMA2_DMA_HISR_DMEIF4                             \ DMEIF4
$00000008 constant DMA2_DMA_HISR_TEIF4                              \ TEIF4
$00000010 constant DMA2_DMA_HISR_HTIF4                              \ HTIF4
$00000020 constant DMA2_DMA_HISR_TCIF4                              \ TCIF4
$00000040 constant DMA2_DMA_HISR_FEIF5                              \ FEIF5
$00000100 constant DMA2_DMA_HISR_DMEIF5                             \ DMEIF5
$00000200 constant DMA2_DMA_HISR_TEIF5                              \ TEIF5
$00000400 constant DMA2_DMA_HISR_HTIF5                              \ HTIF5
$00000800 constant DMA2_DMA_HISR_TCIF5                              \ TCIF5
$00010000 constant DMA2_DMA_HISR_FEIF6                              \ FEIF6
$00040000 constant DMA2_DMA_HISR_DMEIF6                             \ DMEIF6
$00080000 constant DMA2_DMA_HISR_TEIF6                              \ TEIF6
$00100000 constant DMA2_DMA_HISR_HTIF6                              \ HTIF6
$00200000 constant DMA2_DMA_HISR_TCIF6                              \ TCIF6
$00400000 constant DMA2_DMA_HISR_FEIF7                              \ FEIF7
$01000000 constant DMA2_DMA_HISR_DMEIF7                             \ DMEIF7
$02000000 constant DMA2_DMA_HISR_TEIF7                              \ TEIF7
$04000000 constant DMA2_DMA_HISR_HTIF7                              \ HTIF7
$08000000 constant DMA2_DMA_HISR_TCIF7                              \ TCIF7


\
\ @brief DMA low interrupt flag clear register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_LIFCR_CFEIF0                            \ CFEIF0
$00000004 constant DMA2_DMA_LIFCR_CDMEIF0                           \ CDMEIF0
$00000008 constant DMA2_DMA_LIFCR_CTEIF0                            \ CTEIF0
$00000010 constant DMA2_DMA_LIFCR_CHTIF0                            \ CHTIF0
$00000020 constant DMA2_DMA_LIFCR_CTCIF0                            \ CTCIF0
$00000040 constant DMA2_DMA_LIFCR_CFEIF1                            \ CFEIF1
$00000100 constant DMA2_DMA_LIFCR_CDMEIF1                           \ CDMEIF1
$00000200 constant DMA2_DMA_LIFCR_CTEIF1                            \ CTEIF1
$00000400 constant DMA2_DMA_LIFCR_CHTIF1                            \ CHTIF1
$00000800 constant DMA2_DMA_LIFCR_CTCIF1                            \ CTCIF1
$00010000 constant DMA2_DMA_LIFCR_CFEIF2                            \ CFEIF2
$00040000 constant DMA2_DMA_LIFCR_CDMEIF2                           \ CDMEIF2
$00080000 constant DMA2_DMA_LIFCR_CTEIF2                            \ CTEIF2
$00100000 constant DMA2_DMA_LIFCR_CHTIF2                            \ CHTIF2
$00200000 constant DMA2_DMA_LIFCR_CTCIF2                            \ CTCIF2
$00400000 constant DMA2_DMA_LIFCR_CFEIF3                            \ CFEIF3
$01000000 constant DMA2_DMA_LIFCR_CDMEIF3                           \ CDMEIF3
$02000000 constant DMA2_DMA_LIFCR_CTEIF3                            \ CTEIF3
$04000000 constant DMA2_DMA_LIFCR_CHTIF3                            \ CHTIF3
$08000000 constant DMA2_DMA_LIFCR_CTCIF3                            \ CTCIF3


\
\ @brief DMA high interrupt flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_HIFCR_CFEIF4                            \ CFEIF4
$00000004 constant DMA2_DMA_HIFCR_CDMEIF4                           \ CDMEIF4
$00000008 constant DMA2_DMA_HIFCR_CTEIF4                            \ CTEIF4
$00000010 constant DMA2_DMA_HIFCR_CHTIF4                            \ CHTIF4
$00000020 constant DMA2_DMA_HIFCR_CTCIF4                            \ CTCIF4
$00000040 constant DMA2_DMA_HIFCR_CFEIF5                            \ CFEIF5
$00000100 constant DMA2_DMA_HIFCR_CDMEIF5                           \ CDMEIF5
$00000200 constant DMA2_DMA_HIFCR_CTEIF5                            \ CTEIF5
$00000400 constant DMA2_DMA_HIFCR_CHTIF5                            \ CHTIF5
$00000800 constant DMA2_DMA_HIFCR_CTCIF5                            \ CTCIF5
$00010000 constant DMA2_DMA_HIFCR_CFEIF6                            \ CFEIF6
$00040000 constant DMA2_DMA_HIFCR_CDMEIF6                           \ CDMEIF6
$00080000 constant DMA2_DMA_HIFCR_CTEIF6                            \ CTEIF6
$00100000 constant DMA2_DMA_HIFCR_CHTIF6                            \ CHTIF6
$00200000 constant DMA2_DMA_HIFCR_CTCIF6                            \ CTCIF6
$00400000 constant DMA2_DMA_HIFCR_CFEIF7                            \ CFEIF7
$01000000 constant DMA2_DMA_HIFCR_CDMEIF7                           \ CDMEIF7
$02000000 constant DMA2_DMA_HIFCR_CTEIF7                            \ CTEIF7
$04000000 constant DMA2_DMA_HIFCR_CHTIF7                            \ CHTIF7
$08000000 constant DMA2_DMA_HIFCR_CTCIF7                            \ CTCIF7


\
\ @brief This register is used to configure the concerned stream.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_S0CR_EN                                 \ EN
$00000002 constant DMA2_DMA_S0CR_DMEIE                              \ DMEIE
$00000004 constant DMA2_DMA_S0CR_TEIE                               \ TEIE
$00000008 constant DMA2_DMA_S0CR_HTIE                               \ HTIE
$00000010 constant DMA2_DMA_S0CR_TCIE                               \ TCIE
$00000020 constant DMA2_DMA_S0CR_PFCTRL                             \ PFCTRL
$000000c0 constant DMA2_DMA_S0CR_DIR                                \ DIR
$00000100 constant DMA2_DMA_S0CR_CIRC                               \ CIRC
$00000200 constant DMA2_DMA_S0CR_PINC                               \ PINC
$00000400 constant DMA2_DMA_S0CR_MINC                               \ MINC
$00001800 constant DMA2_DMA_S0CR_PSIZE                              \ PSIZE
$00006000 constant DMA2_DMA_S0CR_MSIZE                              \ MSIZE
$00008000 constant DMA2_DMA_S0CR_PINCOS                             \ PINCOS
$00030000 constant DMA2_DMA_S0CR_PL                                 \ PL
$00040000 constant DMA2_DMA_S0CR_DBM                                \ DBM
$00080000 constant DMA2_DMA_S0CR_CT                                 \ CT
$00600000 constant DMA2_DMA_S0CR_PBURST                             \ PBURST
$01800000 constant DMA2_DMA_S0CR_MBURST                             \ MBURST


\
\ @brief DMA stream 0 number of data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_S0NDTR_NDT                              \ NDT


\
\ @brief DMA stream 0 peripheral address register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S0PAR_PAR                               \ PAR


\
\ @brief DMA stream 0 memory 0 address register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S0M0AR_M0A                              \ M0A


\
\ @brief DMA stream 0 memory 1 address register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S0M1AR_M1A                              \ M1A


\
\ @brief DMA stream 0 FIFO control register
\ Address offset: 0x24
\ Reset value: 0x00000021
\

$00000003 constant DMA2_DMA_S0FCR_FTH                               \ FTH
$00000004 constant DMA2_DMA_S0FCR_DMDIS                             \ DMDIS
$00000038 constant DMA2_DMA_S0FCR_FS                                \ FS
$00000080 constant DMA2_DMA_S0FCR_FEIE                              \ FEIE


\
\ @brief This register is used to configure the concerned stream.
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_S1CR_EN                                 \ EN
$00000002 constant DMA2_DMA_S1CR_DMEIE                              \ DMEIE
$00000004 constant DMA2_DMA_S1CR_TEIE                               \ TEIE
$00000008 constant DMA2_DMA_S1CR_HTIE                               \ HTIE
$00000010 constant DMA2_DMA_S1CR_TCIE                               \ TCIE
$00000020 constant DMA2_DMA_S1CR_PFCTRL                             \ PFCTRL
$000000c0 constant DMA2_DMA_S1CR_DIR                                \ DIR
$00000100 constant DMA2_DMA_S1CR_CIRC                               \ CIRC
$00000200 constant DMA2_DMA_S1CR_PINC                               \ PINC
$00000400 constant DMA2_DMA_S1CR_MINC                               \ MINC
$00001800 constant DMA2_DMA_S1CR_PSIZE                              \ PSIZE
$00006000 constant DMA2_DMA_S1CR_MSIZE                              \ MSIZE
$00008000 constant DMA2_DMA_S1CR_PINCOS                             \ PINCOS
$00030000 constant DMA2_DMA_S1CR_PL                                 \ PL
$00040000 constant DMA2_DMA_S1CR_DBM                                \ DBM
$00080000 constant DMA2_DMA_S1CR_CT                                 \ CT
$00600000 constant DMA2_DMA_S1CR_PBURST                             \ PBURST
$01800000 constant DMA2_DMA_S1CR_MBURST                             \ MBURST


\
\ @brief DMA stream 1 number of data register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_S1NDTR_NDT                              \ NDT


\
\ @brief DMA stream 1 peripheral address register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S1PAR_PAR                               \ PAR


\
\ @brief DMA stream 1 memory 0 address register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S1M0AR_M0A                              \ M0A


\
\ @brief DMA stream 1 memory 1 address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S1M1AR_M1A                              \ M1A


\
\ @brief DMA stream 1 FIFO control register
\ Address offset: 0x3C
\ Reset value: 0x00000021
\

$00000003 constant DMA2_DMA_S1FCR_FTH                               \ FTH
$00000004 constant DMA2_DMA_S1FCR_DMDIS                             \ DMDIS
$00000038 constant DMA2_DMA_S1FCR_FS                                \ FS
$00000080 constant DMA2_DMA_S1FCR_FEIE                              \ FEIE


\
\ @brief This register is used to configure the concerned stream.
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_S2CR_EN                                 \ EN
$00000002 constant DMA2_DMA_S2CR_DMEIE                              \ DMEIE
$00000004 constant DMA2_DMA_S2CR_TEIE                               \ TEIE
$00000008 constant DMA2_DMA_S2CR_HTIE                               \ HTIE
$00000010 constant DMA2_DMA_S2CR_TCIE                               \ TCIE
$00000020 constant DMA2_DMA_S2CR_PFCTRL                             \ PFCTRL
$000000c0 constant DMA2_DMA_S2CR_DIR                                \ DIR
$00000100 constant DMA2_DMA_S2CR_CIRC                               \ CIRC
$00000200 constant DMA2_DMA_S2CR_PINC                               \ PINC
$00000400 constant DMA2_DMA_S2CR_MINC                               \ MINC
$00001800 constant DMA2_DMA_S2CR_PSIZE                              \ PSIZE
$00006000 constant DMA2_DMA_S2CR_MSIZE                              \ MSIZE
$00008000 constant DMA2_DMA_S2CR_PINCOS                             \ PINCOS
$00030000 constant DMA2_DMA_S2CR_PL                                 \ PL
$00040000 constant DMA2_DMA_S2CR_DBM                                \ DBM
$00080000 constant DMA2_DMA_S2CR_CT                                 \ CT
$00600000 constant DMA2_DMA_S2CR_PBURST                             \ PBURST
$01800000 constant DMA2_DMA_S2CR_MBURST                             \ MBURST


\
\ @brief DMA stream 2 number of data register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_S2NDTR_NDT                              \ NDT


\
\ @brief DMA stream 2 peripheral address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S2PAR_PAR                               \ PAR


\
\ @brief DMA stream 2 memory 0 address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S2M0AR_M0A                              \ M0A


\
\ @brief DMA stream 2 memory 1 address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S2M1AR_M1A                              \ M1A


\
\ @brief DMA stream 2 FIFO control register
\ Address offset: 0x54
\ Reset value: 0x00000021
\

$00000003 constant DMA2_DMA_S2FCR_FTH                               \ FTH
$00000004 constant DMA2_DMA_S2FCR_DMDIS                             \ DMDIS
$00000038 constant DMA2_DMA_S2FCR_FS                                \ FS
$00000080 constant DMA2_DMA_S2FCR_FEIE                              \ FEIE


\
\ @brief This register is used to configure the concerned stream.
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_S3CR_EN                                 \ EN
$00000002 constant DMA2_DMA_S3CR_DMEIE                              \ DMEIE
$00000004 constant DMA2_DMA_S3CR_TEIE                               \ TEIE
$00000008 constant DMA2_DMA_S3CR_HTIE                               \ HTIE
$00000010 constant DMA2_DMA_S3CR_TCIE                               \ TCIE
$00000020 constant DMA2_DMA_S3CR_PFCTRL                             \ PFCTRL
$000000c0 constant DMA2_DMA_S3CR_DIR                                \ DIR
$00000100 constant DMA2_DMA_S3CR_CIRC                               \ CIRC
$00000200 constant DMA2_DMA_S3CR_PINC                               \ PINC
$00000400 constant DMA2_DMA_S3CR_MINC                               \ MINC
$00001800 constant DMA2_DMA_S3CR_PSIZE                              \ PSIZE
$00006000 constant DMA2_DMA_S3CR_MSIZE                              \ MSIZE
$00008000 constant DMA2_DMA_S3CR_PINCOS                             \ PINCOS
$00030000 constant DMA2_DMA_S3CR_PL                                 \ PL
$00040000 constant DMA2_DMA_S3CR_DBM                                \ DBM
$00080000 constant DMA2_DMA_S3CR_CT                                 \ CT
$00600000 constant DMA2_DMA_S3CR_PBURST                             \ PBURST
$01800000 constant DMA2_DMA_S3CR_MBURST                             \ MBURST


\
\ @brief DMA stream 3 number of data register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_S3NDTR_NDT                              \ NDT


\
\ @brief DMA stream 3 peripheral address register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S3PAR_PAR                               \ PAR


\
\ @brief DMA stream 3 memory 0 address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S3M0AR_M0A                              \ M0A


\
\ @brief DMA stream 3 memory 1 address register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S3M1AR_M1A                              \ M1A


\
\ @brief DMA stream 3 FIFO control register
\ Address offset: 0x6C
\ Reset value: 0x00000021
\

$00000003 constant DMA2_DMA_S3FCR_FTH                               \ FTH
$00000004 constant DMA2_DMA_S3FCR_DMDIS                             \ DMDIS
$00000038 constant DMA2_DMA_S3FCR_FS                                \ FS
$00000080 constant DMA2_DMA_S3FCR_FEIE                              \ FEIE


\
\ @brief This register is used to configure the concerned stream.
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_S4CR_EN                                 \ EN
$00000002 constant DMA2_DMA_S4CR_DMEIE                              \ DMEIE
$00000004 constant DMA2_DMA_S4CR_TEIE                               \ TEIE
$00000008 constant DMA2_DMA_S4CR_HTIE                               \ HTIE
$00000010 constant DMA2_DMA_S4CR_TCIE                               \ TCIE
$00000020 constant DMA2_DMA_S4CR_PFCTRL                             \ PFCTRL
$000000c0 constant DMA2_DMA_S4CR_DIR                                \ DIR
$00000100 constant DMA2_DMA_S4CR_CIRC                               \ CIRC
$00000200 constant DMA2_DMA_S4CR_PINC                               \ PINC
$00000400 constant DMA2_DMA_S4CR_MINC                               \ MINC
$00001800 constant DMA2_DMA_S4CR_PSIZE                              \ PSIZE
$00006000 constant DMA2_DMA_S4CR_MSIZE                              \ MSIZE
$00008000 constant DMA2_DMA_S4CR_PINCOS                             \ PINCOS
$00030000 constant DMA2_DMA_S4CR_PL                                 \ PL
$00040000 constant DMA2_DMA_S4CR_DBM                                \ DBM
$00080000 constant DMA2_DMA_S4CR_CT                                 \ CT
$00600000 constant DMA2_DMA_S4CR_PBURST                             \ PBURST
$01800000 constant DMA2_DMA_S4CR_MBURST                             \ MBURST


\
\ @brief DMA stream 4 number of data register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_S4NDTR_NDT                              \ NDT


\
\ @brief DMA stream 4 peripheral address register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S4PAR_PAR                               \ PAR


\
\ @brief DMA stream 4 memory 0 address register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S4M0AR_M0A                              \ M0A


\
\ @brief DMA stream 4 memory 1 address register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S4M1AR_M1A                              \ M1A


\
\ @brief DMA stream 4 FIFO control register
\ Address offset: 0x84
\ Reset value: 0x00000021
\

$00000003 constant DMA2_DMA_S4FCR_FTH                               \ FTH
$00000004 constant DMA2_DMA_S4FCR_DMDIS                             \ DMDIS
$00000038 constant DMA2_DMA_S4FCR_FS                                \ FS
$00000080 constant DMA2_DMA_S4FCR_FEIE                              \ FEIE


\
\ @brief This register is used to configure the concerned stream.
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_S5CR_EN                                 \ EN
$00000002 constant DMA2_DMA_S5CR_DMEIE                              \ DMEIE
$00000004 constant DMA2_DMA_S5CR_TEIE                               \ TEIE
$00000008 constant DMA2_DMA_S5CR_HTIE                               \ HTIE
$00000010 constant DMA2_DMA_S5CR_TCIE                               \ TCIE
$00000020 constant DMA2_DMA_S5CR_PFCTRL                             \ PFCTRL
$000000c0 constant DMA2_DMA_S5CR_DIR                                \ DIR
$00000100 constant DMA2_DMA_S5CR_CIRC                               \ CIRC
$00000200 constant DMA2_DMA_S5CR_PINC                               \ PINC
$00000400 constant DMA2_DMA_S5CR_MINC                               \ MINC
$00001800 constant DMA2_DMA_S5CR_PSIZE                              \ PSIZE
$00006000 constant DMA2_DMA_S5CR_MSIZE                              \ MSIZE
$00008000 constant DMA2_DMA_S5CR_PINCOS                             \ PINCOS
$00030000 constant DMA2_DMA_S5CR_PL                                 \ PL
$00040000 constant DMA2_DMA_S5CR_DBM                                \ DBM
$00080000 constant DMA2_DMA_S5CR_CT                                 \ CT
$00600000 constant DMA2_DMA_S5CR_PBURST                             \ PBURST
$01800000 constant DMA2_DMA_S5CR_MBURST                             \ MBURST


\
\ @brief DMA stream 5 number of data register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_S5NDTR_NDT                              \ NDT


\
\ @brief DMA stream 5 peripheral address register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S5PAR_PAR                               \ PAR


\
\ @brief DMA stream 5 memory 0 address register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S5M0AR_M0A                              \ M0A


\
\ @brief DMA stream 5 memory 1 address register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S5M1AR_M1A                              \ M1A


\
\ @brief DMA stream 5 FIFO control register
\ Address offset: 0x9C
\ Reset value: 0x00000021
\

$00000003 constant DMA2_DMA_S5FCR_FTH                               \ FTH
$00000004 constant DMA2_DMA_S5FCR_DMDIS                             \ DMDIS
$00000038 constant DMA2_DMA_S5FCR_FS                                \ FS
$00000080 constant DMA2_DMA_S5FCR_FEIE                              \ FEIE


\
\ @brief This register is used to configure the concerned stream.
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_S6CR_EN                                 \ EN
$00000002 constant DMA2_DMA_S6CR_DMEIE                              \ DMEIE
$00000004 constant DMA2_DMA_S6CR_TEIE                               \ TEIE
$00000008 constant DMA2_DMA_S6CR_HTIE                               \ HTIE
$00000010 constant DMA2_DMA_S6CR_TCIE                               \ TCIE
$00000020 constant DMA2_DMA_S6CR_PFCTRL                             \ PFCTRL
$000000c0 constant DMA2_DMA_S6CR_DIR                                \ DIR
$00000100 constant DMA2_DMA_S6CR_CIRC                               \ CIRC
$00000200 constant DMA2_DMA_S6CR_PINC                               \ PINC
$00000400 constant DMA2_DMA_S6CR_MINC                               \ MINC
$00001800 constant DMA2_DMA_S6CR_PSIZE                              \ PSIZE
$00006000 constant DMA2_DMA_S6CR_MSIZE                              \ MSIZE
$00008000 constant DMA2_DMA_S6CR_PINCOS                             \ PINCOS
$00030000 constant DMA2_DMA_S6CR_PL                                 \ PL
$00040000 constant DMA2_DMA_S6CR_DBM                                \ DBM
$00080000 constant DMA2_DMA_S6CR_CT                                 \ CT
$00600000 constant DMA2_DMA_S6CR_PBURST                             \ PBURST
$01800000 constant DMA2_DMA_S6CR_MBURST                             \ MBURST


\
\ @brief DMA stream 6 number of data register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_S6NDTR_NDT                              \ NDT


\
\ @brief DMA stream 6 peripheral address register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S6PAR_PAR                               \ PAR


\
\ @brief DMA stream 6 memory 0 address register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S6M0AR_M0A                              \ M0A


\
\ @brief DMA stream 6 memory 1 address register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S6M1AR_M1A                              \ M1A


\
\ @brief DMA stream 6 FIFO control register
\ Address offset: 0xB4
\ Reset value: 0x00000021
\

$00000003 constant DMA2_DMA_S6FCR_FTH                               \ FTH
$00000004 constant DMA2_DMA_S6FCR_DMDIS                             \ DMDIS
$00000038 constant DMA2_DMA_S6FCR_FS                                \ FS
$00000080 constant DMA2_DMA_S6FCR_FEIE                              \ FEIE


\
\ @brief This register is used to configure the concerned stream.
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant DMA2_DMA_S7CR_EN                                 \ EN
$00000002 constant DMA2_DMA_S7CR_DMEIE                              \ DMEIE
$00000004 constant DMA2_DMA_S7CR_TEIE                               \ TEIE
$00000008 constant DMA2_DMA_S7CR_HTIE                               \ HTIE
$00000010 constant DMA2_DMA_S7CR_TCIE                               \ TCIE
$00000020 constant DMA2_DMA_S7CR_PFCTRL                             \ PFCTRL
$000000c0 constant DMA2_DMA_S7CR_DIR                                \ DIR
$00000100 constant DMA2_DMA_S7CR_CIRC                               \ CIRC
$00000200 constant DMA2_DMA_S7CR_PINC                               \ PINC
$00000400 constant DMA2_DMA_S7CR_MINC                               \ MINC
$00001800 constant DMA2_DMA_S7CR_PSIZE                              \ PSIZE
$00006000 constant DMA2_DMA_S7CR_MSIZE                              \ MSIZE
$00008000 constant DMA2_DMA_S7CR_PINCOS                             \ PINCOS
$00030000 constant DMA2_DMA_S7CR_PL                                 \ PL
$00040000 constant DMA2_DMA_S7CR_DBM                                \ DBM
$00080000 constant DMA2_DMA_S7CR_CT                                 \ CT
$00600000 constant DMA2_DMA_S7CR_PBURST                             \ PBURST
$01800000 constant DMA2_DMA_S7CR_MBURST                             \ MBURST


\
\ @brief DMA stream 7 number of data register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$0000ffff constant DMA2_DMA_S7NDTR_NDT                              \ NDT


\
\ @brief DMA stream 7 peripheral address register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S7PAR_PAR                               \ PAR


\
\ @brief DMA stream 7 memory 0 address register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S7M0AR_M0A                              \ M0A


\
\ @brief DMA stream 7 memory 1 address register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant DMA2_DMA_S7M1AR_M1A                              \ M1A


\
\ @brief DMA stream 7 FIFO control register
\ Address offset: 0xCC
\ Reset value: 0x00000021
\

$00000003 constant DMA2_DMA_S7FCR_FTH                               \ FTH
$00000004 constant DMA2_DMA_S7FCR_DMDIS                             \ DMDIS
$00000038 constant DMA2_DMA_S7FCR_FS                                \ FS
$00000080 constant DMA2_DMA_S7FCR_FEIE                              \ FEIE


\
\ @brief DMA hardware configuration 2register
\ Address offset: 0x3EC
\ Reset value: 0x00000001
\

$00000003 constant DMA2_DMA_HWCFGR2_FIFO_SIZE                       \ FIFO_SIZE
$00000010 constant DMA2_DMA_HWCFGR2_WRITE_BUFFERABLE                \ WRITE_BUFFERABLE
$00000700 constant DMA2_DMA_HWCFGR2_CHSEL_WIDTH                     \ CHSEL_WIDTH


\
\ @brief DMA hardware configuration 1 register
\ Address offset: 0x3F0
\ Reset value: 0x22222222
\

$00000003 constant DMA2_DMA_HWCFGR1_DMA_DEF0                        \ DMA_DEF0
$00000030 constant DMA2_DMA_HWCFGR1_DMA_DEF1                        \ DMA_DEF1
$00000300 constant DMA2_DMA_HWCFGR1_DMA_DEF2                        \ DMA_DEF2
$00003000 constant DMA2_DMA_HWCFGR1_DMA_DEF3                        \ DMA_DEF3
$00030000 constant DMA2_DMA_HWCFGR1_DMA_DEF4                        \ DMA_DEF4
$00300000 constant DMA2_DMA_HWCFGR1_DMA_DEF5                        \ DMA_DEF5
$03000000 constant DMA2_DMA_HWCFGR1_DMA_DEF6                        \ DMA_DEF6
$30000000 constant DMA2_DMA_HWCFGR1_DMA_DEF7                        \ DMA_DEF7


\
\ @brief This register identifies the version of the IP.
\ Address offset: 0x3F4
\ Reset value: 0x00000014
\

$0000000f constant DMA2_DMA_VERR_MINREV                             \ MINREV
$000000f0 constant DMA2_DMA_VERR_MAJREV                             \ MAJREV


\
\ @brief DMA IP identification register
\ Address offset: 0x3F8
\ Reset value: 0x00100002
\

$00000000 constant DMA2_DMA_IPDR_ID                                 \ ID


\
\ @brief DMA size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant DMA2_DMA_SIDR_SID                                \ SID


\
\ @brief DMA2 stream0 global interrupt
\
$48001000 constant DMA2_DMA_LISR  \ offset: 0x00 : DMA low interrupt status register
$48001004 constant DMA2_DMA_HISR  \ offset: 0x04 : DMA high interrupt status register
$48001008 constant DMA2_DMA_LIFCR  \ offset: 0x08 : DMA low interrupt flag clear register
$4800100c constant DMA2_DMA_HIFCR  \ offset: 0x0C : DMA high interrupt flag clear register
$48001010 constant DMA2_DMA_S0CR  \ offset: 0x10 : This register is used to configure the concerned stream.
$48001014 constant DMA2_DMA_S0NDTR  \ offset: 0x14 : DMA stream 0 number of data register
$48001018 constant DMA2_DMA_S0PAR  \ offset: 0x18 : DMA stream 0 peripheral address register
$4800101c constant DMA2_DMA_S0M0AR  \ offset: 0x1C : DMA stream 0 memory 0 address register
$48001020 constant DMA2_DMA_S0M1AR  \ offset: 0x20 : DMA stream 0 memory 1 address register
$48001024 constant DMA2_DMA_S0FCR  \ offset: 0x24 : DMA stream 0 FIFO control register
$48001028 constant DMA2_DMA_S1CR  \ offset: 0x28 : This register is used to configure the concerned stream.
$4800102c constant DMA2_DMA_S1NDTR  \ offset: 0x2C : DMA stream 1 number of data register
$48001030 constant DMA2_DMA_S1PAR  \ offset: 0x30 : DMA stream 1 peripheral address register
$48001034 constant DMA2_DMA_S1M0AR  \ offset: 0x34 : DMA stream 1 memory 0 address register
$48001038 constant DMA2_DMA_S1M1AR  \ offset: 0x38 : DMA stream 1 memory 1 address register
$4800103c constant DMA2_DMA_S1FCR  \ offset: 0x3C : DMA stream 1 FIFO control register
$48001040 constant DMA2_DMA_S2CR  \ offset: 0x40 : This register is used to configure the concerned stream.
$48001044 constant DMA2_DMA_S2NDTR  \ offset: 0x44 : DMA stream 2 number of data register
$48001048 constant DMA2_DMA_S2PAR  \ offset: 0x48 : DMA stream 2 peripheral address register
$4800104c constant DMA2_DMA_S2M0AR  \ offset: 0x4C : DMA stream 2 memory 0 address register
$48001050 constant DMA2_DMA_S2M1AR  \ offset: 0x50 : DMA stream 2 memory 1 address register
$48001054 constant DMA2_DMA_S2FCR  \ offset: 0x54 : DMA stream 2 FIFO control register
$48001058 constant DMA2_DMA_S3CR  \ offset: 0x58 : This register is used to configure the concerned stream.
$4800105c constant DMA2_DMA_S3NDTR  \ offset: 0x5C : DMA stream 3 number of data register
$48001060 constant DMA2_DMA_S3PAR  \ offset: 0x60 : DMA stream 3 peripheral address register
$48001064 constant DMA2_DMA_S3M0AR  \ offset: 0x64 : DMA stream 3 memory 0 address register
$48001068 constant DMA2_DMA_S3M1AR  \ offset: 0x68 : DMA stream 3 memory 1 address register
$4800106c constant DMA2_DMA_S3FCR  \ offset: 0x6C : DMA stream 3 FIFO control register
$48001070 constant DMA2_DMA_S4CR  \ offset: 0x70 : This register is used to configure the concerned stream.
$48001074 constant DMA2_DMA_S4NDTR  \ offset: 0x74 : DMA stream 4 number of data register
$48001078 constant DMA2_DMA_S4PAR  \ offset: 0x78 : DMA stream 4 peripheral address register
$4800107c constant DMA2_DMA_S4M0AR  \ offset: 0x7C : DMA stream 4 memory 0 address register
$48001080 constant DMA2_DMA_S4M1AR  \ offset: 0x80 : DMA stream 4 memory 1 address register
$48001084 constant DMA2_DMA_S4FCR  \ offset: 0x84 : DMA stream 4 FIFO control register
$48001088 constant DMA2_DMA_S5CR  \ offset: 0x88 : This register is used to configure the concerned stream.
$4800108c constant DMA2_DMA_S5NDTR  \ offset: 0x8C : DMA stream 5 number of data register
$48001090 constant DMA2_DMA_S5PAR  \ offset: 0x90 : DMA stream 5 peripheral address register
$48001094 constant DMA2_DMA_S5M0AR  \ offset: 0x94 : DMA stream 5 memory 0 address register
$48001098 constant DMA2_DMA_S5M1AR  \ offset: 0x98 : DMA stream 5 memory 1 address register
$4800109c constant DMA2_DMA_S5FCR  \ offset: 0x9C : DMA stream 5 FIFO control register
$480010a0 constant DMA2_DMA_S6CR  \ offset: 0xA0 : This register is used to configure the concerned stream.
$480010a4 constant DMA2_DMA_S6NDTR  \ offset: 0xA4 : DMA stream 6 number of data register
$480010a8 constant DMA2_DMA_S6PAR  \ offset: 0xA8 : DMA stream 6 peripheral address register
$480010ac constant DMA2_DMA_S6M0AR  \ offset: 0xAC : DMA stream 6 memory 0 address register
$480010b0 constant DMA2_DMA_S6M1AR  \ offset: 0xB0 : DMA stream 6 memory 1 address register
$480010b4 constant DMA2_DMA_S6FCR  \ offset: 0xB4 : DMA stream 6 FIFO control register
$480010b8 constant DMA2_DMA_S7CR  \ offset: 0xB8 : This register is used to configure the concerned stream.
$480010bc constant DMA2_DMA_S7NDTR  \ offset: 0xBC : DMA stream 7 number of data register
$480010c0 constant DMA2_DMA_S7PAR  \ offset: 0xC0 : DMA stream 7 peripheral address register
$480010c4 constant DMA2_DMA_S7M0AR  \ offset: 0xC4 : DMA stream 7 memory 0 address register
$480010c8 constant DMA2_DMA_S7M1AR  \ offset: 0xC8 : DMA stream 7 memory 1 address register
$480010cc constant DMA2_DMA_S7FCR  \ offset: 0xCC : DMA stream 7 FIFO control register
$480013ec constant DMA2_DMA_HWCFGR2  \ offset: 0x3EC : DMA hardware configuration 2register
$480013f0 constant DMA2_DMA_HWCFGR1  \ offset: 0x3F0 : DMA hardware configuration 1 register
$480013f4 constant DMA2_DMA_VERR  \ offset: 0x3F4 : This register identifies the version of the IP.
$480013f8 constant DMA2_DMA_IPDR  \ offset: 0x3F8 : DMA IP identification register
$480013fc constant DMA2_DMA_SIDR  \ offset: 0x3FC : DMA size identification register

