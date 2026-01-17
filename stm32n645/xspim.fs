\
\ @file xspim.fs
\ @brief XSPI I/O manager
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] XSPIM_DEF

  [ifdef] XSPIM_XSPIM_CR_DEF
    \
    \ @brief XSPIM control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant XSPIM_MUXEN                    \ [0x00] Multiplexed mode enable
    $01 constant XSPIM_MODE                     \ [0x01] XSPI multiplexing mode
    $04 constant XSPIM_CSSEL_OVR_EN             \ [0x04] Chip select selector override enable
    $05 constant XSPIM_CSSEL_OVR_O1             \ [0x05] Chip select selector override setting for XSPI1
    $06 constant XSPIM_CSSEL_OVR_O2             \ [0x06] Chip select selector override setting for XSPI2
    $10 constant XSPIM_REQ2ACK_TIME             \ [0x10 : 8] REQ to ACK time
  [then]

  \
  \ @brief XSPI I/O manager
  \
  $00 constant XSPIM_XSPIM_CR           \ XSPIM control register

: XSPIM_DEF ; [then]
