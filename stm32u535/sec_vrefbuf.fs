\
\ @file sec_vrefbuf.fs
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

$00000001 constant SEC_VREFBUF_VREFBUF_CSR_ENVR                     \ ENVR
$00000002 constant SEC_VREFBUF_VREFBUF_CSR_HIZ                      \ HIZ
$00000008 constant SEC_VREFBUF_VREFBUF_CSR_VRR                      \ VRR
$00000070 constant SEC_VREFBUF_VREFBUF_CSR_VRS                      \ VRS


\
\ @brief VREFBUF calibration control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000003f constant SEC_VREFBUF_VREFBUF_CCR_TRIM                     \ TRIM


\
\ @brief Voltage reference buffer
\
$56007400 constant SEC_VREFBUF_VREFBUF_CSR  \ offset: 0x00 : VREFBUF control and status register
$56007404 constant SEC_VREFBUF_VREFBUF_CCR  \ offset: 0x04 : VREFBUF calibration control register

