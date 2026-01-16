\
\ @file ltdc.fs
\ @brief LTDC register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LTDC identification register
\ Address offset: 0x00
\ Reset value: 0x00040100
\

$000000ff constant LTDC_LTDC_IDR_REV                                \ revision
$0000ff00 constant LTDC_LTDC_IDR_MINVER                             \ minor version
$00ff0000 constant LTDC_LTDC_IDR_MAJVER                             \ major version


\
\ @brief LDTC layer count register
\ Address offset: 0x04
\ Reset value: 0x00000002
\

$000000ff constant LTDC_LTDC_LCR_LNBR                               \ number of layers


\
\ @brief LTDC synchronization size configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_SSCR_VSH                               \ vertical synchronization height (in units of horizontal scan line) This field defines the vertical synchronization height minus 1. It represents the number of horizontal synchronization lines.
$ffff0000 constant LTDC_LTDC_SSCR_HSW                               \ horizontal synchronization width (in units of pixel clock period) This field defines the number of horizontal synchronization pixel minus 1.


\
\ @brief LTDC back porch configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_BPCR_AVBP                              \ accumulated Vertical back porch (in units of horizontal scan line) This field defines the accumulated vertical back porch width that includes the vertical synchronization and vertical back porch lines minus 1. The vertical back porch is the number of horizontal scan lines at a start of frame to the start of the first active scan line of the next frame.
$ffff0000 constant LTDC_LTDC_BPCR_AHBP                              \ accumulated horizontal back porch (in units of pixel clock period) This field defines the accumulated horizontal back porch width that includes the horizontal synchronization and horizontal back porch pixels minus 1. The horizontal back porch is the period between horizontal synchronization going inactive and the start of the active display part of the next scan line.


\
\ @brief LTDC active width configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_AWCR_AAH                               \ accumulated active height (in units of horizontal scan line) This field defines the accumulated height that includes the vertical synchronization, vertical back porch and the active height lines minus 1. The active height is the number of active lines in the panel. Refer to device datasheet for maximum active height supported following maximum pixel clock.
$ffff0000 constant LTDC_LTDC_AWCR_AAW                               \ accumulated active width (in units of pixel clock period) This field defines the accumulated active width that includes the horizontal synchronization, horizontal back porch and active pixels minus 1. The active width is the number of pixels in active display area of the panel scan line. Refer to device datasheet for maximum active width supported following maximum pixel clock.


\
\ @brief LTDC total width configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_TWCR_TOTALH                            \ total height (in units of horizontal scan line) This field defines the accumulated height that includes the vertical synchronization, vertical back porch, the active height and vertical front porch height lines minus 1.
$ffff0000 constant LTDC_LTDC_TWCR_TOTALW                            \ total width (in units of pixel clock period) This field defines the accumulated total width that includes the horizontal synchronization, horizontal back porch, active width and horizontal front porch pixels minus 1.


\
\ @brief LTDC global control register
\ Address offset: 0x18
\ Reset value: 0x00002220
\

$00000001 constant LTDC_LTDC_GCR_LTDCEN                             \ LTDC global enable This bit is set and cleared by software.
$00000002 constant LTDC_LTDC_GCR_GAMEN                              \ Gamma correction enable This bit is set and cleared by software.
$00000070 constant LTDC_LTDC_GCR_DBW                                \ dither blue width This field returns the dither blue bits.
$00000700 constant LTDC_LTDC_GCR_DGW                                \ dither green width This field returns the dither green bits.
$00007000 constant LTDC_LTDC_GCR_DRW                                \ dither red width This field returns the dither red bits.
$00010000 constant LTDC_LTDC_GCR_DEN                                \ dither enable This bit is set and cleared by software.
$00080000 constant LTDC_LTDC_GCR_CRCEN                              \ CRC enable This bit is set and cleared by software.
$01000000 constant LTDC_LTDC_GCR_SFEN                               \ single-frame mode: mode enable This bit is set and cleared by software.
$02000000 constant LTDC_LTDC_GCR_SFSWTR                             \ single-frame mode: software trigger This bit is set by software and cleared by hardware.
$10000000 constant LTDC_LTDC_GCR_PCPOL                              \ pixel clock polarity This bit is set and cleared by software.
$20000000 constant LTDC_LTDC_GCR_DEPOL                              \ blanking (no data/pixel) polarity This bit is set and cleared by software.
$40000000 constant LTDC_LTDC_GCR_VSPOL                              \ vertical synchronization polarity This bit is set and cleared by software.
$80000000 constant LTDC_LTDC_GCR_HSPOL                              \ horizontal synchronization polarity This bit is set and cleared by software.


\
\ @brief LTDC global configuration 1 register
\ Address offset: 0x1C
\ Reset value: 0x6BE4D888
\

$0000000f constant LTDC_LTDC_GC1R_WBCH                              \ width of blue channel output
$000000f0 constant LTDC_LTDC_GC1R_WGCH                              \ width of green channel output
$00000f00 constant LTDC_LTDC_GC1R_WRCH                              \ width of red channel output
$00001000 constant LTDC_LTDC_GC1R_PRBA                              \ precise blending ability
$0000c000 constant LTDC_LTDC_GC1R_DT                                \ dithering technique implemented 1.: ordered 4x4 custom
$000e0000 constant LTDC_LTDC_GC1R_GCT                               \ gamma correction technique implemented others: reserved
$00200000 constant LTDC_LTDC_GC1R_SHRA                              \ shadow registers ability
$00400000 constant LTDC_LTDC_GC1R_BCP                               \ background color programmability (unique color blended as background)
$00800000 constant LTDC_LTDC_GC1R_BBA                               \ background blending ability
$01000000 constant LTDC_LTDC_GC1R_LNIP                              \ line-IRQ: line position programmability
$02000000 constant LTDC_LTDC_GC1R_TP                                \ timing programmability
$08000000 constant LTDC_LTDC_GC1R_SPP                               \ sync polarity programmability
$10000000 constant LTDC_LTDC_GC1R_DWP                               \ dither width programmability
$20000000 constant LTDC_LTDC_GC1R_STRA                              \ status register ability
$40000000 constant LTDC_LTDC_GC1R_CRMA                              \ configuration reading mode ability
$80000000 constant LTDC_LTDC_GC1R_BMA                               \ blind mode ability


\
\ @brief LTDC global configuration 2 register
\ Address offset: 0x20
\ Reset value: 0x0000BB30
\

