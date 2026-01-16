\
\ @file vrefbuf_s.fs
\ @brief VREFBUF address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief VREFBUF control and status register
\ Address offset: 0x00
\ Reset value: 0x00000002
\

$00000001 constant VREFBUF_S_VREFBUF_CSR_ENVR                       \ Voltage reference buffer mode enable
$00000002 constant VREFBUF_S_VREFBUF_CSR_HIZ                        \ High impedance mode
$00000008 constant VREFBUF_S_VREFBUF_CSR_VRR                        \ Voltage reference buffer ready
$00000070 constant VREFBUF_S_VREFBUF_CSR_VRS                        \ Voltage reference scale


\
\ @brief VREFBUF calibration control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000003f constant VREFBUF_S_VREFBUF_CCR_TRIM                       \ Trimming code


\
\ @brief VREFBUF address block description
\
$54007400 constant VREFBUF_S_VREFBUF_CSR  \ offset: 0x00 : VREFBUF control and status register
$54007404 constant VREFBUF_S_VREFBUF_CCR  \ offset: 0x04 : VREFBUF calibration control register

