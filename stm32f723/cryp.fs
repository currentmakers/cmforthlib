\
\ @file cryp.fs
\ @brief Cryptographic processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant CRYP_CR_EN                                       \ AES enable
$00000006 constant CRYP_CR_DATATYPE                                 \ Data type selection (for data in and data out to/from the cryptographic block)
$00000018 constant CRYP_CR_MODE                                     \ AES operating mode
$00000060 constant CRYP_CR_CHMOD                                    \ AES chaining mode
$00000080 constant CRYP_CR_CCFC                                     \ Computation complete flag clear
$00000100 constant CRYP_CR_ERRC                                     \ Error clear
$00000200 constant CRYP_CR_CCFIE                                    \ CCF flag interrupt enable
$00000400 constant CRYP_CR_ERRIE                                    \ Error interrupt enable
$00000800 constant CRYP_CR_DMAINEN                                  \ Enable DMA management of data input phase
$00001000 constant CRYP_CR_DMAOUTEN                                 \ Enable DMA management of data output phase
$00006000 constant CRYP_CR_GCMPH                                    \ Used only for GCM, GMAC and CMAC algorithms and has no effect when other
$00040000 constant CRYP_CR_KEYSIZE                                  \ Key size selection


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant CRYP_SR_CCF                                      \ Computation complete flag
$00000002 constant CRYP_SR_RDERR                                    \ Read error flag
$00000004 constant CRYP_SR_WRERR                                    \ Write error flag
$00000008 constant CRYP_SR_BUSY                                     \ Busy flag


\
\ @brief data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant CRYP_DINR_DINR                                   \ Data input


\
\ @brief data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_DOUTR_DOUTR                                 \ Data output


\
\ @brief key register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$7fffffff constant CRYP_KEYR0_KEYR0                                 \ Data output register


\
\ @brief key register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant CRYP_KEYR1_KEYR1                                 \ Data output register


\
\ @brief key register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$7fffffff constant CRYP_KEYR2_KEYR2                                 \ Data output register


\
\ @brief key register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_KEYR3_KEYR3                                 \ Data output register


\
\ @brief initialization vector register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant CRYP_IVR0_IVR0                                   \ initialization vector register


\
\ @brief initialization vector register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant CRYP_IVR1_IVR1                                   \ Initialization vector register


\
\ @brief initialization vector register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant CRYP_IVR2_IVR2                                   \ Initialization vector register


\
\ @brief initialization vector register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_IVR3_IVR3                                   \ Initialization vector register


\
\ @brief key registers
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant CRYP_KEYR4_KEYR4                                 \ Data output register


\
\ @brief key registers
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant CRYP_KEYR5_KEYR5                                 \ Data output register


\
\ @brief key registers
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant CRYP_KEYR6_KEYR6                                 \ Data output register


\
\ @brief key registers
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_KEYR7_KEYR7                                 \ Data output register


\
\ @brief Suspend registers
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant CRYP_SUSP0R_SUSP0R                               \ AES Suspend


\
\ @brief Suspend registers
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant CRYP_SUSP1R_SUSP1R                               \ AES Suspend


\
\ @brief Suspend registers
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant CRYP_SUSP2R_SUSP2R                               \ AES Suspend


\
\ @brief Suspend registers
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_SUSP3R_SUSP3R                               \ IV127


\
\ @brief Suspend registers
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant CRYP_SUSP4R_SUSP4R                               \ AES Suspend


\
\ @brief Suspend registers
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant CRYP_SUSP5R_SUSP5R                               \ AES Suspend


\
\ @brief Suspend registers
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant CRYP_SUSP6R_SUSP6R                               \ AES Suspend


\
\ @brief Suspend registers
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_SUSP7R_SUSP7R                               \ AES Suspend


\
\ @brief Cryptographic processor
\
$50060000 constant CRYP_CR        \ offset: 0x00 : control register
$50060004 constant CRYP_SR        \ offset: 0x04 : status register
$50060008 constant CRYP_DINR      \ offset: 0x08 : data input register
$5006000c constant CRYP_DOUTR     \ offset: 0x0C : data output register
$50060010 constant CRYP_KEYR0     \ offset: 0x10 : key register
$50060014 constant CRYP_KEYR1     \ offset: 0x14 : key register
$50060018 constant CRYP_KEYR2     \ offset: 0x18 : key register
$5006001c constant CRYP_KEYR3     \ offset: 0x1C : key register
$50060020 constant CRYP_IVR0      \ offset: 0x20 : initialization vector register
$50060024 constant CRYP_IVR1      \ offset: 0x24 : initialization vector register
$50060028 constant CRYP_IVR2      \ offset: 0x28 : initialization vector register
$5006002c constant CRYP_IVR3      \ offset: 0x2C : initialization vector register
$50060030 constant CRYP_KEYR4     \ offset: 0x30 : key registers
$50060034 constant CRYP_KEYR5     \ offset: 0x34 : key registers
$50060038 constant CRYP_KEYR6     \ offset: 0x38 : key registers
$5006003c constant CRYP_KEYR7     \ offset: 0x3C : key registers
$50060040 constant CRYP_SUSP0R    \ offset: 0x40 : Suspend registers
$50060044 constant CRYP_SUSP1R    \ offset: 0x44 : Suspend registers
$50060048 constant CRYP_SUSP2R    \ offset: 0x48 : Suspend registers
$5006004c constant CRYP_SUSP3R    \ offset: 0x4C : Suspend registers
$50060050 constant CRYP_SUSP4R    \ offset: 0x50 : Suspend registers
$50060054 constant CRYP_SUSP5R    \ offset: 0x54 : Suspend registers
$50060058 constant CRYP_SUSP6R    \ offset: 0x58 : Suspend registers
$5006005c constant CRYP_SUSP7R    \ offset: 0x5C : Suspend registers