$00000001 constant LTDC_LTDC_GC2R_BLA                               \ background layer ability (pixels of background layer are read from memory)
$00000002 constant LTDC_LTDC_GC2R_STSA                              \ slave timings synchronization ability
$00000004 constant LTDC_LTDC_GC2R_DVA                               \ dual-view ability
$00000008 constant LTDC_LTDC_GC2R_DPA                               \ secondary RGB output port ability
$00000070 constant LTDC_LTDC_GC2R_BW                                \ bus width (log2 of number of bytes) others: reserved
$00000080 constant LTDC_LTDC_GC2R_EDCA                              \ external display control ability
$00000100 constant LTDC_LTDC_GC2R_OCA                               \ output conversion ability (RGB to YCbCr)
$00000200 constant LTDC_LTDC_GC2R_AXIIDA                            \ AXIID ability
$00000400 constant LTDC_LTDC_GC2R_ROTA                              \ rotation support ability
$00000800 constant LTDC_LTDC_GC2R_SISA                              \ second interrupt set ability
$00001000 constant LTDC_LTDC_GC2R_SFA                               \ single frame mode ability
$00002000 constant LTDC_LTDC_GC2R_CRCA                              \ CRC ability
$00008000 constant LTDC_LTDC_GC2R_BOA                               \ blending order ability


\
\ @brief LTDC shadow reload configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_SRCR_IMR                               \ immediate reload trigger This bit is set by software and cleared only by hardware after reload.
$00000002 constant LTDC_LTDC_SRCR_VBR                               \ vertical blanking reload request This bit is set by software and cleared only by hardware after reload (it cannot be cleared through register write once it is set).


\
\ @brief LTDC gamma correction configuration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_GCCR_ADDR                              \ address of the R,G,B table where the COMP component is written When LTDC_GC1R.GCT=2, the gamma is implemented with eight interpolated segment. In that case, the valid ADDR addresses are: 0, 32, 64, 96, 128, 160, 192, 224, 255. Note: For ADDR = 255, the gamma interpolation hardware considers that the address is 256.
$0000ff00 constant LTDC_LTDC_GCCR_COMP                              \ color component to be written, in either (or all) the R,G,B tables
$00010000 constant LTDC_LTDC_GCCR_BEN                               \ write trigger to the blue table
$00020000 constant LTDC_LTDC_GCCR_GEN                               \ write trigger to the green table
$00040000 constant LTDC_LTDC_GCCR_REN                               \ write trigger to the red table


\
\ @brief LTDC background color configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_BCCR_BCBLUE                            \ background color blue value This field configures the background blue value.
$0000ff00 constant LTDC_LTDC_BCCR_BCGREEN                           \ background color green value This field configures the background green value.
$00ff0000 constant LTDC_LTDC_BCCR_BCRED                             \ background color red value This field configures the background red value.


\
\ @brief LTDC interrupt enable register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_IER_LIE                                \ Line interrupt enable This bit is set and cleared by software.
$00000002 constant LTDC_LTDC_IER_FUWIE                              \ FIFO underrun warning interrupt enable This bit is set and cleared by software.
$00000004 constant LTDC_LTDC_IER_TERRIE                             \ Transfer Error interrupt enable This bit is set and cleared by software.
$00000008 constant LTDC_LTDC_IER_RRIE                               \ Register reload interrupt enable This bit is set and cleared by software.
$00000040 constant LTDC_LTDC_IER_FUIE                               \ FIFO underrun interrupt enable This bit is set and cleared by software.
$00000080 constant LTDC_LTDC_IER_CRCIE                              \ CRC error interrupt enable This bit is set and cleared by software.


\
\ @brief LTDC interrupt status register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_ISR_LIF                                \ Line interrupt flag
$00000002 constant LTDC_LTDC_ISR_FUWIF                              \ FIFO underrun warning interrupt flag
$00000004 constant LTDC_LTDC_ISR_TERRIF                             \ Transfer error interrupt flag
$00000008 constant LTDC_LTDC_ISR_RRIF                               \ Register reload interrupt flag
$00000040 constant LTDC_LTDC_ISR_FUIF                               \ FIFO underrun interrupt flag
$00000080 constant LTDC_LTDC_ISR_CRCIF                              \ CRC error interrupt flag


\
\ @brief LTDC interrupt clear register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_ICR_CLIF                               \ clears the line interrupt flag
$00000002 constant LTDC_LTDC_ICR_CFUWIF                             \ clears the FIFO underrun warning interrupt flag
$00000004 constant LTDC_LTDC_ICR_CTERRIF                            \ clears the transfer error interrupt flag
$00000008 constant LTDC_LTDC_ICR_CRRIF                              \ clears register reload interrupt flag
$00000040 constant LTDC_LTDC_ICR_CFUIF                              \ clears the FIFO underrun interrupt flag
$00000080 constant LTDC_LTDC_ICR_CCRCIF                             \ clears the CRC error interrupt flag


\
\ @brief LTDC line interrupt position configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_LIPCR_LIPOS                            \ line interrupt position This field configures the line interrupt position.


\
\ @brief LTDC current position status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_CPSR_CYPOS                             \ current Y position This field returns the current Y position.
$ffff0000 constant LTDC_LTDC_CPSR_CXPOS                             \ current X position This field returns the current X position.


\
\ @brief LTDC current display status register
\ Address offset: 0x48
\ Reset value: 0x00000003
\

$00000001 constant LTDC_LTDC_CDSR_VDES                              \ vertical data enable display status
$00000002 constant LTDC_LTDC_CDSR_HDES                              \ horizontal data enable display status
$00000004 constant LTDC_LTDC_CDSR_VSYNCS                            \ vertical synchronization display status
$00000008 constant LTDC_LTDC_CDSR_HSYNCS                            \ horizontal synchronization display status


\
\ @brief LTDC external display control register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$02000000 constant LTDC_LTDC_EDCR_OCYEN                             \ output conversion to YCbCr 422 enable
$04000000 constant LTDC_LTDC_EDCR_OCYSEL                            \ output conversion to YCbCr 422 This bit selects the set of CCIR hard-wired coefficients (ITU-R BT.601 or 709).
$08000000 constant LTDC_LTDC_EDCR_OCYCO                             \ output conversion to YCbCr 422 This bit defines the chrominance order (whether Cb or Cr is output first).


\
\ @brief LTDC interrupt enable register 2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_IER2_LIE                               \ Line interrupt enable This bit is set and cleared by software.
$00000002 constant LTDC_LTDC_IER2_FUWIE                             \ FIFO underrun warning interrupt enable This bit is set and cleared by software.
$00000004 constant LTDC_LTDC_IER2_TERRIE                            \ Transfer error interrupt enable This bit is set and cleared by software.
$00000008 constant LTDC_LTDC_IER2_RRIE                              \ Register reload interrupt enable This bit is set and cleared by software.
$00000040 constant LTDC_LTDC_IER2_FUIE                              \ FIFO underrun interrupt enable This bit is set and cleared by software.
$00000080 constant LTDC_LTDC_IER2_CRCIE                             \ CRC error interrupt enable This bit is set and cleared by software.


