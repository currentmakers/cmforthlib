\
\ @file dcmi.fs
\ @brief DCMI
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DCMI_DEF

  [ifdef] DCMI_DCMI_CR_DEF
    \
    \ @brief DCMI control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_CAPTURE                   \ [0x00] CAPTURE
    $01 constant DCMI_CM                        \ [0x01] CM
    $02 constant DCMI_CROP                      \ [0x02] CROP
    $03 constant DCMI_JPEG                      \ [0x03] JPEG
    $04 constant DCMI_ESS                       \ [0x04] ESS
    $05 constant DCMI_PCKPOL                    \ [0x05] PCKPOL
    $06 constant DCMI_HSPOL                     \ [0x06] HSPOL
    $07 constant DCMI_VSPOL                     \ [0x07] VSPOL
    $08 constant DCMI_FCRC                      \ [0x08 : 2] FCRC
    $0a constant DCMI_EDM                       \ [0x0a : 2] EDM
    $0e constant DCMI_ENABLE                    \ [0x0e] ENABLE
    $10 constant DCMI_BSM                       \ [0x10 : 2] BSM
    $12 constant DCMI_OEBS                      \ [0x12] OEBS
    $13 constant DCMI_LSM                       \ [0x13] LSM
    $14 constant DCMI_OELS                      \ [0x14] OELS
  [then]


  [ifdef] DCMI_DCMI_SR_DEF
    \
    \ @brief DCMI status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_HSYNC                     \ [0x00] HSYNC
    $01 constant DCMI_VSYNC                     \ [0x01] VSYNC
    $02 constant DCMI_FNE                       \ [0x02] FNE
  [then]


  [ifdef] DCMI_DCMI_RIS_DEF
    \
    \ @brief DCMI_RIS gives the raw interrupt status and is accessible in read only. When read, this register returns the status of the corresponding interrupt before masking with the DCMI_IER register value.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_RIS                 \ [0x00] FRAME_RIS
    $01 constant DCMI_OVR_RIS                   \ [0x01] OVR_RIS
    $02 constant DCMI_ERR_RIS                   \ [0x02] ERR_RIS
    $03 constant DCMI_VSYNC_RIS                 \ [0x03] VSYNC_RIS
    $04 constant DCMI_LINE_RIS                  \ [0x04] LINE_RIS
  [then]


  [ifdef] DCMI_DCMI_IER_DEF
    \
    \ @brief The DCMI_IER register is used to enable interrupts. When one of the DCMI_IER bits is set, the corresponding interrupt is enabled. This register is accessible in both read and write.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_IE                  \ [0x00] FRAME_IE
    $01 constant DCMI_OVR_IE                    \ [0x01] OVR_IE
    $02 constant DCMI_ERR_IE                    \ [0x02] ERR_IE
    $03 constant DCMI_VSYNC_IE                  \ [0x03] VSYNC_IE
    $04 constant DCMI_LINE_IE                   \ [0x04] LINE_IE
  [then]


  [ifdef] DCMI_DCMI_MIS_DEF
    \
    \ @brief This DCMI_MIS register is a read-only register. When read, it returns the current masked status value (depending on the value in DCMI_IER) of the corresponding interrupt. A bit in this register is set if the corresponding enable bit in DCMI_IER is set and the corresponding bit in DCMI_RIS is set.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_MIS                 \ [0x00] FRAME_MIS
    $01 constant DCMI_OVR_MIS                   \ [0x01] OVR_MIS
    $02 constant DCMI_ERR_MIS                   \ [0x02] ERR_MIS
    $03 constant DCMI_VSYNC_MIS                 \ [0x03] VSYNC_MIS
    $04 constant DCMI_LINE_MIS                  \ [0x04] LINE_MIS
  [then]


  [ifdef] DCMI_DCMI_ICR_DEF
    \
    \ @brief The DCMI_ICR register is write-only.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FRAME_ISC                 \ [0x00] FRAME_ISC
    $01 constant DCMI_OVR_ISC                   \ [0x01] OVR_ISC
    $02 constant DCMI_ERR_ISC                   \ [0x02] ERR_ISC
    $03 constant DCMI_VSYNC_ISC                 \ [0x03] VSYNC_ISC
    $04 constant DCMI_LINE_ISC                  \ [0x04] LINE_ISC
  [then]


  [ifdef] DCMI_DCMI_ESCR_DEF
    \
    \ @brief DCMI embedded synchronization code register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FSC                       \ [0x00 : 8] FSC
    $08 constant DCMI_LSC                       \ [0x08 : 8] LSC
    $10 constant DCMI_LEC                       \ [0x10 : 8] LEC
    $18 constant DCMI_FEC                       \ [0x18 : 8] FEC
  [then]


  [ifdef] DCMI_DCMI_ESUR_DEF
    \
    \ @brief DCMI embedded synchronization unmask register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_FSU                       \ [0x00 : 8] FSU
    $08 constant DCMI_LSU                       \ [0x08 : 8] LSU
    $10 constant DCMI_LEU                       \ [0x10 : 8] LEU
    $18 constant DCMI_FEU                       \ [0x18 : 8] FEU
  [then]


  [ifdef] DCMI_DCMI_CWSTRT_DEF
    \
    \ @brief DCMI crop window start
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_HOFFCNT                   \ [0x00 : 14] HOFFCNT
    $10 constant DCMI_VST                       \ [0x10 : 13] VST
  [then]


  [ifdef] DCMI_DCMI_CWSIZE_DEF
    \
    \ @brief DCMI crop window size
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_CAPCNT                    \ [0x00 : 14] CAPCNT
    $10 constant DCMI_VLINE                     \ [0x10 : 14] VLINE
  [then]


  [ifdef] DCMI_DCMI_DR_DEF
    \
    \ @brief DCMI data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DCMI_Byte0                     \ [0x00 : 8] Byte0
    $08 constant DCMI_Byte1                     \ [0x08 : 8] Byte1
    $10 constant DCMI_Byte2                     \ [0x10 : 8] Byte2
    $18 constant DCMI_Byte3                     \ [0x18 : 8] Byte3
  [then]

  \
  \ @brief DCMI
  \
  $00 constant DCMI_DCMI_CR             \ DCMI control register
  $04 constant DCMI_DCMI_SR             \ DCMI status register
  $08 constant DCMI_DCMI_RIS            \ DCMI_RIS gives the raw interrupt status and is accessible in read only. When read, this register returns the status of the corresponding interrupt before masking with the DCMI_IER register value.
  $0C constant DCMI_DCMI_IER            \ The DCMI_IER register is used to enable interrupts. When one of the DCMI_IER bits is set, the corresponding interrupt is enabled. This register is accessible in both read and write.
  $10 constant DCMI_DCMI_MIS            \ This DCMI_MIS register is a read-only register. When read, it returns the current masked status value (depending on the value in DCMI_IER) of the corresponding interrupt. A bit in this register is set if the corresponding enable bit in DCMI_IER is set and the corresponding bit in DCMI_RIS is set.
  $14 constant DCMI_DCMI_ICR            \ The DCMI_ICR register is write-only.
  $18 constant DCMI_DCMI_ESCR           \ DCMI embedded synchronization code register
  $1C constant DCMI_DCMI_ESUR           \ DCMI embedded synchronization unmask register
  $20 constant DCMI_DCMI_CWSTRT         \ DCMI crop window start
  $24 constant DCMI_DCMI_CWSIZE         \ DCMI crop window size
  $28 constant DCMI_DCMI_DR             \ DCMI data register

: DCMI_DEF ; [then]
