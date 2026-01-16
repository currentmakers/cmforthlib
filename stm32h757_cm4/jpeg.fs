\
\ @file jpeg.fs
\ @brief JPEG
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

$00000001 constant JPEG_CONFR0_START                                \ Start This bit start or stop the encoding or decoding process. Read this register always return 0.


\
\ @brief JPEG codec configuration register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000003 constant JPEG_CONFR1_NF                                   \ Number of color components This field defines the number of color components minus 1.
$00000008 constant JPEG_CONFR1_DE                                   \ Decoding Enable This bit selects the coding or decoding process
$00000030 constant JPEG_CONFR1_COLORSPACE                           \ Color Space This filed defines the number of quantization tables minus 1 to insert in the output stream.
$000000c0 constant JPEG_CONFR1_NS                                   \ Number of components for Scan This field defines the number of components minus 1 for scan header marker segment.
$00000100 constant JPEG_CONFR1_HDR                                  \ Header Processing This bit enable the header processing (generation/parsing).
$ffff0000 constant JPEG_CONFR1_YSIZE                                \ Y Size This field defines the number of lines in source image.


\
\ @brief JPEG codec configuration register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$03ffffff constant JPEG_CONFR2_NMCU                                 \ Number of MCU For encoding: this field defines the number of MCU units minus 1 to encode. For decoding: this field indicates the number of complete MCU units minus 1 to be decoded (this field is updated after the JPEG header parsing). If the decoded image size has not a X or Y size multiple of 8 or 16 (depending on the sub-sampling process), the resulting incomplete or empty MCU must be added to this value to get the total number of MCU generated.


\
\ @brief JPEG codec configuration register 3
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$ffff0000 constant JPEG_CONFR3_XSIZE                                \ X size This field defines the number of pixels per line.


\
\ @brief JPEG codec configuration register 4-7
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant JPEG_CONFRN1_HD                                  \ Huffman DC Selects the Huffman table for encoding the DC coefficients.
$00000002 constant JPEG_CONFRN1_HA                                  \ Huffman AC Selects the Huffman table for encoding the AC coefficients.
$0000000c constant JPEG_CONFRN1_QT                                  \ Quantization Table Selects quantization table associated with a color component.
$000000f0 constant JPEG_CONFRN1_NB                                  \ Number of Block Number of data units minus 1 that belong to a particular color in the MCU.
$00000f00 constant JPEG_CONFRN1_VSF                                 \ Vertical Sampling Factor Vertical sampling factor for component i.
$0000f000 constant JPEG_CONFRN1_HSF                                 \ Horizontal Sampling Factor Horizontal sampling factor for component i.


\
\ @brief JPEG codec configuration register 4-7
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant JPEG_CONFRN2_HD                                  \ Huffman DC Selects the Huffman table for encoding the DC coefficients.
$00000002 constant JPEG_CONFRN2_HA                                  \ Huffman AC Selects the Huffman table for encoding the AC coefficients.
$0000000c constant JPEG_CONFRN2_QT                                  \ Quantization Table Selects quantization table associated with a color component.
$000000f0 constant JPEG_CONFRN2_NB                                  \ Number of Block Number of data units minus 1 that belong to a particular color in the MCU.
$00000f00 constant JPEG_CONFRN2_VSF                                 \ Vertical Sampling Factor Vertical sampling factor for component i.
$0000f000 constant JPEG_CONFRN2_HSF                                 \ Horizontal Sampling Factor Horizontal sampling factor for component i.


\
\ @brief JPEG codec configuration register 4-7
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant JPEG_CONFRN3_HD                                  \ Huffman DC Selects the Huffman table for encoding the DC coefficients.
$00000002 constant JPEG_CONFRN3_HA                                  \ Huffman AC Selects the Huffman table for encoding the AC coefficients.
$0000000c constant JPEG_CONFRN3_QT                                  \ Quantization Table Selects quantization table associated with a color component.
$000000f0 constant JPEG_CONFRN3_NB                                  \ Number of Block Number of data units minus 1 that belong to a particular color in the MCU.
$00000f00 constant JPEG_CONFRN3_VSF                                 \ Vertical Sampling Factor Vertical sampling factor for component i.
$0000f000 constant JPEG_CONFRN3_HSF                                 \ Horizontal Sampling Factor Horizontal sampling factor for component i.


\
\ @brief JPEG codec configuration register 4-7
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant JPEG_CONFRN4_HD                                  \ Huffman DC Selects the Huffman table for encoding the DC coefficients.
$00000002 constant JPEG_CONFRN4_HA                                  \ Huffman AC Selects the Huffman table for encoding the AC coefficients.
$0000000c constant JPEG_CONFRN4_QT                                  \ Quantization Table Selects quantization table associated with a color component.
$000000f0 constant JPEG_CONFRN4_NB                                  \ Number of Block Number of data units minus 1 that belong to a particular color in the MCU.
$00000f00 constant JPEG_CONFRN4_VSF                                 \ Vertical Sampling Factor Vertical sampling factor for component i.
$0000f000 constant JPEG_CONFRN4_HSF                                 \ Horizontal Sampling Factor Horizontal sampling factor for component i.


