\
\ @file mce2.fs
\ @brief MCE2 global interrupt
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

$00000001 constant MCE2_MCE_CR_GLOCK                                \ Global lock Lock the configuration of most MCE registers until next reset. This bit is cleared by default and once set it cannot be reset until MCE reset.
$00000002 constant MCE2_MCE_CR_MKLOCK                               \ Master keys lock Lock the master key configurations until next reset. This bit is cleared by default and once set it cannot be reset until MCE reset. Effect of this bit depends on the number of master keys. See Section 35.3: MCE implementation for details.


\
\ @brief MCE status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_SR_MKVALID                              \ Master key valid
$00000004 constant MCE2_MCE_SR_FMKVALID                             \ Fast master key valid This bit is reserved when fast master key is not present in the MCE instance. See Section 35.3: MCE implementation for detail.
$00000010 constant MCE2_MCE_SR_ENCDIS                               \ encryption disabled This bit is set by hardware when the encryption feature is not functional. When ENCDIS is set application must reset MCE peripheral to be able to use the encryption feature again.


\
\ @brief MCE illegal access status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_IASR_CAEF                               \ Configuration access error flag This bit is set when an illegal access to any MCE configuration register is detected. Bit is cleared by setting corresponding bit in MCE_IACR register. No additional details on the error is available.
$00000002 constant MCE2_MCE_IASR_IAEF                               \ Illegal access error flag This bit is set when an illegal access is detected on the system bus. More details on the error can be found in MCE_IAESR and MCE_IADDR registers. This bit is cleared by setting corresponding bit in MCE_IACR register.


\
\ @brief MCE illegal access clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_IACR_CAEF                               \ Configuration access error flag clear Set this bit to clear CAEF bit in MCE_IASR register.
$00000002 constant MCE2_MCE_IACR_IAEF                               \ Illegal access error flag clear Set this bit to clear IAEF bit in MCE_IASR register. Clearing IAEF bit permits to capture new error information in MCE_IAESR and MCE_IADDR registers. Note that clearing this bit does not clear RISAB_IADDR register.


\
\ @brief MCE illegal access interrupt enable register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_IAIER_CAEIE                             \ Configuration access error interrupt enable
$00000002 constant MCE2_MCE_IAIER_IAEIE                             \ Illegal access error interrupt enable


\
\ @brief MCE privileged configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_PRIVCFGR_PRIV                           \ Privileged configuration


\
\ @brief MCE illegal access error status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000010 constant MCE2_MCE_IAESR_IAPRIV                            \ Illegal access privilege When IAEF bit is set in MCE_IASR register IAPRIV bit captures the privileged state of the master that issued the illegal access detected on the AXI system bus.
$00000080 constant MCE2_MCE_IAESR_IANRW                             \ Illegal access read/write When IAEF bit is set in MCE_IASR register IANRW bit captures the access type of the illegal access detected.


\
\ @brief MCE illegal address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_IADDR_IADD                              \ Illegal address When IAEF bit is set in MCE_IASR register IADD bitfield captures the 32-bit bus address of the erroneous access. Additional information can be found in MCE_IAESR register.


\
\ @brief MCE region 1 configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_REGCR1_BREN                             \ Base region enable BREN cannot be set if BADDRSTART > BADDREND.
$00000600 constant MCE2_MCE_REGCR1_CTXID                            \ Context ID This bitfield defines the cryptographic context used by the cipher engine assigned to this region. If ENC=00 bitfield CTXID is ignored. If BREN is set write to this bitfield is ignored. If ENC=01 the key stored in MCE_CC1KEYR is used by the stream cipher. The nonce in MCE_CC1NRx registers and the version in MCE_CC1CR register are also used. If ENC=01 the key stored in MCE_CC2KEYR is used by the stream cipher. The nonce in MCE_CC2NRx registers and the version in MCE_CC2CR register are also used.
$0000c000 constant MCE2_MCE_REGCR1_ENC                              \ Encrypted region Those bits are taken into account only if BREN is set and if the corresponding encryption feature is available in the MCE instance (see Section 35.3: MCE implementation). Write to those bits is ignored if BREN is set.
$00010000 constant MCE2_MCE_REGCR1_PRIV                             \ Privileged region This bit is taken into account only if BREN is set.


\
\ @brief MCE start address for region 1 register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$fffff000 constant MCE2_MCE_SADDR1_BADDSTART                        \ Region address start This bitfield defines the absolute start address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits and the 12 LSB bits return zeros (reference value in MCE).


\
\ @brief MCE end address for region 1 register
\ Address offset: 0x48
\ Reset value: 0x00000FFF
\

$fffff000 constant MCE2_MCE_EADDR1_BADDEND                          \ Region address end This bitfield defines the absolute end address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits return zeros and the 12 LSB bits return ones (reference value in MCE).


\
\ @brief MCE attribute for region 1 register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00010000 constant MCE2_MCE_ATTR1_WREN                              \ Write enable This bit is taken into account only if BREN is set.


\
\ @brief MCE region 2 configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_REGCR2_BREN                             \ Base region enable BREN cannot be set if BADDRSTART > BADDREND.
$00000600 constant MCE2_MCE_REGCR2_CTXID                            \ Context ID This bitfield defines the cryptographic context used by the cipher engine assigned to this region. If ENC=00 bitfield CTXID is ignored. If BREN is set write to this bitfield is ignored. If ENC=01 the key stored in MCE_CC1KEYR is used by the stream cipher. The nonce in MCE_CC1NRx registers and the version in MCE_CC1CR register are also used. If ENC=01 the key stored in MCE_CC2KEYR is used by the stream cipher. The nonce in MCE_CC2NRx registers and the version in MCE_CC2CR register are also used.
$0000c000 constant MCE2_MCE_REGCR2_ENC                              \ Encrypted region Those bits are taken into account only if BREN is set and if the corresponding encryption feature is available in the MCE instance (see Section 35.3: MCE implementation). Write to those bits is ignored if BREN is set.
$00010000 constant MCE2_MCE_REGCR2_PRIV                             \ Privileged region This bit is taken into account only if BREN is set.


