\
\ @file ddrphyc.fs
\ @brief DDRPHYC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DDRPHYC revision ID register
\ Address offset: 0x00
\ Reset value: 0x00410010
\

$0000000f constant DDRPHYC_DDRPHYC_RIDR_PUBMNR                      \ PUBMNR
$000000f0 constant DDRPHYC_DDRPHYC_RIDR_PUBMDR                      \ PUBMDR
$00000f00 constant DDRPHYC_DDRPHYC_RIDR_PUBMJR                      \ PUBMJR
$0000f000 constant DDRPHYC_DDRPHYC_RIDR_PHYMNR                      \ PHYMNR
$000f0000 constant DDRPHYC_DDRPHYC_RIDR_PHYMDR                      \ PHYMDR
$00f00000 constant DDRPHYC_DDRPHYC_RIDR_PHYMJR                      \ PHYMJR
$ff000000 constant DDRPHYC_DDRPHYC_RIDR_UDRID                       \ UDRID


\
\ @brief DDRPHYC PHY initialization register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_PIR_INIT                         \ INIT
$00000002 constant DDRPHYC_DDRPHYC_PIR_DLLSRST                      \ DLLSRST
$00000004 constant DDRPHYC_DDRPHYC_PIR_DLLLOCK                      \ DLLLOCK
$00000008 constant DDRPHYC_DDRPHYC_PIR_ZCAL                         \ ZCAL
$00000010 constant DDRPHYC_DDRPHYC_PIR_ITMSRST                      \ ITMSRST
$00000020 constant DDRPHYC_DDRPHYC_PIR_DRAMRST                      \ DRAMRST
$00000040 constant DDRPHYC_DDRPHYC_PIR_DRAMINIT                     \ DRAMINIT
$00000080 constant DDRPHYC_DDRPHYC_PIR_QSTRN                        \ QSTRN
$00000100 constant DDRPHYC_DDRPHYC_PIR_RVTRN                        \ RVTRN
$00010000 constant DDRPHYC_DDRPHYC_PIR_ICPC                         \ ICPC
$00020000 constant DDRPHYC_DDRPHYC_PIR_DLLBYP                       \ DLLBYP
$00040000 constant DDRPHYC_DDRPHYC_PIR_CTLDINIT                     \ CTLDINIT
$10000000 constant DDRPHYC_DDRPHYC_PIR_CLRSR                        \ CLRSR
$20000000 constant DDRPHYC_DDRPHYC_PIR_LOCKBYP                      \ LOCKBYP
$40000000 constant DDRPHYC_DDRPHYC_PIR_ZCALBYP                      \ ZCALBYP
$80000000 constant DDRPHYC_DDRPHYC_PIR_INITBYP                      \ INITBYP


\
\ @brief DDRPHYC PHY global control register
\ Address offset: 0x08
\ Reset value: 0x01BC2E04
\

$00000001 constant DDRPHYC_DDRPHYC_PGCR_ITMDMD                      \ ITMDMD
$00000002 constant DDRPHYC_DDRPHYC_PGCR_DQSCFG                      \ DQSCFG
$00000004 constant DDRPHYC_DDRPHYC_PGCR_DFTCMP                      \ DFTCMP
$00000018 constant DDRPHYC_DDRPHYC_PGCR_DFTLMT                      \ DFTLMT
$000001e0 constant DDRPHYC_DDRPHYC_PGCR_DTOSEL                      \ DTOSEL
$00000e00 constant DDRPHYC_DDRPHYC_PGCR_CKEN                        \ CKEN
$00003000 constant DDRPHYC_DDRPHYC_PGCR_CKDV                        \ CKDV
$00004000 constant DDRPHYC_DDRPHYC_PGCR_CKINV                       \ CKINV
$00008000 constant DDRPHYC_DDRPHYC_PGCR_IOLB                        \ IOLB
$00030000 constant DDRPHYC_DDRPHYC_PGCR_IODDRM                      \ IODDRM
$003c0000 constant DDRPHYC_DDRPHYC_PGCR_RANKEN                      \ RANKEN
$00c00000 constant DDRPHYC_DDRPHYC_PGCR_ZKSEL                       \ ZKSEL
$01000000 constant DDRPHYC_DDRPHYC_PGCR_PDDISDX                     \ PDDISDX
$1e000000 constant DDRPHYC_DDRPHYC_PGCR_RFSHDT                      \ RFSHDT
$20000000 constant DDRPHYC_DDRPHYC_PGCR_LBDQSS                      \ LBDQSS
$40000000 constant DDRPHYC_DDRPHYC_PGCR_LBGDQS                      \ LBGDQS
$80000000 constant DDRPHYC_DDRPHYC_PGCR_LBMODE                      \ LBMODE


\
\ @brief DDRPHYC PHY global status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_PGSR_IDONE                       \ IDONE
$00000002 constant DDRPHYC_DDRPHYC_PGSR_DLDONE                      \ DLDONE
$00000004 constant DDRPHYC_DDRPHYC_PGSR_ZCDDONE                     \ ZCDDONE
$00000008 constant DDRPHYC_DDRPHYC_PGSR_DIDONE                      \ DIDONE
$00000010 constant DDRPHYC_DDRPHYC_PGSR_DTDONE                      \ DTDONE
$00000020 constant DDRPHYC_DDRPHYC_PGSR_DTERR                       \ DTERR
$00000040 constant DDRPHYC_DDRPHYC_PGSR_DTIERR                      \ DTIERR
$00000080 constant DDRPHYC_DDRPHYC_PGSR_DFTERR                      \ DFTERR
$00000100 constant DDRPHYC_DDRPHYC_PGSR_RVERR                       \ RVERR
$00000200 constant DDRPHYC_DDRPHYC_PGSR_RVEIRR                      \ RVEIRR
$80000000 constant DDRPHYC_DDRPHYC_PGSR_TQ                          \ TQ


\
\ @brief DDRPHYC DDR global control register
\ Address offset: 0x10
\ Reset value: 0x03737000
\

$00000003 constant DDRPHYC_DDRPHYC_DLLGCR_DRES                      \ DRES
$0000001c constant DDRPHYC_DDRPHYC_DLLGCR_IPUMP                     \ IPUMP
$00000020 constant DDRPHYC_DDRPHYC_DLLGCR_TESTEN                    \ TESTEN
$000001c0 constant DDRPHYC_DDRPHYC_DLLGCR_DTC                       \ DTC
$00000600 constant DDRPHYC_DDRPHYC_DLLGCR_ATC                       \ ATC
$00000800 constant DDRPHYC_DDRPHYC_DLLGCR_TESTSW                    \ TESTSW
$000ff000 constant DDRPHYC_DDRPHYC_DLLGCR_MBIAS                     \ MBIAS
$00700000 constant DDRPHYC_DDRPHYC_DLLGCR_SBIAS2_0                  \ SBIAS2_0
$00800000 constant DDRPHYC_DDRPHYC_DLLGCR_BPS200                    \ BPS200
$07000000 constant DDRPHYC_DDRPHYC_DLLGCR_SBIAS5_3                  \ SBIAS5_3
$18000000 constant DDRPHYC_DDRPHYC_DLLGCR_FDTRMSL                   \ FDTRMSL
$20000000 constant DDRPHYC_DDRPHYC_DLLGCR_LOCKDET                   \ LOCKDET
$c0000000 constant DDRPHYC_DDRPHYC_DLLGCR_DLLRSVD2                  \ DLLRSVD2


