\
\ @file dcmi.fs
\ @brief DCMI
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

$00000001 constant DCMI_DCMI_CR_CAPTURE                             \ CAPTURE
$00000002 constant DCMI_DCMI_CR_CM                                  \ CM
$00000004 constant DCMI_DCMI_CR_CROP                                \ CROP
$00000008 constant DCMI_DCMI_CR_JPEG                                \ JPEG
$00000010 constant DCMI_DCMI_CR_ESS                                 \ ESS
$00000020 constant DCMI_DCMI_CR_PCKPOL                              \ PCKPOL
$00000040 constant DCMI_DCMI_CR_HSPOL                               \ HSPOL
$00000080 constant DCMI_DCMI_CR_VSPOL                               \ VSPOL
$00000300 constant DCMI_DCMI_CR_FCRC                                \ FCRC
$00000c00 constant DCMI_DCMI_CR_EDM                                 \ EDM
$00004000 constant DCMI_DCMI_CR_ENABLE                              \ ENABLE
$00030000 constant DCMI_DCMI_CR_BSM                                 \ BSM
$00040000 constant DCMI_DCMI_CR_OEBS                                \ OEBS
$00080000 constant DCMI_DCMI_CR_LSM                                 \ LSM
$00100000 constant DCMI_DCMI_CR_OELS                                \ OELS


\
\ @brief DCMI status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DCMI_DCMI_SR_HSYNC                               \ HSYNC
$00000002 constant DCMI_DCMI_SR_VSYNC                               \ VSYNC
$00000004 constant DCMI_DCMI_SR_FNE                                 \ FNE


\
\ @brief DCMI_RIS gives the raw interrupt status and is accessible in read only. When read, this register returns the status of the corresponding interrupt before masking with the DCMI_IER register value.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DCMI_DCMI_RIS_FRAME_RIS                          \ FRAME_RIS
$00000002 constant DCMI_DCMI_RIS_OVR_RIS                            \ OVR_RIS
$00000004 constant DCMI_DCMI_RIS_ERR_RIS                            \ ERR_RIS
$00000008 constant DCMI_DCMI_RIS_VSYNC_RIS                          \ VSYNC_RIS
$00000010 constant DCMI_DCMI_RIS_LINE_RIS                           \ LINE_RIS


\
\ @brief The DCMI_IER register is used to enable interrupts. When one of the DCMI_IER bits is set, the corresponding interrupt is enabled. This register is accessible in both read and write.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant DCMI_DCMI_IER_FRAME_IE                           \ FRAME_IE
$00000002 constant DCMI_DCMI_IER_OVR_IE                             \ OVR_IE
$00000004 constant DCMI_DCMI_IER_ERR_IE                             \ ERR_IE
$00000008 constant DCMI_DCMI_IER_VSYNC_IE                           \ VSYNC_IE
$00000010 constant DCMI_DCMI_IER_LINE_IE                            \ LINE_IE


\
\ @brief This DCMI_MIS register is a read-only register. When read, it returns the current masked status value (depending on the value in DCMI_IER) of the corresponding interrupt. A bit in this register is set if the corresponding enable bit in DCMI_IER is set and the corresponding bit in DCMI_RIS is set.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant DCMI_DCMI_MIS_FRAME_MIS                          \ FRAME_MIS
$00000002 constant DCMI_DCMI_MIS_OVR_MIS                            \ OVR_MIS
$00000004 constant DCMI_DCMI_MIS_ERR_MIS                            \ ERR_MIS
$00000008 constant DCMI_DCMI_MIS_VSYNC_MIS                          \ VSYNC_MIS
$00000010 constant DCMI_DCMI_MIS_LINE_MIS                           \ LINE_MIS


\
\ @brief The DCMI_ICR register is write-only.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant DCMI_DCMI_ICR_FRAME_ISC                          \ FRAME_ISC
$00000002 constant DCMI_DCMI_ICR_OVR_ISC                            \ OVR_ISC
$00000004 constant DCMI_DCMI_ICR_ERR_ISC                            \ ERR_ISC
$00000008 constant DCMI_DCMI_ICR_VSYNC_ISC                          \ VSYNC_ISC
$00000010 constant DCMI_DCMI_ICR_LINE_ISC                           \ LINE_ISC


\
\ @brief DCMI embedded synchronization code register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant DCMI_DCMI_ESCR_FSC                               \ FSC
$0000ff00 constant DCMI_DCMI_ESCR_LSC                               \ LSC
$00ff0000 constant DCMI_DCMI_ESCR_LEC                               \ LEC
$ff000000 constant DCMI_DCMI_ESCR_FEC                               \ FEC


\
\ @brief DCMI embedded synchronization unmask register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant DCMI_DCMI_ESUR_FSU                               \ FSU
$0000ff00 constant DCMI_DCMI_ESUR_LSU                               \ LSU
$00ff0000 constant DCMI_DCMI_ESUR_LEU                               \ LEU
$ff000000 constant DCMI_DCMI_ESUR_FEU                               \ FEU


\
\ @brief DCMI crop window start
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00003fff constant DCMI_DCMI_CWSTRT_HOFFCNT                         \ HOFFCNT
$1fff0000 constant DCMI_DCMI_CWSTRT_VST                             \ VST


\
\ @brief DCMI crop window size
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00003fff constant DCMI_DCMI_CWSIZE_CAPCNT                          \ CAPCNT
$3fff0000 constant DCMI_DCMI_CWSIZE_VLINE                           \ VLINE


\
\ @brief DCMI data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DCMI_DCMI_DR_BYTE0                               \ Byte0
$0000ff00 constant DCMI_DCMI_DR_BYTE1                               \ Byte1
$00ff0000 constant DCMI_DCMI_DR_BYTE2                               \ Byte2
$ff000000 constant DCMI_DCMI_DR_BYTE3                               \ Byte3


\
\ @brief DCMI
\
$4c006000 constant DCMI_DCMI_CR   \ offset: 0x00 : DCMI control register
$4c006004 constant DCMI_DCMI_SR   \ offset: 0x04 : DCMI status register
$4c006008 constant DCMI_DCMI_RIS  \ offset: 0x08 : DCMI_RIS gives the raw interrupt status and is accessible in read only. When read, this register returns the status of the corresponding interrupt before masking with the DCMI_IER register value.
$4c00600c constant DCMI_DCMI_IER  \ offset: 0x0C : The DCMI_IER register is used to enable interrupts. When one of the DCMI_IER bits is set, the corresponding interrupt is enabled. This register is accessible in both read and write.
$4c006010 constant DCMI_DCMI_MIS  \ offset: 0x10 : This DCMI_MIS register is a read-only register. When read, it returns the current masked status value (depending on the value in DCMI_IER) of the corresponding interrupt. A bit in this register is set if the corresponding enable bit in DCMI_IER is set and the corresponding bit in DCMI_RIS is set.
$4c006014 constant DCMI_DCMI_ICR  \ offset: 0x14 : The DCMI_ICR register is write-only.
$4c006018 constant DCMI_DCMI_ESCR  \ offset: 0x18 : DCMI embedded synchronization code register
$4c00601c constant DCMI_DCMI_ESUR  \ offset: 0x1C : DCMI embedded synchronization unmask register
$4c006020 constant DCMI_DCMI_CWSTRT  \ offset: 0x20 : DCMI crop window start
$4c006024 constant DCMI_DCMI_CWSIZE  \ offset: 0x24 : DCMI crop window size
$4c006028 constant DCMI_DCMI_DR   \ offset: 0x28 : DCMI data register

