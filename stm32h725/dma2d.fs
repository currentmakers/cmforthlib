\
\ @file dma2d.fs
\ @brief DMA2D
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMA2D control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DMA2D_CR_START                                   \ Start This bit can be used to launch the DMA2D according to the parameters loaded in the various configuration registers
$00000002 constant DMA2D_CR_SUSP                                    \ Suspend This bit can be used to suspend the current transfer. This bit is set and reset by software. It is automatically reset by hardware when the START bit is reset.
$00000004 constant DMA2D_CR_ABORT                                   \ Abort This bit can be used to abort the current transfer. This bit is set by software and is automatically reset by hardware when the START bit is reset.
$00000100 constant DMA2D_CR_TEIE                                    \ Transfer error interrupt enable This bit is set and cleared by software.
$00000200 constant DMA2D_CR_TCIE                                    \ Transfer complete interrupt enable This bit is set and cleared by software.
$00000400 constant DMA2D_CR_TWIE                                    \ Transfer watermark interrupt enable This bit is set and cleared by software.
$00000800 constant DMA2D_CR_CAEIE                                   \ CLUT access error interrupt enable This bit is set and cleared by software.
$00001000 constant DMA2D_CR_CTCIE                                   \ CLUT transfer complete interrupt enable This bit is set and cleared by software.
$00002000 constant DMA2D_CR_CEIE                                    \ Configuration Error Interrupt Enable This bit is set and cleared by software.
$00030000 constant DMA2D_CR_MODE                                    \ DMA2D mode This bit is set and cleared by software. It cannot be modified while a transfer is ongoing.


\
\ @brief DMA2D Interrupt Status Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA2D_ISR_TEIF                                   \ Transfer error interrupt flag This bit is set when an error occurs during a DMA transfer (data transfer or automatic CLUT loading).
$00000002 constant DMA2D_ISR_TCIF                                   \ Transfer complete interrupt flag This bit is set when a DMA2D transfer operation is complete (data transfer only).
$00000004 constant DMA2D_ISR_TWIF                                   \ Transfer watermark interrupt flag This bit is set when the last pixel of the watermarked line has been transferred.
$00000008 constant DMA2D_ISR_CAEIF                                  \ CLUT access error interrupt flag This bit is set when the CPU accesses the CLUT while the CLUT is being automatically copied from a system memory to the internal DMA2D.
$00000010 constant DMA2D_ISR_CTCIF                                  \ CLUT transfer complete interrupt flag This bit is set when the CLUT copy from a system memory area to the internal DMA2D memory is complete.
$00000020 constant DMA2D_ISR_CEIF                                   \ Configuration error interrupt flag This bit is set when the START bit of DMA2D_CR, DMA2DFGPFCCR or DMA2D_BGPFCCR is set and a wrong configuration has been programmed.


\
\ @brief DMA2D interrupt flag clear register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA2D_IFCR_CTEIF                                 \ Clear Transfer error interrupt flag Programming this bit to 1 clears the TEIF flag in the DMA2D_ISR register
$00000002 constant DMA2D_IFCR_CTCIF                                 \ Clear transfer complete interrupt flag Programming this bit to 1 clears the TCIF flag in the DMA2D_ISR register
$00000004 constant DMA2D_IFCR_CTWIF                                 \ Clear transfer watermark interrupt flag Programming this bit to 1 clears the TWIF flag in the DMA2D_ISR register
$00000008 constant DMA2D_IFCR_CAECIF                                \ Clear CLUT access error interrupt flag Programming this bit to 1 clears the CAEIF flag in the DMA2D_ISR register
$00000010 constant DMA2D_IFCR_CCTCIF                                \ Clear CLUT transfer complete interrupt flag Programming this bit to 1 clears the CTCIF flag in the DMA2D_ISR register
$00000020 constant DMA2D_IFCR_CCEIF                                 \ Clear configuration error interrupt flag Programming this bit to 1 clears the CEIF flag in the DMA2D_ISR register


