\
\ @file dcmi.fs
\ @brief Digital camera interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DCMI_CR_CAPTURE                                  \ Capture enable
$00000002 constant DCMI_CR_CM                                       \ Capture mode
$00000004 constant DCMI_CR_CROP                                     \ Crop feature
$00000008 constant DCMI_CR_JPEG                                     \ JPEG format
$00000010 constant DCMI_CR_ESS                                      \ Embedded synchronization select
$00000020 constant DCMI_CR_PCKPOL                                   \ Pixel clock polarity
$00000040 constant DCMI_CR_HSPOL                                    \ Horizontal synchronization polarity
$00000080 constant DCMI_CR_VSPOL                                    \ Vertical synchronization polarity
$00000300 constant DCMI_CR_FCRC                                     \ Frame capture rate control
$00000c00 constant DCMI_CR_EDM                                      \ Extended data mode
$00004000 constant DCMI_CR_ENABLE                                   \ DCMI enable
$00030000 constant DCMI_CR_BSM                                      \ Byte Select mode
$00040000 constant DCMI_CR_OEBS                                     \ Odd/Even Byte Select (Byte Select Start)
$00080000 constant DCMI_CR_LSM                                      \ Line Select mode
$00100000 constant DCMI_CR_OELS                                     \ Odd/Even Line Select (Line Select Start)


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DCMI_SR_HSYNC                                    \ HSYNC
$00000002 constant DCMI_SR_VSYNC                                    \ VSYNC
$00000004 constant DCMI_SR_FNE                                      \ FIFO not empty


\
\ @brief raw interrupt status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DCMI_RIS_FRAME_RIS                               \ Capture complete raw interrupt status
$00000002 constant DCMI_RIS_OVR_RIS                                 \ Overrun raw interrupt status
$00000004 constant DCMI_RIS_ERR_RIS                                 \ Synchronization error raw interrupt status
$00000008 constant DCMI_RIS_VSYNC_RIS                               \ VSYNC raw interrupt status
$00000010 constant DCMI_RIS_LINE_RIS                                \ Line raw interrupt status


\
\ @brief interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant DCMI_IER_FRAME_IE                                \ Capture complete interrupt enable
$00000002 constant DCMI_IER_OVR_IE                                  \ Overrun interrupt enable
$00000004 constant DCMI_IER_ERR_IE                                  \ Synchronization error interrupt enable
$00000008 constant DCMI_IER_VSYNC_IE                                \ VSYNC interrupt enable
$00000010 constant DCMI_IER_LINE_IE                                 \ Line interrupt enable


\
\ @brief masked interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant DCMI_MIS_FRAME_MIS                               \ Capture complete masked interrupt status
$00000002 constant DCMI_MIS_OVR_MIS                                 \ Overrun masked interrupt status
$00000004 constant DCMI_MIS_ERR_MIS                                 \ Synchronization error masked interrupt status
$00000008 constant DCMI_MIS_VSYNC_MIS                               \ VSYNC masked interrupt status
$00000010 constant DCMI_MIS_LINE_MIS                                \ Line masked interrupt status


\
\ @brief interrupt clear register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant DCMI_ICR_FRAME_ISC                               \ Capture complete interrupt status clear
$00000002 constant DCMI_ICR_OVR_ISC                                 \ Overrun interrupt status clear
$00000004 constant DCMI_ICR_ERR_ISC                                 \ Synchronization error interrupt status clear
$00000008 constant DCMI_ICR_VSYNC_ISC                               \ Vertical synch interrupt status clear
$00000010 constant DCMI_ICR_LINE_ISC                                \ line interrupt status clear


\
\ @brief embedded synchronization code register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant DCMI_ESCR_FSC                                    \ Frame start delimiter code
$0000ff00 constant DCMI_ESCR_LSC                                    \ Line start delimiter code
$00ff0000 constant DCMI_ESCR_LEC                                    \ Line end delimiter code
$ff000000 constant DCMI_ESCR_FEC                                    \ Frame end delimiter code


\
\ @brief embedded synchronization unmask register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant DCMI_ESUR_FSU                                    \ Frame start delimiter unmask
$0000ff00 constant DCMI_ESUR_LSU                                    \ Line start delimiter unmask
$00ff0000 constant DCMI_ESUR_LEU                                    \ Line end delimiter unmask
$ff000000 constant DCMI_ESUR_FEU                                    \ Frame end delimiter unmask


\
\ @brief crop window start
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00003fff constant DCMI_CWSTRT_HOFFCNT                              \ Horizontal offset count
$1fff0000 constant DCMI_CWSTRT_VST                                  \ Vertical start line count


\
\ @brief crop window size
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00003fff constant DCMI_CWSIZE_CAPCNT                               \ Capture count
$3fff0000 constant DCMI_CWSIZE_VLINE                                \ Vertical line count


\
\ @brief data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DCMI_DR_BYTE0                                    \ Data byte 0
$0000ff00 constant DCMI_DR_BYTE1                                    \ Data byte 1
$00ff0000 constant DCMI_DR_BYTE2                                    \ Data byte 2
$ff000000 constant DCMI_DR_BYTE3                                    \ Data byte 3


\
\ @brief Digital camera interface
\
$48020000 constant DCMI_CR        \ offset: 0x00 : control register 1
$48020004 constant DCMI_SR        \ offset: 0x04 : status register
$48020008 constant DCMI_RIS       \ offset: 0x08 : raw interrupt status register
$4802000c constant DCMI_IER       \ offset: 0x0C : interrupt enable register
$48020010 constant DCMI_MIS       \ offset: 0x10 : masked interrupt status register
$48020014 constant DCMI_ICR       \ offset: 0x14 : interrupt clear register
$48020018 constant DCMI_ESCR      \ offset: 0x18 : embedded synchronization code register
$4802001c constant DCMI_ESUR      \ offset: 0x1C : embedded synchronization unmask register
$48020020 constant DCMI_CWSTRT    \ offset: 0x20 : crop window start
$48020024 constant DCMI_CWSIZE    \ offset: 0x24 : crop window size
$48020028 constant DCMI_DR        \ offset: 0x28 : data register

