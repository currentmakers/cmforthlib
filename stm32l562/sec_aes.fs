\
\ @file sec_aes.fs
\ @brief Advanced encryption standard hardware       accelerator 1
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
$00000060 constant SEC_AES_CR_CHMOD                                 \ AES chaining mode selection Bit1 Bit0
$00000080 constant SEC_AES_CR_CCFC                                  \ Computation Complete Flag Clear
$00000100 constant SEC_AES_CR_ERRC                                  \ Error clear
$00000200 constant SEC_AES_CR_CCFIE                                 \ CCF flag interrupt enable
$00000400 constant SEC_AES_CR_ERRIE                                 \ Error interrupt enable
$00000800 constant SEC_AES_CR_DMAINEN                               \ Enable DMA management of data input phase
$00001000 constant SEC_AES_CR_DMAOUTEN                              \ Enable DMA management of data output phase
$00006000 constant SEC_AES_CR_GCMPH                                 \ Used only for GCM, CCM and GMAC algorithms and has no effect when other algorithms are selected
$00010000 constant SEC_AES_CR_CHMOD2                                \ AES chaining mode Bit2
$00040000 constant SEC_AES_CR_KEYSIZE                               \ Key size selection
$00f00000 constant SEC_AES_CR_NPBLB                                 \ Number of padding bytes in last block of payload


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_AES_SR_CCF                                   \ Computation complete flag
$00000002 constant SEC_AES_SR_RDERR                                 \ Read error flag
$00000004 constant SEC_AES_SR_WRERR                                 \ Write error flag
$00000008 constant SEC_AES_SR_BUSY                                  \ Busy flag


\
\ @brief data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_DINR_DIN                                 \ Data Input Register


\
\ @brief data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_DOUTR_DOUT                               \ Data output register


\
\ @brief key register 0
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR0_KEY                                \ Cryptographic key, bits[31:0]


\
\ @brief key register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR1_KEY                                \ Cryptographic key, bits [63:32])


\
\ @brief key register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR2_KEY                                \ Cryptographic key, bits [95:64])


\
\ @brief key register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR3_KEY                                \ Cryptographic key, bits [127:96])


\
\ @brief initialization vector register 0
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_IVR0_IVI                                 \ initialization vector register (LSB IVR [31:0])


\
\ @brief initialization vector register 1
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_IVR1_IVI                                 \ Initialization Vector Register (IVR [63:32])


\
\ @brief initialization vector register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_IVR2_IVI                                 \ Initialization Vector Register (IVR [95:64])


\
\ @brief initialization vector register 3
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_IVR3_IVI                                 \ Initialization Vector Register (MSB IVR [127:96])


\
\ @brief key register 4
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR4_KEY                                \ Cryptographic key, bits [159:128])


\
\ @brief key register 5
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR5_KEY                                \ Cryptographic key, bits [191:160])


\
\ @brief key register 6
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR6_KEY                                \ Cryptographic key, bits [223:192])


\
\ @brief key register 7
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_KEYR7_KEY                                \ Cryptographic key, bits [255:224])


\
\ @brief AES suspend register 0
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP0R_AES_SUSP0R                        \ AES suspend register 0


\
\ @brief AES suspend register 1
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP1R_AES_SUSP1R                        \ AES suspend register 1


\
\ @brief AES suspend register 2
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP2R_AES_SUSP2R                        \ AES suspend register 2


\
\ @brief AES suspend register 3
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP3R_AES_SUSP3R                        \ AES suspend register 3


\
\ @brief AES suspend register 4
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP4R_AES_SUSP4R                        \ AES suspend register 4


\
\ @brief AES suspend register 5
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP5R_AES_SUSP5R                        \ AES suspend register 5


\
\ @brief AES suspend register 6
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP6R_AES_SUSP6R                        \ AES suspend register 6


\
\ @brief AES suspend register 7
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant SEC_AES_SUSP7R_AES_SUSP7R                        \ AES suspend register 7


\
\ @brief Advanced encryption standard hardware accelerator 1
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
$520c0040 constant SEC_AES_SUSP0R  \ offset: 0x40 : AES suspend register 0
$520c0044 constant SEC_AES_SUSP1R  \ offset: 0x44 : AES suspend register 1
$520c0048 constant SEC_AES_SUSP2R  \ offset: 0x48 : AES suspend register 2
$520c004c constant SEC_AES_SUSP3R  \ offset: 0x4C : AES suspend register 3
$520c0050 constant SEC_AES_SUSP4R  \ offset: 0x50 : AES suspend register 4
$520c0054 constant SEC_AES_SUSP5R  \ offset: 0x54 : AES suspend register 5
$520c0058 constant SEC_AES_SUSP6R  \ offset: 0x58 : AES suspend register 6
$520c005c constant SEC_AES_SUSP7R  \ offset: 0x5C : AES suspend register 7