\
\ @brief MCE start address for region 2 register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$fffff000 constant MCE2_MCE_SADDR2_BADDSTART                        \ Region address start This bitfield defines the absolute start address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits and the 12 LSB bits return zeros (reference value in MCE).


\
\ @brief MCE end address for region 2 register
\ Address offset: 0x58
\ Reset value: 0x00000FFF
\

$fffff000 constant MCE2_MCE_EADDR2_BADDEND                          \ Region address end This bitfield defines the absolute end address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits return zeros and the 12 LSB bits return ones (reference value in MCE).


\
\ @brief MCE attribute for region 2 register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00010000 constant MCE2_MCE_ATTR2_WREN                              \ Write enable This bit is taken into account only if BREN is set.


\
\ @brief MCE region 3 configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_REGCR3_BREN                             \ Base region enable BREN cannot be set if BADDRSTART > BADDREND.
$00000600 constant MCE2_MCE_REGCR3_CTXID                            \ Context ID This bitfield defines the cryptographic context used by the cipher engine assigned to this region. If ENC=00 bitfield CTXID is ignored. If BREN is set write to this bitfield is ignored. If ENC=01 the key stored in MCE_CC1KEYR is used by the stream cipher. The nonce in MCE_CC1NRx registers and the version in MCE_CC1CR register are also used. If ENC=01 the key stored in MCE_CC2KEYR is used by the stream cipher. The nonce in MCE_CC2NRx registers and the version in MCE_CC2CR register are also used.
$0000c000 constant MCE2_MCE_REGCR3_ENC                              \ Encrypted region Those bits are taken into account only if BREN is set and if the corresponding encryption feature is available in the MCE instance (see Section 35.3: MCE implementation). Write to those bits is ignored if BREN is set.
$00010000 constant MCE2_MCE_REGCR3_PRIV                             \ Privileged region This bit is taken into account only if BREN is set.


\
\ @brief MCE start address for region 3 register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$fffff000 constant MCE2_MCE_SADDR3_BADDSTART                        \ Region address start This bitfield defines the absolute start address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits and the 12 LSB bits return zeros (reference value in MCE).


\
\ @brief MCE end address for region 3 register
\ Address offset: 0x68
\ Reset value: 0x00000FFF
\

$fffff000 constant MCE2_MCE_EADDR3_BADDEND                          \ Region address end This bitfield defines the absolute end address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits return zeros and the 12 LSB bits return ones (reference value in MCE).


\
\ @brief MCE attribute for region 3 register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00010000 constant MCE2_MCE_ATTR3_WREN                              \ Write enable This bit is taken into account only if BREN is set.


\
\ @brief MCE region 4 configuration register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_REGCR4_BREN                             \ Base region enable BREN cannot be set if BADDRSTART > BADDREND.
$00000600 constant MCE2_MCE_REGCR4_CTXID                            \ Context ID This bitfield defines the cryptographic context used by the cipher engine assigned to this region. If ENC=00 bitfield CTXID is ignored. If BREN is set write to this bitfield is ignored. If ENC=01 the key stored in MCE_CC1KEYR is used by the stream cipher. The nonce in MCE_CC1NRx registers and the version in MCE_CC1CR register are also used. If ENC=01 the key stored in MCE_CC2KEYR is used by the stream cipher. The nonce in MCE_CC2NRx registers and the version in MCE_CC2CR register are also used.
$0000c000 constant MCE2_MCE_REGCR4_ENC                              \ Encrypted region Those bits are taken into account only if BREN is set and if the corresponding encryption feature is available in the MCE instance (see Section 35.3: MCE implementation). Write to those bits is ignored if BREN is set.
$00010000 constant MCE2_MCE_REGCR4_PRIV                             \ Privileged region This bit is taken into account only if BREN is set.


\
\ @brief MCE start address for region 4 register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$fffff000 constant MCE2_MCE_SADDR4_BADDSTART                        \ Region address start This bitfield defines the absolute start address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits and the 12 LSB bits return zeros (reference value in MCE).


\
\ @brief MCE end address for region 4 register
\ Address offset: 0x78
\ Reset value: 0x00000FFF
\

$fffff000 constant MCE2_MCE_EADDR4_BADDEND                          \ Region address end This bitfield defines the absolute end address of the region x on 4 kBytes boundary (inclusive). BREN cannot be set if BADDRSTART > BADDREND. When MCE determines the region, the first 12 bits (LSB) and the last 4 bits (MSB) in this register are ignored, and when this register is accessed in read the 4 MSB bits return zeros and the 12 LSB bits return ones (reference value in MCE).


\
\ @brief MCE attribute for region 4 register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00010000 constant MCE2_MCE_ATTR4_WREN                              \ Write enable This bit is taken into account only if BREN is set.


