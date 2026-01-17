\
\ @file switchable.fs
\ @brief RFIP_VERSION register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SWITCHABLE_DEF

  [ifdef] SWITCHABLE_RFIP_VERSION_DEF
    \
    \ @brief RFIP_VERSION register
    \ Address offset: 0x00
    \ Reset value: 0x00001100
    \
    $04 constant SWITCHABLE_REVISION            \ [0x04 : 4] Revision of the RFIP to be used for metal fixes)
    $08 constant SWITCHABLE_VERSION             \ [0x08 : 4] Version of the RFIP (to be used for cut upgrades)
    $0c constant SWITCHABLE_PRODUCT             \ [0x0c : 4] Used for major upgrades (new protocols support / new features)
  [then]


  [ifdef] SWITCHABLE_IRQ_ENABLE_DEF
    \
    \ @brief IRQ_ENABLE register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SWITCHABLE_BIT_SYNC_DETECTED_E     \ [0x00] Preamble has been detected, the content of the PAYLOAD_X registers is not yet valid.
    $01 constant SWITCHABLE_FRAME_SYNC_COMPLETE_E     \ [0x01] Frame Sync has been detected, the content of the PAYLOAD_X registers is not yet valid.
    $02 constant SWITCHABLE_FRAME_COMPLETE_E    \ [0x02] Frame ( payload + CRC) received, the content of the PAYLOAD_X registers is valid.
    $03 constant SWITCHABLE_FRAME_VALID_E       \ [0x03] Frame ( payload + CRC) received wthout error (the CRC has been checked and is matching with the received CRC).
  [then]


  [ifdef] SWITCHABLE_STATUS_DEF
    \
    \ @brief STATUS register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SWITCHABLE_BIT_SYNC_DETECTED_F     \ [0x00] Preamble has been detected, the content of the PAYLOAD_X registers is not yet valid.
    $01 constant SWITCHABLE_FRAME_SYNC_COMPLETE_F     \ [0x01] Frame Sync has been detected, the content of the PAYLOAD_X registers is not yet valid.
    $02 constant SWITCHABLE_FRAME_COMPLETE_F    \ [0x02] Frame ( payload + CRC) received, the content of the PAYLOAD_X registers is valid.
    $03 constant SWITCHABLE_FRAME_VALID_F       \ [0x03] Frame ( payload + CRC) received wthout error (the CRC has been checked and is matching with the received CRC).
    $1e constant SWITCHABLE_ERROR_F             \ [0x1e : 2] - 11 : CRC error
  [then]

  \
  \ @brief RFIP_VERSION register
  \
  $00 constant SWITCHABLE_RFIP_VERSION  \ RFIP_VERSION register
  $04 constant SWITCHABLE_IRQ_ENABLE    \ IRQ_ENABLE register
  $08 constant SWITCHABLE_STATUS        \ STATUS register

: SWITCHABLE_DEF ; [then]