\
\ @brief DMA2D foreground memory address register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant DMA2D_FGMAR_MA                                   \ Memory address Address of the data used for the foreground image. This register can only be written when data transfers are disabled. Once the data transfer has started, this register is read-only. The address alignment must match the image format selected e.g. a 32-bit per pixel format must be 32-bit aligned, a 16-bit per pixel format must be 16-bit aligned and a 4-bit per pixel format must be 8-bit aligned.


\
\ @brief DMA2D foreground offset register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00003fff constant DMA2D_FGOR_LO                                    \ Line offset Line offset used for the foreground expressed in pixel. This value is used to generate the address. It is added at the end of each line to determine the starting address of the next line. These bits can only be written when data transfers are disabled. Once a data transfer has started, they become read-only. If the image format is 4-bit per pixel, the line offset must be even.


\
\ @brief DMA2D background memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant DMA2D_BGMAR_MA                                   \ Memory address Address of the data used for the background image. This register can only be written when data transfers are disabled. Once a data transfer has started, this register is read-only. The address alignment must match the image format selected e.g. a 32-bit per pixel format must be 32-bit aligned, a 16-bit per pixel format must be 16-bit aligned and a 4-bit per pixel format must be 8-bit aligned.


\
\ @brief DMA2D background offset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00003fff constant DMA2D_BGOR_LO                                    \ Line offset Line offset used for the background image (expressed in pixel). This value is used for the address generation. It is added at the end of each line to determine the starting address of the next line. These bits can only be written when data transfers are disabled. Once data transfer has started, they become read-only. If the image format is 4-bit per pixel, the line offset must be even.


\
\ @brief DMA2D foreground PFC control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant DMA2D_FGPFCCR_CM                                 \ Color mode These bits defines the color format of the foreground image. They can only be written when data transfers are disabled. Once the transfer has started, they are read-only. others: meaningless
$00000010 constant DMA2D_FGPFCCR_CCM                                \ CLUT color mode This bit defines the color format of the CLUT. It can only be written when the transfer is disabled. Once the CLUT transfer has started, this bit is read-only.
$00000020 constant DMA2D_FGPFCCR_START                              \ Start This bit can be set to start the automatic loading of the CLUT. It is automatically reset: ** at the end of the transfer ** when the transfer is aborted by the user application by setting the ABORT bit in DMA2D_CR ** when a transfer error occurs ** when the transfer has not started due to a configuration error or another transfer operation already ongoing (data transfer or automatic background CLUT transfer).
$0000ff00 constant DMA2D_FGPFCCR_CS                                 \ CLUT size These bits define the size of the CLUT used for the foreground image. Once the CLUT transfer has started, this field is read-only. The number of CLUT entries is equal to CS[7:0] + 1.
$00030000 constant DMA2D_FGPFCCR_AM                                 \ Alpha mode These bits select the alpha channel value to be used for the foreground image. They can only be written data the transfer are disabled. Once the transfer has started, they become read-only. other configurations are meaningless
$000c0000 constant DMA2D_FGPFCCR_CSS                                \ Chroma Sub-Sampling These bits define the chroma sub-sampling mode for YCbCr color mode. Once the transfer has started, these bits are read-only. others: meaningless
$00100000 constant DMA2D_FGPFCCR_AI                                 \ Alpha Inverted This bit inverts the alpha value. Once the transfer has started, this bit is read-only.
$00200000 constant DMA2D_FGPFCCR_RBS                                \ Red Blue Swap This bit allows to swap the R &amp; B to support BGR or ABGR color formats. Once the transfer has started, this bit is read-only.
$ff000000 constant DMA2D_FGPFCCR_ALPHA                              \ Alpha value These bits define a fixed alpha channel value which can replace the original alpha value or be multiplied by the original alpha value according to the alpha mode selected through the AM[1:0] bits. These bits can only be written when data transfers are disabled. Once a transfer has started, they become read-only.


