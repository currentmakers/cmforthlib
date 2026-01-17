\
\ @file ramecc3.fs
\ @brief ECC controller is associated to each RAM area
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RAMECC3_DEF

  [ifdef] RAMECC3_IER_DEF
    \
    \ @brief RAMECC interrupt enable register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC3_GIE                    \ [0x00] Global interrupt enable
    $01 constant RAMECC3_GECCSEIE_              \ [0x01] Global ECC single error interrupt enable
    $02 constant RAMECC3_GECCDEIE               \ [0x02] Global ECC double error interrupt enable
    $03 constant RAMECC3_GECCDEBWIE             \ [0x03] Global ECC double error on byte write (BW) interrupt enable
  [then]


  [ifdef] RAMECC3_M1CR_DEF
    \
    \ @brief RAMECC monitor x configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $02 constant RAMECC3_ECCSEIE                \ [0x02] ECC single error interrupt enable
    $03 constant RAMECC3_ECCDEIE                \ [0x03] ECC double error interrupt enable
    $04 constant RAMECC3_ECCDEBWIE              \ [0x04] ECC double error on byte write (BW) interrupt enable
    $05 constant RAMECC3_ECCELEN                \ [0x05] ECC error latching enable
  [then]


  [ifdef] RAMECC3_M1SR_DEF
    \
    \ @brief RAMECC monitor x status register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC3_SEDCF                  \ [0x00] ECC single error detected and corrected flag
    $01 constant RAMECC3_DEDF                   \ [0x01] ECC double error detected flag
    $02 constant RAMECC3_DEBWDF                 \ [0x02] ECC double error on byte write (BW) detected flag
  [then]


  [ifdef] RAMECC3_M1FAR_DEF
    \
    \ @brief RAMECC monitor x failing address register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC3_FADD                   \ [0x00 : 32] ECC error failing address
  [then]


  [ifdef] RAMECC3_M1FDRL_DEF
    \
    \ @brief RAMECC monitor x failing data low register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC3_FDATAL                 \ [0x00 : 32] Failing data low
  [then]


  [ifdef] RAMECC3_M1FDRH_DEF
    \
    \ @brief RAMECC monitor x failing data high register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC3_FDATAH                 \ [0x00 : 32] Failing data high (64-bit memory)
  [then]


  [ifdef] RAMECC3_M1FECR_DEF
    \
    \ @brief RAMECC monitor x failing ECC error code register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC3_FEC                    \ [0x00 : 32] Failing error code
  [then]


  [ifdef] RAMECC3_M2CR_DEF
    \
    \ @brief RAMECC monitor x configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $02 constant RAMECC3_ECCSEIE                \ [0x02] ECC single error interrupt enable
    $03 constant RAMECC3_ECCDEIE                \ [0x03] ECC double error interrupt enable
    $04 constant RAMECC3_ECCDEBWIE              \ [0x04] ECC double error on byte write (BW) interrupt enable
    $05 constant RAMECC3_ECCELEN                \ [0x05] ECC error latching enable
  [then]


  [ifdef] RAMECC3_M2SR_DEF
    \
    \ @brief RAMECC monitor x status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC3_SEDCF                  \ [0x00] ECC single error detected and corrected flag
    $01 constant RAMECC3_DEDF                   \ [0x01] ECC double error detected flag
    $02 constant RAMECC3_DEBWDF                 \ [0x02] ECC double error on byte write (BW) detected flag
  [then]


  [ifdef] RAMECC3_M2FAR_DEF
    \
    \ @brief RAMECC monitor x failing address register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC3_FADD                   \ [0x00 : 32] ECC error failing address
  [then]


  [ifdef] RAMECC3_M2FDRL_DEF
    \
    \ @brief RAMECC monitor x failing data low register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC3_FDATAL                 \ [0x00 : 32] Failing data low
  [then]


  [ifdef] RAMECC3_M2FDRH_DEF
    \
    \ @brief RAMECC monitor x failing data high register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC3_FDATAH                 \ [0x00 : 32] Failing data high (64-bit memory)
  [then]


  [ifdef] RAMECC3_M2FECR_DEF
    \
    \ @brief RAMECC monitor x failing ECC error code register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC3_FEC                    \ [0x00 : 32] Failing error code
  [then]

  \
  \ @brief ECC controller is associated to each RAM area
  \
  $00 constant RAMECC3_IER              \ RAMECC interrupt enable register
  $20 constant RAMECC3_M1CR             \ RAMECC monitor x configuration register
  $24 constant RAMECC3_M1SR             \ RAMECC monitor x status register
  $28 constant RAMECC3_M1FAR            \ RAMECC monitor x failing address register
  $2C constant RAMECC3_M1FDRL           \ RAMECC monitor x failing data low register
  $30 constant RAMECC3_M1FDRH           \ RAMECC monitor x failing data high register
  $34 constant RAMECC3_M1FECR           \ RAMECC monitor x failing ECC error code register
  $40 constant RAMECC3_M2CR             \ RAMECC monitor x configuration register
  $44 constant RAMECC3_M2SR             \ RAMECC monitor x status register
  $48 constant RAMECC3_M2FAR            \ RAMECC monitor x failing address register
  $4C constant RAMECC3_M2FDRL           \ RAMECC monitor x failing data low register
  $50 constant RAMECC3_M2FDRH           \ RAMECC monitor x failing data high register
  $58 constant RAMECC3_M2FECR           \ RAMECC monitor x failing ECC error code register

: RAMECC3_DEF ; [then]
