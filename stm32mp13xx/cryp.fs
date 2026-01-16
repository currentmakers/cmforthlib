\
\ @file cryp.fs
\ @brief CRYP
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Algorithm Direction Writing ALGODIR bit while BUSYÂ =Â 1 has no effect.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000004 constant CRYP_CRYP_CR_ALGODIR                             \ Algorithm Direction Writing ALGODIR bit while BUSYÂ =Â 1 has no effect.
$00000038 constant CRYP_CRYP_CR_ALGOMODE                            \ Algorithm mode Below definition includes the bit 19: Writing ALGOMODE bits while BUSYÂ =Â 1 has no effect. Others: Reserved, must no be used Changing ALGOMODE from AES algorithm to DES or TDES (or the reverse) clears KEYVALID. KEYVALID is not cleared when the algorithm type is kept between two ALGOMODE, that is between TDES-ECB and TDES-CBC or between AES-ECB and AES_CTR.
$000000c0 constant CRYP_CRYP_CR_DATATYPE                            \ Data Type selection This bitfield defines the format of data written in CRYP_DIN or read from CRYP_DOUT registers. For more details refer to registers and data swapping). Writing DATATYPE bits while BUSYÂ =Â 1 has no effect.
$00000300 constant CRYP_CRYP_CR_KEYSIZE                             \ Key size selection (AES mode only) This bitfield defines the bit-length of the key used for the AES cryptographic core. This bitfield is 'donât careâ in the DES or TDES modes. Writing KEYSIZE bits while BUSYÂ =Â 1 has no effect. When KEYSIZE is changed KEYVALID is cleared.
$00004000 constant CRYP_CRYP_CR_FFLUSH                              \ CRYP FIFO Flush When CRYPEN = 0, writing this bit to 1 flushes the IN and OUT FIFOs (that is read and write pointers of the FIFOs are reset). Writing this bit to 0 has no effect. When CRYPEN = 1, writing this bit to 0 or 1 has no effect. Reading this bit always returns 0. FFLUSH bit has to be set only when BUSYÂ =Â 0. If not, the FIFO is flushed, but the block being processed may be pushed into the output FIFO just after the flush operation, resulting in a non-empty FIFO condition.
$00008000 constant CRYP_CRYP_CR_CRYPEN                              \ CRYP processor Enable This bit is automatically cleared by hardware when the key preparation process ends (ALGOMODEÂ =Â 0111) or after GCM/GMAC or CCM Initialization phase.
$00030000 constant CRYP_CRYP_CR_GCM_CCMPH                           \ GCM or CCM Phase selection This bitfield has no effect if GCM, GMAC or CCM algorithm is not selected in ALGOMODE field. Writing to GCM_CCMPH bits while BUSYÂ =Â 1 has no effect.
$00080000 constant CRYP_CRYP_CR_ALGOMODE3                           \ Algorithm mode Below definition includes the bit 19: Writing ALGOMODE bits while BUSYÂ =Â 1 has no effect. Others: Reserved, must no be used Changing ALGOMODE from AES algorithm to DES or TDES (or the reverse) clears KEYVALID. KEYVALID is not cleared when the algorithm type is kept between two ALGOMODE, that is between TDES-ECB and TDES-CBC or between AES-ECB and AES_CTR.
$00f00000 constant CRYP_CRYP_CR_NPBLB                               \ Number of Padding Bytes in Last Block of payload. This padding information must be filled by software before processing the last block of GCM payload encryption or CCM payload decryption, otherwise authentication tag computation is incorrect. ... Writing NPBLB bits while BUSYÂ =Â 1 has no effect.
$01000000 constant CRYP_CRYP_CR_KMOD0                               \ Key mode selection This bitfield defines how the CRYP key is used by the application: Others: Reserved, must not be used. When KMOD[1:0]Â =Â 10 the selected key value is available in the key registers when KEYVALID is set in SAES_SR register. Otherwise the key error flag KERF is set in CRYP_SR register. KMOD[1:0] must be set to 10 only when KEYSIZE is correct and a shared key decryption sequence has been successfully completed by the SAES co-processor. Otherwise the key error flag KERF is set in CRYP_SR. Writing to KMOD bits while BUSYÂ =Â 1 has no effect.
$02000000 constant CRYP_CRYP_CR_KMOD1                               \ Key mode selection This bitfield defines how the CRYP key is used by the application: Others: Reserved, must not be used. When KMOD[1:0]Â =Â 10 the selected key value is available in the key registers when KEYVALID is set in SAES_SR register. Otherwise the key error flag KERF is set in CRYP_SR register. KMOD[1:0] must be set to 10 only when KEYSIZE is correct and a shared key decryption sequence has been successfully completed by the SAES co-processor. Otherwise the key error flag KERF is set in CRYP_SR. Writing to KMOD bits while BUSYÂ =Â 1 has no effect.
$80000000 constant CRYP_CRYP_CR_IPRST                               \ CRYP software reset Setting the bit resets the CRYP processor, resetting all registers to their default values except the IPRST bit itself. This bit must be kept cleared while writing any configuration registers.


