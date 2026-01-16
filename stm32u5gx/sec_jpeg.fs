\
\ @file sec_jpeg.fs
\ @brief JPEG address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief JPEG codec control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_JPEG_JPEG_CONFR0_START                       \ Start This bit start or stop the encoding or decoding process. Note: Reads always return 0.


\
\ @brief JPEG codec configuration register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000003 constant SEC_JPEG_JPEG_CONFR1_NF                          \ Number of color components This field defines the number of color components minus 1.
$00000008 constant SEC_JPEG_JPEG_CONFR1_DE                          \ Codec operation as coder or decoder This bit selects the code or decode process
$00000030 constant SEC_JPEG_JPEG_CONFR1_COLSPACE                    \ Color space This filed defines the number of quantization tables minus 1 to insert in the output stream.
$000000c0 constant SEC_JPEG_JPEG_CONFR1_NS                          \ Number of components for scan This field defines the number of components minus 1 for scan header marker segment.
$00000100 constant SEC_JPEG_JPEG_CONFR1_HDR                         \ Header processing This bit enables the header processing (generation/parsing).
$ffff0000 constant SEC_JPEG_JPEG_CONFR1_YSIZE                       \ Y Size This field defines the number of lines in source image.


\
\ @brief JPEG codec configuration register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$03ffffff constant SEC_JPEG_JPEG_CONFR2_NMCU                        \ Number of MCUs For encoding: this field defines the number of MCU units minus 1 to encode. For decoding: this field indicates the number of complete MCU units minus 1 to be decoded (this field is updated after the JPEG header parsing). If the decoded image size has not a X or Y size multiple of 8 or 16 (depending on the sub-sampling process), the resulting incomplete or empty MCU must be added to this value to get the total number of MCUs generated.


\
\ @brief JPEG codec configuration register 3
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$ffff0000 constant SEC_JPEG_JPEG_CONFR3_XSIZE                       \ X size This field defines the number of pixels per line.


\
\ @brief JPEG codec configuration register 4
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_JPEG_JPEG_CONFR4_HD                          \ Huffman DC Selects the Huffman table for encoding DC coefficients.
$00000002 constant SEC_JPEG_JPEG_CONFR4_HA                          \ Huffman AC Selects the Huffman table for encoding AC coefficients.
$0000000c constant SEC_JPEG_JPEG_CONFR4_QT                          \ Quantization table Selects quantization table used for component 0.
$000000f0 constant SEC_JPEG_JPEG_CONFR4_NB                          \ Number of blocks Number of data units minus 1 that belong to a particular color in the MCU.
$00000f00 constant SEC_JPEG_JPEG_CONFR4_VSF                         \ Vertical sampling factor Vertical sampling factor for component 0.
$0000f000 constant SEC_JPEG_JPEG_CONFR4_HSF                         \ Horizontal sampling factor Horizontal sampling factor for component 0.


\
\ @brief JPEG codec configuration register 5
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_JPEG_JPEG_CONFR5_HD                          \ Huffman DC Selects the Huffman table for encoding DC coefficients.
$00000002 constant SEC_JPEG_JPEG_CONFR5_HA                          \ Huffman AC Selects the Huffman table for encoding AC coefficients.
$0000000c constant SEC_JPEG_JPEG_CONFR5_QT                          \ Quantization table Selects quantization table used for component 1.
$000000f0 constant SEC_JPEG_JPEG_CONFR5_NB                          \ Number of blocks Number of data units minus 1 that belong to a particular color in the MCU.
$00000f00 constant SEC_JPEG_JPEG_CONFR5_VSF                         \ Vertical sampling factor Vertical sampling factor for component 1.
$0000f000 constant SEC_JPEG_JPEG_CONFR5_HSF                         \ Horizontal sampling factor Horizontal sampling factor for component 1.


\
\ @brief JPEG codec configuration register 6
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SEC_JPEG_JPEG_CONFR6_HD                          \ Huffman DC Selects the Huffman table for encoding DC coefficients.
$00000002 constant SEC_JPEG_JPEG_CONFR6_HA                          \ Huffman AC Selects the Huffman table for encoding AC coefficients.
$0000000c constant SEC_JPEG_JPEG_CONFR6_QT                          \ Quantization table Selects quantization table used for component 2.
$000000f0 constant SEC_JPEG_JPEG_CONFR6_NB                          \ Number of blocks Number of data units minus 1 that belong to a particular color in the MCU.
$00000f00 constant SEC_JPEG_JPEG_CONFR6_VSF                         \ Vertical sampling factor Vertical sampling factor for component 2.
$0000f000 constant SEC_JPEG_JPEG_CONFR6_HSF                         \ Horizontal sampling factor Horizontal sampling factor for component 2.


\
\ @brief JPEG codec configuration register 7
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SEC_JPEG_JPEG_CONFR7_HD                          \ Huffman DC Selects the Huffman table for encoding DC coefficients.
$00000002 constant SEC_JPEG_JPEG_CONFR7_HA                          \ Huffman AC Selects the Huffman table for encoding AC coefficients.
$0000000c constant SEC_JPEG_JPEG_CONFR7_QT                          \ Quantization table Selects quantization table used for component 3.
$000000f0 constant SEC_JPEG_JPEG_CONFR7_NB                          \ Number of blocks Number of data units minus 1 that belong to a particular color in the MCU.
$00000f00 constant SEC_JPEG_JPEG_CONFR7_VSF                         \ Vertical sampling factor Vertical sampling factor for component 3.
$0000f000 constant SEC_JPEG_JPEG_CONFR7_HSF                         \ Horizontal sampling factor Horizontal sampling factor for component 3.


\
\ @brief JPEG control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant SEC_JPEG_JPEG_CR_JCEN                            \ JPEG core enable This bit enables the JPEG codec core.
$00000002 constant SEC_JPEG_JPEG_CR_IFTIE                           \ Input FIFO threshold interrupt enable This bit enables interrupt generation when the input FIFO reaches a threshold.
$00000004 constant SEC_JPEG_JPEG_CR_IFNFIE                          \ Input FIFO not full interrupt enable This bit enables interrupt generation when the input FIFO is not empty.
$00000008 constant SEC_JPEG_JPEG_CR_OFTIE                           \ Output FIFO threshold interrupt enable This bit enables interrupt generation when the output FIFO reaches a threshold.
$00000010 constant SEC_JPEG_JPEG_CR_OFNEIE                          \ Output FIFO not empty interrupt enable This bit enables interrupt generation when the output FIFO is not empty.
$00000020 constant SEC_JPEG_JPEG_CR_EOCIE                           \ End of conversion interrupt enable This bit enables interrupt generation at the end of conversion.
$00000040 constant SEC_JPEG_JPEG_CR_HPDIE                           \ Header parsing done interrupt enable This bit enables interrupt generation upon the completion of the header parsing operation.
$00000800 constant SEC_JPEG_JPEG_CR_IDMAEN                          \ Input DMA enable Enables DMA request generation for the input FIFO.
$00001000 constant SEC_JPEG_JPEG_CR_ODMAEN                          \ Output DMA enable Enables DMA request generation for the output FIFO.
$00002000 constant SEC_JPEG_JPEG_CR_IFF                             \ Input FIFO flush This bit flushes the input FIFO. Note: Reads always return 0.
$00004000 constant SEC_JPEG_JPEG_CR_OFF                             \ Output FIFO flush This bit flushes the output FIFO. Note: Reads always return 0.


\
\ @brief JPEG status register
\ Address offset: 0x34
\ Reset value: 0x00000006
\

$00000002 constant SEC_JPEG_JPEG_SR_IFTF                            \ Input FIFO threshold flag This bit flags that the amount of data in the input FIFO is below a threshold. This flag must not be considered when using DMA.
$00000004 constant SEC_JPEG_JPEG_SR_IFNFF                           \ Input FIFO not full flag This bit flags that the input FIFO is not full (data can be written). This flag must not be considered when using DMA.
$00000008 constant SEC_JPEG_JPEG_SR_OFTF                            \ Output FIFO threshold flag This bit flags that the amount of data in the output FIFO reaches or exceeds a threshold. This flag must not be considered when using DMA.
$00000010 constant SEC_JPEG_JPEG_SR_OFNEF                           \ Output FIFO not empty flag This bit flags that data is available in the output FIFO. This flag must not be considered when using DMA.
$00000020 constant SEC_JPEG_JPEG_SR_EOCF                            \ End of conversion flag This bit flags the completion of encode/decode process and data transfer to the output FIFO.
$00000040 constant SEC_JPEG_JPEG_SR_HPDF                            \ Header parsing done flag In decode mode, this bit flags the completion of header parsing and updating internal registers.
$00000080 constant SEC_JPEG_JPEG_SR_COF                             \ Codec operation flag This bit flags code/decode operation in progress.


\
\ @brief JPEG clear flag register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000020 constant SEC_JPEG_JPEG_CFR_CEOCF                          \ Clear end of conversion flag Writing 1 clears the ECF bit of the JPEG_SR register.
$00000040 constant SEC_JPEG_JPEG_CFR_CHPDF                          \ Clear header parsing done flag Writing 1 clears the HPDF bit of the JPEG_SR register.


\
\ @brief JPEG data input register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_DIR_DATAIN                         \ Data input FIFO Input FIFO data register


\
\ @brief JPEG data output register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_DOR_DATAOUT                        \ Data output FIFO Output FIFO data register.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_0_QCOEF0                     \ Quantization coefficient 0 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_0_QCOEF1                     \ Quantization coefficient 1 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_0_QCOEF2                     \ Quantization coefficient 2 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_0_QCOEF3                     \ Quantization coefficient 3 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_1_QCOEF4                     \ Quantization coefficient 4 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_1_QCOEF5                     \ Quantization coefficient 5 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_1_QCOEF6                     \ Quantization coefficient 6 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_1_QCOEF7                     \ Quantization coefficient 7 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_2_QCOEF8                     \ Quantization coefficient 8 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_2_QCOEF9                     \ Quantization coefficient 9 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_2_QCOEF10                    \ Quantization coefficient 10 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_2_QCOEF11                    \ Quantization coefficient 11 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_3_QCOEF12                    \ Quantization coefficient 12 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_3_QCOEF13                    \ Quantization coefficient 13 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_3_QCOEF14                    \ Quantization coefficient 14 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_3_QCOEF15                    \ Quantization coefficient 15 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_4_QCOEF16                    \ Quantization coefficient 16 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_4_QCOEF17                    \ Quantization coefficient 17 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_4_QCOEF18                    \ Quantization coefficient 18 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_4_QCOEF19                    \ Quantization coefficient 19 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_5_QCOEF20                    \ Quantization coefficient 20 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_5_QCOEF21                    \ Quantization coefficient 21 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_5_QCOEF22                    \ Quantization coefficient 22 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_5_QCOEF23                    \ Quantization coefficient 23 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_6_QCOEF24                    \ Quantization coefficient 24 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_6_QCOEF25                    \ Quantization coefficient 25 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_6_QCOEF26                    \ Quantization coefficient 26 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_6_QCOEF27                    \ Quantization coefficient 27 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_7_QCOEF28                    \ Quantization coefficient 28 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_7_QCOEF29                    \ Quantization coefficient 29 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_7_QCOEF30                    \ Quantization coefficient 30 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_7_QCOEF31                    \ Quantization coefficient 31 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_8_QCOEF32                    \ Quantization coefficient 32 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_8_QCOEF33                    \ Quantization coefficient 33 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_8_QCOEF34                    \ Quantization coefficient 34 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_8_QCOEF35                    \ Quantization coefficient 35 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_9_QCOEF36                    \ Quantization coefficient 36 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_9_QCOEF37                    \ Quantization coefficient 37 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_9_QCOEF38                    \ Quantization coefficient 38 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_9_QCOEF39                    \ Quantization coefficient 39 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_10_QCOEF40                   \ Quantization coefficient 40 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_10_QCOEF41                   \ Quantization coefficient 41 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_10_QCOEF42                   \ Quantization coefficient 42 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_10_QCOEF43                   \ Quantization coefficient 43 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_11_QCOEF44                   \ Quantization coefficient 44 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_11_QCOEF45                   \ Quantization coefficient 45 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_11_QCOEF46                   \ Quantization coefficient 46 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_11_QCOEF47                   \ Quantization coefficient 47 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_12_QCOEF48                   \ Quantization coefficient 48 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_12_QCOEF49                   \ Quantization coefficient 49 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_12_QCOEF50                   \ Quantization coefficient 50 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_12_QCOEF51                   \ Quantization coefficient 51 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_13_QCOEF52                   \ Quantization coefficient 52 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_13_QCOEF53                   \ Quantization coefficient 53 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_13_QCOEF54                   \ Quantization coefficient 54 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_13_QCOEF55                   \ Quantization coefficient 55 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_14_QCOEF56                   \ Quantization coefficient 56 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_14_QCOEF57                   \ Quantization coefficient 57 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_14_QCOEF58                   \ Quantization coefficient 58 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_14_QCOEF59                   \ Quantization coefficient 59 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 0
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM0_15_QCOEF60                   \ Quantization coefficient 60 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM0_15_QCOEF61                   \ Quantization coefficient 61 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM0_15_QCOEF62                   \ Quantization coefficient 62 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM0_15_QCOEF63                   \ Quantization coefficient 63 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_0_QCOEF0                     \ Quantization coefficient 0 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_0_QCOEF1                     \ Quantization coefficient 1 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_0_QCOEF2                     \ Quantization coefficient 2 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_0_QCOEF3                     \ Quantization coefficient 3 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_1_QCOEF4                     \ Quantization coefficient 4 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_1_QCOEF5                     \ Quantization coefficient 5 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_1_QCOEF6                     \ Quantization coefficient 6 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_1_QCOEF7                     \ Quantization coefficient 7 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_2_QCOEF8                     \ Quantization coefficient 8 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_2_QCOEF9                     \ Quantization coefficient 9 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_2_QCOEF10                    \ Quantization coefficient 10 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_2_QCOEF11                    \ Quantization coefficient 11 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_3_QCOEF12                    \ Quantization coefficient 12 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_3_QCOEF13                    \ Quantization coefficient 13 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_3_QCOEF14                    \ Quantization coefficient 14 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_3_QCOEF15                    \ Quantization coefficient 15 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_4_QCOEF16                    \ Quantization coefficient 16 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_4_QCOEF17                    \ Quantization coefficient 17 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_4_QCOEF18                    \ Quantization coefficient 18 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_4_QCOEF19                    \ Quantization coefficient 19 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_5_QCOEF20                    \ Quantization coefficient 20 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_5_QCOEF21                    \ Quantization coefficient 21 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_5_QCOEF22                    \ Quantization coefficient 22 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_5_QCOEF23                    \ Quantization coefficient 23 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_6_QCOEF24                    \ Quantization coefficient 24 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_6_QCOEF25                    \ Quantization coefficient 25 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_6_QCOEF26                    \ Quantization coefficient 26 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_6_QCOEF27                    \ Quantization coefficient 27 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_7_QCOEF28                    \ Quantization coefficient 28 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_7_QCOEF29                    \ Quantization coefficient 29 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_7_QCOEF30                    \ Quantization coefficient 30 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_7_QCOEF31                    \ Quantization coefficient 31 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_8_QCOEF32                    \ Quantization coefficient 32 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_8_QCOEF33                    \ Quantization coefficient 33 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_8_QCOEF34                    \ Quantization coefficient 34 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_8_QCOEF35                    \ Quantization coefficient 35 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_9_QCOEF36                    \ Quantization coefficient 36 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_9_QCOEF37                    \ Quantization coefficient 37 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_9_QCOEF38                    \ Quantization coefficient 38 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_9_QCOEF39                    \ Quantization coefficient 39 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_10_QCOEF40                   \ Quantization coefficient 40 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_10_QCOEF41                   \ Quantization coefficient 41 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_10_QCOEF42                   \ Quantization coefficient 42 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_10_QCOEF43                   \ Quantization coefficient 43 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_11_QCOEF44                   \ Quantization coefficient 44 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_11_QCOEF45                   \ Quantization coefficient 45 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_11_QCOEF46                   \ Quantization coefficient 46 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_11_QCOEF47                   \ Quantization coefficient 47 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_12_QCOEF48                   \ Quantization coefficient 48 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_12_QCOEF49                   \ Quantization coefficient 49 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_12_QCOEF50                   \ Quantization coefficient 50 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_12_QCOEF51                   \ Quantization coefficient 51 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_13_QCOEF52                   \ Quantization coefficient 52 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_13_QCOEF53                   \ Quantization coefficient 53 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_13_QCOEF54                   \ Quantization coefficient 54 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_13_QCOEF55                   \ Quantization coefficient 55 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_14_QCOEF56                   \ Quantization coefficient 56 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_14_QCOEF57                   \ Quantization coefficient 57 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_14_QCOEF58                   \ Quantization coefficient 58 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_14_QCOEF59                   \ Quantization coefficient 59 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 1
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM1_15_QCOEF60                   \ Quantization coefficient 60 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM1_15_QCOEF61                   \ Quantization coefficient 61 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM1_15_QCOEF62                   \ Quantization coefficient 62 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM1_15_QCOEF63                   \ Quantization coefficient 63 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_0_QCOEF0                     \ Quantization coefficient 0 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_0_QCOEF1                     \ Quantization coefficient 1 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_0_QCOEF2                     \ Quantization coefficient 2 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_0_QCOEF3                     \ Quantization coefficient 3 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_1_QCOEF4                     \ Quantization coefficient 4 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_1_QCOEF5                     \ Quantization coefficient 5 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_1_QCOEF6                     \ Quantization coefficient 6 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_1_QCOEF7                     \ Quantization coefficient 7 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_2_QCOEF8                     \ Quantization coefficient 8 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_2_QCOEF9                     \ Quantization coefficient 9 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_2_QCOEF10                    \ Quantization coefficient 10 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_2_QCOEF11                    \ Quantization coefficient 11 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_3_QCOEF12                    \ Quantization coefficient 12 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_3_QCOEF13                    \ Quantization coefficient 13 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_3_QCOEF14                    \ Quantization coefficient 14 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_3_QCOEF15                    \ Quantization coefficient 15 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_4_QCOEF16                    \ Quantization coefficient 16 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_4_QCOEF17                    \ Quantization coefficient 17 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_4_QCOEF18                    \ Quantization coefficient 18 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_4_QCOEF19                    \ Quantization coefficient 19 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_5_QCOEF20                    \ Quantization coefficient 20 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_5_QCOEF21                    \ Quantization coefficient 21 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_5_QCOEF22                    \ Quantization coefficient 22 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_5_QCOEF23                    \ Quantization coefficient 23 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_6_QCOEF24                    \ Quantization coefficient 24 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_6_QCOEF25                    \ Quantization coefficient 25 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_6_QCOEF26                    \ Quantization coefficient 26 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_6_QCOEF27                    \ Quantization coefficient 27 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_7_QCOEF28                    \ Quantization coefficient 28 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_7_QCOEF29                    \ Quantization coefficient 29 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_7_QCOEF30                    \ Quantization coefficient 30 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_7_QCOEF31                    \ Quantization coefficient 31 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_8_QCOEF32                    \ Quantization coefficient 32 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_8_QCOEF33                    \ Quantization coefficient 33 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_8_QCOEF34                    \ Quantization coefficient 34 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_8_QCOEF35                    \ Quantization coefficient 35 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_9_QCOEF36                    \ Quantization coefficient 36 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_9_QCOEF37                    \ Quantization coefficient 37 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_9_QCOEF38                    \ Quantization coefficient 38 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_9_QCOEF39                    \ Quantization coefficient 39 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_10_QCOEF40                   \ Quantization coefficient 40 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_10_QCOEF41                   \ Quantization coefficient 41 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_10_QCOEF42                   \ Quantization coefficient 42 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_10_QCOEF43                   \ Quantization coefficient 43 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_11_QCOEF44                   \ Quantization coefficient 44 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_11_QCOEF45                   \ Quantization coefficient 45 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_11_QCOEF46                   \ Quantization coefficient 46 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_11_QCOEF47                   \ Quantization coefficient 47 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_12_QCOEF48                   \ Quantization coefficient 48 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_12_QCOEF49                   \ Quantization coefficient 49 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_12_QCOEF50                   \ Quantization coefficient 50 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_12_QCOEF51                   \ Quantization coefficient 51 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_13_QCOEF52                   \ Quantization coefficient 52 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_13_QCOEF53                   \ Quantization coefficient 53 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_13_QCOEF54                   \ Quantization coefficient 54 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_13_QCOEF55                   \ Quantization coefficient 55 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_14_QCOEF56                   \ Quantization coefficient 56 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_14_QCOEF57                   \ Quantization coefficient 57 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_14_QCOEF58                   \ Quantization coefficient 58 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_14_QCOEF59                   \ Quantization coefficient 59 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 2
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM2_15_QCOEF60                   \ Quantization coefficient 60 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM2_15_QCOEF61                   \ Quantization coefficient 61 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM2_15_QCOEF62                   \ Quantization coefficient 62 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM2_15_QCOEF63                   \ Quantization coefficient 63 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_0_QCOEF0                     \ Quantization coefficient 0 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_0_QCOEF1                     \ Quantization coefficient 1 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_0_QCOEF2                     \ Quantization coefficient 2 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_0_QCOEF3                     \ Quantization coefficient 3 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_1_QCOEF4                     \ Quantization coefficient 4 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_1_QCOEF5                     \ Quantization coefficient 5 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_1_QCOEF6                     \ Quantization coefficient 6 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_1_QCOEF7                     \ Quantization coefficient 7 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_2_QCOEF8                     \ Quantization coefficient 8 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_2_QCOEF9                     \ Quantization coefficient 9 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_2_QCOEF10                    \ Quantization coefficient 10 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_2_QCOEF11                    \ Quantization coefficient 11 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_3_QCOEF12                    \ Quantization coefficient 12 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_3_QCOEF13                    \ Quantization coefficient 13 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_3_QCOEF14                    \ Quantization coefficient 14 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_3_QCOEF15                    \ Quantization coefficient 15 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_4_QCOEF16                    \ Quantization coefficient 16 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_4_QCOEF17                    \ Quantization coefficient 17 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_4_QCOEF18                    \ Quantization coefficient 18 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_4_QCOEF19                    \ Quantization coefficient 19 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_5_QCOEF20                    \ Quantization coefficient 20 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_5_QCOEF21                    \ Quantization coefficient 21 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_5_QCOEF22                    \ Quantization coefficient 22 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_5_QCOEF23                    \ Quantization coefficient 23 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_6_QCOEF24                    \ Quantization coefficient 24 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_6_QCOEF25                    \ Quantization coefficient 25 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_6_QCOEF26                    \ Quantization coefficient 26 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_6_QCOEF27                    \ Quantization coefficient 27 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_7_QCOEF28                    \ Quantization coefficient 28 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_7_QCOEF29                    \ Quantization coefficient 29 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_7_QCOEF30                    \ Quantization coefficient 30 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_7_QCOEF31                    \ Quantization coefficient 31 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_8_QCOEF32                    \ Quantization coefficient 32 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_8_QCOEF33                    \ Quantization coefficient 33 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_8_QCOEF34                    \ Quantization coefficient 34 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_8_QCOEF35                    \ Quantization coefficient 35 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_9_QCOEF36                    \ Quantization coefficient 36 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_9_QCOEF37                    \ Quantization coefficient 37 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_9_QCOEF38                    \ Quantization coefficient 38 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_9_QCOEF39                    \ Quantization coefficient 39 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_10_QCOEF40                   \ Quantization coefficient 40 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_10_QCOEF41                   \ Quantization coefficient 41 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_10_QCOEF42                   \ Quantization coefficient 42 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_10_QCOEF43                   \ Quantization coefficient 43 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_11_QCOEF44                   \ Quantization coefficient 44 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_11_QCOEF45                   \ Quantization coefficient 45 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_11_QCOEF46                   \ Quantization coefficient 46 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_11_QCOEF47                   \ Quantization coefficient 47 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_12_QCOEF48                   \ Quantization coefficient 48 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_12_QCOEF49                   \ Quantization coefficient 49 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_12_QCOEF50                   \ Quantization coefficient 50 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_12_QCOEF51                   \ Quantization coefficient 51 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_13_QCOEF52                   \ Quantization coefficient 52 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_13_QCOEF53                   \ Quantization coefficient 53 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_13_QCOEF54                   \ Quantization coefficient 54 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_13_QCOEF55                   \ Quantization coefficient 55 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_14_QCOEF56                   \ Quantization coefficient 56 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_14_QCOEF57                   \ Quantization coefficient 57 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_14_QCOEF58                   \ Quantization coefficient 58 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_14_QCOEF59                   \ Quantization coefficient 59 8-bit quantization coefficient.