\
\ @brief LTDC interrupt status register 2
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_ISR2_LIF                               \ Line interrupt flag
$00000002 constant LTDC_LTDC_ISR2_FUWIF                             \ FIFO underrun warning interrupt flag
$00000004 constant LTDC_LTDC_ISR2_TERRIF                            \ Transfer error interrupt flag
$00000008 constant LTDC_LTDC_ISR2_RRIF                              \ Register reload interrupt flag
$00000040 constant LTDC_LTDC_ISR2_FUIF                              \ FIFO underrun interrupt flag
$00000080 constant LTDC_LTDC_ISR2_CRCIF                             \ CRC Error interrupt flag


\
\ @brief LTDC interrupt clear register 2
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_ICR2_CLIF                              \ clears the Line interrupt flag
$00000002 constant LTDC_LTDC_ICR2_CFUWIF                            \ clears the FIFO underrun warning interrupt flag
$00000004 constant LTDC_LTDC_ICR2_CTERRIF                           \ clears the Transfer Error interrupt flag
$00000008 constant LTDC_LTDC_ICR2_CRRIF                             \ clears register reload interrupt flag
$00000040 constant LTDC_LTDC_ICR2_CFUIF                             \ clears the FIFO underrun interrupt flag
$00000080 constant LTDC_LTDC_ICR2_CCRCIF                            \ clears the CRC error interrupt flag


\
\ @brief LTDC line interrupt position configuration register 2
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_LIPCR2_LIPOS                           \ line interrupt position This field configures the line interrupt position.


\
\ @brief LTDC expected CRC register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_ECRCR_ECRC                             \ expected CRC of frame


\
\ @brief LTDC computed CRC register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_CCRCR_CCRC                             \ computed CRC of frame


\
\ @brief LTDC FIFO underrun threshold register
\ Address offset: 0x90
\ Reset value: 0x00000010
\

$0000ffff constant LTDC_LTDC_FUTR_THRE                              \ threshold to trigger a FIFO underrun interrupt (per FIFO word, 64 bits) Threshold above which a FIFO underrun warning becomes a FIFO underrun error.


\
\ @brief LTDC Layerx configuration 0 register
\ Address offset: 0x100
\ Reset value: 0xFF50A076
\

$00000001 constant LTDC_LTDC_L1C0R_CKTA                             \ color key transparency ability
$00000002 constant LTDC_LTDC_L1C0R_CFBDA                            \ color frame buffer duplication ability
$00000004 constant LTDC_LTDC_L1C0R_CFBPA                            \ color frame buffer pitch ability
$00000008 constant LTDC_LTDC_L1C0R_APA                              \ alpha plane ability
$00000010 constant LTDC_LTDC_L1C0R_DCP                              \ default color programmability
$00000020 constant LTDC_LTDC_L1C0R_WINA                             \ windowing ability
$00000040 constant LTDC_LTDC_L1C0R_CLUTA                            \ CLUT ability
$00000080 constant LTDC_LTDC_L1C0R_CKRA                             \ color key replace ability
$00000100 constant LTDC_LTDC_L1C0R_F21                              \ blending factor 2, ability for: 1.0
$00000200 constant LTDC_LTDC_L1C0R_F20                              \ blending factor 2, ability for: 0.0
$00000400 constant LTDC_LTDC_L1C0R_F2P                              \ blending factor 2, ability for: pixel_alpha
$00000800 constant LTDC_LTDC_L1C0R_F21P                             \ blending factor 2, ability for: 1.0 - pixel_alpha
$00001000 constant LTDC_LTDC_L1C0R_F2C                              \ blending factor 2, ability for: constant_alpha
$00002000 constant LTDC_LTDC_L1C0R_F21C                             \ blending factor 2, ability for: 1.0 - constant_alpha
$00004000 constant LTDC_LTDC_L1C0R_F2PC                             \ blending factor 2, ability for: pixel_alpha * constant_alpha
$00008000 constant LTDC_LTDC_L1C0R_F21PC                            \ blending factor 2, ability for: 1.0 - (pixel_alpha * constant_alpha)
$00010000 constant LTDC_LTDC_L1C0R_F11                              \ blending factor 1, ability for: 1.0
$00020000 constant LTDC_LTDC_L1C0R_F10                              \ blending factor 1,ability for: 0.0
$00040000 constant LTDC_LTDC_L1C0R_F1P                              \ blending factor 1, ability for: pixel_alpha
$00080000 constant LTDC_LTDC_L1C0R_F11P                             \ blending factor 1, ability for: 1.0 - pixel_alpha
$00100000 constant LTDC_LTDC_L1C0R_F1C                              \ blending factor 1, ability for: constant_alpha
$00200000 constant LTDC_LTDC_L1C0R_F11C                             \ blending factor 1, ability for: 1.0 - constant_alpha
$00400000 constant LTDC_LTDC_L1C0R_F1PC                             \ blending factor 1, ability for: pixel_alpha * constant_alpha
$00800000 constant LTDC_LTDC_L1C0R_F11PC                            \ blending factor 1, ability for: 1.0 - (pixel_alpha * constant_alpha)
$01000000 constant LTDC_LTDC_L1C0R_FF                               \ flexible pixel format, ability
$02000000 constant LTDC_LTDC_L1C0R_RGB888                           \ pixel format, ability for rgb888
$04000000 constant LTDC_LTDC_L1C0R_BGR565                           \ pixel format, ability for bgr565
$08000000 constant LTDC_LTDC_L1C0R_RGB565                           \ pixel format, ability for rgb565
$10000000 constant LTDC_LTDC_L1C0R_BGRA888                          \ pixel format, ability for bgra8888
$20000000 constant LTDC_LTDC_L1C0R_RGBA8888                         \ pixel format, ability for rgba8888
$40000000 constant LTDC_LTDC_L1C0R_ABGR8888                         \ pixel format, ability for abgr8888
$80000000 constant LTDC_LTDC_L1C0R_ARGB8888                         \ pixel format, ability for argb8888


\
\ @brief LTDC Layerx configuration 1 register
\ Address offset: 0x104
\ Reset value: 0x80000007
\

$00000001 constant LTDC_LTDC_L1C1R_YIA                              \ YCbCr 422 interleaved ability for that layer
$00000002 constant LTDC_LTDC_L1C1R_YSPA                             \ YCbCr 420 semi-planar ability for that layer
$00000004 constant LTDC_LTDC_L1C1R_YFPA                             \ YCbCr 420 full-planar ability for that layer
$80000000 constant LTDC_LTDC_L1C1R_SCA                              \ scaling ability for that layer


\
\ @brief LTDC Layerx reload control register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_L1RCR_IMR                              \ immediate reload trigger This bit is set by software and cleared only by hardware after reload.
$00000002 constant LTDC_LTDC_L1RCR_VBR                              \ vertical blanking reload request This bit is set by software and cleared only by hardware after reload (it cannot be cleared through register write once it is set).
$00000004 constant LTDC_LTDC_L1RCR_GRMSK                            \ shadow reload control, global (centralized) reload masked This bit is set and cleared by software.