\
\ @brief Input FIFO empty flag
\ Address offset: 0x04
\ Reset value: 0x00000003
\

$00000001 constant CRYP_CRYP_SR_IFEM                                \ Input FIFO empty flag
$00000002 constant CRYP_CRYP_SR_IFNF                                \ Input FIFO not full flag
$00000004 constant CRYP_CRYP_SR_OFNE                                \ Output FIFO not empty flag
$00000008 constant CRYP_CRYP_SR_OFFU                                \ Output FIFO full flag
$00000010 constant CRYP_CRYP_SR_BUSY                                \ Busy bit either that the CRYP core is disabled (CRYPENÂ =Â 0 in the CRYP_CR register) and the last processing has completed, or the CRYP core is waiting for enough data in the input FIFO or enough free space in the output FIFO (that is in each case at least 2 words in the DES, 4 words in the AES).
$00000040 constant CRYP_CRYP_SR_KERF                                \ Key error flag KERF is a read-only bit. It is set by hardware when key information failed to load into key registers. KERF is set if one of the below errors occurred: The user application did not write the key registers in the correct sequence (refer to for details). The CRYP failed to load the AES key shared by SAES peripheral (KMODÂ =Â 10). KMODÂ =Â 10 with ALGOMODE selecting either DES or TDES algorithm. KERF must be cleared by the application, for example through IPRST bit of CRYP_CR, otherwise KEYVALID cannot be set.
$00000080 constant CRYP_CRYP_SR_KEYVALID                            \ Key valid KEYVALID is a read-only bit. It is set by hardware when the expected amount of key information has been loaded in CRYP_KEYx key registers. It is valid for both AES and DES/TDES algorithms. When KMODÂ =Â 00, the use application must write the key registers in the correct sequence, otherwise KERF flag is set and KEYVALID remains at zero. When KMODÂ =Â 10 (AES Shared key mode), the shared key is loaded successfully from SAES to CRYP when KEYVALID is set. When an error occurs KERF flag is set in CRYP_SR and KEYVALID remains at zero.


\
\ @brief CRYP data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_DIN_DATAIN                             \ Data Input On read FIFO is popped (last written value is returned), and its value is returned if CRYPENÂ =Â 0. If CRYPENÂ =Â 1 DATAIN register returns an undefined value. On write current register content is pushed inside the FIFO.


\
\ @brief CRYP data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_DOUT_DATAOUT                           \ Data Output On read returns output FIFO content (pointed to by read pointer), else returns an undefined value. On write, no effect.


\
\ @brief DMA Input Enable When this bit is set, DMA requests are automatically generated by the peripheral during the input data phase.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CRYP_CRYP_DMACR_DIEN                             \ DMA Input Enable When this bit is set, DMA requests are automatically generated by the peripheral during the input data phase.
$00000002 constant CRYP_CRYP_DMACR_DOEN                             \ DMA Output Enable When this bit is set, DMA requests are automatically generated by the peripheral during the output data phase.