\
\ @brief MCE master key 0
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_MKEYR0_MKEY0                            \ Master key bit 0 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000002 constant MCE2_MCE_MKEYR0_MKEY1                            \ Master key bit 1 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000004 constant MCE2_MCE_MKEYR0_MKEY2                            \ Master key bit 2 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000008 constant MCE2_MCE_MKEYR0_MKEY3                            \ Master key bit 3 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000010 constant MCE2_MCE_MKEYR0_MKEY4                            \ Master key bit 4 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000020 constant MCE2_MCE_MKEYR0_MKEY5                            \ Master key bit 5 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000040 constant MCE2_MCE_MKEYR0_MKEY6                            \ Master key bit 6 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000080 constant MCE2_MCE_MKEYR0_MKEY7                            \ Master key bit 7 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000100 constant MCE2_MCE_MKEYR0_MKEY8                            \ Master key bit 8 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000200 constant MCE2_MCE_MKEYR0_MKEY9                            \ Master key bit 9 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000400 constant MCE2_MCE_MKEYR0_MKEY10                           \ Master key bit 10 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000800 constant MCE2_MCE_MKEYR0_MKEY11                           \ Master key bit 11 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00001000 constant MCE2_MCE_MKEYR0_MKEY12                           \ Master key bit 12 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00002000 constant MCE2_MCE_MKEYR0_MKEY13                           \ Master key bit 13 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00004000 constant MCE2_MCE_MKEYR0_MKEY14                           \ Master key bit 14 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00008000 constant MCE2_MCE_MKEYR0_MKEY15                           \ Master key bit 15 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00010000 constant MCE2_MCE_MKEYR0_MKEY16                           \ Master key bit 16 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00020000 constant MCE2_MCE_MKEYR0_MKEY17                           \ Master key bit 17 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00040000 constant MCE2_MCE_MKEYR0_MKEY18                           \ Master key bit 18 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00080000 constant MCE2_MCE_MKEYR0_MKEY19                           \ Master key bit 19 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00100000 constant MCE2_MCE_MKEYR0_MKEY20                           \ Master key bit 20 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00200000 constant MCE2_MCE_MKEYR0_MKEY21                           \ Master key bit 21 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00400000 constant MCE2_MCE_MKEYR0_MKEY22                           \ Master key bit 22 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00800000 constant MCE2_MCE_MKEYR0_MKEY23                           \ Master key bit 23 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$01000000 constant MCE2_MCE_MKEYR0_MKEY24                           \ Master key bit 24 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$02000000 constant MCE2_MCE_MKEYR0_MKEY25                           \ Master key bit 25 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$04000000 constant MCE2_MCE_MKEYR0_MKEY26                           \ Master key bit 26 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$08000000 constant MCE2_MCE_MKEYR0_MKEY27                           \ Master key bit 27 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$10000000 constant MCE2_MCE_MKEYR0_MKEY28                           \ Master key bit 28 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$20000000 constant MCE2_MCE_MKEYR0_MKEY29                           \ Master key bit 29 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$40000000 constant MCE2_MCE_MKEYR0_MKEY30                           \ Master key bit 30 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$80000000 constant MCE2_MCE_MKEYR0_MKEY31                           \ Master key bit 31 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.


\
\ @brief MCE master key 1
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_MKEYR1_MKEY32                           \ Master key bit 32 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000002 constant MCE2_MCE_MKEYR1_MKEY33                           \ Master key bit 33 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000004 constant MCE2_MCE_MKEYR1_MKEY34                           \ Master key bit 34 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000008 constant MCE2_MCE_MKEYR1_MKEY35                           \ Master key bit 35 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000010 constant MCE2_MCE_MKEYR1_MKEY36                           \ Master key bit 36 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000020 constant MCE2_MCE_MKEYR1_MKEY37                           \ Master key bit 37 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000040 constant MCE2_MCE_MKEYR1_MKEY38                           \ Master key bit 38 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000080 constant MCE2_MCE_MKEYR1_MKEY39                           \ Master key bit 39 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000100 constant MCE2_MCE_MKEYR1_MKEY40                           \ Master key bit 40 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000200 constant MCE2_MCE_MKEYR1_MKEY41                           \ Master key bit 41 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000400 constant MCE2_MCE_MKEYR1_MKEY42                           \ Master key bit 42 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000800 constant MCE2_MCE_MKEYR1_MKEY43                           \ Master key bit 43 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00001000 constant MCE2_MCE_MKEYR1_MKEY44                           \ Master key bit 44 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00002000 constant MCE2_MCE_MKEYR1_MKEY45                           \ Master key bit 45 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00004000 constant MCE2_MCE_MKEYR1_MKEY46                           \ Master key bit 46 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00008000 constant MCE2_MCE_MKEYR1_MKEY47                           \ Master key bit 47 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00010000 constant MCE2_MCE_MKEYR1_MKEY48                           \ Master key bit 48 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00020000 constant MCE2_MCE_MKEYR1_MKEY49                           \ Master key bit 49 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00040000 constant MCE2_MCE_MKEYR1_MKEY50                           \ Master key bit 50 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00080000 constant MCE2_MCE_MKEYR1_MKEY51                           \ Master key bit 51 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00100000 constant MCE2_MCE_MKEYR1_MKEY52                           \ Master key bit 52 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00200000 constant MCE2_MCE_MKEYR1_MKEY53                           \ Master key bit 53 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00400000 constant MCE2_MCE_MKEYR1_MKEY54                           \ Master key bit 54 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00800000 constant MCE2_MCE_MKEYR1_MKEY55                           \ Master key bit 55 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$01000000 constant MCE2_MCE_MKEYR1_MKEY56                           \ Master key bit 56 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$02000000 constant MCE2_MCE_MKEYR1_MKEY57                           \ Master key bit 57 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$04000000 constant MCE2_MCE_MKEYR1_MKEY58                           \ Master key bit 58 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$08000000 constant MCE2_MCE_MKEYR1_MKEY59                           \ Master key bit 59 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$10000000 constant MCE2_MCE_MKEYR1_MKEY60                           \ Master key bit 60 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$20000000 constant MCE2_MCE_MKEYR1_MKEY61                           \ Master key bit 61 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$40000000 constant MCE2_MCE_MKEYR1_MKEY62                           \ Master key bit 62 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$80000000 constant MCE2_MCE_MKEYR1_MKEY63                           \ Master key bit 63 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.


