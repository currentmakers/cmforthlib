\
\ @file aes1.fs
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

$00000001 constant AES1_CR_EN                                       \ AES enable
$00000006 constant AES1_CR_DATATYPE                                 \ Data type selection (for data in and data out to/from the cryptographic block)
$00000018 constant AES1_CR_MODE                                     \ AES operating mode
$00000060 constant AES1_CR_CHMOD10                                  \ AES chaining mode Bit1 Bit0
$00000080 constant AES1_CR_CCFC                                     \ Computation Complete Flag Clear
$00000100 constant AES1_CR_ERRC                                     \ Error clear
$00000200 constant AES1_CR_CCFIE                                    \ CCF flag interrupt enable
$00000400 constant AES1_CR_ERRIE                                    \ Error interrupt enable
$00000800 constant AES1_CR_DMAINEN                                  \ Enable DMA management of data input phase
$00001000 constant AES1_CR_DMAOUTEN                                 \ Enable DMA management of data output phase
$00006000 constant AES1_CR_GCMPH                                    \ Used only for GCM, CCM and GMAC algorithms and has no effect when other algorithms are selected
$00010000 constant AES1_CR_CHMOD2                                   \ AES chaining mode Bit2
$00040000 constant AES1_CR_KEYSIZE                                  \ Key size selection
$00f00000 constant AES1_CR_NPBLB                                    \ Number of padding bytes in last block of payload


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant AES1_SR_CCF                                      \ Computation complete flag
$00000002 constant AES1_SR_RDERR                                    \ Read error flag
$00000004 constant AES1_SR_WRERR                                    \ Write error flag
$00000008 constant AES1_SR_BUSY                                     \ Busy flag


\
\ @brief data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant AES1_DINR_AES_DINR                               \ Data Input Register


\
\ @brief data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant AES1_DOUTR_AES_DOUTR                             \ Data output register


\
\ @brief key register 0
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant AES1_KEYR0_AES_KEYR0                             \ Data Output Register (LSB key [31:0])


\
\ @brief key register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant AES1_KEYR1_AES_KEYR1                             \ AES key register (key [63:32])


\
\ @brief key register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant AES1_KEYR2_AES_KEYR2                             \ AES key register (key [95:64])


\
\ @brief key register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant AES1_KEYR3_AES_KEYR3                             \ AES key register (MSB key [127:96])


\
\ @brief initialization vector register 0
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant AES1_IVR0_AES_IVR0                               \ initialization vector register (LSB IVR [31:0])


\
\ @brief initialization vector register 1
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant AES1_IVR1_AES_IVR1                               \ Initialization Vector Register (IVR [63:32])


\
\ @brief initialization vector register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant AES1_IVR2_AES_IVR2                               \ Initialization Vector Register (IVR [95:64])


\
\ @brief initialization vector register 3
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant AES1_IVR3_AES_IVR3                               \ Initialization Vector Register (MSB IVR [127:96])


\
\ @brief key register 4
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant AES1_KEYR4_AES_KEYR4                             \ AES key register (MSB key [159:128])


\
\ @brief key register 5
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant AES1_KEYR5_AES_KEYR5                             \ AES key register (MSB key [191:160])


\
\ @brief key register 6
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant AES1_KEYR6_AES_KEYR6                             \ AES key register (MSB key [223:192])


\
\ @brief key register 7
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant AES1_KEYR7_AES_KEYR7                             \ AES key register (MSB key [255:224])


\
\ @brief AES suspend register 0
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant AES1_SUSP0R_AES_SUSP0R                           \ AES suspend register 0


\
\ @brief AES suspend register 1
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant AES1_SUSP1R_AES_SUSP1R                           \ AES suspend register 1


\
\ @brief AES suspend register 2
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant AES1_SUSP2R_AES_SUSP2R                           \ AES suspend register 2


\
\ @brief AES suspend register 3
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant AES1_SUSP3R_AES_SUSP3R                           \ AES suspend register 3


