\
\ @file cacheaxi.fs
\ @brief AXI cache
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CACHEAXI_DEF

  [ifdef] CACHEAXI_CACHEAXI_CR1_DEF
    \
    \ @brief CACHEAXI control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant CACHEAXI_EN                    \ [0x00] enable
    $01 constant CACHEAXI_CACHEINV              \ [0x01] full cache invalidation
    $10 constant CACHEAXI_RHITMEN               \ [0x10] read-hit monitor enable
    $11 constant CACHEAXI_RMISSMEN              \ [0x11] read-miss monitor enable
    $12 constant CACHEAXI_RHITMRST              \ [0x12] read-hit monitor reset
    $13 constant CACHEAXI_RMISSMRST             \ [0x13] read-miss monitor reset
    $14 constant CACHEAXI_WHITMEN               \ [0x14] write-hit monitor enable
    $15 constant CACHEAXI_WMISSMEN              \ [0x15] write-miss monitor enable
    $16 constant CACHEAXI_WHITMRST              \ [0x16] write-hit monitor reset
    $17 constant CACHEAXI_WMISSMRST             \ [0x17] write-miss monitor reset
    $18 constant CACHEAXI_RAMMEN                \ [0x18] read-allocate miss monitor enable
    $19 constant CACHEAXI_WAMMEN                \ [0x19] write-allocate miss monitor enable
    $1a constant CACHEAXI_RAMMRST               \ [0x1a] read-allocate miss monitor reset
    $1b constant CACHEAXI_WAMMRST               \ [0x1b] write-allocate miss monitor reset
    $1c constant CACHEAXI_WTMEN                 \ [0x1c] write-through monitor enable
    $1d constant CACHEAXI_EVIMEN                \ [0x1d] eviction monitor enable
    $1e constant CACHEAXI_WTMRST                \ [0x1e] write-through monitor reset
    $1f constant CACHEAXI_EVIMRST               \ [0x1f] eviction monitor reset
  [then]


  [ifdef] CACHEAXI_CACHEAXI_SR_DEF
    \
    \ @brief CACHEAXI status register
    \ Address offset: 0x04
    \ Reset value: 0x00000001
    \
    $00 constant CACHEAXI_BUSYF                 \ [0x00] full invalidate busy flag
    $01 constant CACHEAXI_BSYENDF               \ [0x01] full invalidate busy end flag
    $02 constant CACHEAXI_ERRF                  \ [0x02] cache error flag
    $03 constant CACHEAXI_BUSYCMDF              \ [0x03] command busy flag
    $04 constant CACHEAXI_CMDENDF               \ [0x04] command end flag
  [then]


  [ifdef] CACHEAXI_CACHEAXI_IER_DEF
    \
    \ @brief CACHEAXI interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $01 constant CACHEAXI_BSYENDIE              \ [0x01] interrupt enable on busy end
    $02 constant CACHEAXI_ERRIE                 \ [0x02] interrupt enable on cache error
    $04 constant CACHEAXI_CMDENDIE              \ [0x04] interrupt enable on command end
  [then]


  [ifdef] CACHEAXI_CACHEAXI_FCR_DEF
    \
    \ @brief CACHEAXI flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant CACHEAXI_CBSYENDF              \ [0x01] clear full invalidate busy end flag
    $02 constant CACHEAXI_CERRF                 \ [0x02] clear cache error flag
    $04 constant CACHEAXI_CCMDENDF              \ [0x04] clear command end flag
  [then]


  [ifdef] CACHEAXI_CACHEAXI_RHMONR_DEF
    \
    \ @brief CACHEAXI read-hit monitor register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CACHEAXI_RHITMON               \ [0x00 : 32] cache read-hit monitor counter
  [then]


  [ifdef] CACHEAXI_CACHEAXI_RMMONR_DEF
    \
    \ @brief CACHEAXI read-miss monitor register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CACHEAXI_RMISSMON              \ [0x00 : 32] cache read-miss monitor counter
  [then]


  [ifdef] CACHEAXI_CACHEAXI_RAMMONR_DEF
    \
    \ @brief CACHEAXI read-allocate miss monitor register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant CACHEAXI_RAMMON                \ [0x00 : 32] cache read-allocate miss monitor counter
  [then]


  [ifdef] CACHEAXI_CACHEAXI_EVIMONR_DEF
    \
    \ @brief CACHEAXI eviction monitor register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant CACHEAXI_EVIMON                \ [0x00 : 32] cache eviction monitor counter
  [then]


  [ifdef] CACHEAXI_CACHEAXI_WHMONR_DEF
    \
    \ @brief CACHEAXI write-hit monitor register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant CACHEAXI_WHITMON               \ [0x00 : 32] cache write-hit monitor counter
  [then]


  [ifdef] CACHEAXI_CACHEAXI_WMMONR_DEF
    \
    \ @brief CACHEAXI write-miss monitor register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant CACHEAXI_WMISSMON              \ [0x00 : 32] cache write-miss monitor counter
  [then]


  [ifdef] CACHEAXI_CACHEAXI_WAMMONR_DEF
    \
    \ @brief CACHEAXI write-allocate miss monitor register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant CACHEAXI_WAMMON                \ [0x00 : 32] cache write-allocate miss monitor counter
  [then]


  [ifdef] CACHEAXI_CACHEAXI_WTMONR_DEF
    \
    \ @brief CACHEAXI write-through monitor register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant CACHEAXI_WTMON                 \ [0x00 : 32] cache write-through monitor counter
  [then]


  [ifdef] CACHEAXI_CACHEAXI_CR2_DEF
    \
    \ @brief CACHEAXI control register 2
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant CACHEAXI_STARTCMD              \ [0x00] starts maintenance range command (maintenance operation defined in CACHECMD).
    $01 constant CACHEAXI_CACHECMD              \ [0x01 : 2] cache command maintenance operation (clean or clean-and-invalidate an address range)
  [then]


  [ifdef] CACHEAXI_CACHEAXI_CMDRSADDRR_DEF
    \
    \ @brief CACHEAXI command range start address register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $06 constant CACHEAXI_CMDSTARTADDR          \ [0x06 : 26] start address of range to which the cache maintenance command specified in CACHEAXI_CR2.CACHECMD field applies
  [then]


  [ifdef] CACHEAXI_CACHEAXI_CMDREADDRR_DEF
    \
    \ @brief CACHEAXI command range end address register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $06 constant CACHEAXI_CMDENDADDR            \ [0x06 : 26] end address of range to which the cache maintenance command specified in CACHEAXI_CR2.CACHECMD field applies
  [then]

  \
  \ @brief AXI cache
  \
  $00 constant CACHEAXI_CACHEAXI_CR1    \ CACHEAXI control register 1
  $04 constant CACHEAXI_CACHEAXI_SR     \ CACHEAXI status register
  $08 constant CACHEAXI_CACHEAXI_IER    \ CACHEAXI interrupt enable register
  $0C constant CACHEAXI_CACHEAXI_FCR    \ CACHEAXI flag clear register
  $10 constant CACHEAXI_CACHEAXI_RHMONR \ CACHEAXI read-hit monitor register
  $14 constant CACHEAXI_CACHEAXI_RMMONR \ CACHEAXI read-miss monitor register
  $18 constant CACHEAXI_CACHEAXI_RAMMONR    \ CACHEAXI read-allocate miss monitor register
  $1C constant CACHEAXI_CACHEAXI_EVIMONR    \ CACHEAXI eviction monitor register
  $20 constant CACHEAXI_CACHEAXI_WHMONR \ CACHEAXI write-hit monitor register
  $24 constant CACHEAXI_CACHEAXI_WMMONR \ CACHEAXI write-miss monitor register
  $28 constant CACHEAXI_CACHEAXI_WAMMONR    \ CACHEAXI write-allocate miss monitor register
  $2C constant CACHEAXI_CACHEAXI_WTMONR \ CACHEAXI write-through monitor register
  $100 constant CACHEAXI_CACHEAXI_CR2   \ CACHEAXI control register 2
  $104 constant CACHEAXI_CACHEAXI_CMDRSADDRR    \ CACHEAXI command range start address register
  $108 constant CACHEAXI_CACHEAXI_CMDREADDRR    \ CACHEAXI command range end address register

: CACHEAXI_DEF ; [then]