\
\ @brief JPEG quantization memory 3
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_QMEM3_15_QCOEF60                   \ Quantization coefficient 60 8-bit quantization coefficient.
$0000ff00 constant SEC_JPEG_JPEG_QMEM3_15_QCOEF61                   \ Quantization coefficient 61 8-bit quantization coefficient.
$00ff0000 constant SEC_JPEG_JPEG_QMEM3_15_QCOEF62                   \ Quantization coefficient 62 8-bit quantization coefficient.
$ff000000 constant SEC_JPEG_JPEG_QMEM3_15_QCOEF63                   \ Quantization coefficient 63 8-bit quantization coefficient.


\
\ @brief JPEG Huffman min
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN0_0_DATA0                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN0_1_DATA0                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN0_2_DATA0                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min 0 [alternate]
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$0000000f constant SEC_JPEG_JPEG_HUFFMIN0_3_DATA0                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN1_0_DATA1                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN1_1_DATA1                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN1_2_DATA1                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min 1 [alternate]
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$0000000f constant SEC_JPEG_JPEG_HUFFMIN1_3_DATA1                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN2_0_DATA2                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN2_1_DATA2                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN2_2_DATA2                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min 2 [alternate]
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$0000000f constant SEC_JPEG_JPEG_HUFFMIN2_3_DATA2                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN3_0_DATA3                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN3_1_DATA3                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000000 constant SEC_JPEG_JPEG_HUFFMIN3_2_DATA3                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman min 3 [alternate]
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$0000000f constant SEC_JPEG_JPEG_HUFFMIN3_3_DATA3                   \ Minimum Huffman value 100-bit minimum Huffman value used internally by the JPEG decoder.


\
\ @brief JPEG Huffman base
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE0_DATA0                    \ Data 0 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE0_DATA1                    \ Data 1 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE1_DATA2                    \ Data 2 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE1_DATA3                    \ Data 3 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE2_DATA4                    \ Data 4 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE2_DATA5                    \ Data 5 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE3_DATA6                    \ Data 6 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE3_DATA7                    \ Data 7 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE4_DATA8                    \ Data 8 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE4_DATA9                    \ Data 9 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE5_DATA10                   \ Data 10 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE5_DATA11                   \ Data 11 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE6_DATA12                   \ Data 12 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE6_DATA13                   \ Data 13 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE7_DATA14                   \ Data 14 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE7_DATA15                   \ Data 15 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE8_DATA16                   \ Data 16 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE8_DATA17                   \ Data 17 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE9_DATA18                   \ Data 18 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE9_DATA19                   \ Data 19 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE10_DATA20                  \ Data 20 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE10_DATA21                  \ Data 21 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE11_DATA22                  \ Data 22 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE11_DATA23                  \ Data 23 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE12_DATA24                  \ Data 24 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE12_DATA25                  \ Data 25 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE13_DATA26                  \ Data 26 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE13_DATA27                  \ Data 27 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE14_DATA28                  \ Data 28 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE14_DATA29                  \ Data 29 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE15_DATA30                  \ Data 30 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE15_DATA31                  \ Data 31 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE16_DATA32                  \ Data 32 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE16_DATA33                  \ Data 33 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE17_DATA34                  \ Data 34 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE17_DATA35                  \ Data 35 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1D8
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE18_DATA36                  \ Data 36 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE18_DATA37                  \ Data 37 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE19_DATA38                  \ Data 38 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE19_DATA39                  \ Data 39 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE20_DATA40                  \ Data 40 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE20_DATA41                  \ Data 41 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE21_DATA42                  \ Data 42 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE21_DATA43                  \ Data 43 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE22_DATA44                  \ Data 44 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE22_DATA45                  \ Data 45 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE23_DATA46                  \ Data 46 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE23_DATA47                  \ Data 47 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE24_DATA48                  \ Data 48 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE24_DATA49                  \ Data 49 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE25_DATA50                  \ Data 50 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE25_DATA51                  \ Data 51 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1F8
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE26_DATA52                  \ Data 52 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE26_DATA53                  \ Data 53 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x1FC
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE27_DATA54                  \ Data 54 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE27_DATA55                  \ Data 55 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE28_DATA56                  \ Data 56 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE28_DATA57                  \ Data 57 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE29_DATA58                  \ Data 58 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE29_DATA59                  \ Data 59 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE30_DATA60                  \ Data 60 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE30_DATA61                  \ Data 61 Base Huffman value.


\
\ @brief JPEG Huffman base
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$000001ff constant SEC_JPEG_JPEG_HUFFBASE31_DATA62                  \ Data 62 Base Huffman value.
$01ff0000 constant SEC_JPEG_JPEG_HUFFBASE31_DATA63                  \ Data 63 Base Huffman value.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB0_DATA0                    \ Data 0 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB0_DATA1                    \ Data 1 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB0_DATA2                    \ Data 2 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB0_DATA3                    \ Data 3 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB1_DATA4                    \ Data 4 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB1_DATA5                    \ Data 5 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB1_DATA6                    \ Data 6 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB1_DATA7                    \ Data 7 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB2_DATA8                    \ Data 8 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB2_DATA9                    \ Data 9 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB2_DATA10                   \ Data 10 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB2_DATA11                   \ Data 11 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB3_DATA12                   \ Data 12 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB3_DATA13                   \ Data 13 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB3_DATA14                   \ Data 14 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB3_DATA15                   \ Data 15 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB4_DATA16                   \ Data 16 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB4_DATA17                   \ Data 17 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB4_DATA18                   \ Data 18 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB4_DATA19                   \ Data 19 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB5_DATA20                   \ Data 20 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB5_DATA21                   \ Data 21 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB5_DATA22                   \ Data 22 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB5_DATA23                   \ Data 23 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB6_DATA24                   \ Data 24 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB6_DATA25                   \ Data 25 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB6_DATA26                   \ Data 26 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB6_DATA27                   \ Data 27 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB7_DATA28                   \ Data 28 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB7_DATA29                   \ Data 29 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB7_DATA30                   \ Data 30 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB7_DATA31                   \ Data 31 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB8_DATA32                   \ Data 32 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB8_DATA33                   \ Data 33 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB8_DATA34                   \ Data 34 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB8_DATA35                   \ Data 35 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB9_DATA36                   \ Data 36 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB9_DATA37                   \ Data 37 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB9_DATA38                   \ Data 38 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB9_DATA39                   \ Data 39 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB10_DATA40                  \ Data 40 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB10_DATA41                  \ Data 41 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB10_DATA42                  \ Data 42 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB10_DATA43                  \ Data 43 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x23C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB11_DATA44                  \ Data 44 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB11_DATA45                  \ Data 45 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB11_DATA46                  \ Data 46 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB11_DATA47                  \ Data 47 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB12_DATA48                  \ Data 48 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB12_DATA49                  \ Data 49 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB12_DATA50                  \ Data 50 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB12_DATA51                  \ Data 51 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB13_DATA52                  \ Data 52 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB13_DATA53                  \ Data 53 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB13_DATA54                  \ Data 54 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB13_DATA55                  \ Data 55 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB14_DATA56                  \ Data 56 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB14_DATA57                  \ Data 57 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB14_DATA58                  \ Data 58 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB14_DATA59                  \ Data 59 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB15_DATA60                  \ Data 60 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB15_DATA61                  \ Data 61 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB15_DATA62                  \ Data 62 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB15_DATA63                  \ Data 63 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB16_DATA64                  \ Data 64 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB16_DATA65                  \ Data 65 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB16_DATA66                  \ Data 66 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB16_DATA67                  \ Data 67 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB17_DATA68                  \ Data 68 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB17_DATA69                  \ Data 69 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB17_DATA70                  \ Data 70 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB17_DATA71                  \ Data 71 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB18_DATA72                  \ Data 72 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB18_DATA73                  \ Data 73 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB18_DATA74                  \ Data 74 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB18_DATA75                  \ Data 75 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB19_DATA76                  \ Data 76 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB19_DATA77                  \ Data 77 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB19_DATA78                  \ Data 78 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB19_DATA79                  \ Data 79 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB20_DATA80                  \ Data 80 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB20_DATA81                  \ Data 81 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB20_DATA82                  \ Data 82 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB20_DATA83                  \ Data 83 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB21_DATA84                  \ Data 84 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB21_DATA85                  \ Data 85 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB21_DATA86                  \ Data 86 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB21_DATA87                  \ Data 87 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB22_DATA88                  \ Data 88 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB22_DATA89                  \ Data 89 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB22_DATA90                  \ Data 90 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB22_DATA91                  \ Data 91 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB23_DATA92                  \ Data 92 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB23_DATA93                  \ Data 93 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB23_DATA94                  \ Data 94 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB23_DATA95                  \ Data 95 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB24_DATA96                  \ Data 96 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB24_DATA97                  \ Data 97 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB24_DATA98                  \ Data 98 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB24_DATA99                  \ Data 99 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB25_DATA100                 \ Data 100 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB25_DATA101                 \ Data 101 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB25_DATA102                 \ Data 102 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB25_DATA103                 \ Data 103 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x278
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB26_DATA104                 \ Data 104 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB26_DATA105                 \ Data 105 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB26_DATA106                 \ Data 106 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB26_DATA107                 \ Data 107 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB27_DATA108                 \ Data 108 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB27_DATA109                 \ Data 109 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB27_DATA110                 \ Data 110 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB27_DATA111                 \ Data 111 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB28_DATA112                 \ Data 112 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB28_DATA113                 \ Data 113 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB28_DATA114                 \ Data 114 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB28_DATA115                 \ Data 115 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB29_DATA116                 \ Data 116 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB29_DATA117                 \ Data 117 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB29_DATA118                 \ Data 118 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB29_DATA119                 \ Data 119 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB30_DATA120                 \ Data 120 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB30_DATA121                 \ Data 121 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB30_DATA122                 \ Data 122 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB30_DATA123                 \ Data 123 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB31_DATA124                 \ Data 124 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB31_DATA125                 \ Data 125 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB31_DATA126                 \ Data 126 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB31_DATA127                 \ Data 127 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB32_DATA128                 \ Data 128 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB32_DATA129                 \ Data 129 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB32_DATA130                 \ Data 130 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB32_DATA131                 \ Data 131 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB33_DATA132                 \ Data 132 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB33_DATA133                 \ Data 133 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB33_DATA134                 \ Data 134 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB33_DATA135                 \ Data 135 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB34_DATA136                 \ Data 136 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB34_DATA137                 \ Data 137 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB34_DATA138                 \ Data 138 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB34_DATA139                 \ Data 139 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB35_DATA140                 \ Data 140 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB35_DATA141                 \ Data 141 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB35_DATA142                 \ Data 142 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB35_DATA143                 \ Data 143 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB36_DATA144                 \ Data 144 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB36_DATA145                 \ Data 145 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB36_DATA146                 \ Data 146 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB36_DATA147                 \ Data 147 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB37_DATA148                 \ Data 148 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB37_DATA149                 \ Data 149 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB37_DATA150                 \ Data 150 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB37_DATA151                 \ Data 151 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB38_DATA152                 \ Data 152 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB38_DATA153                 \ Data 153 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB38_DATA154                 \ Data 154 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB38_DATA155                 \ Data 155 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB39_DATA156                 \ Data 156 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB39_DATA157                 \ Data 157 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB39_DATA158                 \ Data 158 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB39_DATA159                 \ Data 159 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2B0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB40_DATA160                 \ Data 160 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB40_DATA161                 \ Data 161 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB40_DATA162                 \ Data 162 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB40_DATA163                 \ Data 163 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2B4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB41_DATA164                 \ Data 164 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB41_DATA165                 \ Data 165 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB41_DATA166                 \ Data 166 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB41_DATA167                 \ Data 167 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2B8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB42_DATA168                 \ Data 168 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB42_DATA169                 \ Data 169 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB42_DATA170                 \ Data 170 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB42_DATA171                 \ Data 171 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2BC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB43_DATA172                 \ Data 172 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB43_DATA173                 \ Data 173 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB43_DATA174                 \ Data 174 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB43_DATA175                 \ Data 175 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2C0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB44_DATA176                 \ Data 176 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB44_DATA177                 \ Data 177 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB44_DATA178                 \ Data 178 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB44_DATA179                 \ Data 179 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2C4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB45_DATA180                 \ Data 180 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB45_DATA181                 \ Data 181 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB45_DATA182                 \ Data 182 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB45_DATA183                 \ Data 183 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2C8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB46_DATA184                 \ Data 184 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB46_DATA185                 \ Data 185 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB46_DATA186                 \ Data 186 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB46_DATA187                 \ Data 187 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB47_DATA188                 \ Data 188 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB47_DATA189                 \ Data 189 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB47_DATA190                 \ Data 190 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB47_DATA191                 \ Data 191 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB48_DATA192                 \ Data 192 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB48_DATA193                 \ Data 193 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB48_DATA194                 \ Data 194 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB48_DATA195                 \ Data 195 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2D4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB49_DATA196                 \ Data 196 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB49_DATA197                 \ Data 197 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB49_DATA198                 \ Data 198 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB49_DATA199                 \ Data 199 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2D8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB50_DATA200                 \ Data 200 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB50_DATA201                 \ Data 201 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB50_DATA202                 \ Data 202 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB50_DATA203                 \ Data 203 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB51_DATA204                 \ Data 204 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB51_DATA205                 \ Data 205 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB51_DATA206                 \ Data 206 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB51_DATA207                 \ Data 207 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2E0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB52_DATA208                 \ Data 208 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB52_DATA209                 \ Data 209 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB52_DATA210                 \ Data 210 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB52_DATA211                 \ Data 211 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB53_DATA212                 \ Data 212 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB53_DATA213                 \ Data 213 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB53_DATA214                 \ Data 214 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB53_DATA215                 \ Data 215 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2E8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB54_DATA216                 \ Data 216 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB54_DATA217                 \ Data 217 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB54_DATA218                 \ Data 218 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB54_DATA219                 \ Data 219 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2EC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB55_DATA220                 \ Data 220 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB55_DATA221                 \ Data 221 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB55_DATA222                 \ Data 222 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB55_DATA223                 \ Data 223 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2F0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB56_DATA224                 \ Data 224 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB56_DATA225                 \ Data 225 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB56_DATA226                 \ Data 226 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB56_DATA227                 \ Data 227 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2F4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB57_DATA228                 \ Data 228 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB57_DATA229                 \ Data 229 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB57_DATA230                 \ Data 230 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB57_DATA231                 \ Data 231 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2F8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB58_DATA232                 \ Data 232 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB58_DATA233                 \ Data 233 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB58_DATA234                 \ Data 234 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB58_DATA235                 \ Data 235 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x2FC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB59_DATA236                 \ Data 236 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB59_DATA237                 \ Data 237 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB59_DATA238                 \ Data 238 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB59_DATA239                 \ Data 239 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB60_DATA240                 \ Data 240 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB60_DATA241                 \ Data 241 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB60_DATA242                 \ Data 242 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB60_DATA243                 \ Data 243 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB61_DATA244                 \ Data 244 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB61_DATA245                 \ Data 245 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB61_DATA246                 \ Data 246 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB61_DATA247                 \ Data 247 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB62_DATA248                 \ Data 248 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB62_DATA249                 \ Data 249 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB62_DATA250                 \ Data 250 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB62_DATA251                 \ Data 251 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB63_DATA252                 \ Data 252 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB63_DATA253                 \ Data 253 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB63_DATA254                 \ Data 254 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB63_DATA255                 \ Data 255 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB64_DATA256                 \ Data 256 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB64_DATA257                 \ Data 257 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB64_DATA258                 \ Data 258 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB64_DATA259                 \ Data 259 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB65_DATA260                 \ Data 260 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB65_DATA261                 \ Data 261 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB65_DATA262                 \ Data 262 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB65_DATA263                 \ Data 263 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB66_DATA264                 \ Data 264 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB66_DATA265                 \ Data 265 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB66_DATA266                 \ Data 266 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB66_DATA267                 \ Data 267 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB67_DATA268                 \ Data 268 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB67_DATA269                 \ Data 269 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB67_DATA270                 \ Data 270 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB67_DATA271                 \ Data 271 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB68_DATA272                 \ Data 272 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB68_DATA273                 \ Data 273 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB68_DATA274                 \ Data 274 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB68_DATA275                 \ Data 275 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB69_DATA276                 \ Data 276 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB69_DATA277                 \ Data 277 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB69_DATA278                 \ Data 278 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB69_DATA279                 \ Data 279 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB70_DATA280                 \ Data 280 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB70_DATA281                 \ Data 281 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB70_DATA282                 \ Data 282 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB70_DATA283                 \ Data 283 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB71_DATA284                 \ Data 284 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB71_DATA285                 \ Data 285 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB71_DATA286                 \ Data 286 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB71_DATA287                 \ Data 287 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB72_DATA288                 \ Data 288 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB72_DATA289                 \ Data 289 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB72_DATA290                 \ Data 290 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB72_DATA291                 \ Data 291 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB73_DATA292                 \ Data 292 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB73_DATA293                 \ Data 293 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB73_DATA294                 \ Data 294 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB73_DATA295                 \ Data 295 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB74_DATA296                 \ Data 296 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB74_DATA297                 \ Data 297 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB74_DATA298                 \ Data 298 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB74_DATA299                 \ Data 299 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x33C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB75_DATA300                 \ Data 300 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB75_DATA301                 \ Data 301 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB75_DATA302                 \ Data 302 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB75_DATA303                 \ Data 303 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB76_DATA304                 \ Data 304 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB76_DATA305                 \ Data 305 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB76_DATA306                 \ Data 306 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB76_DATA307                 \ Data 307 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB77_DATA308                 \ Data 308 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB77_DATA309                 \ Data 309 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB77_DATA310                 \ Data 310 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB77_DATA311                 \ Data 311 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x348
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB78_DATA312                 \ Data 312 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB78_DATA313                 \ Data 313 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB78_DATA314                 \ Data 314 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB78_DATA315                 \ Data 315 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB79_DATA316                 \ Data 316 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB79_DATA317                 \ Data 317 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB79_DATA318                 \ Data 318 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB79_DATA319                 \ Data 319 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB80_DATA320                 \ Data 320 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB80_DATA321                 \ Data 321 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB80_DATA322                 \ Data 322 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB80_DATA323                 \ Data 323 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x354
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB81_DATA324                 \ Data 324 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB81_DATA325                 \ Data 325 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB81_DATA326                 \ Data 326 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB81_DATA327                 \ Data 327 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x358
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB82_DATA328                 \ Data 328 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB82_DATA329                 \ Data 329 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB82_DATA330                 \ Data 330 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB82_DATA331                 \ Data 331 Huffman symbol.


\
\ @brief JPEG Huffman symbol
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFSYMB83_DATA332                 \ Data 332 Huffman symbol.
$0000ff00 constant SEC_JPEG_JPEG_HUFFSYMB83_DATA333                 \ Data 333 Huffman symbol.
$00ff0000 constant SEC_JPEG_JPEG_HUFFSYMB83_DATA334                 \ Data 334 Huffman symbol.
$ff000000 constant SEC_JPEG_JPEG_HUFFSYMB83_DATA335                 \ Data 335 Huffman symbol.


