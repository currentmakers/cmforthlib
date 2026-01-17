\
\ @file mce.fs
\ @brief MCE
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] MCE_DEF

  [ifdef] MCE_MCE_CR_DEF
    \
    \ @brief MCE configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant MCE_GLOCK                      \ [0x00] Global lock Lock the configuration of most MCE registers until next reset. This bit is cleared by default and once set it cannot be reset until MCE reset.
    $01 constant MCE_MKLOCK                     \ [0x01] Master keys lock Lock the master key configurations until next reset. This bit is cleared by default and once set it cannot be reset until MCE reset.
  [then]


  [ifdef] MCE_MCE_SR_DEF
    \
    \ @brief MCE status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKVALID                    \ [0x00] Master key valid
    $04 constant MCE_ENCDIS                     \ [0x04] encryption disabled This bit is set by hardware when the encryption feature is not functional. When ENCDIS is set application must reset MCE peripheral to be able to use the encryption feature again.
  [then]


  [ifdef] MCE_MCE_IASR_DEF
    \
    \ @brief MCE illegal access status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant MCE_CAEF                       \ [0x00] Configuration access error flag This bit is set when an illegal access to any MCE configuration register is detected. Bit is cleared by setting corresponding bit in MCE_IACR register. No additional details on the error is available.
  [then]


  [ifdef] MCE_MCE_IACR_DEF
    \
    \ @brief MCE illegal access clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_CAEF                       \ [0x00] Configuration access error flag clear Set this bit to clear CAEF bit in MCE_IASR register.
  [then]


  [ifdef] MCE_MCE_IAIER_DEF
    \
    \ @brief MCE illegal access interrupt enable register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant MCE_CAEIE                      \ [0x00] Configuration access error interrupt enable
  [then]


  [ifdef] MCE_MCE_PRIVCFGR_DEF
    \
    \ @brief MCE privileged configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_PRIV                       \ [0x00] Privileged configuration
  [then]


  [ifdef] MCE_MCE_REGCR_DEF
    \
    \ @brief MCE region x configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant MCE_BREN                       \ [0x00] Base region enable BREN cannot be set if BADDRSTART > BADDREND.
    $0f constant MCE_ENC                        \ [0x0f] Encrypted region This bit is taken into account only if BREN is set.
  [then]


  [ifdef] MCE_MCE_SADDR_DEF
    \
    \ @brief MCE start address register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $10 constant MCE_BADDSTART                  \ [0x10 : 16] Region address start This bitfield defines the absolute start address of the region on 64 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 16 bits (LSB) and the last 2 bits (MSB) in this register are ignored, and when this register is accessed in read the 2 MSB bits and the 16 LSB bits return zeros (reference value in MCE).
  [then]


  [ifdef] MCE_MCE_EADDR_DEF
    \
    \ @brief MCE end address register
    \ Address offset: 0x48
    \ Reset value: 0x0000FFFF
    \
    $10 constant MCE_BADDEND                    \ [0x10 : 16] Region address end This bitfield defines the absolute end address of the region on 64 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 16 bits (LSB) and the last 2 bits (MSB) in this register are ignored, and when this register is accessed in read the 2 MSB bits return zeros and the 16 LSB bits return ones (reference value in MCE).
  [then]


  [ifdef] MCE_MCE_MKEYR0_DEF
    \
    \ @brief MCE master key 0
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY                       \ [0x00 : 32] Master key, bits [31:0] This key is used by the MCE block cipher
  [then]


  [ifdef] MCE_MCE_MKEYR1_DEF
    \
    \ @brief MCE master key 1
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY                       \ [0x00 : 32] Master key, bits [63:32] This key is used by the MCE block cipher
  [then]


  [ifdef] MCE_MCE_MKEYR2_DEF
    \
    \ @brief MCE master key 2
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY                       \ [0x00 : 32] Master key, bits [95:64] This key is used by the MCE block cipher
  [then]


  [ifdef] MCE_MCE_MKEYR3_DEF
    \
    \ @brief MCE master key 3
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY                       \ [0x00 : 32] Master key, bits [127:96] This key is used by the MCE block cipher
  [then]


  [ifdef] MCE_MCE_HWCFGR3_DEF
    \
    \ @brief MCE version register
    \ Address offset: 0x3E8
    \ Reset value: 0x3B000102
    \
    $00 constant MCE_CFG1                       \ [0x00 : 4] HW Generic 1 This field returns the generic value aes_core
    $04 constant MCE_CFG2                       \ [0x04 : 4] HW Generic 2 This field returns the generic value nk_core
    $08 constant MCE_CFG3                       \ [0x08 : 4] HW Generic 3 This field returns the generic value priv_enable
    $0c constant MCE_CFG4                       \ [0x0c : 4] HW Generic 4 This field returns the generic value sec_enable
    $10 constant MCE_CFG5                       \ [0x10 : 4] HW Generic 5 This field returns the generic value rif_enable
    $14 constant MCE_CFG6                       \ [0x14 : 4] HW Generic 6 This field returns the generic value priv_enable_axi
    $18 constant MCE_CFG7                       \ [0x18 : 4] HW Generic 7 This field returns the generic value id_size
    $1c constant MCE_CFG8                       \ [0x1c : 4] HW Generic 8 This field returns the generic value ooo_enable | interconnect_enable
  [then]


  [ifdef] MCE_MCE_HWCFGR2_DEF
    \
    \ @brief MCE version register
    \ Address offset: 0x3EC
    \ Reset value: 0x11071444
    \
    $00 constant MCE_CFG1                       \ [0x00 : 4] HW Generic 1 This field returns the generic value burst_fifo_depth
    $04 constant MCE_CFG2                       \ [0x04 : 4] HW Generic 2 This field returns the generic value info_fifo_depth
    $08 constant MCE_CFG3                       \ [0x08 : 4] HW Generic 3 This field returns the generic value mask_fifo_depth
    $0c constant MCE_CFG4                       \ [0x0c : 4] HW Generic 4 This field returns the generic value ilac_is_int
    $10 constant MCE_CFG5                       \ [0x10 : 4] HW Generic 5 This field returns the generic value nb_dpa_cycles
    $14 constant MCE_CFG6                       \ [0x14 : 4] HW Generic 6 This field returns the generic value nb_cctx
    $18 constant MCE_CFG7                       \ [0x18 : 4] HW Generic 7 This field returns the generic value nb_mkey
    $1c constant MCE_CFG8                       \ [0x1c : 4] HW Generic 8 This field returns the generic value nb_breg
  [then]


  [ifdef] MCE_MCE_HWCFGR1_DEF
    \
    \ @brief MCE version register
    \ Address offset: 0x3F0
    \ Reset value: 0x00001D10
    \
    $00 constant MCE_CFG1                       \ [0x00 : 8] HW Generic 1 This field returns the generic value address_region_lsb_max_bits
    $08 constant MCE_CFG2                       \ [0x08 : 8] HW Generic 2 This field returns the generic value address_region_msb_max_bits
    $10 constant MCE_CFG3                       \ [0x10 : 8] HW Generic 3 This field returns the generic value opbits_gen
  [then]


  [ifdef] MCE_MCE_VERR_DEF
    \
    \ @brief MCE version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant MCE_MINREV                     \ [0x00 : 4] Minor revision This field returns the MCE IP Minor Version.
    $04 constant MCE_MAJREV                     \ [0x04 : 4] Major revision This field returns the MCE IP Major Version.
  [then]


  [ifdef] MCE_MCE_IPIDR_DEF
    \
    \ @brief MCE identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00170081
    \
    $00 constant MCE_ID                         \ [0x00 : 32] Identification Code This field returns the identification code of the MCE IP.
  [then]


  [ifdef] MCE_MCE_SIDR_DEF
    \
    \ @brief MCE size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant MCE_SID                        \ [0x00 : 32] Size Identification Code This field returns the size identification code of the MCE IP as defined below: Bits[31:8] = 0xA3C5DD (fixed code) Bits[7:0] = 0x01 (1KB address decoding)
  [then]

  \
  \ @brief MCE
  \
  $00 constant MCE_MCE_CR               \ MCE configuration register
  $04 constant MCE_MCE_SR               \ MCE status register
  $08 constant MCE_MCE_IASR             \ MCE illegal access status register
  $0C constant MCE_MCE_IACR             \ MCE illegal access clear register
  $10 constant MCE_MCE_IAIER            \ MCE illegal access interrupt enable register
  $1C constant MCE_MCE_PRIVCFGR         \ MCE privileged configuration register
  $40 constant MCE_MCE_REGCR            \ MCE region x configuration register
  $44 constant MCE_MCE_SADDR            \ MCE start address register
  $48 constant MCE_MCE_EADDR            \ MCE end address register
  $200 constant MCE_MCE_MKEYR0          \ MCE master key 0
  $204 constant MCE_MCE_MKEYR1          \ MCE master key 1
  $208 constant MCE_MCE_MKEYR2          \ MCE master key 2
  $20C constant MCE_MCE_MKEYR3          \ MCE master key 3
  $3E8 constant MCE_MCE_HWCFGR3         \ MCE version register
  $3EC constant MCE_MCE_HWCFGR2         \ MCE version register
  $3F0 constant MCE_MCE_HWCFGR1         \ MCE version register
  $3F4 constant MCE_MCE_VERR            \ MCE version register
  $3F8 constant MCE_MCE_IPIDR           \ MCE identification register
  $3FC constant MCE_MCE_SIDR            \ MCE size ID register

: MCE_DEF ; [then]