\
\ @brief AES suspend register 4
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant AES1_SUSP4R_AES_SUSP4R                           \ AES suspend register 4


\
\ @brief AES suspend register 5
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant AES1_SUSP5R_AES_SUSP5R                           \ AES suspend register 5


\
\ @brief AES suspend register 6
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant AES1_SUSP6R_AES_SUSP6R                           \ AES suspend register 6


\
\ @brief AES suspend register 7
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant AES1_SUSP7R_AES_SUSP7R                           \ AES suspend register 7


\
\ @brief AES hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000002
\

$0000000f constant AES1_HWCFR_CFG1                                  \ HW Generic 1
$000000f0 constant AES1_HWCFR_CFG2                                  \ HW Generic 2
$00000f00 constant AES1_HWCFR_CFG3                                  \ HW Generic 3
$0000f000 constant AES1_HWCFR_CFG4                                  \ HW Generic 4


\
\ @brief AES version register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$0000000f constant AES1_VERR_MINREV                                 \ Minor revision
$000000f0 constant AES1_VERR_MAJREV                                 \ Major revision


\
\ @brief AES identification register
\ Address offset: 0x3F8
\ Reset value: 0x00170023
\

$00000000 constant AES1_IPIDR_ID                                    \ Identification code


\
\ @brief AES size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant AES1_SIDR_ID                                     \ Size Identification code


\
\ @brief Advanced encryption standard hardware accelerator 1
\
$50060000 constant AES1_CR        \ offset: 0x00 : control register
$50060004 constant AES1_SR        \ offset: 0x04 : status register
$50060008 constant AES1_DINR      \ offset: 0x08 : data input register
$5006000c constant AES1_DOUTR     \ offset: 0x0C : data output register
$50060010 constant AES1_KEYR0     \ offset: 0x10 : key register 0
$50060014 constant AES1_KEYR1     \ offset: 0x14 : key register 1
$50060018 constant AES1_KEYR2     \ offset: 0x18 : key register 2
$5006001c constant AES1_KEYR3     \ offset: 0x1C : key register 3
$50060020 constant AES1_IVR0      \ offset: 0x20 : initialization vector register 0
$50060024 constant AES1_IVR1      \ offset: 0x24 : initialization vector register 1
$50060028 constant AES1_IVR2      \ offset: 0x28 : initialization vector register 2
$5006002c constant AES1_IVR3      \ offset: 0x2C : initialization vector register 3
$50060030 constant AES1_KEYR4     \ offset: 0x30 : key register 4
$50060034 constant AES1_KEYR5     \ offset: 0x34 : key register 5
$50060038 constant AES1_KEYR6     \ offset: 0x38 : key register 6
$5006003c constant AES1_KEYR7     \ offset: 0x3C : key register 7
$50060040 constant AES1_SUSP0R    \ offset: 0x40 : AES suspend register 0
$50060044 constant AES1_SUSP1R    \ offset: 0x44 : AES suspend register 1
$50060048 constant AES1_SUSP2R    \ offset: 0x48 : AES suspend register 2
$5006004c constant AES1_SUSP3R    \ offset: 0x4C : AES suspend register 3
$50060050 constant AES1_SUSP4R    \ offset: 0x50 : AES suspend register 4
$50060054 constant AES1_SUSP5R    \ offset: 0x54 : AES suspend register 5
$50060058 constant AES1_SUSP6R    \ offset: 0x58 : AES suspend register 6
$5006005c constant AES1_SUSP7R    \ offset: 0x5C : AES suspend register 7
$500603f0 constant AES1_HWCFR     \ offset: 0x3F0 : AES hardware configuration register
$500603f4 constant AES1_VERR      \ offset: 0x3F4 : AES version register
$500603f8 constant AES1_IPIDR     \ offset: 0x3F8 : AES identification register
$500603fc constant AES1_SIDR      \ offset: 0x3FC : AES size ID register

