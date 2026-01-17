\
\ @file mdios.fs
\ @brief MDIOS
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] MDIOS_DEF

  [ifdef] MDIOS_MDIOS_CR_DEF
    \
    \ @brief MDIOS configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_EN                       \ [0x00] EN
    $01 constant MDIOS_WRIE                     \ [0x01] WRIE
    $02 constant MDIOS_RDIE                     \ [0x02] RDIE
    $03 constant MDIOS_EIE                      \ [0x03] EIE
    $07 constant MDIOS_DPC                      \ [0x07] DPC
    $08 constant MDIOS_PORT_ADDRESS             \ [0x08 : 5] PORT_ADDRESS
  [then]


  [ifdef] MDIOS_MDIOS_WRFR_DEF
    \
    \ @brief MDIOS write flag register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_WRF                      \ [0x00 : 32] WRF
  [then]


  [ifdef] MDIOS_MDIOS_CWRFR_DEF
    \
    \ @brief MDIOS clear write flag register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_CWRF                     \ [0x00 : 32] CWRF
  [then]


  [ifdef] MDIOS_MDIOS_RDFR_DEF
    \
    \ @brief MDIOS read flag register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_RDF                      \ [0x00 : 32] RDF
  [then]


  [ifdef] MDIOS_MDIOS_CRDFR_DEF
    \
    \ @brief MDIOS clear read flag register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_CRDF                     \ [0x00 : 32] CRDF
  [then]


  [ifdef] MDIOS_MDIOS_SR_DEF
    \
    \ @brief MDIOS status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_PERF                     \ [0x00] PERF
    $01 constant MDIOS_SERF                     \ [0x01] SERF
    $02 constant MDIOS_TERF                     \ [0x02] TERF
  [then]


  [ifdef] MDIOS_MDIOS_CLRFR_DEF
    \
    \ @brief MDIOS clear flag register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_CPERF                    \ [0x00] CPERF
    $01 constant MDIOS_CSERF                    \ [0x01] CSERF
    $02 constant MDIOS_CTERF                    \ [0x02] CTERF
  [then]


  [ifdef] MDIOS_MDIOS_DINR0_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR1_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR2_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR3_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR4_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR5_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR6_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR7_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR8_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR9_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR10_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR11_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR12_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR13_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR14_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR15_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR16_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR17_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR18_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR19_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR20_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR21_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR22_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR23_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR24_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR25_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR26_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR27_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR28_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR29_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR30_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DINR31_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN                      \ [0x00 : 16] DIN
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR0_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR1_DEF
    \
    \ @brief MDIOS input data register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR2_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR3_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR4_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR5_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR6_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR7_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR8_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR9_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR10_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR11_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR12_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR13_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR14_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR15_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR16_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR17_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR18_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR19_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR20_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR21_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR22_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1D8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR23_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR24_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR25_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR26_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR27_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR28_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR29_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR30_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1F8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR31_DEF
    \
    \ @brief MDIOS output data register
    \ Address offset: 0x1FC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT                     \ [0x00 : 16] DOUT
  [then]


  [ifdef] MDIOS_MDIOS_HWCFGR_DEF
    \
    \ @brief MDIOS HW configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000020
    \
    $00 constant MDIOS_NBREG                    \ [0x00 : 8] NBREG
  [then]


  [ifdef] MDIOS_MDIOS_VERR_DEF
    \
    \ @brief MDIOS version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000011
    \
    $00 constant MDIOS_MINREV                   \ [0x00 : 4] MINREV
    $04 constant MDIOS_MAJREV                   \ [0x04 : 4] MAJREV
  [then]


  [ifdef] MDIOS_MDIOS_IPIDR_DEF
    \
    \ @brief MDIOS identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00180001
    \
    $00 constant MDIOS_ID                       \ [0x00 : 32] ID
  [then]


  [ifdef] MDIOS_MDIOS_SIDR_DEF
    \
    \ @brief MDIOS size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant MDIOS_SID                      \ [0x00 : 32] SID
  [then]

  \
  \ @brief MDIOS
  \
  $00 constant MDIOS_MDIOS_CR           \ MDIOS configuration register
  $04 constant MDIOS_MDIOS_WRFR         \ MDIOS write flag register
  $08 constant MDIOS_MDIOS_CWRFR        \ MDIOS clear write flag register
  $0C constant MDIOS_MDIOS_RDFR         \ MDIOS read flag register
  $10 constant MDIOS_MDIOS_CRDFR        \ MDIOS clear read flag register
  $14 constant MDIOS_MDIOS_SR           \ MDIOS status register
  $18 constant MDIOS_MDIOS_CLRFR        \ MDIOS clear flag register
  $100 constant MDIOS_MDIOS_DINR0       \ MDIOS input data register
  $104 constant MDIOS_MDIOS_DINR1       \ MDIOS input data register
  $108 constant MDIOS_MDIOS_DINR2       \ MDIOS input data register
  $10C constant MDIOS_MDIOS_DINR3       \ MDIOS input data register
  $110 constant MDIOS_MDIOS_DINR4       \ MDIOS input data register
  $114 constant MDIOS_MDIOS_DINR5       \ MDIOS input data register
  $118 constant MDIOS_MDIOS_DINR6       \ MDIOS input data register
  $11C constant MDIOS_MDIOS_DINR7       \ MDIOS input data register
  $120 constant MDIOS_MDIOS_DINR8       \ MDIOS input data register
  $124 constant MDIOS_MDIOS_DINR9       \ MDIOS input data register
  $128 constant MDIOS_MDIOS_DINR10      \ MDIOS input data register
  $12C constant MDIOS_MDIOS_DINR11      \ MDIOS input data register
  $130 constant MDIOS_MDIOS_DINR12      \ MDIOS input data register
  $134 constant MDIOS_MDIOS_DINR13      \ MDIOS input data register
  $138 constant MDIOS_MDIOS_DINR14      \ MDIOS input data register
  $13C constant MDIOS_MDIOS_DINR15      \ MDIOS input data register
  $140 constant MDIOS_MDIOS_DINR16      \ MDIOS input data register
  $144 constant MDIOS_MDIOS_DINR17      \ MDIOS input data register
  $148 constant MDIOS_MDIOS_DINR18      \ MDIOS input data register
  $14C constant MDIOS_MDIOS_DINR19      \ MDIOS input data register
  $150 constant MDIOS_MDIOS_DINR20      \ MDIOS input data register
  $154 constant MDIOS_MDIOS_DINR21      \ MDIOS input data register
  $158 constant MDIOS_MDIOS_DINR22      \ MDIOS input data register
  $15C constant MDIOS_MDIOS_DINR23      \ MDIOS input data register
  $160 constant MDIOS_MDIOS_DINR24      \ MDIOS input data register
  $164 constant MDIOS_MDIOS_DINR25      \ MDIOS input data register
  $168 constant MDIOS_MDIOS_DINR26      \ MDIOS input data register
  $16C constant MDIOS_MDIOS_DINR27      \ MDIOS input data register
  $170 constant MDIOS_MDIOS_DINR28      \ MDIOS input data register
  $174 constant MDIOS_MDIOS_DINR29      \ MDIOS input data register
  $178 constant MDIOS_MDIOS_DINR30      \ MDIOS input data register
  $17C constant MDIOS_MDIOS_DINR31      \ MDIOS input data register
  $180 constant MDIOS_MDIOS_DOUTR0      \ MDIOS input data register
  $184 constant MDIOS_MDIOS_DOUTR1      \ MDIOS input data register
  $188 constant MDIOS_MDIOS_DOUTR2      \ MDIOS output data register
  $18C constant MDIOS_MDIOS_DOUTR3      \ MDIOS output data register
  $190 constant MDIOS_MDIOS_DOUTR4      \ MDIOS output data register
  $194 constant MDIOS_MDIOS_DOUTR5      \ MDIOS output data register
  $198 constant MDIOS_MDIOS_DOUTR6      \ MDIOS output data register
  $19C constant MDIOS_MDIOS_DOUTR7      \ MDIOS output data register
  $1A0 constant MDIOS_MDIOS_DOUTR8      \ MDIOS output data register
  $1A4 constant MDIOS_MDIOS_DOUTR9      \ MDIOS output data register
  $1A8 constant MDIOS_MDIOS_DOUTR10     \ MDIOS output data register
  $1AC constant MDIOS_MDIOS_DOUTR11     \ MDIOS output data register
  $1B0 constant MDIOS_MDIOS_DOUTR12     \ MDIOS output data register
  $1B4 constant MDIOS_MDIOS_DOUTR13     \ MDIOS output data register
  $1B8 constant MDIOS_MDIOS_DOUTR14     \ MDIOS output data register
  $1BC constant MDIOS_MDIOS_DOUTR15     \ MDIOS output data register
  $1C0 constant MDIOS_MDIOS_DOUTR16     \ MDIOS output data register
  $1C4 constant MDIOS_MDIOS_DOUTR17     \ MDIOS output data register
  $1C8 constant MDIOS_MDIOS_DOUTR18     \ MDIOS output data register
  $1CC constant MDIOS_MDIOS_DOUTR19     \ MDIOS output data register
  $1D0 constant MDIOS_MDIOS_DOUTR20     \ MDIOS output data register
  $1D4 constant MDIOS_MDIOS_DOUTR21     \ MDIOS output data register
  $1D8 constant MDIOS_MDIOS_DOUTR22     \ MDIOS output data register
  $1DC constant MDIOS_MDIOS_DOUTR23     \ MDIOS output data register
  $1E0 constant MDIOS_MDIOS_DOUTR24     \ MDIOS output data register
  $1E4 constant MDIOS_MDIOS_DOUTR25     \ MDIOS output data register
  $1E8 constant MDIOS_MDIOS_DOUTR26     \ MDIOS output data register
  $1EC constant MDIOS_MDIOS_DOUTR27     \ MDIOS output data register
  $1F0 constant MDIOS_MDIOS_DOUTR28     \ MDIOS output data register
  $1F4 constant MDIOS_MDIOS_DOUTR29     \ MDIOS output data register
  $1F8 constant MDIOS_MDIOS_DOUTR30     \ MDIOS output data register
  $1FC constant MDIOS_MDIOS_DOUTR31     \ MDIOS output data register
  $3F0 constant MDIOS_MDIOS_HWCFGR      \ MDIOS HW configuration register
  $3F4 constant MDIOS_MDIOS_VERR        \ MDIOS version register
  $3F8 constant MDIOS_MDIOS_IPIDR       \ MDIOS identification register
  $3FC constant MDIOS_MDIOS_SIDR        \ MDIOS size identification register

: MDIOS_DEF ; [then]
