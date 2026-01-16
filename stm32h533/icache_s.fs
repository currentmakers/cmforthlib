\
\ @file icache_s.fs
\ @brief ICACHE register block
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

$00000001 constant ICACHE_S_ICACHE_CR_EN                            \ enable
$00000002 constant ICACHE_S_ICACHE_CR_CACHEINV                      \ cache invalidation
$00000004 constant ICACHE_S_ICACHE_CR_WAYSEL                        \ cache associativity mode selection
$00010000 constant ICACHE_S_ICACHE_CR_HITMEN                        \ hit monitor enable
$00020000 constant ICACHE_S_ICACHE_CR_MISSMEN                       \ miss monitor enable
$00040000 constant ICACHE_S_ICACHE_CR_HITMRST                       \ hit monitor reset
$00080000 constant ICACHE_S_ICACHE_CR_MISSMRST                      \ miss monitor reset


\
\ @brief ICACHE status register
\ Address offset: 0x04
\ Reset value: 0x00000001
\

$00000001 constant ICACHE_S_ICACHE_SR_BUSYF                         \ busy flag
$00000002 constant ICACHE_S_ICACHE_SR_BSYENDF                       \ busy end flag
$00000004 constant ICACHE_S_ICACHE_SR_ERRF                          \ cache error flag


\
\ @brief ICACHE interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant ICACHE_S_ICACHE_IER_BSYENDIE                     \ interrupt enable on busy end
$00000004 constant ICACHE_S_ICACHE_IER_ERRIE                        \ interrupt enable on cache error


\
\ @brief ICACHE flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant ICACHE_S_ICACHE_FCR_CBSYENDF                     \ clear busy end flag
$00000004 constant ICACHE_S_ICACHE_FCR_CERRF                        \ clear cache error flag


\
\ @brief ICACHE hit monitor register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ICACHE_S_ICACHE_HMONR_HITMON                     \ cache hit monitor counter


\
\ @brief ICACHE miss monitor register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant ICACHE_S_ICACHE_MMONR_MISSMON                    \ cache miss monitor counter


\
\ @brief ICACHE region 0 configuration register
\ Address offset: 0x20
\ Reset value: 0x00000200
\

$000000ff constant ICACHE_S_ICACHE_CRR0_BASEADDR                    \ base address for region x
$00000e00 constant ICACHE_S_ICACHE_CRR0_RSIZE                       \ size for region x
$00008000 constant ICACHE_S_ICACHE_CRR0_REN                         \ enable for region x
$07ff0000 constant ICACHE_S_ICACHE_CRR0_REMAPADDR                   \ remapped address for region x
$10000000 constant ICACHE_S_ICACHE_CRR0_MSTSEL                      \ AHB cache master selection for region x
$80000000 constant ICACHE_S_ICACHE_CRR0_HBURST                      \ output burst type for region x


\
\ @brief ICACHE region 1 configuration register
\ Address offset: 0x24
\ Reset value: 0x00000200
\

$000000ff constant ICACHE_S_ICACHE_CRR1_BASEADDR                    \ base address for region x
$00000e00 constant ICACHE_S_ICACHE_CRR1_RSIZE                       \ size for region x
$00008000 constant ICACHE_S_ICACHE_CRR1_REN                         \ enable for region x
$07ff0000 constant ICACHE_S_ICACHE_CRR1_REMAPADDR                   \ remapped address for region x
$10000000 constant ICACHE_S_ICACHE_CRR1_MSTSEL                      \ AHB cache master selection for region x
$80000000 constant ICACHE_S_ICACHE_CRR1_HBURST                      \ output burst type for region x


\
\ @brief ICACHE region 2 configuration register
\ Address offset: 0x28
\ Reset value: 0x00000200
\

$000000ff constant ICACHE_S_ICACHE_CRR2_BASEADDR                    \ base address for region x
$00000e00 constant ICACHE_S_ICACHE_CRR2_RSIZE                       \ size for region x
$00008000 constant ICACHE_S_ICACHE_CRR2_REN                         \ enable for region x
$07ff0000 constant ICACHE_S_ICACHE_CRR2_REMAPADDR                   \ remapped address for region x
$10000000 constant ICACHE_S_ICACHE_CRR2_MSTSEL                      \ AHB cache master selection for region x
$80000000 constant ICACHE_S_ICACHE_CRR2_HBURST                      \ output burst type for region x


\
\ @brief ICACHE region 3 configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000200
\

$000000ff constant ICACHE_S_ICACHE_CRR3_BASEADDR                    \ base address for region x
$00000e00 constant ICACHE_S_ICACHE_CRR3_RSIZE                       \ size for region x
$00008000 constant ICACHE_S_ICACHE_CRR3_REN                         \ enable for region x
$07ff0000 constant ICACHE_S_ICACHE_CRR3_REMAPADDR                   \ remapped address for region x
$10000000 constant ICACHE_S_ICACHE_CRR3_MSTSEL                      \ AHB cache master selection for region x
$80000000 constant ICACHE_S_ICACHE_CRR3_HBURST                      \ output burst type for region x


\
\ @brief ICACHE register block
\
$50030400 constant ICACHE_S_ICACHE_CR  \ offset: 0x00 : ICACHE control register
$50030404 constant ICACHE_S_ICACHE_SR  \ offset: 0x04 : ICACHE status register
$50030408 constant ICACHE_S_ICACHE_IER  \ offset: 0x08 : ICACHE interrupt enable register
$5003040c constant ICACHE_S_ICACHE_FCR  \ offset: 0x0C : ICACHE flag clear register
$50030410 constant ICACHE_S_ICACHE_HMONR  \ offset: 0x10 : ICACHE hit monitor register
$50030414 constant ICACHE_S_ICACHE_MMONR  \ offset: 0x14 : ICACHE miss monitor register
$50030420 constant ICACHE_S_ICACHE_CRR0  \ offset: 0x20 : ICACHE region 0 configuration register
$50030424 constant ICACHE_S_ICACHE_CRR1  \ offset: 0x24 : ICACHE region 1 configuration register
$50030428 constant ICACHE_S_ICACHE_CRR2  \ offset: 0x28 : ICACHE region 2 configuration register
$5003042c constant ICACHE_S_ICACHE_CRR3  \ offset: 0x2C : ICACHE region 3 configuration register

