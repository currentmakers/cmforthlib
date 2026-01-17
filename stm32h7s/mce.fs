\
\ @file mce.fs
\ @brief Memory cipher engine
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
    $01 constant MCE_MKLOCK                     \ [0x01] Master keys lock Lock the master key configurations until next reset. This bit is cleared by default and once set it cannot be reset until MCE reset. Effect of this bit depends on the number of master keys. See Section 35.3: MCE implementation for details.
  [then]


  [ifdef] MCE_MCE_SR_DEF
    \
    \ @brief MCE status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKVALID                    \ [0x00] Master key valid
    $02 constant MCE_FMKVALID                   \ [0x02] Fast master key valid This bit is reserved when fast master key is not present in the MCE instance. See Section 35.3: MCE implementation for detail.
    $04 constant MCE_ENCDIS                     \ [0x04] encryption disabled This bit is set by hardware when the encryption feature is not functional. When ENCDIS is set application must reset MCE peripheral to be able to use the encryption feature again.
  [then]


  [ifdef] MCE_MCE_IASR_DEF
    \
    \ @brief MCE illegal access status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant MCE_CAEF                       \ [0x00] Configuration access error flag This bit is set when an illegal access to any MCE configuration register is detected. Bit is cleared by setting corresponding bit in MCE_IACR register. No additional details on the error is available.
    $01 constant MCE_IAEF                       \ [0x01] Illegal access error flag This bit is set when an illegal access is detected on the system bus. More details on the error can be found in MCE_IAESR and MCE_IADDR registers. This bit is cleared by setting corresponding bit in MCE_IACR register.
  [then]


  [ifdef] MCE_MCE_IACR_DEF
    \
    \ @brief MCE illegal access clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_CAEF                       \ [0x00] Configuration access error flag clear Set this bit to clear CAEF bit in MCE_IASR register.
    $01 constant MCE_IAEF                       \ [0x01] Illegal access error flag clear Set this bit to clear IAEF bit in MCE_IASR register. Clearing IAEF bit permits to capture new error information in MCE_IAESR and MCE_IADDR registers. Note that clearing this bit does not clear RISAB_IADDR register.
  [then]


  [ifdef] MCE_MCE_IAIER_DEF
    \
    \ @brief MCE illegal access interrupt enable register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant MCE_CAEIE                      \ [0x00] Configuration access error interrupt enable
    $01 constant MCE_IAEIE                      \ [0x01] Illegal access error interrupt enable
  [then]


  [ifdef] MCE_MCE_PRIVCFGR_DEF
    \
    \ @brief MCE privileged configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_PRIV                       \ [0x00] Privileged configuration
  [then]


  [ifdef] MCE_MCE_IAESR_DEF
    \
    \ @brief MCE illegal access error status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $04 constant MCE_IAPRIV                     \ [0x04] Illegal access privilege When IAEF bit is set in MCE_IASR register IAPRIV bit captures the privileged state of the master that issued the illegal access detected on the AXI system bus.
    $07 constant MCE_IANRW                      \ [0x07] Illegal access read/write When IAEF bit is set in MCE_IASR register IANRW bit captures the access type of the illegal access detected.
  [then]


  [ifdef] MCE_MCE_IADDR_DEF
    \
    \ @brief MCE illegal address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant MCE_IADD                       \ [0x00 : 32] Illegal address When IAEF bit is set in MCE_IASR register IADD bitfield captures the 32-bit bus address of the erroneous access. Additional information can be found in MCE_IAESR register.
  [then]


  [ifdef] MCE_MCE_REGCR1_DEF
    \
    \ @brief MCE region 1 configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant MCE_BREN                       \ [0x00] Base region enable BREN cannot be set if BADDRSTART > BADDREND.
    $09 constant MCE_CTXID                      \ [0x09 : 2] Context ID This bitfield defines the cryptographic context used by the cipher engine assigned to this region. If ENC=00 bitfield CTXID is ignored. If BREN is set write to this bitfield is ignored. If ENC=01 the key stored in MCE_CC1KEYR is used by the stream cipher. The nonce in MCE_CC1NRx registers and the version in MCE_CC1CR register are also used. If ENC=01 the key stored in MCE_CC2KEYR is used by the stream cipher. The nonce in MCE_CC2NRx registers and the version in MCE_CC2CR register are also used.
    $0e constant MCE_ENC                        \ [0x0e : 2] Encrypted region Those bits are taken into account only if BREN is set and if the corresponding encryption feature is available in the MCE instance (see Section 35.3: MCE implementation). Write to those bits is ignored if BREN is set.
    $10 constant MCE_PRIV                       \ [0x10] Privileged region This bit is taken into account only if BREN is set.
  [then]


  [ifdef] MCE_MCE_SADDR1_DEF
    \
    \ @brief MCE start address for region 1 register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $0c constant MCE_BADDSTART                  \ [0x0c : 20] Region address start This bitfield defines the absolute start address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits and the 12 LSB bits return zeros (reference value in MCE).
  [then]


  [ifdef] MCE_MCE_EADDR1_DEF
    \
    \ @brief MCE end address for region 1 register
    \ Address offset: 0x48
    \ Reset value: 0x00000FFF
    \
    $0c constant MCE_BADDEND                    \ [0x0c : 20] Region address end This bitfield defines the absolute end address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits return zeros and the 12 LSB bits return ones (reference value in MCE).
  [then]


  [ifdef] MCE_MCE_ATTR1_DEF
    \
    \ @brief MCE attribute for region 1 register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $10 constant MCE_WREN                       \ [0x10] Write enable This bit is taken into account only if BREN is set.
  [then]


  [ifdef] MCE_MCE_REGCR2_DEF
    \
    \ @brief MCE region 2 configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant MCE_BREN                       \ [0x00] Base region enable BREN cannot be set if BADDRSTART > BADDREND.
    $09 constant MCE_CTXID                      \ [0x09 : 2] Context ID This bitfield defines the cryptographic context used by the cipher engine assigned to this region. If ENC=00 bitfield CTXID is ignored. If BREN is set write to this bitfield is ignored. If ENC=01 the key stored in MCE_CC1KEYR is used by the stream cipher. The nonce in MCE_CC1NRx registers and the version in MCE_CC1CR register are also used. If ENC=01 the key stored in MCE_CC2KEYR is used by the stream cipher. The nonce in MCE_CC2NRx registers and the version in MCE_CC2CR register are also used.
    $0e constant MCE_ENC                        \ [0x0e : 2] Encrypted region Those bits are taken into account only if BREN is set and if the corresponding encryption feature is available in the MCE instance (see Section 35.3: MCE implementation). Write to those bits is ignored if BREN is set.
    $10 constant MCE_PRIV                       \ [0x10] Privileged region This bit is taken into account only if BREN is set.
  [then]


  [ifdef] MCE_MCE_SADDR2_DEF
    \
    \ @brief MCE start address for region 2 register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $0c constant MCE_BADDSTART                  \ [0x0c : 20] Region address start This bitfield defines the absolute start address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits and the 12 LSB bits return zeros (reference value in MCE).
  [then]


  [ifdef] MCE_MCE_EADDR2_DEF
    \
    \ @brief MCE end address for region 2 register
    \ Address offset: 0x58
    \ Reset value: 0x00000FFF
    \
    $0c constant MCE_BADDEND                    \ [0x0c : 20] Region address end This bitfield defines the absolute end address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits return zeros and the 12 LSB bits return ones (reference value in MCE).
  [then]


  [ifdef] MCE_MCE_ATTR2_DEF
    \
    \ @brief MCE attribute for region 2 register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $10 constant MCE_WREN                       \ [0x10] Write enable This bit is taken into account only if BREN is set.
  [then]


  [ifdef] MCE_MCE_REGCR3_DEF
    \
    \ @brief MCE region 3 configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant MCE_BREN                       \ [0x00] Base region enable BREN cannot be set if BADDRSTART > BADDREND.
    $09 constant MCE_CTXID                      \ [0x09 : 2] Context ID This bitfield defines the cryptographic context used by the cipher engine assigned to this region. If ENC=00 bitfield CTXID is ignored. If BREN is set write to this bitfield is ignored. If ENC=01 the key stored in MCE_CC1KEYR is used by the stream cipher. The nonce in MCE_CC1NRx registers and the version in MCE_CC1CR register are also used. If ENC=01 the key stored in MCE_CC2KEYR is used by the stream cipher. The nonce in MCE_CC2NRx registers and the version in MCE_CC2CR register are also used.
    $0e constant MCE_ENC                        \ [0x0e : 2] Encrypted region Those bits are taken into account only if BREN is set and if the corresponding encryption feature is available in the MCE instance (see Section 35.3: MCE implementation). Write to those bits is ignored if BREN is set.
    $10 constant MCE_PRIV                       \ [0x10] Privileged region This bit is taken into account only if BREN is set.
  [then]


  [ifdef] MCE_MCE_SADDR3_DEF
    \
    \ @brief MCE start address for region 3 register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $0c constant MCE_BADDSTART                  \ [0x0c : 20] Region address start This bitfield defines the absolute start address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits and the 12 LSB bits return zeros (reference value in MCE).
  [then]


  [ifdef] MCE_MCE_EADDR3_DEF
    \
    \ @brief MCE end address for region 3 register
    \ Address offset: 0x68
    \ Reset value: 0x00000FFF
    \
    $0c constant MCE_BADDEND                    \ [0x0c : 20] Region address end This bitfield defines the absolute end address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits return zeros and the 12 LSB bits return ones (reference value in MCE).
  [then]


  [ifdef] MCE_MCE_ATTR3_DEF
    \
    \ @brief MCE attribute for region 3 register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $10 constant MCE_WREN                       \ [0x10] Write enable This bit is taken into account only if BREN is set.
  [then]


  [ifdef] MCE_MCE_REGCR4_DEF
    \
    \ @brief MCE region 4 configuration register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant MCE_BREN                       \ [0x00] Base region enable BREN cannot be set if BADDRSTART > BADDREND.
    $09 constant MCE_CTXID                      \ [0x09 : 2] Context ID This bitfield defines the cryptographic context used by the cipher engine assigned to this region. If ENC=00 bitfield CTXID is ignored. If BREN is set write to this bitfield is ignored. If ENC=01 the key stored in MCE_CC1KEYR is used by the stream cipher. The nonce in MCE_CC1NRx registers and the version in MCE_CC1CR register are also used. If ENC=01 the key stored in MCE_CC2KEYR is used by the stream cipher. The nonce in MCE_CC2NRx registers and the version in MCE_CC2CR register are also used.
    $0e constant MCE_ENC                        \ [0x0e : 2] Encrypted region Those bits are taken into account only if BREN is set and if the corresponding encryption feature is available in the MCE instance (see Section 35.3: MCE implementation). Write to those bits is ignored if BREN is set.
    $10 constant MCE_PRIV                       \ [0x10] Privileged region This bit is taken into account only if BREN is set.
  [then]


  [ifdef] MCE_MCE_SADDR4_DEF
    \
    \ @brief MCE start address for region 4 register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $0c constant MCE_BADDSTART                  \ [0x0c : 20] Region address start This bitfield defines the absolute start address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits and the 12 LSB bits return zeros (reference value in MCE).
  [then]


  [ifdef] MCE_MCE_EADDR4_DEF
    \
    \ @brief MCE end address for region 4 register
    \ Address offset: 0x78
    \ Reset value: 0x00000FFF
    \
    $0c constant MCE_BADDEND                    \ [0x0c : 20] Region address end This bitfield defines the absolute end address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits return zeros and the 12 LSB bits return ones (reference value in MCE).
  [then]


  [ifdef] MCE_MCE_ATTR4_DEF
    \
    \ @brief MCE attribute for region 4 register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $10 constant MCE_WREN                       \ [0x10] Write enable This bit is taken into account only if BREN is set.
  [then]


  [ifdef] MCE_MCE_MKEYR0_DEF
    \
    \ @brief MCE master key 0
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY0                      \ [0x00] Master key bit 0 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $01 constant MCE_MKEY1                      \ [0x01] Master key bit 1 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $02 constant MCE_MKEY2                      \ [0x02] Master key bit 2 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $03 constant MCE_MKEY3                      \ [0x03] Master key bit 3 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $04 constant MCE_MKEY4                      \ [0x04] Master key bit 4 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $05 constant MCE_MKEY5                      \ [0x05] Master key bit 5 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $06 constant MCE_MKEY6                      \ [0x06] Master key bit 6 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $07 constant MCE_MKEY7                      \ [0x07] Master key bit 7 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $08 constant MCE_MKEY8                      \ [0x08] Master key bit 8 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $09 constant MCE_MKEY9                      \ [0x09] Master key bit 9 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0a constant MCE_MKEY10                     \ [0x0a] Master key bit 10 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0b constant MCE_MKEY11                     \ [0x0b] Master key bit 11 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0c constant MCE_MKEY12                     \ [0x0c] Master key bit 12 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0d constant MCE_MKEY13                     \ [0x0d] Master key bit 13 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0e constant MCE_MKEY14                     \ [0x0e] Master key bit 14 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0f constant MCE_MKEY15                     \ [0x0f] Master key bit 15 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $10 constant MCE_MKEY16                     \ [0x10] Master key bit 16 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $11 constant MCE_MKEY17                     \ [0x11] Master key bit 17 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $12 constant MCE_MKEY18                     \ [0x12] Master key bit 18 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $13 constant MCE_MKEY19                     \ [0x13] Master key bit 19 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $14 constant MCE_MKEY20                     \ [0x14] Master key bit 20 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $15 constant MCE_MKEY21                     \ [0x15] Master key bit 21 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $16 constant MCE_MKEY22                     \ [0x16] Master key bit 22 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $17 constant MCE_MKEY23                     \ [0x17] Master key bit 23 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $18 constant MCE_MKEY24                     \ [0x18] Master key bit 24 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $19 constant MCE_MKEY25                     \ [0x19] Master key bit 25 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1a constant MCE_MKEY26                     \ [0x1a] Master key bit 26 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1b constant MCE_MKEY27                     \ [0x1b] Master key bit 27 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1c constant MCE_MKEY28                     \ [0x1c] Master key bit 28 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1d constant MCE_MKEY29                     \ [0x1d] Master key bit 29 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1e constant MCE_MKEY30                     \ [0x1e] Master key bit 30 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1f constant MCE_MKEY31                     \ [0x1f] Master key bit 31 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
  [then]


  [ifdef] MCE_MCE_MKEYR1_DEF
    \
    \ @brief MCE master key 1
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY32                     \ [0x00] Master key bit 32 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $01 constant MCE_MKEY33                     \ [0x01] Master key bit 33 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $02 constant MCE_MKEY34                     \ [0x02] Master key bit 34 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $03 constant MCE_MKEY35                     \ [0x03] Master key bit 35 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $04 constant MCE_MKEY36                     \ [0x04] Master key bit 36 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $05 constant MCE_MKEY37                     \ [0x05] Master key bit 37 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $06 constant MCE_MKEY38                     \ [0x06] Master key bit 38 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $07 constant MCE_MKEY39                     \ [0x07] Master key bit 39 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $08 constant MCE_MKEY40                     \ [0x08] Master key bit 40 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $09 constant MCE_MKEY41                     \ [0x09] Master key bit 41 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0a constant MCE_MKEY42                     \ [0x0a] Master key bit 42 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0b constant MCE_MKEY43                     \ [0x0b] Master key bit 43 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0c constant MCE_MKEY44                     \ [0x0c] Master key bit 44 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0d constant MCE_MKEY45                     \ [0x0d] Master key bit 45 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0e constant MCE_MKEY46                     \ [0x0e] Master key bit 46 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0f constant MCE_MKEY47                     \ [0x0f] Master key bit 47 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $10 constant MCE_MKEY48                     \ [0x10] Master key bit 48 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $11 constant MCE_MKEY49                     \ [0x11] Master key bit 49 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $12 constant MCE_MKEY50                     \ [0x12] Master key bit 50 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $13 constant MCE_MKEY51                     \ [0x13] Master key bit 51 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $14 constant MCE_MKEY52                     \ [0x14] Master key bit 52 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $15 constant MCE_MKEY53                     \ [0x15] Master key bit 53 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $16 constant MCE_MKEY54                     \ [0x16] Master key bit 54 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $17 constant MCE_MKEY55                     \ [0x17] Master key bit 55 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $18 constant MCE_MKEY56                     \ [0x18] Master key bit 56 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $19 constant MCE_MKEY57                     \ [0x19] Master key bit 57 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1a constant MCE_MKEY58                     \ [0x1a] Master key bit 58 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1b constant MCE_MKEY59                     \ [0x1b] Master key bit 59 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1c constant MCE_MKEY60                     \ [0x1c] Master key bit 60 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1d constant MCE_MKEY61                     \ [0x1d] Master key bit 61 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1e constant MCE_MKEY62                     \ [0x1e] Master key bit 62 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1f constant MCE_MKEY63                     \ [0x1f] Master key bit 63 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
  [then]


  [ifdef] MCE_MCE_MKEYR2_DEF
    \
    \ @brief MCE master key 2
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY64                     \ [0x00] Master key bit 64 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $01 constant MCE_MKEY65                     \ [0x01] Master key bit 65 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $02 constant MCE_MKEY66                     \ [0x02] Master key bit 66 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $03 constant MCE_MKEY67                     \ [0x03] Master key bit 67 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $04 constant MCE_MKEY68                     \ [0x04] Master key bit 68 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $05 constant MCE_MKEY69                     \ [0x05] Master key bit 69 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $06 constant MCE_MKEY70                     \ [0x06] Master key bit 70 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $07 constant MCE_MKEY71                     \ [0x07] Master key bit 71 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $08 constant MCE_MKEY72                     \ [0x08] Master key bit 72 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $09 constant MCE_MKEY73                     \ [0x09] Master key bit 73 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0a constant MCE_MKEY74                     \ [0x0a] Master key bit 74 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0b constant MCE_MKEY75                     \ [0x0b] Master key bit 75 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0c constant MCE_MKEY76                     \ [0x0c] Master key bit 76 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0d constant MCE_MKEY77                     \ [0x0d] Master key bit 77 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0e constant MCE_MKEY78                     \ [0x0e] Master key bit 78 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0f constant MCE_MKEY79                     \ [0x0f] Master key bit 79 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $10 constant MCE_MKEY80                     \ [0x10] Master key bit 80 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $11 constant MCE_MKEY81                     \ [0x11] Master key bit 81 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $12 constant MCE_MKEY82                     \ [0x12] Master key bit 82 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $13 constant MCE_MKEY83                     \ [0x13] Master key bit 83 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $14 constant MCE_MKEY84                     \ [0x14] Master key bit 84 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $15 constant MCE_MKEY85                     \ [0x15] Master key bit 85 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $16 constant MCE_MKEY86                     \ [0x16] Master key bit 86 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $17 constant MCE_MKEY87                     \ [0x17] Master key bit 87 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $18 constant MCE_MKEY88                     \ [0x18] Master key bit 88 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $19 constant MCE_MKEY89                     \ [0x19] Master key bit 89 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1a constant MCE_MKEY90                     \ [0x1a] Master key bit 90 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1b constant MCE_MKEY91                     \ [0x1b] Master key bit 91 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1c constant MCE_MKEY92                     \ [0x1c] Master key bit 92 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1d constant MCE_MKEY93                     \ [0x1d] Master key bit 93 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1e constant MCE_MKEY94                     \ [0x1e] Master key bit 94 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1f constant MCE_MKEY95                     \ [0x1f] Master key bit 95 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
  [then]


  [ifdef] MCE_MCE_MKEYR3_DEF
    \
    \ @brief MCE master key 3
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY96                     \ [0x00] Master key bit 96 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $01 constant MCE_MKEY97                     \ [0x01] Master key bit 97 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $02 constant MCE_MKEY98                     \ [0x02] Master key bit 98 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $03 constant MCE_MKEY99                     \ [0x03] Master key bit 99 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $04 constant MCE_MKEY100                    \ [0x04] Master key bit 100 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $05 constant MCE_MKEY101                    \ [0x05] Master key bit 101 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $06 constant MCE_MKEY102                    \ [0x06] Master key bit 102 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $07 constant MCE_MKEY103                    \ [0x07] Master key bit 103 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $08 constant MCE_MKEY104                    \ [0x08] Master key bit 104 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $09 constant MCE_MKEY105                    \ [0x09] Master key bit 105 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0a constant MCE_MKEY106                    \ [0x0a] Master key bit 106 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0b constant MCE_MKEY107                    \ [0x0b] Master key bit 107 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0c constant MCE_MKEY108                    \ [0x0c] Master key bit 108 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0d constant MCE_MKEY109                    \ [0x0d] Master key bit 109 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0e constant MCE_MKEY110                    \ [0x0e] Master key bit 110 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $0f constant MCE_MKEY111                    \ [0x0f] Master key bit 111 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $10 constant MCE_MKEY112                    \ [0x10] Master key bit 112 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $11 constant MCE_MKEY113                    \ [0x11] Master key bit 113 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $12 constant MCE_MKEY114                    \ [0x12] Master key bit 114 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $13 constant MCE_MKEY115                    \ [0x13] Master key bit 115 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $14 constant MCE_MKEY116                    \ [0x14] Master key bit 116 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $15 constant MCE_MKEY117                    \ [0x15] Master key bit 117 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $16 constant MCE_MKEY118                    \ [0x16] Master key bit 118 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $17 constant MCE_MKEY119                    \ [0x17] Master key bit 119 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $18 constant MCE_MKEY120                    \ [0x18] Master key bit 120 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $19 constant MCE_MKEY121                    \ [0x19] Master key bit 121 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1a constant MCE_MKEY122                    \ [0x1a] Master key bit 122 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1b constant MCE_MKEY123                    \ [0x1b] Master key bit 123 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1c constant MCE_MKEY124                    \ [0x1c] Master key bit 124 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1d constant MCE_MKEY125                    \ [0x1d] Master key bit 125 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1e constant MCE_MKEY126                    \ [0x1e] Master key bit 126 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
    $1f constant MCE_MKEY127                    \ [0x1f] Master key bit 127 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
  [then]


  [ifdef] MCE_MCE_FMKEYR0_DEF
    \
    \ @brief MCE fast master key 0
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY0                     \ [0x00] Fast master key bit 0 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $01 constant MCE_FMKEY1                     \ [0x01] Fast master key bit 1 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $02 constant MCE_FMKEY2                     \ [0x02] Fast master key bit 2 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $03 constant MCE_FMKEY3                     \ [0x03] Fast master key bit 3 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $04 constant MCE_FMKEY4                     \ [0x04] Fast master key bit 4 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $05 constant MCE_FMKEY5                     \ [0x05] Fast master key bit 5 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $06 constant MCE_FMKEY6                     \ [0x06] Fast master key bit 6 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $07 constant MCE_FMKEY7                     \ [0x07] Fast master key bit 7 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $08 constant MCE_FMKEY8                     \ [0x08] Fast master key bit 8 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $09 constant MCE_FMKEY9                     \ [0x09] Fast master key bit 9 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0a constant MCE_FMKEY10                    \ [0x0a] Fast master key bit 10 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0b constant MCE_FMKEY11                    \ [0x0b] Fast master key bit 11 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0c constant MCE_FMKEY12                    \ [0x0c] Fast master key bit 12 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0d constant MCE_FMKEY13                    \ [0x0d] Fast master key bit 13 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0e constant MCE_FMKEY14                    \ [0x0e] Fast master key bit 14 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0f constant MCE_FMKEY15                    \ [0x0f] Fast master key bit 15 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $10 constant MCE_FMKEY16                    \ [0x10] Fast master key bit 16 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $11 constant MCE_FMKEY17                    \ [0x11] Fast master key bit 17 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $12 constant MCE_FMKEY18                    \ [0x12] Fast master key bit 18 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $13 constant MCE_FMKEY19                    \ [0x13] Fast master key bit 19 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $14 constant MCE_FMKEY20                    \ [0x14] Fast master key bit 20 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $15 constant MCE_FMKEY21                    \ [0x15] Fast master key bit 21 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $16 constant MCE_FMKEY22                    \ [0x16] Fast master key bit 22 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $17 constant MCE_FMKEY23                    \ [0x17] Fast master key bit 23 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $18 constant MCE_FMKEY24                    \ [0x18] Fast master key bit 24 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $19 constant MCE_FMKEY25                    \ [0x19] Fast master key bit 25 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1a constant MCE_FMKEY26                    \ [0x1a] Fast master key bit 26 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1b constant MCE_FMKEY27                    \ [0x1b] Fast master key bit 27 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1c constant MCE_FMKEY28                    \ [0x1c] Fast master key bit 28 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1d constant MCE_FMKEY29                    \ [0x1d] Fast master key bit 29 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1e constant MCE_FMKEY30                    \ [0x1e] Fast master key bit 30 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1f constant MCE_FMKEY31                    \ [0x1f] Fast master key bit 31 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
  [then]


  [ifdef] MCE_MCE_FMKEYR1_DEF
    \
    \ @brief MCE fast master key 1
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY32                    \ [0x00] Fast master key bit 32 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $01 constant MCE_FMKEY33                    \ [0x01] Fast master key bit 33 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $02 constant MCE_FMKEY34                    \ [0x02] Fast master key bit 34 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $03 constant MCE_FMKEY35                    \ [0x03] Fast master key bit 35 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $04 constant MCE_FMKEY36                    \ [0x04] Fast master key bit 36 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $05 constant MCE_FMKEY37                    \ [0x05] Fast master key bit 37 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $06 constant MCE_FMKEY38                    \ [0x06] Fast master key bit 38 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $07 constant MCE_FMKEY39                    \ [0x07] Fast master key bit 39 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $08 constant MCE_FMKEY40                    \ [0x08] Fast master key bit 40 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $09 constant MCE_FMKEY41                    \ [0x09] Fast master key bit 41 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0a constant MCE_FMKEY42                    \ [0x0a] Fast master key bit 42 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0b constant MCE_FMKEY43                    \ [0x0b] Fast master key bit 43 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0c constant MCE_FMKEY44                    \ [0x0c] Fast master key bit 44 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0d constant MCE_FMKEY45                    \ [0x0d] Fast master key bit 45 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0e constant MCE_FMKEY46                    \ [0x0e] Fast master key bit 46 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0f constant MCE_FMKEY47                    \ [0x0f] Fast master key bit 47 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $10 constant MCE_FMKEY48                    \ [0x10] Fast master key bit 48 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $11 constant MCE_FMKEY49                    \ [0x11] Fast master key bit 49 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $12 constant MCE_FMKEY50                    \ [0x12] Fast master key bit 50 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $13 constant MCE_FMKEY51                    \ [0x13] Fast master key bit 51 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $14 constant MCE_FMKEY52                    \ [0x14] Fast master key bit 52 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $15 constant MCE_FMKEY53                    \ [0x15] Fast master key bit 53 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $16 constant MCE_FMKEY54                    \ [0x16] Fast master key bit 54 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $17 constant MCE_FMKEY55                    \ [0x17] Fast master key bit 55 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $18 constant MCE_FMKEY56                    \ [0x18] Fast master key bit 56 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $19 constant MCE_FMKEY57                    \ [0x19] Fast master key bit 57 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1a constant MCE_FMKEY58                    \ [0x1a] Fast master key bit 58 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1b constant MCE_FMKEY59                    \ [0x1b] Fast master key bit 59 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1c constant MCE_FMKEY60                    \ [0x1c] Fast master key bit 60 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1d constant MCE_FMKEY61                    \ [0x1d] Fast master key bit 61 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1e constant MCE_FMKEY62                    \ [0x1e] Fast master key bit 62 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1f constant MCE_FMKEY63                    \ [0x1f] Fast master key bit 63 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
  [then]


  [ifdef] MCE_MCE_FMKEYR2_DEF
    \
    \ @brief MCE fast master key 2
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY64                    \ [0x00] Fast master key bit 64 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $01 constant MCE_FMKEY65                    \ [0x01] Fast master key bit 65 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $02 constant MCE_FMKEY66                    \ [0x02] Fast master key bit 66 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $03 constant MCE_FMKEY67                    \ [0x03] Fast master key bit 67 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $04 constant MCE_FMKEY68                    \ [0x04] Fast master key bit 68 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $05 constant MCE_FMKEY69                    \ [0x05] Fast master key bit 69 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $06 constant MCE_FMKEY70                    \ [0x06] Fast master key bit 70 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $07 constant MCE_FMKEY71                    \ [0x07] Fast master key bit 71 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $08 constant MCE_FMKEY72                    \ [0x08] Fast master key bit 72 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $09 constant MCE_FMKEY73                    \ [0x09] Fast master key bit 73 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0a constant MCE_FMKEY74                    \ [0x0a] Fast master key bit 74 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0b constant MCE_FMKEY75                    \ [0x0b] Fast master key bit 75 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0c constant MCE_FMKEY76                    \ [0x0c] Fast master key bit 76 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0d constant MCE_FMKEY77                    \ [0x0d] Fast master key bit 77 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0e constant MCE_FMKEY78                    \ [0x0e] Fast master key bit 78 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0f constant MCE_FMKEY79                    \ [0x0f] Fast master key bit 79 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $10 constant MCE_FMKEY80                    \ [0x10] Fast master key bit 80 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $11 constant MCE_FMKEY81                    \ [0x11] Fast master key bit 81 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $12 constant MCE_FMKEY82                    \ [0x12] Fast master key bit 82 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $13 constant MCE_FMKEY83                    \ [0x13] Fast master key bit 83 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $14 constant MCE_FMKEY84                    \ [0x14] Fast master key bit 84 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $15 constant MCE_FMKEY85                    \ [0x15] Fast master key bit 85 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $16 constant MCE_FMKEY86                    \ [0x16] Fast master key bit 86 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $17 constant MCE_FMKEY87                    \ [0x17] Fast master key bit 87 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $18 constant MCE_FMKEY88                    \ [0x18] Fast master key bit 88 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $19 constant MCE_FMKEY89                    \ [0x19] Fast master key bit 89 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1a constant MCE_FMKEY90                    \ [0x1a] Fast master key bit 90 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1b constant MCE_FMKEY91                    \ [0x1b] Fast master key bit 91 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1c constant MCE_FMKEY92                    \ [0x1c] Fast master key bit 92 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1d constant MCE_FMKEY93                    \ [0x1d] Fast master key bit 93 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1e constant MCE_FMKEY94                    \ [0x1e] Fast master key bit 94 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1f constant MCE_FMKEY95                    \ [0x1f] Fast master key bit 95 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
  [then]


  [ifdef] MCE_MCE_FMKEYR3_DEF
    \
    \ @brief MCE fast master key 3
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY96                    \ [0x00] Fast master key bit 96 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $01 constant MCE_FMKEY97                    \ [0x01] Fast master key bit 97 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $02 constant MCE_FMKEY98                    \ [0x02] Fast master key bit 98 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $03 constant MCE_FMKEY99                    \ [0x03] Fast master key bit 99 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $04 constant MCE_FMKEY100                   \ [0x04] Fast master key bit 100 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $05 constant MCE_FMKEY101                   \ [0x05] Fast master key bit 101 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $06 constant MCE_FMKEY102                   \ [0x06] Fast master key bit 102 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $07 constant MCE_FMKEY103                   \ [0x07] Fast master key bit 103 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $08 constant MCE_FMKEY104                   \ [0x08] Fast master key bit 104 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $09 constant MCE_FMKEY105                   \ [0x09] Fast master key bit 105 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0a constant MCE_FMKEY106                   \ [0x0a] Fast master key bit 106 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0b constant MCE_FMKEY107                   \ [0x0b] Fast master key bit 107 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0c constant MCE_FMKEY108                   \ [0x0c] Fast master key bit 108 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0d constant MCE_FMKEY109                   \ [0x0d] Fast master key bit 109 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0e constant MCE_FMKEY110                   \ [0x0e] Fast master key bit 110 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $0f constant MCE_FMKEY111                   \ [0x0f] Fast master key bit 111 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $10 constant MCE_FMKEY112                   \ [0x10] Fast master key bit 112 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $11 constant MCE_FMKEY113                   \ [0x11] Fast master key bit 113 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $12 constant MCE_FMKEY114                   \ [0x12] Fast master key bit 114 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $13 constant MCE_FMKEY115                   \ [0x13] Fast master key bit 115 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $14 constant MCE_FMKEY116                   \ [0x14] Fast master key bit 116 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $15 constant MCE_FMKEY117                   \ [0x15] Fast master key bit 117 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $16 constant MCE_FMKEY118                   \ [0x16] Fast master key bit 118 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $17 constant MCE_FMKEY119                   \ [0x17] Fast master key bit 119 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $18 constant MCE_FMKEY120                   \ [0x18] Fast master key bit 120 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $19 constant MCE_FMKEY121                   \ [0x19] Fast master key bit 121 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1a constant MCE_FMKEY122                   \ [0x1a] Fast master key bit 122 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1b constant MCE_FMKEY123                   \ [0x1b] Fast master key bit 123 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1c constant MCE_FMKEY124                   \ [0x1c] Fast master key bit 124 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1d constant MCE_FMKEY125                   \ [0x1d] Fast master key bit 125 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1e constant MCE_FMKEY126                   \ [0x1e] Fast master key bit 126 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
    $1f constant MCE_FMKEY127                   \ [0x1f] Fast master key bit 127 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
  [then]


  [ifdef] MCE_MCE_CC1CFGR_DEF
    \
    \ @brief MCE cipher context 1 configuration register
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant MCE_CCEN                       \ [0x00] Cipher context enable
    $01 constant MCE_CCLOCK                     \ [0x01] Cipher context lock Note: This bit is set once. If this bit is set, it can only be cleared to 0 if MCE is reset. Setting this bit forces KEYLOCK bit to 1.
    $02 constant MCE_KEYLOCK                    \ [0x02] Key lock Note: This bit is set once. If this bit is set, it can only be cleared to 0 if MCE is reset.
    $08 constant MCE_KEYCRC                     \ [0x08 : 8] Key CRC When KEYLOCK=0, KEYCRC information is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new KEYCRC computation starts as soon as a new valid sequence is initiated. KEYCRC bitfield reads as zero until a valid sequence is completed (after it return the computed CRC value). When GLOCK=1, KEYCRC bitfield always return the computed CRC value until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Note: CRC information is updated, and the key is usable by MCE, only after the last bit of the key has been written. When GLOCK=0 any write to MCE_CCxKEYR registers clears KEYCRC in MCE_CCxCFGR, and makes the cipher context key un-usable (bypass mode is selected instead). To be able to use the key again application must perform this sequence: write to KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). As KEYLOCK=1 all those writes are ignored, so the correct key is used instead.
    $10 constant MCE_VERSION                    \ [0x10 : 16] Version This 16-bit bitfield must be correctly initialized before CCEN bit is set. Bitfield usage is defined in Section 35.4.6: MCE stream cipher encryption mode.
  [then]


  [ifdef] MCE_MCE_CC1NR0_DEF
    \
    \ @brief MCE cipher context 1 nonce register 0
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant MCE_SCNONCE                    \ [0x00 : 32] Stream cipher nonce, bits [31:0] This register is used by stream cipher to compute keystream. It must be correctly initialize before CCEN bit is set in MCE_CCzCFGR register. Bitfield usage is defined in Section 35.4.6: MCE stream cipher encryption mode.
  [then]


  [ifdef] MCE_MCE_CC1NR1_DEF
    \
    \ @brief MCE cipher context 1 nonce register 1
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant MCE_SCNONCE                    \ [0x00 : 32] Stream cipher nonce, bits [63:32] Refer to the MCE_CCzNR0 register for description of the SCNONCE[63:0] bitfield.
  [then]


  [ifdef] MCE_MCE_CC1KEYR0_DEF
    \
    \ @brief MCE cipher context 1 key register 0
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [31:0] This register is used by the block or stream cipher of MCE when CTXID = z in encrypted region configuration register. KEY[127:0] must be correctly initialize before CCEN bit is set in MCE_CCzCFGR register.
  [then]


  [ifdef] MCE_MCE_CC1KEYR1_DEF
    \
    \ @brief MCE cipher context 1 key register 1
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [63:32] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] MCE_MCE_CC1KEYR2_DEF
    \
    \ @brief MCE cipher context 1 key register 2
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [95:64] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] MCE_MCE_CC1KEYR3_DEF
    \
    \ @brief MCE cipher context 1 key register 3
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [127:96] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] MCE_MCE_CC2CFGR_DEF
    \
    \ @brief MCE cipher context 2 configuration register
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant MCE_CCEN                       \ [0x00] Cipher context enable
    $01 constant MCE_CCLOCK                     \ [0x01] Cipher context lock Note: This bit is set once. If this bit is set, it can only be cleared to 0 if MCE is reset. Setting this bit forces KEYLOCK bit to 1.
    $02 constant MCE_KEYLOCK                    \ [0x02] Key lock Note: This bit is set once. If this bit is set, it can only be cleared to 0 if MCE is reset.
    $08 constant MCE_KEYCRC                     \ [0x08 : 8] Key CRC When KEYLOCK=0, KEYCRC information is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new KEYCRC computation starts as soon as a new valid sequence is initiated. KEYCRC bitfield reads as zero until a valid sequence is completed (after it return the computed CRC value). When GLOCK=1, KEYCRC bitfield always return the computed CRC value until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Note: CRC information is updated, and the key is usable by MCE, only after the last bit of the key has been written. When GLOCK=0 any write to MCE_CCxKEYR registers clears KEYCRC in MCE_CCxCFGR, and makes the cipher context key un-usable (bypass mode is selected instead). To be able to use the key again application must perform this sequence: write to KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). As KEYLOCK=1 all those writes are ignored, so the correct key is used instead.
    $10 constant MCE_VERSION                    \ [0x10 : 16] Version This 16-bit bitfield must be correctly initialized before CCEN bit is set. Bitfield usage is defined in Section 35.4.6: MCE stream cipher encryption mode.
  [then]


  [ifdef] MCE_MCE_CC2NR0_DEF
    \
    \ @brief MCE cipher context 2 nonce register 0
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant MCE_SCNONCE                    \ [0x00 : 32] Stream cipher nonce, bits [31:0] This register is used by stream cipher to compute keystream. It must be correctly initialize before CCEN bit is set in MCE_CCzCFGR register. Bitfield usage is defined in Section 35.4.6: MCE stream cipher encryption mode.
  [then]


  [ifdef] MCE_MCE_CC2NR1_DEF
    \
    \ @brief MCE cipher context 2 nonce register 1
    \ Address offset: 0x278
    \ Reset value: 0x00000000
    \
    $00 constant MCE_SCNONCE                    \ [0x00 : 32] Stream cipher nonce, bits [63:32] Refer to the MCE_CCzNR0 register for description of the SCNONCE[63:0] bitfield.
  [then]


  [ifdef] MCE_MCE_CC2KEYR0_DEF
    \
    \ @brief MCE cipher context 2 key register 0
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [31:0] This register is used by the block or stream cipher of MCE when CTXID = z in encrypted region configuration register. KEY[127:0] must be correctly initialize before CCEN bit is set in MCE_CCzCFGR register.
  [then]


  [ifdef] MCE_MCE_CC2KEYR1_DEF
    \
    \ @brief MCE cipher context 2 key register 1
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [63:32] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] MCE_MCE_CC2KEYR2_DEF
    \
    \ @brief MCE cipher context 2 key register 2
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [95:64] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] MCE_MCE_CC2KEYR3_DEF
    \
    \ @brief MCE cipher context 2 key register 3
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [127:96] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.
  [then]

  \
  \ @brief Memory cipher engine
  \
  $00 constant MCE_MCE_CR               \ MCE configuration register
  $04 constant MCE_MCE_SR               \ MCE status register
  $08 constant MCE_MCE_IASR             \ MCE illegal access status register
  $0C constant MCE_MCE_IACR             \ MCE illegal access clear register
  $10 constant MCE_MCE_IAIER            \ MCE illegal access interrupt enable register
  $1C constant MCE_MCE_PRIVCFGR         \ MCE privileged configuration register
  $20 constant MCE_MCE_IAESR            \ MCE illegal access error status register
  $24 constant MCE_MCE_IADDR            \ MCE illegal address register
  $40 constant MCE_MCE_REGCR1           \ MCE region 1 configuration register
  $44 constant MCE_MCE_SADDR1           \ MCE start address for region 1 register
  $48 constant MCE_MCE_EADDR1           \ MCE end address for region 1 register
  $4C constant MCE_MCE_ATTR1            \ MCE attribute for region 1 register
  $50 constant MCE_MCE_REGCR2           \ MCE region 2 configuration register
  $54 constant MCE_MCE_SADDR2           \ MCE start address for region 2 register
  $58 constant MCE_MCE_EADDR2           \ MCE end address for region 2 register
  $5C constant MCE_MCE_ATTR2            \ MCE attribute for region 2 register
  $60 constant MCE_MCE_REGCR3           \ MCE region 3 configuration register
  $64 constant MCE_MCE_SADDR3           \ MCE start address for region 3 register
  $68 constant MCE_MCE_EADDR3           \ MCE end address for region 3 register
  $6C constant MCE_MCE_ATTR3            \ MCE attribute for region 3 register
  $70 constant MCE_MCE_REGCR4           \ MCE region 4 configuration register
  $74 constant MCE_MCE_SADDR4           \ MCE start address for region 4 register
  $78 constant MCE_MCE_EADDR4           \ MCE end address for region 4 register
  $7C constant MCE_MCE_ATTR4            \ MCE attribute for region 4 register
  $200 constant MCE_MCE_MKEYR0          \ MCE master key 0
  $204 constant MCE_MCE_MKEYR1          \ MCE master key 1
  $208 constant MCE_MCE_MKEYR2          \ MCE master key 2
  $20C constant MCE_MCE_MKEYR3          \ MCE master key 3
  $220 constant MCE_MCE_FMKEYR0         \ MCE fast master key 0
  $224 constant MCE_MCE_FMKEYR1         \ MCE fast master key 1
  $228 constant MCE_MCE_FMKEYR2         \ MCE fast master key 2
  $22C constant MCE_MCE_FMKEYR3         \ MCE fast master key 3
  $240 constant MCE_MCE_CC1CFGR         \ MCE cipher context 1 configuration register
  $244 constant MCE_MCE_CC1NR0          \ MCE cipher context 1 nonce register 0
  $248 constant MCE_MCE_CC1NR1          \ MCE cipher context 1 nonce register 1
  $24C constant MCE_MCE_CC1KEYR0        \ MCE cipher context 1 key register 0
  $250 constant MCE_MCE_CC1KEYR1        \ MCE cipher context 1 key register 1
  $254 constant MCE_MCE_CC1KEYR2        \ MCE cipher context 1 key register 2
  $258 constant MCE_MCE_CC1KEYR3        \ MCE cipher context 1 key register 3
  $270 constant MCE_MCE_CC2CFGR         \ MCE cipher context 2 configuration register
  $274 constant MCE_MCE_CC2NR0          \ MCE cipher context 2 nonce register 0
  $278 constant MCE_MCE_CC2NR1          \ MCE cipher context 2 nonce register 1
  $27C constant MCE_MCE_CC2KEYR0        \ MCE cipher context 2 key register 0
  $280 constant MCE_MCE_CC2KEYR1        \ MCE cipher context 2 key register 1
  $284 constant MCE_MCE_CC2KEYR2        \ MCE cipher context 2 key register 2
  $288 constant MCE_MCE_CC2KEYR3        \ MCE cipher context 2 key register 3

: MCE_DEF ; [then]
