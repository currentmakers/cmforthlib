\
\ @file saes.fs
\ @brief Secure AES coprocessor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SAES control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SAES_SAES_CR_EN                                  \ Enable
$00000006 constant SAES_SAES_CR_DATATYPE                            \ Data type
$00000018 constant SAES_SAES_CR_MODE                                \ Operating mode
$00000060 constant SAES_SAES_CR_CHMOD                               \ CHMOD[1:0]: Chaining mode
$00000800 constant SAES_SAES_CR_DMAINEN                             \ DMA input enable
$00001000 constant SAES_SAES_CR_DMAOUTEN                            \ DMA output enable
$00006000 constant SAES_SAES_CR_GCMPH                               \ GCM or CCM phase selection
$00010000 constant SAES_SAES_CR_CHMOD_1                             \ CHMOD[2]
$00040000 constant SAES_SAES_CR_KEYSIZE                             \ Key size selection
$00080000 constant SAES_SAES_CR_KEYPROT                             \ Key protection
$00f00000 constant SAES_SAES_CR_NPBLB                               \ Number of padding bytes in last block
$03000000 constant SAES_SAES_CR_KMOD                                \ Key mode selection
$0c000000 constant SAES_SAES_CR_KSHAREID                            \ Key share identification
$70000000 constant SAES_SAES_CR_KEYSEL                              \ Key selection
$80000000 constant SAES_SAES_CR_IPRST                               \ SAES peripheral software reset


\
\ @brief SAES status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000002 constant SAES_SAES_SR_RDERRF                              \ Read error flag
$00000004 constant SAES_SAES_SR_WRERRF                              \ Write error flag
$00000008 constant SAES_SAES_SR_BUSY                                \ Busy
$00000080 constant SAES_SAES_SR_KEYVALID                            \ Key valid flag


\
\ @brief SAES data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_DINR_DIN                               \ Data input


\
\ @brief SAES data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_DOUTR_DOUT                             \ Data output


\
\ @brief SAES key register 0
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_KEYR0_KEY                              \ Cryptographic key, bits [31:0]


\
\ @brief SAES key register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_KEYR1_KEY                              \ Cryptographic key, bits [63:32]


\
\ @brief SAES key register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_KEYR2_KEY                              \ Cryptographic key, bits [95:64]


\
\ @brief SAES key register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_KEYR3_KEY                              \ Cryptographic key, bits [127:96]


\
\ @brief SAES initialization vector register 0
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_IVR0_IVI                               \ Initialization vector input, bits [31:0]


\
\ @brief SAES initialization vector register 1
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_IVR1_IVI                               \ Initialization vector input, bits [63:32]


\
\ @brief SAES initialization vector register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_IVR2_IVI                               \ Initialization vector input, bits [95:64]


\
\ @brief SAES initialization vector register 3
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_IVR3_IVI                               \ Initialization vector input, bits [127:96]


\
\ @brief SAES key register 4
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_KEYR4_KEY                              \ Cryptographic key, bits [159:128]


\
\ @brief SAES key register 5
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_KEYR5_KEY                              \ Cryptographic key, bits [191:160]


\
\ @brief SAES key register 6
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_KEYR6_KEY                              \ Cryptographic key, bits [223:192]


\
\ @brief SAES key register 7
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_KEYR7_KEY                              \ Cryptographic key, bits [255:224]


\
\ @brief SAES suspend registers
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_SUSPR0_SUSP                            \ Suspend data


\
\ @brief SAES suspend registers
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_SUSPR1_SUSP                            \ Suspend data


\
\ @brief SAES suspend registers
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_SUSPR2_SUSP                            \ Suspend data


\
\ @brief SAES suspend registers
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_SUSPR3_SUSP                            \ Suspend data


\
\ @brief SAES suspend registers
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_SUSPR4_SUSP                            \ Suspend data


\
\ @brief SAES suspend registers
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_SUSPR5_SUSP                            \ Suspend data


\
\ @brief SAES suspend registers
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_SUSPR6_SUSP                            \ Suspend data


\
\ @brief SAES suspend registers
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant SAES_SAES_SUSPR7_SUSP                            \ Suspend data


