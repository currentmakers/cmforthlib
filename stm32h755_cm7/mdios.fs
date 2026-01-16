\
\ @file mdios.fs
\ @brief Management data input/output slave
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

$00000001 constant MDIOS_MDIOS_CR_EN                                \ Peripheral enable
$00000002 constant MDIOS_MDIOS_CR_WRIE                              \ Register write interrupt enable
$00000004 constant MDIOS_MDIOS_CR_RDIE                              \ Register Read Interrupt Enable
$00000008 constant MDIOS_MDIOS_CR_EIE                               \ Error interrupt enable
$00000080 constant MDIOS_MDIOS_CR_DPC                               \ Disable Preamble Check
$00001f00 constant MDIOS_MDIOS_CR_PORT_ADDRESS                      \ Slaves's address


\
\ @brief MDIOS write flag register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_WRFR_WRF                             \ Write flags for MDIO registers 0 to 31


\
\ @brief MDIOS clear write flag register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_CWRFR_CWRF                           \ Clear the write flag


\
\ @brief MDIOS read flag register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_RDFR_RDF                             \ Read flags for MDIO registers 0 to 31


\
\ @brief MDIOS clear read flag register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant MDIOS_MDIOS_CRDFR_CRDF                           \ Clear the read flag


\
\ @brief MDIOS status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant MDIOS_MDIOS_SR_PERF                              \ Preamble error flag
$00000002 constant MDIOS_MDIOS_SR_SERF                              \ Start error flag
$00000004 constant MDIOS_MDIOS_SR_TERF                              \ Turnaround error flag


\
\ @brief MDIOS clear flag register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant MDIOS_MDIOS_CLRFR_CPERF                          \ Clear the preamble error flag
$00000002 constant MDIOS_MDIOS_CLRFR_CSERF                          \ Clear the start error flag
$00000004 constant MDIOS_MDIOS_CLRFR_CTERF                          \ Clear the turnaround error flag


\
\ @brief MDIOS input data register 0
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR0_DIN0                           \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR1_DIN1                           \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR2_DIN2                           \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 3
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR3_DIN3                           \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 4
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR4_DIN4                           \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 5
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR5_DIN5                           \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 6
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR6_DIN6                           \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 7
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR7_DIN7                           \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 8
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR8_DIN8                           \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 9
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR9_DIN9                           \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 10
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR10_DIN10                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 11
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR11_DIN11                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 12
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR12_DIN12                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 13
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR13_DIN13                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 14
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR14_DIN14                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 15
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR15_DIN15                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 16
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR16_DIN16                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 17
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR17_DIN17                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 18
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR18_DIN18                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 19
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR19_DIN19                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 20
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR20_DIN20                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 21
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR21_DIN21                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 22
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR22_DIN22                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 23
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR23_DIN23                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 24
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR24_DIN24                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 25
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR25_DIN25                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 26
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR26_DIN26                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 27
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR27_DIN27                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 28
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR28_DIN28                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 29
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR29_DIN29                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 30
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR30_DIN30                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS input data register 31
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DINR31_DIN31                         \ Input data received from MDIO Master during write frames


\
\ @brief MDIOS output data register 0
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR0_DOUT0                         \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 1
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR1_DOUT1                         \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 2
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR2_DOUT2                         \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 3
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR3_DOUT3                         \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 4
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR4_DOUT4                         \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 5
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR5_DOUT5                         \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 6
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR6_DOUT6                         \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 7
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR7_DOUT7                         \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 8
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR8_DOUT8                         \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 9
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR9_DOUT9                         \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 10
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR10_DOUT10                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 11
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR11_DOUT11                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 12
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR12_DOUT12                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 13
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR13_DOUT13                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 14
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR14_DOUT14                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 15
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR15_DOUT15                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 16
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR16_DOUT16                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 17
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR17_DOUT17                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 18
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR18_DOUT18                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 19
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR19_DOUT19                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 20
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR20_DOUT20                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 21
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR21_DOUT21                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 22
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR22_DOUT22                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 23
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR23_DOUT23                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 24
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR24_DOUT24                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 25
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR25_DOUT25                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 26
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR26_DOUT26                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 27
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR27_DOUT27                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 28
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR28_DOUT28                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 29
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR29_DOUT29                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 30
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR30_DOUT30                       \ Output data sent to MDIO Master during read frames