\
\ @brief JPEG DHT memory
\ Address offset: 0x360
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM0_DATA0                      \ Huffman table data 0 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM0_DATA1                      \ Huffman table data 1 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM0_DATA2                      \ Huffman table data 2 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM0_DATA3                      \ Huffman table data 3 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM1_DATA4                      \ Huffman table data 4 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM1_DATA5                      \ Huffman table data 5 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM1_DATA6                      \ Huffman table data 6 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM1_DATA7                      \ Huffman table data 7 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x368
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM2_DATA8                      \ Huffman table data 8 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM2_DATA9                      \ Huffman table data 9 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM2_DATA10                     \ Huffman table data 10 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM2_DATA11                     \ Huffman table data 11 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x36C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM3_DATA12                     \ Huffman table data 12 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM3_DATA13                     \ Huffman table data 13 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM3_DATA14                     \ Huffman table data 14 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM3_DATA15                     \ Huffman table data 15 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM4_DATA16                     \ Huffman table data 16 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM4_DATA17                     \ Huffman table data 17 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM4_DATA18                     \ Huffman table data 18 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM4_DATA19                     \ Huffman table data 19 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x374
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM5_DATA20                     \ Huffman table data 20 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM5_DATA21                     \ Huffman table data 21 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM5_DATA22                     \ Huffman table data 22 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM5_DATA23                     \ Huffman table data 23 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x378
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM6_DATA24                     \ Huffman table data 24 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM6_DATA25                     \ Huffman table data 25 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM6_DATA26                     \ Huffman table data 26 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM6_DATA27                     \ Huffman table data 27 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x37C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM7_DATA28                     \ Huffman table data 28 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM7_DATA29                     \ Huffman table data 29 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM7_DATA30                     \ Huffman table data 30 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM7_DATA31                     \ Huffman table data 31 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM8_DATA32                     \ Huffman table data 32 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM8_DATA33                     \ Huffman table data 33 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM8_DATA34                     \ Huffman table data 34 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM8_DATA35                     \ Huffman table data 35 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM9_DATA36                     \ Huffman table data 36 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM9_DATA37                     \ Huffman table data 37 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM9_DATA38                     \ Huffman table data 38 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM9_DATA39                     \ Huffman table data 39 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x388
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM10_DATA40                    \ Huffman table data 40 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM10_DATA41                    \ Huffman table data 41 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM10_DATA42                    \ Huffman table data 42 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM10_DATA43                    \ Huffman table data 43 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x38C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM11_DATA44                    \ Huffman table data 44 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM11_DATA45                    \ Huffman table data 45 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM11_DATA46                    \ Huffman table data 46 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM11_DATA47                    \ Huffman table data 47 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM12_DATA48                    \ Huffman table data 48 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM12_DATA49                    \ Huffman table data 49 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM12_DATA50                    \ Huffman table data 50 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM12_DATA51                    \ Huffman table data 51 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM13_DATA52                    \ Huffman table data 52 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM13_DATA53                    \ Huffman table data 53 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM13_DATA54                    \ Huffman table data 54 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM13_DATA55                    \ Huffman table data 55 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM14_DATA56                    \ Huffman table data 56 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM14_DATA57                    \ Huffman table data 57 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM14_DATA58                    \ Huffman table data 58 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM14_DATA59                    \ Huffman table data 59 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM15_DATA60                    \ Huffman table data 60 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM15_DATA61                    \ Huffman table data 61 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM15_DATA62                    \ Huffman table data 62 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM15_DATA63                    \ Huffman table data 63 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM16_DATA64                    \ Huffman table data 64 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM16_DATA65                    \ Huffman table data 65 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM16_DATA66                    \ Huffman table data 66 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM16_DATA67                    \ Huffman table data 67 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3A4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM17_DATA68                    \ Huffman table data 68 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM17_DATA69                    \ Huffman table data 69 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM17_DATA70                    \ Huffman table data 70 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM17_DATA71                    \ Huffman table data 71 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3A8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM18_DATA72                    \ Huffman table data 72 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM18_DATA73                    \ Huffman table data 73 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM18_DATA74                    \ Huffman table data 74 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM18_DATA75                    \ Huffman table data 75 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3AC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM19_DATA76                    \ Huffman table data 76 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM19_DATA77                    \ Huffman table data 77 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM19_DATA78                    \ Huffman table data 78 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM19_DATA79                    \ Huffman table data 79 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3B0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM20_DATA80                    \ Huffman table data 80 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM20_DATA81                    \ Huffman table data 81 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM20_DATA82                    \ Huffman table data 82 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM20_DATA83                    \ Huffman table data 83 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3B4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM21_DATA84                    \ Huffman table data 84 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM21_DATA85                    \ Huffman table data 85 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM21_DATA86                    \ Huffman table data 86 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM21_DATA87                    \ Huffman table data 87 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3B8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM22_DATA88                    \ Huffman table data 88 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM22_DATA89                    \ Huffman table data 89 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM22_DATA90                    \ Huffman table data 90 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM22_DATA91                    \ Huffman table data 91 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3BC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM23_DATA92                    \ Huffman table data 92 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM23_DATA93                    \ Huffman table data 93 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM23_DATA94                    \ Huffman table data 94 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM23_DATA95                    \ Huffman table data 95 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3C0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM24_DATA96                    \ Huffman table data 96 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM24_DATA97                    \ Huffman table data 97 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM24_DATA98                    \ Huffman table data 98 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM24_DATA99                    \ Huffman table data 99 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3C4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM25_DATA100                   \ Huffman table data 100 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM25_DATA101                   \ Huffman table data 101 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM25_DATA102                   \ Huffman table data 102 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM25_DATA103                   \ Huffman table data 103 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3C8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM26_DATA104                   \ Huffman table data 104 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM26_DATA105                   \ Huffman table data 105 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM26_DATA106                   \ Huffman table data 106 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM26_DATA107                   \ Huffman table data 107 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3CC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM27_DATA108                   \ Huffman table data 108 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM27_DATA109                   \ Huffman table data 109 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM27_DATA110                   \ Huffman table data 110 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM27_DATA111                   \ Huffman table data 111 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM28_DATA112                   \ Huffman table data 112 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM28_DATA113                   \ Huffman table data 113 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM28_DATA114                   \ Huffman table data 114 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM28_DATA115                   \ Huffman table data 115 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3D4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM29_DATA116                   \ Huffman table data 116 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM29_DATA117                   \ Huffman table data 117 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM29_DATA118                   \ Huffman table data 118 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM29_DATA119                   \ Huffman table data 119 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3D8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM30_DATA120                   \ Huffman table data 120 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM30_DATA121                   \ Huffman table data 121 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM30_DATA122                   \ Huffman table data 122 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM30_DATA123                   \ Huffman table data 123 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM31_DATA124                   \ Huffman table data 124 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM31_DATA125                   \ Huffman table data 125 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM31_DATA126                   \ Huffman table data 126 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM31_DATA127                   \ Huffman table data 127 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM32_DATA128                   \ Huffman table data 128 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM32_DATA129                   \ Huffman table data 129 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM32_DATA130                   \ Huffman table data 130 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM32_DATA131                   \ Huffman table data 131 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM33_DATA132                   \ Huffman table data 132 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM33_DATA133                   \ Huffman table data 133 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM33_DATA134                   \ Huffman table data 134 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM33_DATA135                   \ Huffman table data 135 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3E8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM34_DATA136                   \ Huffman table data 136 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM34_DATA137                   \ Huffman table data 137 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM34_DATA138                   \ Huffman table data 138 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM34_DATA139                   \ Huffman table data 139 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3EC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM35_DATA140                   \ Huffman table data 140 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM35_DATA141                   \ Huffman table data 141 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM35_DATA142                   \ Huffman table data 142 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM35_DATA143                   \ Huffman table data 143 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM36_DATA144                   \ Huffman table data 144 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM36_DATA145                   \ Huffman table data 145 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM36_DATA146                   \ Huffman table data 146 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM36_DATA147                   \ Huffman table data 147 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3F4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM37_DATA148                   \ Huffman table data 148 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM37_DATA149                   \ Huffman table data 149 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM37_DATA150                   \ Huffman table data 150 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM37_DATA151                   \ Huffman table data 151 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3F8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM38_DATA152                   \ Huffman table data 152 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM38_DATA153                   \ Huffman table data 153 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM38_DATA154                   \ Huffman table data 154 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM38_DATA155                   \ Huffman table data 155 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x3FC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM39_DATA156                   \ Huffman table data 156 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM39_DATA157                   \ Huffman table data 157 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM39_DATA158                   \ Huffman table data 158 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM39_DATA159                   \ Huffman table data 159 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM40_DATA160                   \ Huffman table data 160 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM40_DATA161                   \ Huffman table data 161 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM40_DATA162                   \ Huffman table data 162 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM40_DATA163                   \ Huffman table data 163 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM41_DATA164                   \ Huffman table data 164 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM41_DATA165                   \ Huffman table data 165 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM41_DATA166                   \ Huffman table data 166 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM41_DATA167                   \ Huffman table data 167 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM42_DATA168                   \ Huffman table data 168 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM42_DATA169                   \ Huffman table data 169 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM42_DATA170                   \ Huffman table data 170 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM42_DATA171                   \ Huffman table data 171 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM43_DATA172                   \ Huffman table data 172 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM43_DATA173                   \ Huffman table data 173 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM43_DATA174                   \ Huffman table data 174 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM43_DATA175                   \ Huffman table data 175 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM44_DATA176                   \ Huffman table data 176 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM44_DATA177                   \ Huffman table data 177 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM44_DATA178                   \ Huffman table data 178 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM44_DATA179                   \ Huffman table data 179 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM45_DATA180                   \ Huffman table data 180 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM45_DATA181                   \ Huffman table data 181 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM45_DATA182                   \ Huffman table data 182 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM45_DATA183                   \ Huffman table data 183 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM46_DATA184                   \ Huffman table data 184 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM46_DATA185                   \ Huffman table data 185 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM46_DATA186                   \ Huffman table data 186 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM46_DATA187                   \ Huffman table data 187 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM47_DATA188                   \ Huffman table data 188 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM47_DATA189                   \ Huffman table data 189 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM47_DATA190                   \ Huffman table data 190 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM47_DATA191                   \ Huffman table data 191 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM48_DATA192                   \ Huffman table data 192 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM48_DATA193                   \ Huffman table data 193 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM48_DATA194                   \ Huffman table data 194 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM48_DATA195                   \ Huffman table data 195 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM49_DATA196                   \ Huffman table data 196 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM49_DATA197                   \ Huffman table data 197 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM49_DATA198                   \ Huffman table data 198 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM49_DATA199                   \ Huffman table data 199 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM50_DATA200                   \ Huffman table data 200 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM50_DATA201                   \ Huffman table data 201 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM50_DATA202                   \ Huffman table data 202 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM50_DATA203                   \ Huffman table data 203 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x42C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM51_DATA204                   \ Huffman table data 204 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM51_DATA205                   \ Huffman table data 205 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM51_DATA206                   \ Huffman table data 206 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM51_DATA207                   \ Huffman table data 207 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x430
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM52_DATA208                   \ Huffman table data 208 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM52_DATA209                   \ Huffman table data 209 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM52_DATA210                   \ Huffman table data 210 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM52_DATA211                   \ Huffman table data 211 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x434
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM53_DATA212                   \ Huffman table data 212 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM53_DATA213                   \ Huffman table data 213 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM53_DATA214                   \ Huffman table data 214 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM53_DATA215                   \ Huffman table data 215 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x438
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM54_DATA216                   \ Huffman table data 216 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM54_DATA217                   \ Huffman table data 217 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM54_DATA218                   \ Huffman table data 218 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM54_DATA219                   \ Huffman table data 219 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x43C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM55_DATA220                   \ Huffman table data 220 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM55_DATA221                   \ Huffman table data 221 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM55_DATA222                   \ Huffman table data 222 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM55_DATA223                   \ Huffman table data 223 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM56_DATA224                   \ Huffman table data 224 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM56_DATA225                   \ Huffman table data 225 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM56_DATA226                   \ Huffman table data 226 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM56_DATA227                   \ Huffman table data 227 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x444
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM57_DATA228                   \ Huffman table data 228 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM57_DATA229                   \ Huffman table data 229 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM57_DATA230                   \ Huffman table data 230 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM57_DATA231                   \ Huffman table data 231 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x448
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM58_DATA232                   \ Huffman table data 232 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM58_DATA233                   \ Huffman table data 233 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM58_DATA234                   \ Huffman table data 234 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM58_DATA235                   \ Huffman table data 235 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x44C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM59_DATA236                   \ Huffman table data 236 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM59_DATA237                   \ Huffman table data 237 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM59_DATA238                   \ Huffman table data 238 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM59_DATA239                   \ Huffman table data 239 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x450
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM60_DATA240                   \ Huffman table data 240 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM60_DATA241                   \ Huffman table data 241 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM60_DATA242                   \ Huffman table data 242 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM60_DATA243                   \ Huffman table data 243 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x454
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM61_DATA244                   \ Huffman table data 244 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM61_DATA245                   \ Huffman table data 245 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM61_DATA246                   \ Huffman table data 246 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM61_DATA247                   \ Huffman table data 247 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x458
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM62_DATA248                   \ Huffman table data 248 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM62_DATA249                   \ Huffman table data 249 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM62_DATA250                   \ Huffman table data 250 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM62_DATA251                   \ Huffman table data 251 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x45C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM63_DATA252                   \ Huffman table data 252 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM63_DATA253                   \ Huffman table data 253 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM63_DATA254                   \ Huffman table data 254 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM63_DATA255                   \ Huffman table data 255 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x460
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM64_DATA256                   \ Huffman table data 256 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM64_DATA257                   \ Huffman table data 257 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM64_DATA258                   \ Huffman table data 258 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM64_DATA259                   \ Huffman table data 259 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x464
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM65_DATA260                   \ Huffman table data 260 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM65_DATA261                   \ Huffman table data 261 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM65_DATA262                   \ Huffman table data 262 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM65_DATA263                   \ Huffman table data 263 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x468
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM66_DATA264                   \ Huffman table data 264 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM66_DATA265                   \ Huffman table data 265 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM66_DATA266                   \ Huffman table data 266 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM66_DATA267                   \ Huffman table data 267 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x46C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM67_DATA268                   \ Huffman table data 268 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM67_DATA269                   \ Huffman table data 269 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM67_DATA270                   \ Huffman table data 270 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM67_DATA271                   \ Huffman table data 271 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x470
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM68_DATA272                   \ Huffman table data 272 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM68_DATA273                   \ Huffman table data 273 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM68_DATA274                   \ Huffman table data 274 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM68_DATA275                   \ Huffman table data 275 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x474
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM69_DATA276                   \ Huffman table data 276 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM69_DATA277                   \ Huffman table data 277 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM69_DATA278                   \ Huffman table data 278 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM69_DATA279                   \ Huffman table data 279 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x478
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM70_DATA280                   \ Huffman table data 280 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM70_DATA281                   \ Huffman table data 281 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM70_DATA282                   \ Huffman table data 282 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM70_DATA283                   \ Huffman table data 283 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x47C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM71_DATA284                   \ Huffman table data 284 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM71_DATA285                   \ Huffman table data 285 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM71_DATA286                   \ Huffman table data 286 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM71_DATA287                   \ Huffman table data 287 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x480
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM72_DATA288                   \ Huffman table data 288 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM72_DATA289                   \ Huffman table data 289 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM72_DATA290                   \ Huffman table data 290 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM72_DATA291                   \ Huffman table data 291 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x484
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM73_DATA292                   \ Huffman table data 292 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM73_DATA293                   \ Huffman table data 293 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM73_DATA294                   \ Huffman table data 294 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM73_DATA295                   \ Huffman table data 295 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x488
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM74_DATA296                   \ Huffman table data 296 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM74_DATA297                   \ Huffman table data 297 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM74_DATA298                   \ Huffman table data 298 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM74_DATA299                   \ Huffman table data 299 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x48C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM75_DATA300                   \ Huffman table data 300 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM75_DATA301                   \ Huffman table data 301 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM75_DATA302                   \ Huffman table data 302 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM75_DATA303                   \ Huffman table data 303 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x490
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM76_DATA304                   \ Huffman table data 304 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM76_DATA305                   \ Huffman table data 305 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM76_DATA306                   \ Huffman table data 306 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM76_DATA307                   \ Huffman table data 307 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x494
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM77_DATA308                   \ Huffman table data 308 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM77_DATA309                   \ Huffman table data 309 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM77_DATA310                   \ Huffman table data 310 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM77_DATA311                   \ Huffman table data 311 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM78_DATA312                   \ Huffman table data 312 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM78_DATA313                   \ Huffman table data 313 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM78_DATA314                   \ Huffman table data 314 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM78_DATA315                   \ Huffman table data 315 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x49C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM79_DATA316                   \ Huffman table data 316 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM79_DATA317                   \ Huffman table data 317 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM79_DATA318                   \ Huffman table data 318 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM79_DATA319                   \ Huffman table data 319 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM80_DATA320                   \ Huffman table data 320 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM80_DATA321                   \ Huffman table data 321 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM80_DATA322                   \ Huffman table data 322 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM80_DATA323                   \ Huffman table data 323 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4A4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM81_DATA324                   \ Huffman table data 324 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM81_DATA325                   \ Huffman table data 325 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM81_DATA326                   \ Huffman table data 326 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM81_DATA327                   \ Huffman table data 327 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4A8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM82_DATA328                   \ Huffman table data 328 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM82_DATA329                   \ Huffman table data 329 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM82_DATA330                   \ Huffman table data 330 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM82_DATA331                   \ Huffman table data 331 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4AC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM83_DATA332                   \ Huffman table data 332 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM83_DATA333                   \ Huffman table data 333 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM83_DATA334                   \ Huffman table data 334 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM83_DATA335                   \ Huffman table data 335 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4B0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM84_DATA336                   \ Huffman table data 336 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM84_DATA337                   \ Huffman table data 337 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM84_DATA338                   \ Huffman table data 338 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM84_DATA339                   \ Huffman table data 339 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4B4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM85_DATA340                   \ Huffman table data 340 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM85_DATA341                   \ Huffman table data 341 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM85_DATA342                   \ Huffman table data 342 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM85_DATA343                   \ Huffman table data 343 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4B8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM86_DATA344                   \ Huffman table data 344 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM86_DATA345                   \ Huffman table data 345 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM86_DATA346                   \ Huffman table data 346 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM86_DATA347                   \ Huffman table data 347 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4BC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM87_DATA348                   \ Huffman table data 348 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM87_DATA349                   \ Huffman table data 349 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM87_DATA350                   \ Huffman table data 350 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM87_DATA351                   \ Huffman table data 351 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4C0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM88_DATA352                   \ Huffman table data 352 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM88_DATA353                   \ Huffman table data 353 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM88_DATA354                   \ Huffman table data 354 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM88_DATA355                   \ Huffman table data 355 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4C4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM89_DATA356                   \ Huffman table data 356 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM89_DATA357                   \ Huffman table data 357 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM89_DATA358                   \ Huffman table data 358 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM89_DATA359                   \ Huffman table data 359 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4C8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM90_DATA360                   \ Huffman table data 360 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM90_DATA361                   \ Huffman table data 361 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM90_DATA362                   \ Huffman table data 362 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM90_DATA363                   \ Huffman table data 363 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4CC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM91_DATA364                   \ Huffman table data 364 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM91_DATA365                   \ Huffman table data 365 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM91_DATA366                   \ Huffman table data 366 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM91_DATA367                   \ Huffman table data 367 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4D0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM92_DATA368                   \ Huffman table data 368 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM92_DATA369                   \ Huffman table data 369 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM92_DATA370                   \ Huffman table data 370 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM92_DATA371                   \ Huffman table data 371 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4D4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM93_DATA372                   \ Huffman table data 372 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM93_DATA373                   \ Huffman table data 373 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM93_DATA374                   \ Huffman table data 374 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM93_DATA375                   \ Huffman table data 375 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4D8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM94_DATA376                   \ Huffman table data 376 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM94_DATA377                   \ Huffman table data 377 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM94_DATA378                   \ Huffman table data 378 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM94_DATA379                   \ Huffman table data 379 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4DC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM95_DATA380                   \ Huffman table data 380 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM95_DATA381                   \ Huffman table data 381 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM95_DATA382                   \ Huffman table data 382 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM95_DATA383                   \ Huffman table data 383 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4E0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM96_DATA384                   \ Huffman table data 384 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM96_DATA385                   \ Huffman table data 385 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM96_DATA386                   \ Huffman table data 386 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM96_DATA387                   \ Huffman table data 387 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4E4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM97_DATA388                   \ Huffman table data 388 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM97_DATA389                   \ Huffman table data 389 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM97_DATA390                   \ Huffman table data 390 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM97_DATA391                   \ Huffman table data 391 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4E8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM98_DATA392                   \ Huffman table data 392 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM98_DATA393                   \ Huffman table data 393 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM98_DATA394                   \ Huffman table data 394 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM98_DATA395                   \ Huffman table data 395 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4EC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM99_DATA396                   \ Huffman table data 396 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM99_DATA397                   \ Huffman table data 397 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM99_DATA398                   \ Huffman table data 398 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM99_DATA399                   \ Huffman table data 399 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4F0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM100_DATA400                  \ Huffman table data 400 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM100_DATA401                  \ Huffman table data 401 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM100_DATA402                  \ Huffman table data 402 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM100_DATA403                  \ Huffman table data 403 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4F4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM101_DATA404                  \ Huffman table data 404 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM101_DATA405                  \ Huffman table data 405 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM101_DATA406                  \ Huffman table data 406 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM101_DATA407                  \ Huffman table data 407 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG DHT memory
\ Address offset: 0x4F8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_DHTMEM102_DATA408                  \ Huffman table data 408 Huffman table data for DHT marker segment generation.
$0000ff00 constant SEC_JPEG_JPEG_DHTMEM102_DATA409                  \ Huffman table data 409 Huffman table data for DHT marker segment generation.
$00ff0000 constant SEC_JPEG_JPEG_DHTMEM102_DATA410                  \ Huffman table data 410 Huffman table data for DHT marker segment generation.
$ff000000 constant SEC_JPEG_JPEG_DHTMEM102_DATA411                  \ Huffman table data 411 Huffman table data for DHT marker segment generation.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_0_HCODE0               \ Huffman code 0 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_0_HLEN0                \ Huffman length 0 Number of bits in the Huffman code HCODE0 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_0_HCODE1               \ Huffman code 1 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_0_HLEN1                \ Huffman length 1 Number of bits in the Huffman code HCODE1 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x504
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_1_HCODE2               \ Huffman code 2 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_1_HLEN2                \ Huffman length 2 Number of bits in the Huffman code HCODE2 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_1_HCODE3               \ Huffman code 3 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_1_HLEN3                \ Huffman length 3 Number of bits in the Huffman code HCODE3 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_2_HCODE4               \ Huffman code 4 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_2_HLEN4                \ Huffman length 4 Number of bits in the Huffman code HCODE4 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_2_HCODE5               \ Huffman code 5 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_2_HLEN5                \ Huffman length 5 Number of bits in the Huffman code HCODE5 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x50C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_3_HCODE6               \ Huffman code 6 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_3_HLEN6                \ Huffman length 6 Number of bits in the Huffman code HCODE6 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_3_HCODE7               \ Huffman code 7 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_3_HLEN7                \ Huffman length 7 Number of bits in the Huffman code HCODE7 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_4_HCODE8               \ Huffman code 8 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_4_HLEN8                \ Huffman length 8 Number of bits in the Huffman code HCODE8 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_4_HCODE9               \ Huffman code 9 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_4_HLEN9                \ Huffman length 9 Number of bits in the Huffman code HCODE9 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x514
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_5_HCODE10              \ Huffman code 10 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_5_HLEN10               \ Huffman length 10 Number of bits in the Huffman code HCODE10 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_5_HCODE11              \ Huffman code 11 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_5_HLEN11               \ Huffman length 11 Number of bits in the Huffman code HCODE11 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x518
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_6_HCODE12              \ Huffman code 12 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_6_HLEN12               \ Huffman length 12 Number of bits in the Huffman code HCODE12 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_6_HCODE13              \ Huffman code 13 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_6_HLEN13               \ Huffman length 13 Number of bits in the Huffman code HCODE13 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x51C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_7_HCODE14              \ Huffman code 14 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_7_HLEN14               \ Huffman length 14 Number of bits in the Huffman code HCODE14 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_7_HCODE15              \ Huffman code 15 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_7_HLEN15               \ Huffman length 15 Number of bits in the Huffman code HCODE15 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_8_HCODE16              \ Huffman code 16 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_8_HLEN16               \ Huffman length 16 Number of bits in the Huffman code HCODE16 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_8_HCODE17              \ Huffman code 17 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_8_HLEN17               \ Huffman length 17 Number of bits in the Huffman code HCODE17 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x524
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_9_HCODE18              \ Huffman code 18 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_9_HLEN18               \ Huffman length 18 Number of bits in the Huffman code HCODE18 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_9_HCODE19              \ Huffman code 19 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_9_HLEN19               \ Huffman length 19 Number of bits in the Huffman code HCODE19 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x528
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_10_HCODE20             \ Huffman code 20 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_10_HLEN20              \ Huffman length 20 Number of bits in the Huffman code HCODE20 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_10_HCODE21             \ Huffman code 21 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_10_HLEN21              \ Huffman length 21 Number of bits in the Huffman code HCODE21 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x52C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_11_HCODE22             \ Huffman code 22 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_11_HLEN22              \ Huffman length 22 Number of bits in the Huffman code HCODE22 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_11_HCODE23             \ Huffman code 23 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_11_HLEN23              \ Huffman length 23 Number of bits in the Huffman code HCODE23 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x530
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_12_HCODE24             \ Huffman code 24 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_12_HLEN24              \ Huffman length 24 Number of bits in the Huffman code HCODE24 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_12_HCODE25             \ Huffman code 25 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_12_HLEN25              \ Huffman length 25 Number of bits in the Huffman code HCODE25 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x534
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_13_HCODE26             \ Huffman code 26 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_13_HLEN26              \ Huffman length 26 Number of bits in the Huffman code HCODE26 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_13_HCODE27             \ Huffman code 27 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_13_HLEN27              \ Huffman length 27 Number of bits in the Huffman code HCODE27 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x538
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_14_HCODE28             \ Huffman code 28 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_14_HLEN28              \ Huffman length 28 Number of bits in the Huffman code HCODE28 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_14_HCODE29             \ Huffman code 29 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_14_HLEN29              \ Huffman length 29 Number of bits in the Huffman code HCODE29 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x53C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_15_HCODE30             \ Huffman code 30 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_15_HLEN30              \ Huffman length 30 Number of bits in the Huffman code HCODE30 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_15_HCODE31             \ Huffman code 31 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_15_HLEN31              \ Huffman length 31 Number of bits in the Huffman code HCODE31 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x540
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_16_HCODE32             \ Huffman code 32 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_16_HLEN32              \ Huffman length 32 Number of bits in the Huffman code HCODE32 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_16_HCODE33             \ Huffman code 33 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_16_HLEN33              \ Huffman length 33 Number of bits in the Huffman code HCODE33 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x544
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_17_HCODE34             \ Huffman code 34 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_17_HLEN34              \ Huffman length 34 Number of bits in the Huffman code HCODE34 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_17_HCODE35             \ Huffman code 35 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_17_HLEN35              \ Huffman length 35 Number of bits in the Huffman code HCODE35 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x548
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_18_HCODE36             \ Huffman code 36 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_18_HLEN36              \ Huffman length 36 Number of bits in the Huffman code HCODE36 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_18_HCODE37             \ Huffman code 37 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_18_HLEN37              \ Huffman length 37 Number of bits in the Huffman code HCODE37 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_19_HCODE38             \ Huffman code 38 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_19_HLEN38              \ Huffman length 38 Number of bits in the Huffman code HCODE38 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_19_HCODE39             \ Huffman code 39 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_19_HLEN39              \ Huffman length 39 Number of bits in the Huffman code HCODE39 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_20_HCODE40             \ Huffman code 40 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_20_HLEN40              \ Huffman length 40 Number of bits in the Huffman code HCODE40 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_20_HCODE41             \ Huffman code 41 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_20_HLEN41              \ Huffman length 41 Number of bits in the Huffman code HCODE41 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x554
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_21_HCODE42             \ Huffman code 42 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_21_HLEN42              \ Huffman length 42 Number of bits in the Huffman code HCODE42 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_21_HCODE43             \ Huffman code 43 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_21_HLEN43              \ Huffman length 43 Number of bits in the Huffman code HCODE43 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x558
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_22_HCODE44             \ Huffman code 44 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_22_HLEN44              \ Huffman length 44 Number of bits in the Huffman code HCODE44 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_22_HCODE45             \ Huffman code 45 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_22_HLEN45              \ Huffman length 45 Number of bits in the Huffman code HCODE45 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x55C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_23_HCODE46             \ Huffman code 46 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_23_HLEN46              \ Huffman length 46 Number of bits in the Huffman code HCODE46 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_23_HCODE47             \ Huffman code 47 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_23_HLEN47              \ Huffman length 47 Number of bits in the Huffman code HCODE47 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x560
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_24_HCODE48             \ Huffman code 48 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_24_HLEN48              \ Huffman length 48 Number of bits in the Huffman code HCODE48 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_24_HCODE49             \ Huffman code 49 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_24_HLEN49              \ Huffman length 49 Number of bits in the Huffman code HCODE49 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x564
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_25_HCODE50             \ Huffman code 50 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_25_HLEN50              \ Huffman length 50 Number of bits in the Huffman code HCODE50 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_25_HCODE51             \ Huffman code 51 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_25_HLEN51              \ Huffman length 51 Number of bits in the Huffman code HCODE51 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x568
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_26_HCODE52             \ Huffman code 52 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_26_HLEN52              \ Huffman length 52 Number of bits in the Huffman code HCODE52 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_26_HCODE53             \ Huffman code 53 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_26_HLEN53              \ Huffman length 53 Number of bits in the Huffman code HCODE53 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x56C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_27_HCODE54             \ Huffman code 54 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_27_HLEN54              \ Huffman length 54 Number of bits in the Huffman code HCODE54 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_27_HCODE55             \ Huffman code 55 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_27_HLEN55              \ Huffman length 55 Number of bits in the Huffman code HCODE55 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x570
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_28_HCODE56             \ Huffman code 56 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_28_HLEN56              \ Huffman length 56 Number of bits in the Huffman code HCODE56 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_28_HCODE57             \ Huffman code 57 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_28_HLEN57              \ Huffman length 57 Number of bits in the Huffman code HCODE57 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x574
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_29_HCODE58             \ Huffman code 58 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_29_HLEN58              \ Huffman length 58 Number of bits in the Huffman code HCODE58 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_29_HCODE59             \ Huffman code 59 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_29_HLEN59              \ Huffman length 59 Number of bits in the Huffman code HCODE59 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x578
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_30_HCODE60             \ Huffman code 60 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_30_HLEN60              \ Huffman length 60 Number of bits in the Huffman code HCODE60 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_30_HCODE61             \ Huffman code 61 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_30_HLEN61              \ Huffman length 61 Number of bits in the Huffman code HCODE61 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x57C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_31_HCODE62             \ Huffman code 62 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_31_HLEN62              \ Huffman length 62 Number of bits in the Huffman code HCODE62 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_31_HCODE63             \ Huffman code 63 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_31_HLEN63              \ Huffman length 63 Number of bits in the Huffman code HCODE63 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x580
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_32_HCODE64             \ Huffman code 64 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_32_HLEN64              \ Huffman length 64 Number of bits in the Huffman code HCODE64 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_32_HCODE65             \ Huffman code 65 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_32_HLEN65              \ Huffman length 65 Number of bits in the Huffman code HCODE65 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x584
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_33_HCODE66             \ Huffman code 66 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_33_HLEN66              \ Huffman length 66 Number of bits in the Huffman code HCODE66 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_33_HCODE67             \ Huffman code 67 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_33_HLEN67              \ Huffman length 67 Number of bits in the Huffman code HCODE67 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x588
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_34_HCODE68             \ Huffman code 68 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_34_HLEN68              \ Huffman length 68 Number of bits in the Huffman code HCODE68 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_34_HCODE69             \ Huffman code 69 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_34_HLEN69              \ Huffman length 69 Number of bits in the Huffman code HCODE69 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x58C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_35_HCODE70             \ Huffman code 70 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_35_HLEN70              \ Huffman length 70 Number of bits in the Huffman code HCODE70 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_35_HCODE71             \ Huffman code 71 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_35_HLEN71              \ Huffman length 71 Number of bits in the Huffman code HCODE71 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x590
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_36_HCODE72             \ Huffman code 72 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_36_HLEN72              \ Huffman length 72 Number of bits in the Huffman code HCODE72 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_36_HCODE73             \ Huffman code 73 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_36_HLEN73              \ Huffman length 73 Number of bits in the Huffman code HCODE73 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x594
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_37_HCODE74             \ Huffman code 74 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_37_HLEN74              \ Huffman length 74 Number of bits in the Huffman code HCODE74 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_37_HCODE75             \ Huffman code 75 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_37_HLEN75              \ Huffman length 75 Number of bits in the Huffman code HCODE75 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x598
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_38_HCODE76             \ Huffman code 76 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_38_HLEN76              \ Huffman length 76 Number of bits in the Huffman code HCODE76 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_38_HCODE77             \ Huffman code 77 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_38_HLEN77              \ Huffman length 77 Number of bits in the Huffman code HCODE77 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x59C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_39_HCODE78             \ Huffman code 78 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_39_HLEN78              \ Huffman length 78 Number of bits in the Huffman code HCODE78 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_39_HCODE79             \ Huffman code 79 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_39_HLEN79              \ Huffman length 79 Number of bits in the Huffman code HCODE79 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5A0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_40_HCODE80             \ Huffman code 80 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_40_HLEN80              \ Huffman length 80 Number of bits in the Huffman code HCODE80 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_40_HCODE81             \ Huffman code 81 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_40_HLEN81              \ Huffman length 81 Number of bits in the Huffman code HCODE81 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5A4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_41_HCODE82             \ Huffman code 82 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_41_HLEN82              \ Huffman length 82 Number of bits in the Huffman code HCODE82 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_41_HCODE83             \ Huffman code 83 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_41_HLEN83              \ Huffman length 83 Number of bits in the Huffman code HCODE83 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5A8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_42_HCODE84             \ Huffman code 84 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_42_HLEN84              \ Huffman length 84 Number of bits in the Huffman code HCODE84 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_42_HCODE85             \ Huffman code 85 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_42_HLEN85              \ Huffman length 85 Number of bits in the Huffman code HCODE85 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5AC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_43_HCODE86             \ Huffman code 86 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_43_HLEN86              \ Huffman length 86 Number of bits in the Huffman code HCODE86 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_43_HCODE87             \ Huffman code 87 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_43_HLEN87              \ Huffman length 87 Number of bits in the Huffman code HCODE87 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5B0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_44_HCODE88             \ Huffman code 88 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_44_HLEN88              \ Huffman length 88 Number of bits in the Huffman code HCODE88 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_44_HCODE89             \ Huffman code 89 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_44_HLEN89              \ Huffman length 89 Number of bits in the Huffman code HCODE89 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5B4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_45_HCODE90             \ Huffman code 90 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_45_HLEN90              \ Huffman length 90 Number of bits in the Huffman code HCODE90 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_45_HCODE91             \ Huffman code 91 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_45_HLEN91              \ Huffman length 91 Number of bits in the Huffman code HCODE91 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5B8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_46_HCODE92             \ Huffman code 92 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_46_HLEN92              \ Huffman length 92 Number of bits in the Huffman code HCODE92 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_46_HCODE93             \ Huffman code 93 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_46_HLEN93              \ Huffman length 93 Number of bits in the Huffman code HCODE93 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5BC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_47_HCODE94             \ Huffman code 94 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_47_HLEN94              \ Huffman length 94 Number of bits in the Huffman code HCODE94 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_47_HCODE95             \ Huffman code 95 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_47_HLEN95              \ Huffman length 95 Number of bits in the Huffman code HCODE95 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5C0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_48_HCODE96             \ Huffman code 96 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_48_HLEN96              \ Huffman length 96 Number of bits in the Huffman code HCODE96 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_48_HCODE97             \ Huffman code 97 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_48_HLEN97              \ Huffman length 97 Number of bits in the Huffman code HCODE97 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5C4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_49_HCODE98             \ Huffman code 98 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_49_HLEN98              \ Huffman length 98 Number of bits in the Huffman code HCODE98 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_49_HCODE99             \ Huffman code 99 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_49_HLEN99              \ Huffman length 99 Number of bits in the Huffman code HCODE99 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5C8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_50_HCODE100            \ Huffman code 100 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_50_HLEN100             \ Huffman length 100 Number of bits in the Huffman code HCODE100 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_50_HCODE101            \ Huffman code 101 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_50_HLEN101             \ Huffman length 101 Number of bits in the Huffman code HCODE101 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5CC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_51_HCODE102            \ Huffman code 102 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_51_HLEN102             \ Huffman length 102 Number of bits in the Huffman code HCODE102 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_51_HCODE103            \ Huffman code 103 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_51_HLEN103             \ Huffman length 103 Number of bits in the Huffman code HCODE103 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_52_HCODE104            \ Huffman code 104 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_52_HLEN104             \ Huffman length 104 Number of bits in the Huffman code HCODE104 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_52_HCODE105            \ Huffman code 105 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_52_HLEN105             \ Huffman length 105 Number of bits in the Huffman code HCODE105 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5D4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_53_HCODE106            \ Huffman code 106 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_53_HLEN106             \ Huffman length 106 Number of bits in the Huffman code HCODE106 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_53_HCODE107            \ Huffman code 107 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_53_HLEN107             \ Huffman length 107 Number of bits in the Huffman code HCODE107 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5D8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_54_HCODE108            \ Huffman code 108 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_54_HLEN108             \ Huffman length 108 Number of bits in the Huffman code HCODE108 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_54_HCODE109            \ Huffman code 109 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_54_HLEN109             \ Huffman length 109 Number of bits in the Huffman code HCODE109 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5DC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_55_HCODE110            \ Huffman code 110 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_55_HLEN110             \ Huffman length 110 Number of bits in the Huffman code HCODE110 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_55_HCODE111            \ Huffman code 111 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_55_HLEN111             \ Huffman length 111 Number of bits in the Huffman code HCODE111 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x5DC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_0_HCODE0               \ Huffman code 0 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_0_HLEN0                \ Huffman length 0 Number of bits in the Huffman code HCODE0 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_0_HCODE1               \ Huffman code 1 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_0_HLEN1                \ Huffman length 1 Number of bits in the Huffman code HCODE1 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5E0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_56_HCODE112            \ Huffman code 112 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_56_HLEN112             \ Huffman length 112 Number of bits in the Huffman code HCODE112 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_56_HCODE113            \ Huffman code 113 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_56_HLEN113             \ Huffman length 113 Number of bits in the Huffman code HCODE113 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x5E0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_1_HCODE2               \ Huffman code 2 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_1_HLEN2                \ Huffman length 2 Number of bits in the Huffman code HCODE2 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_1_HCODE3               \ Huffman code 3 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_1_HLEN3                \ Huffman length 3 Number of bits in the Huffman code HCODE3 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5E4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_57_HCODE114            \ Huffman code 114 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_57_HLEN114             \ Huffman length 114 Number of bits in the Huffman code HCODE114 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_57_HCODE115            \ Huffman code 115 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_57_HLEN115             \ Huffman length 115 Number of bits in the Huffman code HCODE115 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x5E4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_2_HCODE4               \ Huffman code 4 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_2_HLEN4                \ Huffman length 4 Number of bits in the Huffman code HCODE4 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_2_HCODE5               \ Huffman code 5 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_2_HLEN5                \ Huffman length 5 Number of bits in the Huffman code HCODE5 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5E8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_58_HCODE116            \ Huffman code 116 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_58_HLEN116             \ Huffman length 116 Number of bits in the Huffman code HCODE116 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_58_HCODE117            \ Huffman code 117 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_58_HLEN117             \ Huffman length 117 Number of bits in the Huffman code HCODE117 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x5E8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_3_HCODE6               \ Huffman code 6 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_3_HLEN6                \ Huffman length 6 Number of bits in the Huffman code HCODE6 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_3_HCODE7               \ Huffman code 7 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_3_HLEN7                \ Huffman length 7 Number of bits in the Huffman code HCODE7 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5EC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_59_HCODE118            \ Huffman code 118 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_59_HLEN118             \ Huffman length 118 Number of bits in the Huffman code HCODE118 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_59_HCODE119            \ Huffman code 119 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_59_HLEN119             \ Huffman length 119 Number of bits in the Huffman code HCODE119 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x5EC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_4_HCODE8               \ Huffman code 8 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_4_HLEN8                \ Huffman length 8 Number of bits in the Huffman code HCODE8 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_4_HCODE9               \ Huffman code 9 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_4_HLEN9                \ Huffman length 9 Number of bits in the Huffman code HCODE9 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5F0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_60_HCODE120            \ Huffman code 120 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_60_HLEN120             \ Huffman length 120 Number of bits in the Huffman code HCODE120 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_60_HCODE121            \ Huffman code 121 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_60_HLEN121             \ Huffman length 121 Number of bits in the Huffman code HCODE121 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x5F0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_5_HCODE10              \ Huffman code 10 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_5_HLEN10               \ Huffman length 10 Number of bits in the Huffman code HCODE10 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_5_HCODE11              \ Huffman code 11 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_5_HLEN11               \ Huffman length 11 Number of bits in the Huffman code HCODE11 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5F4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_61_HCODE122            \ Huffman code 122 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_61_HLEN122             \ Huffman length 122 Number of bits in the Huffman code HCODE122 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_61_HCODE123            \ Huffman code 123 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_61_HLEN123             \ Huffman length 123 Number of bits in the Huffman code HCODE123 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x5F4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_6_HCODE12              \ Huffman code 12 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_6_HLEN12               \ Huffman length 12 Number of bits in the Huffman code HCODE12 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_6_HCODE13              \ Huffman code 13 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_6_HLEN13               \ Huffman length 13 Number of bits in the Huffman code HCODE13 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5F8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_62_HCODE124            \ Huffman code 124 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_62_HLEN124             \ Huffman length 124 Number of bits in the Huffman code HCODE124 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_62_HCODE125            \ Huffman code 125 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_62_HLEN125             \ Huffman length 125 Number of bits in the Huffman code HCODE125 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x5F8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_7_HCODE14              \ Huffman code 14 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_7_HLEN14               \ Huffman length 14 Number of bits in the Huffman code HCODE14 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_7_HCODE15              \ Huffman code 15 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_7_HLEN15               \ Huffman length 15 Number of bits in the Huffman code HCODE15 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x5FC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_63_HCODE126            \ Huffman code 126 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_63_HLEN126             \ Huffman length 126 Number of bits in the Huffman code HCODE126 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_63_HCODE127            \ Huffman code 127 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_63_HLEN127             \ Huffman length 127 Number of bits in the Huffman code HCODE127 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x5FC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_8_HCODE16              \ Huffman code 16 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_8_HLEN16               \ Huffman length 16 Number of bits in the Huffman code HCODE16 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_8_HCODE17              \ Huffman code 17 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_8_HLEN17               \ Huffman length 17 Number of bits in the Huffman code HCODE17 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_64_HCODE128            \ Huffman code 128 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_64_HLEN128             \ Huffman length 128 Number of bits in the Huffman code HCODE128 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_64_HCODE129            \ Huffman code 129 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_64_HLEN129             \ Huffman length 129 Number of bits in the Huffman code HCODE129 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_9_HCODE18              \ Huffman code 18 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_9_HLEN18               \ Huffman length 18 Number of bits in the Huffman code HCODE18 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_9_HCODE19              \ Huffman code 19 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_9_HLEN19               \ Huffman length 19 Number of bits in the Huffman code HCODE19 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_65_HCODE130            \ Huffman code 130 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_65_HLEN130             \ Huffman length 130 Number of bits in the Huffman code HCODE130 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_65_HCODE131            \ Huffman code 131 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_65_HLEN131             \ Huffman length 131 Number of bits in the Huffman code HCODE131 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_10_HCODE20             \ Huffman code 20 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_10_HLEN20              \ Huffman length 20 Number of bits in the Huffman code HCODE20 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_10_HCODE21             \ Huffman code 21 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_10_HLEN21              \ Huffman length 21 Number of bits in the Huffman code HCODE21 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_66_HCODE132            \ Huffman code 132 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_66_HLEN132             \ Huffman length 132 Number of bits in the Huffman code HCODE132 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_66_HCODE133            \ Huffman code 133 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_66_HLEN133             \ Huffman length 133 Number of bits in the Huffman code HCODE133 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_11_HCODE22             \ Huffman code 22 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_11_HLEN22              \ Huffman length 22 Number of bits in the Huffman code HCODE22 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_11_HCODE23             \ Huffman code 23 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_11_HLEN23              \ Huffman length 23 Number of bits in the Huffman code HCODE23 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_67_HCODE134            \ Huffman code 134 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_67_HLEN134             \ Huffman length 134 Number of bits in the Huffman code HCODE134 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_67_HCODE135            \ Huffman code 135 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_67_HLEN135             \ Huffman length 135 Number of bits in the Huffman code HCODE135 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_12_HCODE24             \ Huffman code 24 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_12_HLEN24              \ Huffman length 24 Number of bits in the Huffman code HCODE24 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_12_HCODE25             \ Huffman code 25 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_12_HLEN25              \ Huffman length 25 Number of bits in the Huffman code HCODE25 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_68_HCODE136            \ Huffman code 136 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_68_HLEN136             \ Huffman length 136 Number of bits in the Huffman code HCODE136 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_68_HCODE137            \ Huffman code 137 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_68_HLEN137             \ Huffman length 137 Number of bits in the Huffman code HCODE137 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_13_HCODE26             \ Huffman code 26 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_13_HLEN26              \ Huffman length 26 Number of bits in the Huffman code HCODE26 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_13_HCODE27             \ Huffman code 27 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_13_HLEN27              \ Huffman length 27 Number of bits in the Huffman code HCODE27 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_69_HCODE138            \ Huffman code 138 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_69_HLEN138             \ Huffman length 138 Number of bits in the Huffman code HCODE138 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_69_HCODE139            \ Huffman code 139 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_69_HLEN139             \ Huffman length 139 Number of bits in the Huffman code HCODE139 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_14_HCODE28             \ Huffman code 28 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_14_HLEN28              \ Huffman length 28 Number of bits in the Huffman code HCODE28 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_14_HCODE29             \ Huffman code 29 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_14_HLEN29              \ Huffman length 29 Number of bits in the Huffman code HCODE29 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x618
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_70_HCODE140            \ Huffman code 140 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_70_HLEN140             \ Huffman length 140 Number of bits in the Huffman code HCODE140 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_70_HCODE141            \ Huffman code 141 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_70_HLEN141             \ Huffman length 141 Number of bits in the Huffman code HCODE141 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x618
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_15_HCODE30             \ Huffman code 30 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_15_HLEN30              \ Huffman length 30 Number of bits in the Huffman code HCODE30 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_15_HCODE31             \ Huffman code 31 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_15_HLEN31              \ Huffman length 31 Number of bits in the Huffman code HCODE31 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x61C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_71_HCODE142            \ Huffman code 142 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_71_HLEN142             \ Huffman length 142 Number of bits in the Huffman code HCODE142 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_71_HCODE143            \ Huffman code 143 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_71_HLEN143             \ Huffman length 143 Number of bits in the Huffman code HCODE143 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x61C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_16_HCODE32             \ Huffman code 32 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_16_HLEN32              \ Huffman length 32 Number of bits in the Huffman code HCODE32 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_16_HCODE33             \ Huffman code 33 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_16_HLEN33              \ Huffman length 33 Number of bits in the Huffman code HCODE33 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_72_HCODE144            \ Huffman code 144 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_72_HLEN144             \ Huffman length 144 Number of bits in the Huffman code HCODE144 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_72_HCODE145            \ Huffman code 145 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_72_HLEN145             \ Huffman length 145 Number of bits in the Huffman code HCODE145 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_17_HCODE34             \ Huffman code 34 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_17_HLEN34              \ Huffman length 34 Number of bits in the Huffman code HCODE34 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_17_HCODE35             \ Huffman code 35 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_17_HLEN35              \ Huffman length 35 Number of bits in the Huffman code HCODE35 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x624
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_73_HCODE146            \ Huffman code 146 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_73_HLEN146             \ Huffman length 146 Number of bits in the Huffman code HCODE146 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_73_HCODE147            \ Huffman code 147 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_73_HLEN147             \ Huffman length 147 Number of bits in the Huffman code HCODE147 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x624
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_18_HCODE36             \ Huffman code 36 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_18_HLEN36              \ Huffman length 36 Number of bits in the Huffman code HCODE36 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_18_HCODE37             \ Huffman code 37 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_18_HLEN37              \ Huffman length 37 Number of bits in the Huffman code HCODE37 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_74_HCODE148            \ Huffman code 148 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_74_HLEN148             \ Huffman length 148 Number of bits in the Huffman code HCODE148 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_74_HCODE149            \ Huffman code 149 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_74_HLEN149             \ Huffman length 149 Number of bits in the Huffman code HCODE149 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_19_HCODE38             \ Huffman code 38 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_19_HLEN38              \ Huffman length 38 Number of bits in the Huffman code HCODE38 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_19_HCODE39             \ Huffman code 39 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_19_HLEN39              \ Huffman length 39 Number of bits in the Huffman code HCODE39 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x62C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_75_HCODE150            \ Huffman code 150 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_75_HLEN150             \ Huffman length 150 Number of bits in the Huffman code HCODE150 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_75_HCODE151            \ Huffman code 151 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_75_HLEN151             \ Huffman length 151 Number of bits in the Huffman code HCODE151 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x62C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_20_HCODE40             \ Huffman code 40 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_20_HLEN40              \ Huffman length 40 Number of bits in the Huffman code HCODE40 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_20_HCODE41             \ Huffman code 41 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_20_HLEN41              \ Huffman length 41 Number of bits in the Huffman code HCODE41 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_76_HCODE152            \ Huffman code 152 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_76_HLEN152             \ Huffman length 152 Number of bits in the Huffman code HCODE152 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_76_HCODE153            \ Huffman code 153 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_76_HLEN153             \ Huffman length 153 Number of bits in the Huffman code HCODE153 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_21_HCODE42             \ Huffman code 42 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_21_HLEN42              \ Huffman length 42 Number of bits in the Huffman code HCODE42 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_21_HCODE43             \ Huffman code 43 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_21_HLEN43              \ Huffman length 43 Number of bits in the Huffman code HCODE43 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x634
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_77_HCODE154            \ Huffman code 154 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_77_HLEN154             \ Huffman length 154 Number of bits in the Huffman code HCODE154 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_77_HCODE155            \ Huffman code 155 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_77_HLEN155             \ Huffman length 155 Number of bits in the Huffman code HCODE155 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x634
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_22_HCODE44             \ Huffman code 44 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_22_HLEN44              \ Huffman length 44 Number of bits in the Huffman code HCODE44 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_22_HCODE45             \ Huffman code 45 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_22_HLEN45              \ Huffman length 45 Number of bits in the Huffman code HCODE45 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x638
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_78_HCODE156            \ Huffman code 156 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_78_HLEN156             \ Huffman length 156 Number of bits in the Huffman code HCODE156 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_78_HCODE157            \ Huffman code 157 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_78_HLEN157             \ Huffman length 157 Number of bits in the Huffman code HCODE157 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x638
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_23_HCODE46             \ Huffman code 46 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_23_HLEN46              \ Huffman length 46 Number of bits in the Huffman code HCODE46 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_23_HCODE47             \ Huffman code 47 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_23_HLEN47              \ Huffman length 47 Number of bits in the Huffman code HCODE47 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x63C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_79_HCODE158            \ Huffman code 158 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_79_HLEN158             \ Huffman length 158 Number of bits in the Huffman code HCODE158 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_79_HCODE159            \ Huffman code 159 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_79_HLEN159             \ Huffman length 159 Number of bits in the Huffman code HCODE159 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x63C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_24_HCODE48             \ Huffman code 48 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_24_HLEN48              \ Huffman length 48 Number of bits in the Huffman code HCODE48 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_24_HCODE49             \ Huffman code 49 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_24_HLEN49              \ Huffman length 49 Number of bits in the Huffman code HCODE49 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_80_HCODE160            \ Huffman code 160 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_80_HLEN160             \ Huffman length 160 Number of bits in the Huffman code HCODE160 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_80_HCODE161            \ Huffman code 161 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_80_HLEN161             \ Huffman length 161 Number of bits in the Huffman code HCODE161 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_25_HCODE50             \ Huffman code 50 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_25_HLEN50              \ Huffman length 50 Number of bits in the Huffman code HCODE50 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_25_HCODE51             \ Huffman code 51 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_25_HLEN51              \ Huffman length 51 Number of bits in the Huffman code HCODE51 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x644
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_81_HCODE162            \ Huffman code 162 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_81_HLEN162             \ Huffman length 162 Number of bits in the Huffman code HCODE162 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_81_HCODE163            \ Huffman code 163 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_81_HLEN163             \ Huffman length 163 Number of bits in the Huffman code HCODE163 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x644
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_26_HCODE52             \ Huffman code 52 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_26_HLEN52              \ Huffman length 52 Number of bits in the Huffman code HCODE52 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_26_HCODE53             \ Huffman code 53 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_26_HLEN53              \ Huffman length 53 Number of bits in the Huffman code HCODE53 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x648
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_82_HCODE164            \ Huffman code 164 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_82_HLEN164             \ Huffman length 164 Number of bits in the Huffman code HCODE164 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_82_HCODE165            \ Huffman code 165 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_82_HLEN165             \ Huffman length 165 Number of bits in the Huffman code HCODE165 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x648
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_27_HCODE54             \ Huffman code 54 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_27_HLEN54              \ Huffman length 54 Number of bits in the Huffman code HCODE54 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_27_HCODE55             \ Huffman code 55 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_27_HLEN55              \ Huffman length 55 Number of bits in the Huffman code HCODE55 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_83_HCODE166            \ Huffman code 166 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_83_HLEN166             \ Huffman length 166 Number of bits in the Huffman code HCODE166 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_83_HCODE167            \ Huffman code 167 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_83_HLEN167             \ Huffman length 167 Number of bits in the Huffman code HCODE167 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_28_HCODE56             \ Huffman code 56 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_28_HLEN56              \ Huffman length 56 Number of bits in the Huffman code HCODE56 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_28_HCODE57             \ Huffman code 57 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_28_HLEN57              \ Huffman length 57 Number of bits in the Huffman code HCODE57 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_84_HCODE168            \ Huffman code 168 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_84_HLEN168             \ Huffman length 168 Number of bits in the Huffman code HCODE168 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_84_HCODE169            \ Huffman code 169 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_84_HLEN169             \ Huffman length 169 Number of bits in the Huffman code HCODE169 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_29_HCODE58             \ Huffman code 58 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_29_HLEN58              \ Huffman length 58 Number of bits in the Huffman code HCODE58 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_29_HCODE59             \ Huffman code 59 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_29_HLEN59              \ Huffman length 59 Number of bits in the Huffman code HCODE59 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_85_HCODE170            \ Huffman code 170 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_85_HLEN170             \ Huffman length 170 Number of bits in the Huffman code HCODE170 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_85_HCODE171            \ Huffman code 171 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_85_HLEN171             \ Huffman length 171 Number of bits in the Huffman code HCODE171 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_30_HCODE60             \ Huffman code 60 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_30_HLEN60              \ Huffman length 60 Number of bits in the Huffman code HCODE60 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_30_HCODE61             \ Huffman code 61 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_30_HLEN61              \ Huffman length 61 Number of bits in the Huffman code HCODE61 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x658
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_86_HCODE172            \ Huffman code 172 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_86_HLEN172             \ Huffman length 172 Number of bits in the Huffman code HCODE172 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_86_HCODE173            \ Huffman code 173 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_86_HLEN173             \ Huffman length 173 Number of bits in the Huffman code HCODE173 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x658
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_31_HCODE62             \ Huffman code 62 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_31_HLEN62              \ Huffman length 62 Number of bits in the Huffman code HCODE62 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_31_HCODE63             \ Huffman code 63 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_31_HLEN63              \ Huffman length 63 Number of bits in the Huffman code HCODE63 minus 1.


