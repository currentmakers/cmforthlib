\
\ @file dcmi_s.fs
\ @brief Digital camera interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DCMI control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DCMI_S_DCMI_CR_CAPTURE                           \ Capture enable
$00000002 constant DCMI_S_DCMI_CR_CM                                \ Capture mode
$00000004 constant DCMI_S_DCMI_CR_CROP                              \ Crop feature
$00000008 constant DCMI_S_DCMI_CR_JPEG                              \ JPEG format
$00000010 constant DCMI_S_DCMI_CR_ESS                               \ Embedded synchronization select
$00000020 constant DCMI_S_DCMI_CR_PCKPOL                            \ Pixel clock polarity
$00000040 constant DCMI_S_DCMI_CR_HSPOL                             \ Horizontal synchronization polarity
$00000080 constant DCMI_S_DCMI_CR_VSPOL                             \ Vertical synchronization polarity
$00000300 constant DCMI_S_DCMI_CR_FCRC                              \ Frame capture rate control
$00000c00 constant DCMI_S_DCMI_CR_EDM                               \ Extended data mode
$00004000 constant DCMI_S_DCMI_CR_ENABLE                            \ DCMI enable
$00030000 constant DCMI_S_DCMI_CR_BSM                               \ Byte Select mode
$00040000 constant DCMI_S_DCMI_CR_OEBS                              \ Odd/Even Byte Select (Byte Select Start)
$00080000 constant DCMI_S_DCMI_CR_LSM                               \ Line Select mode
$00100000 constant DCMI_S_DCMI_CR_OELS                              \ Odd/Even Line Select (Line Select Start)


\
\ @brief DCMI status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DCMI_S_DCMI_SR_HSYNC                             \ Horizontal synchronization
$00000002 constant DCMI_S_DCMI_SR_VSYNC                             \ Vertical synchronization
$00000004 constant DCMI_S_DCMI_SR_FNE                               \ FIFO not empty


\
\ @brief DCMI raw interrupt status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DCMI_S_DCMI_RIS_FRAME_RIS                        \ Capture complete raw interrupt status
$00000002 constant DCMI_S_DCMI_RIS_OVR_RIS                          \ Overrun raw interrupt status
$00000004 constant DCMI_S_DCMI_RIS_ERR_RIS                          \ Synchronization error raw interrupt status
$00000008 constant DCMI_S_DCMI_RIS_VSYNC_RIS                        \ DCMI_VSYNC raw interrupt status
$00000010 constant DCMI_S_DCMI_RIS_LINE_RIS                         \ Line raw interrupt status


\
\ @brief DCMI interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant DCMI_S_DCMI_IER_FRAME_IE                         \ Capture complete interrupt enable
$00000002 constant DCMI_S_DCMI_IER_OVR_IE                           \ Overrun interrupt enable
$00000004 constant DCMI_S_DCMI_IER_ERR_IE                           \ Synchronization error interrupt enable
$00000008 constant DCMI_S_DCMI_IER_VSYNC_IE                         \ DCMI_VSYNC interrupt enable
$00000010 constant DCMI_S_DCMI_IER_LINE_IE                          \ Line interrupt enable


\
\ @brief DCMI masked interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant DCMI_S_DCMI_MIS_FRAME_MIS                        \ Capture complete masked interrupt status
$00000002 constant DCMI_S_DCMI_MIS_OVR_MIS                          \ Overrun masked interrupt status
$00000004 constant DCMI_S_DCMI_MIS_ERR_MIS                          \ Synchronization error masked interrupt status
$00000008 constant DCMI_S_DCMI_MIS_VSYNC_MIS                        \ VSYNC masked interrupt status
$00000010 constant DCMI_S_DCMI_MIS_LINE_MIS                         \ Line masked interrupt status


\
\ @brief DCMI interrupt clear register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant DCMI_S_DCMI_ICR_FRAME_ISC                        \ Capture complete interrupt status clear
$00000002 constant DCMI_S_DCMI_ICR_OVR_ISC                          \ Overrun interrupt status clear
$00000004 constant DCMI_S_DCMI_ICR_ERR_ISC                          \ Synchronization error interrupt status clear
$00000008 constant DCMI_S_DCMI_ICR_VSYNC_ISC                        \ Vertical Synchronization interrupt status clear
$00000010 constant DCMI_S_DCMI_ICR_LINE_ISC                         \ line interrupt status clear


\
\ @brief DCMI embedded synchronization code register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant DCMI_S_DCMI_ESCR_FSC                             \ Frame start delimiter code
$0000ff00 constant DCMI_S_DCMI_ESCR_LSC                             \ Line start delimiter code
$00ff0000 constant DCMI_S_DCMI_ESCR_LEC                             \ Line end delimiter code
$ff000000 constant DCMI_S_DCMI_ESCR_FEC                             \ Frame end delimiter code


\
\ @brief DCMI embedded synchronization unmask register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant DCMI_S_DCMI_ESUR_FSU                             \ Frame start delimiter unmask
$0000ff00 constant DCMI_S_DCMI_ESUR_LSU                             \ Line start delimiter unmask
$00ff0000 constant DCMI_S_DCMI_ESUR_LEU                             \ Line end delimiter unmask
$ff000000 constant DCMI_S_DCMI_ESUR_FEU                             \ Frame end delimiter unmask


\
\ @brief DCMI crop window start
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00003fff constant DCMI_S_DCMI_CWSTRT_HOFFCNT                       \ Horizontal offset count
$1fff0000 constant DCMI_S_DCMI_CWSTRT_VST                           \ Vertical start line count


\
\ @brief DCMI crop window size
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00003fff constant DCMI_S_DCMI_CWSIZE_CAPCNT                        \ Capture count
$3fff0000 constant DCMI_S_DCMI_CWSIZE_VLINE                         \ Vertical line count


\
\ @brief DCMI data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DCMI_S_DCMI_DR_BYTE0                             \ Data byte 0
$0000ff00 constant DCMI_S_DCMI_DR_BYTE1                             \ Data byte 1
$00ff0000 constant DCMI_S_DCMI_DR_BYTE2                             \ Data byte 2
$ff000000 constant DCMI_S_DCMI_DR_BYTE3                             \ Data byte 3


\
\ @brief Digital camera interface
\
$58028400 constant DCMI_S_DCMI_CR  \ offset: 0x00 : DCMI control register
$58028404 constant DCMI_S_DCMI_SR  \ offset: 0x04 : DCMI status register
$58028408 constant DCMI_S_DCMI_RIS  \ offset: 0x08 : DCMI raw interrupt status register
$5802840c constant DCMI_S_DCMI_IER  \ offset: 0x0C : DCMI interrupt enable register
$58028410 constant DCMI_S_DCMI_MIS  \ offset: 0x10 : DCMI masked interrupt status register
$58028414 constant DCMI_S_DCMI_ICR  \ offset: 0x14 : DCMI interrupt clear register
$58028418 constant DCMI_S_DCMI_ESCR  \ offset: 0x18 : DCMI embedded synchronization code register
$5802841c constant DCMI_S_DCMI_ESUR  \ offset: 0x1C : DCMI embedded synchronization unmask register
$58028420 constant DCMI_S_DCMI_CWSTRT  \ offset: 0x20 : DCMI crop window start
$58028424 constant DCMI_S_DCMI_CWSIZE  \ offset: 0x24 : DCMI crop window size
$58028428 constant DCMI_S_DCMI_DR  \ offset: 0x28 : DCMI data register

