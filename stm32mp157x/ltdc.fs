\
\ @file ltdc.fs
\ @brief LTDC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LTDC identification register
\ Address offset: 0x00
\ Reset value: 0x00010300
\

$000000ff constant LTDC_LTDC_IDR_REV                                \ REV
$0000ff00 constant LTDC_LTDC_IDR_MINVER                             \ MINVER
$00ff0000 constant LTDC_LTDC_IDR_MAJVER                             \ MAJVER


\
\ @brief LDTC layer count register
\ Address offset: 0x04
\ Reset value: 0x00000002
\

$000000ff constant LTDC_LTDC_LCR_LNBR                               \ LNBR


\
\ @brief This register defines the number of horizontal synchronization pixels minus 1 and the number of vertical synchronization lines minus 1. Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_SSCR_VSH                               \ VSH
$0fff0000 constant LTDC_LTDC_SSCR_HSW                               \ HSW


\
\ @brief This register defines the accumulated number of horizontal synchronization and back porch pixels minus 1 (HSYNCwidth+HBP-1) and the accumulated number of vertical synchronization and back porch lines minus 1 (VSYNCheight+VBP-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_BPCR_AVBP                              \ AVBP
$0fff0000 constant LTDC_LTDC_BPCR_AHBP                              \ AHBP


\
\ @brief This register defines the accumulated number of horizontal synchronization, back porch and active pixels minus 1 (HSYNC width+HBP+activewidth-1) and the accumulated number of vertical synchronization, back porch lines and active lines minus 1 (VSYNCheight+BVBP+activeheight-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_AWCR_AAH                               \ AAH
$0fff0000 constant LTDC_LTDC_AWCR_AAW                               \ AAW


\
\ @brief This register defines the accumulated number of horizontal synchronization, back porch, active and front porch pixels minus 1 (HSYNCwidth+HBP+activewidth+HFP-1) and the accumulated number of vertical synchronization, back porch lines, active and front lines minus 1 (VSYNCheight+BVBP+activeheight+VFP-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_TWCR_TOTALH                            \ TOTALH
$0fff0000 constant LTDC_LTDC_TWCR_TOTALW                            \ TOTALW


\
\ @brief This register defines the global configuration of the LCD-TFT controller.
\ Address offset: 0x18
\ Reset value: 0x00002220
\

$00000001 constant LTDC_LTDC_GCR_LTDCEN                             \ LTDCEN
$00000070 constant LTDC_LTDC_GCR_DBW                                \ DBW
$00000700 constant LTDC_LTDC_GCR_DGW                                \ DGW
$00007000 constant LTDC_LTDC_GCR_DRW                                \ DRW
$00010000 constant LTDC_LTDC_GCR_DEN                                \ DEN
$10000000 constant LTDC_LTDC_GCR_PCPOL                              \ PCPOL
$20000000 constant LTDC_LTDC_GCR_DEPOL                              \ DEPOL
$40000000 constant LTDC_LTDC_GCR_VSPOL                              \ VSPOL
$80000000 constant LTDC_LTDC_GCR_HSPOL                              \ HSPOL


\
\ @brief LTDC global configuration 1 register
\ Address offset: 0x1C
\ Reset value: 0x6BE2D888
\

$0000000f constant LTDC_LTDC_GC1R_WBCH                              \ WBCH
$000000f0 constant LTDC_LTDC_GC1R_WGCH                              \ WGCH
$00000f00 constant LTDC_LTDC_GC1R_WRCH                              \ WRCH
$00001000 constant LTDC_LTDC_GC1R_PRBEN                             \ PRBEN
$0000c000 constant LTDC_LTDC_GC1R_DT                                \ DT
$000e0000 constant LTDC_LTDC_GC1R_GCT                               \ GCT
$00200000 constant LTDC_LTDC_GC1R_SHREN                             \ SHREN
$00400000 constant LTDC_LTDC_GC1R_BCP                               \ BCP
$00800000 constant LTDC_LTDC_GC1R_BBEN                              \ BBEN
$01000000 constant LTDC_LTDC_GC1R_LNIP                              \ LNIP
$02000000 constant LTDC_LTDC_GC1R_TP                                \ TP
$04000000 constant LTDC_LTDC_GC1R_IPP                               \ IPP
$08000000 constant LTDC_LTDC_GC1R_SPP                               \ SPP
$10000000 constant LTDC_LTDC_GC1R_DWP                               \ DWP
$20000000 constant LTDC_LTDC_GC1R_STREN                             \ STREN
$80000000 constant LTDC_LTDC_GC1R_BMEN                              \ BMEN


\
\ @brief LTDC global configuration 2 register
\ Address offset: 0x20
\ Reset value: 0x00000030
\

$00000001 constant LTDC_LTDC_GC2R_EDCEN                             \ EDCEN
$00000002 constant LTDC_LTDC_GC2R_STSAEN                            \ STSAEN
$00000004 constant LTDC_LTDC_GC2R_DVAEN                             \ DVAEN
$00000008 constant LTDC_LTDC_GC2R_DPAEN                             \ DPAEN
$00000070 constant LTDC_LTDC_GC2R_BW                                \ BW
$00000080 constant LTDC_LTDC_GC2R_EDCA                              \ EDCA


\
\ @brief This register allows to reload either immediately or during the vertical blanking period, the shadow registers values to the active registers. The shadow registers are all Layer1 and Layer2 registers except the LTDC_L1CLUTWR and the LTDC_L2CLUTWR.
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_SRCR_IMR                               \ IMR
$00000002 constant LTDC_LTDC_SRCR_VBR                               \ VBR


\
\ @brief This register defines the background color (RGB888).
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_BCCR_BCBLUE                            \ BCBLUE
$0000ff00 constant LTDC_LTDC_BCCR_BCGREEN                           \ BCGREEN
$00ff0000 constant LTDC_LTDC_BCCR_BCRED                             \ BCRED


\
\ @brief This register determines which status flags generate an interrupt request by setting the corresponding bit to 1.
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_IER_LIE                                \ LIE
$00000002 constant LTDC_LTDC_IER_FUIE                               \ FUIE
$00000004 constant LTDC_LTDC_IER_TERRIE                             \ TERRIE
$00000008 constant LTDC_LTDC_IER_RRIE                               \ RRIE


\
\ @brief This register returns the interrupt status flag.
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_ISR_LIF                                \ LIF
$00000002 constant LTDC_LTDC_ISR_FUIF                               \ FUIF
$00000004 constant LTDC_LTDC_ISR_TERRIF                             \ TERRIF
$00000008 constant LTDC_LTDC_ISR_RRIF                               \ RRIF


\
\ @brief LTDC Interrupt Clear Register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_ICR_CLIF                               \ CLIF
$00000002 constant LTDC_LTDC_ICR_CFUIF                              \ CFUIF
$00000004 constant LTDC_LTDC_ICR_CTERRIF                            \ CTERRIF
$00000008 constant LTDC_LTDC_ICR_CRRIF                              \ CRRIF


\
\ @brief This register defines the position of the line interrupt. The line value to be programmed depends on the timings parameters. Refer to Figure274.
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_LIPCR_LIPOS                            \ LIPOS


\
\ @brief LTDC current position status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_LTDC_CPSR_CYPOS                             \ CYPOS
$ffff0000 constant LTDC_LTDC_CPSR_CXPOS                             \ CXPOS


\
\ @brief This register returns the status of the current display phase which is controlled by the HSYNC, VSYNC, and horizontal/vertical DE signals. Example: if the current display phase is the vertical synchronization, the VSYNCS bit is set (active high). If the current display phase is the horizontal synchronization, the HSYNCS bit is active high.
\ Address offset: 0x48
\ Reset value: 0x0000000F
\

$00000001 constant LTDC_LTDC_CDSR_VDES                              \ VDES
$00000002 constant LTDC_LTDC_CDSR_HDES                              \ HDES
$00000004 constant LTDC_LTDC_CDSR_VSYNCS                            \ VSYNCS
$00000008 constant LTDC_LTDC_CDSR_HSYNCS                            \ HSYNCS


\
\ @brief LTDC layer 1 control register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_L1CR_LEN                               \ LEN
$00000002 constant LTDC_LTDC_L1CR_COLKEN                            \ COLKEN
$00000010 constant LTDC_LTDC_L1CR_CLUTEN                            \ CLUTEN


\
\ @brief This register defines the horizontal position (first and last pixel) of the layer 1 or 2 window. The first visible pixel of a line is the programmed value of AHBP[11:0] bits + 1 in the LTDC_BPCR register. The last visible pixel of a line is the programmed value of AAW[11:0] bits in the LTDC_AWCR register.
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_L1WHPCR_WHSTPOS                        \ WHSTPOS
$0fff0000 constant LTDC_LTDC_L1WHPCR_WHSPPOS                        \ WHSPPOS


\
\ @brief This register defines the vertical position (first and last line) of the layer1 or 2 window. The first visible line of a frame is the programmed value of AVBP[11:0] bits + 1 in the register LTDC_BPCR register. The last visible line of a frame is the programmed value of AAH[11:0] bits in the LTDC_AWCR register.
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_L1WVPCR_WVSTPOS                        \ WVSTPOS
$0fff0000 constant LTDC_LTDC_L1WVPCR_WVSPPOS                        \ WVSPPOS


\
\ @brief This register defines the color key value (RGB), that is used by the color keying.
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L1CKCR_CKBLUE                          \ CKBLUE
$0000ff00 constant LTDC_LTDC_L1CKCR_CKGREEN                         \ CKGREEN
$00ff0000 constant LTDC_LTDC_L1CKCR_CKRED                           \ CKRED


\
\ @brief This register defines the pixel format that is used for the stored data in the frame buffer of a layer. The pixel data is read from the frame buffer and then transformed to the internal format 8888 (ARGB).
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000007 constant LTDC_LTDC_L1PFCR_PF                              \ PF


\
\ @brief This register defines the constant alpha value (divided by 255 by hardware), that is used in the alpha blending. Refer to LTDC_LxBFCR register.
\ Address offset: 0x98
\ Reset value: 0x000000FF
\

$000000ff constant LTDC_LTDC_L1CACR_CONSTA                          \ CONSTA


\
\ @brief This register defines the default color of a layer in the format ARGB. The default color is used outside the defined layer window or when a layer is disabled. The reset value of 0x00000000 defines a transparent black color.
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L1DCCR_DCBLUE                          \ DCBLUE
$0000ff00 constant LTDC_LTDC_L1DCCR_DCGREEN                         \ DCGREEN
$00ff0000 constant LTDC_LTDC_L1DCCR_DCRED                           \ DCRED
$ff000000 constant LTDC_LTDC_L1DCCR_DCALPHA                         \ DCALPHA


\
\ @brief This register defines the blending factors F1 and F2. The general blending formula is: BC = BF1 x C + BF2 x Cs BC = blended color BF1 = blend factor 1 C = current layer color BF2 = blend factor 2 Cs = subjacent layers blended color
\ Address offset: 0xA0
\ Reset value: 0x00000607
\

$00000007 constant LTDC_LTDC_L1BFCR_BF2                             \ BF2
$00000700 constant LTDC_LTDC_L1BFCR_BF1                             \ BF1


\
\ @brief This register defines the color frame buffer start address which has to point to the address where the pixel data of the top left pixel of a layer is stored in the frame buffer.
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant LTDC_LTDC_L1CFBAR_CFBADD                         \ CFBADD


\
\ @brief This register defines the color frame buffer line length and pitch.
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00003fff constant LTDC_LTDC_L1CFBLR_CFBLL                          \ CFBLL
$3fff0000 constant LTDC_LTDC_L1CFBLR_CFBP                           \ CFBP


\
\ @brief This register defines the number of lines in the color frame buffer.
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_L1CFBLNR_CFBLNBR                       \ CFBLNBR


\
\ @brief This register defines the CLUT address and the RGB value.
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L1CLUTWR_BLUE                          \ BLUE
$0000ff00 constant LTDC_LTDC_L1CLUTWR_GREEN                         \ GREEN
$00ff0000 constant LTDC_LTDC_L1CLUTWR_RED                           \ RED
$ff000000 constant LTDC_LTDC_L1CLUTWR_CLUTADD                       \ CLUTADD


\
\ @brief LTDC layer 2 control register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant LTDC_LTDC_L2CR_LEN                               \ LEN
$00000002 constant LTDC_LTDC_L2CR_COLKEN                            \ COLKEN
$00000010 constant LTDC_LTDC_L2CR_CLUTEN                            \ CLUTEN


\
\ @brief This register defines the horizontal position (first and last pixel) of the layer 1 or 2 window. The first visible pixel of a line is the programmed value of AHBP[11:0] bits + 1 in the LTDC_BPCR register. The last visible pixel of a line is the programmed value of AAW[11:0] bits in the LTDC_AWCR register.
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_L2WHPCR_WHSTPOS                        \ WHSTPOS
$0fff0000 constant LTDC_LTDC_L2WHPCR_WHSPPOS                        \ WHSPPOS


\
\ @brief This register defines the vertical position (first and last line) of the layer1 or 2 window. The first visible line of a frame is the programmed value of AVBP[11:0] bits + 1 in the register LTDC_BPCR register. The last visible line of a frame is the programmed value of AAH[11:0] bits in the LTDC_AWCR register.
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_L2WVPCR_WVSTPOS                        \ WVSTPOS
$0fff0000 constant LTDC_LTDC_L2WVPCR_WVSPPOS                        \ WVSPPOS


\
\ @brief This register defines the color key value (RGB), that is used by the color keying.
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L2CKCR_CKBLUE                          \ CKBLUE
$0000ff00 constant LTDC_LTDC_L2CKCR_CKGREEN                         \ CKGREEN
$00ff0000 constant LTDC_LTDC_L2CKCR_CKRED                           \ CKRED


\
\ @brief This register defines the pixel format that is used for the stored data in the frame buffer of a layer. The pixel data is read from the frame buffer and then transformed to the internal format 8888 (ARGB).
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000007 constant LTDC_LTDC_L2PFCR_PF                              \ PF


\
\ @brief This register defines the constant alpha value (divided by 255 by hardware), that is used in the alpha blending. Refer to LTDC_LxBFCR register.
\ Address offset: 0x118
\ Reset value: 0x000000FF
\

$000000ff constant LTDC_LTDC_L2CACR_CONSTA                          \ CONSTA


\
\ @brief This register defines the default color of a layer in the format ARGB. The default color is used outside the defined layer window or when a layer is disabled. The reset value of 0x00000000 defines a transparent black color.
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L2DCCR_DCBLUE                          \ DCBLUE
$0000ff00 constant LTDC_LTDC_L2DCCR_DCGREEN                         \ DCGREEN
$00ff0000 constant LTDC_LTDC_L2DCCR_DCRED                           \ DCRED
$ff000000 constant LTDC_LTDC_L2DCCR_DCALPHA                         \ DCALPHA


\
\ @brief This register defines the blending factors F1 and F2. The general blending formula is: BC = BF1 x C + BF2 x Cs BC = blended color BF1 = blend factor 1 C = current layer color BF2 = blend factor 2 Cs = subjacent layers blended color
\ Address offset: 0x120
\ Reset value: 0x00000607
\

$00000007 constant LTDC_LTDC_L2BFCR_BF2                             \ BF2
$00000700 constant LTDC_LTDC_L2BFCR_BF1                             \ BF1


\
\ @brief This register defines the color frame buffer start address which has to point to the address where the pixel data of the top left pixel of a layer is stored in the frame buffer.
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant LTDC_LTDC_L2CFBAR_CFBADD                         \ CFBADD


\
\ @brief This register defines the color frame buffer line length and pitch.
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00003fff constant LTDC_LTDC_L2CFBLR_CFBLL                          \ CFBLL
$3fff0000 constant LTDC_LTDC_L2CFBLR_CFBP                           \ CFBP


\
\ @brief This register defines the number of lines in the color frame buffer.
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000fff constant LTDC_LTDC_L2CFBLNR_CFBLNBR                       \ CFBLNBR


\
\ @brief This register defines the CLUT address and the RGB value.
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$000000ff constant LTDC_LTDC_L2CLUTWR_BLUE                          \ BLUE
$0000ff00 constant LTDC_LTDC_L2CLUTWR_GREEN                         \ GREEN
$00ff0000 constant LTDC_LTDC_L2CLUTWR_RED                           \ RED
$ff000000 constant LTDC_LTDC_L2CLUTWR_CLUTADD                       \ CLUTADD


\
\ @brief LTDC
\
$5a001000 constant LTDC_LTDC_IDR  \ offset: 0x00 : LTDC identification register
$5a001004 constant LTDC_LTDC_LCR  \ offset: 0x04 : LDTC layer count register
$5a001008 constant LTDC_LTDC_SSCR  \ offset: 0x08 : This register defines the number of horizontal synchronization pixels minus 1 and the number of vertical synchronization lines minus 1. Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
$5a00100c constant LTDC_LTDC_BPCR  \ offset: 0x0C : This register defines the accumulated number of horizontal synchronization and back porch pixels minus 1 (HSYNCwidth+HBP-1) and the accumulated number of vertical synchronization and back porch lines minus 1 (VSYNCheight+VBP-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
$5a001010 constant LTDC_LTDC_AWCR  \ offset: 0x10 : This register defines the accumulated number of horizontal synchronization, back porch and active pixels minus 1 (HSYNC width+HBP+activewidth-1) and the accumulated number of vertical synchronization, back porch lines and active lines minus 1 (VSYNCheight+BVBP+activeheight-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
$5a001014 constant LTDC_LTDC_TWCR  \ offset: 0x14 : This register defines the accumulated number of horizontal synchronization, back porch, active and front porch pixels minus 1 (HSYNCwidth+HBP+activewidth+HFP-1) and the accumulated number of vertical synchronization, back porch lines, active and front lines minus 1 (VSYNCheight+BVBP+activeheight+VFP-1). Refer to Figure274 and Section36.4: LTDC programmable parameters for an example of configuration.
$5a001018 constant LTDC_LTDC_GCR  \ offset: 0x18 : This register defines the global configuration of the LCD-TFT controller.
$5a00101c constant LTDC_LTDC_GC1R  \ offset: 0x1C : LTDC global configuration 1 register
$5a001020 constant LTDC_LTDC_GC2R  \ offset: 0x20 : LTDC global configuration 2 register
$5a001024 constant LTDC_LTDC_SRCR  \ offset: 0x24 : This register allows to reload either immediately or during the vertical blanking period, the shadow registers values to the active registers. The shadow registers are all Layer1 and Layer2 registers except the LTDC_L1CLUTWR and the LTDC_L2CLUTWR.
$5a00102c constant LTDC_LTDC_BCCR  \ offset: 0x2C : This register defines the background color (RGB888).
$5a001034 constant LTDC_LTDC_IER  \ offset: 0x34 : This register determines which status flags generate an interrupt request by setting the corresponding bit to 1.
$5a001038 constant LTDC_LTDC_ISR  \ offset: 0x38 : This register returns the interrupt status flag.
$5a00103c constant LTDC_LTDC_ICR  \ offset: 0x3C : LTDC Interrupt Clear Register
$5a001040 constant LTDC_LTDC_LIPCR  \ offset: 0x40 : This register defines the position of the line interrupt. The line value to be programmed depends on the timings parameters. Refer to Figure274.
$5a001044 constant LTDC_LTDC_CPSR  \ offset: 0x44 : LTDC current position status register
$5a001048 constant LTDC_LTDC_CDSR  \ offset: 0x48 : This register returns the status of the current display phase which is controlled by the HSYNC, VSYNC, and horizontal/vertical DE signals. Example: if the current display phase is the vertical synchronization, the VSYNCS bit is set (active high). If the current display phase is the horizontal synchronization, the HSYNCS bit is active high.
$5a001084 constant LTDC_LTDC_L1CR  \ offset: 0x84 : LTDC layer 1 control register
$5a001088 constant LTDC_LTDC_L1WHPCR  \ offset: 0x88 : This register defines the horizontal position (first and last pixel) of the layer 1 or 2 window. The first visible pixel of a line is the programmed value of AHBP[11:0] bits + 1 in the LTDC_BPCR register. The last visible pixel of a line is the programmed value of AAW[11:0] bits in the LTDC_AWCR register.
$5a00108c constant LTDC_LTDC_L1WVPCR  \ offset: 0x8C : This register defines the vertical position (first and last line) of the layer1 or 2 window. The first visible line of a frame is the programmed value of AVBP[11:0] bits + 1 in the register LTDC_BPCR register. The last visible line of a frame is the programmed value of AAH[11:0] bits in the LTDC_AWCR register.
$5a001090 constant LTDC_LTDC_L1CKCR  \ offset: 0x90 : This register defines the color key value (RGB), that is used by the color keying.
$5a001094 constant LTDC_LTDC_L1PFCR  \ offset: 0x94 : This register defines the pixel format that is used for the stored data in the frame buffer of a layer. The pixel data is read from the frame buffer and then transformed to the internal format 8888 (ARGB).
$5a001098 constant LTDC_LTDC_L1CACR  \ offset: 0x98 : This register defines the constant alpha value (divided by 255 by hardware), that is used in the alpha blending. Refer to LTDC_LxBFCR register.
$5a00109c constant LTDC_LTDC_L1DCCR  \ offset: 0x9C : This register defines the default color of a layer in the format ARGB. The default color is used outside the defined layer window or when a layer is disabled. The reset value of 0x00000000 defines a transparent black color.
$5a0010a0 constant LTDC_LTDC_L1BFCR  \ offset: 0xA0 : This register defines the blending factors F1 and F2. The general blending formula is: BC = BF1 x C + BF2 x Cs BC = blended color BF1 = blend factor 1 C = current layer color BF2 = blend factor 2 Cs = subjacent layers blended color
$5a0010ac constant LTDC_LTDC_L1CFBAR  \ offset: 0xAC : This register defines the color frame buffer start address which has to point to the address where the pixel data of the top left pixel of a layer is stored in the frame buffer.
$5a0010b0 constant LTDC_LTDC_L1CFBLR  \ offset: 0xB0 : This register defines the color frame buffer line length and pitch.
$5a0010b4 constant LTDC_LTDC_L1CFBLNR  \ offset: 0xB4 : This register defines the number of lines in the color frame buffer.
$5a0010c4 constant LTDC_LTDC_L1CLUTWR  \ offset: 0xC4 : This register defines the CLUT address and the RGB value.
$5a001104 constant LTDC_LTDC_L2CR  \ offset: 0x104 : LTDC layer 2 control register
$5a001108 constant LTDC_LTDC_L2WHPCR  \ offset: 0x108 : This register defines the horizontal position (first and last pixel) of the layer 1 or 2 window. The first visible pixel of a line is the programmed value of AHBP[11:0] bits + 1 in the LTDC_BPCR register. The last visible pixel of a line is the programmed value of AAW[11:0] bits in the LTDC_AWCR register.
$5a00110c constant LTDC_LTDC_L2WVPCR  \ offset: 0x10C : This register defines the vertical position (first and last line) of the layer1 or 2 window. The first visible line of a frame is the programmed value of AVBP[11:0] bits + 1 in the register LTDC_BPCR register. The last visible line of a frame is the programmed value of AAH[11:0] bits in the LTDC_AWCR register.
$5a001110 constant LTDC_LTDC_L2CKCR  \ offset: 0x110 : This register defines the color key value (RGB), that is used by the color keying.
$5a001114 constant LTDC_LTDC_L2PFCR  \ offset: 0x114 : This register defines the pixel format that is used for the stored data in the frame buffer of a layer. The pixel data is read from the frame buffer and then transformed to the internal format 8888 (ARGB).
$5a001118 constant LTDC_LTDC_L2CACR  \ offset: 0x118 : This register defines the constant alpha value (divided by 255 by hardware), that is used in the alpha blending. Refer to LTDC_LxBFCR register.
$5a00111c constant LTDC_LTDC_L2DCCR  \ offset: 0x11C : This register defines the default color of a layer in the format ARGB. The default color is used outside the defined layer window or when a layer is disabled. The reset value of 0x00000000 defines a transparent black color.
$5a001120 constant LTDC_LTDC_L2BFCR  \ offset: 0x120 : This register defines the blending factors F1 and F2. The general blending formula is: BC = BF1 x C + BF2 x Cs BC = blended color BF1 = blend factor 1 C = current layer color BF2 = blend factor 2 Cs = subjacent layers blended color
$5a00112c constant LTDC_LTDC_L2CFBAR  \ offset: 0x12C : This register defines the color frame buffer start address which has to point to the address where the pixel data of the top left pixel of a layer is stored in the frame buffer.
$5a001130 constant LTDC_LTDC_L2CFBLR  \ offset: 0x130 : This register defines the color frame buffer line length and pitch.
$5a001134 constant LTDC_LTDC_L2CFBLNR  \ offset: 0x134 : This register defines the number of lines in the color frame buffer.
$5a001144 constant LTDC_LTDC_L2CLUTWR  \ offset: 0x144 : This register defines the CLUT address and the RGB value.

