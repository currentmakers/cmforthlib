\
\ @file octospim.fs
\ @brief OctoSPI IO Manager
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OctoSPI IO Manager Port 1 Configuration Register
\ Address offset: 0x04
\ Reset value: 0x03010111
\

$00000001 constant OCTOSPIM_P1CR_CLKEN                              \ CLK/CLK Enable for Port
$00000002 constant OCTOSPIM_P1CR_CLKSRC                             \ CLK/CLK Source for Port
$00000010 constant OCTOSPIM_P1CR_DQSEN                              \ DQS Enable for Port
$00000020 constant OCTOSPIM_P1CR_DQSSRC                             \ DQS Source for Port
$00000100 constant OCTOSPIM_P1CR_NCSEN                              \ CS Enable for Port
$00000200 constant OCTOSPIM_P1CR_NCSSRC                             \ CS Source for Port
$00010000 constant OCTOSPIM_P1CR_IOLEN                              \ Enable for Port
$00060000 constant OCTOSPIM_P1CR_IOLSRC                             \ Source for Port
$01000000 constant OCTOSPIM_P1CR_IOHEN                              \ Enable for Port n
$06000000 constant OCTOSPIM_P1CR_IOHSRC                             \ Source for Port


\
\ @brief OctoSPI IO Manager Port 2 Configuration Register
\ Address offset: 0x08
\ Reset value: 0x07050333
\

$00000001 constant OCTOSPIM_P2CR_CLKEN                              \ CLK/CLK Enable for Port
$00000002 constant OCTOSPIM_P2CR_CLKSRC                             \ CLK/CLK Source for Port
$00000010 constant OCTOSPIM_P2CR_DQSEN                              \ DQS Enable for Port
$00000020 constant OCTOSPIM_P2CR_DQSSRC                             \ DQS Source for Port
$00000100 constant OCTOSPIM_P2CR_NCSEN                              \ CS Enable for Port
$00000200 constant OCTOSPIM_P2CR_NCSSRC                             \ CS Source for Port
$00010000 constant OCTOSPIM_P2CR_IOLEN                              \ Enable for Port
$00060000 constant OCTOSPIM_P2CR_IOLSRC                             \ Source for Port
$01000000 constant OCTOSPIM_P2CR_IOHEN                              \ Enable for Port n
$06000000 constant OCTOSPIM_P2CR_IOHSRC                             \ Source for Port


\
\ @brief OctoSPI IO Manager
\
$50061c04 constant OCTOSPIM_P1CR  \ offset: 0x04 : OctoSPI IO Manager Port 1 Configuration Register
$50061c08 constant OCTOSPIM_P2CR  \ offset: 0x08 : OctoSPI IO Manager Port 2 Configuration Register

