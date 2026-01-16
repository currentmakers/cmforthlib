\
\ @file switchable.fs
\ @brief RFIP_VERSION register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RFIP_VERSION register
\ Address offset: 0x00
\ Reset value: 0x00001100
\

$000000f0 constant SWITCHABLE_RFIP_VERSION_REVISION                 \ Revision of the RFIP to be used for metal fixes)
$00000f00 constant SWITCHABLE_RFIP_VERSION_VERSION                  \ Version of the RFIP (to be used for cut upgrades)
$0000f000 constant SWITCHABLE_RFIP_VERSION_PRODUCT                  \ Used for major upgrades (new protocols support / new features)


\
\ @brief IRQ_ENABLE register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SWITCHABLE_IRQ_ENABLE_BIT_SYNC_DETECTED_E        \ Preamble has been detected, the content of the PAYLOAD_X registers is not yet valid.
$00000002 constant SWITCHABLE_IRQ_ENABLE_FRAME_SYNC_COMPLETE_E      \ Frame Sync has been detected, the content of the PAYLOAD_X registers is not yet valid.
$00000004 constant SWITCHABLE_IRQ_ENABLE_FRAME_COMPLETE_E           \ Frame ( payload + CRC) received, the content of the PAYLOAD_X registers is valid.
$00000008 constant SWITCHABLE_IRQ_ENABLE_FRAME_VALID_E              \ Frame ( payload + CRC) received wthout error (the CRC has been checked and is matching with the received CRC).


\
\ @brief STATUS register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SWITCHABLE_STATUS_BIT_SYNC_DETECTED_F            \ Preamble has been detected, the content of the PAYLOAD_X registers is not yet valid.
$00000002 constant SWITCHABLE_STATUS_FRAME_SYNC_COMPLETE_F          \ Frame Sync has been detected, the content of the PAYLOAD_X registers is not yet valid.
$00000004 constant SWITCHABLE_STATUS_FRAME_COMPLETE_F               \ Frame ( payload + CRC) received, the content of the PAYLOAD_X registers is valid.
$00000008 constant SWITCHABLE_STATUS_FRAME_VALID_F                  \ Frame ( payload + CRC) received wthout error (the CRC has been checked and is matching with the received CRC).
$c0000000 constant SWITCHABLE_STATUS_ERROR_F                        \ - 11 : CRC error


\
\ @brief RFIP_VERSION register
\
$49001040 constant SWITCHABLE_RFIP_VERSION  \ offset: 0x00 : RFIP_VERSION register
$49001044 constant SWITCHABLE_IRQ_ENABLE  \ offset: 0x04 : IRQ_ENABLE register
$49001048 constant SWITCHABLE_STATUS  \ offset: 0x08 : STATUS register

