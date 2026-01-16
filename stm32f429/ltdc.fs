\
\ @file ltdc.fs
\ @brief LCD-TFT Controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Synchronization Size Configuration Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000007ff constant LTDC_SSCR_VSH                                    \ Vertical Synchronization Height (in units of horizontal scan line)
$0fff0000 constant LTDC_SSCR_HSW                                    \ Horizontal Synchronization Width (in units of pixel clock period)


\
\ @brief Back Porch Configuration Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000007ff constant LTDC_BPCR_AVBP                                   \ Accumulated Vertical back porch (in units of horizontal scan line)
$0fff0000 constant LTDC_BPCR_AHBP                                   \ Accumulated Horizontal back porch (in units of pixel clock period)


\
\ @brief Active Width Configuration Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000007ff constant LTDC_AWCR_AAH                                    \ Accumulated Active Height (in units of horizontal scan line)
$0fff0000 constant LTDC_AWCR_AAW                                    \ AAW


\
\ @brief Total Width Configuration Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000007ff constant LTDC_TWCR_TOTALH                                 \ Total Height (in units of horizontal scan line)
$0fff0000 constant LTDC_TWCR_TOTALW                                 \ Total Width (in units of pixel clock period)


\
\ @brief Global Control Register
\ Address offset: 0x18
\ Reset value: 0x00002220
\

$00000001 constant LTDC_GCR_LTDCEN                                  \ LCD-TFT controller enable bit
$00000070 constant LTDC_GCR_DBW                                     \ Dither Blue Width
$00000700 constant LTDC_GCR_DGW                                     \ Dither Green Width
$00007000 constant LTDC_GCR_DRW                                     \ Dither Red Width
$00010000 constant LTDC_GCR_DEN                                     \ Dither Enable
$10000000 constant LTDC_GCR_PCPOL                                   \ Pixel Clock Polarity
$20000000 constant LTDC_GCR_DEPOL                                   \ Data Enable Polarity
$40000000 constant LTDC_GCR_VSPOL                                   \ Vertical Synchronization Polarity
$80000000 constant LTDC_GCR_HSPOL                                   \ Horizontal Synchronization Polarity


\
\ @brief Shadow Reload Configuration Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant LTDC_SRCR_IMR                                    \ Immediate Reload
$00000002 constant LTDC_SRCR_VBR                                    \ Vertical Blanking Reload


\
\ @brief Background Color Configuration Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00ffffff constant LTDC_BCCR_BC                                     \ Background Color Red value


\
\ @brief Interrupt Enable Register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant LTDC_IER_LIE                                     \ Line Interrupt Enable
$00000002 constant LTDC_IER_FUIE                                    \ FIFO Underrun Interrupt Enable
$00000004 constant LTDC_IER_TERRIE                                  \ Transfer Error Interrupt Enable
$00000008 constant LTDC_IER_RRIE                                    \ Register Reload interrupt enable


\
\ @brief Interrupt Status Register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant LTDC_ISR_LIF                                     \ Line Interrupt flag
$00000002 constant LTDC_ISR_FUIF                                    \ FIFO Underrun Interrupt flag
$00000004 constant LTDC_ISR_TERRIF                                  \ Transfer Error interrupt flag
$00000008 constant LTDC_ISR_RRIF                                    \ Register Reload Interrupt Flag


\
\ @brief Interrupt Clear Register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant LTDC_ICR_CLIF                                    \ Clears the Line Interrupt Flag
$00000002 constant LTDC_ICR_CFUIF                                   \ Clears the FIFO Underrun Interrupt flag
$00000004 constant LTDC_ICR_CTERRIF                                 \ Clears the Transfer Error Interrupt Flag
$00000008 constant LTDC_ICR_CRRIF                                   \ Clears Register Reload Interrupt Flag


\
\ @brief Line Interrupt Position Configuration Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000007ff constant LTDC_LIPCR_LIPOS                                 \ Line Interrupt Position


\
\ @brief Current Position Status Register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant LTDC_CPSR_CYPOS                                  \ Current Y Position
$ffff0000 constant LTDC_CPSR_CXPOS                                  \ Current X Position


\
\ @brief Current Display Status Register
\ Address offset: 0x48
\ Reset value: 0x0000000F
\

$00000001 constant LTDC_CDSR_VDES                                   \ Vertical Data Enable display Status
$00000002 constant LTDC_CDSR_HDES                                   \ Horizontal Data Enable display Status
$00000004 constant LTDC_CDSR_VSYNCS                                 \ Vertical Synchronization display Status
$00000008 constant LTDC_CDSR_HSYNCS                                 \ Horizontal Synchronization display Status


\
\ @brief Layerx Control Register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant LTDC_L1CR_LEN                                    \ Layer Enable
$00000002 constant LTDC_L1CR_COLKEN                                 \ Color Keying Enable
$00000010 constant LTDC_L1CR_CLUTEN                                 \ Color Look-Up Table Enable


\
\ @brief Layerx Window Horizontal Position Configuration Register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000fff constant LTDC_L1WHPCR_WHSTPOS                             \ Window Horizontal Start Position
$0fff0000 constant LTDC_L1WHPCR_WHSPPOS                             \ Window Horizontal Stop Position


