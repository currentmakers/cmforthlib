\
\ @file icache.fs
\ @brief ICache
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
    $00 constant ICACHE_EN                      \ [0x00] EN
    $01 constant ICACHE_CACHEINV                \ [0x01] CACHEINV
    $02 constant ICACHE_WAYSEL                  \ [0x02] WAYSEL
    $10 constant ICACHE_HITMEN                  \ [0x10] HITMEN
    $11 constant ICACHE_MISSMEN                 \ [0x11] MISSMEN
    $12 constant ICACHE_HITMRST                 \ [0x12] HITMRST
    $13 constant ICACHE_MISSMRST                \ [0x13] MISSMRST
  [then]


  [ifdef] ICACHE_ICACHE_SR_DEF
    \
    \ @brief ICACHE status register
    \ Address offset: 0x04
    \ Reset value: 0x00000001
    \
    $00 constant ICACHE_BUSYF                   \ [0x00] BUSYF
    $01 constant ICACHE_BSYENDF                 \ [0x01] BSYENDF
    $02 constant ICACHE_ERRF                    \ [0x02] ERRF
  [then]


  [ifdef] ICACHE_ICACHE_IER_DEF
    \
    \ @brief ICACHE interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $01 constant ICACHE_BSYENDIE                \ [0x01] BSYENDIE
    $02 constant ICACHE_ERRIE                   \ [0x02] ERRIE
  [then]


  [ifdef] ICACHE_ICACHE_FCR_DEF
    \
    \ @brief ICACHE flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant ICACHE_CBSYENDF                \ [0x01] CBSYENDF
    $02 constant ICACHE_CERRF                   \ [0x02] CERRF
  [then]


  [ifdef] ICACHE_ICACHE_HMONR_DEF
    \
    \ @brief ICACHE hit monitor register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ICACHE_HITMON                  \ [0x00 : 32] HITMON
  [then]


  [ifdef] ICACHE_ICACHE_MMONR_DEF
    \
    \ @brief ICACHE miss monitor register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ICACHE_MISSMON                 \ [0x00 : 16] MISSMON
  [then]


  [ifdef] ICACHE_ICACHE_CRR0_DEF
    \
    \ @brief ICACHE region configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000200
    \
    $00 constant ICACHE_BASEADDR                \ [0x00 : 8] BASEADDR
    $09 constant ICACHE_RSIZE                   \ [0x09 : 3] RSIZE
    $0f constant ICACHE_REN                     \ [0x0f] REN
    $10 constant ICACHE_REMAPADDR               \ [0x10 : 11] REMAPADDR
    $1c constant ICACHE_MSTSEL                  \ [0x1c] MSTSEL
    $1f constant ICACHE_HBURST                  \ [0x1f] HBURST
  [then]


  [ifdef] ICACHE_ICACHE_CRR1_DEF
    \
    \ @brief ICACHE region configuration register
    \ Address offset: 0x24
    \ Reset value: 0x00000200
    \
    $00 constant ICACHE_BASEADDR                \ [0x00 : 8] BASEADDR
    $09 constant ICACHE_RSIZE                   \ [0x09 : 3] RSIZE
    $0f constant ICACHE_REN                     \ [0x0f] REN
    $10 constant ICACHE_REMAPADDR               \ [0x10 : 11] REMAPADDR
    $1c constant ICACHE_MSTSEL                  \ [0x1c] MSTSEL
    $1f constant ICACHE_HBURST                  \ [0x1f] HBURST
  [then]


  [ifdef] ICACHE_ICACHE_CRR2_DEF
    \
    \ @brief ICACHE region configuration register
    \ Address offset: 0x28
    \ Reset value: 0x00000200
    \
    $00 constant ICACHE_BASEADDR                \ [0x00 : 8] BASEADDR
    $09 constant ICACHE_RSIZE                   \ [0x09 : 3] RSIZE
    $0f constant ICACHE_REN                     \ [0x0f] REN
    $10 constant ICACHE_REMAPADDR               \ [0x10 : 11] REMAPADDR
    $1c constant ICACHE_MSTSEL                  \ [0x1c] MSTSEL
    $1f constant ICACHE_HBURST                  \ [0x1f] HBURST
  [then]


  [ifdef] ICACHE_ICACHE_CRR3_DEF
    \
    \ @brief ICACHE region configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000200
    \
    $00 constant ICACHE_BASEADDR                \ [0x00 : 8] BASEADDR
    $09 constant ICACHE_RSIZE                   \ [0x09 : 3] RSIZE
    $0f constant ICACHE_REN                     \ [0x0f] REN
    $10 constant ICACHE_REMAPADDR               \ [0x10 : 11] REMAPADDR
    $1c constant ICACHE_MSTSEL                  \ [0x1c] MSTSEL
    $1f constant ICACHE_HBURST                  \ [0x1f] HBURST
  [then]

  \
  \ @brief ICache
  \
  $00 constant ICACHE_ICACHE_CR         \ ICACHE control register
  $04 constant ICACHE_ICACHE_SR         \ ICACHE status register
  $08 constant ICACHE_ICACHE_IER        \ ICACHE interrupt enable register
  $0C constant ICACHE_ICACHE_FCR        \ ICACHE flag clear register
  $10 constant ICACHE_ICACHE_HMONR      \ ICACHE hit monitor register
  $14 constant ICACHE_ICACHE_MMONR      \ ICACHE miss monitor register
  $20 constant ICACHE_ICACHE_CRR0       \ ICACHE region configuration register
  $24 constant ICACHE_ICACHE_CRR1       \ ICACHE region configuration register
  $28 constant ICACHE_ICACHE_CRR2       \ ICACHE region configuration register
  $2C constant ICACHE_ICACHE_CRR3       \ ICACHE region configuration register

: ICACHE_DEF ; [then]