\
\ @brief DMA2D foreground color register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_FGCOLR_BLUE                                \ Blue Value These bits defines the blue value for the A4 or A8 mode of the foreground image. They can only be written when data transfers are disabled. Once the transfer has started, They are read-only.
$0000ff00 constant DMA2D_FGCOLR_GREEN                               \ Green Value These bits defines the green value for the A4 or A8 mode of the foreground image. They can only be written when data transfers are disabled. Once the transfer has started, They are read-only.
$00ff0000 constant DMA2D_FGCOLR_RED                                 \ Red Value These bits defines the red value for the A4 or A8 mode of the foreground image. They can only be written when data transfers are disabled. Once the transfer has started, they are read-only.


\
\ @brief DMA2D background PFC control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant DMA2D_BGPFCCR_CM                                 \ Color mode These bits define the color format of the foreground image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only. others: meaningless
$00000010 constant DMA2D_BGPFCCR_CCM                                \ CLUT Color mode These bits define the color format of the CLUT. This register can only be written when the transfer is disabled. Once the CLUT transfer has started, this bit is read-only.
$00000020 constant DMA2D_BGPFCCR_START                              \ Start This bit is set to start the automatic loading of the CLUT. This bit is automatically reset: ** at the end of the transfer ** when the transfer is aborted by the user application by setting the ABORT bit in the DMA2D_CR ** when a transfer error occurs ** when the transfer has not started due to a configuration error or another transfer operation already on going (data transfer or automatic BackGround CLUT transfer).
$0000ff00 constant DMA2D_BGPFCCR_CS                                 \ CLUT size These bits define the size of the CLUT used for the BG. Once the CLUT transfer has started, this field is read-only. The number of CLUT entries is equal to CS[7:0] + 1.
$00030000 constant DMA2D_BGPFCCR_AM                                 \ Alpha mode These bits define which alpha channel value to be used for the background image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only. others: meaningless
$00100000 constant DMA2D_BGPFCCR_AI                                 \ Alpha Inverted This bit inverts the alpha value. Once the transfer has started, this bit is read-only.
$00200000 constant DMA2D_BGPFCCR_RBS                                \ Red Blue Swap This bit allows to swap the R &amp; B to support BGR or ABGR color formats. Once the transfer has started, this bit is read-only.
$ff000000 constant DMA2D_BGPFCCR_ALPHA                              \ Alpha value These bits define a fixed alpha channel value which can replace the original alpha value or be multiplied with the original alpha value according to the alpha mode selected with bits AM[1: 0]. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.


\
\ @brief DMA2D background color register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_BGCOLR_BLUE                                \ Blue Value These bits define the blue value for the A4 or A8 mode of the background. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
$0000ff00 constant DMA2D_BGCOLR_GREEN                               \ Green Value These bits define the green value for the A4 or A8 mode of the background. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
$00ff0000 constant DMA2D_BGCOLR_RED                                 \ Red Value These bits define the red value for the A4 or A8 mode of the background. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.


\
\ @brief DMA2D foreground CLUT memory address register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant DMA2D_FGCMAR_MA                                  \ Memory Address Address of the data used for the CLUT address dedicated to the foreground image. This register can only be written when no transfer is ongoing. Once the CLUT transfer has started, this register is read-only. If the foreground CLUT format is 32-bit, the address must be 32-bit aligned.


\
\ @brief DMA2D background CLUT memory address register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant DMA2D_BGCMAR_MA                                  \ Memory address Address of the data used for the CLUT address dedicated to the background image. This register can only be written when no transfer is on going. Once the CLUT transfer has started, this register is read-only. If the background CLUT format is 32-bit, the address must be 32-bit aligned.


\
\ @brief DMA2D output PFC control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000007 constant DMA2D_OPFCCR_CM                                  \ Color mode These bits define the color format of the output image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only. others: meaningless
$00100000 constant DMA2D_OPFCCR_AI                                  \ Alpha Inverted This bit inverts the alpha value. Once the transfer has started, this bit is read-only.
$00200000 constant DMA2D_OPFCCR_RBS                                 \ Red Blue Swap This bit allows to swap the R &amp; B to support BGR or ABGR color formats. Once the transfer has started, this bit is read-only.