\
\ @brief LTDC Layerx control register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_L1CR_LEN                               \ layer enable: the bit is used to enable/disable the presence of this whole layer. This bit is set and cleared by software.
$00000002 constant LTDC_LTDC_L1CR_CKEN                              \ color keying enable This bit is set and cleared by software.
$00000010 constant LTDC_LTDC_L1CR_CLUTEN                            \ color look-up table enable This bit is set and cleared by software. The CLUT is only meaningful for L8, AL44 and AL88 pixel format.
$00000100 constant LTDC_LTDC_L1CR_HMEN                              \ horizontal mirroring enable This bit is set and cleared by software.
$00000200 constant LTDC_LTDC_L1CR_DCBEN                             \ default color blending enable This bit is set and cleared by software.


\
\ @brief LTDC Layerx window horizontal position configuration register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_L1WHPCR_WHSTPOS                        \ window horizontal start position This field configures the first visible pixel of a line of the layer window. WHSTPOS[15:0] must be ≤ AAW[15:0] bits (programmed in LTDC_AWCR).
$ffff0000 constant LTDC_LTDC_L1WHPCR_WHSPPOS                        \ window horizontal stop position This field configures the last visible pixel of a line of the layer window. WHSPPOS[15:0] must be ≥ AHBP[15:0] bits + 1 (programmed in LTDC_BPCR).


\
\ @brief LTDC Layerx window vertical position configuration register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_L1WVPCR_WVSTPOS                        \ window vertical start position This field configures the first visible line of the layer window. WVSTPOS[15:0] must be ≤ AAH[15:0] bits (programmed in LTDC_AWCR).
$ffff0000 constant LTDC_LTDC_L1WVPCR_WVSPPOS                        \ window vertical stop position This field configures the last visible line of the layer window. WVSPPOS[11:0] must be ≥ AVBP[15:0] bits + 1 (programmed in LTDC_BPCR).


\
\ @brief LTDC Layerx color keying configuration register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L1CKCR_CKBLUE                          \ color key blue value
$0000ff00 constant LTDC_LTDC_L1CKCR_CKGREEN                         \ color key green value
$00ff0000 constant LTDC_LTDC_L1CKCR_CKRED                           \ color key red value


\
\ @brief LTDC Layerx pixel format configuration register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000007 constant LTDC_LTDC_L1PFCR_PF                              \ pixel format This field configures the pixel format.


\
\ @brief LTDC Layerx constant alpha configuration register
\ Address offset: 0x120
\ Reset value: 0x000000FF
\

$000000ff constant LTDC_LTDC_L1CACR_CONSTA                          \ constant alpha This field configures the constant alpha used for blending. The constant alpha is divided by 255 by hardware. Example: if the programmed constant alpha is 0xFF, the floating alpha value is 255 / 255 = 1.


\
\ @brief LTDC Layerx default color configuration register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L1DCCR_DCBLUE                          \ default color blue This field configures the default blue value.
$0000ff00 constant LTDC_LTDC_L1DCCR_DCGREEN                         \ default color green This field configures the default green value.
$00ff0000 constant LTDC_LTDC_L1DCCR_DCRED                           \ default color red This field configures the default red value.
$ff000000 constant LTDC_LTDC_L1DCCR_DCALPHA                         \ default color alpha This field configures the default alpha value.


\
\ @brief LTDC Layerx blending factors configuration register
\ Address offset: 0x128
\ Reset value: 0x00000607
\

$00000007 constant LTDC_LTDC_L1BFCR_BF2                             \ blending factor 2 This field selects the blending factor F2 others: reserved
$00000700 constant LTDC_LTDC_L1BFCR_BF1                             \ blending factor 1 This field selects the blending factor F1. others: reserved
$00010000 constant LTDC_LTDC_L1BFCR_BOR                             \ blending order This bit defines the blending order of the layer. If two layers have the same BOR value, the layer with the highest index is on the foreground.


\
\ @brief LTDC Layerx burst length configuration register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L1BLCR_BL                              \ burst length others: reserved


\
\ @brief LTDC Layerx planar configuration register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000008 constant LTDC_LTDC_L1PCR_YCEN                             \ YCbCr-to-RGB conversion enable
$00000030 constant LTDC_LTDC_L1PCR_YCM                              \ YCbCr conversion mode Defines the type of input that is considered and converted to a YCbCr 444.
$00000040 constant LTDC_LTDC_L1PCR_YF                               \ Y component first Defines if the byte 0 of a word (in LSB) contains the Y component.
$00000080 constant LTDC_LTDC_L1PCR_CBF                              \ Cb component first Defines if the byte 0 and 1 of a word (in LSB) contains the Cb component. The setting impacts only for interleaved and semi-planar modes, as it has no meaning in full-planar mode.
$00000100 constant LTDC_LTDC_L1PCR_OF                               \ Odd pixel first Defines if the byte 0 of a word (in LSB) contains the odd pixel.
$00000200 constant LTDC_LTDC_L1PCR_YREN                             \ Y rescale enable for the color dynamic range When enabled, incoming Y values in range 16 to 235, are re-scaled to range 0 to 255.


\
\ @brief LTDC Layerx color frame buffer address register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant LTDC_LTDC_L1CFBAR_CFBADD                         \ color frame buffer start address This field defines the color frame buffer start address.


\
\ @brief LTDC Layerx color frame buffer length register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_L1CFBLR_CFBLL                          \ color frame buffer line length This field defines the length of one line of pixels in bytes + 7. The line length is computed as follows: active high width * number of bytes per pixel + 7.
$ffff0000 constant LTDC_LTDC_L1CFBLR_CFBP                           \ color frame buffer pitch in bytes This field defines the pitch that is the increment from the start of one line of pixels to the start of the next line in bytes. Negative values (with MSB bit = 1) are allowed, to read the buffer from bottom to top, and thus to flip is vertically. When vertically flipped, as the address register must provide the address of the first line to be read, the address register must point to the start of the bottom line of the buffer.


\
\ @brief LTDC Layerx color frame buffer line number register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_L1CFBLNR_CFBLNBR                       \ frame buffer line number This field defines the number of lines in the frame buffer that corresponds to the active high width.


\
\ @brief LTDC Layer1 auxiliary frame buffer address 0 register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant LTDC_LTDC_L1AFBA0R_AFBADD0                       \ frame buffer start address This field defines the color frame buffer start address.


\
\ @brief LTDC Layer1 auxiliary frame buffer address 1 register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant LTDC_LTDC_L1AFBA1R_AFBADD1                       \ auxiliary frame buffer start address This field defines the color frame buffer start address.


