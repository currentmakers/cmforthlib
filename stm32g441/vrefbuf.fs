\
\ @file vrefbuf.fs
\ @brief Voltage reference buffer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief VREF_BUF Control and Status Register
\ Address offset: 0x00
\ Reset value: 0x00000002
\

$00000001 constant VREFBUF_VREFBUF_CSR_ENVR                         \ Enable Voltage Reference
$00000002 constant VREFBUF_VREFBUF_CSR_HIZ                          \ High impedence mode for the VREF_BUF
$00000008 constant VREFBUF_VREFBUF_CSR_VRR                          \ Voltage reference buffer ready
$00000030 constant VREFBUF_VREFBUF_CSR_VRS                          \ Voltage reference scale


\
\ @brief VREF_BUF Calibration Control Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000003f constant VREFBUF_VREFBUF_CCR_TRIM                         \ Trimming code


\
\ @brief Voltage reference buffer
\
$40010030 constant VREFBUF_VREFBUF_CSR  \ offset: 0x00 : VREF_BUF Control and Status Register
$40010034 constant VREFBUF_VREFBUF_CCR  \ offset: 0x04 : VREF_BUF Calibration Control Register

