\
\ @file tzic.fs
\ @brief TrustZone Interrupt Control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TZIC interrupt enable register 1
\ Address offset: 0x00
\ Reset value: 0xFFFFFFFF
\

$00000001 constant TZIC_IER1_TZICIE                                 \ TZICIE
$00000002 constant TZIC_IER1_TZSCIE                                 \ TZSCIE
$00000004 constant TZIC_IER1_AESIE                                  \ AESIE
$00000008 constant TZIC_IER1_RNGIE                                  \ RNGIE
$00000010 constant TZIC_IER1_SUBGHZSPIIE                            \ SUBGHZSPIIE
$00000020 constant TZIC_IER1_PWRIE                                  \ PWRIE
$00000040 constant TZIC_IER1_FLASHIFIE                              \ FLASHIFIE
$00000080 constant TZIC_IER1_DMA1IE                                 \ DMA1IE
$00000100 constant TZIC_IER1_DMA2IE                                 \ DMA2IE
$00000200 constant TZIC_IER1_DMAMUX1IE                              \ DMAMUX1IE
$00000400 constant TZIC_IER1_FLASHIE                                \ FLASHIE
$00000800 constant TZIC_IER1_SRAM1IE                                \ SRAM1IE
$00001000 constant TZIC_IER1_SRAM2IE                                \ SRAM2IE
$00002000 constant TZIC_IER1_PKAIE                                  \ PKAIE


\
\ @brief TZIC status register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TZIC_MISR1_TZICMF                                \ TZICMF
$00000002 constant TZIC_MISR1_TZSCMF                                \ TZSCMF
$00000004 constant TZIC_MISR1_AESMF                                 \ AESMF
$00000008 constant TZIC_MISR1_RNGMF                                 \ RNGMF
$00000010 constant TZIC_MISR1_SUBGHZSPIMF                           \ SUBGHZSPIMF
$00000020 constant TZIC_MISR1_PWRMF                                 \ PWRMF
$00000040 constant TZIC_MISR1_FLASHIFMF                             \ FLASHIFMF
$00000080 constant TZIC_MISR1_DMA1MF                                \ DMA1MF
$00000100 constant TZIC_MISR1_DMA2MF                                \ DMA2MF
$00000200 constant TZIC_MISR1_DMAMUX1MF                             \ DMAMUX1MF
$00000400 constant TZIC_MISR1_FLASHMF                               \ FLASHMF
$00000800 constant TZIC_MISR1_SRAM1MF                               \ SRAM1MF
$00001000 constant TZIC_MISR1_SRAM2MF                               \ SRAM2MF
$00002000 constant TZIC_MISR1_PKAMF                                 \ PKAMF


\
\ @brief TZIC interrupt status clear register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TZIC_ICR1_TZICCF                                 \ TZICCF
$00000002 constant TZIC_ICR1_TZSCCF                                 \ TZSCCF
$00000004 constant TZIC_ICR1_AESCF                                  \ AESCF
$00000008 constant TZIC_ICR1_RNGCF                                  \ RNGCF
$00000010 constant TZIC_ICR1_SUBGHZSPICF                            \ SUBGHZSPICF
$00000020 constant TZIC_ICR1_PWRCF                                  \ PWRCF
$00000040 constant TZIC_ICR1_FLASHIFCF                              \ FLASHIFCF
$00000080 constant TZIC_ICR1_DMA1CF                                 \ DMA1CF
$00000100 constant TZIC_ICR1_DMA2CF                                 \ DMA2CF
$00000200 constant TZIC_ICR1_DMAMUX1CF                              \ DMAMUX1CF
$00000400 constant TZIC_ICR1_FLASHCF                                \ FLASHCF
$00000800 constant TZIC_ICR1_SRAM1CF                                \ SRAM1CF
$00001000 constant TZIC_ICR1_SRAM2CF                                \ SRAM2CF
$00002000 constant TZIC_ICR1_PKACF                                  \ PKACF


\
\ @brief TrustZone Interrupt Control
\
$58004800 constant TZIC_IER1      \ offset: 0x00 : TZIC interrupt enable register 1
$58004810 constant TZIC_MISR1     \ offset: 0x10 : TZIC status register 1
$58004820 constant TZIC_ICR1      \ offset: 0x20 : TZIC interrupt status clear register 1

