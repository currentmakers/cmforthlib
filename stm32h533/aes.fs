\
\ @file aes.fs
\ @brief AES register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief AES control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant AES_AES_CR_EN                                    \ Enable
$00000006 constant AES_AES_CR_DATATYPE                              \ Data type
$00000018 constant AES_AES_CR_MODE                                  \ Operating mode
$00000060 constant AES_AES_CR_CHMOD                                 \ CHMOD[1:0]: Chaining mode
$00000800 constant AES_AES_CR_DMAINEN                               \ DMA input enable
$00001000 constant AES_AES_CR_DMAOUTEN                              \ DMA output enable
$00006000 constant AES_AES_CR_GCMPH                                 \ GCM or CCM phase selection
$00010000 constant AES_AES_CR_CHMOD_1                               \ CHMOD[2]
$00040000 constant AES_AES_CR_KEYSIZE                               \ Key size selection
$00f00000 constant AES_AES_CR_NPBLB                                 \ Number of padding bytes in last block
$03000000 constant AES_AES_CR_KMOD                                  \ Key mode selection
$80000000 constant AES_AES_CR_IPRST                                 \ AES peripheral software reset


\
\ @brief AES status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000002 constant AES_AES_SR_RDERRF                                \ Read error flag
$00000004 constant AES_AES_SR_WRERRF                                \ Write error flag
$00000008 constant AES_AES_SR_BUSY                                  \ Busy
$00000080 constant AES_AES_SR_KEYVALID                              \ Key valid flag


\
\ @brief AES data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_DINR_DIN                                 \ Data input


\
\ @brief AES data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_DOUTR_DOUT                               \ Data output


\
\ @brief AES key register 0
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR0_KEY                                \ Cryptographic key, bits [31:0]


\
\ @brief AES key register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR1_KEY                                \ Cryptographic key, bits [63:32]


\
\ @brief AES key register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR2_KEY                                \ Cryptographic key, bits [95:64]


\
\ @brief AES key register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR3_KEY                                \ Cryptographic key, bits [127:96]


\
\ @brief AES initialization vector register 0
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_IVR0_IVI                                 \ Initialization vector input, bits [31:0]


\
\ @brief AES initialization vector register 1
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_IVR1_IVI                                 \ Initialization vector input, bits [63:32]


\
\ @brief AES initialization vector register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_IVR2_IVI                                 \ Initialization vector input, bits [95:64]


\
\ @brief AES initialization vector register 3
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_IVR3_IVI                                 \ Initialization vector input, bits [127:96]


\
\ @brief AES key register 4
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR4_KEY                                \ Cryptographic key, bits [159:128]


\
\ @brief AES key register 5
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR5_KEY                                \ Cryptographic key, bits [191:160]


\
\ @brief AES key register 6
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR6_KEY                                \ Cryptographic key, bits [223:192]


\
\ @brief AES key register 7
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR7_KEY                                \ Cryptographic key, bits [255:224]


\
\ @brief AES suspend registers
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_SUSPR0_SUSP                              \ Suspend data


\
\ @brief AES suspend registers
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_SUSPR1_SUSP                              \ Suspend data


\
\ @brief AES suspend registers
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_SUSPR2_SUSP                              \ Suspend data


\
\ @brief AES suspend registers
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_SUSPR3_SUSP                              \ Suspend data


\
\ @brief AES suspend registers
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_SUSPR4_SUSP                              \ Suspend data


\
\ @brief AES suspend registers
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_SUSPR5_SUSP                              \ Suspend data


\
\ @brief AES suspend registers
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_SUSPR6_SUSP                              \ Suspend data


\
\ @brief AES suspend registers
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_SUSPR7_SUSP                              \ Suspend data


\
\ @brief AES interrupt enable register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant AES_AES_IER_CCFIE                                \ Computation complete flag interrupt enable
$00000002 constant AES_AES_IER_RWEIE                                \ Read or write error interrupt enable
$00000004 constant AES_AES_IER_KEIE                                 \ Key error interrupt enable


\
\ @brief AES interrupt status register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant AES_AES_ISR_CCF                                  \ Computation complete flag
$00000002 constant AES_AES_ISR_RWEIF                                \ Read or write error interrupt flag
$00000004 constant AES_AES_ISR_KEIF                                 \ Key error interrupt flag


\
\ @brief AES interrupt clear register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant AES_AES_ICR_CCF                                  \ Computation complete flag clear
$00000002 constant AES_AES_ICR_RWEIF                                \ Read or write error interrupt flag clear
$00000004 constant AES_AES_ICR_KEIF                                 \ Key error interrupt flag clear


\
\ @brief AES register block
\
$420c0000 constant AES_AES_CR     \ offset: 0x00 : AES control register
$420c0004 constant AES_AES_SR     \ offset: 0x04 : AES status register
$420c0008 constant AES_AES_DINR   \ offset: 0x08 : AES data input register
$420c000c constant AES_AES_DOUTR  \ offset: 0x0C : AES data output register
$420c0010 constant AES_AES_KEYR0  \ offset: 0x10 : AES key register 0
$420c0014 constant AES_AES_KEYR1  \ offset: 0x14 : AES key register 1
$420c0018 constant AES_AES_KEYR2  \ offset: 0x18 : AES key register 2
$420c001c constant AES_AES_KEYR3  \ offset: 0x1C : AES key register 3
$420c0020 constant AES_AES_IVR0   \ offset: 0x20 : AES initialization vector register 0
$420c0024 constant AES_AES_IVR1   \ offset: 0x24 : AES initialization vector register 1
$420c0028 constant AES_AES_IVR2   \ offset: 0x28 : AES initialization vector register 2
$420c002c constant AES_AES_IVR3   \ offset: 0x2C : AES initialization vector register 3
$420c0030 constant AES_AES_KEYR4  \ offset: 0x30 : AES key register 4
$420c0034 constant AES_AES_KEYR5  \ offset: 0x34 : AES key register 5
$420c0038 constant AES_AES_KEYR6  \ offset: 0x38 : AES key register 6
$420c003c constant AES_AES_KEYR7  \ offset: 0x3C : AES key register 7
$420c0040 constant AES_AES_SUSPR0  \ offset: 0x40 : AES suspend registers
$420c0044 constant AES_AES_SUSPR1  \ offset: 0x44 : AES suspend registers
$420c0048 constant AES_AES_SUSPR2  \ offset: 0x48 : AES suspend registers
$420c004c constant AES_AES_SUSPR3  \ offset: 0x4C : AES suspend registers
$420c0050 constant AES_AES_SUSPR4  \ offset: 0x50 : AES suspend registers
$420c0054 constant AES_AES_SUSPR5  \ offset: 0x54 : AES suspend registers
$420c0058 constant AES_AES_SUSPR6  \ offset: 0x58 : AES suspend registers
$420c005c constant AES_AES_SUSPR7  \ offset: 0x5C : AES suspend registers
$420c0300 constant AES_AES_IER    \ offset: 0x300 : AES interrupt enable register
$420c0304 constant AES_AES_ISR    \ offset: 0x304 : AES interrupt status register
$420c0308 constant AES_AES_ICR    \ offset: 0x308 : AES interrupt clear register

