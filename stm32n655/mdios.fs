\
\ @file mdios.fs
\ @brief Management data input/output
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

$00000001 constant MDIOS_MDIOS_CR_EN                                \ peripheral enable
$00000002 constant MDIOS_MDIOS_CR_WRIE                              \ register write interrupt enable
$00000004 constant MDIOS_MDIOS_CR_RDIE                              \ register read interrupt enable
$00000008 constant MDIOS_MDIOS_CR_EIE                               \ error interrupt enable
$00000080 constant MDIOS_MDIOS_CR_DPC                               \ disable preamble check
$00001f00 constant MDIOS_MDIOS_CR_PORT_ADDRESS                      \ slave address


\
\ @brief MDIOS write flag register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_WRFR_WRF                             \ write flags for MDIOS registers 0 to 31.


\
\ @brief MDIOS clear write flag register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_CWRFR_CWRF                           \ clear the write flag


\
\ @brief MDIOS read flag register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_RDFR_RDF                             \ read flags for MDIOS registers 0 to 31.


\
\ @brief MDIOS clear read flag register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_CRDFR_CRDF                           \ clear the read flag


\
\ @brief MDIOS status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant MDIOS_MDIOS_SR_PERF                              \ preamble error flag
$00000002 constant MDIOS_MDIOS_SR_SERF                              \ start error flag
$00000004 constant MDIOS_MDIOS_SR_TERF                              \ turnaround error flag


\
\ @brief MDIOS clear flag register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant MDIOS_MDIOS_CLRFR_CPERF                          \ clear the preamble error flag
$00000002 constant MDIOS_MDIOS_CLRFR_CSERF                          \ clear the start error flag
$00000004 constant MDIOS_MDIOS_CLRFR_CTERF                          \ clear the turnaround error flag


\
\ @brief MDIOS input data register 0
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR0_DIN                            \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 1
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR1_DIN                            \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 2
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR2_DIN                            \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 3
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR3_DIN                            \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 4
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR4_DIN                            \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 5
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR5_DIN                            \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 6
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR6_DIN                            \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 7
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR7_DIN                            \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 8
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR8_DIN                            \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 9
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR9_DIN                            \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 10
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR10_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 11
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR11_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 12
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR12_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 13
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR13_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 14
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR14_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 15
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR15_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 16
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR16_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 17
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR17_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 18
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR18_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 19
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR19_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 20
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR20_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 21
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR21_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 22
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR22_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 23
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR23_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 24
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR24_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 25
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR25_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 26
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR26_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 27
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR27_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 28
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR28_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 29
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR29_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 30
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR30_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS input data register 31
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR31_DIN                           \ input data received from MDIO master during write frames


\
\ @brief MDIOS output data register 0
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR0_DOUT                          \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 1
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR1_DOUT                          \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 2
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR2_DOUT                          \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 3
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR3_DOUT                          \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 4
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR4_DOUT                          \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 5
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR5_DOUT                          \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 6
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR6_DOUT                          \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 7
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR7_DOUT                          \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 8
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR8_DOUT                          \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 9
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR9_DOUT                          \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 10
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR10_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 11
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR11_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 12
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR12_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 13
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR13_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 14
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR14_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 15
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR15_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 16
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR16_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 17
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR17_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 18
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR18_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 19
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR19_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 20
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR20_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 21
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR21_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 22
\ Address offset: 0x1D8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR22_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 23
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR23_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 24
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR24_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 25
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR25_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 26
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR26_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 27
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR27_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 28
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR28_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 29
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR29_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 30
\ Address offset: 0x1F8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR30_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 31
\ Address offset: 0x1FC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR31_DOUT                         \ output data sent to MDIO Master during read frames