\
\ @brief MCE master key 2
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_MKEYR2_MKEY64                           \ Master key bit 64 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000002 constant MCE2_MCE_MKEYR2_MKEY65                           \ Master key bit 65 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000004 constant MCE2_MCE_MKEYR2_MKEY66                           \ Master key bit 66 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000008 constant MCE2_MCE_MKEYR2_MKEY67                           \ Master key bit 67 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000010 constant MCE2_MCE_MKEYR2_MKEY68                           \ Master key bit 68 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000020 constant MCE2_MCE_MKEYR2_MKEY69                           \ Master key bit 69 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000040 constant MCE2_MCE_MKEYR2_MKEY70                           \ Master key bit 70 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000080 constant MCE2_MCE_MKEYR2_MKEY71                           \ Master key bit 71 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000100 constant MCE2_MCE_MKEYR2_MKEY72                           \ Master key bit 72 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000200 constant MCE2_MCE_MKEYR2_MKEY73                           \ Master key bit 73 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000400 constant MCE2_MCE_MKEYR2_MKEY74                           \ Master key bit 74 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000800 constant MCE2_MCE_MKEYR2_MKEY75                           \ Master key bit 75 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00001000 constant MCE2_MCE_MKEYR2_MKEY76                           \ Master key bit 76 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00002000 constant MCE2_MCE_MKEYR2_MKEY77                           \ Master key bit 77 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00004000 constant MCE2_MCE_MKEYR2_MKEY78                           \ Master key bit 78 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00008000 constant MCE2_MCE_MKEYR2_MKEY79                           \ Master key bit 79 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00010000 constant MCE2_MCE_MKEYR2_MKEY80                           \ Master key bit 80 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00020000 constant MCE2_MCE_MKEYR2_MKEY81                           \ Master key bit 81 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00040000 constant MCE2_MCE_MKEYR2_MKEY82                           \ Master key bit 82 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00080000 constant MCE2_MCE_MKEYR2_MKEY83                           \ Master key bit 83 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00100000 constant MCE2_MCE_MKEYR2_MKEY84                           \ Master key bit 84 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00200000 constant MCE2_MCE_MKEYR2_MKEY85                           \ Master key bit 85 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00400000 constant MCE2_MCE_MKEYR2_MKEY86                           \ Master key bit 86 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00800000 constant MCE2_MCE_MKEYR2_MKEY87                           \ Master key bit 87 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$01000000 constant MCE2_MCE_MKEYR2_MKEY88                           \ Master key bit 88 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$02000000 constant MCE2_MCE_MKEYR2_MKEY89                           \ Master key bit 89 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$04000000 constant MCE2_MCE_MKEYR2_MKEY90                           \ Master key bit 90 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$08000000 constant MCE2_MCE_MKEYR2_MKEY91                           \ Master key bit 91 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$10000000 constant MCE2_MCE_MKEYR2_MKEY92                           \ Master key bit 92 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$20000000 constant MCE2_MCE_MKEYR2_MKEY93                           \ Master key bit 93 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$40000000 constant MCE2_MCE_MKEYR2_MKEY94                           \ Master key bit 94 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$80000000 constant MCE2_MCE_MKEYR2_MKEY95                           \ Master key bit 95 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.


\
\ @brief MCE master key 3
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_MKEYR3_MKEY96                           \ Master key bit 96 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000002 constant MCE2_MCE_MKEYR3_MKEY97                           \ Master key bit 97 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000004 constant MCE2_MCE_MKEYR3_MKEY98                           \ Master key bit 98 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000008 constant MCE2_MCE_MKEYR3_MKEY99                           \ Master key bit 99 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000010 constant MCE2_MCE_MKEYR3_MKEY100                          \ Master key bit 100 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000020 constant MCE2_MCE_MKEYR3_MKEY101                          \ Master key bit 101 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000040 constant MCE2_MCE_MKEYR3_MKEY102                          \ Master key bit 102 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000080 constant MCE2_MCE_MKEYR3_MKEY103                          \ Master key bit 103 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000100 constant MCE2_MCE_MKEYR3_MKEY104                          \ Master key bit 104 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000200 constant MCE2_MCE_MKEYR3_MKEY105                          \ Master key bit 105 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000400 constant MCE2_MCE_MKEYR3_MKEY106                          \ Master key bit 106 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00000800 constant MCE2_MCE_MKEYR3_MKEY107                          \ Master key bit 107 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00001000 constant MCE2_MCE_MKEYR3_MKEY108                          \ Master key bit 108 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00002000 constant MCE2_MCE_MKEYR3_MKEY109                          \ Master key bit 109 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00004000 constant MCE2_MCE_MKEYR3_MKEY110                          \ Master key bit 110 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00008000 constant MCE2_MCE_MKEYR3_MKEY111                          \ Master key bit 111 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00010000 constant MCE2_MCE_MKEYR3_MKEY112                          \ Master key bit 112 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00020000 constant MCE2_MCE_MKEYR3_MKEY113                          \ Master key bit 113 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00040000 constant MCE2_MCE_MKEYR3_MKEY114                          \ Master key bit 114 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00080000 constant MCE2_MCE_MKEYR3_MKEY115                          \ Master key bit 115 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00100000 constant MCE2_MCE_MKEYR3_MKEY116                          \ Master key bit 116 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00200000 constant MCE2_MCE_MKEYR3_MKEY117                          \ Master key bit 117 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00400000 constant MCE2_MCE_MKEYR3_MKEY118                          \ Master key bit 118 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$00800000 constant MCE2_MCE_MKEYR3_MKEY119                          \ Master key bit 119 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$01000000 constant MCE2_MCE_MKEYR3_MKEY120                          \ Master key bit 120 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$02000000 constant MCE2_MCE_MKEYR3_MKEY121                          \ Master key bit 121 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$04000000 constant MCE2_MCE_MKEYR3_MKEY122                          \ Master key bit 122 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$08000000 constant MCE2_MCE_MKEYR3_MKEY123                          \ Master key bit 123 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$10000000 constant MCE2_MCE_MKEYR3_MKEY124                          \ Master key bit 124 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$20000000 constant MCE2_MCE_MKEYR3_MKEY125                          \ Master key bit 125 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$40000000 constant MCE2_MCE_MKEYR3_MKEY126                          \ Master key bit 126 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.
$80000000 constant MCE2_MCE_MKEYR3_MKEY127                          \ Master key bit 127 This key is used by the MCE block cipher in normal, SCA resistant mode, if CTXID=0x0 in MCE_REGCR register.


