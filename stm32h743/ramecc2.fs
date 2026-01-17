\
\ @file ramecc2.fs
\ @brief ECC controller is associated to each RAM area
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RAMECC2_DEF

  [ifdef] RAMECC2_IER_DEF
    \
    \ @brief RAMECC interrupt enable register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_GIE                    \ [0x00] Global interrupt enable
    $01 constant RAMECC2_GECCSEIE_              \ [0x01] Global ECC single error interrupt enable
    $02 constant RAMECC2_GECCDEIE               \ [0x02] Global ECC double error interrupt enable
    $03 constant RAMECC2_GECCDEBWIE             \ [0x03] Global ECC double error on byte write (BW) interrupt enable
  [then]


  [ifdef] RAMECC2_M1CR_DEF
    \
    \ @brief RAMECC monitor x configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $02 constant RAMECC2_ECCSEIE                \ [0x02] ECC single error interrupt enable
    $03 constant RAMECC2_ECCDEIE                \ [0x03] ECC double error interrupt enable
    $04 constant RAMECC2_ECCDEBWIE              \ [0x04] ECC double error on byte write (BW) interrupt enable
    $05 constant RAMECC2_ECCELEN                \ [0x05] ECC error latching enable
  [then]


  [ifdef] RAMECC2_M1SR_DEF
    \
    \ @brief RAMECC monitor x status register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_SEDCF                  \ [0x00] ECC single error detected and corrected flag
    $01 constant RAMECC2_DEDF                   \ [0x01] ECC double error detected flag
    $02 constant RAMECC2_DEBWDF                 \ [0x02] ECC double error on byte write (BW) detected flag
  [then]


  [ifdef] RAMECC2_M1FAR_DEF
    \
    \ @brief RAMECC monitor x failing address register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FADD                   \ [0x00 : 32] ECC error failing address
  [then]


  [ifdef] RAMECC2_M1FDRL_DEF
    \
    \ @brief RAMECC monitor x failing data low register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FDATAL                 \ [0x00 : 32] Failing data low
  [then]


  [ifdef] RAMECC2_M1FDRH_DEF
    \
    \ @brief RAMECC monitor x failing data high register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FDATAH                 \ [0x00 : 32] Failing data high (64-bit memory)
  [then]


  [ifdef] RAMECC2_M1FECR_DEF
    \
    \ @brief RAMECC monitor x failing ECC error code register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FEC                    \ [0x00 : 32] Failing error code
  [then]


  [ifdef] RAMECC2_M2CR_DEF
    \
    \ @brief RAMECC monitor x configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $02 constant RAMECC2_ECCSEIE                \ [0x02] ECC single error interrupt enable
    $03 constant RAMECC2_ECCDEIE                \ [0x03] ECC double error interrupt enable
    $04 constant RAMECC2_ECCDEBWIE              \ [0x04] ECC double error on byte write (BW) interrupt enable
    $05 constant RAMECC2_ECCELEN                \ [0x05] ECC error latching enable
  [then]


  [ifdef] RAMECC2_M2SR_DEF
    \
    \ @brief RAMECC monitor x status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_SEDCF                  \ [0x00] ECC single error detected and corrected flag
    $01 constant RAMECC2_DEDF                   \ [0x01] ECC double error detected flag
    $02 constant RAMECC2_DEBWDF                 \ [0x02] ECC double error on byte write (BW) detected flag
  [then]


  [ifdef] RAMECC2_M2FAR_DEF
    \
    \ @brief RAMECC monitor x failing address register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FADD                   \ [0x00 : 32] ECC error failing address
  [then]


  [ifdef] RAMECC2_M2FDRL_DEF
    \
    \ @brief RAMECC monitor x failing data low register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FDATAL                 \ [0x00 : 32] Failing data low
  [then]


  [ifdef] RAMECC2_M2FDRH_DEF
    \
    \ @brief RAMECC monitor x failing data high register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FDATAH                 \ [0x00 : 32] Failing data high (64-bit memory)
  [then]


  [ifdef] RAMECC2_M2FECR_DEF
    \
    \ @brief RAMECC monitor x failing ECC error code register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FEC                    \ [0x00 : 32] Failing error code
  [then]


  [ifdef] RAMECC2_M3CR_DEF
    \
    \ @brief RAMECC monitor x configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $02 constant RAMECC2_ECCSEIE                \ [0x02] ECC single error interrupt enable
    $03 constant RAMECC2_ECCDEIE                \ [0x03] ECC double error interrupt enable
    $04 constant RAMECC2_ECCDEBWIE              \ [0x04] ECC double error on byte write (BW) interrupt enable
    $05 constant RAMECC2_ECCELEN                \ [0x05] ECC error latching enable
  [then]


  [ifdef] RAMECC2_M3SR_DEF
    \
    \ @brief RAMECC monitor x status register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_SEDCF                  \ [0x00] ECC single error detected and corrected flag
    $01 constant RAMECC2_DEDF                   \ [0x01] ECC double error detected flag
    $02 constant RAMECC2_DEBWDF                 \ [0x02] ECC double error on byte write (BW) detected flag
  [then]


  [ifdef] RAMECC2_M3FAR_DEF
    \
    \ @brief RAMECC monitor x failing address register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FADD                   \ [0x00 : 32] ECC error failing address
  [then]


  [ifdef] RAMECC2_M3FDRL_DEF
    \
    \ @brief RAMECC monitor x failing data low register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FDATAL                 \ [0x00 : 32] Failing data low
  [then]


  [ifdef] RAMECC2_M3FDRH_DEF
    \
    \ @brief RAMECC monitor x failing data high register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FDATAH                 \ [0x00 : 32] Failing data high (64-bit memory)
  [then]


  [ifdef] RAMECC2_M3FECR_DEF
    \
    \ @brief RAMECC monitor x failing ECC error code register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FEC                    \ [0x00 : 32] Failing error code
  [then]


  [ifdef] RAMECC2_M4CR_DEF
    \
    \ @brief RAMECC monitor x configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $02 constant RAMECC2_ECCSEIE                \ [0x02] ECC single error interrupt enable
    $03 constant RAMECC2_ECCDEIE                \ [0x03] ECC double error interrupt enable
    $04 constant RAMECC2_ECCDEBWIE              \ [0x04] ECC double error on byte write (BW) interrupt enable
    $05 constant RAMECC2_ECCELEN                \ [0x05] ECC error latching enable
  [then]


  [ifdef] RAMECC2_M4SR_DEF
    \
    \ @brief RAMECC monitor x status register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_SEDCF                  \ [0x00] ECC single error detected and corrected flag
    $01 constant RAMECC2_DEDF                   \ [0x01] ECC double error detected flag
    $02 constant RAMECC2_DEBWDF                 \ [0x02] ECC double error on byte write (BW) detected flag
  [then]


  [ifdef] RAMECC2_M4FAR_DEF
    \
    \ @brief RAMECC monitor x failing address register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FADD                   \ [0x00 : 32] ECC error failing address
  [then]


  [ifdef] RAMECC2_M4FDRL_DEF
    \
    \ @brief RAMECC monitor x failing data low register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FDATAL                 \ [0x00 : 32] Failing data low
  [then]


  [ifdef] RAMECC2_M4FDRH_DEF
    \
    \ @brief RAMECC monitor x failing data high register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FDATAH                 \ [0x00 : 32] Failing data high (64-bit memory)
  [then]


  [ifdef] RAMECC2_M4FECR_DEF
    \
    \ @brief RAMECC monitor x failing ECC error code register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FEC                    \ [0x00 : 32] Failing error code
  [then]


  [ifdef] RAMECC2_M5CR_DEF
    \
    \ @brief RAMECC monitor x configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $02 constant RAMECC2_ECCSEIE                \ [0x02] ECC single error interrupt enable
    $03 constant RAMECC2_ECCDEIE                \ [0x03] ECC double error interrupt enable
    $04 constant RAMECC2_ECCDEBWIE              \ [0x04] ECC double error on byte write (BW) interrupt enable
    $05 constant RAMECC2_ECCELEN                \ [0x05] ECC error latching enable
  [then]


  [ifdef] RAMECC2_M5SR_DEF
    \
    \ @brief RAMECC monitor x status register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_SEDCF                  \ [0x00] ECC single error detected and corrected flag
    $01 constant RAMECC2_DEDF                   \ [0x01] ECC double error detected flag
    $02 constant RAMECC2_DEBWDF                 \ [0x02] ECC double error on byte write (BW) detected flag
  [then]


  [ifdef] RAMECC2_M5FAR_DEF
    \
    \ @brief RAMECC monitor x failing address register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FADD                   \ [0x00 : 32] ECC error failing address
  [then]


  [ifdef] RAMECC2_M5FDRL_DEF
    \
    \ @brief RAMECC monitor x failing data low register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FDATAL                 \ [0x00 : 32] Failing data low
  [then]


  [ifdef] RAMECC2_M5FDRH_DEF
    \
    \ @brief RAMECC monitor x failing data high register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FEC                    \ [0x00 : 32] Failing error code
  [then]


  [ifdef] RAMECC2_M5FECR_DEF
    \
    \ @brief RAMECC monitor x failing ECC error code register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant RAMECC2_FEC                    \ [0x00 : 32] Failing error code
  [then]

  \
  \ @brief ECC controller is associated to each RAM area
  \
  $00 constant RAMECC2_IER              \ RAMECC interrupt enable register
  $20 constant RAMECC2_M1CR             \ RAMECC monitor x configuration register
  $24 constant RAMECC2_M1SR             \ RAMECC monitor x status register
  $28 constant RAMECC2_M1FAR            \ RAMECC monitor x failing address register
  $2C constant RAMECC2_M1FDRL           \ RAMECC monitor x failing data low register
  $30 constant RAMECC2_M1FDRH           \ RAMECC monitor x failing data high register
  $34 constant RAMECC2_M1FECR           \ RAMECC monitor x failing ECC error code register
  $40 constant RAMECC2_M2CR             \ RAMECC monitor x configuration register
  $44 constant RAMECC2_M2SR             \ RAMECC monitor x status register
  $48 constant RAMECC2_M2FAR            \ RAMECC monitor x failing address register
  $4C constant RAMECC2_M2FDRL           \ RAMECC monitor x failing data low register
  $50 constant RAMECC2_M2FDRH           \ RAMECC monitor x failing data high register
  $58 constant RAMECC2_M2FECR           \ RAMECC monitor x failing ECC error code register
  $60 constant RAMECC2_M3CR             \ RAMECC monitor x configuration register
  $64 constant RAMECC2_M3SR             \ RAMECC monitor x status register
  $68 constant RAMECC2_M3FAR            \ RAMECC monitor x failing address register
  $6C constant RAMECC2_M3FDRL           \ RAMECC monitor x failing data low register
  $70 constant RAMECC2_M3FDRH           \ RAMECC monitor x failing data high register
  $7C constant RAMECC2_M3FECR           \ RAMECC monitor x failing ECC error code register
  $80 constant RAMECC2_M4CR             \ RAMECC monitor x configuration register
  $84 constant RAMECC2_M4SR             \ RAMECC monitor x status register
  $88 constant RAMECC2_M4FAR            \ RAMECC monitor x failing address register
  $8C constant RAMECC2_M4FDRL           \ RAMECC monitor x failing data low register
  $90 constant RAMECC2_M4FDRH           \ RAMECC monitor x failing data high register
  $90 constant RAMECC2_M4FECR           \ RAMECC monitor x failing ECC error code register
  $A0 constant RAMECC2_M5CR             \ RAMECC monitor x configuration register
  $A4 constant RAMECC2_M5SR             \ RAMECC monitor x status register
  $A8 constant RAMECC2_M5FAR            \ RAMECC monitor x failing address register
  $AC constant RAMECC2_M5FDRL           \ RAMECC monitor x failing data low register
  $B0 constant RAMECC2_M5FDRH           \ RAMECC monitor x failing data high register
  $B4 constant RAMECC2_M5FECR           \ RAMECC monitor x failing ECC error code register

: RAMECC2_DEF ; [then]
