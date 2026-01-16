\
\ @file aes.fs
\ @brief Advanced encryption standard hardware       accelerator
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

$00000001 constant AES_CR_EN                                        \ AES enable
$00000006 constant AES_CR_DATATYPE                                  \ Data type selection (for data in and data out to/from the cryptographic block)
$00000018 constant AES_CR_MODE                                      \ AES operating mode
$00000060 constant AES_CR_CHMOD                                     \ AES chaining mode
$00000080 constant AES_CR_CCFC                                      \ Computation Complete Flag Clear
$00000100 constant AES_CR_ERRC                                      \ Error clear
$00000200 constant AES_CR_CCFIE                                     \ CCF flag interrupt enable
$00000400 constant AES_CR_ERRIE                                     \ Error interrupt enable
$00000800 constant AES_CR_DMAINEN                                   \ Enable DMA management of data input phase
$00001000 constant AES_CR_DMAOUTEN                                  \ Enable DMA management of data output phase
$00006000 constant AES_CR_GCMPH                                     \ GCMPH
$00010000 constant AES_CR_CHMOD_2                                   \ CHMOD_2
$00040000 constant AES_CR_KEYSIZE                                   \ KEYSIZE
$00f00000 constant AES_CR_NPBLB                                     \ NPBLB


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant AES_SR_CCF                                       \ Computation complete flag
$00000002 constant AES_SR_RDERR                                     \ Read error flag
$00000004 constant AES_SR_WRERR                                     \ Write error flag
$00000008 constant AES_SR_BUSY                                      \ BUSY


\
\ @brief data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant AES_DINR_AES_DINR                                \ Data Input Register


\
\ @brief data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant AES_DOUTR_AES_DOUTR                              \ Data output register


\
\ @brief key register 0
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR0_AES_KEYR0                              \ Data Output Register (LSB key [31:0])


\
\ @brief key register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR1_AES_KEYR1                              \ AES key register (key [63:32])


\
\ @brief key register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR2_AES_KEYR2                              \ AES key register (key [95:64])


\
\ @brief key register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR3_AES_KEYR3                              \ AES key register (MSB key [127:96])


\
\ @brief initialization vector register 0
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR0_AES_IVR0                                \ initialization vector register (LSB IVR [31:0])


\
\ @brief initialization vector register 1
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR1_AES_IVR1                                \ Initialization Vector Register (IVR [63:32])


\
\ @brief initialization vector register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR2_AES_IVR2                                \ Initialization Vector Register (IVR [95:64])


\
\ @brief initialization vector register 3
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR3_AES_IVR3                                \ Initialization Vector Register (MSB IVR [127:96])


\
\ @brief key register 4
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR4_KEY                                    \ AES key


\
\ @brief key register 5
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR5_KEY                                    \ AES key


\
\ @brief key register 6
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR6_KEY                                    \ AES key


\
\ @brief key register 7
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR7_KEY                                    \ AES key


\
\ @brief suspend registers
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP0R_SUSP                                  \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP1R_SUSP                                  \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP2R_SUSP                                  \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP3R_SUSP                                  \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP4R_SUSP                                  \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP5R_SUSP                                  \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP6R_SUSP                                  \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP7R_SUSP                                  \ AES suspend


\
\ @brief Advanced encryption standard hardware accelerator
\
$50060000 constant AES_CR         \ offset: 0x00 : control register
$50060004 constant AES_SR         \ offset: 0x04 : status register
$50060008 constant AES_DINR       \ offset: 0x08 : data input register
$5006000c constant AES_DOUTR      \ offset: 0x0C : data output register
$50060010 constant AES_KEYR0      \ offset: 0x10 : key register 0
$50060014 constant AES_KEYR1      \ offset: 0x14 : key register 1
$50060018 constant AES_KEYR2      \ offset: 0x18 : key register 2
$5006001c constant AES_KEYR3      \ offset: 0x1C : key register 3
$50060020 constant AES_IVR0       \ offset: 0x20 : initialization vector register 0
$50060024 constant AES_IVR1       \ offset: 0x24 : initialization vector register 1
$50060028 constant AES_IVR2       \ offset: 0x28 : initialization vector register 2
$5006002c constant AES_IVR3       \ offset: 0x2C : initialization vector register 3
$50060030 constant AES_KEYR4      \ offset: 0x30 : key register 4
$50060034 constant AES_KEYR5      \ offset: 0x34 : key register 5
$50060038 constant AES_KEYR6      \ offset: 0x38 : key register 6
$5006003c constant AES_KEYR7      \ offset: 0x3C : key register 7
$50060040 constant AES_SUSP0R     \ offset: 0x40 : suspend registers
$50060044 constant AES_SUSP1R     \ offset: 0x44 : suspend registers
$50060048 constant AES_SUSP2R     \ offset: 0x48 : suspend registers
$5006004c constant AES_SUSP3R     \ offset: 0x4C : suspend registers
$50060050 constant AES_SUSP4R     \ offset: 0x50 : suspend registers
$50060054 constant AES_SUSP5R     \ offset: 0x54 : suspend registers
$50060058 constant AES_SUSP6R     \ offset: 0x58 : suspend registers
$5006005c constant AES_SUSP7R     \ offset: 0x5C : suspend registers

