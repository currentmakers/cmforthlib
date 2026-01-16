\
\ @file jpeg.fs
\ @brief JPEG codec
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief JPEG codec configuration register 0
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant JPEG_JPEG_CONFR0_START                           \ Start


\
\ @brief JPEG codec configuration register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000003 constant JPEG_JPEG_CONFR1_NF                              \ Number of color components
$00000008 constant JPEG_JPEG_CONFR1_DE                              \ Decoding Enable
$00000030 constant JPEG_JPEG_CONFR1_COLORSPACE                      \ Color Space
$000000c0 constant JPEG_JPEG_CONFR1_NS                              \ Number of components for Scan
$00000100 constant JPEG_JPEG_CONFR1_HDR                             \ Header Processing
$ffff0000 constant JPEG_JPEG_CONFR1_YSIZE                           \ Y Size


\
\ @brief JPEG codec configuration register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$03ffffff constant JPEG_JPEG_CONFR2_NMCU                            \ Number of MCU


\
\ @brief JPEG codec configuration register 3
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$ffff0000 constant JPEG_JPEG_CONFR3_XSIZE                           \ X size


\
\ @brief JPEG codec configuration register 4
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant JPEG_JPEG_CONFR4_HD                              \ Huffman DC
$00000002 constant JPEG_JPEG_CONFR4_HA                              \ Huffman AC
$0000000c constant JPEG_JPEG_CONFR4_QT                              \ Quantization Table
$000000f0 constant JPEG_JPEG_CONFR4_NB                              \ Number of Block
$00000f00 constant JPEG_JPEG_CONFR4_VSF                             \ Vertical Sampling Factor
$0000f000 constant JPEG_JPEG_CONFR4_HSF                             \ Horizontal Sampling Factor


\
\ @brief JPEG codec configuration register 5
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant JPEG_JPEG_CONFR5_HD                              \ Huffman DC
$00000002 constant JPEG_JPEG_CONFR5_HA                              \ Huffman AC
$0000000c constant JPEG_JPEG_CONFR5_QT                              \ Quantization Table
$000000f0 constant JPEG_JPEG_CONFR5_NB                              \ Number of Block
$00000f00 constant JPEG_JPEG_CONFR5_VSF                             \ Vertical Sampling Factor
$0000f000 constant JPEG_JPEG_CONFR5_HSF                             \ Horizontal Sampling Factor


\
\ @brief JPEG codec configuration register 6
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant JPEG_JPEG_CONFR6_HD                              \ Huffman DC
$00000002 constant JPEG_JPEG_CONFR6_HA                              \ Huffman AC
$0000000c constant JPEG_JPEG_CONFR6_QT                              \ Quantization Table
$000000f0 constant JPEG_JPEG_CONFR6_NB                              \ Number of Block
$00000f00 constant JPEG_JPEG_CONFR6_VSF                             \ Vertical Sampling Factor
$0000f000 constant JPEG_JPEG_CONFR6_HSF                             \ Horizontal Sampling Factor


\
\ @brief JPEG codec configuration register 7
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant JPEG_JPEG_CONFR7_HD                              \ Huffman DC
$00000002 constant JPEG_JPEG_CONFR7_HA                              \ Huffman AC
$0000000c constant JPEG_JPEG_CONFR7_QT                              \ Quantization Table
$000000f0 constant JPEG_JPEG_CONFR7_NB                              \ Number of Block
$00000f00 constant JPEG_JPEG_CONFR7_VSF                             \ Vertical Sampling Factor
$0000f000 constant JPEG_JPEG_CONFR7_HSF                             \ Horizontal Sampling Factor


\
\ @brief JPEG control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant JPEG_JPEG_CR_JCEN                                \ JPEG Core Enable
$00000002 constant JPEG_JPEG_CR_IFTIE                               \ Input FIFO Threshold Interrupt Enable
$00000004 constant JPEG_JPEG_CR_IFNFIE                              \ Input FIFO Not Full Interrupt Enable
$00000008 constant JPEG_JPEG_CR_OFTIE                               \ Output FIFO Threshold Interrupt Enable
$00000010 constant JPEG_JPEG_CR_OFNEIE                              \ Output FIFO Not Empty Interrupt Enable
$00000020 constant JPEG_JPEG_CR_EOCIE                               \ End of Conversion Interrupt Enable
$00000040 constant JPEG_JPEG_CR_HPDIE                               \ Header Parsing Done Interrupt Enable
$00000800 constant JPEG_JPEG_CR_IDMAEN                              \ Input DMA Enable
$00001000 constant JPEG_JPEG_CR_ODMAEN                              \ Output DMA Enable
$00002000 constant JPEG_JPEG_CR_IFF                                 \ Input FIFO Flush
$00004000 constant JPEG_JPEG_CR_OFF                                 \ Output FIFO Flush


\
\ @brief JPEG status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000002 constant JPEG_JPEG_SR_IFTF                                \ Input FIFO Threshold Flag
$00000004 constant JPEG_JPEG_SR_IFNFF                               \ Input FIFO Not Full Flag
$00000008 constant JPEG_JPEG_SR_OFTF                                \ Output FIFO Threshold Flag
$00000010 constant JPEG_JPEG_SR_OFNEF                               \ Output FIFO Not Empty Flag
$00000020 constant JPEG_JPEG_SR_EOCF                                \ End of Conversion Flag
$00000040 constant JPEG_JPEG_SR_HPDF                                \ Header Parsing Done Flag
$00000080 constant JPEG_JPEG_SR_COF                                 \ Codec Operation Flag


\
\ @brief JPEG clear flag register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000020 constant JPEG_JPEG_CFR_CEOCF                              \ Clear End of Conversion Flag
$00000040 constant JPEG_JPEG_CFR_CHPDF                              \ Clear Header Parsing Done Flag


\
\ @brief JPEG data input register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant JPEG_JPEG_DIR_DATAIN                             \ Data Input FIFO


\
\ @brief JPEG data output register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant JPEG_JPEG_DOR_DATAOUT                            \ Data Output FIFO


\
\ @brief JPEG quantization tables
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_0_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_1_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_2_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_3_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_4_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_5_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_6_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_7_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_8_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_9_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_10_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_11_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_12_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_13_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_14_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM0_15_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_0_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_1_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_2_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_3_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_4_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_5_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_6_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_7_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_8_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_9_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_10_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_11_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_12_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_13_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_14_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM1_15_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_0_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_1_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_2_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_3_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_4_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_5_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_6_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_7_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_8_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_9_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_10_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_11_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_12_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_13_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_14_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM2_15_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_0_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_1_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_2_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_3_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_4_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_5_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_6_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_7_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_8_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_9_QMEM_RAM                            \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_10_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_11_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_12_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_13_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_14_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG quantization tables
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_QMEM3_15_QMEM_RAM                           \ QMem RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_0_HUFFMIN_RAM                       \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_1_HUFFMIN_RAM                       \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_2_HUFFMIN_RAM                       \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_3_HUFFMIN_RAM                       \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_4_HUFFMIN_RAM                       \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_5_HUFFMIN_RAM                       \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_6_HUFFMIN_RAM                       \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_7_HUFFMIN_RAM                       \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_8_HUFFMIN_RAM                       \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_9_HUFFMIN_RAM                       \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_10_HUFFMIN_RAM                      \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_11_HUFFMIN_RAM                      \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_12_HUFFMIN_RAM                      \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_13_HUFFMIN_RAM                      \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_14_HUFFMIN_RAM                      \ HuffMin RAM


