\
\ @file gicc.fs
\ @brief GICC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GICC_DEF

  [ifdef] GICC_GICC_CTLR_DEF
    \
    \ @brief GICC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GICC_ENABLEGRP0                \ [0x00] ENABLEGRP0
    $01 constant GICC_ENABLEGRP1                \ [0x01] ENABLEGRP1
    $02 constant GICC_ACKCTL                    \ [0x02] ACKCTL
    $03 constant GICC_FIQEN                     \ [0x03] FIQEN
    $04 constant GICC_CBPR                      \ [0x04] CBPR
    $05 constant GICC_FIQBYPDISGRP0             \ [0x05] FIQBYPDISGRP0
    $06 constant GICC_IRQBYPDISGRP0             \ [0x06] IRQBYPDISGRP0
    $07 constant GICC_FIQBYPDISGRP1             \ [0x07] FIQBYPDISGRP1
    $08 constant GICC_IRQBYPDISGRP1             \ [0x08] IRQBYPDISGRP1
    $09 constant GICC_EOIMODES                  \ [0x09] EOIMODES
    $0a constant GICC_EOIMODENS                 \ [0x0a] EOIMODENS
  [then]


  [ifdef] GICC_GICC_PMR_DEF
    \
    \ @brief GICC input priority mask register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant GICC_PRIORITY                  \ [0x03 : 5] PRIORITY
  [then]


  [ifdef] GICC_GICC_BPR_DEF
    \
    \ @brief GICC binary point register
    \ Address offset: 0x08
    \ Reset value: 0x00000002
    \
    $00 constant GICC_BINARY_POINT              \ [0x00 : 3] BINARY_POINT
  [then]


  [ifdef] GICC_GICC_IAR_DEF
    \
    \ @brief GICC interrupt acknowledge register
    \ Address offset: 0x0C
    \ Reset value: 0x000003FF
    \
    $00 constant GICC_INTERRUPT_ID              \ [0x00 : 10] INTERRUPT_ID
    $0a constant GICC_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICC_GICC_EOIR_DEF
    \
    \ @brief GICC end of interrupt register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GICC_EOIINTID                  \ [0x00 : 10] EOIINTID
    $0a constant GICC_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICC_GICC_RPR_DEF
    \
    \ @brief GICC running priority register
    \ Address offset: 0x14
    \ Reset value: 0x000000FF
    \
    $03 constant GICC_PRIORITY                  \ [0x03 : 5] PRIORITY
  [then]


  [ifdef] GICC_GICC_HPPIR_DEF
    \
    \ @brief GICC highest priority pending interrupt register
    \ Address offset: 0x18
    \ Reset value: 0x000003FF
    \
    $00 constant GICC_PENDINTID                 \ [0x00 : 10] PENDINTID
    $0a constant GICC_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICC_GICC_ABPR_DEF
    \
    \ @brief GICC_ABPR is an alias of the non-secure GICC_BPR. When GICC_CTLR.CBPR is set to 0, a secure access to this register is equivalent to a non-secure access to GICC_BPR.
    \ Address offset: 0x1C
    \ Reset value: 0x00000003
    \
    $00 constant GICC_BINARY_POINT              \ [0x00 : 3] BINARY_POINT
  [then]


  [ifdef] GICC_GICC_AIAR_DEF
    \
    \ @brief GICC_AIAR is an alias of the non-secure view of GICC_IAR. A secure access to this register is identical to a non-secure access to GICC_IAR.
    \ Address offset: 0x20
    \ Reset value: 0x000003FF
    \
    $00 constant GICC_INTERRUPT_ID              \ [0x00 : 10] INTERRUPT_ID
    $0a constant GICC_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICC_GICC_AEOIR_DEF
    \
    \ @brief GICC_AEOIR is an alias of the Non-secure GICC_EOIR. A secure access to this register is similar to a non-secure access to GICC_EOIR, except that the GICC_CTLR.EOImodeS bit is used.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GICC_EOIINTID                  \ [0x00 : 10] EOIINTID
    $0a constant GICC_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICC_GICC_AHPPIR_DEF
    \
    \ @brief ICC_AHPPIR is an alias of the non-secure GICC_HPPIR. A secure access to this register is equivalent to a non-secure access to GICC_HPPIR.
    \ Address offset: 0x28
    \ Reset value: 0x000003FF
    \
    $00 constant GICC_PENDINTID                 \ [0x00 : 10] PENDINTID
    $0a constant GICC_CPUID                     \ [0x0a] CPUID
  [then]


  [ifdef] GICC_GICC_APR0_DEF
    \
    \ @brief GICC active priority register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant GICC_APR0                      \ [0x00 : 32] APR0
  [then]


  [ifdef] GICC_GICC_NSAPR0_DEF
    \
    \ @brief GICC non-secure active priority register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant GICC_NSAPR0                    \ [0x00 : 32] NSAPR0
  [then]


  [ifdef] GICC_GICC_IIDR_DEF
    \
    \ @brief GICC interface identification register
    \ Address offset: 0xFC
    \ Reset value: 0x0102143B
    \
    $00 constant GICC_IMPLEMENTER               \ [0x00 : 12] IMPLEMENTER
    $0c constant GICC_REVISION                  \ [0x0c : 4] REVISION
    $10 constant GICC_ARCH                      \ [0x10 : 4] ARCH
    $14 constant GICC_PRODUCTID                 \ [0x14 : 12] PRODUCTID
  [then]


  [ifdef] GICC_GICC_DIR_DEF
    \
    \ @brief GICC deactivate interrupt register
    \ Address offset: 0x1000
    \ Reset value: 0x00000000
    \
    $00 constant GICC_INTERRUPT_ID              \ [0x00 : 10] INTERRUPT_ID
    $0a constant GICC_CPUID                     \ [0x0a] CPUID
  [then]

  \
  \ @brief GICC
  \
  $00 constant GICC_GICC_CTLR           \ GICC control register
  $04 constant GICC_GICC_PMR            \ GICC input priority mask register
  $08 constant GICC_GICC_BPR            \ GICC binary point register
  $0C constant GICC_GICC_IAR            \ GICC interrupt acknowledge register
  $10 constant GICC_GICC_EOIR           \ GICC end of interrupt register
  $14 constant GICC_GICC_RPR            \ GICC running priority register
  $18 constant GICC_GICC_HPPIR          \ GICC highest priority pending interrupt register
  $1C constant GICC_GICC_ABPR           \ GICC_ABPR is an alias of the non-secure GICC_BPR. When GICC_CTLR.CBPR is set to 0, a secure access to this register is equivalent to a non-secure access to GICC_BPR.
  $20 constant GICC_GICC_AIAR           \ GICC_AIAR is an alias of the non-secure view of GICC_IAR. A secure access to this register is identical to a non-secure access to GICC_IAR.
  $24 constant GICC_GICC_AEOIR          \ GICC_AEOIR is an alias of the Non-secure GICC_EOIR. A secure access to this register is similar to a non-secure access to GICC_EOIR, except that the GICC_CTLR.EOImodeS bit is used.
  $28 constant GICC_GICC_AHPPIR         \ ICC_AHPPIR is an alias of the non-secure GICC_HPPIR. A secure access to this register is equivalent to a non-secure access to GICC_HPPIR.
  $D0 constant GICC_GICC_APR0           \ GICC active priority register
  $E0 constant GICC_GICC_NSAPR0         \ GICC non-secure active priority register
  $FC constant GICC_GICC_IIDR           \ GICC interface identification register
  $1000 constant GICC_GICC_DIR          \ GICC deactivate interrupt register

: GICC_DEF ; [then]