\
\ @brief DDRPHYC AC DLL control register
\ Address offset: 0x14
\ Reset value: 0x40000000
\

$000001c0 constant DDRPHYC_DDRPHYC_ACDLLCR_MFBDLY                   \ MFBDLY
$00000e00 constant DDRPHYC_DDRPHYC_ACDLLCR_MFWDLY                   \ MFWDLY
$00040000 constant DDRPHYC_DDRPHYC_ACDLLCR_ATESTEN                  \ ATESTEN
$40000000 constant DDRPHYC_DDRPHYC_ACDLLCR_DLLSRST                  \ DLLSRST
$80000000 constant DDRPHYC_DDRPHYC_ACDLLCR_DLLDIS                   \ DLLDIS


\
\ @brief DDRPHYC PT register 0
\ Address offset: 0x18
\ Reset value: 0x0022AF9B
\

$0000003f constant DDRPHYC_DDRPHYC_PTR0_TDLLSRST                    \ TDLLSRST
$0003ffc0 constant DDRPHYC_DDRPHYC_PTR0_TDLLLOCK                    \ TDLLLOCK
$003c0000 constant DDRPHYC_DDRPHYC_PTR0_TITMSRST                    \ TITMSRST


\
\ @brief DDRPHYC PT register 1
\ Address offset: 0x1C
\ Reset value: 0x0604111D
\

$0007ffff constant DDRPHYC_DDRPHYC_PTR1_TDINIT0                     \ TDINIT0
$07f80000 constant DDRPHYC_DDRPHYC_PTR1_TDINIT1                     \ TDINIT1


\
\ @brief DDRPHYC PT register 2
\ Address offset: 0x20
\ Reset value: 0x042DA072
\

$0001ffff constant DDRPHYC_DDRPHYC_PTR2_TDINIT2                     \ TDINIT2
$07fe0000 constant DDRPHYC_DDRPHYC_PTR2_TDINIT3                     \ TDINIT3


\
\ @brief DDRPHYC ACIOC register
\ Address offset: 0x24
\ Reset value: 0x33C03812
\

$00000001 constant DDRPHYC_DDRPHYC_ACIOCR_ACIOM                     \ ACIOM
$00000002 constant DDRPHYC_DDRPHYC_ACIOCR_ACOE                      \ ACOE
$00000004 constant DDRPHYC_DDRPHYC_ACIOCR_ACODT                     \ ACODT
$00000008 constant DDRPHYC_DDRPHYC_ACIOCR_ACPDD                     \ ACPDD
$00000010 constant DDRPHYC_DDRPHYC_ACIOCR_ACPDR                     \ ACPDR
$000000e0 constant DDRPHYC_DDRPHYC_ACIOCR_CKODT                     \ CKODT
$00000700 constant DDRPHYC_DDRPHYC_ACIOCR_CKPDD                     \ CKPDD
$00003800 constant DDRPHYC_DDRPHYC_ACIOCR_CKPDR                     \ CKPDR
$00004000 constant DDRPHYC_DDRPHYC_ACIOCR_RANKODT                   \ RANKODT
$00040000 constant DDRPHYC_DDRPHYC_ACIOCR_CSPDD                     \ CSPDD
$00400000 constant DDRPHYC_DDRPHYC_ACIOCR_RANKPDR                   \ RANKPDR
$04000000 constant DDRPHYC_DDRPHYC_ACIOCR_RSTODT                    \ RSTODT
$08000000 constant DDRPHYC_DDRPHYC_ACIOCR_RSTPDD                    \ RSTPDD
$10000000 constant DDRPHYC_DDRPHYC_ACIOCR_RSTPDR                    \ RSTPDR
$20000000 constant DDRPHYC_DDRPHYC_ACIOCR_RSTIOM                    \ RSTIOM
$c0000000 constant DDRPHYC_DDRPHYC_ACIOCR_ACSR                      \ ACSR


\
\ @brief DDRPHYC DXCC register
\ Address offset: 0x28
\ Reset value: 0x00000800
\

$00000001 constant DDRPHYC_DDRPHYC_DXCCR_DXODT                      \ DXODT
$00000002 constant DDRPHYC_DDRPHYC_DXCCR_DXIOM                      \ DXIOM
$00000004 constant DDRPHYC_DDRPHYC_DXCCR_DXPDD                      \ DXPDD
$00000008 constant DDRPHYC_DDRPHYC_DXCCR_DXPDR                      \ DXPDR
$000000f0 constant DDRPHYC_DDRPHYC_DXCCR_DQSRES                     \ DQSRES
$00000f00 constant DDRPHYC_DDRPHYC_DXCCR_DQSNRES                    \ DQSNRES
$00004000 constant DDRPHYC_DDRPHYC_DXCCR_DQSNRST                    \ DQSNRST
$00008000 constant DDRPHYC_DDRPHYC_DXCCR_RVSEL                      \ RVSEL
$00010000 constant DDRPHYC_DDRPHYC_DXCCR_AWDT                       \ AWDT


\
\ @brief DDRPHYC DSGC register
\ Address offset: 0x2C
\ Reset value: 0xFA00001F
\

$00000001 constant DDRPHYC_DDRPHYC_DSGCR_PUREN                      \ PUREN
$00000002 constant DDRPHYC_DDRPHYC_DSGCR_BDISEN                     \ BDISEN
$00000004 constant DDRPHYC_DDRPHYC_DSGCR_ZUEN                       \ ZUEN
$00000008 constant DDRPHYC_DDRPHYC_DSGCR_LPIOPD                     \ LPIOPD
$00000010 constant DDRPHYC_DDRPHYC_DSGCR_LPDLLPD                    \ LPDLLPD
$000000e0 constant DDRPHYC_DDRPHYC_DSGCR_DQSGX                      \ DQSGX
$00000700 constant DDRPHYC_DDRPHYC_DSGCR_DQSGE                      \ DQSGE
$00000800 constant DDRPHYC_DDRPHYC_DSGCR_NOBUB                      \ NOBUB
$00001000 constant DDRPHYC_DDRPHYC_DSGCR_FXDLAT                     \ FXDLAT
$00010000 constant DDRPHYC_DDRPHYC_DSGCR_CKEPDD                     \ CKEPDD
$00100000 constant DDRPHYC_DDRPHYC_DSGCR_ODTPDD                     \ ODTPDD
$01000000 constant DDRPHYC_DDRPHYC_DSGCR_NL2PD                      \ NL2PD
$02000000 constant DDRPHYC_DDRPHYC_DSGCR_NL2OE                      \ NL2OE
$04000000 constant DDRPHYC_DDRPHYC_DSGCR_TPDPD                      \ TPDPD
$08000000 constant DDRPHYC_DDRPHYC_DSGCR_TPDOE                      \ TPDOE
$10000000 constant DDRPHYC_DDRPHYC_DSGCR_CKOE                       \ CKOE
$20000000 constant DDRPHYC_DDRPHYC_DSGCR_ODTOE                      \ ODTOE
$40000000 constant DDRPHYC_DDRPHYC_DSGCR_RSTOE                      \ RSTOE
$80000000 constant DDRPHYC_DDRPHYC_DSGCR_CKEOE                      \ CKEOE


