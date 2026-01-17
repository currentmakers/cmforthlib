\
\ @file ltdc.fs
\ @brief LTDC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LTDC_DEF

  [ifdef] LTDC_LTDC_IDR_DEF
    \
    \ @brief LTDC identification register
    \ Address offset: 0x00
    \ Reset value: 0x00010300
    \
    $00 constant LTDC_REV                       \ [0x00 : 8] REV
    $08 constant LTDC_MINVER                    \ [0x08 : 8] MINVER
    $10 constant LTDC_MAJVER                    \ [0x10 : 8] MAJVER
  [then]


  [ifdef] LTDC_LTDC_LCR_DEF
    \
    \ @brief LDTC layer count register
    \ Address offset: 0x04
    \ Reset value: 0x00000002
    \
    $00 constant LTDC_LNBR                      \ [0x00 : 8] LNBR
  [then]


  [ifdef] LTDC_LTDC_SSCR_DEF
    \
    \ @brief This register defines the number of horizontal synchronization pixels minus 1 and the number of vertical synchronization lines minus 1. Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_VSH                       \ [0x00 : 12] VSH
    $10 constant LTDC_HSW                       \ [0x10 : 12] HSW
  [then]


  [ifdef] LTDC_LTDC_BPCR_DEF
    \
    \ @brief This register defines the accumulated number of horizontal synchronization and back porch pixels minus 1 (HSYNCwidth+HBP-1) and the accumulated number of vertical synchronization and back porch lines minus 1 (VSYNCheight+VBP-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AVBP                      \ [0x00 : 12] AVBP
    $10 constant LTDC_AHBP                      \ [0x10 : 12] AHBP
  [then]


  [ifdef] LTDC_LTDC_AWCR_DEF
    \
    \ @brief This register defines the accumulated number of horizontal synchronization, back porch and active pixels minus 1 (HSYNC width+HBP+activewidth-1) and the accumulated number of vertical synchronization, back porch lines and active lines minus 1 (VSYNCheight+BVBP+activeheight-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AAH                       \ [0x00 : 12] AAH
    $10 constant LTDC_AAW                       \ [0x10 : 12] AAW
  [then]


  [ifdef] LTDC_LTDC_TWCR_DEF
    \
    \ @brief This register defines the accumulated number of horizontal synchronization, back porch, active and front porch pixels minus 1 (HSYNCwidth+HBP+activewidth+HFP-1) and the accumulated number of vertical synchronization, back porch lines, active and front lines minus 1 (VSYNCheight+BVBP+activeheight+VFP-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_TOTALH                    \ [0x00 : 12] TOTALH
    $10 constant LTDC_TOTALW                    \ [0x10 : 12] TOTALW
  [then]


  [ifdef] LTDC_LTDC_GCR_DEF
    \
    \ @brief This register defines the global configuration of the LCD-TFT controller.
    \ Address offset: 0x18
    \ Reset value: 0x00002220
    \
    $00 constant LTDC_LTDCEN                    \ [0x00] LTDCEN
    $04 constant LTDC_DBW                       \ [0x04 : 3] DBW
    $08 constant LTDC_DGW                       \ [0x08 : 3] DGW
    $0c constant LTDC_DRW                       \ [0x0c : 3] DRW
    $10 constant LTDC_DEN                       \ [0x10] DEN
    $1c constant LTDC_PCPOL                     \ [0x1c] PCPOL
    $1d constant LTDC_DEPOL                     \ [0x1d] DEPOL
    $1e constant LTDC_VSPOL                     \ [0x1e] VSPOL
    $1f constant LTDC_HSPOL                     \ [0x1f] HSPOL
  [then]


  [ifdef] LTDC_LTDC_GC1R_DEF
    \
    \ @brief LTDC global configuration 1 register
    \ Address offset: 0x1C
    \ Reset value: 0x6BE2D888
    \
    $00 constant LTDC_WBCH                      \ [0x00 : 4] WBCH
    $04 constant LTDC_WGCH                      \ [0x04 : 4] WGCH
    $08 constant LTDC_WRCH                      \ [0x08 : 4] WRCH
    $0c constant LTDC_PRBEN                     \ [0x0c] PRBEN
    $0e constant LTDC_DT                        \ [0x0e : 2] DT
    $11 constant LTDC_GCT                       \ [0x11 : 3] GCT
    $15 constant LTDC_SHREN                     \ [0x15] SHREN
    $16 constant LTDC_BCP                       \ [0x16] BCP
    $17 constant LTDC_BBEN                      \ [0x17] BBEN
    $18 constant LTDC_LNIP                      \ [0x18] LNIP
    $19 constant LTDC_TP                        \ [0x19] TP
    $1a constant LTDC_IPP                       \ [0x1a] IPP
    $1b constant LTDC_SPP                       \ [0x1b] SPP
    $1c constant LTDC_DWP                       \ [0x1c] DWP
    $1d constant LTDC_STREN                     \ [0x1d] STREN
    $1f constant LTDC_BMEN                      \ [0x1f] BMEN
  [then]


  [ifdef] LTDC_LTDC_GC2R_DEF
    \
    \ @brief LTDC global configuration 2 register
    \ Address offset: 0x20
    \ Reset value: 0x00000030
    \
    $00 constant LTDC_EDCEN                     \ [0x00] EDCEN
    $01 constant LTDC_STSAEN                    \ [0x01] STSAEN
    $02 constant LTDC_DVAEN                     \ [0x02] DVAEN
    $03 constant LTDC_DPAEN                     \ [0x03] DPAEN
    $04 constant LTDC_BW                        \ [0x04 : 3] BW
    $07 constant LTDC_EDCA                      \ [0x07] EDCA
  [then]


  [ifdef] LTDC_LTDC_SRCR_DEF
    \
    \ @brief This register allows to reload either immediately or during the vertical blanking period, the shadow registers values to the active registers. The shadow registers are all Layer1 and Layer2 registers except the LTDC_L1CLUTWR and the LTDC_L2CLUTWR.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_IMR                       \ [0x00] IMR
    $01 constant LTDC_VBR                       \ [0x01] VBR
  [then]


  [ifdef] LTDC_LTDC_BCCR_DEF
    \
    \ @brief This register defines the background color (RGB888).
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BCBLUE                    \ [0x00 : 8] BCBLUE
    $08 constant LTDC_BCGREEN                   \ [0x08 : 8] BCGREEN
    $10 constant LTDC_BCRED                     \ [0x10 : 8] BCRED
  [then]


  [ifdef] LTDC_LTDC_IER_DEF
    \
    \ @brief This register determines which status flags generate an interrupt request by setting the corresponding bit to 1.
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIE                       \ [0x00] LIE
    $01 constant LTDC_FUIE                      \ [0x01] FUIE
    $02 constant LTDC_TERRIE                    \ [0x02] TERRIE
    $03 constant LTDC_RRIE                      \ [0x03] RRIE
  [then]


  [ifdef] LTDC_LTDC_ISR_DEF
    \
    \ @brief This register returns the interrupt status flag.
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIF                       \ [0x00] LIF
    $01 constant LTDC_FUIF                      \ [0x01] FUIF
    $02 constant LTDC_TERRIF                    \ [0x02] TERRIF
    $03 constant LTDC_RRIF                      \ [0x03] RRIF
  [then]


  [ifdef] LTDC_LTDC_ICR_DEF
    \
    \ @brief LTDC Interrupt Clear Register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CLIF                      \ [0x00] CLIF
    $01 constant LTDC_CFUIF                     \ [0x01] CFUIF
    $02 constant LTDC_CTERRIF                   \ [0x02] CTERRIF
    $03 constant LTDC_CRRIF                     \ [0x03] CRRIF
  [then]


  [ifdef] LTDC_LTDC_LIPCR_DEF
    \
    \ @brief This register defines the position of the line interrupt. The line value to be programmed depends on the timings parameters. Refer to Figure274.
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIPOS                     \ [0x00 : 12] LIPOS
  [then]


  [ifdef] LTDC_LTDC_CPSR_DEF
    \
    \ @brief LTDC current position status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CYPOS                     \ [0x00 : 16] CYPOS
    $10 constant LTDC_CXPOS                     \ [0x10 : 16] CXPOS
  [then]


  [ifdef] LTDC_LTDC_CDSR_DEF
    \
    \ @brief This register returns the status of the current display phase which is controlled by the HSYNC, VSYNC, and horizontal/vertical DE signals. Example: if the current display phase is the vertical synchronization, the VSYNCS bit is set (active high). If the current display phase is the horizontal synchronization, the HSYNCS bit is active high.
    \ Address offset: 0x48
    \ Reset value: 0x0000000F
    \
    $00 constant LTDC_VDES                      \ [0x00] VDES
    $01 constant LTDC_HDES                      \ [0x01] HDES
    $02 constant LTDC_VSYNCS                    \ [0x02] VSYNCS
    $03 constant LTDC_HSYNCS                    \ [0x03] HSYNCS
  [then]


  [ifdef] LTDC_LTDC_L1CR_DEF
    \
    \ @brief LTDC layer 1 control register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LEN                       \ [0x00] LEN
    $01 constant LTDC_COLKEN                    \ [0x01] COLKEN
    $04 constant LTDC_CLUTEN                    \ [0x04] CLUTEN
  [then]


  [ifdef] LTDC_LTDC_L1WHPCR_DEF
    \
    \ @brief This register defines the horizontal position (first and last pixel) of the layer 1 or 2 window. The first visible pixel of a line is the programmed value of AHBP[11:0] bits + 1 in the LTDC_BPCR register. The last visible pixel of a line is the programmed value of AAW[11:0] bits in the LTDC_AWCR register.
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WHSTPOS                   \ [0x00 : 12] WHSTPOS
    $10 constant LTDC_WHSPPOS                   \ [0x10 : 12] WHSPPOS
  [then]


  [ifdef] LTDC_LTDC_L1WVPCR_DEF
    \
    \ @brief This register defines the vertical position (first and last line) of the layer1 or 2 window. The first visible line of a frame is the programmed value of AVBP[11:0] bits + 1 in the register LTDC_BPCR register. The last visible line of a frame is the programmed value of AAH[11:0] bits in the LTDC_AWCR register.
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WVSTPOS                   \ [0x00 : 12] WVSTPOS
    $10 constant LTDC_WVSPPOS                   \ [0x10 : 12] WVSPPOS
  [then]


  [ifdef] LTDC_LTDC_L1CKCR_DEF
    \
    \ @brief This register defines the color key value (RGB), that is used by the color keying.
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CKBLUE                    \ [0x00 : 8] CKBLUE
    $08 constant LTDC_CKGREEN                   \ [0x08 : 8] CKGREEN
    $10 constant LTDC_CKRED                     \ [0x10 : 8] CKRED
  [then]


  [ifdef] LTDC_LTDC_L1PFCR_DEF
    \
    \ @brief This register defines the pixel format that is used for the stored data in the frame buffer of a layer. The pixel data is read from the frame buffer and then transformed to the internal format 8888 (ARGB).
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_PF                        \ [0x00 : 3] PF
  [then]


  [ifdef] LTDC_LTDC_L1CACR_DEF
    \
    \ @brief This register defines the constant alpha value (divided by 255 by hardware), that is used in the alpha blending. Refer to LTDC_LxBFCR register.
    \ Address offset: 0x98
    \ Reset value: 0x000000FF
    \
    $00 constant LTDC_CONSTA                    \ [0x00 : 8] CONSTA
  [then]


  [ifdef] LTDC_LTDC_L1DCCR_DEF
    \
    \ @brief This register defines the default color of a layer in the format ARGB. The default color is used outside the defined layer window or when a layer is disabled. The reset value of 0x00000000 defines a transparent black color.
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_DCBLUE                    \ [0x00 : 8] DCBLUE
    $08 constant LTDC_DCGREEN                   \ [0x08 : 8] DCGREEN
    $10 constant LTDC_DCRED                     \ [0x10 : 8] DCRED
    $18 constant LTDC_DCALPHA                   \ [0x18 : 8] DCALPHA
  [then]


  [ifdef] LTDC_LTDC_L1BFCR_DEF
    \
    \ @brief This register defines the blending factors F1 and F2. The general blending formula is: BC = BF1 x C + BF2 x Cs BC = blended color BF1 = blend factor 1 C = current layer color BF2 = blend factor 2 Cs = subjacent layers blended color
    \ Address offset: 0xA0
    \ Reset value: 0x00000607
    \
    $00 constant LTDC_BF2                       \ [0x00 : 3] BF2
    $08 constant LTDC_BF1                       \ [0x08 : 3] BF1
  [then]


  [ifdef] LTDC_LTDC_L1CFBAR_DEF
    \
    \ @brief This register defines the color frame buffer start address which has to point to the address where the pixel data of the top left pixel of a layer is stored in the frame buffer.
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBADD                    \ [0x00 : 32] CFBADD
  [then]


  [ifdef] LTDC_LTDC_L1CFBLR_DEF
    \
    \ @brief This register defines the color frame buffer line length and pitch.
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLL                     \ [0x00 : 14] CFBLL
    $10 constant LTDC_CFBP                      \ [0x10 : 14] CFBP
  [then]


  [ifdef] LTDC_LTDC_L1CFBLNR_DEF
    \
    \ @brief This register defines the number of lines in the color frame buffer.
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLNBR                   \ [0x00 : 12] CFBLNBR
  [then]


  [ifdef] LTDC_LTDC_L1CLUTWR_DEF
    \
    \ @brief This register defines the CLUT address and the RGB value.
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BLUE                      \ [0x00 : 8] BLUE
    $08 constant LTDC_GREEN                     \ [0x08 : 8] GREEN
    $10 constant LTDC_RED                       \ [0x10 : 8] RED
    $18 constant LTDC_CLUTADD                   \ [0x18 : 8] CLUTADD
  [then]


  [ifdef] LTDC_LTDC_L2CR_DEF
    \
    \ @brief LTDC layer 2 control register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LEN                       \ [0x00] LEN
    $01 constant LTDC_COLKEN                    \ [0x01] COLKEN
    $04 constant LTDC_CLUTEN                    \ [0x04] CLUTEN
  [then]


  [ifdef] LTDC_LTDC_L2WHPCR_DEF
    \
    \ @brief This register defines the horizontal position (first and last pixel) of the layer 1 or 2 window. The first visible pixel of a line is the programmed value of AHBP[11:0] bits + 1 in the LTDC_BPCR register. The last visible pixel of a line is the programmed value of AAW[11:0] bits in the LTDC_AWCR register.
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WHSTPOS                   \ [0x00 : 12] WHSTPOS
    $10 constant LTDC_WHSPPOS                   \ [0x10 : 12] WHSPPOS
  [then]


  [ifdef] LTDC_LTDC_L2WVPCR_DEF
    \
    \ @brief This register defines the vertical position (first and last line) of the layer1 or 2 window. The first visible line of a frame is the programmed value of AVBP[11:0] bits + 1 in the register LTDC_BPCR register. The last visible line of a frame is the programmed value of AAH[11:0] bits in the LTDC_AWCR register.
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WVSTPOS                   \ [0x00 : 12] WVSTPOS
    $10 constant LTDC_WVSPPOS                   \ [0x10 : 12] WVSPPOS
  [then]


  [ifdef] LTDC_LTDC_L2CKCR_DEF
    \
    \ @brief This register defines the color key value (RGB), that is used by the color keying.
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CKBLUE                    \ [0x00 : 8] CKBLUE
    $08 constant LTDC_CKGREEN                   \ [0x08 : 8] CKGREEN
    $10 constant LTDC_CKRED                     \ [0x10 : 8] CKRED
  [then]


  [ifdef] LTDC_LTDC_L2PFCR_DEF
    \
    \ @brief This register defines the pixel format that is used for the stored data in the frame buffer of a layer. The pixel data is read from the frame buffer and then transformed to the internal format 8888 (ARGB).
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_PF                        \ [0x00 : 3] PF
  [then]


  [ifdef] LTDC_LTDC_L2CACR_DEF
    \
    \ @brief This register defines the constant alpha value (divided by 255 by hardware), that is used in the alpha blending. Refer to LTDC_LxBFCR register.
    \ Address offset: 0x118
    \ Reset value: 0x000000FF
    \
    $00 constant LTDC_CONSTA                    \ [0x00 : 8] CONSTA
  [then]


  [ifdef] LTDC_LTDC_L2DCCR_DEF
    \
    \ @brief This register defines the default color of a layer in the format ARGB. The default color is used outside the defined layer window or when a layer is disabled. The reset value of 0x00000000 defines a transparent black color.
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_DCBLUE                    \ [0x00 : 8] DCBLUE
    $08 constant LTDC_DCGREEN                   \ [0x08 : 8] DCGREEN
    $10 constant LTDC_DCRED                     \ [0x10 : 8] DCRED
    $18 constant LTDC_DCALPHA                   \ [0x18 : 8] DCALPHA
  [then]


  [ifdef] LTDC_LTDC_L2BFCR_DEF
    \
    \ @brief This register defines the blending factors F1 and F2. The general blending formula is: BC = BF1 x C + BF2 x Cs BC = blended color BF1 = blend factor 1 C = current layer color BF2 = blend factor 2 Cs = subjacent layers blended color
    \ Address offset: 0x120
    \ Reset value: 0x00000607
    \
    $00 constant LTDC_BF2                       \ [0x00 : 3] BF2
    $08 constant LTDC_BF1                       \ [0x08 : 3] BF1
  [then]


  [ifdef] LTDC_LTDC_L2CFBAR_DEF
    \
    \ @brief This register defines the color frame buffer start address which has to point to the address where the pixel data of the top left pixel of a layer is stored in the frame buffer.
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBADD                    \ [0x00 : 32] CFBADD
  [then]


  [ifdef] LTDC_LTDC_L2CFBLR_DEF
    \
    \ @brief This register defines the color frame buffer line length and pitch.
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLL                     \ [0x00 : 14] CFBLL
    $10 constant LTDC_CFBP                      \ [0x10 : 14] CFBP
  [then]


  [ifdef] LTDC_LTDC_L2CFBLNR_DEF
    \
    \ @brief This register defines the number of lines in the color frame buffer.
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLNBR                   \ [0x00 : 12] CFBLNBR
  [then]


  [ifdef] LTDC_LTDC_L2CLUTWR_DEF
    \
    \ @brief This register defines the CLUT address and the RGB value.
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BLUE                      \ [0x00 : 8] BLUE
    $08 constant LTDC_GREEN                     \ [0x08 : 8] GREEN
    $10 constant LTDC_RED                       \ [0x10 : 8] RED
    $18 constant LTDC_CLUTADD                   \ [0x18 : 8] CLUTADD
  [then]

  \
  \ @brief LTDC
  \
  $00 constant LTDC_LTDC_IDR            \ LTDC identification register
  $04 constant LTDC_LTDC_LCR            \ LDTC layer count register
  $08 constant LTDC_LTDC_SSCR           \ This register defines the number of horizontal synchronization pixels minus 1 and the number of vertical synchronization lines minus 1. Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
  $0C constant LTDC_LTDC_BPCR           \ This register defines the accumulated number of horizontal synchronization and back porch pixels minus 1 (HSYNCwidth+HBP-1) and the accumulated number of vertical synchronization and back porch lines minus 1 (VSYNCheight+VBP-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
  $10 constant LTDC_LTDC_AWCR           \ This register defines the accumulated number of horizontal synchronization, back porch and active pixels minus 1 (HSYNC width+HBP+activewidth-1) and the accumulated number of vertical synchronization, back porch lines and active lines minus 1 (VSYNCheight+BVBP+activeheight-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
  $14 constant LTDC_LTDC_TWCR           \ This register defines the accumulated number of horizontal synchronization, back porch, active and front porch pixels minus 1 (HSYNCwidth+HBP+activewidth+HFP-1) and the accumulated number of vertical synchronization, back porch lines, active and front lines minus 1 (VSYNCheight+BVBP+activeheight+VFP-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
  $18 constant LTDC_LTDC_GCR            \ This register defines the global configuration of the LCD-TFT controller.
  $1C constant LTDC_LTDC_GC1R           \ LTDC global configuration 1 register
  $20 constant LTDC_LTDC_GC2R           \ LTDC global configuration 2 register
  $24 constant LTDC_LTDC_SRCR           \ This register allows to reload either immediately or during the vertical blanking period, the shadow registers values to the active registers. The shadow registers are all Layer1 and Layer2 registers except the LTDC_L1CLUTWR and the LTDC_L2CLUTWR.
  $2C constant LTDC_LTDC_BCCR           \ This register defines the background color (RGB888).
  $34 constant LTDC_LTDC_IER            \ This register determines which status flags generate an interrupt request by setting the corresponding bit to 1.
  $38 constant LTDC_LTDC_ISR            \ This register returns the interrupt status flag.
  $3C constant LTDC_LTDC_ICR            \ LTDC Interrupt Clear Register
  $40 constant LTDC_LTDC_LIPCR          \ This register defines the position of the line interrupt. The line value to be programmed depends on the timings parameters. Refer to Figure274.
  $44 constant LTDC_LTDC_CPSR           \ LTDC current position status register
  $48 constant LTDC_LTDC_CDSR           \ This register returns the status of the current display phase which is controlled by the HSYNC, VSYNC, and horizontal/vertical DE signals. Example: if the current display phase is the vertical synchronization, the VSYNCS bit is set (active high). If the current display phase is the horizontal synchronization, the HSYNCS bit is active high.
  $84 constant LTDC_LTDC_L1CR           \ LTDC layer 1 control register
  $88 constant LTDC_LTDC_L1WHPCR        \ This register defines the horizontal position (first and last pixel) of the layer 1 or 2 window. The first visible pixel of a line is the programmed value of AHBP[11:0] bits + 1 in the LTDC_BPCR register. The last visible pixel of a line is the programmed value of AAW[11:0] bits in the LTDC_AWCR register.
  $8C constant LTDC_LTDC_L1WVPCR        \ This register defines the vertical position (first and last line) of the layer1 or 2 window. The first visible line of a frame is the programmed value of AVBP[11:0] bits + 1 in the register LTDC_BPCR register. The last visible line of a frame is the programmed value of AAH[11:0] bits in the LTDC_AWCR register.
  $90 constant LTDC_LTDC_L1CKCR         \ This register defines the color key value (RGB), that is used by the color keying.
  $94 constant LTDC_LTDC_L1PFCR         \ This register defines the pixel format that is used for the stored data in the frame buffer of a layer. The pixel data is read from the frame buffer and then transformed to the internal format 8888 (ARGB).
  $98 constant LTDC_LTDC_L1CACR         \ This register defines the constant alpha value (divided by 255 by hardware), that is used in the alpha blending. Refer to LTDC_LxBFCR register.
  $9C constant LTDC_LTDC_L1DCCR         \ This register defines the default color of a layer in the format ARGB. The default color is used outside the defined layer window or when a layer is disabled. The reset value of 0x00000000 defines a transparent black color.
  $A0 constant LTDC_LTDC_L1BFCR         \ This register defines the blending factors F1 and F2. The general blending formula is: BC = BF1 x C + BF2 x Cs BC = blended color BF1 = blend factor 1 C = current layer color BF2 = blend factor 2 Cs = subjacent layers blended color
  $AC constant LTDC_LTDC_L1CFBAR        \ This register defines the color frame buffer start address which has to point to the address where the pixel data of the top left pixel of a layer is stored in the frame buffer.
  $B0 constant LTDC_LTDC_L1CFBLR        \ This register defines the color frame buffer line length and pitch.
  $B4 constant LTDC_LTDC_L1CFBLNR       \ This register defines the number of lines in the color frame buffer.
  $C4 constant LTDC_LTDC_L1CLUTWR       \ This register defines the CLUT address and the RGB value.
  $104 constant LTDC_LTDC_L2CR          \ LTDC layer 2 control register
  $108 constant LTDC_LTDC_L2WHPCR       \ This register defines the horizontal position (first and last pixel) of the layer 1 or 2 window. The first visible pixel of a line is the programmed value of AHBP[11:0] bits + 1 in the LTDC_BPCR register. The last visible pixel of a line is the programmed value of AAW[11:0] bits in the LTDC_AWCR register.
  $10C constant LTDC_LTDC_L2WVPCR       \ This register defines the vertical position (first and last line) of the layer1 or 2 window. The first visible line of a frame is the programmed value of AVBP[11:0] bits + 1 in the register LTDC_BPCR register. The last visible line of a frame is the programmed value of AAH[11:0] bits in the LTDC_AWCR register.
  $110 constant LTDC_LTDC_L2CKCR        \ This register defines the color key value (RGB), that is used by the color keying.
  $114 constant LTDC_LTDC_L2PFCR        \ This register defines the pixel format that is used for the stored data in the frame buffer of a layer. The pixel data is read from the frame buffer and then transformed to the internal format 8888 (ARGB).
  $118 constant LTDC_LTDC_L2CACR        \ This register defines the constant alpha value (divided by 255 by hardware), that is used in the alpha blending. Refer to LTDC_LxBFCR register.
  $11C constant LTDC_LTDC_L2DCCR        \ This register defines the default color of a layer in the format ARGB. The default color is used outside the defined layer window or when a layer is disabled. The reset value of 0x00000000 defines a transparent black color.
  $120 constant LTDC_LTDC_L2BFCR        \ This register defines the blending factors F1 and F2. The general blending formula is: BC = BF1 x C + BF2 x Cs BC = blended color BF1 = blend factor 1 C = current layer color BF2 = blend factor 2 Cs = subjacent layers blended color
  $12C constant LTDC_LTDC_L2CFBAR       \ This register defines the color frame buffer start address which has to point to the address where the pixel data of the top left pixel of a layer is stored in the frame buffer.
  $130 constant LTDC_LTDC_L2CFBLR       \ This register defines the color frame buffer line length and pitch.
  $134 constant LTDC_LTDC_L2CFBLNR      \ This register defines the number of lines in the color frame buffer.
  $144 constant LTDC_LTDC_L2CLUTWR      \ This register defines the CLUT address and the RGB value.

: LTDC_DEF ; [then]
