\
\ @file ltdc.fs
\ @brief LTDC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LTDC synchronization size configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000007ff constant LTDC_LTDC_SSCR_VSH                               \ vertical synchronization height (in units of horizontal scan line) These bits define the vertical Synchronization height minus 1. It represents the number of horizontal synchronization lines.
$0fff0000 constant LTDC_LTDC_SSCR_HSW                               \ horizontal synchronization width (in units of pixel clock period) These bits define the number of Horizontal Synchronization pixel minus 1.


\
\ @brief LTDC back porch configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000007ff constant LTDC_LTDC_BPCR_AVBP                              \ accumulated Vertical back porch (in units of horizontal scan line) These bits define the accumulated vertical back porch width that includes the vertical synchronization and vertical back porch lines minus 1. The vertical back porch is the number of horizontal scan lines at a start of frame to the start of the first active scan line of the next frame.
$0fff0000 constant LTDC_LTDC_BPCR_AHBP                              \ accumulated horizontal back porch (in units of pixel clock period) These bits define the accumulated horizontal back porch width that includes the horizontal synchronization and horizontal back porch pixels minus 1. The horizontal back porch is the period between horizontal synchronization going inactive and the start of the active display part of the next scan line.


\
\ @brief LTDC active width configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000007ff constant LTDC_LTDC_AWCR_AAH                               \ accumulated active height (in units of horizontal scan line) These bits define the accumulated height which includes the vertical synchronization, vertical back porch and the active height lines minus 1. The active height is the number of active lines in the panel. Refer to device datasheet for maximum active height supported following maximum pixel clock.
$0fff0000 constant LTDC_LTDC_AWCR_AAW                               \ accumulated active width (in units of pixel clock period) These bits define the accumulated active width which includes the horizontal synchronization, horizontal back porch and active pixels minus 1. The active width is the number of pixels in active display area of the panel scan line. Refer to device datasheet for maximum active width supported following maximum pixel clock.


\
\ @brief LTDC total width configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000007ff constant LTDC_LTDC_TWCR_TOTALH                            \ total height (in units of horizontal scan line) These bits defines the accumulated height which includes the vertical synchronization, vertical back porch, the active height and vertical front porch height lines minus 1.
$0fff0000 constant LTDC_LTDC_TWCR_TOTALW                            \ total width (in units of pixel clock period) These bits defines the accumulated total width which includes the horizontal synchronization, horizontal back porch, active width and horizontal front porch pixels minus 1.


\
\ @brief LTDC global control register
\ Address offset: 0x18
\ Reset value: 0x00002220
\

$00000001 constant LTDC_LTDC_GCR_LTDCEN                             \ LCD-TFT controller enable This bit is set and cleared by software.
$00000070 constant LTDC_LTDC_GCR_DBW                                \ dither blue width These bits return the dither blue bits.
$00000700 constant LTDC_LTDC_GCR_DGW                                \ dither green width These bits return the dither green bits.
$00007000 constant LTDC_LTDC_GCR_DRW                                \ dither red width These bits return the Dither Red Bits.
$00010000 constant LTDC_LTDC_GCR_DEN                                \ dither enable This bit is set and cleared by software.
$10000000 constant LTDC_LTDC_GCR_PCPOL                              \ pixel clock polarity This bit is set and cleared by software.
$20000000 constant LTDC_LTDC_GCR_DEPOL                              \ not data enable polarity This bit is set and cleared by software.
$40000000 constant LTDC_LTDC_GCR_VSPOL                              \ vertical synchronization polarity This bit is set and cleared by software.
$80000000 constant LTDC_LTDC_GCR_HSPOL                              \ horizontal synchronization polarity This bit is set and cleared by software.


\
\ @brief LTDC shadow reload configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_SRCR_IMR                               \ immediate reload This bit is set by software and cleared only by hardware after reload.
$00000002 constant LTDC_LTDC_SRCR_VBR                               \ vertical blanking reload This bit is set by software and cleared only by hardware after reload (it cannot be cleared through register write once it is set).


\
\ @brief LTDC background color configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_BCCR_BCBLUE                            \ background color blue value These bits configure the background blue value.
$0000ff00 constant LTDC_LTDC_BCCR_BCGREEN                           \ background color green value These bits configure the background green value.
$00ff0000 constant LTDC_LTDC_BCCR_BCRED                             \ background color red value These bits configure the background red value.


