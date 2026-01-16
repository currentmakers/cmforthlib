\
\ @file ramecc.fs
\ @brief ECC controller is associated to each RAM       area
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RAMECC interrupt enable register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant RAMECC_IER_GIE                                   \ Global interrupt enable
$00000002 constant RAMECC_IER_GECCSEIE_                             \ Global ECC single error interrupt enable
$00000004 constant RAMECC_IER_GECCDEIE                              \ Global ECC double error interrupt enable
$00000008 constant RAMECC_IER_GECCDEBWIE                            \ Global ECC double error on byte write (BW) interrupt enable


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000004 constant RAMECC_M1CR_ECCSEIE                              \ ECC single error interrupt enable
$00000008 constant RAMECC_M1CR_ECCDEIE                              \ ECC double error interrupt enable
$00000010 constant RAMECC_M1CR_ECCDEBWIE                            \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC_M1CR_ECCELEN                              \ ECC error latching enable


\
\ @brief RAMECC monitor x status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000004 constant RAMECC_M1SR_ECCSEIE                              \ ECC single error interrupt enable
$00000008 constant RAMECC_M1SR_ECCDEIE                              \ ECC double error interrupt enable
$00000010 constant RAMECC_M1SR_ECCDEBWIE                            \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC_M1SR_ECCELEN                              \ ECC error latching enable


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000004 constant RAMECC_M1FAR_ECCSEIE                             \ ECC single error interrupt enable
$00000008 constant RAMECC_M1FAR_ECCDEIE                             \ ECC double error interrupt enable
$00000010 constant RAMECC_M1FAR_ECCDEBWIE                           \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC_M1FAR_ECCELEN                             \ ECC error latching enable


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000004 constant RAMECC_M1FDRL_ECCSEIE                            \ ECC single error interrupt enable
$00000008 constant RAMECC_M1FDRL_ECCDEIE                            \ ECC double error interrupt enable
$00000010 constant RAMECC_M1FDRL_ECCDEBWIE                          \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC_M1FDRL_ECCELEN                            \ ECC error latching enable


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000004 constant RAMECC_M1FDRH_ECCSEIE                            \ ECC single error interrupt enable
$00000008 constant RAMECC_M1FDRH_ECCDEIE                            \ ECC double error interrupt enable
$00000010 constant RAMECC_M1FDRH_ECCDEBWIE                          \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC_M1FDRH_ECCELEN                            \ ECC error latching enable


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant RAMECC_M1FECR_SEDCF                              \ ECC single error detected and corrected flag
$00000002 constant RAMECC_M1FECR_DEDF                               \ ECC double error detected flag
$00000004 constant RAMECC_M1FECR_DEBWDF                             \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RAMECC_M2CR_SEDCF                                \ ECC single error detected and corrected flag
$00000002 constant RAMECC_M2CR_DEDF                                 \ ECC double error detected flag
$00000004 constant RAMECC_M2CR_DEBWDF                               \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RAMECC_M2SR_SEDCF                                \ ECC single error detected and corrected flag
$00000002 constant RAMECC_M2SR_DEDF                                 \ ECC double error detected flag
$00000004 constant RAMECC_M2SR_DEBWDF                               \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant RAMECC_M2FAR_SEDCF                               \ ECC single error detected and corrected flag
$00000002 constant RAMECC_M2FAR_DEDF                                \ ECC double error detected flag
$00000004 constant RAMECC_M2FAR_DEBWDF                              \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant RAMECC_M2FDRL_SEDCF                              \ ECC single error detected and corrected flag
$00000002 constant RAMECC_M2FDRL_DEDF                               \ ECC double error detected flag
$00000004 constant RAMECC_M2FDRL_DEBWDF                             \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M2FDRH_FADD                               \ ECC error failing address


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M2FECR_FADD                               \ ECC error failing address


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M3CR_FADD                                 \ ECC error failing address


\
\ @brief RAMECC monitor x status register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M3SR_FADD                                 \ ECC error failing address


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M3FAR_FADD                                \ ECC error failing address


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M3FDRL_FDATAL                             \ Failing data low


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M3FDRH_FDATAL                             \ Failing data low


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M3FECR_FDATAL                             \ Failing data low


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M4CR_FDATAL                               \ Failing data low


