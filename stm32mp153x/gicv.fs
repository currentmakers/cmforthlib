\
\ @file gicv.fs
\ @brief GICV
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GICV_DEF

  [ifdef] GICV_GICV_CTLR_DEF
    \
    \ @brief GICV virtual machine control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GICV_ENABLEGRP0                \ [0x00] ENABLEGRP0
    $01 constant GICV_ENABLEGRP1                \ [0x01] ENABLEGRP1
    $02 constant GICV_ACKCTL                    \ [0x02] ACKCTL
    $03 constant GICV_FIQEN                     \ [0x03] FIQEN
    $04 constant GICV_CBPR                      \ [0x04] CBPR
    $09 constant GICV_EOIMODE                   \ [0x09] EOIMODE
  [then]


  [ifdef] GICV_GICV_PMR_DEF
    \
    \ @brief GICV VM priority mask register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant GICV_PRIORITY                  \ [0x03 : 5] PRIORITY
  [then]


  [ifdef] GICV_GICV_BPR_DEF
    \
    \ @brief GICV VM binary point register
    \ Address offset: 0x08
    \ Reset value: 0x00000002
    \
    $00 constant GICV_BINARY_POINT              \ [0x00 : 3] BINARY_POINT
  [then]


  [ifdef] GICV_GICV_IAR_DEF
    \
    \ @brief GICV VM interrupt acknowledge register
    \ Address offset: 0x0C
    \ Reset value: 0x000003FF
    \
    $00 constant GICV_INTERRUPT_ID              \ [0x00 : 10] INTERRUPT_ID
    $0a constant GICV_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICV_GICV_EOIR_DEF
    \
    \ @brief GICV VM end of interrupt register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GICV_EOIINTID                  \ [0x00 : 10] EOIINTID
    $0a constant GICV_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICV_GICV_RPR_DEF
    \
    \ @brief GICV VM running priority register
    \ Address offset: 0x14
    \ Reset value: 0x000000FF
    \
    $03 constant GICV_PRIORITY                  \ [0x03 : 5] PRIORITY
  [then]


  [ifdef] GICV_GICV_HPPIR_DEF
    \
    \ @brief GICV VM highest priority pending interrupt register
    \ Address offset: 0x18
    \ Reset value: 0x000003FF
    \
    $00 constant GICV_PENDINTID                 \ [0x00 : 10] PENDINTID
    $0a constant GICV_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICV_GICV_ABPR_DEF
    \
    \ @brief GICV VM aliased binary point register
    \ Address offset: 0x1C
    \ Reset value: 0x00000003
    \
    $00 constant GICV_BINARY_POINT              \ [0x00 : 3] BINARY_POINT
  [then]


  [ifdef] GICV_GICV_AIAR_DEF
    \
    \ @brief GICV VM aliased interrupt register
    \ Address offset: 0x20
    \ Reset value: 0x000003FF
    \
    $00 constant GICV_INTERRUPT_ID              \ [0x00 : 10] INTERRUPT_ID
    $0a constant GICV_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICV_GICV_AEOIR_DEF
    \
    \ @brief GICV VM aliased end of interrupt register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GICV_EOIINTID                  \ [0x00 : 10] EOIINTID
    $0a constant GICV_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICV_GICV_AHPPIR_DEF
    \
    \ @brief GICV VM aliased highest priority pending interrupt register
    \ Address offset: 0x28
    \ Reset value: 0x000003FF
    \
    $00 constant GICV_PENDINTID                 \ [0x00 : 10] PENDINTID
    $0a constant GICV_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICV_GICV_APR0_DEF
    \
    \ @brief The GICV_APR0 is an alias of GICH_APR.
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant GICV_APR0                      \ [0x00 : 32] APR0
  [then]


  [ifdef] GICV_GICV_IIDR_DEF
    \
    \ @brief The GICV_IIDR is an alias of GICC_IIDR.
    \ Address offset: 0xFC
    \ Reset value: 0x0102143B
    \
    $00 constant GICV_IIDR                      \ [0x00 : 32] IIDR
  [then]


  [ifdef] GICV_GICV_DIR_DEF
    \
    \ @brief GICV VM deactivate interrupt register
    \ Address offset: 0x1000
    \ Reset value: 0x00000000
    \
    $00 constant GICV_INTERRUPT_ID              \ [0x00 : 10] INTERRUPT_ID
    $0a constant GICV_CPUID                     \ [0x0a] CPUID
  [then]

  \
  \ @brief GICV
  \
  $00 constant GICV_GICV_CTLR           \ GICV virtual machine control register
  $04 constant GICV_GICV_PMR            \ GICV VM priority mask register
  $08 constant GICV_GICV_BPR            \ GICV VM binary point register
  $0C constant GICV_GICV_IAR            \ GICV VM interrupt acknowledge register
  $10 constant GICV_GICV_EOIR           \ GICV VM end of interrupt register
  $14 constant GICV_GICV_RPR            \ GICV VM running priority register
  $18 constant GICV_GICV_HPPIR          \ GICV VM highest priority pending interrupt register
  $1C constant GICV_GICV_ABPR           \ GICV VM aliased binary point register
  $20 constant GICV_GICV_AIAR           \ GICV VM aliased interrupt register
  $24 constant GICV_GICV_AEOIR          \ GICV VM aliased end of interrupt register
  $28 constant GICV_GICV_AHPPIR         \ GICV VM aliased highest priority pending interrupt register
  $D0 constant GICV_GICV_APR0           \ The GICV_APR0 is an alias of GICH_APR.
  $FC constant GICV_GICV_IIDR           \ The GICV_IIDR is an alias of GICC_IIDR.
  $1000 constant GICV_GICV_DIR          \ GICV VM deactivate interrupt register

: GICV_DEF ; [then]