\
\ @brief JPEG Huffman encoder AC0
\ Address offset: 0x65C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC0_87_HCODE174            \ Huffman code 174 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC0_87_HLEN174             \ Huffman length 174 Number of bits in the Huffman code HCODE174 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC0_87_HCODE175            \ Huffman code 175 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC0_87_HLEN175             \ Huffman length 175 Number of bits in the Huffman code HCODE175 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x65C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_32_HCODE64             \ Huffman code 64 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_32_HLEN64              \ Huffman length 64 Number of bits in the Huffman code HCODE64 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_32_HCODE65             \ Huffman code 65 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_32_HLEN65              \ Huffman length 65 Number of bits in the Huffman code HCODE65 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x660
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_33_HCODE66             \ Huffman code 66 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_33_HLEN66              \ Huffman length 66 Number of bits in the Huffman code HCODE66 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_33_HCODE67             \ Huffman code 67 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_33_HLEN67              \ Huffman length 67 Number of bits in the Huffman code HCODE67 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_34_HCODE68             \ Huffman code 68 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_34_HLEN68              \ Huffman length 68 Number of bits in the Huffman code HCODE68 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_34_HCODE69             \ Huffman code 69 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_34_HLEN69              \ Huffman length 69 Number of bits in the Huffman code HCODE69 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x668
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_35_HCODE70             \ Huffman code 70 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_35_HLEN70              \ Huffman length 70 Number of bits in the Huffman code HCODE70 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_35_HCODE71             \ Huffman code 71 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_35_HLEN71              \ Huffman length 71 Number of bits in the Huffman code HCODE71 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x66C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_36_HCODE72             \ Huffman code 72 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_36_HLEN72              \ Huffman length 72 Number of bits in the Huffman code HCODE72 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_36_HCODE73             \ Huffman code 73 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_36_HLEN73              \ Huffman length 73 Number of bits in the Huffman code HCODE73 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x670
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_37_HCODE74             \ Huffman code 74 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_37_HLEN74              \ Huffman length 74 Number of bits in the Huffman code HCODE74 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_37_HCODE75             \ Huffman code 75 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_37_HLEN75              \ Huffman length 75 Number of bits in the Huffman code HCODE75 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x674
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_38_HCODE76             \ Huffman code 76 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_38_HLEN76              \ Huffman length 76 Number of bits in the Huffman code HCODE76 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_38_HCODE77             \ Huffman code 77 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_38_HLEN77              \ Huffman length 77 Number of bits in the Huffman code HCODE77 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x678
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_39_HCODE78             \ Huffman code 78 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_39_HLEN78              \ Huffman length 78 Number of bits in the Huffman code HCODE78 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_39_HCODE79             \ Huffman code 79 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_39_HLEN79              \ Huffman length 79 Number of bits in the Huffman code HCODE79 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x67C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_40_HCODE80             \ Huffman code 80 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_40_HLEN80              \ Huffman length 80 Number of bits in the Huffman code HCODE80 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_40_HCODE81             \ Huffman code 81 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_40_HLEN81              \ Huffman length 81 Number of bits in the Huffman code HCODE81 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x680
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_41_HCODE82             \ Huffman code 82 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_41_HLEN82              \ Huffman length 82 Number of bits in the Huffman code HCODE82 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_41_HCODE83             \ Huffman code 83 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_41_HLEN83              \ Huffman length 83 Number of bits in the Huffman code HCODE83 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x684
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_42_HCODE84             \ Huffman code 84 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_42_HLEN84              \ Huffman length 84 Number of bits in the Huffman code HCODE84 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_42_HCODE85             \ Huffman code 85 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_42_HLEN85              \ Huffman length 85 Number of bits in the Huffman code HCODE85 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x688
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_43_HCODE86             \ Huffman code 86 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_43_HLEN86              \ Huffman length 86 Number of bits in the Huffman code HCODE86 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_43_HCODE87             \ Huffman code 87 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_43_HLEN87              \ Huffman length 87 Number of bits in the Huffman code HCODE87 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x68C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_44_HCODE88             \ Huffman code 88 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_44_HLEN88              \ Huffman length 88 Number of bits in the Huffman code HCODE88 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_44_HCODE89             \ Huffman code 89 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_44_HLEN89              \ Huffman length 89 Number of bits in the Huffman code HCODE89 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x690
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_45_HCODE90             \ Huffman code 90 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_45_HLEN90              \ Huffman length 90 Number of bits in the Huffman code HCODE90 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_45_HCODE91             \ Huffman code 91 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_45_HLEN91              \ Huffman length 91 Number of bits in the Huffman code HCODE91 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x694
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_46_HCODE92             \ Huffman code 92 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_46_HLEN92              \ Huffman length 92 Number of bits in the Huffman code HCODE92 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_46_HCODE93             \ Huffman code 93 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_46_HLEN93              \ Huffman length 93 Number of bits in the Huffman code HCODE93 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x698
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_47_HCODE94             \ Huffman code 94 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_47_HLEN94              \ Huffman length 94 Number of bits in the Huffman code HCODE94 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_47_HCODE95             \ Huffman code 95 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_47_HLEN95              \ Huffman length 95 Number of bits in the Huffman code HCODE95 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x69C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_48_HCODE96             \ Huffman code 96 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_48_HLEN96              \ Huffman length 96 Number of bits in the Huffman code HCODE96 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_48_HCODE97             \ Huffman code 97 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_48_HLEN97              \ Huffman length 97 Number of bits in the Huffman code HCODE97 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6A0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_49_HCODE98             \ Huffman code 98 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_49_HLEN98              \ Huffman length 98 Number of bits in the Huffman code HCODE98 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_49_HCODE99             \ Huffman code 99 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_49_HLEN99              \ Huffman length 99 Number of bits in the Huffman code HCODE99 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6A4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_50_HCODE100            \ Huffman code 100 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_50_HLEN100             \ Huffman length 100 Number of bits in the Huffman code HCODE100 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_50_HCODE101            \ Huffman code 101 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_50_HLEN101             \ Huffman length 101 Number of bits in the Huffman code HCODE101 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6A8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_51_HCODE102            \ Huffman code 102 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_51_HLEN102             \ Huffman length 102 Number of bits in the Huffman code HCODE102 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_51_HCODE103            \ Huffman code 103 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_51_HLEN103             \ Huffman length 103 Number of bits in the Huffman code HCODE103 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6AC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_52_HCODE104            \ Huffman code 104 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_52_HLEN104             \ Huffman length 104 Number of bits in the Huffman code HCODE104 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_52_HCODE105            \ Huffman code 105 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_52_HLEN105             \ Huffman length 105 Number of bits in the Huffman code HCODE105 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6B0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_53_HCODE106            \ Huffman code 106 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_53_HLEN106             \ Huffman length 106 Number of bits in the Huffman code HCODE106 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_53_HCODE107            \ Huffman code 107 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_53_HLEN107             \ Huffman length 107 Number of bits in the Huffman code HCODE107 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6B4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_54_HCODE108            \ Huffman code 108 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_54_HLEN108             \ Huffman length 108 Number of bits in the Huffman code HCODE108 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_54_HCODE109            \ Huffman code 109 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_54_HLEN109             \ Huffman length 109 Number of bits in the Huffman code HCODE109 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6B8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_55_HCODE110            \ Huffman code 110 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_55_HLEN110             \ Huffman length 110 Number of bits in the Huffman code HCODE110 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_55_HCODE111            \ Huffman code 111 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_55_HLEN111             \ Huffman length 111 Number of bits in the Huffman code HCODE111 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6BC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_56_HCODE112            \ Huffman code 112 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_56_HLEN112             \ Huffman length 112 Number of bits in the Huffman code HCODE112 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_56_HCODE113            \ Huffman code 113 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_56_HLEN113             \ Huffman length 113 Number of bits in the Huffman code HCODE113 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6C0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_57_HCODE114            \ Huffman code 114 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_57_HLEN114             \ Huffman length 114 Number of bits in the Huffman code HCODE114 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_57_HCODE115            \ Huffman code 115 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_57_HLEN115             \ Huffman length 115 Number of bits in the Huffman code HCODE115 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6C4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_58_HCODE116            \ Huffman code 116 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_58_HLEN116             \ Huffman length 116 Number of bits in the Huffman code HCODE116 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_58_HCODE117            \ Huffman code 117 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_58_HLEN117             \ Huffman length 117 Number of bits in the Huffman code HCODE117 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6C8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_59_HCODE118            \ Huffman code 118 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_59_HLEN118             \ Huffman length 118 Number of bits in the Huffman code HCODE118 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_59_HCODE119            \ Huffman code 119 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_59_HLEN119             \ Huffman length 119 Number of bits in the Huffman code HCODE119 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6CC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_60_HCODE120            \ Huffman code 120 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_60_HLEN120             \ Huffman length 120 Number of bits in the Huffman code HCODE120 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_60_HCODE121            \ Huffman code 121 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_60_HLEN121             \ Huffman length 121 Number of bits in the Huffman code HCODE121 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6D0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_61_HCODE122            \ Huffman code 122 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_61_HLEN122             \ Huffman length 122 Number of bits in the Huffman code HCODE122 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_61_HCODE123            \ Huffman code 123 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_61_HLEN123             \ Huffman length 123 Number of bits in the Huffman code HCODE123 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6D4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_62_HCODE124            \ Huffman code 124 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_62_HLEN124             \ Huffman length 124 Number of bits in the Huffman code HCODE124 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_62_HCODE125            \ Huffman code 125 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_62_HLEN125             \ Huffman length 125 Number of bits in the Huffman code HCODE125 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6D8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_63_HCODE126            \ Huffman code 126 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_63_HLEN126             \ Huffman length 126 Number of bits in the Huffman code HCODE126 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_63_HCODE127            \ Huffman code 127 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_63_HLEN127             \ Huffman length 127 Number of bits in the Huffman code HCODE127 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6DC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_64_HCODE128            \ Huffman code 128 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_64_HLEN128             \ Huffman length 128 Number of bits in the Huffman code HCODE128 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_64_HCODE129            \ Huffman code 129 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_64_HLEN129             \ Huffman length 129 Number of bits in the Huffman code HCODE129 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6E0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_65_HCODE130            \ Huffman code 130 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_65_HLEN130             \ Huffman length 130 Number of bits in the Huffman code HCODE130 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_65_HCODE131            \ Huffman code 131 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_65_HLEN131             \ Huffman length 131 Number of bits in the Huffman code HCODE131 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6E4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_66_HCODE132            \ Huffman code 132 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_66_HLEN132             \ Huffman length 132 Number of bits in the Huffman code HCODE132 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_66_HCODE133            \ Huffman code 133 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_66_HLEN133             \ Huffman length 133 Number of bits in the Huffman code HCODE133 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6E8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_67_HCODE134            \ Huffman code 134 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_67_HLEN134             \ Huffman length 134 Number of bits in the Huffman code HCODE134 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_67_HCODE135            \ Huffman code 135 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_67_HLEN135             \ Huffman length 135 Number of bits in the Huffman code HCODE135 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6EC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_68_HCODE136            \ Huffman code 136 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_68_HLEN136             \ Huffman length 136 Number of bits in the Huffman code HCODE136 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_68_HCODE137            \ Huffman code 137 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_68_HLEN137             \ Huffman length 137 Number of bits in the Huffman code HCODE137 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6F0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_69_HCODE138            \ Huffman code 138 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_69_HLEN138             \ Huffman length 138 Number of bits in the Huffman code HCODE138 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_69_HCODE139            \ Huffman code 139 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_69_HLEN139             \ Huffman length 139 Number of bits in the Huffman code HCODE139 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6F4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_70_HCODE140            \ Huffman code 140 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_70_HLEN140             \ Huffman length 140 Number of bits in the Huffman code HCODE140 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_70_HCODE141            \ Huffman code 141 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_70_HLEN141             \ Huffman length 141 Number of bits in the Huffman code HCODE141 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6F8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_71_HCODE142            \ Huffman code 142 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_71_HLEN142             \ Huffman length 142 Number of bits in the Huffman code HCODE142 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_71_HCODE143            \ Huffman code 143 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_71_HLEN143             \ Huffman length 143 Number of bits in the Huffman code HCODE143 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x6FC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_72_HCODE144            \ Huffman code 144 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_72_HLEN144             \ Huffman length 144 Number of bits in the Huffman code HCODE144 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_72_HCODE145            \ Huffman code 145 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_72_HLEN145             \ Huffman length 145 Number of bits in the Huffman code HCODE145 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x700
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_73_HCODE146            \ Huffman code 146 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_73_HLEN146             \ Huffman length 146 Number of bits in the Huffman code HCODE146 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_73_HCODE147            \ Huffman code 147 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_73_HLEN147             \ Huffman length 147 Number of bits in the Huffman code HCODE147 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x704
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_74_HCODE148            \ Huffman code 148 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_74_HLEN148             \ Huffman length 148 Number of bits in the Huffman code HCODE148 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_74_HCODE149            \ Huffman code 149 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_74_HLEN149             \ Huffman length 149 Number of bits in the Huffman code HCODE149 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x708
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_75_HCODE150            \ Huffman code 150 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_75_HLEN150             \ Huffman length 150 Number of bits in the Huffman code HCODE150 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_75_HCODE151            \ Huffman code 151 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_75_HLEN151             \ Huffman length 151 Number of bits in the Huffman code HCODE151 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x70C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_76_HCODE152            \ Huffman code 152 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_76_HLEN152             \ Huffman length 152 Number of bits in the Huffman code HCODE152 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_76_HCODE153            \ Huffman code 153 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_76_HLEN153             \ Huffman length 153 Number of bits in the Huffman code HCODE153 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x710
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_77_HCODE154            \ Huffman code 154 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_77_HLEN154             \ Huffman length 154 Number of bits in the Huffman code HCODE154 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_77_HCODE155            \ Huffman code 155 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_77_HLEN155             \ Huffman length 155 Number of bits in the Huffman code HCODE155 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x714
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_78_HCODE156            \ Huffman code 156 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_78_HLEN156             \ Huffman length 156 Number of bits in the Huffman code HCODE156 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_78_HCODE157            \ Huffman code 157 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_78_HLEN157             \ Huffman length 157 Number of bits in the Huffman code HCODE157 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x718
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_79_HCODE158            \ Huffman code 158 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_79_HLEN158             \ Huffman length 158 Number of bits in the Huffman code HCODE158 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_79_HCODE159            \ Huffman code 159 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_79_HLEN159             \ Huffman length 159 Number of bits in the Huffman code HCODE159 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x71C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_80_HCODE160            \ Huffman code 160 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_80_HLEN160             \ Huffman length 160 Number of bits in the Huffman code HCODE160 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_80_HCODE161            \ Huffman code 161 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_80_HLEN161             \ Huffman length 161 Number of bits in the Huffman code HCODE161 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x720
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_81_HCODE162            \ Huffman code 162 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_81_HLEN162             \ Huffman length 162 Number of bits in the Huffman code HCODE162 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_81_HCODE163            \ Huffman code 163 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_81_HLEN163             \ Huffman length 163 Number of bits in the Huffman code HCODE163 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x724
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_82_HCODE164            \ Huffman code 164 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_82_HLEN164             \ Huffman length 164 Number of bits in the Huffman code HCODE164 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_82_HCODE165            \ Huffman code 165 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_82_HLEN165             \ Huffman length 165 Number of bits in the Huffman code HCODE165 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x728
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_83_HCODE166            \ Huffman code 166 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_83_HLEN166             \ Huffman length 166 Number of bits in the Huffman code HCODE166 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_83_HCODE167            \ Huffman code 167 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_83_HLEN167             \ Huffman length 167 Number of bits in the Huffman code HCODE167 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x72C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_84_HCODE168            \ Huffman code 168 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_84_HLEN168             \ Huffman length 168 Number of bits in the Huffman code HCODE168 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_84_HCODE169            \ Huffman code 169 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_84_HLEN169             \ Huffman length 169 Number of bits in the Huffman code HCODE169 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x730
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_85_HCODE170            \ Huffman code 170 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_85_HLEN170             \ Huffman length 170 Number of bits in the Huffman code HCODE170 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_85_HCODE171            \ Huffman code 171 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_85_HLEN171             \ Huffman length 171 Number of bits in the Huffman code HCODE171 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x734
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_86_HCODE172            \ Huffman code 172 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_86_HLEN172             \ Huffman length 172 Number of bits in the Huffman code HCODE172 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_86_HCODE173            \ Huffman code 173 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_86_HLEN173             \ Huffman length 173 Number of bits in the Huffman code HCODE173 minus 1.


