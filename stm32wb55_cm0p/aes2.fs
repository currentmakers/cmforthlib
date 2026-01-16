\
\ @file aes2.fs
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

$00000001 constant AES2_CR_EN                                       \ AES enable
$00000006 constant AES2_CR_DATATYPE                                 \ Data type selection (for data in and data out to/from the cryptographic block)
$00000018 constant AES2_CR_MODE                                     \ AES operating mode
$00000060 constant AES2_CR_CHMOD10                                  \ AES chaining mode Bit1 Bit0
$00000080 constant AES2_CR_CCFC                                     \ Computation Complete Flag Clear
$00000100 constant AES2_CR_ERRC                                     \ Error clear
$00000200 constant AES2_CR_CCFIE                                    \ CCF flag interrupt enable
$00000400 constant AES2_CR_ERRIE                                    \ Error interrupt enable
$00000800 constant AES2_CR_DMAINEN                                  \ Enable DMA management of data input phase
$00001000 constant AES2_CR_DMAOUTEN                                 \ Enable DMA management of data output phase
$00006000 constant AES2_CR_GCMPH                                    \ Used only for GCM, CCM and GMAC algorithms and has no effect when other algorithms are selected
$00010000 constant AES2_CR_CHMOD2                                   \ AES chaining mode Bit2
$00040000 constant AES2_CR_KEYSIZE                                  \ Key size selection
$00f00000 constant AES2_CR_NPBLB                                    \ Number of padding bytes in last block of payload


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant AES2_SR_CCF                                      \ Computation complete flag
$00000002 constant AES2_SR_RDERR                                    \ Read error flag
$00000004 constant AES2_SR_WRERR                                    \ Write error flag
$00000008 constant AES2_SR_BUSY                                     \ Busy flag


\
\ @brief data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant AES2_DINR_AES_DINR                               \ Data Input Register


\
\ @brief data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant AES2_DOUTR_AES_DOUTR                             \ Data output register


\
\ @brief key register 0
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant AES2_KEYR0_AES_KEYR0                             \ Data Output Register (LSB key [31:0])


\
\ @brief key register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant AES2_KEYR1_AES_KEYR1                             \ AES key register (key [63:32])


\
\ @brief key register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant AES2_KEYR2_AES_KEYR2                             \ AES key register (key [95:64])


\
\ @brief key register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant AES2_KEYR3_AES_KEYR3                             \ AES key register (MSB key [127:96])


\
\ @brief initialization vector register 0
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant AES2_IVR0_AES_IVR0                               \ initialization vector register (LSB IVR [31:0])


\
\ @brief initialization vector register 1
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant AES2_IVR1_AES_IVR1                               \ Initialization Vector Register (IVR [63:32])


\
\ @brief initialization vector register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant AES2_IVR2_AES_IVR2                               \ Initialization Vector Register (IVR [95:64])


\
\ @brief initialization vector register 3
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant AES2_IVR3_AES_IVR3                               \ Initialization Vector Register (MSB IVR [127:96])


\
\ @brief key register 4
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant AES2_KEYR4_AES_KEYR4                             \ AES key register (MSB key [159:128])


\
\ @brief key register 5
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant AES2_KEYR5_AES_KEYR5                             \ AES key register (MSB key [191:160])


\
\ @brief key register 6
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant AES2_KEYR6_AES_KEYR6                             \ AES key register (MSB key [223:192])


\
\ @brief key register 7
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant AES2_KEYR7_AES_KEYR7                             \ AES key register (MSB key [255:224])


\
\ @brief AES suspend register 0
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant AES2_SUSP0R_AES_SUSP0R                           \ AES suspend register 0


\
\ @brief AES suspend register 1
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant AES2_SUSP1R_AES_SUSP1R                           \ AES suspend register 1


\
\ @brief AES suspend register 2
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant AES2_SUSP2R_AES_SUSP2R                           \ AES suspend register 2


\
\ @brief AES suspend register 3
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant AES2_SUSP3R_AES_SUSP3R                           \ AES suspend register 3


