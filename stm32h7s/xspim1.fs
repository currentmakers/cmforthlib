\
\ @file xspim1.fs
\ @brief XSPIM1 register block
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

$00000001 constant XSPIM1_XSPIM_CR_MUXEN                            \ Multiplexed mode enable This bit enables the multiplexing of the two XSPIs.
$00000002 constant XSPIM1_XSPIM_CR_MODE                             \ XSPI multiplexing mode
$00000010 constant XSPIM1_XSPIM_CR_CSSEL_OVR_EN                     \ Chip select selector override enable
$00000020 constant XSPIM1_XSPIM_CR_CSSEL_OVR_O1                     \ Chip select selector override setting for XSPI1
$00000040 constant XSPIM1_XSPIM_CR_CSSEL_OVR_O2                     \ Chip select selector override setting for XSPI2
$00ff0000 constant XSPIM1_XSPIM_CR_REQ2ACK_TIME                     \ REQ to ACK time In Multiplexed mode (MUXEN = 1), this field defines the time between two transactions.


\
\ @brief XSPIM1 register block
\
$5200b400 constant XSPIM1_XSPIM_CR  \ offset: 0x00 : XSPIM control register

