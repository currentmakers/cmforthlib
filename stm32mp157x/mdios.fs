\
\ @file mdios.fs
\ @brief MDIOS
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief MDIOS configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant MDIOS_MDIOS_CR_EN                                \ EN
$00000002 constant MDIOS_MDIOS_CR_WRIE                              \ WRIE
$00000004 constant MDIOS_MDIOS_CR_RDIE                              \ RDIE
$00000008 constant MDIOS_MDIOS_CR_EIE                               \ EIE
$00000080 constant MDIOS_MDIOS_CR_DPC                               \ DPC
$00001f00 constant MDIOS_MDIOS_CR_PORT_ADDRESS                      \ PORT_ADDRESS


\
\ @brief MDIOS write flag register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_WRFR_WRF                             \ WRF


\
\ @brief MDIOS clear write flag register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_CWRFR_CWRF                           \ CWRF


\
\ @brief MDIOS read flag register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_RDFR_RDF                             \ RDF


\
\ @brief MDIOS clear read flag register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_CRDFR_CRDF                           \ CRDF


\
\ @brief MDIOS status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant MDIOS_MDIOS_SR_PERF                              \ PERF
$00000002 constant MDIOS_MDIOS_SR_SERF                              \ SERF
$00000004 constant MDIOS_MDIOS_SR_TERF                              \ TERF


\
\ @brief MDIOS clear flag register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant MDIOS_MDIOS_CLRFR_CPERF                          \ CPERF
$00000002 constant MDIOS_MDIOS_CLRFR_CSERF                          \ CSERF
$00000004 constant MDIOS_MDIOS_CLRFR_CTERF                          \ CTERF


\
\ @brief MDIOS input data register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR0_DIN                            \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR1_DIN                            \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR2_DIN                            \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR3_DIN                            \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR4_DIN                            \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR5_DIN                            \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR6_DIN                            \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR7_DIN                            \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR8_DIN                            \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR9_DIN                            \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR10_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR11_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR12_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR13_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR14_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR15_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR16_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR17_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR18_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR19_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR20_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR21_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR22_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR23_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR24_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR25_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR26_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR27_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR28_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR29_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR30_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR31_DIN                           \ DIN


\
\ @brief MDIOS input data register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR0_DOUT                          \ DOUT


\
\ @brief MDIOS input data register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR1_DOUT                          \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR2_DOUT                          \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR3_DOUT                          \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR4_DOUT                          \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR5_DOUT                          \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR6_DOUT                          \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR7_DOUT                          \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR8_DOUT                          \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR9_DOUT                          \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR10_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR11_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR12_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR13_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR14_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR15_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR16_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR17_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR18_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR19_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR20_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR21_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1D8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR22_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR23_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR24_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR25_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR26_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR27_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR28_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR29_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1F8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR30_DOUT                         \ DOUT


\
\ @brief MDIOS output data register
\ Address offset: 0x1FC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR31_DOUT                         \ DOUT


\
\ @brief MDIOS HW configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000020
\

$000000ff constant MDIOS_MDIOS_HWCFGR_NBREG                         \ NBREG


\
\ @brief MDIOS version register
\ Address offset: 0x3F4
\ Reset value: 0x00000011
\

$0000000f constant MDIOS_MDIOS_VERR_MINREV                          \ MINREV
$000000f0 constant MDIOS_MDIOS_VERR_MAJREV                          \ MAJREV


\
\ @brief MDIOS identification register
\ Address offset: 0x3F8
\ Reset value: 0x00180001
\

$00000000 constant MDIOS_MDIOS_IPIDR_ID                             \ ID


\
\ @brief MDIOS size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant MDIOS_MDIOS_SIDR_SID                             \ SID