\
\ @brief DDRPHYC DC register
\ Address offset: 0x30
\ Reset value: 0x0000000B
\

$00000007 constant DDRPHYC_DDRPHYC_DCR_DDRMD                        \ DDRMD
$00000008 constant DDRPHYC_DDRPHYC_DCR_DDR8BNK                      \ DDR8BNK
$00000070 constant DDRPHYC_DDRPHYC_DCR_PDQ                          \ PDQ
$00000080 constant DDRPHYC_DDRPHYC_DCR_MPRDQ                        \ MPRDQ
$00000300 constant DDRPHYC_DDRPHYC_DCR_DDRTYPE                      \ DDRTYPE
$08000000 constant DDRPHYC_DDRPHYC_DCR_NOSRA                        \ NOSRA
$10000000 constant DDRPHYC_DDRPHYC_DCR_DDR2T                        \ DDR2T
$20000000 constant DDRPHYC_DDRPHYC_DCR_UDIMM                        \ UDIMM
$40000000 constant DDRPHYC_DDRPHYC_DCR_RDIMM                        \ RDIMM
$80000000 constant DDRPHYC_DDRPHYC_DCR_TPD                          \ TPD


\
\ @brief DDRPHYC DTP register 0
\ Address offset: 0x34
\ Reset value: 0x3012666E
\

$00000003 constant DDRPHYC_DDRPHYC_DTPR0_TMRD                       \ TMRD
$0000001c constant DDRPHYC_DDRPHYC_DTPR0_TRTP                       \ TRTP
$000000e0 constant DDRPHYC_DDRPHYC_DTPR0_TWTR                       \ TWTR
$00000f00 constant DDRPHYC_DDRPHYC_DTPR0_TRP                        \ TRP
$0000f000 constant DDRPHYC_DDRPHYC_DTPR0_TRCD                       \ TRCD
$001f0000 constant DDRPHYC_DDRPHYC_DTPR0_TRAS                       \ TRAS
$01e00000 constant DDRPHYC_DDRPHYC_DTPR0_TRRD                       \ TRRD
$7e000000 constant DDRPHYC_DDRPHYC_DTPR0_TRC                        \ TRC
$80000000 constant DDRPHYC_DDRPHYC_DTPR0_TCCD                       \ TCCD


\
\ @brief DDRPHYC DTP register 1
\ Address offset: 0x38
\ Reset value: 0x0A030090
\

$00000003 constant DDRPHYC_DDRPHYC_DTPR1_TAOND                      \ TAOND
$00000004 constant DDRPHYC_DDRPHYC_DTPR1_TRTW                       \ TRTW
$000001f8 constant DDRPHYC_DDRPHYC_DTPR1_TFAW                       \ TFAW
$00000600 constant DDRPHYC_DDRPHYC_DTPR1_TMOD                       \ TMOD
$00000800 constant DDRPHYC_DDRPHYC_DTPR1_TRTODT                     \ TRTODT
$00ff0000 constant DDRPHYC_DDRPHYC_DTPR1_TRFC                       \ TRFC
$07000000 constant DDRPHYC_DDRPHYC_DTPR1_TDQSCKMIN                  \ TDQSCKMIN
$38000000 constant DDRPHYC_DDRPHYC_DTPR1_TDQSCKMAX                  \ TDQSCKMAX


\
\ @brief DDRPHYC DTP register 2
\ Address offset: 0x3C
\ Reset value: 0x20040D84
\

$000003ff constant DDRPHYC_DDRPHYC_DTPR2_TXS                        \ TXS
$00007c00 constant DDRPHYC_DDRPHYC_DTPR2_TXP                        \ TXP
$00078000 constant DDRPHYC_DDRPHYC_DTPR2_TCKE                       \ TCKE
$1ff80000 constant DDRPHYC_DDRPHYC_DTPR2_TDLLK                      \ TDLLK


\
\ @brief DDRPHYC MR0 register for DDR3
\ Address offset: 0x40
\ Reset value: 0x00000A52
\

$00000003 constant DDRPHYC_DDRPHYC_DDR3_MR0_BL                      \ BL
$00000004 constant DDRPHYC_DDRPHYC_DDR3_MR0_CL0                     \ CL0
$00000008 constant DDRPHYC_DDRPHYC_DDR3_MR0_BT                      \ BT
$00000070 constant DDRPHYC_DDRPHYC_DDR3_MR0_CL                      \ CL
$00000080 constant DDRPHYC_DDRPHYC_DDR3_MR0_TM                      \ TM
$00000100 constant DDRPHYC_DDRPHYC_DDR3_MR0_DR                      \ DR
$00000e00 constant DDRPHYC_DDRPHYC_DDR3_MR0_WR                      \ WR
$00001000 constant DDRPHYC_DDRPHYC_DDR3_MR0_PD                      \ PD
$0000e000 constant DDRPHYC_DDRPHYC_DDR3_MR0_RSVD                    \ RSVD


\
\ @brief DDRPHYC MR1 register for DDR3
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DDR3_MR1_DE                      \ DE
$00000002 constant DDRPHYC_DDRPHYC_DDR3_MR1_DIC0                    \ DIC0
$00000004 constant DDRPHYC_DDRPHYC_DDR3_MR1_RTT0                    \ RTT0
$00000018 constant DDRPHYC_DDRPHYC_DDR3_MR1_AL                      \ AL
$00000020 constant DDRPHYC_DDRPHYC_DDR3_MR1_DIC1                    \ DIC1
$00000040 constant DDRPHYC_DDRPHYC_DDR3_MR1_RTT1                    \ RTT1
$00000080 constant DDRPHYC_DDRPHYC_DDR3_MR1_LEVEL                   \ LEVEL
$00000200 constant DDRPHYC_DDRPHYC_DDR3_MR1_RTT2                    \ RTT2
$00000800 constant DDRPHYC_DDRPHYC_DDR3_MR1_TDQS                    \ TDQS
$00001000 constant DDRPHYC_DDRPHYC_DDR3_MR1_QOFF                    \ QOFF


\
\ @brief DDRPHYC MR2 register for DDR3
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000007 constant DDRPHYC_DDRPHYC_DDR3_MR2_PASR                    \ PASR
$00000038 constant DDRPHYC_DDRPHYC_DDR3_MR2_CWL                     \ CWL
$00000040 constant DDRPHYC_DDRPHYC_DDR3_MR2_ASR                     \ ASR
$00000080 constant DDRPHYC_DDRPHYC_DDR3_MR2_SRT                     \ SRT
$00000600 constant DDRPHYC_DDRPHYC_DDR3_MR2_RTTWR                   \ RTTWR