\
\ @brief MCE fast master key 0
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_FMKEYR0_FMKEY0                          \ Fast master key bit 0 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000002 constant MCE2_MCE_FMKEYR0_FMKEY1                          \ Fast master key bit 1 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000004 constant MCE2_MCE_FMKEYR0_FMKEY2                          \ Fast master key bit 2 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000008 constant MCE2_MCE_FMKEYR0_FMKEY3                          \ Fast master key bit 3 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000010 constant MCE2_MCE_FMKEYR0_FMKEY4                          \ Fast master key bit 4 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000020 constant MCE2_MCE_FMKEYR0_FMKEY5                          \ Fast master key bit 5 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000040 constant MCE2_MCE_FMKEYR0_FMKEY6                          \ Fast master key bit 6 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000080 constant MCE2_MCE_FMKEYR0_FMKEY7                          \ Fast master key bit 7 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000100 constant MCE2_MCE_FMKEYR0_FMKEY8                          \ Fast master key bit 8 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000200 constant MCE2_MCE_FMKEYR0_FMKEY9                          \ Fast master key bit 9 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000400 constant MCE2_MCE_FMKEYR0_FMKEY10                         \ Fast master key bit 10 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000800 constant MCE2_MCE_FMKEYR0_FMKEY11                         \ Fast master key bit 11 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00001000 constant MCE2_MCE_FMKEYR0_FMKEY12                         \ Fast master key bit 12 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00002000 constant MCE2_MCE_FMKEYR0_FMKEY13                         \ Fast master key bit 13 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00004000 constant MCE2_MCE_FMKEYR0_FMKEY14                         \ Fast master key bit 14 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00008000 constant MCE2_MCE_FMKEYR0_FMKEY15                         \ Fast master key bit 15 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00010000 constant MCE2_MCE_FMKEYR0_FMKEY16                         \ Fast master key bit 16 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00020000 constant MCE2_MCE_FMKEYR0_FMKEY17                         \ Fast master key bit 17 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00040000 constant MCE2_MCE_FMKEYR0_FMKEY18                         \ Fast master key bit 18 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00080000 constant MCE2_MCE_FMKEYR0_FMKEY19                         \ Fast master key bit 19 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00100000 constant MCE2_MCE_FMKEYR0_FMKEY20                         \ Fast master key bit 20 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00200000 constant MCE2_MCE_FMKEYR0_FMKEY21                         \ Fast master key bit 21 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00400000 constant MCE2_MCE_FMKEYR0_FMKEY22                         \ Fast master key bit 22 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00800000 constant MCE2_MCE_FMKEYR0_FMKEY23                         \ Fast master key bit 23 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$01000000 constant MCE2_MCE_FMKEYR0_FMKEY24                         \ Fast master key bit 24 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$02000000 constant MCE2_MCE_FMKEYR0_FMKEY25                         \ Fast master key bit 25 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$04000000 constant MCE2_MCE_FMKEYR0_FMKEY26                         \ Fast master key bit 26 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$08000000 constant MCE2_MCE_FMKEYR0_FMKEY27                         \ Fast master key bit 27 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$10000000 constant MCE2_MCE_FMKEYR0_FMKEY28                         \ Fast master key bit 28 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$20000000 constant MCE2_MCE_FMKEYR0_FMKEY29                         \ Fast master key bit 29 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$40000000 constant MCE2_MCE_FMKEYR0_FMKEY30                         \ Fast master key bit 30 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$80000000 constant MCE2_MCE_FMKEYR0_FMKEY31                         \ Fast master key bit 31 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.


\
\ @brief MCE fast master key 1
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_FMKEYR1_FMKEY32                         \ Fast master key bit 32 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000002 constant MCE2_MCE_FMKEYR1_FMKEY33                         \ Fast master key bit 33 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000004 constant MCE2_MCE_FMKEYR1_FMKEY34                         \ Fast master key bit 34 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000008 constant MCE2_MCE_FMKEYR1_FMKEY35                         \ Fast master key bit 35 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000010 constant MCE2_MCE_FMKEYR1_FMKEY36                         \ Fast master key bit 36 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000020 constant MCE2_MCE_FMKEYR1_FMKEY37                         \ Fast master key bit 37 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000040 constant MCE2_MCE_FMKEYR1_FMKEY38                         \ Fast master key bit 38 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000080 constant MCE2_MCE_FMKEYR1_FMKEY39                         \ Fast master key bit 39 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000100 constant MCE2_MCE_FMKEYR1_FMKEY40                         \ Fast master key bit 40 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000200 constant MCE2_MCE_FMKEYR1_FMKEY41                         \ Fast master key bit 41 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000400 constant MCE2_MCE_FMKEYR1_FMKEY42                         \ Fast master key bit 42 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000800 constant MCE2_MCE_FMKEYR1_FMKEY43                         \ Fast master key bit 43 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00001000 constant MCE2_MCE_FMKEYR1_FMKEY44                         \ Fast master key bit 44 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00002000 constant MCE2_MCE_FMKEYR1_FMKEY45                         \ Fast master key bit 45 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00004000 constant MCE2_MCE_FMKEYR1_FMKEY46                         \ Fast master key bit 46 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00008000 constant MCE2_MCE_FMKEYR1_FMKEY47                         \ Fast master key bit 47 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00010000 constant MCE2_MCE_FMKEYR1_FMKEY48                         \ Fast master key bit 48 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00020000 constant MCE2_MCE_FMKEYR1_FMKEY49                         \ Fast master key bit 49 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00040000 constant MCE2_MCE_FMKEYR1_FMKEY50                         \ Fast master key bit 50 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00080000 constant MCE2_MCE_FMKEYR1_FMKEY51                         \ Fast master key bit 51 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00100000 constant MCE2_MCE_FMKEYR1_FMKEY52                         \ Fast master key bit 52 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00200000 constant MCE2_MCE_FMKEYR1_FMKEY53                         \ Fast master key bit 53 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00400000 constant MCE2_MCE_FMKEYR1_FMKEY54                         \ Fast master key bit 54 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00800000 constant MCE2_MCE_FMKEYR1_FMKEY55                         \ Fast master key bit 55 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$01000000 constant MCE2_MCE_FMKEYR1_FMKEY56                         \ Fast master key bit 56 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$02000000 constant MCE2_MCE_FMKEYR1_FMKEY57                         \ Fast master key bit 57 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$04000000 constant MCE2_MCE_FMKEYR1_FMKEY58                         \ Fast master key bit 58 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$08000000 constant MCE2_MCE_FMKEYR1_FMKEY59                         \ Fast master key bit 59 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$10000000 constant MCE2_MCE_FMKEYR1_FMKEY60                         \ Fast master key bit 60 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$20000000 constant MCE2_MCE_FMKEYR1_FMKEY61                         \ Fast master key bit 61 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$40000000 constant MCE2_MCE_FMKEYR1_FMKEY62                         \ Fast master key bit 62 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$80000000 constant MCE2_MCE_FMKEYR1_FMKEY63                         \ Fast master key bit 63 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.


