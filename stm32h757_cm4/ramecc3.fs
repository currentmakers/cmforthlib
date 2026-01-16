\
\ @file ramecc3.fs
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

$00000001 constant RAMECC3_IER_GIE                                  \ Global interrupt enable
$00000002 constant RAMECC3_IER_GECCSEIE_                            \ Global ECC single error interrupt enable
$00000004 constant RAMECC3_IER_GECCDEIE                             \ Global ECC double error interrupt enable
$00000008 constant RAMECC3_IER_GECCDEBWIE                           \ Global ECC double error on byte write (BW) interrupt enable


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000004 constant RAMECC3_M1CR_ECCSEIE                             \ ECC single error interrupt enable
$00000008 constant RAMECC3_M1CR_ECCDEIE                             \ ECC double error interrupt enable
$00000010 constant RAMECC3_M1CR_ECCDEBWIE                           \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC3_M1CR_ECCELEN                             \ ECC error latching enable


\
\ @brief RAMECC monitor x status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant RAMECC3_M1SR_SEDCF                               \ ECC single error detected and corrected flag
$00000002 constant RAMECC3_M1SR_DEDF                                \ ECC double error detected flag
$00000004 constant RAMECC3_M1SR_DEBWDF                              \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant RAMECC3_M1FAR_FADD                               \ ECC error failing address


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant RAMECC3_M1FDRL_FDATAL                            \ Failing data low


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant RAMECC3_M1FDRH_FDATAH                            \ Failing data high (64-bit memory)


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant RAMECC3_M1FECR_FEC                               \ Failing error code


\
\ @brief RAMECC monitor x configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000004 constant RAMECC3_M2CR_ECCSEIE                             \ ECC single error interrupt enable
$00000008 constant RAMECC3_M2CR_ECCDEIE                             \ ECC double error interrupt enable
$00000010 constant RAMECC3_M2CR_ECCDEBWIE                           \ ECC double error on byte write (BW) interrupt enable
$00000020 constant RAMECC3_M2CR_ECCELEN                             \ ECC error latching enable


\
\ @brief RAMECC monitor x status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RAMECC3_M2SR_SEDCF                               \ ECC single error detected and corrected flag
$00000002 constant RAMECC3_M2SR_DEDF                                \ ECC double error detected flag
$00000004 constant RAMECC3_M2SR_DEBWDF                              \ ECC double error on byte write (BW) detected flag


\
\ @brief RAMECC monitor x failing address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant RAMECC3_M2FAR_FADD                               \ ECC error failing address


\
\ @brief RAMECC monitor x failing data low register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant RAMECC3_M2FDRL_FDATAL                            \ Failing data low


\
\ @brief RAMECC monitor x failing data high register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant RAMECC3_M2FDRH_FDATAH                            \ Failing data high (64-bit memory)


\
\ @brief RAMECC monitor x failing ECC error code register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant RAMECC3_M2FECR_FEC                               \ Failing error code


\
\ @brief ECC controller is associated to each RAM area
\
$58027000 constant RAMECC3_IER    \ offset: 0x00 : RAMECC interrupt enable register
$58027020 constant RAMECC3_M1CR   \ offset: 0x20 : RAMECC monitor x configuration register
$58027024 constant RAMECC3_M1SR   \ offset: 0x24 : RAMECC monitor x status register
$58027028 constant RAMECC3_M1FAR  \ offset: 0x28 : RAMECC monitor x failing address register
$5802702c constant RAMECC3_M1FDRL  \ offset: 0x2C : RAMECC monitor x failing data low register
$58027030 constant RAMECC3_M1FDRH  \ offset: 0x30 : RAMECC monitor x failing data high register
$58027034 constant RAMECC3_M1FECR  \ offset: 0x34 : RAMECC monitor x failing ECC error code register
$58027040 constant RAMECC3_M2CR   \ offset: 0x40 : RAMECC monitor x configuration register
$58027044 constant RAMECC3_M2SR   \ offset: 0x44 : RAMECC monitor x status register
$58027048 constant RAMECC3_M2FAR  \ offset: 0x48 : RAMECC monitor x failing address register
$5802704c constant RAMECC3_M2FDRL  \ offset: 0x4C : RAMECC monitor x failing data low register
$58027050 constant RAMECC3_M2FDRH  \ offset: 0x50 : RAMECC monitor x failing data high register
$58027058 constant RAMECC3_M2FECR  \ offset: 0x58 : RAMECC monitor x failing ECC error code register