\
\ @brief CRYP interrupt mask set/clear register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CRYP_CRYP_IMSCR_INIM                             \ Input FIFO service interrupt mask
$00000002 constant CRYP_CRYP_IMSCR_OUTIM                            \ Output FIFO service interrupt mask


\
\ @brief CRYP raw interrupt status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant CRYP_CRYP_RISR_INRIS                             \ Input FIFO service raw interrupt status This bit gives the input FIFO interrupt information without taking CRYP_IMSCR corresponding mask into account.
$00000002 constant CRYP_CRYP_RISR_OUTRIS                            \ Output FIFO service raw interrupt status This bit gives the output FIFO interrupt information without taking CRYP_IMSCR corresponding mask into account.


\
\ @brief CRYP masked interrupt status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant CRYP_CRYP_MISR_INMIS                             \ Input FIFO service masked interrupt status This bit gives the input FIFO interrupt information without taking into account the corresponding CRYP_IMSCR mask.
$00000002 constant CRYP_CRYP_MISR_OUTMIS                            \ Output FIFO service masked interrupt status This bit gives the output FIFO interrupt information without taking into account the corresponding CRYP_IMSCR mask.


\
\ @brief CRYP key register 0L
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K0LR_K                                 \ Key bit x (xÂ =Â  255 to 224) This write-only bitfield contains the bits [255:224] of the AES encryption or decryption key, depending on the operating mode. This register is not used in DES/TDES mode.


\
\ @brief CRYP key register 0R
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K0RR_K                                 \ Key bit x (xÂ =Â  223 to 192) This write-only bitfield contains the bits [223:192] of the AES encryption or decryption key, depending on the operating mode. This register is not used in DES/TDES mode.


\
\ @brief CRYP key register 1L
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K1LR_K                                 \ Key bit x (xÂ =Â  191 to 160) This write-only bitfield contains the bits [191:160] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [64:33] of the key K1, with parity bits unused.


\
\ @brief CRYP key register 1R
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K1RR_K                                 \ Key bit x (xÂ =Â  159 to 128) This write-only bitfield contains the bits [159:128] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [32:1] of the key K1, with parity bits unused.


\
\ @brief CRYP key register 2L
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K2LR_K                                 \ Key bit x (xÂ =Â  127 to 96) This write-only bitfield contains the bits [127:96] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [64:33] of the key K2, with parity bits unused.


\
\ @brief CRYP key register 2R
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K2RR_K                                 \ Key bit x (xÂ =Â  95 to 64) This write-only bitfield contains the bits [95:64] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [32:1] of the key K2, with parity bits unused.


\
\ @brief CRYP key register 3L
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K3LR_K                                 \ Key bit x (xÂ =Â  63 to 32) This write-only bitfield contains the bits [63:32] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [64:33] of the key K3, with parity bits unused.


\
\ @brief CRYP key register 3R
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K3RR_K                                 \ Key bit x (xÂ =Â  31 to 0) This write-only bitfield contains the bits [31:0] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [32:1] of the key K3, with parity bits unused.


\
\ @brief CRYP initialization vector register 0L
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_IV0LR_IV                               \ Initialization vector bit x (xÂ =Â  127 to 96) This bitfield stores the initialization vector bits [127:96] for AES chaining modes other than ECB. In DES/TDES mode it corresponds to IV bits [63:32]. IV registers are updated by the core after each computation round of the DES/TDES or AES core.


\
\ @brief CRYP initialization vector register 0R
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_IV0RR_IV                               \ Initialization vector bit x (xÂ =Â  95 to 64) This bitfield stores the initialization vector bits [95:64] for AES chaining modes other than ECB. In DES/TDES mode it corresponds to IV bits [31:0]. IV registers are updated by the core after each computation round of the DES/TDES or AES core.


\
\ @brief CRYP initialization vector register 1L
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_IV1LR_IV                               \ Initialization vector bit x (xÂ =Â  63 to 32) This bitfield stores the initialization vector bits [63:32] for AES chaining modes other than ECB. This register is not used in DES mode. IV registers are updated by the core after each computation round of the AES core.