\
\ @brief LTDC interrupt enable register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_IER_LIE                                \ line interrupt enable This bit is set and cleared by software.
$00000002 constant LTDC_LTDC_IER_FUIE                               \ FIFO underrun interrupt enable This bit is set and cleared by software.
$00000004 constant LTDC_LTDC_IER_TERRIE                             \ transfer error interrupt enable This bit is set and cleared by software.
$00000008 constant LTDC_LTDC_IER_RRIE                               \ register reload interrupt enable This bit is set and cleared by software.


\
\ @brief LTDC interrupt status register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_ISR_LIF                                \ line interrupt flag
$00000002 constant LTDC_LTDC_ISR_FUIF                               \ FIFO underrun interrupt flag
$00000004 constant LTDC_LTDC_ISR_TERRIF                             \ transfer error interrupt flag
$00000008 constant LTDC_LTDC_ISR_RRIF                               \ register reload interrupt flag


\
\ @brief clears the line interrupt flag
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_ICR_CLIF                               \ clears the line interrupt flag
$00000002 constant LTDC_LTDC_ICR_CFUIF                              \ clears the FIFO underrun interrupt flag
$00000004 constant LTDC_LTDC_ICR_CTERRIF                            \ clears the transfer error interrupt flag
$00000008 constant LTDC_LTDC_ICR_CRRIF                              \ clears register reload interrupt flag


\
\ @brief LTDC line interrupt position configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000007ff constant LTDC_LTDC_LIPCR_LIPOS                            \ line interrupt position These bits configure the line interrupt position.


\
\ @brief current Y position These bits return the current Y position.
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_CPSR_CYPOS                             \ current Y position These bits return the current Y position.
$ffff0000 constant LTDC_LTDC_CPSR_CXPOS                             \ current X position These bits return the current X position.


\
\ @brief LTDC current display status register
\ Address offset: 0x48
\ Reset value: 0x0000000F
\

$00000001 constant LTDC_LTDC_CDSR_VDES                              \ vertical data enable display status
$00000002 constant LTDC_LTDC_CDSR_HDES                              \ horizontal data enable display status
$00000004 constant LTDC_LTDC_CDSR_VSYNCS                            \ vertical synchronization display status
$00000008 constant LTDC_LTDC_CDSR_HSYNCS                            \ horizontal synchronization display status


\
\ @brief layer enable This bit is set and cleared by software.
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_L1CR_LEN                               \ layer enable This bit is set and cleared by software.
$00000002 constant LTDC_LTDC_L1CR_COLKEN                            \ color keying enable This bit is set and cleared by software.
$00000010 constant LTDC_LTDC_L1CR_CLUTEN                            \ color look-up table enable This bit is set and cleared by software. The CLUT is only meaningful for L8, AL44 and AL88 pixel format. Refer to table (CLUT)


\
\ @brief LTDC layer 1 window horizontal position configuration register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_L1WHPCR_WHSTPOS                        \ window horizontal start position These bits configure the first visible pixel of a line of the layer window. WHSTPOS[11:0] must be ≤ AAW[11:0] bits (programmed in LTDC_AWCR register).
$0fff0000 constant LTDC_LTDC_L1WHPCR_WHSPPOS                        \ window horizontal stop position These bits configure the last visible pixel of a line of the layer window. WHSPPOS[11:0] must be ≥ AHBP[11:0] bits + 1 (programmed in LTDC_BPCR register).


\
\ @brief LTDC layer 1 window vertical position configuration register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$000007ff constant LTDC_LTDC_L1WVPCR_WVSTPOS                        \ window vertical start position These bits configure the first visible line of the layer window. WVSTPOS[10:0] must be ≤ AAH[10:0] bits (programmed in LTDC_AWCR register).
$07ff0000 constant LTDC_LTDC_L1WVPCR_WVSPPOS                        \ window vertical stop position These bits configure the last visible line of the layer window. WVSPPOS[10:0] must be ≥ AVBP[10:0] bits + 1 (programmed in LTDC_BPCR register).


\
\ @brief LTDC layer 1 color keying configuration register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L1CKCR_CKBLUE                          \ color key blue value
$0000ff00 constant LTDC_LTDC_L1CKCR_CKGREEN                         \ color key green value
$00ff0000 constant LTDC_LTDC_L1CKCR_CKRED                           \ color key red value


