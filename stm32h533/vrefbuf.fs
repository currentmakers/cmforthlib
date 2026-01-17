\
\ @file vrefbuf.fs
\ @brief VREFBUF address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] VREFBUF_DEF

  [ifdef] VREFBUF_VREFBUF_CSR_DEF
    \
    \ @brief VREFBUF control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000002
    \
    $00 constant VREFBUF_ENVR                   \ [0x00] Voltage reference buffer mode enable
    $01 constant VREFBUF_HIZ                    \ [0x01] High impedance mode
    $03 constant VREFBUF_VRR                    \ [0x03] Voltage reference buffer ready
    $04 constant VREFBUF_VRS                    \ [0x04 : 3] Voltage reference scale
  [then]


  [ifdef] VREFBUF_VREFBUF_CCR_DEF
    \
    \ @brief VREFBUF calibration control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant VREFBUF_TRIM                   \ [0x00 : 6] Trimming code
  [then]

  \
  \ @brief VREFBUF address block description
  \
  $00 constant VREFBUF_VREFBUF_CSR      \ VREFBUF control and status register
  $04 constant VREFBUF_VREFBUF_CCR      \ VREFBUF calibration control register

: VREFBUF_DEF ; [then]
