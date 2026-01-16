\
\ @file gicc.fs
\ @brief GICC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GICC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GICC_GICC_CTLR_ENABLEGRP0                        \ ENABLEGRP0
$00000002 constant GICC_GICC_CTLR_ENABLEGRP1                        \ ENABLEGRP1
$00000004 constant GICC_GICC_CTLR_ACKCTL                            \ ACKCTL
$00000008 constant GICC_GICC_CTLR_FIQEN                             \ FIQEN
$00000010 constant GICC_GICC_CTLR_CBPR                              \ CBPR
$00000020 constant GICC_GICC_CTLR_FIQBYPDISGRP0                     \ FIQBYPDISGRP0
$00000040 constant GICC_GICC_CTLR_IRQBYPDISGRP0                     \ IRQBYPDISGRP0
$00000080 constant GICC_GICC_CTLR_FIQBYPDISGRP1                     \ FIQBYPDISGRP1
$00000100 constant GICC_GICC_CTLR_IRQBYPDISGRP1                     \ IRQBYPDISGRP1
$00000200 constant GICC_GICC_CTLR_EOIMODES                          \ EOIMODES
$00000400 constant GICC_GICC_CTLR_EOIMODENS                         \ EOIMODENS


\
\ @brief GICC input priority mask register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000f8 constant GICC_GICC_PMR_PRIORITY                           \ PRIORITY


\
\ @brief GICC binary point register
\ Address offset: 0x08
\ Reset value: 0x00000002
\

$00000007 constant GICC_GICC_BPR_BINARY_POINT                       \ BINARY_POINT


\
\ @brief GICC interrupt acknowledge register
\ Address offset: 0x0C
\ Reset value: 0x000003FF
\

$000003ff constant GICC_GICC_IAR_INTERRUPT_ID                       \ INTERRUPT_ID
$00000400 constant GICC_GICC_IAR_CPUID                              \ CPUID


\
\ @brief GICC end of interrupt register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000003ff constant GICC_GICC_EOIR_EOIINTID                          \ EOIINTID
$00000400 constant GICC_GICC_EOIR_CPUID                             \ CPUID


\
\ @brief GICC running priority register
\ Address offset: 0x14
\ Reset value: 0x000000FF
\

$000000f8 constant GICC_GICC_RPR_PRIORITY                           \ PRIORITY


\
\ @brief GICC highest priority pending interrupt register
\ Address offset: 0x18
\ Reset value: 0x000003FF
\

$000003ff constant GICC_GICC_HPPIR_PENDINTID                        \ PENDINTID
$00000400 constant GICC_GICC_HPPIR_CPUID                            \ CPUID


\
\ @brief GICC_ABPR is an alias of the non-secure GICC_BPR. When GICC_CTLR.CBPR is set to 0, a secure access to this register is equivalent to a non-secure access to GICC_BPR.
\ Address offset: 0x1C
\ Reset value: 0x00000003
\

$00000007 constant GICC_GICC_ABPR_BINARY_POINT                      \ BINARY_POINT


\
\ @brief GICC_AIAR is an alias of the non-secure view of GICC_IAR. A secure access to this register is identical to a non-secure access to GICC_IAR.
\ Address offset: 0x20
\ Reset value: 0x000003FF
\

$000003ff constant GICC_GICC_AIAR_INTERRUPT_ID                      \ INTERRUPT_ID
$00000400 constant GICC_GICC_AIAR_CPUID                             \ CPUID


\
\ @brief GICC_AEOIR is an alias of the Non-secure GICC_EOIR. A secure access to this register is similar to a non-secure access to GICC_EOIR, except that the GICC_CTLR.EOImodeS bit is used.
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000003ff constant GICC_GICC_AEOIR_EOIINTID                         \ EOIINTID
$00000400 constant GICC_GICC_AEOIR_CPUID                            \ CPUID


\
\ @brief ICC_AHPPIR is an alias of the non-secure GICC_HPPIR. A secure access to this register is equivalent to a non-secure access to GICC_HPPIR.
\ Address offset: 0x28
\ Reset value: 0x000003FF
\

$000003ff constant GICC_GICC_AHPPIR_PENDINTID                       \ PENDINTID
$00000400 constant GICC_GICC_AHPPIR_CPUID                           \ CPUID


\
\ @brief GICC active priority register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant GICC_GICC_APR0_APR0                              \ APR0


\
\ @brief GICC non-secure active priority register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000000 constant GICC_GICC_NSAPR0_NSAPR0                          \ NSAPR0


\
\ @brief GICC interface identification register
\ Address offset: 0xFC
\ Reset value: 0x0102143B
\

$00000fff constant GICC_GICC_IIDR_IMPLEMENTER                       \ IMPLEMENTER
$0000f000 constant GICC_GICC_IIDR_REVISION                          \ REVISION
$000f0000 constant GICC_GICC_IIDR_ARCH                              \ ARCH
$fff00000 constant GICC_GICC_IIDR_PRODUCTID                         \ PRODUCTID


\
\ @brief GICC deactivate interrupt register
\ Address offset: 0x1000
\ Reset value: 0x00000000
\

$000003ff constant GICC_GICC_DIR_INTERRUPT_ID                       \ INTERRUPT_ID
$00000400 constant GICC_GICC_DIR_CPUID                              \ CPUID


\
\ @brief GICC
\
$a0022000 constant GICC_GICC_CTLR  \ offset: 0x00 : GICC control register
$a0022004 constant GICC_GICC_PMR  \ offset: 0x04 : GICC input priority mask register
$a0022008 constant GICC_GICC_BPR  \ offset: 0x08 : GICC binary point register
$a002200c constant GICC_GICC_IAR  \ offset: 0x0C : GICC interrupt acknowledge register
$a0022010 constant GICC_GICC_EOIR  \ offset: 0x10 : GICC end of interrupt register
$a0022014 constant GICC_GICC_RPR  \ offset: 0x14 : GICC running priority register
$a0022018 constant GICC_GICC_HPPIR  \ offset: 0x18 : GICC highest priority pending interrupt register
$a002201c constant GICC_GICC_ABPR  \ offset: 0x1C : GICC_ABPR is an alias of the non-secure GICC_BPR. When GICC_CTLR.CBPR is set to 0, a secure access to this register is equivalent to a non-secure access to GICC_BPR.
$a0022020 constant GICC_GICC_AIAR  \ offset: 0x20 : GICC_AIAR is an alias of the non-secure view of GICC_IAR. A secure access to this register is identical to a non-secure access to GICC_IAR.
$a0022024 constant GICC_GICC_AEOIR  \ offset: 0x24 : GICC_AEOIR is an alias of the Non-secure GICC_EOIR. A secure access to this register is similar to a non-secure access to GICC_EOIR, except that the GICC_CTLR.EOImodeS bit is used.
$a0022028 constant GICC_GICC_AHPPIR  \ offset: 0x28 : ICC_AHPPIR is an alias of the non-secure GICC_HPPIR. A secure access to this register is equivalent to a non-secure access to GICC_HPPIR.
$a00220d0 constant GICC_GICC_APR0  \ offset: 0xD0 : GICC active priority register
$a00220e0 constant GICC_GICC_NSAPR0  \ offset: 0xE0 : GICC non-secure active priority register
$a00220fc constant GICC_GICC_IIDR  \ offset: 0xFC : GICC interface identification register
$a0023000 constant GICC_GICC_DIR  \ offset: 0x1000 : GICC deactivate interrupt register

