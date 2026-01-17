\
\ @file dcache1.fs
\ @brief DCACHE1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DCACHE1_DEF

  [ifdef] DCACHE1_DCACHE_CR_DEF
    \
    \ @brief DCACHE control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DCACHE1_EN                     \ [0x00] EN
    $01 constant DCACHE1_CACHEINV               \ [0x01] CACHEINV
    $08 constant DCACHE1_CACHECMD               \ [0x08 : 3] CACHECMD
    $0b constant DCACHE1_STARTCMD               \ [0x0b] STARTCMD
    $10 constant DCACHE1_RHITMEN                \ [0x10] RHITMEN
    $11 constant DCACHE1_RMISSMEN               \ [0x11] RMISSMEN
    $12 constant DCACHE1_RHITMRST               \ [0x12] RHITMRST
    $13 constant DCACHE1_RMISSMRST              \ [0x13] RMISSMRST
    $14 constant DCACHE1_WHITMEN                \ [0x14] WHITMEN
    $15 constant DCACHE1_WMISSMEN               \ [0x15] WMISSMEN
    $16 constant DCACHE1_WHITMRST               \ [0x16] WHITMRST
    $17 constant DCACHE1_WMISSMRST              \ [0x17] WMISSMRST
    $1f constant DCACHE1_HBURST                 \ [0x1f] HBURST
  [then]


  [ifdef] DCACHE1_DCACHE_SR_DEF
    \
    \ @brief DCACHE status register
    \ Address offset: 0x04
    \ Reset value: 0x00000001
    \
    $00 constant DCACHE1_BUSYF                  \ [0x00] BUSYF
    $01 constant DCACHE1_BSYENDF                \ [0x01] BSYENDF
    $02 constant DCACHE1_ERRF                   \ [0x02] ERRF
    $03 constant DCACHE1_BUSYCMDF               \ [0x03] BUSYCMDF
    $04 constant DCACHE1_CMDENDF                \ [0x04] CMDENDF
  [then]


  [ifdef] DCACHE1_DCACHE_IER_DEF
    \
    \ @brief DCACHE interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $01 constant DCACHE1_BSYENDIE               \ [0x01] BSYENDIE
    $02 constant DCACHE1_ERRIE                  \ [0x02] ERRIE
    $04 constant DCACHE1_CMDENDIE               \ [0x04] CMDENDIE
  [then]


  [ifdef] DCACHE1_DCACHE_FCR_DEF
    \
    \ @brief DCACHE flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant DCACHE1_CBSYENDF               \ [0x01] CBSYENDF
    $02 constant DCACHE1_CERRF                  \ [0x02] CERRF
    $04 constant DCACHE1_CCMDENDF               \ [0x04] CCMDENDF
  [then]


  [ifdef] DCACHE1_DCACHE_RHMONR_DEF
    \
    \ @brief DCACHE read-hit monitor register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DCACHE1_RHITMON                \ [0x00 : 32] RHITMON
  [then]


  [ifdef] DCACHE1_DCACHE_RMMONR_DEF
    \
    \ @brief DCACHE read-miss monitor register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DCACHE1_MRISSMON               \ [0x00 : 16] RMISSMON
  [then]


  [ifdef] DCACHE1_DCACHE_WHMONR_DEF
    \
    \ @brief write-hit monitor register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DCACHE1_WHITMON                \ [0x00 : 32] WHITMON
  [then]


  [ifdef] DCACHE1_DCACHE_WMMONR_DEF
    \
    \ @brief write-miss monitor register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DCACHE1_WMISSMON               \ [0x00 : 16] WMISSMON
  [then]


  [ifdef] DCACHE1_DCACHE_CMDRSADDRR_DEF
    \
    \ @brief command range start address register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $04 constant DCACHE1_CMDSTARTADDR           \ [0x04 : 28] CMDSTARTADDR
  [then]


  [ifdef] DCACHE1_DCACHE_CMDREADDRR_DEF
    \
    \ @brief command range start address register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $04 constant DCACHE1_CMDENDADDR             \ [0x04 : 28] CMDENDADDR
  [then]

  \
  \ @brief DCACHE1
  \
  $00 constant DCACHE1_DCACHE_CR        \ DCACHE control register
  $04 constant DCACHE1_DCACHE_SR        \ DCACHE status register
  $08 constant DCACHE1_DCACHE_IER       \ DCACHE interrupt enable register
  $0C constant DCACHE1_DCACHE_FCR       \ DCACHE flag clear register
  $10 constant DCACHE1_DCACHE_RHMONR    \ DCACHE read-hit monitor register
  $14 constant DCACHE1_DCACHE_RMMONR    \ DCACHE read-miss monitor register
  $20 constant DCACHE1_DCACHE_WHMONR    \ write-hit monitor register
  $24 constant DCACHE1_DCACHE_WMMONR    \ write-miss monitor register
  $28 constant DCACHE1_DCACHE_CMDRSADDRR    \ command range start address register
  $2C constant DCACHE1_DCACHE_CMDREADDRR    \ command range start address register

: DCACHE1_DEF ; [then]
