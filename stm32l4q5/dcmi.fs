\
\ @file dcmi.fs
\ @brief Digital camera interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DCMI_DEF

  [ifdef] DCMI_CR_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_CAPTURE                   \ [0x00] Capture enable
    $01 constant DCMI_CM                        \ [0x01] Capture mode
    $02 constant DCMI_CROP                      \ [0x02] Crop feature
    $03 constant DCMI_JPEG                      \ [0x03] JPEG format
    $04 constant DCMI_ESS                       \ [0x04] Embedded synchronization select
    $05 constant DCMI_PCKPOL                    \ [0x05] Pixel clock polarity
    $06 constant DCMI_HSPOL                     \ [0x06] Horizontal synchronization polarity
    $07 constant DCMI_VSPOL                     \ [0x07] Vertical synchronization polarity
    $08 constant DCMI_FCRC                      \ [0x08 : 2] Frame capture rate control
    $0a constant DCMI_EDM                       \ [0x0a : 2] Extended data mode
    $0e constant DCMI_ENABLE                    \ [0x0e] DCMI enable
    $10 constant DCMI_BSM                       \ [0x10 : 2] Byte Select mode
    $12 constant DCMI_OEBS                      \ [0x12] Odd/Even Byte Select (Byte Select Start)
    $13 constant DCMI_LSM                       \ [0x13] Line Select mode
    $14 constant DCMI_OELS                      \ [0x14] Odd/Even Line Select (Line Select Start)
  [then]


  [ifdef] DCMI_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_HSYNC                     \ [0x00] HSYNC
    $01 constant DCMI_VSYNC                     \ [0x01] VSYNC
    $02 constant DCMI_FNE                       \ [0x02] FIFO not empty
  [then]


  [ifdef] DCMI_RIS_DEF
    \
    \ @brief raw interrupt status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_RIS                 \ [0x00] Capture complete raw interrupt status
    $01 constant DCMI_OVR_RIS                   \ [0x01] Overrun raw interrupt status
    $02 constant DCMI_ERR_RIS                   \ [0x02] Synchronization error raw interrupt status
    $03 constant DCMI_VSYNC_RIS                 \ [0x03] VSYNC raw interrupt status
    $04 constant DCMI_LINE_RIS                  \ [0x04] Line raw interrupt status
  [then]


  [ifdef] DCMI_IER_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_IE                  \ [0x00] Capture complete interrupt enable
    $01 constant DCMI_OVR_IE                    \ [0x01] Overrun interrupt enable
    $02 constant DCMI_ERR_IE                    \ [0x02] Synchronization error interrupt enable
    $03 constant DCMI_VSYNC_IE                  \ [0x03] VSYNC interrupt enable
    $04 constant DCMI_LINE_IE                   \ [0x04] Line interrupt enable
  [then]


  [ifdef] DCMI_MIS_DEF
    \
    \ @brief masked interrupt status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_MIS                 \ [0x00] Capture complete masked interrupt status
    $01 constant DCMI_OVR_MIS                   \ [0x01] Overrun masked interrupt status
    $02 constant DCMI_ERR_MIS                   \ [0x02] Synchronization error masked interrupt status
    $03 constant DCMI_VSYNC_MIS                 \ [0x03] VSYNC masked interrupt status
    $04 constant DCMI_LINE_MIS                  \ [0x04] Line masked interrupt status
  [then]


  [ifdef] DCMI_ICR_DEF
    \
    \ @brief interrupt clear register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_ISC                 \ [0x00] Capture complete interrupt status clear
    $01 constant DCMI_OVR_ISC                   \ [0x01] Overrun interrupt status clear
    $02 constant DCMI_ERR_ISC                   \ [0x02] Synchronization error interrupt status clear
    $03 constant DCMI_VSYNC_ISC                 \ [0x03] Vertical synch interrupt status clear
    $04 constant DCMI_LINE_ISC                  \ [0x04] line interrupt status clear
  [then]


  [ifdef] DCMI_ESCR_DEF
    \
    \ @brief embedded synchronization code register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FSC                       \ [0x00 : 8] Frame start delimiter code
    $08 constant DCMI_LSC                       \ [0x08 : 8] Line start delimiter code
    $10 constant DCMI_LEC                       \ [0x10 : 8] Line end delimiter code
    $18 constant DCMI_FEC                       \ [0x18 : 8] Frame end delimiter code
  [then]


  [ifdef] DCMI_ESUR_DEF
    \
    \ @brief embedded synchronization unmask register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FSU                       \ [0x00 : 8] Frame start delimiter unmask
    $08 constant DCMI_LSU                       \ [0x08 : 8] Line start delimiter unmask
    $10 constant DCMI_LEU                       \ [0x10 : 8] Line end delimiter unmask
    $18 constant DCMI_FEU                       \ [0x18 : 8] Frame end delimiter unmask
  [then]


  [ifdef] DCMI_CWSTRT_DEF
    \
    \ @brief crop window start
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_HOFFCNT                   \ [0x00 : 14] Horizontal offset count
    $10 constant DCMI_VST                       \ [0x10 : 13] Vertical start line count
  [then]


  [ifdef] DCMI_CWSIZE_DEF
    \
    \ @brief crop window size
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_CAPCNT                    \ [0x00 : 14] Capture count
    $10 constant DCMI_VLINE                     \ [0x10 : 14] Vertical line count
  [then]


  [ifdef] DCMI_DR_DEF
    \
    \ @brief data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_Byte0                     \ [0x00 : 8] Data byte 0
    $08 constant DCMI_Byte1                     \ [0x08 : 8] Data byte 1
    $10 constant DCMI_Byte2                     \ [0x10 : 8] Data byte 2
    $18 constant DCMI_Byte3                     \ [0x18 : 8] Data byte 3
  [then]

  \
  \ @brief Digital camera interface
  \
  $00 constant DCMI_CR                  \ control register 1
  $04 constant DCMI_SR                  \ status register
  $08 constant DCMI_RIS                 \ raw interrupt status register
  $0C constant DCMI_IER                 \ interrupt enable register
  $10 constant DCMI_MIS                 \ masked interrupt status register
  $14 constant DCMI_ICR                 \ interrupt clear register
  $18 constant DCMI_ESCR                \ embedded synchronization code register
  $1C constant DCMI_ESUR                \ embedded synchronization unmask register
  $20 constant DCMI_CWSTRT              \ crop window start
  $24 constant DCMI_CWSIZE              \ crop window size
  $28 constant DCMI_DR                  \ data register

: DCMI_DEF ; [then]