\
\ @brief JPEG control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant JPEG_CR_JCEN                                     \ JPEG Core Enable Enable the JPEG codec Core.
$00000002 constant JPEG_CR_IFTIE                                    \ Input FIFO Threshold Interrupt Enable This bit enables the interrupt generation when input FIFO reach the threshold.
$00000004 constant JPEG_CR_IFNFIE                                   \ Input FIFO Not Full Interrupt Enable This bit enables the interrupt generation when input FIFO is not empty.
$00000008 constant JPEG_CR_OFTIE                                    \ Output FIFO Threshold Interrupt Enable This bit enables the interrupt generation when output FIFO reach the threshold.
$00000010 constant JPEG_CR_OFNEIE                                   \ Output FIFO Not Empty Interrupt Enable This bit enables the interrupt generation when output FIFO is not empty.
$00000020 constant JPEG_CR_EOCIE                                    \ End of Conversion Interrupt Enable This bit enables the interrupt generation on the end of conversion.
$00000040 constant JPEG_CR_HPDIE                                    \ Header Parsing Done Interrupt Enable This bit enables the interrupt generation on the Header Parsing Operation.
$00000800 constant JPEG_CR_IDMAEN                                   \ Input DMA Enable Enable the DMA request generation for the input FIFO.
$00001000 constant JPEG_CR_ODMAEN                                   \ Output DMA Enable Enable the DMA request generation for the output FIFO.
$00002000 constant JPEG_CR_IFF                                      \ Input FIFO Flush This bit flush the input FIFO. This bit is always read as 0.
$00004000 constant JPEG_CR_OFF                                      \ Output FIFO Flush This bit flush the output FIFO. This bit is always read as 0.


\
\ @brief JPEG status register
\ Address offset: 0x34
\ Reset value: 0x00000006
\

$00000002 constant JPEG_SR_IFTF                                     \ Input FIFO Threshold Flag This bit is set when the input FIFO is not full and is bellow its threshold.
$00000004 constant JPEG_SR_IFNFF                                    \ Input FIFO Not Full Flag This bit is set when the input FIFO is not full (a data can be written).
$00000008 constant JPEG_SR_OFTF                                     \ Output FIFO Threshold Flag This bit is set when the output FIFO is not empty and has reach its threshold.
$00000010 constant JPEG_SR_OFNEF                                    \ Output FIFO Not Empty Flag This bit is set when the output FIFO is not empty (a data is available).
$00000020 constant JPEG_SR_EOCF                                     \ End of Conversion Flag This bit is set when the JPEG codec core has finished the encoding or the decoding process and than last data has been sent to the output FIFO.
$00000040 constant JPEG_SR_HPDF                                     \ Header Parsing Done Flag This bit is set in decode mode when the JPEG codec has finished the parsing of the headers and the internal registers have been updated.
$00000080 constant JPEG_SR_COF                                      \ Codec Operation Flag This bit is set when when a JPEG codec operation is on going (encoding or decoding).


\
\ @brief JPEG clear flag register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000020 constant JPEG_CFR_CEOCF                                   \ Clear End of Conversion Flag Writing 1 clears the End of Conversion Flag of the JPEG Status Register.
$00000040 constant JPEG_CFR_CHPDF                                   \ Clear Header Parsing Done Flag Writing 1 clears the Header Parsing Done Flag of the JPEG Status Register.


\
\ @brief JPEG data input register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DIR_DATAIN                                  \ Data Input FIFO Input FIFO data register.


\
\ @brief JPEG data output register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant JPEG_DOR_DATAOUT                                 \ Data Output FIFO Output FIFO data register.


\
\ @brief JPEG
\
$52003000 constant JPEG_CONFR0    \ offset: 0x00 : JPEG codec control register
$52003004 constant JPEG_CONFR1    \ offset: 0x04 : JPEG codec configuration register 1
$52003008 constant JPEG_CONFR2    \ offset: 0x08 : JPEG codec configuration register 2
$5200300c constant JPEG_CONFR3    \ offset: 0x0C : JPEG codec configuration register 3
$52003010 constant JPEG_CONFRN1   \ offset: 0x10 : JPEG codec configuration register 4-7
$52003014 constant JPEG_CONFRN2   \ offset: 0x14 : JPEG codec configuration register 4-7
$52003018 constant JPEG_CONFRN3   \ offset: 0x18 : JPEG codec configuration register 4-7
$5200301c constant JPEG_CONFRN4   \ offset: 0x1C : JPEG codec configuration register 4-7
$52003030 constant JPEG_CR        \ offset: 0x30 : JPEG control register
$52003034 constant JPEG_SR        \ offset: 0x34 : JPEG status register
$52003038 constant JPEG_CFR       \ offset: 0x38 : JPEG clear flag register
$52003040 constant JPEG_DIR       \ offset: 0x40 : JPEG data input register
$52003044 constant JPEG_DOR       \ offset: 0x44 : JPEG data output register