\
\ @brief JPEG HuffMin tables
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFMIN_15_HUFFMIN_RAM                      \ HuffMin RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE0_HUFFBASE_RAM_0                    \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE0_HUFFBASE_RAM_1                    \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE1_HUFFBASE_RAM_0                    \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE1_HUFFBASE_RAM_1                    \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE2_HUFFBASE_RAM_0                    \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE2_HUFFBASE_RAM_1                    \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE3_HUFFBASE_RAM_0                    \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE3_HUFFBASE_RAM_1                    \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE4_HUFFBASE_RAM_0                    \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE4_HUFFBASE_RAM_1                    \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE5_HUFFBASE_RAM_0                    \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE5_HUFFBASE_RAM_1                    \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE6_HUFFBASE_RAM_0                    \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE6_HUFFBASE_RAM_1                    \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE7_HUFFBASE_RAM_0                    \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE7_HUFFBASE_RAM_1                    \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE8_HUFFBASE_RAM_0                    \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE8_HUFFBASE_RAM_1                    \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE9_HUFFBASE_RAM_0                    \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE9_HUFFBASE_RAM_1                    \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE10_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE10_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE11_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE11_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE12_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE12_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE13_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE13_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE14_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE14_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE15_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE15_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE16_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE16_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE17_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE17_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1D8
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE18_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE18_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE19_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE19_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE20_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE20_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE21_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE21_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE22_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE22_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE23_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE23_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE24_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE24_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE25_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE25_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1F8
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE26_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE26_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x1FC
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE27_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE27_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE28_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE28_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE29_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE29_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE30_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE30_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HuffSymb tables
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$000001ff constant JPEG_HUFFBASE31_HUFFBASE_RAM_0                   \ HuffBase RAM
$01ff0000 constant JPEG_HUFFBASE31_HUFFBASE_RAM_1                   \ HuffBase RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB0_HUFFSYMB_RAM                      \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB1_HUFFSYMB_RAM                      \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB2_HUFFSYMB_RAM                      \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB3_HUFFSYMB_RAM                      \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB4_HUFFSYMB_RAM                      \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB5_HUFFSYMB_RAM                      \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB6_HUFFSYMB_RAM                      \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB7_HUFFSYMB_RAM                      \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB8_HUFFSYMB_RAM                      \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB9_HUFFSYMB_RAM                      \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB10_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x23C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB11_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB12_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB13_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB14_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB15_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB16_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB17_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB18_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB19_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB20_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB21_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB22_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB23_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB24_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB25_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x278
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB26_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB27_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB28_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB29_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB30_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB31_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB32_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB33_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB34_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB35_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB36_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB37_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB38_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB39_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2B0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB40_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2B4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB41_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2B8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB42_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2BC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB43_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2C0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB44_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2C4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB45_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2C8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB46_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB47_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB48_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2D4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB49_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2D8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB50_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB51_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2E0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB52_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB53_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2E8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB54_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2EC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB55_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2F0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB56_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2F4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB57_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2F8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB58_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x2FC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB59_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB60_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB61_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB62_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB63_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB64_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB65_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB66_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB67_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB68_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB69_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB70_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB71_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB72_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB73_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB74_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x33C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB75_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB76_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB77_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x348
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB78_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB79_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB80_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x354
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB81_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x358
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB82_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG HUFFSYMB tables
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFSYMB83_HUFFSYMB_RAM                     \ DHTSymb RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x360
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM0_DHTMEM_RAM                          \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM2_DHTMEM_RAM                          \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x368
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM3_DHTMEM_RAM                          \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x36C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM4_DHTMEM_RAM                          \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM5_DHTMEM_RAM                          \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x374
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM6_DHTMEM_RAM                          \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x378
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM7_DHTMEM_RAM                          \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x37C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM8_DHTMEM_RAM                          \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM9_DHTMEM_RAM                          \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM10_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x388
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM11_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x38C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM12_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM13_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM14_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM15_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM16_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM17_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3A4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM18_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3A8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM19_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3AC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM20_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3B0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM21_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3B4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM22_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3B8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM23_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3BC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM24_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3C0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM25_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3C4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM26_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3C8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM27_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3CC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM28_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM29_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3D4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM30_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3D8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM31_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM32_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM33_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM34_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3E8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM35_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3EC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM36_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM37_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3F4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM38_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3F8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM39_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x3FC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM40_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM41_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM42_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM43_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM44_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM45_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM46_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM47_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM48_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM49_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM50_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM51_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x42C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM52_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x430
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM53_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x434
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM54_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x438
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM55_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x43C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM56_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM57_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x444
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM58_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x448
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM59_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x44C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM60_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x450
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM61_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x454
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM62_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x458
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM63_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x45C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM64_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x460
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM65_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x464
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM66_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x468
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM67_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x46C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM68_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x470
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM69_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x474
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM70_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x478
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM71_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x47C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM72_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x480
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM73_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x484
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM74_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x488
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM75_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x48C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM76_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x490
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM77_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x494
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM78_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM79_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x49C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM80_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM81_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4A4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM82_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4A8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM83_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4AC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM84_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4B0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM85_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4B4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM86_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4B8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM87_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4BC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM88_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4C0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM89_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4C4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM90_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4C8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM91_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4CC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM92_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4D0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM93_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4D4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM94_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4D8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM95_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4DC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM96_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4E0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM97_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4E4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM98_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4E8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM99_DHTMEM_RAM                         \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4EC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM100_DHTMEM_RAM                        \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4F0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM101_DHTMEM_RAM                        \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4F4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM102_DHTMEM_RAM                        \ DHTMem RAM


\
\ @brief JPEG DHTMem tables
\ Address offset: 0x4F8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DHTMEM103_DHTMEM_RAM                        \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_0_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x504
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_1_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_2_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x50C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_3_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_4_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x514
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_5_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x518
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_6_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x51C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_7_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_8_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x524
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_9_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x528
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_10_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x52C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_11_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x530
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_12_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x534
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_13_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x538
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_14_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x53C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_15_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x540
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_16_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x544
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_17_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x548
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_18_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_19_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_20_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x554
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_21_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x558
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_22_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x55C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_23_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x560
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_24_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x564
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_25_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x568
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_26_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x56C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_27_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x570
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_28_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x574
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_29_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x578
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_30_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x57C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_31_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x580
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_32_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x584
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_33_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x588
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_34_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x58C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_35_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x590
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_36_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x594
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_37_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x598
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_38_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x59C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_39_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5A0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_40_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5A4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_41_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5A8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_42_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5AC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_43_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5B0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_44_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5B4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_45_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5B8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_46_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5BC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_47_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5C0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_48_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5C4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_49_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5C8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_50_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5CC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_51_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_52_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5D4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_53_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5D8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_54_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5DC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_55_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5E0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_56_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5E4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_57_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5E8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_58_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5EC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_59_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5F0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_60_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5F4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_61_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5F8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_62_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x5FC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_63_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_64_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_65_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_66_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_67_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_68_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_69_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x618
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_70_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x61C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_71_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_72_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x624
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_73_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_74_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x62C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_75_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_76_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x634
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_77_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x638
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_78_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x63C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_79_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_80_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x644
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_81_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x648
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_82_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_83_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_84_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_85_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x658
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_86_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 0
\ Address offset: 0x65C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC0_87_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x660
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_0_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_1_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x668
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_2_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x66C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_3_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x670
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_4_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x674
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_5_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x678
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_6_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x67C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_7_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x680
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_8_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x684
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_9_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x688
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_10_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x68C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_11_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x690
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_12_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x694
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_13_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x698
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_14_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x69C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_15_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6A0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_16_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6A4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_17_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6A8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_18_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6AC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_19_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6B0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_20_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6B4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_21_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6B8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_22_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6BC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_23_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6C0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_24_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6C4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_25_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6C8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_26_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6CC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_27_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6D0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_28_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6D4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_29_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6D8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_30_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6DC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_31_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6E0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_32_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6E4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_33_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6E8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_34_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6EC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_35_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6F0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_36_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6F4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_37_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6F8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_38_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x6FC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_39_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x700
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_40_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x704
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_41_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x708
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_42_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x70C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_43_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x710
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_44_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x714
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_45_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x718
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_46_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x71C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_47_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x720
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_48_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x724
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_49_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x728
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_50_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x72C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_51_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x730
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_52_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x734
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_53_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x738
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_54_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x73C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_55_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x740
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_56_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x744
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_57_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x748
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_58_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x74C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_59_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x750
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_60_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x754
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_61_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x758
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_62_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x75C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_63_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x760
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_64_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x764
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_65_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x768
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_66_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x76C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_67_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x770
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_68_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x774
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_69_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x778
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_70_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x77C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_71_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x780
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_72_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x784
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_73_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x788
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_74_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x78C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_75_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x790
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_76_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x794
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_77_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x798
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_78_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x79C
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_79_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x7A0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_80_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x7A4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_81_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x7A8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_82_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x7AC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_83_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x7B0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_84_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x7B4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_85_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x7B8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_86_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, AC Huffman table 1
\ Address offset: 0x7BC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_AC1_87_DHTMEM_RAM                   \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 0
\ Address offset: 0x7C0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC0_0_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 0
\ Address offset: 0x7C4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC0_1_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 0
\ Address offset: 0x7C8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC0_2_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 0
\ Address offset: 0x7CC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC0_3_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 0
\ Address offset: 0x7D0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC0_4_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 0
\ Address offset: 0x7D4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC0_5_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 0
\ Address offset: 0x7D8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC0_6_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 0
\ Address offset: 0x7DC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC0_7_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 1
\ Address offset: 0x7E0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC1_0_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 1
\ Address offset: 0x7E4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC1_1_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 1
\ Address offset: 0x7E8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC1_2_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 1
\ Address offset: 0x7EC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC1_3_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 1
\ Address offset: 0x7F0
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC1_4_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 1
\ Address offset: 0x7F4
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC1_5_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 1
\ Address offset: 0x7F8
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC1_6_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG encoder, DC Huffman table 1
\ Address offset: 0x7FC
\ Reset value: 0x00000000
\

$00000000 constant JPEG_HUFFENC_DC1_7_DHTMEM_RAM                    \ DHTMem RAM


