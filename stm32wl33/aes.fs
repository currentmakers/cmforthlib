\
\ @file aes.fs
\ @brief AES interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief AES_CR register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant AES_AES_CR_EN                                    \ EN: AES IP enable
$00000006 constant AES_AES_CR_DATATYPE                              \ DATATYPE[1:0]: Data type selection
$00000018 constant AES_AES_CR_MODE                                  \ MODE[1:0]: AES operating mode
$00000060 constant AES_AES_CR_CHMOD_1_0                             \ CHMOD[1:0]: AES Chaining Mode selection
$00000080 constant AES_AES_CR_CCFC                                  \ CCFC: Computation Complete Flag Clear
$00000100 constant AES_AES_CR_ERRC                                  \ ERRC: Error clear
$00000200 constant AES_AES_CR_CCFIE                                 \ CCFIE: CCF Flag Interrupt Enable
$00000400 constant AES_AES_CR_ERRIE                                 \ ERRIE: Error Interrupt Enable
$00000800 constant AES_AES_CR_DMAINEN                               \ DMAINEN: DMA Input Enable
$00001000 constant AES_AES_CR_DMAOUTEN                              \ DMAOUTEN: DMA Output Enable
$00006000 constant AES_AES_CR_GCMPH                                 \ GCMPH[1:0]: GCM or CCM Phase selection
$00010000 constant AES_AES_CR_CHMOD_2                               \ CHMOD[2]: Chaining mode selection, bit [2]
$00040000 constant AES_AES_CR_KEYSIZE                               \ KEYSIZE: Key Size selection.
$00f00000 constant AES_AES_CR_NPBLB                                 \ NPBLB: Number of Padding Bytes in Last Block of payload.


\
\ @brief AES_SR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant AES_AES_SR_CCF                                   \ CCF: Computation complete flag
$00000002 constant AES_AES_SR_RDERR                                 \ RDERR: Read error flag
$00000004 constant AES_AES_SR_WRERR                                 \ WRERR: Write error flag
$00000008 constant AES_AES_SR_BUSY                                  \ BUSY: Busy flag


\
\ @brief AES_DINR register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_DINR_DINR                                \ DINR[x+31:x]: One of four 32-bit words of a 128-bit input data block being written into the peripheral


\
\ @brief AES_DOUTR register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_DOUTR_DOUTR                              \ DOUTR[x+31:x]: One of four 32-bit words of a 128-bit output data block being read from the


\
\ @brief AES_KEYRx register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR0_KEY                                \ KEY [((32*x)+31):((32*x)+0)]: Cryptographic key, bits [((32*x)+31):((32*x)+0)]


\
\ @brief AES_KEYRx register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR1_KEY                                \ KEY [((32*x)+31):((32*x)+0)]: Cryptographic key, bits [((32*x)+31):((32*x)+0)]


\
\ @brief AES_KEYRx register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR2_KEY                                \ KEY [((32*x)+31):((32*x)+0)]: Cryptographic key, bits [((32*x)+31):((32*x)+0)]


\
\ @brief AES_KEYRx register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_KEYR3_KEY                                \ KEY [((32*x)+31):((32*x)+0)]: Cryptographic key, bits [((32*x)+31):((32*x)+0)]


\
\ @brief AES_IVRx register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_IVR0_IVI                                 \ IVI [((32*x)+31):((32*x)+0)]: Initialization vector register (LSB IVR[((32*x)+31):((32*x)+0)])


\
\ @brief AES_IVRx register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_IVR1_IVI                                 \ IVI [((32*x)+31):((32*x)+0)]: Initialization vector register (LSB IVR[((32*x)+31):((32*x)+0)])


\
\ @brief AES_IVRx register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_IVR2_IVI                                 \ IVI [((32*x)+31):((32*x)+0)]: Initialization vector register (LSB IVR[((32*x)+31):((32*x)+0)])


\
\ @brief AES_IVRx register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant AES_AES_IVR3_IVI                                 \ IVI [((32*x)+31):((32*x)+0)]: Initialization vector register (LSB IVR[((32*x)+31):((32*x)+0)])


\
\ @brief AES interrupt
\
$48900000 constant AES_AES_CR     \ offset: 0x00 : AES_CR register
$48900004 constant AES_AES_SR     \ offset: 0x04 : AES_SR register
$48900008 constant AES_AES_DINR   \ offset: 0x08 : AES_DINR register
$4890000c constant AES_AES_DOUTR  \ offset: 0x0C : AES_DOUTR register
$48900010 constant AES_AES_KEYR0  \ offset: 0x10 : AES_KEYRx register
$48900014 constant AES_AES_KEYR1  \ offset: 0x14 : AES_KEYRx register
$48900018 constant AES_AES_KEYR2  \ offset: 0x18 : AES_KEYRx register
$4890001c constant AES_AES_KEYR3  \ offset: 0x1C : AES_KEYRx register
$48900020 constant AES_AES_IVR0   \ offset: 0x20 : AES_IVRx register
$48900024 constant AES_AES_IVR1   \ offset: 0x24 : AES_IVRx register
$48900028 constant AES_AES_IVR2   \ offset: 0x28 : AES_IVRx register
$4890002c constant AES_AES_IVR3   \ offset: 0x2C : AES_IVRx register