\
\ @brief SAES interrupt enable register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant SAES_SAES_IER_CCFIE                              \ Computation complete flag interrupt enable
$00000002 constant SAES_SAES_IER_RWEIE                              \ Read or write error interrupt enable
$00000004 constant SAES_SAES_IER_KEIE                               \ Key error interrupt enable
$00000008 constant SAES_SAES_IER_RNGEIE                             \ RNG error interrupt enable


\
\ @brief SAES interrupt status register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant SAES_SAES_ISR_CCF                                \ Computation complete flag
$00000002 constant SAES_SAES_ISR_RWEIF                              \ Read or write error interrupt flag
$00000004 constant SAES_SAES_ISR_KEIF                               \ Key error interrupt flag
$00000008 constant SAES_SAES_ISR_RNGEIF                             \ RNG error interrupt flag


\
\ @brief SAES interrupt clear register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant SAES_SAES_ICR_CCF                                \ Computation complete flag clear
$00000002 constant SAES_SAES_ICR_RWEIF                              \ Read or write error interrupt flag clear
$00000004 constant SAES_SAES_ICR_KEIF                               \ Key error interrupt flag clear
$00000008 constant SAES_SAES_ICR_RNGEIF                             \ RNG error interrupt flag clear


\
\ @brief Secure AES coprocessor
\
$44021000 constant SAES_SAES_CR   \ offset: 0x00 : SAES control register
$44021004 constant SAES_SAES_SR   \ offset: 0x04 : SAES status register
$44021008 constant SAES_SAES_DINR  \ offset: 0x08 : SAES data input register
$4402100c constant SAES_SAES_DOUTR  \ offset: 0x0C : SAES data output register
$44021010 constant SAES_SAES_KEYR0  \ offset: 0x10 : SAES key register 0
$44021014 constant SAES_SAES_KEYR1  \ offset: 0x14 : SAES key register 1
$44021018 constant SAES_SAES_KEYR2  \ offset: 0x18 : SAES key register 2
$4402101c constant SAES_SAES_KEYR3  \ offset: 0x1C : SAES key register 3
$44021020 constant SAES_SAES_IVR0  \ offset: 0x20 : SAES initialization vector register 0
$44021024 constant SAES_SAES_IVR1  \ offset: 0x24 : SAES initialization vector register 1
$44021028 constant SAES_SAES_IVR2  \ offset: 0x28 : SAES initialization vector register 2
$4402102c constant SAES_SAES_IVR3  \ offset: 0x2C : SAES initialization vector register 3
$44021030 constant SAES_SAES_KEYR4  \ offset: 0x30 : SAES key register 4
$44021034 constant SAES_SAES_KEYR5  \ offset: 0x34 : SAES key register 5
$44021038 constant SAES_SAES_KEYR6  \ offset: 0x38 : SAES key register 6
$4402103c constant SAES_SAES_KEYR7  \ offset: 0x3C : SAES key register 7
$44021040 constant SAES_SAES_SUSPR0  \ offset: 0x40 : SAES suspend registers
$44021044 constant SAES_SAES_SUSPR1  \ offset: 0x44 : SAES suspend registers
$44021048 constant SAES_SAES_SUSPR2  \ offset: 0x48 : SAES suspend registers
$4402104c constant SAES_SAES_SUSPR3  \ offset: 0x4C : SAES suspend registers
$44021050 constant SAES_SAES_SUSPR4  \ offset: 0x50 : SAES suspend registers
$44021054 constant SAES_SAES_SUSPR5  \ offset: 0x54 : SAES suspend registers
$44021058 constant SAES_SAES_SUSPR6  \ offset: 0x58 : SAES suspend registers
$4402105c constant SAES_SAES_SUSPR7  \ offset: 0x5C : SAES suspend registers
$44021300 constant SAES_SAES_IER  \ offset: 0x300 : SAES interrupt enable register
$44021304 constant SAES_SAES_ISR  \ offset: 0x304 : SAES interrupt status register
$44021308 constant SAES_SAES_ICR  \ offset: 0x308 : SAES interrupt clear register