\
\ @brief DDRPHYC MR3 register for DDR3
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant DDRPHYC_DDRPHYC_DDR3_MR3_MPRLOC                  \ MPRLOC
$00000004 constant DDRPHYC_DDRPHYC_DDR3_MR3_MPR                     \ MPR


\
\ @brief DDRPHYC ODTC register
\ Address offset: 0x50
\ Reset value: 0x84210000
\

$00000001 constant DDRPHYC_DDRPHYC_ODTCR_RDODT                      \ RDODT
$00010000 constant DDRPHYC_DDRPHYC_ODTCR_WRODT                      \ WRODT


\
\ @brief DDRPHYC DTA register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000fff constant DDRPHYC_DDRPHYC_DTAR_DTCOL                       \ DTCOL
$0ffff000 constant DDRPHYC_DDRPHYC_DTAR_DTROW                       \ DTROW
$70000000 constant DDRPHYC_DDRPHYC_DTAR_DTBANK                      \ DTBANK
$80000000 constant DDRPHYC_DDRPHYC_DTAR_DTMPR                       \ DTMPR


\
\ @brief DDRPHYC DTD register 0
\ Address offset: 0x58
\ Reset value: 0xDD22EE11
\

$000000ff constant DDRPHYC_DDRPHYC_DTDR0_DTBYTE0                    \ DTBYTE0
$0000ff00 constant DDRPHYC_DDRPHYC_DTDR0_DTBYTE1                    \ DTBYTE1
$00ff0000 constant DDRPHYC_DDRPHYC_DTDR0_DTBYTE2                    \ DTBYTE2
$ff000000 constant DDRPHYC_DDRPHYC_DTDR0_DTBYTE3                    \ DTBYTE3


\
\ @brief DDRPHYC DTD register 1
\ Address offset: 0x5C
\ Reset value: 0x7788BB44
\

$000000ff constant DDRPHYC_DDRPHYC_DTDR1_DTBYTE4                    \ DTBYTE4
$0000ff00 constant DDRPHYC_DDRPHYC_DTDR1_DTBYTE5                    \ DTBYTE5
$00ff0000 constant DDRPHYC_DDRPHYC_DTDR1_DTBYTE6                    \ DTBYTE6
$ff000000 constant DDRPHYC_DDRPHYC_DTDR1_DTBYTE7                    \ DTBYTE7


\
\ @brief DDRPHYC general purpose register 0
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant DDRPHYC_DDRPHYC_GPR0_GPR0                        \ GPR0


\
\ @brief DDRPHYC general purpose register 1
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant DDRPHYC_DDRPHYC_GPR1_GPR1                        \ GPR1


\
\ @brief DDRPHYC ZQ0C register 0
\ Address offset: 0x180
\ Reset value: 0x0000014A
\

$000fffff constant DDRPHYC_DDRPHYC_ZQ0CR0_ZDATA                     \ ZDATA
$10000000 constant DDRPHYC_DDRPHYC_ZQ0CR0_ZDEN                      \ ZDEN
$20000000 constant DDRPHYC_DDRPHYC_ZQ0CR0_ZCALBYP                   \ ZCALBYP
$40000000 constant DDRPHYC_DDRPHYC_ZQ0CR0_ZCAL                      \ ZCAL
$80000000 constant DDRPHYC_DDRPHYC_ZQ0CR0_ZQPD                      \ ZQPD


\
\ @brief DDRPHYC ZQ0CR1 register
\ Address offset: 0x184
\ Reset value: 0x0000007B
\

$000000ff constant DDRPHYC_DDRPHYC_ZQ0CR1_ZPROG                     \ ZPROG


\
\ @brief DDRPHYC ZQ0S register 0
\ Address offset: 0x188
\ Reset value: 0x0000014A
\

$000fffff constant DDRPHYC_DDRPHYC_ZQ0SR0_ZCTRL                     \ ZCTRL
$40000000 constant DDRPHYC_DDRPHYC_ZQ0SR0_ZERR                      \ ZERR
$80000000 constant DDRPHYC_DDRPHYC_ZQ0SR0_ZDONE                     \ ZDONE


\
\ @brief DDRPHYC ZQ0S register 1
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000003 constant DDRPHYC_DDRPHYC_ZQ0SR1_ZPD                       \ ZPD
$0000000c constant DDRPHYC_DDRPHYC_ZQ0SR1_ZPU                       \ ZPU
$00000030 constant DDRPHYC_DDRPHYC_ZQ0SR1_OPD                       \ OPD
$000000c0 constant DDRPHYC_DDRPHYC_ZQ0SR1_OPU                       \ OPU


\
\ @brief DDRPHYC byte lane 0 GC register
\ Address offset: 0x1C0
\ Reset value: 0x0000EE81
\

$00000001 constant DDRPHYC_DDRPHYC_DX0GCR_DXEN                      \ DXEN
$00000002 constant DDRPHYC_DDRPHYC_DX0GCR_DQSODT                    \ DQSODT
$00000004 constant DDRPHYC_DDRPHYC_DX0GCR_DQODT                     \ DQODT
$00000008 constant DDRPHYC_DDRPHYC_DX0GCR_DXIOM                     \ DXIOM
$00000010 constant DDRPHYC_DDRPHYC_DX0GCR_DXPDD                     \ DXPDD
$00000020 constant DDRPHYC_DDRPHYC_DX0GCR_DXPDR                     \ DXPDR
$00000040 constant DDRPHYC_DDRPHYC_DX0GCR_DQSRPD                    \ DQSRPD
$00000180 constant DDRPHYC_DDRPHYC_DX0GCR_DSEN                      \ DSEN
$00000200 constant DDRPHYC_DDRPHYC_DX0GCR_DQSRTT                    \ DQSRTT
$00000400 constant DDRPHYC_DDRPHYC_DX0GCR_DQRTT                     \ DQRTT
$00001800 constant DDRPHYC_DDRPHYC_DX0GCR_RTTOH                     \ RTTOH
$00002000 constant DDRPHYC_DDRPHYC_DX0GCR_RTTOAL                    \ RTTOAL
$0001c000 constant DDRPHYC_DDRPHYC_DX0GCR_R0RVSL                    \ R0RVSL


\
\ @brief DDRPHYC byte lane 0 GS register 0
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX0GSR0_DTDONE                   \ DTDONE
$00000010 constant DDRPHYC_DDRPHYC_DX0GSR0_DTERR                    \ DTERR
$00000100 constant DDRPHYC_DDRPHYC_DX0GSR0_DTIERR                   \ DTIERR
$0000e000 constant DDRPHYC_DDRPHYC_DX0GSR0_DTPASS                   \ DTPASS


