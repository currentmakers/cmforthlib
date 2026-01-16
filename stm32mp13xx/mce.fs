\
\ @file mce.fs
\ @brief MCE
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief MCE configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant MCE_MCE_CR_GLOCK                                 \ Global lock Lock the configuration of most MCE registers until next reset. This bit is cleared by default and once set it cannot be reset until MCE reset.
$00000002 constant MCE_MCE_CR_MKLOCK                                \ Master keys lock Lock the master key configurations until next reset. This bit is cleared by default and once set it cannot be reset until MCE reset.


\
\ @brief MCE status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant MCE_MCE_SR_MKVALID                               \ Master key valid
$00000010 constant MCE_MCE_SR_ENCDIS                                \ encryption disabled This bit is set by hardware when the encryption feature is not functional. When ENCDIS is set application must reset MCE peripheral to be able to use the encryption feature again.


\
\ @brief MCE illegal access status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant MCE_MCE_IASR_CAEF                                \ Configuration access error flag This bit is set when an illegal access to any MCE configuration register is detected. Bit is cleared by setting corresponding bit in MCE_IACR register. No additional details on the error is available.


\
\ @brief MCE illegal access clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant MCE_MCE_IACR_CAEF                                \ Configuration access error flag clear Set this bit to clear CAEF bit in MCE_IASR register.


\
\ @brief MCE illegal access interrupt enable register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant MCE_MCE_IAIER_CAEIE                              \ Configuration access error interrupt enable


\
\ @brief MCE privileged configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant MCE_MCE_PRIVCFGR_PRIV                            \ Privileged configuration


\
\ @brief MCE region x configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant MCE_MCE_REGCR_BREN                               \ Base region enable BREN cannot be set if BADDRSTART > BADDREND.
$00008000 constant MCE_MCE_REGCR_ENC                                \ Encrypted region This bit is taken into account only if BREN is set.


\
\ @brief MCE start address register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$ffff0000 constant MCE_MCE_SADDR_BADDSTART                          \ Region address start This bitfield defines the absolute start address of the region on 64 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 16 bits (LSB) and the last 2 bits (MSB) in this register are ignored, and when this register is accessed in read the 2 MSB bits and the 16 LSB bits return zeros (reference value in MCE).


\
\ @brief MCE end address register
\ Address offset: 0x48
\ Reset value: 0x0000FFFF
\

$ffff0000 constant MCE_MCE_EADDR_BADDEND                            \ Region address end This bitfield defines the absolute end address of the region on 64 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 16 bits (LSB) and the last 2 bits (MSB) in this register are ignored, and when this register is accessed in read the 2 MSB bits return zeros and the 16 LSB bits return ones (reference value in MCE).


\
\ @brief MCE master key 0
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000000 constant MCE_MCE_MKEYR0_MKEY                              \ Master key, bits [31:0] This key is used by the MCE block cipher


\
\ @brief MCE master key 1
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000000 constant MCE_MCE_MKEYR1_MKEY                              \ Master key, bits [63:32] This key is used by the MCE block cipher


\
\ @brief MCE master key 2
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000000 constant MCE_MCE_MKEYR2_MKEY                              \ Master key, bits [95:64] This key is used by the MCE block cipher


\
\ @brief MCE master key 3
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000000 constant MCE_MCE_MKEYR3_MKEY                              \ Master key, bits [127:96] This key is used by the MCE block cipher


\
\ @brief MCE version register
\ Address offset: 0x3E8
\ Reset value: 0x3B000102
\

$0000000f constant MCE_MCE_HWCFGR3_CFG1                             \ HW Generic 1 This field returns the generic value aes_core
$000000f0 constant MCE_MCE_HWCFGR3_CFG2                             \ HW Generic 2 This field returns the generic value nk_core
$00000f00 constant MCE_MCE_HWCFGR3_CFG3                             \ HW Generic 3 This field returns the generic value priv_enable
$0000f000 constant MCE_MCE_HWCFGR3_CFG4                             \ HW Generic 4 This field returns the generic value sec_enable
$000f0000 constant MCE_MCE_HWCFGR3_CFG5                             \ HW Generic 5 This field returns the generic value rif_enable
$00f00000 constant MCE_MCE_HWCFGR3_CFG6                             \ HW Generic 6 This field returns the generic value priv_enable_axi
$0f000000 constant MCE_MCE_HWCFGR3_CFG7                             \ HW Generic 7 This field returns the generic value id_size
$f0000000 constant MCE_MCE_HWCFGR3_CFG8                             \ HW Generic 8 This field returns the generic value ooo_enable | interconnect_enable


