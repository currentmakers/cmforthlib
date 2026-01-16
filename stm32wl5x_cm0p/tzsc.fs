\
\ @file tzsc.fs
\ @brief Global TrustZone Controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TZSC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TZSC_TZSC_CR_LCK                                 \ LCK


\
\ @brief TZSC security configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000004 constant TZSC_TZSC_SECCFGR1_AESSEC                        \ AESSEC
$00000008 constant TZSC_TZSC_SECCFGR1_RNGSEC                        \ RNGSEC
$00002000 constant TZSC_TZSC_SECCFGR1_PKASEC                        \ PKASEC


\
\ @brief TZSC privilege configuration register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000004 constant TZSC_TZSC_PRIVCFGR1_AESPRIV                      \ AESPRIV
$00000008 constant TZSC_TZSC_PRIVCFGR1_RNGPRIV                      \ RNGPRIV
$00000010 constant TZSC_TZSC_PRIVCFGR1_SUBGHZSPIPRIV                \ SUBGHZSPIPRIV
$00002000 constant TZSC_TZSC_PRIVCFGR1_PKAPRIV                      \ PKAPRIV


\
\ @brief Unprivileged Water Mark 1 register
\ Address offset: 0x130
\ Reset value: 0x0FFF0000
\

$0fff0000 constant TZSC_TZSC_MPCWM1_UPWMR_LGTH                      \ LGTH


\
\ @brief Unprivileged Writable Water Mark 1 register
\ Address offset: 0x134
\ Reset value: 0x0FFF0000
\

$0fff0000 constant TZSC_TZSC_MPCWM1_UPWWMR_LGTH                     \ Define the length of Flash Unprivileged Writable area, in 2


\
\ @brief Unprivileged Water Mark 2 register
\ Address offset: 0x138
\ Reset value: 0x0FFF0000
\

$0fff0000 constant TZSC_TZSC_MPCWM2_UPWMR_LGTH                      \ LGTH


\
\ @brief Unprivileged Water Mark 3 register
\ Address offset: 0x140
\ Reset value: 0x0FFF0000
\

$0fff0000 constant TZSC_TZSC_MPCWM3_UPWMR_LGTH                      \ LGTH


\
\ @brief Global TrustZone Controller
\
$58004400 constant TZSC_TZSC_CR   \ offset: 0x00 : TZSC control register
$58004410 constant TZSC_TZSC_SECCFGR1  \ offset: 0x10 : TZSC security configuration register
$58004420 constant TZSC_TZSC_PRIVCFGR1  \ offset: 0x20 : TZSC privilege configuration register 1
$58004530 constant TZSC_TZSC_MPCWM1_UPWMR  \ offset: 0x130 : Unprivileged Water Mark 1 register
$58004534 constant TZSC_TZSC_MPCWM1_UPWWMR  \ offset: 0x134 : Unprivileged Writable Water Mark 1 register
$58004538 constant TZSC_TZSC_MPCWM2_UPWMR  \ offset: 0x138 : Unprivileged Water Mark 2 register
$58004540 constant TZSC_TZSC_MPCWM3_UPWMR  \ offset: 0x140 : Unprivileged Water Mark 3 register

