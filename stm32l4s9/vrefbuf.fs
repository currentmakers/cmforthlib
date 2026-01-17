\
\ @file vrefbuf.fs
\ @brief Voltage reference buffer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] VREFBUF_DEF

  [ifdef] VREFBUF_CSR_DEF
    \
    \ @brief VREF control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000002
    \
    $00 constant VREFBUF_ENVR                   \ [0x00] Voltage reference buffer enable
    $01 constant VREFBUF_HIZ                    \ [0x01] High impedance mode
    $02 constant VREFBUF_VRS                    \ [0x02] Voltage reference scale
    $03 constant VREFBUF_VRR                    \ [0x03] Voltage reference buffer ready
  [then]


  [ifdef] VREFBUF_CCR_DEF
    \
    \ @brief calibration control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant VREFBUF_TRIM                   \ [0x00 : 6] Trimming code
  [then]

  \
  \ @brief Voltage reference buffer
  \
  $00 constant VREFBUF_CSR              \ VREF control and status register
  $04 constant VREFBUF_CCR              \ calibration control register

: VREFBUF_DEF ; [then]
