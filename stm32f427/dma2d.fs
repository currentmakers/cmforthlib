\
\ @file dma2d.fs
\ @brief DMA2D
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMA2D_DEF

  [ifdef] DMA2D_DMA2D_CR_DEF
    \
    \ @brief DMA2D control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_START                    \ [0x00] Start This bit can be used to launch the DMA2D according to the parameters loaded in the various configuration registers. This bit is automatically reset by the following events: ** At the end of the transfer ** When the data transfer is aborted by the user application by setting the ABORT bit in DMA2D_CR ** When a data transfer error occurs ** When the data transfer has not started due to a configuration error or another transfer operation already ongoing (automatic CLUT loading).
    $01 constant DMA2D_SUSP                     \ [0x01] Suspend This bit can be used to suspend the current transfer. This bit is set and reset by software. It is automatically reset by hardware when the START bit is reset.
    $02 constant DMA2D_ABORT                    \ [0x02] Abort This bit can be used to abort the current transfer. This bit is set by software and is automatically reset by hardware when the START bit is reset.
    $08 constant DMA2D_TEIE                     \ [0x08] Transfer error interrupt enable This bit is set and cleared by software.
    $09 constant DMA2D_TCIE                     \ [0x09] Transfer complete interrupt enable This bit is set and cleared by software.
    $0a constant DMA2D_TWIE                     \ [0x0a] Transfer watermark interrupt enable This bit is set and cleared by software.
    $0b constant DMA2D_CAEIE                    \ [0x0b] CLUT access error interrupt enable This bit is set and cleared by software.
    $0c constant DMA2D_CTCIE                    \ [0x0c] CLUT transfer complete interrupt enable This bit is set and cleared by software.
    $0d constant DMA2D_CEIE                     \ [0x0d] Configuration Error Interrupt Enable This bit is set and cleared by software.
    $10 constant DMA2D_MODE                     \ [0x10 : 2] DMA2D mode This bit is set and cleared by software. It cannot be modified while a transfer is ongoing.
  [then]


  [ifdef] DMA2D_DMA2D_ISR_DEF
    \
    \ @brief DMA2D Interrupt Status Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_TEIF                     \ [0x00] Transfer error interrupt flag This bit is set when an error occurs during a DMA transfer (data transfer or automatic CLUT loading).
    $01 constant DMA2D_TCIF                     \ [0x01] Transfer complete interrupt flag This bit is set when a DMA2D transfer operation is complete (data transfer only).
    $02 constant DMA2D_TWIF                     \ [0x02] Transfer watermark interrupt flag This bit is set when the last pixel of the watermarked line has been transferred.
    $03 constant DMA2D_CAEIF                    \ [0x03] CLUT access error interrupt flag This bit is set when the CPU accesses the CLUT while the CLUT is being automatically copied from a system memory to the internal DMA2D.
    $04 constant DMA2D_CTCIF                    \ [0x04] CLUT transfer complete interrupt flag This bit is set when the CLUT copy from a system memory area to the internal DMA2D memory is complete.
    $05 constant DMA2D_CEIF                     \ [0x05] Configuration error interrupt flag This bit is set when the START bit of DMA2D_CR, DMA2DFGPFCCR or DMA2D_BGPFCCR is set and a wrong configuration has been programmed.
  [then]


  [ifdef] DMA2D_DMA2D_IFCR_DEF
    \
    \ @brief DMA2D interrupt flag clear register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CTEIF                    \ [0x00] Clear Transfer error interrupt flag Programming this bit to 1 clears the TEIF flag in the DMA2D_ISR register
    $01 constant DMA2D_CTCIF                    \ [0x01] Clear transfer complete interrupt flag Programming this bit to 1 clears the TCIF flag in the DMA2D_ISR register
    $02 constant DMA2D_CTWIF                    \ [0x02] Clear transfer watermark interrupt flag Programming this bit to 1 clears the TWIF flag in the DMA2D_ISR register
    $03 constant DMA2D_CAECIF                   \ [0x03] Clear CLUT access error interrupt flag Programming this bit to 1 clears the CAEIF flag in the DMA2D_ISR register
    $04 constant DMA2D_CCTCIF                   \ [0x04] Clear CLUT transfer complete interrupt flag Programming this bit to 1 clears the CTCIF flag in the DMA2D_ISR register
    $05 constant DMA2D_CCEIF                    \ [0x05] Clear configuration error interrupt flag Programming this bit to 1 clears the CEIF flag in the DMA2D_ISR register
  [then]


  [ifdef] DMA2D_DMA2D_FGMAR_DEF
    \
    \ @brief DMA2D foreground memory address register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory address Address of the data used for the foreground image. This register can only be written when data transfers are disabled. Once the data transfer has started, this register is read-only. The address alignment must match the image format selected e.g. a 32-bit per pixel format must be 32-bit aligned, a 16-bit per pixel format must be 16-bit aligned and a 4-bit per pixel format must be 8-bit aligned.
  [then]


  [ifdef] DMA2D_DMA2D_FGOR_DEF
    \
    \ @brief DMA2D foreground offset register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LO                       \ [0x00 : 14] Line offset Line offset used for the foreground expressed in pixel. This value is used to generate the address. It is added at the end of each line to determine the starting address of the next line. These bits can only be written when data transfers are disabled. Once a data transfer has started, they become read-only. If the image format is 4-bit per pixel, the line offset must be even.
  [then]


  [ifdef] DMA2D_DMA2D_BGMAR_DEF
    \
    \ @brief DMA2D background memory address register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory address Address of the data used for the background image. This register can only be written when data transfers are disabled. Once a data transfer has started, this register is read-only. The address alignment must match the image format selected e.g. a 32-bit per pixel format must be 32-bit aligned, a 16-bit per pixel format must be 16-bit aligned and a 4-bit per pixel format must be 8-bit aligned.
  [then]


  [ifdef] DMA2D_DMA2D_BGOR_DEF
    \
    \ @brief DMA2D background offset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LO                       \ [0x00 : 14] Line offset Line offset used for the background image (expressed in pixel). This value is used for the address generation. It is added at the end of each line to determine the starting address of the next line. These bits can only be written when data transfers are disabled. Once data transfer has started, they become read-only. If the image format is 4-bit per pixel, the line offset must be even.
  [then]


  [ifdef] DMA2D_DMA2D_FGPFCCR_DEF
    \
    \ @brief DMA2D foreground PFC control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CM                       \ [0x00 : 4] Color mode These bits defines the color format of the foreground image. They can only be written when data transfers are disabled. Once the transfer has started, they are read-only. others: meaningless
    $04 constant DMA2D_CCM                      \ [0x04] CLUT color mode This bit defines the color format of the CLUT. It can only be written when the transfer is disabled. Once the CLUT transfer has started, this bit is read-only.
    $05 constant DMA2D_START                    \ [0x05] Start This bit can be set to start the automatic loading of the CLUT. It is automatically reset: ** at the end of the transfer ** when the transfer is aborted by the user application by setting the ABORT bit in DMA2D_CR ** when a transfer error occurs ** when the transfer has not started due to a configuration error or another transfer operation already ongoing (data transfer or automatic background CLUT transfer).
    $08 constant DMA2D_CS                       \ [0x08 : 8] CLUT size These bits define the size of the CLUT used for the foreground image. Once the CLUT transfer has started, this field is read-only. The number of CLUT entries is equal to CS[7:0] + 1.
    $10 constant DMA2D_AM                       \ [0x10 : 2] Alpha mode These bits select the alpha channel value to be used for the foreground image. They can only be written data the transfer are disabled. Once the transfer has started, they become read-only. other configurations are meaningless
    $12 constant DMA2D_CSS                      \ [0x12 : 2] Chroma Sub-Sampling These bits define the chroma sub-sampling mode for YCbCr color mode. Once the transfer has started, these bits are read-only. others: meaningless
    $14 constant DMA2D_AI                       \ [0x14] Alpha Inverted This bit inverts the alpha value. Once the transfer has started, this bit is read-only.
    $15 constant DMA2D_RBS                      \ [0x15] Red Blue Swap This bit allows to swap the R &amp; B to support BGR or ABGR color formats. Once the transfer has started, this bit is read-only.
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha value These bits define a fixed alpha channel value which can replace the original alpha value or be multiplied by the original alpha value according to the alpha mode selected through the AM[1:0] bits. These bits can only be written when data transfers are disabled. Once a transfer has started, they become read-only.
  [then]


  [ifdef] DMA2D_DMA2D_FGCOLR_DEF
    \
    \ @brief DMA2D foreground color register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue Value These bits defines the blue value for the A4 or A8 mode of the foreground image. They can only be written when data transfers are disabled. Once the transfer has started, They are read-only.
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green Value These bits defines the green value for the A4 or A8 mode of the foreground image. They can only be written when data transfers are disabled. Once the transfer has started, They are read-only.
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red Value These bits defines the red value for the A4 or A8 mode of the foreground image. They can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
  [then]


  [ifdef] DMA2D_DMA2D_BGPFCCR_DEF
    \
    \ @brief DMA2D background PFC control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CM                       \ [0x00 : 4] Color mode These bits define the color format of the foreground image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only. others: meaningless
    $04 constant DMA2D_CCM                      \ [0x04] CLUT Color mode These bits define the color format of the CLUT. This register can only be written when the transfer is disabled. Once the CLUT transfer has started, this bit is read-only.
    $05 constant DMA2D_START                    \ [0x05] Start This bit is set to start the automatic loading of the CLUT. This bit is automatically reset: ** at the end of the transfer ** when the transfer is aborted by the user application by setting the ABORT bit in the DMA2D_CR ** when a transfer error occurs ** when the transfer has not started due to a configuration error or another transfer operation already on going (data transfer or automatic BackGround CLUT transfer).
    $08 constant DMA2D_CS                       \ [0x08 : 8] CLUT size These bits define the size of the CLUT used for the BG. Once the CLUT transfer has started, this field is read-only. The number of CLUT entries is equal to CS[7:0] + 1.
    $10 constant DMA2D_AM                       \ [0x10 : 2] Alpha mode These bits define which alpha channel value to be used for the background image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only. others: meaningless
    $14 constant DMA2D_AI                       \ [0x14] Alpha Inverted This bit inverts the alpha value. Once the transfer has started, this bit is read-only.
    $15 constant DMA2D_RBS                      \ [0x15] Red Blue Swap This bit allows to swap the R &amp; B to support BGR or ABGR color formats. Once the transfer has started, this bit is read-only.
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha value These bits define a fixed alpha channel value which can replace the original alpha value or be multiplied with the original alpha value according to the alpha mode selected with bits AM[1: 0]. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
  [then]


  [ifdef] DMA2D_DMA2D_BGCOLR_DEF
    \
    \ @brief DMA2D background color register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue Value These bits define the blue value for the A4 or A8 mode of the background. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green Value These bits define the green value for the A4 or A8 mode of the background. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red Value These bits define the red value for the A4 or A8 mode of the background. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
  [then]


  [ifdef] DMA2D_DMA2D_FGCMAR_DEF
    \
    \ @brief DMA2D foreground CLUT memory address register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory Address Address of the data used for the CLUT address dedicated to the foreground image. This register can only be written when no transfer is ongoing. Once the CLUT transfer has started, this register is read-only. If the foreground CLUT format is 32-bit, the address must be 32-bit aligned.
  [then]


  [ifdef] DMA2D_DMA2D_BGCMAR_DEF
    \
    \ @brief DMA2D background CLUT memory address register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory address Address of the data used for the CLUT address dedicated to the background image. This register can only be written when no transfer is on going. Once the CLUT transfer has started, this register is read-only. If the background CLUT format is 32-bit, the address must be 32-bit aligned.
  [then]


  [ifdef] DMA2D_DMA2D_OPFCCR_DEF
    \
    \ @brief DMA2D output PFC control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CM                       \ [0x00 : 3] Color mode These bits define the color format of the output image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only. others: meaningless
    $14 constant DMA2D_AI                       \ [0x14] Alpha Inverted This bit inverts the alpha value. Once the transfer has started, this bit is read-only.
    $15 constant DMA2D_RBS                      \ [0x15] Red Blue Swap This bit allows to swap the R &amp; B to support BGR or ABGR color formats. Once the transfer has started, this bit is read-only.
  [then]


  [ifdef] DMA2D_DMA2D_OCOLR_DEF
    \
    \ @brief DMA2D output color register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue Value These bits define the blue value of the output image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green Value These bits define the green value of the output image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red Value These bits define the red value of the output image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha Channel Value These bits define the alpha channel of the output color. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
  [then]


  [ifdef] DMA2D_DMA2D_OMAR_DEF
    \
    \ @brief DMA2D output memory address register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory Address Address of the data used for the output FIFO. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only. The address alignment must match the image format selected e.g. a 32-bit per pixel format must be 32-bit aligned and a 16-bit per pixel format must be 16-bit aligned.
  [then]


  [ifdef] DMA2D_DMA2D_OOR_DEF
    \
    \ @brief DMA2D output offset register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LO                       \ [0x00 : 14] Line Offset Line offset used for the output (expressed in pixels). This value is used for the address generation. It is added at the end of each line to determine the starting address of the next line. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
  [then]


  [ifdef] DMA2D_DMA2D_NLR_DEF
    \
    \ @brief DMA2D number of line register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_NL                       \ [0x00 : 16] Number of lines Number of lines of the area to be transferred. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
    $10 constant DMA2D_PL                       \ [0x10 : 14] Pixel per lines Number of pixels per lines of the area to be transferred. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only. If any of the input image format is 4-bit per pixel, pixel per lines must be even.
  [then]


  [ifdef] DMA2D_DMA2D_LWR_DEF
    \
    \ @brief DMA2D line watermark register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LW                       \ [0x00 : 16] Line watermark These bits allow to configure the line watermark for interrupt generation. An interrupt is raised when the last pixel of the watermarked line has been transferred. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
  [then]


  [ifdef] DMA2D_DMA2D_AMTCR_DEF
    \
    \ @brief DMA2D AXI master timer configuration register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_EN                       \ [0x00] Enable Enables the dead time functionality.
    $08 constant DMA2D_DT                       \ [0x08 : 8] Dead Time Dead time value in the AXI clock cycle inserted between two consecutive accesses on the AXI master port. These bits represent the minimum guaranteed number of cycles between two consecutive AXI accesses.
  [then]

  \
  \ @brief DMA2D
  \
  $00 constant DMA2D_DMA2D_CR           \ DMA2D control register
  $04 constant DMA2D_DMA2D_ISR          \ DMA2D Interrupt Status Register
  $08 constant DMA2D_DMA2D_IFCR         \ DMA2D interrupt flag clear register
  $0C constant DMA2D_DMA2D_FGMAR        \ DMA2D foreground memory address register
  $10 constant DMA2D_DMA2D_FGOR         \ DMA2D foreground offset register
  $14 constant DMA2D_DMA2D_BGMAR        \ DMA2D background memory address register
  $18 constant DMA2D_DMA2D_BGOR         \ DMA2D background offset register
  $1C constant DMA2D_DMA2D_FGPFCCR      \ DMA2D foreground PFC control register
  $20 constant DMA2D_DMA2D_FGCOLR       \ DMA2D foreground color register
  $24 constant DMA2D_DMA2D_BGPFCCR      \ DMA2D background PFC control register
  $28 constant DMA2D_DMA2D_BGCOLR       \ DMA2D background color register
  $2C constant DMA2D_DMA2D_FGCMAR       \ DMA2D foreground CLUT memory address register
  $30 constant DMA2D_DMA2D_BGCMAR       \ DMA2D background CLUT memory address register
  $34 constant DMA2D_DMA2D_OPFCCR       \ DMA2D output PFC control register
  $38 constant DMA2D_DMA2D_OCOLR        \ DMA2D output color register
  $3C constant DMA2D_DMA2D_OMAR         \ DMA2D output memory address register
  $40 constant DMA2D_DMA2D_OOR          \ DMA2D output offset register
  $44 constant DMA2D_DMA2D_NLR          \ DMA2D number of line register
  $48 constant DMA2D_DMA2D_LWR          \ DMA2D line watermark register
  $4C constant DMA2D_DMA2D_AMTCR        \ DMA2D AXI master timer configuration register

: DMA2D_DEF ; [then]
