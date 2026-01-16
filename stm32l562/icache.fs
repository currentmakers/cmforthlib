\
\ @file icache.fs
\ @brief ICache
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief ICACHE control register
\ Address offset: 0x00
\ Reset value: 0x00000004
\

$00000001 constant ICACHE_ICACHE_CR_EN                              \ EN
$00000002 constant ICACHE_ICACHE_CR_CACHEINV                        \ CACHEINV
$00000004 constant ICACHE_ICACHE_CR_WAYSEL                          \ WAYSEL
$00010000 constant ICACHE_ICACHE_CR_HITMEN                          \ HITMEN
$00020000 constant ICACHE_ICACHE_CR_MISSMEN                         \ MISSMEN
$00040000 constant ICACHE_ICACHE_CR_HITMRST                         \ HITMRST
$00080000 constant ICACHE_ICACHE_CR_MISSMRST                        \ MISSMRST


\
\ @brief ICACHE status register
\ Address offset: 0x04
\ Reset value: 0x00000001
\

$00000001 constant ICACHE_ICACHE_SR_BUSYF                           \ BUSYF
$00000002 constant ICACHE_ICACHE_SR_BSYENDF                         \ BSYENDF
$00000004 constant ICACHE_ICACHE_SR_ERRF                            \ ERRF


\
\ @brief ICACHE interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant ICACHE_ICACHE_IER_BSYENDIE                       \ BSYENDIE
$00000004 constant ICACHE_ICACHE_IER_ERRIE                          \ ERRIE


\
\ @brief ICACHE flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant ICACHE_ICACHE_FCR_CBSYENDF                       \ CBSYENDF
$00000004 constant ICACHE_ICACHE_FCR_CERRF                          \ CERRF


\
\ @brief ICACHE hit monitor register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ICACHE_ICACHE_HMONR_HITMON                       \ HITMON


\
\ @brief ICACHE miss monitor register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant ICACHE_ICACHE_MMONR_MISSMON                      \ MISSMON


\
\ @brief ICACHE region configuration register
\ Address offset: 0x20
\ Reset value: 0x00000200
\

$000000ff constant ICACHE_ICACHE_CRR0_BASEADDR                      \ BASEADDR
$00000e00 constant ICACHE_ICACHE_CRR0_RSIZE                         \ RSIZE
$00008000 constant ICACHE_ICACHE_CRR0_REN                           \ REN
$07ff0000 constant ICACHE_ICACHE_CRR0_REMAPADDR                     \ REMAPADDR
$10000000 constant ICACHE_ICACHE_CRR0_MSTSEL                        \ MSTSEL
$80000000 constant ICACHE_ICACHE_CRR0_HBURST                        \ HBURST


\
\ @brief ICACHE region configuration register
\ Address offset: 0x24
\ Reset value: 0x00000200
\

$000000ff constant ICACHE_ICACHE_CRR1_BASEADDR                      \ BASEADDR
$00000e00 constant ICACHE_ICACHE_CRR1_RSIZE                         \ RSIZE
$00008000 constant ICACHE_ICACHE_CRR1_REN                           \ REN
$07ff0000 constant ICACHE_ICACHE_CRR1_REMAPADDR                     \ REMAPADDR
$10000000 constant ICACHE_ICACHE_CRR1_MSTSEL                        \ MSTSEL
$80000000 constant ICACHE_ICACHE_CRR1_HBURST                        \ HBURST


\
\ @brief ICACHE region configuration register
\ Address offset: 0x28
\ Reset value: 0x00000200
\

$000000ff constant ICACHE_ICACHE_CRR2_BASEADDR                      \ BASEADDR
$00000e00 constant ICACHE_ICACHE_CRR2_RSIZE                         \ RSIZE
$00008000 constant ICACHE_ICACHE_CRR2_REN                           \ REN
$07ff0000 constant ICACHE_ICACHE_CRR2_REMAPADDR                     \ REMAPADDR
$10000000 constant ICACHE_ICACHE_CRR2_MSTSEL                        \ MSTSEL
$80000000 constant ICACHE_ICACHE_CRR2_HBURST                        \ HBURST


\
\ @brief ICACHE region configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000200
\

$000000ff constant ICACHE_ICACHE_CRR3_BASEADDR                      \ BASEADDR
$00000e00 constant ICACHE_ICACHE_CRR3_RSIZE                         \ RSIZE
$00008000 constant ICACHE_ICACHE_CRR3_REN                           \ REN
$07ff0000 constant ICACHE_ICACHE_CRR3_REMAPADDR                     \ REMAPADDR
$10000000 constant ICACHE_ICACHE_CRR3_MSTSEL                        \ MSTSEL
$80000000 constant ICACHE_ICACHE_CRR3_HBURST                        \ HBURST


\
\ @brief ICache
\
$40030400 constant ICACHE_ICACHE_CR  \ offset: 0x00 : ICACHE control register
$40030404 constant ICACHE_ICACHE_SR  \ offset: 0x04 : ICACHE status register
$40030408 constant ICACHE_ICACHE_IER  \ offset: 0x08 : ICACHE interrupt enable register
$4003040c constant ICACHE_ICACHE_FCR  \ offset: 0x0C : ICACHE flag clear register
$40030410 constant ICACHE_ICACHE_HMONR  \ offset: 0x10 : ICACHE hit monitor register
$40030414 constant ICACHE_ICACHE_MMONR  \ offset: 0x14 : ICACHE miss monitor register
$40030420 constant ICACHE_ICACHE_CRR0  \ offset: 0x20 : ICACHE region configuration register
$40030424 constant ICACHE_ICACHE_CRR1  \ offset: 0x24 : ICACHE region configuration register
$40030428 constant ICACHE_ICACHE_CRR2  \ offset: 0x28 : ICACHE region configuration register
$4003042c constant ICACHE_ICACHE_CRR3  \ offset: 0x2C : ICACHE region configuration register

