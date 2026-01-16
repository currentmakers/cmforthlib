\
\ @file sec_saes.fs
\ @brief Secure AES coprocessor
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

$00000001 constant SEC_SAES_CR_EN                                   \ SAES enable
$00000006 constant SEC_SAES_CR_DATATYPE                             \ DATATYPE
$00000018 constant SEC_SAES_CR_MODE                                 \ MODE
$00000060 constant SEC_SAES_CR_CHMOD                                \ CHMOD
$00000800 constant SEC_SAES_CR_DMAINEN                              \ DMAINEN
$00001000 constant SEC_SAES_CR_DMAOUTEN                             \ DMAOUTEN
$00040000 constant SEC_SAES_CR_KEYSIZE                              \ KEYSIZE
$00080000 constant SEC_SAES_CR_KEYPROT                              \ KEYPROT
$03000000 constant SEC_SAES_CR_KMOD                                 \ KMOD
$0c000000 constant SEC_SAES_CR_KSHAREID                             \ KSHAREID
$70000000 constant SEC_SAES_CR_KEYSEL                               \ KEYSEL
$80000000 constant SEC_SAES_CR_IPRST                                \ IPRST


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_SAES_SR_CCF                                  \ Computation complete flag
$00000002 constant SEC_SAES_SR_RDERR                                \ Read error flag
$00000004 constant SEC_SAES_SR_WRERR                                \ Write error flag
$00000008 constant SEC_SAES_SR_BUSY                                 \ BUSY
$00000080 constant SEC_SAES_SR_KEYVALID                             \ Key Valid flag


\
\ @brief data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_DINR_DIN                                \ Input data word


\
\ @brief data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_DOUTR_DOUT                              \ Output data word


\
\ @brief key register 0
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_KEYR0_KEY                               \ Cryptographic key, bits [31:0]


\
\ @brief key register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_KEYR1_KEY                               \ Cryptographic key, bits [63:32]


\
\ @brief key register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_KEYR2_KEYR                              \ Cryptographic key, bits [95:64]


\
\ @brief key register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_KEYR3_SAES_KEYR3                        \ Cryptographic key, bits [127:96]


\
\ @brief initialization vector register 0
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_IVR0_IVI                                \ Initialization vector input, bits [31:0]


\
\ @brief initialization vector register 1
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_IVR1_IVI                                \ Initialization vector input, bits [63:32]


\
\ @brief initialization vector register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_IVR2_IVI                                \ Initialization vector input, bits [95:64]


\
\ @brief initialization vector register 3
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_IVR3_IVI                                \ Initialization vector input, bits [127:96]


\
\ @brief key register 4
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_KEYR4_KEY                               \ Cryptographic key, bits [159:128]


\
\ @brief key register 5
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_KEYR5_KEY                               \ Cryptographic key, bits [191:160]


\
\ @brief key register 6
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_KEYR6_KEY                               \ Cryptographic key, bits [223:192]


\
\ @brief key register 7
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAES_KEYR7_KEY                               \ Cryptographic key, bits [255:224]


\
\ @brief configuration register
\ Address offset: 0x100
\ Reset value: 0x00000008
\

$00000002 constant SEC_SAES_DPACFGR_REDCFG                          \ REDCFG
$00000004 constant SEC_SAES_DPACFGR_RESEED                          \ RESEED
$00000018 constant SEC_SAES_DPACFGR_TRIMCFG                         \ TRIMCFG
$80000000 constant SEC_SAES_DPACFGR_CONFIGLOCK                      \ CONFIGLOCK


\
\ @brief interrupt enable register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant SEC_SAES_IER_CCFIE                               \ Computation complete flag interrupt enable
$00000002 constant SEC_SAES_IER_RWEIE                               \ Read or write error interrupt enable
$00000004 constant SEC_SAES_IER_KEIE                                \ Key error interrupt enable
$00000008 constant SEC_SAES_IER_RNGEIE                              \ RNGEIE


\
\ @brief interrupt status register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant SEC_SAES_ISR_CCF                                 \ Computation complete flag
$00000002 constant SEC_SAES_ISR_RWEIF                               \ Read or write error interrupt flag
$00000004 constant SEC_SAES_ISR_KEIF                                \ Key error interrupt flag
$00000008 constant SEC_SAES_ISR_RNGEIF                              \ RNGEIF


\
\ @brief interrupt clear register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant SEC_SAES_ICR_CCF                                 \ Computation complete flag clear
$00000002 constant SEC_SAES_ICR_RWEIF                               \ Read or write error interrupt flag clear
$00000004 constant SEC_SAES_ICR_KEIF                                \ Key error interrupt flag clear
$00000008 constant SEC_SAES_ICR_RNGEIF                              \ RNGEIF


\
\ @brief Secure AES coprocessor
\
$520c0c00 constant SEC_SAES_CR    \ offset: 0x00 : control register
$520c0c04 constant SEC_SAES_SR    \ offset: 0x04 : status register
$520c0c08 constant SEC_SAES_DINR  \ offset: 0x08 : data input register
$520c0c0c constant SEC_SAES_DOUTR  \ offset: 0x0C : data output register
$520c0c10 constant SEC_SAES_KEYR0  \ offset: 0x10 : key register 0
$520c0c14 constant SEC_SAES_KEYR1  \ offset: 0x14 : key register 1
$520c0c18 constant SEC_SAES_KEYR2  \ offset: 0x18 : key register 2
$520c0c1c constant SEC_SAES_KEYR3  \ offset: 0x1C : key register 3
$520c0c20 constant SEC_SAES_IVR0  \ offset: 0x20 : initialization vector register 0
$520c0c24 constant SEC_SAES_IVR1  \ offset: 0x24 : initialization vector register 1
$520c0c28 constant SEC_SAES_IVR2  \ offset: 0x28 : initialization vector register 2
$520c0c2c constant SEC_SAES_IVR3  \ offset: 0x2C : initialization vector register 3
$520c0c30 constant SEC_SAES_KEYR4  \ offset: 0x30 : key register 4
$520c0c34 constant SEC_SAES_KEYR5  \ offset: 0x34 : key register 5
$520c0c38 constant SEC_SAES_KEYR6  \ offset: 0x38 : key register 6
$520c0c3c constant SEC_SAES_KEYR7  \ offset: 0x3C : key register 7
$520c0d00 constant SEC_SAES_DPACFGR  \ offset: 0x100 : configuration register
$520c0f00 constant SEC_SAES_IER   \ offset: 0x300 : interrupt enable register
$520c0f04 constant SEC_SAES_ISR   \ offset: 0x304 : interrupt status register
$520c0f08 constant SEC_SAES_ICR   \ offset: 0x308 : interrupt clear register

