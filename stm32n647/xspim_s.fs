\
\ @file xspim_s.fs
\ @brief XSPI I/O manager
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief XSPIM control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant XSPIM_S_XSPIM_CR_MUXEN                           \ Multiplexed mode enable
$00000002 constant XSPIM_S_XSPIM_CR_MODE                            \ XSPI multiplexing mode
$00000010 constant XSPIM_S_XSPIM_CR_CSSEL_OVR_EN                    \ Chip select selector override enable
$00000020 constant XSPIM_S_XSPIM_CR_CSSEL_OVR_O1                    \ Chip select selector override setting for XSPI1
$00000040 constant XSPIM_S_XSPIM_CR_CSSEL_OVR_O2                    \ Chip select selector override setting for XSPI2
$00ff0000 constant XSPIM_S_XSPIM_CR_REQ2ACK_TIME                    \ REQ to ACK time


\
\ @brief XSPI I/O manager
\
$5802b400 constant XSPIM_S_XSPIM_CR  \ offset: 0x00 : XSPIM control register

