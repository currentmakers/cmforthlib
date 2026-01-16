\
\ @file ramecc2.fs
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

$00000001 constant RAMECC2_IER_GIE                                  \ Global interrupt enable
$00000002 constant RAMECC2_IER_GECCSEIE_                            \ Global ECC single error interrupt enable
$00000004 constant RAMECC2_IER_GECCDEIE                             \ Global ECC double error interrupt enable
$00000008 constant RAMECC2_IER_GECCDEBWIE                           \ Global ECC double error on byte write (BW) interrupt enable


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000004 constant RAMECC2_M1CR_ECCSEIE                             \ ECC single error interrupt enable
$00000008 constant RAMECC2_M1CR_ECCDEIE                             \ ECC double error interrupt enable
$00000010 constant RAMECC2_M1CR_ECCDEBWIE                           \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC2_M1CR_ECCELEN                             \ ECC error latching enable


\
\ @brief RAMECC monitor x status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant RAMECC2_M1SR_SEDCF                               \ ECC single error detected and corrected flag
$00000002 constant RAMECC2_M1SR_DEDF                                \ ECC double error detected flag
$00000004 constant RAMECC2_M1SR_DEBWDF                              \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M1FAR_FADD                               \ ECC error failing address


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M1FDRL_FDATAL                            \ Failing data low


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M1FDRH_FDATAH                            \ Failing data high (64-bit memory)


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M1FECR_FEC                               \ Failing error code


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000004 constant RAMECC2_M2CR_ECCSEIE                             \ ECC single error interrupt enable
$00000008 constant RAMECC2_M2CR_ECCDEIE                             \ ECC double error interrupt enable
$00000010 constant RAMECC2_M2CR_ECCDEBWIE                           \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC2_M2CR_ECCELEN                             \ ECC error latching enable


\
\ @brief RAMECC monitor x status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RAMECC2_M2SR_SEDCF                               \ ECC single error detected and corrected flag
$00000002 constant RAMECC2_M2SR_DEDF                                \ ECC double error detected flag
$00000004 constant RAMECC2_M2SR_DEBWDF                              \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M2FAR_FADD                               \ ECC error failing address


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M2FDRL_FDATAL                            \ Failing data low


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M2FDRH_FDATAH                            \ Failing data high (64-bit memory)


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M2FECR_FEC                               \ Failing error code


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000004 constant RAMECC2_M3CR_ECCSEIE                             \ ECC single error interrupt enable
$00000008 constant RAMECC2_M3CR_ECCDEIE                             \ ECC double error interrupt enable
$00000010 constant RAMECC2_M3CR_ECCDEBWIE                           \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC2_M3CR_ECCELEN                             \ ECC error latching enable


\
\ @brief RAMECC monitor x status register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant RAMECC2_M3SR_SEDCF                               \ ECC single error detected and corrected flag
$00000002 constant RAMECC2_M3SR_DEDF                                \ ECC double error detected flag
$00000004 constant RAMECC2_M3SR_DEBWDF                              \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M3FAR_FADD                               \ ECC error failing address


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M3FDRL_FDATAL                            \ Failing data low


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M3FDRH_FDATAH                            \ Failing data high (64-bit memory)


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M3FECR_FEC                               \ Failing error code


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000004 constant RAMECC2_M4CR_ECCSEIE                             \ ECC single error interrupt enable
$00000008 constant RAMECC2_M4CR_ECCDEIE                             \ ECC double error interrupt enable
$00000010 constant RAMECC2_M4CR_ECCDEBWIE                           \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC2_M4CR_ECCELEN                             \ ECC error latching enable


\
\ @brief RAMECC monitor x status register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant RAMECC2_M4SR_SEDCF                               \ ECC single error detected and corrected flag
$00000002 constant RAMECC2_M4SR_DEDF                                \ ECC double error detected flag
$00000004 constant RAMECC2_M4SR_DEBWDF                              \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M4FAR_FADD                               \ ECC error failing address


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M4FDRL_FDATAL                            \ Failing data low


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M4FDRH_FDATAH                            \ Failing data high (64-bit memory)


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M4FECR_FEC                               \ Failing error code


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000004 constant RAMECC2_M5CR_ECCSEIE                             \ ECC single error interrupt enable
$00000008 constant RAMECC2_M5CR_ECCDEIE                             \ ECC double error interrupt enable
$00000010 constant RAMECC2_M5CR_ECCDEBWIE                           \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC2_M5CR_ECCELEN                             \ ECC error latching enable