\
\ @brief JPEG Huffman encoder AC1
\ Address offset: 0x738
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_AC1_87_HCODE174            \ Huffman code 174 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_AC1_87_HLEN174             \ Huffman length 174 Number of bits in the Huffman code HCODE174 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_AC1_87_HCODE175            \ Huffman code 175 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_AC1_87_HLEN175             \ Huffman length 175 Number of bits in the Huffman code HCODE175 minus 1.


\
\ @brief JPEG Huffman encoder DC0
\ Address offset: 0x7C0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC0_0_HCODE0               \ Huffman code 0 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC0_0_HLEN0                \ Huffman length 0 Number of bits in the Huffman code HCODE0 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC0_0_HCODE1               \ Huffman code 1 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC0_0_HLEN1                \ Huffman length 1 Number of bits in the Huffman code HCODE1 minus 1.


\
\ @brief JPEG Huffman encoder DC0
\ Address offset: 0x7C4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC0_1_HCODE2               \ Huffman code 2 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC0_1_HLEN2                \ Huffman length 2 Number of bits in the Huffman code HCODE2 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC0_1_HCODE3               \ Huffman code 3 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC0_1_HLEN3                \ Huffman length 3 Number of bits in the Huffman code HCODE3 minus 1.


\
\ @brief JPEG Huffman encoder DC0
\ Address offset: 0x7C8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC0_2_HCODE4               \ Huffman code 4 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC0_2_HLEN4                \ Huffman length 4 Number of bits in the Huffman code HCODE4 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC0_2_HCODE5               \ Huffman code 5 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC0_2_HLEN5                \ Huffman length 5 Number of bits in the Huffman code HCODE5 minus 1.


\
\ @brief JPEG Huffman encoder DC0
\ Address offset: 0x7CC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC0_3_HCODE6               \ Huffman code 6 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC0_3_HLEN6                \ Huffman length 6 Number of bits in the Huffman code HCODE6 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC0_3_HCODE7               \ Huffman code 7 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC0_3_HLEN7                \ Huffman length 7 Number of bits in the Huffman code HCODE7 minus 1.


\
\ @brief JPEG Huffman encoder DC0
\ Address offset: 0x7D0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC0_4_HCODE8               \ Huffman code 8 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC0_4_HLEN8                \ Huffman length 8 Number of bits in the Huffman code HCODE8 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC0_4_HCODE9               \ Huffman code 9 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC0_4_HLEN9                \ Huffman length 9 Number of bits in the Huffman code HCODE9 minus 1.


\
\ @brief JPEG Huffman encoder DC0
\ Address offset: 0x7D4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC0_5_HCODE10              \ Huffman code 10 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC0_5_HLEN10               \ Huffman length 10 Number of bits in the Huffman code HCODE10 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC0_5_HCODE11              \ Huffman code 11 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC0_5_HLEN11               \ Huffman length 11 Number of bits in the Huffman code HCODE11 minus 1.


\
\ @brief JPEG Huffman encoder DC0
\ Address offset: 0x7D8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC0_6_HCODE12              \ Huffman code 12 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC0_6_HLEN12               \ Huffman length 12 Number of bits in the Huffman code HCODE12 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC0_6_HCODE13              \ Huffman code 13 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC0_6_HLEN13               \ Huffman length 13 Number of bits in the Huffman code HCODE13 minus 1.


\
\ @brief JPEG Huffman encoder DC0
\ Address offset: 0x7DC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC0_7_HCODE14              \ Huffman code 14 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC0_7_HLEN14               \ Huffman length 14 Number of bits in the Huffman code HCODE14 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC0_7_HCODE15              \ Huffman code 15 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC0_7_HLEN15               \ Huffman length 15 Number of bits in the Huffman code HCODE15 minus 1.


\
\ @brief JPEG Huffman encoder DC1
\ Address offset: 0x89C
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC1_0_HCODE0               \ Huffman code 0 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC1_0_HLEN0                \ Huffman length 0 Number of bits in the Huffman code HCODE0 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC1_0_HCODE1               \ Huffman code 1 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC1_0_HLEN1                \ Huffman length 1 Number of bits in the Huffman code HCODE1 minus 1.


\
\ @brief JPEG Huffman encoder DC1
\ Address offset: 0x8A0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC1_1_HCODE2               \ Huffman code 2 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC1_1_HLEN2                \ Huffman length 2 Number of bits in the Huffman code HCODE2 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC1_1_HCODE3               \ Huffman code 3 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC1_1_HLEN3                \ Huffman length 3 Number of bits in the Huffman code HCODE3 minus 1.