\
\ @brief MDIOS output data register 31
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant MDIOS_MDIOS_DOUTR31_DOUT31                       \ Output data sent to MDIO Master during read frames


\
\ @brief Management data input/output slave
\
$40009400 constant MDIOS_MDIOS_CR  \ offset: 0x00 : MDIOS configuration register
$40009404 constant MDIOS_MDIOS_WRFR  \ offset: 0x04 : MDIOS write flag register
$40009408 constant MDIOS_MDIOS_CWRFR  \ offset: 0x08 : MDIOS clear write flag register
$4000940c constant MDIOS_MDIOS_RDFR  \ offset: 0x0C : MDIOS read flag register
$40009410 constant MDIOS_MDIOS_CRDFR  \ offset: 0x10 : MDIOS clear read flag register
$40009414 constant MDIOS_MDIOS_SR  \ offset: 0x14 : MDIOS status register
$40009418 constant MDIOS_MDIOS_CLRFR  \ offset: 0x18 : MDIOS clear flag register
$4000941c constant MDIOS_MDIOS_DINR0  \ offset: 0x1C : MDIOS input data register 0
$40009420 constant MDIOS_MDIOS_DINR1  \ offset: 0x20 : MDIOS input data register 1
$40009424 constant MDIOS_MDIOS_DINR2  \ offset: 0x24 : MDIOS input data register 2
$40009428 constant MDIOS_MDIOS_DINR3  \ offset: 0x28 : MDIOS input data register 3
$4000942c constant MDIOS_MDIOS_DINR4  \ offset: 0x2C : MDIOS input data register 4
$40009430 constant MDIOS_MDIOS_DINR5  \ offset: 0x30 : MDIOS input data register 5
$40009434 constant MDIOS_MDIOS_DINR6  \ offset: 0x34 : MDIOS input data register 6
$40009438 constant MDIOS_MDIOS_DINR7  \ offset: 0x38 : MDIOS input data register 7
$4000943c constant MDIOS_MDIOS_DINR8  \ offset: 0x3C : MDIOS input data register 8
$40009440 constant MDIOS_MDIOS_DINR9  \ offset: 0x40 : MDIOS input data register 9
$40009444 constant MDIOS_MDIOS_DINR10  \ offset: 0x44 : MDIOS input data register 10
$40009448 constant MDIOS_MDIOS_DINR11  \ offset: 0x48 : MDIOS input data register 11
$4000944c constant MDIOS_MDIOS_DINR12  \ offset: 0x4C : MDIOS input data register 12
$40009450 constant MDIOS_MDIOS_DINR13  \ offset: 0x50 : MDIOS input data register 13
$40009454 constant MDIOS_MDIOS_DINR14  \ offset: 0x54 : MDIOS input data register 14
$40009458 constant MDIOS_MDIOS_DINR15  \ offset: 0x58 : MDIOS input data register 15
$4000945c constant MDIOS_MDIOS_DINR16  \ offset: 0x5C : MDIOS input data register 16
$40009460 constant MDIOS_MDIOS_DINR17  \ offset: 0x60 : MDIOS input data register 17
$40009464 constant MDIOS_MDIOS_DINR18  \ offset: 0x64 : MDIOS input data register 18
$40009468 constant MDIOS_MDIOS_DINR19  \ offset: 0x68 : MDIOS input data register 19
$4000946c constant MDIOS_MDIOS_DINR20  \ offset: 0x6C : MDIOS input data register 20
$40009470 constant MDIOS_MDIOS_DINR21  \ offset: 0x70 : MDIOS input data register 21
$40009474 constant MDIOS_MDIOS_DINR22  \ offset: 0x74 : MDIOS input data register 22
$40009478 constant MDIOS_MDIOS_DINR23  \ offset: 0x78 : MDIOS input data register 23
$4000947c constant MDIOS_MDIOS_DINR24  \ offset: 0x7C : MDIOS input data register 24
$40009480 constant MDIOS_MDIOS_DINR25  \ offset: 0x80 : MDIOS input data register 25
$40009484 constant MDIOS_MDIOS_DINR26  \ offset: 0x84 : MDIOS input data register 26
$40009488 constant MDIOS_MDIOS_DINR27  \ offset: 0x88 : MDIOS input data register 27
$4000948c constant MDIOS_MDIOS_DINR28  \ offset: 0x8C : MDIOS input data register 28
$40009490 constant MDIOS_MDIOS_DINR29  \ offset: 0x90 : MDIOS input data register 29
$40009494 constant MDIOS_MDIOS_DINR30  \ offset: 0x94 : MDIOS input data register 30
$40009498 constant MDIOS_MDIOS_DINR31  \ offset: 0x98 : MDIOS input data register 31
$4000949c constant MDIOS_MDIOS_DOUTR0  \ offset: 0x9C : MDIOS output data register 0
$400094a0 constant MDIOS_MDIOS_DOUTR1  \ offset: 0xA0 : MDIOS output data register 1
$400094a4 constant MDIOS_MDIOS_DOUTR2  \ offset: 0xA4 : MDIOS output data register 2
$400094a8 constant MDIOS_MDIOS_DOUTR3  \ offset: 0xA8 : MDIOS output data register 3
$400094ac constant MDIOS_MDIOS_DOUTR4  \ offset: 0xAC : MDIOS output data register 4
$400094b0 constant MDIOS_MDIOS_DOUTR5  \ offset: 0xB0 : MDIOS output data register 5
$400094b4 constant MDIOS_MDIOS_DOUTR6  \ offset: 0xB4 : MDIOS output data register 6
$400094b8 constant MDIOS_MDIOS_DOUTR7  \ offset: 0xB8 : MDIOS output data register 7
$400094bc constant MDIOS_MDIOS_DOUTR8  \ offset: 0xBC : MDIOS output data register 8
$400094c0 constant MDIOS_MDIOS_DOUTR9  \ offset: 0xC0 : MDIOS output data register 9
$400094c4 constant MDIOS_MDIOS_DOUTR10  \ offset: 0xC4 : MDIOS output data register 10
$400094c8 constant MDIOS_MDIOS_DOUTR11  \ offset: 0xC8 : MDIOS output data register 11
$400094cc constant MDIOS_MDIOS_DOUTR12  \ offset: 0xCC : MDIOS output data register 12
$400094d0 constant MDIOS_MDIOS_DOUTR13  \ offset: 0xD0 : MDIOS output data register 13
$400094d4 constant MDIOS_MDIOS_DOUTR14  \ offset: 0xD4 : MDIOS output data register 14
$400094d8 constant MDIOS_MDIOS_DOUTR15  \ offset: 0xD8 : MDIOS output data register 15
$400094dc constant MDIOS_MDIOS_DOUTR16  \ offset: 0xDC : MDIOS output data register 16
$400094e0 constant MDIOS_MDIOS_DOUTR17  \ offset: 0xE0 : MDIOS output data register 17
$400094e4 constant MDIOS_MDIOS_DOUTR18  \ offset: 0xE4 : MDIOS output data register 18
$400094e8 constant MDIOS_MDIOS_DOUTR19  \ offset: 0xE8 : MDIOS output data register 19
$400094ec constant MDIOS_MDIOS_DOUTR20  \ offset: 0xEC : MDIOS output data register 20
$400094f0 constant MDIOS_MDIOS_DOUTR21  \ offset: 0xF0 : MDIOS output data register 21
$400094f4 constant MDIOS_MDIOS_DOUTR22  \ offset: 0xF4 : MDIOS output data register 22
$400094f8 constant MDIOS_MDIOS_DOUTR23  \ offset: 0xF8 : MDIOS output data register 23
$400094fc constant MDIOS_MDIOS_DOUTR24  \ offset: 0xFC : MDIOS output data register 24
$40009500 constant MDIOS_MDIOS_DOUTR25  \ offset: 0x100 : MDIOS output data register 25
$40009504 constant MDIOS_MDIOS_DOUTR26  \ offset: 0x104 : MDIOS output data register 26
$40009508 constant MDIOS_MDIOS_DOUTR27  \ offset: 0x108 : MDIOS output data register 27
$4000950c constant MDIOS_MDIOS_DOUTR28  \ offset: 0x10C : MDIOS output data register 28
$40009510 constant MDIOS_MDIOS_DOUTR29  \ offset: 0x110 : MDIOS output data register 29
$40009514 constant MDIOS_MDIOS_DOUTR30  \ offset: 0x114 : MDIOS output data register 30
$40009518 constant MDIOS_MDIOS_DOUTR31  \ offset: 0x118 : MDIOS output data register 31

