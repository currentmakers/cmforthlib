\
\ @file sec_aes.fs
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

$00000001 constant SEC_AES_CR_EN                                    \ AES enable
$00000006 constant SEC_AES_CR_DATATYPE                              \ Data type selection (for data in and data out to/from the cryptographic block)
$00000018 constant SEC_AES_CR_MODE                                  \ AES operating mode
$00000060 constant SEC_AES_CR_CHMOD                                 \ AES chaining mode
$00000800 constant SEC_AES_CR_DMAINEN                               \ Enable DMA management of data input phase
$00001000 constant SEC_AES_CR_DMAOUTEN                              \ Enable DMA management of data output phase
$00006000 constant SEC_AES_CR_GCMPH                                 \ GCMPH
$00010000 constant SEC_AES_CR_CHMOD_2                               \ CHMOD_2
$00040000 constant SEC_AES_CR_KEYSIZE                               \ KEYSIZE
$00f00000 constant SEC_AES_CR_NPBLB                                 \ NPBLB
$03000000 constant SEC_AES_CR_KMOD                                  \ KMOD
$80000000 constant SEC_AES_CR_IPRST                                 \ IPRST


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_AES_SR_CCF                                   \ Computation complete flag
$00000002 constant SEC_AES_SR_RDERR                                 \ Read error flag
$00000004 constant SEC_AES_SR_WRERR                                 \ Write error flag
$00000008 constant SEC_AES_SR_BUSY                                  \ BUSY
$00000080 constant SEC_AES_SR_KEYVALID                              \ Key Valid flag


\
\ @brief data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_DINR_DIN                                 \ Input data word


\
\ @brief data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_DOUTR_DOUT                               \ Output data word


\
\ @brief key register 0
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR0_KEY                                \ Cryptographic key, bits [31:0]


\
\ @brief key register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR1_KEY                                \ Cryptographic key, bits [63:32]


\
\ @brief key register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR2_KEYR                               \ Cryptographic key, bits [95:64]


\
\ @brief key register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR3_AES_KEYR3                          \ Cryptographic key, bits [127:96]


\
\ @brief initialization vector register 0
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_IVR0_IVI                                 \ Initialization vector input, bits [31:0]


\
\ @brief initialization vector register 1
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_IVR1_IVI                                 \ Initialization vector input, bits [63:32]


\
\ @brief initialization vector register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_IVR2_IVI                                 \ Initialization vector input, bits [95:64]


\
\ @brief initialization vector register 3
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_IVR3_IVI                                 \ Initialization vector input, bits [127:96]


\
\ @brief key register 4
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR4_KEY                                \ Cryptographic key, bits [159:128]


\
\ @brief key register 5
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR5_KEY                                \ Cryptographic key, bits [191:160]


\
\ @brief key register 6
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR6_KEY                                \ Cryptographic key, bits [223:192]


\
\ @brief key register 7
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR7_KEY                                \ Cryptographic key, bits [255:224]


\
\ @brief suspend registers
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP0R_SUSP0                             \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP1R_SUSP1                             \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP2R_SUSP2                             \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP3R_SUSP3                             \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP4R_SUSP4                             \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP5R_SUSP5                             \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP6R_SUSP6                             \ AES suspend


\
\ @brief suspend registers
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP7R_SUSP7                             \ AES suspend


\
\ @brief interrupt enable register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant SEC_AES_IER_CCFIE                                \ Computation complete flag
$00000002 constant SEC_AES_IER_RWEIE                                \ Read or write error interrupt flag
$00000004 constant SEC_AES_IER_KEIE                                 \ Key error interrupt flag


\
\ @brief interrupt status register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant SEC_AES_ISR_CCF                                  \ Computation complete flag
$00000002 constant SEC_AES_ISR_RWEIF                                \ Read or write error interrupt flag
$00000004 constant SEC_AES_ISR_KEIF                                 \ Key error interrupt flag


\
\ @brief interrupt clear register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant SEC_AES_ICR_CCF                                  \ Computation complete flag clear
$00000002 constant SEC_AES_ICR_RWEIF                                \ Read or write error interrupt flag clear
$00000004 constant SEC_AES_ICR_KEIF                                 \ Key error interrupt flag clear


\
\ @brief Advanced encryption standard hardware accelerator
\
$520c0000 constant SEC_AES_CR     \ offset: 0x00 : control register
$520c0004 constant SEC_AES_SR     \ offset: 0x04 : status register
$520c0008 constant SEC_AES_DINR   \ offset: 0x08 : data input register
$520c000c constant SEC_AES_DOUTR  \ offset: 0x0C : data output register
$520c0010 constant SEC_AES_KEYR0  \ offset: 0x10 : key register 0
$520c0014 constant SEC_AES_KEYR1  \ offset: 0x14 : key register 1
$520c0018 constant SEC_AES_KEYR2  \ offset: 0x18 : key register 2
$520c001c constant SEC_AES_KEYR3  \ offset: 0x1C : key register 3
$520c0020 constant SEC_AES_IVR0   \ offset: 0x20 : initialization vector register 0
$520c0024 constant SEC_AES_IVR1   \ offset: 0x24 : initialization vector register 1
$520c0028 constant SEC_AES_IVR2   \ offset: 0x28 : initialization vector register 2
$520c002c constant SEC_AES_IVR3   \ offset: 0x2C : initialization vector register 3
$520c0030 constant SEC_AES_KEYR4  \ offset: 0x30 : key register 4
$520c0034 constant SEC_AES_KEYR5  \ offset: 0x34 : key register 5
$520c0038 constant SEC_AES_KEYR6  \ offset: 0x38 : key register 6
$520c003c constant SEC_AES_KEYR7  \ offset: 0x3C : key register 7
$520c0040 constant SEC_AES_SUSP0R  \ offset: 0x40 : suspend registers
$520c0044 constant SEC_AES_SUSP1R  \ offset: 0x44 : suspend registers
$520c0048 constant SEC_AES_SUSP2R  \ offset: 0x48 : suspend registers
$520c004c constant SEC_AES_SUSP3R  \ offset: 0x4C : suspend registers
$520c0050 constant SEC_AES_SUSP4R  \ offset: 0x50 : suspend registers
$520c0054 constant SEC_AES_SUSP5R  \ offset: 0x54 : suspend registers
$520c0058 constant SEC_AES_SUSP6R  \ offset: 0x58 : suspend registers
$520c005c constant SEC_AES_SUSP7R  \ offset: 0x5C : suspend registers
$520c0300 constant SEC_AES_IER    \ offset: 0x300 : interrupt enable register
$520c0304 constant SEC_AES_ISR    \ offset: 0x304 : interrupt status register
$520c0308 constant SEC_AES_ICR    \ offset: 0x308 : interrupt clear register