\
\ @brief LTDC layer 1 pixel format configuration register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000007 constant LTDC_LTDC_L1PFCR_PF                              \ pixel format These bits configure the pixel format


\
\ @brief LTDC layer 1 constant alpha configuration register
\ Address offset: 0x98
\ Reset value: 0x000000FF
\

$000000ff constant LTDC_LTDC_L1CACR_CONSTA                          \ constant alpha These bits configure the constant alpha used for blending. The constant alpha is divided by 255 by hardware. Example: if the programmed constant alpha is 0xFF, the constant alpha value is 255 / 255 = 1.


\
\ @brief LTDC layer 1 default color configuration register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L1DCCR_DCBLUE                          \ default color blue These bits configure the default blue value.
$0000ff00 constant LTDC_LTDC_L1DCCR_DCGREEN                         \ default color green These bits configure the default green value.
$00ff0000 constant LTDC_LTDC_L1DCCR_DCRED                           \ default color red These bits configure the default red value.
$ff000000 constant LTDC_LTDC_L1DCCR_DCALPHA                         \ default color alpha These bits configure the default alpha value.


\
\ @brief LTDC layer 1 blending factors configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000607
\

$00000007 constant LTDC_LTDC_L1BFCR_BF2                             \ blending factor 2 These bits select the blending factor F2
$00000700 constant LTDC_LTDC_L1BFCR_BF1                             \ blending factor 1 These bits select the blending factor F1.


\
\ @brief LTDC layer 1 color frame buffer address register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant LTDC_LTDC_L1CFBAR_CFBADD                         \ color frame buffer start address These bits define the color frame buffer start address.


\
\ @brief LTDC layer 1 color frame buffer length register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00001fff constant LTDC_LTDC_L1CFBLR_CFBLL                          \ color frame buffer line length These bits define the length of one line of pixels in bytes + 3. The line length is computed as follows: active high width *  number of bytes per pixel + 3.
$1fff0000 constant LTDC_LTDC_L1CFBLR_CFBP                           \ color frame buffer pitch in bytes These bits define the pitch that is the increment from the start of one line of pixels to the start of the next line in bytes.


\
\ @brief LTDC layer 1 color frame buffer line number register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$000007ff constant LTDC_LTDC_L1CFBLNR_CFBLNBR                       \ frame buffer line number These bits define the number of lines in the frame buffer that corresponds to the active high width.


\
\ @brief LTDC layer 1 CLUT write register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L1CLUTWR_BLUE                          \ blue value These bits configure the blue value.
$0000ff00 constant LTDC_LTDC_L1CLUTWR_GREEN                         \ green value These bits configure the green value.
$00ff0000 constant LTDC_LTDC_L1CLUTWR_RED                           \ red value These bits configure the red value.
$ff000000 constant LTDC_LTDC_L1CLUTWR_CLUTADD                       \ CLUT address These bits configure the CLUT address (color position within the CLUT) of each RGB value.


\
\ @brief layer enable This bit is set and cleared by software.
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_L2CR_LEN                               \ layer enable This bit is set and cleared by software.
$00000002 constant LTDC_LTDC_L2CR_COLKEN                            \ color keying enable This bit is set and cleared by software.
$00000010 constant LTDC_LTDC_L2CR_CLUTEN                            \ color look-up table enable This bit is set and cleared by software. The CLUT is only meaningful for L8, AL44 and AL88 pixel format. Refer to table (CLUT)


\
\ @brief LTDC layer 2 window horizontal position configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_L2WHPCR_WHSTPOS                        \ window horizontal start position These bits configure the first visible pixel of a line of the layer window. WHSTPOS[11:0] must be ≤ AAW[11:0] bits (programmed in LTDC_AWCR register).
$0fff0000 constant LTDC_LTDC_L2WHPCR_WHSPPOS                        \ window horizontal stop position These bits configure the last visible pixel of a line of the layer window. WHSPPOS[11:0] must be ≥ AHBP[11:0] bits + 1 (programmed in LTDC_BPCR register).


