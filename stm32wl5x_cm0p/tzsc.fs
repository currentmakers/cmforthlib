\
\ @file tzsc.fs
\ @brief Global TrustZone Controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TZSC_DEF

  [ifdef] TZSC_TZSC_CR_DEF
    \
    \ @brief TZSC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TZSC_LCK                       \ [0x00] LCK
  [then]


  [ifdef] TZSC_TZSC_SECCFGR1_DEF
    \
    \ @brief TZSC security configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $02 constant TZSC_AESSEC                    \ [0x02] AESSEC
    $03 constant TZSC_RNGSEC                    \ [0x03] RNGSEC
    $0d constant TZSC_PKASEC                    \ [0x0d] PKASEC
  [then]


  [ifdef] TZSC_TZSC_PRIVCFGR1_DEF
    \
    \ @brief TZSC privilege configuration register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $02 constant TZSC_AESPRIV                   \ [0x02] AESPRIV
    $03 constant TZSC_RNGPRIV                   \ [0x03] RNGPRIV
    $04 constant TZSC_SUBGHZSPIPRIV             \ [0x04] SUBGHZSPIPRIV
    $0d constant TZSC_PKAPRIV                   \ [0x0d] PKAPRIV
  [then]


  [ifdef] TZSC_TZSC_MPCWM1_UPWMR_DEF
    \
    \ @brief Unprivileged Water Mark 1 register
    \ Address offset: 0x130
    \ Reset value: 0x0FFF0000
    \
    $10 constant TZSC_LGTH                      \ [0x10 : 12] LGTH
  [then]


  [ifdef] TZSC_TZSC_MPCWM1_UPWWMR_DEF
    \
    \ @brief Unprivileged Writable Water Mark 1 register
    \ Address offset: 0x134
    \ Reset value: 0x0FFF0000
    \
    $10 constant TZSC_LGTH                      \ [0x10 : 12] Define the length of Flash Unprivileged Writable area, in 2
  [then]


  [ifdef] TZSC_TZSC_MPCWM2_UPWMR_DEF
    \
    \ @brief Unprivileged Water Mark 2 register
    \ Address offset: 0x138
    \ Reset value: 0x0FFF0000
    \
    $10 constant TZSC_LGTH                      \ [0x10 : 12] LGTH
  [then]


  [ifdef] TZSC_TZSC_MPCWM3_UPWMR_DEF
    \
    \ @brief Unprivileged Water Mark 3 register
    \ Address offset: 0x140
    \ Reset value: 0x0FFF0000
    \
    $10 constant TZSC_LGTH                      \ [0x10 : 12] LGTH
  [then]

  \
  \ @brief Global TrustZone Controller
  \
  $00 constant TZSC_TZSC_CR             \ TZSC control register
  $10 constant TZSC_TZSC_SECCFGR1       \ TZSC security configuration register
  $20 constant TZSC_TZSC_PRIVCFGR1      \ TZSC privilege configuration register 1
  $130 constant TZSC_TZSC_MPCWM1_UPWMR  \ Unprivileged Water Mark 1 register
  $134 constant TZSC_TZSC_MPCWM1_UPWWMR \ Unprivileged Writable Water Mark 1 register
  $138 constant TZSC_TZSC_MPCWM2_UPWMR  \ Unprivileged Water Mark 2 register
  $140 constant TZSC_TZSC_MPCWM3_UPWMR  \ Unprivileged Water Mark 3 register

: TZSC_DEF ; [then]