\
\ @brief RAMECC monitor x status register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M4SR_FDATAL                               \ Failing data low


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M4FAR_FDATAH                              \ Failing data high (64-bit memory)


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M4FDRL_FDATAH                             \ Failing data high (64-bit memory)


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M4FDRH_FDATAH                             \ Failing data high (64-bit memory)


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M4FECR_FDATAH                             \ Failing data high (64-bit memory)


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M5CR_FEC                                  \ Failing error code


\
\ @brief RAMECC monitor x status register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M5SR_FEC                                  \ Failing error code


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M5FAR_FEC                                 \ Failing error code


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M5FDRL_FEC                                \ Failing error code


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M5FDRH_FEC                                \ Failing error code


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant RAMECC_M5FECR_FEC                                \ Failing error code


\
\ @brief ECC controller is associated to each RAM area
\
$52009000 constant RAMECC_IER     \ offset: 0x00 : RAMECC interrupt enable register
$52009020 constant RAMECC_M1CR    \ offset: 0x20 : RAMECC monitor x configuration register
$52009024 constant RAMECC_M1SR    \ offset: 0x24 : RAMECC monitor x status register
$52009028 constant RAMECC_M1FAR   \ offset: 0x28 : RAMECC monitor x failing address register
$5200902c constant RAMECC_M1FDRL  \ offset: 0x2C : RAMECC monitor x failing data low register
$52009030 constant RAMECC_M1FDRH  \ offset: 0x30 : RAMECC monitor x failing data high register
$52009034 constant RAMECC_M1FECR  \ offset: 0x34 : RAMECC monitor x failing ECC error code register
$52009040 constant RAMECC_M2CR    \ offset: 0x40 : RAMECC monitor x configuration register
$52009044 constant RAMECC_M2SR    \ offset: 0x44 : RAMECC monitor x status register
$52009048 constant RAMECC_M2FAR   \ offset: 0x48 : RAMECC monitor x failing address register
$5200904c constant RAMECC_M2FDRL  \ offset: 0x4C : RAMECC monitor x failing data low register
$52009050 constant RAMECC_M2FDRH  \ offset: 0x50 : RAMECC monitor x failing data high register
$52009058 constant RAMECC_M2FECR  \ offset: 0x58 : RAMECC monitor x failing ECC error code register
$52009060 constant RAMECC_M3CR    \ offset: 0x60 : RAMECC monitor x configuration register
$52009064 constant RAMECC_M3SR    \ offset: 0x64 : RAMECC monitor x status register
$52009068 constant RAMECC_M3FAR   \ offset: 0x68 : RAMECC monitor x failing address register
$5200906c constant RAMECC_M3FDRL  \ offset: 0x6C : RAMECC monitor x failing data low register
$52009070 constant RAMECC_M3FDRH  \ offset: 0x70 : RAMECC monitor x failing data high register
$5200907c constant RAMECC_M3FECR  \ offset: 0x7C : RAMECC monitor x failing ECC error code register
$52009080 constant RAMECC_M4CR    \ offset: 0x80 : RAMECC monitor x configuration register
$52009084 constant RAMECC_M4SR    \ offset: 0x84 : RAMECC monitor x status register
$52009088 constant RAMECC_M4FAR   \ offset: 0x88 : RAMECC monitor x failing address register
$5200908c constant RAMECC_M4FDRL  \ offset: 0x8C : RAMECC monitor x failing data low register
$52009090 constant RAMECC_M4FDRH  \ offset: 0x90 : RAMECC monitor x failing data high register
$52009090 constant RAMECC_M4FECR  \ offset: 0x90 : RAMECC monitor x failing ECC error code register
$520090a0 constant RAMECC_M5CR    \ offset: 0xA0 : RAMECC monitor x configuration register
$520090a4 constant RAMECC_M5SR    \ offset: 0xA4 : RAMECC monitor x status register
$520090a8 constant RAMECC_M5FAR   \ offset: 0xA8 : RAMECC monitor x failing address register
$520090ac constant RAMECC_M5FDRL  \ offset: 0xAC : RAMECC monitor x failing data low register
$520090b0 constant RAMECC_M5FDRH  \ offset: 0xB0 : RAMECC monitor x failing data high register
$520090b4 constant RAMECC_M5FECR  \ offset: 0xB4 : RAMECC monitor x failing ECC error code register