\
\ @brief LTDC layer 2 window vertical position configuration register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$000007ff constant LTDC_LTDC_L2WVPCR_WVSTPOS                        \ window vertical start position These bits configure the first visible line of the layer window. WVSTPOS[10:0] must be ≤ AAH[10:0] bits (programmed in LTDC_AWCR register).
$07ff0000 constant LTDC_LTDC_L2WVPCR_WVSPPOS                        \ window vertical stop position These bits configure the last visible line of the layer window. WVSPPOS[10:0] must be ≥ AVBP[10:0] bits + 1 (programmed in LTDC_BPCR register).


\
\ @brief LTDC layer 2 color keying configuration register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L2CKCR_CKBLUE                          \ color key blue value
$0000ff00 constant LTDC_LTDC_L2CKCR_CKGREEN                         \ color key green value
$00ff0000 constant LTDC_LTDC_L2CKCR_CKRED                           \ color key red value


\
\ @brief LTDC layer 2 pixel format configuration register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000007 constant LTDC_LTDC_L2PFCR_PF                              \ pixel format These bits configure the pixel format


\
\ @brief LTDC layer 2 constant alpha configuration register
\ Address offset: 0x118
\ Reset value: 0x000000FF
\

$000000ff constant LTDC_LTDC_L2CACR_CONSTA                          \ constant alpha These bits configure the constant alpha used for blending. The constant alpha is divided by 255 by hardware. Example: if the programmed constant alpha is 0xFF, the constant alpha value is 255 / 255 = 1.


\
\ @brief LTDC layer 2 default color configuration register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L2DCCR_DCBLUE                          \ default color blue These bits configure the default blue value.
$0000ff00 constant LTDC_LTDC_L2DCCR_DCGREEN                         \ default color green These bits configure the default green value.
$00ff0000 constant LTDC_LTDC_L2DCCR_DCRED                           \ default color red These bits configure the default red value.
$ff000000 constant LTDC_LTDC_L2DCCR_DCALPHA                         \ default color alpha These bits configure the default alpha value.


\
\ @brief LTDC layer 2 blending factors configuration register
\ Address offset: 0x120
\ Reset value: 0x00000607
\

$00000007 constant LTDC_LTDC_L2BFCR_BF2                             \ blending factor 2 These bits select the blending factor F2
$00000700 constant LTDC_LTDC_L2BFCR_BF1                             \ blending factor 1 These bits select the blending factor F1.


\
\ @brief LTDC layer 2 color frame buffer address register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant LTDC_LTDC_L2CFBAR_CFBADD                         \ color frame buffer start address These bits define the color frame buffer start address.


\
\ @brief LTDC layer 2 color frame buffer length register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00001fff constant LTDC_LTDC_L2CFBLR_CFBLL                          \ color frame buffer line length These bits define the length of one line of pixels in bytes + 3. The line length is computed as follows: active high width *  number of bytes per pixel + 3.
$1fff0000 constant LTDC_LTDC_L2CFBLR_CFBP                           \ color frame buffer pitch in bytes These bits define the pitch that is the increment from the start of one line of pixels to the start of the next line in bytes.


\
\ @brief LTDC layer 2 color frame buffer line number register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$000007ff constant LTDC_LTDC_L2CFBLNR_CFBLNBR                       \ frame buffer line number These bits define the number of lines in the frame buffer that corresponds to the active high width.


\
\ @brief LTDC layer 2 CLUT write register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L2CLUTWR_BLUE                          \ blue value These bits configure the blue value.
$0000ff00 constant LTDC_LTDC_L2CLUTWR_GREEN                         \ green value These bits configure the green value.
$00ff0000 constant LTDC_LTDC_L2CLUTWR_RED                           \ red value These bits configure the red value.
$ff000000 constant LTDC_LTDC_L2CLUTWR_CLUTADD                       \ CLUT address These bits configure the CLUT address (color position within the CLUT) of each RGB value.