\
\ @brief DDRPHYC byte lane 0 GS register 1
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX0GSR1_DFTERR                   \ DFTERR
$00000030 constant DDRPHYC_DDRPHYC_DX0GSR1_DQSDFT                   \ DQSDFT
$00001000 constant DDRPHYC_DDRPHYC_DX0GSR1_RVERR                    \ RVERR
$00010000 constant DDRPHYC_DDRPHYC_DX0GSR1_RVIERR                   \ RVIERR
$00700000 constant DDRPHYC_DDRPHYC_DX0GSR1_RVPASS                   \ RVPASS


\
\ @brief DDRPHYC byte lane 0 DLLC register
\ Address offset: 0x1CC
\ Reset value: 0x40000000
\

$00000007 constant DDRPHYC_DDRPHYC_DX0DLLCR_SFBDLY                  \ SFBDLY
$00000038 constant DDRPHYC_DDRPHYC_DX0DLLCR_SFWDLY                  \ SFWDLY
$000001c0 constant DDRPHYC_DDRPHYC_DX0DLLCR_MFBDLY                  \ MFBDLY
$00000e00 constant DDRPHYC_DDRPHYC_DX0DLLCR_MFWDLY                  \ MFWDLY
$00003000 constant DDRPHYC_DDRPHYC_DX0DLLCR_SSTART                  \ SSTART
$0003c000 constant DDRPHYC_DDRPHYC_DX0DLLCR_SDPHASE                 \ SDPHASE
$00040000 constant DDRPHYC_DDRPHYC_DX0DLLCR_ATESTEN                 \ ATESTEN
$00080000 constant DDRPHYC_DDRPHYC_DX0DLLCR_SDLBMODE                \ SDLBMODE
$40000000 constant DDRPHYC_DDRPHYC_DX0DLLCR_DLLSRST                 \ DLLSRST
$80000000 constant DDRPHYC_DDRPHYC_DX0DLLCR_DLLDIS                  \ DLLDIS


\
\ @brief DDRPHYC byte lane 0 DQT register
\ Address offset: 0x1D0
\ Reset value: 0xFFFFFFFF
\

$0000000f constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY0                   \ DQDLY0
$000000f0 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY1                   \ DQDLY1
$00000f00 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY2                   \ DQDLY2
$0000f000 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY3                   \ DQDLY3
$000f0000 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY4                   \ DQDLY4
$00f00000 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY5                   \ DQDLY5
$0f000000 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY6                   \ DQDLY6
$f0000000 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY7                   \ DQDLY7


\
\ @brief DDRPHYC byte lane 0 DQST register
\ Address offset: 0x1D4
\ Reset value: 0x3DB02000
\

$00000007 constant DDRPHYC_DDRPHYC_DX0DQSTR_R0DGSL                  \ R0DGSL
$00003000 constant DDRPHYC_DDRPHYC_DX0DQSTR_R0DGPS                  \ R0DGPS
$00700000 constant DDRPHYC_DDRPHYC_DX0DQSTR_DQSDLY                  \ DQSDLY
$03800000 constant DDRPHYC_DDRPHYC_DX0DQSTR_DQSNDLY                 \ DQSNDLY
$3c000000 constant DDRPHYC_DDRPHYC_DX0DQSTR_DMDLY                   \ DMDLY


\
\ @brief DDRPHYC byte lane 1 GC register
\ Address offset: 0x200
\ Reset value: 0x0000EE81
\

$00000001 constant DDRPHYC_DDRPHYC_DX1GCR_DXEN                      \ DXEN
$00000002 constant DDRPHYC_DDRPHYC_DX1GCR_DQSODT                    \ DQSODT
$00000004 constant DDRPHYC_DDRPHYC_DX1GCR_DQODT                     \ DQODT
$00000008 constant DDRPHYC_DDRPHYC_DX1GCR_DXIOM                     \ DXIOM
$00000010 constant DDRPHYC_DDRPHYC_DX1GCR_DXPDD                     \ DXPDD
$00000020 constant DDRPHYC_DDRPHYC_DX1GCR_DXPDR                     \ DXPDR
$00000040 constant DDRPHYC_DDRPHYC_DX1GCR_DQSRPD                    \ DQSRPD
$00000180 constant DDRPHYC_DDRPHYC_DX1GCR_DSEN                      \ DSEN
$00000200 constant DDRPHYC_DDRPHYC_DX1GCR_DQSRTT                    \ DQSRTT
$00000400 constant DDRPHYC_DDRPHYC_DX1GCR_DQRTT                     \ DQRTT
$00001800 constant DDRPHYC_DDRPHYC_DX1GCR_RTTOH                     \ RTTOH
$00002000 constant DDRPHYC_DDRPHYC_DX1GCR_RTTOAL                    \ RTTOAL
$0001c000 constant DDRPHYC_DDRPHYC_DX1GCR_R0RVSL                    \ R0RVSL


\
\ @brief DDRPHYC byte lane 1 GS register 0
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX1GSR0_DTDONE                   \ DTDONE
$00000010 constant DDRPHYC_DDRPHYC_DX1GSR0_DTERR                    \ DTERR
$00000100 constant DDRPHYC_DDRPHYC_DX1GSR0_DTIERR                   \ DTIERR
$0000e000 constant DDRPHYC_DDRPHYC_DX1GSR0_DTPASS                   \ DTPASS


\
\ @brief DDRPHYC byte lane 1 GS register 1
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX1GSR1_DFTERR                   \ DFTERR
$00000030 constant DDRPHYC_DDRPHYC_DX1GSR1_DQSDFT                   \ DQSDFT
$00001000 constant DDRPHYC_DDRPHYC_DX1GSR1_RVERR                    \ RVERR
$00010000 constant DDRPHYC_DDRPHYC_DX1GSR1_RVIERR                   \ RVIERR
$00700000 constant DDRPHYC_DDRPHYC_DX1GSR1_RVPASS                   \ RVPASS


\
\ @brief DDRPHYC byte lane 1 DLLC register
\ Address offset: 0x20C
\ Reset value: 0x40000000
\

$00000007 constant DDRPHYC_DDRPHYC_DX1DLLCR_SFBDLY                  \ SFBDLY
$00000038 constant DDRPHYC_DDRPHYC_DX1DLLCR_SFWDLY                  \ SFWDLY
$000001c0 constant DDRPHYC_DDRPHYC_DX1DLLCR_MFBDLY                  \ MFBDLY
$00000e00 constant DDRPHYC_DDRPHYC_DX1DLLCR_MFWDLY                  \ MFWDLY
$00003000 constant DDRPHYC_DDRPHYC_DX1DLLCR_SSTART                  \ SSTART
$0003c000 constant DDRPHYC_DDRPHYC_DX1DLLCR_SDPHASE                 \ SDPHASE
$00040000 constant DDRPHYC_DDRPHYC_DX1DLLCR_ATESTEN                 \ ATESTEN
$00080000 constant DDRPHYC_DDRPHYC_DX1DLLCR_SDLBMODE                \ SDLBMODE
$40000000 constant DDRPHYC_DDRPHYC_DX1DLLCR_DLLSRST                 \ DLLSRST
$80000000 constant DDRPHYC_DDRPHYC_DX1DLLCR_DLLDIS                  \ DLLDIS