\
\ @brief JPEG codec
\
$50051000 constant JPEG_JPEG_CONFR0  \ offset: 0x00 : JPEG codec configuration register 0
$50051004 constant JPEG_JPEG_CONFR1  \ offset: 0x04 : JPEG codec configuration register 1
$50051008 constant JPEG_JPEG_CONFR2  \ offset: 0x08 : JPEG codec configuration register 2
$5005100c constant JPEG_JPEG_CONFR3  \ offset: 0x0C : JPEG codec configuration register 3
$50051010 constant JPEG_JPEG_CONFR4  \ offset: 0x10 : JPEG codec configuration register 4
$50051014 constant JPEG_JPEG_CONFR5  \ offset: 0x14 : JPEG codec configuration register 5
$50051018 constant JPEG_JPEG_CONFR6  \ offset: 0x18 : JPEG codec configuration register 6
$5005101c constant JPEG_JPEG_CONFR7  \ offset: 0x1C : JPEG codec configuration register 7
$50051030 constant JPEG_JPEG_CR   \ offset: 0x30 : JPEG control register
$50051034 constant JPEG_JPEG_SR   \ offset: 0x34 : JPEG status register
$50051038 constant JPEG_JPEG_CFR  \ offset: 0x38 : JPEG clear flag register
$50051040 constant JPEG_JPEG_DIR  \ offset: 0x40 : JPEG data input register
$50051044 constant JPEG_JPEG_DOR  \ offset: 0x44 : JPEG data output register
$50051050 constant JPEG_QMEM0_0   \ offset: 0x50 : JPEG quantization tables
$50051054 constant JPEG_QMEM0_1   \ offset: 0x54 : JPEG quantization tables
$50051058 constant JPEG_QMEM0_2   \ offset: 0x58 : JPEG quantization tables
$5005105c constant JPEG_QMEM0_3   \ offset: 0x5C : JPEG quantization tables
$50051060 constant JPEG_QMEM0_4   \ offset: 0x60 : JPEG quantization tables
$50051064 constant JPEG_QMEM0_5   \ offset: 0x64 : JPEG quantization tables
$50051068 constant JPEG_QMEM0_6   \ offset: 0x68 : JPEG quantization tables
$5005106c constant JPEG_QMEM0_7   \ offset: 0x6C : JPEG quantization tables
$50051070 constant JPEG_QMEM0_8   \ offset: 0x70 : JPEG quantization tables
$50051074 constant JPEG_QMEM0_9   \ offset: 0x74 : JPEG quantization tables
$50051078 constant JPEG_QMEM0_10  \ offset: 0x78 : JPEG quantization tables
$5005107c constant JPEG_QMEM0_11  \ offset: 0x7C : JPEG quantization tables
$50051080 constant JPEG_QMEM0_12  \ offset: 0x80 : JPEG quantization tables
$50051084 constant JPEG_QMEM0_13  \ offset: 0x84 : JPEG quantization tables
$50051088 constant JPEG_QMEM0_14  \ offset: 0x88 : JPEG quantization tables
$5005108c constant JPEG_QMEM0_15  \ offset: 0x8C : JPEG quantization tables
$50051090 constant JPEG_QMEM1_0   \ offset: 0x90 : JPEG quantization tables
$50051094 constant JPEG_QMEM1_1   \ offset: 0x94 : JPEG quantization tables
$50051098 constant JPEG_QMEM1_2   \ offset: 0x98 : JPEG quantization tables
$5005109c constant JPEG_QMEM1_3   \ offset: 0x9C : JPEG quantization tables
$500510a0 constant JPEG_QMEM1_4   \ offset: 0xA0 : JPEG quantization tables
$500510a4 constant JPEG_QMEM1_5   \ offset: 0xA4 : JPEG quantization tables
$500510a8 constant JPEG_QMEM1_6   \ offset: 0xA8 : JPEG quantization tables
$500510ac constant JPEG_QMEM1_7   \ offset: 0xAC : JPEG quantization tables
$500510b0 constant JPEG_QMEM1_8   \ offset: 0xB0 : JPEG quantization tables
$500510b4 constant JPEG_QMEM1_9   \ offset: 0xB4 : JPEG quantization tables
$500510b8 constant JPEG_QMEM1_10  \ offset: 0xB8 : JPEG quantization tables
$500510bc constant JPEG_QMEM1_11  \ offset: 0xBC : JPEG quantization tables
$500510c0 constant JPEG_QMEM1_12  \ offset: 0xC0 : JPEG quantization tables
$500510c4 constant JPEG_QMEM1_13  \ offset: 0xC4 : JPEG quantization tables
$500510c8 constant JPEG_QMEM1_14  \ offset: 0xC8 : JPEG quantization tables
$500510cc constant JPEG_QMEM1_15  \ offset: 0xCC : JPEG quantization tables
$500510d0 constant JPEG_QMEM2_0   \ offset: 0xD0 : JPEG quantization tables
$500510d4 constant JPEG_QMEM2_1   \ offset: 0xD4 : JPEG quantization tables
$500510d8 constant JPEG_QMEM2_2   \ offset: 0xD8 : JPEG quantization tables
$500510dc constant JPEG_QMEM2_3   \ offset: 0xDC : JPEG quantization tables
$500510e0 constant JPEG_QMEM2_4   \ offset: 0xE0 : JPEG quantization tables
$500510e4 constant JPEG_QMEM2_5   \ offset: 0xE4 : JPEG quantization tables
$500510e8 constant JPEG_QMEM2_6   \ offset: 0xE8 : JPEG quantization tables
$500510ec constant JPEG_QMEM2_7   \ offset: 0xEC : JPEG quantization tables
$500510f0 constant JPEG_QMEM2_8   \ offset: 0xF0 : JPEG quantization tables
$500510f4 constant JPEG_QMEM2_9   \ offset: 0xF4 : JPEG quantization tables
$500510f8 constant JPEG_QMEM2_10  \ offset: 0xF8 : JPEG quantization tables
$500510fc constant JPEG_QMEM2_11  \ offset: 0xFC : JPEG quantization tables
$50051100 constant JPEG_QMEM2_12  \ offset: 0x100 : JPEG quantization tables
$50051104 constant JPEG_QMEM2_13  \ offset: 0x104 : JPEG quantization tables
$50051108 constant JPEG_QMEM2_14  \ offset: 0x108 : JPEG quantization tables
$5005110c constant JPEG_QMEM2_15  \ offset: 0x10C : JPEG quantization tables
$50051110 constant JPEG_QMEM3_0   \ offset: 0x110 : JPEG quantization tables
$50051114 constant JPEG_QMEM3_1   \ offset: 0x114 : JPEG quantization tables
$50051118 constant JPEG_QMEM3_2   \ offset: 0x118 : JPEG quantization tables
$5005111c constant JPEG_QMEM3_3   \ offset: 0x11C : JPEG quantization tables
$50051120 constant JPEG_QMEM3_4   \ offset: 0x120 : JPEG quantization tables
$50051124 constant JPEG_QMEM3_5   \ offset: 0x124 : JPEG quantization tables
$50051128 constant JPEG_QMEM3_6   \ offset: 0x128 : JPEG quantization tables
$5005112c constant JPEG_QMEM3_7   \ offset: 0x12C : JPEG quantization tables
$50051130 constant JPEG_QMEM3_8   \ offset: 0x130 : JPEG quantization tables
$50051134 constant JPEG_QMEM3_9   \ offset: 0x134 : JPEG quantization tables
$50051138 constant JPEG_QMEM3_10  \ offset: 0x138 : JPEG quantization tables
$5005113c constant JPEG_QMEM3_11  \ offset: 0x13C : JPEG quantization tables
$50051140 constant JPEG_QMEM3_12  \ offset: 0x140 : JPEG quantization tables
$50051144 constant JPEG_QMEM3_13  \ offset: 0x144 : JPEG quantization tables
$50051148 constant JPEG_QMEM3_14  \ offset: 0x148 : JPEG quantization tables
$5005114c constant JPEG_QMEM3_15  \ offset: 0x14C : JPEG quantization tables
$50051150 constant JPEG_HUFFMIN_0  \ offset: 0x150 : JPEG HuffMin tables
$50051154 constant JPEG_HUFFMIN_1  \ offset: 0x154 : JPEG HuffMin tables
$50051158 constant JPEG_HUFFMIN_2  \ offset: 0x158 : JPEG HuffMin tables
$5005115c constant JPEG_HUFFMIN_3  \ offset: 0x15C : JPEG HuffMin tables
$50051160 constant JPEG_HUFFMIN_4  \ offset: 0x160 : JPEG HuffMin tables
$50051164 constant JPEG_HUFFMIN_5  \ offset: 0x164 : JPEG HuffMin tables
$50051168 constant JPEG_HUFFMIN_6  \ offset: 0x168 : JPEG HuffMin tables
$5005116c constant JPEG_HUFFMIN_7  \ offset: 0x16C : JPEG HuffMin tables
$50051170 constant JPEG_HUFFMIN_8  \ offset: 0x170 : JPEG HuffMin tables
$50051174 constant JPEG_HUFFMIN_9  \ offset: 0x174 : JPEG HuffMin tables
$50051178 constant JPEG_HUFFMIN_10  \ offset: 0x178 : JPEG HuffMin tables
$5005117c constant JPEG_HUFFMIN_11  \ offset: 0x17C : JPEG HuffMin tables
$50051180 constant JPEG_HUFFMIN_12  \ offset: 0x180 : JPEG HuffMin tables
$50051184 constant JPEG_HUFFMIN_13  \ offset: 0x184 : JPEG HuffMin tables
$50051188 constant JPEG_HUFFMIN_14  \ offset: 0x188 : JPEG HuffMin tables
$5005118c constant JPEG_HUFFMIN_15  \ offset: 0x18C : JPEG HuffMin tables
$50051190 constant JPEG_HUFFBASE0  \ offset: 0x190 : JPEG HuffSymb tables
$50051194 constant JPEG_HUFFBASE1  \ offset: 0x194 : JPEG HuffSymb tables
$50051198 constant JPEG_HUFFBASE2  \ offset: 0x198 : JPEG HuffSymb tables
$5005119c constant JPEG_HUFFBASE3  \ offset: 0x19C : JPEG HuffSymb tables
$500511a0 constant JPEG_HUFFBASE4  \ offset: 0x1A0 : JPEG HuffSymb tables
$500511a4 constant JPEG_HUFFBASE5  \ offset: 0x1A4 : JPEG HuffSymb tables
$500511a8 constant JPEG_HUFFBASE6  \ offset: 0x1A8 : JPEG HuffSymb tables
$500511ac constant JPEG_HUFFBASE7  \ offset: 0x1AC : JPEG HuffSymb tables
$500511b0 constant JPEG_HUFFBASE8  \ offset: 0x1B0 : JPEG HuffSymb tables
$500511b4 constant JPEG_HUFFBASE9  \ offset: 0x1B4 : JPEG HuffSymb tables
$500511b8 constant JPEG_HUFFBASE10  \ offset: 0x1B8 : JPEG HuffSymb tables
$500511bc constant JPEG_HUFFBASE11  \ offset: 0x1BC : JPEG HuffSymb tables
$500511c0 constant JPEG_HUFFBASE12  \ offset: 0x1C0 : JPEG HuffSymb tables
$500511c4 constant JPEG_HUFFBASE13  \ offset: 0x1C4 : JPEG HuffSymb tables
$500511c8 constant JPEG_HUFFBASE14  \ offset: 0x1C8 : JPEG HuffSymb tables
$500511cc constant JPEG_HUFFBASE15  \ offset: 0x1CC : JPEG HuffSymb tables
$500511d0 constant JPEG_HUFFBASE16  \ offset: 0x1D0 : JPEG HuffSymb tables
$500511d4 constant JPEG_HUFFBASE17  \ offset: 0x1D4 : JPEG HuffSymb tables
$500511d8 constant JPEG_HUFFBASE18  \ offset: 0x1D8 : JPEG HuffSymb tables
$500511dc constant JPEG_HUFFBASE19  \ offset: 0x1DC : JPEG HuffSymb tables
$500511e0 constant JPEG_HUFFBASE20  \ offset: 0x1E0 : JPEG HuffSymb tables
$500511e4 constant JPEG_HUFFBASE21  \ offset: 0x1E4 : JPEG HuffSymb tables
$500511e8 constant JPEG_HUFFBASE22  \ offset: 0x1E8 : JPEG HuffSymb tables
$500511ec constant JPEG_HUFFBASE23  \ offset: 0x1EC : JPEG HuffSymb tables
$500511f0 constant JPEG_HUFFBASE24  \ offset: 0x1F0 : JPEG HuffSymb tables
$500511f4 constant JPEG_HUFFBASE25  \ offset: 0x1F4 : JPEG HuffSymb tables
$500511f8 constant JPEG_HUFFBASE26  \ offset: 0x1F8 : JPEG HuffSymb tables
$500511fc constant JPEG_HUFFBASE27  \ offset: 0x1FC : JPEG HuffSymb tables
$50051200 constant JPEG_HUFFBASE28  \ offset: 0x200 : JPEG HuffSymb tables
$50051204 constant JPEG_HUFFBASE29  \ offset: 0x204 : JPEG HuffSymb tables
$50051208 constant JPEG_HUFFBASE30  \ offset: 0x208 : JPEG HuffSymb tables
$5005120c constant JPEG_HUFFBASE31  \ offset: 0x20C : JPEG HuffSymb tables
$50051210 constant JPEG_HUFFSYMB0  \ offset: 0x210 : JPEG HUFFSYMB tables
$50051214 constant JPEG_HUFFSYMB1  \ offset: 0x214 : JPEG HUFFSYMB tables
$50051218 constant JPEG_HUFFSYMB2  \ offset: 0x218 : JPEG HUFFSYMB tables
$5005121c constant JPEG_HUFFSYMB3  \ offset: 0x21C : JPEG HUFFSYMB tables
$50051220 constant JPEG_HUFFSYMB4  \ offset: 0x220 : JPEG HUFFSYMB tables
$50051224 constant JPEG_HUFFSYMB5  \ offset: 0x224 : JPEG HUFFSYMB tables
$50051228 constant JPEG_HUFFSYMB6  \ offset: 0x228 : JPEG HUFFSYMB tables
$5005122c constant JPEG_HUFFSYMB7  \ offset: 0x22C : JPEG HUFFSYMB tables
$50051230 constant JPEG_HUFFSYMB8  \ offset: 0x230 : JPEG HUFFSYMB tables
$50051234 constant JPEG_HUFFSYMB9  \ offset: 0x234 : JPEG HUFFSYMB tables
$50051238 constant JPEG_HUFFSYMB10  \ offset: 0x238 : JPEG HUFFSYMB tables
$5005123c constant JPEG_HUFFSYMB11  \ offset: 0x23C : JPEG HUFFSYMB tables
$50051240 constant JPEG_HUFFSYMB12  \ offset: 0x240 : JPEG HUFFSYMB tables
$50051244 constant JPEG_HUFFSYMB13  \ offset: 0x244 : JPEG HUFFSYMB tables
$50051248 constant JPEG_HUFFSYMB14  \ offset: 0x248 : JPEG HUFFSYMB tables
$5005124c constant JPEG_HUFFSYMB15  \ offset: 0x24C : JPEG HUFFSYMB tables
$50051250 constant JPEG_HUFFSYMB16  \ offset: 0x250 : JPEG HUFFSYMB tables
$50051254 constant JPEG_HUFFSYMB17  \ offset: 0x254 : JPEG HUFFSYMB tables
$50051258 constant JPEG_HUFFSYMB18  \ offset: 0x258 : JPEG HUFFSYMB tables
$5005125c constant JPEG_HUFFSYMB19  \ offset: 0x25C : JPEG HUFFSYMB tables
$50051260 constant JPEG_HUFFSYMB20  \ offset: 0x260 : JPEG HUFFSYMB tables
$50051264 constant JPEG_HUFFSYMB21  \ offset: 0x264 : JPEG HUFFSYMB tables
$50051268 constant JPEG_HUFFSYMB22  \ offset: 0x268 : JPEG HUFFSYMB tables
$5005126c constant JPEG_HUFFSYMB23  \ offset: 0x26C : JPEG HUFFSYMB tables
$50051270 constant JPEG_HUFFSYMB24  \ offset: 0x270 : JPEG HUFFSYMB tables
$50051274 constant JPEG_HUFFSYMB25  \ offset: 0x274 : JPEG HUFFSYMB tables
$50051278 constant JPEG_HUFFSYMB26  \ offset: 0x278 : JPEG HUFFSYMB tables
$5005127c constant JPEG_HUFFSYMB27  \ offset: 0x27C : JPEG HUFFSYMB tables
$50051280 constant JPEG_HUFFSYMB28  \ offset: 0x280 : JPEG HUFFSYMB tables
$50051284 constant JPEG_HUFFSYMB29  \ offset: 0x284 : JPEG HUFFSYMB tables
$50051288 constant JPEG_HUFFSYMB30  \ offset: 0x288 : JPEG HUFFSYMB tables
$5005128c constant JPEG_HUFFSYMB31  \ offset: 0x28C : JPEG HUFFSYMB tables
$50051290 constant JPEG_HUFFSYMB32  \ offset: 0x290 : JPEG HUFFSYMB tables
$50051294 constant JPEG_HUFFSYMB33  \ offset: 0x294 : JPEG HUFFSYMB tables
$50051298 constant JPEG_HUFFSYMB34  \ offset: 0x298 : JPEG HUFFSYMB tables
$5005129c constant JPEG_HUFFSYMB35  \ offset: 0x29C : JPEG HUFFSYMB tables
$500512a0 constant JPEG_HUFFSYMB36  \ offset: 0x2A0 : JPEG HUFFSYMB tables
$500512a4 constant JPEG_HUFFSYMB37  \ offset: 0x2A4 : JPEG HUFFSYMB tables
$500512a8 constant JPEG_HUFFSYMB38  \ offset: 0x2A8 : JPEG HUFFSYMB tables
$500512ac constant JPEG_HUFFSYMB39  \ offset: 0x2AC : JPEG HUFFSYMB tables
$500512b0 constant JPEG_HUFFSYMB40  \ offset: 0x2B0 : JPEG HUFFSYMB tables
$500512b4 constant JPEG_HUFFSYMB41  \ offset: 0x2B4 : JPEG HUFFSYMB tables
$500512b8 constant JPEG_HUFFSYMB42  \ offset: 0x2B8 : JPEG HUFFSYMB tables
$500512bc constant JPEG_HUFFSYMB43  \ offset: 0x2BC : JPEG HUFFSYMB tables
$500512c0 constant JPEG_HUFFSYMB44  \ offset: 0x2C0 : JPEG HUFFSYMB tables
$500512c4 constant JPEG_HUFFSYMB45  \ offset: 0x2C4 : JPEG HUFFSYMB tables
$500512c8 constant JPEG_HUFFSYMB46  \ offset: 0x2C8 : JPEG HUFFSYMB tables
$500512cc constant JPEG_HUFFSYMB47  \ offset: 0x2CC : JPEG HUFFSYMB tables
$500512d0 constant JPEG_HUFFSYMB48  \ offset: 0x2D0 : JPEG HUFFSYMB tables
$500512d4 constant JPEG_HUFFSYMB49  \ offset: 0x2D4 : JPEG HUFFSYMB tables
$500512d8 constant JPEG_HUFFSYMB50  \ offset: 0x2D8 : JPEG HUFFSYMB tables
$500512dc constant JPEG_HUFFSYMB51  \ offset: 0x2DC : JPEG HUFFSYMB tables
$500512e0 constant JPEG_HUFFSYMB52  \ offset: 0x2E0 : JPEG HUFFSYMB tables
$500512e4 constant JPEG_HUFFSYMB53  \ offset: 0x2E4 : JPEG HUFFSYMB tables
$500512e8 constant JPEG_HUFFSYMB54  \ offset: 0x2E8 : JPEG HUFFSYMB tables
$500512ec constant JPEG_HUFFSYMB55  \ offset: 0x2EC : JPEG HUFFSYMB tables
$500512f0 constant JPEG_HUFFSYMB56  \ offset: 0x2F0 : JPEG HUFFSYMB tables
$500512f4 constant JPEG_HUFFSYMB57  \ offset: 0x2F4 : JPEG HUFFSYMB tables
$500512f8 constant JPEG_HUFFSYMB58  \ offset: 0x2F8 : JPEG HUFFSYMB tables
$500512fc constant JPEG_HUFFSYMB59  \ offset: 0x2FC : JPEG HUFFSYMB tables
$50051300 constant JPEG_HUFFSYMB60  \ offset: 0x300 : JPEG HUFFSYMB tables
$50051304 constant JPEG_HUFFSYMB61  \ offset: 0x304 : JPEG HUFFSYMB tables
$50051308 constant JPEG_HUFFSYMB62  \ offset: 0x308 : JPEG HUFFSYMB tables
$5005130c constant JPEG_HUFFSYMB63  \ offset: 0x30C : JPEG HUFFSYMB tables
$50051310 constant JPEG_HUFFSYMB64  \ offset: 0x310 : JPEG HUFFSYMB tables
$50051314 constant JPEG_HUFFSYMB65  \ offset: 0x314 : JPEG HUFFSYMB tables
$50051318 constant JPEG_HUFFSYMB66  \ offset: 0x318 : JPEG HUFFSYMB tables
$5005131c constant JPEG_HUFFSYMB67  \ offset: 0x31C : JPEG HUFFSYMB tables
$50051320 constant JPEG_HUFFSYMB68  \ offset: 0x320 : JPEG HUFFSYMB tables
$50051324 constant JPEG_HUFFSYMB69  \ offset: 0x324 : JPEG HUFFSYMB tables
$50051328 constant JPEG_HUFFSYMB70  \ offset: 0x328 : JPEG HUFFSYMB tables
$5005132c constant JPEG_HUFFSYMB71  \ offset: 0x32C : JPEG HUFFSYMB tables
$50051330 constant JPEG_HUFFSYMB72  \ offset: 0x330 : JPEG HUFFSYMB tables
$50051334 constant JPEG_HUFFSYMB73  \ offset: 0x334 : JPEG HUFFSYMB tables
$50051338 constant JPEG_HUFFSYMB74  \ offset: 0x338 : JPEG HUFFSYMB tables
$5005133c constant JPEG_HUFFSYMB75  \ offset: 0x33C : JPEG HUFFSYMB tables
$50051340 constant JPEG_HUFFSYMB76  \ offset: 0x340 : JPEG HUFFSYMB tables
$50051344 constant JPEG_HUFFSYMB77  \ offset: 0x344 : JPEG HUFFSYMB tables
$50051348 constant JPEG_HUFFSYMB78  \ offset: 0x348 : JPEG HUFFSYMB tables
$5005134c constant JPEG_HUFFSYMB79  \ offset: 0x34C : JPEG HUFFSYMB tables
$50051350 constant JPEG_HUFFSYMB80  \ offset: 0x350 : JPEG HUFFSYMB tables
$50051354 constant JPEG_HUFFSYMB81  \ offset: 0x354 : JPEG HUFFSYMB tables
$50051358 constant JPEG_HUFFSYMB82  \ offset: 0x358 : JPEG HUFFSYMB tables
$5005135c constant JPEG_HUFFSYMB83  \ offset: 0x35C : JPEG HUFFSYMB tables
$50051360 constant JPEG_DHTMEM0   \ offset: 0x360 : JPEG DHTMem tables
$50051364 constant JPEG_DHTMEM2   \ offset: 0x364 : JPEG DHTMem tables
$50051368 constant JPEG_DHTMEM3   \ offset: 0x368 : JPEG DHTMem tables
$5005136c constant JPEG_DHTMEM4   \ offset: 0x36C : JPEG DHTMem tables
$50051370 constant JPEG_DHTMEM5   \ offset: 0x370 : JPEG DHTMem tables
$50051374 constant JPEG_DHTMEM6   \ offset: 0x374 : JPEG DHTMem tables
$50051378 constant JPEG_DHTMEM7   \ offset: 0x378 : JPEG DHTMem tables
$5005137c constant JPEG_DHTMEM8   \ offset: 0x37C : JPEG DHTMem tables
$50051380 constant JPEG_DHTMEM9   \ offset: 0x380 : JPEG DHTMem tables
$50051384 constant JPEG_DHTMEM10  \ offset: 0x384 : JPEG DHTMem tables
$50051388 constant JPEG_DHTMEM11  \ offset: 0x388 : JPEG DHTMem tables
$5005138c constant JPEG_DHTMEM12  \ offset: 0x38C : JPEG DHTMem tables
$50051390 constant JPEG_DHTMEM13  \ offset: 0x390 : JPEG DHTMem tables
$50051394 constant JPEG_DHTMEM14  \ offset: 0x394 : JPEG DHTMem tables
$50051398 constant JPEG_DHTMEM15  \ offset: 0x398 : JPEG DHTMem tables
$5005139c constant JPEG_DHTMEM16  \ offset: 0x39C : JPEG DHTMem tables
$500513a0 constant JPEG_DHTMEM17  \ offset: 0x3A0 : JPEG DHTMem tables
$500513a4 constant JPEG_DHTMEM18  \ offset: 0x3A4 : JPEG DHTMem tables
$500513a8 constant JPEG_DHTMEM19  \ offset: 0x3A8 : JPEG DHTMem tables
$500513ac constant JPEG_DHTMEM20  \ offset: 0x3AC : JPEG DHTMem tables
$500513b0 constant JPEG_DHTMEM21  \ offset: 0x3B0 : JPEG DHTMem tables
$500513b4 constant JPEG_DHTMEM22  \ offset: 0x3B4 : JPEG DHTMem tables
$500513b8 constant JPEG_DHTMEM23  \ offset: 0x3B8 : JPEG DHTMem tables
$500513bc constant JPEG_DHTMEM24  \ offset: 0x3BC : JPEG DHTMem tables
$500513c0 constant JPEG_DHTMEM25  \ offset: 0x3C0 : JPEG DHTMem tables
$500513c4 constant JPEG_DHTMEM26  \ offset: 0x3C4 : JPEG DHTMem tables
$500513c8 constant JPEG_DHTMEM27  \ offset: 0x3C8 : JPEG DHTMem tables
$500513cc constant JPEG_DHTMEM28  \ offset: 0x3CC : JPEG DHTMem tables
$500513d0 constant JPEG_DHTMEM29  \ offset: 0x3D0 : JPEG DHTMem tables
$500513d4 constant JPEG_DHTMEM30  \ offset: 0x3D4 : JPEG DHTMem tables
$500513d8 constant JPEG_DHTMEM31  \ offset: 0x3D8 : JPEG DHTMem tables
$500513dc constant JPEG_DHTMEM32  \ offset: 0x3DC : JPEG DHTMem tables
$500513e0 constant JPEG_DHTMEM33  \ offset: 0x3E0 : JPEG DHTMem tables
$500513e4 constant JPEG_DHTMEM34  \ offset: 0x3E4 : JPEG DHTMem tables
$500513e8 constant JPEG_DHTMEM35  \ offset: 0x3E8 : JPEG DHTMem tables
$500513ec constant JPEG_DHTMEM36  \ offset: 0x3EC : JPEG DHTMem tables
$500513f0 constant JPEG_DHTMEM37  \ offset: 0x3F0 : JPEG DHTMem tables
$500513f4 constant JPEG_DHTMEM38  \ offset: 0x3F4 : JPEG DHTMem tables
$500513f8 constant JPEG_DHTMEM39  \ offset: 0x3F8 : JPEG DHTMem tables
$500513fc constant JPEG_DHTMEM40  \ offset: 0x3FC : JPEG DHTMem tables
$50051400 constant JPEG_DHTMEM41  \ offset: 0x400 : JPEG DHTMem tables
$50051404 constant JPEG_DHTMEM42  \ offset: 0x404 : JPEG DHTMem tables
$50051408 constant JPEG_DHTMEM43  \ offset: 0x408 : JPEG DHTMem tables
$5005140c constant JPEG_DHTMEM44  \ offset: 0x40C : JPEG DHTMem tables
$50051410 constant JPEG_DHTMEM45  \ offset: 0x410 : JPEG DHTMem tables
$50051414 constant JPEG_DHTMEM46  \ offset: 0x414 : JPEG DHTMem tables
$50051418 constant JPEG_DHTMEM47  \ offset: 0x418 : JPEG DHTMem tables
$5005141c constant JPEG_DHTMEM48  \ offset: 0x41C : JPEG DHTMem tables
$50051420 constant JPEG_DHTMEM49  \ offset: 0x420 : JPEG DHTMem tables
$50051424 constant JPEG_DHTMEM50  \ offset: 0x424 : JPEG DHTMem tables
$50051428 constant JPEG_DHTMEM51  \ offset: 0x428 : JPEG DHTMem tables
$5005142c constant JPEG_DHTMEM52  \ offset: 0x42C : JPEG DHTMem tables
$50051430 constant JPEG_DHTMEM53  \ offset: 0x430 : JPEG DHTMem tables
$50051434 constant JPEG_DHTMEM54  \ offset: 0x434 : JPEG DHTMem tables
$50051438 constant JPEG_DHTMEM55  \ offset: 0x438 : JPEG DHTMem tables
$5005143c constant JPEG_DHTMEM56  \ offset: 0x43C : JPEG DHTMem tables
$50051440 constant JPEG_DHTMEM57  \ offset: 0x440 : JPEG DHTMem tables
$50051444 constant JPEG_DHTMEM58  \ offset: 0x444 : JPEG DHTMem tables
$50051448 constant JPEG_DHTMEM59  \ offset: 0x448 : JPEG DHTMem tables
$5005144c constant JPEG_DHTMEM60  \ offset: 0x44C : JPEG DHTMem tables
$50051450 constant JPEG_DHTMEM61  \ offset: 0x450 : JPEG DHTMem tables
$50051454 constant JPEG_DHTMEM62  \ offset: 0x454 : JPEG DHTMem tables
$50051458 constant JPEG_DHTMEM63  \ offset: 0x458 : JPEG DHTMem tables
$5005145c constant JPEG_DHTMEM64  \ offset: 0x45C : JPEG DHTMem tables
$50051460 constant JPEG_DHTMEM65  \ offset: 0x460 : JPEG DHTMem tables
$50051464 constant JPEG_DHTMEM66  \ offset: 0x464 : JPEG DHTMem tables
$50051468 constant JPEG_DHTMEM67  \ offset: 0x468 : JPEG DHTMem tables
$5005146c constant JPEG_DHTMEM68  \ offset: 0x46C : JPEG DHTMem tables
$50051470 constant JPEG_DHTMEM69  \ offset: 0x470 : JPEG DHTMem tables
$50051474 constant JPEG_DHTMEM70  \ offset: 0x474 : JPEG DHTMem tables
$50051478 constant JPEG_DHTMEM71  \ offset: 0x478 : JPEG DHTMem tables
$5005147c constant JPEG_DHTMEM72  \ offset: 0x47C : JPEG DHTMem tables
$50051480 constant JPEG_DHTMEM73  \ offset: 0x480 : JPEG DHTMem tables
$50051484 constant JPEG_DHTMEM74  \ offset: 0x484 : JPEG DHTMem tables
$50051488 constant JPEG_DHTMEM75  \ offset: 0x488 : JPEG DHTMem tables
$5005148c constant JPEG_DHTMEM76  \ offset: 0x48C : JPEG DHTMem tables
$50051490 constant JPEG_DHTMEM77  \ offset: 0x490 : JPEG DHTMem tables
$50051494 constant JPEG_DHTMEM78  \ offset: 0x494 : JPEG DHTMem tables
$50051498 constant JPEG_DHTMEM79  \ offset: 0x498 : JPEG DHTMem tables
$5005149c constant JPEG_DHTMEM80  \ offset: 0x49C : JPEG DHTMem tables
$500514a0 constant JPEG_DHTMEM81  \ offset: 0x4A0 : JPEG DHTMem tables
$500514a4 constant JPEG_DHTMEM82  \ offset: 0x4A4 : JPEG DHTMem tables
$500514a8 constant JPEG_DHTMEM83  \ offset: 0x4A8 : JPEG DHTMem tables
$500514ac constant JPEG_DHTMEM84  \ offset: 0x4AC : JPEG DHTMem tables
$500514b0 constant JPEG_DHTMEM85  \ offset: 0x4B0 : JPEG DHTMem tables
$500514b4 constant JPEG_DHTMEM86  \ offset: 0x4B4 : JPEG DHTMem tables
$500514b8 constant JPEG_DHTMEM87  \ offset: 0x4B8 : JPEG DHTMem tables
$500514bc constant JPEG_DHTMEM88  \ offset: 0x4BC : JPEG DHTMem tables
$500514c0 constant JPEG_DHTMEM89  \ offset: 0x4C0 : JPEG DHTMem tables
$500514c4 constant JPEG_DHTMEM90  \ offset: 0x4C4 : JPEG DHTMem tables
$500514c8 constant JPEG_DHTMEM91  \ offset: 0x4C8 : JPEG DHTMem tables
$500514cc constant JPEG_DHTMEM92  \ offset: 0x4CC : JPEG DHTMem tables
$500514d0 constant JPEG_DHTMEM93  \ offset: 0x4D0 : JPEG DHTMem tables
$500514d4 constant JPEG_DHTMEM94  \ offset: 0x4D4 : JPEG DHTMem tables
$500514d8 constant JPEG_DHTMEM95  \ offset: 0x4D8 : JPEG DHTMem tables
$500514dc constant JPEG_DHTMEM96  \ offset: 0x4DC : JPEG DHTMem tables
$500514e0 constant JPEG_DHTMEM97  \ offset: 0x4E0 : JPEG DHTMem tables
$500514e4 constant JPEG_DHTMEM98  \ offset: 0x4E4 : JPEG DHTMem tables
$500514e8 constant JPEG_DHTMEM99  \ offset: 0x4E8 : JPEG DHTMem tables
$500514ec constant JPEG_DHTMEM100  \ offset: 0x4EC : JPEG DHTMem tables
$500514f0 constant JPEG_DHTMEM101  \ offset: 0x4F0 : JPEG DHTMem tables
$500514f4 constant JPEG_DHTMEM102  \ offset: 0x4F4 : JPEG DHTMem tables
$500514f8 constant JPEG_DHTMEM103  \ offset: 0x4F8 : JPEG DHTMem tables
$50051500 constant JPEG_HUFFENC_AC0_0  \ offset: 0x500 : JPEG encoder, AC Huffman table 0
$50051504 constant JPEG_HUFFENC_AC0_1  \ offset: 0x504 : JPEG encoder, AC Huffman table 0
$50051508 constant JPEG_HUFFENC_AC0_2  \ offset: 0x508 : JPEG encoder, AC Huffman table 0
$5005150c constant JPEG_HUFFENC_AC0_3  \ offset: 0x50C : JPEG encoder, AC Huffman table 0
$50051510 constant JPEG_HUFFENC_AC0_4  \ offset: 0x510 : JPEG encoder, AC Huffman table 0
$50051514 constant JPEG_HUFFENC_AC0_5  \ offset: 0x514 : JPEG encoder, AC Huffman table 0
$50051518 constant JPEG_HUFFENC_AC0_6  \ offset: 0x518 : JPEG encoder, AC Huffman table 0
$5005151c constant JPEG_HUFFENC_AC0_7  \ offset: 0x51C : JPEG encoder, AC Huffman table 0
$50051520 constant JPEG_HUFFENC_AC0_8  \ offset: 0x520 : JPEG encoder, AC Huffman table 0
$50051524 constant JPEG_HUFFENC_AC0_9  \ offset: 0x524 : JPEG encoder, AC Huffman table 0
$50051528 constant JPEG_HUFFENC_AC0_10  \ offset: 0x528 : JPEG encoder, AC Huffman table 0
$5005152c constant JPEG_HUFFENC_AC0_11  \ offset: 0x52C : JPEG encoder, AC Huffman table 0
$50051530 constant JPEG_HUFFENC_AC0_12  \ offset: 0x530 : JPEG encoder, AC Huffman table 0
$50051534 constant JPEG_HUFFENC_AC0_13  \ offset: 0x534 : JPEG encoder, AC Huffman table 0
$50051538 constant JPEG_HUFFENC_AC0_14  \ offset: 0x538 : JPEG encoder, AC Huffman table 0
$5005153c constant JPEG_HUFFENC_AC0_15  \ offset: 0x53C : JPEG encoder, AC Huffman table 0
$50051540 constant JPEG_HUFFENC_AC0_16  \ offset: 0x540 : JPEG encoder, AC Huffman table 0
$50051544 constant JPEG_HUFFENC_AC0_17  \ offset: 0x544 : JPEG encoder, AC Huffman table 0
$50051548 constant JPEG_HUFFENC_AC0_18  \ offset: 0x548 : JPEG encoder, AC Huffman table 0
$5005154c constant JPEG_HUFFENC_AC0_19  \ offset: 0x54C : JPEG encoder, AC Huffman table 0
$50051550 constant JPEG_HUFFENC_AC0_20  \ offset: 0x550 : JPEG encoder, AC Huffman table 0
$50051554 constant JPEG_HUFFENC_AC0_21  \ offset: 0x554 : JPEG encoder, AC Huffman table 0
$50051558 constant JPEG_HUFFENC_AC0_22  \ offset: 0x558 : JPEG encoder, AC Huffman table 0
$5005155c constant JPEG_HUFFENC_AC0_23  \ offset: 0x55C : JPEG encoder, AC Huffman table 0
$50051560 constant JPEG_HUFFENC_AC0_24  \ offset: 0x560 : JPEG encoder, AC Huffman table 0
$50051564 constant JPEG_HUFFENC_AC0_25  \ offset: 0x564 : JPEG encoder, AC Huffman table 0
$50051568 constant JPEG_HUFFENC_AC0_26  \ offset: 0x568 : JPEG encoder, AC Huffman table 0
$5005156c constant JPEG_HUFFENC_AC0_27  \ offset: 0x56C : JPEG encoder, AC Huffman table 0
$50051570 constant JPEG_HUFFENC_AC0_28  \ offset: 0x570 : JPEG encoder, AC Huffman table 0
$50051574 constant JPEG_HUFFENC_AC0_29  \ offset: 0x574 : JPEG encoder, AC Huffman table 0
$50051578 constant JPEG_HUFFENC_AC0_30  \ offset: 0x578 : JPEG encoder, AC Huffman table 0
$5005157c constant JPEG_HUFFENC_AC0_31  \ offset: 0x57C : JPEG encoder, AC Huffman table 0
$50051580 constant JPEG_HUFFENC_AC0_32  \ offset: 0x580 : JPEG encoder, AC Huffman table 0
$50051584 constant JPEG_HUFFENC_AC0_33  \ offset: 0x584 : JPEG encoder, AC Huffman table 0
$50051588 constant JPEG_HUFFENC_AC0_34  \ offset: 0x588 : JPEG encoder, AC Huffman table 0
$5005158c constant JPEG_HUFFENC_AC0_35  \ offset: 0x58C : JPEG encoder, AC Huffman table 0
$50051590 constant JPEG_HUFFENC_AC0_36  \ offset: 0x590 : JPEG encoder, AC Huffman table 0
$50051594 constant JPEG_HUFFENC_AC0_37  \ offset: 0x594 : JPEG encoder, AC Huffman table 0
$50051598 constant JPEG_HUFFENC_AC0_38  \ offset: 0x598 : JPEG encoder, AC Huffman table 0
$5005159c constant JPEG_HUFFENC_AC0_39  \ offset: 0x59C : JPEG encoder, AC Huffman table 0
$500515a0 constant JPEG_HUFFENC_AC0_40  \ offset: 0x5A0 : JPEG encoder, AC Huffman table 0
$500515a4 constant JPEG_HUFFENC_AC0_41  \ offset: 0x5A4 : JPEG encoder, AC Huffman table 0
$500515a8 constant JPEG_HUFFENC_AC0_42  \ offset: 0x5A8 : JPEG encoder, AC Huffman table 0
$500515ac constant JPEG_HUFFENC_AC0_43  \ offset: 0x5AC : JPEG encoder, AC Huffman table 0
$500515b0 constant JPEG_HUFFENC_AC0_44  \ offset: 0x5B0 : JPEG encoder, AC Huffman table 0
$500515b4 constant JPEG_HUFFENC_AC0_45  \ offset: 0x5B4 : JPEG encoder, AC Huffman table 0
$500515b8 constant JPEG_HUFFENC_AC0_46  \ offset: 0x5B8 : JPEG encoder, AC Huffman table 0
$500515bc constant JPEG_HUFFENC_AC0_47  \ offset: 0x5BC : JPEG encoder, AC Huffman table 0
$500515c0 constant JPEG_HUFFENC_AC0_48  \ offset: 0x5C0 : JPEG encoder, AC Huffman table 0
$500515c4 constant JPEG_HUFFENC_AC0_49  \ offset: 0x5C4 : JPEG encoder, AC Huffman table 0
$500515c8 constant JPEG_HUFFENC_AC0_50  \ offset: 0x5C8 : JPEG encoder, AC Huffman table 0
$500515cc constant JPEG_HUFFENC_AC0_51  \ offset: 0x5CC : JPEG encoder, AC Huffman table 0
$500515d0 constant JPEG_HUFFENC_AC0_52  \ offset: 0x5D0 : JPEG encoder, AC Huffman table 0
$500515d4 constant JPEG_HUFFENC_AC0_53  \ offset: 0x5D4 : JPEG encoder, AC Huffman table 0
$500515d8 constant JPEG_HUFFENC_AC0_54  \ offset: 0x5D8 : JPEG encoder, AC Huffman table 0
$500515dc constant JPEG_HUFFENC_AC0_55  \ offset: 0x5DC : JPEG encoder, AC Huffman table 0
$500515e0 constant JPEG_HUFFENC_AC0_56  \ offset: 0x5E0 : JPEG encoder, AC Huffman table 0
$500515e4 constant JPEG_HUFFENC_AC0_57  \ offset: 0x5E4 : JPEG encoder, AC Huffman table 0
$500515e8 constant JPEG_HUFFENC_AC0_58  \ offset: 0x5E8 : JPEG encoder, AC Huffman table 0
$500515ec constant JPEG_HUFFENC_AC0_59  \ offset: 0x5EC : JPEG encoder, AC Huffman table 0
$500515f0 constant JPEG_HUFFENC_AC0_60  \ offset: 0x5F0 : JPEG encoder, AC Huffman table 0
$500515f4 constant JPEG_HUFFENC_AC0_61  \ offset: 0x5F4 : JPEG encoder, AC Huffman table 0
$500515f8 constant JPEG_HUFFENC_AC0_62  \ offset: 0x5F8 : JPEG encoder, AC Huffman table 0
$500515fc constant JPEG_HUFFENC_AC0_63  \ offset: 0x5FC : JPEG encoder, AC Huffman table 0
$50051600 constant JPEG_HUFFENC_AC0_64  \ offset: 0x600 : JPEG encoder, AC Huffman table 0
$50051604 constant JPEG_HUFFENC_AC0_65  \ offset: 0x604 : JPEG encoder, AC Huffman table 0
$50051608 constant JPEG_HUFFENC_AC0_66  \ offset: 0x608 : JPEG encoder, AC Huffman table 0
$5005160c constant JPEG_HUFFENC_AC0_67  \ offset: 0x60C : JPEG encoder, AC Huffman table 0
$50051610 constant JPEG_HUFFENC_AC0_68  \ offset: 0x610 : JPEG encoder, AC Huffman table 0
$50051614 constant JPEG_HUFFENC_AC0_69  \ offset: 0x614 : JPEG encoder, AC Huffman table 0
$50051618 constant JPEG_HUFFENC_AC0_70  \ offset: 0x618 : JPEG encoder, AC Huffman table 0
$5005161c constant JPEG_HUFFENC_AC0_71  \ offset: 0x61C : JPEG encoder, AC Huffman table 0
$50051620 constant JPEG_HUFFENC_AC0_72  \ offset: 0x620 : JPEG encoder, AC Huffman table 0
$50051624 constant JPEG_HUFFENC_AC0_73  \ offset: 0x624 : JPEG encoder, AC Huffman table 0
$50051628 constant JPEG_HUFFENC_AC0_74  \ offset: 0x628 : JPEG encoder, AC Huffman table 0
$5005162c constant JPEG_HUFFENC_AC0_75  \ offset: 0x62C : JPEG encoder, AC Huffman table 0
$50051630 constant JPEG_HUFFENC_AC0_76  \ offset: 0x630 : JPEG encoder, AC Huffman table 0
$50051634 constant JPEG_HUFFENC_AC0_77  \ offset: 0x634 : JPEG encoder, AC Huffman table 0
$50051638 constant JPEG_HUFFENC_AC0_78  \ offset: 0x638 : JPEG encoder, AC Huffman table 0
$5005163c constant JPEG_HUFFENC_AC0_79  \ offset: 0x63C : JPEG encoder, AC Huffman table 0
$50051640 constant JPEG_HUFFENC_AC0_80  \ offset: 0x640 : JPEG encoder, AC Huffman table 0
$50051644 constant JPEG_HUFFENC_AC0_81  \ offset: 0x644 : JPEG encoder, AC Huffman table 0
$50051648 constant JPEG_HUFFENC_AC0_82  \ offset: 0x648 : JPEG encoder, AC Huffman table 0
$5005164c constant JPEG_HUFFENC_AC0_83  \ offset: 0x64C : JPEG encoder, AC Huffman table 0
$50051650 constant JPEG_HUFFENC_AC0_84  \ offset: 0x650 : JPEG encoder, AC Huffman table 0
$50051654 constant JPEG_HUFFENC_AC0_85  \ offset: 0x654 : JPEG encoder, AC Huffman table 0
$50051658 constant JPEG_HUFFENC_AC0_86  \ offset: 0x658 : JPEG encoder, AC Huffman table 0
$5005165c constant JPEG_HUFFENC_AC0_87  \ offset: 0x65C : JPEG encoder, AC Huffman table 0
$50051660 constant JPEG_HUFFENC_AC1_0  \ offset: 0x660 : JPEG encoder, AC Huffman table 1
$50051664 constant JPEG_HUFFENC_AC1_1  \ offset: 0x664 : JPEG encoder, AC Huffman table 1
$50051668 constant JPEG_HUFFENC_AC1_2  \ offset: 0x668 : JPEG encoder, AC Huffman table 1
$5005166c constant JPEG_HUFFENC_AC1_3  \ offset: 0x66C : JPEG encoder, AC Huffman table 1
$50051670 constant JPEG_HUFFENC_AC1_4  \ offset: 0x670 : JPEG encoder, AC Huffman table 1
$50051674 constant JPEG_HUFFENC_AC1_5  \ offset: 0x674 : JPEG encoder, AC Huffman table 1
$50051678 constant JPEG_HUFFENC_AC1_6  \ offset: 0x678 : JPEG encoder, AC Huffman table 1
$5005167c constant JPEG_HUFFENC_AC1_7  \ offset: 0x67C : JPEG encoder, AC Huffman table 1
$50051680 constant JPEG_HUFFENC_AC1_8  \ offset: 0x680 : JPEG encoder, AC Huffman table 1
$50051684 constant JPEG_HUFFENC_AC1_9  \ offset: 0x684 : JPEG encoder, AC Huffman table 1
$50051688 constant JPEG_HUFFENC_AC1_10  \ offset: 0x688 : JPEG encoder, AC Huffman table 1
$5005168c constant JPEG_HUFFENC_AC1_11  \ offset: 0x68C : JPEG encoder, AC Huffman table 1
$50051690 constant JPEG_HUFFENC_AC1_12  \ offset: 0x690 : JPEG encoder, AC Huffman table 1
$50051694 constant JPEG_HUFFENC_AC1_13  \ offset: 0x694 : JPEG encoder, AC Huffman table 1
$50051698 constant JPEG_HUFFENC_AC1_14  \ offset: 0x698 : JPEG encoder, AC Huffman table 1
$5005169c constant JPEG_HUFFENC_AC1_15  \ offset: 0x69C : JPEG encoder, AC Huffman table 1
$500516a0 constant JPEG_HUFFENC_AC1_16  \ offset: 0x6A0 : JPEG encoder, AC Huffman table 1
$500516a4 constant JPEG_HUFFENC_AC1_17  \ offset: 0x6A4 : JPEG encoder, AC Huffman table 1
$500516a8 constant JPEG_HUFFENC_AC1_18  \ offset: 0x6A8 : JPEG encoder, AC Huffman table 1
$500516ac constant JPEG_HUFFENC_AC1_19  \ offset: 0x6AC : JPEG encoder, AC Huffman table 1
$500516b0 constant JPEG_HUFFENC_AC1_20  \ offset: 0x6B0 : JPEG encoder, AC Huffman table 1
$500516b4 constant JPEG_HUFFENC_AC1_21  \ offset: 0x6B4 : JPEG encoder, AC Huffman table 1
$500516b8 constant JPEG_HUFFENC_AC1_22  \ offset: 0x6B8 : JPEG encoder, AC Huffman table 1
$500516bc constant JPEG_HUFFENC_AC1_23  \ offset: 0x6BC : JPEG encoder, AC Huffman table 1
$500516c0 constant JPEG_HUFFENC_AC1_24  \ offset: 0x6C0 : JPEG encoder, AC Huffman table 1
$500516c4 constant JPEG_HUFFENC_AC1_25  \ offset: 0x6C4 : JPEG encoder, AC Huffman table 1
$500516c8 constant JPEG_HUFFENC_AC1_26  \ offset: 0x6C8 : JPEG encoder, AC Huffman table 1
$500516cc constant JPEG_HUFFENC_AC1_27  \ offset: 0x6CC : JPEG encoder, AC Huffman table 1
$500516d0 constant JPEG_HUFFENC_AC1_28  \ offset: 0x6D0 : JPEG encoder, AC Huffman table 1
$500516d4 constant JPEG_HUFFENC_AC1_29  \ offset: 0x6D4 : JPEG encoder, AC Huffman table 1
$500516d8 constant JPEG_HUFFENC_AC1_30  \ offset: 0x6D8 : JPEG encoder, AC Huffman table 1
$500516dc constant JPEG_HUFFENC_AC1_31  \ offset: 0x6DC : JPEG encoder, AC Huffman table 1
$500516e0 constant JPEG_HUFFENC_AC1_32  \ offset: 0x6E0 : JPEG encoder, AC Huffman table 1
$500516e4 constant JPEG_HUFFENC_AC1_33  \ offset: 0x6E4 : JPEG encoder, AC Huffman table 1
$500516e8 constant JPEG_HUFFENC_AC1_34  \ offset: 0x6E8 : JPEG encoder, AC Huffman table 1
$500516ec constant JPEG_HUFFENC_AC1_35  \ offset: 0x6EC : JPEG encoder, AC Huffman table 1
$500516f0 constant JPEG_HUFFENC_AC1_36  \ offset: 0x6F0 : JPEG encoder, AC Huffman table 1
$500516f4 constant JPEG_HUFFENC_AC1_37  \ offset: 0x6F4 : JPEG encoder, AC Huffman table 1
$500516f8 constant JPEG_HUFFENC_AC1_38  \ offset: 0x6F8 : JPEG encoder, AC Huffman table 1
$500516fc constant JPEG_HUFFENC_AC1_39  \ offset: 0x6FC : JPEG encoder, AC Huffman table 1
$50051700 constant JPEG_HUFFENC_AC1_40  \ offset: 0x700 : JPEG encoder, AC Huffman table 1
$50051704 constant JPEG_HUFFENC_AC1_41  \ offset: 0x704 : JPEG encoder, AC Huffman table 1
$50051708 constant JPEG_HUFFENC_AC1_42  \ offset: 0x708 : JPEG encoder, AC Huffman table 1
$5005170c constant JPEG_HUFFENC_AC1_43  \ offset: 0x70C : JPEG encoder, AC Huffman table 1
$50051710 constant JPEG_HUFFENC_AC1_44  \ offset: 0x710 : JPEG encoder, AC Huffman table 1
$50051714 constant JPEG_HUFFENC_AC1_45  \ offset: 0x714 : JPEG encoder, AC Huffman table 1
$50051718 constant JPEG_HUFFENC_AC1_46  \ offset: 0x718 : JPEG encoder, AC Huffman table 1
$5005171c constant JPEG_HUFFENC_AC1_47  \ offset: 0x71C : JPEG encoder, AC Huffman table 1
$50051720 constant JPEG_HUFFENC_AC1_48  \ offset: 0x720 : JPEG encoder, AC Huffman table 1
$50051724 constant JPEG_HUFFENC_AC1_49  \ offset: 0x724 : JPEG encoder, AC Huffman table 1
$50051728 constant JPEG_HUFFENC_AC1_50  \ offset: 0x728 : JPEG encoder, AC Huffman table 1
$5005172c constant JPEG_HUFFENC_AC1_51  \ offset: 0x72C : JPEG encoder, AC Huffman table 1
$50051730 constant JPEG_HUFFENC_AC1_52  \ offset: 0x730 : JPEG encoder, AC Huffman table 1
$50051734 constant JPEG_HUFFENC_AC1_53  \ offset: 0x734 : JPEG encoder, AC Huffman table 1
$50051738 constant JPEG_HUFFENC_AC1_54  \ offset: 0x738 : JPEG encoder, AC Huffman table 1
$5005173c constant JPEG_HUFFENC_AC1_55  \ offset: 0x73C : JPEG encoder, AC Huffman table 1
$50051740 constant JPEG_HUFFENC_AC1_56  \ offset: 0x740 : JPEG encoder, AC Huffman table 1
$50051744 constant JPEG_HUFFENC_AC1_57  \ offset: 0x744 : JPEG encoder, AC Huffman table 1
$50051748 constant JPEG_HUFFENC_AC1_58  \ offset: 0x748 : JPEG encoder, AC Huffman table 1
$5005174c constant JPEG_HUFFENC_AC1_59  \ offset: 0x74C : JPEG encoder, AC Huffman table 1
$50051750 constant JPEG_HUFFENC_AC1_60  \ offset: 0x750 : JPEG encoder, AC Huffman table 1
$50051754 constant JPEG_HUFFENC_AC1_61  \ offset: 0x754 : JPEG encoder, AC Huffman table 1
$50051758 constant JPEG_HUFFENC_AC1_62  \ offset: 0x758 : JPEG encoder, AC Huffman table 1
$5005175c constant JPEG_HUFFENC_AC1_63  \ offset: 0x75C : JPEG encoder, AC Huffman table 1
$50051760 constant JPEG_HUFFENC_AC1_64  \ offset: 0x760 : JPEG encoder, AC Huffman table 1
$50051764 constant JPEG_HUFFENC_AC1_65  \ offset: 0x764 : JPEG encoder, AC Huffman table 1
$50051768 constant JPEG_HUFFENC_AC1_66  \ offset: 0x768 : JPEG encoder, AC Huffman table 1
$5005176c constant JPEG_HUFFENC_AC1_67  \ offset: 0x76C : JPEG encoder, AC Huffman table 1
$50051770 constant JPEG_HUFFENC_AC1_68  \ offset: 0x770 : JPEG encoder, AC Huffman table 1
$50051774 constant JPEG_HUFFENC_AC1_69  \ offset: 0x774 : JPEG encoder, AC Huffman table 1
$50051778 constant JPEG_HUFFENC_AC1_70  \ offset: 0x778 : JPEG encoder, AC Huffman table 1
$5005177c constant JPEG_HUFFENC_AC1_71  \ offset: 0x77C : JPEG encoder, AC Huffman table 1
$50051780 constant JPEG_HUFFENC_AC1_72  \ offset: 0x780 : JPEG encoder, AC Huffman table 1
$50051784 constant JPEG_HUFFENC_AC1_73  \ offset: 0x784 : JPEG encoder, AC Huffman table 1
$50051788 constant JPEG_HUFFENC_AC1_74  \ offset: 0x788 : JPEG encoder, AC Huffman table 1
$5005178c constant JPEG_HUFFENC_AC1_75  \ offset: 0x78C : JPEG encoder, AC Huffman table 1
$50051790 constant JPEG_HUFFENC_AC1_76  \ offset: 0x790 : JPEG encoder, AC Huffman table 1
$50051794 constant JPEG_HUFFENC_AC1_77  \ offset: 0x794 : JPEG encoder, AC Huffman table 1
$50051798 constant JPEG_HUFFENC_AC1_78  \ offset: 0x798 : JPEG encoder, AC Huffman table 1
$5005179c constant JPEG_HUFFENC_AC1_79  \ offset: 0x79C : JPEG encoder, AC Huffman table 1
$500517a0 constant JPEG_HUFFENC_AC1_80  \ offset: 0x7A0 : JPEG encoder, AC Huffman table 1
$500517a4 constant JPEG_HUFFENC_AC1_81  \ offset: 0x7A4 : JPEG encoder, AC Huffman table 1
$500517a8 constant JPEG_HUFFENC_AC1_82  \ offset: 0x7A8 : JPEG encoder, AC Huffman table 1
$500517ac constant JPEG_HUFFENC_AC1_83  \ offset: 0x7AC : JPEG encoder, AC Huffman table 1
$500517b0 constant JPEG_HUFFENC_AC1_84  \ offset: 0x7B0 : JPEG encoder, AC Huffman table 1
$500517b4 constant JPEG_HUFFENC_AC1_85  \ offset: 0x7B4 : JPEG encoder, AC Huffman table 1
$500517b8 constant JPEG_HUFFENC_AC1_86  \ offset: 0x7B8 : JPEG encoder, AC Huffman table 1
$500517bc constant JPEG_HUFFENC_AC1_87  \ offset: 0x7BC : JPEG encoder, AC Huffman table 1
$500517c0 constant JPEG_HUFFENC_DC0_0  \ offset: 0x7C0 : JPEG encoder, DC Huffman table 0
$500517c4 constant JPEG_HUFFENC_DC0_1  \ offset: 0x7C4 : JPEG encoder, DC Huffman table 0
$500517c8 constant JPEG_HUFFENC_DC0_2  \ offset: 0x7C8 : JPEG encoder, DC Huffman table 0
$500517cc constant JPEG_HUFFENC_DC0_3  \ offset: 0x7CC : JPEG encoder, DC Huffman table 0
$500517d0 constant JPEG_HUFFENC_DC0_4  \ offset: 0x7D0 : JPEG encoder, DC Huffman table 0
$500517d4 constant JPEG_HUFFENC_DC0_5  \ offset: 0x7D4 : JPEG encoder, DC Huffman table 0
$500517d8 constant JPEG_HUFFENC_DC0_6  \ offset: 0x7D8 : JPEG encoder, DC Huffman table 0
$500517dc constant JPEG_HUFFENC_DC0_7  \ offset: 0x7DC : JPEG encoder, DC Huffman table 0
$500517e0 constant JPEG_HUFFENC_DC1_0  \ offset: 0x7E0 : JPEG encoder, DC Huffman table 1
$500517e4 constant JPEG_HUFFENC_DC1_1  \ offset: 0x7E4 : JPEG encoder, DC Huffman table 1
$500517e8 constant JPEG_HUFFENC_DC1_2  \ offset: 0x7E8 : JPEG encoder, DC Huffman table 1
$500517ec constant JPEG_HUFFENC_DC1_3  \ offset: 0x7EC : JPEG encoder, DC Huffman table 1
$500517f0 constant JPEG_HUFFENC_DC1_4  \ offset: 0x7F0 : JPEG encoder, DC Huffman table 1
$500517f4 constant JPEG_HUFFENC_DC1_5  \ offset: 0x7F4 : JPEG encoder, DC Huffman table 1
$500517f8 constant JPEG_HUFFENC_DC1_6  \ offset: 0x7F8 : JPEG encoder, DC Huffman table 1
$500517fc constant JPEG_HUFFENC_DC1_7  \ offset: 0x7FC : JPEG encoder, DC Huffman table 1

