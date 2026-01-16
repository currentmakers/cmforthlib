\
\ @file aes.fs
\ @brief Advanced encryption standard hardware accelerator
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
$00000800 constant AES_CR_DMAINEN                                   \ Enable DMA management of data input phase
$00001000 constant AES_CR_DMAOUTEN                                  \ Enable DMA management of data output phase
$00006000 constant AES_CR_GCMPH                                     \ GCMPH
$00010000 constant AES_CR_CHMOD_2                                   \ CHMOD_2
$00040000 constant AES_CR_KEYSIZE                                   \ KEYSIZE
$00f00000 constant AES_CR_NPBLB                                     \ NPBLB
$03000000 constant AES_CR_KMOD                                      \ KMOD
$80000000 constant AES_CR_IPRST                                     \ IPRST


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant AES_SR_CCF                                       \ Computation complete flag
$00000002 constant AES_SR_RDERR                                     \ Read error flag
$00000004 constant AES_SR_WRERR                                     \ Write error flag
$00000008 constant AES_SR_BUSY                                      \ BUSY
$00000080 constant AES_SR_KEYVALID                                  \ Key Valid flag


\
\ @brief data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant AES_DINR_DIN                                     \ Input data word


\
\ @brief data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant AES_DOUTR_DOUT                                   \ Output data word


\
\ @brief key register 0
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR0_KEY                                    \ Cryptographic key, bits [31:0]


\
\ @brief key register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR1_KEY                                    \ Cryptographic key, bits [63:32]


\
\ @brief key register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR2_KEYR                                   \ Cryptographic key, bits [95:64]


\
\ @brief key register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR3_AES_KEYR3                              \ Cryptographic key, bits [127:96]


\
\ @brief initialization vector register 0
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR0_IVI                                     \ Initialization vector input, bits [31:0]


\
\ @brief initialization vector register 1
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR1_IVI                                     \ Initialization vector input, bits [63:32]


\
\ @brief initialization vector register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR2_IVI                                     \ Initialization vector input, bits [95:64]


\
\ @brief initialization vector register 3
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR3_IVI                                     \ Initialization vector input, bits [127:96]


\
\ @brief key register 4
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR4_KEY                                    \ Cryptographic key, bits [159:128]


\
\ @brief key register 5
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR5_KEY                                    \ Cryptographic key, bits [191:160]


\
\ @brief key register 6
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR6_KEY                                    \ Cryptographic key, bits [223:192]


\
\ @brief key register 7
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR7_KEY                                    \ Cryptographic key, bits [255:224]


\
\ @brief suspend registers
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP0R_SUSP0                                 \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP1R_SUSP1                                 \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP2R_SUSP2                                 \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP3R_SUSP3                                 \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP4R_SUSP4                                 \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP5R_SUSP5                                 \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP6R_SUSP6                                 \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant AES_SUSP7R_SUSP7                                 \ AES suspend


\
\ @brief interrupt enable register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant AES_IER_CCFIE                                    \ Computation complete flag
$00000002 constant AES_IER_RWEIE                                    \ Read or write error interrupt flag
$00000004 constant AES_IER_KEIE                                     \ Key error interrupt flag
$00000008 constant AES_IER_RNGEIE                                   \ Key error interrupt flag


\
\ @brief interrupt status register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant AES_ISR_CCF                                      \ Computation complete flag
$00000002 constant AES_ISR_RWEIF                                    \ Read or write error interrupt flag
$00000004 constant AES_ISR_KEIF                                     \ Key error interrupt flag
$00000008 constant AES_ISR_RNGEIF                                   \ Key error interrupt flag


\
\ @brief interrupt clear register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant AES_ICR_CCF                                      \ Computation complete flag clear
$00000002 constant AES_ICR_RWEIF                                    \ Read or write error interrupt flag clear
$00000004 constant AES_ICR_KEIF                                     \ Key error interrupt flag clear


\
\ @brief Advanced encryption standard hardware accelerator
\
$420c0000 constant AES_CR         \ offset: 0x00 : control register
$420c0004 constant AES_SR         \ offset: 0x04 : status register
$420c0008 constant AES_DINR       \ offset: 0x08 : data input register
$420c000c constant AES_DOUTR      \ offset: 0x0C : data output register
$420c0010 constant AES_KEYR0      \ offset: 0x10 : key register 0
$420c0014 constant AES_KEYR1      \ offset: 0x14 : key register 1
$420c0018 constant AES_KEYR2      \ offset: 0x18 : key register 2
$420c001c constant AES_KEYR3      \ offset: 0x1C : key register 3
$420c0020 constant AES_IVR0       \ offset: 0x20 : initialization vector register 0
$420c0024 constant AES_IVR1       \ offset: 0x24 : initialization vector register 1
$420c0028 constant AES_IVR2       \ offset: 0x28 : initialization vector register 2
$420c002c constant AES_IVR3       \ offset: 0x2C : initialization vector register 3
$420c0030 constant AES_KEYR4      \ offset: 0x30 : key register 4
$420c0034 constant AES_KEYR5      \ offset: 0x34 : key register 5
$420c0038 constant AES_KEYR6      \ offset: 0x38 : key register 6
$420c003c constant AES_KEYR7      \ offset: 0x3C : key register 7
$420c0040 constant AES_SUSP0R     \ offset: 0x40 : suspend registers
$420c0044 constant AES_SUSP1R     \ offset: 0x44 : suspend registers
$420c0048 constant AES_SUSP2R     \ offset: 0x48 : suspend registers
$420c004c constant AES_SUSP3R     \ offset: 0x4C : suspend registers
$420c0050 constant AES_SUSP4R     \ offset: 0x50 : suspend registers
$420c0054 constant AES_SUSP5R     \ offset: 0x54 : suspend registers
$420c0058 constant AES_SUSP6R     \ offset: 0x58 : suspend registers
$420c005c constant AES_SUSP7R     \ offset: 0x5C : suspend registers
$420c0300 constant AES_IER        \ offset: 0x300 : interrupt enable register
$420c0304 constant AES_ISR        \ offset: 0x304 : interrupt status register
$420c0308 constant AES_ICR        \ offset: 0x308 : interrupt clear register