\
\ @brief JPEG Huffman encoder DC1
\ Address offset: 0x8A4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC1_2_HCODE4               \ Huffman code 4 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC1_2_HLEN4                \ Huffman length 4 Number of bits in the Huffman code HCODE4 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC1_2_HCODE5               \ Huffman code 5 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC1_2_HLEN5                \ Huffman length 5 Number of bits in the Huffman code HCODE5 minus 1.


\
\ @brief JPEG Huffman encoder DC1
\ Address offset: 0x8A8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC1_3_HCODE6               \ Huffman code 6 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC1_3_HLEN6                \ Huffman length 6 Number of bits in the Huffman code HCODE6 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC1_3_HCODE7               \ Huffman code 7 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC1_3_HLEN7                \ Huffman length 7 Number of bits in the Huffman code HCODE7 minus 1.


\
\ @brief JPEG Huffman encoder DC1
\ Address offset: 0x8AC
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC1_4_HCODE8               \ Huffman code 8 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC1_4_HLEN8                \ Huffman length 8 Number of bits in the Huffman code HCODE8 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC1_4_HCODE9               \ Huffman code 9 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC1_4_HLEN9                \ Huffman length 9 Number of bits in the Huffman code HCODE9 minus 1.


\
\ @brief JPEG Huffman encoder DC1
\ Address offset: 0x8B0
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC1_5_HCODE10              \ Huffman code 10 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC1_5_HLEN10               \ Huffman length 10 Number of bits in the Huffman code HCODE10 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC1_5_HCODE11              \ Huffman code 11 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC1_5_HLEN11               \ Huffman length 11 Number of bits in the Huffman code HCODE11 minus 1.


\
\ @brief JPEG Huffman encoder DC1
\ Address offset: 0x8B4
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC1_6_HCODE12              \ Huffman code 12 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC1_6_HLEN12               \ Huffman length 12 Number of bits in the Huffman code HCODE12 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC1_6_HCODE13              \ Huffman code 13 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC1_6_HLEN13               \ Huffman length 13 Number of bits in the Huffman code HCODE13 minus 1.


\
\ @brief JPEG Huffman encoder DC1
\ Address offset: 0x8B8
\ Reset value: 0x00000000
\

$000000ff constant SEC_JPEG_JPEG_HUFFENC_DC1_7_HCODE14              \ Huffman code 14 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$00000f00 constant SEC_JPEG_JPEG_HUFFENC_DC1_7_HLEN14               \ Huffman length 14 Number of bits in the Huffman code HCODE14 minus 1.
$00ff0000 constant SEC_JPEG_JPEG_HUFFENC_DC1_7_HCODE15              \ Huffman code 15 8 least significant bits of the Huffman code. If the Huffman code is less than 8 bits long, the unused bits must be 0.
$0f000000 constant SEC_JPEG_JPEG_HUFFENC_DC1_7_HLEN15               \ Huffman length 15 Number of bits in the Huffman code HCODE15 minus 1.


