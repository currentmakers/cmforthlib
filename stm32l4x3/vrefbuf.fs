\
\ @file vrefbuf.fs
\ @brief Voltage reference buffer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief VREF control and status register
\ Address offset: 0x00
\ Reset value: 0x00000002
\

$00000001 constant VREFBUF_CSR_ENVR                                 \ Voltage reference buffer enable
$00000002 constant VREFBUF_CSR_HIZ                                  \ High impedance mode
$00000004 constant VREFBUF_CSR_VRS                                  \ Voltage reference scale
$00000008 constant VREFBUF_CSR_VRR                                  \ Voltage reference buffer ready


\
\ @brief calibration control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000003f constant VREFBUF_CCR_TRIM                                 \ Trimming code


\
\ @brief Voltage reference buffer
\
$40010030 constant VREFBUF_CSR    \ offset: 0x00 : VREF control and status register
$40010034 constant VREFBUF_CCR    \ offset: 0x04 : calibration control register

