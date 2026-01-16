\
\ @file ltcd.fs
\ @brief Liquid crystal display controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LTDC Synchronization Size Configuration Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000007ff constant LTCD_SSCR_VSH                                    \ Vertical Synchronization Height (in units of horizontal scan line)
$0fff0000 constant LTCD_SSCR_HSW                                    \ Horizontal Synchronization Width (in units of pixel clock period)


\
\ @brief LTDC Back Porch Configuration Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000007ff constant LTCD_BPCR_AVBP                                   \ Accumulated Vertical back porch (in units of horizontal scan line)
$0fff0000 constant LTCD_BPCR_AHBP                                   \ Accumulated Horizontal back porch (in units of pixel clock period)


\
\ @brief LTDC Active Width Configuration Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000007ff constant LTCD_AWCR_AAH                                    \ Accumulated Active Height (in units of horizontal scan line)
$0fff0000 constant LTCD_AWCR_AAW                                    \ Accumulated Active Width (in units of pixel clock period)


\
\ @brief LTDC Total Width Configuration Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000007ff constant LTCD_TWCR_TOTALH                                 \ Total Height (in units of horizontal scan line)
$0fff0000 constant LTCD_TWCR_TOTALW                                 \ Total Width (in units of pixel clock period)


\
\ @brief LTDC Global Control Register
\ Address offset: 0x18
\ Reset value: 0x00002220
\

$00000001 constant LTCD_GCR_LTDCEN                                  \ LCD-TFT controller enable bit
$00000070 constant LTCD_GCR_DBW                                     \ Dither Blue Width
$00000700 constant LTCD_GCR_DGW                                     \ Dither Green Width
$00007000 constant LTCD_GCR_DRW                                     \ Dither Red Width
$00010000 constant LTCD_GCR_DEN                                     \ Dither Enable
$10000000 constant LTCD_GCR_PCPOL                                   \ Pixel Clock Polarity
$20000000 constant LTCD_GCR_DEPOL                                   \ Not Data Enable Polarity
$40000000 constant LTCD_GCR_VSPOL                                   \ Vertical Synchronization Polarity
$80000000 constant LTCD_GCR_HSPOL                                   \ Horizontal Synchronization Polarity


\
\ @brief LTDC Shadow Reload Configuration Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant LTCD_SRCR_IMR                                    \ Immediate Reload
$00000002 constant LTCD_SRCR_VBR                                    \ Vertical Blanking Reload


\
\ @brief LTDC Background Color Configuration Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000000ff constant LTCD_BCCR_BCBLUE                                 \ Background Color Blue value
$0000ff00 constant LTCD_BCCR_BCGREEN                                \ Background Color Green value
$00ff0000 constant LTCD_BCCR_BCRED                                  \ Background Color Red value


\
\ @brief LTDC Interrupt Enable Register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant LTCD_IER_LIE                                     \ Line Interrupt Enable
$00000002 constant LTCD_IER_FUIE                                    \ FIFO Underrun Interrupt Enable
$00000004 constant LTCD_IER_TERRIE                                  \ Transfer Error Interrupt Enable
$00000008 constant LTCD_IER_RRIE                                    \ Register Reload interrupt enable


\
\ @brief LTDC Interrupt Status Register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant LTCD_ISR_LIF                                     \ Line Interrupt flag
$00000002 constant LTCD_ISR_FUIF                                    \ FIFO Underrun Interrupt flag
$00000004 constant LTCD_ISR_TERRIF                                  \ Transfer Error interrupt flag
$00000008 constant LTCD_ISR_RRIF                                    \ Register Reload Interrupt Flag


\
\ @brief LTDC Interrupt Clear Register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant LTCD_ICR_CLIF                                    \ Clears the Line Interrupt Flag
$00000002 constant LTCD_ICR_CFUIF                                   \ Clears the FIFO Underrun Interrupt flag
$00000004 constant LTCD_ICR_CTERRIF                                 \ Clears the Transfer Error Interrupt Flag
$00000008 constant LTCD_ICR_CRRIF                                   \ Clears Register Reload Interrupt Flag