\
\ @brief DDRPHYC byte lane 1 DQT register
\ Address offset: 0x210
\ Reset value: 0xFFFFFFFF
\

$0000000f constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY0                   \ DQDLY0
$000000f0 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY1                   \ DQDLY1
$00000f00 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY2                   \ DQDLY2
$0000f000 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY3                   \ DQDLY3
$000f0000 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY4                   \ DQDLY4
$00f00000 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY5                   \ DQDLY5
$0f000000 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY6                   \ DQDLY6
$f0000000 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY7                   \ DQDLY7


\
\ @brief DDRPHYC byte lane 1 DQST register
\ Address offset: 0x214
\ Reset value: 0x3DB02000
\

$00000007 constant DDRPHYC_DDRPHYC_DX1DQSTR_R0DGSL                  \ R0DGSL
$00003000 constant DDRPHYC_DDRPHYC_DX1DQSTR_R0DGPS                  \ R0DGPS
$00700000 constant DDRPHYC_DDRPHYC_DX1DQSTR_DQSDLY                  \ DQSDLY
$03800000 constant DDRPHYC_DDRPHYC_DX1DQSTR_DQSNDLY                 \ DQSNDLY
$3c000000 constant DDRPHYC_DDRPHYC_DX1DQSTR_DMDLY                   \ DMDLY


\
\ @brief DDRPHYC byte lane 2 GC register
\ Address offset: 0x240
\ Reset value: 0x0000EE81
\

$00000001 constant DDRPHYC_DDRPHYC_DX2GCR_DXEN                      \ DXEN
$00000002 constant DDRPHYC_DDRPHYC_DX2GCR_DQSODT                    \ DQSODT
$00000004 constant DDRPHYC_DDRPHYC_DX2GCR_DQODT                     \ DQODT
$00000008 constant DDRPHYC_DDRPHYC_DX2GCR_DXIOM                     \ DXIOM
$00000010 constant DDRPHYC_DDRPHYC_DX2GCR_DXPDD                     \ DXPDD
$00000020 constant DDRPHYC_DDRPHYC_DX2GCR_DXPDR                     \ DXPDR
$00000040 constant DDRPHYC_DDRPHYC_DX2GCR_DQSRPD                    \ DQSRPD
$00000180 constant DDRPHYC_DDRPHYC_DX2GCR_DSEN                      \ DSEN
$00000200 constant DDRPHYC_DDRPHYC_DX2GCR_DQSRTT                    \ DQSRTT
$00000400 constant DDRPHYC_DDRPHYC_DX2GCR_DQRTT                     \ DQRTT
$00001800 constant DDRPHYC_DDRPHYC_DX2GCR_RTTOH                     \ RTTOH
$00002000 constant DDRPHYC_DDRPHYC_DX2GCR_RTTOAL                    \ RTTOAL
$0001c000 constant DDRPHYC_DDRPHYC_DX2GCR_R0RVSL                    \ R0RVSL


\
\ @brief DDRPHYC byte lane 2 GS register 0
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX2GSR0_DTDONE                   \ DTDONE
$00000010 constant DDRPHYC_DDRPHYC_DX2GSR0_DTERR                    \ DTERR
$00000100 constant DDRPHYC_DDRPHYC_DX2GSR0_DTIERR                   \ DTIERR
$0000e000 constant DDRPHYC_DDRPHYC_DX2GSR0_DTPASS                   \ DTPASS


\
\ @brief DDRPHYC byte lane 2 GS register 1
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX2GSR1_DFTERR                   \ DFTERR
$00000030 constant DDRPHYC_DDRPHYC_DX2GSR1_DQSDFT                   \ DQSDFT
$00001000 constant DDRPHYC_DDRPHYC_DX2GSR1_RVERR                    \ RVERR
$00010000 constant DDRPHYC_DDRPHYC_DX2GSR1_RVIERR                   \ RVIERR
$00700000 constant DDRPHYC_DDRPHYC_DX2GSR1_RVPASS                   \ RVPASS


\
\ @brief DDRPHYC byte lane 2 DLLC register
\ Address offset: 0x24C
\ Reset value: 0x40000000
\

$00000007 constant DDRPHYC_DDRPHYC_DX2DLLCR_SFBDLY                  \ SFBDLY
$00000038 constant DDRPHYC_DDRPHYC_DX2DLLCR_SFWDLY                  \ SFWDLY
$000001c0 constant DDRPHYC_DDRPHYC_DX2DLLCR_MFBDLY                  \ MFBDLY
$00000e00 constant DDRPHYC_DDRPHYC_DX2DLLCR_MFWDLY                  \ MFWDLY
$00003000 constant DDRPHYC_DDRPHYC_DX2DLLCR_SSTART                  \ SSTART
$0003c000 constant DDRPHYC_DDRPHYC_DX2DLLCR_SDPHASE                 \ SDPHASE
$00040000 constant DDRPHYC_DDRPHYC_DX2DLLCR_ATESTEN                 \ ATESTEN
$00080000 constant DDRPHYC_DDRPHYC_DX2DLLCR_SDLBMODE                \ SDLBMODE
$40000000 constant DDRPHYC_DDRPHYC_DX2DLLCR_DLLSRST                 \ DLLSRST
$80000000 constant DDRPHYC_DDRPHYC_DX2DLLCR_DLLDIS                  \ DLLDIS


\
\ @brief DDRPHYC byte lane 2 DQT register
\ Address offset: 0x250
\ Reset value: 0xFFFFFFFF
\

$0000000f constant DDRPHYC_DDRPHYC_DX2DQTR_DQDLY0                   \ DQDLY0
$000000f0 constant DDRPHYC_DDRPHYC_DX2DQTR_DQDLY1                   \ DQDLY1
$00000f00 constant DDRPHYC_DDRPHYC_DX2DQTR_DQDLY2                   \ DQDLY2
$0000f000 constant DDRPHYC_DDRPHYC_DX2DQTR_DQDLY3                   \ DQDLY3
$000f0000 constant DDRPHYC_DDRPHYC_DX2DQTR_DQDLY4                   \ DQDLY4
$00f00000 constant DDRPHYC_DDRPHYC_DX2DQTR_DQDLY5                   \ DQDLY5
$0f000000 constant DDRPHYC_DDRPHYC_DX2DQTR_DQDLY6                   \ DQDLY6
$f0000000 constant DDRPHYC_DDRPHYC_DX2DQTR_DQDLY7                   \ DQDLY7


\
\ @brief DDRPHYC byte lane 2 DQST register
\ Address offset: 0x254
\ Reset value: 0x3DB02000
\

$00000007 constant DDRPHYC_DDRPHYC_DX2DQSTR_R0DGSL                  \ R0DGSL
$00003000 constant DDRPHYC_DDRPHYC_DX2DQSTR_R0DGPS                  \ R0DGPS
$00700000 constant DDRPHYC_DDRPHYC_DX2DQSTR_DQSDLY                  \ DQSDLY
$03800000 constant DDRPHYC_DDRPHYC_DX2DQSTR_DQSNDLY                 \ DQSNDLY
$3c000000 constant DDRPHYC_DDRPHYC_DX2DQSTR_DMDLY                   \ DMDLY


