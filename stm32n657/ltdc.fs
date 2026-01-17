\
\ @file ltdc.fs
\ @brief LCD-TFT display controller
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
    $00 constant LTDC_VSH                       \ [0x00 : 16] vertical synchronization height (in units of horizontal scan line)
    $10 constant LTDC_HSW                       \ [0x10 : 16] horizontal synchronization width (in units of pixel clock period)
  [then]


  [ifdef] LTDC_LTDC_BPCR_DEF
    \
    \ @brief LTDC back porch configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AVBP                      \ [0x00 : 16] accumulated Vertical back porch (in units of horizontal scan line)
    $10 constant LTDC_AHBP                      \ [0x10 : 16] accumulated horizontal back porch (in units of pixel clock period)
  [then]


  [ifdef] LTDC_LTDC_AWCR_DEF
    \
    \ @brief LTDC active width configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AAH                       \ [0x00 : 16] accumulated active height (in units of horizontal scan line)
    $10 constant LTDC_AAW                       \ [0x10 : 16] accumulated active width (in units of pixel clock period)
  [then]


  [ifdef] LTDC_LTDC_TWCR_DEF
    \
    \ @brief LTDC total width configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_TOTALH                    \ [0x00 : 16] total height (in units of horizontal scan line)
    $10 constant LTDC_TOTALW                    \ [0x10 : 16] total width (in units of pixel clock period)
  [then]


  [ifdef] LTDC_LTDC_GCR_DEF
    \
    \ @brief LTDC global control register
    \ Address offset: 0x18
    \ Reset value: 0x00002220
    \
    $00 constant LTDC_LTDCEN                    \ [0x00] LTDC global enable
    $01 constant LTDC_GAMEN                     \ [0x01] Gamma correction enable
    $04 constant LTDC_DBW                       \ [0x04 : 3] dither blue width
    $08 constant LTDC_DGW                       \ [0x08 : 3] dither green width
    $0c constant LTDC_DRW                       \ [0x0c : 3] dither red width
    $10 constant LTDC_DEN                       \ [0x10] dither enable
    $13 constant LTDC_CRCEN                     \ [0x13] CRC enable
    $18 constant LTDC_SFEN                      \ [0x18] single-frame mode: mode enable
    $19 constant LTDC_SFSWTR                    \ [0x19] single-frame mode: software trigger
    $1c constant LTDC_PCPOL                     \ [0x1c] pixel clock polarity
    $1d constant LTDC_DEPOL                     \ [0x1d] blanking (no data/pixel) polarity
    $1e constant LTDC_VSPOL                     \ [0x1e] vertical synchronization polarity
    $1f constant LTDC_HSPOL                     \ [0x1f] horizontal synchronization polarity
  [then]


  [ifdef] LTDC_LTDC_GC1R_DEF
    \
    \ @brief LTDC global configuration 1 register
    \ Address offset: 0x1C
    \ Reset value: 0x6BE4D888
    \
    $00 constant LTDC_WBCH                      \ [0x00 : 4] width of blue channel output
    $04 constant LTDC_WGCH                      \ [0x04 : 4] width of green channel output
    $08 constant LTDC_WRCH                      \ [0x08 : 4] width of red channel output
    $0c constant LTDC_PRBA                      \ [0x0c] precise blending ability
    $0e constant LTDC_DT                        \ [0x0e : 2] dithering technique implemented
    $11 constant LTDC_GCT                       \ [0x11 : 3] gamma correction technique implemented
    $15 constant LTDC_SHRA                      \ [0x15] shadow registers ability
    $16 constant LTDC_BCP                       \ [0x16] background color programmability (unique color blended as background)
    $17 constant LTDC_BBA                       \ [0x17] background blending ability
    $18 constant LTDC_LNIP                      \ [0x18] line-IRQ: line position programmability
    $19 constant LTDC_TP                        \ [0x19] timing programmability
    $1b constant LTDC_SPP                       \ [0x1b] sync polarity programmability
    $1c constant LTDC_DWP                       \ [0x1c] dither width programmability
    $1d constant LTDC_STRA                      \ [0x1d] status register ability
    $1e constant LTDC_CRMA                      \ [0x1e] configuration reading mode ability
    $1f constant LTDC_BMA                       \ [0x1f] blind mode ability
  [then]


  [ifdef] LTDC_LTDC_GC2R_DEF
    \
    \ @brief LTDC global configuration 2 register
    \ Address offset: 0x20
    \ Reset value: 0x0000BB30
    \
    $00 constant LTDC_BLA                       \ [0x00] background layer ability (pixels of background layer are read from memory)
    $01 constant LTDC_STSA                      \ [0x01] slave timings synchronization ability
    $02 constant LTDC_DVA                       \ [0x02] dual-view ability
    $03 constant LTDC_DPA                       \ [0x03] secondary RGB output port ability
    $04 constant LTDC_BW                        \ [0x04 : 3] bus width (log2 of number of bytes)
    $07 constant LTDC_EDCA                      \ [0x07] external display control ability
    $08 constant LTDC_OCA                       \ [0x08] output conversion ability (RGB to YCbCr)
    $09 constant LTDC_AXIIDA                    \ [0x09] AXIID ability
    $0a constant LTDC_ROTA                      \ [0x0a] rotation support ability
    $0b constant LTDC_SISA                      \ [0x0b] second interrupt set ability
    $0c constant LTDC_SFA                       \ [0x0c] single frame mode ability
    $0d constant LTDC_CRCA                      \ [0x0d] CRC ability
    $0f constant LTDC_BOA                       \ [0x0f] blending order ability
  [then]


  [ifdef] LTDC_LTDC_SRCR_DEF
    \
    \ @brief LTDC shadow reload configuration register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_IMR                       \ [0x00] immediate reload trigger
    $01 constant LTDC_VBR                       \ [0x01] vertical blanking reload request
  [then]


  [ifdef] LTDC_LTDC_GCCR_DEF
    \
    \ @brief LTDC gamma correction configuration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_ADDR                      \ [0x00 : 8] address of the R,G,B table where the COMP component is written
    $08 constant LTDC_COMP                      \ [0x08 : 8] color component to be written, in either (or all) the R,G,B tables
    $10 constant LTDC_BEN                       \ [0x10] write trigger to the blue table
    $11 constant LTDC_GEN                       \ [0x11] write trigger to the green table
    $12 constant LTDC_REN                       \ [0x12] write trigger to the red table
  [then]


  [ifdef] LTDC_LTDC_BCCR_DEF
    \
    \ @brief LTDC background color configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BCBLUE                    \ [0x00 : 8] background color blue value
    $08 constant LTDC_BCGREEN                   \ [0x08 : 8] background color green value
    $10 constant LTDC_BCRED                     \ [0x10 : 8] background color red value
  [then]


  [ifdef] LTDC_LTDC_IER_DEF
    \
    \ @brief LTDC interrupt enable register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIE                       \ [0x00] Line interrupt enable
    $01 constant LTDC_FUWIE                     \ [0x01] FIFO underrun warning interrupt enable
    $02 constant LTDC_TERRIE                    \ [0x02] Transfer Error interrupt enable
    $03 constant LTDC_RRIE                      \ [0x03] Register reload interrupt enable
    $06 constant LTDC_FUIE                      \ [0x06] FIFO underrun interrupt enable
    $07 constant LTDC_CRCIE                     \ [0x07] CRC error interrupt enable
  [then]


  [ifdef] LTDC_LTDC_ISR_DEF
    \
    \ @brief LTDC interrupt status register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIF                       \ [0x00] Line interrupt flag
    $01 constant LTDC_FUWIF                     \ [0x01] FIFO underrun warning interrupt flag
    $02 constant LTDC_TERRIF                    \ [0x02] Transfer error interrupt flag
    $03 constant LTDC_RRIF                      \ [0x03] Register reload interrupt flag
    $06 constant LTDC_FUIF                      \ [0x06] FIFO underrun interrupt flag
    $07 constant LTDC_CRCIF                     \ [0x07] CRC error interrupt flag
  [then]


  [ifdef] LTDC_LTDC_ICR_DEF
    \
    \ @brief LTDC interrupt clear register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CLIF                      \ [0x00] clears the line interrupt flag
    $01 constant LTDC_CFUWIF                    \ [0x01] clears the FIFO underrun warning interrupt flag
    $02 constant LTDC_CTERRIF                   \ [0x02] clears the transfer error interrupt flag
    $03 constant LTDC_CRRIF                     \ [0x03] clears register reload interrupt flag
    $06 constant LTDC_CFUIF                     \ [0x06] clears the FIFO underrun interrupt flag
    $07 constant LTDC_CCRCIF                    \ [0x07] clears the CRC error interrupt flag
  [then]


  [ifdef] LTDC_LTDC_LIPCR_DEF
    \
    \ @brief LTDC line interrupt position configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIPOS                     \ [0x00 : 16] line interrupt position
  [then]


  [ifdef] LTDC_LTDC_CPSR_DEF
    \
    \ @brief LTDC current position status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CYPOS                     \ [0x00 : 16] current Y position
    $10 constant LTDC_CXPOS                     \ [0x10 : 16] current X position
  [then]


  [ifdef] LTDC_LTDC_CDSR_DEF
    \
    \ @brief LTDC current display status register
    \ Address offset: 0x48
    \ Reset value: 0x00000003
    \
    $00 constant LTDC_VDES                      \ [0x00] vertical data enable display status
    $01 constant LTDC_HDES                      \ [0x01] horizontal data enable display status
    $02 constant LTDC_VSYNCS                    \ [0x02] vertical synchronization display status
    $03 constant LTDC_HSYNCS                    \ [0x03] horizontal synchronization display status
  [then]


  [ifdef] LTDC_LTDC_EDCR_DEF
    \
    \ @brief LTDC external display control register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $19 constant LTDC_OCYEN                     \ [0x19] output conversion to YCbCr 422 enable
    $1a constant LTDC_OCYSEL                    \ [0x1a] output conversion to YCbCr 422
    $1b constant LTDC_OCYCO                     \ [0x1b] output conversion to YCbCr 422
  [then]


  [ifdef] LTDC_LTDC_IER2_DEF
    \
    \ @brief LTDC interrupt enable register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIE                       \ [0x00] Line interrupt enable
    $01 constant LTDC_FUWIE                     \ [0x01] FIFO underrun warning interrupt enable
    $02 constant LTDC_TERRIE                    \ [0x02] Transfer error interrupt enable
    $03 constant LTDC_RRIE                      \ [0x03] Register reload interrupt enable
    $06 constant LTDC_FUIE                      \ [0x06] FIFO underrun interrupt enable
    $07 constant LTDC_CRCIE                     \ [0x07] CRC error interrupt enable
  [then]


  [ifdef] LTDC_LTDC_ISR2_DEF
    \
    \ @brief LTDC interrupt status register 2
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIF                       \ [0x00] Line interrupt flag
    $01 constant LTDC_FUWIF                     \ [0x01] FIFO underrun warning interrupt flag
    $02 constant LTDC_TERRIF                    \ [0x02] Transfer error interrupt flag
    $03 constant LTDC_RRIF                      \ [0x03] Register reload interrupt flag
    $06 constant LTDC_FUIF                      \ [0x06] FIFO underrun interrupt flag
    $07 constant LTDC_CRCIF                     \ [0x07] CRC Error interrupt flag
  [then]


  [ifdef] LTDC_LTDC_ICR2_DEF
    \
    \ @brief LTDC interrupt clear register 2
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CLIF                      \ [0x00] clears the Line interrupt flag
    $01 constant LTDC_CFUWIF                    \ [0x01] clears the FIFO underrun warning interrupt flag
    $02 constant LTDC_CTERRIF                   \ [0x02] clears the Transfer Error interrupt flag
    $03 constant LTDC_CRRIF                     \ [0x03] clears register reload interrupt flag
    $06 constant LTDC_CFUIF                     \ [0x06] clears the FIFO underrun interrupt flag
    $07 constant LTDC_CCRCIF                    \ [0x07] clears the CRC error interrupt flag
  [then]


  [ifdef] LTDC_LTDC_LIPCR2_DEF
    \
    \ @brief LTDC line interrupt position configuration register 2
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIPOS                     \ [0x00 : 16] line interrupt position
  [then]


  [ifdef] LTDC_LTDC_ECRCR_DEF
    \
    \ @brief LTDC expected CRC register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_ECRC                      \ [0x00 : 16] expected CRC of frame
  [then]


  [ifdef] LTDC_LTDC_CCRCR_DEF
    \
    \ @brief LTDC computed CRC register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CCRC                      \ [0x00 : 16] computed CRC of frame
  [then]


  [ifdef] LTDC_LTDC_FUTR_DEF
    \
    \ @brief LTDC FIFO underrun threshold register
    \ Address offset: 0x90
    \ Reset value: 0x00000010
    \
    $00 constant LTDC_THRE                      \ [0x00 : 16] threshold to trigger a FIFO underrun interrupt (per FIFO word, 64 bits)
  [then]


  [ifdef] LTDC_LTDC_L1C0R_DEF
    \
    \ @brief LTDC layerx configuration 0 register
    \ Address offset: 0x100
    \ Reset value: 0xFF50A076
    \
    $00 constant LTDC_CKTA                      \ [0x00] color key transparency ability
    $01 constant LTDC_CFBDA                     \ [0x01] color frame buffer duplication ability
    $02 constant LTDC_CFBPA                     \ [0x02] color frame buffer pitch ability
    $03 constant LTDC_APA                       \ [0x03] alpha plane ability
    $04 constant LTDC_DCP                       \ [0x04] default color programmability
    $05 constant LTDC_WINA                      \ [0x05] windowing ability
    $06 constant LTDC_CLUTA                     \ [0x06] CLUT ability
    $07 constant LTDC_CKRA                      \ [0x07] color key replace ability
    $08 constant LTDC_F21                       \ [0x08] blending factor 2, ability for: 1.0
    $09 constant LTDC_F20                       \ [0x09] blending factor 2, ability for: 0.0
    $0a constant LTDC_F2P                       \ [0x0a] blending factor 2, ability for: pixel_alpha
    $0b constant LTDC_F21P                      \ [0x0b] blending factor 2, ability for: 1.0 - pixel_alpha
    $0c constant LTDC_F2C                       \ [0x0c] blending factor 2, ability for: constant_alpha
    $0d constant LTDC_F21C                      \ [0x0d] blending factor 2, ability for: 1.0 - constant_alpha
    $0e constant LTDC_F2PC                      \ [0x0e] blending factor 2, ability for: pixel_alpha * constant_alpha
    $0f constant LTDC_F21PC                     \ [0x0f] blending factor 2, ability for: 1.0 - (pixel_alpha * constant_alpha)
    $10 constant LTDC_F11                       \ [0x10] blending factor 1, ability for: 1.0
    $11 constant LTDC_F10                       \ [0x11] blending factor 1,ability for: 0.0
    $12 constant LTDC_F1P                       \ [0x12] blending factor 1, ability for: pixel_alpha
    $13 constant LTDC_F11P                      \ [0x13] blending factor 1, ability for: 1.0 - pixel_alpha
    $14 constant LTDC_F1C                       \ [0x14] blending factor 1, ability for: constant_alpha
    $15 constant LTDC_F11C                      \ [0x15] blending factor 1, ability for: 1.0 - constant_alpha
    $16 constant LTDC_F1PC                      \ [0x16] blending factor 1, ability for: pixel_alpha * constant_alpha
    $17 constant LTDC_F11PC                     \ [0x17] blending factor 1, ability for: 1.0 - (pixel_alpha * constant_alpha)
    $18 constant LTDC_FF                        \ [0x18] flexible pixel format, ability
    $19 constant LTDC_RGB888                    \ [0x19] pixel format, ability for rgb888
    $1a constant LTDC_BGR565                    \ [0x1a] pixel format, ability for bgr565
    $1b constant LTDC_RGB565                    \ [0x1b] pixel format, ability for rgb565
    $1c constant LTDC_BGRA888                   \ [0x1c] pixel format, ability for bgra8888
    $1d constant LTDC_RGBA8888                  \ [0x1d] pixel format, ability for rgba8888
    $1e constant LTDC_ABGR8888                  \ [0x1e] pixel format, ability for abgr8888
    $1f constant LTDC_ARGB8888                  \ [0x1f] pixel format, ability for argb8888
  [then]


  [ifdef] LTDC_LTDC_L1C1R_DEF
    \
    \ @brief LTDC layerx configuration 1 register
    \ Address offset: 0x104
    \ Reset value: 0x80000007
    \
    $00 constant LTDC_YIA                       \ [0x00] YCbCr 422 interleaved ability for that layer
    $01 constant LTDC_YSPA                      \ [0x01] YCbCr 420 semi-planar ability for that layer
    $02 constant LTDC_YFPA                      \ [0x02] YCbCr 420 full-planar ability for that layer
    $1f constant LTDC_SCA                       \ [0x1f] scaling ability for that layer
  [then]


  [ifdef] LTDC_LTDC_L1RCR_DEF
    \
    \ @brief LTDC layerx reload control register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_IMR                       \ [0x00] immediate reload trigger
    $01 constant LTDC_VBR                       \ [0x01] vertical blanking reload request
    $02 constant LTDC_GRMSK                     \ [0x02] shadow reload control, global (centralized) reload masked
  [then]


  [ifdef] LTDC_LTDC_L1CR_DEF
    \
    \ @brief LTDC layerx control register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LEN                       \ [0x00] layer enable
    $01 constant LTDC_CKEN                      \ [0x01] color keying enable
    $04 constant LTDC_CLUTEN                    \ [0x04] color look-up table enable
    $08 constant LTDC_HMEN                      \ [0x08] horizontal mirroring enable
    $09 constant LTDC_DCBEN                     \ [0x09] default color blending enable
  [then]


  [ifdef] LTDC_LTDC_L1WHPCR_DEF
    \
    \ @brief LTDC layerx window horizontal position configuration register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WHSTPOS                   \ [0x00 : 16] window horizontal start position
    $10 constant LTDC_WHSPPOS                   \ [0x10 : 16] window horizontal stop position
  [then]


  [ifdef] LTDC_LTDC_L1WVPCR_DEF
    \
    \ @brief LTDC layerx window vertical position configuration register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WVSTPOS                   \ [0x00 : 16] window vertical start position
    $10 constant LTDC_WVSPPOS                   \ [0x10 : 16] window vertical stop position
  [then]


  [ifdef] LTDC_LTDC_L1CKCR_DEF
    \
    \ @brief LTDC layerx color keying configuration register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CKBLUE                    \ [0x00 : 8] color key blue value
    $08 constant LTDC_CKGREEN                   \ [0x08 : 8] color key green value
    $10 constant LTDC_CKRED                     \ [0x10 : 8] color key red value
  [then]


  [ifdef] LTDC_LTDC_L1PFCR_DEF
    \
    \ @brief LTDC layerx pixel format configuration register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_PF                        \ [0x00 : 3] pixel format
  [then]


  [ifdef] LTDC_LTDC_L1CACR_DEF
    \
    \ @brief LTDC layerx constant alpha configuration register
    \ Address offset: 0x120
    \ Reset value: 0x000000FF
    \
    $00 constant LTDC_CONSTA                    \ [0x00 : 8] constant alpha
  [then]


  [ifdef] LTDC_LTDC_L1DCCR_DEF
    \
    \ @brief LTDC layerx default color configuration register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_DCBLUE                    \ [0x00 : 8] default color blue
    $08 constant LTDC_DCGREEN                   \ [0x08 : 8] default color green
    $10 constant LTDC_DCRED                     \ [0x10 : 8] default color red
    $18 constant LTDC_DCALPHA                   \ [0x18 : 8] default color alpha
  [then]


  [ifdef] LTDC_LTDC_L1BFCR_DEF
    \
    \ @brief LTDC layerx blending factors configuration register
    \ Address offset: 0x128
    \ Reset value: 0x00000607
    \
    $00 constant LTDC_BF2                       \ [0x00 : 3] blending factor 2
    $08 constant LTDC_BF1                       \ [0x08 : 3] blending factor 1
    $10 constant LTDC_BOR                       \ [0x10] blending order
  [then]


  [ifdef] LTDC_LTDC_L1BLCR_DEF
    \
    \ @brief LTDC layerx burst length configuration register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BL                        \ [0x00 : 8] burst length
  [then]


  [ifdef] LTDC_LTDC_L1PCR_DEF
    \
    \ @brief LTDC layerx planar configuration register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $03 constant LTDC_YCEN                      \ [0x03] YCbCr-to-RGB conversion enable
    $04 constant LTDC_YCM                       \ [0x04 : 2] YCbCr conversion mode
    $06 constant LTDC_YF                        \ [0x06] Y component first
    $07 constant LTDC_CBF                       \ [0x07] Cb component first
    $08 constant LTDC_OF                        \ [0x08] Odd pixel first
    $09 constant LTDC_YREN                      \ [0x09] Y rescale enable for the color dynamic range
  [then]


  [ifdef] LTDC_LTDC_L1CFBAR_DEF
    \
    \ @brief LTDC layerx color frame buffer address register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBADD                    \ [0x00 : 32] color frame buffer start address
  [then]


  [ifdef] LTDC_LTDC_L1CFBLR_DEF
    \
    \ @brief LTDC layerx color frame buffer length register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLL                     \ [0x00 : 16] color frame buffer line length
    $10 constant LTDC_CFBP                      \ [0x10 : 16] color frame buffer pitch in bytes
  [then]


  [ifdef] LTDC_LTDC_L1CFBLNR_DEF
    \
    \ @brief LTDC layerx color frame buffer line number register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLNBR                   \ [0x00 : 16] frame buffer line number
  [then]


  [ifdef] LTDC_LTDC_L1AFBA0R_DEF
    \
    \ @brief LTDC layer1 auxiliary frame buffer address 0 register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AFBADD0                   \ [0x00 : 32] frame buffer start address
  [then]


  [ifdef] LTDC_LTDC_L1AFBA1R_DEF
    \
    \ @brief LTDC layer1 auxiliary frame buffer address 1 register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AFBADD1                   \ [0x00 : 32] auxiliary frame buffer start address
  [then]


  [ifdef] LTDC_LTDC_L1AFBLR_DEF
    \
    \ @brief LTDC layer1 auxiliary frame buffer length register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AFBLL                     \ [0x00 : 16] auxiliary frame buffer line length
    $10 constant LTDC_AFBP                      \ [0x10 : 16] auxiliary frame buffer pitch in bytes
  [then]


  [ifdef] LTDC_LTDC_L1AFBLNR_DEF
    \
    \ @brief LTDC layer1 auxiliary frame buffer line number register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AFBLNBR                   \ [0x00 : 16] auxiliary frame buffer line number
  [then]


  [ifdef] LTDC_LTDC_L1CLUTWR_DEF
    \
    \ @brief LTDC layerx CLUT write register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BLUE                      \ [0x00 : 8] blue value
    $08 constant LTDC_GREEN                     \ [0x08 : 8] green value
    $10 constant LTDC_RED                       \ [0x10 : 8] red value
    $18 constant LTDC_CLUTADD                   \ [0x18 : 8] CLUT address
  [then]


  [ifdef] LTDC_LTDC_L1CYR0R_DEF
    \
    \ @brief LTDC layerx conversion YCbCr RGB 0 register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CR2R                      \ [0x00 : 10] Cr-to-Red coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
    $10 constant LTDC_CB2B                      \ [0x10 : 10] Cb-to-Blue coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
  [then]


  [ifdef] LTDC_LTDC_L1CYR1R_DEF
    \
    \ @brief LTDC layerx conversion YCbCr RGB 1 register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CR2G                      \ [0x00 : 10] Cr-to-Green coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
    $10 constant LTDC_CB2G                      \ [0x10 : 10] Cb-to-Green coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
  [then]


  [ifdef] LTDC_LTDC_L1FPF0R_DEF
    \
    \ @brief LTDC layerx flexible pixel format 0 register
    \ Address offset: 0x174
    \ Reset value: 0x00011100
    \
    $00 constant LTDC_APOS                      \ [0x00 : 5] Location of the Alpha component inside the pixel memory word (in bits)
    $05 constant LTDC_ALEN                      \ [0x05 : 4] Width of the Alpha component (in bits)
    $09 constant LTDC_RPOS                      \ [0x09 : 5] Location of the Red component inside the pixel memory word (in bits)
    $0e constant LTDC_RLEN                      \ [0x0e : 4] Width of the Red component (in bits)
  [then]


  [ifdef] LTDC_LTDC_L1FPF1R_DEF
    \
    \ @brief LTDC layerx flexible pixel format 1 register
    \ Address offset: 0x178
    \ Reset value: 0x00093110
    \
    $00 constant LTDC_GPOS                      \ [0x00 : 5] Location of the Green component inside the pixel memory word (in bits)
    $05 constant LTDC_GLEN                      \ [0x05 : 4] Width of the Green component (in bits)
    $09 constant LTDC_BPOS                      \ [0x09 : 5] Location of the Blue component inside the pixel memory word (in bits)
    $0e constant LTDC_BLEN                      \ [0x0e : 4] Width of the Blue component (in bits)
    $12 constant LTDC_PSIZE                     \ [0x12 : 3] Pixel size (in bytes)
  [then]


  [ifdef] LTDC_LTDC_L2C0R_DEF
    \
    \ @brief LTDC layerx configuration 0 register
    \ Address offset: 0x200
    \ Reset value: 0xFF50A076
    \
    $00 constant LTDC_CKTA                      \ [0x00] color key transparency ability
    $01 constant LTDC_CFBDA                     \ [0x01] color frame buffer duplication ability
    $02 constant LTDC_CFBPA                     \ [0x02] color frame buffer pitch ability
    $03 constant LTDC_APA                       \ [0x03] alpha plane ability
    $04 constant LTDC_DCP                       \ [0x04] default color programmability
    $05 constant LTDC_WINA                      \ [0x05] windowing ability
    $06 constant LTDC_CLUTA                     \ [0x06] CLUT ability
    $07 constant LTDC_CKRA                      \ [0x07] color key replace ability
    $08 constant LTDC_F21                       \ [0x08] blending factor 2, ability for: 1.0
    $09 constant LTDC_F20                       \ [0x09] blending factor 2, ability for: 0.0
    $0a constant LTDC_F2P                       \ [0x0a] blending factor 2, ability for: pixel_alpha
    $0b constant LTDC_F21P                      \ [0x0b] blending factor 2, ability for: 1.0 - pixel_alpha
    $0c constant LTDC_F2C                       \ [0x0c] blending factor 2, ability for: constant_alpha
    $0d constant LTDC_F21C                      \ [0x0d] blending factor 2, ability for: 1.0 - constant_alpha
    $0e constant LTDC_F2PC                      \ [0x0e] blending factor 2, ability for: pixel_alpha * constant_alpha
    $0f constant LTDC_F21PC                     \ [0x0f] blending factor 2, ability for: 1.0 - (pixel_alpha * constant_alpha)
    $10 constant LTDC_F11                       \ [0x10] blending factor 1, ability for: 1.0
    $11 constant LTDC_F10                       \ [0x11] blending factor 1,ability for: 0.0
    $12 constant LTDC_F1P                       \ [0x12] blending factor 1, ability for: pixel_alpha
    $13 constant LTDC_F11P                      \ [0x13] blending factor 1, ability for: 1.0 - pixel_alpha
    $14 constant LTDC_F1C                       \ [0x14] blending factor 1, ability for: constant_alpha
    $15 constant LTDC_F11C                      \ [0x15] blending factor 1, ability for: 1.0 - constant_alpha
    $16 constant LTDC_F1PC                      \ [0x16] blending factor 1, ability for: pixel_alpha * constant_alpha
    $17 constant LTDC_F11PC                     \ [0x17] blending factor 1, ability for: 1.0 - (pixel_alpha * constant_alpha)
    $18 constant LTDC_FF                        \ [0x18] flexible pixel format, ability
    $19 constant LTDC_RGB888                    \ [0x19] pixel format, ability for rgb888
    $1a constant LTDC_BGR565                    \ [0x1a] pixel format, ability for bgr565
    $1b constant LTDC_RGB565                    \ [0x1b] pixel format, ability for rgb565
    $1c constant LTDC_BGRA888                   \ [0x1c] pixel format, ability for bgra8888
    $1d constant LTDC_RGBA8888                  \ [0x1d] pixel format, ability for rgba8888
    $1e constant LTDC_ABGR8888                  \ [0x1e] pixel format, ability for abgr8888
    $1f constant LTDC_ARGB8888                  \ [0x1f] pixel format, ability for argb8888
  [then]


  [ifdef] LTDC_LTDC_L2C1R_DEF
    \
    \ @brief LTDC layerx configuration 1 register
    \ Address offset: 0x204
    \ Reset value: 0x80000001
    \
    $00 constant LTDC_YIA                       \ [0x00] YCbCr 422 interleaved ability for that layer
    $01 constant LTDC_YSPA                      \ [0x01] YCbCr 420 semi-planar ability for that layer
    $02 constant LTDC_YFPA                      \ [0x02] YCbCr 420 full-planar ability for that layer
    $1f constant LTDC_SCA                       \ [0x1f] scaling ability for that layer
  [then]


  [ifdef] LTDC_LTDC_L2RCR_DEF
    \
    \ @brief LTDC layerx reload control register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_IMR                       \ [0x00] immediate reload trigger
    $01 constant LTDC_VBR                       \ [0x01] vertical blanking reload request
    $02 constant LTDC_GRMSK                     \ [0x02] shadow reload control, global (centralized) reload masked
  [then]


  [ifdef] LTDC_LTDC_L2CR_DEF
    \
    \ @brief LTDC layerx control register
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LEN                       \ [0x00] layer enable
    $01 constant LTDC_CKEN                      \ [0x01] color keying enable
    $04 constant LTDC_CLUTEN                    \ [0x04] color look-up table enable
    $08 constant LTDC_HMEN                      \ [0x08] horizontal mirroring enable
    $09 constant LTDC_DCBEN                     \ [0x09] default color blending enable
  [then]


  [ifdef] LTDC_LTDC_L2WHPCR_DEF
    \
    \ @brief LTDC layerx window horizontal position configuration register
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WHSTPOS                   \ [0x00 : 16] window horizontal start position
    $10 constant LTDC_WHSPPOS                   \ [0x10 : 16] window horizontal stop position
  [then]


  [ifdef] LTDC_LTDC_L2WVPCR_DEF
    \
    \ @brief LTDC layerx window vertical position configuration register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WVSTPOS                   \ [0x00 : 16] window vertical start position
    $10 constant LTDC_WVSPPOS                   \ [0x10 : 16] window vertical stop position
  [then]


  [ifdef] LTDC_LTDC_L2CKCR_DEF
    \
    \ @brief LTDC layerx color keying configuration register
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CKBLUE                    \ [0x00 : 8] color key blue value
    $08 constant LTDC_CKGREEN                   \ [0x08 : 8] color key green value
    $10 constant LTDC_CKRED                     \ [0x10 : 8] color key red value
  [then]


  [ifdef] LTDC_LTDC_L2PFCR_DEF
    \
    \ @brief LTDC layerx pixel format configuration register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_PF                        \ [0x00 : 3] pixel format
  [then]


  [ifdef] LTDC_LTDC_L2CACR_DEF
    \
    \ @brief LTDC layerx constant alpha configuration register
    \ Address offset: 0x220
    \ Reset value: 0x000000FF
    \
    $00 constant LTDC_CONSTA                    \ [0x00 : 8] constant alpha
  [then]


  [ifdef] LTDC_LTDC_L2DCCR_DEF
    \
    \ @brief LTDC layerx default color configuration register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_DCBLUE                    \ [0x00 : 8] default color blue
    $08 constant LTDC_DCGREEN                   \ [0x08 : 8] default color green
    $10 constant LTDC_DCRED                     \ [0x10 : 8] default color red
    $18 constant LTDC_DCALPHA                   \ [0x18 : 8] default color alpha
  [then]


  [ifdef] LTDC_LTDC_L2BFCR_DEF
    \
    \ @brief LTDC layerx blending factors configuration register
    \ Address offset: 0x228
    \ Reset value: 0x00010607
    \
    $00 constant LTDC_BF2                       \ [0x00 : 3] blending factor 2
    $08 constant LTDC_BF1                       \ [0x08 : 3] blending factor 1
    $10 constant LTDC_BOR                       \ [0x10] blending order
  [then]


  [ifdef] LTDC_LTDC_L2BLCR_DEF
    \
    \ @brief LTDC layerx burst length configuration register
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BL                        \ [0x00 : 8] burst length
  [then]


  [ifdef] LTDC_LTDC_L2PCR_DEF
    \
    \ @brief LTDC layerx planar configuration register
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $03 constant LTDC_YCEN                      \ [0x03] YCbCr-to-RGB conversion enable
    $04 constant LTDC_YCM                       \ [0x04 : 2] YCbCr conversion mode
    $06 constant LTDC_YF                        \ [0x06] Y component first
    $07 constant LTDC_CBF                       \ [0x07] Cb component first
    $08 constant LTDC_OF                        \ [0x08] Odd pixel first
    $09 constant LTDC_YREN                      \ [0x09] Y rescale enable for the color dynamic range
  [then]


  [ifdef] LTDC_LTDC_L2CFBAR_DEF
    \
    \ @brief LTDC layerx color frame buffer address register
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBADD                    \ [0x00 : 32] color frame buffer start address
  [then]


  [ifdef] LTDC_LTDC_L2CFBLR_DEF
    \
    \ @brief LTDC layerx color frame buffer length register
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLL                     \ [0x00 : 16] color frame buffer line length
    $10 constant LTDC_CFBP                      \ [0x10 : 16] color frame buffer pitch in bytes
  [then]


  [ifdef] LTDC_LTDC_L2CFBLNR_DEF
    \
    \ @brief LTDC layerx color frame buffer line number register
    \ Address offset: 0x23C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLNBR                   \ [0x00 : 16] frame buffer line number
  [then]


  [ifdef] LTDC_LTDC_L2CLUTWR_DEF
    \
    \ @brief LTDC layerx CLUT write register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BLUE                      \ [0x00 : 8] blue value
    $08 constant LTDC_GREEN                     \ [0x08 : 8] green value
    $10 constant LTDC_RED                       \ [0x10 : 8] red value
    $18 constant LTDC_CLUTADD                   \ [0x18 : 8] CLUT address
  [then]


  [ifdef] LTDC_LTDC_L2CYR0R_DEF
    \
    \ @brief LTDC layerx conversion YCbCr RGB 0 register
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CR2R                      \ [0x00 : 10] Cr-to-Red coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
    $10 constant LTDC_CB2B                      \ [0x10 : 10] Cb-to-Blue coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
  [then]


  [ifdef] LTDC_LTDC_L2CYR1R_DEF
    \
    \ @brief LTDC layerx conversion YCbCr RGB 1 register
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CR2G                      \ [0x00 : 10] Cr-to-Green coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
    $10 constant LTDC_CB2G                      \ [0x10 : 10] Cb-to-Green coefficient, with bits 9:8 as positive integer and 7:0 as decimals.
  [then]


  [ifdef] LTDC_LTDC_L2FPF0R_DEF
    \
    \ @brief LTDC layerx flexible pixel format 0 register
    \ Address offset: 0x274
    \ Reset value: 0x00011100
    \
    $00 constant LTDC_APOS                      \ [0x00 : 5] Location of the Alpha component inside the pixel memory word (in bits)
    $05 constant LTDC_ALEN                      \ [0x05 : 4] Width of the Alpha component (in bits)
    $09 constant LTDC_RPOS                      \ [0x09 : 5] Location of the Red component inside the pixel memory word (in bits)
    $0e constant LTDC_RLEN                      \ [0x0e : 4] Width of the Red component (in bits)
  [then]


  [ifdef] LTDC_LTDC_L2FPF1R_DEF
    \
    \ @brief LTDC layerx flexible pixel format 1 register
    \ Address offset: 0x278
    \ Reset value: 0x00093110
    \
    $00 constant LTDC_GPOS                      \ [0x00 : 5] Location of the Green component inside the pixel memory word (in bits)
    $05 constant LTDC_GLEN                      \ [0x05 : 4] Width of the Green component (in bits)
    $09 constant LTDC_BPOS                      \ [0x09 : 5] Location of the Blue component inside the pixel memory word (in bits)
    $0e constant LTDC_BLEN                      \ [0x0e : 4] Width of the Blue component (in bits)
    $12 constant LTDC_PSIZE                     \ [0x12 : 3] Pixel size (in bytes)
  [then]

  \
  \ @brief LCD-TFT display controller
  \
  $08 constant LTDC_LTDC_SSCR           \ LTDC synchronization size configuration register
  $0C constant LTDC_LTDC_BPCR           \ LTDC back porch configuration register
  $10 constant LTDC_LTDC_AWCR           \ LTDC active width configuration register
  $14 constant LTDC_LTDC_TWCR           \ LTDC total width configuration register
  $18 constant LTDC_LTDC_GCR            \ LTDC global control register
  $1C constant LTDC_LTDC_GC1R           \ LTDC global configuration 1 register
  $20 constant LTDC_LTDC_GC2R           \ LTDC global configuration 2 register
  $24 constant LTDC_LTDC_SRCR           \ LTDC shadow reload configuration register
  $28 constant LTDC_LTDC_GCCR           \ LTDC gamma correction configuration register
  $2C constant LTDC_LTDC_BCCR           \ LTDC background color configuration register
  $34 constant LTDC_LTDC_IER            \ LTDC interrupt enable register
  $38 constant LTDC_LTDC_ISR            \ LTDC interrupt status register
  $3C constant LTDC_LTDC_ICR            \ LTDC interrupt clear register
  $40 constant LTDC_LTDC_LIPCR          \ LTDC line interrupt position configuration register
  $44 constant LTDC_LTDC_CPSR           \ LTDC current position status register
  $48 constant LTDC_LTDC_CDSR           \ LTDC current display status register
  $60 constant LTDC_LTDC_EDCR           \ LTDC external display control register
  $64 constant LTDC_LTDC_IER2           \ LTDC interrupt enable register 2
  $68 constant LTDC_LTDC_ISR2           \ LTDC interrupt status register 2
  $6C constant LTDC_LTDC_ICR2           \ LTDC interrupt clear register 2
  $70 constant LTDC_LTDC_LIPCR2         \ LTDC line interrupt position configuration register 2
  $78 constant LTDC_LTDC_ECRCR          \ LTDC expected CRC register
  $7C constant LTDC_LTDC_CCRCR          \ LTDC computed CRC register
  $90 constant LTDC_LTDC_FUTR           \ LTDC FIFO underrun threshold register
  $100 constant LTDC_LTDC_L1C0R         \ LTDC layerx configuration 0 register
  $104 constant LTDC_LTDC_L1C1R         \ LTDC layerx configuration 1 register
  $108 constant LTDC_LTDC_L1RCR         \ LTDC layerx reload control register
  $10C constant LTDC_LTDC_L1CR          \ LTDC layerx control register
  $110 constant LTDC_LTDC_L1WHPCR       \ LTDC layerx window horizontal position configuration register
  $114 constant LTDC_LTDC_L1WVPCR       \ LTDC layerx window vertical position configuration register
  $118 constant LTDC_LTDC_L1CKCR        \ LTDC layerx color keying configuration register
  $11C constant LTDC_LTDC_L1PFCR        \ LTDC layerx pixel format configuration register
  $120 constant LTDC_LTDC_L1CACR        \ LTDC layerx constant alpha configuration register
  $124 constant LTDC_LTDC_L1DCCR        \ LTDC layerx default color configuration register
  $128 constant LTDC_LTDC_L1BFCR        \ LTDC layerx blending factors configuration register
  $12C constant LTDC_LTDC_L1BLCR        \ LTDC layerx burst length configuration register
  $130 constant LTDC_LTDC_L1PCR         \ LTDC layerx planar configuration register
  $134 constant LTDC_LTDC_L1CFBAR       \ LTDC layerx color frame buffer address register
  $138 constant LTDC_LTDC_L1CFBLR       \ LTDC layerx color frame buffer length register
  $13C constant LTDC_LTDC_L1CFBLNR      \ LTDC layerx color frame buffer line number register
  $140 constant LTDC_LTDC_L1AFBA0R      \ LTDC layer1 auxiliary frame buffer address 0 register
  $144 constant LTDC_LTDC_L1AFBA1R      \ LTDC layer1 auxiliary frame buffer address 1 register
  $148 constant LTDC_LTDC_L1AFBLR       \ LTDC layer1 auxiliary frame buffer length register
  $14C constant LTDC_LTDC_L1AFBLNR      \ LTDC layer1 auxiliary frame buffer line number register
  $150 constant LTDC_LTDC_L1CLUTWR      \ LTDC layerx CLUT write register
  $16C constant LTDC_LTDC_L1CYR0R       \ LTDC layerx conversion YCbCr RGB 0 register
  $170 constant LTDC_LTDC_L1CYR1R       \ LTDC layerx conversion YCbCr RGB 1 register
  $174 constant LTDC_LTDC_L1FPF0R       \ LTDC layerx flexible pixel format 0 register
  $178 constant LTDC_LTDC_L1FPF1R       \ LTDC layerx flexible pixel format 1 register
  $200 constant LTDC_LTDC_L2C0R         \ LTDC layerx configuration 0 register
  $204 constant LTDC_LTDC_L2C1R         \ LTDC layerx configuration 1 register
  $208 constant LTDC_LTDC_L2RCR         \ LTDC layerx reload control register
  $20C constant LTDC_LTDC_L2CR          \ LTDC layerx control register
  $210 constant LTDC_LTDC_L2WHPCR       \ LTDC layerx window horizontal position configuration register
  $214 constant LTDC_LTDC_L2WVPCR       \ LTDC layerx window vertical position configuration register
  $218 constant LTDC_LTDC_L2CKCR        \ LTDC layerx color keying configuration register
  $21C constant LTDC_LTDC_L2PFCR        \ LTDC layerx pixel format configuration register
  $220 constant LTDC_LTDC_L2CACR        \ LTDC layerx constant alpha configuration register
  $224 constant LTDC_LTDC_L2DCCR        \ LTDC layerx default color configuration register
  $228 constant LTDC_LTDC_L2BFCR        \ LTDC layerx blending factors configuration register
  $22C constant LTDC_LTDC_L2BLCR        \ LTDC layerx burst length configuration register
  $230 constant LTDC_LTDC_L2PCR         \ LTDC layerx planar configuration register
  $234 constant LTDC_LTDC_L2CFBAR       \ LTDC layerx color frame buffer address register
  $238 constant LTDC_LTDC_L2CFBLR       \ LTDC layerx color frame buffer length register
  $23C constant LTDC_LTDC_L2CFBLNR      \ LTDC layerx color frame buffer line number register
  $250 constant LTDC_LTDC_L2CLUTWR      \ LTDC layerx CLUT write register
  $26C constant LTDC_LTDC_L2CYR0R       \ LTDC layerx conversion YCbCr RGB 0 register
  $270 constant LTDC_LTDC_L2CYR1R       \ LTDC layerx conversion YCbCr RGB 1 register
  $274 constant LTDC_LTDC_L2FPF0R       \ LTDC layerx flexible pixel format 0 register
  $278 constant LTDC_LTDC_L2FPF1R       \ LTDC layerx flexible pixel format 1 register

: LTDC_DEF ; [then]
