\
\ @file dcache.fs
\ @brief DCACHE register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DCACHE_DEF

  [ifdef] DCACHE_DCACHE_CR_DEF
    \
    \ @brief DCACHE control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DCACHE_EN                      \ [0x00] enable
    $01 constant DCACHE_CACHEINV                \ [0x01] full cache invalidation
    $08 constant DCACHE_CACHECMD                \ [0x08 : 3] cache command maintenance operation (cleans and/or invalidates an address range)
    $0b constant DCACHE_STARTCMD                \ [0x0b] starts maintenance command (maintenance operation defined in CACHECMD).
    $10 constant DCACHE_RHITMEN                 \ [0x10] read-hit monitor enable
    $11 constant DCACHE_RMISSMEN                \ [0x11] read-miss monitor enable
    $12 constant DCACHE_RHITMRST                \ [0x12] read-hit monitor reset
    $13 constant DCACHE_RMISSMRST               \ [0x13] read-miss monitor reset
    $14 constant DCACHE_WHITMEN                 \ [0x14] write-hit monitor enable
    $15 constant DCACHE_WMISSMEN                \ [0x15] write-miss monitor enable
    $16 constant DCACHE_WHITMRST                \ [0x16] write-hit monitor reset
    $17 constant DCACHE_WMISSMRST               \ [0x17] write-miss monitor reset
    $1f constant DCACHE_HBURST                  \ [0x1f] output burst type for cache master port read accesses
  [then]


  [ifdef] DCACHE_DCACHE_SR_DEF
    \
    \ @brief DCACHE status register
    \ Address offset: 0x04
    \ Reset value: 0x00000001
    \
    $00 constant DCACHE_BUSYF                   \ [0x00] full invalidate busy flag
    $01 constant DCACHE_BSYENDF                 \ [0x01] full invalidate busy end flag
    $02 constant DCACHE_ERRF                    \ [0x02] cache error flag
    $03 constant DCACHE_BUSYCMDF                \ [0x03] command busy flag
    $04 constant DCACHE_CMDENDF                 \ [0x04] command end flag
  [then]


  [ifdef] DCACHE_DCACHE_IER_DEF
    \
    \ @brief DCACHE interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $01 constant DCACHE_BSYENDIE                \ [0x01] interrupt enable on busy end
    $02 constant DCACHE_ERRIE                   \ [0x02] interrupt enable on cache error
    $04 constant DCACHE_CMDENDIE                \ [0x04] interrupt enable on command end
  [then]


  [ifdef] DCACHE_DCACHE_FCR_DEF
    \
    \ @brief DCACHE flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant DCACHE_CBSYENDF                \ [0x01] clear full invalidate busy end flag
    $02 constant DCACHE_CERRF                   \ [0x02] clear cache error flag
    $04 constant DCACHE_CCMDENDF                \ [0x04] clear command end flag
  [then]


  [ifdef] DCACHE_DCACHE_RHMONR_DEF
    \
    \ @brief DCACHE read-hit monitor register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DCACHE_RHITMON                 \ [0x00 : 32] cache read-hit monitor counter
  [then]


  [ifdef] DCACHE_DCACHE_RMMONR_DEF
    \
    \ @brief DCACHE read-miss monitor register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DCACHE_RMISSMON                \ [0x00 : 16] cache read-miss monitor counter
  [then]


  [ifdef] DCACHE_DCACHE_WHMONR_DEF
    \
    \ @brief DCACHE write-hit monitor register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DCACHE_WHITMON                 \ [0x00 : 32] cache write-hit monitor counter
  [then]


  [ifdef] DCACHE_DCACHE_WMMONR_DEF
    \
    \ @brief DCACHE write-miss monitor register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DCACHE_WMISSMON                \ [0x00 : 16] cache write-miss monitor counter
  [then]


  [ifdef] DCACHE_DCACHE_CMDRSADDRR_DEF
    \
    \ @brief DCACHE command range start address register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $04 constant DCACHE_CMDSTARTADDR            \ [0x04 : 28] start address of range to which the cache maintenance command specified in DCACHE_CR.
  [then]


  [ifdef] DCACHE_DCACHE_CMDREADDRR_DEF
    \
    \ @brief DCACHE command range end address register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $04 constant DCACHE_CMDENDADDR              \ [0x04 : 28] end address of range to which the cache maintenance command specified in DCACHE_CR.
  [then]

  \
  \ @brief DCACHE register block
  \
  $00 constant DCACHE_DCACHE_CR         \ DCACHE control register
  $04 constant DCACHE_DCACHE_SR         \ DCACHE status register
  $08 constant DCACHE_DCACHE_IER        \ DCACHE interrupt enable register
  $0C constant DCACHE_DCACHE_FCR        \ DCACHE flag clear register
  $10 constant DCACHE_DCACHE_RHMONR     \ DCACHE read-hit monitor register
  $14 constant DCACHE_DCACHE_RMMONR     \ DCACHE read-miss monitor register
  $20 constant DCACHE_DCACHE_WHMONR     \ DCACHE write-hit monitor register
  $24 constant DCACHE_DCACHE_WMMONR     \ DCACHE write-miss monitor register
  $28 constant DCACHE_DCACHE_CMDRSADDRR \ DCACHE command range start address register
  $2C constant DCACHE_DCACHE_CMDREADDRR \ DCACHE command range end address register

: DCACHE_DEF ; [then]
