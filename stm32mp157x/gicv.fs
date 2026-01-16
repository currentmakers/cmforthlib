\
\ @file gicv.fs
\ @brief GICV
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GICV virtual machine control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GICV_GICV_CTLR_ENABLEGRP0                        \ ENABLEGRP0
$00000002 constant GICV_GICV_CTLR_ENABLEGRP1                        \ ENABLEGRP1
$00000004 constant GICV_GICV_CTLR_ACKCTL                            \ ACKCTL
$00000008 constant GICV_GICV_CTLR_FIQEN                             \ FIQEN
$00000010 constant GICV_GICV_CTLR_CBPR                              \ CBPR
$00000200 constant GICV_GICV_CTLR_EOIMODE                           \ EOIMODE


\
\ @brief GICV VM priority mask register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000f8 constant GICV_GICV_PMR_PRIORITY                           \ PRIORITY


\
\ @brief GICV VM binary point register
\ Address offset: 0x08
\ Reset value: 0x00000002
\

$00000007 constant GICV_GICV_BPR_BINARY_POINT                       \ BINARY_POINT


\
\ @brief GICV VM interrupt acknowledge register
\ Address offset: 0x0C
\ Reset value: 0x000003FF
\

$000003ff constant GICV_GICV_IAR_INTERRUPT_ID                       \ INTERRUPT_ID
$00000400 constant GICV_GICV_IAR_CPUID                              \ CPUID


\
\ @brief GICV VM end of interrupt register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000003ff constant GICV_GICV_EOIR_EOIINTID                          \ EOIINTID
$00000400 constant GICV_GICV_EOIR_CPUID                             \ CPUID


\
\ @brief GICV VM running priority register
\ Address offset: 0x14
\ Reset value: 0x000000FF
\

$000000f8 constant GICV_GICV_RPR_PRIORITY                           \ PRIORITY


\
\ @brief GICV VM highest priority pending interrupt register
\ Address offset: 0x18
\ Reset value: 0x000003FF
\

$000003ff constant GICV_GICV_HPPIR_PENDINTID                        \ PENDINTID
$00000400 constant GICV_GICV_HPPIR_CPUID                            \ CPUID


\
\ @brief GICV VM aliased binary point register
\ Address offset: 0x1C
\ Reset value: 0x00000003
\

$00000007 constant GICV_GICV_ABPR_BINARY_POINT                      \ BINARY_POINT


\
\ @brief GICV VM aliased interrupt register
\ Address offset: 0x20
\ Reset value: 0x000003FF
\

$000003ff constant GICV_GICV_AIAR_INTERRUPT_ID                      \ INTERRUPT_ID
$00000400 constant GICV_GICV_AIAR_CPUID                             \ CPUID


\
\ @brief GICV VM aliased end of interrupt register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000003ff constant GICV_GICV_AEOIR_EOIINTID                         \ EOIINTID
$00000400 constant GICV_GICV_AEOIR_CPUID                            \ CPUID


\
\ @brief GICV VM aliased highest priority pending interrupt register
\ Address offset: 0x28
\ Reset value: 0x000003FF
\

$000003ff constant GICV_GICV_AHPPIR_PENDINTID                       \ PENDINTID
$00000400 constant GICV_GICV_AHPPIR_CPUID                           \ CPUID


\
\ @brief The GICV_APR0 is an alias of GICH_APR.
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant GICV_GICV_APR0_APR0                              \ APR0


\
\ @brief The GICV_IIDR is an alias of GICC_IIDR.
\ Address offset: 0xFC
\ Reset value: 0x0102143B
\

$00000000 constant GICV_GICV_IIDR_IIDR                              \ IIDR


\
\ @brief GICV VM deactivate interrupt register
\ Address offset: 0x1000
\ Reset value: 0x00000000
\

$000003ff constant GICV_GICV_DIR_INTERRUPT_ID                       \ INTERRUPT_ID
$00000400 constant GICV_GICV_DIR_CPUID                              \ CPUID


\
\ @brief GICV
\
$a0026000 constant GICV_GICV_CTLR  \ offset: 0x00 : GICV virtual machine control register
$a0026004 constant GICV_GICV_PMR  \ offset: 0x04 : GICV VM priority mask register
$a0026008 constant GICV_GICV_BPR  \ offset: 0x08 : GICV VM binary point register
$a002600c constant GICV_GICV_IAR  \ offset: 0x0C : GICV VM interrupt acknowledge register
$a0026010 constant GICV_GICV_EOIR  \ offset: 0x10 : GICV VM end of interrupt register
$a0026014 constant GICV_GICV_RPR  \ offset: 0x14 : GICV VM running priority register
$a0026018 constant GICV_GICV_HPPIR  \ offset: 0x18 : GICV VM highest priority pending interrupt register
$a002601c constant GICV_GICV_ABPR  \ offset: 0x1C : GICV VM aliased binary point register
$a0026020 constant GICV_GICV_AIAR  \ offset: 0x20 : GICV VM aliased interrupt register
$a0026024 constant GICV_GICV_AEOIR  \ offset: 0x24 : GICV VM aliased end of interrupt register
$a0026028 constant GICV_GICV_AHPPIR  \ offset: 0x28 : GICV VM aliased highest priority pending interrupt register
$a00260d0 constant GICV_GICV_APR0  \ offset: 0xD0 : The GICV_APR0 is an alias of GICH_APR.
$a00260fc constant GICV_GICV_IIDR  \ offset: 0xFC : The GICV_IIDR is an alias of GICC_IIDR.
$a0027000 constant GICV_GICV_DIR  \ offset: 0x1000 : GICV VM deactivate interrupt register