\
\ @brief LTDC Layer1 auxiliary frame buffer length register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_L1AFBLR_AFBLL                          \ auxiliary frame buffer line length This field defines the length of one line of pixels in bytes + 7. The line length is computed as follows: active high width * number of bytes per pixel + 7.
$ffff0000 constant LTDC_LTDC_L1AFBLR_AFBP                           \ auxiliary frame buffer pitch in bytes This field defines the pitch that is the increment from the start of one line of pixels to the start of the next line in bytes. Negative values (with MSB bit = 1) are allowed, to read the buffer from bottom to top, and thus to flip is vertically. When vertically flipped, as the address register must provide the address of the first line to be read, the address register must point to the start of the bottom line of the buffer.


\
\ @brief LTDC Layer1 auxiliary frame buffer line number register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_L1AFBLNR_AFBLNBR                       \ auxiliary frame buffer line number This field defines the number of lines in the auxiliary frame buffer that corresponds to the active high width.


\
\ @brief LTDC Layerx CLUT write register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L1CLUTWR_BLUE                          \ blue value This field configures the blue value.
$0000ff00 constant LTDC_LTDC_L1CLUTWR_GREEN                         \ green value This field configures the green value.
$00ff0000 constant LTDC_LTDC_L1CLUTWR_RED                           \ red value This field configures the red value.
$ff000000 constant LTDC_LTDC_L1CLUTWR_CLUTADD                       \ CLUT address This field configures the CLUT address (color position within the CLUT) of each RGB value.


\
\ @brief LTDC Layerx conversion YCbCr RGB 0 register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$000003ff constant LTDC_LTDC_L1CYR0R_CR2R                           \ Cr-to-Red coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
$03ff0000 constant LTDC_LTDC_L1CYR0R_CB2B                           \ Cb-to-Blue coefficient, with bits 9:8 as positive integer and 7:0 as decimals.


\
\ @brief LTDC Layerx conversion YCbCr RGB 1 register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$000003ff constant LTDC_LTDC_L1CYR1R_CR2G                           \ Cr-to-Green coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
$03ff0000 constant LTDC_LTDC_L1CYR1R_CB2G                           \ Cb-to-Green coefficient, with bits 9:8 as positive integer and 7:0 as decimals.


\
\ @brief LTDC Layerx flexible pixel format 0 register
\ Address offset: 0x174
\ Reset value: 0x00011100
\

$0000001f constant LTDC_LTDC_L1FPF0R_APOS                           \ Location of the Alpha component inside the pixel memory word (in bits)
$000001e0 constant LTDC_LTDC_L1FPF0R_ALEN                           \ Width of the Alpha component (in bits)
$00003e00 constant LTDC_LTDC_L1FPF0R_RPOS                           \ Location of the Red component inside the pixel memory word (in bits)
$0003c000 constant LTDC_LTDC_L1FPF0R_RLEN                           \ Width of the Red component (in bits)


\
\ @brief LTDC Layerx flexible pixel format 1 register
\ Address offset: 0x178
\ Reset value: 0x00093110
\

$0000001f constant LTDC_LTDC_L1FPF1R_GPOS                           \ Location of the Green Component inside the Pixel Memory Word (in bits).
$000001e0 constant LTDC_LTDC_L1FPF1R_GLEN                           \ Width of the Green Component (in bits).
$00003e00 constant LTDC_LTDC_L1FPF1R_BPOS                           \ Location of the Blue Component inside the Pixel Memory Word (in bits).
$0003c000 constant LTDC_LTDC_L1FPF1R_BLEN                           \ Width of the Blue Component (in bits).
$001c0000 constant LTDC_LTDC_L1FPF1R_PSIZE                          \ Pixel Size (in Bytes).


\
\ @brief LTDC Layerx configuration 0 register
\ Address offset: 0x200
\ Reset value: 0xFF50A076
\

$00000001 constant LTDC_LTDC_L2C0R_CKTA                             \ color key transparency ability
$00000002 constant LTDC_LTDC_L2C0R_CFBDA                            \ color frame buffer duplication ability
$00000004 constant LTDC_LTDC_L2C0R_CFBPA                            \ color frame buffer pitch ability
$00000008 constant LTDC_LTDC_L2C0R_APA                              \ alpha plane ability
$00000010 constant LTDC_LTDC_L2C0R_DCP                              \ default color programmability
$00000020 constant LTDC_LTDC_L2C0R_WINA                             \ windowing ability
$00000040 constant LTDC_LTDC_L2C0R_CLUTA                            \ CLUT ability
$00000080 constant LTDC_LTDC_L2C0R_CKRA                             \ color key replace ability
$00000100 constant LTDC_LTDC_L2C0R_F21                              \ blending factor 2, ability for: 1.0
$00000200 constant LTDC_LTDC_L2C0R_F20                              \ blending factor 2, ability for: 0.0
$00000400 constant LTDC_LTDC_L2C0R_F2P                              \ blending factor 2, ability for: pixel_alpha
$00000800 constant LTDC_LTDC_L2C0R_F21P                             \ blending factor 2, ability for: 1.0 - pixel_alpha
$00001000 constant LTDC_LTDC_L2C0R_F2C                              \ blending factor 2, ability for: constant_alpha
$00002000 constant LTDC_LTDC_L2C0R_F21C                             \ blending factor 2, ability for: 1.0 - constant_alpha
$00004000 constant LTDC_LTDC_L2C0R_F2PC                             \ blending factor 2, ability for: pixel_alpha * constant_alpha
$00008000 constant LTDC_LTDC_L2C0R_F21PC                            \ blending factor 2, ability for: 1.0 - (pixel_alpha * constant_alpha)
$00010000 constant LTDC_LTDC_L2C0R_F11                              \ blending factor 1, ability for: 1.0
$00020000 constant LTDC_LTDC_L2C0R_F10                              \ blending factor 1,ability for: 0.0
$00040000 constant LTDC_LTDC_L2C0R_F1P                              \ blending factor 1, ability for: pixel_alpha
$00080000 constant LTDC_LTDC_L2C0R_F11P                             \ blending factor 1, ability for: 1.0 - pixel_alpha
$00100000 constant LTDC_LTDC_L2C0R_F1C                              \ blending factor 1, ability for: constant_alpha
$00200000 constant LTDC_LTDC_L2C0R_F11C                             \ blending factor 1, ability for: 1.0 - constant_alpha
$00400000 constant LTDC_LTDC_L2C0R_F1PC                             \ blending factor 1, ability for: pixel_alpha * constant_alpha
$00800000 constant LTDC_LTDC_L2C0R_F11PC                            \ blending factor 1, ability for: 1.0 - (pixel_alpha * constant_alpha)
$01000000 constant LTDC_LTDC_L2C0R_FF                               \ flexible pixel format, ability
$02000000 constant LTDC_LTDC_L2C0R_RGB888                           \ pixel format, ability for rgb888
$04000000 constant LTDC_LTDC_L2C0R_BGR565                           \ pixel format, ability for bgr565
$08000000 constant LTDC_LTDC_L2C0R_RGB565                           \ pixel format, ability for rgb565
$10000000 constant LTDC_LTDC_L2C0R_BGRA888                          \ pixel format, ability for bgra8888
$20000000 constant LTDC_LTDC_L2C0R_RGBA8888                         \ pixel format, ability for rgba8888
$40000000 constant LTDC_LTDC_L2C0R_ABGR8888                         \ pixel format, ability for abgr8888
$80000000 constant LTDC_LTDC_L2C0R_ARGB8888                         \ pixel format, ability for argb8888