\
\ @brief AES suspend register 4
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant AES2_SUSP4R_AES_SUSP4R                           \ AES suspend register 4


\
\ @brief AES suspend register 5
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant AES2_SUSP5R_AES_SUSP5R                           \ AES suspend register 5


\
\ @brief AES suspend register 6
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant AES2_SUSP6R_AES_SUSP6R                           \ AES suspend register 6


\
\ @brief AES suspend register 7
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant AES2_SUSP7R_AES_SUSP7R                           \ AES suspend register 7


\
\ @brief AES hardware configuration register
\ Address offset: 0x60
\ Reset value: 0x00000002
\

$0000000f constant AES2_HWCFR_CFG1                                  \ HW Generic 1
$000000f0 constant AES2_HWCFR_CFG2                                  \ HW Generic 2
$00000f00 constant AES2_HWCFR_CFG3                                  \ HW Generic 3
$0000f000 constant AES2_HWCFR_CFG4                                  \ HW Generic 4


\
\ @brief AES version register
\ Address offset: 0x64
\ Reset value: 0x00000010
\

$0000000f constant AES2_VERR_MINREV                                 \ Minor revision
$000000f0 constant AES2_VERR_MAJREV                                 \ Major revision


\
\ @brief AES identification register
\ Address offset: 0x68
\ Reset value: 0x00170023
\

$00000000 constant AES2_IPIDR_ID                                    \ Identification code


\
\ @brief AES size ID register
\ Address offset: 0x6C
\ Reset value: 0x00170023
\

$00000000 constant AES2_SIDR_ID                                     \ Size Identification code


\
\ @brief Advanced encryption standard hardware accelerator 1
\
$58001800 constant AES2_CR        \ offset: 0x00 : control register
$58001804 constant AES2_SR        \ offset: 0x04 : status register
$58001808 constant AES2_DINR      \ offset: 0x08 : data input register
$5800180c constant AES2_DOUTR     \ offset: 0x0C : data output register
$58001810 constant AES2_KEYR0     \ offset: 0x10 : key register 0
$58001814 constant AES2_KEYR1     \ offset: 0x14 : key register 1
$58001818 constant AES2_KEYR2     \ offset: 0x18 : key register 2
$5800181c constant AES2_KEYR3     \ offset: 0x1C : key register 3
$58001820 constant AES2_IVR0      \ offset: 0x20 : initialization vector register 0
$58001824 constant AES2_IVR1      \ offset: 0x24 : initialization vector register 1
$58001828 constant AES2_IVR2      \ offset: 0x28 : initialization vector register 2
$5800182c constant AES2_IVR3      \ offset: 0x2C : initialization vector register 3
$58001830 constant AES2_KEYR4     \ offset: 0x30 : key register 4
$58001834 constant AES2_KEYR5     \ offset: 0x34 : key register 5
$58001838 constant AES2_KEYR6     \ offset: 0x38 : key register 6
$5800183c constant AES2_KEYR7     \ offset: 0x3C : key register 7
$58001840 constant AES2_SUSP0R    \ offset: 0x40 : AES suspend register 0
$58001844 constant AES2_SUSP1R    \ offset: 0x44 : AES suspend register 1
$58001848 constant AES2_SUSP2R    \ offset: 0x48 : AES suspend register 2
$5800184c constant AES2_SUSP3R    \ offset: 0x4C : AES suspend register 3
$58001850 constant AES2_SUSP4R    \ offset: 0x50 : AES suspend register 4
$58001854 constant AES2_SUSP5R    \ offset: 0x54 : AES suspend register 5
$58001858 constant AES2_SUSP6R    \ offset: 0x58 : AES suspend register 6
$5800185c constant AES2_SUSP7R    \ offset: 0x5C : AES suspend register 7
$58001860 constant AES2_HWCFR     \ offset: 0x60 : AES hardware configuration register
$58001864 constant AES2_VERR      \ offset: 0x64 : AES version register
$58001868 constant AES2_IPIDR     \ offset: 0x68 : AES identification register
$5800186c constant AES2_SIDR      \ offset: 0x6C : AES size ID register

