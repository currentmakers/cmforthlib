\
\ @file sec_octospim.fs
\ @brief OCTOSPI I/O manager
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_OCTOSPIM_CR_MUXEN                            \ Multiplexed mode enable
$00ff0000 constant SEC_OCTOSPIM_CR_REQ2ACK_TIME                     \ REQ to ACK time


\
\ @brief OCTOSPI I/O manager Port 1 configuration register
\ Address offset: 0x04
\ Reset value: 0x03010111
\

$00000001 constant SEC_OCTOSPIM_P1CR_CLKEN                          \ CLKEN
$00000002 constant SEC_OCTOSPIM_P1CR_CLKSRC                         \ CLKSRC
$00000010 constant SEC_OCTOSPIM_P1CR_DQSEN                          \ DQSEN
$00000020 constant SEC_OCTOSPIM_P1CR_DQSSRC                         \ DQSSRC
$00000100 constant SEC_OCTOSPIM_P1CR_NCSEN                          \ NCSEN
$00000200 constant SEC_OCTOSPIM_P1CR_NCSSRC                         \ NCSSRC
$00010000 constant SEC_OCTOSPIM_P1CR_IOLEN                          \ IOLEN
$00060000 constant SEC_OCTOSPIM_P1CR_IOLSRC                         \ IOLSRC
$01000000 constant SEC_OCTOSPIM_P1CR_IOHEN                          \ IOHEN
$06000000 constant SEC_OCTOSPIM_P1CR_IOHSRC                         \ IOHSR


\
\ @brief OCTOSPI I/O manager Port 2 configuration register
\ Address offset: 0x08
\ Reset value: 0x07050333
\

$00000001 constant SEC_OCTOSPIM_P2CR_CLKEN                          \ CLKEN
$00000002 constant SEC_OCTOSPIM_P2CR_CLKSRC                         \ CLKSRC
$00000010 constant SEC_OCTOSPIM_P2CR_DQSEN                          \ DQSEN
$00000020 constant SEC_OCTOSPIM_P2CR_DQSSRC                         \ DQSSRC
$00000100 constant SEC_OCTOSPIM_P2CR_NCSEN                          \ NCSEN
$00000200 constant SEC_OCTOSPIM_P2CR_NCSSRC                         \ NCSSRC
$00010000 constant SEC_OCTOSPIM_P2CR_IOLEN                          \ IOLEN
$00060000 constant SEC_OCTOSPIM_P2CR_IOLSRC                         \ IOLSRC
$01000000 constant SEC_OCTOSPIM_P2CR_IOHEN                          \ IOHEN
$06000000 constant SEC_OCTOSPIM_P2CR_IOHSRC                         \ IOHSR


\
\ @brief OCTOSPI I/O manager
\
$520c4000 constant SEC_OCTOSPIM_CR  \ offset: 0x00 : control register
$520c4004 constant SEC_OCTOSPIM_P1CR  \ offset: 0x04 : OCTOSPI I/O manager Port 1 configuration register
$520c4008 constant SEC_OCTOSPIM_P2CR  \ offset: 0x08 : OCTOSPI I/O manager Port 2 configuration register