\
\ @brief LTDC Layerx configuration 1 register
\ Address offset: 0x204
\ Reset value: 0x80000007
\

$00000001 constant LTDC_LTDC_L2C1R_YIA                              \ YCbCr 422 interleaved ability for that layer
$00000002 constant LTDC_LTDC_L2C1R_YSPA                             \ YCbCr 420 semi-planar ability for that layer
$00000004 constant LTDC_LTDC_L2C1R_YFPA                             \ YCbCr 420 full-planar ability for that layer
$80000000 constant LTDC_LTDC_L2C1R_SCA                              \ scaling ability for that layer


\
\ @brief LTDC Layerx reload control register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_L2RCR_IMR                              \ immediate reload trigger This bit is set by software and cleared only by hardware after reload.
$00000002 constant LTDC_LTDC_L2RCR_VBR                              \ vertical blanking reload request This bit is set by software and cleared only by hardware after reload (it cannot be cleared through register write once it is set).
$00000004 constant LTDC_LTDC_L2RCR_GRMSK                            \ shadow reload control, global (centralized) reload masked This bit is set and cleared by software.


\
\ @brief LTDC Layerx control register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_L2CR_LEN                               \ layer enable: the bit is used to enable/disable the presence of this whole layer. This bit is set and cleared by software.
$00000002 constant LTDC_LTDC_L2CR_CKEN                              \ color keying enable This bit is set and cleared by software.
$00000010 constant LTDC_LTDC_L2CR_CLUTEN                            \ color look-up table enable This bit is set and cleared by software. The CLUT is only meaningful for L8, AL44 and AL88 pixel format.
$00000100 constant LTDC_LTDC_L2CR_HMEN                              \ horizontal mirroring enable This bit is set and cleared by software.
$00000200 constant LTDC_LTDC_L2CR_DCBEN                             \ default color blending enable This bit is set and cleared by software.


\
\ @brief LTDC Layerx window horizontal position configuration register
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_L2WHPCR_WHSTPOS                        \ window horizontal start position This field configures the first visible pixel of a line of the layer window. WHSTPOS[15:0] must be ≤ AAW[15:0] bits (programmed in LTDC_AWCR).
$ffff0000 constant LTDC_LTDC_L2WHPCR_WHSPPOS                        \ window horizontal stop position This field configures the last visible pixel of a line of the layer window. WHSPPOS[15:0] must be ≥ AHBP[15:0] bits + 1 (programmed in LTDC_BPCR).


\
\ @brief LTDC Layerx window vertical position configuration register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_L2WVPCR_WVSTPOS                        \ window vertical start position This field configures the first visible line of the layer window. WVSTPOS[15:0] must be ≤ AAH[15:0] bits (programmed in LTDC_AWCR).
$ffff0000 constant LTDC_LTDC_L2WVPCR_WVSPPOS                        \ window vertical stop position This field configures the last visible line of the layer window. WVSPPOS[11:0] must be ≥ AVBP[15:0] bits + 1 (programmed in LTDC_BPCR).


\
\ @brief LTDC Layerx color keying configuration register
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L2CKCR_CKBLUE                          \ color key blue value
$0000ff00 constant LTDC_LTDC_L2CKCR_CKGREEN                         \ color key green value
$00ff0000 constant LTDC_LTDC_L2CKCR_CKRED                           \ color key red value


\
\ @brief LTDC Layerx pixel format configuration register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000007 constant LTDC_LTDC_L2PFCR_PF                              \ pixel format This field configures the pixel format.


\
\ @brief LTDC Layerx constant alpha configuration register
\ Address offset: 0x220
\ Reset value: 0x000000FF
\

$000000ff constant LTDC_LTDC_L2CACR_CONSTA                          \ constant alpha This field configures the constant alpha used for blending. The constant alpha is divided by 255 by hardware. Example: if the programmed constant alpha is 0xFF, the floating alpha value is 255 / 255 = 1.


\
\ @brief LTDC Layerx default color configuration register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L2DCCR_DCBLUE                          \ default color blue This field configures the default blue value.
$0000ff00 constant LTDC_LTDC_L2DCCR_DCGREEN                         \ default color green This field configures the default green value.
$00ff0000 constant LTDC_LTDC_L2DCCR_DCRED                           \ default color red This field configures the default red value.
$ff000000 constant LTDC_LTDC_L2DCCR_DCALPHA                         \ default color alpha This field configures the default alpha value.


\
\ @brief LTDC Layerx blending factors configuration register
\ Address offset: 0x228
\ Reset value: 0x00000607
\

$00000007 constant LTDC_LTDC_L2BFCR_BF2                             \ blending factor 2 This field selects the blending factor F2 others: reserved
$00000700 constant LTDC_LTDC_L2BFCR_BF1                             \ blending factor 1 This field selects the blending factor F1. others: reserved
$00010000 constant LTDC_LTDC_L2BFCR_BOR                             \ blending order This bit defines the blending order of the layer. If two layers have the same BOR value, the layer with the highest index is on the foreground.


\
\ @brief LTDC Layerx burst length configuration register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L2BLCR_BL                              \ burst length others: reserved


\
\ @brief LTDC Layerx planar configuration register
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000008 constant LTDC_LTDC_L2PCR_YCEN                             \ YCbCr-to-RGB conversion enable
$00000030 constant LTDC_LTDC_L2PCR_YCM                              \ YCbCr conversion mode Defines the type of input that is considered and converted to a YCbCr 444.
$00000040 constant LTDC_LTDC_L2PCR_YF                               \ Y component first Defines if the byte 0 of a word (in LSB) contains the Y component.
$00000080 constant LTDC_LTDC_L2PCR_CBF                              \ Cb component first Defines if the byte 0 and 1 of a word (in LSB) contains the Cb component. The setting impacts only for interleaved and semi-planar modes, as it has no meaning in full-planar mode.
$00000100 constant LTDC_LTDC_L2PCR_OF                               \ Odd pixel first Defines if the byte 0 of a word (in LSB) contains the odd pixel.
$00000200 constant LTDC_LTDC_L2PCR_YREN                             \ Y rescale enable for the color dynamic range When enabled, incoming Y values in range 16 to 235, are re-scaled to range 0 to 255.


\
\ @brief LTDC Layerx color frame buffer address register
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000000 constant LTDC_LTDC_L2CFBAR_CFBADD                         \ color frame buffer start address This field defines the color frame buffer start address.


