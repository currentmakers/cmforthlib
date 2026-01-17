\
\ @file jpeg.fs
\ @brief JPEG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] JPEG_DEF

  [ifdef] JPEG_CONFR0_DEF
    \
    \ @brief JPEG codec control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_START                     \ [0x00] Start This bit start or stop the encoding or decoding process. Read this register always return 0.
  [then]


  [ifdef] JPEG_CONFR1_DEF
    \
    \ @brief JPEG codec configuration register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_NF                        \ [0x00 : 2] Number of color components This field defines the number of color components minus 1.
    $03 constant JPEG_DE                        \ [0x03] Decoding Enable This bit selects the coding or decoding process
    $04 constant JPEG_COLORSPACE                \ [0x04 : 2] Color Space This filed defines the number of quantization tables minus 1 to insert in the output stream.
    $06 constant JPEG_NS                        \ [0x06 : 2] Number of components for Scan This field defines the number of components minus 1 for scan header marker segment.
    $08 constant JPEG_HDR                       \ [0x08] Header Processing This bit enable the header processing (generation/parsing).
    $10 constant JPEG_YSIZE                     \ [0x10 : 16] Y Size This field defines the number of lines in source image.
  [then]


  [ifdef] JPEG_CONFR2_DEF
    \
    \ @brief JPEG codec configuration register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_NMCU                      \ [0x00 : 26] Number of MCU For encoding: this field defines the number of MCU units minus 1 to encode. For decoding: this field indicates the number of complete MCU units minus 1 to be decoded (this field is updated after the JPEG header parsing). If the decoded image size has not a X or Y size multiple of 8 or 16 (depending on the sub-sampling process), the resulting incomplete or empty MCU must be added to this value to get the total number of MCU generated.
  [then]


  [ifdef] JPEG_CONFR3_DEF
    \
    \ @brief JPEG codec configuration register 3
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $10 constant JPEG_XSIZE                     \ [0x10 : 16] X size This field defines the number of pixels per line.
  [then]


  [ifdef] JPEG_CONFRN1_DEF
    \
    \ @brief JPEG codec configuration register 4-7
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HD                        \ [0x00] Huffman DC Selects the Huffman table for encoding the DC coefficients.
    $01 constant JPEG_HA                        \ [0x01] Huffman AC Selects the Huffman table for encoding the AC coefficients.
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization Table Selects quantization table associated with a color component.
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of Block Number of data units minus 1 that belong to a particular color in the MCU.
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical Sampling Factor Vertical sampling factor for component i.
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal Sampling Factor Horizontal sampling factor for component i.
  [then]


  [ifdef] JPEG_CONFRN2_DEF
    \
    \ @brief JPEG codec configuration register 4-7
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HD                        \ [0x00] Huffman DC Selects the Huffman table for encoding the DC coefficients.
    $01 constant JPEG_HA                        \ [0x01] Huffman AC Selects the Huffman table for encoding the AC coefficients.
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization Table Selects quantization table associated with a color component.
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of Block Number of data units minus 1 that belong to a particular color in the MCU.
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical Sampling Factor Vertical sampling factor for component i.
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal Sampling Factor Horizontal sampling factor for component i.
  [then]


  [ifdef] JPEG_CONFRN3_DEF
    \
    \ @brief JPEG codec configuration register 4-7
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HD                        \ [0x00] Huffman DC Selects the Huffman table for encoding the DC coefficients.
    $01 constant JPEG_HA                        \ [0x01] Huffman AC Selects the Huffman table for encoding the AC coefficients.
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization Table Selects quantization table associated with a color component.
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of Block Number of data units minus 1 that belong to a particular color in the MCU.
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical Sampling Factor Vertical sampling factor for component i.
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal Sampling Factor Horizontal sampling factor for component i.
  [then]


  [ifdef] JPEG_CONFRN4_DEF
    \
    \ @brief JPEG codec configuration register 4-7
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_HD                        \ [0x00] Huffman DC Selects the Huffman table for encoding the DC coefficients.
    $01 constant JPEG_HA                        \ [0x01] Huffman AC Selects the Huffman table for encoding the AC coefficients.
    $02 constant JPEG_QT                        \ [0x02 : 2] Quantization Table Selects quantization table associated with a color component.
    $04 constant JPEG_NB                        \ [0x04 : 4] Number of Block Number of data units minus 1 that belong to a particular color in the MCU.
    $08 constant JPEG_VSF                       \ [0x08 : 4] Vertical Sampling Factor Vertical sampling factor for component i.
    $0c constant JPEG_HSF                       \ [0x0c : 4] Horizontal Sampling Factor Horizontal sampling factor for component i.
  [then]


  [ifdef] JPEG_CR_DEF
    \
    \ @brief JPEG control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_JCEN                      \ [0x00] JPEG Core Enable Enable the JPEG codec Core.
    $01 constant JPEG_IFTIE                     \ [0x01] Input FIFO Threshold Interrupt Enable This bit enables the interrupt generation when input FIFO reach the threshold.
    $02 constant JPEG_IFNFIE                    \ [0x02] Input FIFO Not Full Interrupt Enable This bit enables the interrupt generation when input FIFO is not empty.
    $03 constant JPEG_OFTIE                     \ [0x03] Output FIFO Threshold Interrupt Enable This bit enables the interrupt generation when output FIFO reach the threshold.
    $04 constant JPEG_OFNEIE                    \ [0x04] Output FIFO Not Empty Interrupt Enable This bit enables the interrupt generation when output FIFO is not empty.
    $05 constant JPEG_EOCIE                     \ [0x05] End of Conversion Interrupt Enable This bit enables the interrupt generation on the end of conversion.
    $06 constant JPEG_HPDIE                     \ [0x06] Header Parsing Done Interrupt Enable This bit enables the interrupt generation on the Header Parsing Operation.
    $0b constant JPEG_IDMAEN                    \ [0x0b] Input DMA Enable Enable the DMA request generation for the input FIFO.
    $0c constant JPEG_ODMAEN                    \ [0x0c] Output DMA Enable Enable the DMA request generation for the output FIFO.
    $0d constant JPEG_IFF                       \ [0x0d] Input FIFO Flush This bit flush the input FIFO. This bit is always read as 0.
    $0e constant JPEG_OFF                       \ [0x0e] Output FIFO Flush This bit flush the output FIFO. This bit is always read as 0.
  [then]


  [ifdef] JPEG_SR_DEF
    \
    \ @brief JPEG status register
    \ Address offset: 0x34
    \ Reset value: 0x00000006
    \
    $01 constant JPEG_IFTF                      \ [0x01] Input FIFO Threshold Flag This bit is set when the input FIFO is not full and is bellow its threshold.
    $02 constant JPEG_IFNFF                     \ [0x02] Input FIFO Not Full Flag This bit is set when the input FIFO is not full (a data can be written).
    $03 constant JPEG_OFTF                      \ [0x03] Output FIFO Threshold Flag This bit is set when the output FIFO is not empty and has reach its threshold.
    $04 constant JPEG_OFNEF                     \ [0x04] Output FIFO Not Empty Flag This bit is set when the output FIFO is not empty (a data is available).
    $05 constant JPEG_EOCF                      \ [0x05] End of Conversion Flag This bit is set when the JPEG codec core has finished the encoding or the decoding process and than last data has been sent to the output FIFO.
    $06 constant JPEG_HPDF                      \ [0x06] Header Parsing Done Flag This bit is set in decode mode when the JPEG codec has finished the parsing of the headers and the internal registers have been updated.
    $07 constant JPEG_COF                       \ [0x07] Codec Operation Flag This bit is set when when a JPEG codec operation is on going (encoding or decoding).
  [then]


  [ifdef] JPEG_CFR_DEF
    \
    \ @brief JPEG clear flag register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $05 constant JPEG_CEOCF                     \ [0x05] Clear End of Conversion Flag Writing 1 clears the End of Conversion Flag of the JPEG Status Register.
    $06 constant JPEG_CHPDF                     \ [0x06] Clear Header Parsing Done Flag Writing 1 clears the Header Parsing Done Flag of the JPEG Status Register.
  [then]


  [ifdef] JPEG_DIR_DEF
    \
    \ @brief JPEG data input register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATAIN                    \ [0x00 : 32] Data Input FIFO Input FIFO data register.
  [then]


  [ifdef] JPEG_DOR_DEF
    \
    \ @brief JPEG data output register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant JPEG_DATAOUT                   \ [0x00 : 32] Data Output FIFO Output FIFO data register.
  [then]

  \
  \ @brief JPEG
  \
  $00 constant JPEG_CONFR0              \ JPEG codec control register
  $04 constant JPEG_CONFR1              \ JPEG codec configuration register 1
  $08 constant JPEG_CONFR2              \ JPEG codec configuration register 2
  $0C constant JPEG_CONFR3              \ JPEG codec configuration register 3
  $10 constant JPEG_CONFRN1             \ JPEG codec configuration register 4-7
  $14 constant JPEG_CONFRN2             \ JPEG codec configuration register 4-7
  $18 constant JPEG_CONFRN3             \ JPEG codec configuration register 4-7
  $1C constant JPEG_CONFRN4             \ JPEG codec configuration register 4-7
  $30 constant JPEG_CR                  \ JPEG control register
  $34 constant JPEG_SR                  \ JPEG status register
  $38 constant JPEG_CFR                 \ JPEG clear flag register
  $40 constant JPEG_DIR                 \ JPEG data input register
  $44 constant JPEG_DOR                 \ JPEG data output register

: JPEG_DEF ; [then]
