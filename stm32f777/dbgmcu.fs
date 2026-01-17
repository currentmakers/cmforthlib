\
\ @file dbgmcu.fs
\ @brief MCU debug component
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_IDCODE_DEF
    \
    \ @brief DBGMCU_IDCODE
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] Device identifier
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision identifie
  [then]

  \
  \ @brief MCU debug component
  \
  $00 constant DBGMCU_IDCODE            \ DBGMCU_IDCODE

: DBGMCU_DEF ; [then]
