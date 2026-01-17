\
\ @file ptaconv.fs
\ @brief PTA converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PTACONV_DEF

  [ifdef] PTACONV_PTACONV_ACTCR_DEF
    \
    \ @brief PTACONV active control register
    \ Address offset: 0x00
    \ Reset value: 0x00050014
    \
    $00 constant PTACONV_TACTIVE                \ [0x00 : 8] PTA_ACTIVE setup time in us
    $0f constant PTACONV_ACTPOL                 \ [0x0f] PTA_ACTIVE polarity
    $10 constant PTACONV_TABORT                 \ [0x10 : 4] PTA_ACTIVE delay to cease an ongoing transmission in us
    $14 constant PTACONV_ABORTDIS               \ [0x14] Disable PTA_ACTIVE deny to abort an ongoing transmission
  [then]


  [ifdef] PTACONV_PTACONV_PRICR_DEF
    \
    \ @brief PTACONV priority control register
    \ Address offset: 0x04
    \ Reset value: 0x0000000A
    \
    $00 constant PTACONV_TPRIORITY              \ [0x00 : 5] Priority valid time in us.
    $0f constant PTACONV_PRIPOL                 \ [0x0f] Priority polarity.
  [then]


  [ifdef] PTACONV_PTACONV_CR_DEF
    \
    \ @brief PTACONV control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $0f constant PTACONV_TXRXPOL                \ [0x0f] PTA_STATUS transmit and receive polarity.
    $1f constant PTACONV_GRANTPOL               \ [0x1f] PTA_GRANT polarity.
  [then]

  \
  \ @brief PTA converter
  \
  $00 constant PTACONV_PTACONV_ACTCR    \ PTACONV active control register
  $04 constant PTACONV_PTACONV_PRICR    \ PTACONV priority control register
  $08 constant PTACONV_PTACONV_CR       \ PTACONV control register

: PTACONV_DEF ; [then]