\
\ @brief JPEG address block description
\
$5002a000 constant SEC_JPEG_JPEG_CONFR0  \ offset: 0x00 : JPEG codec control register
$5002a004 constant SEC_JPEG_JPEG_CONFR1  \ offset: 0x04 : JPEG codec configuration register 1
$5002a008 constant SEC_JPEG_JPEG_CONFR2  \ offset: 0x08 : JPEG codec configuration register 2
$5002a00c constant SEC_JPEG_JPEG_CONFR3  \ offset: 0x0C : JPEG codec configuration register 3
$5002a010 constant SEC_JPEG_JPEG_CONFR4  \ offset: 0x10 : JPEG codec configuration register 4
$5002a014 constant SEC_JPEG_JPEG_CONFR5  \ offset: 0x14 : JPEG codec configuration register 5
$5002a018 constant SEC_JPEG_JPEG_CONFR6  \ offset: 0x18 : JPEG codec configuration register 6
$5002a01c constant SEC_JPEG_JPEG_CONFR7  \ offset: 0x1C : JPEG codec configuration register 7
$5002a030 constant SEC_JPEG_JPEG_CR  \ offset: 0x30 : JPEG control register
$5002a034 constant SEC_JPEG_JPEG_SR  \ offset: 0x34 : JPEG status register
$5002a038 constant SEC_JPEG_JPEG_CFR  \ offset: 0x38 : JPEG clear flag register
$5002a040 constant SEC_JPEG_JPEG_DIR  \ offset: 0x40 : JPEG data input register
$5002a044 constant SEC_JPEG_JPEG_DOR  \ offset: 0x44 : JPEG data output register
$5002a050 constant SEC_JPEG_JPEG_QMEM0_0  \ offset: 0x50 : JPEG quantization memory 0
$5002a054 constant SEC_JPEG_JPEG_QMEM0_1  \ offset: 0x54 : JPEG quantization memory 0
$5002a058 constant SEC_JPEG_JPEG_QMEM0_2  \ offset: 0x58 : JPEG quantization memory 0
$5002a05c constant SEC_JPEG_JPEG_QMEM0_3  \ offset: 0x5C : JPEG quantization memory 0
$5002a060 constant SEC_JPEG_JPEG_QMEM0_4  \ offset: 0x60 : JPEG quantization memory 0
$5002a064 constant SEC_JPEG_JPEG_QMEM0_5  \ offset: 0x64 : JPEG quantization memory 0
$5002a068 constant SEC_JPEG_JPEG_QMEM0_6  \ offset: 0x68 : JPEG quantization memory 0
$5002a06c constant SEC_JPEG_JPEG_QMEM0_7  \ offset: 0x6C : JPEG quantization memory 0
$5002a070 constant SEC_JPEG_JPEG_QMEM0_8  \ offset: 0x70 : JPEG quantization memory 0
$5002a074 constant SEC_JPEG_JPEG_QMEM0_9  \ offset: 0x74 : JPEG quantization memory 0
$5002a078 constant SEC_JPEG_JPEG_QMEM0_10  \ offset: 0x78 : JPEG quantization memory 0
$5002a07c constant SEC_JPEG_JPEG_QMEM0_11  \ offset: 0x7C : JPEG quantization memory 0
$5002a080 constant SEC_JPEG_JPEG_QMEM0_12  \ offset: 0x80 : JPEG quantization memory 0
$5002a084 constant SEC_JPEG_JPEG_QMEM0_13  \ offset: 0x84 : JPEG quantization memory 0
$5002a088 constant SEC_JPEG_JPEG_QMEM0_14  \ offset: 0x88 : JPEG quantization memory 0
$5002a08c constant SEC_JPEG_JPEG_QMEM0_15  \ offset: 0x8C : JPEG quantization memory 0
$5002a090 constant SEC_JPEG_JPEG_QMEM1_0  \ offset: 0x90 : JPEG quantization memory 1
$5002a094 constant SEC_JPEG_JPEG_QMEM1_1  \ offset: 0x94 : JPEG quantization memory 1
$5002a098 constant SEC_JPEG_JPEG_QMEM1_2  \ offset: 0x98 : JPEG quantization memory 1
$5002a09c constant SEC_JPEG_JPEG_QMEM1_3  \ offset: 0x9C : JPEG quantization memory 1
$5002a0a0 constant SEC_JPEG_JPEG_QMEM1_4  \ offset: 0xA0 : JPEG quantization memory 1
$5002a0a4 constant SEC_JPEG_JPEG_QMEM1_5  \ offset: 0xA4 : JPEG quantization memory 1
$5002a0a8 constant SEC_JPEG_JPEG_QMEM1_6  \ offset: 0xA8 : JPEG quantization memory 1
$5002a0ac constant SEC_JPEG_JPEG_QMEM1_7  \ offset: 0xAC : JPEG quantization memory 1
$5002a0b0 constant SEC_JPEG_JPEG_QMEM1_8  \ offset: 0xB0 : JPEG quantization memory 1
$5002a0b4 constant SEC_JPEG_JPEG_QMEM1_9  \ offset: 0xB4 : JPEG quantization memory 1
$5002a0b8 constant SEC_JPEG_JPEG_QMEM1_10  \ offset: 0xB8 : JPEG quantization memory 1
$5002a0bc constant SEC_JPEG_JPEG_QMEM1_11  \ offset: 0xBC : JPEG quantization memory 1
$5002a0c0 constant SEC_JPEG_JPEG_QMEM1_12  \ offset: 0xC0 : JPEG quantization memory 1
$5002a0c4 constant SEC_JPEG_JPEG_QMEM1_13  \ offset: 0xC4 : JPEG quantization memory 1
$5002a0c8 constant SEC_JPEG_JPEG_QMEM1_14  \ offset: 0xC8 : JPEG quantization memory 1
$5002a0cc constant SEC_JPEG_JPEG_QMEM1_15  \ offset: 0xCC : JPEG quantization memory 1
$5002a0d0 constant SEC_JPEG_JPEG_QMEM2_0  \ offset: 0xD0 : JPEG quantization memory 2
$5002a0d4 constant SEC_JPEG_JPEG_QMEM2_1  \ offset: 0xD4 : JPEG quantization memory 2
$5002a0d8 constant SEC_JPEG_JPEG_QMEM2_2  \ offset: 0xD8 : JPEG quantization memory 2
$5002a0dc constant SEC_JPEG_JPEG_QMEM2_3  \ offset: 0xDC : JPEG quantization memory 2
$5002a0e0 constant SEC_JPEG_JPEG_QMEM2_4  \ offset: 0xE0 : JPEG quantization memory 2
$5002a0e4 constant SEC_JPEG_JPEG_QMEM2_5  \ offset: 0xE4 : JPEG quantization memory 2
$5002a0e8 constant SEC_JPEG_JPEG_QMEM2_6  \ offset: 0xE8 : JPEG quantization memory 2
$5002a0ec constant SEC_JPEG_JPEG_QMEM2_7  \ offset: 0xEC : JPEG quantization memory 2
$5002a0f0 constant SEC_JPEG_JPEG_QMEM2_8  \ offset: 0xF0 : JPEG quantization memory 2
$5002a0f4 constant SEC_JPEG_JPEG_QMEM2_9  \ offset: 0xF4 : JPEG quantization memory 2
$5002a0f8 constant SEC_JPEG_JPEG_QMEM2_10  \ offset: 0xF8 : JPEG quantization memory 2
$5002a0fc constant SEC_JPEG_JPEG_QMEM2_11  \ offset: 0xFC : JPEG quantization memory 2
$5002a100 constant SEC_JPEG_JPEG_QMEM2_12  \ offset: 0x100 : JPEG quantization memory 2
$5002a104 constant SEC_JPEG_JPEG_QMEM2_13  \ offset: 0x104 : JPEG quantization memory 2
$5002a108 constant SEC_JPEG_JPEG_QMEM2_14  \ offset: 0x108 : JPEG quantization memory 2
$5002a10c constant SEC_JPEG_JPEG_QMEM2_15  \ offset: 0x10C : JPEG quantization memory 2
$5002a110 constant SEC_JPEG_JPEG_QMEM3_0  \ offset: 0x110 : JPEG quantization memory 3
$5002a114 constant SEC_JPEG_JPEG_QMEM3_1  \ offset: 0x114 : JPEG quantization memory 3
$5002a118 constant SEC_JPEG_JPEG_QMEM3_2  \ offset: 0x118 : JPEG quantization memory 3
$5002a11c constant SEC_JPEG_JPEG_QMEM3_3  \ offset: 0x11C : JPEG quantization memory 3
$5002a120 constant SEC_JPEG_JPEG_QMEM3_4  \ offset: 0x120 : JPEG quantization memory 3
$5002a124 constant SEC_JPEG_JPEG_QMEM3_5  \ offset: 0x124 : JPEG quantization memory 3
$5002a128 constant SEC_JPEG_JPEG_QMEM3_6  \ offset: 0x128 : JPEG quantization memory 3
$5002a12c constant SEC_JPEG_JPEG_QMEM3_7  \ offset: 0x12C : JPEG quantization memory 3
$5002a130 constant SEC_JPEG_JPEG_QMEM3_8  \ offset: 0x130 : JPEG quantization memory 3
$5002a134 constant SEC_JPEG_JPEG_QMEM3_9  \ offset: 0x134 : JPEG quantization memory 3
$5002a138 constant SEC_JPEG_JPEG_QMEM3_10  \ offset: 0x138 : JPEG quantization memory 3
$5002a13c constant SEC_JPEG_JPEG_QMEM3_11  \ offset: 0x13C : JPEG quantization memory 3
$5002a140 constant SEC_JPEG_JPEG_QMEM3_12  \ offset: 0x140 : JPEG quantization memory 3
$5002a144 constant SEC_JPEG_JPEG_QMEM3_13  \ offset: 0x144 : JPEG quantization memory 3
$5002a148 constant SEC_JPEG_JPEG_QMEM3_14  \ offset: 0x148 : JPEG quantization memory 3
$5002a14c constant SEC_JPEG_JPEG_QMEM3_15  \ offset: 0x14C : JPEG quantization memory 3
$5002a150 constant SEC_JPEG_JPEG_HUFFMIN0_0  \ offset: 0x150 : JPEG Huffman min
$5002a154 constant SEC_JPEG_JPEG_HUFFMIN0_1  \ offset: 0x154 : JPEG Huffman min
$5002a158 constant SEC_JPEG_JPEG_HUFFMIN0_2  \ offset: 0x158 : JPEG Huffman min
$5002a15c constant SEC_JPEG_JPEG_HUFFMIN0_3  \ offset: 0x15C : JPEG Huffman min 0 [alternate]
$5002a160 constant SEC_JPEG_JPEG_HUFFMIN1_0  \ offset: 0x160 : JPEG Huffman min
$5002a164 constant SEC_JPEG_JPEG_HUFFMIN1_1  \ offset: 0x164 : JPEG Huffman min
$5002a168 constant SEC_JPEG_JPEG_HUFFMIN1_2  \ offset: 0x168 : JPEG Huffman min
$5002a16c constant SEC_JPEG_JPEG_HUFFMIN1_3  \ offset: 0x16C : JPEG Huffman min 1 [alternate]
$5002a170 constant SEC_JPEG_JPEG_HUFFMIN2_0  \ offset: 0x170 : JPEG Huffman min
$5002a174 constant SEC_JPEG_JPEG_HUFFMIN2_1  \ offset: 0x174 : JPEG Huffman min
$5002a178 constant SEC_JPEG_JPEG_HUFFMIN2_2  \ offset: 0x178 : JPEG Huffman min
$5002a17c constant SEC_JPEG_JPEG_HUFFMIN2_3  \ offset: 0x17C : JPEG Huffman min 2 [alternate]
$5002a180 constant SEC_JPEG_JPEG_HUFFMIN3_0  \ offset: 0x180 : JPEG Huffman min
$5002a184 constant SEC_JPEG_JPEG_HUFFMIN3_1  \ offset: 0x184 : JPEG Huffman min
$5002a188 constant SEC_JPEG_JPEG_HUFFMIN3_2  \ offset: 0x188 : JPEG Huffman min
$5002a18c constant SEC_JPEG_JPEG_HUFFMIN3_3  \ offset: 0x18C : JPEG Huffman min 3 [alternate]
$5002a190 constant SEC_JPEG_JPEG_HUFFBASE0  \ offset: 0x190 : JPEG Huffman base
$5002a194 constant SEC_JPEG_JPEG_HUFFBASE1  \ offset: 0x194 : JPEG Huffman base
$5002a198 constant SEC_JPEG_JPEG_HUFFBASE2  \ offset: 0x198 : JPEG Huffman base
$5002a19c constant SEC_JPEG_JPEG_HUFFBASE3  \ offset: 0x19C : JPEG Huffman base
$5002a1a0 constant SEC_JPEG_JPEG_HUFFBASE4  \ offset: 0x1A0 : JPEG Huffman base
$5002a1a4 constant SEC_JPEG_JPEG_HUFFBASE5  \ offset: 0x1A4 : JPEG Huffman base
$5002a1a8 constant SEC_JPEG_JPEG_HUFFBASE6  \ offset: 0x1A8 : JPEG Huffman base
$5002a1ac constant SEC_JPEG_JPEG_HUFFBASE7  \ offset: 0x1AC : JPEG Huffman base
$5002a1b0 constant SEC_JPEG_JPEG_HUFFBASE8  \ offset: 0x1B0 : JPEG Huffman base
$5002a1b4 constant SEC_JPEG_JPEG_HUFFBASE9  \ offset: 0x1B4 : JPEG Huffman base
$5002a1b8 constant SEC_JPEG_JPEG_HUFFBASE10  \ offset: 0x1B8 : JPEG Huffman base
$5002a1bc constant SEC_JPEG_JPEG_HUFFBASE11  \ offset: 0x1BC : JPEG Huffman base
$5002a1c0 constant SEC_JPEG_JPEG_HUFFBASE12  \ offset: 0x1C0 : JPEG Huffman base
$5002a1c4 constant SEC_JPEG_JPEG_HUFFBASE13  \ offset: 0x1C4 : JPEG Huffman base
$5002a1c8 constant SEC_JPEG_JPEG_HUFFBASE14  \ offset: 0x1C8 : JPEG Huffman base
$5002a1cc constant SEC_JPEG_JPEG_HUFFBASE15  \ offset: 0x1CC : JPEG Huffman base
$5002a1d0 constant SEC_JPEG_JPEG_HUFFBASE16  \ offset: 0x1D0 : JPEG Huffman base
$5002a1d4 constant SEC_JPEG_JPEG_HUFFBASE17  \ offset: 0x1D4 : JPEG Huffman base
$5002a1d8 constant SEC_JPEG_JPEG_HUFFBASE18  \ offset: 0x1D8 : JPEG Huffman base
$5002a1dc constant SEC_JPEG_JPEG_HUFFBASE19  \ offset: 0x1DC : JPEG Huffman base
$5002a1e0 constant SEC_JPEG_JPEG_HUFFBASE20  \ offset: 0x1E0 : JPEG Huffman base
$5002a1e4 constant SEC_JPEG_JPEG_HUFFBASE21  \ offset: 0x1E4 : JPEG Huffman base
$5002a1e8 constant SEC_JPEG_JPEG_HUFFBASE22  \ offset: 0x1E8 : JPEG Huffman base
$5002a1ec constant SEC_JPEG_JPEG_HUFFBASE23  \ offset: 0x1EC : JPEG Huffman base
$5002a1f0 constant SEC_JPEG_JPEG_HUFFBASE24  \ offset: 0x1F0 : JPEG Huffman base
$5002a1f4 constant SEC_JPEG_JPEG_HUFFBASE25  \ offset: 0x1F4 : JPEG Huffman base
$5002a1f8 constant SEC_JPEG_JPEG_HUFFBASE26  \ offset: 0x1F8 : JPEG Huffman base
$5002a1fc constant SEC_JPEG_JPEG_HUFFBASE27  \ offset: 0x1FC : JPEG Huffman base
$5002a200 constant SEC_JPEG_JPEG_HUFFBASE28  \ offset: 0x200 : JPEG Huffman base
$5002a204 constant SEC_JPEG_JPEG_HUFFBASE29  \ offset: 0x204 : JPEG Huffman base
$5002a208 constant SEC_JPEG_JPEG_HUFFBASE30  \ offset: 0x208 : JPEG Huffman base
$5002a20c constant SEC_JPEG_JPEG_HUFFBASE31  \ offset: 0x20C : JPEG Huffman base
$5002a210 constant SEC_JPEG_JPEG_HUFFSYMB0  \ offset: 0x210 : JPEG Huffman symbol
$5002a214 constant SEC_JPEG_JPEG_HUFFSYMB1  \ offset: 0x214 : JPEG Huffman symbol
$5002a218 constant SEC_JPEG_JPEG_HUFFSYMB2  \ offset: 0x218 : JPEG Huffman symbol
$5002a21c constant SEC_JPEG_JPEG_HUFFSYMB3  \ offset: 0x21C : JPEG Huffman symbol
$5002a220 constant SEC_JPEG_JPEG_HUFFSYMB4  \ offset: 0x220 : JPEG Huffman symbol
$5002a224 constant SEC_JPEG_JPEG_HUFFSYMB5  \ offset: 0x224 : JPEG Huffman symbol
$5002a228 constant SEC_JPEG_JPEG_HUFFSYMB6  \ offset: 0x228 : JPEG Huffman symbol
$5002a22c constant SEC_JPEG_JPEG_HUFFSYMB7  \ offset: 0x22C : JPEG Huffman symbol
$5002a230 constant SEC_JPEG_JPEG_HUFFSYMB8  \ offset: 0x230 : JPEG Huffman symbol
$5002a234 constant SEC_JPEG_JPEG_HUFFSYMB9  \ offset: 0x234 : JPEG Huffman symbol
$5002a238 constant SEC_JPEG_JPEG_HUFFSYMB10  \ offset: 0x238 : JPEG Huffman symbol
$5002a23c constant SEC_JPEG_JPEG_HUFFSYMB11  \ offset: 0x23C : JPEG Huffman symbol
$5002a240 constant SEC_JPEG_JPEG_HUFFSYMB12  \ offset: 0x240 : JPEG Huffman symbol
$5002a244 constant SEC_JPEG_JPEG_HUFFSYMB13  \ offset: 0x244 : JPEG Huffman symbol
$5002a248 constant SEC_JPEG_JPEG_HUFFSYMB14  \ offset: 0x248 : JPEG Huffman symbol
$5002a24c constant SEC_JPEG_JPEG_HUFFSYMB15  \ offset: 0x24C : JPEG Huffman symbol
$5002a250 constant SEC_JPEG_JPEG_HUFFSYMB16  \ offset: 0x250 : JPEG Huffman symbol
$5002a254 constant SEC_JPEG_JPEG_HUFFSYMB17  \ offset: 0x254 : JPEG Huffman symbol
$5002a258 constant SEC_JPEG_JPEG_HUFFSYMB18  \ offset: 0x258 : JPEG Huffman symbol
$5002a25c constant SEC_JPEG_JPEG_HUFFSYMB19  \ offset: 0x25C : JPEG Huffman symbol
$5002a260 constant SEC_JPEG_JPEG_HUFFSYMB20  \ offset: 0x260 : JPEG Huffman symbol
$5002a264 constant SEC_JPEG_JPEG_HUFFSYMB21  \ offset: 0x264 : JPEG Huffman symbol
$5002a268 constant SEC_JPEG_JPEG_HUFFSYMB22  \ offset: 0x268 : JPEG Huffman symbol
$5002a26c constant SEC_JPEG_JPEG_HUFFSYMB23  \ offset: 0x26C : JPEG Huffman symbol
$5002a270 constant SEC_JPEG_JPEG_HUFFSYMB24  \ offset: 0x270 : JPEG Huffman symbol
$5002a274 constant SEC_JPEG_JPEG_HUFFSYMB25  \ offset: 0x274 : JPEG Huffman symbol
$5002a278 constant SEC_JPEG_JPEG_HUFFSYMB26  \ offset: 0x278 : JPEG Huffman symbol
$5002a27c constant SEC_JPEG_JPEG_HUFFSYMB27  \ offset: 0x27C : JPEG Huffman symbol
$5002a280 constant SEC_JPEG_JPEG_HUFFSYMB28  \ offset: 0x280 : JPEG Huffman symbol
$5002a284 constant SEC_JPEG_JPEG_HUFFSYMB29  \ offset: 0x284 : JPEG Huffman symbol
$5002a288 constant SEC_JPEG_JPEG_HUFFSYMB30  \ offset: 0x288 : JPEG Huffman symbol
$5002a28c constant SEC_JPEG_JPEG_HUFFSYMB31  \ offset: 0x28C : JPEG Huffman symbol
$5002a290 constant SEC_JPEG_JPEG_HUFFSYMB32  \ offset: 0x290 : JPEG Huffman symbol
$5002a294 constant SEC_JPEG_JPEG_HUFFSYMB33  \ offset: 0x294 : JPEG Huffman symbol
$5002a298 constant SEC_JPEG_JPEG_HUFFSYMB34  \ offset: 0x298 : JPEG Huffman symbol
$5002a29c constant SEC_JPEG_JPEG_HUFFSYMB35  \ offset: 0x29C : JPEG Huffman symbol
$5002a2a0 constant SEC_JPEG_JPEG_HUFFSYMB36  \ offset: 0x2A0 : JPEG Huffman symbol
$5002a2a4 constant SEC_JPEG_JPEG_HUFFSYMB37  \ offset: 0x2A4 : JPEG Huffman symbol
$5002a2a8 constant SEC_JPEG_JPEG_HUFFSYMB38  \ offset: 0x2A8 : JPEG Huffman symbol
$5002a2ac constant SEC_JPEG_JPEG_HUFFSYMB39  \ offset: 0x2AC : JPEG Huffman symbol
$5002a2b0 constant SEC_JPEG_JPEG_HUFFSYMB40  \ offset: 0x2B0 : JPEG Huffman symbol
$5002a2b4 constant SEC_JPEG_JPEG_HUFFSYMB41  \ offset: 0x2B4 : JPEG Huffman symbol
$5002a2b8 constant SEC_JPEG_JPEG_HUFFSYMB42  \ offset: 0x2B8 : JPEG Huffman symbol
$5002a2bc constant SEC_JPEG_JPEG_HUFFSYMB43  \ offset: 0x2BC : JPEG Huffman symbol
$5002a2c0 constant SEC_JPEG_JPEG_HUFFSYMB44  \ offset: 0x2C0 : JPEG Huffman symbol
$5002a2c4 constant SEC_JPEG_JPEG_HUFFSYMB45  \ offset: 0x2C4 : JPEG Huffman symbol
$5002a2c8 constant SEC_JPEG_JPEG_HUFFSYMB46  \ offset: 0x2C8 : JPEG Huffman symbol
$5002a2cc constant SEC_JPEG_JPEG_HUFFSYMB47  \ offset: 0x2CC : JPEG Huffman symbol
$5002a2d0 constant SEC_JPEG_JPEG_HUFFSYMB48  \ offset: 0x2D0 : JPEG Huffman symbol
$5002a2d4 constant SEC_JPEG_JPEG_HUFFSYMB49  \ offset: 0x2D4 : JPEG Huffman symbol
$5002a2d8 constant SEC_JPEG_JPEG_HUFFSYMB50  \ offset: 0x2D8 : JPEG Huffman symbol
$5002a2dc constant SEC_JPEG_JPEG_HUFFSYMB51  \ offset: 0x2DC : JPEG Huffman symbol
$5002a2e0 constant SEC_JPEG_JPEG_HUFFSYMB52  \ offset: 0x2E0 : JPEG Huffman symbol
$5002a2e4 constant SEC_JPEG_JPEG_HUFFSYMB53  \ offset: 0x2E4 : JPEG Huffman symbol
$5002a2e8 constant SEC_JPEG_JPEG_HUFFSYMB54  \ offset: 0x2E8 : JPEG Huffman symbol
$5002a2ec constant SEC_JPEG_JPEG_HUFFSYMB55  \ offset: 0x2EC : JPEG Huffman symbol
$5002a2f0 constant SEC_JPEG_JPEG_HUFFSYMB56  \ offset: 0x2F0 : JPEG Huffman symbol
$5002a2f4 constant SEC_JPEG_JPEG_HUFFSYMB57  \ offset: 0x2F4 : JPEG Huffman symbol
$5002a2f8 constant SEC_JPEG_JPEG_HUFFSYMB58  \ offset: 0x2F8 : JPEG Huffman symbol
$5002a2fc constant SEC_JPEG_JPEG_HUFFSYMB59  \ offset: 0x2FC : JPEG Huffman symbol
$5002a300 constant SEC_JPEG_JPEG_HUFFSYMB60  \ offset: 0x300 : JPEG Huffman symbol
$5002a304 constant SEC_JPEG_JPEG_HUFFSYMB61  \ offset: 0x304 : JPEG Huffman symbol
$5002a308 constant SEC_JPEG_JPEG_HUFFSYMB62  \ offset: 0x308 : JPEG Huffman symbol
$5002a30c constant SEC_JPEG_JPEG_HUFFSYMB63  \ offset: 0x30C : JPEG Huffman symbol
$5002a310 constant SEC_JPEG_JPEG_HUFFSYMB64  \ offset: 0x310 : JPEG Huffman symbol
$5002a314 constant SEC_JPEG_JPEG_HUFFSYMB65  \ offset: 0x314 : JPEG Huffman symbol
$5002a318 constant SEC_JPEG_JPEG_HUFFSYMB66  \ offset: 0x318 : JPEG Huffman symbol
$5002a31c constant SEC_JPEG_JPEG_HUFFSYMB67  \ offset: 0x31C : JPEG Huffman symbol
$5002a320 constant SEC_JPEG_JPEG_HUFFSYMB68  \ offset: 0x320 : JPEG Huffman symbol
$5002a324 constant SEC_JPEG_JPEG_HUFFSYMB69  \ offset: 0x324 : JPEG Huffman symbol
$5002a328 constant SEC_JPEG_JPEG_HUFFSYMB70  \ offset: 0x328 : JPEG Huffman symbol
$5002a32c constant SEC_JPEG_JPEG_HUFFSYMB71  \ offset: 0x32C : JPEG Huffman symbol
$5002a330 constant SEC_JPEG_JPEG_HUFFSYMB72  \ offset: 0x330 : JPEG Huffman symbol
$5002a334 constant SEC_JPEG_JPEG_HUFFSYMB73  \ offset: 0x334 : JPEG Huffman symbol
$5002a338 constant SEC_JPEG_JPEG_HUFFSYMB74  \ offset: 0x338 : JPEG Huffman symbol
$5002a33c constant SEC_JPEG_JPEG_HUFFSYMB75  \ offset: 0x33C : JPEG Huffman symbol
$5002a340 constant SEC_JPEG_JPEG_HUFFSYMB76  \ offset: 0x340 : JPEG Huffman symbol
$5002a344 constant SEC_JPEG_JPEG_HUFFSYMB77  \ offset: 0x344 : JPEG Huffman symbol
$5002a348 constant SEC_JPEG_JPEG_HUFFSYMB78  \ offset: 0x348 : JPEG Huffman symbol
$5002a34c constant SEC_JPEG_JPEG_HUFFSYMB79  \ offset: 0x34C : JPEG Huffman symbol
$5002a350 constant SEC_JPEG_JPEG_HUFFSYMB80  \ offset: 0x350 : JPEG Huffman symbol
$5002a354 constant SEC_JPEG_JPEG_HUFFSYMB81  \ offset: 0x354 : JPEG Huffman symbol
$5002a358 constant SEC_JPEG_JPEG_HUFFSYMB82  \ offset: 0x358 : JPEG Huffman symbol
$5002a35c constant SEC_JPEG_JPEG_HUFFSYMB83  \ offset: 0x35C : JPEG Huffman symbol
$5002a360 constant SEC_JPEG_JPEG_DHTMEM0  \ offset: 0x360 : JPEG DHT memory
$5002a364 constant SEC_JPEG_JPEG_DHTMEM1  \ offset: 0x364 : JPEG DHT memory
$5002a368 constant SEC_JPEG_JPEG_DHTMEM2  \ offset: 0x368 : JPEG DHT memory
$5002a36c constant SEC_JPEG_JPEG_DHTMEM3  \ offset: 0x36C : JPEG DHT memory
$5002a370 constant SEC_JPEG_JPEG_DHTMEM4  \ offset: 0x370 : JPEG DHT memory
$5002a374 constant SEC_JPEG_JPEG_DHTMEM5  \ offset: 0x374 : JPEG DHT memory
$5002a378 constant SEC_JPEG_JPEG_DHTMEM6  \ offset: 0x378 : JPEG DHT memory
$5002a37c constant SEC_JPEG_JPEG_DHTMEM7  \ offset: 0x37C : JPEG DHT memory
$5002a380 constant SEC_JPEG_JPEG_DHTMEM8  \ offset: 0x380 : JPEG DHT memory
$5002a384 constant SEC_JPEG_JPEG_DHTMEM9  \ offset: 0x384 : JPEG DHT memory
$5002a388 constant SEC_JPEG_JPEG_DHTMEM10  \ offset: 0x388 : JPEG DHT memory
$5002a38c constant SEC_JPEG_JPEG_DHTMEM11  \ offset: 0x38C : JPEG DHT memory
$5002a390 constant SEC_JPEG_JPEG_DHTMEM12  \ offset: 0x390 : JPEG DHT memory
$5002a394 constant SEC_JPEG_JPEG_DHTMEM13  \ offset: 0x394 : JPEG DHT memory
$5002a398 constant SEC_JPEG_JPEG_DHTMEM14  \ offset: 0x398 : JPEG DHT memory
$5002a39c constant SEC_JPEG_JPEG_DHTMEM15  \ offset: 0x39C : JPEG DHT memory
$5002a3a0 constant SEC_JPEG_JPEG_DHTMEM16  \ offset: 0x3A0 : JPEG DHT memory
$5002a3a4 constant SEC_JPEG_JPEG_DHTMEM17  \ offset: 0x3A4 : JPEG DHT memory
$5002a3a8 constant SEC_JPEG_JPEG_DHTMEM18  \ offset: 0x3A8 : JPEG DHT memory
$5002a3ac constant SEC_JPEG_JPEG_DHTMEM19  \ offset: 0x3AC : JPEG DHT memory
$5002a3b0 constant SEC_JPEG_JPEG_DHTMEM20  \ offset: 0x3B0 : JPEG DHT memory
$5002a3b4 constant SEC_JPEG_JPEG_DHTMEM21  \ offset: 0x3B4 : JPEG DHT memory
$5002a3b8 constant SEC_JPEG_JPEG_DHTMEM22  \ offset: 0x3B8 : JPEG DHT memory
$5002a3bc constant SEC_JPEG_JPEG_DHTMEM23  \ offset: 0x3BC : JPEG DHT memory
$5002a3c0 constant SEC_JPEG_JPEG_DHTMEM24  \ offset: 0x3C0 : JPEG DHT memory
$5002a3c4 constant SEC_JPEG_JPEG_DHTMEM25  \ offset: 0x3C4 : JPEG DHT memory
$5002a3c8 constant SEC_JPEG_JPEG_DHTMEM26  \ offset: 0x3C8 : JPEG DHT memory
$5002a3cc constant SEC_JPEG_JPEG_DHTMEM27  \ offset: 0x3CC : JPEG DHT memory
$5002a3d0 constant SEC_JPEG_JPEG_DHTMEM28  \ offset: 0x3D0 : JPEG DHT memory
$5002a3d4 constant SEC_JPEG_JPEG_DHTMEM29  \ offset: 0x3D4 : JPEG DHT memory
$5002a3d8 constant SEC_JPEG_JPEG_DHTMEM30  \ offset: 0x3D8 : JPEG DHT memory
$5002a3dc constant SEC_JPEG_JPEG_DHTMEM31  \ offset: 0x3DC : JPEG DHT memory
$5002a3e0 constant SEC_JPEG_JPEG_DHTMEM32  \ offset: 0x3E0 : JPEG DHT memory
$5002a3e4 constant SEC_JPEG_JPEG_DHTMEM33  \ offset: 0x3E4 : JPEG DHT memory
$5002a3e8 constant SEC_JPEG_JPEG_DHTMEM34  \ offset: 0x3E8 : JPEG DHT memory
$5002a3ec constant SEC_JPEG_JPEG_DHTMEM35  \ offset: 0x3EC : JPEG DHT memory
$5002a3f0 constant SEC_JPEG_JPEG_DHTMEM36  \ offset: 0x3F0 : JPEG DHT memory
$5002a3f4 constant SEC_JPEG_JPEG_DHTMEM37  \ offset: 0x3F4 : JPEG DHT memory
$5002a3f8 constant SEC_JPEG_JPEG_DHTMEM38  \ offset: 0x3F8 : JPEG DHT memory
$5002a3fc constant SEC_JPEG_JPEG_DHTMEM39  \ offset: 0x3FC : JPEG DHT memory
$5002a400 constant SEC_JPEG_JPEG_DHTMEM40  \ offset: 0x400 : JPEG DHT memory
$5002a404 constant SEC_JPEG_JPEG_DHTMEM41  \ offset: 0x404 : JPEG DHT memory
$5002a408 constant SEC_JPEG_JPEG_DHTMEM42  \ offset: 0x408 : JPEG DHT memory
$5002a40c constant SEC_JPEG_JPEG_DHTMEM43  \ offset: 0x40C : JPEG DHT memory
$5002a410 constant SEC_JPEG_JPEG_DHTMEM44  \ offset: 0x410 : JPEG DHT memory
$5002a414 constant SEC_JPEG_JPEG_DHTMEM45  \ offset: 0x414 : JPEG DHT memory
$5002a418 constant SEC_JPEG_JPEG_DHTMEM46  \ offset: 0x418 : JPEG DHT memory
$5002a41c constant SEC_JPEG_JPEG_DHTMEM47  \ offset: 0x41C : JPEG DHT memory
$5002a420 constant SEC_JPEG_JPEG_DHTMEM48  \ offset: 0x420 : JPEG DHT memory
$5002a424 constant SEC_JPEG_JPEG_DHTMEM49  \ offset: 0x424 : JPEG DHT memory
$5002a428 constant SEC_JPEG_JPEG_DHTMEM50  \ offset: 0x428 : JPEG DHT memory
$5002a42c constant SEC_JPEG_JPEG_DHTMEM51  \ offset: 0x42C : JPEG DHT memory
$5002a430 constant SEC_JPEG_JPEG_DHTMEM52  \ offset: 0x430 : JPEG DHT memory
$5002a434 constant SEC_JPEG_JPEG_DHTMEM53  \ offset: 0x434 : JPEG DHT memory
$5002a438 constant SEC_JPEG_JPEG_DHTMEM54  \ offset: 0x438 : JPEG DHT memory
$5002a43c constant SEC_JPEG_JPEG_DHTMEM55  \ offset: 0x43C : JPEG DHT memory
$5002a440 constant SEC_JPEG_JPEG_DHTMEM56  \ offset: 0x440 : JPEG DHT memory
$5002a444 constant SEC_JPEG_JPEG_DHTMEM57  \ offset: 0x444 : JPEG DHT memory
$5002a448 constant SEC_JPEG_JPEG_DHTMEM58  \ offset: 0x448 : JPEG DHT memory
$5002a44c constant SEC_JPEG_JPEG_DHTMEM59  \ offset: 0x44C : JPEG DHT memory
$5002a450 constant SEC_JPEG_JPEG_DHTMEM60  \ offset: 0x450 : JPEG DHT memory
$5002a454 constant SEC_JPEG_JPEG_DHTMEM61  \ offset: 0x454 : JPEG DHT memory
$5002a458 constant SEC_JPEG_JPEG_DHTMEM62  \ offset: 0x458 : JPEG DHT memory
$5002a45c constant SEC_JPEG_JPEG_DHTMEM63  \ offset: 0x45C : JPEG DHT memory
$5002a460 constant SEC_JPEG_JPEG_DHTMEM64  \ offset: 0x460 : JPEG DHT memory
$5002a464 constant SEC_JPEG_JPEG_DHTMEM65  \ offset: 0x464 : JPEG DHT memory
$5002a468 constant SEC_JPEG_JPEG_DHTMEM66  \ offset: 0x468 : JPEG DHT memory
$5002a46c constant SEC_JPEG_JPEG_DHTMEM67  \ offset: 0x46C : JPEG DHT memory
$5002a470 constant SEC_JPEG_JPEG_DHTMEM68  \ offset: 0x470 : JPEG DHT memory
$5002a474 constant SEC_JPEG_JPEG_DHTMEM69  \ offset: 0x474 : JPEG DHT memory
$5002a478 constant SEC_JPEG_JPEG_DHTMEM70  \ offset: 0x478 : JPEG DHT memory
$5002a47c constant SEC_JPEG_JPEG_DHTMEM71  \ offset: 0x47C : JPEG DHT memory
$5002a480 constant SEC_JPEG_JPEG_DHTMEM72  \ offset: 0x480 : JPEG DHT memory
$5002a484 constant SEC_JPEG_JPEG_DHTMEM73  \ offset: 0x484 : JPEG DHT memory
$5002a488 constant SEC_JPEG_JPEG_DHTMEM74  \ offset: 0x488 : JPEG DHT memory
$5002a48c constant SEC_JPEG_JPEG_DHTMEM75  \ offset: 0x48C : JPEG DHT memory
$5002a490 constant SEC_JPEG_JPEG_DHTMEM76  \ offset: 0x490 : JPEG DHT memory
$5002a494 constant SEC_JPEG_JPEG_DHTMEM77  \ offset: 0x494 : JPEG DHT memory
$5002a498 constant SEC_JPEG_JPEG_DHTMEM78  \ offset: 0x498 : JPEG DHT memory
$5002a49c constant SEC_JPEG_JPEG_DHTMEM79  \ offset: 0x49C : JPEG DHT memory
$5002a4a0 constant SEC_JPEG_JPEG_DHTMEM80  \ offset: 0x4A0 : JPEG DHT memory
$5002a4a4 constant SEC_JPEG_JPEG_DHTMEM81  \ offset: 0x4A4 : JPEG DHT memory
$5002a4a8 constant SEC_JPEG_JPEG_DHTMEM82  \ offset: 0x4A8 : JPEG DHT memory
$5002a4ac constant SEC_JPEG_JPEG_DHTMEM83  \ offset: 0x4AC : JPEG DHT memory
$5002a4b0 constant SEC_JPEG_JPEG_DHTMEM84  \ offset: 0x4B0 : JPEG DHT memory
$5002a4b4 constant SEC_JPEG_JPEG_DHTMEM85  \ offset: 0x4B4 : JPEG DHT memory
$5002a4b8 constant SEC_JPEG_JPEG_DHTMEM86  \ offset: 0x4B8 : JPEG DHT memory
$5002a4bc constant SEC_JPEG_JPEG_DHTMEM87  \ offset: 0x4BC : JPEG DHT memory
$5002a4c0 constant SEC_JPEG_JPEG_DHTMEM88  \ offset: 0x4C0 : JPEG DHT memory
$5002a4c4 constant SEC_JPEG_JPEG_DHTMEM89  \ offset: 0x4C4 : JPEG DHT memory
$5002a4c8 constant SEC_JPEG_JPEG_DHTMEM90  \ offset: 0x4C8 : JPEG DHT memory
$5002a4cc constant SEC_JPEG_JPEG_DHTMEM91  \ offset: 0x4CC : JPEG DHT memory
$5002a4d0 constant SEC_JPEG_JPEG_DHTMEM92  \ offset: 0x4D0 : JPEG DHT memory
$5002a4d4 constant SEC_JPEG_JPEG_DHTMEM93  \ offset: 0x4D4 : JPEG DHT memory
$5002a4d8 constant SEC_JPEG_JPEG_DHTMEM94  \ offset: 0x4D8 : JPEG DHT memory
$5002a4dc constant SEC_JPEG_JPEG_DHTMEM95  \ offset: 0x4DC : JPEG DHT memory
$5002a4e0 constant SEC_JPEG_JPEG_DHTMEM96  \ offset: 0x4E0 : JPEG DHT memory
$5002a4e4 constant SEC_JPEG_JPEG_DHTMEM97  \ offset: 0x4E4 : JPEG DHT memory
$5002a4e8 constant SEC_JPEG_JPEG_DHTMEM98  \ offset: 0x4E8 : JPEG DHT memory
$5002a4ec constant SEC_JPEG_JPEG_DHTMEM99  \ offset: 0x4EC : JPEG DHT memory
$5002a4f0 constant SEC_JPEG_JPEG_DHTMEM100  \ offset: 0x4F0 : JPEG DHT memory
$5002a4f4 constant SEC_JPEG_JPEG_DHTMEM101  \ offset: 0x4F4 : JPEG DHT memory
$5002a4f8 constant SEC_JPEG_JPEG_DHTMEM102  \ offset: 0x4F8 : JPEG DHT memory
$5002a500 constant SEC_JPEG_JPEG_HUFFENC_AC0_0  \ offset: 0x500 : JPEG Huffman encoder AC0
$5002a504 constant SEC_JPEG_JPEG_HUFFENC_AC0_1  \ offset: 0x504 : JPEG Huffman encoder AC0
$5002a508 constant SEC_JPEG_JPEG_HUFFENC_AC0_2  \ offset: 0x508 : JPEG Huffman encoder AC0
$5002a50c constant SEC_JPEG_JPEG_HUFFENC_AC0_3  \ offset: 0x50C : JPEG Huffman encoder AC0
$5002a510 constant SEC_JPEG_JPEG_HUFFENC_AC0_4  \ offset: 0x510 : JPEG Huffman encoder AC0
$5002a514 constant SEC_JPEG_JPEG_HUFFENC_AC0_5  \ offset: 0x514 : JPEG Huffman encoder AC0
$5002a518 constant SEC_JPEG_JPEG_HUFFENC_AC0_6  \ offset: 0x518 : JPEG Huffman encoder AC0
$5002a51c constant SEC_JPEG_JPEG_HUFFENC_AC0_7  \ offset: 0x51C : JPEG Huffman encoder AC0
$5002a520 constant SEC_JPEG_JPEG_HUFFENC_AC0_8  \ offset: 0x520 : JPEG Huffman encoder AC0
$5002a524 constant SEC_JPEG_JPEG_HUFFENC_AC0_9  \ offset: 0x524 : JPEG Huffman encoder AC0
$5002a528 constant SEC_JPEG_JPEG_HUFFENC_AC0_10  \ offset: 0x528 : JPEG Huffman encoder AC0
$5002a52c constant SEC_JPEG_JPEG_HUFFENC_AC0_11  \ offset: 0x52C : JPEG Huffman encoder AC0
$5002a530 constant SEC_JPEG_JPEG_HUFFENC_AC0_12  \ offset: 0x530 : JPEG Huffman encoder AC0
$5002a534 constant SEC_JPEG_JPEG_HUFFENC_AC0_13  \ offset: 0x534 : JPEG Huffman encoder AC0
$5002a538 constant SEC_JPEG_JPEG_HUFFENC_AC0_14  \ offset: 0x538 : JPEG Huffman encoder AC0
$5002a53c constant SEC_JPEG_JPEG_HUFFENC_AC0_15  \ offset: 0x53C : JPEG Huffman encoder AC0
$5002a540 constant SEC_JPEG_JPEG_HUFFENC_AC0_16  \ offset: 0x540 : JPEG Huffman encoder AC0
$5002a544 constant SEC_JPEG_JPEG_HUFFENC_AC0_17  \ offset: 0x544 : JPEG Huffman encoder AC0
$5002a548 constant SEC_JPEG_JPEG_HUFFENC_AC0_18  \ offset: 0x548 : JPEG Huffman encoder AC0
$5002a54c constant SEC_JPEG_JPEG_HUFFENC_AC0_19  \ offset: 0x54C : JPEG Huffman encoder AC0
$5002a550 constant SEC_JPEG_JPEG_HUFFENC_AC0_20  \ offset: 0x550 : JPEG Huffman encoder AC0
$5002a554 constant SEC_JPEG_JPEG_HUFFENC_AC0_21  \ offset: 0x554 : JPEG Huffman encoder AC0
$5002a558 constant SEC_JPEG_JPEG_HUFFENC_AC0_22  \ offset: 0x558 : JPEG Huffman encoder AC0
$5002a55c constant SEC_JPEG_JPEG_HUFFENC_AC0_23  \ offset: 0x55C : JPEG Huffman encoder AC0
$5002a560 constant SEC_JPEG_JPEG_HUFFENC_AC0_24  \ offset: 0x560 : JPEG Huffman encoder AC0
$5002a564 constant SEC_JPEG_JPEG_HUFFENC_AC0_25  \ offset: 0x564 : JPEG Huffman encoder AC0
$5002a568 constant SEC_JPEG_JPEG_HUFFENC_AC0_26  \ offset: 0x568 : JPEG Huffman encoder AC0
$5002a56c constant SEC_JPEG_JPEG_HUFFENC_AC0_27  \ offset: 0x56C : JPEG Huffman encoder AC0
$5002a570 constant SEC_JPEG_JPEG_HUFFENC_AC0_28  \ offset: 0x570 : JPEG Huffman encoder AC0
$5002a574 constant SEC_JPEG_JPEG_HUFFENC_AC0_29  \ offset: 0x574 : JPEG Huffman encoder AC0
$5002a578 constant SEC_JPEG_JPEG_HUFFENC_AC0_30  \ offset: 0x578 : JPEG Huffman encoder AC0
$5002a57c constant SEC_JPEG_JPEG_HUFFENC_AC0_31  \ offset: 0x57C : JPEG Huffman encoder AC0
$5002a580 constant SEC_JPEG_JPEG_HUFFENC_AC0_32  \ offset: 0x580 : JPEG Huffman encoder AC0
$5002a584 constant SEC_JPEG_JPEG_HUFFENC_AC0_33  \ offset: 0x584 : JPEG Huffman encoder AC0
$5002a588 constant SEC_JPEG_JPEG_HUFFENC_AC0_34  \ offset: 0x588 : JPEG Huffman encoder AC0
$5002a58c constant SEC_JPEG_JPEG_HUFFENC_AC0_35  \ offset: 0x58C : JPEG Huffman encoder AC0
$5002a590 constant SEC_JPEG_JPEG_HUFFENC_AC0_36  \ offset: 0x590 : JPEG Huffman encoder AC0
$5002a594 constant SEC_JPEG_JPEG_HUFFENC_AC0_37  \ offset: 0x594 : JPEG Huffman encoder AC0
$5002a598 constant SEC_JPEG_JPEG_HUFFENC_AC0_38  \ offset: 0x598 : JPEG Huffman encoder AC0
$5002a59c constant SEC_JPEG_JPEG_HUFFENC_AC0_39  \ offset: 0x59C : JPEG Huffman encoder AC0
$5002a5a0 constant SEC_JPEG_JPEG_HUFFENC_AC0_40  \ offset: 0x5A0 : JPEG Huffman encoder AC0
$5002a5a4 constant SEC_JPEG_JPEG_HUFFENC_AC0_41  \ offset: 0x5A4 : JPEG Huffman encoder AC0
$5002a5a8 constant SEC_JPEG_JPEG_HUFFENC_AC0_42  \ offset: 0x5A8 : JPEG Huffman encoder AC0
$5002a5ac constant SEC_JPEG_JPEG_HUFFENC_AC0_43  \ offset: 0x5AC : JPEG Huffman encoder AC0
$5002a5b0 constant SEC_JPEG_JPEG_HUFFENC_AC0_44  \ offset: 0x5B0 : JPEG Huffman encoder AC0
$5002a5b4 constant SEC_JPEG_JPEG_HUFFENC_AC0_45  \ offset: 0x5B4 : JPEG Huffman encoder AC0
$5002a5b8 constant SEC_JPEG_JPEG_HUFFENC_AC0_46  \ offset: 0x5B8 : JPEG Huffman encoder AC0
$5002a5bc constant SEC_JPEG_JPEG_HUFFENC_AC0_47  \ offset: 0x5BC : JPEG Huffman encoder AC0
$5002a5c0 constant SEC_JPEG_JPEG_HUFFENC_AC0_48  \ offset: 0x5C0 : JPEG Huffman encoder AC0
$5002a5c4 constant SEC_JPEG_JPEG_HUFFENC_AC0_49  \ offset: 0x5C4 : JPEG Huffman encoder AC0
$5002a5c8 constant SEC_JPEG_JPEG_HUFFENC_AC0_50  \ offset: 0x5C8 : JPEG Huffman encoder AC0
$5002a5cc constant SEC_JPEG_JPEG_HUFFENC_AC0_51  \ offset: 0x5CC : JPEG Huffman encoder AC0
$5002a5d0 constant SEC_JPEG_JPEG_HUFFENC_AC0_52  \ offset: 0x5D0 : JPEG Huffman encoder AC0
$5002a5d4 constant SEC_JPEG_JPEG_HUFFENC_AC0_53  \ offset: 0x5D4 : JPEG Huffman encoder AC0
$5002a5d8 constant SEC_JPEG_JPEG_HUFFENC_AC0_54  \ offset: 0x5D8 : JPEG Huffman encoder AC0
$5002a5dc constant SEC_JPEG_JPEG_HUFFENC_AC0_55  \ offset: 0x5DC : JPEG Huffman encoder AC0
$5002a5dc constant SEC_JPEG_JPEG_HUFFENC_AC1_0  \ offset: 0x5DC : JPEG Huffman encoder AC1
$5002a5e0 constant SEC_JPEG_JPEG_HUFFENC_AC0_56  \ offset: 0x5E0 : JPEG Huffman encoder AC0
$5002a5e0 constant SEC_JPEG_JPEG_HUFFENC_AC1_1  \ offset: 0x5E0 : JPEG Huffman encoder AC1
$5002a5e4 constant SEC_JPEG_JPEG_HUFFENC_AC0_57  \ offset: 0x5E4 : JPEG Huffman encoder AC0
$5002a5e4 constant SEC_JPEG_JPEG_HUFFENC_AC1_2  \ offset: 0x5E4 : JPEG Huffman encoder AC1
$5002a5e8 constant SEC_JPEG_JPEG_HUFFENC_AC0_58  \ offset: 0x5E8 : JPEG Huffman encoder AC0
$5002a5e8 constant SEC_JPEG_JPEG_HUFFENC_AC1_3  \ offset: 0x5E8 : JPEG Huffman encoder AC1
$5002a5ec constant SEC_JPEG_JPEG_HUFFENC_AC0_59  \ offset: 0x5EC : JPEG Huffman encoder AC0
$5002a5ec constant SEC_JPEG_JPEG_HUFFENC_AC1_4  \ offset: 0x5EC : JPEG Huffman encoder AC1
$5002a5f0 constant SEC_JPEG_JPEG_HUFFENC_AC0_60  \ offset: 0x5F0 : JPEG Huffman encoder AC0
$5002a5f0 constant SEC_JPEG_JPEG_HUFFENC_AC1_5  \ offset: 0x5F0 : JPEG Huffman encoder AC1
$5002a5f4 constant SEC_JPEG_JPEG_HUFFENC_AC0_61  \ offset: 0x5F4 : JPEG Huffman encoder AC0
$5002a5f4 constant SEC_JPEG_JPEG_HUFFENC_AC1_6  \ offset: 0x5F4 : JPEG Huffman encoder AC1
$5002a5f8 constant SEC_JPEG_JPEG_HUFFENC_AC0_62  \ offset: 0x5F8 : JPEG Huffman encoder AC0
$5002a5f8 constant SEC_JPEG_JPEG_HUFFENC_AC1_7  \ offset: 0x5F8 : JPEG Huffman encoder AC1
$5002a5fc constant SEC_JPEG_JPEG_HUFFENC_AC0_63  \ offset: 0x5FC : JPEG Huffman encoder AC0
$5002a5fc constant SEC_JPEG_JPEG_HUFFENC_AC1_8  \ offset: 0x5FC : JPEG Huffman encoder AC1
$5002a600 constant SEC_JPEG_JPEG_HUFFENC_AC0_64  \ offset: 0x600 : JPEG Huffman encoder AC0
$5002a600 constant SEC_JPEG_JPEG_HUFFENC_AC1_9  \ offset: 0x600 : JPEG Huffman encoder AC1
$5002a604 constant SEC_JPEG_JPEG_HUFFENC_AC0_65  \ offset: 0x604 : JPEG Huffman encoder AC0
$5002a604 constant SEC_JPEG_JPEG_HUFFENC_AC1_10  \ offset: 0x604 : JPEG Huffman encoder AC1
$5002a608 constant SEC_JPEG_JPEG_HUFFENC_AC0_66  \ offset: 0x608 : JPEG Huffman encoder AC0
$5002a608 constant SEC_JPEG_JPEG_HUFFENC_AC1_11  \ offset: 0x608 : JPEG Huffman encoder AC1
$5002a60c constant SEC_JPEG_JPEG_HUFFENC_AC0_67  \ offset: 0x60C : JPEG Huffman encoder AC0
$5002a60c constant SEC_JPEG_JPEG_HUFFENC_AC1_12  \ offset: 0x60C : JPEG Huffman encoder AC1
$5002a610 constant SEC_JPEG_JPEG_HUFFENC_AC0_68  \ offset: 0x610 : JPEG Huffman encoder AC0
$5002a610 constant SEC_JPEG_JPEG_HUFFENC_AC1_13  \ offset: 0x610 : JPEG Huffman encoder AC1
$5002a614 constant SEC_JPEG_JPEG_HUFFENC_AC0_69  \ offset: 0x614 : JPEG Huffman encoder AC0
$5002a614 constant SEC_JPEG_JPEG_HUFFENC_AC1_14  \ offset: 0x614 : JPEG Huffman encoder AC1
$5002a618 constant SEC_JPEG_JPEG_HUFFENC_AC0_70  \ offset: 0x618 : JPEG Huffman encoder AC0
$5002a618 constant SEC_JPEG_JPEG_HUFFENC_AC1_15  \ offset: 0x618 : JPEG Huffman encoder AC1
$5002a61c constant SEC_JPEG_JPEG_HUFFENC_AC0_71  \ offset: 0x61C : JPEG Huffman encoder AC0
$5002a61c constant SEC_JPEG_JPEG_HUFFENC_AC1_16  \ offset: 0x61C : JPEG Huffman encoder AC1
$5002a620 constant SEC_JPEG_JPEG_HUFFENC_AC0_72  \ offset: 0x620 : JPEG Huffman encoder AC0
$5002a620 constant SEC_JPEG_JPEG_HUFFENC_AC1_17  \ offset: 0x620 : JPEG Huffman encoder AC1
$5002a624 constant SEC_JPEG_JPEG_HUFFENC_AC0_73  \ offset: 0x624 : JPEG Huffman encoder AC0
$5002a624 constant SEC_JPEG_JPEG_HUFFENC_AC1_18  \ offset: 0x624 : JPEG Huffman encoder AC1
$5002a628 constant SEC_JPEG_JPEG_HUFFENC_AC0_74  \ offset: 0x628 : JPEG Huffman encoder AC0
$5002a628 constant SEC_JPEG_JPEG_HUFFENC_AC1_19  \ offset: 0x628 : JPEG Huffman encoder AC1
$5002a62c constant SEC_JPEG_JPEG_HUFFENC_AC0_75  \ offset: 0x62C : JPEG Huffman encoder AC0
$5002a62c constant SEC_JPEG_JPEG_HUFFENC_AC1_20  \ offset: 0x62C : JPEG Huffman encoder AC1
$5002a630 constant SEC_JPEG_JPEG_HUFFENC_AC0_76  \ offset: 0x630 : JPEG Huffman encoder AC0
$5002a630 constant SEC_JPEG_JPEG_HUFFENC_AC1_21  \ offset: 0x630 : JPEG Huffman encoder AC1
$5002a634 constant SEC_JPEG_JPEG_HUFFENC_AC0_77  \ offset: 0x634 : JPEG Huffman encoder AC0
$5002a634 constant SEC_JPEG_JPEG_HUFFENC_AC1_22  \ offset: 0x634 : JPEG Huffman encoder AC1
$5002a638 constant SEC_JPEG_JPEG_HUFFENC_AC0_78  \ offset: 0x638 : JPEG Huffman encoder AC0
$5002a638 constant SEC_JPEG_JPEG_HUFFENC_AC1_23  \ offset: 0x638 : JPEG Huffman encoder AC1
$5002a63c constant SEC_JPEG_JPEG_HUFFENC_AC0_79  \ offset: 0x63C : JPEG Huffman encoder AC0
$5002a63c constant SEC_JPEG_JPEG_HUFFENC_AC1_24  \ offset: 0x63C : JPEG Huffman encoder AC1
$5002a640 constant SEC_JPEG_JPEG_HUFFENC_AC0_80  \ offset: 0x640 : JPEG Huffman encoder AC0
$5002a640 constant SEC_JPEG_JPEG_HUFFENC_AC1_25  \ offset: 0x640 : JPEG Huffman encoder AC1
$5002a644 constant SEC_JPEG_JPEG_HUFFENC_AC0_81  \ offset: 0x644 : JPEG Huffman encoder AC0
$5002a644 constant SEC_JPEG_JPEG_HUFFENC_AC1_26  \ offset: 0x644 : JPEG Huffman encoder AC1
$5002a648 constant SEC_JPEG_JPEG_HUFFENC_AC0_82  \ offset: 0x648 : JPEG Huffman encoder AC0
$5002a648 constant SEC_JPEG_JPEG_HUFFENC_AC1_27  \ offset: 0x648 : JPEG Huffman encoder AC1
$5002a64c constant SEC_JPEG_JPEG_HUFFENC_AC0_83  \ offset: 0x64C : JPEG Huffman encoder AC0
$5002a64c constant SEC_JPEG_JPEG_HUFFENC_AC1_28  \ offset: 0x64C : JPEG Huffman encoder AC1
$5002a650 constant SEC_JPEG_JPEG_HUFFENC_AC0_84  \ offset: 0x650 : JPEG Huffman encoder AC0
$5002a650 constant SEC_JPEG_JPEG_HUFFENC_AC1_29  \ offset: 0x650 : JPEG Huffman encoder AC1
$5002a654 constant SEC_JPEG_JPEG_HUFFENC_AC0_85  \ offset: 0x654 : JPEG Huffman encoder AC0
$5002a654 constant SEC_JPEG_JPEG_HUFFENC_AC1_30  \ offset: 0x654 : JPEG Huffman encoder AC1
$5002a658 constant SEC_JPEG_JPEG_HUFFENC_AC0_86  \ offset: 0x658 : JPEG Huffman encoder AC0
$5002a658 constant SEC_JPEG_JPEG_HUFFENC_AC1_31  \ offset: 0x658 : JPEG Huffman encoder AC1
$5002a65c constant SEC_JPEG_JPEG_HUFFENC_AC0_87  \ offset: 0x65C : JPEG Huffman encoder AC0
$5002a65c constant SEC_JPEG_JPEG_HUFFENC_AC1_32  \ offset: 0x65C : JPEG Huffman encoder AC1
$5002a660 constant SEC_JPEG_JPEG_HUFFENC_AC1_33  \ offset: 0x660 : JPEG Huffman encoder AC1
$5002a664 constant SEC_JPEG_JPEG_HUFFENC_AC1_34  \ offset: 0x664 : JPEG Huffman encoder AC1
$5002a668 constant SEC_JPEG_JPEG_HUFFENC_AC1_35  \ offset: 0x668 : JPEG Huffman encoder AC1
$5002a66c constant SEC_JPEG_JPEG_HUFFENC_AC1_36  \ offset: 0x66C : JPEG Huffman encoder AC1
$5002a670 constant SEC_JPEG_JPEG_HUFFENC_AC1_37  \ offset: 0x670 : JPEG Huffman encoder AC1
$5002a674 constant SEC_JPEG_JPEG_HUFFENC_AC1_38  \ offset: 0x674 : JPEG Huffman encoder AC1
$5002a678 constant SEC_JPEG_JPEG_HUFFENC_AC1_39  \ offset: 0x678 : JPEG Huffman encoder AC1
$5002a67c constant SEC_JPEG_JPEG_HUFFENC_AC1_40  \ offset: 0x67C : JPEG Huffman encoder AC1
$5002a680 constant SEC_JPEG_JPEG_HUFFENC_AC1_41  \ offset: 0x680 : JPEG Huffman encoder AC1
$5002a684 constant SEC_JPEG_JPEG_HUFFENC_AC1_42  \ offset: 0x684 : JPEG Huffman encoder AC1
$5002a688 constant SEC_JPEG_JPEG_HUFFENC_AC1_43  \ offset: 0x688 : JPEG Huffman encoder AC1
$5002a68c constant SEC_JPEG_JPEG_HUFFENC_AC1_44  \ offset: 0x68C : JPEG Huffman encoder AC1
$5002a690 constant SEC_JPEG_JPEG_HUFFENC_AC1_45  \ offset: 0x690 : JPEG Huffman encoder AC1
$5002a694 constant SEC_JPEG_JPEG_HUFFENC_AC1_46  \ offset: 0x694 : JPEG Huffman encoder AC1
$5002a698 constant SEC_JPEG_JPEG_HUFFENC_AC1_47  \ offset: 0x698 : JPEG Huffman encoder AC1
$5002a69c constant SEC_JPEG_JPEG_HUFFENC_AC1_48  \ offset: 0x69C : JPEG Huffman encoder AC1
$5002a6a0 constant SEC_JPEG_JPEG_HUFFENC_AC1_49  \ offset: 0x6A0 : JPEG Huffman encoder AC1
$5002a6a4 constant SEC_JPEG_JPEG_HUFFENC_AC1_50  \ offset: 0x6A4 : JPEG Huffman encoder AC1
$5002a6a8 constant SEC_JPEG_JPEG_HUFFENC_AC1_51  \ offset: 0x6A8 : JPEG Huffman encoder AC1
$5002a6ac constant SEC_JPEG_JPEG_HUFFENC_AC1_52  \ offset: 0x6AC : JPEG Huffman encoder AC1
$5002a6b0 constant SEC_JPEG_JPEG_HUFFENC_AC1_53  \ offset: 0x6B0 : JPEG Huffman encoder AC1
$5002a6b4 constant SEC_JPEG_JPEG_HUFFENC_AC1_54  \ offset: 0x6B4 : JPEG Huffman encoder AC1
$5002a6b8 constant SEC_JPEG_JPEG_HUFFENC_AC1_55  \ offset: 0x6B8 : JPEG Huffman encoder AC1
$5002a6bc constant SEC_JPEG_JPEG_HUFFENC_AC1_56  \ offset: 0x6BC : JPEG Huffman encoder AC1
$5002a6c0 constant SEC_JPEG_JPEG_HUFFENC_AC1_57  \ offset: 0x6C0 : JPEG Huffman encoder AC1
$5002a6c4 constant SEC_JPEG_JPEG_HUFFENC_AC1_58  \ offset: 0x6C4 : JPEG Huffman encoder AC1
$5002a6c8 constant SEC_JPEG_JPEG_HUFFENC_AC1_59  \ offset: 0x6C8 : JPEG Huffman encoder AC1
$5002a6cc constant SEC_JPEG_JPEG_HUFFENC_AC1_60  \ offset: 0x6CC : JPEG Huffman encoder AC1
$5002a6d0 constant SEC_JPEG_JPEG_HUFFENC_AC1_61  \ offset: 0x6D0 : JPEG Huffman encoder AC1
$5002a6d4 constant SEC_JPEG_JPEG_HUFFENC_AC1_62  \ offset: 0x6D4 : JPEG Huffman encoder AC1
$5002a6d8 constant SEC_JPEG_JPEG_HUFFENC_AC1_63  \ offset: 0x6D8 : JPEG Huffman encoder AC1
$5002a6dc constant SEC_JPEG_JPEG_HUFFENC_AC1_64  \ offset: 0x6DC : JPEG Huffman encoder AC1
$5002a6e0 constant SEC_JPEG_JPEG_HUFFENC_AC1_65  \ offset: 0x6E0 : JPEG Huffman encoder AC1
$5002a6e4 constant SEC_JPEG_JPEG_HUFFENC_AC1_66  \ offset: 0x6E4 : JPEG Huffman encoder AC1
$5002a6e8 constant SEC_JPEG_JPEG_HUFFENC_AC1_67  \ offset: 0x6E8 : JPEG Huffman encoder AC1
$5002a6ec constant SEC_JPEG_JPEG_HUFFENC_AC1_68  \ offset: 0x6EC : JPEG Huffman encoder AC1
$5002a6f0 constant SEC_JPEG_JPEG_HUFFENC_AC1_69  \ offset: 0x6F0 : JPEG Huffman encoder AC1
$5002a6f4 constant SEC_JPEG_JPEG_HUFFENC_AC1_70  \ offset: 0x6F4 : JPEG Huffman encoder AC1
$5002a6f8 constant SEC_JPEG_JPEG_HUFFENC_AC1_71  \ offset: 0x6F8 : JPEG Huffman encoder AC1
$5002a6fc constant SEC_JPEG_JPEG_HUFFENC_AC1_72  \ offset: 0x6FC : JPEG Huffman encoder AC1
$5002a700 constant SEC_JPEG_JPEG_HUFFENC_AC1_73  \ offset: 0x700 : JPEG Huffman encoder AC1
$5002a704 constant SEC_JPEG_JPEG_HUFFENC_AC1_74  \ offset: 0x704 : JPEG Huffman encoder AC1
$5002a708 constant SEC_JPEG_JPEG_HUFFENC_AC1_75  \ offset: 0x708 : JPEG Huffman encoder AC1
$5002a70c constant SEC_JPEG_JPEG_HUFFENC_AC1_76  \ offset: 0x70C : JPEG Huffman encoder AC1
$5002a710 constant SEC_JPEG_JPEG_HUFFENC_AC1_77  \ offset: 0x710 : JPEG Huffman encoder AC1
$5002a714 constant SEC_JPEG_JPEG_HUFFENC_AC1_78  \ offset: 0x714 : JPEG Huffman encoder AC1
$5002a718 constant SEC_JPEG_JPEG_HUFFENC_AC1_79  \ offset: 0x718 : JPEG Huffman encoder AC1
$5002a71c constant SEC_JPEG_JPEG_HUFFENC_AC1_80  \ offset: 0x71C : JPEG Huffman encoder AC1
$5002a720 constant SEC_JPEG_JPEG_HUFFENC_AC1_81  \ offset: 0x720 : JPEG Huffman encoder AC1
$5002a724 constant SEC_JPEG_JPEG_HUFFENC_AC1_82  \ offset: 0x724 : JPEG Huffman encoder AC1
$5002a728 constant SEC_JPEG_JPEG_HUFFENC_AC1_83  \ offset: 0x728 : JPEG Huffman encoder AC1
$5002a72c constant SEC_JPEG_JPEG_HUFFENC_AC1_84  \ offset: 0x72C : JPEG Huffman encoder AC1
$5002a730 constant SEC_JPEG_JPEG_HUFFENC_AC1_85  \ offset: 0x730 : JPEG Huffman encoder AC1
$5002a734 constant SEC_JPEG_JPEG_HUFFENC_AC1_86  \ offset: 0x734 : JPEG Huffman encoder AC1
$5002a738 constant SEC_JPEG_JPEG_HUFFENC_AC1_87  \ offset: 0x738 : JPEG Huffman encoder AC1
$5002a7c0 constant SEC_JPEG_JPEG_HUFFENC_DC0_0  \ offset: 0x7C0 : JPEG Huffman encoder DC0
$5002a7c4 constant SEC_JPEG_JPEG_HUFFENC_DC0_1  \ offset: 0x7C4 : JPEG Huffman encoder DC0
$5002a7c8 constant SEC_JPEG_JPEG_HUFFENC_DC0_2  \ offset: 0x7C8 : JPEG Huffman encoder DC0
$5002a7cc constant SEC_JPEG_JPEG_HUFFENC_DC0_3  \ offset: 0x7CC : JPEG Huffman encoder DC0
$5002a7d0 constant SEC_JPEG_JPEG_HUFFENC_DC0_4  \ offset: 0x7D0 : JPEG Huffman encoder DC0
$5002a7d4 constant SEC_JPEG_JPEG_HUFFENC_DC0_5  \ offset: 0x7D4 : JPEG Huffman encoder DC0
$5002a7d8 constant SEC_JPEG_JPEG_HUFFENC_DC0_6  \ offset: 0x7D8 : JPEG Huffman encoder DC0
$5002a7dc constant SEC_JPEG_JPEG_HUFFENC_DC0_7  \ offset: 0x7DC : JPEG Huffman encoder DC0
$5002a89c constant SEC_JPEG_JPEG_HUFFENC_DC1_0  \ offset: 0x89C : JPEG Huffman encoder DC1
$5002a8a0 constant SEC_JPEG_JPEG_HUFFENC_DC1_1  \ offset: 0x8A0 : JPEG Huffman encoder DC1
$5002a8a4 constant SEC_JPEG_JPEG_HUFFENC_DC1_2  \ offset: 0x8A4 : JPEG Huffman encoder DC1
$5002a8a8 constant SEC_JPEG_JPEG_HUFFENC_DC1_3  \ offset: 0x8A8 : JPEG Huffman encoder DC1
$5002a8ac constant SEC_JPEG_JPEG_HUFFENC_DC1_4  \ offset: 0x8AC : JPEG Huffman encoder DC1
$5002a8b0 constant SEC_JPEG_JPEG_HUFFENC_DC1_5  \ offset: 0x8B0 : JPEG Huffman encoder DC1
$5002a8b4 constant SEC_JPEG_JPEG_HUFFENC_DC1_6  \ offset: 0x8B4 : JPEG Huffman encoder DC1
$5002a8b8 constant SEC_JPEG_JPEG_HUFFENC_DC1_7  \ offset: 0x8B8 : JPEG Huffman encoder DC1

