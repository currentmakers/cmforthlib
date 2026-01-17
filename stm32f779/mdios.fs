\
\ @file mdios.fs
\ @brief Management data input/output slave
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
    $00 constant MDIOS_EN                       \ [0x00] Peripheral enable
    $01 constant MDIOS_WRIE                     \ [0x01] Register write interrupt enable
    $02 constant MDIOS_RDIE                     \ [0x02] Register Read Interrupt Enable
    $03 constant MDIOS_EIE                      \ [0x03] Error interrupt enable
    $07 constant MDIOS_DPC                      \ [0x07] Disable Preamble Check
    $08 constant MDIOS_PORT_ADDRESS             \ [0x08 : 5] Slaves's address
  [then]


  [ifdef] MDIOS_MDIOS_WRFR_DEF
    \
    \ @brief MDIOS write flag register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_WRF                      \ [0x00 : 32] Write flags for MDIO registers 0 to 31
  [then]


  [ifdef] MDIOS_MDIOS_CWRFR_DEF
    \
    \ @brief MDIOS clear write flag register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_CWRF                     \ [0x00 : 32] Clear the write flag
  [then]


  [ifdef] MDIOS_MDIOS_RDFR_DEF
    \
    \ @brief MDIOS read flag register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_RDF                      \ [0x00 : 32] Read flags for MDIO registers 0 to 31
  [then]


  [ifdef] MDIOS_MDIOS_CRDFR_DEF
    \
    \ @brief MDIOS clear read flag register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_CRDF                     \ [0x00 : 32] Clear the read flag
  [then]


  [ifdef] MDIOS_MDIOS_SR_DEF
    \
    \ @brief MDIOS status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_PERF                     \ [0x00] Preamble error flag
    $01 constant MDIOS_SERF                     \ [0x01] Start error flag
    $02 constant MDIOS_TERF                     \ [0x02] Turnaround error flag
  [then]


  [ifdef] MDIOS_MDIOS_CLRFR_DEF
    \
    \ @brief MDIOS clear flag register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_CPERF                    \ [0x00] Clear the preamble error flag
    $01 constant MDIOS_CSERF                    \ [0x01] Clear the start error flag
    $02 constant MDIOS_CTERF                    \ [0x02] Clear the turnaround error flag
  [then]


  [ifdef] MDIOS_MDIOS_DINR0_DEF
    \
    \ @brief MDIOS input data register 0
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN0                     \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR1_DEF
    \
    \ @brief MDIOS input data register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN1                     \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR2_DEF
    \
    \ @brief MDIOS input data register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN2                     \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR3_DEF
    \
    \ @brief MDIOS input data register 3
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN3                     \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR4_DEF
    \
    \ @brief MDIOS input data register 4
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN4                     \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR5_DEF
    \
    \ @brief MDIOS input data register 5
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN5                     \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR6_DEF
    \
    \ @brief MDIOS input data register 6
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN6                     \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR7_DEF
    \
    \ @brief MDIOS input data register 7
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN7                     \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR8_DEF
    \
    \ @brief MDIOS input data register 8
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN8                     \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR9_DEF
    \
    \ @brief MDIOS input data register 9
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN9                     \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR10_DEF
    \
    \ @brief MDIOS input data register 10
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN10                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR11_DEF
    \
    \ @brief MDIOS input data register 11
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN11                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR12_DEF
    \
    \ @brief MDIOS input data register 12
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN12                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR13_DEF
    \
    \ @brief MDIOS input data register 13
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN13                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR14_DEF
    \
    \ @brief MDIOS input data register 14
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN14                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR15_DEF
    \
    \ @brief MDIOS input data register 15
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN15                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR16_DEF
    \
    \ @brief MDIOS input data register 16
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN16                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR17_DEF
    \
    \ @brief MDIOS input data register 17
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN17                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR18_DEF
    \
    \ @brief MDIOS input data register 18
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN18                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR19_DEF
    \
    \ @brief MDIOS input data register 19
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN19                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR20_DEF
    \
    \ @brief MDIOS input data register 20
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN20                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR21_DEF
    \
    \ @brief MDIOS input data register 21
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN21                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR22_DEF
    \
    \ @brief MDIOS input data register 22
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN22                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR23_DEF
    \
    \ @brief MDIOS input data register 23
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN23                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR24_DEF
    \
    \ @brief MDIOS input data register 24
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN24                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR25_DEF
    \
    \ @brief MDIOS input data register 25
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN25                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR26_DEF
    \
    \ @brief MDIOS input data register 26
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN26                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR27_DEF
    \
    \ @brief MDIOS input data register 27
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN27                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR28_DEF
    \
    \ @brief MDIOS input data register 28
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN28                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR29_DEF
    \
    \ @brief MDIOS input data register 29
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN29                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR30_DEF
    \
    \ @brief MDIOS input data register 30
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN30                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DINR31_DEF
    \
    \ @brief MDIOS input data register 31
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DIN31                    \ [0x00 : 16] Input data received from MDIO Master during write frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR0_DEF
    \
    \ @brief MDIOS output data register 0
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT0                    \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR1_DEF
    \
    \ @brief MDIOS output data register 1
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT1                    \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR2_DEF
    \
    \ @brief MDIOS output data register 2
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT2                    \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR3_DEF
    \
    \ @brief MDIOS output data register 3
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT3                    \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR4_DEF
    \
    \ @brief MDIOS output data register 4
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT4                    \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR5_DEF
    \
    \ @brief MDIOS output data register 5
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT5                    \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR6_DEF
    \
    \ @brief MDIOS output data register 6
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT6                    \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR7_DEF
    \
    \ @brief MDIOS output data register 7
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT7                    \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR8_DEF
    \
    \ @brief MDIOS output data register 8
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT8                    \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR9_DEF
    \
    \ @brief MDIOS output data register 9
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT9                    \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR10_DEF
    \
    \ @brief MDIOS output data register 10
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT10                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR11_DEF
    \
    \ @brief MDIOS output data register 11
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT11                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR12_DEF
    \
    \ @brief MDIOS output data register 12
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT12                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR13_DEF
    \
    \ @brief MDIOS output data register 13
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT13                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR14_DEF
    \
    \ @brief MDIOS output data register 14
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT14                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR15_DEF
    \
    \ @brief MDIOS output data register 15
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT15                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR16_DEF
    \
    \ @brief MDIOS output data register 16
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT16                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR17_DEF
    \
    \ @brief MDIOS output data register 17
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT17                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR18_DEF
    \
    \ @brief MDIOS output data register 18
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT18                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR19_DEF
    \
    \ @brief MDIOS output data register 19
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT19                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR20_DEF
    \
    \ @brief MDIOS output data register 20
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT20                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR21_DEF
    \
    \ @brief MDIOS output data register 21
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT21                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR22_DEF
    \
    \ @brief MDIOS output data register 22
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT22                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR23_DEF
    \
    \ @brief MDIOS output data register 23
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT23                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR24_DEF
    \
    \ @brief MDIOS output data register 24
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT24                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR25_DEF
    \
    \ @brief MDIOS output data register 25
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT25                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR26_DEF
    \
    \ @brief MDIOS output data register 26
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT26                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR27_DEF
    \
    \ @brief MDIOS output data register 27
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT27                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR28_DEF
    \
    \ @brief MDIOS output data register 28
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT28                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR29_DEF
    \
    \ @brief MDIOS output data register 29
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT29                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR30_DEF
    \
    \ @brief MDIOS output data register 30
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT30                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]


  [ifdef] MDIOS_MDIOS_DOUTR31_DEF
    \
    \ @brief MDIOS output data register 31
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant MDIOS_DOUT31                   \ [0x00 : 16] Output data sent to MDIO Master during read frames
  [then]

  \
  \ @brief Management data input/output slave
  \
  $00 constant MDIOS_MDIOS_CR           \ MDIOS configuration register
  $04 constant MDIOS_MDIOS_WRFR         \ MDIOS write flag register
  $08 constant MDIOS_MDIOS_CWRFR        \ MDIOS clear write flag register
  $0C constant MDIOS_MDIOS_RDFR         \ MDIOS read flag register
  $10 constant MDIOS_MDIOS_CRDFR        \ MDIOS clear read flag register
  $14 constant MDIOS_MDIOS_SR           \ MDIOS status register
  $18 constant MDIOS_MDIOS_CLRFR        \ MDIOS clear flag register
  $1C constant MDIOS_MDIOS_DINR0        \ MDIOS input data register 0
  $20 constant MDIOS_MDIOS_DINR1        \ MDIOS input data register 1
  $24 constant MDIOS_MDIOS_DINR2        \ MDIOS input data register 2
  $28 constant MDIOS_MDIOS_DINR3        \ MDIOS input data register 3
  $2C constant MDIOS_MDIOS_DINR4        \ MDIOS input data register 4
  $30 constant MDIOS_MDIOS_DINR5        \ MDIOS input data register 5
  $34 constant MDIOS_MDIOS_DINR6        \ MDIOS input data register 6
  $38 constant MDIOS_MDIOS_DINR7        \ MDIOS input data register 7
  $3C constant MDIOS_MDIOS_DINR8        \ MDIOS input data register 8
  $40 constant MDIOS_MDIOS_DINR9        \ MDIOS input data register 9
  $44 constant MDIOS_MDIOS_DINR10       \ MDIOS input data register 10
  $48 constant MDIOS_MDIOS_DINR11       \ MDIOS input data register 11
  $4C constant MDIOS_MDIOS_DINR12       \ MDIOS input data register 12
  $50 constant MDIOS_MDIOS_DINR13       \ MDIOS input data register 13
  $54 constant MDIOS_MDIOS_DINR14       \ MDIOS input data register 14
  $58 constant MDIOS_MDIOS_DINR15       \ MDIOS input data register 15
  $5C constant MDIOS_MDIOS_DINR16       \ MDIOS input data register 16
  $60 constant MDIOS_MDIOS_DINR17       \ MDIOS input data register 17
  $64 constant MDIOS_MDIOS_DINR18       \ MDIOS input data register 18
  $68 constant MDIOS_MDIOS_DINR19       \ MDIOS input data register 19
  $6C constant MDIOS_MDIOS_DINR20       \ MDIOS input data register 20
  $70 constant MDIOS_MDIOS_DINR21       \ MDIOS input data register 21
  $74 constant MDIOS_MDIOS_DINR22       \ MDIOS input data register 22
  $78 constant MDIOS_MDIOS_DINR23       \ MDIOS input data register 23
  $7C constant MDIOS_MDIOS_DINR24       \ MDIOS input data register 24
  $80 constant MDIOS_MDIOS_DINR25       \ MDIOS input data register 25
  $84 constant MDIOS_MDIOS_DINR26       \ MDIOS input data register 26
  $88 constant MDIOS_MDIOS_DINR27       \ MDIOS input data register 27
  $8C constant MDIOS_MDIOS_DINR28       \ MDIOS input data register 28
  $90 constant MDIOS_MDIOS_DINR29       \ MDIOS input data register 29
  $94 constant MDIOS_MDIOS_DINR30       \ MDIOS input data register 30
  $98 constant MDIOS_MDIOS_DINR31       \ MDIOS input data register 31
  $9C constant MDIOS_MDIOS_DOUTR0       \ MDIOS output data register 0
  $A0 constant MDIOS_MDIOS_DOUTR1       \ MDIOS output data register 1
  $A4 constant MDIOS_MDIOS_DOUTR2       \ MDIOS output data register 2
  $A8 constant MDIOS_MDIOS_DOUTR3       \ MDIOS output data register 3
  $AC constant MDIOS_MDIOS_DOUTR4       \ MDIOS output data register 4
  $B0 constant MDIOS_MDIOS_DOUTR5       \ MDIOS output data register 5
  $B4 constant MDIOS_MDIOS_DOUTR6       \ MDIOS output data register 6
  $B8 constant MDIOS_MDIOS_DOUTR7       \ MDIOS output data register 7
  $BC constant MDIOS_MDIOS_DOUTR8       \ MDIOS output data register 8
  $C0 constant MDIOS_MDIOS_DOUTR9       \ MDIOS output data register 9
  $C4 constant MDIOS_MDIOS_DOUTR10      \ MDIOS output data register 10
  $C8 constant MDIOS_MDIOS_DOUTR11      \ MDIOS output data register 11
  $CC constant MDIOS_MDIOS_DOUTR12      \ MDIOS output data register 12
  $D0 constant MDIOS_MDIOS_DOUTR13      \ MDIOS output data register 13
  $D4 constant MDIOS_MDIOS_DOUTR14      \ MDIOS output data register 14
  $D8 constant MDIOS_MDIOS_DOUTR15      \ MDIOS output data register 15
  $DC constant MDIOS_MDIOS_DOUTR16      \ MDIOS output data register 16
  $E0 constant MDIOS_MDIOS_DOUTR17      \ MDIOS output data register 17
  $E4 constant MDIOS_MDIOS_DOUTR18      \ MDIOS output data register 18
  $E8 constant MDIOS_MDIOS_DOUTR19      \ MDIOS output data register 19
  $EC constant MDIOS_MDIOS_DOUTR20      \ MDIOS output data register 20
  $F0 constant MDIOS_MDIOS_DOUTR21      \ MDIOS output data register 21
  $F4 constant MDIOS_MDIOS_DOUTR22      \ MDIOS output data register 22
  $F8 constant MDIOS_MDIOS_DOUTR23      \ MDIOS output data register 23
  $FC constant MDIOS_MDIOS_DOUTR24      \ MDIOS output data register 24
  $100 constant MDIOS_MDIOS_DOUTR25     \ MDIOS output data register 25
  $104 constant MDIOS_MDIOS_DOUTR26     \ MDIOS output data register 26
  $108 constant MDIOS_MDIOS_DOUTR27     \ MDIOS output data register 27
  $10C constant MDIOS_MDIOS_DOUTR28     \ MDIOS output data register 28
  $110 constant MDIOS_MDIOS_DOUTR29     \ MDIOS output data register 29
  $114 constant MDIOS_MDIOS_DOUTR30     \ MDIOS output data register 30
  $118 constant MDIOS_MDIOS_DOUTR31     \ MDIOS output data register 31

: MDIOS_DEF ; [then]
