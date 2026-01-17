\
\ @file octospim.fs
\ @brief OctoSPI IO Manager
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OCTOSPIM_DEF

  [ifdef] OCTOSPIM_P1CR_DEF
    \
    \ @brief OctoSPI IO Manager Port 1 Configuration Register
    \ Address offset: 0x04
    \ Reset value: 0x03010111
    \
    $00 constant OCTOSPIM_CLKEN                 \ [0x00] CLK/CLK Enable for Port
    $01 constant OCTOSPIM_CLKSRC                \ [0x01] CLK/CLK Source for Port
    $04 constant OCTOSPIM_DQSEN                 \ [0x04] DQS Enable for Port
    $05 constant OCTOSPIM_DQSSRC                \ [0x05] DQS Source for Port
    $08 constant OCTOSPIM_NCSEN                 \ [0x08] CS Enable for Port
    $09 constant OCTOSPIM_NCSSRC                \ [0x09] CS Source for Port
    $10 constant OCTOSPIM_IOLEN                 \ [0x10] Enable for Port
    $11 constant OCTOSPIM_IOLSRC                \ [0x11 : 2] Source for Port
    $18 constant OCTOSPIM_IOHEN                 \ [0x18] Enable for Port n
    $19 constant OCTOSPIM_IOHSRC                \ [0x19 : 2] Source for Port
  [then]


  [ifdef] OCTOSPIM_P2CR_DEF
    \
    \ @brief OctoSPI IO Manager Port 2 Configuration Register
    \ Address offset: 0x08
    \ Reset value: 0x07050333
    \
    $00 constant OCTOSPIM_CLKEN                 \ [0x00] CLK/CLK Enable for Port
    $01 constant OCTOSPIM_CLKSRC                \ [0x01] CLK/CLK Source for Port
    $04 constant OCTOSPIM_DQSEN                 \ [0x04] DQS Enable for Port
    $05 constant OCTOSPIM_DQSSRC                \ [0x05] DQS Source for Port
    $08 constant OCTOSPIM_NCSEN                 \ [0x08] CS Enable for Port
    $09 constant OCTOSPIM_NCSSRC                \ [0x09] CS Source for Port
    $10 constant OCTOSPIM_IOLEN                 \ [0x10] Enable for Port
    $11 constant OCTOSPIM_IOLSRC                \ [0x11 : 2] Source for Port
    $18 constant OCTOSPIM_IOHEN                 \ [0x18] Enable for Port n
    $19 constant OCTOSPIM_IOHSRC                \ [0x19 : 2] Source for Port
  [then]

  \
  \ @brief OctoSPI IO Manager
  \
  $04 constant OCTOSPIM_P1CR            \ OctoSPI IO Manager Port 1 Configuration Register
  $08 constant OCTOSPIM_P2CR            \ OctoSPI IO Manager Port 2 Configuration Register

: OCTOSPIM_DEF ; [then]