\
\ @brief MCE fast master key 2
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_FMKEYR2_FMKEY64                         \ Fast master key bit 64 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000002 constant MCE2_MCE_FMKEYR2_FMKEY65                         \ Fast master key bit 65 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000004 constant MCE2_MCE_FMKEYR2_FMKEY66                         \ Fast master key bit 66 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000008 constant MCE2_MCE_FMKEYR2_FMKEY67                         \ Fast master key bit 67 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000010 constant MCE2_MCE_FMKEYR2_FMKEY68                         \ Fast master key bit 68 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000020 constant MCE2_MCE_FMKEYR2_FMKEY69                         \ Fast master key bit 69 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000040 constant MCE2_MCE_FMKEYR2_FMKEY70                         \ Fast master key bit 70 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000080 constant MCE2_MCE_FMKEYR2_FMKEY71                         \ Fast master key bit 71 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000100 constant MCE2_MCE_FMKEYR2_FMKEY72                         \ Fast master key bit 72 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000200 constant MCE2_MCE_FMKEYR2_FMKEY73                         \ Fast master key bit 73 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000400 constant MCE2_MCE_FMKEYR2_FMKEY74                         \ Fast master key bit 74 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000800 constant MCE2_MCE_FMKEYR2_FMKEY75                         \ Fast master key bit 75 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00001000 constant MCE2_MCE_FMKEYR2_FMKEY76                         \ Fast master key bit 76 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00002000 constant MCE2_MCE_FMKEYR2_FMKEY77                         \ Fast master key bit 77 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00004000 constant MCE2_MCE_FMKEYR2_FMKEY78                         \ Fast master key bit 78 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00008000 constant MCE2_MCE_FMKEYR2_FMKEY79                         \ Fast master key bit 79 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00010000 constant MCE2_MCE_FMKEYR2_FMKEY80                         \ Fast master key bit 80 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00020000 constant MCE2_MCE_FMKEYR2_FMKEY81                         \ Fast master key bit 81 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00040000 constant MCE2_MCE_FMKEYR2_FMKEY82                         \ Fast master key bit 82 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00080000 constant MCE2_MCE_FMKEYR2_FMKEY83                         \ Fast master key bit 83 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00100000 constant MCE2_MCE_FMKEYR2_FMKEY84                         \ Fast master key bit 84 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00200000 constant MCE2_MCE_FMKEYR2_FMKEY85                         \ Fast master key bit 85 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00400000 constant MCE2_MCE_FMKEYR2_FMKEY86                         \ Fast master key bit 86 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00800000 constant MCE2_MCE_FMKEYR2_FMKEY87                         \ Fast master key bit 87 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$01000000 constant MCE2_MCE_FMKEYR2_FMKEY88                         \ Fast master key bit 88 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$02000000 constant MCE2_MCE_FMKEYR2_FMKEY89                         \ Fast master key bit 89 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$04000000 constant MCE2_MCE_FMKEYR2_FMKEY90                         \ Fast master key bit 90 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$08000000 constant MCE2_MCE_FMKEYR2_FMKEY91                         \ Fast master key bit 91 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$10000000 constant MCE2_MCE_FMKEYR2_FMKEY92                         \ Fast master key bit 92 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$20000000 constant MCE2_MCE_FMKEYR2_FMKEY93                         \ Fast master key bit 93 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$40000000 constant MCE2_MCE_FMKEYR2_FMKEY94                         \ Fast master key bit 94 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$80000000 constant MCE2_MCE_FMKEYR2_FMKEY95                         \ Fast master key bit 95 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.


\
\ @brief MCE fast master key 3
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_FMKEYR3_FMKEY96                         \ Fast master key bit 96 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000002 constant MCE2_MCE_FMKEYR3_FMKEY97                         \ Fast master key bit 97 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000004 constant MCE2_MCE_FMKEYR3_FMKEY98                         \ Fast master key bit 98 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000008 constant MCE2_MCE_FMKEYR3_FMKEY99                         \ Fast master key bit 99 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000010 constant MCE2_MCE_FMKEYR3_FMKEY100                        \ Fast master key bit 100 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000020 constant MCE2_MCE_FMKEYR3_FMKEY101                        \ Fast master key bit 101 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000040 constant MCE2_MCE_FMKEYR3_FMKEY102                        \ Fast master key bit 102 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000080 constant MCE2_MCE_FMKEYR3_FMKEY103                        \ Fast master key bit 103 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000100 constant MCE2_MCE_FMKEYR3_FMKEY104                        \ Fast master key bit 104 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000200 constant MCE2_MCE_FMKEYR3_FMKEY105                        \ Fast master key bit 105 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000400 constant MCE2_MCE_FMKEYR3_FMKEY106                        \ Fast master key bit 106 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00000800 constant MCE2_MCE_FMKEYR3_FMKEY107                        \ Fast master key bit 107 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00001000 constant MCE2_MCE_FMKEYR3_FMKEY108                        \ Fast master key bit 108 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00002000 constant MCE2_MCE_FMKEYR3_FMKEY109                        \ Fast master key bit 109 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00004000 constant MCE2_MCE_FMKEYR3_FMKEY110                        \ Fast master key bit 110 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00008000 constant MCE2_MCE_FMKEYR3_FMKEY111                        \ Fast master key bit 111 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00010000 constant MCE2_MCE_FMKEYR3_FMKEY112                        \ Fast master key bit 112 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00020000 constant MCE2_MCE_FMKEYR3_FMKEY113                        \ Fast master key bit 113 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00040000 constant MCE2_MCE_FMKEYR3_FMKEY114                        \ Fast master key bit 114 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00080000 constant MCE2_MCE_FMKEYR3_FMKEY115                        \ Fast master key bit 115 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00100000 constant MCE2_MCE_FMKEYR3_FMKEY116                        \ Fast master key bit 116 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00200000 constant MCE2_MCE_FMKEYR3_FMKEY117                        \ Fast master key bit 117 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00400000 constant MCE2_MCE_FMKEYR3_FMKEY118                        \ Fast master key bit 118 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$00800000 constant MCE2_MCE_FMKEYR3_FMKEY119                        \ Fast master key bit 119 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$01000000 constant MCE2_MCE_FMKEYR3_FMKEY120                        \ Fast master key bit 120 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$02000000 constant MCE2_MCE_FMKEYR3_FMKEY121                        \ Fast master key bit 121 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$04000000 constant MCE2_MCE_FMKEYR3_FMKEY122                        \ Fast master key bit 122 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$08000000 constant MCE2_MCE_FMKEYR3_FMKEY123                        \ Fast master key bit 123 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$10000000 constant MCE2_MCE_FMKEYR3_FMKEY124                        \ Fast master key bit 124 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$20000000 constant MCE2_MCE_FMKEYR3_FMKEY125                        \ Fast master key bit 125 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$40000000 constant MCE2_MCE_FMKEYR3_FMKEY126                        \ Fast master key bit 126 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.
$80000000 constant MCE2_MCE_FMKEYR3_FMKEY127                        \ Fast master key bit 127 This key is used by the MCE block cipher in fast mode, if CTXID=0x0 in MCE_REGCR register.


