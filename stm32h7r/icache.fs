\
\ @file icache.fs
\ @brief Texture cache
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

$00000001 constant ICACHE_ICACHE_CR_EN                              \ enable
$00000002 constant ICACHE_ICACHE_CR_CACHEINV                        \ cache invalidation Set by software and cleared by hardware when the BUSYF flag is set (during cache maintenance operation). Writing 0 has no effect.
$00000004 constant ICACHE_ICACHE_CR_WAYSEL                          \ cache associativity mode selection This bit allows user to choose ICACHE set-associativity. It can be written by software only when cache is disabled (EN = 0).
$00010000 constant ICACHE_ICACHE_CR_HITMEN                          \ hit monitor enable
$00020000 constant ICACHE_ICACHE_CR_MISSMEN                         \ miss monitor enable
$00040000 constant ICACHE_ICACHE_CR_HITMRST                         \ hit monitor reset
$00080000 constant ICACHE_ICACHE_CR_MISSMRST                        \ miss monitor reset


\
\ @brief ICACHE status register
\ Address offset: 0x04
\ Reset value: 0x00000001
\

$00000001 constant ICACHE_ICACHE_SR_BUSYF                           \ busy flag
$00000002 constant ICACHE_ICACHE_SR_BSYENDF                         \ busy end flag
$00000004 constant ICACHE_ICACHE_SR_ERRF                            \ cache error flag


\
\ @brief ICACHE interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant ICACHE_ICACHE_IER_BSYENDIE                       \ interrupt enable on busy end Set by software to enable an interrupt generation at the end of a cache invalidate operation.
$00000004 constant ICACHE_ICACHE_IER_ERRIE                          \ interrupt enable on cache error Set by software to enable an interrupt generation in case of cache functional error (cacheable write access)


\
\ @brief ICACHE flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant ICACHE_ICACHE_FCR_CBSYENDF                       \ clear busy end flag Set by software.
$00000004 constant ICACHE_ICACHE_FCR_CERRF                          \ clear cache error flag Set by software.


\
\ @brief ICACHE hit monitor register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ICACHE_ICACHE_HMONR_HITMON                       \ cache hit monitor counter


\
\ @brief ICACHE miss monitor register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant ICACHE_ICACHE_MMONR_MISSMON                      \ cache miss monitor counter


\
\ @brief Texture cache
\
$52015000 constant ICACHE_ICACHE_CR  \ offset: 0x00 : ICACHE control register
$52015004 constant ICACHE_ICACHE_SR  \ offset: 0x04 : ICACHE status register
$52015008 constant ICACHE_ICACHE_IER  \ offset: 0x08 : ICACHE interrupt enable register
$5201500c constant ICACHE_ICACHE_FCR  \ offset: 0x0C : ICACHE flag clear register
$52015010 constant ICACHE_ICACHE_HMONR  \ offset: 0x10 : ICACHE hit monitor register
$52015014 constant ICACHE_ICACHE_MMONR  \ offset: 0x14 : ICACHE miss monitor register

