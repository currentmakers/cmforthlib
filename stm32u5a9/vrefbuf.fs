\
\ @file vrefbuf.fs
\ @brief Voltage reference buffer
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

$00000001 constant VREFBUF_VREFBUF_CSR_ENVR                         \ ENVR
$00000002 constant VREFBUF_VREFBUF_CSR_HIZ                          \ HIZ
$00000008 constant VREFBUF_VREFBUF_CSR_VRR                          \ VRR
$00000070 constant VREFBUF_VREFBUF_CSR_VRS                          \ VRS


\
\ @brief VREFBUF calibration control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000003f constant VREFBUF_VREFBUF_CCR_TRIM                         \ TRIM


\
\ @brief Voltage reference buffer
\
$46007400 constant VREFBUF_VREFBUF_CSR  \ offset: 0x00 : VREFBUF control and status register
$46007404 constant VREFBUF_VREFBUF_CCR  \ offset: 0x04 : VREFBUF calibration control register