\
\ @brief MCE cipher context 1 configuration register
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_CC1CFGR_CCEN                            \ Cipher context enable
$00000002 constant MCE2_MCE_CC1CFGR_CCLOCK                          \ Cipher context lock Note: This bit is set once. If this bit is set, it can only be cleared to 0 if MCE is reset. Setting this bit forces KEYLOCK bit to 1.
$00000004 constant MCE2_MCE_CC1CFGR_KEYLOCK                         \ Key lock Note: This bit is set once. If this bit is set, it can only be cleared to 0 if MCE is reset.
$0000ff00 constant MCE2_MCE_CC1CFGR_KEYCRC                          \ Key CRC When KEYLOCK=0, KEYCRC information is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new KEYCRC computation starts as soon as a new valid sequence is initiated. KEYCRC bitfield reads as zero until a valid sequence is completed (after it return the computed CRC value). When GLOCK=1, KEYCRC bitfield always return the computed CRC value until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Note: CRC information is updated, and the key is usable by MCE, only after the last bit of the key has been written. When GLOCK=0 any write to MCE_CCxKEYR registers clears KEYCRC in MCE_CCxCFGR, and makes the cipher context key un-usable (bypass mode is selected instead). To be able to use the key again application must perform this sequence: write to KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). As KEYLOCK=1 all those writes are ignored, so the correct key is used instead.
$ffff0000 constant MCE2_MCE_CC1CFGR_VERSION                         \ Version This 16-bit bitfield must be correctly initialized before CCEN bit is set. Bitfield usage is defined in Section 35.4.6: MCE stream cipher encryption mode.


\
\ @brief MCE cipher context 1 nonce register 0
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC1NR0_SCNONCE                          \ Stream cipher nonce, bits [31:0] This register is used by stream cipher to compute keystream. It must be correctly initialize before CCEN bit is set in MCE_CCzCFGR register. Bitfield usage is defined in Section 35.4.6: MCE stream cipher encryption mode.


\
\ @brief MCE cipher context 1 nonce register 1
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC1NR1_SCNONCE                          \ Stream cipher nonce, bits [63:32] Refer to the MCE_CCzNR0 register for description of the SCNONCE[63:0] bitfield.


\
\ @brief MCE cipher context 1 key register 0
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC1KEYR0_KEY                            \ cipher key, bits [31:0] This register is used by the block or stream cipher of MCE when CTXID = z in encrypted region configuration register. KEY[127:0] must be correctly initialize before CCEN bit is set in MCE_CCzCFGR register.


\
\ @brief MCE cipher context 1 key register 1
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC1KEYR1_KEY                            \ cipher key, bits [63:32] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief MCE cipher context 1 key register 2
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC1KEYR2_KEY                            \ cipher key, bits [95:64] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief MCE cipher context 1 key register 3
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC1KEYR3_KEY                            \ cipher key, bits [127:96] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief MCE cipher context 2 configuration register
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000001 constant MCE2_MCE_CC2CFGR_CCEN                            \ Cipher context enable
$00000002 constant MCE2_MCE_CC2CFGR_CCLOCK                          \ Cipher context lock Note: This bit is set once. If this bit is set, it can only be cleared to 0 if MCE is reset. Setting this bit forces KEYLOCK bit to 1.
$00000004 constant MCE2_MCE_CC2CFGR_KEYLOCK                         \ Key lock Note: This bit is set once. If this bit is set, it can only be cleared to 0 if MCE is reset.
$0000ff00 constant MCE2_MCE_CC2CFGR_KEYCRC                          \ Key CRC When KEYLOCK=0, KEYCRC information is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new KEYCRC computation starts as soon as a new valid sequence is initiated. KEYCRC bitfield reads as zero until a valid sequence is completed (after it return the computed CRC value). When GLOCK=1, KEYCRC bitfield always return the computed CRC value until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Note: CRC information is updated, and the key is usable by MCE, only after the last bit of the key has been written. When GLOCK=0 any write to MCE_CCxKEYR registers clears KEYCRC in MCE_CCxCFGR, and makes the cipher context key un-usable (bypass mode is selected instead). To be able to use the key again application must perform this sequence: write to KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). As KEYLOCK=1 all those writes are ignored, so the correct key is used instead.
$ffff0000 constant MCE2_MCE_CC2CFGR_VERSION                         \ Version This 16-bit bitfield must be correctly initialized before CCEN bit is set. Bitfield usage is defined in Section 35.4.6: MCE stream cipher encryption mode.


\
\ @brief MCE cipher context 2 nonce register 0
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC2NR0_SCNONCE                          \ Stream cipher nonce, bits [31:0] This register is used by stream cipher to compute keystream. It must be correctly initialize before CCEN bit is set in MCE_CCzCFGR register. Bitfield usage is defined in Section 35.4.6: MCE stream cipher encryption mode.


\
\ @brief MCE cipher context 2 nonce register 1
\ Address offset: 0x278
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC2NR1_SCNONCE                          \ Stream cipher nonce, bits [63:32] Refer to the MCE_CCzNR0 register for description of the SCNONCE[63:0] bitfield.


