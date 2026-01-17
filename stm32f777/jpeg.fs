\
\ @file jpeg.fs
\ @brief JPEG codec
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] JPEG_DEF

  [ifdef] JPEG_JPEG_CONFR0_DEF
    \
    \ @brief JPEG codec configuration register 0
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_START                     \ [0x00] Start
  [then]


  [ifdef] JPEG_JPEG_CONFR1_DEF
    \
    \ @brief JPEG codec configuration register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_NF                        \ [0x00 : 2] Number of color components
    $03 constant JPEG_DE                        \ [0x03] Decoding Enable
    $04 constant JPEG_COLORSPACE                \ [0x04 : 2] Color Space
    $06 constant JPEG_NS                        \ [0x06 : 2] Number of components for Scan
    $08 constant JPEG_HDR                       \ [0x08] Header Processing
    $10 constant JPEG_YSIZE                     \ [0x10 : 16] Y Size
  [then]


  [ifdef] JPEG_JPEG_CONFR2_DEF
    \
    \ @brief JPEG codec configuration register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_NMCU                      \ [0x00 : 26] Number of MCU
  [then]


  [ifdef] JPEG_JPEG_CONFR3_DEF
    \
    \ @brief JPEG codec configuration register 3
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $10 constant JPEG_XSIZE                     \ [0x10 : 16] X size
  [then]


  [ifdef] JPEG_JPEG_CONFR4_DEF
    \
    \ @brief JPEG codec configuration register 4
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HD                        \ [0x00] Huffman DC
    $01 constant JPEG_HA                        \ [0x01] Huffman AC
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization Table
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of Block
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical Sampling Factor
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal Sampling Factor
  [then]


  [ifdef] JPEG_JPEG_CONFR5_DEF
    \
    \ @brief JPEG codec configuration register 5
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HD                        \ [0x00] Huffman DC
    $01 constant JPEG_HA                        \ [0x01] Huffman AC
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization Table
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of Block
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical Sampling Factor
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal Sampling Factor
  [then]


  [ifdef] JPEG_JPEG_CONFR6_DEF
    \
    \ @brief JPEG codec configuration register 6
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HD                        \ [0x00] Huffman DC
    $01 constant JPEG_HA                        \ [0x01] Huffman AC
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization Table
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of Block
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical Sampling Factor
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal Sampling Factor
  [then]


  [ifdef] JPEG_JPEG_CONFR7_DEF
    \
    \ @brief JPEG codec configuration register 7
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HD                        \ [0x00] Huffman DC
    $01 constant JPEG_HA                        \ [0x01] Huffman AC
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization Table
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of Block
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical Sampling Factor
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal Sampling Factor
  [then]


  [ifdef] JPEG_JPEG_CR_DEF
    \
    \ @brief JPEG control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_JCEN                      \ [0x00] JPEG Core Enable
    $01 constant JPEG_IFTIE                     \ [0x01] Input FIFO Threshold Interrupt Enable
    $02 constant JPEG_IFNFIE                    \ [0x02] Input FIFO Not Full Interrupt Enable
    $03 constant JPEG_OFTIE                     \ [0x03] Output FIFO Threshold Interrupt Enable
    $04 constant JPEG_OFNEIE                    \ [0x04] Output FIFO Not Empty Interrupt Enable
    $05 constant JPEG_EOCIE                     \ [0x05] End of Conversion Interrupt Enable
    $06 constant JPEG_HPDIE                     \ [0x06] Header Parsing Done Interrupt Enable
    $0b constant JPEG_IDMAEN                    \ [0x0b] Input DMA Enable
    $0c constant JPEG_ODMAEN                    \ [0x0c] Output DMA Enable
    $0d constant JPEG_IFF                       \ [0x0d] Input FIFO Flush
    $0e constant JPEG_OFF                       \ [0x0e] Output FIFO Flush
  [then]


  [ifdef] JPEG_JPEG_SR_DEF
    \
    \ @brief JPEG status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $01 constant JPEG_IFTF                      \ [0x01] Input FIFO Threshold Flag
    $02 constant JPEG_IFNFF                     \ [0x02] Input FIFO Not Full Flag
    $03 constant JPEG_OFTF                      \ [0x03] Output FIFO Threshold Flag
    $04 constant JPEG_OFNEF                     \ [0x04] Output FIFO Not Empty Flag
    $05 constant JPEG_EOCF                      \ [0x05] End of Conversion Flag
    $06 constant JPEG_HPDF                      \ [0x06] Header Parsing Done Flag
    $07 constant JPEG_COF                       \ [0x07] Codec Operation Flag
  [then]


  [ifdef] JPEG_JPEG_CFR_DEF
    \
    \ @brief JPEG clear flag register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $05 constant JPEG_CEOCF                     \ [0x05] Clear End of Conversion Flag
    $06 constant JPEG_CHPDF                     \ [0x06] Clear Header Parsing Done Flag
  [then]


  [ifdef] JPEG_JPEG_DIR_DEF
    \
    \ @brief JPEG data input register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATAIN                    \ [0x00 : 32] Data Input FIFO
  [then]


  [ifdef] JPEG_JPEG_DOR_DEF
    \
    \ @brief JPEG data output register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATAOUT                   \ [0x00 : 32] Data Output FIFO
  [then]


  [ifdef] JPEG_QMEM0_0_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_1_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_2_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_3_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_4_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_5_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_6_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_7_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_8_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_9_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_10_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_11_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_12_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_13_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_14_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM0_15_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_0_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_1_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_2_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_3_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_4_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_5_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_6_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_7_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_8_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_9_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_10_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_11_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_12_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_13_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_14_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM1_15_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_0_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_1_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_2_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_3_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_4_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_5_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_6_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_7_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_8_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_9_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_10_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_11_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_12_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_13_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_14_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM2_15_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_0_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_1_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_2_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_3_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_4_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_5_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_6_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_7_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_8_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_9_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_10_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_11_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_12_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_13_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_14_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_QMEM3_15_DEF
    \
    \ @brief JPEG quantization tables
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QMem_RAM                  \ [0x00 : 32] QMem RAM
  [then]


  [ifdef] JPEG_HUFFMIN_0_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_1_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_2_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_3_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_4_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_5_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_6_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_7_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_8_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_9_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_10_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_11_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_12_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_13_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_14_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFMIN_15_DEF
    \
    \ @brief JPEG HuffMin tables
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffMin_RAM               \ [0x00 : 32] HuffMin RAM
  [then]


  [ifdef] JPEG_HUFFBASE0_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE1_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE2_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE3_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE4_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE5_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE6_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE7_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE8_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE9_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE10_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE11_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE12_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE13_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE14_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE15_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE16_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE17_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE18_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE19_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE20_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE21_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE22_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE23_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE24_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE25_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE26_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE27_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x1FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE28_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE29_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE30_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFBASE31_DEF
    \
    \ @brief JPEG HuffSymb tables
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffBase_RAM_0            \ [0x00 : 9] HuffBase RAM
    $10 constant JPEG_HuffBase_RAM_1            \ [0x10 : 9] HuffBase RAM
  [then]


  [ifdef] JPEG_HUFFSYMB0_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB1_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB2_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB3_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB4_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB5_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB6_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB7_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB8_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB9_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB10_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB11_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x23C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB12_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB13_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB14_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB15_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB16_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB17_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB18_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB19_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB20_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB21_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB22_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB23_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB24_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB25_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB26_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x278
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB27_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB28_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB29_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB30_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB31_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB32_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB33_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB34_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB35_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB36_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB37_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB38_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB39_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB40_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB41_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB42_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB43_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB44_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB45_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB46_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB47_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB48_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB49_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB50_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB51_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB52_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB53_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB54_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB55_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB56_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB57_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB58_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB59_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x2FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB60_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB61_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB62_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB63_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB64_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB65_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB66_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB67_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB68_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB69_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB70_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB71_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB72_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB73_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB74_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x338
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB75_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x33C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB76_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB77_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x344
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB78_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x348
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB79_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB80_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB81_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x354
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB82_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x358
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_HUFFSYMB83_DEF
    \
    \ @brief JPEG HUFFSYMB tables
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HuffSymb_RAM              \ [0x00 : 32] DHTSymb RAM
  [then]


  [ifdef] JPEG_DHTMEM0_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x360
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM2_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM3_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x368
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM4_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x36C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM5_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM6_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x374
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM7_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x378
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM8_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x37C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM9_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM10_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM11_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x388
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM12_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x38C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM13_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM14_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM15_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM16_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM17_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM18_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM19_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM20_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM21_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM22_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM23_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM24_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM25_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM26_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM27_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM28_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM29_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM30_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM31_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM32_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM33_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM34_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM35_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM36_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM37_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM38_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM39_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM40_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x3FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM41_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM42_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM43_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM44_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM45_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM46_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM47_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM48_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM49_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM50_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM51_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM52_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x42C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM53_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM54_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x434
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM55_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x438
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM56_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x43C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM57_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM58_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x444
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM59_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x448
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM60_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM61_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x450
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM62_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x454
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM63_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x458
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM64_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x45C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM65_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x460
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM66_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM67_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x468
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM68_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x46C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM69_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x470
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM70_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x474
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM71_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x478
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM72_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x47C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM73_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x480
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM74_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x484
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM75_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x488
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM76_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x48C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM77_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x490
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM78_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x494
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM79_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM80_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x49C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM81_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM82_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM83_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM84_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM85_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM86_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM87_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM88_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM89_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM90_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM91_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM92_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM93_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM94_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM95_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM96_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM97_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM98_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM99_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM100_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM101_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM102_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_DHTMEM103_DEF
    \
    \ @brief JPEG DHTMem tables
    \ Address offset: 0x4F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_0_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_1_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_2_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_3_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_4_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_5_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_6_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x518
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_7_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_8_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_9_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x524
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_10_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_11_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x52C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_12_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_13_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x534
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_14_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x538
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_15_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x53C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_16_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_17_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x544
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_18_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_19_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_20_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_21_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x554
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_22_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x558
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_23_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x55C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_24_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_25_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_26_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x568
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_27_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x56C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_28_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x570
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_29_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x574
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_30_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x578
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_31_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x57C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_32_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x580
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_33_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x584
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_34_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x588
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_35_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x58C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_36_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_37_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_38_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x598
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_39_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x59C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_40_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_41_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_42_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_43_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_44_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_45_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_46_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_47_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_48_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_49_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_50_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_51_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_52_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_53_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_54_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_55_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_56_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_57_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_58_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_59_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_60_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_61_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_62_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_63_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x5FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_64_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_65_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_66_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_67_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_68_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_69_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_70_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x618
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_71_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_72_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_73_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x624
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_74_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_75_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x62C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_76_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_77_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x634
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_78_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x638
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_79_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x63C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_80_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_81_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x644
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_82_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x648
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_83_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_84_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_85_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_86_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x658
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC0_87_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 0
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_0_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_1_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_2_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_3_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x66C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_4_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x670
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_5_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x674
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_6_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x678
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_7_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x67C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_8_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x680
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_9_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x684
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_10_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x688
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_11_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x68C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_12_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x690
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_13_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_14_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x698
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_15_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x69C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_16_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_17_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_18_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_19_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_20_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_21_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_22_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_23_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_24_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_25_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_26_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_27_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_28_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_29_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_30_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_31_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_32_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_33_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_34_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_35_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_36_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_37_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_38_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_39_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x6FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_40_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x700
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_41_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x704
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_42_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x708
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_43_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x70C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_44_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x710
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_45_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x714
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_46_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x718
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_47_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x71C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_48_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x720
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_49_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x724
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_50_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x728
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_51_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x72C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_52_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x730
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_53_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x734
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_54_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x738
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_55_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x73C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_56_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x740
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_57_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x744
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_58_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x748
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_59_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_60_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_61_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x754
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_62_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x758
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_63_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x75C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_64_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x760
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_65_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x764
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_66_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x768
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_67_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x76C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_68_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x770
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_69_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x774
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_70_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x778
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_71_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x77C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_72_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x780
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_73_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x784
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_74_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x788
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_75_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x78C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_76_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x790
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_77_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_78_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_79_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x79C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_80_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x7A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_81_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x7A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_82_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x7A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_83_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x7AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_84_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x7B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_85_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x7B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_86_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x7B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_AC1_87_DEF
    \
    \ @brief JPEG encoder, AC Huffman table 1
    \ Address offset: 0x7BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC0_0_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 0
    \ Address offset: 0x7C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC0_1_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 0
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC0_2_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 0
    \ Address offset: 0x7C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC0_3_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 0
    \ Address offset: 0x7CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC0_4_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 0
    \ Address offset: 0x7D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC0_5_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 0
    \ Address offset: 0x7D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC0_6_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 0
    \ Address offset: 0x7D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC0_7_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 0
    \ Address offset: 0x7DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC1_0_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 1
    \ Address offset: 0x7E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC1_1_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 1
    \ Address offset: 0x7E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC1_2_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 1
    \ Address offset: 0x7E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC1_3_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 1
    \ Address offset: 0x7EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC1_4_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 1
    \ Address offset: 0x7F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC1_5_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 1
    \ Address offset: 0x7F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC1_6_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 1
    \ Address offset: 0x7F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]


  [ifdef] JPEG_HUFFENC_DC1_7_DEF
    \
    \ @brief JPEG encoder, DC Huffman table 1
    \ Address offset: 0x7FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DHTMem_RAM                \ [0x00 : 32] DHTMem RAM
  [then]

  \
  \ @brief JPEG codec
  \
  $00 constant JPEG_JPEG_CONFR0         \ JPEG codec configuration register 0
  $04 constant JPEG_JPEG_CONFR1         \ JPEG codec configuration register 1
  $08 constant JPEG_JPEG_CONFR2         \ JPEG codec configuration register 2
  $0C constant JPEG_JPEG_CONFR3         \ JPEG codec configuration register 3
  $10 constant JPEG_JPEG_CONFR4         \ JPEG codec configuration register 4
  $14 constant JPEG_JPEG_CONFR5         \ JPEG codec configuration register 5
  $18 constant JPEG_JPEG_CONFR6         \ JPEG codec configuration register 6
  $1C constant JPEG_JPEG_CONFR7         \ JPEG codec configuration register 7
  $30 constant JPEG_JPEG_CR             \ JPEG control register
  $34 constant JPEG_JPEG_SR             \ JPEG status register
  $38 constant JPEG_JPEG_CFR            \ JPEG clear flag register
  $40 constant JPEG_JPEG_DIR            \ JPEG data input register
  $44 constant JPEG_JPEG_DOR            \ JPEG data output register
  $50 constant JPEG_QMEM0_0             \ JPEG quantization tables
  $54 constant JPEG_QMEM0_1             \ JPEG quantization tables
  $58 constant JPEG_QMEM0_2             \ JPEG quantization tables
  $5C constant JPEG_QMEM0_3             \ JPEG quantization tables
  $60 constant JPEG_QMEM0_4             \ JPEG quantization tables
  $64 constant JPEG_QMEM0_5             \ JPEG quantization tables
  $68 constant JPEG_QMEM0_6             \ JPEG quantization tables
  $6C constant JPEG_QMEM0_7             \ JPEG quantization tables
  $70 constant JPEG_QMEM0_8             \ JPEG quantization tables
  $74 constant JPEG_QMEM0_9             \ JPEG quantization tables
  $78 constant JPEG_QMEM0_10            \ JPEG quantization tables
  $7C constant JPEG_QMEM0_11            \ JPEG quantization tables
  $80 constant JPEG_QMEM0_12            \ JPEG quantization tables
  $84 constant JPEG_QMEM0_13            \ JPEG quantization tables
  $88 constant JPEG_QMEM0_14            \ JPEG quantization tables
  $8C constant JPEG_QMEM0_15            \ JPEG quantization tables
  $90 constant JPEG_QMEM1_0             \ JPEG quantization tables
  $94 constant JPEG_QMEM1_1             \ JPEG quantization tables
  $98 constant JPEG_QMEM1_2             \ JPEG quantization tables
  $9C constant JPEG_QMEM1_3             \ JPEG quantization tables
  $A0 constant JPEG_QMEM1_4             \ JPEG quantization tables
  $A4 constant JPEG_QMEM1_5             \ JPEG quantization tables
  $A8 constant JPEG_QMEM1_6             \ JPEG quantization tables
  $AC constant JPEG_QMEM1_7             \ JPEG quantization tables
  $B0 constant JPEG_QMEM1_8             \ JPEG quantization tables
  $B4 constant JPEG_QMEM1_9             \ JPEG quantization tables
  $B8 constant JPEG_QMEM1_10            \ JPEG quantization tables
  $BC constant JPEG_QMEM1_11            \ JPEG quantization tables
  $C0 constant JPEG_QMEM1_12            \ JPEG quantization tables
  $C4 constant JPEG_QMEM1_13            \ JPEG quantization tables
  $C8 constant JPEG_QMEM1_14            \ JPEG quantization tables
  $CC constant JPEG_QMEM1_15            \ JPEG quantization tables
  $D0 constant JPEG_QMEM2_0             \ JPEG quantization tables
  $D4 constant JPEG_QMEM2_1             \ JPEG quantization tables
  $D8 constant JPEG_QMEM2_2             \ JPEG quantization tables
  $DC constant JPEG_QMEM2_3             \ JPEG quantization tables
  $E0 constant JPEG_QMEM2_4             \ JPEG quantization tables
  $E4 constant JPEG_QMEM2_5             \ JPEG quantization tables
  $E8 constant JPEG_QMEM2_6             \ JPEG quantization tables
  $EC constant JPEG_QMEM2_7             \ JPEG quantization tables
  $F0 constant JPEG_QMEM2_8             \ JPEG quantization tables
  $F4 constant JPEG_QMEM2_9             \ JPEG quantization tables
  $F8 constant JPEG_QMEM2_10            \ JPEG quantization tables
  $FC constant JPEG_QMEM2_11            \ JPEG quantization tables
  $100 constant JPEG_QMEM2_12           \ JPEG quantization tables
  $104 constant JPEG_QMEM2_13           \ JPEG quantization tables
  $108 constant JPEG_QMEM2_14           \ JPEG quantization tables
  $10C constant JPEG_QMEM2_15           \ JPEG quantization tables
  $110 constant JPEG_QMEM3_0            \ JPEG quantization tables
  $114 constant JPEG_QMEM3_1            \ JPEG quantization tables
  $118 constant JPEG_QMEM3_2            \ JPEG quantization tables
  $11C constant JPEG_QMEM3_3            \ JPEG quantization tables
  $120 constant JPEG_QMEM3_4            \ JPEG quantization tables
  $124 constant JPEG_QMEM3_5            \ JPEG quantization tables
  $128 constant JPEG_QMEM3_6            \ JPEG quantization tables
  $12C constant JPEG_QMEM3_7            \ JPEG quantization tables
  $130 constant JPEG_QMEM3_8            \ JPEG quantization tables
  $134 constant JPEG_QMEM3_9            \ JPEG quantization tables
  $138 constant JPEG_QMEM3_10           \ JPEG quantization tables
  $13C constant JPEG_QMEM3_11           \ JPEG quantization tables
  $140 constant JPEG_QMEM3_12           \ JPEG quantization tables
  $144 constant JPEG_QMEM3_13           \ JPEG quantization tables
  $148 constant JPEG_QMEM3_14           \ JPEG quantization tables
  $14C constant JPEG_QMEM3_15           \ JPEG quantization tables
  $150 constant JPEG_HUFFMIN_0          \ JPEG HuffMin tables
  $154 constant JPEG_HUFFMIN_1          \ JPEG HuffMin tables
  $158 constant JPEG_HUFFMIN_2          \ JPEG HuffMin tables
  $15C constant JPEG_HUFFMIN_3          \ JPEG HuffMin tables
  $160 constant JPEG_HUFFMIN_4          \ JPEG HuffMin tables
  $164 constant JPEG_HUFFMIN_5          \ JPEG HuffMin tables
  $168 constant JPEG_HUFFMIN_6          \ JPEG HuffMin tables
  $16C constant JPEG_HUFFMIN_7          \ JPEG HuffMin tables
  $170 constant JPEG_HUFFMIN_8          \ JPEG HuffMin tables
  $174 constant JPEG_HUFFMIN_9          \ JPEG HuffMin tables
  $178 constant JPEG_HUFFMIN_10         \ JPEG HuffMin tables
  $17C constant JPEG_HUFFMIN_11         \ JPEG HuffMin tables
  $180 constant JPEG_HUFFMIN_12         \ JPEG HuffMin tables
  $184 constant JPEG_HUFFMIN_13         \ JPEG HuffMin tables
  $188 constant JPEG_HUFFMIN_14         \ JPEG HuffMin tables
  $18C constant JPEG_HUFFMIN_15         \ JPEG HuffMin tables
  $190 constant JPEG_HUFFBASE0          \ JPEG HuffSymb tables
  $194 constant JPEG_HUFFBASE1          \ JPEG HuffSymb tables
  $198 constant JPEG_HUFFBASE2          \ JPEG HuffSymb tables
  $19C constant JPEG_HUFFBASE3          \ JPEG HuffSymb tables
  $1A0 constant JPEG_HUFFBASE4          \ JPEG HuffSymb tables
  $1A4 constant JPEG_HUFFBASE5          \ JPEG HuffSymb tables
  $1A8 constant JPEG_HUFFBASE6          \ JPEG HuffSymb tables
  $1AC constant JPEG_HUFFBASE7          \ JPEG HuffSymb tables
  $1B0 constant JPEG_HUFFBASE8          \ JPEG HuffSymb tables
  $1B4 constant JPEG_HUFFBASE9          \ JPEG HuffSymb tables
  $1B8 constant JPEG_HUFFBASE10         \ JPEG HuffSymb tables
  $1BC constant JPEG_HUFFBASE11         \ JPEG HuffSymb tables
  $1C0 constant JPEG_HUFFBASE12         \ JPEG HuffSymb tables
  $1C4 constant JPEG_HUFFBASE13         \ JPEG HuffSymb tables
  $1C8 constant JPEG_HUFFBASE14         \ JPEG HuffSymb tables
  $1CC constant JPEG_HUFFBASE15         \ JPEG HuffSymb tables
  $1D0 constant JPEG_HUFFBASE16         \ JPEG HuffSymb tables
  $1D4 constant JPEG_HUFFBASE17         \ JPEG HuffSymb tables
  $1D8 constant JPEG_HUFFBASE18         \ JPEG HuffSymb tables
  $1DC constant JPEG_HUFFBASE19         \ JPEG HuffSymb tables
  $1E0 constant JPEG_HUFFBASE20         \ JPEG HuffSymb tables
  $1E4 constant JPEG_HUFFBASE21         \ JPEG HuffSymb tables
  $1E8 constant JPEG_HUFFBASE22         \ JPEG HuffSymb tables
  $1EC constant JPEG_HUFFBASE23         \ JPEG HuffSymb tables
  $1F0 constant JPEG_HUFFBASE24         \ JPEG HuffSymb tables
  $1F4 constant JPEG_HUFFBASE25         \ JPEG HuffSymb tables
  $1F8 constant JPEG_HUFFBASE26         \ JPEG HuffSymb tables
  $1FC constant JPEG_HUFFBASE27         \ JPEG HuffSymb tables
  $200 constant JPEG_HUFFBASE28         \ JPEG HuffSymb tables
  $204 constant JPEG_HUFFBASE29         \ JPEG HuffSymb tables
  $208 constant JPEG_HUFFBASE30         \ JPEG HuffSymb tables
  $20C constant JPEG_HUFFBASE31         \ JPEG HuffSymb tables
  $210 constant JPEG_HUFFSYMB0          \ JPEG HUFFSYMB tables
  $214 constant JPEG_HUFFSYMB1          \ JPEG HUFFSYMB tables
  $218 constant JPEG_HUFFSYMB2          \ JPEG HUFFSYMB tables
  $21C constant JPEG_HUFFSYMB3          \ JPEG HUFFSYMB tables
  $220 constant JPEG_HUFFSYMB4          \ JPEG HUFFSYMB tables
  $224 constant JPEG_HUFFSYMB5          \ JPEG HUFFSYMB tables
  $228 constant JPEG_HUFFSYMB6          \ JPEG HUFFSYMB tables
  $22C constant JPEG_HUFFSYMB7          \ JPEG HUFFSYMB tables
  $230 constant JPEG_HUFFSYMB8          \ JPEG HUFFSYMB tables
  $234 constant JPEG_HUFFSYMB9          \ JPEG HUFFSYMB tables
  $238 constant JPEG_HUFFSYMB10         \ JPEG HUFFSYMB tables
  $23C constant JPEG_HUFFSYMB11         \ JPEG HUFFSYMB tables
  $240 constant JPEG_HUFFSYMB12         \ JPEG HUFFSYMB tables
  $244 constant JPEG_HUFFSYMB13         \ JPEG HUFFSYMB tables
  $248 constant JPEG_HUFFSYMB14         \ JPEG HUFFSYMB tables
  $24C constant JPEG_HUFFSYMB15         \ JPEG HUFFSYMB tables
  $250 constant JPEG_HUFFSYMB16         \ JPEG HUFFSYMB tables
  $254 constant JPEG_HUFFSYMB17         \ JPEG HUFFSYMB tables
  $258 constant JPEG_HUFFSYMB18         \ JPEG HUFFSYMB tables
  $25C constant JPEG_HUFFSYMB19         \ JPEG HUFFSYMB tables
  $260 constant JPEG_HUFFSYMB20         \ JPEG HUFFSYMB tables
  $264 constant JPEG_HUFFSYMB21         \ JPEG HUFFSYMB tables
  $268 constant JPEG_HUFFSYMB22         \ JPEG HUFFSYMB tables
  $26C constant JPEG_HUFFSYMB23         \ JPEG HUFFSYMB tables
  $270 constant JPEG_HUFFSYMB24         \ JPEG HUFFSYMB tables
  $274 constant JPEG_HUFFSYMB25         \ JPEG HUFFSYMB tables
  $278 constant JPEG_HUFFSYMB26         \ JPEG HUFFSYMB tables
  $27C constant JPEG_HUFFSYMB27         \ JPEG HUFFSYMB tables
  $280 constant JPEG_HUFFSYMB28         \ JPEG HUFFSYMB tables
  $284 constant JPEG_HUFFSYMB29         \ JPEG HUFFSYMB tables
  $288 constant JPEG_HUFFSYMB30         \ JPEG HUFFSYMB tables
  $28C constant JPEG_HUFFSYMB31         \ JPEG HUFFSYMB tables
  $290 constant JPEG_HUFFSYMB32         \ JPEG HUFFSYMB tables
  $294 constant JPEG_HUFFSYMB33         \ JPEG HUFFSYMB tables
  $298 constant JPEG_HUFFSYMB34         \ JPEG HUFFSYMB tables
  $29C constant JPEG_HUFFSYMB35         \ JPEG HUFFSYMB tables
  $2A0 constant JPEG_HUFFSYMB36         \ JPEG HUFFSYMB tables
  $2A4 constant JPEG_HUFFSYMB37         \ JPEG HUFFSYMB tables
  $2A8 constant JPEG_HUFFSYMB38         \ JPEG HUFFSYMB tables
  $2AC constant JPEG_HUFFSYMB39         \ JPEG HUFFSYMB tables
  $2B0 constant JPEG_HUFFSYMB40         \ JPEG HUFFSYMB tables
  $2B4 constant JPEG_HUFFSYMB41         \ JPEG HUFFSYMB tables
  $2B8 constant JPEG_HUFFSYMB42         \ JPEG HUFFSYMB tables
  $2BC constant JPEG_HUFFSYMB43         \ JPEG HUFFSYMB tables
  $2C0 constant JPEG_HUFFSYMB44         \ JPEG HUFFSYMB tables
  $2C4 constant JPEG_HUFFSYMB45         \ JPEG HUFFSYMB tables
  $2C8 constant JPEG_HUFFSYMB46         \ JPEG HUFFSYMB tables
  $2CC constant JPEG_HUFFSYMB47         \ JPEG HUFFSYMB tables
  $2D0 constant JPEG_HUFFSYMB48         \ JPEG HUFFSYMB tables
  $2D4 constant JPEG_HUFFSYMB49         \ JPEG HUFFSYMB tables
  $2D8 constant JPEG_HUFFSYMB50         \ JPEG HUFFSYMB tables
  $2DC constant JPEG_HUFFSYMB51         \ JPEG HUFFSYMB tables
  $2E0 constant JPEG_HUFFSYMB52         \ JPEG HUFFSYMB tables
  $2E4 constant JPEG_HUFFSYMB53         \ JPEG HUFFSYMB tables
  $2E8 constant JPEG_HUFFSYMB54         \ JPEG HUFFSYMB tables
  $2EC constant JPEG_HUFFSYMB55         \ JPEG HUFFSYMB tables
  $2F0 constant JPEG_HUFFSYMB56         \ JPEG HUFFSYMB tables
  $2F4 constant JPEG_HUFFSYMB57         \ JPEG HUFFSYMB tables
  $2F8 constant JPEG_HUFFSYMB58         \ JPEG HUFFSYMB tables
  $2FC constant JPEG_HUFFSYMB59         \ JPEG HUFFSYMB tables
  $300 constant JPEG_HUFFSYMB60         \ JPEG HUFFSYMB tables
  $304 constant JPEG_HUFFSYMB61         \ JPEG HUFFSYMB tables
  $308 constant JPEG_HUFFSYMB62         \ JPEG HUFFSYMB tables
  $30C constant JPEG_HUFFSYMB63         \ JPEG HUFFSYMB tables
  $310 constant JPEG_HUFFSYMB64         \ JPEG HUFFSYMB tables
  $314 constant JPEG_HUFFSYMB65         \ JPEG HUFFSYMB tables
  $318 constant JPEG_HUFFSYMB66         \ JPEG HUFFSYMB tables
  $31C constant JPEG_HUFFSYMB67         \ JPEG HUFFSYMB tables
  $320 constant JPEG_HUFFSYMB68         \ JPEG HUFFSYMB tables
  $324 constant JPEG_HUFFSYMB69         \ JPEG HUFFSYMB tables
  $328 constant JPEG_HUFFSYMB70         \ JPEG HUFFSYMB tables
  $32C constant JPEG_HUFFSYMB71         \ JPEG HUFFSYMB tables
  $330 constant JPEG_HUFFSYMB72         \ JPEG HUFFSYMB tables
  $334 constant JPEG_HUFFSYMB73         \ JPEG HUFFSYMB tables
  $338 constant JPEG_HUFFSYMB74         \ JPEG HUFFSYMB tables
  $33C constant JPEG_HUFFSYMB75         \ JPEG HUFFSYMB tables
  $340 constant JPEG_HUFFSYMB76         \ JPEG HUFFSYMB tables
  $344 constant JPEG_HUFFSYMB77         \ JPEG HUFFSYMB tables
  $348 constant JPEG_HUFFSYMB78         \ JPEG HUFFSYMB tables
  $34C constant JPEG_HUFFSYMB79         \ JPEG HUFFSYMB tables
  $350 constant JPEG_HUFFSYMB80         \ JPEG HUFFSYMB tables
  $354 constant JPEG_HUFFSYMB81         \ JPEG HUFFSYMB tables
  $358 constant JPEG_HUFFSYMB82         \ JPEG HUFFSYMB tables
  $35C constant JPEG_HUFFSYMB83         \ JPEG HUFFSYMB tables
  $360 constant JPEG_DHTMEM0            \ JPEG DHTMem tables
  $364 constant JPEG_DHTMEM2            \ JPEG DHTMem tables
  $368 constant JPEG_DHTMEM3            \ JPEG DHTMem tables
  $36C constant JPEG_DHTMEM4            \ JPEG DHTMem tables
  $370 constant JPEG_DHTMEM5            \ JPEG DHTMem tables
  $374 constant JPEG_DHTMEM6            \ JPEG DHTMem tables
  $378 constant JPEG_DHTMEM7            \ JPEG DHTMem tables
  $37C constant JPEG_DHTMEM8            \ JPEG DHTMem tables
  $380 constant JPEG_DHTMEM9            \ JPEG DHTMem tables
  $384 constant JPEG_DHTMEM10           \ JPEG DHTMem tables
  $388 constant JPEG_DHTMEM11           \ JPEG DHTMem tables
  $38C constant JPEG_DHTMEM12           \ JPEG DHTMem tables
  $390 constant JPEG_DHTMEM13           \ JPEG DHTMem tables
  $394 constant JPEG_DHTMEM14           \ JPEG DHTMem tables
  $398 constant JPEG_DHTMEM15           \ JPEG DHTMem tables
  $39C constant JPEG_DHTMEM16           \ JPEG DHTMem tables
  $3A0 constant JPEG_DHTMEM17           \ JPEG DHTMem tables
  $3A4 constant JPEG_DHTMEM18           \ JPEG DHTMem tables
  $3A8 constant JPEG_DHTMEM19           \ JPEG DHTMem tables
  $3AC constant JPEG_DHTMEM20           \ JPEG DHTMem tables
  $3B0 constant JPEG_DHTMEM21           \ JPEG DHTMem tables
  $3B4 constant JPEG_DHTMEM22           \ JPEG DHTMem tables
  $3B8 constant JPEG_DHTMEM23           \ JPEG DHTMem tables
  $3BC constant JPEG_DHTMEM24           \ JPEG DHTMem tables
  $3C0 constant JPEG_DHTMEM25           \ JPEG DHTMem tables
  $3C4 constant JPEG_DHTMEM26           \ JPEG DHTMem tables
  $3C8 constant JPEG_DHTMEM27           \ JPEG DHTMem tables
  $3CC constant JPEG_DHTMEM28           \ JPEG DHTMem tables
  $3D0 constant JPEG_DHTMEM29           \ JPEG DHTMem tables
  $3D4 constant JPEG_DHTMEM30           \ JPEG DHTMem tables
  $3D8 constant JPEG_DHTMEM31           \ JPEG DHTMem tables
  $3DC constant JPEG_DHTMEM32           \ JPEG DHTMem tables
  $3E0 constant JPEG_DHTMEM33           \ JPEG DHTMem tables
  $3E4 constant JPEG_DHTMEM34           \ JPEG DHTMem tables
  $3E8 constant JPEG_DHTMEM35           \ JPEG DHTMem tables
  $3EC constant JPEG_DHTMEM36           \ JPEG DHTMem tables
  $3F0 constant JPEG_DHTMEM37           \ JPEG DHTMem tables
  $3F4 constant JPEG_DHTMEM38           \ JPEG DHTMem tables
  $3F8 constant JPEG_DHTMEM39           \ JPEG DHTMem tables
  $3FC constant JPEG_DHTMEM40           \ JPEG DHTMem tables
  $400 constant JPEG_DHTMEM41           \ JPEG DHTMem tables
  $404 constant JPEG_DHTMEM42           \ JPEG DHTMem tables
  $408 constant JPEG_DHTMEM43           \ JPEG DHTMem tables
  $40C constant JPEG_DHTMEM44           \ JPEG DHTMem tables
  $410 constant JPEG_DHTMEM45           \ JPEG DHTMem tables
  $414 constant JPEG_DHTMEM46           \ JPEG DHTMem tables
  $418 constant JPEG_DHTMEM47           \ JPEG DHTMem tables
  $41C constant JPEG_DHTMEM48           \ JPEG DHTMem tables
  $420 constant JPEG_DHTMEM49           \ JPEG DHTMem tables
  $424 constant JPEG_DHTMEM50           \ JPEG DHTMem tables
  $428 constant JPEG_DHTMEM51           \ JPEG DHTMem tables
  $42C constant JPEG_DHTMEM52           \ JPEG DHTMem tables
  $430 constant JPEG_DHTMEM53           \ JPEG DHTMem tables
  $434 constant JPEG_DHTMEM54           \ JPEG DHTMem tables
  $438 constant JPEG_DHTMEM55           \ JPEG DHTMem tables
  $43C constant JPEG_DHTMEM56           \ JPEG DHTMem tables
  $440 constant JPEG_DHTMEM57           \ JPEG DHTMem tables
  $444 constant JPEG_DHTMEM58           \ JPEG DHTMem tables
  $448 constant JPEG_DHTMEM59           \ JPEG DHTMem tables
  $44C constant JPEG_DHTMEM60           \ JPEG DHTMem tables
  $450 constant JPEG_DHTMEM61           \ JPEG DHTMem tables
  $454 constant JPEG_DHTMEM62           \ JPEG DHTMem tables
  $458 constant JPEG_DHTMEM63           \ JPEG DHTMem tables
  $45C constant JPEG_DHTMEM64           \ JPEG DHTMem tables
  $460 constant JPEG_DHTMEM65           \ JPEG DHTMem tables
  $464 constant JPEG_DHTMEM66           \ JPEG DHTMem tables
  $468 constant JPEG_DHTMEM67           \ JPEG DHTMem tables
  $46C constant JPEG_DHTMEM68           \ JPEG DHTMem tables
  $470 constant JPEG_DHTMEM69           \ JPEG DHTMem tables
  $474 constant JPEG_DHTMEM70           \ JPEG DHTMem tables
  $478 constant JPEG_DHTMEM71           \ JPEG DHTMem tables
  $47C constant JPEG_DHTMEM72           \ JPEG DHTMem tables
  $480 constant JPEG_DHTMEM73           \ JPEG DHTMem tables
  $484 constant JPEG_DHTMEM74           \ JPEG DHTMem tables
  $488 constant JPEG_DHTMEM75           \ JPEG DHTMem tables
  $48C constant JPEG_DHTMEM76           \ JPEG DHTMem tables
  $490 constant JPEG_DHTMEM77           \ JPEG DHTMem tables
  $494 constant JPEG_DHTMEM78           \ JPEG DHTMem tables
  $498 constant JPEG_DHTMEM79           \ JPEG DHTMem tables
  $49C constant JPEG_DHTMEM80           \ JPEG DHTMem tables
  $4A0 constant JPEG_DHTMEM81           \ JPEG DHTMem tables
  $4A4 constant JPEG_DHTMEM82           \ JPEG DHTMem tables
  $4A8 constant JPEG_DHTMEM83           \ JPEG DHTMem tables
  $4AC constant JPEG_DHTMEM84           \ JPEG DHTMem tables
  $4B0 constant JPEG_DHTMEM85           \ JPEG DHTMem tables
  $4B4 constant JPEG_DHTMEM86           \ JPEG DHTMem tables
  $4B8 constant JPEG_DHTMEM87           \ JPEG DHTMem tables
  $4BC constant JPEG_DHTMEM88           \ JPEG DHTMem tables
  $4C0 constant JPEG_DHTMEM89           \ JPEG DHTMem tables
  $4C4 constant JPEG_DHTMEM90           \ JPEG DHTMem tables
  $4C8 constant JPEG_DHTMEM91           \ JPEG DHTMem tables
  $4CC constant JPEG_DHTMEM92           \ JPEG DHTMem tables
  $4D0 constant JPEG_DHTMEM93           \ JPEG DHTMem tables
  $4D4 constant JPEG_DHTMEM94           \ JPEG DHTMem tables
  $4D8 constant JPEG_DHTMEM95           \ JPEG DHTMem tables
  $4DC constant JPEG_DHTMEM96           \ JPEG DHTMem tables
  $4E0 constant JPEG_DHTMEM97           \ JPEG DHTMem tables
  $4E4 constant JPEG_DHTMEM98           \ JPEG DHTMem tables
  $4E8 constant JPEG_DHTMEM99           \ JPEG DHTMem tables
  $4EC constant JPEG_DHTMEM100          \ JPEG DHTMem tables
  $4F0 constant JPEG_DHTMEM101          \ JPEG DHTMem tables
  $4F4 constant JPEG_DHTMEM102          \ JPEG DHTMem tables
  $4F8 constant JPEG_DHTMEM103          \ JPEG DHTMem tables
  $500 constant JPEG_HUFFENC_AC0_0      \ JPEG encoder, AC Huffman table 0
  $504 constant JPEG_HUFFENC_AC0_1      \ JPEG encoder, AC Huffman table 0
  $508 constant JPEG_HUFFENC_AC0_2      \ JPEG encoder, AC Huffman table 0
  $50C constant JPEG_HUFFENC_AC0_3      \ JPEG encoder, AC Huffman table 0
  $510 constant JPEG_HUFFENC_AC0_4      \ JPEG encoder, AC Huffman table 0
  $514 constant JPEG_HUFFENC_AC0_5      \ JPEG encoder, AC Huffman table 0
  $518 constant JPEG_HUFFENC_AC0_6      \ JPEG encoder, AC Huffman table 0
  $51C constant JPEG_HUFFENC_AC0_7      \ JPEG encoder, AC Huffman table 0
  $520 constant JPEG_HUFFENC_AC0_8      \ JPEG encoder, AC Huffman table 0
  $524 constant JPEG_HUFFENC_AC0_9      \ JPEG encoder, AC Huffman table 0
  $528 constant JPEG_HUFFENC_AC0_10     \ JPEG encoder, AC Huffman table 0
  $52C constant JPEG_HUFFENC_AC0_11     \ JPEG encoder, AC Huffman table 0
  $530 constant JPEG_HUFFENC_AC0_12     \ JPEG encoder, AC Huffman table 0
  $534 constant JPEG_HUFFENC_AC0_13     \ JPEG encoder, AC Huffman table 0
  $538 constant JPEG_HUFFENC_AC0_14     \ JPEG encoder, AC Huffman table 0
  $53C constant JPEG_HUFFENC_AC0_15     \ JPEG encoder, AC Huffman table 0
  $540 constant JPEG_HUFFENC_AC0_16     \ JPEG encoder, AC Huffman table 0
  $544 constant JPEG_HUFFENC_AC0_17     \ JPEG encoder, AC Huffman table 0
  $548 constant JPEG_HUFFENC_AC0_18     \ JPEG encoder, AC Huffman table 0
  $54C constant JPEG_HUFFENC_AC0_19     \ JPEG encoder, AC Huffman table 0
  $550 constant JPEG_HUFFENC_AC0_20     \ JPEG encoder, AC Huffman table 0
  $554 constant JPEG_HUFFENC_AC0_21     \ JPEG encoder, AC Huffman table 0
  $558 constant JPEG_HUFFENC_AC0_22     \ JPEG encoder, AC Huffman table 0
  $55C constant JPEG_HUFFENC_AC0_23     \ JPEG encoder, AC Huffman table 0
  $560 constant JPEG_HUFFENC_AC0_24     \ JPEG encoder, AC Huffman table 0
  $564 constant JPEG_HUFFENC_AC0_25     \ JPEG encoder, AC Huffman table 0
  $568 constant JPEG_HUFFENC_AC0_26     \ JPEG encoder, AC Huffman table 0
  $56C constant JPEG_HUFFENC_AC0_27     \ JPEG encoder, AC Huffman table 0
  $570 constant JPEG_HUFFENC_AC0_28     \ JPEG encoder, AC Huffman table 0
  $574 constant JPEG_HUFFENC_AC0_29     \ JPEG encoder, AC Huffman table 0
  $578 constant JPEG_HUFFENC_AC0_30     \ JPEG encoder, AC Huffman table 0
  $57C constant JPEG_HUFFENC_AC0_31     \ JPEG encoder, AC Huffman table 0
  $580 constant JPEG_HUFFENC_AC0_32     \ JPEG encoder, AC Huffman table 0
  $584 constant JPEG_HUFFENC_AC0_33     \ JPEG encoder, AC Huffman table 0
  $588 constant JPEG_HUFFENC_AC0_34     \ JPEG encoder, AC Huffman table 0
  $58C constant JPEG_HUFFENC_AC0_35     \ JPEG encoder, AC Huffman table 0
  $590 constant JPEG_HUFFENC_AC0_36     \ JPEG encoder, AC Huffman table 0
  $594 constant JPEG_HUFFENC_AC0_37     \ JPEG encoder, AC Huffman table 0
  $598 constant JPEG_HUFFENC_AC0_38     \ JPEG encoder, AC Huffman table 0
  $59C constant JPEG_HUFFENC_AC0_39     \ JPEG encoder, AC Huffman table 0
  $5A0 constant JPEG_HUFFENC_AC0_40     \ JPEG encoder, AC Huffman table 0
  $5A4 constant JPEG_HUFFENC_AC0_41     \ JPEG encoder, AC Huffman table 0
  $5A8 constant JPEG_HUFFENC_AC0_42     \ JPEG encoder, AC Huffman table 0
  $5AC constant JPEG_HUFFENC_AC0_43     \ JPEG encoder, AC Huffman table 0
  $5B0 constant JPEG_HUFFENC_AC0_44     \ JPEG encoder, AC Huffman table 0
  $5B4 constant JPEG_HUFFENC_AC0_45     \ JPEG encoder, AC Huffman table 0
  $5B8 constant JPEG_HUFFENC_AC0_46     \ JPEG encoder, AC Huffman table 0
  $5BC constant JPEG_HUFFENC_AC0_47     \ JPEG encoder, AC Huffman table 0
  $5C0 constant JPEG_HUFFENC_AC0_48     \ JPEG encoder, AC Huffman table 0
  $5C4 constant JPEG_HUFFENC_AC0_49     \ JPEG encoder, AC Huffman table 0
  $5C8 constant JPEG_HUFFENC_AC0_50     \ JPEG encoder, AC Huffman table 0
  $5CC constant JPEG_HUFFENC_AC0_51     \ JPEG encoder, AC Huffman table 0
  $5D0 constant JPEG_HUFFENC_AC0_52     \ JPEG encoder, AC Huffman table 0
  $5D4 constant JPEG_HUFFENC_AC0_53     \ JPEG encoder, AC Huffman table 0
  $5D8 constant JPEG_HUFFENC_AC0_54     \ JPEG encoder, AC Huffman table 0
  $5DC constant JPEG_HUFFENC_AC0_55     \ JPEG encoder, AC Huffman table 0
  $5E0 constant JPEG_HUFFENC_AC0_56     \ JPEG encoder, AC Huffman table 0
  $5E4 constant JPEG_HUFFENC_AC0_57     \ JPEG encoder, AC Huffman table 0
  $5E8 constant JPEG_HUFFENC_AC0_58     \ JPEG encoder, AC Huffman table 0
  $5EC constant JPEG_HUFFENC_AC0_59     \ JPEG encoder, AC Huffman table 0
  $5F0 constant JPEG_HUFFENC_AC0_60     \ JPEG encoder, AC Huffman table 0
  $5F4 constant JPEG_HUFFENC_AC0_61     \ JPEG encoder, AC Huffman table 0
  $5F8 constant JPEG_HUFFENC_AC0_62     \ JPEG encoder, AC Huffman table 0
  $5FC constant JPEG_HUFFENC_AC0_63     \ JPEG encoder, AC Huffman table 0
  $600 constant JPEG_HUFFENC_AC0_64     \ JPEG encoder, AC Huffman table 0
  $604 constant JPEG_HUFFENC_AC0_65     \ JPEG encoder, AC Huffman table 0
  $608 constant JPEG_HUFFENC_AC0_66     \ JPEG encoder, AC Huffman table 0
  $60C constant JPEG_HUFFENC_AC0_67     \ JPEG encoder, AC Huffman table 0
  $610 constant JPEG_HUFFENC_AC0_68     \ JPEG encoder, AC Huffman table 0
  $614 constant JPEG_HUFFENC_AC0_69     \ JPEG encoder, AC Huffman table 0
  $618 constant JPEG_HUFFENC_AC0_70     \ JPEG encoder, AC Huffman table 0
  $61C constant JPEG_HUFFENC_AC0_71     \ JPEG encoder, AC Huffman table 0
  $620 constant JPEG_HUFFENC_AC0_72     \ JPEG encoder, AC Huffman table 0
  $624 constant JPEG_HUFFENC_AC0_73     \ JPEG encoder, AC Huffman table 0
  $628 constant JPEG_HUFFENC_AC0_74     \ JPEG encoder, AC Huffman table 0
  $62C constant JPEG_HUFFENC_AC0_75     \ JPEG encoder, AC Huffman table 0
  $630 constant JPEG_HUFFENC_AC0_76     \ JPEG encoder, AC Huffman table 0
  $634 constant JPEG_HUFFENC_AC0_77     \ JPEG encoder, AC Huffman table 0
  $638 constant JPEG_HUFFENC_AC0_78     \ JPEG encoder, AC Huffman table 0
  $63C constant JPEG_HUFFENC_AC0_79     \ JPEG encoder, AC Huffman table 0
  $640 constant JPEG_HUFFENC_AC0_80     \ JPEG encoder, AC Huffman table 0
  $644 constant JPEG_HUFFENC_AC0_81     \ JPEG encoder, AC Huffman table 0
  $648 constant JPEG_HUFFENC_AC0_82     \ JPEG encoder, AC Huffman table 0
  $64C constant JPEG_HUFFENC_AC0_83     \ JPEG encoder, AC Huffman table 0
  $650 constant JPEG_HUFFENC_AC0_84     \ JPEG encoder, AC Huffman table 0
  $654 constant JPEG_HUFFENC_AC0_85     \ JPEG encoder, AC Huffman table 0
  $658 constant JPEG_HUFFENC_AC0_86     \ JPEG encoder, AC Huffman table 0
  $65C constant JPEG_HUFFENC_AC0_87     \ JPEG encoder, AC Huffman table 0
  $660 constant JPEG_HUFFENC_AC1_0      \ JPEG encoder, AC Huffman table 1
  $664 constant JPEG_HUFFENC_AC1_1      \ JPEG encoder, AC Huffman table 1
  $668 constant JPEG_HUFFENC_AC1_2      \ JPEG encoder, AC Huffman table 1
  $66C constant JPEG_HUFFENC_AC1_3      \ JPEG encoder, AC Huffman table 1
  $670 constant JPEG_HUFFENC_AC1_4      \ JPEG encoder, AC Huffman table 1
  $674 constant JPEG_HUFFENC_AC1_5      \ JPEG encoder, AC Huffman table 1
  $678 constant JPEG_HUFFENC_AC1_6      \ JPEG encoder, AC Huffman table 1
  $67C constant JPEG_HUFFENC_AC1_7      \ JPEG encoder, AC Huffman table 1
  $680 constant JPEG_HUFFENC_AC1_8      \ JPEG encoder, AC Huffman table 1
  $684 constant JPEG_HUFFENC_AC1_9      \ JPEG encoder, AC Huffman table 1
  $688 constant JPEG_HUFFENC_AC1_10     \ JPEG encoder, AC Huffman table 1
  $68C constant JPEG_HUFFENC_AC1_11     \ JPEG encoder, AC Huffman table 1
  $690 constant JPEG_HUFFENC_AC1_12     \ JPEG encoder, AC Huffman table 1
  $694 constant JPEG_HUFFENC_AC1_13     \ JPEG encoder, AC Huffman table 1
  $698 constant JPEG_HUFFENC_AC1_14     \ JPEG encoder, AC Huffman table 1
  $69C constant JPEG_HUFFENC_AC1_15     \ JPEG encoder, AC Huffman table 1
  $6A0 constant JPEG_HUFFENC_AC1_16     \ JPEG encoder, AC Huffman table 1
  $6A4 constant JPEG_HUFFENC_AC1_17     \ JPEG encoder, AC Huffman table 1
  $6A8 constant JPEG_HUFFENC_AC1_18     \ JPEG encoder, AC Huffman table 1
  $6AC constant JPEG_HUFFENC_AC1_19     \ JPEG encoder, AC Huffman table 1
  $6B0 constant JPEG_HUFFENC_AC1_20     \ JPEG encoder, AC Huffman table 1
  $6B4 constant JPEG_HUFFENC_AC1_21     \ JPEG encoder, AC Huffman table 1
  $6B8 constant JPEG_HUFFENC_AC1_22     \ JPEG encoder, AC Huffman table 1
  $6BC constant JPEG_HUFFENC_AC1_23     \ JPEG encoder, AC Huffman table 1
  $6C0 constant JPEG_HUFFENC_AC1_24     \ JPEG encoder, AC Huffman table 1
  $6C4 constant JPEG_HUFFENC_AC1_25     \ JPEG encoder, AC Huffman table 1
  $6C8 constant JPEG_HUFFENC_AC1_26     \ JPEG encoder, AC Huffman table 1
  $6CC constant JPEG_HUFFENC_AC1_27     \ JPEG encoder, AC Huffman table 1
  $6D0 constant JPEG_HUFFENC_AC1_28     \ JPEG encoder, AC Huffman table 1
  $6D4 constant JPEG_HUFFENC_AC1_29     \ JPEG encoder, AC Huffman table 1
  $6D8 constant JPEG_HUFFENC_AC1_30     \ JPEG encoder, AC Huffman table 1
  $6DC constant JPEG_HUFFENC_AC1_31     \ JPEG encoder, AC Huffman table 1
  $6E0 constant JPEG_HUFFENC_AC1_32     \ JPEG encoder, AC Huffman table 1
  $6E4 constant JPEG_HUFFENC_AC1_33     \ JPEG encoder, AC Huffman table 1
  $6E8 constant JPEG_HUFFENC_AC1_34     \ JPEG encoder, AC Huffman table 1
  $6EC constant JPEG_HUFFENC_AC1_35     \ JPEG encoder, AC Huffman table 1
  $6F0 constant JPEG_HUFFENC_AC1_36     \ JPEG encoder, AC Huffman table 1
  $6F4 constant JPEG_HUFFENC_AC1_37     \ JPEG encoder, AC Huffman table 1
  $6F8 constant JPEG_HUFFENC_AC1_38     \ JPEG encoder, AC Huffman table 1
  $6FC constant JPEG_HUFFENC_AC1_39     \ JPEG encoder, AC Huffman table 1
  $700 constant JPEG_HUFFENC_AC1_40     \ JPEG encoder, AC Huffman table 1
  $704 constant JPEG_HUFFENC_AC1_41     \ JPEG encoder, AC Huffman table 1
  $708 constant JPEG_HUFFENC_AC1_42     \ JPEG encoder, AC Huffman table 1
  $70C constant JPEG_HUFFENC_AC1_43     \ JPEG encoder, AC Huffman table 1
  $710 constant JPEG_HUFFENC_AC1_44     \ JPEG encoder, AC Huffman table 1
  $714 constant JPEG_HUFFENC_AC1_45     \ JPEG encoder, AC Huffman table 1
  $718 constant JPEG_HUFFENC_AC1_46     \ JPEG encoder, AC Huffman table 1
  $71C constant JPEG_HUFFENC_AC1_47     \ JPEG encoder, AC Huffman table 1
  $720 constant JPEG_HUFFENC_AC1_48     \ JPEG encoder, AC Huffman table 1
  $724 constant JPEG_HUFFENC_AC1_49     \ JPEG encoder, AC Huffman table 1
  $728 constant JPEG_HUFFENC_AC1_50     \ JPEG encoder, AC Huffman table 1
  $72C constant JPEG_HUFFENC_AC1_51     \ JPEG encoder, AC Huffman table 1
  $730 constant JPEG_HUFFENC_AC1_52     \ JPEG encoder, AC Huffman table 1
  $734 constant JPEG_HUFFENC_AC1_53     \ JPEG encoder, AC Huffman table 1
  $738 constant JPEG_HUFFENC_AC1_54     \ JPEG encoder, AC Huffman table 1
  $73C constant JPEG_HUFFENC_AC1_55     \ JPEG encoder, AC Huffman table 1
  $740 constant JPEG_HUFFENC_AC1_56     \ JPEG encoder, AC Huffman table 1
  $744 constant JPEG_HUFFENC_AC1_57     \ JPEG encoder, AC Huffman table 1
  $748 constant JPEG_HUFFENC_AC1_58     \ JPEG encoder, AC Huffman table 1
  $74C constant JPEG_HUFFENC_AC1_59     \ JPEG encoder, AC Huffman table 1
  $750 constant JPEG_HUFFENC_AC1_60     \ JPEG encoder, AC Huffman table 1
  $754 constant JPEG_HUFFENC_AC1_61     \ JPEG encoder, AC Huffman table 1
  $758 constant JPEG_HUFFENC_AC1_62     \ JPEG encoder, AC Huffman table 1
  $75C constant JPEG_HUFFENC_AC1_63     \ JPEG encoder, AC Huffman table 1
  $760 constant JPEG_HUFFENC_AC1_64     \ JPEG encoder, AC Huffman table 1
  $764 constant JPEG_HUFFENC_AC1_65     \ JPEG encoder, AC Huffman table 1
  $768 constant JPEG_HUFFENC_AC1_66     \ JPEG encoder, AC Huffman table 1
  $76C constant JPEG_HUFFENC_AC1_67     \ JPEG encoder, AC Huffman table 1
  $770 constant JPEG_HUFFENC_AC1_68     \ JPEG encoder, AC Huffman table 1
  $774 constant JPEG_HUFFENC_AC1_69     \ JPEG encoder, AC Huffman table 1
  $778 constant JPEG_HUFFENC_AC1_70     \ JPEG encoder, AC Huffman table 1
  $77C constant JPEG_HUFFENC_AC1_71     \ JPEG encoder, AC Huffman table 1
  $780 constant JPEG_HUFFENC_AC1_72     \ JPEG encoder, AC Huffman table 1
  $784 constant JPEG_HUFFENC_AC1_73     \ JPEG encoder, AC Huffman table 1
  $788 constant JPEG_HUFFENC_AC1_74     \ JPEG encoder, AC Huffman table 1
  $78C constant JPEG_HUFFENC_AC1_75     \ JPEG encoder, AC Huffman table 1
  $790 constant JPEG_HUFFENC_AC1_76     \ JPEG encoder, AC Huffman table 1
  $794 constant JPEG_HUFFENC_AC1_77     \ JPEG encoder, AC Huffman table 1
  $798 constant JPEG_HUFFENC_AC1_78     \ JPEG encoder, AC Huffman table 1
  $79C constant JPEG_HUFFENC_AC1_79     \ JPEG encoder, AC Huffman table 1
  $7A0 constant JPEG_HUFFENC_AC1_80     \ JPEG encoder, AC Huffman table 1
  $7A4 constant JPEG_HUFFENC_AC1_81     \ JPEG encoder, AC Huffman table 1
  $7A8 constant JPEG_HUFFENC_AC1_82     \ JPEG encoder, AC Huffman table 1
  $7AC constant JPEG_HUFFENC_AC1_83     \ JPEG encoder, AC Huffman table 1
  $7B0 constant JPEG_HUFFENC_AC1_84     \ JPEG encoder, AC Huffman table 1
  $7B4 constant JPEG_HUFFENC_AC1_85     \ JPEG encoder, AC Huffman table 1
  $7B8 constant JPEG_HUFFENC_AC1_86     \ JPEG encoder, AC Huffman table 1
  $7BC constant JPEG_HUFFENC_AC1_87     \ JPEG encoder, AC Huffman table 1
  $7C0 constant JPEG_HUFFENC_DC0_0      \ JPEG encoder, DC Huffman table 0
  $7C4 constant JPEG_HUFFENC_DC0_1      \ JPEG encoder, DC Huffman table 0
  $7C8 constant JPEG_HUFFENC_DC0_2      \ JPEG encoder, DC Huffman table 0
  $7CC constant JPEG_HUFFENC_DC0_3      \ JPEG encoder, DC Huffman table 0
  $7D0 constant JPEG_HUFFENC_DC0_4      \ JPEG encoder, DC Huffman table 0
  $7D4 constant JPEG_HUFFENC_DC0_5      \ JPEG encoder, DC Huffman table 0
  $7D8 constant JPEG_HUFFENC_DC0_6      \ JPEG encoder, DC Huffman table 0
  $7DC constant JPEG_HUFFENC_DC0_7      \ JPEG encoder, DC Huffman table 0
  $7E0 constant JPEG_HUFFENC_DC1_0      \ JPEG encoder, DC Huffman table 1
  $7E4 constant JPEG_HUFFENC_DC1_1      \ JPEG encoder, DC Huffman table 1
  $7E8 constant JPEG_HUFFENC_DC1_2      \ JPEG encoder, DC Huffman table 1
  $7EC constant JPEG_HUFFENC_DC1_3      \ JPEG encoder, DC Huffman table 1
  $7F0 constant JPEG_HUFFENC_DC1_4      \ JPEG encoder, DC Huffman table 1
  $7F4 constant JPEG_HUFFENC_DC1_5      \ JPEG encoder, DC Huffman table 1
  $7F8 constant JPEG_HUFFENC_DC1_6      \ JPEG encoder, DC Huffman table 1
  $7FC constant JPEG_HUFFENC_DC1_7      \ JPEG encoder, DC Huffman table 1

: JPEG_DEF ; [then]