\
\ @brief DMA2D output color register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_OCOLR_BLUE                                 \ Blue Value These bits define the blue value of the output image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
$0000ff00 constant DMA2D_OCOLR_GREEN                                \ Green Value These bits define the green value of the output image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
$00ff0000 constant DMA2D_OCOLR_RED                                  \ Red Value These bits define the red value of the output image. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
$ff000000 constant DMA2D_OCOLR_ALPHA                                \ Alpha Channel Value These bits define the alpha channel of the output color. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.


\
\ @brief DMA2D output memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant DMA2D_OMAR_MA                                    \ Memory Address Address of the data used for the output FIFO. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only. The address alignment must match the image format selected e.g. a 32-bit per pixel format must be 32-bit aligned and a 16-bit per pixel format must be 16-bit aligned.


\
\ @brief DMA2D output offset register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00003fff constant DMA2D_OOR_LO                                     \ Line Offset Line offset used for the output (expressed in pixels). This value is used for the address generation. It is added at the end of each line to determine the starting address of the next line. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.


\
\ @brief DMA2D number of line register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant DMA2D_NLR_NL                                     \ Number of lines Number of lines of the area to be transferred. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.
$3fff0000 constant DMA2D_NLR_PL                                     \ Pixel per lines Number of pixels per lines of the area to be transferred. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only. If any of the input image format is 4-bit per pixel, pixel per lines must be even.


\
\ @brief DMA2D line watermark register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant DMA2D_LWR_LW                                     \ Line watermark These bits allow to configure the line watermark for interrupt generation. An interrupt is raised when the last pixel of the watermarked line has been transferred. These bits can only be written when data transfers are disabled. Once the transfer has started, they are read-only.


\
\ @brief DMA2D AXI master timer configuration register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant DMA2D_AMTCR_EN                                   \ Enable Enables the dead time functionality.
$0000ff00 constant DMA2D_AMTCR_DT                                   \ Dead Time Dead time value in the AXI clock cycle inserted between two consecutive accesses on the AXI master port. These bits represent the minimum guaranteed number of cycles between two consecutive AXI accesses.


\
\ @brief DMA2D
\
$52001000 constant DMA2D_CR       \ offset: 0x00 : DMA2D control register
$52001004 constant DMA2D_ISR      \ offset: 0x04 : DMA2D Interrupt Status Register
$52001008 constant DMA2D_IFCR     \ offset: 0x08 : DMA2D interrupt flag clear register
$5200100c constant DMA2D_FGMAR    \ offset: 0x0C : DMA2D foreground memory address register
$52001010 constant DMA2D_FGOR     \ offset: 0x10 : DMA2D foreground offset register
$52001014 constant DMA2D_BGMAR    \ offset: 0x14 : DMA2D background memory address register
$52001018 constant DMA2D_BGOR     \ offset: 0x18 : DMA2D background offset register
$5200101c constant DMA2D_FGPFCCR  \ offset: 0x1C : DMA2D foreground PFC control register
$52001020 constant DMA2D_FGCOLR   \ offset: 0x20 : DMA2D foreground color register
$52001024 constant DMA2D_BGPFCCR  \ offset: 0x24 : DMA2D background PFC control register
$52001028 constant DMA2D_BGCOLR   \ offset: 0x28 : DMA2D background color register
$5200102c constant DMA2D_FGCMAR   \ offset: 0x2C : DMA2D foreground CLUT memory address register
$52001030 constant DMA2D_BGCMAR   \ offset: 0x30 : DMA2D background CLUT memory address register
$52001034 constant DMA2D_OPFCCR   \ offset: 0x34 : DMA2D output PFC control register
$52001038 constant DMA2D_OCOLR    \ offset: 0x38 : DMA2D output color register
$5200103c constant DMA2D_OMAR     \ offset: 0x3C : DMA2D output memory address register
$52001040 constant DMA2D_OOR      \ offset: 0x40 : DMA2D output offset register
$52001044 constant DMA2D_NLR      \ offset: 0x44 : DMA2D number of line register
$52001048 constant DMA2D_LWR      \ offset: 0x48 : DMA2D line watermark register
$5200104c constant DMA2D_AMTCR    \ offset: 0x4C : DMA2D AXI master timer configuration register