\
\ @brief Layerx Window Vertical Position Configuration Register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$000007ff constant LTDC_L1WVPCR_WVSTPOS                             \ Window Vertical Start Position
$07ff0000 constant LTDC_L1WVPCR_WVSPPOS                             \ Window Vertical Stop Position


\
\ @brief Layerx Color Keying Configuration Register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$000000ff constant LTDC_L1CKCR_CKBLUE                               \ Color Key Blue value
$0000ff00 constant LTDC_L1CKCR_CKGREEN                              \ Color Key Green value
$00ff0000 constant LTDC_L1CKCR_CKRED                                \ Color Key Red value


\
\ @brief Layerx Pixel Format Configuration Register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000007 constant LTDC_L1PFCR_PF                                   \ Pixel Format


\
\ @brief Layerx Constant Alpha Configuration Register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$000000ff constant LTDC_L1CACR_CONSTA                               \ Constant Alpha


\
\ @brief Layerx Default Color Configuration Register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$000000ff constant LTDC_L1DCCR_DCBLUE                               \ Default Color Blue
$0000ff00 constant LTDC_L1DCCR_DCGREEN                              \ Default Color Green
$00ff0000 constant LTDC_L1DCCR_DCRED                                \ Default Color Red
$ff000000 constant LTDC_L1DCCR_DCALPHA                              \ Default Color Alpha


\
\ @brief Layerx Blending Factors Configuration Register
\ Address offset: 0xA0
\ Reset value: 0x00000607
\

$00000007 constant LTDC_L1BFCR_BF2                                  \ Blending Factor 2
$00000700 constant LTDC_L1BFCR_BF1                                  \ Blending Factor 1


\
\ @brief Layerx Color Frame Buffer Address Register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant LTDC_L1CFBAR_CFBADD                              \ Color Frame Buffer Start Address


\
\ @brief Layerx Color Frame Buffer Length Register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00001fff constant LTDC_L1CFBLR_CFBLL                               \ Color Frame Buffer Line Length
$1fff0000 constant LTDC_L1CFBLR_CFBP                                \ Color Frame Buffer Pitch in bytes


\
\ @brief Layerx ColorFrame Buffer Line Number Register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$000007ff constant LTDC_L1CFBLNR_CFBLNBR                            \ Frame Buffer Line Number


\
\ @brief Layerx CLUT Write Register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000ff constant LTDC_L1CLUTWR_BLUE                               \ Blue value
$0000ff00 constant LTDC_L1CLUTWR_GREEN                              \ Green value
$00ff0000 constant LTDC_L1CLUTWR_RED                                \ Red value
$ff000000 constant LTDC_L1CLUTWR_CLUTADD                            \ CLUT Address


\
\ @brief Layerx Control Register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant LTDC_L2CR_LEN                                    \ Layer Enable
$00000002 constant LTDC_L2CR_COLKEN                                 \ Color Keying Enable
$00000010 constant LTDC_L2CR_CLUTEN                                 \ Color Look-Up Table Enable


\
\ @brief Layerx Window Horizontal Position Configuration Register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000fff constant LTDC_L2WHPCR_WHSTPOS                             \ Window Horizontal Start Position
$0fff0000 constant LTDC_L2WHPCR_WHSPPOS                             \ Window Horizontal Stop Position


\
\ @brief Layerx Window Vertical Position Configuration Register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$000007ff constant LTDC_L2WVPCR_WVSTPOS                             \ Window Vertical Start Position
$07ff0000 constant LTDC_L2WVPCR_WVSPPOS                             \ Window Vertical Stop Position


\
\ @brief Layerx Color Keying Configuration Register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$000000ff constant LTDC_L2CKCR_CKBLUE                               \ Color Key Blue value
$00007f00 constant LTDC_L2CKCR_CKGREEN                              \ Color Key Green value
$00ff8000 constant LTDC_L2CKCR_CKRED                                \ Color Key Red value


\
\ @brief Layerx Pixel Format Configuration Register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000007 constant LTDC_L2PFCR_PF                                   \ Pixel Format


\
\ @brief Layerx Constant Alpha Configuration Register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$000000ff constant LTDC_L2CACR_CONSTA                               \ Constant Alpha


\
\ @brief Layerx Default Color Configuration Register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$000000ff constant LTDC_L2DCCR_DCBLUE                               \ Default Color Blue
$0000ff00 constant LTDC_L2DCCR_DCGREEN                              \ Default Color Green
$00ff0000 constant LTDC_L2DCCR_DCRED                                \ Default Color Red
$ff000000 constant LTDC_L2DCCR_DCALPHA                              \ Default Color Alpha


\
\ @brief Layerx Blending Factors Configuration Register
\ Address offset: 0x120
\ Reset value: 0x00000607
\

$00000007 constant LTDC_L2BFCR_BF2                                  \ Blending Factor 2
$00000700 constant LTDC_L2BFCR_BF1                                  \ Blending Factor 1


\
\ @brief Layerx Color Frame Buffer Address Register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant LTDC_L2CFBAR_CFBADD                              \ Color Frame Buffer Start Address


