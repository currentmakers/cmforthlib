\
\ @file vrefbuf.fs
\ @brief Voltage reference buffer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] VREFBUF_DEF

  [ifdef] VREFBUF_VREFBUF_CSR_DEF
    \
    \ @brief VREF_BUF Control and Status Register
    \ Address offset: 0x00
    \ Reset value: 0x00000002
    \
    $00 constant VREFBUF_ENVR                   \ [0x00] Enable Voltage Reference
    $01 constant VREFBUF_HIZ                    \ [0x01] High impedence mode for the VREF_BUF
    $03 constant VREFBUF_VRR                    \ [0x03] Voltage reference buffer ready
    $04 constant VREFBUF_VRS                    \ [0x04 : 2] Voltage reference scale
  [then]


  [ifdef] VREFBUF_VREFBUF_CCR_DEF
    \
    \ @brief VREF_BUF Calibration Control Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant VREFBUF_TRIM                   \ [0x00 : 6] Trimming code
  [then]

  \
  \ @brief Voltage reference buffer
  \
  $00 constant VREFBUF_VREFBUF_CSR      \ VREF_BUF Control and Status Register
  $04 constant VREFBUF_VREFBUF_CCR      \ VREF_BUF Calibration Control Register

: VREFBUF_DEF ; [then]