\
\ @brief CRYP initialization vector register 1R
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_IV1RR_IV                               \ Initialization vector bit x (xÂ =Â  31 to 16) This bitfield stores the initialization vector bits [31:0] for AES chaining modes other than ECB. This register is not used in DES mode. IV registers are updated by the core after each computation round of the AES core.


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM0R_CSGCMCCM0                   \ CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM1R_CSGCMCCM1                   \ CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM2R_CSGCMCCM2                   \ CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM3R_CSGCMCCM3                   \ CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM4R_CSGCMCCM4                   \ CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM5R_CSGCMCCM5                   \ CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM6R_CSGCMCCM6                   \ CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM7R_CSGCMCCM7                   \ CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM0R_CSGCM0                         \ CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM1R_CSGCM1                         \ CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM2R_CSGCM2                         \ CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM3R_CSGCM3                         \ CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM4R_CSGCM4                         \ CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM5R_CSGCM5                         \ CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM6R_CSGCM6                         \ CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM7R_CSGCM7                         \ CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated


\
\ @brief HW Generic 1 This field returns the tdes_impl generic value (0x1).
\ Address offset: 0x3F0
\ Reset value: 0x00000131
\

$0000000f constant CRYP_CRYP_HWCFGR_CFG1                            \ HW Generic 1 This field returns the tdes_impl generic value (0x1).
$000000f0 constant CRYP_CRYP_HWCFGR_CFG2                            \ HW Generic 2 This field returns the aes_impl generic value (0x3).
$00000f00 constant CRYP_CRYP_HWCFGR_CFG3                            \ HW Generic 3 This field returns the dma_version generic value (0x1).
$0000f000 constant CRYP_CRYP_HWCFGR_CFG4                            \ HW Generic 4 Reserved, must be kept at reset value.


\
\ @brief CRYP processor minor version This field returns the CRYP processor minor version.
\ Address offset: 0x3F4
\ Reset value: 0x00000023
\

$0000000f constant CRYP_CRYP_VERR_MINVER                            \ CRYP processor minor version This field returns the CRYP processor minor version.
$000000f0 constant CRYP_CRYP_VERR_MAJVER                            \ CRYP processor major version This field returns the CRYP processor major version.


\
\ @brief Identification Code This field returns the identification code of the CRYP processor.
\ Address offset: 0x3F8
\ Reset value: 0x00170011
\

$00000000 constant CRYP_CRYP_IPIDR_ID                               \ Identification Code This field returns the identification code of the CRYP processor.


\
\ @brief Size identification code This field returns the size identification code of the CRYP processor as defined below: SID[31:8]Â =Â 0xA3C5DD (fixed code) SID[7:0]Â =Â 0x01 (1-Kbyte address decoding)
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant CRYP_CRYP_SIDR_SID                               \ Size identification code This field returns the size identification code of the CRYP processor as defined below: SID[31:8]Â =Â 0xA3C5DD (fixed code) SID[7:0]Â =Â 0x01 (1-Kbyte address decoding)


