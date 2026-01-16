\
\ @file rng1.fs
\ @brief RNG1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RNG control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000004 constant RNG1_RNG_CR_RNGEN                                \ RNGEN
$00000008 constant RNG1_RNG_CR_IE                                   \ IE
$00000020 constant RNG1_RNG_CR_CED                                  \ CED


\
\ @brief RNG status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant RNG1_RNG_SR_DRDY                                 \ DRDY
$00000002 constant RNG1_RNG_SR_CECS                                 \ CECS
$00000004 constant RNG1_RNG_SR_SECS                                 \ SECS
$00000020 constant RNG1_RNG_SR_CEIS                                 \ CEIS
$00000040 constant RNG1_RNG_SR_SEIS                                 \ SEIS


\
\ @brief The RNG_DR register is a read-only register.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant RNG1_RNG_DR_RNDATA                               \ RNDATA


\
\ @brief RNG hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000006
\


\
\ @brief RNG version register
\ Address offset: 0x3F4
\ Reset value: 0x00000021
\

$0000000f constant RNG1_RNG_VERR_MINREV                             \ MINREV
$000000f0 constant RNG1_RNG_VERR_MAJREV                             \ MAJREV


\
\ @brief RNG identification register
\ Address offset: 0x3F8
\ Reset value: 0x00170041
\

$00000000 constant RNG1_RNG_IPIDR_ID                                \ ID


\
\ @brief RNG size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant RNG1_RNG_SIDR_SID                                \ SID


\
\ @brief RNG1
\
$54003000 constant RNG1_RNG_CR    \ offset: 0x00 : RNG control register
$54003004 constant RNG1_RNG_SR    \ offset: 0x04 : RNG status register
$54003008 constant RNG1_RNG_DR    \ offset: 0x08 : The RNG_DR register is a read-only register.
$540033f0 constant RNG1_RNG_HWCFGR  \ offset: 0x3F0 : RNG hardware configuration register
$540033f4 constant RNG1_RNG_VERR  \ offset: 0x3F4 : RNG version register
$540033f8 constant RNG1_RNG_IPIDR  \ offset: 0x3F8 : RNG identification register
$540033fc constant RNG1_RNG_SIDR  \ offset: 0x3FC : RNG size ID register