\
\ @brief LTDC Line Interrupt Position Configuration Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000007ff constant LTCD_LIPCR_LIPOS                                 \ Line Interrupt Position


\
\ @brief LTDC Current Position Status Register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant LTCD_CPSR_CYPOS                                  \ Current Y Position
$ffff0000 constant LTCD_CPSR_CXPOS                                  \ Current X Position


\
\ @brief LTDC Current Display Status Register
\ Address offset: 0x48
\ Reset value: 0x0000000F
\

$00000001 constant LTCD_CDSR_VDES                                   \ Vertical Data Enable display Status
$00000002 constant LTCD_CDSR_HDES                                   \ Horizontal Data Enable display Status
$00000004 constant LTCD_CDSR_VSYNCS                                 \ Vertical Synchronization display Status
$00000008 constant LTCD_CDSR_HSYNCS                                 \ Horizontal Synchronization display Status


\
\ @brief LTDC Layer Control Register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant LTCD_L1CR_LEN                                    \ Layer Enable
$00000002 constant LTCD_L1CR_COLKEN                                 \ Color Keying Enable
$00000010 constant LTCD_L1CR_CLUTEN                                 \ Color Look-Up Table Enable


\
\ @brief LTDC Layer Window Horizontal Position Configuration Register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000fff constant LTCD_L1WHPCR_WHSTPOS                             \ Window Horizontal Start Position
$0fff0000 constant LTCD_L1WHPCR_WHSPPOS                             \ Window Horizontal Stop Position


\
\ @brief LTDC Layer Window Vertical Position Configuration Register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$000007ff constant LTCD_L1WVPCR_WVSTPOS                             \ Window Vertical Start Position
$07ff0000 constant LTCD_L1WVPCR_WVSPPOS                             \ Window Vertical Stop Position


\
\ @brief LTDC Layer Color Keying Configuration Register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$000000ff constant LTCD_L1CKCR_CKBLUE                               \ Color Key Blue value
$0000ff00 constant LTCD_L1CKCR_CKGREEN                              \ Color Key Green value
$00ff0000 constant LTCD_L1CKCR_CKRED                                \ Color Key Red value


\
\ @brief LTDC Layer Pixel Format Configuration Register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000007 constant LTCD_L1PFCR_PF                                   \ Pixel Format


\
\ @brief LTDC Layer Constant Alpha Configuration Register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$000000ff constant LTCD_L1CACR_CONSTA                               \ Constant Alpha


\
\ @brief LTDC Layer Default Color Configuration Register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$000000ff constant LTCD_L1DCCR_DCBLUE                               \ Default Color Blue
$0000ff00 constant LTCD_L1DCCR_DCGREEN                              \ Default Color Green
$00ff0000 constant LTCD_L1DCCR_DCRED                                \ Default Color Red
$ff000000 constant LTCD_L1DCCR_DCALPHA                              \ Default Color Alpha


\
\ @brief LTDC Layer Blending Factors Configuration Register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000007 constant LTCD_L1BFCR_BF2                                  \ Blending Factor 2
$00000700 constant LTCD_L1BFCR_BF1                                  \ Blending Factor 1


\
\ @brief LTDC Layer Color Frame Buffer Address Register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant LTCD_L1CFBAR_CFBADD                              \ Color Frame Buffer Start Address


\
\ @brief LTDC Layer Color Frame Buffer Length Register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00001fff constant LTCD_L1CFBLR_CFBLL                               \ Color Frame Buffer Line Length
$1fff0000 constant LTCD_L1CFBLR_CFBP                                \ Color Frame Buffer Pitch in bytes


\
\ @brief LTDC Layer ColorFrame Buffer Line Number Register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$000007ff constant LTCD_L1CFBLNR_CFBLNBR                            \ Frame Buffer Line Number