\
\ @brief CRYP
\
$54002000 constant CRYP_CRYP_CR   \ offset: 0x00 : Algorithm Direction Writing ALGODIR bit while BUSYÂ =Â 1 has no effect.
$54002004 constant CRYP_CRYP_SR   \ offset: 0x04 : Input FIFO empty flag
$54002008 constant CRYP_CRYP_DIN  \ offset: 0x08 : CRYP data input register
$5400200c constant CRYP_CRYP_DOUT  \ offset: 0x0C : CRYP data output register
$54002010 constant CRYP_CRYP_DMACR  \ offset: 0x10 : DMA Input Enable When this bit is set, DMA requests are automatically generated by the peripheral during the input data phase.
$54002014 constant CRYP_CRYP_IMSCR  \ offset: 0x14 : CRYP interrupt mask set/clear register
$54002018 constant CRYP_CRYP_RISR  \ offset: 0x18 : CRYP raw interrupt status register
$5400201c constant CRYP_CRYP_MISR  \ offset: 0x1C : CRYP masked interrupt status register
$54002020 constant CRYP_CRYP_K0LR  \ offset: 0x20 : CRYP key register 0L
$54002024 constant CRYP_CRYP_K0RR  \ offset: 0x24 : CRYP key register 0R
$54002028 constant CRYP_CRYP_K1LR  \ offset: 0x28 : CRYP key register 1L
$5400202c constant CRYP_CRYP_K1RR  \ offset: 0x2C : CRYP key register 1R
$54002030 constant CRYP_CRYP_K2LR  \ offset: 0x30 : CRYP key register 2L
$54002034 constant CRYP_CRYP_K2RR  \ offset: 0x34 : CRYP key register 2R
$54002038 constant CRYP_CRYP_K3LR  \ offset: 0x38 : CRYP key register 3L
$5400203c constant CRYP_CRYP_K3RR  \ offset: 0x3C : CRYP key register 3R
$54002040 constant CRYP_CRYP_IV0LR  \ offset: 0x40 : CRYP initialization vector register 0L
$54002044 constant CRYP_CRYP_IV0RR  \ offset: 0x44 : CRYP initialization vector register 0R
$54002048 constant CRYP_CRYP_IV1LR  \ offset: 0x48 : CRYP initialization vector register 1L
$5400204c constant CRYP_CRYP_IV1RR  \ offset: 0x4C : CRYP initialization vector register 1R
$54002050 constant CRYP_CRYP_CSGCMCCM0R  \ offset: 0x50 : CRYP context swap GCM-CCM registers
$54002054 constant CRYP_CRYP_CSGCMCCM1R  \ offset: 0x54 : CRYP context swap GCM-CCM registers
$54002058 constant CRYP_CRYP_CSGCMCCM2R  \ offset: 0x58 : CRYP context swap GCM-CCM registers
$5400205c constant CRYP_CRYP_CSGCMCCM3R  \ offset: 0x5C : CRYP context swap GCM-CCM registers
$54002060 constant CRYP_CRYP_CSGCMCCM4R  \ offset: 0x60 : CRYP context swap GCM-CCM registers
$54002064 constant CRYP_CRYP_CSGCMCCM5R  \ offset: 0x64 : CRYP context swap GCM-CCM registers
$54002068 constant CRYP_CRYP_CSGCMCCM6R  \ offset: 0x68 : CRYP context swap GCM-CCM registers
$5400206c constant CRYP_CRYP_CSGCMCCM7R  \ offset: 0x6C : CRYP context swap GCM-CCM registers
$54002070 constant CRYP_CRYP_CSGCM0R  \ offset: 0x70 : CRYP context swap GCM registers
$54002074 constant CRYP_CRYP_CSGCM1R  \ offset: 0x74 : CRYP context swap GCM registers
$54002078 constant CRYP_CRYP_CSGCM2R  \ offset: 0x78 : CRYP context swap GCM registers
$5400207c constant CRYP_CRYP_CSGCM3R  \ offset: 0x7C : CRYP context swap GCM registers
$54002080 constant CRYP_CRYP_CSGCM4R  \ offset: 0x80 : CRYP context swap GCM registers
$54002084 constant CRYP_CRYP_CSGCM5R  \ offset: 0x84 : CRYP context swap GCM registers
$54002088 constant CRYP_CRYP_CSGCM6R  \ offset: 0x88 : CRYP context swap GCM registers
$5400208c constant CRYP_CRYP_CSGCM7R  \ offset: 0x8C : CRYP context swap GCM registers
$540023f0 constant CRYP_CRYP_HWCFGR  \ offset: 0x3F0 : HW Generic 1 This field returns the tdes_impl generic value (0x1).
$540023f4 constant CRYP_CRYP_VERR  \ offset: 0x3F4 : CRYP processor minor version This field returns the CRYP processor minor version.
$540023f8 constant CRYP_CRYP_IPIDR  \ offset: 0x3F8 : Identification Code This field returns the identification code of the CRYP processor.
$540023fc constant CRYP_CRYP_SIDR  \ offset: 0x3FC : Size identification code This field returns the size identification code of the CRYP processor as defined below: SID[31:8]Â =Â 0xA3C5DD (fixed code) SID[7:0]Â =Â 0x01 (1-Kbyte address decoding)