\
\ @brief LTDC
\
$40016808 constant LTDC_LTDC_SSCR  \ offset: 0x08 : LTDC synchronization size configuration register
$4001680c constant LTDC_LTDC_BPCR  \ offset: 0x0C : LTDC back porch configuration register
$40016810 constant LTDC_LTDC_AWCR  \ offset: 0x10 : LTDC active width configuration register
$40016814 constant LTDC_LTDC_TWCR  \ offset: 0x14 : LTDC total width configuration register
$40016818 constant LTDC_LTDC_GCR  \ offset: 0x18 : LTDC global control register
$40016824 constant LTDC_LTDC_SRCR  \ offset: 0x24 : LTDC shadow reload configuration register
$4001682c constant LTDC_LTDC_BCCR  \ offset: 0x2C : LTDC background color configuration register
$40016834 constant LTDC_LTDC_IER  \ offset: 0x34 : LTDC interrupt enable register
$40016838 constant LTDC_LTDC_ISR  \ offset: 0x38 : LTDC interrupt status register
$4001683c constant LTDC_LTDC_ICR  \ offset: 0x3C : clears the line interrupt flag
$40016840 constant LTDC_LTDC_LIPCR  \ offset: 0x40 : LTDC line interrupt position configuration register
$40016844 constant LTDC_LTDC_CPSR  \ offset: 0x44 : current Y position These bits return the current Y position.
$40016848 constant LTDC_LTDC_CDSR  \ offset: 0x48 : LTDC current display status register
$40016884 constant LTDC_LTDC_L1CR  \ offset: 0x84 : layer enable This bit is set and cleared by software.
$40016888 constant LTDC_LTDC_L1WHPCR  \ offset: 0x88 : LTDC layer 1 window horizontal position configuration register
$4001688c constant LTDC_LTDC_L1WVPCR  \ offset: 0x8C : LTDC layer 1 window vertical position configuration register
$40016890 constant LTDC_LTDC_L1CKCR  \ offset: 0x90 : LTDC layer 1 color keying configuration register
$40016894 constant LTDC_LTDC_L1PFCR  \ offset: 0x94 : LTDC layer 1 pixel format configuration register
$40016898 constant LTDC_LTDC_L1CACR  \ offset: 0x98 : LTDC layer 1 constant alpha configuration register
$4001689c constant LTDC_LTDC_L1DCCR  \ offset: 0x9C : LTDC layer 1 default color configuration register
$400168a0 constant LTDC_LTDC_L1BFCR  \ offset: 0xA0 : LTDC layer 1 blending factors configuration register
$400168ac constant LTDC_LTDC_L1CFBAR  \ offset: 0xAC : LTDC layer 1 color frame buffer address register
$400168b0 constant LTDC_LTDC_L1CFBLR  \ offset: 0xB0 : LTDC layer 1 color frame buffer length register
$400168b4 constant LTDC_LTDC_L1CFBLNR  \ offset: 0xB4 : LTDC layer 1 color frame buffer line number register
$400168c4 constant LTDC_LTDC_L1CLUTWR  \ offset: 0xC4 : LTDC layer 1 CLUT write register
$40016904 constant LTDC_LTDC_L2CR  \ offset: 0x104 : layer enable This bit is set and cleared by software.
$40016908 constant LTDC_LTDC_L2WHPCR  \ offset: 0x108 : LTDC layer 2 window horizontal position configuration register
$4001690c constant LTDC_LTDC_L2WVPCR  \ offset: 0x10C : LTDC layer 2 window vertical position configuration register
$40016910 constant LTDC_LTDC_L2CKCR  \ offset: 0x110 : LTDC layer 2 color keying configuration register
$40016914 constant LTDC_LTDC_L2PFCR  \ offset: 0x114 : LTDC layer 2 pixel format configuration register
$40016918 constant LTDC_LTDC_L2CACR  \ offset: 0x118 : LTDC layer 2 constant alpha configuration register
$4001691c constant LTDC_LTDC_L2DCCR  \ offset: 0x11C : LTDC layer 2 default color configuration register
$40016920 constant LTDC_LTDC_L2BFCR  \ offset: 0x120 : LTDC layer 2 blending factors configuration register
$4001692c constant LTDC_LTDC_L2CFBAR  \ offset: 0x12C : LTDC layer 2 color frame buffer address register
$40016930 constant LTDC_LTDC_L2CFBLR  \ offset: 0x130 : LTDC layer 2 color frame buffer length register
$40016934 constant LTDC_LTDC_L2CFBLNR  \ offset: 0x134 : LTDC layer 2 color frame buffer line number register
$40016944 constant LTDC_LTDC_L2CLUTWR  \ offset: 0x144 : LTDC layer 2 CLUT write register