\
\ @brief MCE cipher context 2 key register 0
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC2KEYR0_KEY                            \ cipher key, bits [31:0] This register is used by the block or stream cipher of MCE when CTXID = z in encrypted region configuration register. KEY[127:0] must be correctly initialize before CCEN bit is set in MCE_CCzCFGR register.


\
\ @brief MCE cipher context 2 key register 1
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC2KEYR1_KEY                            \ cipher key, bits [63:32] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief MCE cipher context 2 key register 2
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC2KEYR2_KEY                            \ cipher key, bits [95:64] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief MCE cipher context 2 key register 3
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000000 constant MCE2_MCE_CC2KEYR3_KEY                            \ cipher key, bits [127:96] Refer to the MCE_CCzKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief MCE2 global interrupt
\
$5200bc00 constant MCE2_MCE_CR    \ offset: 0x00 : MCE configuration register
$5200bc04 constant MCE2_MCE_SR    \ offset: 0x04 : MCE status register
$5200bc08 constant MCE2_MCE_IASR  \ offset: 0x08 : MCE illegal access status register
$5200bc0c constant MCE2_MCE_IACR  \ offset: 0x0C : MCE illegal access clear register
$5200bc10 constant MCE2_MCE_IAIER  \ offset: 0x10 : MCE illegal access interrupt enable register
$5200bc1c constant MCE2_MCE_PRIVCFGR  \ offset: 0x1C : MCE privileged configuration register
$5200bc20 constant MCE2_MCE_IAESR  \ offset: 0x20 : MCE illegal access error status register
$5200bc24 constant MCE2_MCE_IADDR  \ offset: 0x24 : MCE illegal address register
$5200bc40 constant MCE2_MCE_REGCR1  \ offset: 0x40 : MCE region 1 configuration register
$5200bc44 constant MCE2_MCE_SADDR1  \ offset: 0x44 : MCE start address for region 1 register
$5200bc48 constant MCE2_MCE_EADDR1  \ offset: 0x48 : MCE end address for region 1 register
$5200bc4c constant MCE2_MCE_ATTR1  \ offset: 0x4C : MCE attribute for region 1 register
$5200bc50 constant MCE2_MCE_REGCR2  \ offset: 0x50 : MCE region 2 configuration register
$5200bc54 constant MCE2_MCE_SADDR2  \ offset: 0x54 : MCE start address for region 2 register
$5200bc58 constant MCE2_MCE_EADDR2  \ offset: 0x58 : MCE end address for region 2 register
$5200bc5c constant MCE2_MCE_ATTR2  \ offset: 0x5C : MCE attribute for region 2 register
$5200bc60 constant MCE2_MCE_REGCR3  \ offset: 0x60 : MCE region 3 configuration register
$5200bc64 constant MCE2_MCE_SADDR3  \ offset: 0x64 : MCE start address for region 3 register
$5200bc68 constant MCE2_MCE_EADDR3  \ offset: 0x68 : MCE end address for region 3 register
$5200bc6c constant MCE2_MCE_ATTR3  \ offset: 0x6C : MCE attribute for region 3 register
$5200bc70 constant MCE2_MCE_REGCR4  \ offset: 0x70 : MCE region 4 configuration register
$5200bc74 constant MCE2_MCE_SADDR4  \ offset: 0x74 : MCE start address for region 4 register
$5200bc78 constant MCE2_MCE_EADDR4  \ offset: 0x78 : MCE end address for region 4 register
$5200bc7c constant MCE2_MCE_ATTR4  \ offset: 0x7C : MCE attribute for region 4 register
$5200be00 constant MCE2_MCE_MKEYR0  \ offset: 0x200 : MCE master key 0
$5200be04 constant MCE2_MCE_MKEYR1  \ offset: 0x204 : MCE master key 1
$5200be08 constant MCE2_MCE_MKEYR2  \ offset: 0x208 : MCE master key 2
$5200be0c constant MCE2_MCE_MKEYR3  \ offset: 0x20C : MCE master key 3
$5200be20 constant MCE2_MCE_FMKEYR0  \ offset: 0x220 : MCE fast master key 0
$5200be24 constant MCE2_MCE_FMKEYR1  \ offset: 0x224 : MCE fast master key 1
$5200be28 constant MCE2_MCE_FMKEYR2  \ offset: 0x228 : MCE fast master key 2
$5200be2c constant MCE2_MCE_FMKEYR3  \ offset: 0x22C : MCE fast master key 3
$5200be40 constant MCE2_MCE_CC1CFGR  \ offset: 0x240 : MCE cipher context 1 configuration register
$5200be44 constant MCE2_MCE_CC1NR0  \ offset: 0x244 : MCE cipher context 1 nonce register 0
$5200be48 constant MCE2_MCE_CC1NR1  \ offset: 0x248 : MCE cipher context 1 nonce register 1
$5200be4c constant MCE2_MCE_CC1KEYR0  \ offset: 0x24C : MCE cipher context 1 key register 0
$5200be50 constant MCE2_MCE_CC1KEYR1  \ offset: 0x250 : MCE cipher context 1 key register 1
$5200be54 constant MCE2_MCE_CC1KEYR2  \ offset: 0x254 : MCE cipher context 1 key register 2
$5200be58 constant MCE2_MCE_CC1KEYR3  \ offset: 0x258 : MCE cipher context 1 key register 3
$5200be70 constant MCE2_MCE_CC2CFGR  \ offset: 0x270 : MCE cipher context 2 configuration register
$5200be74 constant MCE2_MCE_CC2NR0  \ offset: 0x274 : MCE cipher context 2 nonce register 0
$5200be78 constant MCE2_MCE_CC2NR1  \ offset: 0x278 : MCE cipher context 2 nonce register 1
$5200be7c constant MCE2_MCE_CC2KEYR0  \ offset: 0x27C : MCE cipher context 2 key register 0
$5200be80 constant MCE2_MCE_CC2KEYR1  \ offset: 0x280 : MCE cipher context 2 key register 1
$5200be84 constant MCE2_MCE_CC2KEYR2  \ offset: 0x284 : MCE cipher context 2 key register 2
$5200be88 constant MCE2_MCE_CC2KEYR3  \ offset: 0x288 : MCE cipher context 2 key register 3