\
\ @brief MCE version register
\ Address offset: 0x3EC
\ Reset value: 0x11071444
\

$0000000f constant MCE_MCE_HWCFGR2_CFG1                             \ HW Generic 1 This field returns the generic value burst_fifo_depth
$000000f0 constant MCE_MCE_HWCFGR2_CFG2                             \ HW Generic 2 This field returns the generic value info_fifo_depth
$00000f00 constant MCE_MCE_HWCFGR2_CFG3                             \ HW Generic 3 This field returns the generic value mask_fifo_depth
$0000f000 constant MCE_MCE_HWCFGR2_CFG4                             \ HW Generic 4 This field returns the generic value ilac_is_int
$000f0000 constant MCE_MCE_HWCFGR2_CFG5                             \ HW Generic 5 This field returns the generic value nb_dpa_cycles
$00f00000 constant MCE_MCE_HWCFGR2_CFG6                             \ HW Generic 6 This field returns the generic value nb_cctx
$0f000000 constant MCE_MCE_HWCFGR2_CFG7                             \ HW Generic 7 This field returns the generic value nb_mkey
$f0000000 constant MCE_MCE_HWCFGR2_CFG8                             \ HW Generic 8 This field returns the generic value nb_breg


\
\ @brief MCE version register
\ Address offset: 0x3F0
\ Reset value: 0x00001D10
\

$000000ff constant MCE_MCE_HWCFGR1_CFG1                             \ HW Generic 1 This field returns the generic value address_region_lsb_max_bits
$0000ff00 constant MCE_MCE_HWCFGR1_CFG2                             \ HW Generic 2 This field returns the generic value address_region_msb_max_bits
$00ff0000 constant MCE_MCE_HWCFGR1_CFG3                             \ HW Generic 3 This field returns the generic value opbits_gen


\
\ @brief MCE version register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$0000000f constant MCE_MCE_VERR_MINREV                              \ Minor revision This field returns the MCE IP Minor Version.
$000000f0 constant MCE_MCE_VERR_MAJREV                              \ Major revision This field returns the MCE IP Major Version.


\
\ @brief MCE identification register
\ Address offset: 0x3F8
\ Reset value: 0x00170081
\

$00000000 constant MCE_MCE_IPIDR_ID                                 \ Identification Code This field returns the identification code of the MCE IP.


\
\ @brief MCE size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant MCE_MCE_SIDR_SID                                 \ Size Identification Code This field returns the size identification code of the MCE IP as defined below: Bits[31:8] = 0xA3C5DD (fixed code) Bits[7:0] = 0x01 (1KB address decoding)


\
\ @brief MCE
\
$58001000 constant MCE_MCE_CR     \ offset: 0x00 : MCE configuration register
$58001004 constant MCE_MCE_SR     \ offset: 0x04 : MCE status register
$58001008 constant MCE_MCE_IASR   \ offset: 0x08 : MCE illegal access status register
$5800100c constant MCE_MCE_IACR   \ offset: 0x0C : MCE illegal access clear register
$58001010 constant MCE_MCE_IAIER  \ offset: 0x10 : MCE illegal access interrupt enable register
$5800101c constant MCE_MCE_PRIVCFGR  \ offset: 0x1C : MCE privileged configuration register
$58001040 constant MCE_MCE_REGCR  \ offset: 0x40 : MCE region x configuration register
$58001044 constant MCE_MCE_SADDR  \ offset: 0x44 : MCE start address register
$58001048 constant MCE_MCE_EADDR  \ offset: 0x48 : MCE end address register
$58001200 constant MCE_MCE_MKEYR0  \ offset: 0x200 : MCE master key 0
$58001204 constant MCE_MCE_MKEYR1  \ offset: 0x204 : MCE master key 1
$58001208 constant MCE_MCE_MKEYR2  \ offset: 0x208 : MCE master key 2
$5800120c constant MCE_MCE_MKEYR3  \ offset: 0x20C : MCE master key 3
$580013e8 constant MCE_MCE_HWCFGR3  \ offset: 0x3E8 : MCE version register
$580013ec constant MCE_MCE_HWCFGR2  \ offset: 0x3EC : MCE version register
$580013f0 constant MCE_MCE_HWCFGR1  \ offset: 0x3F0 : MCE version register
$580013f4 constant MCE_MCE_VERR   \ offset: 0x3F4 : MCE version register
$580013f8 constant MCE_MCE_IPIDR  \ offset: 0x3F8 : MCE identification register
$580013fc constant MCE_MCE_SIDR   \ offset: 0x3FC : MCE size ID register