\
\ @brief LTDC Layerx CLUT Write Register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000ff constant LTCD_L1CLUTWR_BLUE                               \ Blue value
$0000ff00 constant LTCD_L1CLUTWR_GREEN                              \ Green value
$00ff0000 constant LTCD_L1CLUTWR_RED                                \ Red value
$ff000000 constant LTCD_L1CLUTWR_CLUTADD                            \ CLUT Address


\
\ @brief LTDC Layer Control Register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant LTCD_L2CR_LEN                                    \ Layer Enable
$00000002 constant LTCD_L2CR_COLKEN                                 \ Color Keying Enable
$00000010 constant LTCD_L2CR_CLUTEN                                 \ Color Look-Up Table Enable


\
\ @brief LTDC Layerx Window Horizontal Position Configuration Register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000fff constant LTCD_L2WHPCR_WHSTPOS                             \ Window Horizontal Start Position
$0fff0000 constant LTCD_L2WHPCR_WHSPPOS                             \ Window Horizontal Stop Position


\
\ @brief LTDC Layer Window Vertical Position Configuration Register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$000007ff constant LTCD_L2WVPCR_WVSTPOS                             \ Window Vertical Start Position
$07ff0000 constant LTCD_L2WVPCR_WVSPPOS                             \ Window Vertical Stop Position


\
\ @brief LTDC Layer Color Keying Configuration Register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$000000ff constant LTCD_L2CKCR_CKBLUE                               \ Color Key Blue value
$0000ff00 constant LTCD_L2CKCR_CKGREEN                              \ Color Key Green value
$00ff0000 constant LTCD_L2CKCR_CKRED                                \ Color Key Red value


\
\ @brief LTDC Layer Pixel Format Configuration Register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000007 constant LTCD_L2PFCR_PF                                   \ Pixel Format


\
\ @brief LTDC Layer Constant Alpha Configuration Register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$000000ff constant LTCD_L2CACR_CONSTA                               \ Constant Alpha


\
\ @brief LTDC Layer Default Color Configuration Register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$000000ff constant LTCD_L2DCCR_DCBLUE                               \ Default Color Blue
$0000ff00 constant LTCD_L2DCCR_DCGREEN                              \ Default Color Green
$00ff0000 constant LTCD_L2DCCR_DCRED                                \ Default Color Red
$ff000000 constant LTCD_L2DCCR_DCALPHA                              \ Default Color Alpha


\
\ @brief LTDC Layer Blending Factors Configuration Register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000007 constant LTCD_L2BFCR_BF2                                  \ Blending Factor 2
$00000700 constant LTCD_L2BFCR_BF1                                  \ Blending Factor 1


\
\ @brief LTDC Layer Color Frame Buffer Address Register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant LTCD_L2CFBAR_CFBADD                              \ Color Frame Buffer Start Address


\
\ @brief LTDC Layer Color Frame Buffer Length Register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00001fff constant LTCD_L2CFBLR_CFBLL                               \ Color Frame Buffer Line Length
$1fff0000 constant LTCD_L2CFBLR_CFBP                                \ Color Frame Buffer Pitch in bytes


\
\ @brief LTDC Layer ColorFrame Buffer Line Number Register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$000007ff constant LTCD_L2CFBLNR_CFBLNBR                            \ Frame Buffer Line Number


\
\ @brief LTDC Layerx CLUT Write Register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$000000ff constant LTCD_L2CLUTWR_BLUE                               \ Blue value
$0000ff00 constant LTCD_L2CLUTWR_GREEN                              \ Green value
$00ff0000 constant LTCD_L2CLUTWR_RED                                \ Red value
$ff000000 constant LTCD_L2CLUTWR_CLUTADD                            \ CLUT Address


