\
\ @file icache.fs
\ @brief Texture cache
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ICACHE_DEF

  [ifdef] ICACHE_ICACHE_CR_DEF
    \
    \ @brief ICACHE control register
    \ Address offset: 0x00
    \ Reset value: 0x00000004
    \
    $00 constant ICACHE_EN                      \ [0x00] enable
    $01 constant ICACHE_CACHEINV                \ [0x01] cache invalidation Set by software and cleared by hardware when the BUSYF flag is set (during cache maintenance operation). Writing 0 has no effect.
    $02 constant ICACHE_WAYSEL                  \ [0x02] cache associativity mode selection This bit allows user to choose ICACHE set-associativity. It can be written by software only when cache is disabled (EN = 0).
    $10 constant ICACHE_HITMEN                  \ [0x10] hit monitor enable
    $11 constant ICACHE_MISSMEN                 \ [0x11] miss monitor enable
    $12 constant ICACHE_HITMRST                 \ [0x12] hit monitor reset
    $13 constant ICACHE_MISSMRST                \ [0x13] miss monitor reset
  [then]


  [ifdef] ICACHE_ICACHE_SR_DEF
    \
    \ @brief ICACHE status register
    \ Address offset: 0x04
    \ Reset value: 0x00000001
    \
    $00 constant ICACHE_BUSYF                   \ [0x00] busy flag
    $01 constant ICACHE_BSYENDF                 \ [0x01] busy end flag
    $02 constant ICACHE_ERRF                    \ [0x02] cache error flag
  [then]


  [ifdef] ICACHE_ICACHE_IER_DEF
    \
    \ @brief ICACHE interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $01 constant ICACHE_BSYENDIE                \ [0x01] interrupt enable on busy end Set by software to enable an interrupt generation at the end of a cache invalidate operation.
    $02 constant ICACHE_ERRIE                   \ [0x02] interrupt enable on cache error Set by software to enable an interrupt generation in case of cache functional error (cacheable write access)
  [then]


  [ifdef] ICACHE_ICACHE_FCR_DEF
    \
    \ @brief ICACHE flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant ICACHE_CBSYENDF                \ [0x01] clear busy end flag Set by software.
    $02 constant ICACHE_CERRF                   \ [0x02] clear cache error flag Set by software.
  [then]


  [ifdef] ICACHE_ICACHE_HMONR_DEF
    \
    \ @brief ICACHE hit monitor register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ICACHE_HITMON                  \ [0x00 : 32] cache hit monitor counter
  [then]


  [ifdef] ICACHE_ICACHE_MMONR_DEF
    \
    \ @brief ICACHE miss monitor register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ICACHE_MISSMON                 \ [0x00 : 16] cache miss monitor counter
  [then]

  \
  \ @brief Texture cache
  \
  $00 constant ICACHE_ICACHE_CR         \ ICACHE control register
  $04 constant ICACHE_ICACHE_SR         \ ICACHE status register
  $08 constant ICACHE_ICACHE_IER        \ ICACHE interrupt enable register
  $0C constant ICACHE_ICACHE_FCR        \ ICACHE flag clear register
  $10 constant ICACHE_ICACHE_HMONR      \ ICACHE hit monitor register
  $14 constant ICACHE_ICACHE_MMONR      \ ICACHE miss monitor register

: ICACHE_DEF ; [then]
