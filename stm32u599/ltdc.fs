\
\ @file ltdc.fs
\ @brief LTDC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LTDC_DEF

  [ifdef] LTDC_LTDC_SSCR_DEF
    \
    \ @brief LTDC synchronization size configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_VSH                       \ [0x00 : 11] vertical synchronization height (in units of horizontal scan line) These bits define the vertical Synchronization height minus 1. It represents the number of horizontal synchronization lines.
    $10 constant LTDC_HSW                       \ [0x10 : 12] horizontal synchronization width (in units of pixel clock period) These bits define the number of Horizontal Synchronization pixel minus 1.
  [then]


  [ifdef] LTDC_LTDC_BPCR_DEF
    \
    \ @brief LTDC back porch configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AVBP                      \ [0x00 : 11] accumulated Vertical back porch (in units of horizontal scan line) These bits define the accumulated vertical back porch width that includes the vertical synchronization and vertical back porch lines minus 1. The vertical back porch is the number of horizontal scan lines at a start of frame to the start of the first active scan line of the next frame.
    $10 constant LTDC_AHBP                      \ [0x10 : 12] accumulated horizontal back porch (in units of pixel clock period) These bits define the accumulated horizontal back porch width that includes the horizontal synchronization and horizontal back porch pixels minus 1. The horizontal back porch is the period between horizontal synchronization going inactive and the start of the active display part of the next scan line.
  [then]


  [ifdef] LTDC_LTDC_AWCR_DEF
    \
    \ @brief LTDC active width configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AAH                       \ [0x00 : 11] accumulated active height (in units of horizontal scan line) These bits define the accumulated height which includes the vertical synchronization, vertical back porch and the active height lines minus 1. The active height is the number of active lines in the panel. Refer to device datasheet for maximum active height supported following maximum pixel clock.
    $10 constant LTDC_AAW                       \ [0x10 : 12] accumulated active width (in units of pixel clock period) These bits define the accumulated active width which includes the horizontal synchronization, horizontal back porch and active pixels minus 1. The active width is the number of pixels in active display area of the panel scan line. Refer to device datasheet for maximum active width supported following maximum pixel clock.
  [then]


  [ifdef] LTDC_LTDC_TWCR_DEF
    \
    \ @brief LTDC total width configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_TOTALH                    \ [0x00 : 11] total height (in units of horizontal scan line) These bits defines the accumulated height which includes the vertical synchronization, vertical back porch, the active height and vertical front porch height lines minus 1.
    $10 constant LTDC_TOTALW                    \ [0x10 : 12] total width (in units of pixel clock period) These bits defines the accumulated total width which includes the horizontal synchronization, horizontal back porch, active width and horizontal front porch pixels minus 1.
  [then]


  [ifdef] LTDC_LTDC_GCR_DEF
    \
    \ @brief LTDC global control register
    \ Address offset: 0x18
    \ Reset value: 0x00002220
    \
    $00 constant LTDC_LTDCEN                    \ [0x00] LCD-TFT controller enable This bit is set and cleared by software.
    $04 constant LTDC_DBW                       \ [0x04 : 3] dither blue width These bits return the dither blue bits.
    $08 constant LTDC_DGW                       \ [0x08 : 3] dither green width These bits return the dither green bits.
    $0c constant LTDC_DRW                       \ [0x0c : 3] dither red width These bits return the Dither Red Bits.
    $10 constant LTDC_DEN                       \ [0x10] dither enable This bit is set and cleared by software.
    $1c constant LTDC_PCPOL                     \ [0x1c] pixel clock polarity This bit is set and cleared by software.
    $1d constant LTDC_DEPOL                     \ [0x1d] not data enable polarity This bit is set and cleared by software.
    $1e constant LTDC_VSPOL                     \ [0x1e] vertical synchronization polarity This bit is set and cleared by software.
    $1f constant LTDC_HSPOL                     \ [0x1f] horizontal synchronization polarity This bit is set and cleared by software.
  [then]


  [ifdef] LTDC_LTDC_SRCR_DEF
    \
    \ @brief LTDC shadow reload configuration register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_IMR                       \ [0x00] immediate reload This bit is set by software and cleared only by hardware after reload.
    $01 constant LTDC_VBR                       \ [0x01] vertical blanking reload This bit is set by software and cleared only by hardware after reload (it cannot be cleared through register write once it is set).
  [then]


  [ifdef] LTDC_LTDC_BCCR_DEF
    \
    \ @brief LTDC background color configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BCBLUE                    \ [0x00 : 8] background color blue value These bits configure the background blue value.
    $08 constant LTDC_BCGREEN                   \ [0x08 : 8] background color green value These bits configure the background green value.
    $10 constant LTDC_BCRED                     \ [0x10 : 8] background color red value These bits configure the background red value.
  [then]


  [ifdef] LTDC_LTDC_IER_DEF
    \
    \ @brief LTDC interrupt enable register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIE                       \ [0x00] line interrupt enable This bit is set and cleared by software.
    $01 constant LTDC_FUIE                      \ [0x01] FIFO underrun interrupt enable This bit is set and cleared by software.
    $02 constant LTDC_TERRIE                    \ [0x02] transfer error interrupt enable This bit is set and cleared by software.
    $03 constant LTDC_RRIE                      \ [0x03] register reload interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] LTDC_LTDC_ISR_DEF
    \
    \ @brief LTDC interrupt status register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIF                       \ [0x00] line interrupt flag
    $01 constant LTDC_FUIF                      \ [0x01] FIFO underrun interrupt flag
    $02 constant LTDC_TERRIF                    \ [0x02] transfer error interrupt flag
    $03 constant LTDC_RRIF                      \ [0x03] register reload interrupt flag
  [then]


  [ifdef] LTDC_LTDC_ICR_DEF
    \
    \ @brief clears the line interrupt flag
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CLIF                      \ [0x00] clears the line interrupt flag
    $01 constant LTDC_CFUIF                     \ [0x01] clears the FIFO underrun interrupt flag
    $02 constant LTDC_CTERRIF                   \ [0x02] clears the transfer error interrupt flag
    $03 constant LTDC_CRRIF                     \ [0x03] clears register reload interrupt flag
  [then]


  [ifdef] LTDC_LTDC_LIPCR_DEF
    \
    \ @brief LTDC line interrupt position configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIPOS                     \ [0x00 : 11] line interrupt position These bits configure the line interrupt position.
  [then]


  [ifdef] LTDC_LTDC_CPSR_DEF
    \
    \ @brief current Y position These bits return the current Y position.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CYPOS                     \ [0x00 : 16] current Y position These bits return the current Y position.
    $10 constant LTDC_CXPOS                     \ [0x10 : 16] current X position These bits return the current X position.
  [then]


  [ifdef] LTDC_LTDC_CDSR_DEF
    \
    \ @brief LTDC current display status register
    \ Address offset: 0x48
    \ Reset value: 0x0000000F
    \
    $00 constant LTDC_VDES                      \ [0x00] vertical data enable display status
    $01 constant LTDC_HDES                      \ [0x01] horizontal data enable display status
    $02 constant LTDC_VSYNCS                    \ [0x02] vertical synchronization display status
    $03 constant LTDC_HSYNCS                    \ [0x03] horizontal synchronization display status
  [then]


  [ifdef] LTDC_LTDC_L1CR_DEF
    \
    \ @brief layer enable This bit is set and cleared by software.
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LEN                       \ [0x00] layer enable This bit is set and cleared by software.
    $01 constant LTDC_COLKEN                    \ [0x01] color keying enable This bit is set and cleared by software.
    $04 constant LTDC_CLUTEN                    \ [0x04] color look-up table enable This bit is set and cleared by software. The CLUT is only meaningful for L8, AL44 and AL88 pixel format. Refer to table (CLUT)
  [then]


  [ifdef] LTDC_LTDC_L1WHPCR_DEF
    \
    \ @brief LTDC layer 1 window horizontal position configuration register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WHSTPOS                   \ [0x00 : 12] window horizontal start position These bits configure the first visible pixel of a line of the layer window. WHSTPOS[11:0] must be ≤ AAW[11:0] bits (programmed in LTDC_AWCR register).
    $10 constant LTDC_WHSPPOS                   \ [0x10 : 12] window horizontal stop position These bits configure the last visible pixel of a line of the layer window. WHSPPOS[11:0] must be ≥ AHBP[11:0] bits + 1 (programmed in LTDC_BPCR register).
  [then]


  [ifdef] LTDC_LTDC_L1WVPCR_DEF
    \
    \ @brief LTDC layer 1 window vertical position configuration register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WVSTPOS                   \ [0x00 : 11] window vertical start position These bits configure the first visible line of the layer window. WVSTPOS[10:0] must be ≤ AAH[10:0] bits (programmed in LTDC_AWCR register).
    $10 constant LTDC_WVSPPOS                   \ [0x10 : 11] window vertical stop position These bits configure the last visible line of the layer window. WVSPPOS[10:0] must be ≥ AVBP[10:0] bits + 1 (programmed in LTDC_BPCR register).
  [then]


  [ifdef] LTDC_LTDC_L1CKCR_DEF
    \
    \ @brief LTDC layer 1 color keying configuration register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CKBLUE                    \ [0x00 : 8] color key blue value
    $08 constant LTDC_CKGREEN                   \ [0x08 : 8] color key green value
    $10 constant LTDC_CKRED                     \ [0x10 : 8] color key red value
  [then]


  [ifdef] LTDC_LTDC_L1PFCR_DEF
    \
    \ @brief LTDC layer 1 pixel format configuration register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_PF                        \ [0x00 : 3] pixel format These bits configure the pixel format
  [then]


  [ifdef] LTDC_LTDC_L1CACR_DEF
    \
    \ @brief LTDC layer 1 constant alpha configuration register
    \ Address offset: 0x98
    \ Reset value: 0x000000FF
    \
    $00 constant LTDC_CONSTA                    \ [0x00 : 8] constant alpha These bits configure the constant alpha used for blending. The constant alpha is divided by 255 by hardware. Example: if the programmed constant alpha is 0xFF, the constant alpha value is 255 / 255 = 1.
  [then]


  [ifdef] LTDC_LTDC_L1DCCR_DEF
    \
    \ @brief LTDC layer 1 default color configuration register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_DCBLUE                    \ [0x00 : 8] default color blue These bits configure the default blue value.
    $08 constant LTDC_DCGREEN                   \ [0x08 : 8] default color green These bits configure the default green value.
    $10 constant LTDC_DCRED                     \ [0x10 : 8] default color red These bits configure the default red value.
    $18 constant LTDC_DCALPHA                   \ [0x18 : 8] default color alpha These bits configure the default alpha value.
  [then]


  [ifdef] LTDC_LTDC_L1BFCR_DEF
    \
    \ @brief LTDC layer 1 blending factors configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000607
    \
    $00 constant LTDC_BF2                       \ [0x00 : 3] blending factor 2 These bits select the blending factor F2
    $08 constant LTDC_BF1                       \ [0x08 : 3] blending factor 1 These bits select the blending factor F1.
  [then]


  [ifdef] LTDC_LTDC_L1CFBAR_DEF
    \
    \ @brief LTDC layer 1 color frame buffer address register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBADD                    \ [0x00 : 32] color frame buffer start address These bits define the color frame buffer start address.
  [then]


  [ifdef] LTDC_LTDC_L1CFBLR_DEF
    \
    \ @brief LTDC layer 1 color frame buffer length register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLL                     \ [0x00 : 13] color frame buffer line length These bits define the length of one line of pixels in bytes + 3. The line length is computed as follows: active high width *  number of bytes per pixel + 3.
    $10 constant LTDC_CFBP                      \ [0x10 : 13] color frame buffer pitch in bytes These bits define the pitch that is the increment from the start of one line of pixels to the start of the next line in bytes.
  [then]


  [ifdef] LTDC_LTDC_L1CFBLNR_DEF
    \
    \ @brief LTDC layer 1 color frame buffer line number register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLNBR                   \ [0x00 : 11] frame buffer line number These bits define the number of lines in the frame buffer that corresponds to the active high width.
  [then]


  [ifdef] LTDC_LTDC_L1CLUTWR_DEF
    \
    \ @brief LTDC layer 1 CLUT write register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BLUE                      \ [0x00 : 8] blue value These bits configure the blue value.
    $08 constant LTDC_GREEN                     \ [0x08 : 8] green value These bits configure the green value.
    $10 constant LTDC_RED                       \ [0x10 : 8] red value These bits configure the red value.
    $18 constant LTDC_CLUTADD                   \ [0x18 : 8] CLUT address These bits configure the CLUT address (color position within the CLUT) of each RGB value.
  [then]


  [ifdef] LTDC_LTDC_L2CR_DEF
    \
    \ @brief layer enable This bit is set and cleared by software.
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LEN                       \ [0x00] layer enable This bit is set and cleared by software.
    $01 constant LTDC_COLKEN                    \ [0x01] color keying enable This bit is set and cleared by software.
    $04 constant LTDC_CLUTEN                    \ [0x04] color look-up table enable This bit is set and cleared by software. The CLUT is only meaningful for L8, AL44 and AL88 pixel format. Refer to table (CLUT)
  [then]


  [ifdef] LTDC_LTDC_L2WHPCR_DEF
    \
    \ @brief LTDC layer 2 window horizontal position configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WHSTPOS                   \ [0x00 : 12] window horizontal start position These bits configure the first visible pixel of a line of the layer window. WHSTPOS[11:0] must be ≤ AAW[11:0] bits (programmed in LTDC_AWCR register).
    $10 constant LTDC_WHSPPOS                   \ [0x10 : 12] window horizontal stop position These bits configure the last visible pixel of a line of the layer window. WHSPPOS[11:0] must be ≥ AHBP[11:0] bits + 1 (programmed in LTDC_BPCR register).
  [then]


  [ifdef] LTDC_LTDC_L2WVPCR_DEF
    \
    \ @brief LTDC layer 2 window vertical position configuration register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WVSTPOS                   \ [0x00 : 11] window vertical start position These bits configure the first visible line of the layer window. WVSTPOS[10:0] must be ≤ AAH[10:0] bits (programmed in LTDC_AWCR register).
    $10 constant LTDC_WVSPPOS                   \ [0x10 : 11] window vertical stop position These bits configure the last visible line of the layer window. WVSPPOS[10:0] must be ≥ AVBP[10:0] bits + 1 (programmed in LTDC_BPCR register).
  [then]


  [ifdef] LTDC_LTDC_L2CKCR_DEF
    \
    \ @brief LTDC layer 2 color keying configuration register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CKBLUE                    \ [0x00 : 8] color key blue value
    $08 constant LTDC_CKGREEN                   \ [0x08 : 8] color key green value
    $10 constant LTDC_CKRED                     \ [0x10 : 8] color key red value
  [then]


  [ifdef] LTDC_LTDC_L2PFCR_DEF
    \
    \ @brief LTDC layer 2 pixel format configuration register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_PF                        \ [0x00 : 3] pixel format These bits configure the pixel format
  [then]


  [ifdef] LTDC_LTDC_L2CACR_DEF
    \
    \ @brief LTDC layer 2 constant alpha configuration register
    \ Address offset: 0x118
    \ Reset value: 0x000000FF
    \
    $00 constant LTDC_CONSTA                    \ [0x00 : 8] constant alpha These bits configure the constant alpha used for blending. The constant alpha is divided by 255 by hardware. Example: if the programmed constant alpha is 0xFF, the constant alpha value is 255 / 255 = 1.
  [then]


  [ifdef] LTDC_LTDC_L2DCCR_DEF
    \
    \ @brief LTDC layer 2 default color configuration register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_DCBLUE                    \ [0x00 : 8] default color blue These bits configure the default blue value.
    $08 constant LTDC_DCGREEN                   \ [0x08 : 8] default color green These bits configure the default green value.
    $10 constant LTDC_DCRED                     \ [0x10 : 8] default color red These bits configure the default red value.
    $18 constant LTDC_DCALPHA                   \ [0x18 : 8] default color alpha These bits configure the default alpha value.
  [then]


  [ifdef] LTDC_LTDC_L2BFCR_DEF
    \
    \ @brief LTDC layer 2 blending factors configuration register
    \ Address offset: 0x120
    \ Reset value: 0x00000607
    \
    $00 constant LTDC_BF2                       \ [0x00 : 3] blending factor 2 These bits select the blending factor F2
    $08 constant LTDC_BF1                       \ [0x08 : 3] blending factor 1 These bits select the blending factor F1.
  [then]


  [ifdef] LTDC_LTDC_L2CFBAR_DEF
    \
    \ @brief LTDC layer 2 color frame buffer address register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBADD                    \ [0x00 : 32] color frame buffer start address These bits define the color frame buffer start address.
  [then]


  [ifdef] LTDC_LTDC_L2CFBLR_DEF
    \
    \ @brief LTDC layer 2 color frame buffer length register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLL                     \ [0x00 : 13] color frame buffer line length These bits define the length of one line of pixels in bytes + 3. The line length is computed as follows: active high width *  number of bytes per pixel + 3.
    $10 constant LTDC_CFBP                      \ [0x10 : 13] color frame buffer pitch in bytes These bits define the pitch that is the increment from the start of one line of pixels to the start of the next line in bytes.
  [then]


  [ifdef] LTDC_LTDC_L2CFBLNR_DEF
    \
    \ @brief LTDC layer 2 color frame buffer line number register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLNBR                   \ [0x00 : 11] frame buffer line number These bits define the number of lines in the frame buffer that corresponds to the active high width.
  [then]


  [ifdef] LTDC_LTDC_L2CLUTWR_DEF
    \
    \ @brief LTDC layer 2 CLUT write register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BLUE                      \ [0x00 : 8] blue value These bits configure the blue value.
    $08 constant LTDC_GREEN                     \ [0x08 : 8] green value These bits configure the green value.
    $10 constant LTDC_RED                       \ [0x10 : 8] red value These bits configure the red value.
    $18 constant LTDC_CLUTADD                   \ [0x18 : 8] CLUT address These bits configure the CLUT address (color position within the CLUT) of each RGB value.
  [then]

  \
  \ @brief LTDC
  \
  $08 constant LTDC_LTDC_SSCR           \ LTDC synchronization size configuration register
  $0C constant LTDC_LTDC_BPCR           \ LTDC back porch configuration register
  $10 constant LTDC_LTDC_AWCR           \ LTDC active width configuration register
  $14 constant LTDC_LTDC_TWCR           \ LTDC total width configuration register
  $18 constant LTDC_LTDC_GCR            \ LTDC global control register
  $24 constant LTDC_LTDC_SRCR           \ LTDC shadow reload configuration register
  $2C constant LTDC_LTDC_BCCR           \ LTDC background color configuration register
  $34 constant LTDC_LTDC_IER            \ LTDC interrupt enable register
  $38 constant LTDC_LTDC_ISR            \ LTDC interrupt status register
  $3C constant LTDC_LTDC_ICR            \ clears the line interrupt flag
  $40 constant LTDC_LTDC_LIPCR          \ LTDC line interrupt position configuration register
  $44 constant LTDC_LTDC_CPSR           \ current Y position These bits return the current Y position.
  $48 constant LTDC_LTDC_CDSR           \ LTDC current display status register
  $84 constant LTDC_LTDC_L1CR           \ layer enable This bit is set and cleared by software.
  $88 constant LTDC_LTDC_L1WHPCR        \ LTDC layer 1 window horizontal position configuration register
  $8C constant LTDC_LTDC_L1WVPCR        \ LTDC layer 1 window vertical position configuration register
  $90 constant LTDC_LTDC_L1CKCR         \ LTDC layer 1 color keying configuration register
  $94 constant LTDC_LTDC_L1PFCR         \ LTDC layer 1 pixel format configuration register
  $98 constant LTDC_LTDC_L1CACR         \ LTDC layer 1 constant alpha configuration register
  $9C constant LTDC_LTDC_L1DCCR         \ LTDC layer 1 default color configuration register
  $A0 constant LTDC_LTDC_L1BFCR         \ LTDC layer 1 blending factors configuration register
  $AC constant LTDC_LTDC_L1CFBAR        \ LTDC layer 1 color frame buffer address register
  $B0 constant LTDC_LTDC_L1CFBLR        \ LTDC layer 1 color frame buffer length register
  $B4 constant LTDC_LTDC_L1CFBLNR       \ LTDC layer 1 color frame buffer line number register
  $C4 constant LTDC_LTDC_L1CLUTWR       \ LTDC layer 1 CLUT write register
  $104 constant LTDC_LTDC_L2CR          \ layer enable This bit is set and cleared by software.
  $108 constant LTDC_LTDC_L2WHPCR       \ LTDC layer 2 window horizontal position configuration register
  $10C constant LTDC_LTDC_L2WVPCR       \ LTDC layer 2 window vertical position configuration register
  $110 constant LTDC_LTDC_L2CKCR        \ LTDC layer 2 color keying configuration register
  $114 constant LTDC_LTDC_L2PFCR        \ LTDC layer 2 pixel format configuration register
  $118 constant LTDC_LTDC_L2CACR        \ LTDC layer 2 constant alpha configuration register
  $11C constant LTDC_LTDC_L2DCCR        \ LTDC layer 2 default color configuration register
  $120 constant LTDC_LTDC_L2BFCR        \ LTDC layer 2 blending factors configuration register
  $12C constant LTDC_LTDC_L2CFBAR       \ LTDC layer 2 color frame buffer address register
  $130 constant LTDC_LTDC_L2CFBLR       \ LTDC layer 2 color frame buffer length register
  $134 constant LTDC_LTDC_L2CFBLNR      \ LTDC layer 2 color frame buffer line number register
  $144 constant LTDC_LTDC_L2CLUTWR      \ LTDC layer 2 CLUT write register

: LTDC_DEF ; [then]
