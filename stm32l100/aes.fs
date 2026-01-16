\
\ @file aes.fs
\ @brief Advanced encrytion standard hardware       accelerator
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
$00000006 constant AES_CR_DATATYPE                                  \ Data type selection
$00000018 constant AES_CR_MODE                                      \ AES operating mode
$00000060 constant AES_CR_CHMOD                                     \ AES chaining mode
$00000080 constant AES_CR_CCFC                                      \ Computation Complete Flag Clear
$00000100 constant AES_CR_ERRC                                      \ Error clear
$00000200 constant AES_CR_CCFIE                                     \ CCF flag interrupt enable
$00000400 constant AES_CR_ERRIE                                     \ Error interrupt enable
$00000800 constant AES_CR_DMAINEN                                   \ Enable DMA management of data input phase
$00001000 constant AES_CR_DMAOUTEN                                  \ Enable DMA management of data output phase


\
\ @brief Status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant AES_SR_CCF                                       \ Computation complete flag
$00000002 constant AES_SR_RDERR                                     \ Read error flag
$00000004 constant AES_SR_WRERR                                     \ Write error flag


\
\ @brief Data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant AES_DINR_DINR                                    \ Data input


\
\ @brief Data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant AES_DOUTR_DOUTR                                  \ Data output


\
\ @brief AES Key register 0
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR0_KEYR0                                  \ AES key


\
\ @brief AES Key register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR1_KEYR1                                  \ AES key


\
\ @brief AES Key register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR2_KEYR2                                  \ AES key


\
\ @brief AES Key register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant AES_KEYR3_KEYR3                                  \ AES key


\
\ @brief Initialization Vector Register 0
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR0_IVR0                                    \ Initialization Vector Register


\
\ @brief Initialization Vector Register 1
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR1_IVR1                                    \ Initialization Vector Register


\
\ @brief Initialization Vector Register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR2_IVR2                                    \ Initialization Vector Register


\
\ @brief Initialization Vector Register 3
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant AES_IVR3_IVR3                                    \ Initialization Vector Register


\
\ @brief Advanced encrytion standard hardware accelerator
\
$50060000 constant AES_CR         \ offset: 0x00 : control register
$50060004 constant AES_SR         \ offset: 0x04 : Status register
$50060008 constant AES_DINR       \ offset: 0x08 : Data input register
$5006000c constant AES_DOUTR      \ offset: 0x0C : Data output register
$50060010 constant AES_KEYR0      \ offset: 0x10 : AES Key register 0
$50060014 constant AES_KEYR1      \ offset: 0x14 : AES Key register 1
$50060018 constant AES_KEYR2      \ offset: 0x18 : AES Key register 2
$5006001c constant AES_KEYR3      \ offset: 0x1C : AES Key register 3
$50060020 constant AES_IVR0       \ offset: 0x20 : Initialization Vector Register 0
$50060024 constant AES_IVR1       \ offset: 0x24 : Initialization Vector Register 1
$50060028 constant AES_IVR2       \ offset: 0x28 : Initialization Vector Register 2
$5006002c constant AES_IVR3       \ offset: 0x2C : Initialization Vector Register 3