\
\ @brief Liquid crystal display controller
\
$40016808 constant LTCD_SSCR      \ offset: 0x08 : LTDC Synchronization Size Configuration Register
$4001680c constant LTCD_BPCR      \ offset: 0x0C : LTDC Back Porch Configuration Register
$40016810 constant LTCD_AWCR      \ offset: 0x10 : LTDC Active Width Configuration Register
$40016814 constant LTCD_TWCR      \ offset: 0x14 : LTDC Total Width Configuration Register
$40016818 constant LTCD_GCR       \ offset: 0x18 : LTDC Global Control Register
$40016824 constant LTCD_SRCR      \ offset: 0x24 : LTDC Shadow Reload Configuration Register
$4001682c constant LTCD_BCCR      \ offset: 0x2C : LTDC Background Color Configuration Register
$40016834 constant LTCD_IER       \ offset: 0x34 : LTDC Interrupt Enable Register
$40016838 constant LTCD_ISR       \ offset: 0x38 : LTDC Interrupt Status Register
$4001683c constant LTCD_ICR       \ offset: 0x3C : LTDC Interrupt Clear Register
$40016840 constant LTCD_LIPCR     \ offset: 0x40 : LTDC Line Interrupt Position Configuration Register
$40016844 constant LTCD_CPSR      \ offset: 0x44 : LTDC Current Position Status Register
$40016848 constant LTCD_CDSR      \ offset: 0x48 : LTDC Current Display Status Register
$40016884 constant LTCD_L1CR      \ offset: 0x84 : LTDC Layer Control Register
$40016888 constant LTCD_L1WHPCR   \ offset: 0x88 : LTDC Layer Window Horizontal Position Configuration Register
$4001688c constant LTCD_L1WVPCR   \ offset: 0x8C : LTDC Layer Window Vertical Position Configuration Register
$40016890 constant LTCD_L1CKCR    \ offset: 0x90 : LTDC Layer Color Keying Configuration Register
$40016894 constant LTCD_L1PFCR    \ offset: 0x94 : LTDC Layer Pixel Format Configuration Register
$40016898 constant LTCD_L1CACR    \ offset: 0x98 : LTDC Layer Constant Alpha Configuration Register
$4001689c constant LTCD_L1DCCR    \ offset: 0x9C : LTDC Layer Default Color Configuration Register
$400168a0 constant LTCD_L1BFCR    \ offset: 0xA0 : LTDC Layer Blending Factors Configuration Register
$400168ac constant LTCD_L1CFBAR   \ offset: 0xAC : LTDC Layer Color Frame Buffer Address Register
$400168b0 constant LTCD_L1CFBLR   \ offset: 0xB0 : LTDC Layer Color Frame Buffer Length Register
$400168b4 constant LTCD_L1CFBLNR  \ offset: 0xB4 : LTDC Layer ColorFrame Buffer Line Number Register
$400168c4 constant LTCD_L1CLUTWR  \ offset: 0xC4 : LTDC Layerx CLUT Write Register
$40016904 constant LTCD_L2CR      \ offset: 0x104 : LTDC Layer Control Register
$40016908 constant LTCD_L2WHPCR   \ offset: 0x108 : LTDC Layerx Window Horizontal Position Configuration Register
$4001690c constant LTCD_L2WVPCR   \ offset: 0x10C : LTDC Layer Window Vertical Position Configuration Register
$40016910 constant LTCD_L2CKCR    \ offset: 0x110 : LTDC Layer Color Keying Configuration Register
$40016914 constant LTCD_L2PFCR    \ offset: 0x114 : LTDC Layer Pixel Format Configuration Register
$40016918 constant LTCD_L2CACR    \ offset: 0x118 : LTDC Layer Constant Alpha Configuration Register
$4001691c constant LTCD_L2DCCR    \ offset: 0x11C : LTDC Layer Default Color Configuration Register
$40016924 constant LTCD_L2BFCR    \ offset: 0x124 : LTDC Layer Blending Factors Configuration Register
$4001692c constant LTCD_L2CFBAR   \ offset: 0x12C : LTDC Layer Color Frame Buffer Address Register
$40016930 constant LTCD_L2CFBLR   \ offset: 0x130 : LTDC Layer Color Frame Buffer Length Register
$40016934 constant LTCD_L2CFBLNR  \ offset: 0x134 : LTDC Layer ColorFrame Buffer Line Number Register
$40016944 constant LTCD_L2CLUTWR  \ offset: 0x144 : LTDC Layerx CLUT Write Register

