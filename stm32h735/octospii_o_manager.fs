\
\ @file octospii_o_manager.fs
\ @brief OctoSPI IO Manager
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OctoSPI IO Manager Control Register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPII_O_MANAGER_CR_MUXEN                      \ Multiplexed mode Enable
$00ff0000 constant OCTOSPII_O_MANAGER_CR_REQ2ACK_TIME               \ REQ to ACK Time


\
\ @brief OctoSPI IO Manager Port 1 configuration register
\ Address offset: 0x04
\ Reset value: 0x03010111
\

$00000001 constant OCTOSPII_O_MANAGER_P1CR_CLKEN                    \ CLK/CLKn Enable for Port n
$00000002 constant OCTOSPII_O_MANAGER_P1CR_CLKSRC                   \ CLK/CLKn Source for Port n
$00000010 constant OCTOSPII_O_MANAGER_P1CR_DQSEN                    \ DQSEN
$00000020 constant OCTOSPII_O_MANAGER_P1CR_DQSSRC                   \ DQSSRC
$00000100 constant OCTOSPII_O_MANAGER_P1CR_NCSEN                    \ NCSEN
$00000200 constant OCTOSPII_O_MANAGER_P1CR_NCSSRC                   \ NCSSRC
$00010000 constant OCTOSPII_O_MANAGER_P1CR_IOLEN                    \ IOLEN
$00060000 constant OCTOSPII_O_MANAGER_P1CR_IOLSRC                   \ IOLSRC
$01000000 constant OCTOSPII_O_MANAGER_P1CR_IOHEN                    \ IOHEN
$06000000 constant OCTOSPII_O_MANAGER_P1CR_IOHSRC                   \ IOHSRC


\
\ @brief OctoSPI IO Manager Port 2 configuration register
\ Address offset: 0x08
\ Reset value: 0x07050333
\

$00000001 constant OCTOSPII_O_MANAGER_P2CR_CLKEN                    \ CLKEN
$00000002 constant OCTOSPII_O_MANAGER_P2CR_CLKSRC                   \ CLKSRC
$00000010 constant OCTOSPII_O_MANAGER_P2CR_DQSEN                    \ DQSEN
$00000020 constant OCTOSPII_O_MANAGER_P2CR_DQSSRC                   \ DQSSRC
$00000100 constant OCTOSPII_O_MANAGER_P2CR_NCSEN                    \ NCSEN
$00000200 constant OCTOSPII_O_MANAGER_P2CR_NCSSRC                   \ NCSSRC
$00010000 constant OCTOSPII_O_MANAGER_P2CR_IOLEN                    \ IOLEN
$00060000 constant OCTOSPII_O_MANAGER_P2CR_IOLSRC                   \ IOLSRC
$01000000 constant OCTOSPII_O_MANAGER_P2CR_IOHEN                    \ IOHEN
$06000000 constant OCTOSPII_O_MANAGER_P2CR_IOHSRC                   \ IOHSRC


\
\ @brief OctoSPI IO Manager
\
$5200b400 constant OCTOSPII_O_MANAGER_CR  \ offset: 0x00 : OctoSPI IO Manager Control Register
$5200b404 constant OCTOSPII_O_MANAGER_P1CR  \ offset: 0x04 : OctoSPI IO Manager Port 1 configuration register
$5200b408 constant OCTOSPII_O_MANAGER_P2CR  \ offset: 0x08 : OctoSPI IO Manager Port 2 configuration register

