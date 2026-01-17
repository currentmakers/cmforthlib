\
\ @file octospim.fs
\ @brief OCTOSPI I/O manager
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OCTOSPIM_DEF

  [ifdef] OCTOSPIM_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPIM_MUXEN                 \ [0x00] Multiplexed mode enable
    $10 constant OCTOSPIM_REQ2ACK_TIME          \ [0x10 : 8] REQ to ACK time
  [then]


  [ifdef] OCTOSPIM_P1CR_DEF
    \
    \ @brief OCTOSPI I/O manager Port 1 configuration register
    \ Address offset: 0x04
    \ Reset value: 0x03010111
    \
    $00 constant OCTOSPIM_CLKEN                 \ [0x00] CLKEN
    $01 constant OCTOSPIM_CLKSRC                \ [0x01] CLKSRC
    $04 constant OCTOSPIM_DQSEN                 \ [0x04] DQSEN
    $05 constant OCTOSPIM_DQSSRC                \ [0x05] DQSSRC
    $08 constant OCTOSPIM_NCSEN                 \ [0x08] NCSEN
    $09 constant OCTOSPIM_NCSSRC                \ [0x09] NCSSRC
    $10 constant OCTOSPIM_IOLEN                 \ [0x10] IOLEN
    $11 constant OCTOSPIM_IOLSRC                \ [0x11 : 2] IOLSRC
    $18 constant OCTOSPIM_IOHEN                 \ [0x18] IOHEN
    $19 constant OCTOSPIM_IOHSRC                \ [0x19 : 2] IOHSR
  [then]


  [ifdef] OCTOSPIM_P2CR_DEF
    \
    \ @brief OCTOSPI I/O manager Port 2 configuration register
    \ Address offset: 0x08
    \ Reset value: 0x07050333
    \
    $00 constant OCTOSPIM_CLKEN                 \ [0x00] CLKEN
    $01 constant OCTOSPIM_CLKSRC                \ [0x01] CLKSRC
    $04 constant OCTOSPIM_DQSEN                 \ [0x04] DQSEN
    $05 constant OCTOSPIM_DQSSRC                \ [0x05] DQSSRC
    $08 constant OCTOSPIM_NCSEN                 \ [0x08] NCSEN
    $09 constant OCTOSPIM_NCSSRC                \ [0x09] NCSSRC
    $10 constant OCTOSPIM_IOLEN                 \ [0x10] IOLEN
    $11 constant OCTOSPIM_IOLSRC                \ [0x11 : 2] IOLSRC
    $18 constant OCTOSPIM_IOHEN                 \ [0x18] IOHEN
    $19 constant OCTOSPIM_IOHSRC                \ [0x19 : 2] IOHSR
  [then]

  \
  \ @brief OCTOSPI I/O manager
  \
  $00 constant OCTOSPIM_CR              \ control register
  $04 constant OCTOSPIM_P1CR            \ OCTOSPI I/O manager Port 1 configuration register
  $08 constant OCTOSPIM_P2CR            \ OCTOSPI I/O manager Port 2 configuration register

: OCTOSPIM_DEF ; [then]