\
\ @brief MDIOS
\
$4001c000 constant MDIOS_MDIOS_CR  \ offset: 0x00 : MDIOS configuration register
$4001c004 constant MDIOS_MDIOS_WRFR  \ offset: 0x04 : MDIOS write flag register
$4001c008 constant MDIOS_MDIOS_CWRFR  \ offset: 0x08 : MDIOS clear write flag register
$4001c00c constant MDIOS_MDIOS_RDFR  \ offset: 0x0C : MDIOS read flag register
$4001c010 constant MDIOS_MDIOS_CRDFR  \ offset: 0x10 : MDIOS clear read flag register
$4001c014 constant MDIOS_MDIOS_SR  \ offset: 0x14 : MDIOS status register
$4001c018 constant MDIOS_MDIOS_CLRFR  \ offset: 0x18 : MDIOS clear flag register
$4001c100 constant MDIOS_MDIOS_DINR0  \ offset: 0x100 : MDIOS input data register
$4001c104 constant MDIOS_MDIOS_DINR1  \ offset: 0x104 : MDIOS input data register
$4001c108 constant MDIOS_MDIOS_DINR2  \ offset: 0x108 : MDIOS input data register
$4001c10c constant MDIOS_MDIOS_DINR3  \ offset: 0x10C : MDIOS input data register
$4001c110 constant MDIOS_MDIOS_DINR4  \ offset: 0x110 : MDIOS input data register
$4001c114 constant MDIOS_MDIOS_DINR5  \ offset: 0x114 : MDIOS input data register
$4001c118 constant MDIOS_MDIOS_DINR6  \ offset: 0x118 : MDIOS input data register
$4001c11c constant MDIOS_MDIOS_DINR7  \ offset: 0x11C : MDIOS input data register
$4001c120 constant MDIOS_MDIOS_DINR8  \ offset: 0x120 : MDIOS input data register
$4001c124 constant MDIOS_MDIOS_DINR9  \ offset: 0x124 : MDIOS input data register
$4001c128 constant MDIOS_MDIOS_DINR10  \ offset: 0x128 : MDIOS input data register
$4001c12c constant MDIOS_MDIOS_DINR11  \ offset: 0x12C : MDIOS input data register
$4001c130 constant MDIOS_MDIOS_DINR12  \ offset: 0x130 : MDIOS input data register
$4001c134 constant MDIOS_MDIOS_DINR13  \ offset: 0x134 : MDIOS input data register
$4001c138 constant MDIOS_MDIOS_DINR14  \ offset: 0x138 : MDIOS input data register
$4001c13c constant MDIOS_MDIOS_DINR15  \ offset: 0x13C : MDIOS input data register
$4001c140 constant MDIOS_MDIOS_DINR16  \ offset: 0x140 : MDIOS input data register
$4001c144 constant MDIOS_MDIOS_DINR17  \ offset: 0x144 : MDIOS input data register
$4001c148 constant MDIOS_MDIOS_DINR18  \ offset: 0x148 : MDIOS input data register
$4001c14c constant MDIOS_MDIOS_DINR19  \ offset: 0x14C : MDIOS input data register
$4001c150 constant MDIOS_MDIOS_DINR20  \ offset: 0x150 : MDIOS input data register
$4001c154 constant MDIOS_MDIOS_DINR21  \ offset: 0x154 : MDIOS input data register
$4001c158 constant MDIOS_MDIOS_DINR22  \ offset: 0x158 : MDIOS input data register
$4001c15c constant MDIOS_MDIOS_DINR23  \ offset: 0x15C : MDIOS input data register
$4001c160 constant MDIOS_MDIOS_DINR24  \ offset: 0x160 : MDIOS input data register
$4001c164 constant MDIOS_MDIOS_DINR25  \ offset: 0x164 : MDIOS input data register
$4001c168 constant MDIOS_MDIOS_DINR26  \ offset: 0x168 : MDIOS input data register
$4001c16c constant MDIOS_MDIOS_DINR27  \ offset: 0x16C : MDIOS input data register
$4001c170 constant MDIOS_MDIOS_DINR28  \ offset: 0x170 : MDIOS input data register
$4001c174 constant MDIOS_MDIOS_DINR29  \ offset: 0x174 : MDIOS input data register
$4001c178 constant MDIOS_MDIOS_DINR30  \ offset: 0x178 : MDIOS input data register
$4001c17c constant MDIOS_MDIOS_DINR31  \ offset: 0x17C : MDIOS input data register
$4001c180 constant MDIOS_MDIOS_DOUTR0  \ offset: 0x180 : MDIOS input data register
$4001c184 constant MDIOS_MDIOS_DOUTR1  \ offset: 0x184 : MDIOS input data register
$4001c188 constant MDIOS_MDIOS_DOUTR2  \ offset: 0x188 : MDIOS output data register
$4001c18c constant MDIOS_MDIOS_DOUTR3  \ offset: 0x18C : MDIOS output data register
$4001c190 constant MDIOS_MDIOS_DOUTR4  \ offset: 0x190 : MDIOS output data register
$4001c194 constant MDIOS_MDIOS_DOUTR5  \ offset: 0x194 : MDIOS output data register
$4001c198 constant MDIOS_MDIOS_DOUTR6  \ offset: 0x198 : MDIOS output data register
$4001c19c constant MDIOS_MDIOS_DOUTR7  \ offset: 0x19C : MDIOS output data register
$4001c1a0 constant MDIOS_MDIOS_DOUTR8  \ offset: 0x1A0 : MDIOS output data register
$4001c1a4 constant MDIOS_MDIOS_DOUTR9  \ offset: 0x1A4 : MDIOS output data register
$4001c1a8 constant MDIOS_MDIOS_DOUTR10  \ offset: 0x1A8 : MDIOS output data register
$4001c1ac constant MDIOS_MDIOS_DOUTR11  \ offset: 0x1AC : MDIOS output data register
$4001c1b0 constant MDIOS_MDIOS_DOUTR12  \ offset: 0x1B0 : MDIOS output data register
$4001c1b4 constant MDIOS_MDIOS_DOUTR13  \ offset: 0x1B4 : MDIOS output data register
$4001c1b8 constant MDIOS_MDIOS_DOUTR14  \ offset: 0x1B8 : MDIOS output data register
$4001c1bc constant MDIOS_MDIOS_DOUTR15  \ offset: 0x1BC : MDIOS output data register
$4001c1c0 constant MDIOS_MDIOS_DOUTR16  \ offset: 0x1C0 : MDIOS output data register
$4001c1c4 constant MDIOS_MDIOS_DOUTR17  \ offset: 0x1C4 : MDIOS output data register
$4001c1c8 constant MDIOS_MDIOS_DOUTR18  \ offset: 0x1C8 : MDIOS output data register
$4001c1cc constant MDIOS_MDIOS_DOUTR19  \ offset: 0x1CC : MDIOS output data register
$4001c1d0 constant MDIOS_MDIOS_DOUTR20  \ offset: 0x1D0 : MDIOS output data register
$4001c1d4 constant MDIOS_MDIOS_DOUTR21  \ offset: 0x1D4 : MDIOS output data register
$4001c1d8 constant MDIOS_MDIOS_DOUTR22  \ offset: 0x1D8 : MDIOS output data register
$4001c1dc constant MDIOS_MDIOS_DOUTR23  \ offset: 0x1DC : MDIOS output data register
$4001c1e0 constant MDIOS_MDIOS_DOUTR24  \ offset: 0x1E0 : MDIOS output data register
$4001c1e4 constant MDIOS_MDIOS_DOUTR25  \ offset: 0x1E4 : MDIOS output data register
$4001c1e8 constant MDIOS_MDIOS_DOUTR26  \ offset: 0x1E8 : MDIOS output data register
$4001c1ec constant MDIOS_MDIOS_DOUTR27  \ offset: 0x1EC : MDIOS output data register
$4001c1f0 constant MDIOS_MDIOS_DOUTR28  \ offset: 0x1F0 : MDIOS output data register
$4001c1f4 constant MDIOS_MDIOS_DOUTR29  \ offset: 0x1F4 : MDIOS output data register
$4001c1f8 constant MDIOS_MDIOS_DOUTR30  \ offset: 0x1F8 : MDIOS output data register
$4001c1fc constant MDIOS_MDIOS_DOUTR31  \ offset: 0x1FC : MDIOS output data register
$4001c3f0 constant MDIOS_MDIOS_HWCFGR  \ offset: 0x3F0 : MDIOS HW configuration register
$4001c3f4 constant MDIOS_MDIOS_VERR  \ offset: 0x3F4 : MDIOS version register
$4001c3f8 constant MDIOS_MDIOS_IPIDR  \ offset: 0x3F8 : MDIOS identification register
$4001c3fc constant MDIOS_MDIOS_SIDR  \ offset: 0x3FC : MDIOS size identification register