\
\ @brief Layerx Color Frame Buffer Length Register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00001fff constant LTDC_L2CFBLR_CFBLL                               \ Color Frame Buffer Line Length
$1fff0000 constant LTDC_L2CFBLR_CFBP                                \ Color Frame Buffer Pitch in bytes


\
\ @brief Layerx ColorFrame Buffer Line Number Register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$000007ff constant LTDC_L2CFBLNR_CFBLNBR                            \ Frame Buffer Line Number


\
\ @brief Layerx CLUT Write Register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$000000ff constant LTDC_L2CLUTWR_BLUE                               \ Blue value
$0000ff00 constant LTDC_L2CLUTWR_GREEN                              \ Green value
$00ff0000 constant LTDC_L2CLUTWR_RED                                \ Red value
$ff000000 constant LTDC_L2CLUTWR_CLUTADD                            \ CLUT Address


\
\ @brief LCD-TFT Controller
\
$40016808 constant LTDC_SSCR      \ offset: 0x08 : Synchronization Size Configuration Register
$4001680c constant LTDC_BPCR      \ offset: 0x0C : Back Porch Configuration Register
$40016810 constant LTDC_AWCR      \ offset: 0x10 : Active Width Configuration Register
$40016814 constant LTDC_TWCR      \ offset: 0x14 : Total Width Configuration Register
$40016818 constant LTDC_GCR       \ offset: 0x18 : Global Control Register
$40016824 constant LTDC_SRCR      \ offset: 0x24 : Shadow Reload Configuration Register
$4001682c constant LTDC_BCCR      \ offset: 0x2C : Background Color Configuration Register
$40016834 constant LTDC_IER       \ offset: 0x34 : Interrupt Enable Register
$40016838 constant LTDC_ISR       \ offset: 0x38 : Interrupt Status Register
$4001683c constant LTDC_ICR       \ offset: 0x3C : Interrupt Clear Register
$40016840 constant LTDC_LIPCR     \ offset: 0x40 : Line Interrupt Position Configuration Register
$40016844 constant LTDC_CPSR      \ offset: 0x44 : Current Position Status Register
$40016848 constant LTDC_CDSR      \ offset: 0x48 : Current Display Status Register
$40016884 constant LTDC_L1CR      \ offset: 0x84 : Layerx Control Register
$40016888 constant LTDC_L1WHPCR   \ offset: 0x88 : Layerx Window Horizontal Position Configuration Register
$4001688c constant LTDC_L1WVPCR   \ offset: 0x8C : Layerx Window Vertical Position Configuration Register
$40016890 constant LTDC_L1CKCR    \ offset: 0x90 : Layerx Color Keying Configuration Register
$40016894 constant LTDC_L1PFCR    \ offset: 0x94 : Layerx Pixel Format Configuration Register
$40016898 constant LTDC_L1CACR    \ offset: 0x98 : Layerx Constant Alpha Configuration Register
$4001689c constant LTDC_L1DCCR    \ offset: 0x9C : Layerx Default Color Configuration Register
$400168a0 constant LTDC_L1BFCR    \ offset: 0xA0 : Layerx Blending Factors Configuration Register
$400168ac constant LTDC_L1CFBAR   \ offset: 0xAC : Layerx Color Frame Buffer Address Register
$400168b0 constant LTDC_L1CFBLR   \ offset: 0xB0 : Layerx Color Frame Buffer Length Register
$400168b4 constant LTDC_L1CFBLNR  \ offset: 0xB4 : Layerx ColorFrame Buffer Line Number Register
$400168c4 constant LTDC_L1CLUTWR  \ offset: 0xC4 : Layerx CLUT Write Register
$40016904 constant LTDC_L2CR      \ offset: 0x104 : Layerx Control Register
$40016908 constant LTDC_L2WHPCR   \ offset: 0x108 : Layerx Window Horizontal Position Configuration Register
$4001690c constant LTDC_L2WVPCR   \ offset: 0x10C : Layerx Window Vertical Position Configuration Register
$40016910 constant LTDC_L2CKCR    \ offset: 0x110 : Layerx Color Keying Configuration Register
$40016914 constant LTDC_L2PFCR    \ offset: 0x114 : Layerx Pixel Format Configuration Register
$40016918 constant LTDC_L2CACR    \ offset: 0x118 : Layerx Constant Alpha Configuration Register
$4001691c constant LTDC_L2DCCR    \ offset: 0x11C : Layerx Default Color Configuration Register
$40016920 constant LTDC_L2BFCR    \ offset: 0x120 : Layerx Blending Factors Configuration Register
$4001692c constant LTDC_L2CFBAR   \ offset: 0x12C : Layerx Color Frame Buffer Address Register
$40016930 constant LTDC_L2CFBLR   \ offset: 0x130 : Layerx Color Frame Buffer Length Register
$40016934 constant LTDC_L2CFBLNR  \ offset: 0x134 : Layerx ColorFrame Buffer Line Number Register
$40016944 constant LTDC_L2CLUTWR  \ offset: 0x144 : Layerx CLUT Write Register