\
\ @brief Management data input/output
\
$40009400 constant MDIOS_MDIOS_CR  \ offset: 0x00 : MDIOS configuration register
$40009404 constant MDIOS_MDIOS_WRFR  \ offset: 0x04 : MDIOS write flag register
$40009408 constant MDIOS_MDIOS_CWRFR  \ offset: 0x08 : MDIOS clear write flag register
$4000940c constant MDIOS_MDIOS_RDFR  \ offset: 0x0C : MDIOS read flag register
$40009410 constant MDIOS_MDIOS_CRDFR  \ offset: 0x10 : MDIOS clear read flag register
$40009414 constant MDIOS_MDIOS_SR  \ offset: 0x14 : MDIOS status register
$40009418 constant MDIOS_MDIOS_CLRFR  \ offset: 0x18 : MDIOS clear flag register
$40009500 constant MDIOS_MDIOS_DINR0  \ offset: 0x100 : MDIOS input data register 0
$40009504 constant MDIOS_MDIOS_DINR1  \ offset: 0x104 : MDIOS input data register 1
$40009508 constant MDIOS_MDIOS_DINR2  \ offset: 0x108 : MDIOS input data register 2
$4000950c constant MDIOS_MDIOS_DINR3  \ offset: 0x10C : MDIOS input data register 3
$40009510 constant MDIOS_MDIOS_DINR4  \ offset: 0x110 : MDIOS input data register 4
$40009514 constant MDIOS_MDIOS_DINR5  \ offset: 0x114 : MDIOS input data register 5
$40009518 constant MDIOS_MDIOS_DINR6  \ offset: 0x118 : MDIOS input data register 6
$4000951c constant MDIOS_MDIOS_DINR7  \ offset: 0x11C : MDIOS input data register 7
$40009520 constant MDIOS_MDIOS_DINR8  \ offset: 0x120 : MDIOS input data register 8
$40009524 constant MDIOS_MDIOS_DINR9  \ offset: 0x124 : MDIOS input data register 9
$40009528 constant MDIOS_MDIOS_DINR10  \ offset: 0x128 : MDIOS input data register 10
$4000952c constant MDIOS_MDIOS_DINR11  \ offset: 0x12C : MDIOS input data register 11
$40009530 constant MDIOS_MDIOS_DINR12  \ offset: 0x130 : MDIOS input data register 12
$40009534 constant MDIOS_MDIOS_DINR13  \ offset: 0x134 : MDIOS input data register 13
$40009538 constant MDIOS_MDIOS_DINR14  \ offset: 0x138 : MDIOS input data register 14
$4000953c constant MDIOS_MDIOS_DINR15  \ offset: 0x13C : MDIOS input data register 15
$40009540 constant MDIOS_MDIOS_DINR16  \ offset: 0x140 : MDIOS input data register 16
$40009544 constant MDIOS_MDIOS_DINR17  \ offset: 0x144 : MDIOS input data register 17
$40009548 constant MDIOS_MDIOS_DINR18  \ offset: 0x148 : MDIOS input data register 18
$4000954c constant MDIOS_MDIOS_DINR19  \ offset: 0x14C : MDIOS input data register 19
$40009550 constant MDIOS_MDIOS_DINR20  \ offset: 0x150 : MDIOS input data register 20
$40009554 constant MDIOS_MDIOS_DINR21  \ offset: 0x154 : MDIOS input data register 21
$40009558 constant MDIOS_MDIOS_DINR22  \ offset: 0x158 : MDIOS input data register 22
$4000955c constant MDIOS_MDIOS_DINR23  \ offset: 0x15C : MDIOS input data register 23
$40009560 constant MDIOS_MDIOS_DINR24  \ offset: 0x160 : MDIOS input data register 24
$40009564 constant MDIOS_MDIOS_DINR25  \ offset: 0x164 : MDIOS input data register 25
$40009568 constant MDIOS_MDIOS_DINR26  \ offset: 0x168 : MDIOS input data register 26
$4000956c constant MDIOS_MDIOS_DINR27  \ offset: 0x16C : MDIOS input data register 27
$40009570 constant MDIOS_MDIOS_DINR28  \ offset: 0x170 : MDIOS input data register 28
$40009574 constant MDIOS_MDIOS_DINR29  \ offset: 0x174 : MDIOS input data register 29
$40009578 constant MDIOS_MDIOS_DINR30  \ offset: 0x178 : MDIOS input data register 30
$4000957c constant MDIOS_MDIOS_DINR31  \ offset: 0x17C : MDIOS input data register 31
$40009580 constant MDIOS_MDIOS_DOUTR0  \ offset: 0x180 : MDIOS output data register 0
$40009584 constant MDIOS_MDIOS_DOUTR1  \ offset: 0x184 : MDIOS output data register 1
$40009588 constant MDIOS_MDIOS_DOUTR2  \ offset: 0x188 : MDIOS output data register 2
$4000958c constant MDIOS_MDIOS_DOUTR3  \ offset: 0x18C : MDIOS output data register 3
$40009590 constant MDIOS_MDIOS_DOUTR4  \ offset: 0x190 : MDIOS output data register 4
$40009594 constant MDIOS_MDIOS_DOUTR5  \ offset: 0x194 : MDIOS output data register 5
$40009598 constant MDIOS_MDIOS_DOUTR6  \ offset: 0x198 : MDIOS output data register 6
$4000959c constant MDIOS_MDIOS_DOUTR7  \ offset: 0x19C : MDIOS output data register 7
$400095a0 constant MDIOS_MDIOS_DOUTR8  \ offset: 0x1A0 : MDIOS output data register 8
$400095a4 constant MDIOS_MDIOS_DOUTR9  \ offset: 0x1A4 : MDIOS output data register 9
$400095a8 constant MDIOS_MDIOS_DOUTR10  \ offset: 0x1A8 : MDIOS output data register 10
$400095ac constant MDIOS_MDIOS_DOUTR11  \ offset: 0x1AC : MDIOS output data register 11
$400095b0 constant MDIOS_MDIOS_DOUTR12  \ offset: 0x1B0 : MDIOS output data register 12
$400095b4 constant MDIOS_MDIOS_DOUTR13  \ offset: 0x1B4 : MDIOS output data register 13
$400095b8 constant MDIOS_MDIOS_DOUTR14  \ offset: 0x1B8 : MDIOS output data register 14
$400095bc constant MDIOS_MDIOS_DOUTR15  \ offset: 0x1BC : MDIOS output data register 15
$400095c0 constant MDIOS_MDIOS_DOUTR16  \ offset: 0x1C0 : MDIOS output data register 16
$400095c4 constant MDIOS_MDIOS_DOUTR17  \ offset: 0x1C4 : MDIOS output data register 17
$400095c8 constant MDIOS_MDIOS_DOUTR18  \ offset: 0x1C8 : MDIOS output data register 18
$400095cc constant MDIOS_MDIOS_DOUTR19  \ offset: 0x1CC : MDIOS output data register 19
$400095d0 constant MDIOS_MDIOS_DOUTR20  \ offset: 0x1D0 : MDIOS output data register 20
$400095d4 constant MDIOS_MDIOS_DOUTR21  \ offset: 0x1D4 : MDIOS output data register 21
$400095d8 constant MDIOS_MDIOS_DOUTR22  \ offset: 0x1D8 : MDIOS output data register 22
$400095dc constant MDIOS_MDIOS_DOUTR23  \ offset: 0x1DC : MDIOS output data register 23
$400095e0 constant MDIOS_MDIOS_DOUTR24  \ offset: 0x1E0 : MDIOS output data register 24
$400095e4 constant MDIOS_MDIOS_DOUTR25  \ offset: 0x1E4 : MDIOS output data register 25
$400095e8 constant MDIOS_MDIOS_DOUTR26  \ offset: 0x1E8 : MDIOS output data register 26
$400095ec constant MDIOS_MDIOS_DOUTR27  \ offset: 0x1EC : MDIOS output data register 27
$400095f0 constant MDIOS_MDIOS_DOUTR28  \ offset: 0x1F0 : MDIOS output data register 28
$400095f4 constant MDIOS_MDIOS_DOUTR29  \ offset: 0x1F4 : MDIOS output data register 29
$400095f8 constant MDIOS_MDIOS_DOUTR30  \ offset: 0x1F8 : MDIOS output data register 30
$400095fc constant MDIOS_MDIOS_DOUTR31  \ offset: 0x1FC : MDIOS output data register 31