\
\ @brief LTDC Layerx color frame buffer length register
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_L2CFBLR_CFBLL                          \ color frame buffer line length This field defines the length of one line of pixels in bytes + 7. The line length is computed as follows: active high width * number of bytes per pixel + 7.
$ffff0000 constant LTDC_LTDC_L2CFBLR_CFBP                           \ color frame buffer pitch in bytes This field defines the pitch that is the increment from the start of one line of pixels to the start of the next line in bytes. Negative values (with MSB bit = 1) are allowed, to read the buffer from bottom to top, and thus to flip is vertically. When vertically flipped, as the address register must provide the address of the first line to be read, the address register must point to the start of the bottom line of the buffer.


\
\ @brief LTDC Layerx color frame buffer line number register
\ Address offset: 0x23C
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_L2CFBLNR_CFBLNBR                       \ frame buffer line number This field defines the number of lines in the frame buffer that corresponds to the active high width.


\
\ @brief LTDC Layerx CLUT write register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L2CLUTWR_BLUE                          \ blue value This field configures the blue value.
$0000ff00 constant LTDC_LTDC_L2CLUTWR_GREEN                         \ green value This field configures the green value.
$00ff0000 constant LTDC_LTDC_L2CLUTWR_RED                           \ red value This field configures the red value.
$ff000000 constant LTDC_LTDC_L2CLUTWR_CLUTADD                       \ CLUT address This field configures the CLUT address (color position within the CLUT) of each RGB value.


\
\ @brief LTDC Layerx conversion YCbCr RGB 0 register
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$000003ff constant LTDC_LTDC_L2CYR0R_CR2R                           \ Cr-to-Red coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
$03ff0000 constant LTDC_LTDC_L2CYR0R_CB2B                           \ Cb-to-Blue coefficient, with bits 9:8 as positive integer and 7:0 as decimals.


\
\ @brief LTDC Layerx conversion YCbCr RGB 1 register
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$000003ff constant LTDC_LTDC_L2CYR1R_CR2G                           \ Cr-to-Green coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
$03ff0000 constant LTDC_LTDC_L2CYR1R_CB2G                           \ Cb-to-Green coefficient, with bits 9:8 as positive integer and 7:0 as decimals.


\
\ @brief LTDC Layerx flexible pixel format 0 register
\ Address offset: 0x274
\ Reset value: 0x00011100
\

$0000001f constant LTDC_LTDC_L2FPF0R_APOS                           \ Location of the Alpha component inside the pixel memory word (in bits)
$000001e0 constant LTDC_LTDC_L2FPF0R_ALEN                           \ Width of the Alpha component (in bits)
$00003e00 constant LTDC_LTDC_L2FPF0R_RPOS                           \ Location of the Red component inside the pixel memory word (in bits)
$0003c000 constant LTDC_LTDC_L2FPF0R_RLEN                           \ Width of the Red component (in bits)


\
\ @brief LTDC Layerx flexible pixel format 1 register
\ Address offset: 0x278
\ Reset value: 0x00093110
\

$0000001f constant LTDC_LTDC_L2FPF1R_GPOS                           \ Location of the Green Component inside the Pixel Memory Word (in bits).
$000001e0 constant LTDC_LTDC_L2FPF1R_GLEN                           \ Width of the Green Component (in bits).
$00003e00 constant LTDC_LTDC_L2FPF1R_BPOS                           \ Location of the Blue Component inside the Pixel Memory Word (in bits).
$0003c000 constant LTDC_LTDC_L2FPF1R_BLEN                           \ Width of the Blue Component (in bits).
$001c0000 constant LTDC_LTDC_L2FPF1R_PSIZE                          \ Pixel Size (in Bytes).


\
\ @brief LTDC Layerx flexible pixel format 1 register
\ Address offset: 0x378
\ Reset value: 0x00093110
\

$0000001f constant LTDC_LTDC_L3FPF1R_GPOS                           \ Location of the Green Component inside the Pixel Memory Word (in bits).
$000001e0 constant LTDC_LTDC_L3FPF1R_GLEN                           \ Width of the Green Component (in bits).
$00003e00 constant LTDC_LTDC_L3FPF1R_BPOS                           \ Location of the Blue Component inside the Pixel Memory Word (in bits).
$0003c000 constant LTDC_LTDC_L3FPF1R_BLEN                           \ Width of the Blue Component (in bits).
$001c0000 constant LTDC_LTDC_L3FPF1R_PSIZE                          \ Pixel Size (in Bytes).