\
\ @brief DDRPHYC byte lane 3 GC register
\ Address offset: 0x280
\ Reset value: 0x0000EE81
\

$00000001 constant DDRPHYC_DDRPHYC_DX3GCR_DXEN                      \ DXEN
$00000002 constant DDRPHYC_DDRPHYC_DX3GCR_DQSODT                    \ DQSODT
$00000004 constant DDRPHYC_DDRPHYC_DX3GCR_DQODT                     \ DQODT
$00000008 constant DDRPHYC_DDRPHYC_DX3GCR_DXIOM                     \ DXIOM
$00000010 constant DDRPHYC_DDRPHYC_DX3GCR_DXPDD                     \ DXPDD
$00000020 constant DDRPHYC_DDRPHYC_DX3GCR_DXPDR                     \ DXPDR
$00000040 constant DDRPHYC_DDRPHYC_DX3GCR_DQSRPD                    \ DQSRPD
$00000180 constant DDRPHYC_DDRPHYC_DX3GCR_DSEN                      \ DSEN
$00000200 constant DDRPHYC_DDRPHYC_DX3GCR_DQSRTT                    \ DQSRTT
$00000400 constant DDRPHYC_DDRPHYC_DX3GCR_DQRTT                     \ DQRTT
$00001800 constant DDRPHYC_DDRPHYC_DX3GCR_RTTOH                     \ RTTOH
$00002000 constant DDRPHYC_DDRPHYC_DX3GCR_RTTOAL                    \ RTTOAL
$0001c000 constant DDRPHYC_DDRPHYC_DX3GCR_R0RVSL                    \ R0RVSL


\
\ @brief DDRPHYC byte lane 3 GS register 0
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX3GSR0_DTDONE                   \ DTDONE
$00000010 constant DDRPHYC_DDRPHYC_DX3GSR0_DTERR                    \ DTERR
$00000100 constant DDRPHYC_DDRPHYC_DX3GSR0_DTIERR                   \ DTIERR
$0000e000 constant DDRPHYC_DDRPHYC_DX3GSR0_DTPASS                   \ DTPASS


\
\ @brief DDRPHYC byte lane 3 GS register 1
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX3GSR1_DFTERR                   \ DFTERR
$00000030 constant DDRPHYC_DDRPHYC_DX3GSR1_DQSDFT                   \ DQSDFT
$00001000 constant DDRPHYC_DDRPHYC_DX3GSR1_RVERR                    \ RVERR
$00010000 constant DDRPHYC_DDRPHYC_DX3GSR1_RVIERR                   \ RVIERR
$00700000 constant DDRPHYC_DDRPHYC_DX3GSR1_RVPASS                   \ RVPASS


\
\ @brief DDRPHYC byte lane 3 DLLC register
\ Address offset: 0x28C
\ Reset value: 0x40000000
\

$00000007 constant DDRPHYC_DDRPHYC_DX3DLLCR_SFBDLY                  \ SFBDLY
$00000038 constant DDRPHYC_DDRPHYC_DX3DLLCR_SFWDLY                  \ SFWDLY
$000001c0 constant DDRPHYC_DDRPHYC_DX3DLLCR_MFBDLY                  \ MFBDLY
$00000e00 constant DDRPHYC_DDRPHYC_DX3DLLCR_MFWDLY                  \ MFWDLY
$00003000 constant DDRPHYC_DDRPHYC_DX3DLLCR_SSTART                  \ SSTART
$0003c000 constant DDRPHYC_DDRPHYC_DX3DLLCR_SDPHASE                 \ SDPHASE
$00040000 constant DDRPHYC_DDRPHYC_DX3DLLCR_ATESTEN                 \ ATESTEN
$00080000 constant DDRPHYC_DDRPHYC_DX3DLLCR_SDLBMODE                \ SDLBMODE
$40000000 constant DDRPHYC_DDRPHYC_DX3DLLCR_DLLSRST                 \ DLLSRST
$80000000 constant DDRPHYC_DDRPHYC_DX3DLLCR_DLLDIS                  \ DLLDIS


\
\ @brief DDRPHYC byte lane 3 DQT register
\ Address offset: 0x290
\ Reset value: 0xFFFFFFFF
\

$0000000f constant DDRPHYC_DDRPHYC_DX3DQTR_DQDLY0                   \ DQDLY0
$000000f0 constant DDRPHYC_DDRPHYC_DX3DQTR_DQDLY1                   \ DQDLY1
$00000f00 constant DDRPHYC_DDRPHYC_DX3DQTR_DQDLY2                   \ DQDLY2
$0000f000 constant DDRPHYC_DDRPHYC_DX3DQTR_DQDLY3                   \ DQDLY3
$000f0000 constant DDRPHYC_DDRPHYC_DX3DQTR_DQDLY4                   \ DQDLY4
$00f00000 constant DDRPHYC_DDRPHYC_DX3DQTR_DQDLY5                   \ DQDLY5
$0f000000 constant DDRPHYC_DDRPHYC_DX3DQTR_DQDLY6                   \ DQDLY6
$f0000000 constant DDRPHYC_DDRPHYC_DX3DQTR_DQDLY7                   \ DQDLY7


\
\ @brief DDRPHYC byte lane 3 DQST register
\ Address offset: 0x294
\ Reset value: 0x3DB02000
\

$00000007 constant DDRPHYC_DDRPHYC_DX3DQSTR_R0DGSL                  \ R0DGSL
$00003000 constant DDRPHYC_DDRPHYC_DX3DQSTR_R0DGPS                  \ R0DGPS
$00700000 constant DDRPHYC_DDRPHYC_DX3DQSTR_DQSDLY                  \ DQSDLY
$03800000 constant DDRPHYC_DDRPHYC_DX3DQSTR_DQSNDLY                 \ DQSNDLY
$3c000000 constant DDRPHYC_DDRPHYC_DX3DQSTR_DMDLY                   \ DMDLY


