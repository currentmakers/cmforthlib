\
\ @file ltdc.fs
\ @brief LCD-TFT Controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LTDC_DEF

  [ifdef] LTDC_SSCR_DEF
    \
    \ @brief Synchronization Size Configuration Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_VSH                       \ [0x00 : 11] Vertical Synchronization Height (in units of horizontal scan line)
    $10 constant LTDC_HSW                       \ [0x10 : 10] Horizontal Synchronization Width (in units of pixel clock period)
  [then]


  [ifdef] LTDC_BPCR_DEF
    \
    \ @brief Back Porch Configuration Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AVBP                      \ [0x00 : 11] Accumulated Vertical back porch (in units of horizontal scan line)
    $10 constant LTDC_AHBP                      \ [0x10 : 12] Accumulated Horizontal back porch (in units of pixel clock period)
  [then]


  [ifdef] LTDC_AWCR_DEF
    \
    \ @brief Active Width Configuration Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_AAH                       \ [0x00 : 11] Accumulated Active Height (in units of horizontal scan line)
    $10 constant LTDC_AAV                       \ [0x10 : 12] AAV
  [then]


  [ifdef] LTDC_TWCR_DEF
    \
    \ @brief Total Width Configuration Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_TOTALH                    \ [0x00 : 11] Total Height (in units of horizontal scan line)
    $10 constant LTDC_TOTALW                    \ [0x10 : 12] Total Width (in units of pixel clock period)
  [then]


  [ifdef] LTDC_GCR_DEF
    \
    \ @brief Global Control Register
    \ Address offset: 0x18
    \ Reset value: 0x00002220
    \
    $00 constant LTDC_LTDCEN                    \ [0x00] LCD-TFT controller enable bit
    $04 constant LTDC_DBW                       \ [0x04 : 3] Dither Blue Width
    $08 constant LTDC_DGW                       \ [0x08 : 3] Dither Green Width
    $0c constant LTDC_DRW                       \ [0x0c : 3] Dither Red Width
    $10 constant LTDC_DEN                       \ [0x10] Dither Enable
    $1c constant LTDC_PCPOL                     \ [0x1c] Pixel Clock Polarity
    $1d constant LTDC_DEPOL                     \ [0x1d] Data Enable Polarity
    $1e constant LTDC_VSPOL                     \ [0x1e] Vertical Synchronization Polarity
    $1f constant LTDC_HSPOL                     \ [0x1f] Horizontal Synchronization Polarity
  [then]


  [ifdef] LTDC_SRCR_DEF
    \
    \ @brief Shadow Reload Configuration Register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_IMR                       \ [0x00] Immediate Reload
    $01 constant LTDC_VBR                       \ [0x01] Vertical Blanking Reload
  [then]


  [ifdef] LTDC_BCCR_DEF
    \
    \ @brief Background Color Configuration Register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BCBLUE                    \ [0x00 : 8] Background Color Blue value
    $08 constant LTDC_BCGREEN                   \ [0x08 : 8] Background Color Green value
    $10 constant LTDC_BCRED                     \ [0x10 : 8] Background Color Red value
  [then]


  [ifdef] LTDC_IER_DEF
    \
    \ @brief Interrupt Enable Register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIE                       \ [0x00] Line Interrupt Enable
    $01 constant LTDC_FUIE                      \ [0x01] FIFO Underrun Interrupt Enable
    $02 constant LTDC_TERRIE                    \ [0x02] Transfer Error Interrupt Enable
    $03 constant LTDC_RRIE                      \ [0x03] Register Reload interrupt enable
  [then]


  [ifdef] LTDC_ISR_DEF
    \
    \ @brief Interrupt Status Register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIF                       \ [0x00] Line Interrupt flag
    $01 constant LTDC_FUIF                      \ [0x01] FIFO Underrun Interrupt flag
    $02 constant LTDC_TERRIF                    \ [0x02] Transfer Error interrupt flag
    $03 constant LTDC_RRIF                      \ [0x03] Register Reload Interrupt Flag
  [then]


  [ifdef] LTDC_ICR_DEF
    \
    \ @brief Interrupt Clear Register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CLIF                      \ [0x00] Clears the Line Interrupt Flag
    $01 constant LTDC_CFUIF                     \ [0x01] Clears the FIFO Underrun Interrupt flag
    $02 constant LTDC_CTERRIF                   \ [0x02] Clears the Transfer Error Interrupt Flag
    $03 constant LTDC_CRRIF                     \ [0x03] Clears Register Reload Interrupt Flag
  [then]


  [ifdef] LTDC_LIPCR_DEF
    \
    \ @brief Line Interrupt Position Configuration Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LIPOS                     \ [0x00 : 11] Line Interrupt Position
  [then]


  [ifdef] LTDC_CPSR_DEF
    \
    \ @brief Current Position Status Register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CYPOS                     \ [0x00 : 16] Current Y Position
    $10 constant LTDC_CXPOS                     \ [0x10 : 16] Current X Position
  [then]


  [ifdef] LTDC_CDSR_DEF
    \
    \ @brief Current Display Status Register
    \ Address offset: 0x48
    \ Reset value: 0x0000000F
    \
    $00 constant LTDC_VDES                      \ [0x00] Vertical Data Enable display Status
    $01 constant LTDC_HDES                      \ [0x01] Horizontal Data Enable display Status
    $02 constant LTDC_VSYNCS                    \ [0x02] Vertical Synchronization display Status
    $03 constant LTDC_HSYNCS                    \ [0x03] Horizontal Synchronization display Status
  [then]


  [ifdef] LTDC_L1CR_DEF
    \
    \ @brief Layerx Control Register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LEN                       \ [0x00] Layer Enable
    $01 constant LTDC_COLKEN                    \ [0x01] Color Keying Enable
    $04 constant LTDC_CLUTEN                    \ [0x04] Color Look-Up Table Enable
  [then]


  [ifdef] LTDC_L1WHPCR_DEF
    \
    \ @brief Layerx Window Horizontal Position Configuration Register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WHSTPOS                   \ [0x00 : 12] Window Horizontal Start Position
    $10 constant LTDC_WHSPPOS                   \ [0x10 : 12] Window Horizontal Stop Position
  [then]


  [ifdef] LTDC_L1WVPCR_DEF
    \
    \ @brief Layerx Window Vertical Position Configuration Register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WVSTPOS                   \ [0x00 : 11] Window Vertical Start Position
    $10 constant LTDC_WVSPPOS                   \ [0x10 : 11] Window Vertical Stop Position
  [then]


  [ifdef] LTDC_L1CKCR_DEF
    \
    \ @brief Layerx Color Keying Configuration Register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CKBLUE                    \ [0x00 : 8] Color Key Blue value
    $08 constant LTDC_CKGREEN                   \ [0x08 : 8] Color Key Green value
    $10 constant LTDC_CKRED                     \ [0x10 : 8] Color Key Red value
  [then]


  [ifdef] LTDC_L1PFCR_DEF
    \
    \ @brief Layerx Pixel Format Configuration Register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_PF                        \ [0x00 : 3] Pixel Format
  [then]


  [ifdef] LTDC_L1CACR_DEF
    \
    \ @brief Layerx Constant Alpha Configuration Register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CONSTA                    \ [0x00 : 8] Constant Alpha
  [then]


  [ifdef] LTDC_L1DCCR_DEF
    \
    \ @brief Layerx Default Color Configuration Register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_DCBLUE                    \ [0x00 : 8] Default Color Blue
    $08 constant LTDC_DCGREEN                   \ [0x08 : 8] Default Color Green
    $10 constant LTDC_DCRED                     \ [0x10 : 8] Default Color Red
    $18 constant LTDC_DCALPHA                   \ [0x18 : 8] Default Color Alpha
  [then]


  [ifdef] LTDC_L1BFCR_DEF
    \
    \ @brief Layerx Blending Factors Configuration Register
    \ Address offset: 0xA0
    \ Reset value: 0x00000607
    \
    $00 constant LTDC_BF2                       \ [0x00 : 3] Blending Factor 2
    $08 constant LTDC_BF1                       \ [0x08 : 3] Blending Factor 1
  [then]


  [ifdef] LTDC_L1CFBAR_DEF
    \
    \ @brief Layerx Color Frame Buffer Address Register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBADD                    \ [0x00 : 32] Color Frame Buffer Start Address
  [then]


  [ifdef] LTDC_L1CFBLR_DEF
    \
    \ @brief Layerx Color Frame Buffer Length Register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLL                     \ [0x00 : 13] Color Frame Buffer Line Length
    $10 constant LTDC_CFBP                      \ [0x10 : 13] Color Frame Buffer Pitch in bytes
  [then]


  [ifdef] LTDC_L1CFBLNR_DEF
    \
    \ @brief Layerx ColorFrame Buffer Line Number Register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLNBR                   \ [0x00 : 11] Frame Buffer Line Number
  [then]


  [ifdef] LTDC_L1CLUTWR_DEF
    \
    \ @brief Layerx CLUT Write Register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BLUE                      \ [0x00 : 8] Blue value
    $08 constant LTDC_GREEN                     \ [0x08 : 8] Green value
    $10 constant LTDC_RED                       \ [0x10 : 8] Red value
    $18 constant LTDC_CLUTADD                   \ [0x18 : 8] CLUT Address
  [then]


  [ifdef] LTDC_L2CR_DEF
    \
    \ @brief Layerx Control Register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_LEN                       \ [0x00] Layer Enable
    $01 constant LTDC_COLKEN                    \ [0x01] Color Keying Enable
    $04 constant LTDC_CLUTEN                    \ [0x04] Color Look-Up Table Enable
  [then]


  [ifdef] LTDC_L2WHPCR_DEF
    \
    \ @brief Layerx Window Horizontal Position Configuration Register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WHSTPOS                   \ [0x00 : 12] Window Horizontal Start Position
    $10 constant LTDC_WHSPPOS                   \ [0x10 : 12] Window Horizontal Stop Position
  [then]


  [ifdef] LTDC_L2WVPCR_DEF
    \
    \ @brief Layerx Window Vertical Position Configuration Register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_WVSTPOS                   \ [0x00 : 11] Window Vertical Start Position
    $10 constant LTDC_WVSPPOS                   \ [0x10 : 11] Window Vertical Stop Position
  [then]


  [ifdef] LTDC_L2CKCR_DEF
    \
    \ @brief Layerx Color Keying Configuration Register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CKBLUE                    \ [0x00 : 8] Color Key Blue value
    $08 constant LTDC_CKGREEN                   \ [0x08 : 8] Color Key Green value
    $10 constant LTDC_CKRED                     \ [0x10 : 8] Color Key Red value
  [then]


  [ifdef] LTDC_L2PFCR_DEF
    \
    \ @brief Layerx Pixel Format Configuration Register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_PF                        \ [0x00 : 3] Pixel Format
  [then]


  [ifdef] LTDC_L2CACR_DEF
    \
    \ @brief Layerx Constant Alpha Configuration Register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CONSTA                    \ [0x00 : 8] Constant Alpha
  [then]


  [ifdef] LTDC_L2DCCR_DEF
    \
    \ @brief Layerx Default Color Configuration Register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_DCBLUE                    \ [0x00 : 8] Default Color Blue
    $08 constant LTDC_DCGREEN                   \ [0x08 : 8] Default Color Green
    $10 constant LTDC_DCRED                     \ [0x10 : 8] Default Color Red
    $18 constant LTDC_DCALPHA                   \ [0x18 : 8] Default Color Alpha
  [then]


  [ifdef] LTDC_L2BFCR_DEF
    \
    \ @brief Layerx Blending Factors Configuration Register
    \ Address offset: 0x120
    \ Reset value: 0x00000607
    \
    $00 constant LTDC_BF2                       \ [0x00 : 3] Blending Factor 2
    $08 constant LTDC_BF1                       \ [0x08 : 3] Blending Factor 1
  [then]


  [ifdef] LTDC_L2CFBAR_DEF
    \
    \ @brief Layerx Color Frame Buffer Address Register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBADD                    \ [0x00 : 32] Color Frame Buffer Start Address
  [then]


  [ifdef] LTDC_L2CFBLR_DEF
    \
    \ @brief Layerx Color Frame Buffer Length Register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLL                     \ [0x00 : 13] Color Frame Buffer Line Length
    $10 constant LTDC_CFBP                      \ [0x10 : 13] Color Frame Buffer Pitch in bytes
  [then]


  [ifdef] LTDC_L2CFBLNR_DEF
    \
    \ @brief Layerx ColorFrame Buffer Line Number Register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_CFBLNBR                   \ [0x00 : 11] Frame Buffer Line Number
  [then]


  [ifdef] LTDC_L2CLUTWR_DEF
    \
    \ @brief Layerx CLUT Write Register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant LTDC_BLUE                      \ [0x00 : 8] Blue value
    $08 constant LTDC_GREEN                     \ [0x08 : 8] Green value
    $10 constant LTDC_RED                       \ [0x10 : 8] Red value
    $18 constant LTDC_CLUTADD                   \ [0x18 : 8] CLUT Address
  [then]

  \
  \ @brief LCD-TFT Controller
  \
  $08 constant LTDC_SSCR                \ Synchronization Size Configuration Register
  $0C constant LTDC_BPCR                \ Back Porch Configuration Register
  $10 constant LTDC_AWCR                \ Active Width Configuration Register
  $14 constant LTDC_TWCR                \ Total Width Configuration Register
  $18 constant LTDC_GCR                 \ Global Control Register
  $24 constant LTDC_SRCR                \ Shadow Reload Configuration Register
  $2C constant LTDC_BCCR                \ Background Color Configuration Register
  $34 constant LTDC_IER                 \ Interrupt Enable Register
  $38 constant LTDC_ISR                 \ Interrupt Status Register
  $3C constant LTDC_ICR                 \ Interrupt Clear Register
  $40 constant LTDC_LIPCR               \ Line Interrupt Position Configuration Register
  $44 constant LTDC_CPSR                \ Current Position Status Register
  $48 constant LTDC_CDSR                \ Current Display Status Register
  $84 constant LTDC_L1CR                \ Layerx Control Register
  $88 constant LTDC_L1WHPCR             \ Layerx Window Horizontal Position Configuration Register
  $8C constant LTDC_L1WVPCR             \ Layerx Window Vertical Position Configuration Register
  $90 constant LTDC_L1CKCR              \ Layerx Color Keying Configuration Register
  $94 constant LTDC_L1PFCR              \ Layerx Pixel Format Configuration Register
  $98 constant LTDC_L1CACR              \ Layerx Constant Alpha Configuration Register
  $9C constant LTDC_L1DCCR              \ Layerx Default Color Configuration Register
  $A0 constant LTDC_L1BFCR              \ Layerx Blending Factors Configuration Register
  $AC constant LTDC_L1CFBAR             \ Layerx Color Frame Buffer Address Register
  $B0 constant LTDC_L1CFBLR             \ Layerx Color Frame Buffer Length Register
  $B4 constant LTDC_L1CFBLNR            \ Layerx ColorFrame Buffer Line Number Register
  $C4 constant LTDC_L1CLUTWR            \ Layerx CLUT Write Register
  $104 constant LTDC_L2CR               \ Layerx Control Register
  $108 constant LTDC_L2WHPCR            \ Layerx Window Horizontal Position Configuration Register
  $10C constant LTDC_L2WVPCR            \ Layerx Window Vertical Position Configuration Register
  $110 constant LTDC_L2CKCR             \ Layerx Color Keying Configuration Register
  $114 constant LTDC_L2PFCR             \ Layerx Pixel Format Configuration Register
  $118 constant LTDC_L2CACR             \ Layerx Constant Alpha Configuration Register
  $11C constant LTDC_L2DCCR             \ Layerx Default Color Configuration Register
  $120 constant LTDC_L2BFCR             \ Layerx Blending Factors Configuration Register
  $12C constant LTDC_L2CFBAR            \ Layerx Color Frame Buffer Address Register
  $130 constant LTDC_L2CFBLR            \ Layerx Color Frame Buffer Length Register
  $134 constant LTDC_L2CFBLNR           \ Layerx ColorFrame Buffer Line Number Register
  $144 constant LTDC_L2CLUTWR           \ Layerx CLUT Write Register

: LTDC_DEF ; [then]
