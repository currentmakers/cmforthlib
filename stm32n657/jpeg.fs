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
    \ @brief JPEG codec control register
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
    $03 constant JPEG_DE                        \ [0x03] Codec operation as coder or decoder
    $04 constant JPEG_COLSPACE                  \ [0x04 : 2] Color space
    $06 constant JPEG_NS                        \ [0x06 : 2] Number of components for scan
    $08 constant JPEG_HDR                       \ [0x08] Header processing
    $10 constant JPEG_YSIZE                     \ [0x10 : 16] Y Size
  [then]


  [ifdef] JPEG_JPEG_CONFR2_DEF
    \
    \ @brief JPEG codec configuration register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_NMCU                      \ [0x00 : 26] Number of MCUs
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
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization table
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of blocks
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical sampling factor
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal sampling factor
  [then]


  [ifdef] JPEG_JPEG_CONFR5_DEF
    \
    \ @brief JPEG codec configuration register 5
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HD                        \ [0x00] Huffman DC
    $01 constant JPEG_HA                        \ [0x01] Huffman AC
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization table
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of blocks
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical sampling factor
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal sampling factor
  [then]


  [ifdef] JPEG_JPEG_CONFR6_DEF
    \
    \ @brief JPEG codec configuration register 6
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HD                        \ [0x00] Huffman DC
    $01 constant JPEG_HA                        \ [0x01] Huffman AC
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization table
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of blocks
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical sampling factor
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal sampling factor
  [then]


  [ifdef] JPEG_JPEG_CONFR7_DEF
    \
    \ @brief JPEG codec configuration register 7
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HD                        \ [0x00] Huffman DC
    $01 constant JPEG_HA                        \ [0x01] Huffman AC
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization table
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of blocks
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical sampling factor
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal sampling factor
  [then]


  [ifdef] JPEG_JPEG_CR_DEF
    \
    \ @brief JPEG control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_JCEN                      \ [0x00] JPEG core enable
    $01 constant JPEG_IFTIE                     \ [0x01] Input FIFO threshold interrupt enable
    $02 constant JPEG_IFNFIE                    \ [0x02] Input FIFO not full interrupt enable
    $03 constant JPEG_OFTIE                     \ [0x03] Output FIFO threshold interrupt enable
    $04 constant JPEG_OFNEIE                    \ [0x04] Output FIFO not empty interrupt enable
    $05 constant JPEG_EOCIE                     \ [0x05] End of conversion interrupt enable
    $06 constant JPEG_HPDIE                     \ [0x06] Header parsing done interrupt enable
    $0b constant JPEG_IDMAEN                    \ [0x0b] Input DMA enable
    $0c constant JPEG_ODMAEN                    \ [0x0c] Output DMA enable
    $0d constant JPEG_IFF                       \ [0x0d] Input FIFO flush
    $0e constant JPEG_OFF                       \ [0x0e] Output FIFO flush
  [then]


  [ifdef] JPEG_JPEG_SR_DEF
    \
    \ @brief JPEG status register
    \ Address offset: 0x34
    \ Reset value: 0x00000006
    \
    $01 constant JPEG_IFTF                      \ [0x01] Input FIFO threshold flag
    $02 constant JPEG_IFNFF                     \ [0x02] Input FIFO not full flag
    $03 constant JPEG_OFTF                      \ [0x03] Output FIFO threshold flag
    $04 constant JPEG_OFNEF                     \ [0x04] Output FIFO not empty flag
    $05 constant JPEG_EOCF                      \ [0x05] End of conversion flag
    $06 constant JPEG_HPDF                      \ [0x06] Header parsing done flag
    $07 constant JPEG_COF                       \ [0x07] Codec operation flag
  [then]


  [ifdef] JPEG_JPEG_CFR_DEF
    \
    \ @brief JPEG clear flag register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $05 constant JPEG_CEOCF                     \ [0x05] Clear end of conversion flag
    $06 constant JPEG_CHPDF                     \ [0x06] Clear header parsing done flag
  [then]


  [ifdef] JPEG_JPEG_DIR_DEF
    \
    \ @brief JPEG data input register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATAIN                    \ [0x00 : 32] Data input FIFO
  [then]


  [ifdef] JPEG_JPEG_DOR_DEF
    \
    \ @brief JPEG data output register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATAOUT                   \ [0x00 : 32] Data output FIFO
  [then]


  [ifdef] JPEG_JPEG_QMEM0_0_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF0                    \ [0x00 : 8] Quantization coefficient 0
    $08 constant JPEG_QCOEF1                    \ [0x08 : 8] Quantization coefficient 1
    $10 constant JPEG_QCOEF2                    \ [0x10 : 8] Quantization coefficient 2
    $18 constant JPEG_QCOEF3                    \ [0x18 : 8] Quantization coefficient 3
  [then]


  [ifdef] JPEG_JPEG_QMEM0_1_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF4                    \ [0x00 : 8] Quantization coefficient 4
    $08 constant JPEG_QCOEF5                    \ [0x08 : 8] Quantization coefficient 5
    $10 constant JPEG_QCOEF6                    \ [0x10 : 8] Quantization coefficient 6
    $18 constant JPEG_QCOEF7                    \ [0x18 : 8] Quantization coefficient 7
  [then]


  [ifdef] JPEG_JPEG_QMEM0_2_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF8                    \ [0x00 : 8] Quantization coefficient 8
    $08 constant JPEG_QCOEF9                    \ [0x08 : 8] Quantization coefficient 9
    $10 constant JPEG_QCOEF10                   \ [0x10 : 8] Quantization coefficient 10
    $18 constant JPEG_QCOEF11                   \ [0x18 : 8] Quantization coefficient 11
  [then]


  [ifdef] JPEG_JPEG_QMEM0_3_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF12                   \ [0x00 : 8] Quantization coefficient 12
    $08 constant JPEG_QCOEF13                   \ [0x08 : 8] Quantization coefficient 13
    $10 constant JPEG_QCOEF14                   \ [0x10 : 8] Quantization coefficient 14
    $18 constant JPEG_QCOEF15                   \ [0x18 : 8] Quantization coefficient 15
  [then]


  [ifdef] JPEG_JPEG_QMEM0_4_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF16                   \ [0x00 : 8] Quantization coefficient 16
    $08 constant JPEG_QCOEF17                   \ [0x08 : 8] Quantization coefficient 17
    $10 constant JPEG_QCOEF18                   \ [0x10 : 8] Quantization coefficient 18
    $18 constant JPEG_QCOEF19                   \ [0x18 : 8] Quantization coefficient 19
  [then]


  [ifdef] JPEG_JPEG_QMEM0_5_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF20                   \ [0x00 : 8] Quantization coefficient 20
    $08 constant JPEG_QCOEF21                   \ [0x08 : 8] Quantization coefficient 21
    $10 constant JPEG_QCOEF22                   \ [0x10 : 8] Quantization coefficient 22
    $18 constant JPEG_QCOEF23                   \ [0x18 : 8] Quantization coefficient 23
  [then]


  [ifdef] JPEG_JPEG_QMEM0_6_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF24                   \ [0x00 : 8] Quantization coefficient 24
    $08 constant JPEG_QCOEF25                   \ [0x08 : 8] Quantization coefficient 25
    $10 constant JPEG_QCOEF26                   \ [0x10 : 8] Quantization coefficient 26
    $18 constant JPEG_QCOEF27                   \ [0x18 : 8] Quantization coefficient 27
  [then]


  [ifdef] JPEG_JPEG_QMEM0_7_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF28                   \ [0x00 : 8] Quantization coefficient 28
    $08 constant JPEG_QCOEF29                   \ [0x08 : 8] Quantization coefficient 29
    $10 constant JPEG_QCOEF30                   \ [0x10 : 8] Quantization coefficient 30
    $18 constant JPEG_QCOEF31                   \ [0x18 : 8] Quantization coefficient 31
  [then]


  [ifdef] JPEG_JPEG_QMEM0_8_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF32                   \ [0x00 : 8] Quantization coefficient 32
    $08 constant JPEG_QCOEF33                   \ [0x08 : 8] Quantization coefficient 33
    $10 constant JPEG_QCOEF34                   \ [0x10 : 8] Quantization coefficient 34
    $18 constant JPEG_QCOEF35                   \ [0x18 : 8] Quantization coefficient 35
  [then]


  [ifdef] JPEG_JPEG_QMEM0_9_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF36                   \ [0x00 : 8] Quantization coefficient 36
    $08 constant JPEG_QCOEF37                   \ [0x08 : 8] Quantization coefficient 37
    $10 constant JPEG_QCOEF38                   \ [0x10 : 8] Quantization coefficient 38
    $18 constant JPEG_QCOEF39                   \ [0x18 : 8] Quantization coefficient 39
  [then]


  [ifdef] JPEG_JPEG_QMEM0_10_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF40                   \ [0x00 : 8] Quantization coefficient 40
    $08 constant JPEG_QCOEF41                   \ [0x08 : 8] Quantization coefficient 41
    $10 constant JPEG_QCOEF42                   \ [0x10 : 8] Quantization coefficient 42
    $18 constant JPEG_QCOEF43                   \ [0x18 : 8] Quantization coefficient 43
  [then]


  [ifdef] JPEG_JPEG_QMEM0_11_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF44                   \ [0x00 : 8] Quantization coefficient 44
    $08 constant JPEG_QCOEF45                   \ [0x08 : 8] Quantization coefficient 45
    $10 constant JPEG_QCOEF46                   \ [0x10 : 8] Quantization coefficient 46
    $18 constant JPEG_QCOEF47                   \ [0x18 : 8] Quantization coefficient 47
  [then]


  [ifdef] JPEG_JPEG_QMEM0_12_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF48                   \ [0x00 : 8] Quantization coefficient 48
    $08 constant JPEG_QCOEF49                   \ [0x08 : 8] Quantization coefficient 49
    $10 constant JPEG_QCOEF50                   \ [0x10 : 8] Quantization coefficient 50
    $18 constant JPEG_QCOEF51                   \ [0x18 : 8] Quantization coefficient 51
  [then]


  [ifdef] JPEG_JPEG_QMEM0_13_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF52                   \ [0x00 : 8] Quantization coefficient 52
    $08 constant JPEG_QCOEF53                   \ [0x08 : 8] Quantization coefficient 53
    $10 constant JPEG_QCOEF54                   \ [0x10 : 8] Quantization coefficient 54
    $18 constant JPEG_QCOEF55                   \ [0x18 : 8] Quantization coefficient 55
  [then]


  [ifdef] JPEG_JPEG_QMEM0_14_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF56                   \ [0x00 : 8] Quantization coefficient 56
    $08 constant JPEG_QCOEF57                   \ [0x08 : 8] Quantization coefficient 57
    $10 constant JPEG_QCOEF58                   \ [0x10 : 8] Quantization coefficient 58
    $18 constant JPEG_QCOEF59                   \ [0x18 : 8] Quantization coefficient 59
  [then]


  [ifdef] JPEG_JPEG_QMEM0_15_DEF
    \
    \ @brief JPEG quantization memory 0
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF60                   \ [0x00 : 8] Quantization coefficient 60
    $08 constant JPEG_QCOEF61                   \ [0x08 : 8] Quantization coefficient 61
    $10 constant JPEG_QCOEF62                   \ [0x10 : 8] Quantization coefficient 62
    $18 constant JPEG_QCOEF63                   \ [0x18 : 8] Quantization coefficient 63
  [then]


  [ifdef] JPEG_JPEG_QMEM1_0_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF0                    \ [0x00 : 8] Quantization coefficient 0
    $08 constant JPEG_QCOEF1                    \ [0x08 : 8] Quantization coefficient 1
    $10 constant JPEG_QCOEF2                    \ [0x10 : 8] Quantization coefficient 2
    $18 constant JPEG_QCOEF3                    \ [0x18 : 8] Quantization coefficient 3
  [then]


  [ifdef] JPEG_JPEG_QMEM1_1_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF4                    \ [0x00 : 8] Quantization coefficient 4
    $08 constant JPEG_QCOEF5                    \ [0x08 : 8] Quantization coefficient 5
    $10 constant JPEG_QCOEF6                    \ [0x10 : 8] Quantization coefficient 6
    $18 constant JPEG_QCOEF7                    \ [0x18 : 8] Quantization coefficient 7
  [then]


  [ifdef] JPEG_JPEG_QMEM1_2_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF8                    \ [0x00 : 8] Quantization coefficient 8
    $08 constant JPEG_QCOEF9                    \ [0x08 : 8] Quantization coefficient 9
    $10 constant JPEG_QCOEF10                   \ [0x10 : 8] Quantization coefficient 10
    $18 constant JPEG_QCOEF11                   \ [0x18 : 8] Quantization coefficient 11
  [then]


  [ifdef] JPEG_JPEG_QMEM1_3_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF12                   \ [0x00 : 8] Quantization coefficient 12
    $08 constant JPEG_QCOEF13                   \ [0x08 : 8] Quantization coefficient 13
    $10 constant JPEG_QCOEF14                   \ [0x10 : 8] Quantization coefficient 14
    $18 constant JPEG_QCOEF15                   \ [0x18 : 8] Quantization coefficient 15
  [then]


  [ifdef] JPEG_JPEG_QMEM1_4_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF16                   \ [0x00 : 8] Quantization coefficient 16
    $08 constant JPEG_QCOEF17                   \ [0x08 : 8] Quantization coefficient 17
    $10 constant JPEG_QCOEF18                   \ [0x10 : 8] Quantization coefficient 18
    $18 constant JPEG_QCOEF19                   \ [0x18 : 8] Quantization coefficient 19
  [then]


  [ifdef] JPEG_JPEG_QMEM1_5_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF20                   \ [0x00 : 8] Quantization coefficient 20
    $08 constant JPEG_QCOEF21                   \ [0x08 : 8] Quantization coefficient 21
    $10 constant JPEG_QCOEF22                   \ [0x10 : 8] Quantization coefficient 22
    $18 constant JPEG_QCOEF23                   \ [0x18 : 8] Quantization coefficient 23
  [then]


  [ifdef] JPEG_JPEG_QMEM1_6_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF24                   \ [0x00 : 8] Quantization coefficient 24
    $08 constant JPEG_QCOEF25                   \ [0x08 : 8] Quantization coefficient 25
    $10 constant JPEG_QCOEF26                   \ [0x10 : 8] Quantization coefficient 26
    $18 constant JPEG_QCOEF27                   \ [0x18 : 8] Quantization coefficient 27
  [then]


  [ifdef] JPEG_JPEG_QMEM1_7_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF28                   \ [0x00 : 8] Quantization coefficient 28
    $08 constant JPEG_QCOEF29                   \ [0x08 : 8] Quantization coefficient 29
    $10 constant JPEG_QCOEF30                   \ [0x10 : 8] Quantization coefficient 30
    $18 constant JPEG_QCOEF31                   \ [0x18 : 8] Quantization coefficient 31
  [then]


  [ifdef] JPEG_JPEG_QMEM1_8_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF32                   \ [0x00 : 8] Quantization coefficient 32
    $08 constant JPEG_QCOEF33                   \ [0x08 : 8] Quantization coefficient 33
    $10 constant JPEG_QCOEF34                   \ [0x10 : 8] Quantization coefficient 34
    $18 constant JPEG_QCOEF35                   \ [0x18 : 8] Quantization coefficient 35
  [then]


  [ifdef] JPEG_JPEG_QMEM1_9_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF36                   \ [0x00 : 8] Quantization coefficient 36
    $08 constant JPEG_QCOEF37                   \ [0x08 : 8] Quantization coefficient 37
    $10 constant JPEG_QCOEF38                   \ [0x10 : 8] Quantization coefficient 38
    $18 constant JPEG_QCOEF39                   \ [0x18 : 8] Quantization coefficient 39
  [then]


  [ifdef] JPEG_JPEG_QMEM1_10_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF40                   \ [0x00 : 8] Quantization coefficient 40
    $08 constant JPEG_QCOEF41                   \ [0x08 : 8] Quantization coefficient 41
    $10 constant JPEG_QCOEF42                   \ [0x10 : 8] Quantization coefficient 42
    $18 constant JPEG_QCOEF43                   \ [0x18 : 8] Quantization coefficient 43
  [then]


  [ifdef] JPEG_JPEG_QMEM1_11_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF44                   \ [0x00 : 8] Quantization coefficient 44
    $08 constant JPEG_QCOEF45                   \ [0x08 : 8] Quantization coefficient 45
    $10 constant JPEG_QCOEF46                   \ [0x10 : 8] Quantization coefficient 46
    $18 constant JPEG_QCOEF47                   \ [0x18 : 8] Quantization coefficient 47
  [then]


  [ifdef] JPEG_JPEG_QMEM1_12_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF48                   \ [0x00 : 8] Quantization coefficient 48
    $08 constant JPEG_QCOEF49                   \ [0x08 : 8] Quantization coefficient 49
    $10 constant JPEG_QCOEF50                   \ [0x10 : 8] Quantization coefficient 50
    $18 constant JPEG_QCOEF51                   \ [0x18 : 8] Quantization coefficient 51
  [then]


  [ifdef] JPEG_JPEG_QMEM1_13_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF52                   \ [0x00 : 8] Quantization coefficient 52
    $08 constant JPEG_QCOEF53                   \ [0x08 : 8] Quantization coefficient 53
    $10 constant JPEG_QCOEF54                   \ [0x10 : 8] Quantization coefficient 54
    $18 constant JPEG_QCOEF55                   \ [0x18 : 8] Quantization coefficient 55
  [then]


  [ifdef] JPEG_JPEG_QMEM1_14_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF56                   \ [0x00 : 8] Quantization coefficient 56
    $08 constant JPEG_QCOEF57                   \ [0x08 : 8] Quantization coefficient 57
    $10 constant JPEG_QCOEF58                   \ [0x10 : 8] Quantization coefficient 58
    $18 constant JPEG_QCOEF59                   \ [0x18 : 8] Quantization coefficient 59
  [then]


  [ifdef] JPEG_JPEG_QMEM1_15_DEF
    \
    \ @brief JPEG quantization memory 1
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF60                   \ [0x00 : 8] Quantization coefficient 60
    $08 constant JPEG_QCOEF61                   \ [0x08 : 8] Quantization coefficient 61
    $10 constant JPEG_QCOEF62                   \ [0x10 : 8] Quantization coefficient 62
    $18 constant JPEG_QCOEF63                   \ [0x18 : 8] Quantization coefficient 63
  [then]


  [ifdef] JPEG_JPEG_QMEM2_0_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF0                    \ [0x00 : 8] Quantization coefficient 0
    $08 constant JPEG_QCOEF1                    \ [0x08 : 8] Quantization coefficient 1
    $10 constant JPEG_QCOEF2                    \ [0x10 : 8] Quantization coefficient 2
    $18 constant JPEG_QCOEF3                    \ [0x18 : 8] Quantization coefficient 3
  [then]


  [ifdef] JPEG_JPEG_QMEM2_1_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF4                    \ [0x00 : 8] Quantization coefficient 4
    $08 constant JPEG_QCOEF5                    \ [0x08 : 8] Quantization coefficient 5
    $10 constant JPEG_QCOEF6                    \ [0x10 : 8] Quantization coefficient 6
    $18 constant JPEG_QCOEF7                    \ [0x18 : 8] Quantization coefficient 7
  [then]


  [ifdef] JPEG_JPEG_QMEM2_2_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF8                    \ [0x00 : 8] Quantization coefficient 8
    $08 constant JPEG_QCOEF9                    \ [0x08 : 8] Quantization coefficient 9
    $10 constant JPEG_QCOEF10                   \ [0x10 : 8] Quantization coefficient 10
    $18 constant JPEG_QCOEF11                   \ [0x18 : 8] Quantization coefficient 11
  [then]


  [ifdef] JPEG_JPEG_QMEM2_3_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF12                   \ [0x00 : 8] Quantization coefficient 12
    $08 constant JPEG_QCOEF13                   \ [0x08 : 8] Quantization coefficient 13
    $10 constant JPEG_QCOEF14                   \ [0x10 : 8] Quantization coefficient 14
    $18 constant JPEG_QCOEF15                   \ [0x18 : 8] Quantization coefficient 15
  [then]


  [ifdef] JPEG_JPEG_QMEM2_4_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF16                   \ [0x00 : 8] Quantization coefficient 16
    $08 constant JPEG_QCOEF17                   \ [0x08 : 8] Quantization coefficient 17
    $10 constant JPEG_QCOEF18                   \ [0x10 : 8] Quantization coefficient 18
    $18 constant JPEG_QCOEF19                   \ [0x18 : 8] Quantization coefficient 19
  [then]


  [ifdef] JPEG_JPEG_QMEM2_5_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF20                   \ [0x00 : 8] Quantization coefficient 20
    $08 constant JPEG_QCOEF21                   \ [0x08 : 8] Quantization coefficient 21
    $10 constant JPEG_QCOEF22                   \ [0x10 : 8] Quantization coefficient 22
    $18 constant JPEG_QCOEF23                   \ [0x18 : 8] Quantization coefficient 23
  [then]


  [ifdef] JPEG_JPEG_QMEM2_6_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF24                   \ [0x00 : 8] Quantization coefficient 24
    $08 constant JPEG_QCOEF25                   \ [0x08 : 8] Quantization coefficient 25
    $10 constant JPEG_QCOEF26                   \ [0x10 : 8] Quantization coefficient 26
    $18 constant JPEG_QCOEF27                   \ [0x18 : 8] Quantization coefficient 27
  [then]


  [ifdef] JPEG_JPEG_QMEM2_7_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF28                   \ [0x00 : 8] Quantization coefficient 28
    $08 constant JPEG_QCOEF29                   \ [0x08 : 8] Quantization coefficient 29
    $10 constant JPEG_QCOEF30                   \ [0x10 : 8] Quantization coefficient 30
    $18 constant JPEG_QCOEF31                   \ [0x18 : 8] Quantization coefficient 31
  [then]


  [ifdef] JPEG_JPEG_QMEM2_8_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF32                   \ [0x00 : 8] Quantization coefficient 32
    $08 constant JPEG_QCOEF33                   \ [0x08 : 8] Quantization coefficient 33
    $10 constant JPEG_QCOEF34                   \ [0x10 : 8] Quantization coefficient 34
    $18 constant JPEG_QCOEF35                   \ [0x18 : 8] Quantization coefficient 35
  [then]


  [ifdef] JPEG_JPEG_QMEM2_9_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF36                   \ [0x00 : 8] Quantization coefficient 36
    $08 constant JPEG_QCOEF37                   \ [0x08 : 8] Quantization coefficient 37
    $10 constant JPEG_QCOEF38                   \ [0x10 : 8] Quantization coefficient 38
    $18 constant JPEG_QCOEF39                   \ [0x18 : 8] Quantization coefficient 39
  [then]


  [ifdef] JPEG_JPEG_QMEM2_10_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF40                   \ [0x00 : 8] Quantization coefficient 40
    $08 constant JPEG_QCOEF41                   \ [0x08 : 8] Quantization coefficient 41
    $10 constant JPEG_QCOEF42                   \ [0x10 : 8] Quantization coefficient 42
    $18 constant JPEG_QCOEF43                   \ [0x18 : 8] Quantization coefficient 43
  [then]


  [ifdef] JPEG_JPEG_QMEM2_11_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF44                   \ [0x00 : 8] Quantization coefficient 44
    $08 constant JPEG_QCOEF45                   \ [0x08 : 8] Quantization coefficient 45
    $10 constant JPEG_QCOEF46                   \ [0x10 : 8] Quantization coefficient 46
    $18 constant JPEG_QCOEF47                   \ [0x18 : 8] Quantization coefficient 47
  [then]


  [ifdef] JPEG_JPEG_QMEM2_12_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF48                   \ [0x00 : 8] Quantization coefficient 48
    $08 constant JPEG_QCOEF49                   \ [0x08 : 8] Quantization coefficient 49
    $10 constant JPEG_QCOEF50                   \ [0x10 : 8] Quantization coefficient 50
    $18 constant JPEG_QCOEF51                   \ [0x18 : 8] Quantization coefficient 51
  [then]


  [ifdef] JPEG_JPEG_QMEM2_13_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF52                   \ [0x00 : 8] Quantization coefficient 52
    $08 constant JPEG_QCOEF53                   \ [0x08 : 8] Quantization coefficient 53
    $10 constant JPEG_QCOEF54                   \ [0x10 : 8] Quantization coefficient 54
    $18 constant JPEG_QCOEF55                   \ [0x18 : 8] Quantization coefficient 55
  [then]


  [ifdef] JPEG_JPEG_QMEM2_14_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF56                   \ [0x00 : 8] Quantization coefficient 56
    $08 constant JPEG_QCOEF57                   \ [0x08 : 8] Quantization coefficient 57
    $10 constant JPEG_QCOEF58                   \ [0x10 : 8] Quantization coefficient 58
    $18 constant JPEG_QCOEF59                   \ [0x18 : 8] Quantization coefficient 59
  [then]


  [ifdef] JPEG_JPEG_QMEM2_15_DEF
    \
    \ @brief JPEG quantization memory 2
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF60                   \ [0x00 : 8] Quantization coefficient 60
    $08 constant JPEG_QCOEF61                   \ [0x08 : 8] Quantization coefficient 61
    $10 constant JPEG_QCOEF62                   \ [0x10 : 8] Quantization coefficient 62
    $18 constant JPEG_QCOEF63                   \ [0x18 : 8] Quantization coefficient 63
  [then]


  [ifdef] JPEG_JPEG_QMEM3_0_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF0                    \ [0x00 : 8] Quantization coefficient 0
    $08 constant JPEG_QCOEF1                    \ [0x08 : 8] Quantization coefficient 1
    $10 constant JPEG_QCOEF2                    \ [0x10 : 8] Quantization coefficient 2
    $18 constant JPEG_QCOEF3                    \ [0x18 : 8] Quantization coefficient 3
  [then]


  [ifdef] JPEG_JPEG_QMEM3_1_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF4                    \ [0x00 : 8] Quantization coefficient 4
    $08 constant JPEG_QCOEF5                    \ [0x08 : 8] Quantization coefficient 5
    $10 constant JPEG_QCOEF6                    \ [0x10 : 8] Quantization coefficient 6
    $18 constant JPEG_QCOEF7                    \ [0x18 : 8] Quantization coefficient 7
  [then]


  [ifdef] JPEG_JPEG_QMEM3_2_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF8                    \ [0x00 : 8] Quantization coefficient 8
    $08 constant JPEG_QCOEF9                    \ [0x08 : 8] Quantization coefficient 9
    $10 constant JPEG_QCOEF10                   \ [0x10 : 8] Quantization coefficient 10
    $18 constant JPEG_QCOEF11                   \ [0x18 : 8] Quantization coefficient 11
  [then]


  [ifdef] JPEG_JPEG_QMEM3_3_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF12                   \ [0x00 : 8] Quantization coefficient 12
    $08 constant JPEG_QCOEF13                   \ [0x08 : 8] Quantization coefficient 13
    $10 constant JPEG_QCOEF14                   \ [0x10 : 8] Quantization coefficient 14
    $18 constant JPEG_QCOEF15                   \ [0x18 : 8] Quantization coefficient 15
  [then]


  [ifdef] JPEG_JPEG_QMEM3_4_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF16                   \ [0x00 : 8] Quantization coefficient 16
    $08 constant JPEG_QCOEF17                   \ [0x08 : 8] Quantization coefficient 17
    $10 constant JPEG_QCOEF18                   \ [0x10 : 8] Quantization coefficient 18
    $18 constant JPEG_QCOEF19                   \ [0x18 : 8] Quantization coefficient 19
  [then]


  [ifdef] JPEG_JPEG_QMEM3_5_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF20                   \ [0x00 : 8] Quantization coefficient 20
    $08 constant JPEG_QCOEF21                   \ [0x08 : 8] Quantization coefficient 21
    $10 constant JPEG_QCOEF22                   \ [0x10 : 8] Quantization coefficient 22
    $18 constant JPEG_QCOEF23                   \ [0x18 : 8] Quantization coefficient 23
  [then]


  [ifdef] JPEG_JPEG_QMEM3_6_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF24                   \ [0x00 : 8] Quantization coefficient 24
    $08 constant JPEG_QCOEF25                   \ [0x08 : 8] Quantization coefficient 25
    $10 constant JPEG_QCOEF26                   \ [0x10 : 8] Quantization coefficient 26
    $18 constant JPEG_QCOEF27                   \ [0x18 : 8] Quantization coefficient 27
  [then]


  [ifdef] JPEG_JPEG_QMEM3_7_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF28                   \ [0x00 : 8] Quantization coefficient 28
    $08 constant JPEG_QCOEF29                   \ [0x08 : 8] Quantization coefficient 29
    $10 constant JPEG_QCOEF30                   \ [0x10 : 8] Quantization coefficient 30
    $18 constant JPEG_QCOEF31                   \ [0x18 : 8] Quantization coefficient 31
  [then]


  [ifdef] JPEG_JPEG_QMEM3_8_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF32                   \ [0x00 : 8] Quantization coefficient 32
    $08 constant JPEG_QCOEF33                   \ [0x08 : 8] Quantization coefficient 33
    $10 constant JPEG_QCOEF34                   \ [0x10 : 8] Quantization coefficient 34
    $18 constant JPEG_QCOEF35                   \ [0x18 : 8] Quantization coefficient 35
  [then]


  [ifdef] JPEG_JPEG_QMEM3_9_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF36                   \ [0x00 : 8] Quantization coefficient 36
    $08 constant JPEG_QCOEF37                   \ [0x08 : 8] Quantization coefficient 37
    $10 constant JPEG_QCOEF38                   \ [0x10 : 8] Quantization coefficient 38
    $18 constant JPEG_QCOEF39                   \ [0x18 : 8] Quantization coefficient 39
  [then]


  [ifdef] JPEG_JPEG_QMEM3_10_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF40                   \ [0x00 : 8] Quantization coefficient 40
    $08 constant JPEG_QCOEF41                   \ [0x08 : 8] Quantization coefficient 41
    $10 constant JPEG_QCOEF42                   \ [0x10 : 8] Quantization coefficient 42
    $18 constant JPEG_QCOEF43                   \ [0x18 : 8] Quantization coefficient 43
  [then]


  [ifdef] JPEG_JPEG_QMEM3_11_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF44                   \ [0x00 : 8] Quantization coefficient 44
    $08 constant JPEG_QCOEF45                   \ [0x08 : 8] Quantization coefficient 45
    $10 constant JPEG_QCOEF46                   \ [0x10 : 8] Quantization coefficient 46
    $18 constant JPEG_QCOEF47                   \ [0x18 : 8] Quantization coefficient 47
  [then]


  [ifdef] JPEG_JPEG_QMEM3_12_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF48                   \ [0x00 : 8] Quantization coefficient 48
    $08 constant JPEG_QCOEF49                   \ [0x08 : 8] Quantization coefficient 49
    $10 constant JPEG_QCOEF50                   \ [0x10 : 8] Quantization coefficient 50
    $18 constant JPEG_QCOEF51                   \ [0x18 : 8] Quantization coefficient 51
  [then]


  [ifdef] JPEG_JPEG_QMEM3_13_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF52                   \ [0x00 : 8] Quantization coefficient 52
    $08 constant JPEG_QCOEF53                   \ [0x08 : 8] Quantization coefficient 53
    $10 constant JPEG_QCOEF54                   \ [0x10 : 8] Quantization coefficient 54
    $18 constant JPEG_QCOEF55                   \ [0x18 : 8] Quantization coefficient 55
  [then]


  [ifdef] JPEG_JPEG_QMEM3_14_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF56                   \ [0x00 : 8] Quantization coefficient 56
    $08 constant JPEG_QCOEF57                   \ [0x08 : 8] Quantization coefficient 57
    $10 constant JPEG_QCOEF58                   \ [0x10 : 8] Quantization coefficient 58
    $18 constant JPEG_QCOEF59                   \ [0x18 : 8] Quantization coefficient 59
  [then]


  [ifdef] JPEG_JPEG_QMEM3_15_DEF
    \
    \ @brief JPEG quantization memory 3
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_QCOEF60                   \ [0x00 : 8] Quantization coefficient 60
    $08 constant JPEG_QCOEF61                   \ [0x08 : 8] Quantization coefficient 61
    $10 constant JPEG_QCOEF62                   \ [0x10 : 8] Quantization coefficient 62
    $18 constant JPEG_QCOEF63                   \ [0x18 : 8] Quantization coefficient 63
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN0_0_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA0                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN0_1_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA0                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN0_2_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA0                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN0_3_DEF
    \
    \ @brief JPEG Huffman min 0
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA0                     \ [0x00 : 4] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN1_0_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA1                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN1_1_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA1                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN1_2_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA1                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN1_3_DEF
    \
    \ @brief JPEG Huffman min 1
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA1                     \ [0x00 : 4] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN2_0_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA2                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN2_1_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA2                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN2_2_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA2                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN2_3_DEF
    \
    \ @brief JPEG Huffman min 2
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA2                     \ [0x00 : 4] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN3_0_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA3                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN3_1_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA3                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN3_2_DEF
    \
    \ @brief JPEG Huffman min
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA3                     \ [0x00 : 32] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFMIN3_3_DEF
    \
    \ @brief JPEG Huffman min 3
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA3                     \ [0x00 : 4] Minimum Huffman value
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE0_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA0                     \ [0x00 : 9] Data 0
    $10 constant JPEG_DATA1                     \ [0x10 : 9] Data 1
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE1_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA2                     \ [0x00 : 9] Data 2
    $10 constant JPEG_DATA3                     \ [0x10 : 9] Data 3
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE2_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA4                     \ [0x00 : 9] Data 4
    $10 constant JPEG_DATA5                     \ [0x10 : 9] Data 5
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE3_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA6                     \ [0x00 : 9] Data 6
    $10 constant JPEG_DATA7                     \ [0x10 : 9] Data 7
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE4_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA8                     \ [0x00 : 9] Data 8
    $10 constant JPEG_DATA9                     \ [0x10 : 9] Data 9
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE5_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA10                    \ [0x00 : 9] Data 10
    $10 constant JPEG_DATA11                    \ [0x10 : 9] Data 11
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE6_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA12                    \ [0x00 : 9] Data 12
    $10 constant JPEG_DATA13                    \ [0x10 : 9] Data 13
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE7_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA14                    \ [0x00 : 9] Data 14
    $10 constant JPEG_DATA15                    \ [0x10 : 9] Data 15
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE8_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA16                    \ [0x00 : 9] Data 16
    $10 constant JPEG_DATA17                    \ [0x10 : 9] Data 17
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE9_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA18                    \ [0x00 : 9] Data 18
    $10 constant JPEG_DATA19                    \ [0x10 : 9] Data 19
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE10_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA20                    \ [0x00 : 9] Data 20
    $10 constant JPEG_DATA21                    \ [0x10 : 9] Data 21
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE11_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA22                    \ [0x00 : 9] Data 22
    $10 constant JPEG_DATA23                    \ [0x10 : 9] Data 23
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE12_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA24                    \ [0x00 : 9] Data 24
    $10 constant JPEG_DATA25                    \ [0x10 : 9] Data 25
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE13_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA26                    \ [0x00 : 9] Data 26
    $10 constant JPEG_DATA27                    \ [0x10 : 9] Data 27
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE14_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA28                    \ [0x00 : 9] Data 28
    $10 constant JPEG_DATA29                    \ [0x10 : 9] Data 29
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE15_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA30                    \ [0x00 : 9] Data 30
    $10 constant JPEG_DATA31                    \ [0x10 : 9] Data 31
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE16_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA32                    \ [0x00 : 9] Data 32
    $10 constant JPEG_DATA33                    \ [0x10 : 9] Data 33
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE17_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA34                    \ [0x00 : 9] Data 34
    $10 constant JPEG_DATA35                    \ [0x10 : 9] Data 35
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE18_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA36                    \ [0x00 : 9] Data 36
    $10 constant JPEG_DATA37                    \ [0x10 : 9] Data 37
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE19_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA38                    \ [0x00 : 9] Data 38
    $10 constant JPEG_DATA39                    \ [0x10 : 9] Data 39
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE20_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA40                    \ [0x00 : 9] Data 40
    $10 constant JPEG_DATA41                    \ [0x10 : 9] Data 41
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE21_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA42                    \ [0x00 : 9] Data 42
    $10 constant JPEG_DATA43                    \ [0x10 : 9] Data 43
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE22_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA44                    \ [0x00 : 9] Data 44
    $10 constant JPEG_DATA45                    \ [0x10 : 9] Data 45
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE23_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA46                    \ [0x00 : 9] Data 46
    $10 constant JPEG_DATA47                    \ [0x10 : 9] Data 47
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE24_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA48                    \ [0x00 : 9] Data 48
    $10 constant JPEG_DATA49                    \ [0x10 : 9] Data 49
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE25_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA50                    \ [0x00 : 9] Data 50
    $10 constant JPEG_DATA51                    \ [0x10 : 9] Data 51
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE26_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA52                    \ [0x00 : 9] Data 52
    $10 constant JPEG_DATA53                    \ [0x10 : 9] Data 53
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE27_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x1FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA54                    \ [0x00 : 9] Data 54
    $10 constant JPEG_DATA55                    \ [0x10 : 9] Data 55
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE28_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA56                    \ [0x00 : 9] Data 56
    $10 constant JPEG_DATA57                    \ [0x10 : 9] Data 57
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE29_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA58                    \ [0x00 : 9] Data 58
    $10 constant JPEG_DATA59                    \ [0x10 : 9] Data 59
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE30_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA60                    \ [0x00 : 9] Data 60
    $10 constant JPEG_DATA61                    \ [0x10 : 9] Data 61
  [then]


  [ifdef] JPEG_JPEG_HUFFBASE31_DEF
    \
    \ @brief JPEG Huffman base
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA62                    \ [0x00 : 9] Data 62
    $10 constant JPEG_DATA63                    \ [0x10 : 9] Data 63
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB0_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA0                     \ [0x00 : 8] Data 0
    $08 constant JPEG_DATA1                     \ [0x08 : 8] Data 1
    $10 constant JPEG_DATA2                     \ [0x10 : 8] Data 2
    $18 constant JPEG_DATA3                     \ [0x18 : 8] Data 3
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB1_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA4                     \ [0x00 : 8] Data 4
    $08 constant JPEG_DATA5                     \ [0x08 : 8] Data 5
    $10 constant JPEG_DATA6                     \ [0x10 : 8] Data 6
    $18 constant JPEG_DATA7                     \ [0x18 : 8] Data 7
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB2_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA8                     \ [0x00 : 8] Data 8
    $08 constant JPEG_DATA9                     \ [0x08 : 8] Data 9
    $10 constant JPEG_DATA10                    \ [0x10 : 8] Data 10
    $18 constant JPEG_DATA11                    \ [0x18 : 8] Data 11
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB3_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA12                    \ [0x00 : 8] Data 12
    $08 constant JPEG_DATA13                    \ [0x08 : 8] Data 13
    $10 constant JPEG_DATA14                    \ [0x10 : 8] Data 14
    $18 constant JPEG_DATA15                    \ [0x18 : 8] Data 15
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB4_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA16                    \ [0x00 : 8] Data 16
    $08 constant JPEG_DATA17                    \ [0x08 : 8] Data 17
    $10 constant JPEG_DATA18                    \ [0x10 : 8] Data 18
    $18 constant JPEG_DATA19                    \ [0x18 : 8] Data 19
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB5_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA20                    \ [0x00 : 8] Data 20
    $08 constant JPEG_DATA21                    \ [0x08 : 8] Data 21
    $10 constant JPEG_DATA22                    \ [0x10 : 8] Data 22
    $18 constant JPEG_DATA23                    \ [0x18 : 8] Data 23
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB6_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA24                    \ [0x00 : 8] Data 24
    $08 constant JPEG_DATA25                    \ [0x08 : 8] Data 25
    $10 constant JPEG_DATA26                    \ [0x10 : 8] Data 26
    $18 constant JPEG_DATA27                    \ [0x18 : 8] Data 27
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB7_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA28                    \ [0x00 : 8] Data 28
    $08 constant JPEG_DATA29                    \ [0x08 : 8] Data 29
    $10 constant JPEG_DATA30                    \ [0x10 : 8] Data 30
    $18 constant JPEG_DATA31                    \ [0x18 : 8] Data 31
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB8_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA32                    \ [0x00 : 8] Data 32
    $08 constant JPEG_DATA33                    \ [0x08 : 8] Data 33
    $10 constant JPEG_DATA34                    \ [0x10 : 8] Data 34
    $18 constant JPEG_DATA35                    \ [0x18 : 8] Data 35
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB9_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA36                    \ [0x00 : 8] Data 36
    $08 constant JPEG_DATA37                    \ [0x08 : 8] Data 37
    $10 constant JPEG_DATA38                    \ [0x10 : 8] Data 38
    $18 constant JPEG_DATA39                    \ [0x18 : 8] Data 39
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB10_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA40                    \ [0x00 : 8] Data 40
    $08 constant JPEG_DATA41                    \ [0x08 : 8] Data 41
    $10 constant JPEG_DATA42                    \ [0x10 : 8] Data 42
    $18 constant JPEG_DATA43                    \ [0x18 : 8] Data 43
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB11_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x23C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA44                    \ [0x00 : 8] Data 44
    $08 constant JPEG_DATA45                    \ [0x08 : 8] Data 45
    $10 constant JPEG_DATA46                    \ [0x10 : 8] Data 46
    $18 constant JPEG_DATA47                    \ [0x18 : 8] Data 47
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB12_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA48                    \ [0x00 : 8] Data 48
    $08 constant JPEG_DATA49                    \ [0x08 : 8] Data 49
    $10 constant JPEG_DATA50                    \ [0x10 : 8] Data 50
    $18 constant JPEG_DATA51                    \ [0x18 : 8] Data 51
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB13_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA52                    \ [0x00 : 8] Data 52
    $08 constant JPEG_DATA53                    \ [0x08 : 8] Data 53
    $10 constant JPEG_DATA54                    \ [0x10 : 8] Data 54
    $18 constant JPEG_DATA55                    \ [0x18 : 8] Data 55
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB14_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA56                    \ [0x00 : 8] Data 56
    $08 constant JPEG_DATA57                    \ [0x08 : 8] Data 57
    $10 constant JPEG_DATA58                    \ [0x10 : 8] Data 58
    $18 constant JPEG_DATA59                    \ [0x18 : 8] Data 59
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB15_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA60                    \ [0x00 : 8] Data 60
    $08 constant JPEG_DATA61                    \ [0x08 : 8] Data 61
    $10 constant JPEG_DATA62                    \ [0x10 : 8] Data 62
    $18 constant JPEG_DATA63                    \ [0x18 : 8] Data 63
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB16_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA64                    \ [0x00 : 8] Data 64
    $08 constant JPEG_DATA65                    \ [0x08 : 8] Data 65
    $10 constant JPEG_DATA66                    \ [0x10 : 8] Data 66
    $18 constant JPEG_DATA67                    \ [0x18 : 8] Data 67
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB17_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA68                    \ [0x00 : 8] Data 68
    $08 constant JPEG_DATA69                    \ [0x08 : 8] Data 69
    $10 constant JPEG_DATA70                    \ [0x10 : 8] Data 70
    $18 constant JPEG_DATA71                    \ [0x18 : 8] Data 71
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB18_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA72                    \ [0x00 : 8] Data 72
    $08 constant JPEG_DATA73                    \ [0x08 : 8] Data 73
    $10 constant JPEG_DATA74                    \ [0x10 : 8] Data 74
    $18 constant JPEG_DATA75                    \ [0x18 : 8] Data 75
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB19_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA76                    \ [0x00 : 8] Data 76
    $08 constant JPEG_DATA77                    \ [0x08 : 8] Data 77
    $10 constant JPEG_DATA78                    \ [0x10 : 8] Data 78
    $18 constant JPEG_DATA79                    \ [0x18 : 8] Data 79
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB20_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA80                    \ [0x00 : 8] Data 80
    $08 constant JPEG_DATA81                    \ [0x08 : 8] Data 81
    $10 constant JPEG_DATA82                    \ [0x10 : 8] Data 82
    $18 constant JPEG_DATA83                    \ [0x18 : 8] Data 83
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB21_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA84                    \ [0x00 : 8] Data 84
    $08 constant JPEG_DATA85                    \ [0x08 : 8] Data 85
    $10 constant JPEG_DATA86                    \ [0x10 : 8] Data 86
    $18 constant JPEG_DATA87                    \ [0x18 : 8] Data 87
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB22_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA88                    \ [0x00 : 8] Data 88
    $08 constant JPEG_DATA89                    \ [0x08 : 8] Data 89
    $10 constant JPEG_DATA90                    \ [0x10 : 8] Data 90
    $18 constant JPEG_DATA91                    \ [0x18 : 8] Data 91
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB23_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA92                    \ [0x00 : 8] Data 92
    $08 constant JPEG_DATA93                    \ [0x08 : 8] Data 93
    $10 constant JPEG_DATA94                    \ [0x10 : 8] Data 94
    $18 constant JPEG_DATA95                    \ [0x18 : 8] Data 95
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB24_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA96                    \ [0x00 : 8] Data 96
    $08 constant JPEG_DATA97                    \ [0x08 : 8] Data 97
    $10 constant JPEG_DATA98                    \ [0x10 : 8] Data 98
    $18 constant JPEG_DATA99                    \ [0x18 : 8] Data 99
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB25_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA100                   \ [0x00 : 8] Data 100
    $08 constant JPEG_DATA101                   \ [0x08 : 8] Data 101
    $10 constant JPEG_DATA102                   \ [0x10 : 8] Data 102
    $18 constant JPEG_DATA103                   \ [0x18 : 8] Data 103
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB26_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x278
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA104                   \ [0x00 : 8] Data 104
    $08 constant JPEG_DATA105                   \ [0x08 : 8] Data 105
    $10 constant JPEG_DATA106                   \ [0x10 : 8] Data 106
    $18 constant JPEG_DATA107                   \ [0x18 : 8] Data 107
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB27_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA108                   \ [0x00 : 8] Data 108
    $08 constant JPEG_DATA109                   \ [0x08 : 8] Data 109
    $10 constant JPEG_DATA110                   \ [0x10 : 8] Data 110
    $18 constant JPEG_DATA111                   \ [0x18 : 8] Data 111
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB28_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA112                   \ [0x00 : 8] Data 112
    $08 constant JPEG_DATA113                   \ [0x08 : 8] Data 113
    $10 constant JPEG_DATA114                   \ [0x10 : 8] Data 114
    $18 constant JPEG_DATA115                   \ [0x18 : 8] Data 115
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB29_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA116                   \ [0x00 : 8] Data 116
    $08 constant JPEG_DATA117                   \ [0x08 : 8] Data 117
    $10 constant JPEG_DATA118                   \ [0x10 : 8] Data 118
    $18 constant JPEG_DATA119                   \ [0x18 : 8] Data 119
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB30_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA120                   \ [0x00 : 8] Data 120
    $08 constant JPEG_DATA121                   \ [0x08 : 8] Data 121
    $10 constant JPEG_DATA122                   \ [0x10 : 8] Data 122
    $18 constant JPEG_DATA123                   \ [0x18 : 8] Data 123
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB31_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA124                   \ [0x00 : 8] Data 124
    $08 constant JPEG_DATA125                   \ [0x08 : 8] Data 125
    $10 constant JPEG_DATA126                   \ [0x10 : 8] Data 126
    $18 constant JPEG_DATA127                   \ [0x18 : 8] Data 127
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB32_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA128                   \ [0x00 : 8] Data 128
    $08 constant JPEG_DATA129                   \ [0x08 : 8] Data 129
    $10 constant JPEG_DATA130                   \ [0x10 : 8] Data 130
    $18 constant JPEG_DATA131                   \ [0x18 : 8] Data 131
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB33_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA132                   \ [0x00 : 8] Data 132
    $08 constant JPEG_DATA133                   \ [0x08 : 8] Data 133
    $10 constant JPEG_DATA134                   \ [0x10 : 8] Data 134
    $18 constant JPEG_DATA135                   \ [0x18 : 8] Data 135
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB34_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA136                   \ [0x00 : 8] Data 136
    $08 constant JPEG_DATA137                   \ [0x08 : 8] Data 137
    $10 constant JPEG_DATA138                   \ [0x10 : 8] Data 138
    $18 constant JPEG_DATA139                   \ [0x18 : 8] Data 139
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB35_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA140                   \ [0x00 : 8] Data 140
    $08 constant JPEG_DATA141                   \ [0x08 : 8] Data 141
    $10 constant JPEG_DATA142                   \ [0x10 : 8] Data 142
    $18 constant JPEG_DATA143                   \ [0x18 : 8] Data 143
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB36_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA144                   \ [0x00 : 8] Data 144
    $08 constant JPEG_DATA145                   \ [0x08 : 8] Data 145
    $10 constant JPEG_DATA146                   \ [0x10 : 8] Data 146
    $18 constant JPEG_DATA147                   \ [0x18 : 8] Data 147
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB37_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA148                   \ [0x00 : 8] Data 148
    $08 constant JPEG_DATA149                   \ [0x08 : 8] Data 149
    $10 constant JPEG_DATA150                   \ [0x10 : 8] Data 150
    $18 constant JPEG_DATA151                   \ [0x18 : 8] Data 151
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB38_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA152                   \ [0x00 : 8] Data 152
    $08 constant JPEG_DATA153                   \ [0x08 : 8] Data 153
    $10 constant JPEG_DATA154                   \ [0x10 : 8] Data 154
    $18 constant JPEG_DATA155                   \ [0x18 : 8] Data 155
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB39_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA156                   \ [0x00 : 8] Data 156
    $08 constant JPEG_DATA157                   \ [0x08 : 8] Data 157
    $10 constant JPEG_DATA158                   \ [0x10 : 8] Data 158
    $18 constant JPEG_DATA159                   \ [0x18 : 8] Data 159
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB40_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA160                   \ [0x00 : 8] Data 160
    $08 constant JPEG_DATA161                   \ [0x08 : 8] Data 161
    $10 constant JPEG_DATA162                   \ [0x10 : 8] Data 162
    $18 constant JPEG_DATA163                   \ [0x18 : 8] Data 163
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB41_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA164                   \ [0x00 : 8] Data 164
    $08 constant JPEG_DATA165                   \ [0x08 : 8] Data 165
    $10 constant JPEG_DATA166                   \ [0x10 : 8] Data 166
    $18 constant JPEG_DATA167                   \ [0x18 : 8] Data 167
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB42_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA168                   \ [0x00 : 8] Data 168
    $08 constant JPEG_DATA169                   \ [0x08 : 8] Data 169
    $10 constant JPEG_DATA170                   \ [0x10 : 8] Data 170
    $18 constant JPEG_DATA171                   \ [0x18 : 8] Data 171
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB43_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA172                   \ [0x00 : 8] Data 172
    $08 constant JPEG_DATA173                   \ [0x08 : 8] Data 173
    $10 constant JPEG_DATA174                   \ [0x10 : 8] Data 174
    $18 constant JPEG_DATA175                   \ [0x18 : 8] Data 175
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB44_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA176                   \ [0x00 : 8] Data 176
    $08 constant JPEG_DATA177                   \ [0x08 : 8] Data 177
    $10 constant JPEG_DATA178                   \ [0x10 : 8] Data 178
    $18 constant JPEG_DATA179                   \ [0x18 : 8] Data 179
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB45_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA180                   \ [0x00 : 8] Data 180
    $08 constant JPEG_DATA181                   \ [0x08 : 8] Data 181
    $10 constant JPEG_DATA182                   \ [0x10 : 8] Data 182
    $18 constant JPEG_DATA183                   \ [0x18 : 8] Data 183
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB46_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA184                   \ [0x00 : 8] Data 184
    $08 constant JPEG_DATA185                   \ [0x08 : 8] Data 185
    $10 constant JPEG_DATA186                   \ [0x10 : 8] Data 186
    $18 constant JPEG_DATA187                   \ [0x18 : 8] Data 187
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB47_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA188                   \ [0x00 : 8] Data 188
    $08 constant JPEG_DATA189                   \ [0x08 : 8] Data 189
    $10 constant JPEG_DATA190                   \ [0x10 : 8] Data 190
    $18 constant JPEG_DATA191                   \ [0x18 : 8] Data 191
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB48_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA192                   \ [0x00 : 8] Data 192
    $08 constant JPEG_DATA193                   \ [0x08 : 8] Data 193
    $10 constant JPEG_DATA194                   \ [0x10 : 8] Data 194
    $18 constant JPEG_DATA195                   \ [0x18 : 8] Data 195
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB49_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA196                   \ [0x00 : 8] Data 196
    $08 constant JPEG_DATA197                   \ [0x08 : 8] Data 197
    $10 constant JPEG_DATA198                   \ [0x10 : 8] Data 198
    $18 constant JPEG_DATA199                   \ [0x18 : 8] Data 199
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB50_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA200                   \ [0x00 : 8] Data 200
    $08 constant JPEG_DATA201                   \ [0x08 : 8] Data 201
    $10 constant JPEG_DATA202                   \ [0x10 : 8] Data 202
    $18 constant JPEG_DATA203                   \ [0x18 : 8] Data 203
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB51_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA204                   \ [0x00 : 8] Data 204
    $08 constant JPEG_DATA205                   \ [0x08 : 8] Data 205
    $10 constant JPEG_DATA206                   \ [0x10 : 8] Data 206
    $18 constant JPEG_DATA207                   \ [0x18 : 8] Data 207
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB52_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA208                   \ [0x00 : 8] Data 208
    $08 constant JPEG_DATA209                   \ [0x08 : 8] Data 209
    $10 constant JPEG_DATA210                   \ [0x10 : 8] Data 210
    $18 constant JPEG_DATA211                   \ [0x18 : 8] Data 211
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB53_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA212                   \ [0x00 : 8] Data 212
    $08 constant JPEG_DATA213                   \ [0x08 : 8] Data 213
    $10 constant JPEG_DATA214                   \ [0x10 : 8] Data 214
    $18 constant JPEG_DATA215                   \ [0x18 : 8] Data 215
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB54_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA216                   \ [0x00 : 8] Data 216
    $08 constant JPEG_DATA217                   \ [0x08 : 8] Data 217
    $10 constant JPEG_DATA218                   \ [0x10 : 8] Data 218
    $18 constant JPEG_DATA219                   \ [0x18 : 8] Data 219
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB55_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA220                   \ [0x00 : 8] Data 220
    $08 constant JPEG_DATA221                   \ [0x08 : 8] Data 221
    $10 constant JPEG_DATA222                   \ [0x10 : 8] Data 222
    $18 constant JPEG_DATA223                   \ [0x18 : 8] Data 223
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB56_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA224                   \ [0x00 : 8] Data 224
    $08 constant JPEG_DATA225                   \ [0x08 : 8] Data 225
    $10 constant JPEG_DATA226                   \ [0x10 : 8] Data 226
    $18 constant JPEG_DATA227                   \ [0x18 : 8] Data 227
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB57_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA228                   \ [0x00 : 8] Data 228
    $08 constant JPEG_DATA229                   \ [0x08 : 8] Data 229
    $10 constant JPEG_DATA230                   \ [0x10 : 8] Data 230
    $18 constant JPEG_DATA231                   \ [0x18 : 8] Data 231
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB58_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA232                   \ [0x00 : 8] Data 232
    $08 constant JPEG_DATA233                   \ [0x08 : 8] Data 233
    $10 constant JPEG_DATA234                   \ [0x10 : 8] Data 234
    $18 constant JPEG_DATA235                   \ [0x18 : 8] Data 235
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB59_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x2FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA236                   \ [0x00 : 8] Data 236
    $08 constant JPEG_DATA237                   \ [0x08 : 8] Data 237
    $10 constant JPEG_DATA238                   \ [0x10 : 8] Data 238
    $18 constant JPEG_DATA239                   \ [0x18 : 8] Data 239
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB60_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA240                   \ [0x00 : 8] Data 240
    $08 constant JPEG_DATA241                   \ [0x08 : 8] Data 241
    $10 constant JPEG_DATA242                   \ [0x10 : 8] Data 242
    $18 constant JPEG_DATA243                   \ [0x18 : 8] Data 243
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB61_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA244                   \ [0x00 : 8] Data 244
    $08 constant JPEG_DATA245                   \ [0x08 : 8] Data 245
    $10 constant JPEG_DATA246                   \ [0x10 : 8] Data 246
    $18 constant JPEG_DATA247                   \ [0x18 : 8] Data 247
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB62_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA248                   \ [0x00 : 8] Data 248
    $08 constant JPEG_DATA249                   \ [0x08 : 8] Data 249
    $10 constant JPEG_DATA250                   \ [0x10 : 8] Data 250
    $18 constant JPEG_DATA251                   \ [0x18 : 8] Data 251
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB63_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA252                   \ [0x00 : 8] Data 252
    $08 constant JPEG_DATA253                   \ [0x08 : 8] Data 253
    $10 constant JPEG_DATA254                   \ [0x10 : 8] Data 254
    $18 constant JPEG_DATA255                   \ [0x18 : 8] Data 255
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB64_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA256                   \ [0x00 : 8] Data 256
    $08 constant JPEG_DATA257                   \ [0x08 : 8] Data 257
    $10 constant JPEG_DATA258                   \ [0x10 : 8] Data 258
    $18 constant JPEG_DATA259                   \ [0x18 : 8] Data 259
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB65_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA260                   \ [0x00 : 8] Data 260
    $08 constant JPEG_DATA261                   \ [0x08 : 8] Data 261
    $10 constant JPEG_DATA262                   \ [0x10 : 8] Data 262
    $18 constant JPEG_DATA263                   \ [0x18 : 8] Data 263
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB66_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA264                   \ [0x00 : 8] Data 264
    $08 constant JPEG_DATA265                   \ [0x08 : 8] Data 265
    $10 constant JPEG_DATA266                   \ [0x10 : 8] Data 266
    $18 constant JPEG_DATA267                   \ [0x18 : 8] Data 267
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB67_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA268                   \ [0x00 : 8] Data 268
    $08 constant JPEG_DATA269                   \ [0x08 : 8] Data 269
    $10 constant JPEG_DATA270                   \ [0x10 : 8] Data 270
    $18 constant JPEG_DATA271                   \ [0x18 : 8] Data 271
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB68_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA272                   \ [0x00 : 8] Data 272
    $08 constant JPEG_DATA273                   \ [0x08 : 8] Data 273
    $10 constant JPEG_DATA274                   \ [0x10 : 8] Data 274
    $18 constant JPEG_DATA275                   \ [0x18 : 8] Data 275
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB69_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA276                   \ [0x00 : 8] Data 276
    $08 constant JPEG_DATA277                   \ [0x08 : 8] Data 277
    $10 constant JPEG_DATA278                   \ [0x10 : 8] Data 278
    $18 constant JPEG_DATA279                   \ [0x18 : 8] Data 279
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB70_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA280                   \ [0x00 : 8] Data 280
    $08 constant JPEG_DATA281                   \ [0x08 : 8] Data 281
    $10 constant JPEG_DATA282                   \ [0x10 : 8] Data 282
    $18 constant JPEG_DATA283                   \ [0x18 : 8] Data 283
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB71_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA284                   \ [0x00 : 8] Data 284
    $08 constant JPEG_DATA285                   \ [0x08 : 8] Data 285
    $10 constant JPEG_DATA286                   \ [0x10 : 8] Data 286
    $18 constant JPEG_DATA287                   \ [0x18 : 8] Data 287
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB72_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA288                   \ [0x00 : 8] Data 288
    $08 constant JPEG_DATA289                   \ [0x08 : 8] Data 289
    $10 constant JPEG_DATA290                   \ [0x10 : 8] Data 290
    $18 constant JPEG_DATA291                   \ [0x18 : 8] Data 291
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB73_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA292                   \ [0x00 : 8] Data 292
    $08 constant JPEG_DATA293                   \ [0x08 : 8] Data 293
    $10 constant JPEG_DATA294                   \ [0x10 : 8] Data 294
    $18 constant JPEG_DATA295                   \ [0x18 : 8] Data 295
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB74_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x338
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA296                   \ [0x00 : 8] Data 296
    $08 constant JPEG_DATA297                   \ [0x08 : 8] Data 297
    $10 constant JPEG_DATA298                   \ [0x10 : 8] Data 298
    $18 constant JPEG_DATA299                   \ [0x18 : 8] Data 299
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB75_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x33C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA300                   \ [0x00 : 8] Data 300
    $08 constant JPEG_DATA301                   \ [0x08 : 8] Data 301
    $10 constant JPEG_DATA302                   \ [0x10 : 8] Data 302
    $18 constant JPEG_DATA303                   \ [0x18 : 8] Data 303
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB76_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA304                   \ [0x00 : 8] Data 304
    $08 constant JPEG_DATA305                   \ [0x08 : 8] Data 305
    $10 constant JPEG_DATA306                   \ [0x10 : 8] Data 306
    $18 constant JPEG_DATA307                   \ [0x18 : 8] Data 307
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB77_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x344
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA308                   \ [0x00 : 8] Data 308
    $08 constant JPEG_DATA309                   \ [0x08 : 8] Data 309
    $10 constant JPEG_DATA310                   \ [0x10 : 8] Data 310
    $18 constant JPEG_DATA311                   \ [0x18 : 8] Data 311
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB78_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x348
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA312                   \ [0x00 : 8] Data 312
    $08 constant JPEG_DATA313                   \ [0x08 : 8] Data 313
    $10 constant JPEG_DATA314                   \ [0x10 : 8] Data 314
    $18 constant JPEG_DATA315                   \ [0x18 : 8] Data 315
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB79_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA316                   \ [0x00 : 8] Data 316
    $08 constant JPEG_DATA317                   \ [0x08 : 8] Data 317
    $10 constant JPEG_DATA318                   \ [0x10 : 8] Data 318
    $18 constant JPEG_DATA319                   \ [0x18 : 8] Data 319
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB80_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA320                   \ [0x00 : 8] Data 320
    $08 constant JPEG_DATA321                   \ [0x08 : 8] Data 321
    $10 constant JPEG_DATA322                   \ [0x10 : 8] Data 322
    $18 constant JPEG_DATA323                   \ [0x18 : 8] Data 323
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB81_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x354
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA324                   \ [0x00 : 8] Data 324
    $08 constant JPEG_DATA325                   \ [0x08 : 8] Data 325
    $10 constant JPEG_DATA326                   \ [0x10 : 8] Data 326
    $18 constant JPEG_DATA327                   \ [0x18 : 8] Data 327
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB82_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x358
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA328                   \ [0x00 : 8] Data 328
    $08 constant JPEG_DATA329                   \ [0x08 : 8] Data 329
    $10 constant JPEG_DATA330                   \ [0x10 : 8] Data 330
    $18 constant JPEG_DATA331                   \ [0x18 : 8] Data 331
  [then]


  [ifdef] JPEG_JPEG_HUFFSYMB83_DEF
    \
    \ @brief JPEG Huffman symbol
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA332                   \ [0x00 : 8] Data 332
    $08 constant JPEG_DATA333                   \ [0x08 : 8] Data 333
    $10 constant JPEG_DATA334                   \ [0x10 : 8] Data 334
    $18 constant JPEG_DATA335                   \ [0x18 : 8] Data 335
  [then]


  [ifdef] JPEG_JPEG_DHTMEM0_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x360
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA0                     \ [0x00 : 8] Huffman table data 0
    $08 constant JPEG_DATA1                     \ [0x08 : 8] Huffman table data 1
    $10 constant JPEG_DATA2                     \ [0x10 : 8] Huffman table data 2
    $18 constant JPEG_DATA3                     \ [0x18 : 8] Huffman table data 3
  [then]


  [ifdef] JPEG_JPEG_DHTMEM1_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA4                     \ [0x00 : 8] Huffman table data 4
    $08 constant JPEG_DATA5                     \ [0x08 : 8] Huffman table data 5
    $10 constant JPEG_DATA6                     \ [0x10 : 8] Huffman table data 6
    $18 constant JPEG_DATA7                     \ [0x18 : 8] Huffman table data 7
  [then]


  [ifdef] JPEG_JPEG_DHTMEM2_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x368
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA8                     \ [0x00 : 8] Huffman table data 8
    $08 constant JPEG_DATA9                     \ [0x08 : 8] Huffman table data 9
    $10 constant JPEG_DATA10                    \ [0x10 : 8] Huffman table data 10
    $18 constant JPEG_DATA11                    \ [0x18 : 8] Huffman table data 11
  [then]


  [ifdef] JPEG_JPEG_DHTMEM3_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x36C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA12                    \ [0x00 : 8] Huffman table data 12
    $08 constant JPEG_DATA13                    \ [0x08 : 8] Huffman table data 13
    $10 constant JPEG_DATA14                    \ [0x10 : 8] Huffman table data 14
    $18 constant JPEG_DATA15                    \ [0x18 : 8] Huffman table data 15
  [then]


  [ifdef] JPEG_JPEG_DHTMEM4_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA16                    \ [0x00 : 8] Huffman table data 16
    $08 constant JPEG_DATA17                    \ [0x08 : 8] Huffman table data 17
    $10 constant JPEG_DATA18                    \ [0x10 : 8] Huffman table data 18
    $18 constant JPEG_DATA19                    \ [0x18 : 8] Huffman table data 19
  [then]


  [ifdef] JPEG_JPEG_DHTMEM5_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x374
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA20                    \ [0x00 : 8] Huffman table data 20
    $08 constant JPEG_DATA21                    \ [0x08 : 8] Huffman table data 21
    $10 constant JPEG_DATA22                    \ [0x10 : 8] Huffman table data 22
    $18 constant JPEG_DATA23                    \ [0x18 : 8] Huffman table data 23
  [then]


  [ifdef] JPEG_JPEG_DHTMEM6_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x378
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA24                    \ [0x00 : 8] Huffman table data 24
    $08 constant JPEG_DATA25                    \ [0x08 : 8] Huffman table data 25
    $10 constant JPEG_DATA26                    \ [0x10 : 8] Huffman table data 26
    $18 constant JPEG_DATA27                    \ [0x18 : 8] Huffman table data 27
  [then]


  [ifdef] JPEG_JPEG_DHTMEM7_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x37C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA28                    \ [0x00 : 8] Huffman table data 28
    $08 constant JPEG_DATA29                    \ [0x08 : 8] Huffman table data 29
    $10 constant JPEG_DATA30                    \ [0x10 : 8] Huffman table data 30
    $18 constant JPEG_DATA31                    \ [0x18 : 8] Huffman table data 31
  [then]


  [ifdef] JPEG_JPEG_DHTMEM8_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA32                    \ [0x00 : 8] Huffman table data 32
    $08 constant JPEG_DATA33                    \ [0x08 : 8] Huffman table data 33
    $10 constant JPEG_DATA34                    \ [0x10 : 8] Huffman table data 34
    $18 constant JPEG_DATA35                    \ [0x18 : 8] Huffman table data 35
  [then]


  [ifdef] JPEG_JPEG_DHTMEM9_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA36                    \ [0x00 : 8] Huffman table data 36
    $08 constant JPEG_DATA37                    \ [0x08 : 8] Huffman table data 37
    $10 constant JPEG_DATA38                    \ [0x10 : 8] Huffman table data 38
    $18 constant JPEG_DATA39                    \ [0x18 : 8] Huffman table data 39
  [then]


  [ifdef] JPEG_JPEG_DHTMEM10_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x388
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA40                    \ [0x00 : 8] Huffman table data 40
    $08 constant JPEG_DATA41                    \ [0x08 : 8] Huffman table data 41
    $10 constant JPEG_DATA42                    \ [0x10 : 8] Huffman table data 42
    $18 constant JPEG_DATA43                    \ [0x18 : 8] Huffman table data 43
  [then]


  [ifdef] JPEG_JPEG_DHTMEM11_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x38C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA44                    \ [0x00 : 8] Huffman table data 44
    $08 constant JPEG_DATA45                    \ [0x08 : 8] Huffman table data 45
    $10 constant JPEG_DATA46                    \ [0x10 : 8] Huffman table data 46
    $18 constant JPEG_DATA47                    \ [0x18 : 8] Huffman table data 47
  [then]


  [ifdef] JPEG_JPEG_DHTMEM12_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA48                    \ [0x00 : 8] Huffman table data 48
    $08 constant JPEG_DATA49                    \ [0x08 : 8] Huffman table data 49
    $10 constant JPEG_DATA50                    \ [0x10 : 8] Huffman table data 50
    $18 constant JPEG_DATA51                    \ [0x18 : 8] Huffman table data 51
  [then]


  [ifdef] JPEG_JPEG_DHTMEM13_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA52                    \ [0x00 : 8] Huffman table data 52
    $08 constant JPEG_DATA53                    \ [0x08 : 8] Huffman table data 53
    $10 constant JPEG_DATA54                    \ [0x10 : 8] Huffman table data 54
    $18 constant JPEG_DATA55                    \ [0x18 : 8] Huffman table data 55
  [then]


  [ifdef] JPEG_JPEG_DHTMEM14_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA56                    \ [0x00 : 8] Huffman table data 56
    $08 constant JPEG_DATA57                    \ [0x08 : 8] Huffman table data 57
    $10 constant JPEG_DATA58                    \ [0x10 : 8] Huffman table data 58
    $18 constant JPEG_DATA59                    \ [0x18 : 8] Huffman table data 59
  [then]


  [ifdef] JPEG_JPEG_DHTMEM15_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA60                    \ [0x00 : 8] Huffman table data 60
    $08 constant JPEG_DATA61                    \ [0x08 : 8] Huffman table data 61
    $10 constant JPEG_DATA62                    \ [0x10 : 8] Huffman table data 62
    $18 constant JPEG_DATA63                    \ [0x18 : 8] Huffman table data 63
  [then]


  [ifdef] JPEG_JPEG_DHTMEM16_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA64                    \ [0x00 : 8] Huffman table data 64
    $08 constant JPEG_DATA65                    \ [0x08 : 8] Huffman table data 65
    $10 constant JPEG_DATA66                    \ [0x10 : 8] Huffman table data 66
    $18 constant JPEG_DATA67                    \ [0x18 : 8] Huffman table data 67
  [then]


  [ifdef] JPEG_JPEG_DHTMEM17_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA68                    \ [0x00 : 8] Huffman table data 68
    $08 constant JPEG_DATA69                    \ [0x08 : 8] Huffman table data 69
    $10 constant JPEG_DATA70                    \ [0x10 : 8] Huffman table data 70
    $18 constant JPEG_DATA71                    \ [0x18 : 8] Huffman table data 71
  [then]


  [ifdef] JPEG_JPEG_DHTMEM18_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA72                    \ [0x00 : 8] Huffman table data 72
    $08 constant JPEG_DATA73                    \ [0x08 : 8] Huffman table data 73
    $10 constant JPEG_DATA74                    \ [0x10 : 8] Huffman table data 74
    $18 constant JPEG_DATA75                    \ [0x18 : 8] Huffman table data 75
  [then]


  [ifdef] JPEG_JPEG_DHTMEM19_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA76                    \ [0x00 : 8] Huffman table data 76
    $08 constant JPEG_DATA77                    \ [0x08 : 8] Huffman table data 77
    $10 constant JPEG_DATA78                    \ [0x10 : 8] Huffman table data 78
    $18 constant JPEG_DATA79                    \ [0x18 : 8] Huffman table data 79
  [then]


  [ifdef] JPEG_JPEG_DHTMEM20_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA80                    \ [0x00 : 8] Huffman table data 80
    $08 constant JPEG_DATA81                    \ [0x08 : 8] Huffman table data 81
    $10 constant JPEG_DATA82                    \ [0x10 : 8] Huffman table data 82
    $18 constant JPEG_DATA83                    \ [0x18 : 8] Huffman table data 83
  [then]


  [ifdef] JPEG_JPEG_DHTMEM21_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA84                    \ [0x00 : 8] Huffman table data 84
    $08 constant JPEG_DATA85                    \ [0x08 : 8] Huffman table data 85
    $10 constant JPEG_DATA86                    \ [0x10 : 8] Huffman table data 86
    $18 constant JPEG_DATA87                    \ [0x18 : 8] Huffman table data 87
  [then]


  [ifdef] JPEG_JPEG_DHTMEM22_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA88                    \ [0x00 : 8] Huffman table data 88
    $08 constant JPEG_DATA89                    \ [0x08 : 8] Huffman table data 89
    $10 constant JPEG_DATA90                    \ [0x10 : 8] Huffman table data 90
    $18 constant JPEG_DATA91                    \ [0x18 : 8] Huffman table data 91
  [then]


  [ifdef] JPEG_JPEG_DHTMEM23_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA92                    \ [0x00 : 8] Huffman table data 92
    $08 constant JPEG_DATA93                    \ [0x08 : 8] Huffman table data 93
    $10 constant JPEG_DATA94                    \ [0x10 : 8] Huffman table data 94
    $18 constant JPEG_DATA95                    \ [0x18 : 8] Huffman table data 95
  [then]


  [ifdef] JPEG_JPEG_DHTMEM24_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA96                    \ [0x00 : 8] Huffman table data 96
    $08 constant JPEG_DATA97                    \ [0x08 : 8] Huffman table data 97
    $10 constant JPEG_DATA98                    \ [0x10 : 8] Huffman table data 98
    $18 constant JPEG_DATA99                    \ [0x18 : 8] Huffman table data 99
  [then]


  [ifdef] JPEG_JPEG_DHTMEM25_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA100                   \ [0x00 : 8] Huffman table data 100
    $08 constant JPEG_DATA101                   \ [0x08 : 8] Huffman table data 101
    $10 constant JPEG_DATA102                   \ [0x10 : 8] Huffman table data 102
    $18 constant JPEG_DATA103                   \ [0x18 : 8] Huffman table data 103
  [then]


  [ifdef] JPEG_JPEG_DHTMEM26_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA104                   \ [0x00 : 8] Huffman table data 104
    $08 constant JPEG_DATA105                   \ [0x08 : 8] Huffman table data 105
    $10 constant JPEG_DATA106                   \ [0x10 : 8] Huffman table data 106
    $18 constant JPEG_DATA107                   \ [0x18 : 8] Huffman table data 107
  [then]


  [ifdef] JPEG_JPEG_DHTMEM27_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA108                   \ [0x00 : 8] Huffman table data 108
    $08 constant JPEG_DATA109                   \ [0x08 : 8] Huffman table data 109
    $10 constant JPEG_DATA110                   \ [0x10 : 8] Huffman table data 110
    $18 constant JPEG_DATA111                   \ [0x18 : 8] Huffman table data 111
  [then]


  [ifdef] JPEG_JPEG_DHTMEM28_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA112                   \ [0x00 : 8] Huffman table data 112
    $08 constant JPEG_DATA113                   \ [0x08 : 8] Huffman table data 113
    $10 constant JPEG_DATA114                   \ [0x10 : 8] Huffman table data 114
    $18 constant JPEG_DATA115                   \ [0x18 : 8] Huffman table data 115
  [then]


  [ifdef] JPEG_JPEG_DHTMEM29_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA116                   \ [0x00 : 8] Huffman table data 116
    $08 constant JPEG_DATA117                   \ [0x08 : 8] Huffman table data 117
    $10 constant JPEG_DATA118                   \ [0x10 : 8] Huffman table data 118
    $18 constant JPEG_DATA119                   \ [0x18 : 8] Huffman table data 119
  [then]


  [ifdef] JPEG_JPEG_DHTMEM30_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA120                   \ [0x00 : 8] Huffman table data 120
    $08 constant JPEG_DATA121                   \ [0x08 : 8] Huffman table data 121
    $10 constant JPEG_DATA122                   \ [0x10 : 8] Huffman table data 122
    $18 constant JPEG_DATA123                   \ [0x18 : 8] Huffman table data 123
  [then]


  [ifdef] JPEG_JPEG_DHTMEM31_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA124                   \ [0x00 : 8] Huffman table data 124
    $08 constant JPEG_DATA125                   \ [0x08 : 8] Huffman table data 125
    $10 constant JPEG_DATA126                   \ [0x10 : 8] Huffman table data 126
    $18 constant JPEG_DATA127                   \ [0x18 : 8] Huffman table data 127
  [then]


  [ifdef] JPEG_JPEG_DHTMEM32_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA128                   \ [0x00 : 8] Huffman table data 128
    $08 constant JPEG_DATA129                   \ [0x08 : 8] Huffman table data 129
    $10 constant JPEG_DATA130                   \ [0x10 : 8] Huffman table data 130
    $18 constant JPEG_DATA131                   \ [0x18 : 8] Huffman table data 131
  [then]


  [ifdef] JPEG_JPEG_DHTMEM33_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA132                   \ [0x00 : 8] Huffman table data 132
    $08 constant JPEG_DATA133                   \ [0x08 : 8] Huffman table data 133
    $10 constant JPEG_DATA134                   \ [0x10 : 8] Huffman table data 134
    $18 constant JPEG_DATA135                   \ [0x18 : 8] Huffman table data 135
  [then]


  [ifdef] JPEG_JPEG_DHTMEM34_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA136                   \ [0x00 : 8] Huffman table data 136
    $08 constant JPEG_DATA137                   \ [0x08 : 8] Huffman table data 137
    $10 constant JPEG_DATA138                   \ [0x10 : 8] Huffman table data 138
    $18 constant JPEG_DATA139                   \ [0x18 : 8] Huffman table data 139
  [then]


  [ifdef] JPEG_JPEG_DHTMEM35_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA140                   \ [0x00 : 8] Huffman table data 140
    $08 constant JPEG_DATA141                   \ [0x08 : 8] Huffman table data 141
    $10 constant JPEG_DATA142                   \ [0x10 : 8] Huffman table data 142
    $18 constant JPEG_DATA143                   \ [0x18 : 8] Huffman table data 143
  [then]


  [ifdef] JPEG_JPEG_DHTMEM36_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA144                   \ [0x00 : 8] Huffman table data 144
    $08 constant JPEG_DATA145                   \ [0x08 : 8] Huffman table data 145
    $10 constant JPEG_DATA146                   \ [0x10 : 8] Huffman table data 146
    $18 constant JPEG_DATA147                   \ [0x18 : 8] Huffman table data 147
  [then]


  [ifdef] JPEG_JPEG_DHTMEM37_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA148                   \ [0x00 : 8] Huffman table data 148
    $08 constant JPEG_DATA149                   \ [0x08 : 8] Huffman table data 149
    $10 constant JPEG_DATA150                   \ [0x10 : 8] Huffman table data 150
    $18 constant JPEG_DATA151                   \ [0x18 : 8] Huffman table data 151
  [then]


  [ifdef] JPEG_JPEG_DHTMEM38_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA152                   \ [0x00 : 8] Huffman table data 152
    $08 constant JPEG_DATA153                   \ [0x08 : 8] Huffman table data 153
    $10 constant JPEG_DATA154                   \ [0x10 : 8] Huffman table data 154
    $18 constant JPEG_DATA155                   \ [0x18 : 8] Huffman table data 155
  [then]


  [ifdef] JPEG_JPEG_DHTMEM39_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x3FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA156                   \ [0x00 : 8] Huffman table data 156
    $08 constant JPEG_DATA157                   \ [0x08 : 8] Huffman table data 157
    $10 constant JPEG_DATA158                   \ [0x10 : 8] Huffman table data 158
    $18 constant JPEG_DATA159                   \ [0x18 : 8] Huffman table data 159
  [then]


  [ifdef] JPEG_JPEG_DHTMEM40_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA160                   \ [0x00 : 8] Huffman table data 160
    $08 constant JPEG_DATA161                   \ [0x08 : 8] Huffman table data 161
    $10 constant JPEG_DATA162                   \ [0x10 : 8] Huffman table data 162
    $18 constant JPEG_DATA163                   \ [0x18 : 8] Huffman table data 163
  [then]


  [ifdef] JPEG_JPEG_DHTMEM41_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA164                   \ [0x00 : 8] Huffman table data 164
    $08 constant JPEG_DATA165                   \ [0x08 : 8] Huffman table data 165
    $10 constant JPEG_DATA166                   \ [0x10 : 8] Huffman table data 166
    $18 constant JPEG_DATA167                   \ [0x18 : 8] Huffman table data 167
  [then]


  [ifdef] JPEG_JPEG_DHTMEM42_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA168                   \ [0x00 : 8] Huffman table data 168
    $08 constant JPEG_DATA169                   \ [0x08 : 8] Huffman table data 169
    $10 constant JPEG_DATA170                   \ [0x10 : 8] Huffman table data 170
    $18 constant JPEG_DATA171                   \ [0x18 : 8] Huffman table data 171
  [then]


  [ifdef] JPEG_JPEG_DHTMEM43_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA172                   \ [0x00 : 8] Huffman table data 172
    $08 constant JPEG_DATA173                   \ [0x08 : 8] Huffman table data 173
    $10 constant JPEG_DATA174                   \ [0x10 : 8] Huffman table data 174
    $18 constant JPEG_DATA175                   \ [0x18 : 8] Huffman table data 175
  [then]


  [ifdef] JPEG_JPEG_DHTMEM44_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA176                   \ [0x00 : 8] Huffman table data 176
    $08 constant JPEG_DATA177                   \ [0x08 : 8] Huffman table data 177
    $10 constant JPEG_DATA178                   \ [0x10 : 8] Huffman table data 178
    $18 constant JPEG_DATA179                   \ [0x18 : 8] Huffman table data 179
  [then]


  [ifdef] JPEG_JPEG_DHTMEM45_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA180                   \ [0x00 : 8] Huffman table data 180
    $08 constant JPEG_DATA181                   \ [0x08 : 8] Huffman table data 181
    $10 constant JPEG_DATA182                   \ [0x10 : 8] Huffman table data 182
    $18 constant JPEG_DATA183                   \ [0x18 : 8] Huffman table data 183
  [then]


  [ifdef] JPEG_JPEG_DHTMEM46_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA184                   \ [0x00 : 8] Huffman table data 184
    $08 constant JPEG_DATA185                   \ [0x08 : 8] Huffman table data 185
    $10 constant JPEG_DATA186                   \ [0x10 : 8] Huffman table data 186
    $18 constant JPEG_DATA187                   \ [0x18 : 8] Huffman table data 187
  [then]


  [ifdef] JPEG_JPEG_DHTMEM47_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA188                   \ [0x00 : 8] Huffman table data 188
    $08 constant JPEG_DATA189                   \ [0x08 : 8] Huffman table data 189
    $10 constant JPEG_DATA190                   \ [0x10 : 8] Huffman table data 190
    $18 constant JPEG_DATA191                   \ [0x18 : 8] Huffman table data 191
  [then]


  [ifdef] JPEG_JPEG_DHTMEM48_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA192                   \ [0x00 : 8] Huffman table data 192
    $08 constant JPEG_DATA193                   \ [0x08 : 8] Huffman table data 193
    $10 constant JPEG_DATA194                   \ [0x10 : 8] Huffman table data 194
    $18 constant JPEG_DATA195                   \ [0x18 : 8] Huffman table data 195
  [then]


  [ifdef] JPEG_JPEG_DHTMEM49_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA196                   \ [0x00 : 8] Huffman table data 196
    $08 constant JPEG_DATA197                   \ [0x08 : 8] Huffman table data 197
    $10 constant JPEG_DATA198                   \ [0x10 : 8] Huffman table data 198
    $18 constant JPEG_DATA199                   \ [0x18 : 8] Huffman table data 199
  [then]


  [ifdef] JPEG_JPEG_DHTMEM50_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA200                   \ [0x00 : 8] Huffman table data 200
    $08 constant JPEG_DATA201                   \ [0x08 : 8] Huffman table data 201
    $10 constant JPEG_DATA202                   \ [0x10 : 8] Huffman table data 202
    $18 constant JPEG_DATA203                   \ [0x18 : 8] Huffman table data 203
  [then]


  [ifdef] JPEG_JPEG_DHTMEM51_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x42C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA204                   \ [0x00 : 8] Huffman table data 204
    $08 constant JPEG_DATA205                   \ [0x08 : 8] Huffman table data 205
    $10 constant JPEG_DATA206                   \ [0x10 : 8] Huffman table data 206
    $18 constant JPEG_DATA207                   \ [0x18 : 8] Huffman table data 207
  [then]


  [ifdef] JPEG_JPEG_DHTMEM52_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA208                   \ [0x00 : 8] Huffman table data 208
    $08 constant JPEG_DATA209                   \ [0x08 : 8] Huffman table data 209
    $10 constant JPEG_DATA210                   \ [0x10 : 8] Huffman table data 210
    $18 constant JPEG_DATA211                   \ [0x18 : 8] Huffman table data 211
  [then]


  [ifdef] JPEG_JPEG_DHTMEM53_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x434
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA212                   \ [0x00 : 8] Huffman table data 212
    $08 constant JPEG_DATA213                   \ [0x08 : 8] Huffman table data 213
    $10 constant JPEG_DATA214                   \ [0x10 : 8] Huffman table data 214
    $18 constant JPEG_DATA215                   \ [0x18 : 8] Huffman table data 215
  [then]


  [ifdef] JPEG_JPEG_DHTMEM54_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x438
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA216                   \ [0x00 : 8] Huffman table data 216
    $08 constant JPEG_DATA217                   \ [0x08 : 8] Huffman table data 217
    $10 constant JPEG_DATA218                   \ [0x10 : 8] Huffman table data 218
    $18 constant JPEG_DATA219                   \ [0x18 : 8] Huffman table data 219
  [then]


  [ifdef] JPEG_JPEG_DHTMEM55_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x43C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA220                   \ [0x00 : 8] Huffman table data 220
    $08 constant JPEG_DATA221                   \ [0x08 : 8] Huffman table data 221
    $10 constant JPEG_DATA222                   \ [0x10 : 8] Huffman table data 222
    $18 constant JPEG_DATA223                   \ [0x18 : 8] Huffman table data 223
  [then]


  [ifdef] JPEG_JPEG_DHTMEM56_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA224                   \ [0x00 : 8] Huffman table data 224
    $08 constant JPEG_DATA225                   \ [0x08 : 8] Huffman table data 225
    $10 constant JPEG_DATA226                   \ [0x10 : 8] Huffman table data 226
    $18 constant JPEG_DATA227                   \ [0x18 : 8] Huffman table data 227
  [then]


  [ifdef] JPEG_JPEG_DHTMEM57_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x444
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA228                   \ [0x00 : 8] Huffman table data 228
    $08 constant JPEG_DATA229                   \ [0x08 : 8] Huffman table data 229
    $10 constant JPEG_DATA230                   \ [0x10 : 8] Huffman table data 230
    $18 constant JPEG_DATA231                   \ [0x18 : 8] Huffman table data 231
  [then]


  [ifdef] JPEG_JPEG_DHTMEM58_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x448
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA232                   \ [0x00 : 8] Huffman table data 232
    $08 constant JPEG_DATA233                   \ [0x08 : 8] Huffman table data 233
    $10 constant JPEG_DATA234                   \ [0x10 : 8] Huffman table data 234
    $18 constant JPEG_DATA235                   \ [0x18 : 8] Huffman table data 235
  [then]


  [ifdef] JPEG_JPEG_DHTMEM59_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA236                   \ [0x00 : 8] Huffman table data 236
    $08 constant JPEG_DATA237                   \ [0x08 : 8] Huffman table data 237
    $10 constant JPEG_DATA238                   \ [0x10 : 8] Huffman table data 238
    $18 constant JPEG_DATA239                   \ [0x18 : 8] Huffman table data 239
  [then]


  [ifdef] JPEG_JPEG_DHTMEM60_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x450
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA240                   \ [0x00 : 8] Huffman table data 240
    $08 constant JPEG_DATA241                   \ [0x08 : 8] Huffman table data 241
    $10 constant JPEG_DATA242                   \ [0x10 : 8] Huffman table data 242
    $18 constant JPEG_DATA243                   \ [0x18 : 8] Huffman table data 243
  [then]


  [ifdef] JPEG_JPEG_DHTMEM61_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x454
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA244                   \ [0x00 : 8] Huffman table data 244
    $08 constant JPEG_DATA245                   \ [0x08 : 8] Huffman table data 245
    $10 constant JPEG_DATA246                   \ [0x10 : 8] Huffman table data 246
    $18 constant JPEG_DATA247                   \ [0x18 : 8] Huffman table data 247
  [then]


  [ifdef] JPEG_JPEG_DHTMEM62_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x458
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA248                   \ [0x00 : 8] Huffman table data 248
    $08 constant JPEG_DATA249                   \ [0x08 : 8] Huffman table data 249
    $10 constant JPEG_DATA250                   \ [0x10 : 8] Huffman table data 250
    $18 constant JPEG_DATA251                   \ [0x18 : 8] Huffman table data 251
  [then]


  [ifdef] JPEG_JPEG_DHTMEM63_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x45C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA252                   \ [0x00 : 8] Huffman table data 252
    $08 constant JPEG_DATA253                   \ [0x08 : 8] Huffman table data 253
    $10 constant JPEG_DATA254                   \ [0x10 : 8] Huffman table data 254
    $18 constant JPEG_DATA255                   \ [0x18 : 8] Huffman table data 255
  [then]


  [ifdef] JPEG_JPEG_DHTMEM64_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x460
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA256                   \ [0x00 : 8] Huffman table data 256
    $08 constant JPEG_DATA257                   \ [0x08 : 8] Huffman table data 257
    $10 constant JPEG_DATA258                   \ [0x10 : 8] Huffman table data 258
    $18 constant JPEG_DATA259                   \ [0x18 : 8] Huffman table data 259
  [then]


  [ifdef] JPEG_JPEG_DHTMEM65_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA260                   \ [0x00 : 8] Huffman table data 260
    $08 constant JPEG_DATA261                   \ [0x08 : 8] Huffman table data 261
    $10 constant JPEG_DATA262                   \ [0x10 : 8] Huffman table data 262
    $18 constant JPEG_DATA263                   \ [0x18 : 8] Huffman table data 263
  [then]


  [ifdef] JPEG_JPEG_DHTMEM66_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x468
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA264                   \ [0x00 : 8] Huffman table data 264
    $08 constant JPEG_DATA265                   \ [0x08 : 8] Huffman table data 265
    $10 constant JPEG_DATA266                   \ [0x10 : 8] Huffman table data 266
    $18 constant JPEG_DATA267                   \ [0x18 : 8] Huffman table data 267
  [then]


  [ifdef] JPEG_JPEG_DHTMEM67_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x46C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA268                   \ [0x00 : 8] Huffman table data 268
    $08 constant JPEG_DATA269                   \ [0x08 : 8] Huffman table data 269
    $10 constant JPEG_DATA270                   \ [0x10 : 8] Huffman table data 270
    $18 constant JPEG_DATA271                   \ [0x18 : 8] Huffman table data 271
  [then]


  [ifdef] JPEG_JPEG_DHTMEM68_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x470
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA272                   \ [0x00 : 8] Huffman table data 272
    $08 constant JPEG_DATA273                   \ [0x08 : 8] Huffman table data 273
    $10 constant JPEG_DATA274                   \ [0x10 : 8] Huffman table data 274
    $18 constant JPEG_DATA275                   \ [0x18 : 8] Huffman table data 275
  [then]


  [ifdef] JPEG_JPEG_DHTMEM69_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x474
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA276                   \ [0x00 : 8] Huffman table data 276
    $08 constant JPEG_DATA277                   \ [0x08 : 8] Huffman table data 277
    $10 constant JPEG_DATA278                   \ [0x10 : 8] Huffman table data 278
    $18 constant JPEG_DATA279                   \ [0x18 : 8] Huffman table data 279
  [then]


  [ifdef] JPEG_JPEG_DHTMEM70_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x478
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA280                   \ [0x00 : 8] Huffman table data 280
    $08 constant JPEG_DATA281                   \ [0x08 : 8] Huffman table data 281
    $10 constant JPEG_DATA282                   \ [0x10 : 8] Huffman table data 282
    $18 constant JPEG_DATA283                   \ [0x18 : 8] Huffman table data 283
  [then]


  [ifdef] JPEG_JPEG_DHTMEM71_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x47C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA284                   \ [0x00 : 8] Huffman table data 284
    $08 constant JPEG_DATA285                   \ [0x08 : 8] Huffman table data 285
    $10 constant JPEG_DATA286                   \ [0x10 : 8] Huffman table data 286
    $18 constant JPEG_DATA287                   \ [0x18 : 8] Huffman table data 287
  [then]


  [ifdef] JPEG_JPEG_DHTMEM72_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x480
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA288                   \ [0x00 : 8] Huffman table data 288
    $08 constant JPEG_DATA289                   \ [0x08 : 8] Huffman table data 289
    $10 constant JPEG_DATA290                   \ [0x10 : 8] Huffman table data 290
    $18 constant JPEG_DATA291                   \ [0x18 : 8] Huffman table data 291
  [then]


  [ifdef] JPEG_JPEG_DHTMEM73_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x484
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA292                   \ [0x00 : 8] Huffman table data 292
    $08 constant JPEG_DATA293                   \ [0x08 : 8] Huffman table data 293
    $10 constant JPEG_DATA294                   \ [0x10 : 8] Huffman table data 294
    $18 constant JPEG_DATA295                   \ [0x18 : 8] Huffman table data 295
  [then]


  [ifdef] JPEG_JPEG_DHTMEM74_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x488
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA296                   \ [0x00 : 8] Huffman table data 296
    $08 constant JPEG_DATA297                   \ [0x08 : 8] Huffman table data 297
    $10 constant JPEG_DATA298                   \ [0x10 : 8] Huffman table data 298
    $18 constant JPEG_DATA299                   \ [0x18 : 8] Huffman table data 299
  [then]


  [ifdef] JPEG_JPEG_DHTMEM75_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x48C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA300                   \ [0x00 : 8] Huffman table data 300
    $08 constant JPEG_DATA301                   \ [0x08 : 8] Huffman table data 301
    $10 constant JPEG_DATA302                   \ [0x10 : 8] Huffman table data 302
    $18 constant JPEG_DATA303                   \ [0x18 : 8] Huffman table data 303
  [then]


  [ifdef] JPEG_JPEG_DHTMEM76_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x490
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA304                   \ [0x00 : 8] Huffman table data 304
    $08 constant JPEG_DATA305                   \ [0x08 : 8] Huffman table data 305
    $10 constant JPEG_DATA306                   \ [0x10 : 8] Huffman table data 306
    $18 constant JPEG_DATA307                   \ [0x18 : 8] Huffman table data 307
  [then]


  [ifdef] JPEG_JPEG_DHTMEM77_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x494
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA308                   \ [0x00 : 8] Huffman table data 308
    $08 constant JPEG_DATA309                   \ [0x08 : 8] Huffman table data 309
    $10 constant JPEG_DATA310                   \ [0x10 : 8] Huffman table data 310
    $18 constant JPEG_DATA311                   \ [0x18 : 8] Huffman table data 311
  [then]


  [ifdef] JPEG_JPEG_DHTMEM78_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA312                   \ [0x00 : 8] Huffman table data 312
    $08 constant JPEG_DATA313                   \ [0x08 : 8] Huffman table data 313
    $10 constant JPEG_DATA314                   \ [0x10 : 8] Huffman table data 314
    $18 constant JPEG_DATA315                   \ [0x18 : 8] Huffman table data 315
  [then]


  [ifdef] JPEG_JPEG_DHTMEM79_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x49C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA316                   \ [0x00 : 8] Huffman table data 316
    $08 constant JPEG_DATA317                   \ [0x08 : 8] Huffman table data 317
    $10 constant JPEG_DATA318                   \ [0x10 : 8] Huffman table data 318
    $18 constant JPEG_DATA319                   \ [0x18 : 8] Huffman table data 319
  [then]


  [ifdef] JPEG_JPEG_DHTMEM80_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA320                   \ [0x00 : 8] Huffman table data 320
    $08 constant JPEG_DATA321                   \ [0x08 : 8] Huffman table data 321
    $10 constant JPEG_DATA322                   \ [0x10 : 8] Huffman table data 322
    $18 constant JPEG_DATA323                   \ [0x18 : 8] Huffman table data 323
  [then]


  [ifdef] JPEG_JPEG_DHTMEM81_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA324                   \ [0x00 : 8] Huffman table data 324
    $08 constant JPEG_DATA325                   \ [0x08 : 8] Huffman table data 325
    $10 constant JPEG_DATA326                   \ [0x10 : 8] Huffman table data 326
    $18 constant JPEG_DATA327                   \ [0x18 : 8] Huffman table data 327
  [then]


  [ifdef] JPEG_JPEG_DHTMEM82_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA328                   \ [0x00 : 8] Huffman table data 328
    $08 constant JPEG_DATA329                   \ [0x08 : 8] Huffman table data 329
    $10 constant JPEG_DATA330                   \ [0x10 : 8] Huffman table data 330
    $18 constant JPEG_DATA331                   \ [0x18 : 8] Huffman table data 331
  [then]


  [ifdef] JPEG_JPEG_DHTMEM83_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA332                   \ [0x00 : 8] Huffman table data 332
    $08 constant JPEG_DATA333                   \ [0x08 : 8] Huffman table data 333
    $10 constant JPEG_DATA334                   \ [0x10 : 8] Huffman table data 334
    $18 constant JPEG_DATA335                   \ [0x18 : 8] Huffman table data 335
  [then]


  [ifdef] JPEG_JPEG_DHTMEM84_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA336                   \ [0x00 : 8] Huffman table data 336
    $08 constant JPEG_DATA337                   \ [0x08 : 8] Huffman table data 337
    $10 constant JPEG_DATA338                   \ [0x10 : 8] Huffman table data 338
    $18 constant JPEG_DATA339                   \ [0x18 : 8] Huffman table data 339
  [then]


  [ifdef] JPEG_JPEG_DHTMEM85_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA340                   \ [0x00 : 8] Huffman table data 340
    $08 constant JPEG_DATA341                   \ [0x08 : 8] Huffman table data 341
    $10 constant JPEG_DATA342                   \ [0x10 : 8] Huffman table data 342
    $18 constant JPEG_DATA343                   \ [0x18 : 8] Huffman table data 343
  [then]


  [ifdef] JPEG_JPEG_DHTMEM86_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA344                   \ [0x00 : 8] Huffman table data 344
    $08 constant JPEG_DATA345                   \ [0x08 : 8] Huffman table data 345
    $10 constant JPEG_DATA346                   \ [0x10 : 8] Huffman table data 346
    $18 constant JPEG_DATA347                   \ [0x18 : 8] Huffman table data 347
  [then]


  [ifdef] JPEG_JPEG_DHTMEM87_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA348                   \ [0x00 : 8] Huffman table data 348
    $08 constant JPEG_DATA349                   \ [0x08 : 8] Huffman table data 349
    $10 constant JPEG_DATA350                   \ [0x10 : 8] Huffman table data 350
    $18 constant JPEG_DATA351                   \ [0x18 : 8] Huffman table data 351
  [then]


  [ifdef] JPEG_JPEG_DHTMEM88_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA352                   \ [0x00 : 8] Huffman table data 352
    $08 constant JPEG_DATA353                   \ [0x08 : 8] Huffman table data 353
    $10 constant JPEG_DATA354                   \ [0x10 : 8] Huffman table data 354
    $18 constant JPEG_DATA355                   \ [0x18 : 8] Huffman table data 355
  [then]


  [ifdef] JPEG_JPEG_DHTMEM89_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA356                   \ [0x00 : 8] Huffman table data 356
    $08 constant JPEG_DATA357                   \ [0x08 : 8] Huffman table data 357
    $10 constant JPEG_DATA358                   \ [0x10 : 8] Huffman table data 358
    $18 constant JPEG_DATA359                   \ [0x18 : 8] Huffman table data 359
  [then]


  [ifdef] JPEG_JPEG_DHTMEM90_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA360                   \ [0x00 : 8] Huffman table data 360
    $08 constant JPEG_DATA361                   \ [0x08 : 8] Huffman table data 361
    $10 constant JPEG_DATA362                   \ [0x10 : 8] Huffman table data 362
    $18 constant JPEG_DATA363                   \ [0x18 : 8] Huffman table data 363
  [then]


  [ifdef] JPEG_JPEG_DHTMEM91_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA364                   \ [0x00 : 8] Huffman table data 364
    $08 constant JPEG_DATA365                   \ [0x08 : 8] Huffman table data 365
    $10 constant JPEG_DATA366                   \ [0x10 : 8] Huffman table data 366
    $18 constant JPEG_DATA367                   \ [0x18 : 8] Huffman table data 367
  [then]


  [ifdef] JPEG_JPEG_DHTMEM92_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA368                   \ [0x00 : 8] Huffman table data 368
    $08 constant JPEG_DATA369                   \ [0x08 : 8] Huffman table data 369
    $10 constant JPEG_DATA370                   \ [0x10 : 8] Huffman table data 370
    $18 constant JPEG_DATA371                   \ [0x18 : 8] Huffman table data 371
  [then]


  [ifdef] JPEG_JPEG_DHTMEM93_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA372                   \ [0x00 : 8] Huffman table data 372
    $08 constant JPEG_DATA373                   \ [0x08 : 8] Huffman table data 373
    $10 constant JPEG_DATA374                   \ [0x10 : 8] Huffman table data 374
    $18 constant JPEG_DATA375                   \ [0x18 : 8] Huffman table data 375
  [then]


  [ifdef] JPEG_JPEG_DHTMEM94_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA376                   \ [0x00 : 8] Huffman table data 376
    $08 constant JPEG_DATA377                   \ [0x08 : 8] Huffman table data 377
    $10 constant JPEG_DATA378                   \ [0x10 : 8] Huffman table data 378
    $18 constant JPEG_DATA379                   \ [0x18 : 8] Huffman table data 379
  [then]


  [ifdef] JPEG_JPEG_DHTMEM95_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA380                   \ [0x00 : 8] Huffman table data 380
    $08 constant JPEG_DATA381                   \ [0x08 : 8] Huffman table data 381
    $10 constant JPEG_DATA382                   \ [0x10 : 8] Huffman table data 382
    $18 constant JPEG_DATA383                   \ [0x18 : 8] Huffman table data 383
  [then]


  [ifdef] JPEG_JPEG_DHTMEM96_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA384                   \ [0x00 : 8] Huffman table data 384
    $08 constant JPEG_DATA385                   \ [0x08 : 8] Huffman table data 385
    $10 constant JPEG_DATA386                   \ [0x10 : 8] Huffman table data 386
    $18 constant JPEG_DATA387                   \ [0x18 : 8] Huffman table data 387
  [then]


  [ifdef] JPEG_JPEG_DHTMEM97_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA388                   \ [0x00 : 8] Huffman table data 388
    $08 constant JPEG_DATA389                   \ [0x08 : 8] Huffman table data 389
    $10 constant JPEG_DATA390                   \ [0x10 : 8] Huffman table data 390
    $18 constant JPEG_DATA391                   \ [0x18 : 8] Huffman table data 391
  [then]


  [ifdef] JPEG_JPEG_DHTMEM98_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA392                   \ [0x00 : 8] Huffman table data 392
    $08 constant JPEG_DATA393                   \ [0x08 : 8] Huffman table data 393
    $10 constant JPEG_DATA394                   \ [0x10 : 8] Huffman table data 394
    $18 constant JPEG_DATA395                   \ [0x18 : 8] Huffman table data 395
  [then]


  [ifdef] JPEG_JPEG_DHTMEM99_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA396                   \ [0x00 : 8] Huffman table data 396
    $08 constant JPEG_DATA397                   \ [0x08 : 8] Huffman table data 397
    $10 constant JPEG_DATA398                   \ [0x10 : 8] Huffman table data 398
    $18 constant JPEG_DATA399                   \ [0x18 : 8] Huffman table data 399
  [then]


  [ifdef] JPEG_JPEG_DHTMEM100_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA400                   \ [0x00 : 8] Huffman table data 400
    $08 constant JPEG_DATA401                   \ [0x08 : 8] Huffman table data 401
    $10 constant JPEG_DATA402                   \ [0x10 : 8] Huffman table data 402
    $18 constant JPEG_DATA403                   \ [0x18 : 8] Huffman table data 403
  [then]


  [ifdef] JPEG_JPEG_DHTMEM101_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA404                   \ [0x00 : 8] Huffman table data 404
    $08 constant JPEG_DATA405                   \ [0x08 : 8] Huffman table data 405
    $10 constant JPEG_DATA406                   \ [0x10 : 8] Huffman table data 406
    $18 constant JPEG_DATA407                   \ [0x18 : 8] Huffman table data 407
  [then]


  [ifdef] JPEG_JPEG_DHTMEM102_DEF
    \
    \ @brief JPEG DHT memory
    \ Address offset: 0x4F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATA408                   \ [0x00 : 8] Huffman table data 408
    $08 constant JPEG_DATA409                   \ [0x08 : 8] Huffman table data 409
    $10 constant JPEG_DATA410                   \ [0x10 : 8] Huffman table data 410
    $18 constant JPEG_DATA411                   \ [0x18 : 8] Huffman table data 411
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_0_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE0                    \ [0x00 : 8] Huffman code 0
    $08 constant JPEG_HLEN0                     \ [0x08 : 4] Huffman length 0
    $10 constant JPEG_HCODE1                    \ [0x10 : 8] Huffman code 1
    $18 constant JPEG_HLEN1                     \ [0x18 : 4] Huffman length 1
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_1_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE2                    \ [0x00 : 8] Huffman code 2
    $08 constant JPEG_HLEN2                     \ [0x08 : 4] Huffman length 2
    $10 constant JPEG_HCODE3                    \ [0x10 : 8] Huffman code 3
    $18 constant JPEG_HLEN3                     \ [0x18 : 4] Huffman length 3
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_2_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE4                    \ [0x00 : 8] Huffman code 4
    $08 constant JPEG_HLEN4                     \ [0x08 : 4] Huffman length 4
    $10 constant JPEG_HCODE5                    \ [0x10 : 8] Huffman code 5
    $18 constant JPEG_HLEN5                     \ [0x18 : 4] Huffman length 5
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_3_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE6                    \ [0x00 : 8] Huffman code 6
    $08 constant JPEG_HLEN6                     \ [0x08 : 4] Huffman length 6
    $10 constant JPEG_HCODE7                    \ [0x10 : 8] Huffman code 7
    $18 constant JPEG_HLEN7                     \ [0x18 : 4] Huffman length 7
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_4_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE8                    \ [0x00 : 8] Huffman code 8
    $08 constant JPEG_HLEN8                     \ [0x08 : 4] Huffman length 8
    $10 constant JPEG_HCODE9                    \ [0x10 : 8] Huffman code 9
    $18 constant JPEG_HLEN9                     \ [0x18 : 4] Huffman length 9
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_5_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE10                   \ [0x00 : 8] Huffman code 10
    $08 constant JPEG_HLEN10                    \ [0x08 : 4] Huffman length 10
    $10 constant JPEG_HCODE11                   \ [0x10 : 8] Huffman code 11
    $18 constant JPEG_HLEN11                    \ [0x18 : 4] Huffman length 11
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_6_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x518
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE12                   \ [0x00 : 8] Huffman code 12
    $08 constant JPEG_HLEN12                    \ [0x08 : 4] Huffman length 12
    $10 constant JPEG_HCODE13                   \ [0x10 : 8] Huffman code 13
    $18 constant JPEG_HLEN13                    \ [0x18 : 4] Huffman length 13
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_7_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE14                   \ [0x00 : 8] Huffman code 14
    $08 constant JPEG_HLEN14                    \ [0x08 : 4] Huffman length 14
    $10 constant JPEG_HCODE15                   \ [0x10 : 8] Huffman code 15
    $18 constant JPEG_HLEN15                    \ [0x18 : 4] Huffman length 15
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_8_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE16                   \ [0x00 : 8] Huffman code 16
    $08 constant JPEG_HLEN16                    \ [0x08 : 4] Huffman length 16
    $10 constant JPEG_HCODE17                   \ [0x10 : 8] Huffman code 17
    $18 constant JPEG_HLEN17                    \ [0x18 : 4] Huffman length 17
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_9_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x524
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE18                   \ [0x00 : 8] Huffman code 18
    $08 constant JPEG_HLEN18                    \ [0x08 : 4] Huffman length 18
    $10 constant JPEG_HCODE19                   \ [0x10 : 8] Huffman code 19
    $18 constant JPEG_HLEN19                    \ [0x18 : 4] Huffman length 19
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_10_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE20                   \ [0x00 : 8] Huffman code 20
    $08 constant JPEG_HLEN20                    \ [0x08 : 4] Huffman length 20
    $10 constant JPEG_HCODE21                   \ [0x10 : 8] Huffman code 21
    $18 constant JPEG_HLEN21                    \ [0x18 : 4] Huffman length 21
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_11_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x52C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE22                   \ [0x00 : 8] Huffman code 22
    $08 constant JPEG_HLEN22                    \ [0x08 : 4] Huffman length 22
    $10 constant JPEG_HCODE23                   \ [0x10 : 8] Huffman code 23
    $18 constant JPEG_HLEN23                    \ [0x18 : 4] Huffman length 23
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_12_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE24                   \ [0x00 : 8] Huffman code 24
    $08 constant JPEG_HLEN24                    \ [0x08 : 4] Huffman length 24
    $10 constant JPEG_HCODE25                   \ [0x10 : 8] Huffman code 25
    $18 constant JPEG_HLEN25                    \ [0x18 : 4] Huffman length 25
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_13_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x534
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE26                   \ [0x00 : 8] Huffman code 26
    $08 constant JPEG_HLEN26                    \ [0x08 : 4] Huffman length 26
    $10 constant JPEG_HCODE27                   \ [0x10 : 8] Huffman code 27
    $18 constant JPEG_HLEN27                    \ [0x18 : 4] Huffman length 27
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_14_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x538
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE28                   \ [0x00 : 8] Huffman code 28
    $08 constant JPEG_HLEN28                    \ [0x08 : 4] Huffman length 28
    $10 constant JPEG_HCODE29                   \ [0x10 : 8] Huffman code 29
    $18 constant JPEG_HLEN29                    \ [0x18 : 4] Huffman length 29
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_15_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x53C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE30                   \ [0x00 : 8] Huffman code 30
    $08 constant JPEG_HLEN30                    \ [0x08 : 4] Huffman length 30
    $10 constant JPEG_HCODE31                   \ [0x10 : 8] Huffman code 31
    $18 constant JPEG_HLEN31                    \ [0x18 : 4] Huffman length 31
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_16_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE32                   \ [0x00 : 8] Huffman code 32
    $08 constant JPEG_HLEN32                    \ [0x08 : 4] Huffman length 32
    $10 constant JPEG_HCODE33                   \ [0x10 : 8] Huffman code 33
    $18 constant JPEG_HLEN33                    \ [0x18 : 4] Huffman length 33
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_17_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x544
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE34                   \ [0x00 : 8] Huffman code 34
    $08 constant JPEG_HLEN34                    \ [0x08 : 4] Huffman length 34
    $10 constant JPEG_HCODE35                   \ [0x10 : 8] Huffman code 35
    $18 constant JPEG_HLEN35                    \ [0x18 : 4] Huffman length 35
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_18_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE36                   \ [0x00 : 8] Huffman code 36
    $08 constant JPEG_HLEN36                    \ [0x08 : 4] Huffman length 36
    $10 constant JPEG_HCODE37                   \ [0x10 : 8] Huffman code 37
    $18 constant JPEG_HLEN37                    \ [0x18 : 4] Huffman length 37
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_19_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE38                   \ [0x00 : 8] Huffman code 38
    $08 constant JPEG_HLEN38                    \ [0x08 : 4] Huffman length 38
    $10 constant JPEG_HCODE39                   \ [0x10 : 8] Huffman code 39
    $18 constant JPEG_HLEN39                    \ [0x18 : 4] Huffman length 39
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_20_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE40                   \ [0x00 : 8] Huffman code 40
    $08 constant JPEG_HLEN40                    \ [0x08 : 4] Huffman length 40
    $10 constant JPEG_HCODE41                   \ [0x10 : 8] Huffman code 41
    $18 constant JPEG_HLEN41                    \ [0x18 : 4] Huffman length 41
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_21_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x554
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE42                   \ [0x00 : 8] Huffman code 42
    $08 constant JPEG_HLEN42                    \ [0x08 : 4] Huffman length 42
    $10 constant JPEG_HCODE43                   \ [0x10 : 8] Huffman code 43
    $18 constant JPEG_HLEN43                    \ [0x18 : 4] Huffman length 43
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_22_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x558
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE44                   \ [0x00 : 8] Huffman code 44
    $08 constant JPEG_HLEN44                    \ [0x08 : 4] Huffman length 44
    $10 constant JPEG_HCODE45                   \ [0x10 : 8] Huffman code 45
    $18 constant JPEG_HLEN45                    \ [0x18 : 4] Huffman length 45
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_23_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x55C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE46                   \ [0x00 : 8] Huffman code 46
    $08 constant JPEG_HLEN46                    \ [0x08 : 4] Huffman length 46
    $10 constant JPEG_HCODE47                   \ [0x10 : 8] Huffman code 47
    $18 constant JPEG_HLEN47                    \ [0x18 : 4] Huffman length 47
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_24_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE48                   \ [0x00 : 8] Huffman code 48
    $08 constant JPEG_HLEN48                    \ [0x08 : 4] Huffman length 48
    $10 constant JPEG_HCODE49                   \ [0x10 : 8] Huffman code 49
    $18 constant JPEG_HLEN49                    \ [0x18 : 4] Huffman length 49
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_25_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE50                   \ [0x00 : 8] Huffman code 50
    $08 constant JPEG_HLEN50                    \ [0x08 : 4] Huffman length 50
    $10 constant JPEG_HCODE51                   \ [0x10 : 8] Huffman code 51
    $18 constant JPEG_HLEN51                    \ [0x18 : 4] Huffman length 51
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_26_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x568
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE52                   \ [0x00 : 8] Huffman code 52
    $08 constant JPEG_HLEN52                    \ [0x08 : 4] Huffman length 52
    $10 constant JPEG_HCODE53                   \ [0x10 : 8] Huffman code 53
    $18 constant JPEG_HLEN53                    \ [0x18 : 4] Huffman length 53
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_27_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x56C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE54                   \ [0x00 : 8] Huffman code 54
    $08 constant JPEG_HLEN54                    \ [0x08 : 4] Huffman length 54
    $10 constant JPEG_HCODE55                   \ [0x10 : 8] Huffman code 55
    $18 constant JPEG_HLEN55                    \ [0x18 : 4] Huffman length 55
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_28_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x570
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE56                   \ [0x00 : 8] Huffman code 56
    $08 constant JPEG_HLEN56                    \ [0x08 : 4] Huffman length 56
    $10 constant JPEG_HCODE57                   \ [0x10 : 8] Huffman code 57
    $18 constant JPEG_HLEN57                    \ [0x18 : 4] Huffman length 57
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_29_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x574
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE58                   \ [0x00 : 8] Huffman code 58
    $08 constant JPEG_HLEN58                    \ [0x08 : 4] Huffman length 58
    $10 constant JPEG_HCODE59                   \ [0x10 : 8] Huffman code 59
    $18 constant JPEG_HLEN59                    \ [0x18 : 4] Huffman length 59
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_30_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x578
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE60                   \ [0x00 : 8] Huffman code 60
    $08 constant JPEG_HLEN60                    \ [0x08 : 4] Huffman length 60
    $10 constant JPEG_HCODE61                   \ [0x10 : 8] Huffman code 61
    $18 constant JPEG_HLEN61                    \ [0x18 : 4] Huffman length 61
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_31_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x57C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE62                   \ [0x00 : 8] Huffman code 62
    $08 constant JPEG_HLEN62                    \ [0x08 : 4] Huffman length 62
    $10 constant JPEG_HCODE63                   \ [0x10 : 8] Huffman code 63
    $18 constant JPEG_HLEN63                    \ [0x18 : 4] Huffman length 63
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_32_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x580
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE64                   \ [0x00 : 8] Huffman code 64
    $08 constant JPEG_HLEN64                    \ [0x08 : 4] Huffman length 64
    $10 constant JPEG_HCODE65                   \ [0x10 : 8] Huffman code 65
    $18 constant JPEG_HLEN65                    \ [0x18 : 4] Huffman length 65
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_33_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x584
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE66                   \ [0x00 : 8] Huffman code 66
    $08 constant JPEG_HLEN66                    \ [0x08 : 4] Huffman length 66
    $10 constant JPEG_HCODE67                   \ [0x10 : 8] Huffman code 67
    $18 constant JPEG_HLEN67                    \ [0x18 : 4] Huffman length 67
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_34_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x588
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE68                   \ [0x00 : 8] Huffman code 68
    $08 constant JPEG_HLEN68                    \ [0x08 : 4] Huffman length 68
    $10 constant JPEG_HCODE69                   \ [0x10 : 8] Huffman code 69
    $18 constant JPEG_HLEN69                    \ [0x18 : 4] Huffman length 69
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_35_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x58C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE70                   \ [0x00 : 8] Huffman code 70
    $08 constant JPEG_HLEN70                    \ [0x08 : 4] Huffman length 70
    $10 constant JPEG_HCODE71                   \ [0x10 : 8] Huffman code 71
    $18 constant JPEG_HLEN71                    \ [0x18 : 4] Huffman length 71
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_36_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE72                   \ [0x00 : 8] Huffman code 72
    $08 constant JPEG_HLEN72                    \ [0x08 : 4] Huffman length 72
    $10 constant JPEG_HCODE73                   \ [0x10 : 8] Huffman code 73
    $18 constant JPEG_HLEN73                    \ [0x18 : 4] Huffman length 73
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_37_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE74                   \ [0x00 : 8] Huffman code 74
    $08 constant JPEG_HLEN74                    \ [0x08 : 4] Huffman length 74
    $10 constant JPEG_HCODE75                   \ [0x10 : 8] Huffman code 75
    $18 constant JPEG_HLEN75                    \ [0x18 : 4] Huffman length 75
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_38_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x598
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE76                   \ [0x00 : 8] Huffman code 76
    $08 constant JPEG_HLEN76                    \ [0x08 : 4] Huffman length 76
    $10 constant JPEG_HCODE77                   \ [0x10 : 8] Huffman code 77
    $18 constant JPEG_HLEN77                    \ [0x18 : 4] Huffman length 77
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_39_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x59C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE78                   \ [0x00 : 8] Huffman code 78
    $08 constant JPEG_HLEN78                    \ [0x08 : 4] Huffman length 78
    $10 constant JPEG_HCODE79                   \ [0x10 : 8] Huffman code 79
    $18 constant JPEG_HLEN79                    \ [0x18 : 4] Huffman length 79
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_40_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE80                   \ [0x00 : 8] Huffman code 80
    $08 constant JPEG_HLEN80                    \ [0x08 : 4] Huffman length 80
    $10 constant JPEG_HCODE81                   \ [0x10 : 8] Huffman code 81
    $18 constant JPEG_HLEN81                    \ [0x18 : 4] Huffman length 81
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_41_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE82                   \ [0x00 : 8] Huffman code 82
    $08 constant JPEG_HLEN82                    \ [0x08 : 4] Huffman length 82
    $10 constant JPEG_HCODE83                   \ [0x10 : 8] Huffman code 83
    $18 constant JPEG_HLEN83                    \ [0x18 : 4] Huffman length 83
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_42_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE84                   \ [0x00 : 8] Huffman code 84
    $08 constant JPEG_HLEN84                    \ [0x08 : 4] Huffman length 84
    $10 constant JPEG_HCODE85                   \ [0x10 : 8] Huffman code 85
    $18 constant JPEG_HLEN85                    \ [0x18 : 4] Huffman length 85
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_43_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE86                   \ [0x00 : 8] Huffman code 86
    $08 constant JPEG_HLEN86                    \ [0x08 : 4] Huffman length 86
    $10 constant JPEG_HCODE87                   \ [0x10 : 8] Huffman code 87
    $18 constant JPEG_HLEN87                    \ [0x18 : 4] Huffman length 87
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_44_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE88                   \ [0x00 : 8] Huffman code 88
    $08 constant JPEG_HLEN88                    \ [0x08 : 4] Huffman length 88
    $10 constant JPEG_HCODE89                   \ [0x10 : 8] Huffman code 89
    $18 constant JPEG_HLEN89                    \ [0x18 : 4] Huffman length 89
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_45_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE90                   \ [0x00 : 8] Huffman code 90
    $08 constant JPEG_HLEN90                    \ [0x08 : 4] Huffman length 90
    $10 constant JPEG_HCODE91                   \ [0x10 : 8] Huffman code 91
    $18 constant JPEG_HLEN91                    \ [0x18 : 4] Huffman length 91
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_46_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE92                   \ [0x00 : 8] Huffman code 92
    $08 constant JPEG_HLEN92                    \ [0x08 : 4] Huffman length 92
    $10 constant JPEG_HCODE93                   \ [0x10 : 8] Huffman code 93
    $18 constant JPEG_HLEN93                    \ [0x18 : 4] Huffman length 93
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_47_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE94                   \ [0x00 : 8] Huffman code 94
    $08 constant JPEG_HLEN94                    \ [0x08 : 4] Huffman length 94
    $10 constant JPEG_HCODE95                   \ [0x10 : 8] Huffman code 95
    $18 constant JPEG_HLEN95                    \ [0x18 : 4] Huffman length 95
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_48_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE96                   \ [0x00 : 8] Huffman code 96
    $08 constant JPEG_HLEN96                    \ [0x08 : 4] Huffman length 96
    $10 constant JPEG_HCODE97                   \ [0x10 : 8] Huffman code 97
    $18 constant JPEG_HLEN97                    \ [0x18 : 4] Huffman length 97
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_49_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE98                   \ [0x00 : 8] Huffman code 98
    $08 constant JPEG_HLEN98                    \ [0x08 : 4] Huffman length 98
    $10 constant JPEG_HCODE99                   \ [0x10 : 8] Huffman code 99
    $18 constant JPEG_HLEN99                    \ [0x18 : 4] Huffman length 99
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_50_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE100                  \ [0x00 : 8] Huffman code 100
    $08 constant JPEG_HLEN100                   \ [0x08 : 4] Huffman length 100
    $10 constant JPEG_HCODE101                  \ [0x10 : 8] Huffman code 101
    $18 constant JPEG_HLEN101                   \ [0x18 : 4] Huffman length 101
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_51_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE102                  \ [0x00 : 8] Huffman code 102
    $08 constant JPEG_HLEN102                   \ [0x08 : 4] Huffman length 102
    $10 constant JPEG_HCODE103                  \ [0x10 : 8] Huffman code 103
    $18 constant JPEG_HLEN103                   \ [0x18 : 4] Huffman length 103
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_52_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE104                  \ [0x00 : 8] Huffman code 104
    $08 constant JPEG_HLEN104                   \ [0x08 : 4] Huffman length 104
    $10 constant JPEG_HCODE105                  \ [0x10 : 8] Huffman code 105
    $18 constant JPEG_HLEN105                   \ [0x18 : 4] Huffman length 105
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_53_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE106                  \ [0x00 : 8] Huffman code 106
    $08 constant JPEG_HLEN106                   \ [0x08 : 4] Huffman length 106
    $10 constant JPEG_HCODE107                  \ [0x10 : 8] Huffman code 107
    $18 constant JPEG_HLEN107                   \ [0x18 : 4] Huffman length 107
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_54_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE108                  \ [0x00 : 8] Huffman code 108
    $08 constant JPEG_HLEN108                   \ [0x08 : 4] Huffman length 108
    $10 constant JPEG_HCODE109                  \ [0x10 : 8] Huffman code 109
    $18 constant JPEG_HLEN109                   \ [0x18 : 4] Huffman length 109
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_55_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE110                  \ [0x00 : 8] Huffman code 110
    $08 constant JPEG_HLEN110                   \ [0x08 : 4] Huffman length 110
    $10 constant JPEG_HCODE111                  \ [0x10 : 8] Huffman code 111
    $18 constant JPEG_HLEN111                   \ [0x18 : 4] Huffman length 111
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_56_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE112                  \ [0x00 : 8] Huffman code 112
    $08 constant JPEG_HLEN112                   \ [0x08 : 4] Huffman length 112
    $10 constant JPEG_HCODE113                  \ [0x10 : 8] Huffman code 113
    $18 constant JPEG_HLEN113                   \ [0x18 : 4] Huffman length 113
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_57_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE114                  \ [0x00 : 8] Huffman code 114
    $08 constant JPEG_HLEN114                   \ [0x08 : 4] Huffman length 114
    $10 constant JPEG_HCODE115                  \ [0x10 : 8] Huffman code 115
    $18 constant JPEG_HLEN115                   \ [0x18 : 4] Huffman length 115
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_58_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE116                  \ [0x00 : 8] Huffman code 116
    $08 constant JPEG_HLEN116                   \ [0x08 : 4] Huffman length 116
    $10 constant JPEG_HCODE117                  \ [0x10 : 8] Huffman code 117
    $18 constant JPEG_HLEN117                   \ [0x18 : 4] Huffman length 117
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_59_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE118                  \ [0x00 : 8] Huffman code 118
    $08 constant JPEG_HLEN118                   \ [0x08 : 4] Huffman length 118
    $10 constant JPEG_HCODE119                  \ [0x10 : 8] Huffman code 119
    $18 constant JPEG_HLEN119                   \ [0x18 : 4] Huffman length 119
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_60_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE120                  \ [0x00 : 8] Huffman code 120
    $08 constant JPEG_HLEN120                   \ [0x08 : 4] Huffman length 120
    $10 constant JPEG_HCODE121                  \ [0x10 : 8] Huffman code 121
    $18 constant JPEG_HLEN121                   \ [0x18 : 4] Huffman length 121
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_61_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE122                  \ [0x00 : 8] Huffman code 122
    $08 constant JPEG_HLEN122                   \ [0x08 : 4] Huffman length 122
    $10 constant JPEG_HCODE123                  \ [0x10 : 8] Huffman code 123
    $18 constant JPEG_HLEN123                   \ [0x18 : 4] Huffman length 123
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_62_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE124                  \ [0x00 : 8] Huffman code 124
    $08 constant JPEG_HLEN124                   \ [0x08 : 4] Huffman length 124
    $10 constant JPEG_HCODE125                  \ [0x10 : 8] Huffman code 125
    $18 constant JPEG_HLEN125                   \ [0x18 : 4] Huffman length 125
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_63_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x5FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE126                  \ [0x00 : 8] Huffman code 126
    $08 constant JPEG_HLEN126                   \ [0x08 : 4] Huffman length 126
    $10 constant JPEG_HCODE127                  \ [0x10 : 8] Huffman code 127
    $18 constant JPEG_HLEN127                   \ [0x18 : 4] Huffman length 127
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_64_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE128                  \ [0x00 : 8] Huffman code 128
    $08 constant JPEG_HLEN128                   \ [0x08 : 4] Huffman length 128
    $10 constant JPEG_HCODE129                  \ [0x10 : 8] Huffman code 129
    $18 constant JPEG_HLEN129                   \ [0x18 : 4] Huffman length 129
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_65_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE130                  \ [0x00 : 8] Huffman code 130
    $08 constant JPEG_HLEN130                   \ [0x08 : 4] Huffman length 130
    $10 constant JPEG_HCODE131                  \ [0x10 : 8] Huffman code 131
    $18 constant JPEG_HLEN131                   \ [0x18 : 4] Huffman length 131
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_66_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE132                  \ [0x00 : 8] Huffman code 132
    $08 constant JPEG_HLEN132                   \ [0x08 : 4] Huffman length 132
    $10 constant JPEG_HCODE133                  \ [0x10 : 8] Huffman code 133
    $18 constant JPEG_HLEN133                   \ [0x18 : 4] Huffman length 133
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_67_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE134                  \ [0x00 : 8] Huffman code 134
    $08 constant JPEG_HLEN134                   \ [0x08 : 4] Huffman length 134
    $10 constant JPEG_HCODE135                  \ [0x10 : 8] Huffman code 135
    $18 constant JPEG_HLEN135                   \ [0x18 : 4] Huffman length 135
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_68_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE136                  \ [0x00 : 8] Huffman code 136
    $08 constant JPEG_HLEN136                   \ [0x08 : 4] Huffman length 136
    $10 constant JPEG_HCODE137                  \ [0x10 : 8] Huffman code 137
    $18 constant JPEG_HLEN137                   \ [0x18 : 4] Huffman length 137
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_69_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE138                  \ [0x00 : 8] Huffman code 138
    $08 constant JPEG_HLEN138                   \ [0x08 : 4] Huffman length 138
    $10 constant JPEG_HCODE139                  \ [0x10 : 8] Huffman code 139
    $18 constant JPEG_HLEN139                   \ [0x18 : 4] Huffman length 139
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_70_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x618
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE140                  \ [0x00 : 8] Huffman code 140
    $08 constant JPEG_HLEN140                   \ [0x08 : 4] Huffman length 140
    $10 constant JPEG_HCODE141                  \ [0x10 : 8] Huffman code 141
    $18 constant JPEG_HLEN141                   \ [0x18 : 4] Huffman length 141
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_71_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE142                  \ [0x00 : 8] Huffman code 142
    $08 constant JPEG_HLEN142                   \ [0x08 : 4] Huffman length 142
    $10 constant JPEG_HCODE143                  \ [0x10 : 8] Huffman code 143
    $18 constant JPEG_HLEN143                   \ [0x18 : 4] Huffman length 143
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_72_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE144                  \ [0x00 : 8] Huffman code 144
    $08 constant JPEG_HLEN144                   \ [0x08 : 4] Huffman length 144
    $10 constant JPEG_HCODE145                  \ [0x10 : 8] Huffman code 145
    $18 constant JPEG_HLEN145                   \ [0x18 : 4] Huffman length 145
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_73_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x624
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE146                  \ [0x00 : 8] Huffman code 146
    $08 constant JPEG_HLEN146                   \ [0x08 : 4] Huffman length 146
    $10 constant JPEG_HCODE147                  \ [0x10 : 8] Huffman code 147
    $18 constant JPEG_HLEN147                   \ [0x18 : 4] Huffman length 147
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_74_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE148                  \ [0x00 : 8] Huffman code 148
    $08 constant JPEG_HLEN148                   \ [0x08 : 4] Huffman length 148
    $10 constant JPEG_HCODE149                  \ [0x10 : 8] Huffman code 149
    $18 constant JPEG_HLEN149                   \ [0x18 : 4] Huffman length 149
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_75_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x62C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE150                  \ [0x00 : 8] Huffman code 150
    $08 constant JPEG_HLEN150                   \ [0x08 : 4] Huffman length 150
    $10 constant JPEG_HCODE151                  \ [0x10 : 8] Huffman code 151
    $18 constant JPEG_HLEN151                   \ [0x18 : 4] Huffman length 151
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_76_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE152                  \ [0x00 : 8] Huffman code 152
    $08 constant JPEG_HLEN152                   \ [0x08 : 4] Huffman length 152
    $10 constant JPEG_HCODE153                  \ [0x10 : 8] Huffman code 153
    $18 constant JPEG_HLEN153                   \ [0x18 : 4] Huffman length 153
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_77_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x634
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE154                  \ [0x00 : 8] Huffman code 154
    $08 constant JPEG_HLEN154                   \ [0x08 : 4] Huffman length 154
    $10 constant JPEG_HCODE155                  \ [0x10 : 8] Huffman code 155
    $18 constant JPEG_HLEN155                   \ [0x18 : 4] Huffman length 155
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_78_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x638
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE156                  \ [0x00 : 8] Huffman code 156
    $08 constant JPEG_HLEN156                   \ [0x08 : 4] Huffman length 156
    $10 constant JPEG_HCODE157                  \ [0x10 : 8] Huffman code 157
    $18 constant JPEG_HLEN157                   \ [0x18 : 4] Huffman length 157
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_79_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x63C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE158                  \ [0x00 : 8] Huffman code 158
    $08 constant JPEG_HLEN158                   \ [0x08 : 4] Huffman length 158
    $10 constant JPEG_HCODE159                  \ [0x10 : 8] Huffman code 159
    $18 constant JPEG_HLEN159                   \ [0x18 : 4] Huffman length 159
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_80_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE160                  \ [0x00 : 8] Huffman code 160
    $08 constant JPEG_HLEN160                   \ [0x08 : 4] Huffman length 160
    $10 constant JPEG_HCODE161                  \ [0x10 : 8] Huffman code 161
    $18 constant JPEG_HLEN161                   \ [0x18 : 4] Huffman length 161
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_81_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x644
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE162                  \ [0x00 : 8] Huffman code 162
    $08 constant JPEG_HLEN162                   \ [0x08 : 4] Huffman length 162
    $10 constant JPEG_HCODE163                  \ [0x10 : 8] Huffman code 163
    $18 constant JPEG_HLEN163                   \ [0x18 : 4] Huffman length 163
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_82_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x648
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE164                  \ [0x00 : 8] Huffman code 164
    $08 constant JPEG_HLEN164                   \ [0x08 : 4] Huffman length 164
    $10 constant JPEG_HCODE165                  \ [0x10 : 8] Huffman code 165
    $18 constant JPEG_HLEN165                   \ [0x18 : 4] Huffman length 165
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_83_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE166                  \ [0x00 : 8] Huffman code 166
    $08 constant JPEG_HLEN166                   \ [0x08 : 4] Huffman length 166
    $10 constant JPEG_HCODE167                  \ [0x10 : 8] Huffman code 167
    $18 constant JPEG_HLEN167                   \ [0x18 : 4] Huffman length 167
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_84_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE168                  \ [0x00 : 8] Huffman code 168
    $08 constant JPEG_HLEN168                   \ [0x08 : 4] Huffman length 168
    $10 constant JPEG_HCODE169                  \ [0x10 : 8] Huffman code 169
    $18 constant JPEG_HLEN169                   \ [0x18 : 4] Huffman length 169
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_85_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE170                  \ [0x00 : 8] Huffman code 170
    $08 constant JPEG_HLEN170                   \ [0x08 : 4] Huffman length 170
    $10 constant JPEG_HCODE171                  \ [0x10 : 8] Huffman code 171
    $18 constant JPEG_HLEN171                   \ [0x18 : 4] Huffman length 171
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_86_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x658
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE172                  \ [0x00 : 8] Huffman code 172
    $08 constant JPEG_HLEN172                   \ [0x08 : 4] Huffman length 172
    $10 constant JPEG_HCODE173                  \ [0x10 : 8] Huffman code 173
    $18 constant JPEG_HLEN173                   \ [0x18 : 4] Huffman length 173
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC0_87_DEF
    \
    \ @brief JPEG Huffman encoder AC0
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE174                  \ [0x00 : 8] Huffman code 174
    $08 constant JPEG_HLEN174                   \ [0x08 : 4] Huffman length 174
    $10 constant JPEG_HCODE175                  \ [0x10 : 8] Huffman code 175
    $18 constant JPEG_HLEN175                   \ [0x18 : 4] Huffman length 175
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_0_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE0                    \ [0x00 : 8] Huffman code 0
    $08 constant JPEG_HLEN0                     \ [0x08 : 4] Huffman length 0
    $10 constant JPEG_HCODE1                    \ [0x10 : 8] Huffman code 1
    $18 constant JPEG_HLEN1                     \ [0x18 : 4] Huffman length 1
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_1_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE2                    \ [0x00 : 8] Huffman code 2
    $08 constant JPEG_HLEN2                     \ [0x08 : 4] Huffman length 2
    $10 constant JPEG_HCODE3                    \ [0x10 : 8] Huffman code 3
    $18 constant JPEG_HLEN3                     \ [0x18 : 4] Huffman length 3
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_2_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE4                    \ [0x00 : 8] Huffman code 4
    $08 constant JPEG_HLEN4                     \ [0x08 : 4] Huffman length 4
    $10 constant JPEG_HCODE5                    \ [0x10 : 8] Huffman code 5
    $18 constant JPEG_HLEN5                     \ [0x18 : 4] Huffman length 5
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_3_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x66C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE6                    \ [0x00 : 8] Huffman code 6
    $08 constant JPEG_HLEN6                     \ [0x08 : 4] Huffman length 6
    $10 constant JPEG_HCODE7                    \ [0x10 : 8] Huffman code 7
    $18 constant JPEG_HLEN7                     \ [0x18 : 4] Huffman length 7
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_4_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x670
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE8                    \ [0x00 : 8] Huffman code 8
    $08 constant JPEG_HLEN8                     \ [0x08 : 4] Huffman length 8
    $10 constant JPEG_HCODE9                    \ [0x10 : 8] Huffman code 9
    $18 constant JPEG_HLEN9                     \ [0x18 : 4] Huffman length 9
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_5_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x674
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE10                   \ [0x00 : 8] Huffman code 10
    $08 constant JPEG_HLEN10                    \ [0x08 : 4] Huffman length 10
    $10 constant JPEG_HCODE11                   \ [0x10 : 8] Huffman code 11
    $18 constant JPEG_HLEN11                    \ [0x18 : 4] Huffman length 11
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_6_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x678
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE12                   \ [0x00 : 8] Huffman code 12
    $08 constant JPEG_HLEN12                    \ [0x08 : 4] Huffman length 12
    $10 constant JPEG_HCODE13                   \ [0x10 : 8] Huffman code 13
    $18 constant JPEG_HLEN13                    \ [0x18 : 4] Huffman length 13
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_7_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x67C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE14                   \ [0x00 : 8] Huffman code 14
    $08 constant JPEG_HLEN14                    \ [0x08 : 4] Huffman length 14
    $10 constant JPEG_HCODE15                   \ [0x10 : 8] Huffman code 15
    $18 constant JPEG_HLEN15                    \ [0x18 : 4] Huffman length 15
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_8_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x680
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE16                   \ [0x00 : 8] Huffman code 16
    $08 constant JPEG_HLEN16                    \ [0x08 : 4] Huffman length 16
    $10 constant JPEG_HCODE17                   \ [0x10 : 8] Huffman code 17
    $18 constant JPEG_HLEN17                    \ [0x18 : 4] Huffman length 17
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_9_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x684
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE18                   \ [0x00 : 8] Huffman code 18
    $08 constant JPEG_HLEN18                    \ [0x08 : 4] Huffman length 18
    $10 constant JPEG_HCODE19                   \ [0x10 : 8] Huffman code 19
    $18 constant JPEG_HLEN19                    \ [0x18 : 4] Huffman length 19
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_10_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x688
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE20                   \ [0x00 : 8] Huffman code 20
    $08 constant JPEG_HLEN20                    \ [0x08 : 4] Huffman length 20
    $10 constant JPEG_HCODE21                   \ [0x10 : 8] Huffman code 21
    $18 constant JPEG_HLEN21                    \ [0x18 : 4] Huffman length 21
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_11_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x68C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE22                   \ [0x00 : 8] Huffman code 22
    $08 constant JPEG_HLEN22                    \ [0x08 : 4] Huffman length 22
    $10 constant JPEG_HCODE23                   \ [0x10 : 8] Huffman code 23
    $18 constant JPEG_HLEN23                    \ [0x18 : 4] Huffman length 23
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_12_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x690
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE24                   \ [0x00 : 8] Huffman code 24
    $08 constant JPEG_HLEN24                    \ [0x08 : 4] Huffman length 24
    $10 constant JPEG_HCODE25                   \ [0x10 : 8] Huffman code 25
    $18 constant JPEG_HLEN25                    \ [0x18 : 4] Huffman length 25
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_13_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE26                   \ [0x00 : 8] Huffman code 26
    $08 constant JPEG_HLEN26                    \ [0x08 : 4] Huffman length 26
    $10 constant JPEG_HCODE27                   \ [0x10 : 8] Huffman code 27
    $18 constant JPEG_HLEN27                    \ [0x18 : 4] Huffman length 27
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_14_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x698
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE28                   \ [0x00 : 8] Huffman code 28
    $08 constant JPEG_HLEN28                    \ [0x08 : 4] Huffman length 28
    $10 constant JPEG_HCODE29                   \ [0x10 : 8] Huffman code 29
    $18 constant JPEG_HLEN29                    \ [0x18 : 4] Huffman length 29
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_15_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x69C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE30                   \ [0x00 : 8] Huffman code 30
    $08 constant JPEG_HLEN30                    \ [0x08 : 4] Huffman length 30
    $10 constant JPEG_HCODE31                   \ [0x10 : 8] Huffman code 31
    $18 constant JPEG_HLEN31                    \ [0x18 : 4] Huffman length 31
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_16_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE32                   \ [0x00 : 8] Huffman code 32
    $08 constant JPEG_HLEN32                    \ [0x08 : 4] Huffman length 32
    $10 constant JPEG_HCODE33                   \ [0x10 : 8] Huffman code 33
    $18 constant JPEG_HLEN33                    \ [0x18 : 4] Huffman length 33
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_17_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE34                   \ [0x00 : 8] Huffman code 34
    $08 constant JPEG_HLEN34                    \ [0x08 : 4] Huffman length 34
    $10 constant JPEG_HCODE35                   \ [0x10 : 8] Huffman code 35
    $18 constant JPEG_HLEN35                    \ [0x18 : 4] Huffman length 35
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_18_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE36                   \ [0x00 : 8] Huffman code 36
    $08 constant JPEG_HLEN36                    \ [0x08 : 4] Huffman length 36
    $10 constant JPEG_HCODE37                   \ [0x10 : 8] Huffman code 37
    $18 constant JPEG_HLEN37                    \ [0x18 : 4] Huffman length 37
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_19_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE38                   \ [0x00 : 8] Huffman code 38
    $08 constant JPEG_HLEN38                    \ [0x08 : 4] Huffman length 38
    $10 constant JPEG_HCODE39                   \ [0x10 : 8] Huffman code 39
    $18 constant JPEG_HLEN39                    \ [0x18 : 4] Huffman length 39
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_20_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE40                   \ [0x00 : 8] Huffman code 40
    $08 constant JPEG_HLEN40                    \ [0x08 : 4] Huffman length 40
    $10 constant JPEG_HCODE41                   \ [0x10 : 8] Huffman code 41
    $18 constant JPEG_HLEN41                    \ [0x18 : 4] Huffman length 41
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_21_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE42                   \ [0x00 : 8] Huffman code 42
    $08 constant JPEG_HLEN42                    \ [0x08 : 4] Huffman length 42
    $10 constant JPEG_HCODE43                   \ [0x10 : 8] Huffman code 43
    $18 constant JPEG_HLEN43                    \ [0x18 : 4] Huffman length 43
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_22_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE44                   \ [0x00 : 8] Huffman code 44
    $08 constant JPEG_HLEN44                    \ [0x08 : 4] Huffman length 44
    $10 constant JPEG_HCODE45                   \ [0x10 : 8] Huffman code 45
    $18 constant JPEG_HLEN45                    \ [0x18 : 4] Huffman length 45
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_23_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE46                   \ [0x00 : 8] Huffman code 46
    $08 constant JPEG_HLEN46                    \ [0x08 : 4] Huffman length 46
    $10 constant JPEG_HCODE47                   \ [0x10 : 8] Huffman code 47
    $18 constant JPEG_HLEN47                    \ [0x18 : 4] Huffman length 47
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_24_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE48                   \ [0x00 : 8] Huffman code 48
    $08 constant JPEG_HLEN48                    \ [0x08 : 4] Huffman length 48
    $10 constant JPEG_HCODE49                   \ [0x10 : 8] Huffman code 49
    $18 constant JPEG_HLEN49                    \ [0x18 : 4] Huffman length 49
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_25_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE50                   \ [0x00 : 8] Huffman code 50
    $08 constant JPEG_HLEN50                    \ [0x08 : 4] Huffman length 50
    $10 constant JPEG_HCODE51                   \ [0x10 : 8] Huffman code 51
    $18 constant JPEG_HLEN51                    \ [0x18 : 4] Huffman length 51
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_26_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE52                   \ [0x00 : 8] Huffman code 52
    $08 constant JPEG_HLEN52                    \ [0x08 : 4] Huffman length 52
    $10 constant JPEG_HCODE53                   \ [0x10 : 8] Huffman code 53
    $18 constant JPEG_HLEN53                    \ [0x18 : 4] Huffman length 53
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_27_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE54                   \ [0x00 : 8] Huffman code 54
    $08 constant JPEG_HLEN54                    \ [0x08 : 4] Huffman length 54
    $10 constant JPEG_HCODE55                   \ [0x10 : 8] Huffman code 55
    $18 constant JPEG_HLEN55                    \ [0x18 : 4] Huffman length 55
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_28_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE56                   \ [0x00 : 8] Huffman code 56
    $08 constant JPEG_HLEN56                    \ [0x08 : 4] Huffman length 56
    $10 constant JPEG_HCODE57                   \ [0x10 : 8] Huffman code 57
    $18 constant JPEG_HLEN57                    \ [0x18 : 4] Huffman length 57
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_29_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE58                   \ [0x00 : 8] Huffman code 58
    $08 constant JPEG_HLEN58                    \ [0x08 : 4] Huffman length 58
    $10 constant JPEG_HCODE59                   \ [0x10 : 8] Huffman code 59
    $18 constant JPEG_HLEN59                    \ [0x18 : 4] Huffman length 59
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_30_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE60                   \ [0x00 : 8] Huffman code 60
    $08 constant JPEG_HLEN60                    \ [0x08 : 4] Huffman length 60
    $10 constant JPEG_HCODE61                   \ [0x10 : 8] Huffman code 61
    $18 constant JPEG_HLEN61                    \ [0x18 : 4] Huffman length 61
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_31_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE62                   \ [0x00 : 8] Huffman code 62
    $08 constant JPEG_HLEN62                    \ [0x08 : 4] Huffman length 62
    $10 constant JPEG_HCODE63                   \ [0x10 : 8] Huffman code 63
    $18 constant JPEG_HLEN63                    \ [0x18 : 4] Huffman length 63
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_32_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE64                   \ [0x00 : 8] Huffman code 64
    $08 constant JPEG_HLEN64                    \ [0x08 : 4] Huffman length 64
    $10 constant JPEG_HCODE65                   \ [0x10 : 8] Huffman code 65
    $18 constant JPEG_HLEN65                    \ [0x18 : 4] Huffman length 65
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_33_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE66                   \ [0x00 : 8] Huffman code 66
    $08 constant JPEG_HLEN66                    \ [0x08 : 4] Huffman length 66
    $10 constant JPEG_HCODE67                   \ [0x10 : 8] Huffman code 67
    $18 constant JPEG_HLEN67                    \ [0x18 : 4] Huffman length 67
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_34_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE68                   \ [0x00 : 8] Huffman code 68
    $08 constant JPEG_HLEN68                    \ [0x08 : 4] Huffman length 68
    $10 constant JPEG_HCODE69                   \ [0x10 : 8] Huffman code 69
    $18 constant JPEG_HLEN69                    \ [0x18 : 4] Huffman length 69
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_35_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE70                   \ [0x00 : 8] Huffman code 70
    $08 constant JPEG_HLEN70                    \ [0x08 : 4] Huffman length 70
    $10 constant JPEG_HCODE71                   \ [0x10 : 8] Huffman code 71
    $18 constant JPEG_HLEN71                    \ [0x18 : 4] Huffman length 71
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_36_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE72                   \ [0x00 : 8] Huffman code 72
    $08 constant JPEG_HLEN72                    \ [0x08 : 4] Huffman length 72
    $10 constant JPEG_HCODE73                   \ [0x10 : 8] Huffman code 73
    $18 constant JPEG_HLEN73                    \ [0x18 : 4] Huffman length 73
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_37_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE74                   \ [0x00 : 8] Huffman code 74
    $08 constant JPEG_HLEN74                    \ [0x08 : 4] Huffman length 74
    $10 constant JPEG_HCODE75                   \ [0x10 : 8] Huffman code 75
    $18 constant JPEG_HLEN75                    \ [0x18 : 4] Huffman length 75
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_38_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE76                   \ [0x00 : 8] Huffman code 76
    $08 constant JPEG_HLEN76                    \ [0x08 : 4] Huffman length 76
    $10 constant JPEG_HCODE77                   \ [0x10 : 8] Huffman code 77
    $18 constant JPEG_HLEN77                    \ [0x18 : 4] Huffman length 77
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_39_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x6FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE78                   \ [0x00 : 8] Huffman code 78
    $08 constant JPEG_HLEN78                    \ [0x08 : 4] Huffman length 78
    $10 constant JPEG_HCODE79                   \ [0x10 : 8] Huffman code 79
    $18 constant JPEG_HLEN79                    \ [0x18 : 4] Huffman length 79
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_40_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x700
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE80                   \ [0x00 : 8] Huffman code 80
    $08 constant JPEG_HLEN80                    \ [0x08 : 4] Huffman length 80
    $10 constant JPEG_HCODE81                   \ [0x10 : 8] Huffman code 81
    $18 constant JPEG_HLEN81                    \ [0x18 : 4] Huffman length 81
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_41_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x704
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE82                   \ [0x00 : 8] Huffman code 82
    $08 constant JPEG_HLEN82                    \ [0x08 : 4] Huffman length 82
    $10 constant JPEG_HCODE83                   \ [0x10 : 8] Huffman code 83
    $18 constant JPEG_HLEN83                    \ [0x18 : 4] Huffman length 83
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_42_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x708
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE84                   \ [0x00 : 8] Huffman code 84
    $08 constant JPEG_HLEN84                    \ [0x08 : 4] Huffman length 84
    $10 constant JPEG_HCODE85                   \ [0x10 : 8] Huffman code 85
    $18 constant JPEG_HLEN85                    \ [0x18 : 4] Huffman length 85
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_43_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x70C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE86                   \ [0x00 : 8] Huffman code 86
    $08 constant JPEG_HLEN86                    \ [0x08 : 4] Huffman length 86
    $10 constant JPEG_HCODE87                   \ [0x10 : 8] Huffman code 87
    $18 constant JPEG_HLEN87                    \ [0x18 : 4] Huffman length 87
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_44_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x710
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE88                   \ [0x00 : 8] Huffman code 88
    $08 constant JPEG_HLEN88                    \ [0x08 : 4] Huffman length 88
    $10 constant JPEG_HCODE89                   \ [0x10 : 8] Huffman code 89
    $18 constant JPEG_HLEN89                    \ [0x18 : 4] Huffman length 89
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_45_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x714
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE90                   \ [0x00 : 8] Huffman code 90
    $08 constant JPEG_HLEN90                    \ [0x08 : 4] Huffman length 90
    $10 constant JPEG_HCODE91                   \ [0x10 : 8] Huffman code 91
    $18 constant JPEG_HLEN91                    \ [0x18 : 4] Huffman length 91
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_46_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x718
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE92                   \ [0x00 : 8] Huffman code 92
    $08 constant JPEG_HLEN92                    \ [0x08 : 4] Huffman length 92
    $10 constant JPEG_HCODE93                   \ [0x10 : 8] Huffman code 93
    $18 constant JPEG_HLEN93                    \ [0x18 : 4] Huffman length 93
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_47_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x71C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE94                   \ [0x00 : 8] Huffman code 94
    $08 constant JPEG_HLEN94                    \ [0x08 : 4] Huffman length 94
    $10 constant JPEG_HCODE95                   \ [0x10 : 8] Huffman code 95
    $18 constant JPEG_HLEN95                    \ [0x18 : 4] Huffman length 95
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_48_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x720
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE96                   \ [0x00 : 8] Huffman code 96
    $08 constant JPEG_HLEN96                    \ [0x08 : 4] Huffman length 96
    $10 constant JPEG_HCODE97                   \ [0x10 : 8] Huffman code 97
    $18 constant JPEG_HLEN97                    \ [0x18 : 4] Huffman length 97
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_49_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x724
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE98                   \ [0x00 : 8] Huffman code 98
    $08 constant JPEG_HLEN98                    \ [0x08 : 4] Huffman length 98
    $10 constant JPEG_HCODE99                   \ [0x10 : 8] Huffman code 99
    $18 constant JPEG_HLEN99                    \ [0x18 : 4] Huffman length 99
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_50_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x728
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE100                  \ [0x00 : 8] Huffman code 100
    $08 constant JPEG_HLEN100                   \ [0x08 : 4] Huffman length 100
    $10 constant JPEG_HCODE101                  \ [0x10 : 8] Huffman code 101
    $18 constant JPEG_HLEN101                   \ [0x18 : 4] Huffman length 101
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_51_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x72C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE102                  \ [0x00 : 8] Huffman code 102
    $08 constant JPEG_HLEN102                   \ [0x08 : 4] Huffman length 102
    $10 constant JPEG_HCODE103                  \ [0x10 : 8] Huffman code 103
    $18 constant JPEG_HLEN103                   \ [0x18 : 4] Huffman length 103
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_52_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x730
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE104                  \ [0x00 : 8] Huffman code 104
    $08 constant JPEG_HLEN104                   \ [0x08 : 4] Huffman length 104
    $10 constant JPEG_HCODE105                  \ [0x10 : 8] Huffman code 105
    $18 constant JPEG_HLEN105                   \ [0x18 : 4] Huffman length 105
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_53_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x734
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE106                  \ [0x00 : 8] Huffman code 106
    $08 constant JPEG_HLEN106                   \ [0x08 : 4] Huffman length 106
    $10 constant JPEG_HCODE107                  \ [0x10 : 8] Huffman code 107
    $18 constant JPEG_HLEN107                   \ [0x18 : 4] Huffman length 107
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_54_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x738
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE108                  \ [0x00 : 8] Huffman code 108
    $08 constant JPEG_HLEN108                   \ [0x08 : 4] Huffman length 108
    $10 constant JPEG_HCODE109                  \ [0x10 : 8] Huffman code 109
    $18 constant JPEG_HLEN109                   \ [0x18 : 4] Huffman length 109
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_55_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x73C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE110                  \ [0x00 : 8] Huffman code 110
    $08 constant JPEG_HLEN110                   \ [0x08 : 4] Huffman length 110
    $10 constant JPEG_HCODE111                  \ [0x10 : 8] Huffman code 111
    $18 constant JPEG_HLEN111                   \ [0x18 : 4] Huffman length 111
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_56_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x740
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE112                  \ [0x00 : 8] Huffman code 112
    $08 constant JPEG_HLEN112                   \ [0x08 : 4] Huffman length 112
    $10 constant JPEG_HCODE113                  \ [0x10 : 8] Huffman code 113
    $18 constant JPEG_HLEN113                   \ [0x18 : 4] Huffman length 113
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_57_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x744
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE114                  \ [0x00 : 8] Huffman code 114
    $08 constant JPEG_HLEN114                   \ [0x08 : 4] Huffman length 114
    $10 constant JPEG_HCODE115                  \ [0x10 : 8] Huffman code 115
    $18 constant JPEG_HLEN115                   \ [0x18 : 4] Huffman length 115
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_58_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x748
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE116                  \ [0x00 : 8] Huffman code 116
    $08 constant JPEG_HLEN116                   \ [0x08 : 4] Huffman length 116
    $10 constant JPEG_HCODE117                  \ [0x10 : 8] Huffman code 117
    $18 constant JPEG_HLEN117                   \ [0x18 : 4] Huffman length 117
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_59_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE118                  \ [0x00 : 8] Huffman code 118
    $08 constant JPEG_HLEN118                   \ [0x08 : 4] Huffman length 118
    $10 constant JPEG_HCODE119                  \ [0x10 : 8] Huffman code 119
    $18 constant JPEG_HLEN119                   \ [0x18 : 4] Huffman length 119
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_60_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE120                  \ [0x00 : 8] Huffman code 120
    $08 constant JPEG_HLEN120                   \ [0x08 : 4] Huffman length 120
    $10 constant JPEG_HCODE121                  \ [0x10 : 8] Huffman code 121
    $18 constant JPEG_HLEN121                   \ [0x18 : 4] Huffman length 121
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_61_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x754
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE122                  \ [0x00 : 8] Huffman code 122
    $08 constant JPEG_HLEN122                   \ [0x08 : 4] Huffman length 122
    $10 constant JPEG_HCODE123                  \ [0x10 : 8] Huffman code 123
    $18 constant JPEG_HLEN123                   \ [0x18 : 4] Huffman length 123
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_62_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x758
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE124                  \ [0x00 : 8] Huffman code 124
    $08 constant JPEG_HLEN124                   \ [0x08 : 4] Huffman length 124
    $10 constant JPEG_HCODE125                  \ [0x10 : 8] Huffman code 125
    $18 constant JPEG_HLEN125                   \ [0x18 : 4] Huffman length 125
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_63_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x75C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE126                  \ [0x00 : 8] Huffman code 126
    $08 constant JPEG_HLEN126                   \ [0x08 : 4] Huffman length 126
    $10 constant JPEG_HCODE127                  \ [0x10 : 8] Huffman code 127
    $18 constant JPEG_HLEN127                   \ [0x18 : 4] Huffman length 127
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_64_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x760
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE128                  \ [0x00 : 8] Huffman code 128
    $08 constant JPEG_HLEN128                   \ [0x08 : 4] Huffman length 128
    $10 constant JPEG_HCODE129                  \ [0x10 : 8] Huffman code 129
    $18 constant JPEG_HLEN129                   \ [0x18 : 4] Huffman length 129
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_65_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x764
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE130                  \ [0x00 : 8] Huffman code 130
    $08 constant JPEG_HLEN130                   \ [0x08 : 4] Huffman length 130
    $10 constant JPEG_HCODE131                  \ [0x10 : 8] Huffman code 131
    $18 constant JPEG_HLEN131                   \ [0x18 : 4] Huffman length 131
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_66_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x768
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE132                  \ [0x00 : 8] Huffman code 132
    $08 constant JPEG_HLEN132                   \ [0x08 : 4] Huffman length 132
    $10 constant JPEG_HCODE133                  \ [0x10 : 8] Huffman code 133
    $18 constant JPEG_HLEN133                   \ [0x18 : 4] Huffman length 133
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_67_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x76C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE134                  \ [0x00 : 8] Huffman code 134
    $08 constant JPEG_HLEN134                   \ [0x08 : 4] Huffman length 134
    $10 constant JPEG_HCODE135                  \ [0x10 : 8] Huffman code 135
    $18 constant JPEG_HLEN135                   \ [0x18 : 4] Huffman length 135
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_68_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x770
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE136                  \ [0x00 : 8] Huffman code 136
    $08 constant JPEG_HLEN136                   \ [0x08 : 4] Huffman length 136
    $10 constant JPEG_HCODE137                  \ [0x10 : 8] Huffman code 137
    $18 constant JPEG_HLEN137                   \ [0x18 : 4] Huffman length 137
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_69_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x774
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE138                  \ [0x00 : 8] Huffman code 138
    $08 constant JPEG_HLEN138                   \ [0x08 : 4] Huffman length 138
    $10 constant JPEG_HCODE139                  \ [0x10 : 8] Huffman code 139
    $18 constant JPEG_HLEN139                   \ [0x18 : 4] Huffman length 139
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_70_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x778
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE140                  \ [0x00 : 8] Huffman code 140
    $08 constant JPEG_HLEN140                   \ [0x08 : 4] Huffman length 140
    $10 constant JPEG_HCODE141                  \ [0x10 : 8] Huffman code 141
    $18 constant JPEG_HLEN141                   \ [0x18 : 4] Huffman length 141
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_71_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x77C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE142                  \ [0x00 : 8] Huffman code 142
    $08 constant JPEG_HLEN142                   \ [0x08 : 4] Huffman length 142
    $10 constant JPEG_HCODE143                  \ [0x10 : 8] Huffman code 143
    $18 constant JPEG_HLEN143                   \ [0x18 : 4] Huffman length 143
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_72_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x780
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE144                  \ [0x00 : 8] Huffman code 144
    $08 constant JPEG_HLEN144                   \ [0x08 : 4] Huffman length 144
    $10 constant JPEG_HCODE145                  \ [0x10 : 8] Huffman code 145
    $18 constant JPEG_HLEN145                   \ [0x18 : 4] Huffman length 145
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_73_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x784
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE146                  \ [0x00 : 8] Huffman code 146
    $08 constant JPEG_HLEN146                   \ [0x08 : 4] Huffman length 146
    $10 constant JPEG_HCODE147                  \ [0x10 : 8] Huffman code 147
    $18 constant JPEG_HLEN147                   \ [0x18 : 4] Huffman length 147
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_74_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x788
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE148                  \ [0x00 : 8] Huffman code 148
    $08 constant JPEG_HLEN148                   \ [0x08 : 4] Huffman length 148
    $10 constant JPEG_HCODE149                  \ [0x10 : 8] Huffman code 149
    $18 constant JPEG_HLEN149                   \ [0x18 : 4] Huffman length 149
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_75_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x78C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE150                  \ [0x00 : 8] Huffman code 150
    $08 constant JPEG_HLEN150                   \ [0x08 : 4] Huffman length 150
    $10 constant JPEG_HCODE151                  \ [0x10 : 8] Huffman code 151
    $18 constant JPEG_HLEN151                   \ [0x18 : 4] Huffman length 151
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_76_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x790
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE152                  \ [0x00 : 8] Huffman code 152
    $08 constant JPEG_HLEN152                   \ [0x08 : 4] Huffman length 152
    $10 constant JPEG_HCODE153                  \ [0x10 : 8] Huffman code 153
    $18 constant JPEG_HLEN153                   \ [0x18 : 4] Huffman length 153
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_77_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE154                  \ [0x00 : 8] Huffman code 154
    $08 constant JPEG_HLEN154                   \ [0x08 : 4] Huffman length 154
    $10 constant JPEG_HCODE155                  \ [0x10 : 8] Huffman code 155
    $18 constant JPEG_HLEN155                   \ [0x18 : 4] Huffman length 155
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_78_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE156                  \ [0x00 : 8] Huffman code 156
    $08 constant JPEG_HLEN156                   \ [0x08 : 4] Huffman length 156
    $10 constant JPEG_HCODE157                  \ [0x10 : 8] Huffman code 157
    $18 constant JPEG_HLEN157                   \ [0x18 : 4] Huffman length 157
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_79_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x79C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE158                  \ [0x00 : 8] Huffman code 158
    $08 constant JPEG_HLEN158                   \ [0x08 : 4] Huffman length 158
    $10 constant JPEG_HCODE159                  \ [0x10 : 8] Huffman code 159
    $18 constant JPEG_HLEN159                   \ [0x18 : 4] Huffman length 159
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_80_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x7A0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE160                  \ [0x00 : 8] Huffman code 160
    $08 constant JPEG_HLEN160                   \ [0x08 : 4] Huffman length 160
    $10 constant JPEG_HCODE161                  \ [0x10 : 8] Huffman code 161
    $18 constant JPEG_HLEN161                   \ [0x18 : 4] Huffman length 161
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_81_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x7A4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE162                  \ [0x00 : 8] Huffman code 162
    $08 constant JPEG_HLEN162                   \ [0x08 : 4] Huffman length 162
    $10 constant JPEG_HCODE163                  \ [0x10 : 8] Huffman code 163
    $18 constant JPEG_HLEN163                   \ [0x18 : 4] Huffman length 163
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_82_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x7A8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE164                  \ [0x00 : 8] Huffman code 164
    $08 constant JPEG_HLEN164                   \ [0x08 : 4] Huffman length 164
    $10 constant JPEG_HCODE165                  \ [0x10 : 8] Huffman code 165
    $18 constant JPEG_HLEN165                   \ [0x18 : 4] Huffman length 165
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_83_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x7AC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE166                  \ [0x00 : 8] Huffman code 166
    $08 constant JPEG_HLEN166                   \ [0x08 : 4] Huffman length 166
    $10 constant JPEG_HCODE167                  \ [0x10 : 8] Huffman code 167
    $18 constant JPEG_HLEN167                   \ [0x18 : 4] Huffman length 167
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_84_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x7B0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE168                  \ [0x00 : 8] Huffman code 168
    $08 constant JPEG_HLEN168                   \ [0x08 : 4] Huffman length 168
    $10 constant JPEG_HCODE169                  \ [0x10 : 8] Huffman code 169
    $18 constant JPEG_HLEN169                   \ [0x18 : 4] Huffman length 169
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_85_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x7B4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE170                  \ [0x00 : 8] Huffman code 170
    $08 constant JPEG_HLEN170                   \ [0x08 : 4] Huffman length 170
    $10 constant JPEG_HCODE171                  \ [0x10 : 8] Huffman code 171
    $18 constant JPEG_HLEN171                   \ [0x18 : 4] Huffman length 171
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_86_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x7B8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE172                  \ [0x00 : 8] Huffman code 172
    $08 constant JPEG_HLEN172                   \ [0x08 : 4] Huffman length 172
    $10 constant JPEG_HCODE173                  \ [0x10 : 8] Huffman code 173
    $18 constant JPEG_HLEN173                   \ [0x18 : 4] Huffman length 173
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_AC1_87_DEF
    \
    \ @brief JPEG Huffman encoder AC1
    \ Address offset: 0x7BC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE174                  \ [0x00 : 8] Huffman code 174
    $08 constant JPEG_HLEN174                   \ [0x08 : 4] Huffman length 174
    $10 constant JPEG_HCODE175                  \ [0x10 : 8] Huffman code 175
    $18 constant JPEG_HLEN175                   \ [0x18 : 4] Huffman length 175
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC0_0_DEF
    \
    \ @brief JPEG Huffman encoder DC0
    \ Address offset: 0x7C0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE0                    \ [0x00 : 8] Huffman code 0
    $08 constant JPEG_HLEN0                     \ [0x08 : 4] Huffman length 0
    $10 constant JPEG_HCODE1                    \ [0x10 : 8] Huffman code 1
    $18 constant JPEG_HLEN1                     \ [0x18 : 4] Huffman length 1
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC0_1_DEF
    \
    \ @brief JPEG Huffman encoder DC0
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE2                    \ [0x00 : 8] Huffman code 2
    $08 constant JPEG_HLEN2                     \ [0x08 : 4] Huffman length 2
    $10 constant JPEG_HCODE3                    \ [0x10 : 8] Huffman code 3
    $18 constant JPEG_HLEN3                     \ [0x18 : 4] Huffman length 3
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC0_2_DEF
    \
    \ @brief JPEG Huffman encoder DC0
    \ Address offset: 0x7C8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE4                    \ [0x00 : 8] Huffman code 4
    $08 constant JPEG_HLEN4                     \ [0x08 : 4] Huffman length 4
    $10 constant JPEG_HCODE5                    \ [0x10 : 8] Huffman code 5
    $18 constant JPEG_HLEN5                     \ [0x18 : 4] Huffman length 5
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC0_3_DEF
    \
    \ @brief JPEG Huffman encoder DC0
    \ Address offset: 0x7CC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE6                    \ [0x00 : 8] Huffman code 6
    $08 constant JPEG_HLEN6                     \ [0x08 : 4] Huffman length 6
    $10 constant JPEG_HCODE7                    \ [0x10 : 8] Huffman code 7
    $18 constant JPEG_HLEN7                     \ [0x18 : 4] Huffman length 7
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC0_4_DEF
    \
    \ @brief JPEG Huffman encoder DC0
    \ Address offset: 0x7D0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE8                    \ [0x00 : 8] Huffman code 8
    $08 constant JPEG_HLEN8                     \ [0x08 : 4] Huffman length 8
    $10 constant JPEG_HCODE9                    \ [0x10 : 8] Huffman code 9
    $18 constant JPEG_HLEN9                     \ [0x18 : 4] Huffman length 9
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC0_5_DEF
    \
    \ @brief JPEG Huffman encoder DC0
    \ Address offset: 0x7D4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE10                   \ [0x00 : 8] Huffman code 10
    $08 constant JPEG_HLEN10                    \ [0x08 : 4] Huffman length 10
    $10 constant JPEG_HCODE11                   \ [0x10 : 8] Huffman code 11
    $18 constant JPEG_HLEN11                    \ [0x18 : 4] Huffman length 11
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC0_6_DEF
    \
    \ @brief JPEG Huffman encoder DC0
    \ Address offset: 0x7D8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE12                   \ [0x00 : 8] Huffman code 12
    $08 constant JPEG_HLEN12                    \ [0x08 : 4] Huffman length 12
    $10 constant JPEG_HCODE13                   \ [0x10 : 8] Huffman code 13
    $18 constant JPEG_HLEN13                    \ [0x18 : 4] Huffman length 13
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC0_7_DEF
    \
    \ @brief JPEG Huffman encoder DC0
    \ Address offset: 0x7DC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE14                   \ [0x00 : 8] Huffman code 14
    $08 constant JPEG_HLEN14                    \ [0x08 : 4] Huffman length 14
    $10 constant JPEG_HCODE15                   \ [0x10 : 8] Huffman code 15
    $18 constant JPEG_HLEN15                    \ [0x18 : 4] Huffman length 15
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC1_0_DEF
    \
    \ @brief JPEG Huffman encoder DC1
    \ Address offset: 0x7E0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE0                    \ [0x00 : 8] Huffman code 0
    $08 constant JPEG_HLEN0                     \ [0x08 : 4] Huffman length 0
    $10 constant JPEG_HCODE1                    \ [0x10 : 8] Huffman code 1
    $18 constant JPEG_HLEN1                     \ [0x18 : 4] Huffman length 1
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC1_1_DEF
    \
    \ @brief JPEG Huffman encoder DC1
    \ Address offset: 0x7E4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE2                    \ [0x00 : 8] Huffman code 2
    $08 constant JPEG_HLEN2                     \ [0x08 : 4] Huffman length 2
    $10 constant JPEG_HCODE3                    \ [0x10 : 8] Huffman code 3
    $18 constant JPEG_HLEN3                     \ [0x18 : 4] Huffman length 3
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC1_2_DEF
    \
    \ @brief JPEG Huffman encoder DC1
    \ Address offset: 0x7E8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE4                    \ [0x00 : 8] Huffman code 4
    $08 constant JPEG_HLEN4                     \ [0x08 : 4] Huffman length 4
    $10 constant JPEG_HCODE5                    \ [0x10 : 8] Huffman code 5
    $18 constant JPEG_HLEN5                     \ [0x18 : 4] Huffman length 5
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC1_3_DEF
    \
    \ @brief JPEG Huffman encoder DC1
    \ Address offset: 0x7EC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE6                    \ [0x00 : 8] Huffman code 6
    $08 constant JPEG_HLEN6                     \ [0x08 : 4] Huffman length 6
    $10 constant JPEG_HCODE7                    \ [0x10 : 8] Huffman code 7
    $18 constant JPEG_HLEN7                     \ [0x18 : 4] Huffman length 7
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC1_4_DEF
    \
    \ @brief JPEG Huffman encoder DC1
    \ Address offset: 0x7F0
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE8                    \ [0x00 : 8] Huffman code 8
    $08 constant JPEG_HLEN8                     \ [0x08 : 4] Huffman length 8
    $10 constant JPEG_HCODE9                    \ [0x10 : 8] Huffman code 9
    $18 constant JPEG_HLEN9                     \ [0x18 : 4] Huffman length 9
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC1_5_DEF
    \
    \ @brief JPEG Huffman encoder DC1
    \ Address offset: 0x7F4
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE10                   \ [0x00 : 8] Huffman code 10
    $08 constant JPEG_HLEN10                    \ [0x08 : 4] Huffman length 10
    $10 constant JPEG_HCODE11                   \ [0x10 : 8] Huffman code 11
    $18 constant JPEG_HLEN11                    \ [0x18 : 4] Huffman length 11
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC1_6_DEF
    \
    \ @brief JPEG Huffman encoder DC1
    \ Address offset: 0x7F8
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE12                   \ [0x00 : 8] Huffman code 12
    $08 constant JPEG_HLEN12                    \ [0x08 : 4] Huffman length 12
    $10 constant JPEG_HCODE13                   \ [0x10 : 8] Huffman code 13
    $18 constant JPEG_HLEN13                    \ [0x18 : 4] Huffman length 13
  [then]


  [ifdef] JPEG_JPEG_HUFFENC_DC1_7_DEF
    \
    \ @brief JPEG Huffman encoder DC1
    \ Address offset: 0x7FC
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HCODE14                   \ [0x00 : 8] Huffman code 14
    $08 constant JPEG_HLEN14                    \ [0x08 : 4] Huffman length 14
    $10 constant JPEG_HCODE15                   \ [0x10 : 8] Huffman code 15
    $18 constant JPEG_HLEN15                    \ [0x18 : 4] Huffman length 15
  [then]

  \
  \ @brief JPEG codec
  \
  $00 constant JPEG_JPEG_CONFR0         \ JPEG codec control register
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
  $50 constant JPEG_JPEG_QMEM0_0        \ JPEG quantization memory 0
  $54 constant JPEG_JPEG_QMEM0_1        \ JPEG quantization memory 0
  $58 constant JPEG_JPEG_QMEM0_2        \ JPEG quantization memory 0
  $5C constant JPEG_JPEG_QMEM0_3        \ JPEG quantization memory 0
  $60 constant JPEG_JPEG_QMEM0_4        \ JPEG quantization memory 0
  $64 constant JPEG_JPEG_QMEM0_5        \ JPEG quantization memory 0
  $68 constant JPEG_JPEG_QMEM0_6        \ JPEG quantization memory 0
  $6C constant JPEG_JPEG_QMEM0_7        \ JPEG quantization memory 0
  $70 constant JPEG_JPEG_QMEM0_8        \ JPEG quantization memory 0
  $74 constant JPEG_JPEG_QMEM0_9        \ JPEG quantization memory 0
  $78 constant JPEG_JPEG_QMEM0_10       \ JPEG quantization memory 0
  $7C constant JPEG_JPEG_QMEM0_11       \ JPEG quantization memory 0
  $80 constant JPEG_JPEG_QMEM0_12       \ JPEG quantization memory 0
  $84 constant JPEG_JPEG_QMEM0_13       \ JPEG quantization memory 0
  $88 constant JPEG_JPEG_QMEM0_14       \ JPEG quantization memory 0
  $8C constant JPEG_JPEG_QMEM0_15       \ JPEG quantization memory 0
  $90 constant JPEG_JPEG_QMEM1_0        \ JPEG quantization memory 1
  $94 constant JPEG_JPEG_QMEM1_1        \ JPEG quantization memory 1
  $98 constant JPEG_JPEG_QMEM1_2        \ JPEG quantization memory 1
  $9C constant JPEG_JPEG_QMEM1_3        \ JPEG quantization memory 1
  $A0 constant JPEG_JPEG_QMEM1_4        \ JPEG quantization memory 1
  $A4 constant JPEG_JPEG_QMEM1_5        \ JPEG quantization memory 1
  $A8 constant JPEG_JPEG_QMEM1_6        \ JPEG quantization memory 1
  $AC constant JPEG_JPEG_QMEM1_7        \ JPEG quantization memory 1
  $B0 constant JPEG_JPEG_QMEM1_8        \ JPEG quantization memory 1
  $B4 constant JPEG_JPEG_QMEM1_9        \ JPEG quantization memory 1
  $B8 constant JPEG_JPEG_QMEM1_10       \ JPEG quantization memory 1
  $BC constant JPEG_JPEG_QMEM1_11       \ JPEG quantization memory 1
  $C0 constant JPEG_JPEG_QMEM1_12       \ JPEG quantization memory 1
  $C4 constant JPEG_JPEG_QMEM1_13       \ JPEG quantization memory 1
  $C8 constant JPEG_JPEG_QMEM1_14       \ JPEG quantization memory 1
  $CC constant JPEG_JPEG_QMEM1_15       \ JPEG quantization memory 1
  $D0 constant JPEG_JPEG_QMEM2_0        \ JPEG quantization memory 2
  $D4 constant JPEG_JPEG_QMEM2_1        \ JPEG quantization memory 2
  $D8 constant JPEG_JPEG_QMEM2_2        \ JPEG quantization memory 2
  $DC constant JPEG_JPEG_QMEM2_3        \ JPEG quantization memory 2
  $E0 constant JPEG_JPEG_QMEM2_4        \ JPEG quantization memory 2
  $E4 constant JPEG_JPEG_QMEM2_5        \ JPEG quantization memory 2
  $E8 constant JPEG_JPEG_QMEM2_6        \ JPEG quantization memory 2
  $EC constant JPEG_JPEG_QMEM2_7        \ JPEG quantization memory 2
  $F0 constant JPEG_JPEG_QMEM2_8        \ JPEG quantization memory 2
  $F4 constant JPEG_JPEG_QMEM2_9        \ JPEG quantization memory 2
  $F8 constant JPEG_JPEG_QMEM2_10       \ JPEG quantization memory 2
  $FC constant JPEG_JPEG_QMEM2_11       \ JPEG quantization memory 2
  $100 constant JPEG_JPEG_QMEM2_12      \ JPEG quantization memory 2
  $104 constant JPEG_JPEG_QMEM2_13      \ JPEG quantization memory 2
  $108 constant JPEG_JPEG_QMEM2_14      \ JPEG quantization memory 2
  $10C constant JPEG_JPEG_QMEM2_15      \ JPEG quantization memory 2
  $110 constant JPEG_JPEG_QMEM3_0       \ JPEG quantization memory 3
  $114 constant JPEG_JPEG_QMEM3_1       \ JPEG quantization memory 3
  $118 constant JPEG_JPEG_QMEM3_2       \ JPEG quantization memory 3
  $11C constant JPEG_JPEG_QMEM3_3       \ JPEG quantization memory 3
  $120 constant JPEG_JPEG_QMEM3_4       \ JPEG quantization memory 3
  $124 constant JPEG_JPEG_QMEM3_5       \ JPEG quantization memory 3
  $128 constant JPEG_JPEG_QMEM3_6       \ JPEG quantization memory 3
  $12C constant JPEG_JPEG_QMEM3_7       \ JPEG quantization memory 3
  $130 constant JPEG_JPEG_QMEM3_8       \ JPEG quantization memory 3
  $134 constant JPEG_JPEG_QMEM3_9       \ JPEG quantization memory 3
  $138 constant JPEG_JPEG_QMEM3_10      \ JPEG quantization memory 3
  $13C constant JPEG_JPEG_QMEM3_11      \ JPEG quantization memory 3
  $140 constant JPEG_JPEG_QMEM3_12      \ JPEG quantization memory 3
  $144 constant JPEG_JPEG_QMEM3_13      \ JPEG quantization memory 3
  $148 constant JPEG_JPEG_QMEM3_14      \ JPEG quantization memory 3
  $14C constant JPEG_JPEG_QMEM3_15      \ JPEG quantization memory 3
  $150 constant JPEG_JPEG_HUFFMIN0_0    \ JPEG Huffman min
  $154 constant JPEG_JPEG_HUFFMIN0_1    \ JPEG Huffman min
  $158 constant JPEG_JPEG_HUFFMIN0_2    \ JPEG Huffman min
  $15C constant JPEG_JPEG_HUFFMIN0_3    \ JPEG Huffman min 0
  $160 constant JPEG_JPEG_HUFFMIN1_0    \ JPEG Huffman min
  $164 constant JPEG_JPEG_HUFFMIN1_1    \ JPEG Huffman min
  $168 constant JPEG_JPEG_HUFFMIN1_2    \ JPEG Huffman min
  $16C constant JPEG_JPEG_HUFFMIN1_3    \ JPEG Huffman min 1
  $170 constant JPEG_JPEG_HUFFMIN2_0    \ JPEG Huffman min
  $174 constant JPEG_JPEG_HUFFMIN2_1    \ JPEG Huffman min
  $178 constant JPEG_JPEG_HUFFMIN2_2    \ JPEG Huffman min
  $17C constant JPEG_JPEG_HUFFMIN2_3    \ JPEG Huffman min 2
  $180 constant JPEG_JPEG_HUFFMIN3_0    \ JPEG Huffman min
  $184 constant JPEG_JPEG_HUFFMIN3_1    \ JPEG Huffman min
  $188 constant JPEG_JPEG_HUFFMIN3_2    \ JPEG Huffman min
  $18C constant JPEG_JPEG_HUFFMIN3_3    \ JPEG Huffman min 3
  $190 constant JPEG_JPEG_HUFFBASE0     \ JPEG Huffman base
  $194 constant JPEG_JPEG_HUFFBASE1     \ JPEG Huffman base
  $198 constant JPEG_JPEG_HUFFBASE2     \ JPEG Huffman base
  $19C constant JPEG_JPEG_HUFFBASE3     \ JPEG Huffman base
  $1A0 constant JPEG_JPEG_HUFFBASE4     \ JPEG Huffman base
  $1A4 constant JPEG_JPEG_HUFFBASE5     \ JPEG Huffman base
  $1A8 constant JPEG_JPEG_HUFFBASE6     \ JPEG Huffman base
  $1AC constant JPEG_JPEG_HUFFBASE7     \ JPEG Huffman base
  $1B0 constant JPEG_JPEG_HUFFBASE8     \ JPEG Huffman base
  $1B4 constant JPEG_JPEG_HUFFBASE9     \ JPEG Huffman base
  $1B8 constant JPEG_JPEG_HUFFBASE10    \ JPEG Huffman base
  $1BC constant JPEG_JPEG_HUFFBASE11    \ JPEG Huffman base
  $1C0 constant JPEG_JPEG_HUFFBASE12    \ JPEG Huffman base
  $1C4 constant JPEG_JPEG_HUFFBASE13    \ JPEG Huffman base
  $1C8 constant JPEG_JPEG_HUFFBASE14    \ JPEG Huffman base
  $1CC constant JPEG_JPEG_HUFFBASE15    \ JPEG Huffman base
  $1D0 constant JPEG_JPEG_HUFFBASE16    \ JPEG Huffman base
  $1D4 constant JPEG_JPEG_HUFFBASE17    \ JPEG Huffman base
  $1D8 constant JPEG_JPEG_HUFFBASE18    \ JPEG Huffman base
  $1DC constant JPEG_JPEG_HUFFBASE19    \ JPEG Huffman base
  $1E0 constant JPEG_JPEG_HUFFBASE20    \ JPEG Huffman base
  $1E4 constant JPEG_JPEG_HUFFBASE21    \ JPEG Huffman base
  $1E8 constant JPEG_JPEG_HUFFBASE22    \ JPEG Huffman base
  $1EC constant JPEG_JPEG_HUFFBASE23    \ JPEG Huffman base
  $1F0 constant JPEG_JPEG_HUFFBASE24    \ JPEG Huffman base
  $1F4 constant JPEG_JPEG_HUFFBASE25    \ JPEG Huffman base
  $1F8 constant JPEG_JPEG_HUFFBASE26    \ JPEG Huffman base
  $1FC constant JPEG_JPEG_HUFFBASE27    \ JPEG Huffman base
  $200 constant JPEG_JPEG_HUFFBASE28    \ JPEG Huffman base
  $204 constant JPEG_JPEG_HUFFBASE29    \ JPEG Huffman base
  $208 constant JPEG_JPEG_HUFFBASE30    \ JPEG Huffman base
  $20C constant JPEG_JPEG_HUFFBASE31    \ JPEG Huffman base
  $210 constant JPEG_JPEG_HUFFSYMB0     \ JPEG Huffman symbol
  $214 constant JPEG_JPEG_HUFFSYMB1     \ JPEG Huffman symbol
  $218 constant JPEG_JPEG_HUFFSYMB2     \ JPEG Huffman symbol
  $21C constant JPEG_JPEG_HUFFSYMB3     \ JPEG Huffman symbol
  $220 constant JPEG_JPEG_HUFFSYMB4     \ JPEG Huffman symbol
  $224 constant JPEG_JPEG_HUFFSYMB5     \ JPEG Huffman symbol
  $228 constant JPEG_JPEG_HUFFSYMB6     \ JPEG Huffman symbol
  $22C constant JPEG_JPEG_HUFFSYMB7     \ JPEG Huffman symbol
  $230 constant JPEG_JPEG_HUFFSYMB8     \ JPEG Huffman symbol
  $234 constant JPEG_JPEG_HUFFSYMB9     \ JPEG Huffman symbol
  $238 constant JPEG_JPEG_HUFFSYMB10    \ JPEG Huffman symbol
  $23C constant JPEG_JPEG_HUFFSYMB11    \ JPEG Huffman symbol
  $240 constant JPEG_JPEG_HUFFSYMB12    \ JPEG Huffman symbol
  $244 constant JPEG_JPEG_HUFFSYMB13    \ JPEG Huffman symbol
  $248 constant JPEG_JPEG_HUFFSYMB14    \ JPEG Huffman symbol
  $24C constant JPEG_JPEG_HUFFSYMB15    \ JPEG Huffman symbol
  $250 constant JPEG_JPEG_HUFFSYMB16    \ JPEG Huffman symbol
  $254 constant JPEG_JPEG_HUFFSYMB17    \ JPEG Huffman symbol
  $258 constant JPEG_JPEG_HUFFSYMB18    \ JPEG Huffman symbol
  $25C constant JPEG_JPEG_HUFFSYMB19    \ JPEG Huffman symbol
  $260 constant JPEG_JPEG_HUFFSYMB20    \ JPEG Huffman symbol
  $264 constant JPEG_JPEG_HUFFSYMB21    \ JPEG Huffman symbol
  $268 constant JPEG_JPEG_HUFFSYMB22    \ JPEG Huffman symbol
  $26C constant JPEG_JPEG_HUFFSYMB23    \ JPEG Huffman symbol
  $270 constant JPEG_JPEG_HUFFSYMB24    \ JPEG Huffman symbol
  $274 constant JPEG_JPEG_HUFFSYMB25    \ JPEG Huffman symbol
  $278 constant JPEG_JPEG_HUFFSYMB26    \ JPEG Huffman symbol
  $27C constant JPEG_JPEG_HUFFSYMB27    \ JPEG Huffman symbol
  $280 constant JPEG_JPEG_HUFFSYMB28    \ JPEG Huffman symbol
  $284 constant JPEG_JPEG_HUFFSYMB29    \ JPEG Huffman symbol
  $288 constant JPEG_JPEG_HUFFSYMB30    \ JPEG Huffman symbol
  $28C constant JPEG_JPEG_HUFFSYMB31    \ JPEG Huffman symbol
  $290 constant JPEG_JPEG_HUFFSYMB32    \ JPEG Huffman symbol
  $294 constant JPEG_JPEG_HUFFSYMB33    \ JPEG Huffman symbol
  $298 constant JPEG_JPEG_HUFFSYMB34    \ JPEG Huffman symbol
  $29C constant JPEG_JPEG_HUFFSYMB35    \ JPEG Huffman symbol
  $2A0 constant JPEG_JPEG_HUFFSYMB36    \ JPEG Huffman symbol
  $2A4 constant JPEG_JPEG_HUFFSYMB37    \ JPEG Huffman symbol
  $2A8 constant JPEG_JPEG_HUFFSYMB38    \ JPEG Huffman symbol
  $2AC constant JPEG_JPEG_HUFFSYMB39    \ JPEG Huffman symbol
  $2B0 constant JPEG_JPEG_HUFFSYMB40    \ JPEG Huffman symbol
  $2B4 constant JPEG_JPEG_HUFFSYMB41    \ JPEG Huffman symbol
  $2B8 constant JPEG_JPEG_HUFFSYMB42    \ JPEG Huffman symbol
  $2BC constant JPEG_JPEG_HUFFSYMB43    \ JPEG Huffman symbol
  $2C0 constant JPEG_JPEG_HUFFSYMB44    \ JPEG Huffman symbol
  $2C4 constant JPEG_JPEG_HUFFSYMB45    \ JPEG Huffman symbol
  $2C8 constant JPEG_JPEG_HUFFSYMB46    \ JPEG Huffman symbol
  $2CC constant JPEG_JPEG_HUFFSYMB47    \ JPEG Huffman symbol
  $2D0 constant JPEG_JPEG_HUFFSYMB48    \ JPEG Huffman symbol
  $2D4 constant JPEG_JPEG_HUFFSYMB49    \ JPEG Huffman symbol
  $2D8 constant JPEG_JPEG_HUFFSYMB50    \ JPEG Huffman symbol
  $2DC constant JPEG_JPEG_HUFFSYMB51    \ JPEG Huffman symbol
  $2E0 constant JPEG_JPEG_HUFFSYMB52    \ JPEG Huffman symbol
  $2E4 constant JPEG_JPEG_HUFFSYMB53    \ JPEG Huffman symbol
  $2E8 constant JPEG_JPEG_HUFFSYMB54    \ JPEG Huffman symbol
  $2EC constant JPEG_JPEG_HUFFSYMB55    \ JPEG Huffman symbol
  $2F0 constant JPEG_JPEG_HUFFSYMB56    \ JPEG Huffman symbol
  $2F4 constant JPEG_JPEG_HUFFSYMB57    \ JPEG Huffman symbol
  $2F8 constant JPEG_JPEG_HUFFSYMB58    \ JPEG Huffman symbol
  $2FC constant JPEG_JPEG_HUFFSYMB59    \ JPEG Huffman symbol
  $300 constant JPEG_JPEG_HUFFSYMB60    \ JPEG Huffman symbol
  $304 constant JPEG_JPEG_HUFFSYMB61    \ JPEG Huffman symbol
  $308 constant JPEG_JPEG_HUFFSYMB62    \ JPEG Huffman symbol
  $30C constant JPEG_JPEG_HUFFSYMB63    \ JPEG Huffman symbol
  $310 constant JPEG_JPEG_HUFFSYMB64    \ JPEG Huffman symbol
  $314 constant JPEG_JPEG_HUFFSYMB65    \ JPEG Huffman symbol
  $318 constant JPEG_JPEG_HUFFSYMB66    \ JPEG Huffman symbol
  $31C constant JPEG_JPEG_HUFFSYMB67    \ JPEG Huffman symbol
  $320 constant JPEG_JPEG_HUFFSYMB68    \ JPEG Huffman symbol
  $324 constant JPEG_JPEG_HUFFSYMB69    \ JPEG Huffman symbol
  $328 constant JPEG_JPEG_HUFFSYMB70    \ JPEG Huffman symbol
  $32C constant JPEG_JPEG_HUFFSYMB71    \ JPEG Huffman symbol
  $330 constant JPEG_JPEG_HUFFSYMB72    \ JPEG Huffman symbol
  $334 constant JPEG_JPEG_HUFFSYMB73    \ JPEG Huffman symbol
  $338 constant JPEG_JPEG_HUFFSYMB74    \ JPEG Huffman symbol
  $33C constant JPEG_JPEG_HUFFSYMB75    \ JPEG Huffman symbol
  $340 constant JPEG_JPEG_HUFFSYMB76    \ JPEG Huffman symbol
  $344 constant JPEG_JPEG_HUFFSYMB77    \ JPEG Huffman symbol
  $348 constant JPEG_JPEG_HUFFSYMB78    \ JPEG Huffman symbol
  $34C constant JPEG_JPEG_HUFFSYMB79    \ JPEG Huffman symbol
  $350 constant JPEG_JPEG_HUFFSYMB80    \ JPEG Huffman symbol
  $354 constant JPEG_JPEG_HUFFSYMB81    \ JPEG Huffman symbol
  $358 constant JPEG_JPEG_HUFFSYMB82    \ JPEG Huffman symbol
  $35C constant JPEG_JPEG_HUFFSYMB83    \ JPEG Huffman symbol
  $360 constant JPEG_JPEG_DHTMEM0       \ JPEG DHT memory
  $364 constant JPEG_JPEG_DHTMEM1       \ JPEG DHT memory
  $368 constant JPEG_JPEG_DHTMEM2       \ JPEG DHT memory
  $36C constant JPEG_JPEG_DHTMEM3       \ JPEG DHT memory
  $370 constant JPEG_JPEG_DHTMEM4       \ JPEG DHT memory
  $374 constant JPEG_JPEG_DHTMEM5       \ JPEG DHT memory
  $378 constant JPEG_JPEG_DHTMEM6       \ JPEG DHT memory
  $37C constant JPEG_JPEG_DHTMEM7       \ JPEG DHT memory
  $380 constant JPEG_JPEG_DHTMEM8       \ JPEG DHT memory
  $384 constant JPEG_JPEG_DHTMEM9       \ JPEG DHT memory
  $388 constant JPEG_JPEG_DHTMEM10      \ JPEG DHT memory
  $38C constant JPEG_JPEG_DHTMEM11      \ JPEG DHT memory
  $390 constant JPEG_JPEG_DHTMEM12      \ JPEG DHT memory
  $394 constant JPEG_JPEG_DHTMEM13      \ JPEG DHT memory
  $398 constant JPEG_JPEG_DHTMEM14      \ JPEG DHT memory
  $39C constant JPEG_JPEG_DHTMEM15      \ JPEG DHT memory
  $3A0 constant JPEG_JPEG_DHTMEM16      \ JPEG DHT memory
  $3A4 constant JPEG_JPEG_DHTMEM17      \ JPEG DHT memory
  $3A8 constant JPEG_JPEG_DHTMEM18      \ JPEG DHT memory
  $3AC constant JPEG_JPEG_DHTMEM19      \ JPEG DHT memory
  $3B0 constant JPEG_JPEG_DHTMEM20      \ JPEG DHT memory
  $3B4 constant JPEG_JPEG_DHTMEM21      \ JPEG DHT memory
  $3B8 constant JPEG_JPEG_DHTMEM22      \ JPEG DHT memory
  $3BC constant JPEG_JPEG_DHTMEM23      \ JPEG DHT memory
  $3C0 constant JPEG_JPEG_DHTMEM24      \ JPEG DHT memory
  $3C4 constant JPEG_JPEG_DHTMEM25      \ JPEG DHT memory
  $3C8 constant JPEG_JPEG_DHTMEM26      \ JPEG DHT memory
  $3CC constant JPEG_JPEG_DHTMEM27      \ JPEG DHT memory
  $3D0 constant JPEG_JPEG_DHTMEM28      \ JPEG DHT memory
  $3D4 constant JPEG_JPEG_DHTMEM29      \ JPEG DHT memory
  $3D8 constant JPEG_JPEG_DHTMEM30      \ JPEG DHT memory
  $3DC constant JPEG_JPEG_DHTMEM31      \ JPEG DHT memory
  $3E0 constant JPEG_JPEG_DHTMEM32      \ JPEG DHT memory
  $3E4 constant JPEG_JPEG_DHTMEM33      \ JPEG DHT memory
  $3E8 constant JPEG_JPEG_DHTMEM34      \ JPEG DHT memory
  $3EC constant JPEG_JPEG_DHTMEM35      \ JPEG DHT memory
  $3F0 constant JPEG_JPEG_DHTMEM36      \ JPEG DHT memory
  $3F4 constant JPEG_JPEG_DHTMEM37      \ JPEG DHT memory
  $3F8 constant JPEG_JPEG_DHTMEM38      \ JPEG DHT memory
  $3FC constant JPEG_JPEG_DHTMEM39      \ JPEG DHT memory
  $400 constant JPEG_JPEG_DHTMEM40      \ JPEG DHT memory
  $404 constant JPEG_JPEG_DHTMEM41      \ JPEG DHT memory
  $408 constant JPEG_JPEG_DHTMEM42      \ JPEG DHT memory
  $40C constant JPEG_JPEG_DHTMEM43      \ JPEG DHT memory
  $410 constant JPEG_JPEG_DHTMEM44      \ JPEG DHT memory
  $414 constant JPEG_JPEG_DHTMEM45      \ JPEG DHT memory
  $418 constant JPEG_JPEG_DHTMEM46      \ JPEG DHT memory
  $41C constant JPEG_JPEG_DHTMEM47      \ JPEG DHT memory
  $420 constant JPEG_JPEG_DHTMEM48      \ JPEG DHT memory
  $424 constant JPEG_JPEG_DHTMEM49      \ JPEG DHT memory
  $428 constant JPEG_JPEG_DHTMEM50      \ JPEG DHT memory
  $42C constant JPEG_JPEG_DHTMEM51      \ JPEG DHT memory
  $430 constant JPEG_JPEG_DHTMEM52      \ JPEG DHT memory
  $434 constant JPEG_JPEG_DHTMEM53      \ JPEG DHT memory
  $438 constant JPEG_JPEG_DHTMEM54      \ JPEG DHT memory
  $43C constant JPEG_JPEG_DHTMEM55      \ JPEG DHT memory
  $440 constant JPEG_JPEG_DHTMEM56      \ JPEG DHT memory
  $444 constant JPEG_JPEG_DHTMEM57      \ JPEG DHT memory
  $448 constant JPEG_JPEG_DHTMEM58      \ JPEG DHT memory
  $44C constant JPEG_JPEG_DHTMEM59      \ JPEG DHT memory
  $450 constant JPEG_JPEG_DHTMEM60      \ JPEG DHT memory
  $454 constant JPEG_JPEG_DHTMEM61      \ JPEG DHT memory
  $458 constant JPEG_JPEG_DHTMEM62      \ JPEG DHT memory
  $45C constant JPEG_JPEG_DHTMEM63      \ JPEG DHT memory
  $460 constant JPEG_JPEG_DHTMEM64      \ JPEG DHT memory
  $464 constant JPEG_JPEG_DHTMEM65      \ JPEG DHT memory
  $468 constant JPEG_JPEG_DHTMEM66      \ JPEG DHT memory
  $46C constant JPEG_JPEG_DHTMEM67      \ JPEG DHT memory
  $470 constant JPEG_JPEG_DHTMEM68      \ JPEG DHT memory
  $474 constant JPEG_JPEG_DHTMEM69      \ JPEG DHT memory
  $478 constant JPEG_JPEG_DHTMEM70      \ JPEG DHT memory
  $47C constant JPEG_JPEG_DHTMEM71      \ JPEG DHT memory
  $480 constant JPEG_JPEG_DHTMEM72      \ JPEG DHT memory
  $484 constant JPEG_JPEG_DHTMEM73      \ JPEG DHT memory
  $488 constant JPEG_JPEG_DHTMEM74      \ JPEG DHT memory
  $48C constant JPEG_JPEG_DHTMEM75      \ JPEG DHT memory
  $490 constant JPEG_JPEG_DHTMEM76      \ JPEG DHT memory
  $494 constant JPEG_JPEG_DHTMEM77      \ JPEG DHT memory
  $498 constant JPEG_JPEG_DHTMEM78      \ JPEG DHT memory
  $49C constant JPEG_JPEG_DHTMEM79      \ JPEG DHT memory
  $4A0 constant JPEG_JPEG_DHTMEM80      \ JPEG DHT memory
  $4A4 constant JPEG_JPEG_DHTMEM81      \ JPEG DHT memory
  $4A8 constant JPEG_JPEG_DHTMEM82      \ JPEG DHT memory
  $4AC constant JPEG_JPEG_DHTMEM83      \ JPEG DHT memory
  $4B0 constant JPEG_JPEG_DHTMEM84      \ JPEG DHT memory
  $4B4 constant JPEG_JPEG_DHTMEM85      \ JPEG DHT memory
  $4B8 constant JPEG_JPEG_DHTMEM86      \ JPEG DHT memory
  $4BC constant JPEG_JPEG_DHTMEM87      \ JPEG DHT memory
  $4C0 constant JPEG_JPEG_DHTMEM88      \ JPEG DHT memory
  $4C4 constant JPEG_JPEG_DHTMEM89      \ JPEG DHT memory
  $4C8 constant JPEG_JPEG_DHTMEM90      \ JPEG DHT memory
  $4CC constant JPEG_JPEG_DHTMEM91      \ JPEG DHT memory
  $4D0 constant JPEG_JPEG_DHTMEM92      \ JPEG DHT memory
  $4D4 constant JPEG_JPEG_DHTMEM93      \ JPEG DHT memory
  $4D8 constant JPEG_JPEG_DHTMEM94      \ JPEG DHT memory
  $4DC constant JPEG_JPEG_DHTMEM95      \ JPEG DHT memory
  $4E0 constant JPEG_JPEG_DHTMEM96      \ JPEG DHT memory
  $4E4 constant JPEG_JPEG_DHTMEM97      \ JPEG DHT memory
  $4E8 constant JPEG_JPEG_DHTMEM98      \ JPEG DHT memory
  $4EC constant JPEG_JPEG_DHTMEM99      \ JPEG DHT memory
  $4F0 constant JPEG_JPEG_DHTMEM100     \ JPEG DHT memory
  $4F4 constant JPEG_JPEG_DHTMEM101     \ JPEG DHT memory
  $4F8 constant JPEG_JPEG_DHTMEM102     \ JPEG DHT memory
  $500 constant JPEG_JPEG_HUFFENC_AC0_0 \ JPEG Huffman encoder AC0
  $504 constant JPEG_JPEG_HUFFENC_AC0_1 \ JPEG Huffman encoder AC0
  $508 constant JPEG_JPEG_HUFFENC_AC0_2 \ JPEG Huffman encoder AC0
  $50C constant JPEG_JPEG_HUFFENC_AC0_3 \ JPEG Huffman encoder AC0
  $510 constant JPEG_JPEG_HUFFENC_AC0_4 \ JPEG Huffman encoder AC0
  $514 constant JPEG_JPEG_HUFFENC_AC0_5 \ JPEG Huffman encoder AC0
  $518 constant JPEG_JPEG_HUFFENC_AC0_6 \ JPEG Huffman encoder AC0
  $51C constant JPEG_JPEG_HUFFENC_AC0_7 \ JPEG Huffman encoder AC0
  $520 constant JPEG_JPEG_HUFFENC_AC0_8 \ JPEG Huffman encoder AC0
  $524 constant JPEG_JPEG_HUFFENC_AC0_9 \ JPEG Huffman encoder AC0
  $528 constant JPEG_JPEG_HUFFENC_AC0_10    \ JPEG Huffman encoder AC0
  $52C constant JPEG_JPEG_HUFFENC_AC0_11    \ JPEG Huffman encoder AC0
  $530 constant JPEG_JPEG_HUFFENC_AC0_12    \ JPEG Huffman encoder AC0
  $534 constant JPEG_JPEG_HUFFENC_AC0_13    \ JPEG Huffman encoder AC0
  $538 constant JPEG_JPEG_HUFFENC_AC0_14    \ JPEG Huffman encoder AC0
  $53C constant JPEG_JPEG_HUFFENC_AC0_15    \ JPEG Huffman encoder AC0
  $540 constant JPEG_JPEG_HUFFENC_AC0_16    \ JPEG Huffman encoder AC0
  $544 constant JPEG_JPEG_HUFFENC_AC0_17    \ JPEG Huffman encoder AC0
  $548 constant JPEG_JPEG_HUFFENC_AC0_18    \ JPEG Huffman encoder AC0
  $54C constant JPEG_JPEG_HUFFENC_AC0_19    \ JPEG Huffman encoder AC0
  $550 constant JPEG_JPEG_HUFFENC_AC0_20    \ JPEG Huffman encoder AC0
  $554 constant JPEG_JPEG_HUFFENC_AC0_21    \ JPEG Huffman encoder AC0
  $558 constant JPEG_JPEG_HUFFENC_AC0_22    \ JPEG Huffman encoder AC0
  $55C constant JPEG_JPEG_HUFFENC_AC0_23    \ JPEG Huffman encoder AC0
  $560 constant JPEG_JPEG_HUFFENC_AC0_24    \ JPEG Huffman encoder AC0
  $564 constant JPEG_JPEG_HUFFENC_AC0_25    \ JPEG Huffman encoder AC0
  $568 constant JPEG_JPEG_HUFFENC_AC0_26    \ JPEG Huffman encoder AC0
  $56C constant JPEG_JPEG_HUFFENC_AC0_27    \ JPEG Huffman encoder AC0
  $570 constant JPEG_JPEG_HUFFENC_AC0_28    \ JPEG Huffman encoder AC0
  $574 constant JPEG_JPEG_HUFFENC_AC0_29    \ JPEG Huffman encoder AC0
  $578 constant JPEG_JPEG_HUFFENC_AC0_30    \ JPEG Huffman encoder AC0
  $57C constant JPEG_JPEG_HUFFENC_AC0_31    \ JPEG Huffman encoder AC0
  $580 constant JPEG_JPEG_HUFFENC_AC0_32    \ JPEG Huffman encoder AC0
  $584 constant JPEG_JPEG_HUFFENC_AC0_33    \ JPEG Huffman encoder AC0
  $588 constant JPEG_JPEG_HUFFENC_AC0_34    \ JPEG Huffman encoder AC0
  $58C constant JPEG_JPEG_HUFFENC_AC0_35    \ JPEG Huffman encoder AC0
  $590 constant JPEG_JPEG_HUFFENC_AC0_36    \ JPEG Huffman encoder AC0
  $594 constant JPEG_JPEG_HUFFENC_AC0_37    \ JPEG Huffman encoder AC0
  $598 constant JPEG_JPEG_HUFFENC_AC0_38    \ JPEG Huffman encoder AC0
  $59C constant JPEG_JPEG_HUFFENC_AC0_39    \ JPEG Huffman encoder AC0
  $5A0 constant JPEG_JPEG_HUFFENC_AC0_40    \ JPEG Huffman encoder AC0
  $5A4 constant JPEG_JPEG_HUFFENC_AC0_41    \ JPEG Huffman encoder AC0
  $5A8 constant JPEG_JPEG_HUFFENC_AC0_42    \ JPEG Huffman encoder AC0
  $5AC constant JPEG_JPEG_HUFFENC_AC0_43    \ JPEG Huffman encoder AC0
  $5B0 constant JPEG_JPEG_HUFFENC_AC0_44    \ JPEG Huffman encoder AC0
  $5B4 constant JPEG_JPEG_HUFFENC_AC0_45    \ JPEG Huffman encoder AC0
  $5B8 constant JPEG_JPEG_HUFFENC_AC0_46    \ JPEG Huffman encoder AC0
  $5BC constant JPEG_JPEG_HUFFENC_AC0_47    \ JPEG Huffman encoder AC0
  $5C0 constant JPEG_JPEG_HUFFENC_AC0_48    \ JPEG Huffman encoder AC0
  $5C4 constant JPEG_JPEG_HUFFENC_AC0_49    \ JPEG Huffman encoder AC0
  $5C8 constant JPEG_JPEG_HUFFENC_AC0_50    \ JPEG Huffman encoder AC0
  $5CC constant JPEG_JPEG_HUFFENC_AC0_51    \ JPEG Huffman encoder AC0
  $5D0 constant JPEG_JPEG_HUFFENC_AC0_52    \ JPEG Huffman encoder AC0
  $5D4 constant JPEG_JPEG_HUFFENC_AC0_53    \ JPEG Huffman encoder AC0
  $5D8 constant JPEG_JPEG_HUFFENC_AC0_54    \ JPEG Huffman encoder AC0
  $5DC constant JPEG_JPEG_HUFFENC_AC0_55    \ JPEG Huffman encoder AC0
  $5E0 constant JPEG_JPEG_HUFFENC_AC0_56    \ JPEG Huffman encoder AC0
  $5E4 constant JPEG_JPEG_HUFFENC_AC0_57    \ JPEG Huffman encoder AC0
  $5E8 constant JPEG_JPEG_HUFFENC_AC0_58    \ JPEG Huffman encoder AC0
  $5EC constant JPEG_JPEG_HUFFENC_AC0_59    \ JPEG Huffman encoder AC0
  $5F0 constant JPEG_JPEG_HUFFENC_AC0_60    \ JPEG Huffman encoder AC0
  $5F4 constant JPEG_JPEG_HUFFENC_AC0_61    \ JPEG Huffman encoder AC0
  $5F8 constant JPEG_JPEG_HUFFENC_AC0_62    \ JPEG Huffman encoder AC0
  $5FC constant JPEG_JPEG_HUFFENC_AC0_63    \ JPEG Huffman encoder AC0
  $600 constant JPEG_JPEG_HUFFENC_AC0_64    \ JPEG Huffman encoder AC0
  $604 constant JPEG_JPEG_HUFFENC_AC0_65    \ JPEG Huffman encoder AC0
  $608 constant JPEG_JPEG_HUFFENC_AC0_66    \ JPEG Huffman encoder AC0
  $60C constant JPEG_JPEG_HUFFENC_AC0_67    \ JPEG Huffman encoder AC0
  $610 constant JPEG_JPEG_HUFFENC_AC0_68    \ JPEG Huffman encoder AC0
  $614 constant JPEG_JPEG_HUFFENC_AC0_69    \ JPEG Huffman encoder AC0
  $618 constant JPEG_JPEG_HUFFENC_AC0_70    \ JPEG Huffman encoder AC0
  $61C constant JPEG_JPEG_HUFFENC_AC0_71    \ JPEG Huffman encoder AC0
  $620 constant JPEG_JPEG_HUFFENC_AC0_72    \ JPEG Huffman encoder AC0
  $624 constant JPEG_JPEG_HUFFENC_AC0_73    \ JPEG Huffman encoder AC0
  $628 constant JPEG_JPEG_HUFFENC_AC0_74    \ JPEG Huffman encoder AC0
  $62C constant JPEG_JPEG_HUFFENC_AC0_75    \ JPEG Huffman encoder AC0
  $630 constant JPEG_JPEG_HUFFENC_AC0_76    \ JPEG Huffman encoder AC0
  $634 constant JPEG_JPEG_HUFFENC_AC0_77    \ JPEG Huffman encoder AC0
  $638 constant JPEG_JPEG_HUFFENC_AC0_78    \ JPEG Huffman encoder AC0
  $63C constant JPEG_JPEG_HUFFENC_AC0_79    \ JPEG Huffman encoder AC0
  $640 constant JPEG_JPEG_HUFFENC_AC0_80    \ JPEG Huffman encoder AC0
  $644 constant JPEG_JPEG_HUFFENC_AC0_81    \ JPEG Huffman encoder AC0
  $648 constant JPEG_JPEG_HUFFENC_AC0_82    \ JPEG Huffman encoder AC0
  $64C constant JPEG_JPEG_HUFFENC_AC0_83    \ JPEG Huffman encoder AC0
  $650 constant JPEG_JPEG_HUFFENC_AC0_84    \ JPEG Huffman encoder AC0
  $654 constant JPEG_JPEG_HUFFENC_AC0_85    \ JPEG Huffman encoder AC0
  $658 constant JPEG_JPEG_HUFFENC_AC0_86    \ JPEG Huffman encoder AC0
  $65C constant JPEG_JPEG_HUFFENC_AC0_87    \ JPEG Huffman encoder AC0
  $660 constant JPEG_JPEG_HUFFENC_AC1_0 \ JPEG Huffman encoder AC1
  $664 constant JPEG_JPEG_HUFFENC_AC1_1 \ JPEG Huffman encoder AC1
  $668 constant JPEG_JPEG_HUFFENC_AC1_2 \ JPEG Huffman encoder AC1
  $66C constant JPEG_JPEG_HUFFENC_AC1_3 \ JPEG Huffman encoder AC1
  $670 constant JPEG_JPEG_HUFFENC_AC1_4 \ JPEG Huffman encoder AC1
  $674 constant JPEG_JPEG_HUFFENC_AC1_5 \ JPEG Huffman encoder AC1
  $678 constant JPEG_JPEG_HUFFENC_AC1_6 \ JPEG Huffman encoder AC1
  $67C constant JPEG_JPEG_HUFFENC_AC1_7 \ JPEG Huffman encoder AC1
  $680 constant JPEG_JPEG_HUFFENC_AC1_8 \ JPEG Huffman encoder AC1
  $684 constant JPEG_JPEG_HUFFENC_AC1_9 \ JPEG Huffman encoder AC1
  $688 constant JPEG_JPEG_HUFFENC_AC1_10    \ JPEG Huffman encoder AC1
  $68C constant JPEG_JPEG_HUFFENC_AC1_11    \ JPEG Huffman encoder AC1
  $690 constant JPEG_JPEG_HUFFENC_AC1_12    \ JPEG Huffman encoder AC1
  $694 constant JPEG_JPEG_HUFFENC_AC1_13    \ JPEG Huffman encoder AC1
  $698 constant JPEG_JPEG_HUFFENC_AC1_14    \ JPEG Huffman encoder AC1
  $69C constant JPEG_JPEG_HUFFENC_AC1_15    \ JPEG Huffman encoder AC1
  $6A0 constant JPEG_JPEG_HUFFENC_AC1_16    \ JPEG Huffman encoder AC1
  $6A4 constant JPEG_JPEG_HUFFENC_AC1_17    \ JPEG Huffman encoder AC1
  $6A8 constant JPEG_JPEG_HUFFENC_AC1_18    \ JPEG Huffman encoder AC1
  $6AC constant JPEG_JPEG_HUFFENC_AC1_19    \ JPEG Huffman encoder AC1
  $6B0 constant JPEG_JPEG_HUFFENC_AC1_20    \ JPEG Huffman encoder AC1
  $6B4 constant JPEG_JPEG_HUFFENC_AC1_21    \ JPEG Huffman encoder AC1
  $6B8 constant JPEG_JPEG_HUFFENC_AC1_22    \ JPEG Huffman encoder AC1
  $6BC constant JPEG_JPEG_HUFFENC_AC1_23    \ JPEG Huffman encoder AC1
  $6C0 constant JPEG_JPEG_HUFFENC_AC1_24    \ JPEG Huffman encoder AC1
  $6C4 constant JPEG_JPEG_HUFFENC_AC1_25    \ JPEG Huffman encoder AC1
  $6C8 constant JPEG_JPEG_HUFFENC_AC1_26    \ JPEG Huffman encoder AC1
  $6CC constant JPEG_JPEG_HUFFENC_AC1_27    \ JPEG Huffman encoder AC1
  $6D0 constant JPEG_JPEG_HUFFENC_AC1_28    \ JPEG Huffman encoder AC1
  $6D4 constant JPEG_JPEG_HUFFENC_AC1_29    \ JPEG Huffman encoder AC1
  $6D8 constant JPEG_JPEG_HUFFENC_AC1_30    \ JPEG Huffman encoder AC1
  $6DC constant JPEG_JPEG_HUFFENC_AC1_31    \ JPEG Huffman encoder AC1
  $6E0 constant JPEG_JPEG_HUFFENC_AC1_32    \ JPEG Huffman encoder AC1
  $6E4 constant JPEG_JPEG_HUFFENC_AC1_33    \ JPEG Huffman encoder AC1
  $6E8 constant JPEG_JPEG_HUFFENC_AC1_34    \ JPEG Huffman encoder AC1
  $6EC constant JPEG_JPEG_HUFFENC_AC1_35    \ JPEG Huffman encoder AC1
  $6F0 constant JPEG_JPEG_HUFFENC_AC1_36    \ JPEG Huffman encoder AC1
  $6F4 constant JPEG_JPEG_HUFFENC_AC1_37    \ JPEG Huffman encoder AC1
  $6F8 constant JPEG_JPEG_HUFFENC_AC1_38    \ JPEG Huffman encoder AC1
  $6FC constant JPEG_JPEG_HUFFENC_AC1_39    \ JPEG Huffman encoder AC1
  $700 constant JPEG_JPEG_HUFFENC_AC1_40    \ JPEG Huffman encoder AC1
  $704 constant JPEG_JPEG_HUFFENC_AC1_41    \ JPEG Huffman encoder AC1
  $708 constant JPEG_JPEG_HUFFENC_AC1_42    \ JPEG Huffman encoder AC1
  $70C constant JPEG_JPEG_HUFFENC_AC1_43    \ JPEG Huffman encoder AC1
  $710 constant JPEG_JPEG_HUFFENC_AC1_44    \ JPEG Huffman encoder AC1
  $714 constant JPEG_JPEG_HUFFENC_AC1_45    \ JPEG Huffman encoder AC1
  $718 constant JPEG_JPEG_HUFFENC_AC1_46    \ JPEG Huffman encoder AC1
  $71C constant JPEG_JPEG_HUFFENC_AC1_47    \ JPEG Huffman encoder AC1
  $720 constant JPEG_JPEG_HUFFENC_AC1_48    \ JPEG Huffman encoder AC1
  $724 constant JPEG_JPEG_HUFFENC_AC1_49    \ JPEG Huffman encoder AC1
  $728 constant JPEG_JPEG_HUFFENC_AC1_50    \ JPEG Huffman encoder AC1
  $72C constant JPEG_JPEG_HUFFENC_AC1_51    \ JPEG Huffman encoder AC1
  $730 constant JPEG_JPEG_HUFFENC_AC1_52    \ JPEG Huffman encoder AC1
  $734 constant JPEG_JPEG_HUFFENC_AC1_53    \ JPEG Huffman encoder AC1
  $738 constant JPEG_JPEG_HUFFENC_AC1_54    \ JPEG Huffman encoder AC1
  $73C constant JPEG_JPEG_HUFFENC_AC1_55    \ JPEG Huffman encoder AC1
  $740 constant JPEG_JPEG_HUFFENC_AC1_56    \ JPEG Huffman encoder AC1
  $744 constant JPEG_JPEG_HUFFENC_AC1_57    \ JPEG Huffman encoder AC1
  $748 constant JPEG_JPEG_HUFFENC_AC1_58    \ JPEG Huffman encoder AC1
  $74C constant JPEG_JPEG_HUFFENC_AC1_59    \ JPEG Huffman encoder AC1
  $750 constant JPEG_JPEG_HUFFENC_AC1_60    \ JPEG Huffman encoder AC1
  $754 constant JPEG_JPEG_HUFFENC_AC1_61    \ JPEG Huffman encoder AC1
  $758 constant JPEG_JPEG_HUFFENC_AC1_62    \ JPEG Huffman encoder AC1
  $75C constant JPEG_JPEG_HUFFENC_AC1_63    \ JPEG Huffman encoder AC1
  $760 constant JPEG_JPEG_HUFFENC_AC1_64    \ JPEG Huffman encoder AC1
  $764 constant JPEG_JPEG_HUFFENC_AC1_65    \ JPEG Huffman encoder AC1
  $768 constant JPEG_JPEG_HUFFENC_AC1_66    \ JPEG Huffman encoder AC1
  $76C constant JPEG_JPEG_HUFFENC_AC1_67    \ JPEG Huffman encoder AC1
  $770 constant JPEG_JPEG_HUFFENC_AC1_68    \ JPEG Huffman encoder AC1
  $774 constant JPEG_JPEG_HUFFENC_AC1_69    \ JPEG Huffman encoder AC1
  $778 constant JPEG_JPEG_HUFFENC_AC1_70    \ JPEG Huffman encoder AC1
  $77C constant JPEG_JPEG_HUFFENC_AC1_71    \ JPEG Huffman encoder AC1
  $780 constant JPEG_JPEG_HUFFENC_AC1_72    \ JPEG Huffman encoder AC1
  $784 constant JPEG_JPEG_HUFFENC_AC1_73    \ JPEG Huffman encoder AC1
  $788 constant JPEG_JPEG_HUFFENC_AC1_74    \ JPEG Huffman encoder AC1
  $78C constant JPEG_JPEG_HUFFENC_AC1_75    \ JPEG Huffman encoder AC1
  $790 constant JPEG_JPEG_HUFFENC_AC1_76    \ JPEG Huffman encoder AC1
  $794 constant JPEG_JPEG_HUFFENC_AC1_77    \ JPEG Huffman encoder AC1
  $798 constant JPEG_JPEG_HUFFENC_AC1_78    \ JPEG Huffman encoder AC1
  $79C constant JPEG_JPEG_HUFFENC_AC1_79    \ JPEG Huffman encoder AC1
  $7A0 constant JPEG_JPEG_HUFFENC_AC1_80    \ JPEG Huffman encoder AC1
  $7A4 constant JPEG_JPEG_HUFFENC_AC1_81    \ JPEG Huffman encoder AC1
  $7A8 constant JPEG_JPEG_HUFFENC_AC1_82    \ JPEG Huffman encoder AC1
  $7AC constant JPEG_JPEG_HUFFENC_AC1_83    \ JPEG Huffman encoder AC1
  $7B0 constant JPEG_JPEG_HUFFENC_AC1_84    \ JPEG Huffman encoder AC1
  $7B4 constant JPEG_JPEG_HUFFENC_AC1_85    \ JPEG Huffman encoder AC1
  $7B8 constant JPEG_JPEG_HUFFENC_AC1_86    \ JPEG Huffman encoder AC1
  $7BC constant JPEG_JPEG_HUFFENC_AC1_87    \ JPEG Huffman encoder AC1
  $7C0 constant JPEG_JPEG_HUFFENC_DC0_0 \ JPEG Huffman encoder DC0
  $7C4 constant JPEG_JPEG_HUFFENC_DC0_1 \ JPEG Huffman encoder DC0
  $7C8 constant JPEG_JPEG_HUFFENC_DC0_2 \ JPEG Huffman encoder DC0
  $7CC constant JPEG_JPEG_HUFFENC_DC0_3 \ JPEG Huffman encoder DC0
  $7D0 constant JPEG_JPEG_HUFFENC_DC0_4 \ JPEG Huffman encoder DC0
  $7D4 constant JPEG_JPEG_HUFFENC_DC0_5 \ JPEG Huffman encoder DC0
  $7D8 constant JPEG_JPEG_HUFFENC_DC0_6 \ JPEG Huffman encoder DC0
  $7DC constant JPEG_JPEG_HUFFENC_DC0_7 \ JPEG Huffman encoder DC0
  $7E0 constant JPEG_JPEG_HUFFENC_DC1_0 \ JPEG Huffman encoder DC1
  $7E4 constant JPEG_JPEG_HUFFENC_DC1_1 \ JPEG Huffman encoder DC1
  $7E8 constant JPEG_JPEG_HUFFENC_DC1_2 \ JPEG Huffman encoder DC1
  $7EC constant JPEG_JPEG_HUFFENC_DC1_3 \ JPEG Huffman encoder DC1
  $7F0 constant JPEG_JPEG_HUFFENC_DC1_4 \ JPEG Huffman encoder DC1
  $7F4 constant JPEG_JPEG_HUFFENC_DC1_5 \ JPEG Huffman encoder DC1
  $7F8 constant JPEG_JPEG_HUFFENC_DC1_6 \ JPEG Huffman encoder DC1
  $7FC constant JPEG_JPEG_HUFFENC_DC1_7 \ JPEG Huffman encoder DC1

: JPEG_DEF ; [then]