\
\ @brief DDRPHYC
\
$5a004000 constant DDRPHYC_DDRPHYC_RIDR  \ offset: 0x00 : DDRPHYC revision ID register
$5a004004 constant DDRPHYC_DDRPHYC_PIR  \ offset: 0x04 : DDRPHYC PHY initialization register
$5a004008 constant DDRPHYC_DDRPHYC_PGCR  \ offset: 0x08 : DDRPHYC PHY global control register
$5a00400c constant DDRPHYC_DDRPHYC_PGSR  \ offset: 0x0C : DDRPHYC PHY global status register
$5a004010 constant DDRPHYC_DDRPHYC_DLLGCR  \ offset: 0x10 : DDRPHYC DDR global control register
$5a004014 constant DDRPHYC_DDRPHYC_ACDLLCR  \ offset: 0x14 : DDRPHYC AC DLL control register
$5a004018 constant DDRPHYC_DDRPHYC_PTR0  \ offset: 0x18 : DDRPHYC PT register 0
$5a00401c constant DDRPHYC_DDRPHYC_PTR1  \ offset: 0x1C : DDRPHYC PT register 1
$5a004020 constant DDRPHYC_DDRPHYC_PTR2  \ offset: 0x20 : DDRPHYC PT register 2
$5a004024 constant DDRPHYC_DDRPHYC_ACIOCR  \ offset: 0x24 : DDRPHYC ACIOC register
$5a004028 constant DDRPHYC_DDRPHYC_DXCCR  \ offset: 0x28 : DDRPHYC DXCC register
$5a00402c constant DDRPHYC_DDRPHYC_DSGCR  \ offset: 0x2C : DDRPHYC DSGC register
$5a004030 constant DDRPHYC_DDRPHYC_DCR  \ offset: 0x30 : DDRPHYC DC register
$5a004034 constant DDRPHYC_DDRPHYC_DTPR0  \ offset: 0x34 : DDRPHYC DTP register 0
$5a004038 constant DDRPHYC_DDRPHYC_DTPR1  \ offset: 0x38 : DDRPHYC DTP register 1
$5a00403c constant DDRPHYC_DDRPHYC_DTPR2  \ offset: 0x3C : DDRPHYC DTP register 2
$5a004040 constant DDRPHYC_DDRPHYC_DDR3_MR0  \ offset: 0x40 : DDRPHYC MR0 register for DDR3
$5a004044 constant DDRPHYC_DDRPHYC_DDR3_MR1  \ offset: 0x44 : DDRPHYC MR1 register for DDR3
$5a004048 constant DDRPHYC_DDRPHYC_DDR3_MR2  \ offset: 0x48 : DDRPHYC MR2 register for DDR3
$5a00404c constant DDRPHYC_DDRPHYC_DDR3_MR3  \ offset: 0x4C : DDRPHYC MR3 register for DDR3
$5a004050 constant DDRPHYC_DDRPHYC_ODTCR  \ offset: 0x50 : DDRPHYC ODTC register
$5a004054 constant DDRPHYC_DDRPHYC_DTAR  \ offset: 0x54 : DDRPHYC DTA register
$5a004058 constant DDRPHYC_DDRPHYC_DTDR0  \ offset: 0x58 : DDRPHYC DTD register 0
$5a00405c constant DDRPHYC_DDRPHYC_DTDR1  \ offset: 0x5C : DDRPHYC DTD register 1
$5a004178 constant DDRPHYC_DDRPHYC_GPR0  \ offset: 0x178 : DDRPHYC general purpose register 0
$5a00417c constant DDRPHYC_DDRPHYC_GPR1  \ offset: 0x17C : DDRPHYC general purpose register 1
$5a004180 constant DDRPHYC_DDRPHYC_ZQ0CR0  \ offset: 0x180 : DDRPHYC ZQ0C register 0
$5a004184 constant DDRPHYC_DDRPHYC_ZQ0CR1  \ offset: 0x184 : DDRPHYC ZQ0CR1 register
$5a004188 constant DDRPHYC_DDRPHYC_ZQ0SR0  \ offset: 0x188 : DDRPHYC ZQ0S register 0
$5a00418c constant DDRPHYC_DDRPHYC_ZQ0SR1  \ offset: 0x18C : DDRPHYC ZQ0S register 1
$5a0041c0 constant DDRPHYC_DDRPHYC_DX0GCR  \ offset: 0x1C0 : DDRPHYC byte lane 0 GC register
$5a0041c4 constant DDRPHYC_DDRPHYC_DX0GSR0  \ offset: 0x1C4 : DDRPHYC byte lane 0 GS register 0
$5a0041c8 constant DDRPHYC_DDRPHYC_DX0GSR1  \ offset: 0x1C8 : DDRPHYC byte lane 0 GS register 1
$5a0041cc constant DDRPHYC_DDRPHYC_DX0DLLCR  \ offset: 0x1CC : DDRPHYC byte lane 0 DLLC register
$5a0041d0 constant DDRPHYC_DDRPHYC_DX0DQTR  \ offset: 0x1D0 : DDRPHYC byte lane 0 DQT register
$5a0041d4 constant DDRPHYC_DDRPHYC_DX0DQSTR  \ offset: 0x1D4 : DDRPHYC byte lane 0 DQST register
$5a004200 constant DDRPHYC_DDRPHYC_DX1GCR  \ offset: 0x200 : DDRPHYC byte lane 1 GC register
$5a004204 constant DDRPHYC_DDRPHYC_DX1GSR0  \ offset: 0x204 : DDRPHYC byte lane 1 GS register 0
$5a004208 constant DDRPHYC_DDRPHYC_DX1GSR1  \ offset: 0x208 : DDRPHYC byte lane 1 GS register 1
$5a00420c constant DDRPHYC_DDRPHYC_DX1DLLCR  \ offset: 0x20C : DDRPHYC byte lane 1 DLLC register
$5a004210 constant DDRPHYC_DDRPHYC_DX1DQTR  \ offset: 0x210 : DDRPHYC byte lane 1 DQT register
$5a004214 constant DDRPHYC_DDRPHYC_DX1DQSTR  \ offset: 0x214 : DDRPHYC byte lane 1 DQST register
$5a004240 constant DDRPHYC_DDRPHYC_DX2GCR  \ offset: 0x240 : DDRPHYC byte lane 2 GC register
$5a004244 constant DDRPHYC_DDRPHYC_DX2GSR0  \ offset: 0x244 : DDRPHYC byte lane 2 GS register 0
$5a004248 constant DDRPHYC_DDRPHYC_DX2GSR1  \ offset: 0x248 : DDRPHYC byte lane 2 GS register 1
$5a00424c constant DDRPHYC_DDRPHYC_DX2DLLCR  \ offset: 0x24C : DDRPHYC byte lane 2 DLLC register
$5a004250 constant DDRPHYC_DDRPHYC_DX2DQTR  \ offset: 0x250 : DDRPHYC byte lane 2 DQT register
$5a004254 constant DDRPHYC_DDRPHYC_DX2DQSTR  \ offset: 0x254 : DDRPHYC byte lane 2 DQST register
$5a004280 constant DDRPHYC_DDRPHYC_DX3GCR  \ offset: 0x280 : DDRPHYC byte lane 3 GC register
$5a004284 constant DDRPHYC_DDRPHYC_DX3GSR0  \ offset: 0x284 : DDRPHYC byte lane 3 GS register 0
$5a004288 constant DDRPHYC_DDRPHYC_DX3GSR1  \ offset: 0x288 : DDRPHYC byte lane 3 GS register 1
$5a00428c constant DDRPHYC_DDRPHYC_DX3DLLCR  \ offset: 0x28C : DDRPHYC byte lane 3 DLLC register
$5a004290 constant DDRPHYC_DDRPHYC_DX3DQTR  \ offset: 0x290 : DDRPHYC byte lane 3 DQT register
$5a004294 constant DDRPHYC_DDRPHYC_DX3DQSTR  \ offset: 0x294 : DDRPHYC byte lane 3 DQST register

