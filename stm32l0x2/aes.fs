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


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant AES_SR_CCF                                       \ Computation complete flag
$00000002 constant AES_SR_RDERR                                     \ Read error flag
$00000004 constant AES_SR_WRERR                                     \ Write error flag


\
\ @brief data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant AES_DINR_AES_DINR                                \ Data Input Register.


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
\ @brief Advanced encryption standard hardware accelerator
\
$40026000 constant AES_CR         \ offset: 0x00 : control register
$40026004 constant AES_SR         \ offset: 0x04 : status register
$40026008 constant AES_DINR       \ offset: 0x08 : data input register
$4002600c constant AES_DOUTR      \ offset: 0x0C : data output register
$40026010 constant AES_KEYR0      \ offset: 0x10 : key register 0
$40026014 constant AES_KEYR1      \ offset: 0x14 : key register 1
$40026018 constant AES_KEYR2      \ offset: 0x18 : key register 2
$4002601c constant AES_KEYR3      \ offset: 0x1C : key register 3
$40026020 constant AES_IVR0       \ offset: 0x20 : initialization vector register 0
$40026024 constant AES_IVR1       \ offset: 0x24 : initialization vector register 1
$40026028 constant AES_IVR2       \ offset: 0x28 : initialization vector register 2
$4002602c constant AES_IVR3       \ offset: 0x2C : initialization vector register 3