\
\ @brief RAMECC monitor x status register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant RAMECC2_M5SR_SEDCF                               \ ECC single error detected and corrected flag
$00000002 constant RAMECC2_M5SR_DEDF                                \ ECC double error detected flag
$00000004 constant RAMECC2_M5SR_DEBWDF                              \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M5FAR_FADD                               \ ECC error failing address


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M5FDRL_FDATAL                            \ Failing data low


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M5FDRH_FEC                               \ Failing error code


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant RAMECC2_M5FECR_FEC                               \ Failing error code


\
\ @brief ECC controller is associated to each RAM area
\
$48023000 constant RAMECC2_IER    \ offset: 0x00 : RAMECC interrupt enable register
$48023020 constant RAMECC2_M1CR   \ offset: 0x20 : RAMECC monitor x configuration register
$48023024 constant RAMECC2_M1SR   \ offset: 0x24 : RAMECC monitor x status register
$48023028 constant RAMECC2_M1FAR  \ offset: 0x28 : RAMECC monitor x failing address register
$4802302c constant RAMECC2_M1FDRL  \ offset: 0x2C : RAMECC monitor x failing data low register
$48023030 constant RAMECC2_M1FDRH  \ offset: 0x30 : RAMECC monitor x failing data high register
$48023034 constant RAMECC2_M1FECR  \ offset: 0x34 : RAMECC monitor x failing ECC error code register
$48023040 constant RAMECC2_M2CR   \ offset: 0x40 : RAMECC monitor x configuration register
$48023044 constant RAMECC2_M2SR   \ offset: 0x44 : RAMECC monitor x status register
$48023048 constant RAMECC2_M2FAR  \ offset: 0x48 : RAMECC monitor x failing address register
$4802304c constant RAMECC2_M2FDRL  \ offset: 0x4C : RAMECC monitor x failing data low register
$48023050 constant RAMECC2_M2FDRH  \ offset: 0x50 : RAMECC monitor x failing data high register
$48023058 constant RAMECC2_M2FECR  \ offset: 0x58 : RAMECC monitor x failing ECC error code register
$48023060 constant RAMECC2_M3CR   \ offset: 0x60 : RAMECC monitor x configuration register
$48023064 constant RAMECC2_M3SR   \ offset: 0x64 : RAMECC monitor x status register
$48023068 constant RAMECC2_M3FAR  \ offset: 0x68 : RAMECC monitor x failing address register
$4802306c constant RAMECC2_M3FDRL  \ offset: 0x6C : RAMECC monitor x failing data low register
$48023070 constant RAMECC2_M3FDRH  \ offset: 0x70 : RAMECC monitor x failing data high register
$4802307c constant RAMECC2_M3FECR  \ offset: 0x7C : RAMECC monitor x failing ECC error code register
$48023080 constant RAMECC2_M4CR   \ offset: 0x80 : RAMECC monitor x configuration register
$48023084 constant RAMECC2_M4SR   \ offset: 0x84 : RAMECC monitor x status register
$48023088 constant RAMECC2_M4FAR  \ offset: 0x88 : RAMECC monitor x failing address register
$4802308c constant RAMECC2_M4FDRL  \ offset: 0x8C : RAMECC monitor x failing data low register
$48023090 constant RAMECC2_M4FDRH  \ offset: 0x90 : RAMECC monitor x failing data high register
$48023090 constant RAMECC2_M4FECR  \ offset: 0x90 : RAMECC monitor x failing ECC error code register
$480230a0 constant RAMECC2_M5CR   \ offset: 0xA0 : RAMECC monitor x configuration register
$480230a4 constant RAMECC2_M5SR   \ offset: 0xA4 : RAMECC monitor x status register
$480230a8 constant RAMECC2_M5FAR  \ offset: 0xA8 : RAMECC monitor x failing address register
$480230ac constant RAMECC2_M5FDRL  \ offset: 0xAC : RAMECC monitor x failing data low register
$480230b0 constant RAMECC2_M5FDRH  \ offset: 0xB0 : RAMECC monitor x failing data high register
$480230b4 constant RAMECC2_M5FECR  \ offset: 0xB4 : RAMECC monitor x failing ECC error code register