\
\ @brief LTDC register block
\
$5a001000 constant LTDC_LTDC_IDR  \ offset: 0x00 : LTDC identification register
$5a001004 constant LTDC_LTDC_LCR  \ offset: 0x04 : LDTC layer count register
$5a001008 constant LTDC_LTDC_SSCR  \ offset: 0x08 : LTDC synchronization size configuration register
$5a00100c constant LTDC_LTDC_BPCR  \ offset: 0x0C : LTDC back porch configuration register
$5a001010 constant LTDC_LTDC_AWCR  \ offset: 0x10 : LTDC active width configuration register
$5a001014 constant LTDC_LTDC_TWCR  \ offset: 0x14 : LTDC total width configuration register
$5a001018 constant LTDC_LTDC_GCR  \ offset: 0x18 : LTDC global control register
$5a00101c constant LTDC_LTDC_GC1R  \ offset: 0x1C : LTDC global configuration 1 register
$5a001020 constant LTDC_LTDC_GC2R  \ offset: 0x20 : LTDC global configuration 2 register
$5a001024 constant LTDC_LTDC_SRCR  \ offset: 0x24 : LTDC shadow reload configuration register
$5a001028 constant LTDC_LTDC_GCCR  \ offset: 0x28 : LTDC gamma correction configuration register
$5a00102c constant LTDC_LTDC_BCCR  \ offset: 0x2C : LTDC background color configuration register
$5a001034 constant LTDC_LTDC_IER  \ offset: 0x34 : LTDC interrupt enable register
$5a001038 constant LTDC_LTDC_ISR  \ offset: 0x38 : LTDC interrupt status register
$5a00103c constant LTDC_LTDC_ICR  \ offset: 0x3C : LTDC interrupt clear register
$5a001040 constant LTDC_LTDC_LIPCR  \ offset: 0x40 : LTDC line interrupt position configuration register
$5a001044 constant LTDC_LTDC_CPSR  \ offset: 0x44 : LTDC current position status register
$5a001048 constant LTDC_LTDC_CDSR  \ offset: 0x48 : LTDC current display status register
$5a001060 constant LTDC_LTDC_EDCR  \ offset: 0x60 : LTDC external display control register
$5a001064 constant LTDC_LTDC_IER2  \ offset: 0x64 : LTDC interrupt enable register 2
$5a001068 constant LTDC_LTDC_ISR2  \ offset: 0x68 : LTDC interrupt status register 2
$5a00106c constant LTDC_LTDC_ICR2  \ offset: 0x6C : LTDC interrupt clear register 2
$5a001070 constant LTDC_LTDC_LIPCR2  \ offset: 0x70 : LTDC line interrupt position configuration register 2
$5a001078 constant LTDC_LTDC_ECRCR  \ offset: 0x78 : LTDC expected CRC register
$5a00107c constant LTDC_LTDC_CCRCR  \ offset: 0x7C : LTDC computed CRC register
$5a001090 constant LTDC_LTDC_FUTR  \ offset: 0x90 : LTDC FIFO underrun threshold register
$5a001100 constant LTDC_LTDC_L1C0R  \ offset: 0x100 : LTDC Layerx configuration 0 register
$5a001104 constant LTDC_LTDC_L1C1R  \ offset: 0x104 : LTDC Layerx configuration 1 register
$5a001108 constant LTDC_LTDC_L1RCR  \ offset: 0x108 : LTDC Layerx reload control register
$5a00110c constant LTDC_LTDC_L1CR  \ offset: 0x10C : LTDC Layerx control register
$5a001110 constant LTDC_LTDC_L1WHPCR  \ offset: 0x110 : LTDC Layerx window horizontal position configuration register
$5a001114 constant LTDC_LTDC_L1WVPCR  \ offset: 0x114 : LTDC Layerx window vertical position configuration register
$5a001118 constant LTDC_LTDC_L1CKCR  \ offset: 0x118 : LTDC Layerx color keying configuration register
$5a00111c constant LTDC_LTDC_L1PFCR  \ offset: 0x11C : LTDC Layerx pixel format configuration register
$5a001120 constant LTDC_LTDC_L1CACR  \ offset: 0x120 : LTDC Layerx constant alpha configuration register
$5a001124 constant LTDC_LTDC_L1DCCR  \ offset: 0x124 : LTDC Layerx default color configuration register
$5a001128 constant LTDC_LTDC_L1BFCR  \ offset: 0x128 : LTDC Layerx blending factors configuration register
$5a00112c constant LTDC_LTDC_L1BLCR  \ offset: 0x12C : LTDC Layerx burst length configuration register
$5a001130 constant LTDC_LTDC_L1PCR  \ offset: 0x130 : LTDC Layerx planar configuration register
$5a001134 constant LTDC_LTDC_L1CFBAR  \ offset: 0x134 : LTDC Layerx color frame buffer address register
$5a001138 constant LTDC_LTDC_L1CFBLR  \ offset: 0x138 : LTDC Layerx color frame buffer length register
$5a00113c constant LTDC_LTDC_L1CFBLNR  \ offset: 0x13C : LTDC Layerx color frame buffer line number register
$5a001140 constant LTDC_LTDC_L1AFBA0R  \ offset: 0x140 : LTDC Layer1 auxiliary frame buffer address 0 register
$5a001144 constant LTDC_LTDC_L1AFBA1R  \ offset: 0x144 : LTDC Layer1 auxiliary frame buffer address 1 register
$5a001148 constant LTDC_LTDC_L1AFBLR  \ offset: 0x148 : LTDC Layer1 auxiliary frame buffer length register
$5a00114c constant LTDC_LTDC_L1AFBLNR  \ offset: 0x14C : LTDC Layer1 auxiliary frame buffer line number register
$5a001150 constant LTDC_LTDC_L1CLUTWR  \ offset: 0x150 : LTDC Layerx CLUT write register
$5a00116c constant LTDC_LTDC_L1CYR0R  \ offset: 0x16C : LTDC Layerx conversion YCbCr RGB 0 register
$5a001170 constant LTDC_LTDC_L1CYR1R  \ offset: 0x170 : LTDC Layerx conversion YCbCr RGB 1 register
$5a001174 constant LTDC_LTDC_L1FPF0R  \ offset: 0x174 : LTDC Layerx flexible pixel format 0 register
$5a001178 constant LTDC_LTDC_L1FPF1R  \ offset: 0x178 : LTDC Layerx flexible pixel format 1 register
$5a001200 constant LTDC_LTDC_L2C0R  \ offset: 0x200 : LTDC Layerx configuration 0 register
$5a001204 constant LTDC_LTDC_L2C1R  \ offset: 0x204 : LTDC Layerx configuration 1 register
$5a001208 constant LTDC_LTDC_L2RCR  \ offset: 0x208 : LTDC Layerx reload control register
$5a00120c constant LTDC_LTDC_L2CR  \ offset: 0x20C : LTDC Layerx control register
$5a001210 constant LTDC_LTDC_L2WHPCR  \ offset: 0x210 : LTDC Layerx window horizontal position configuration register
$5a001214 constant LTDC_LTDC_L2WVPCR  \ offset: 0x214 : LTDC Layerx window vertical position configuration register
$5a001218 constant LTDC_LTDC_L2CKCR  \ offset: 0x218 : LTDC Layerx color keying configuration register
$5a00121c constant LTDC_LTDC_L2PFCR  \ offset: 0x21C : LTDC Layerx pixel format configuration register
$5a001220 constant LTDC_LTDC_L2CACR  \ offset: 0x220 : LTDC Layerx constant alpha configuration register
$5a001224 constant LTDC_LTDC_L2DCCR  \ offset: 0x224 : LTDC Layerx default color configuration register
$5a001228 constant LTDC_LTDC_L2BFCR  \ offset: 0x228 : LTDC Layerx blending factors configuration register
$5a00122c constant LTDC_LTDC_L2BLCR  \ offset: 0x22C : LTDC Layerx burst length configuration register
$5a001230 constant LTDC_LTDC_L2PCR  \ offset: 0x230 : LTDC Layerx planar configuration register
$5a001234 constant LTDC_LTDC_L2CFBAR  \ offset: 0x234 : LTDC Layerx color frame buffer address register
$5a001238 constant LTDC_LTDC_L2CFBLR  \ offset: 0x238 : LTDC Layerx color frame buffer length register
$5a00123c constant LTDC_LTDC_L2CFBLNR  \ offset: 0x23C : LTDC Layerx color frame buffer line number register
$5a001250 constant LTDC_LTDC_L2CLUTWR  \ offset: 0x250 : LTDC Layerx CLUT write register
$5a00126c constant LTDC_LTDC_L2CYR0R  \ offset: 0x26C : LTDC Layerx conversion YCbCr RGB 0 register
$5a001270 constant LTDC_LTDC_L2CYR1R  \ offset: 0x270 : LTDC Layerx conversion YCbCr RGB 1 register
$5a001274 constant LTDC_LTDC_L2FPF0R  \ offset: 0x274 : LTDC Layerx flexible pixel format 0 register
$5a001278 constant LTDC_LTDC_L2FPF1R  \ offset: 0x278 : LTDC Layerx flexible pixel format 1 register
$5a001378 constant LTDC_LTDC_L3FPF1R  \ offset: 0x378 : LTDC Layerx flexible pixel format 1 register

