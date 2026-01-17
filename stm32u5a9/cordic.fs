\
\ @file cordic.fs
\ @brief CORDIC Co-processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CORDIC_DEF

  [ifdef] CORDIC_CSR_DEF
    \
    \ @brief CORDIC Control Status register
    \ Address offset: 0x00
    \ Reset value: 0x00000050
    \
    $00 constant CORDIC_FUNC                    \ [0x00 : 4] Function
    $04 constant CORDIC_PRECISION               \ [0x04 : 4] Precision required (number of iterations)
    $08 constant CORDIC_SCALE                   \ [0x08 : 3] Scaling factor
    $10 constant CORDIC_IEN                     \ [0x10] Enable interrupt
    $11 constant CORDIC_DMAREN                  \ [0x11] Enable DMA read channel
    $12 constant CORDIC_DMAWEN                  \ [0x12] Enable DMA write channel
    $13 constant CORDIC_NRES                    \ [0x13] Number of results in the CORDIC_RDATA register
    $14 constant CORDIC_NARGS                   \ [0x14] Number of arguments expected by the CORDIC_WDATA register
    $15 constant CORDIC_RESSIZE                 \ [0x15] Width of output data
    $16 constant CORDIC_ARGSIZE                 \ [0x16] Width of input data
    $1f constant CORDIC_RRDY                    \ [0x1f] Result ready flag
  [then]


  [ifdef] CORDIC_WDATA_DEF
    \
    \ @brief FMAC Write Data register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CORDIC_ARG                     \ [0x00 : 32] Function input arguments
  [then]


  [ifdef] CORDIC_RDATA_DEF
    \
    \ @brief FMAC Read Data register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CORDIC_RES                     \ [0x00 : 32] Function result
  [then]

  \
  \ @brief CORDIC Co-processor
  \
  $00 constant CORDIC_CSR               \ CORDIC Control Status register
  $04 constant CORDIC_WDATA             \ FMAC Write Data register
  $08 constant CORDIC_RDATA             \ FMAC Read Data register

: CORDIC_DEF ; [then]
