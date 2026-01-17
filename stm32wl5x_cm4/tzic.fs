\
\ @file tzic.fs
\ @brief TrustZone Interrupt Control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TZIC_DEF

  [ifdef] TZIC_IER1_DEF
    \
    \ @brief TZIC interrupt enable register 1
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TZIC_TZICIE                    \ [0x00] TZICIE
    $01 constant TZIC_TZSCIE                    \ [0x01] TZSCIE
    $02 constant TZIC_AESIE                     \ [0x02] AESIE
    $03 constant TZIC_RNGIE                     \ [0x03] RNGIE
    $04 constant TZIC_SUBGHZSPIIE               \ [0x04] SUBGHZSPIIE
    $05 constant TZIC_PWRIE                     \ [0x05] PWRIE
    $06 constant TZIC_FLASHIFIE                 \ [0x06] FLASHIFIE
    $07 constant TZIC_DMA1IE                    \ [0x07] DMA1IE
    $08 constant TZIC_DMA2IE                    \ [0x08] DMA2IE
    $09 constant TZIC_DMAMUX1IE                 \ [0x09] DMAMUX1IE
    $0a constant TZIC_FLASHIE                   \ [0x0a] FLASHIE
    $0b constant TZIC_SRAM1IE                   \ [0x0b] SRAM1IE
    $0c constant TZIC_SRAM2IE                   \ [0x0c] SRAM2IE
    $0d constant TZIC_PKAIE                     \ [0x0d] PKAIE
  [then]


  [ifdef] TZIC_MISR1_DEF
    \
    \ @brief TZIC status register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TZIC_TZICMF                    \ [0x00] TZICMF
    $01 constant TZIC_TZSCMF                    \ [0x01] TZSCMF
    $02 constant TZIC_AESMF                     \ [0x02] AESMF
    $03 constant TZIC_RNGMF                     \ [0x03] RNGMF
    $04 constant TZIC_SUBGHZSPIMF               \ [0x04] SUBGHZSPIMF
    $05 constant TZIC_PWRMF                     \ [0x05] PWRMF
    $06 constant TZIC_FLASHIFMF                 \ [0x06] FLASHIFMF
    $07 constant TZIC_DMA1MF                    \ [0x07] DMA1MF
    $08 constant TZIC_DMA2MF                    \ [0x08] DMA2MF
    $09 constant TZIC_DMAMUX1MF                 \ [0x09] DMAMUX1MF
    $0a constant TZIC_FLASHMF                   \ [0x0a] FLASHMF
    $0b constant TZIC_SRAM1MF                   \ [0x0b] SRAM1MF
    $0c constant TZIC_SRAM2MF                   \ [0x0c] SRAM2MF
    $0d constant TZIC_PKAMF                     \ [0x0d] PKAMF
  [then]


  [ifdef] TZIC_ICR1_DEF
    \
    \ @brief TZIC interrupt status clear register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TZIC_TZICCF                    \ [0x00] TZICCF
    $01 constant TZIC_TZSCCF                    \ [0x01] TZSCCF
    $02 constant TZIC_AESCF                     \ [0x02] AESCF
    $03 constant TZIC_RNGCF                     \ [0x03] RNGCF
    $04 constant TZIC_SUBGHZSPICF               \ [0x04] SUBGHZSPICF
    $05 constant TZIC_PWRCF                     \ [0x05] PWRCF
    $06 constant TZIC_FLASHIFCF                 \ [0x06] FLASHIFCF
    $07 constant TZIC_DMA1CF                    \ [0x07] DMA1CF
    $08 constant TZIC_DMA2CF                    \ [0x08] DMA2CF
    $09 constant TZIC_DMAMUX1CF                 \ [0x09] DMAMUX1CF
    $0a constant TZIC_FLASHCF                   \ [0x0a] FLASHCF
    $0b constant TZIC_SRAM1CF                   \ [0x0b] SRAM1CF
    $0c constant TZIC_SRAM2CF                   \ [0x0c] SRAM2CF
    $0d constant TZIC_PKACF                     \ [0x0d] PKACF
  [then]

  \
  \ @brief TrustZone Interrupt Control
  \
  $00 constant TZIC_IER1                \ TZIC interrupt enable register 1
  $10 constant TZIC_MISR1               \ TZIC status register 1
  $20 constant TZIC_ICR1                \ TZIC interrupt status clear register 1

: TZIC_DEF ; [then]
