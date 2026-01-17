\
\ @file octospii_o_manager.fs
\ @brief OctoSPI IO Manager
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OCTOSPII_O_MANAGER_DEF

  [ifdef] OCTOSPII_O_MANAGER_CR_DEF
    \
    \ @brief OctoSPI IO Manager Control Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPII_O_MANAGER_MUXEN       \ [0x00] Multiplexed mode Enable
    $10 constant OCTOSPII_O_MANAGER_REQ2ACK_TIME     \ [0x10 : 8] REQ to ACK Time
  [then]


  [ifdef] OCTOSPII_O_MANAGER_P1CR_DEF
    \
    \ @brief OctoSPI IO Manager Port 1 configuration register
    \ Address offset: 0x04
    \ Reset value: 0x03010111
    \
    $00 constant OCTOSPII_O_MANAGER_CLKEN       \ [0x00] CLK/CLKn Enable for Port n
    $01 constant OCTOSPII_O_MANAGER_CLKSRC      \ [0x01] CLK/CLKn Source for Port n
    $04 constant OCTOSPII_O_MANAGER_DQSEN       \ [0x04] DQSEN
    $05 constant OCTOSPII_O_MANAGER_DQSSRC      \ [0x05] DQSSRC
    $08 constant OCTOSPII_O_MANAGER_NCSEN       \ [0x08] NCSEN
    $09 constant OCTOSPII_O_MANAGER_NCSSRC      \ [0x09] NCSSRC
    $10 constant OCTOSPII_O_MANAGER_IOLEN       \ [0x10] IOLEN
    $11 constant OCTOSPII_O_MANAGER_IOLSRC      \ [0x11 : 2] IOLSRC
    $18 constant OCTOSPII_O_MANAGER_IOHEN       \ [0x18] IOHEN
    $19 constant OCTOSPII_O_MANAGER_IOHSRC      \ [0x19 : 2] IOHSRC
  [then]


  [ifdef] OCTOSPII_O_MANAGER_P2CR_DEF
    \
    \ @brief OctoSPI IO Manager Port 2 configuration register
    \ Address offset: 0x08
    \ Reset value: 0x07050333
    \
    $00 constant OCTOSPII_O_MANAGER_CLKEN       \ [0x00] CLKEN
    $01 constant OCTOSPII_O_MANAGER_CLKSRC      \ [0x01] CLKSRC
    $04 constant OCTOSPII_O_MANAGER_DQSEN       \ [0x04] DQSEN
    $05 constant OCTOSPII_O_MANAGER_DQSSRC      \ [0x05] DQSSRC
    $08 constant OCTOSPII_O_MANAGER_NCSEN       \ [0x08] NCSEN
    $09 constant OCTOSPII_O_MANAGER_NCSSRC      \ [0x09] NCSSRC
    $10 constant OCTOSPII_O_MANAGER_IOLEN       \ [0x10] IOLEN
    $11 constant OCTOSPII_O_MANAGER_IOLSRC      \ [0x11 : 2] IOLSRC
    $18 constant OCTOSPII_O_MANAGER_IOHEN       \ [0x18] IOHEN
    $19 constant OCTOSPII_O_MANAGER_IOHSRC      \ [0x19 : 2] IOHSRC
  [then]

  \
  \ @brief OctoSPI IO Manager
  \
  $00 constant OCTOSPII_O_MANAGER_CR    \ OctoSPI IO Manager Control Register
  $04 constant OCTOSPII_O_MANAGER_P1CR  \ OctoSPI IO Manager Port 1 configuration register
  $08 constant OCTOSPII_O_MANAGER_P2CR  \ OctoSPI IO Manager Port 2 configuration register

: OCTOSPII_O_MANAGER_DEF ; [then]
