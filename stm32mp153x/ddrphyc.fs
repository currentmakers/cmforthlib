\
\ @file ddrphyc.fs
\ @brief DDRPHYC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DDRPHYC_DEF

  [ifdef] DDRPHYC_DDRPHYC_RIDR_DEF
    \
    \ @brief DDRPHYC revision ID register
    \ Address offset: 0x00
    \ Reset value: 0x00410010
    \
    $00 constant DDRPHYC_PUBMNR                 \ [0x00 : 4] PUBMNR
    $04 constant DDRPHYC_PUBMDR                 \ [0x04 : 4] PUBMDR
    $08 constant DDRPHYC_PUBMJR                 \ [0x08 : 4] PUBMJR
    $0c constant DDRPHYC_PHYMNR                 \ [0x0c : 4] PHYMNR
    $10 constant DDRPHYC_PHYMDR                 \ [0x10 : 4] PHYMDR
    $14 constant DDRPHYC_PHYMJR                 \ [0x14 : 4] PHYMJR
    $18 constant DDRPHYC_UDRID                  \ [0x18 : 8] UDRID
  [then]


  [ifdef] DDRPHYC_DDRPHYC_PIR_DEF
    \
    \ @brief DDRPHYC PHY initialization register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_INIT                   \ [0x00] INIT
    $01 constant DDRPHYC_DLLSRST                \ [0x01] DLLSRST
    $02 constant DDRPHYC_DLLLOCK                \ [0x02] DLLLOCK
    $03 constant DDRPHYC_ZCAL                   \ [0x03] ZCAL
    $04 constant DDRPHYC_ITMSRST                \ [0x04] ITMSRST
    $05 constant DDRPHYC_DRAMRST                \ [0x05] DRAMRST
    $06 constant DDRPHYC_DRAMINIT               \ [0x06] DRAMINIT
    $07 constant DDRPHYC_QSTRN                  \ [0x07] QSTRN
    $08 constant DDRPHYC_RVTRN                  \ [0x08] RVTRN
    $10 constant DDRPHYC_ICPC                   \ [0x10] ICPC
    $11 constant DDRPHYC_DLLBYP                 \ [0x11] DLLBYP
    $12 constant DDRPHYC_CTLDINIT               \ [0x12] CTLDINIT
    $1c constant DDRPHYC_CLRSR                  \ [0x1c] CLRSR
    $1d constant DDRPHYC_LOCKBYP                \ [0x1d] LOCKBYP
    $1e constant DDRPHYC_ZCALBYP                \ [0x1e] ZCALBYP
    $1f constant DDRPHYC_INITBYP                \ [0x1f] INITBYP
  [then]


  [ifdef] DDRPHYC_DDRPHYC_PGCR_DEF
    \
    \ @brief DDRPHYC PHY global control register
    \ Address offset: 0x08
    \ Reset value: 0x01BC2E04
    \
    $00 constant DDRPHYC_ITMDMD                 \ [0x00] ITMDMD
    $01 constant DDRPHYC_DQSCFG                 \ [0x01] DQSCFG
    $02 constant DDRPHYC_DFTCMP                 \ [0x02] DFTCMP
    $03 constant DDRPHYC_DFTLMT                 \ [0x03 : 2] DFTLMT
    $05 constant DDRPHYC_DTOSEL                 \ [0x05 : 4] DTOSEL
    $09 constant DDRPHYC_CKEN                   \ [0x09 : 3] CKEN
    $0c constant DDRPHYC_CKDV                   \ [0x0c : 2] CKDV
    $0e constant DDRPHYC_CKINV                  \ [0x0e] CKINV
    $0f constant DDRPHYC_IOLB                   \ [0x0f] IOLB
    $10 constant DDRPHYC_IODDRM                 \ [0x10 : 2] IODDRM
    $12 constant DDRPHYC_RANKEN                 \ [0x12 : 4] RANKEN
    $16 constant DDRPHYC_ZKSEL                  \ [0x16 : 2] ZKSEL
    $18 constant DDRPHYC_PDDISDX                \ [0x18] PDDISDX
    $19 constant DDRPHYC_RFSHDT                 \ [0x19 : 4] RFSHDT
    $1d constant DDRPHYC_LBDQSS                 \ [0x1d] LBDQSS
    $1e constant DDRPHYC_LBGDQS                 \ [0x1e] LBGDQS
    $1f constant DDRPHYC_LBMODE                 \ [0x1f] LBMODE
  [then]


  [ifdef] DDRPHYC_DDRPHYC_PGSR_DEF
    \
    \ @brief DDRPHYC PHY global status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_IDONE                  \ [0x00] IDONE
    $01 constant DDRPHYC_DLDONE                 \ [0x01] DLDONE
    $02 constant DDRPHYC_ZCDDONE                \ [0x02] ZCDDONE
    $03 constant DDRPHYC_DIDONE                 \ [0x03] DIDONE
    $04 constant DDRPHYC_DTDONE                 \ [0x04] DTDONE
    $05 constant DDRPHYC_DTERR                  \ [0x05] DTERR
    $06 constant DDRPHYC_DTIERR                 \ [0x06] DTIERR
    $07 constant DDRPHYC_DFTERR                 \ [0x07] DFTERR
    $08 constant DDRPHYC_RVERR                  \ [0x08] RVERR
    $09 constant DDRPHYC_RVEIRR                 \ [0x09] RVEIRR
    $1f constant DDRPHYC_TQ                     \ [0x1f] TQ
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DLLGCR_DEF
    \
    \ @brief DDRPHYC DDR global control register
    \ Address offset: 0x10
    \ Reset value: 0x03737000
    \
    $00 constant DDRPHYC_DRES                   \ [0x00 : 2] DRES
    $02 constant DDRPHYC_IPUMP                  \ [0x02 : 3] IPUMP
    $05 constant DDRPHYC_TESTEN                 \ [0x05] TESTEN
    $06 constant DDRPHYC_DTC                    \ [0x06 : 3] DTC
    $09 constant DDRPHYC_ATC                    \ [0x09 : 2] ATC
    $0b constant DDRPHYC_TESTSW                 \ [0x0b] TESTSW
    $0c constant DDRPHYC_MBIAS                  \ [0x0c : 8] MBIAS
    $14 constant DDRPHYC_SBIAS2_0               \ [0x14 : 3] SBIAS2_0
    $17 constant DDRPHYC_BPS200                 \ [0x17] BPS200
    $18 constant DDRPHYC_SBIAS5_3               \ [0x18 : 3] SBIAS5_3
    $1b constant DDRPHYC_FDTRMSL                \ [0x1b : 2] FDTRMSL
    $1d constant DDRPHYC_LOCKDET                \ [0x1d] LOCKDET
    $1e constant DDRPHYC_DLLRSVD2               \ [0x1e : 2] DLLRSVD2
  [then]


  [ifdef] DDRPHYC_DDRPHYC_ACDLLCR_DEF
    \
    \ @brief DDRPHYC AC DLL control register
    \ Address offset: 0x14
    \ Reset value: 0x40000000
    \
    $06 constant DDRPHYC_MFBDLY                 \ [0x06 : 3] MFBDLY
    $09 constant DDRPHYC_MFWDLY                 \ [0x09 : 3] MFWDLY
    $12 constant DDRPHYC_ATESTEN                \ [0x12] ATESTEN
    $1e constant DDRPHYC_DLLSRST                \ [0x1e] DLLSRST
    $1f constant DDRPHYC_DLLDIS                 \ [0x1f] DLLDIS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_PTR0_DEF
    \
    \ @brief DDRPHYC PT register 0
    \ Address offset: 0x18
    \ Reset value: 0x0022AF9B
    \
    $00 constant DDRPHYC_TDLLSRST               \ [0x00 : 6] TDLLSRST
    $06 constant DDRPHYC_TDLLLOCK               \ [0x06 : 12] TDLLLOCK
    $12 constant DDRPHYC_TITMSRST               \ [0x12 : 4] TITMSRST
  [then]


  [ifdef] DDRPHYC_DDRPHYC_PTR1_DEF
    \
    \ @brief DDRPHYC PT register 1
    \ Address offset: 0x1C
    \ Reset value: 0x0604111D
    \
    $00 constant DDRPHYC_TDINIT0                \ [0x00 : 19] TDINIT0
    $13 constant DDRPHYC_TDINIT1                \ [0x13 : 8] TDINIT1
  [then]


  [ifdef] DDRPHYC_DDRPHYC_PTR2_DEF
    \
    \ @brief DDRPHYC PT register 2
    \ Address offset: 0x20
    \ Reset value: 0x042DA072
    \
    $00 constant DDRPHYC_TDINIT2                \ [0x00 : 17] TDINIT2
    $11 constant DDRPHYC_TDINIT3                \ [0x11 : 10] TDINIT3
  [then]


  [ifdef] DDRPHYC_DDRPHYC_ACIOCR_DEF
    \
    \ @brief DDRPHYC ACIOC register
    \ Address offset: 0x24
    \ Reset value: 0x33C03812
    \
    $00 constant DDRPHYC_ACIOM                  \ [0x00] ACIOM
    $01 constant DDRPHYC_ACOE                   \ [0x01] ACOE
    $02 constant DDRPHYC_ACODT                  \ [0x02] ACODT
    $03 constant DDRPHYC_ACPDD                  \ [0x03] ACPDD
    $04 constant DDRPHYC_ACPDR                  \ [0x04] ACPDR
    $05 constant DDRPHYC_CKODT                  \ [0x05 : 3] CKODT
    $08 constant DDRPHYC_CKPDD                  \ [0x08 : 3] CKPDD
    $0b constant DDRPHYC_CKPDR                  \ [0x0b : 3] CKPDR
    $0e constant DDRPHYC_RANKODT                \ [0x0e] RANKODT
    $12 constant DDRPHYC_CSPDD                  \ [0x12] CSPDD
    $16 constant DDRPHYC_RANKPDR                \ [0x16] RANKPDR
    $1a constant DDRPHYC_RSTODT                 \ [0x1a] RSTODT
    $1b constant DDRPHYC_RSTPDD                 \ [0x1b] RSTPDD
    $1c constant DDRPHYC_RSTPDR                 \ [0x1c] RSTPDR
    $1d constant DDRPHYC_RSTIOM                 \ [0x1d] RSTIOM
    $1e constant DDRPHYC_ACSR                   \ [0x1e : 2] ACSR
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DXCCR_DEF
    \
    \ @brief DDRPHYC DXCC register
    \ Address offset: 0x28
    \ Reset value: 0x00000800
    \
    $00 constant DDRPHYC_DXODT                  \ [0x00] DXODT
    $01 constant DDRPHYC_DXIOM                  \ [0x01] DXIOM
    $02 constant DDRPHYC_DXPDD                  \ [0x02] DXPDD
    $03 constant DDRPHYC_DXPDR                  \ [0x03] DXPDR
    $04 constant DDRPHYC_DQSRES                 \ [0x04 : 4] DQSRES
    $08 constant DDRPHYC_DQSNRES                \ [0x08 : 4] DQSNRES
    $0e constant DDRPHYC_DQSNRST                \ [0x0e] DQSNRST
    $0f constant DDRPHYC_RVSEL                  \ [0x0f] RVSEL
    $10 constant DDRPHYC_AWDT                   \ [0x10] AWDT
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DSGCR_DEF
    \
    \ @brief DDRPHYC DSGC register
    \ Address offset: 0x2C
    \ Reset value: 0xFA00001F
    \
    $00 constant DDRPHYC_PUREN                  \ [0x00] PUREN
    $01 constant DDRPHYC_BDISEN                 \ [0x01] BDISEN
    $02 constant DDRPHYC_ZUEN                   \ [0x02] ZUEN
    $03 constant DDRPHYC_LPIOPD                 \ [0x03] LPIOPD
    $04 constant DDRPHYC_LPDLLPD                \ [0x04] LPDLLPD
    $05 constant DDRPHYC_DQSGX                  \ [0x05 : 3] DQSGX
    $08 constant DDRPHYC_DQSGE                  \ [0x08 : 3] DQSGE
    $0b constant DDRPHYC_NOBUB                  \ [0x0b] NOBUB
    $0c constant DDRPHYC_FXDLAT                 \ [0x0c] FXDLAT
    $10 constant DDRPHYC_CKEPDD                 \ [0x10] CKEPDD
    $14 constant DDRPHYC_ODTPDD                 \ [0x14] ODTPDD
    $18 constant DDRPHYC_NL2PD                  \ [0x18] NL2PD
    $19 constant DDRPHYC_NL2OE                  \ [0x19] NL2OE
    $1a constant DDRPHYC_TPDPD                  \ [0x1a] TPDPD
    $1b constant DDRPHYC_TPDOE                  \ [0x1b] TPDOE
    $1c constant DDRPHYC_CKOE                   \ [0x1c] CKOE
    $1d constant DDRPHYC_ODTOE                  \ [0x1d] ODTOE
    $1e constant DDRPHYC_RSTOE                  \ [0x1e] RSTOE
    $1f constant DDRPHYC_CKEOE                  \ [0x1f] CKEOE
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DCR_DEF
    \
    \ @brief DDRPHYC DC register
    \ Address offset: 0x30
    \ Reset value: 0x0000000B
    \
    $00 constant DDRPHYC_DDRMD                  \ [0x00 : 3] DDRMD
    $03 constant DDRPHYC_DDR8BNK                \ [0x03] DDR8BNK
    $04 constant DDRPHYC_PDQ                    \ [0x04 : 3] PDQ
    $07 constant DDRPHYC_MPRDQ                  \ [0x07] MPRDQ
    $08 constant DDRPHYC_DDRTYPE                \ [0x08 : 2] DDRTYPE
    $1b constant DDRPHYC_NOSRA                  \ [0x1b] NOSRA
    $1c constant DDRPHYC_DDR2T                  \ [0x1c] DDR2T
    $1d constant DDRPHYC_UDIMM                  \ [0x1d] UDIMM
    $1e constant DDRPHYC_RDIMM                  \ [0x1e] RDIMM
    $1f constant DDRPHYC_TPD                    \ [0x1f] TPD
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DTPR0_DEF
    \
    \ @brief DDRPHYC DTP register 0
    \ Address offset: 0x34
    \ Reset value: 0x3012666E
    \
    $00 constant DDRPHYC_TMRD                   \ [0x00 : 2] TMRD
    $02 constant DDRPHYC_TRTP                   \ [0x02 : 3] TRTP
    $05 constant DDRPHYC_TWTR                   \ [0x05 : 3] TWTR
    $08 constant DDRPHYC_TRP                    \ [0x08 : 4] TRP
    $0c constant DDRPHYC_TRCD                   \ [0x0c : 4] TRCD
    $10 constant DDRPHYC_TRAS                   \ [0x10 : 5] TRAS
    $15 constant DDRPHYC_TRRD                   \ [0x15 : 4] TRRD
    $19 constant DDRPHYC_TRC                    \ [0x19 : 6] TRC
    $1f constant DDRPHYC_TCCD                   \ [0x1f] TCCD
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DTPR1_DEF
    \
    \ @brief DDRPHYC DTP register 1
    \ Address offset: 0x38
    \ Reset value: 0x0A030090
    \
    $00 constant DDRPHYC_TAOND                  \ [0x00 : 2] TAOND
    $02 constant DDRPHYC_TRTW                   \ [0x02] TRTW
    $03 constant DDRPHYC_TFAW                   \ [0x03 : 6] TFAW
    $09 constant DDRPHYC_TMOD                   \ [0x09 : 2] TMOD
    $0b constant DDRPHYC_TRTODT                 \ [0x0b] TRTODT
    $10 constant DDRPHYC_TRFC                   \ [0x10 : 8] TRFC
    $18 constant DDRPHYC_TDQSCKMIN              \ [0x18 : 3] TDQSCKMIN
    $1b constant DDRPHYC_TDQSCKMAX              \ [0x1b : 3] TDQSCKMAX
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DTPR2_DEF
    \
    \ @brief DDRPHYC DTP register 2
    \ Address offset: 0x3C
    \ Reset value: 0x20040D84
    \
    $00 constant DDRPHYC_TXS                    \ [0x00 : 10] TXS
    $0a constant DDRPHYC_TXP                    \ [0x0a : 5] TXP
    $0f constant DDRPHYC_TCKE                   \ [0x0f : 4] TCKE
    $13 constant DDRPHYC_TDLLK                  \ [0x13 : 10] TDLLK
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DDR3_MR0_DEF
    \
    \ @brief DDRPHYC MR0 register for DDR3
    \ Address offset: 0x40
    \ Reset value: 0x00000A52
    \
    $00 constant DDRPHYC_BL                     \ [0x00 : 2] BL
    $02 constant DDRPHYC_CL0                    \ [0x02] CL0
    $03 constant DDRPHYC_BT                     \ [0x03] BT
    $04 constant DDRPHYC_CL                     \ [0x04 : 3] CL
    $07 constant DDRPHYC_TM                     \ [0x07] TM
    $08 constant DDRPHYC_DR                     \ [0x08] DR
    $09 constant DDRPHYC_WR                     \ [0x09 : 3] WR
    $0c constant DDRPHYC_PD                     \ [0x0c] PD
    $0d constant DDRPHYC_RSVD                   \ [0x0d : 3] RSVD
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DDR3_MR1_DEF
    \
    \ @brief DDRPHYC MR1 register for DDR3
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_DE                     \ [0x00] DE
    $01 constant DDRPHYC_DIC0                   \ [0x01] DIC0
    $02 constant DDRPHYC_RTT0                   \ [0x02] RTT0
    $03 constant DDRPHYC_AL                     \ [0x03 : 2] AL
    $05 constant DDRPHYC_DIC1                   \ [0x05] DIC1
    $06 constant DDRPHYC_RTT1                   \ [0x06] RTT1
    $07 constant DDRPHYC_LEVEL                  \ [0x07] LEVEL
    $09 constant DDRPHYC_RTT2                   \ [0x09] RTT2
    $0b constant DDRPHYC_TDQS                   \ [0x0b] TDQS
    $0c constant DDRPHYC_QOFF                   \ [0x0c] QOFF
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DDR3_MR2_DEF
    \
    \ @brief DDRPHYC MR2 register for DDR3
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_PASR                   \ [0x00 : 3] PASR
    $03 constant DDRPHYC_CWL                    \ [0x03 : 3] CWL
    $06 constant DDRPHYC_ASR                    \ [0x06] ASR
    $07 constant DDRPHYC_SRT                    \ [0x07] SRT
    $09 constant DDRPHYC_RTTWR                  \ [0x09 : 2] RTTWR
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DDR3_MR3_DEF
    \
    \ @brief DDRPHYC MR3 register for DDR3
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_MPRLOC                 \ [0x00 : 2] MPRLOC
    $02 constant DDRPHYC_MPR                    \ [0x02] MPR
  [then]


  [ifdef] DDRPHYC_DDRPHYC_ODTCR_DEF
    \
    \ @brief DDRPHYC ODTC register
    \ Address offset: 0x50
    \ Reset value: 0x84210000
    \
    $00 constant DDRPHYC_RDODT                  \ [0x00] RDODT
    $10 constant DDRPHYC_WRODT                  \ [0x10] WRODT
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DTAR_DEF
    \
    \ @brief DDRPHYC DTA register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_DTCOL                  \ [0x00 : 12] DTCOL
    $0c constant DDRPHYC_DTROW                  \ [0x0c : 16] DTROW
    $1c constant DDRPHYC_DTBANK                 \ [0x1c : 3] DTBANK
    $1f constant DDRPHYC_DTMPR                  \ [0x1f] DTMPR
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DTDR0_DEF
    \
    \ @brief DDRPHYC DTD register 0
    \ Address offset: 0x58
    \ Reset value: 0xDD22EE11
    \
    $00 constant DDRPHYC_DTBYTE0                \ [0x00 : 8] DTBYTE0
    $08 constant DDRPHYC_DTBYTE1                \ [0x08 : 8] DTBYTE1
    $10 constant DDRPHYC_DTBYTE2                \ [0x10 : 8] DTBYTE2
    $18 constant DDRPHYC_DTBYTE3                \ [0x18 : 8] DTBYTE3
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DTDR1_DEF
    \
    \ @brief DDRPHYC DTD register 1
    \ Address offset: 0x5C
    \ Reset value: 0x7788BB44
    \
    $00 constant DDRPHYC_DTBYTE4                \ [0x00 : 8] DTBYTE4
    $08 constant DDRPHYC_DTBYTE5                \ [0x08 : 8] DTBYTE5
    $10 constant DDRPHYC_DTBYTE6                \ [0x10 : 8] DTBYTE6
    $18 constant DDRPHYC_DTBYTE7                \ [0x18 : 8] DTBYTE7
  [then]


  [ifdef] DDRPHYC_DDRPHYC_GPR0_DEF
    \
    \ @brief DDRPHYC general purpose register 0
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_GPR0                   \ [0x00 : 32] GPR0
  [then]


  [ifdef] DDRPHYC_DDRPHYC_GPR1_DEF
    \
    \ @brief DDRPHYC general purpose register 1
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_GPR1                   \ [0x00 : 32] GPR1
  [then]


  [ifdef] DDRPHYC_DDRPHYC_ZQ0CR0_DEF
    \
    \ @brief DDRPHYC ZQ0C register 0
    \ Address offset: 0x180
    \ Reset value: 0x0000014A
    \
    $00 constant DDRPHYC_ZDATA                  \ [0x00 : 20] ZDATA
    $1c constant DDRPHYC_ZDEN                   \ [0x1c] ZDEN
    $1d constant DDRPHYC_ZCALBYP                \ [0x1d] ZCALBYP
    $1e constant DDRPHYC_ZCAL                   \ [0x1e] ZCAL
    $1f constant DDRPHYC_ZQPD                   \ [0x1f] ZQPD
  [then]


  [ifdef] DDRPHYC_DDRPHYC_ZQ0CR1_DEF
    \
    \ @brief DDRPHYC ZQ0CR1 register
    \ Address offset: 0x184
    \ Reset value: 0x0000007B
    \
    $00 constant DDRPHYC_ZPROG                  \ [0x00 : 8] ZPROG
  [then]


  [ifdef] DDRPHYC_DDRPHYC_ZQ0SR0_DEF
    \
    \ @brief DDRPHYC ZQ0S register 0
    \ Address offset: 0x188
    \ Reset value: 0x0000014A
    \
    $00 constant DDRPHYC_ZCTRL                  \ [0x00 : 20] ZCTRL
    $1e constant DDRPHYC_ZERR                   \ [0x1e] ZERR
    $1f constant DDRPHYC_ZDONE                  \ [0x1f] ZDONE
  [then]


  [ifdef] DDRPHYC_DDRPHYC_ZQ0SR1_DEF
    \
    \ @brief DDRPHYC ZQ0S register 1
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_ZPD                    \ [0x00 : 2] ZPD
    $02 constant DDRPHYC_ZPU                    \ [0x02 : 2] ZPU
    $04 constant DDRPHYC_OPD                    \ [0x04 : 2] OPD
    $06 constant DDRPHYC_OPU                    \ [0x06 : 2] OPU
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX0GCR_DEF
    \
    \ @brief DDRPHYC byte lane 0 GC register
    \ Address offset: 0x1C0
    \ Reset value: 0x0000EE81
    \
    $00 constant DDRPHYC_DXEN                   \ [0x00] DXEN
    $01 constant DDRPHYC_DQSODT                 \ [0x01] DQSODT
    $02 constant DDRPHYC_DQODT                  \ [0x02] DQODT
    $03 constant DDRPHYC_DXIOM                  \ [0x03] DXIOM
    $04 constant DDRPHYC_DXPDD                  \ [0x04] DXPDD
    $05 constant DDRPHYC_DXPDR                  \ [0x05] DXPDR
    $06 constant DDRPHYC_DQSRPD                 \ [0x06] DQSRPD
    $07 constant DDRPHYC_DSEN                   \ [0x07 : 2] DSEN
    $09 constant DDRPHYC_DQSRTT                 \ [0x09] DQSRTT
    $0a constant DDRPHYC_DQRTT                  \ [0x0a] DQRTT
    $0b constant DDRPHYC_RTTOH                  \ [0x0b : 2] RTTOH
    $0d constant DDRPHYC_RTTOAL                 \ [0x0d] RTTOAL
    $0e constant DDRPHYC_R0RVSL                 \ [0x0e : 3] R0RVSL
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX0GSR0_DEF
    \
    \ @brief DDRPHYC byte lane 0 GS register 0
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_DTDONE                 \ [0x00] DTDONE
    $04 constant DDRPHYC_DTERR                  \ [0x04] DTERR
    $08 constant DDRPHYC_DTIERR                 \ [0x08] DTIERR
    $0d constant DDRPHYC_DTPASS                 \ [0x0d : 3] DTPASS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX0GSR1_DEF
    \
    \ @brief DDRPHYC byte lane 0 GS register 1
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_DFTERR                 \ [0x00] DFTERR
    $04 constant DDRPHYC_DQSDFT                 \ [0x04 : 2] DQSDFT
    $0c constant DDRPHYC_RVERR                  \ [0x0c] RVERR
    $10 constant DDRPHYC_RVIERR                 \ [0x10] RVIERR
    $14 constant DDRPHYC_RVPASS                 \ [0x14 : 3] RVPASS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX0DLLCR_DEF
    \
    \ @brief DDRPHYC byte lane 0 DLLC register
    \ Address offset: 0x1CC
    \ Reset value: 0x40000000
    \
    $00 constant DDRPHYC_SFBDLY                 \ [0x00 : 3] SFBDLY
    $03 constant DDRPHYC_SFWDLY                 \ [0x03 : 3] SFWDLY
    $06 constant DDRPHYC_MFBDLY                 \ [0x06 : 3] MFBDLY
    $09 constant DDRPHYC_MFWDLY                 \ [0x09 : 3] MFWDLY
    $0c constant DDRPHYC_SSTART                 \ [0x0c : 2] SSTART
    $0e constant DDRPHYC_SDPHASE                \ [0x0e : 4] SDPHASE
    $12 constant DDRPHYC_ATESTEN                \ [0x12] ATESTEN
    $13 constant DDRPHYC_SDLBMODE               \ [0x13] SDLBMODE
    $1e constant DDRPHYC_DLLSRST                \ [0x1e] DLLSRST
    $1f constant DDRPHYC_DLLDIS                 \ [0x1f] DLLDIS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX0DQTR_DEF
    \
    \ @brief DDRPHYC byte lane 0 DQT register
    \ Address offset: 0x1D0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant DDRPHYC_DQDLY0                 \ [0x00 : 4] DQDLY0
    $04 constant DDRPHYC_DQDLY1                 \ [0x04 : 4] DQDLY1
    $08 constant DDRPHYC_DQDLY2                 \ [0x08 : 4] DQDLY2
    $0c constant DDRPHYC_DQDLY3                 \ [0x0c : 4] DQDLY3
    $10 constant DDRPHYC_DQDLY4                 \ [0x10 : 4] DQDLY4
    $14 constant DDRPHYC_DQDLY5                 \ [0x14 : 4] DQDLY5
    $18 constant DDRPHYC_DQDLY6                 \ [0x18 : 4] DQDLY6
    $1c constant DDRPHYC_DQDLY7                 \ [0x1c : 4] DQDLY7
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX0DQSTR_DEF
    \
    \ @brief DDRPHYC byte lane 0 DQST register
    \ Address offset: 0x1D4
    \ Reset value: 0x3DB02000
    \
    $00 constant DDRPHYC_R0DGSL                 \ [0x00 : 3] R0DGSL
    $0c constant DDRPHYC_R0DGPS                 \ [0x0c : 2] R0DGPS
    $14 constant DDRPHYC_DQSDLY                 \ [0x14 : 3] DQSDLY
    $17 constant DDRPHYC_DQSNDLY                \ [0x17 : 3] DQSNDLY
    $1a constant DDRPHYC_DMDLY                  \ [0x1a : 4] DMDLY
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX1GCR_DEF
    \
    \ @brief DDRPHYC byte lane 1 GC register
    \ Address offset: 0x200
    \ Reset value: 0x0000EE81
    \
    $00 constant DDRPHYC_DXEN                   \ [0x00] DXEN
    $01 constant DDRPHYC_DQSODT                 \ [0x01] DQSODT
    $02 constant DDRPHYC_DQODT                  \ [0x02] DQODT
    $03 constant DDRPHYC_DXIOM                  \ [0x03] DXIOM
    $04 constant DDRPHYC_DXPDD                  \ [0x04] DXPDD
    $05 constant DDRPHYC_DXPDR                  \ [0x05] DXPDR
    $06 constant DDRPHYC_DQSRPD                 \ [0x06] DQSRPD
    $07 constant DDRPHYC_DSEN                   \ [0x07 : 2] DSEN
    $09 constant DDRPHYC_DQSRTT                 \ [0x09] DQSRTT
    $0a constant DDRPHYC_DQRTT                  \ [0x0a] DQRTT
    $0b constant DDRPHYC_RTTOH                  \ [0x0b : 2] RTTOH
    $0d constant DDRPHYC_RTTOAL                 \ [0x0d] RTTOAL
    $0e constant DDRPHYC_R0RVSL                 \ [0x0e : 3] R0RVSL
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX1GSR0_DEF
    \
    \ @brief DDRPHYC byte lane 1 GS register 0
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_DTDONE                 \ [0x00] DTDONE
    $04 constant DDRPHYC_DTERR                  \ [0x04] DTERR
    $08 constant DDRPHYC_DTIERR                 \ [0x08] DTIERR
    $0d constant DDRPHYC_DTPASS                 \ [0x0d : 3] DTPASS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX1GSR1_DEF
    \
    \ @brief DDRPHYC byte lane 1 GS register 1
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_DFTERR                 \ [0x00] DFTERR
    $04 constant DDRPHYC_DQSDFT                 \ [0x04 : 2] DQSDFT
    $0c constant DDRPHYC_RVERR                  \ [0x0c] RVERR
    $10 constant DDRPHYC_RVIERR                 \ [0x10] RVIERR
    $14 constant DDRPHYC_RVPASS                 \ [0x14 : 3] RVPASS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX1DLLCR_DEF
    \
    \ @brief DDRPHYC byte lane 1 DLLC register
    \ Address offset: 0x20C
    \ Reset value: 0x40000000
    \
    $00 constant DDRPHYC_SFBDLY                 \ [0x00 : 3] SFBDLY
    $03 constant DDRPHYC_SFWDLY                 \ [0x03 : 3] SFWDLY
    $06 constant DDRPHYC_MFBDLY                 \ [0x06 : 3] MFBDLY
    $09 constant DDRPHYC_MFWDLY                 \ [0x09 : 3] MFWDLY
    $0c constant DDRPHYC_SSTART                 \ [0x0c : 2] SSTART
    $0e constant DDRPHYC_SDPHASE                \ [0x0e : 4] SDPHASE
    $12 constant DDRPHYC_ATESTEN                \ [0x12] ATESTEN
    $13 constant DDRPHYC_SDLBMODE               \ [0x13] SDLBMODE
    $1e constant DDRPHYC_DLLSRST                \ [0x1e] DLLSRST
    $1f constant DDRPHYC_DLLDIS                 \ [0x1f] DLLDIS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX1DQTR_DEF
    \
    \ @brief DDRPHYC byte lane 1 DQT register
    \ Address offset: 0x210
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant DDRPHYC_DQDLY0                 \ [0x00 : 4] DQDLY0
    $04 constant DDRPHYC_DQDLY1                 \ [0x04 : 4] DQDLY1
    $08 constant DDRPHYC_DQDLY2                 \ [0x08 : 4] DQDLY2
    $0c constant DDRPHYC_DQDLY3                 \ [0x0c : 4] DQDLY3
    $10 constant DDRPHYC_DQDLY4                 \ [0x10 : 4] DQDLY4
    $14 constant DDRPHYC_DQDLY5                 \ [0x14 : 4] DQDLY5
    $18 constant DDRPHYC_DQDLY6                 \ [0x18 : 4] DQDLY6
    $1c constant DDRPHYC_DQDLY7                 \ [0x1c : 4] DQDLY7
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX1DQSTR_DEF
    \
    \ @brief DDRPHYC byte lane 1 DQST register
    \ Address offset: 0x214
    \ Reset value: 0x3DB02000
    \
    $00 constant DDRPHYC_R0DGSL                 \ [0x00 : 3] R0DGSL
    $0c constant DDRPHYC_R0DGPS                 \ [0x0c : 2] R0DGPS
    $14 constant DDRPHYC_DQSDLY                 \ [0x14 : 3] DQSDLY
    $17 constant DDRPHYC_DQSNDLY                \ [0x17 : 3] DQSNDLY
    $1a constant DDRPHYC_DMDLY                  \ [0x1a : 4] DMDLY
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX2GCR_DEF
    \
    \ @brief DDRPHYC byte lane 2 GC register
    \ Address offset: 0x240
    \ Reset value: 0x0000EE81
    \
    $00 constant DDRPHYC_DXEN                   \ [0x00] DXEN
    $01 constant DDRPHYC_DQSODT                 \ [0x01] DQSODT
    $02 constant DDRPHYC_DQODT                  \ [0x02] DQODT
    $03 constant DDRPHYC_DXIOM                  \ [0x03] DXIOM
    $04 constant DDRPHYC_DXPDD                  \ [0x04] DXPDD
    $05 constant DDRPHYC_DXPDR                  \ [0x05] DXPDR
    $06 constant DDRPHYC_DQSRPD                 \ [0x06] DQSRPD
    $07 constant DDRPHYC_DSEN                   \ [0x07 : 2] DSEN
    $09 constant DDRPHYC_DQSRTT                 \ [0x09] DQSRTT
    $0a constant DDRPHYC_DQRTT                  \ [0x0a] DQRTT
    $0b constant DDRPHYC_RTTOH                  \ [0x0b : 2] RTTOH
    $0d constant DDRPHYC_RTTOAL                 \ [0x0d] RTTOAL
    $0e constant DDRPHYC_R0RVSL                 \ [0x0e : 3] R0RVSL
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX2GSR0_DEF
    \
    \ @brief DDRPHYC byte lane 2 GS register 0
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_DTDONE                 \ [0x00] DTDONE
    $04 constant DDRPHYC_DTERR                  \ [0x04] DTERR
    $08 constant DDRPHYC_DTIERR                 \ [0x08] DTIERR
    $0d constant DDRPHYC_DTPASS                 \ [0x0d : 3] DTPASS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX2GSR1_DEF
    \
    \ @brief DDRPHYC byte lane 2 GS register 1
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_DFTERR                 \ [0x00] DFTERR
    $04 constant DDRPHYC_DQSDFT                 \ [0x04 : 2] DQSDFT
    $0c constant DDRPHYC_RVERR                  \ [0x0c] RVERR
    $10 constant DDRPHYC_RVIERR                 \ [0x10] RVIERR
    $14 constant DDRPHYC_RVPASS                 \ [0x14 : 3] RVPASS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX2DLLCR_DEF
    \
    \ @brief DDRPHYC byte lane 2 DLLC register
    \ Address offset: 0x24C
    \ Reset value: 0x40000000
    \
    $00 constant DDRPHYC_SFBDLY                 \ [0x00 : 3] SFBDLY
    $03 constant DDRPHYC_SFWDLY                 \ [0x03 : 3] SFWDLY
    $06 constant DDRPHYC_MFBDLY                 \ [0x06 : 3] MFBDLY
    $09 constant DDRPHYC_MFWDLY                 \ [0x09 : 3] MFWDLY
    $0c constant DDRPHYC_SSTART                 \ [0x0c : 2] SSTART
    $0e constant DDRPHYC_SDPHASE                \ [0x0e : 4] SDPHASE
    $12 constant DDRPHYC_ATESTEN                \ [0x12] ATESTEN
    $13 constant DDRPHYC_SDLBMODE               \ [0x13] SDLBMODE
    $1e constant DDRPHYC_DLLSRST                \ [0x1e] DLLSRST
    $1f constant DDRPHYC_DLLDIS                 \ [0x1f] DLLDIS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX2DQTR_DEF
    \
    \ @brief DDRPHYC byte lane 2 DQT register
    \ Address offset: 0x250
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant DDRPHYC_DQDLY0                 \ [0x00 : 4] DQDLY0
    $04 constant DDRPHYC_DQDLY1                 \ [0x04 : 4] DQDLY1
    $08 constant DDRPHYC_DQDLY2                 \ [0x08 : 4] DQDLY2
    $0c constant DDRPHYC_DQDLY3                 \ [0x0c : 4] DQDLY3
    $10 constant DDRPHYC_DQDLY4                 \ [0x10 : 4] DQDLY4
    $14 constant DDRPHYC_DQDLY5                 \ [0x14 : 4] DQDLY5
    $18 constant DDRPHYC_DQDLY6                 \ [0x18 : 4] DQDLY6
    $1c constant DDRPHYC_DQDLY7                 \ [0x1c : 4] DQDLY7
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX2DQSTR_DEF
    \
    \ @brief DDRPHYC byte lane 2 DQST register
    \ Address offset: 0x254
    \ Reset value: 0x3DB02000
    \
    $00 constant DDRPHYC_R0DGSL                 \ [0x00 : 3] R0DGSL
    $0c constant DDRPHYC_R0DGPS                 \ [0x0c : 2] R0DGPS
    $14 constant DDRPHYC_DQSDLY                 \ [0x14 : 3] DQSDLY
    $17 constant DDRPHYC_DQSNDLY                \ [0x17 : 3] DQSNDLY
    $1a constant DDRPHYC_DMDLY                  \ [0x1a : 4] DMDLY
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX3GCR_DEF
    \
    \ @brief DDRPHYC byte lane 3 GC register
    \ Address offset: 0x280
    \ Reset value: 0x0000EE81
    \
    $00 constant DDRPHYC_DXEN                   \ [0x00] DXEN
    $01 constant DDRPHYC_DQSODT                 \ [0x01] DQSODT
    $02 constant DDRPHYC_DQODT                  \ [0x02] DQODT
    $03 constant DDRPHYC_DXIOM                  \ [0x03] DXIOM
    $04 constant DDRPHYC_DXPDD                  \ [0x04] DXPDD
    $05 constant DDRPHYC_DXPDR                  \ [0x05] DXPDR
    $06 constant DDRPHYC_DQSRPD                 \ [0x06] DQSRPD
    $07 constant DDRPHYC_DSEN                   \ [0x07 : 2] DSEN
    $09 constant DDRPHYC_DQSRTT                 \ [0x09] DQSRTT
    $0a constant DDRPHYC_DQRTT                  \ [0x0a] DQRTT
    $0b constant DDRPHYC_RTTOH                  \ [0x0b : 2] RTTOH
    $0d constant DDRPHYC_RTTOAL                 \ [0x0d] RTTOAL
    $0e constant DDRPHYC_R0RVSL                 \ [0x0e : 3] R0RVSL
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX3GSR0_DEF
    \
    \ @brief DDRPHYC byte lane 3 GS register 0
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_DTDONE                 \ [0x00] DTDONE
    $04 constant DDRPHYC_DTERR                  \ [0x04] DTERR
    $08 constant DDRPHYC_DTIERR                 \ [0x08] DTIERR
    $0d constant DDRPHYC_DTPASS                 \ [0x0d : 3] DTPASS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX3GSR1_DEF
    \
    \ @brief DDRPHYC byte lane 3 GS register 1
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant DDRPHYC_DFTERR                 \ [0x00] DFTERR
    $04 constant DDRPHYC_DQSDFT                 \ [0x04 : 2] DQSDFT
    $0c constant DDRPHYC_RVERR                  \ [0x0c] RVERR
    $10 constant DDRPHYC_RVIERR                 \ [0x10] RVIERR
    $14 constant DDRPHYC_RVPASS                 \ [0x14 : 3] RVPASS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX3DLLCR_DEF
    \
    \ @brief DDRPHYC byte lane 3 DLLC register
    \ Address offset: 0x28C
    \ Reset value: 0x40000000
    \
    $00 constant DDRPHYC_SFBDLY                 \ [0x00 : 3] SFBDLY
    $03 constant DDRPHYC_SFWDLY                 \ [0x03 : 3] SFWDLY
    $06 constant DDRPHYC_MFBDLY                 \ [0x06 : 3] MFBDLY
    $09 constant DDRPHYC_MFWDLY                 \ [0x09 : 3] MFWDLY
    $0c constant DDRPHYC_SSTART                 \ [0x0c : 2] SSTART
    $0e constant DDRPHYC_SDPHASE                \ [0x0e : 4] SDPHASE
    $12 constant DDRPHYC_ATESTEN                \ [0x12] ATESTEN
    $13 constant DDRPHYC_SDLBMODE               \ [0x13] SDLBMODE
    $1e constant DDRPHYC_DLLSRST                \ [0x1e] DLLSRST
    $1f constant DDRPHYC_DLLDIS                 \ [0x1f] DLLDIS
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX3DQTR_DEF
    \
    \ @brief DDRPHYC byte lane 3 DQT register
    \ Address offset: 0x290
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant DDRPHYC_DQDLY0                 \ [0x00 : 4] DQDLY0
    $04 constant DDRPHYC_DQDLY1                 \ [0x04 : 4] DQDLY1
    $08 constant DDRPHYC_DQDLY2                 \ [0x08 : 4] DQDLY2
    $0c constant DDRPHYC_DQDLY3                 \ [0x0c : 4] DQDLY3
    $10 constant DDRPHYC_DQDLY4                 \ [0x10 : 4] DQDLY4
    $14 constant DDRPHYC_DQDLY5                 \ [0x14 : 4] DQDLY5
    $18 constant DDRPHYC_DQDLY6                 \ [0x18 : 4] DQDLY6
    $1c constant DDRPHYC_DQDLY7                 \ [0x1c : 4] DQDLY7
  [then]


  [ifdef] DDRPHYC_DDRPHYC_DX3DQSTR_DEF
    \
    \ @brief DDRPHYC byte lane 3 DQST register
    \ Address offset: 0x294
    \ Reset value: 0x3DB02000
    \
    $00 constant DDRPHYC_R0DGSL                 \ [0x00 : 3] R0DGSL
    $0c constant DDRPHYC_R0DGPS                 \ [0x0c : 2] R0DGPS
    $14 constant DDRPHYC_DQSDLY                 \ [0x14 : 3] DQSDLY
    $17 constant DDRPHYC_DQSNDLY                \ [0x17 : 3] DQSNDLY
    $1a constant DDRPHYC_DMDLY                  \ [0x1a : 4] DMDLY
  [then]

  \
  \ @brief DDRPHYC
  \
  $00 constant DDRPHYC_DDRPHYC_RIDR     \ DDRPHYC revision ID register
  $04 constant DDRPHYC_DDRPHYC_PIR      \ DDRPHYC PHY initialization register
  $08 constant DDRPHYC_DDRPHYC_PGCR     \ DDRPHYC PHY global control register
  $0C constant DDRPHYC_DDRPHYC_PGSR     \ DDRPHYC PHY global status register
  $10 constant DDRPHYC_DDRPHYC_DLLGCR   \ DDRPHYC DDR global control register
  $14 constant DDRPHYC_DDRPHYC_ACDLLCR  \ DDRPHYC AC DLL control register
  $18 constant DDRPHYC_DDRPHYC_PTR0     \ DDRPHYC PT register 0
  $1C constant DDRPHYC_DDRPHYC_PTR1     \ DDRPHYC PT register 1
  $20 constant DDRPHYC_DDRPHYC_PTR2     \ DDRPHYC PT register 2
  $24 constant DDRPHYC_DDRPHYC_ACIOCR   \ DDRPHYC ACIOC register
  $28 constant DDRPHYC_DDRPHYC_DXCCR    \ DDRPHYC DXCC register
  $2C constant DDRPHYC_DDRPHYC_DSGCR    \ DDRPHYC DSGC register
  $30 constant DDRPHYC_DDRPHYC_DCR      \ DDRPHYC DC register
  $34 constant DDRPHYC_DDRPHYC_DTPR0    \ DDRPHYC DTP register 0
  $38 constant DDRPHYC_DDRPHYC_DTPR1    \ DDRPHYC DTP register 1
  $3C constant DDRPHYC_DDRPHYC_DTPR2    \ DDRPHYC DTP register 2
  $40 constant DDRPHYC_DDRPHYC_DDR3_MR0 \ DDRPHYC MR0 register for DDR3
  $44 constant DDRPHYC_DDRPHYC_DDR3_MR1 \ DDRPHYC MR1 register for DDR3
  $48 constant DDRPHYC_DDRPHYC_DDR3_MR2 \ DDRPHYC MR2 register for DDR3
  $4C constant DDRPHYC_DDRPHYC_DDR3_MR3 \ DDRPHYC MR3 register for DDR3
  $50 constant DDRPHYC_DDRPHYC_ODTCR    \ DDRPHYC ODTC register
  $54 constant DDRPHYC_DDRPHYC_DTAR     \ DDRPHYC DTA register
  $58 constant DDRPHYC_DDRPHYC_DTDR0    \ DDRPHYC DTD register 0
  $5C constant DDRPHYC_DDRPHYC_DTDR1    \ DDRPHYC DTD register 1
  $178 constant DDRPHYC_DDRPHYC_GPR0    \ DDRPHYC general purpose register 0
  $17C constant DDRPHYC_DDRPHYC_GPR1    \ DDRPHYC general purpose register 1
  $180 constant DDRPHYC_DDRPHYC_ZQ0CR0  \ DDRPHYC ZQ0C register 0
  $184 constant DDRPHYC_DDRPHYC_ZQ0CR1  \ DDRPHYC ZQ0CR1 register
  $188 constant DDRPHYC_DDRPHYC_ZQ0SR0  \ DDRPHYC ZQ0S register 0
  $18C constant DDRPHYC_DDRPHYC_ZQ0SR1  \ DDRPHYC ZQ0S register 1
  $1C0 constant DDRPHYC_DDRPHYC_DX0GCR  \ DDRPHYC byte lane 0 GC register
  $1C4 constant DDRPHYC_DDRPHYC_DX0GSR0 \ DDRPHYC byte lane 0 GS register 0
  $1C8 constant DDRPHYC_DDRPHYC_DX0GSR1 \ DDRPHYC byte lane 0 GS register 1
  $1CC constant DDRPHYC_DDRPHYC_DX0DLLCR    \ DDRPHYC byte lane 0 DLLC register
  $1D0 constant DDRPHYC_DDRPHYC_DX0DQTR \ DDRPHYC byte lane 0 DQT register
  $1D4 constant DDRPHYC_DDRPHYC_DX0DQSTR    \ DDRPHYC byte lane 0 DQST register
  $200 constant DDRPHYC_DDRPHYC_DX1GCR  \ DDRPHYC byte lane 1 GC register
  $204 constant DDRPHYC_DDRPHYC_DX1GSR0 \ DDRPHYC byte lane 1 GS register 0
  $208 constant DDRPHYC_DDRPHYC_DX1GSR1 \ DDRPHYC byte lane 1 GS register 1
  $20C constant DDRPHYC_DDRPHYC_DX1DLLCR    \ DDRPHYC byte lane 1 DLLC register
  $210 constant DDRPHYC_DDRPHYC_DX1DQTR \ DDRPHYC byte lane 1 DQT register
  $214 constant DDRPHYC_DDRPHYC_DX1DQSTR    \ DDRPHYC byte lane 1 DQST register
  $240 constant DDRPHYC_DDRPHYC_DX2GCR  \ DDRPHYC byte lane 2 GC register
  $244 constant DDRPHYC_DDRPHYC_DX2GSR0 \ DDRPHYC byte lane 2 GS register 0
  $248 constant DDRPHYC_DDRPHYC_DX2GSR1 \ DDRPHYC byte lane 2 GS register 1
  $24C constant DDRPHYC_DDRPHYC_DX2DLLCR    \ DDRPHYC byte lane 2 DLLC register
  $250 constant DDRPHYC_DDRPHYC_DX2DQTR \ DDRPHYC byte lane 2 DQT register
  $254 constant DDRPHYC_DDRPHYC_DX2DQSTR    \ DDRPHYC byte lane 2 DQST register
  $280 constant DDRPHYC_DDRPHYC_DX3GCR  \ DDRPHYC byte lane 3 GC register
  $284 constant DDRPHYC_DDRPHYC_DX3GSR0 \ DDRPHYC byte lane 3 GS register 0
  $288 constant DDRPHYC_DDRPHYC_DX3GSR1 \ DDRPHYC byte lane 3 GS register 1
  $28C constant DDRPHYC_DDRPHYC_DX3DLLCR    \ DDRPHYC byte lane 3 DLLC register
  $290 constant DDRPHYC_DDRPHYC_DX3DQTR \ DDRPHYC byte lane 3 DQT register
  $294 constant DDRPHYC_DDRPHYC_DX3DQSTR    \ DDRPHYC byte lane 3 DQST register

: DDRPHYC_DEF ; [then]
