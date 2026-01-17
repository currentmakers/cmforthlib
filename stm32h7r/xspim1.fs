\
\ @file xspim1.fs
\ @brief XSPIM1 register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] XSPIM1_DEF

  [ifdef] XSPIM1_XSPIM_CR_DEF
    \
    \ @brief XSPIM control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant XSPIM1_MUXEN                   \ [0x00] Multiplexed mode enable This bit enables the multiplexing of the two XSPIs.
    $01 constant XSPIM1_MODE                    \ [0x01] XSPI multiplexing mode
    $04 constant XSPIM1_CSSEL_OVR_EN            \ [0x04] Chip select selector override enable
    $05 constant XSPIM1_CSSEL_OVR_O1            \ [0x05] Chip select selector override setting for XSPI1
    $06 constant XSPIM1_CSSEL_OVR_O2            \ [0x06] Chip select selector override setting for XSPI2
    $10 constant XSPIM1_REQ2ACK_TIME            \ [0x10 : 8] REQ to ACK time In Multiplexed mode (MUXEN = 1), this field defines the time between two transactions.
  [then]

  \
  \ @brief XSPIM1 register block
  \
  $00 constant XSPIM1_XSPIM_CR          \ XSPIM control register

: XSPIM1_DEF ; [then]
